// GENERATED AUTOMATICALLY FROM 'Assets/Input/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Gyro"",
            ""id"": ""c04be97f-3329-4676-9e69-ae9c10b948f2"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""fdd0c4f0-d923-4808-bcfc-683af8c8b504"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": ""ScaleVector3(x=75,y=75,z=75)"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26a12a24-d4ef-4784-a30e-96589c8f3d52"",
                    ""path"": ""<Gyroscope>/angularVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gyro
        m_Gyro = asset.FindActionMap("Gyro", throwIfNotFound: true);
        m_Gyro_Rotation = m_Gyro.FindAction("Rotation", throwIfNotFound: true);
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

    // Gyro
    private readonly InputActionMap m_Gyro;
    private IGyroActions m_GyroActionsCallbackInterface;
    private readonly InputAction m_Gyro_Rotation;
    public struct GyroActions
    {
        private @Input m_Wrapper;
        public GyroActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_Gyro_Rotation;
        public InputActionMap Get() { return m_Wrapper.m_Gyro; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GyroActions set) { return set.Get(); }
        public void SetCallbacks(IGyroActions instance)
        {
            if (m_Wrapper.m_GyroActionsCallbackInterface != null)
            {
                @Rotation.started -= m_Wrapper.m_GyroActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_GyroActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_GyroActionsCallbackInterface.OnRotation;
            }
            m_Wrapper.m_GyroActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
            }
        }
    }
    public GyroActions @Gyro => new GyroActions(this);
    public interface IGyroActions
    {
        void OnRotation(InputAction.CallbackContext context);
    }
}