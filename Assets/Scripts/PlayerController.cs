using Inventory.ShipItems;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Input;


public class Vector2Event : UnityEvent<Vector2> {
    
}

public class PlayerController : MonoBehaviour, GameControls.IShipActions {

    public static PlayerController Instance { get; private set; }

    public static readonly Vector2Event OnPositionChange = new Vector2Event();

    // TODO make readonly fields with CustomEditor
    [Range(0, 360)] [SerializeField] private float rotationSpeed;
    [Range(0, 10)] [SerializeField] private float movementSpeed;
    [Range(0, 1)] [SerializeField] private float movementDamping;
    [Range(0, 50)] [SerializeField] private float maximumSpeed;
    [Range(0, 1000)] [SerializeField] private float brakingForce;

    [SerializeField] private ShipWeapon shipWeapon1;
    [SerializeField] private ShipWeapon shipWeapon2;
    [SerializeField] private ShipRearEngine shipRearEngine;
    [SerializeField] private ShipSideEngine shipSideEngine;
    [SerializeField] private ShipGenerator shipGenerator;
    [SerializeField] private ShipShield shipShield;

    private Transform _t;
    private ShipController _shipController;
    private GameControls _controls;

    private Weapon[] _weapons;
    private static IScrollable _scrollable;


    private void Awake() {
        _t = transform;
        _controls = new GameControls();
        _controls.Ship.SetCallbacks(this);
        _shipController = new ShipController(new ShipParameters(2, 1, 1, 1, 1), _t);
        FillShip(_shipController);
        SetAttributes();
        Instance = this;
    }

    private void SetAttributes() {
        var attr = _shipController.Attributes;
        movementSpeed = attr.MovementSpeed;
        rotationSpeed = attr.RotationSpeed;
        movementDamping = attr.MovementDamping;
        maximumSpeed = attr.MaximumSpeed;
        brakingForce = attr.BrakingForce;
    }

    private void FillShip(ShipController shipController) {
        shipController.PlaceItem(ShipItemType.Weapon, shipWeapon1, 0);
        shipController.PlaceItem(ShipItemType.Weapon, shipWeapon2, 1);
        shipController.PlaceItem(ShipItemType.RearEngine, shipRearEngine, 0);
        shipController.PlaceItem(ShipItemType.SideEngine, shipSideEngine, 0);
        shipController.PlaceItem(ShipItemType.Shield, shipShield, 0);
        shipController.PlaceItem(ShipItemType.Generator, shipGenerator, 0);
    }

    private void Start() {
        _scrollable = CameraController.Instance;
        _weapons = GetComponentsInChildren<Weapon>();
    }

    private void Update() {
        if (Time.timeScale < 0.1f) {
            _controls.Ship.Disable();
            return;
        }

        _controls.Ship.Enable();

        _shipController.RotateAt(GameInput.MousePosition);
        _shipController.MoveToDirection();

        LegacyScroll();
        OnPositionChange.Invoke(transform.position);
    }

    /// <summary>
    /// TODO remove when Unity's UnityEngine.Experimental.Input.InputSystem.GetDevice<Mouse>().scroll is fixed
    /// </summary>
    private static void LegacyScroll() {
        var scroll = Input.GetAxis("Mouse ScrollWheel");

        if (Mathf.Abs(scroll) > float.Epsilon)
            _scrollable.Scroll(Vector2.up * scroll);
    }

    public void OnMove(InputAction.CallbackContext context) {
        _shipController.Direction = context.ReadValue<Vector2>();
    }

    public void OnShoot(InputAction.CallbackContext context) {
        if (_weapons == null || _weapons.Length <= 0) return;
        foreach (var weapon in _weapons) {
            weapon.Fire(_shipController.Velocity);
        }
    }

    public void OnZoom(InputAction.CallbackContext context) {
        var scroll = context.ReadValue<float>();
        Debug.Log($"Zoom: {scroll}");
        _scrollable.Scroll(scroll * Time.deltaTime * Vector2.up);
    }

    public void OnScroll(InputAction.CallbackContext context) {
        //Debug.Log($"Scroll: {context.ReadValue<Vector2>()}"); BUG scroll input is broken
    }

    public void OnBrake(InputAction.CallbackContext context) {
        _shipController.IsBraking = true;
        _shipController.Direction = Vector3.zero;
    }

    public void OnEnable() {
        _controls.Ship.Enable();
    }

    public void OnDisable() {
        _controls.Ship.Disable();
    }
}