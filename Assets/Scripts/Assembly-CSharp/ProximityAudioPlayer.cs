using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

public class ProximityAudioPlayer : MonoBehaviour
{
	private AudioClipInfo _clipInfo;

	private float _maxZProximity = 500f;

	private float _minZProximity;

	private bool _useParentPosition;

	private AudioSource _source;

	private Character _character;

	private void Start()
	{
		AudioSource component = GetComponent<AudioSource>();
		_source = component;
		AudioClipInfo clipInfo = _clipInfo;
		_source.clip = clipInfo.Clip;
		AudioClipInfo clipInfo2 = _clipInfo;
		_source.rolloffMode = clipInfo2.Rollof;
		Character instance = Character.Instance;
		_character = instance;
	}

	public void ProximityBasedPlay()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Transform transform = base.transform;
		Transform transform2 = ((~(_useParentPosition ? 1u : 0u) != 0) ? transform : transform.parent);
		Vector3 position = transform2.position;
		Character character = _character;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num = 0f - character.z;
		if (!(num < _minZProximity) && !(num > _maxZProximity))
		{
			AudioClipInfo clipInfo = _clipInfo;
			float pitch = Random.Range(clipInfo.minPitch, clipInfo.maxPitch);
			_source.pitch = pitch;
			AudioClipInfo clipInfo2 = _clipInfo;
			float volume = Random.Range(clipInfo2.minVolume, clipInfo2.maxVolume);
			_source.volume = volume;
			_source.Play();
		}
	}

	public void Stop()
	{
		_source.Stop();
	}
}
