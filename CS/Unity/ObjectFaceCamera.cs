using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFaceCamera : MonoBehaviour
{
	private Transform target;
	[SerializeField] private Vector3 rotationOffset;


	void Start()
	{
		target = Camera.main.transform;
	}

	void LateUpdate()
	{
		transform.LookAt(target.position); //LookAt
		
		transform.rotation *= Quaternion.Euler(rotationOffset); //Offset
	}
}
