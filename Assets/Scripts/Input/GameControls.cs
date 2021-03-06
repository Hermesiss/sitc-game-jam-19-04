// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/GameControlsAsset.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.Experimental.Input.Utilities;

public class GameControls : IInputActionCollection
{
    private InputActionAsset asset;
    public GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControlsAsset"",
    ""maps"": [
        {
            ""name"": ""Ship"",
            ""id"": ""a1461f3e-bed8-4f3c-a8d7-cf6e4ac45547"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""id"": ""7aa8ffc0-bcb4-4024-bb30-666c6ee10727"",
                    ""expectedControlLayout"": ""Vector2"",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Shoot"",
                    ""id"": ""a683ae53-c4ed-4ba2-ba9d-1ad7d5c7a736"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Zoom"",
                    ""id"": ""2de26e43-4785-4f8d-bb9d-d4d231fdc340"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""bindings"": []
                },
                {
                    ""name"": ""Scroll"",
                    ""id"": ""e61d22b5-52c1-4d30-9d6b-d714f6e766cf"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": true,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Brake"",
                    ""id"": ""51c2ec59-a524-423d-a428-9fa28e25020f"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": true,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3acb0364-4d5f-4b7f-8ca0-dbfbdb762362"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""up"",
                    ""id"": ""285ee4e3-48b5-4300-b6f7-48007cc5ef82"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b4a61d62-3670-4d2a-83db-17ae40f6c1c3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""left"",
                    ""id"": ""87835624-bb52-4b45-a922-3b9380276773"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b1f4f2a8-02e4-4640-9e8a-a66e8029fb14"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""04b8fda0-9680-46a7-95f3-d2d5bb86f13b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""315b4e1f-5c7b-4fda-bc56-cc9bc125743b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1bebef43-55c2-4acb-96e0-9774e3fdc05a"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6741455e-2809-4311-8553-0beb2a8b2e5f"",
                    ""path"": ""<Keyboard>/numpadMinus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d9ef3643-5fd5-42dd-8e94-964bd72ceb7a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""81433226-b6d9-4be6-93ae-5e821fb3f192"",
                    ""path"": ""<Keyboard>/equals"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""79c45db1-37a8-48e1-ad8b-5a14805d63e1"",
                    ""path"": ""<Keyboard>/minus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""d383991f-ca1b-4ac3-8fcd-cb5dd8bc282f"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""114c0133-0732-4097-ac14-c31c36f3712d"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""Universal"",
            ""id"": ""f069fedf-f57a-4b47-b360-fa674b9af49b"",
            ""actions"": [
                {
                    ""name"": ""Menu"",
                    ""id"": ""ba10cda1-ef40-47af-9bc2-40e9d04cb746"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1e65d0b8-564a-4292-82c3-d565e7bca949"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""basedOn"": """",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Ship
        m_Ship = asset.GetActionMap("Ship");
        m_Ship_Move = m_Ship.GetAction("Move");
        m_Ship_Shoot = m_Ship.GetAction("Shoot");
        m_Ship_Zoom = m_Ship.GetAction("Zoom");
        m_Ship_Scroll = m_Ship.GetAction("Scroll");
        m_Ship_Brake = m_Ship.GetAction("Brake");
        // Universal
        m_Universal = asset.GetActionMap("Universal");
        m_Universal_Menu = m_Universal.GetAction("Menu");
    }
    ~GameControls()
    {
        UnityEngine.Object.Destroy(asset);
    }
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }
    public ReadOnlyArray<InputControlScheme> controlSchemes
    {
        get => asset.controlSchemes;
    }
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public void Enable()
    {
        asset.Enable();
    }
    public void Disable()
    {
        asset.Disable();
    }
    // Ship
    private InputActionMap m_Ship;
    private IShipActions m_ShipActionsCallbackInterface;
    private InputAction m_Ship_Move;
    private InputAction m_Ship_Shoot;
    private InputAction m_Ship_Zoom;
    private InputAction m_Ship_Scroll;
    private InputAction m_Ship_Brake;
    public struct ShipActions
    {
        private GameControls m_Wrapper;
        public ShipActions(GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move { get { return m_Wrapper.m_Ship_Move; } }
        public InputAction @Shoot { get { return m_Wrapper.m_Ship_Shoot; } }
        public InputAction @Zoom { get { return m_Wrapper.m_Ship_Zoom; } }
        public InputAction @Scroll { get { return m_Wrapper.m_Ship_Scroll; } }
        public InputAction @Brake { get { return m_Wrapper.m_Ship_Brake; } }
        public InputActionMap Get() { return m_Wrapper.m_Ship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(ShipActions set) { return set.Get(); }
        public void SetCallbacks(IShipActions instance)
        {
            if (m_Wrapper.m_ShipActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnMove;
                Move.cancelled -= m_Wrapper.m_ShipActionsCallbackInterface.OnMove;
                Shoot.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnShoot;
                Shoot.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnShoot;
                Shoot.cancelled -= m_Wrapper.m_ShipActionsCallbackInterface.OnShoot;
                Zoom.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoom;
                Zoom.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoom;
                Zoom.cancelled -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoom;
                Scroll.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnScroll;
                Scroll.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnScroll;
                Scroll.cancelled -= m_Wrapper.m_ShipActionsCallbackInterface.OnScroll;
                Brake.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnBrake;
                Brake.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnBrake;
                Brake.cancelled -= m_Wrapper.m_ShipActionsCallbackInterface.OnBrake;
            }
            m_Wrapper.m_ShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.cancelled += instance.OnMove;
                Shoot.started += instance.OnShoot;
                Shoot.performed += instance.OnShoot;
                Shoot.cancelled += instance.OnShoot;
                Zoom.started += instance.OnZoom;
                Zoom.performed += instance.OnZoom;
                Zoom.cancelled += instance.OnZoom;
                Scroll.started += instance.OnScroll;
                Scroll.performed += instance.OnScroll;
                Scroll.cancelled += instance.OnScroll;
                Brake.started += instance.OnBrake;
                Brake.performed += instance.OnBrake;
                Brake.cancelled += instance.OnBrake;
            }
        }
    }
    public ShipActions @Ship
    {
        get
        {
            return new ShipActions(this);
        }
    }
    // Universal
    private InputActionMap m_Universal;
    private IUniversalActions m_UniversalActionsCallbackInterface;
    private InputAction m_Universal_Menu;
    public struct UniversalActions
    {
        private GameControls m_Wrapper;
        public UniversalActions(GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Menu { get { return m_Wrapper.m_Universal_Menu; } }
        public InputActionMap Get() { return m_Wrapper.m_Universal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(UniversalActions set) { return set.Get(); }
        public void SetCallbacks(IUniversalActions instance)
        {
            if (m_Wrapper.m_UniversalActionsCallbackInterface != null)
            {
                Menu.started -= m_Wrapper.m_UniversalActionsCallbackInterface.OnMenu;
                Menu.performed -= m_Wrapper.m_UniversalActionsCallbackInterface.OnMenu;
                Menu.cancelled -= m_Wrapper.m_UniversalActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_UniversalActionsCallbackInterface = instance;
            if (instance != null)
            {
                Menu.started += instance.OnMenu;
                Menu.performed += instance.OnMenu;
                Menu.cancelled += instance.OnMenu;
            }
        }
    }
    public UniversalActions @Universal
    {
        get
        {
            return new UniversalActions(this);
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.GetControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IShipActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
    }
    public interface IUniversalActions
    {
        void OnMenu(InputAction.CallbackContext context);
    }
}
