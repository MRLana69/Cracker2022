using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Utility;
using SYBO.Common.Automation;
using SYBO.Common.Benchmarking;
using SYBO.Common.Managers;
using SYBO.Common.StateSystem;
using SYBO.Components.Utilities;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Inputs;
using SYBO.Subway.Level;
using SYBO.Subway.Managers;
using SYBO.Subway.Pickups;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.StateSystem.States.Settings;
using UnityEngine;

namespace SYBO.Subway.StateSystem.States;

public class PogostickState : InGameState
{
	private sealed class _003CRemovePickups_003Ed__28(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PogostickState _003C_003E4__this;

		public float endPosition;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Expected Obj, but got Unknown
				//IL_0092: Invalid comparison between I and F4
				//IL_00ec: Expected I, but got Obj
				//IL_0102: Expected Obj, but got I
				//IL_0294: Expected Obj, but got I4
				//IL_02a2: Expected I, but got Obj
				//IL_02b8: Expected Obj, but got I
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Expected Obj, but got Unknown
				//IL_00c5: Expected Obj, but got I4
				//IL_00d9: Expected Obj, but got I4
				//IL_02e4: Expected Obj, but got VT
				//IL_012d: Expected I, but got Obj
				//IL_017a: Expected I, but got Obj
				//IL_01c2: Expected VT, but got Obj
				//IL_01d0: Expected Obj, but got VT
				//IL_01e6: Expected Obj, but got I4
				//IL_01e6: Expected Obj, but got VT
				//IL_0210: Expected VT, but got Obj
				//IL_021e: Expected Obj, but got VT
				//IL_0234: Expected Obj, but got VT
				//IL_023d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0242: Expected Obj, but got Unknown
				//IL_024b: Expected Obj, but got I4
				PogostickState pogostickState = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				object obj = ((BackgroundLayer)(object)pogostickState).SkylineFillObjectPrefabs + 236;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v8+8]");
				_ = 0;
				float num = endPosition + 100f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				if (0f < num)
				{
					object obj3 = this + 12;
					obj3 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				nint num2 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v20 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num3 = (nint)typeof(GamePositionRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v40 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isRestricted = AgeRestriction.isRestricted;
				((BackgroundLayer)isRestricted)._002Ector((BackgroundLayer)(object)pogostickState);
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)((BackgroundLayer)(object)pogostickState)._offsetFromLayerDefault).FindKernel(null) != 0)
				{
					_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
					int layer = ((GameObject)((BackgroundLayer)(object)pogostickState)._offsetFromLayerDefault).layer;
					if (PickupManager.SortSpawnPointsClosestFirst((PickupSpawnPoint)val, (PickupSpawnPoint)layer) != 0)
					{
						_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
						int layer2 = ((GameObject)((BackgroundLayer)(object)pogostickState)._offsetFromLayerDefault).layer;
						((PickupManager)val2).ResetPickupAndPickerLastPositions((PickupManager.ReasonToResetHistory)layer2);
						object obj6 = pogostickState + 32;
						obj6 = 0;
					}
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private PogostickStateSettings _settings;

	private PickupType[] _pickupWeightedList;

	private GameObject _pickupSpawnPointPrefabInstance;

	public Action OnStart;

	public Action OnHangtime;

	public Action OnStop;

	private List<Action> _startHandlers;

	private Vector3 _startGamePosition;

	private float _endGamePositionZ;

	private bool _reachedHangtime;

	private SmoothDampFloat _smoothCameraX;

	private Vector3 _cameraPositionStart;

	private Vector3 _cameraTargetStartOffset;

	public PogostickState(int id)
	{
		//IL_009c: Expected VT, but got Obj
		//IL_00a5: Expected VT, but got Obj
		//IL_00bf: Expected F4, but got I
		//IL_00bf: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		Game game = _game;
		Variable<bool> isInGame = game.IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 != 0)
		{
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v108 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v113 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Game.InvokeOnMenuScreenShown();
		}
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v6 (T)+10]");
		((TimeScaleManager)val).TimeScaleInMenuDefault = 0f;
		_game.LoadFactories();
		throw new NullReferenceException();
	}

	public override void Enter(State fromState)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00ed: Expected I, but got Obj
		//IL_0103: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0091: Expected I4, but got Obj
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Action> list = default;
		list._002Ector();
		object obj = this + 48;
		obj = list;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v44 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 24;
		Vector3 one = Vector3.one;
		object obj5 = obj4 + 36;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+8]");
		_ = 0;
		object obj6 = this + 52;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21+8]");
		_ = 0;
		object obj7 = obj4 + 12;
		Vector3 one2 = Vector3.one;
		obj5 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v27+8]");
		_ = 0;
		object obj8 = this + 76;
		obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21+8]");
		_ = 0;
		Vector3 one3 = Vector3.one;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj9 = this + 88;
		obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21+8]");
		_ = 0;
		base.HandleSwipe((SwipeDir)fromState);
		object obj10 = this + 24;
		_0021_00210[] array = (_0021_00210[])(object)NGUITools.FindActive<T>();
		obj10 = array;
		NotifyOnStart();
	}

	public unsafe override void OnUpdate()
	{
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01bd: Expected Obj, but got I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I4
		//IL_01ee: Expected I, but got Obj
		//IL_0204: Expected Obj, but got I
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_03fd: Expected Obj, but got I
		//IL_0420: Expected I, but got Obj
		//IL_0436: Expected Obj, but got I
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected VT, but got Unknown
		//IL_023c: Expected F4, but got Obj
		//IL_0237: Expected native int or pointer, but got VT
		//IL_0251: Expected F4, but got I
		//IL_024c: Expected native int or pointer, but got VT
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected VT, but got Unknown
		//IL_026c: Expected F4, but got Obj
		//IL_0267: Expected native int or pointer, but got VT
		//IL_0281: Expected F4, but got I
		//IL_027c: Expected native int or pointer, but got VT
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02c4: Expected F4, but got Obj
		//IL_02bf: Expected native int or pointer, but got VT
		//IL_02d9: Expected F4, but got I
		//IL_02d4: Expected native int or pointer, but got VT
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00ac: Expected F4, but got Obj
		//IL_00a7: Expected native int or pointer, but got VT
		//IL_00c1: Expected F4, but got I
		//IL_00bc: Expected native int or pointer, but got VT
		//IL_00ce: Expected F4, but got Obj
		//IL_00c9: Expected native int or pointer, but got VT
		//IL_00e3: Expected F4, but got I
		//IL_00de: Expected native int or pointer, but got VT
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0125: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0331: Expected Obj, but got I4
		//IL_0342: Expected F4, but got Obj
		//IL_033d: Expected native int or pointer, but got VT
		//IL_0357: Expected F4, but got I
		//IL_0352: Expected native int or pointer, but got VT
		//IL_0364: Expected F4, but got Obj
		//IL_035f: Expected native int or pointer, but got VT
		//IL_0379: Expected F4, but got I
		//IL_0374: Expected native int or pointer, but got VT
		//IL_038e: Expected Obj, but got VT
		//IL_038e: Expected Obj, but got VT
		//IL_038e: Expected Obj, but got I4
		//IL_0166: Expected I, but got Obj
		Transform transform = default;
		object obj = transform + 104;
		obj = 0;
		_ = 0;
		object obj2 = transform + 88;
		obj2 = 0;
		_ = 0;
		nint num = (nint)typeof(CharacterCamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v78 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int selectedBenchmarkIndex = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
		Vector3 cameraPositionValue = ((CharacterCamera)null).CameraPositionValue;
		object obj4 = transform + 76;
		object obj5 = _character + 248;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v14+8]");
		_ = 0;
		object obj6 = transform - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v20 (System.Int32)+38]");
		object obj7 = (nint)0 + (nint)44;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v21+8]");
		_ = 0;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v74 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(transform + 116);
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v22+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(transform + 128);
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v25+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj9 = transform + 52;
		Vector3 vector3 = vector - vector2;
		object obj10 = transform + 40;
		Vector3 down = Vector3.down;
		((Vector3*)(nint)vector2)->x = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v41+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj11 = transform + 28;
		Vector3 vector4 = vector2 / 0.8f;
		((Vector3*)(nint)vector)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v39+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v45+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj12 = transform + 16;
		Vector3 vector5 = vector - vector2;
		obj = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v51+8]");
		_ = 0;
		nint num5 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v55 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num6 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v70 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform.Rotate(21.50143f, 0f, 0f);
		obj2 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		CameraData defaultCameraData = ((CharacterCamera)selectedBenchmarkIndex).GetDefaultCameraData();
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((SubwayBenchmark)selectedBenchmarkIndex)._002Ector((IAutomationStep[])(object)defaultCameraData, (IBenchmarkMetric[])vector, (IMetricSampler[])vector2);
	}

	public override void Leave(State toState)
	{
		//IL_03ec: Expected Obj, but got I4
		//IL_03fe: Expected I, but got Obj
		//IL_0414: Expected Obj, but got I
		//IL_0444: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		Vector3 cameraPositionValue = ((CharacterCamera)2).CameraPositionValue;
		nint num = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v105 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		((GamePositionRoot)isRestricted).RemoveLock(this);
		_game.ResetEnemyForEnterPlay();
		Character character = _character;
		character.inAirJump = false;
		throw new NullReferenceException();
	}

	public override void HandleSwipe(SwipeDir swipeDir)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_004c: Expected F4, but got I
		//IL_0059: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj != null)
		{
			((ReturnToCheckpointState)this)._002Ector(0);
			return;
		}
		object obj2 = _character + 236;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v8+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		RouteType routeType = ((RouteManager)(object)this).EvaluateAlternateRouteOffer(0f);
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])routeType);
	}

	private unsafe void EndPogo()
	{
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected VT, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected Obj, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected Obj, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected Obj, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected Obj, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected Obj, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected Obj, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected Obj, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected Obj, but got Unknown
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected Obj, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected Obj, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected Obj, but got Unknown
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected Obj, but got Unknown
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected Obj, but got Unknown
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got Unknown
		//IL_06ec: Expected Obj, but got I4
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected Obj, but got Unknown
		//IL_0709: Expected Obj, but got I4
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected Obj, but got Unknown
		//IL_0726: Expected Obj, but got I4
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected Obj, but got Unknown
		//IL_0743: Expected Obj, but got I4
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected Obj, but got Unknown
		//IL_0760: Expected Obj, but got I4
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected VT, but got Unknown
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected Obj, but got Unknown
		//IL_0791: Expected F4, but got Obj
		//IL_078c: Expected native int or pointer, but got VT
		//IL_07a6: Expected F4, but got I
		//IL_07a1: Expected native int or pointer, but got VT
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected Obj, but got Unknown
		//IL_07be: Invalid comparison between F4 and Obj
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_0827: Expected F4, but got Obj
		//IL_0822: Expected native int or pointer, but got VT
		//IL_083c: Expected F4, but got I
		//IL_0837: Expected native int or pointer, but got VT
		//IL_0136: Expected F4, but got Obj
		//IL_0131: Expected native int or pointer, but got VT
		//IL_014b: Expected F4, but got I
		//IL_0146: Expected native int or pointer, but got VT
		//IL_016e: Expected F4, but got Obj
		//IL_0169: Expected native int or pointer, but got VT
		//IL_0180: Expected F4, but got Obj
		//IL_017b: Expected native int or pointer, but got VT
		//IL_018d: Expected F4, but got Obj
		//IL_0188: Expected native int or pointer, but got VT
		//IL_01a2: Expected F4, but got I
		//IL_019d: Expected native int or pointer, but got VT
		//IL_00e0: Expected I, but got Obj
		//IL_0b29: Expected F4, but got Obj
		//IL_0b24: Expected native int or pointer, but got VT
		//IL_0b3e: Expected F4, but got I
		//IL_0b39: Expected native int or pointer, but got VT
		//IL_0b4d: Expected Obj, but got VT
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected Obj, but got Unknown
		//IL_0b80: Expected Obj, but got I
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_021e: Expected F4, but got Obj
		//IL_0219: Expected native int or pointer, but got VT
		//IL_0233: Expected F4, but got I
		//IL_022e: Expected native int or pointer, but got VT
		//IL_024b: Expected I, but got Obj
		//IL_0261: Expected Obj, but got I
		//IL_039e: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got F4
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_040b: Expected I, but got Obj
		//IL_0421: Expected Obj, but got I
		//IL_08ba: Expected F4, but got I
		//IL_08d5: Expected F4, but got Obj
		//IL_08d0: Expected native int or pointer, but got VT
		//IL_08ea: Expected F4, but got I
		//IL_08e5: Expected native int or pointer, but got VT
		//IL_08f7: Expected F4, but got Obj
		//IL_08f2: Expected native int or pointer, but got VT
		//IL_090c: Expected F4, but got I
		//IL_0907: Expected native int or pointer, but got VT
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected Obj, but got Unknown
		//IL_0975: Expected I, but got Obj
		//IL_098b: Expected Obj, but got I
		//IL_028c: Expected I, but got Obj
		//IL_09c9: Expected F4, but got I
		//IL_09c9: Expected F4, but got I
		//IL_0a13: Expected Obj, but got F4
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected Obj, but got Unknown
		//IL_0a55: Expected F4, but got Obj
		//IL_0a50: Expected native int or pointer, but got VT
		//IL_0a6a: Expected F4, but got I
		//IL_0a65: Expected native int or pointer, but got VT
		//IL_0a77: Expected F4, but got Obj
		//IL_0a72: Expected native int or pointer, but got VT
		//IL_0a8c: Expected F4, but got I
		//IL_0a87: Expected native int or pointer, but got VT
		//IL_0aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aad: Expected Obj, but got Unknown
		//IL_0acf: Expected F4, but got Obj
		//IL_0aca: Expected native int or pointer, but got VT
		//IL_0ae4: Expected F4, but got I
		//IL_0adf: Expected native int or pointer, but got VT
		//IL_0af1: Expected F4, but got Obj
		//IL_0aec: Expected native int or pointer, but got VT
		//IL_0b06: Expected F4, but got I
		//IL_0b01: Expected native int or pointer, but got VT
		//IL_044c: Expected I, but got Obj
		//IL_0505: Expected F4, but got Obj
		//IL_0500: Expected native int or pointer, but got VT
		//IL_051a: Expected F4, but got I
		//IL_0515: Expected native int or pointer, but got VT
		//IL_0527: Expected F4, but got Obj
		//IL_0522: Expected native int or pointer, but got VT
		//IL_053c: Expected F4, but got I
		//IL_0537: Expected native int or pointer, but got VT
		//IL_0499: Expected I, but got Obj
		//IL_0582: Expected Obj, but got F4
		//IL_058f: Expected F4, but got Obj
		//IL_058a: Expected native int or pointer, but got VT
		//IL_05a4: Expected F4, but got I
		//IL_059f: Expected native int or pointer, but got VT
		//IL_05bb: Expected F4, but got Obj
		//IL_05b6: Expected native int or pointer, but got VT
		//IL_05d0: Expected F4, but got I
		//IL_05cb: Expected native int or pointer, but got VT
		//IL_05df: Expected Obj, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + 252);
		RouteBuilder routeBuilder = (RouteBuilder)(obj + 180);
		object obj2 = obj + 168;
		object obj3 = obj + 156;
		object obj4 = obj + 144;
		object obj5 = obj + 132;
		object obj6 = obj + 120;
		object obj7 = obj + 108;
		object obj8 = obj + 96;
		object obj9 = obj + 84;
		object obj10 = obj + 72;
		object obj11 = obj + 60;
		object obj12 = obj + 48;
		object obj13 = obj + 36;
		object obj14 = obj + 24;
		object obj15 = obj + 12;
		object obj16 = obj + 240;
		obj16 = 0;
		_ = 0;
		object obj17 = obj + 228;
		obj17 = 0;
		_ = 0;
		object obj18 = obj + 216;
		obj18 = 0;
		_ = 0;
		object obj19 = obj + 204;
		obj19 = 0;
		_ = 0;
		object obj20 = obj + 192;
		obj20 = 0;
		_ = 0;
		Vector3 vector2 = (Vector3)(obj + 264);
		object obj21 = _character + 236;
		((Vector3*)(nint)vector2)->x = (float)obj21;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v37+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj22 = this - -64;
		float z = vector2.z;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)z) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22))
		{
			Game game = _game;
			float unscaledTime = Time.unscaledTime;
			float num = game.__currentSpeed * unscaledTime;
			float num2 = vector2.z + num;
			PogostickStateSettings settings = _settings;
			object obj23 = this + 52;
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v51+8]");
			float num4 = num3 - 0f;
			Character character = _character;
			routeBuilder.HideLogic(character.x, num2);
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v73 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v226 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 down = Vector3.down;
			PogostickStateSettings settings2 = _settings;
			float num7 = num4 / settings._jumpDistance;
			float num8 = PlayerPrefs.GetFloat((string)(object)settings2._jumpCurve, num7);
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Vector3 vector4 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			Vector3 vector5 = vector2 / num8;
			PogostickStateSettings settings3 = _settings;
			((Vector3*)(nint)vector2)->x = (float)obj3;
			Vector3 vector6 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			Vector3 vector7 = vector2 / settings3._jumpHeight;
			((Vector3*)(nint)vector)->x = (float)routeBuilder;
			((Vector3*)(nint)vector)->z = (float)routeBuilder.OnCompletedLayingSections;
			((Vector3*)(nint)vector2)->x = (float)obj4;
			Vector3 vector8 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			((Vector3*)(nint)vector8)->z = 0f;
			Vector3 vector9 = vector - vector2;
			obj16 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			_ = 0;
			PogostickStateSettings settings4 = _settings;
			if (!(num7 > settings4._fadeInPosition))
			{
				object obj25 = this + 52;
				((Vector3*)(nint)vector2)->x = (float)obj16;
				Vector3 vector10 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41+8]");
				((Vector3*)(nint)vector10)->z = 0f;
				PogostickStateSettings settings5 = _settings;
				nint num9 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v217 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num10 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v222 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float t = num7 / settings5._fadeInPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v207+4]");
				float num11 = Mathf.LerpUnclamped(0f, vector2.y, t);
			}
			PogostickStateSettings settings6 = _settings;
			if (num7 > settings6._hangtimePosition && ~(_reachedHangtime ? 1u : 0u) != 0)
			{
				NotifyOnStop();
				_reachedHangtime = true;
			}
			((Vector3*)(nint)vector2)->x = (float)obj16;
			Vector3 vector11 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41+8]");
			((Vector3*)(nint)vector11)->z = 0f;
			_character.UpdateGroundTag((Character)vector2);
			base.HandleCriticalHit();
			object obj27 = _character + 248;
			routeBuilder = (RouteBuilder)obj27;
			RouteBuilder routeBuilder2 = routeBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S1_v97+8]");
			routeBuilder2.OnCompletedLayingSections = (EventHandler)0;
			obj17 = routeBuilder;
			_ = routeBuilder.OnCompletedLayingSections;
			((SmoothDampVector3)(object)_smoothCameraX).Update();
			SmoothDampFloat smoothCameraX = _smoothCameraX;
			obj2 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v44+8]");
			_ = 0;
			float target = (float)obj2 * 0.75f;
			smoothCameraX._target = target;
			PogostickStateSettings settings7 = _settings;
			float t2 = PlayerPrefs.GetFloat((string)(object)settings7._cameraCurve, num7);
			SmoothDampFloat smoothCameraX2 = _smoothCameraX;
			obj3 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41+8]");
			_ = 0;
			obj4 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v44+8]");
			_ = 0;
			obj5 = 0;
			_ = 0;
			obj5 = smoothCameraX2._value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			_ = 0;
			CharacterCamera characterCamera = _characterCamera;
			object obj28 = characterCamera._currentCameraData + 44;
			obj6 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S1_v128+8]");
			_ = 0;
			nint num12 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v138 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num13 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S0_v197 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector2)->x = (float)obj6;
			Vector3 vector12 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((Vector3*)(nint)vector12)->z = 0f;
			Vector3 vector13 = vector - vector2;
			obj18 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
			_ = 0;
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
			_ = 0;
			object obj30 = this + 76;
			obj9 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v47+8]");
			_ = 0;
			nint num14 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S2_v33 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj31 = (nint)0 & (nint)0x200;
			if (obj31 != null)
			{
				nint num15 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ S2_v54 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v154+4]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+4]");
			float num17 = Mathf.LerpUnclamped(num16, 0f, t2);
			obj10 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v47+8]");
			_ = 0;
			obj19 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
			_ = 0;
			SmoothDampFloat smoothCameraX3 = _smoothCameraX;
			obj19 = smoothCameraX3._value;
			obj11 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v50+8]");
			_ = 0;
			object obj32 = this + 88;
			obj12 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S1_v170+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector2)->x = (float)obj12;
			Vector3 vector14 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
			((Vector3*)(nint)vector14)->z = 0f;
			Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
			object obj33 = _settings + 68;
			obj14 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ S1_v185+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v44+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector2)->x = (float)obj14;
			Vector3 vector15 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
			((Vector3*)(nint)vector15)->z = 0f;
			Vector3 vector16 = vector - vector2;
			PogostickStateSettings settings8 = _settings;
			float t3 = PlayerPrefs.GetFloat((string)(object)settings8._cameraAimFollowCurve, num7);
			((Vector3*)(nint)vector)->x = (float)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector2)->x = (float)obj15;
			Vector3 vector17 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+8]");
			((Vector3*)(nint)vector17)->z = 0f;
			Vector3 vector18 = Vector3.LerpUnclamped(vector, vector2, t3);
			obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			SmoothDampFloat smoothCameraX4 = _smoothCameraX;
			obj20 = smoothCameraX4._value;
			((Vector3*)(nint)vector2)->x = (float)obj19;
			Vector3 vector19 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v50+8]");
			((Vector3*)(nint)vector19)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7516");
			((Vector3*)(nint)vector2)->x = (float)obj20;
			Vector3 vector20 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v53+8]");
			((Vector3*)(nint)vector20)->z = 0f;
			_characterCamera.SetCameraDataForcefully((CameraData)vector2);
		}
		else
		{
			InitializeSpawnList();
		}
	}

	private unsafe void InitializeSpawnList()
	{
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_0051: Expected I, but got Obj
		Character character = _character;
		character._characterController.get_velocity_Injected(out *(Vector3*)1);
		if (!_character.IsVTol)
		{
			Character character2 = _character;
			PogostickStateSettings settings = _settings;
			float fOVForAspectRatio = ((CharacterCamera)(object)_character).GetFOVForAspectRatio(settings._finalJumpSpeed);
			character2.verticalSpeed = fOVForAspectRatio;
		}
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v14 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v24 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)102);
		Game game = _game;
		game._modifiers.Reset();
		SpawnCoinRows();
	}

	public void RegisterStartHandler(Action handler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = handler - 1;
		if ((nint)handler != 1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					PogostickStateSettings settings = _settings;
					Game game = _game;
					float duration = settings._characterChangeTrackLength / game.__currentSpeed;
					_character.ForceChangeTrack(1, duration);
				}
			}
			else
			{
				PogostickStateSettings settings2 = _settings;
				Game game2 = _game;
				float duration2 = settings2._characterChangeTrackLength / game2.__currentSpeed;
				_character.ForceChangeTrack(-1, duration2);
			}
		}
		else
		{
			InitializeSpawnList();
			_character.EnterRoute();
		}
	}

	private void NotifyOnStart()
	{
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0049: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I4
		//IL_008a: Expected I, but got Obj
		//IL_031f: Expected I, but got Obj
		//IL_0335: Expected Obj, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_0110: Expected I, but got Obj
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01cb: Expected Obj, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		PogostickStateSettings settings = _settings;
		object obj = settings._pickupList + 12;
		object obj2 = default;
		object obj9 = default;
		object obj10 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = settings._pickupList + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			object obj6 = obj5;
			nint num = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v49 (Il2CppClass<Info.Upgrades>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(Upgrades);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v61 (Il2CppClass<Info.Upgrades>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<UpgradeType, Upgrade> upgrades = Upgrades.upgrades;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v47+8]");
			Upgrade upgrade = upgrades.get_Item(UpgradeType._notset);
			object obj8 = upgrade.spawnProbability + obj9;
			obj2 = obj10 + 1;
		}
		object obj11 = this + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj12 = default;
		obj11 = obj12;
		object obj13 = 0;
		while (true)
		{
			PogostickStateSettings settings2 = _settings;
			PogostickStateSettings.PickupWeight[] pickupList = settings2._pickupList;
			if ((nint)obj13 >= pickupList.Length)
			{
				break;
			}
			object obj14 = 0;
			while (true)
			{
				nint num3 = (nint)typeof(Upgrades);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v22 (Il2CppClass<Info.Upgrades>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num4 = (nint)typeof(Upgrades);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v38 (Il2CppClass<Info.Upgrades>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				PogostickStateSettings settings3 = _settings;
				object obj16 = settings3._pickupList + 16;
				object obj17 = obj13 << 2;
				object obj18 = obj16 + obj17;
				object obj19 = obj18;
				Dictionary<UpgradeType, Upgrade> upgrades2 = Upgrades.upgrades;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S2_v10+8]");
				Upgrade upgrade2 = upgrades2.get_Item(UpgradeType._notset);
				if ((nint)obj14 >= upgrade2.spawnProbability)
				{
					break;
				}
				object obj20 = _pickupWeightedList + 16;
				object obj21 = 0 << 2;
				object obj22 = obj20 + obj21;
				PogostickStateSettings settings4 = _settings;
				object obj23 = settings4._pickupList + 16;
				object obj24 = obj13 << 2;
				object obj25 = obj23 + obj24;
				object obj26 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v31+C]");
				obj22 = 0;
				object obj27 = obj14 + 1;
				obj14 = obj27;
			}
			object obj28 = obj13 + 1;
			obj13 = obj28;
		}
	}

	private void NotifyHangtime()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (OnStart != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 70)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				return;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void NotifyOnStop()
	{
		if (OnHangtime != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	private void SpawnCoinRows()
	{
		if (OnStop != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	private void SpawnCoinRow(float z, float height)
	{
		//IL_000a: Expected Obj, but got F4
		//IL_0014: Expected I4, but got F4
		_game = (Game)z;
		Id = (int)height;
	}

	private unsafe void SpawnPickup(float endGamePositionZ)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected F4, but got I
		//IL_0447: Expected I, but got Obj
		//IL_045d: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_007a: Expected F4, but got I
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected Obj, but got Unknown
		//IL_0575: Expected Obj, but got I
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected I4, but got Unknown
		//IL_0590: Expected I4, but got Obj
		//IL_00a9: Expected I, but got Obj
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_0240: Expected Obj, but got I
		//IL_0256: Expected Obj, but got I
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_02b0: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I4
		//IL_02f5: Expected Obj, but got I4
		//IL_048a: Expected Obj, but got I
		//IL_049a: Expected Obj, but got I
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected Obj, but got Unknown
		//IL_0303: Expected VT, but got Obj
		//IL_030c: Expected Obj, but got VT
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0327: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_03a9: Expected I4, but got Obj
		//IL_03bf: Expected Obj, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_03d7: Expected Obj, but got I4
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0221: Expected Obj, but got I4
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		((HeadstartState)this).SetFOV();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.PogostickState)+90]");
		float num;
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.PogostickState)+78]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v98+C]");
			num = 0f;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.PogostickState)+90]");
			if ((nint)0 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.PogostickState)+78]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v95+10]");
				num = 0f;
			}
			else
			{
				PogostickStateSettings settings = _settings;
				num = settings._jumpDistance;
			}
		}
		float num2 = num - 5f;
		nint num3 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v15 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v84 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		float num5 = endGamePositionZ;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v9 (System.Boolean)+10]");
		float num6 = num5 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj5 = default;
		object obj4 = obj5 + 12;
		obj4 = 0;
		CallingConvention callingConvention = (CallingConvention)(obj5 + 16);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj4;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		object obj6 = default;
		object obj18 = default;
		while ((nint)obj6 <= 2)
		{
			int num7 = -1;
			while (true)
			{
				object obj7 = unmanagedFunctionPointerAttribute + 16;
				if (num7 != (nint)obj7)
				{
					object obj8 = unmanagedFunctionPointerAttribute + 20;
					if (num7 != (nint)obj8)
					{
						object obj9 = unmanagedFunctionPointerAttribute + 24;
						if (num7 != (nint)obj9)
						{
							break;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.PogostickState)+78]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v58+14]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v59+C]");
				int num8 = UnityEngine.Random.RandomRangeInt(0, 0);
				object obj12 = unmanagedFunctionPointerAttribute + 16;
				if (num8 != (nint)obj12)
				{
					object obj13 = unmanagedFunctionPointerAttribute + 20;
					if (num8 != (nint)obj13)
					{
						object obj14 = unmanagedFunctionPointerAttribute + 24;
						if (num8 != (nint)obj14)
						{
							object obj15 = unmanagedFunctionPointerAttribute + 16;
							object obj16 = obj6 << 2;
							object obj17 = obj15 + obj16;
							obj17 = num8;
							break;
						}
					}
				}
				num7 = num8;
			}
			obj6 = obj18 + 1;
		}
		Route route = null;
		while ((nint)route <= 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.PogostickState)+78]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v38+14]");
			object obj20 = (nint)0 + (nint)16;
			object obj21 = unmanagedFunctionPointerAttribute + 16;
			object obj22 = (object)route << 2;
			object obj23 = obj21 + obj22;
			object obj24 = obj23 << 2;
			object envBaseInfo = obj20 + obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.PogostickState)+88]");
			object obj25 = (nint)0 + (nint)16;
			object obj26 = (object)route << 2;
			object obj27 = obj25 + obj26;
			PickupSpawnPoint component = ((GameObject)obj27).GetComponent<PickupSpawnPoint>();
			((AssetManager)(object)component).CombineEnvironmentBaseModelsAndStore((EnvironmentBaseInfo)envBaseInfo, (Transform)1, (Transform)null, (Transform)1, 1);
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((PickupManager)val).Game_OnGameStarted();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.PogostickState)+88]");
			object obj28 = (nint)0 + (nint)16;
			object obj29 = (object)route << 2;
			object obj30 = obj28 + obj29;
			int layer = ((GameObject)obj30).layer;
			obj5 = 0;
			_ = 0;
			object obj31 = route * 20;
			object obj32 = obj31 + -20;
			obj5 = obj32;
			float num9 = num2 + 10f;
			((CallingConvention*)(int)callingConvention)->value__ = (int)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Vector3 localPosition = ((Transform)callingConvention).localPosition;
			((Route)(object)this).CharacterStartEntryTransition(route, (Route)1);
			Route route2 = (Route)(route + 1);
			route = route2;
		}
	}

	private void SetActiveForPickupPrefabInstance(bool isActive)
	{
		//IL_0014: Expected Obj, but got I4
		_startHandlers.Add((Action)isActive);
	}

	private IEnumerator RemovePickups(float endPosition)
	{
		//IL_001b: Expected Obj, but got F4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		float num = (float)_game + endPosition;
		_game = (Game)num;
		if ((nint)_game >= Id)
		{
			Game game = (Game)(_game - Id);
			_game = game;
			return (IEnumerator)1;
		}
		return null;
	}
}
