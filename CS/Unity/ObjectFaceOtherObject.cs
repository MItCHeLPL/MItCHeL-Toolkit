using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFaceOtherObject : MonoBehaviour
{
	[SerializeField] private Transform target;
	[SerializeField] private Vector3 rotationOffset;

	void Update()
    {
		FaceOtherObject(transform, target, rotationOffset);
	}

	public static void FaceOtherObject(Transform transform, Transform target, Vector3 offset)
	{
		transform.LookAt(target.position);
		transform.rotation *= Quaternion.Euler(offset);
	}
}
