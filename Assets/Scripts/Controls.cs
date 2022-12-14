//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""FreeMoveCamera"",
            ""id"": ""ecda11ce-3901-47e4-8959-d3b8be8f9571"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""3b33468b-3794-48bd-83f8-25e1b947bf1a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c82d9c9d-ee18-4d3b-ac4e-ddcf315c0b51"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""CreatePortal"",
                    ""type"": ""Button"",
                    ""id"": ""25b60544-f590-4a90-8478-558a3dd5d900"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleMenu"",
                    ""type"": ""Button"",
                    ""id"": ""af5a6850-a217-432b-a5cb-f17d4c08efcd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActivatePower"",
                    ""type"": ""Button"",
                    ""id"": ""de0cc1d0-ccd0-4d91-98fd-467496f4f086"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PowerPush"",
                    ""type"": ""Button"",
                    ""id"": ""8c4e94b6-6739-425f-97be-aa7a00e361cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PowerPull"",
                    ""type"": ""Button"",
                    ""id"": ""c79636e6-4036-46c2-8f01-72d9a4f55bf8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PowerStay"",
                    ""type"": ""Button"",
                    ""id"": ""ab6894cc-24e7-49a1-9820-6ac176199e6c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TMP"",
                    ""type"": ""Button"",
                    ""id"": ""4d333a58-ec04-416a-bcbc-619a8e1d8482"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""af2b5951-0155-4ae5-82c8-3ab6217dfd6a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ad086744-fe00-46ba-9d11-23bd2455c77e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""13581097-bae8-4879-bd1b-d852f27b424d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ffe93788-ae48-402e-913e-47f02aead2b9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""356640b6-6773-4eb4-83b3-bb7f86e5da18"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a7c0c6d4-4a00-447d-bf48-300632d6a149"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fe42a74c-663e-4050-9f17-281e95b79592"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CreatePortal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27aa2262-ef77-4332-af49-a745bab1740e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15e0b065-bfb5-488e-8454-065a1af0f843"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivatePower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10e95e3c-8094-4140-89ba-fc5a600f7922"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerPush"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec88f55a-40b9-477a-a007-998f3d7fe76b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerPull"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3938caf3-91c9-4a1f-9d0b-84a9812cac20"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerStay"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb922a26-ad7f-4430-9ad8-acf859789c6b"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TMP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // FreeMoveCamera
        m_FreeMoveCamera = asset.FindActionMap("FreeMoveCamera", throwIfNotFound: true);
        m_FreeMoveCamera_Look = m_FreeMoveCamera.FindAction("Look", throwIfNotFound: true);
        m_FreeMoveCamera_Move = m_FreeMoveCamera.FindAction("Move", throwIfNotFound: true);
        m_FreeMoveCamera_CreatePortal = m_FreeMoveCamera.FindAction("CreatePortal", throwIfNotFound: true);
        m_FreeMoveCamera_ToggleMenu = m_FreeMoveCamera.FindAction("ToggleMenu", throwIfNotFound: true);
        m_FreeMoveCamera_ActivatePower = m_FreeMoveCamera.FindAction("ActivatePower", throwIfNotFound: true);
        m_FreeMoveCamera_PowerPush = m_FreeMoveCamera.FindAction("PowerPush", throwIfNotFound: true);
        m_FreeMoveCamera_PowerPull = m_FreeMoveCamera.FindAction("PowerPull", throwIfNotFound: true);
        m_FreeMoveCamera_PowerStay = m_FreeMoveCamera.FindAction("PowerStay", throwIfNotFound: true);
        m_FreeMoveCamera_TMP = m_FreeMoveCamera.FindAction("TMP", throwIfNotFound: true);
    }

    public void Dispose()
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

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // FreeMoveCamera
    private readonly InputActionMap m_FreeMoveCamera;
    private IFreeMoveCameraActions m_FreeMoveCameraActionsCallbackInterface;
    private readonly InputAction m_FreeMoveCamera_Look;
    private readonly InputAction m_FreeMoveCamera_Move;
    private readonly InputAction m_FreeMoveCamera_CreatePortal;
    private readonly InputAction m_FreeMoveCamera_ToggleMenu;
    private readonly InputAction m_FreeMoveCamera_ActivatePower;
    private readonly InputAction m_FreeMoveCamera_PowerPush;
    private readonly InputAction m_FreeMoveCamera_PowerPull;
    private readonly InputAction m_FreeMoveCamera_PowerStay;
    private readonly InputAction m_FreeMoveCamera_TMP;
    public struct FreeMoveCameraActions
    {
        private @Controls m_Wrapper;
        public FreeMoveCameraActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_FreeMoveCamera_Look;
        public InputAction @Move => m_Wrapper.m_FreeMoveCamera_Move;
        public InputAction @CreatePortal => m_Wrapper.m_FreeMoveCamera_CreatePortal;
        public InputAction @ToggleMenu => m_Wrapper.m_FreeMoveCamera_ToggleMenu;
        public InputAction @ActivatePower => m_Wrapper.m_FreeMoveCamera_ActivatePower;
        public InputAction @PowerPush => m_Wrapper.m_FreeMoveCamera_PowerPush;
        public InputAction @PowerPull => m_Wrapper.m_FreeMoveCamera_PowerPull;
        public InputAction @PowerStay => m_Wrapper.m_FreeMoveCamera_PowerStay;
        public InputAction @TMP => m_Wrapper.m_FreeMoveCamera_TMP;
        public InputActionMap Get() { return m_Wrapper.m_FreeMoveCamera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FreeMoveCameraActions set) { return set.Get(); }
        public void SetCallbacks(IFreeMoveCameraActions instance)
        {
            if (m_Wrapper.m_FreeMoveCameraActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnLook;
                @Move.started -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnMove;
                @CreatePortal.started -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnCreatePortal;
                @CreatePortal.performed -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnCreatePortal;
                @CreatePortal.canceled -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnCreatePortal;
                @ToggleMenu.started -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnToggleMenu;
                @ToggleMenu.performed -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnToggleMenu;
                @ToggleMenu.canceled -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnToggleMenu;
                @ActivatePower.started -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnActivatePower;
                @ActivatePower.performed -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnActivatePower;
                @ActivatePower.canceled -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnActivatePower;
                @PowerPush.started -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnPowerPush;
                @PowerPush.performed -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnPowerPush;
                @PowerPush.canceled -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnPowerPush;
                @PowerPull.started -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnPowerPull;
                @PowerPull.performed -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnPowerPull;
                @PowerPull.canceled -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnPowerPull;
                @PowerStay.started -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnPowerStay;
                @PowerStay.performed -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnPowerStay;
                @PowerStay.canceled -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnPowerStay;
                @TMP.started -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnTMP;
                @TMP.performed -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnTMP;
                @TMP.canceled -= m_Wrapper.m_FreeMoveCameraActionsCallbackInterface.OnTMP;
            }
            m_Wrapper.m_FreeMoveCameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @CreatePortal.started += instance.OnCreatePortal;
                @CreatePortal.performed += instance.OnCreatePortal;
                @CreatePortal.canceled += instance.OnCreatePortal;
                @ToggleMenu.started += instance.OnToggleMenu;
                @ToggleMenu.performed += instance.OnToggleMenu;
                @ToggleMenu.canceled += instance.OnToggleMenu;
                @ActivatePower.started += instance.OnActivatePower;
                @ActivatePower.performed += instance.OnActivatePower;
                @ActivatePower.canceled += instance.OnActivatePower;
                @PowerPush.started += instance.OnPowerPush;
                @PowerPush.performed += instance.OnPowerPush;
                @PowerPush.canceled += instance.OnPowerPush;
                @PowerPull.started += instance.OnPowerPull;
                @PowerPull.performed += instance.OnPowerPull;
                @PowerPull.canceled += instance.OnPowerPull;
                @PowerStay.started += instance.OnPowerStay;
                @PowerStay.performed += instance.OnPowerStay;
                @PowerStay.canceled += instance.OnPowerStay;
                @TMP.started += instance.OnTMP;
                @TMP.performed += instance.OnTMP;
                @TMP.canceled += instance.OnTMP;
            }
        }
    }
    public FreeMoveCameraActions @FreeMoveCamera => new FreeMoveCameraActions(this);
    public interface IFreeMoveCameraActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnCreatePortal(InputAction.CallbackContext context);
        void OnToggleMenu(InputAction.CallbackContext context);
        void OnActivatePower(InputAction.CallbackContext context);
        void OnPowerPush(InputAction.CallbackContext context);
        void OnPowerPull(InputAction.CallbackContext context);
        void OnPowerStay(InputAction.CallbackContext context);
        void OnTMP(InputAction.CallbackContext context);
    }
}
