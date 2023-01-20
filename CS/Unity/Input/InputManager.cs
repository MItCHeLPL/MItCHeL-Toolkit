using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.InputSystem.LowLevel;

[DefaultExecutionOrder(-100)]
public class InputManager : MonoBehaviour
{
    [Header("States")]
    public InputDeviceType LastInputDevice = InputDeviceType.Unknown;

    [Header("Reference")]
    private InputActionAsset actionMapAsset;
    private PlayerInput playerInput;

    private IDisposable anyInputListener;


    public static InputManager Instance { get; private set; }

    private void Awake()
    {
        #region Singleton
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        #endregion


        playerInput = GetComponent<PlayerInput>();
		actionMapAsset = playerInput.actions;
    }

    void OnEnable()
    {
        anyInputListener = InputSystem.onEvent.Call(DetectLastInputDevice);
    }

    void OnDisable()
    {
        anyInputListener.Dispose();
    }


    public InputAction GetAction(ActionMapType actionMap, InputType actionType)
    {
        return actionMapAsset[$"{actionMap}/{actionType}"];
    }

    public void SwitchCurrentActionMap(ActionMapType actionMap)
    {
		foreach (InputAction action in playerInput.currentActionMap.actions)
		{
            action.Disable();
		}

		playerInput.SwitchCurrentActionMap($"{actionMap}");

        foreach(InputAction action in playerInput.currentActionMap.actions)
        {
            action.Enable();
		}
    }

    private void DetectLastInputDevice(InputEventPtr e)
    {
        try
        {
            InputDevice currentInputDevice = InputSystem.GetDeviceById(e.deviceId);

            if (currentInputDevice is Keyboard || currentInputDevice is Mouse)
            {
                LastInputDevice = InputDeviceType.MouseAndKeyboard;
            }
            else if(currentInputDevice is Gamepad)
            {
                LastInputDevice = InputDeviceType.Gamepad;
            }
            else if (currentInputDevice is Touchscreen)
            {
                LastInputDevice = InputDeviceType.Touchscreen;
            }
            else
            {
                LastInputDevice = InputDeviceType.Unknown;
            }
        }
        catch { }
    }
}
