using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Characters;
using UnityEngine;

namespace Missions;

public class StayInOneLaneMission
{
	private sealed class _003CCountMissionProgressCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StayInOneLaneMission _003C_003E4__this;

		public int goal;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0133: Expected Obj, but got I4
				//IL_0133: Expected Obj, but got I4
				//IL_0133: Expected Obj, but got I4
				//IL_0093: Expected Obj, but got I4
				//IL_0093: Expected Obj, but got I4
				//IL_0093: Expected Obj, but got I4
				//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Expected Obj, but got Unknown
				//IL_010c: Expected Obj, but got I4
				StayInOneLaneMission stayInOneLaneMission = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					int currentProgress = stayInOneLaneMission._currentProgress + 1;
					stayInOneLaneMission._currentProgress = currentProgress;
					StayInOneLaneMission instance = StayInOneLaneMission.instance;
					((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)61, (PersistentAwardProgress)1, (Action<Award>)(-1));
				}
				else
				{
					_003C_003E1__state = -1;
					stayInOneLaneMission._coroutineIsRunning = true;
				}
				if (stayInOneLaneMission._currentProgress < goal)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 1f;
					object obj = this + 12;
					object obj2 = default;
					obj = obj2;
					_003C_003E1__state = 1;
					return 1;
				}
				StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
				((OwnBoardsAward)(object)instance2)._002Ector((AwardStaticData)61, (PersistentAwardProgress)goal, (Action<Award>)(-1));
				stayInOneLaneMission._coroutineIsRunning = false;
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CCountMissionProgressCoroutine_003Ed__14(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_000a: Expected I4, but got Obj
			return (byte)(int)((IEnumerable)(object)this).GetEnumerator() != 0;
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

	private const int PROGRESS_INCREMENTS = 1;

	private bool _hasInited;

	private Character _character;

	private IEnumerator _countProgressCoroutine;

	private bool _coroutineIsRunning;

	private int _currentProgress;

	private static StayInOneLaneMission _instance;

	public static StayInOneLaneMission instance
	{
		get
		{
			//IL_002b: Expected I, but got Obj
			//IL_0041: Expected Obj, but got I
			bool flag = MissionsManager._instance == null;
			bool flag2 = !flag;
			MissionsManager result = MissionsManager._instance;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				MissionsManager missionsManager = default;
				missionsManager.SetupDefaultMissionSetIfNeeded();
				nint num = (nint)typeof(MissionsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v16 (Il2CppClass<Missions.MissionsManager>)+5C]");
				object obj = (nint)0 + (nint)8;
				obj = missionsManager;
				result = missionsManager;
			}
			return (StayInOneLaneMission)(object)result;
		}
	}

	public void Init()
	{
		//IL_0122: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		int currentProgress = _currentProgress;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Int32)+10]");
		object obj = (nint)0 + (nint)12;
		object obj2 = 0;
		object obj6 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Int32)+10]");
			object obj3 = (nint)0 + (nint)16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v20+14]");
				string type = ((Notification)0).type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.StayInOneLaneMission)+1C]");
				object obj7 = 0;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S4_v4 (Il2CppMethodInfo)+C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S4_v5+60]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S4_v6+48]");
				object obj10 = 0;
				object obj11 = obj10 & 0x7FF;
				object obj12 = obj11 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S5_v2 (should have been resolved before IL gen)");
			}
			object obj13 = obj2 + 1;
			obj2 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.StayInOneLaneMission)+1C]");
		object obj14 = 0;
		_ = 1;
		_ = 0;
	}

	private unsafe void OnRunStarted()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_0337: Expected I, but got Obj
		//IL_034d: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_016c: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_01ad: Expected I, but got Obj
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		if (~(_hasInited ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v71 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 12;
		CharacterRendering characterRendering = CharacterRendering.Instance;
		obj2 = characterRendering;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v59 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_character).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Character.OnChangeTrackDelegate onChangeTrackDelegate = default;
			((Delegate)onChangeTrackDelegate).method_ptr = method_ptr;
			((Delegate)onChangeTrackDelegate).method = (nint)__ldftn(StayInOneLaneMission.OnTrackChanged);
			object obj4 = onChangeTrackDelegate + 16;
			obj4 = this;
			_character.OnChangeTrack -= onChangeTrackDelegate;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<bool> action = default;
		object obj5 = action + 16;
		obj5 = this;
		nint num6 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v30 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v65 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnRunEnded -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(StayInOneLaneMission.OnMenuScreenShown);
		object obj7 = action2 + 16;
		obj7 = this;
		Game.OnMenuScreenShown -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(StayInOneLaneMission.OnRunStarted);
		object obj8 = action3 + 16;
		obj8 = this;
		Game.OnGameStarted -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr4;
		((Delegate)action4).method = (nint)__ldftn(StayInOneLaneMission.OnRevived);
		object obj9 = action4 + 16;
		obj9 = this;
		Game.OnGameRevived -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		MissionsManager.MissionSetCompleteHandler missionSetCompleteHandler = default;
		((Delegate)missionSetCompleteHandler).method_ptr = method_ptr5;
		((Delegate)missionSetCompleteHandler).method = (nint)__ldftn(StayInOneLaneMission.OnMissionSetCompleted);
		object obj10 = missionSetCompleteHandler + 16;
		obj10 = this;
		MissionsManager.onMissionSetComplete -= missionSetCompleteHandler;
		this._002Ector();
		_hasInited = true;
	}

	private void OnRunEnded(bool playerWasAutoRevived)
	{
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S1_v2 (System.String)+74]");
		_ = 0;
	}

	private void OnRevived()
	{
		this._002Ector();
	}

	private void OnMenuScreenShown()
	{
		this._002Ector();
	}

	private unsafe void OnTrackChanged(Character.OnChangeTrackDirection direction)
	{
		//IL_0009: Expected native int or pointer, but got VT
		//IL_0030: Expected Obj, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0084: Expected native int or pointer, but got VT
		//IL_0098: Expected VT, but got I4
		Quaternion quaternion = default;
		((Quaternion*)(nint)quaternion)->x = 0f;
		bool coroutineIsRunning = _coroutineIsRunning;
		object obj = direction ^ Character.OnChangeTrackDirection.Right;
		object obj2 = coroutineIsRunning & obj;
		if (obj2 != null)
		{
			CoroutineUtil.StopCoroutine((Coroutine)(object)_countProgressCoroutine);
			_coroutineIsRunning = false;
			_currentProgress = 0;
			((Quaternion*)(nint)quaternion)->x = 0f;
			GameObject gameObject = InstanceHandler.InstantiatePrefab(null, (Vector3)75, quaternion);
			if ((object)gameObject != null)
			{
				StayInOneLaneMission stayInOneLaneMission = instance;
				((MissionsManager)(object)stayInOneLaneMission).ResetProgressForMissionIndex(61);
			}
		}
	}

	private void OnMissionSetCompleted()
	{
		if (~(_coroutineIsRunning ? 1u : 0u) == 0)
		{
			OnTrackChanged(Character.OnChangeTrackDirection.Left);
		}
	}

	private void StartCountingProgressIfNeeded()
	{
		//IL_0146: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I
		//IL_01fa: Expected I, but got Obj
		//IL_0210: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)isInstantiated).FindKernel(null) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v24 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated2 = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v20 (System.Boolean)+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v21+8]");
		if ((nint)0 != 0)
		{
			this._002Ector();
		}
	}

	private IEnumerator CountMissionProgressCoroutine(int goal)
	{
		//IL_00c2: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.StayInOneLaneMission)+1C]");
		object obj = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 > -1)
		{
			bool hasInited = _hasInited;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v13 (System.Boolean)+21]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.StayInOneLaneMission)+2C]");
				if ((nint)0 != 0)
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.StayInOneLaneMission)+1C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21+24]");
				int num2 = ((Dictionary<Stat, int>)0).get_Item((Stat)goal);
				return (IEnumerator)num2;
			}
			return null;
		}
		return null;
	}

	private bool IsMissionActive(MissionType missionType, out int goal)
	{
		//IL_002a: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_015b: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got I4
		//IL_00fe: Expected I4, but got Obj
		//IL_0087: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [goal @ L2 (System.Int32&)+20]");
		object obj;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [goal @ L2 (System.Int32&)+10]");
			obj = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [goal @ L2 (System.Int32&)+1C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v46+18]");
			obj = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [missionType @ L1 (MissionType)+20]");
		object obj3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [missionType @ L1 (MissionType)+10]");
			obj3 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [missionType @ L1 (MissionType)+1C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v41+18]");
			obj3 = 0;
		}
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v15 (Il2CppClass<System.DateTime>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v36 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = default;
		object obj6 = obj7 + 8;
		obj6 = obj;
		obj7 = obj3;
		object obj8 = obj7 + 16;
		obj8 = obj6;
		object obj9 = obj7 + 24;
		obj9 = obj7;
		object obj10 = obj8 & 0x3FFFFFFFFFFFFFFFL;
		object obj11 = obj9 & 0x3FFFFFFFFFFFFFFFL;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
		{
			return true;
		}
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
		object obj12 = (flag ? 1u : 0u) << 31;
		return (byte)(obj12 >> 31) != 0;
	}

	public unsafe StayInOneLaneMission()
	{
		//IL_0009: Expected native int or pointer, but got VT
		//IL_001d: Expected VT, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0063: Expected Obj, but got F4
		//IL_0074: Expected Obj, but got I4
		Quaternion quaternion = default;
		((Quaternion*)(nint)quaternion)->x = 0f;
		GameObject gameObject = InstanceHandler.InstantiatePrefab(null, (Vector3)75, quaternion);
		if ((object)gameObject != null)
		{
			CoroutineUtil.StopCoroutine((Coroutine)(object)_countProgressCoroutine);
			object obj = this + 16;
			int progressForGoal = ((SupersneakersTimeInRowAward)this).GetProgressForGoal((AwardGoal)quaternion.x);
			obj = progressForGoal;
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)_countProgressCoroutine);
		}
	}
}
