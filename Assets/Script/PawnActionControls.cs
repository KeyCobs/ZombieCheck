// GENERATED AUTOMATICALLY FROM 'Assets/Script/PawnControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PawnActionControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PawnActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PawnControls"",
    ""maps"": [
        {
            ""name"": ""Pawn"",
            ""id"": ""982f0dbe-a04c-4496-8016-419479129b17"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9dfffbdd-bf31-4670-b50a-4d8327ae0717"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fb8a671f-e2cc-4b51-8779-5b17b6c48420"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Bishop"",
            ""id"": ""573777db-cb05-4de8-9acd-9b4633ab9011"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""c77356e0-03d6-476c-830e-cef717a00e43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7d220088-8eaa-44b2-ac17-9ce89b37405c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Pawn
        m_Pawn = asset.FindActionMap("Pawn", throwIfNotFound: true);
        m_Pawn_Move = m_Pawn.FindAction("Move", throwIfNotFound: true);
        // Bishop
        m_Bishop = asset.FindActionMap("Bishop", throwIfNotFound: true);
        m_Bishop_Newaction = m_Bishop.FindAction("New action", throwIfNotFound: true);
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

    // Pawn
    private readonly InputActionMap m_Pawn;
    private IPawnActions m_PawnActionsCallbackInterface;
    private readonly InputAction m_Pawn_Move;
    public struct PawnActions
    {
        private @PawnActionControls m_Wrapper;
        public PawnActions(@PawnActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Pawn_Move;
        public InputActionMap Get() { return m_Wrapper.m_Pawn; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PawnActions set) { return set.Get(); }
        public void SetCallbacks(IPawnActions instance)
        {
            if (m_Wrapper.m_PawnActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PawnActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PawnActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PawnActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PawnActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public PawnActions @Pawn => new PawnActions(this);

    // Bishop
    private readonly InputActionMap m_Bishop;
    private IBishopActions m_BishopActionsCallbackInterface;
    private readonly InputAction m_Bishop_Newaction;
    public struct BishopActions
    {
        private @PawnActionControls m_Wrapper;
        public BishopActions(@PawnActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Bishop_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Bishop; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BishopActions set) { return set.Get(); }
        public void SetCallbacks(IBishopActions instance)
        {
            if (m_Wrapper.m_BishopActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_BishopActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_BishopActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_BishopActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_BishopActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public BishopActions @Bishop => new BishopActions(this);
    public interface IPawnActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IBishopActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
