// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerCharacter/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""9cdf217e-39e7-4177-892d-53a497fc37fd"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""90fc144a-c579-41af-b639-b630f67d7448"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""a2652905-f388-4aa5-a086-1b69a5516552"",
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
                    ""id"": ""927af2a5-0f95-4b85-a7e4-b7632b6f33d9"",
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
                    ""id"": ""2ee936d8-3525-49b4-afaf-6e14427625b0"",
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
                    ""id"": ""ddfba18b-de0f-44aa-af71-e19b9623e1a7"",
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
                    ""id"": ""f377132d-9297-46a6-96c0-a8b3c80de83e"",
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
                    ""id"": ""0071c70d-e743-46b1-9b92-435fb7b62489"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d46bd35d-0ed7-412f-ac24-a2bca7dd3fdc"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Action"",
            ""id"": ""2f3d78c1-e4f5-4a4d-b421-987ec6cde4a9"",
            ""actions"": [
                {
                    ""name"": ""Slurp"",
                    ""type"": ""Button"",
                    ""id"": ""ea0cbc46-e1b3-45b5-bb44-4beebddf9f48"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""0a9fafbc-178f-48e9-8dc9-ddf59e8e4e5e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a63325ee-250f-41bf-a6a0-3cadb2b51e17"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slurp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""599322f1-9e18-4eb0-93a4-246a37de3448"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        // Action
        m_Action = asset.FindActionMap("Action", throwIfNotFound: true);
        m_Action_Slurp = m_Action.FindAction("Slurp", throwIfNotFound: true);
        m_Action_Aim = m_Action.FindAction("Aim", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Move;
    public struct MovementActions
    {
        private @PlayerInputs m_Wrapper;
        public MovementActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Action
    private readonly InputActionMap m_Action;
    private IActionActions m_ActionActionsCallbackInterface;
    private readonly InputAction m_Action_Slurp;
    private readonly InputAction m_Action_Aim;
    public struct ActionActions
    {
        private @PlayerInputs m_Wrapper;
        public ActionActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Slurp => m_Wrapper.m_Action_Slurp;
        public InputAction @Aim => m_Wrapper.m_Action_Aim;
        public InputActionMap Get() { return m_Wrapper.m_Action; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionActions set) { return set.Get(); }
        public void SetCallbacks(IActionActions instance)
        {
            if (m_Wrapper.m_ActionActionsCallbackInterface != null)
            {
                @Slurp.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnSlurp;
                @Slurp.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnSlurp;
                @Slurp.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnSlurp;
                @Aim.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_ActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Slurp.started += instance.OnSlurp;
                @Slurp.performed += instance.OnSlurp;
                @Slurp.canceled += instance.OnSlurp;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
            }
        }
    }
    public ActionActions @Action => new ActionActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IActionActions
    {
        void OnSlurp(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
}
