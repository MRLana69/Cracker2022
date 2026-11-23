using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

namespace SYBO.Subway.Level;

public class MovingTrainUpdater : MonoBehaviour
{
	private class TrainAudioWrapper
	{
		private GameObject _passingTrainGameObject;

		private Transform _passingTrainTransform;

		private AudioSource _passingTrainAudioSource;

		private MovingTrain _currentPassingTrain;

		private float previousVolume = 1f;

		public MovingTrain CurrentPassingTrain => _currentPassingTrain;

		public TrainAudioWrapper(Transform parent)
		{
			GameObject gameObject = default;
			gameObject._002Ector("PassingTrainAudio");
			_passingTrainGameObject = gameObject;
			Transform transform = _passingTrainGameObject.transform;
			_passingTrainTransform = transform;
			_passingTrainTransform.SetParent(parent);
			_passingTrainAudioSource = _passingTrainGameObject.AddComponent<AudioSource>();
			_passingTrainAudioSource.minDistance = 20f;
			_passingTrainAudioSource.maxDistance = 50f;
			_passingTrainAudioSource.playOnAwake = false;
			_passingTrainAudioSource.loop = true;
			_passingTrainAudioSource.spatialBlend = 1f;
		}

		public void SetAudioClip(AudioClip clip)
		{
			_passingTrainAudioSource.clip = clip;
		}

		public void ResetPassingTrain()
		{
			_currentPassingTrain = null;
			_passingTrainAudioSource.Stop();
		}

		public void SetPassingTrain(MovingTrain train)
		{
			if (train != _currentPassingTrain)
			{
				_currentPassingTrain = train;
				float pitch = UnityEngine.Random.Range(0.8f, 1.1f);
				_passingTrainAudioSource.pitch = pitch;
				float volume = UnityEngine.Random.Range(0.1f, 0.6f);
				_passingTrainAudioSource.volume = volume;
				if (!Settings.optionSfx)
				{
					Mute();
				}
				int timeSamples = _passingTrainAudioSource.timeSamples;
				int timeSamples2 = UnityEngine.Random.Range(0, timeSamples);
				_passingTrainAudioSource.timeSamples = timeSamples2;
				_passingTrainAudioSource.Play();
			}
		}

		public void Mute()
		{
			float volume = _passingTrainAudioSource.volume;
			previousVolume = volume;
			_passingTrainAudioSource.volume = 0f;
		}

		public void Unmute()
		{
			_passingTrainAudioSource.volume = previousVolume;
		}

		public void Pause(bool pause)
		{
			if (pause)
			{
				if (_passingTrainAudioSource.isPlaying)
				{
					_passingTrainAudioSource.Pause();
				}
			}
			else if (_currentPassingTrain != null)
			{
				_passingTrainAudioSource.Play();
			}
		}

		public unsafe void UpdatePosition()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0037: Expected F4, but got I
			//IL_0032: Expected native int or pointer, but got VT
			//IL_004c: Expected F4, but got I
			//IL_0047: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 32);
			if (_currentPassingTrain != null)
			{
				Vector3 trainModelPosition = _currentPassingTrain.GetTrainModelPosition();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				_passingTrainTransform.position = vector;
			}
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MovingTrain> _003C_003E9__14_0;

		public static Func<TrainAudioWrapper, bool> _003C_003E9__14_1;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal unsafe int _003CUpdate_003Eb__14_0(MovingTrain a, MovingTrain b)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_003a: Expected Ref, but got F4
			object obj2 = default;
			object obj = obj2 - 16;
			_ = a._distanceToCameraZ;
			float num = (float)obj + 12f;
			return ((float*)num)->CompareTo(b._distanceToCameraZ);
		}

