namespace UnityEngine;

public sealed class AudioSource : AudioBehaviour
{

	public bool bypassEffects
	{
		 set { } //Length: 53
	}

	public AudioClip clip
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public bool isPlaying
	{
		 get { } //Length: 49
	}

	public bool loop
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public float maxDistance
	{
		 set { } //Length: 52
	}

	public float minDistance
	{
		 set { } //Length: 52
	}

	public float pitch
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public bool playOnAwake
	{
		 set { } //Length: 53
	}

	public int priority
	{
		 set { } //Length: 53
	}

	public AudioRolloffMode rolloffMode
	{
		 set { } //Length: 53
	}

	public float spatialBlend
	{
		 set { } //Length: 52
	}

	public float time
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public int timeSamples
	{
		 get { } //Length: 9
		 set { } //Length: 53
	}

	public float volume
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public AudioClip get_clip() { }

	public bool get_isPlaying() { }

	public bool get_loop() { }

	public float get_pitch() { }

	public float get_time() { }

	public int get_timeSamples() { }

	public float get_volume() { }

	private static float GetPitch(AudioSource source) { }

	public void Pause() { }

	public void Play() { }

	private static void PlayHelper(AudioSource source, ulong delay) { }

	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	public void set_bypassEffects(bool value) { }

	public void set_clip(AudioClip value) { }

	public void set_loop(bool value) { }

	public void set_maxDistance(float value) { }

	public void set_minDistance(float value) { }

	public void set_pitch(float value) { }

	public void set_playOnAwake(bool value) { }

	public void set_priority(int value) { }

	public void set_rolloffMode(AudioRolloffMode value) { }

	public void set_spatialBlend(float value) { }

	public void set_time(float value) { }

	public void set_timeSamples(int value) { }

	public void set_volume(float value) { }

	private static void SetPitch(AudioSource source, float pitch) { }

	public void Stop() { }

	private void Stop(bool stopOneShots) { }

	public void UnPause() { }

}

