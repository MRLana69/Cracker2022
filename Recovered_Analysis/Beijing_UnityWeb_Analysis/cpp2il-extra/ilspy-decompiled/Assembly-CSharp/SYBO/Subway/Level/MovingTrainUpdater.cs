using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Characters;
using UnityEngine;
using UnityEngine.UI;

namespace SYBO.Subway.Level;

public class MovingTrainUpdater : MonoBehaviour
{
	private class TrainAudioWrapper
	{
		private GameObject _passingTrainGameObject = (GameObject)(object)parent;

		private Transform _passingTrainTransform;

		private AudioSource _passingTrainAudioSource;

		private MovingTrain _currentPassingTrain;

		private float previousVolume;

		public MovingTrain CurrentPassingTrain => (MovingTrain)(object)_passingTrainTransform;

		public TrainAudioWrapper(Transform parent)
		{
		}

		public void SetAudioClip(AudioClip clip)
		{
			//IL_00bf: Expected I4, but got Obj
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected Obj, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected Obj, but got Unknown
			//IL_000d: Expected Obj, but got I4
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected Obj, but got Unknown
			previousVolume = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"PassingTrainAudio";
			object obj = this + 8;
			obj = gameObject;
			object obj2 = this + 12;
			int layer = _passingTrainGameObject.layer;
			obj2 = layer;
			Matrix4x4 worldToLocalMatrix = ((Transform)(object)clip).worldToLocalMatrix;
			object obj3 = this + 16;
			AudioSource audioSource = _passingTrainGameObject.AddComponent<AudioSource>();
			obj3 = audioSource;
			_passingTrainAudioSource.maxDistance = 20f;
			((ParticleSystem)(object)_passingTrainAudioSource).Simulate(50f);
			_passingTrainAudioSource.bypassEffects = false;
			_passingTrainAudioSource.playOnAwake = true;
			_passingTrainAudioSource.minDistance = 1f;
		}

		public void ResetPassingTrain()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		public void SetPassingTrain(MovingTrain train)
		{
			//IL_000f: Expected I4, but got Obj
			_passingTrainAudioSource.loop = (byte)(int)train != 0;
		}

		public void Mute()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0014: Expected Obj, but got I4
			object obj = this + 20;
			obj = 0;
			_passingTrainAudioSource.Pause();
		}

		public void Unmute()
		{
			float pitch = _passingTrainAudioSource.pitch;
			previousVolume = pitch;
			_passingTrainAudioSource.pitch = 0f;
		}

