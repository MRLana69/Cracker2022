using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class Sound
{
	private sealed class _003Cplay_003Ed__19(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Sound _003C_003E4__this;

		public Vector3 position;

		public AudioRolloffMode rolloff;

		public float minVolume;

		public float maxVolume;

		public float minPitch;

		public float maxPitch;

		public bool willLoop;

		private bool _003ChasGameObject_003E5__2;

		private bool _003ChasAudioSource_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00b0: Expected F4, but got I
			//IL_00ab: Expected native int or pointer, but got VT
			//IL_00bf: Expected F4, but got VT
			//IL_00ba: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 16);
			Sound sound = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (sound.audioSource != null)
					{
						sound.audioSource.Stop();
					}
					if (~(sound.destroyAfterPlay ? 1u : 0u) == 0)
					{
						sound.destroySelf();
					}
					sound._isAvailable = true;
				}
			}
			else
			{
				_003ChasGameObject_003E5__2 = false;
				_003C_003E1__state = -1;
				if (sound.gameObject != null)
				{
					_003ChasGameObject_003E5__2 = true;
					Transform transform = sound.gameObject.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Sound+<play>d__19)+1C]");
					((Vector3*)(nint)vector)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)position;
					transform.position = vector;
				}
				if ((bool)sound.audioSource)
				{
					_003ChasAudioSource_003E5__3 = true;
					sound.audioSource.rolloffMode = rolloff;
					float volume = UnityEngine.Random.Range(minVolume, maxVolume);
					sound.audioSource.volume = volume;
					float pitch = UnityEngine.Random.Range(minPitch, maxPitch);
					sound.audioSource.pitch = pitch;
					sound.audioSource.loop = willLoop;
					sound._isAvailable = false;
					AudioSource component = sound.audioSource.GetComponent<AudioSource>();
					component.Play();
					if (!sound.audioSource.loop)
					{
						AudioClip clip = sound.audioSource.clip;
						float length = clip.length;
						float num = length + 0.1f;
						object obj2 = default;
						_003C_003E2__current = obj2;
						_003C_003E1__state = 1;
					}
				}
			}
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private So _manager;

	private GameObject gameObject;

	private bool _isAvailable;

	public AudioSource audioSource;

	public bool destroyAfterPlay;

	private string _name;

	public bool IsAvailable => _isAvailable;

	public string name => _name;

	public bool loop
	{
		set
		{
			audioSource.loop = value;
		}
	}

	public Sound(So manager)
	{
		_isAvailable = true;
		_manager = manager;
		GameObject gameObject = default;
		gameObject._002Ector();
		this.gameObject = gameObject;
		_name = "empty";
		this.gameObject.name = _name;
		this.gameObject.transform.parent = manager.transform;
		audioSource = this.gameObject.AddComponent<AudioSource>();
	}

	public void destroySelf()
	{
		_manager.removeSound(this);
		UnityEngine.Object.Destroy(gameObject);
	}

	public void Stop()
	{
		Pause();
		Rewind();
		destroySelf();
	}

	public void Pause()
	{
		audioSource.Stop();
	}

	public void Rewind()
	{
		audioSource.time = 0f;
	}

	public unsafe IEnumerator fadeOutAndStop(float duration)
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(Sound._003CfadeOutAndStop_003Eb__17_0));
		return AudioSourceExtensions.fadeOut(audioSource, duration, action);
	}

	public unsafe IEnumerator playAudioClip(AudioClip audioClip, AudioRolloffMode rolloff, float minVolume, float maxVolume, float minPitch, float maxPitch, Vector3 position, bool willLoop = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00db: Expected native int or pointer, but got VT
		//IL_00ed: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		string text = audioClip.name;
		_name = text;
		if (gameObject != null)
		{
			gameObject.name = _name;
		}
		if (audioSource != null)
		{
			audioSource.clip = audioClip;
			float volume = UnityEngine.Random.Range(minVolume, maxVolume);
			audioSource.volume = volume;
			float pitch = UnityEngine.Random.Range(minPitch, maxPitch);
			audioSource.pitch = pitch;
		}
		((Vector3*)(nint)vector)->z = position.z;
		((Vector3*)(nint)vector)->x = position.x;
		return play(rolloff, minVolume, maxVolume, minPitch, maxPitch, vector, willLoop);
	}

	public IEnumerator play(AudioRolloffMode rolloff, float minVolume, float maxVolume, float minPitch, float maxPitch, Vector3 position, bool willLoop)
	{
		_ = 0;
		_ = position.x;
		_ = position.z;
		IEnumerator result = default;
		return result;
	}

	private void _003CfadeOutAndStop_003Eb__17_0()
	{
		Stop();
	}
}
