using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VirtualCameraController : MonoBehaviour
{
	public bool playerInputEnabled = true;

    public float sensitivityX = 1.0f;
    public float sensitivityY = 1.0f;


    private void OnEnable()
	{
        CinemachineCore.GetInputAxis = GetAxisCustom; //Assign custom input
    }

    //Apply sensitivity and disable input when needed
    public float GetAxisCustom(string axisName)
    {
        if (axisName == "Mouse X" && playerInputEnabled)
        {
            return UnityEngine.Input.GetAxis("Mouse X") * sensitivityX * Time.timeScale;
        }
        else if (axisName == "Mouse Y" && playerInputEnabled)
        {
            return UnityEngine.Input.GetAxis("Mouse Y") * sensitivityY * Time.timeScale;
        }
        else if (axisName == "Mouse X" && !playerInputEnabled)
        {
            return UnityEngine.Input.GetAxis("Mouse X") * 0;
        }
        else if (axisName == "Mouse Y" && !playerInputEnabled)
        {
            return UnityEngine.Input.GetAxis("Mouse Y") * 0;
        }
        return 0;
    }
}