		public void Pause(bool pause)
		{
			//IL_01a0: Expected I, but got Obj
			//IL_01b6: Expected Obj, but got I
			//IL_020f: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			//IL_0065: Expected Obj, but got I4
			//IL_00c1: Expected I, but got Obj
			//IL_00d7: Expected Obj, but got I
			//IL_0169: Expected I4, but got Obj
			//IL_0102: Expected I, but got Obj
			//IL_0181: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)pause).FindKernel((string)(object)_currentPassingTrain) == 0)
			{
				return;
			}
			object obj2 = this + 20;
			obj2 = pause;
			float time = ScrollRect.RubberDelta(0.8f, 1.1f);
			_passingTrainAudioSource.time = time;
			float pitch = ScrollRect.RubberDelta(0.1f, 0.6f);
			_passingTrainAudioSource.pitch = pitch;
			nint num3 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v22 (Il2CppClass<Info.Settings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Settings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v35 (Il2CppClass<Info.Settings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!PreferencesSave.musicEnabled)
			{
				Unmute();
			}
			AudioClip clip = _passingTrainAudioSource.clip;
			int num5 = UnityEngine.Random.RandomRangeInt(0, (int)clip);
			_passingTrainAudioSource.clip = (AudioClip)num5;
			_passingTrainAudioSource.Stop();
		}

		public void UpdatePosition()
		{
			_passingTrainAudioSource.pitch = previousVolume;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MovingTrain> _003C_003E9__13_0;

		public static Func<TrainAudioWrapper, bool> _003C_003E9__13_1;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SubwayMemoryBenchmark._003C_003Ec obj = default;
			SubwayMemoryBenchmark._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			//IL_00a2: Expected I, but got Obj
			//IL_00b8: Expected Obj, but got I
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected Obj, but got Unknown
			//IL_00f5: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MovingTrainUpdater movingTrainUpdater = default;
			Transform transform = (Transform)(movingTrainUpdater + 12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.MovingTrainUpdater+<>c)+14]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.MovingTrainUpdater+<>c)+14]");
				movingTrainUpdater.Game_OnPauseChange(pause: false);
				transform = (Transform)(object)movingTrainUpdater;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)movingTrainUpdater).m_CachedPtr;
				Vector3 localPosition = transform.localPosition;
			}
		}

		internal int _003CUpdate_003Eb__13_0(MovingTrain a, MovingTrain b)
		{
			//IL_00cf: Expected I, but got Obj
			//IL_00e5: Expected Obj, but got I
			//IL_0071: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_005f: Expected I4, but got Obj
			//IL_00c1: Expected I4, but got Obj
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v22 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v34 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Transform characterControllerTransform = a._characterControllerTransform;
			Transform characterControllerTransform2 = b._characterControllerTransform;
			int max = ((System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref characterControllerTransform) >= System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref characterControllerTransform2)) ? ((int)b._characterControllerTransform) : ((int)a._characterControllerTransform));
			int index = UnityEngine.Random.RandomRangeInt(0, max);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list = default;
			list._002Ector();
			string item = ((List<string>)(object)a).get_Item(index);
			list.Add(item);
			string item2 = ((List<string>)(object)b).get_Item(index);
			list.Add(item2);
			return (int)list;
		}

		internal bool _003CUpdate_003Eb__13_1(TrainAudioWrapper w)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreens>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreens);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UIScreens>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return Enumerable.Contains(UIScreens.SCREENS, (string)(object)w);
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
		//IL_000b: Expected Obj, but got F4
		//IL_0016: Expected Obj, but got F4
		_audioWrappers = (TrainAudioWrapper[])1f;
		_trainToAudioWrapperMap = (Dictionary<MovingTrain, TrainAudioWrapper>)3f;
		CancelInvoke();
	}

	private void Game_OnPauseChange(bool pause)
	{
		//IL_0012: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+20]");
		((Transform)(object)this).position = (Vector3)0;
	}

	private unsafe void OnSfxSettingChanged()
	{
		//IL_01f7: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0268: Expected Obj, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_016e: Expected I, but got Obj
		//IL_0184: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_01af: Expected I, but got Obj
		object obj = 0;
		if ((nint)obj <= 2)
		{
			GameObject audioClip = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			TrainAudioWrapper trainAudioWrapper = default;
			trainAudioWrapper.SetAudioClip((AudioClip)(object)audioClip);
			trainAudioWrapper.Mute();
			throw new ArrayTypeMismatchException();
		}
		Update();
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v11 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v33 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<bool> action = default;
		object obj3 = action + 16;
		obj3 = this;
		((Game)isInstantiated).OnPauseChange -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(MovingTrainUpdater.OnSfxSettingChanged);
		object obj4 = action2 + 16;
		obj4 = this;
		nint num4 = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v24 (Il2CppClass<Info.Settings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v29 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Settings.onSfxSettingChanged -= action2;
	}

	private void UpdateSfxVolumeToSettings()
	{
		Update();
	}

	public void SetAudioClip(AudioClip clip)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_00ab: Expected I4, but got Obj
		object obj = default;
		object obj8 = default;
		while ((nint)obj <= 2)
		{
			object obj2 = _audioWrappers + 16;
			object obj3 = obj << 2;
			object obj4 = obj2 + obj3;
			if (obj4 != null)
			{
				object obj5 = _audioWrappers + 16;
				object obj6 = obj << 2;
				object obj7 = obj5 + obj6;
				((LogicAssetsManager.BasicObstaclePrefab)obj7)._002Ector((BasicObstacleType)clip);
			}
			obj = obj8 + 1;
		}
	}

	public void AddMovingTrain(MovingTrain train)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		object obj = default;
		object obj8 = default;
		while ((nint)obj <= 2)
		{
			object obj2 = _audioWrappers + 16;
			object obj3 = obj << 2;
			object obj4 = obj2 + obj3;
			if (obj4 != null)
			{
				object obj5 = _audioWrappers + 16;
				object obj6 = obj << 2;
				object obj7 = obj5 + obj6;
				((TrainAudioWrapper)obj7).SetPassingTrain(train);
			}
			obj = obj8 + 1;
		}
	}

	public void RemoveMovingTrain(MovingTrain train)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
	}

	private void Update()
	{
		//IL_015c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		object obj = 0;
		while ((nint)obj <= 2)
		{
			nint num = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v10 (Il2CppClass<Info.Settings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Settings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v34 (Il2CppClass<Info.Settings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool musicEnabled = PreferencesSave.musicEnabled;
			object obj3 = _audioWrappers + 16;
			object obj4 = obj << 2;
			object obj5 = obj3 + obj4;
			bool flag = obj5 == null;
			if (musicEnabled)
			{
				if (!flag)
				{
					object obj6 = _audioWrappers + 16;
					object obj7 = obj << 2;
					object obj8 = obj6 + obj7;
					((TrainAudioWrapper)obj8).UpdatePosition();
				}
			}
			else if (!flag)
			{
				object obj9 = _audioWrappers + 16;
				object obj10 = obj << 2;
				object obj11 = obj9 + obj10;
				((TrainAudioWrapper)obj11).Unmute();
			}
			object obj12 = obj + 1;
			obj = obj12;
		}
	}

	public unsafe MovingTrainUpdater()
	{
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Ref, but got Unknown
		//IL_053f: Expected I, but got Obj
		//IL_0555: Expected Obj, but got I
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_05c9: Expected I, but got Obj
		//IL_05df: Expected Obj, but got I
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_013a: Expected VT, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_01cf: Expected I, but got Obj
		//IL_01e5: Expected Obj, but got I
		//IL_01a1: Expected F4, but got I
		//IL_01a1: Expected F4, but got I
		//IL_01a1: Expected F4, but got I
		//IL_087d: Expected native int or pointer, but got Obj
		//IL_0210: Expected I, but got Obj
		//IL_025d: Expected I, but got Obj
		//IL_0273: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I4
		//IL_06bd: Expected Obj, but got I
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected Obj, but got Unknown
		//IL_06ed: Expected I, but got Obj
		//IL_0703: Expected Obj, but got I
		//IL_029e: Expected I, but got Obj
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_075f: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_0377: Expected I, but got Obj
		//IL_038d: Expected Obj, but got I
		//IL_08b4: Expected I4, but got Obj
		//IL_08b4: Expected Obj, but got VT
		//IL_08ca: Expected Obj, but got I
		//IL_08da: Expected Obj, but got I
		//IL_08ea: Expected Obj, but got I
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected Obj, but got Unknown
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected Obj, but got Unknown
		//IL_03b8: Expected I, but got Obj
		//IL_0405: Expected I, but got Obj
		//IL_041b: Expected Obj, but got I
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected Obj, but got Unknown
		//IL_07f0: Expected I, but got Obj
		//IL_0806: Expected Obj, but got I
		//IL_0446: Expected I, but got Obj
		Transform transform = default;
		ref TrainAudioWrapper reference = ref *(TrainAudioWrapper*)(transform + 24);
		reference = ref *(TrainAudioWrapper*)null;
		Camera current = Camera.current;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v154 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = transform + 12;
		if (current != null)
		{
			return;
		}
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v25 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v150 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		nint num5 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v33 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v146 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance = CharacterRendering.Instance;
		object obj4 = instance + 248;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v13+8]");
		_ = 0;
		Camera current2 = Camera.current;
		GameObject gameObject = current2.gameObject;
		transform.position = (Vector3)gameObject;
		List<MovingTrain> trains = _trains;
		int num7 = trains._size - 1;
		while (num7 >= 0)
		{
			MovingTrain movingTrain = _trains.get_Item(num7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v30 (System.Boolean)+44]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+8]");
			((UIRect.AnchorPoint)(object)movingTrain).SetToNearest((float)num8, 0f, (float)(nint)((UnityEngine.Object)transform).m_CachedPtr);
			int num9 = num7 - 1;
			num7 = num9;
		}
		nint num10 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v56 (Il2CppClass<SYBO.Subway.Level.MovingTrainUpdater+<>c>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num11 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v136 (Il2CppClass<SYBO.Subway.Level.MovingTrainUpdater+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__13_0 == null;
		bool flag2 = !flag;
		Queue<_00210> q = (Queue<_00210>)(object)_003C_003Ec._003C_003E9__13_0;
		if (!flag2)
		{
			nint num12 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v110 (Il2CppClass<SYBO.Subway.Level.MovingTrainUpdater+<>c>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num13 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v130 (Il2CppClass<SYBO.Subway.Level.MovingTrainUpdater+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num14 = 0;
			Queue<_00210> queue = default;
			queue._array = (_00210[])num14;
			queue._size = 0;
			object obj5 = queue + 16;
			obj5 = _003C_003Ec._003C_003E9;
			nint num15 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v127 (Il2CppClass<SYBO.Subway.Level.MovingTrainUpdater+<>c>)+5C]");
			object obj6 = (nint)0 + (nint)4;
			obj6 = queue;
			q = queue;
		}
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)_trains, new Queue<T>.Enumerator((Queue<T>)(object)q));
		int num16 = trains._size;
		Func<_0021_00210, bool> func = default;
		while (true)
		{
			int num17 = num16 - 1;
			if (num17 < 0)
			{
				break;
			}
			MovingTrain movingTrain2 = _trains.get_Item(num17);
			bool flag3 = num17 <= 2 && movingTrain2._distanceToCameraZ < 300f;
			bool flag4 = _trainToAudioWrapperMap.TryGetValue(movingTrain2, out reference);
			bool flag5 = flag3;
			bool flag6 = reference == null;
			object obj7 = flag5 | flag6;
			if (obj7 != null)
			{
				object obj8 = flag5 & flag6;
				if (obj8 != null)
				{
					nint num18 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S1_v52 (Il2CppClass<SYBO.Subway.Level.MovingTrainUpdater+<>c>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num19 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S1_v91 (Il2CppClass<SYBO.Subway.Level.MovingTrainUpdater+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag7 = _003C_003Ec._003C_003E9__13_1 == null;
					bool flag8 = !flag7;
					Func<_0021_00210, bool> predicate = (Func<_0021_00210, bool>)(object)_003C_003Ec._003C_003E9__13_1;
					if (!flag8)
					{
						nint num20 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S1_v65 (Il2CppClass<SYBO.Subway.Level.MovingTrainUpdater+<>c>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num21 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S1_v85 (Il2CppClass<SYBO.Subway.Level.MovingTrainUpdater+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num22 = 0;
						_ = 0;
						object obj11 = func + 16;
						obj11 = _003C_003Ec._003C_003E9;
						nint num23 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S1_v82 (Il2CppClass<SYBO.Subway.Level.MovingTrainUpdater+<>c>)+5C]");
						object obj12 = (nint)0 + (nint)8;
						obj12 = func;
						predicate = func;
					}
					_0021_00210 val = (_0021_00210)Enumerable.SingleOrDefault<TSource>((IEnumerable<TSource>)(object)_audioWrappers, (Func<TSource, bool>)(object)predicate);
					((TrainAudioWrapper)val).Pause((byte)(int)movingTrain2 != 0);
					nint num24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ S4_v9 (Il2CppMethodInfo)+C]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S4_v10+60]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S4_v11+48]");
					object obj15 = 0;
					object obj16 = obj15 & 0x7FF;
					object obj17 = obj16 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v271 @ S5_v3 (should have been resolved before IL gen)");
				}
			}
			else
			{
				reference.Mute();
				bool flag9 = _trainToAudioWrapperMap.Remove(movingTrain2);
			}
			num16 = num17;
		}
		object obj18 = 0;
		while ((nint)obj18 <= 2)
		{
			object obj19 = _audioWrappers + 16;
			object obj20 = obj18 << 2;
			object obj21 = obj19 + obj20;
			((_003C_003Ec)obj21)._002Ector();
			object obj22 = obj18 + 1;
			obj18 = obj22;
		}
	}
}
