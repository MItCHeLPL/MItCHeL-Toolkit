using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFaceOtherObject : MonoBehaviour
{
	[SerializeField] private Transform target;
	[SerializeField] private Vector3 rotationOffset;

	void Update()
    {
        transform.LookAt(target.position); //LookAt
		transform.rotation *= Quaternion.Euler(rotationOffset); //Offset
	}
}
