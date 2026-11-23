using System;
using UnityEngine;

[Serializable]
public class AudioClipInfo
{
	public AudioClip Clip;

	public float minPitch = 0.8f;

	public float maxPitch;

	public float minVolume = 0.5f;

	public float maxVolume;

	public AudioRolloffMode Rollof = AudioRolloffMode.Linear;

	public override string ToString()
	{
		string name = Clip.name;
		return "[AudioClipInfo (Clip=" + name + ")]";
	}
}