		internal bool _003CUpdate_003Eb__14_1(TrainAudioWrapper w)
		{
			return w._currentPassingTrain == null;
		}
	}

	private const int MaxNumberOfTrainAudios = 3;

	private const float MaxPlayingDistance = 300f;

	private List<MovingTrain> _trains;

	private TrainAudioWrapper[] _audioWrappers;

	private Dictionary<MovingTrain, TrainAudioWrapper> _trainToAudioWrapperMap;

	private float _lastCameraPositionZ;

	private void Awake()
	{
		//IL_00cb: Expected Obj, but got I4
		object obj = 0;
		if ((nint)obj < 3)
		{
			Transform parent = transform;
			TrainAudioWrapper trainAudioWrapper = default;
			trainAudioWrapper._002Ector(parent);
			trainAudioWrapper.ResetPassingTrain();
			throw new ArrayTypeMismatchException();
		}
		UpdateSfxVolumeToSettings();
		Game instance = Game.Instance;
		throw new ArgumentException();
	}

	private void Game_OnPauseChange(bool pause)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got I
		object obj = 0;
		while ((nint)obj < 3)
		{
			object obj2 = obj << 2;
			object obj3 = (object)_audioWrappers + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v7+10]");
			if ((nint)0 != 0)
			{
				object obj4 = obj << 2;
				object obj5 = (object)_audioWrappers + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14+10]");
				((TrainAudioWrapper)0).Pause(pause);
			}
			object obj6 = obj + 1;
			obj = obj6;
		}
	}

	private void OnSfxSettingChanged()
	{
		UpdateSfxVolumeToSettings();
	}

	private void UpdateSfxVolumeToSettings()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		object obj = 0;
		while ((nint)obj < 3)
		{
			bool optionSfx = Settings.optionSfx;
			object obj2 = obj << 2;
			object obj3 = (object)_audioWrappers + obj2;
			if (optionSfx)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v9+10]");
				if ((nint)0 != 0)
				{
					object obj4 = obj << 2;
					object obj5 = (object)_audioWrappers + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v25+10]");
					((TrainAudioWrapper)0).Unmute();
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v9+10]");
				if ((nint)0 != 0)
				{
					object obj6 = obj << 2;
					object obj7 = (object)_audioWrappers + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v19+10]");
					((TrainAudioWrapper)0).Mute();
				}
			}
			object obj8 = obj + 1;
			obj = obj8;
		}
	}

	public void SetAudioClip(AudioClip clip)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got I
		object obj = 0;
		while ((nint)obj < 3)
		{
			object obj2 = obj << 2;
			object obj3 = (object)_audioWrappers + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v7+10]");
			if ((nint)0 != 0)
			{
				object obj4 = obj << 2;
				object obj5 = (object)_audioWrappers + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14+10]");
				((TrainAudioWrapper)0).SetAudioClip(clip);
			}
			object obj6 = obj + 1;
			obj = obj6;
		}
	}

	public void AddMovingTrain(MovingTrain train)
	{
		_trains.Add(train);
	}

	public unsafe void RemoveMovingTrain(MovingTrain train)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Ref, but got Unknown
		//IL_0024: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = _trains.Remove(train);
		if (_trainToAudioWrapperMap.TryGetValue(train, out *(TrainAudioWrapper*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			((TrainAudioWrapper)0).ResetPassingTrain();
		}
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00bb: Expected F4, but got I
		//IL_0271: Expected Obj, but got I4
		//IL_02a4: Expected Obj, but got I
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Ref, but got Unknown
		//IL_01f7: Expected Obj, but got I4
		//IL_03d1: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Camera main = Camera.main;
		if (!(main != null))
		{
			return;
		}
		Game instance = Game.Instance;
		Character instance2 = Character.Instance;
		Camera main2 = Camera.main;
		Transform transform = main2.transform;
		Vector3 position = transform.position;
		List<MovingTrain> trains = _trains;
		int num = trains._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 <= -1)
			{
				break;
			}
			MovingTrain movingTrain = _trains.get_Item(num2);
			float _currentSpeed = instance.__currentSpeed;
			float z = instance2.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			movingTrain.UpdateMovingTrain(_currentSpeed, z, 0f);
			num = num2;
		}
		bool flag = _003C_003Ec._003C_003E9__14_0 == null;
		bool flag2 = !flag;
		Comparison<MovingTrain> comparison = _003C_003Ec._003C_003E9__14_0;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		_trains.Sort(comparison);
		int num3 = trains._size - 1;
		int num7;
		for (int num4 = num3; num4 > -1; num7 = num4 - 1, num4 = num7)
		{
			MovingTrain movingTrain2 = _trains.get_Item(num4);
			bool flag3 = num4 < 3 && movingTrain2._distanceToCameraZ < 300f;
			bool flag4 = _trainToAudioWrapperMap.TryGetValue(movingTrain2, out *(TrainAudioWrapper*)(obj + 12));
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					((TrainAudioWrapper)0).ResetPassingTrain();
					bool flag5 = _trainToAudioWrapperMap.Remove(movingTrain2);
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			bool flag6 = (nint)0 == 0;
			object obj3 = flag3 & flag6;
			if (obj3 != null)
			{
				bool flag7 = _003C_003Ec._003C_003E9__14_1 == null;
				bool flag8 = !flag7;
				Func<TrainAudioWrapper, bool> predicate = _003C_003Ec._003C_003E9__14_1;
				if (!flag8)
				{
					throw new ArgumentException();
				}
				TrainAudioWrapper trainAudioWrapper = Enumerable.FirstOrDefault(_audioWrappers, predicate);
				trainAudioWrapper.SetPassingTrain(movingTrain2);
				nint num5 = 0;
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S5_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.MovingTrain, SYBO.Subway.Level.MovingTrainUpdater+TrainAudioWrapper>>)+5C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v329 @ S5_v7+4] (should have been resolved before IL gen)");
			}
		}
		object obj5 = 0;
		while ((nint)obj5 < 3)
		{
			object obj6 = obj5 << 2;
			object obj7 = (object)_audioWrappers + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v59+10]");
			((TrainAudioWrapper)0).UpdatePosition();
			object obj8 = obj5 + 1;
			obj5 = obj8;
		}
	}

	public MovingTrainUpdater()
	{
		List<MovingTrain> list = default;
		list._002Ector(20);
		_trains = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		TrainAudioWrapper[] audioWrappers = default;
		_audioWrappers = audioWrappers;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.MovingTrain, SYBO.Subway.Level.MovingTrainUpdater+TrainAudioWrapper>>>)+4] (should have been resolved before IL gen)");
		Dictionary<MovingTrain, TrainAudioWrapper> trainToAudioWrapperMap = default;
		_trainToAudioWrapperMap = trainToAudioWrapperMap;
		base._002Ector();
	}
}
