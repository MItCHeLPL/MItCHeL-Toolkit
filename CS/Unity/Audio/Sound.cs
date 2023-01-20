using System;
using UnityEngine;

[Serializable]
public class Sound
{
	public string name;

	public AudioSource source;

	public AudioClip clip;

	public bool playOnAwake = false;

	public bool loop = false;

	public bool stopOnGamePause = false;
	public bool playOnGameResume = true;

	public bool useMusicVolume = false;

	[Range(0f, 2f)]
	public float volume = 1;
	[HideInInspector] public float defaultVolume = 1;

	[Range(0.1f, 3f)]
	public float pitch = 1;

	[Range(0f, 1f)]
	[Tooltip("2D-3D")]
	public float spatialBlend = 0;
}
