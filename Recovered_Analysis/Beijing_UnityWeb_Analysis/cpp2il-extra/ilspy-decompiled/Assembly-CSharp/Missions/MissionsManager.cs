using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AppRefresh;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using Info;
using Kiloo;
using Kiloo.Common.Ads;
using Kiloo.Common.Utility;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Characters;
using SYBO.Subway.Info;
using UI.Pages.MissionsPageInternal;
using UnityEngine;

namespace Missions;

public class MissionsManager
{
	public enum VideoButtonTrackingState
	{
		NotSet,
		Fill,
		NoFill,
		Cooldown,
		AlreadyUsedForSet
	}

	public delegate void MissionSetCompleteHandler();

	public delegate void MissionCompleteHandler(string msg, int missionIndex);

	public delegate void MissionProgressHandler(int missionIndex, float progressFactor);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<UpgradeType, int>, int> _003C_003E9__37_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AwardsManager._003C_003Ec obj = default;
			AwardsManager._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_0380: Expected Obj, but got I
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_038e: Expected Obj, but got Unknown
			//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Expected Obj, but got Unknown
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_0190: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_0257: Expected Obj, but got I
			//IL_02b7: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.MissionsManager+<>c)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.MissionsManager+<>c)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.MissionsManager+<>c)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj23 = default;
			object obj20 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FFF;
						object obj16 = obj15 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj17 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj18 = (nint)0 & (nint)0x100;
						flag2 = obj18 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.MissionsManager+<>c)+C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
							object obj19 = (nint)0 & (nint)3;
							bool flag3 = (nint)obj19 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag3)
							{
								if (obj20 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
								}
							}
							else if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
							}
							continue;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj21 = (nint)0 & (nint)0x3FFF;
				object obj22 = obj21 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
		}

		internal int _003CSyncAchievements_003Eb__37_0(KeyValuePair<UpgradeType, int> x)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [x @ L1 (System.Collections.Generic.KeyValuePair`2<Info.UpgradeType, System.Int32>)+14]");
			return 0;
		}
	}

	private int _currentMissionTemplateSetLoaded;

	private MissionTemplate[] _templates;

	private const int MISSION_COUNT_IN_SET = 3;

	private const string OS_SKIP_WITH_VIDEO_COOLDOWN_VALUE_KEY = "mission_skip_with_video_cooldown_seconds";

	private int _defaultSkipWithVideoCooldownSeconds;

	private int _defaultMissionIndexUpdateInterval;

	private const string OS_MISSION_INDEX_UPDATE_INTERVAL = "mission_skip_with_video_index_update_interval_seconds";

	private VideoButtonTrackingState videoButtonState__BackingField;

	public Action<bool, int> OnMissionSkipped;

	private int[] _currentRunProgress;

	private int _currentMissionSetLoaded;

	private Mission[] _combinedArray;

	private static MissionSetCompleteHandler m_onMissionSetComplete;

	private static MissionCompleteHandler m_onMissionComplete;

	public MissionProgressHandler onMissionProgressed;

	private Mission[][] _missions;

	private static MissionsManager _instance;

	public VideoButtonTrackingState videoButtonState
	{
		get
		{
			//IL_000e: Expected I4, but got Obj
			//IL_0020: Expected I, but got Obj
			//IL_0036: Expected Obj, but got I
			//IL_0061: Expected I, but got Obj
			//IL_0146: Expected Obj, but got I4
			//IL_0155: Expected I4, but got Obj
			//IL_00dd: Expected I4, but got Obj
			StayInOneLaneMission instance = StayInOneLaneMission.instance;
			int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
			StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
			AdLocationInfo currentLocationInfo = GetCurrentLocationInfo((byte)(int)instance2 != 0);
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v19 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = ((currentSkipForVideoMissionIndex >= 0) ? ((currentSkipForVideoMissionIndex <= (nint)currentLocationInfo) ? currentSkipForVideoMissionIndex : ((int)currentLocationInfo)) : 0);
			object obj2 = num3 * _defaultSkipWithVideoCooldownSeconds;
			return (VideoButtonTrackingState)(obj2 + (object)_templates);
		}
		private set
		{
			_defaultSkipWithVideoCooldownSeconds = (int)value;
		}
	}

	private MissionTemplate[] templates
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (MissionTemplate[])videoButtonState__BackingField;
		}
	}

	public bool inRun
	{
		get
		{
			//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Expected Obj, but got Unknown
			//IL_0037: Expected I, but got Obj
			//IL_004d: Expected Obj, but got I
			//IL_03ae: Expected Obj, but got I4
			//IL_0078: Expected I, but got Obj
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected Obj, but got Unknown
			//IL_031b: Expected I4, but got Obj
			//IL_00f1: Expected Obj, but got I4
			//IL_020a: Expected Obj, but got I4
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected Obj, but got Unknown
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected Obj, but got Unknown
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected Obj, but got Unknown
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Expected Obj, but got Unknown
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Expected Obj, but got Unknown
			//IL_0228: Expected Obj, but got I4
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Expected Obj, but got Unknown
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Expected Obj, but got Unknown
			//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cf: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 24;
			int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
			if (_currentMissionTemplateSetLoaded != currentSkipForVideoMissionIndex || _templates == null)
			{
				nint num = (nint)typeof(MissionsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v18 (Il2CppClass<Missions.MissionsData>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(MissionsData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v60 (Il2CppClass<Missions.MissionsData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (_templates == null)
				{
					object obj4 = this + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					object obj5 = default;
					obj4 = obj5;
				}
				object obj6 = 0;
				while ((nint)obj6 <= 2)
				{
					int numberOfBasicMission = GetNumberOfBasicMission();
					object obj7 = numberOfBasicMission + 16;
					int currentSkipForVideoMissionIndex2 = PlayerSave.currentSkipForVideoMissionIndex;
					int num3 = currentSkipForVideoMissionIndex2 << 2;
					object obj8 = obj7 + num3;
					object obj9 = obj8 + 16;
					object obj10 = obj6 << 3;
					object obj11 = obj9 + obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A42B");
					obj = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
					_ = 0;
					object obj12 = _templates + 16;
					object obj13 = obj6 * 24;
					object obj14 = obj12 + obj13;
					obj14 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
					_ = 0;
					object obj15 = obj6 + 1;
					obj6 = obj15;
				}
				if (_currentMissionTemplateSetLoaded == -1)
				{
					object obj16 = 0;
					while ((nint)obj16 <= 40)
					{
						CollectCoinsDummy[] defaultDummyList = CollectCoinsDummyData.GetDefaultDummyList();
						object obj17 = defaultDummyList.Length + 16;
						object obj18 = obj16 << 3;
						object obj19 = obj17 + obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A42B");
						obj = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
						_ = 0;
						object obj20 = obj16 * 24;
						object obj21 = (object)_templates + obj20;
						object obj22 = obj21 + 88;
						obj22 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
						_ = 0;
						object obj23 = obj16 + 1;
						obj16 = obj23;
					}
				}
				int currentSkipForVideoMissionIndex3 = PlayerSave.currentSkipForVideoMissionIndex;
				_currentMissionTemplateSetLoaded = currentSkipForVideoMissionIndex3;
			}
			return (byte)(int)_templates != 0;
		}
		set
		{
			videoButtonState__BackingField = (value ? VideoButtonTrackingState.Fill : VideoButtonTrackingState.NotSet);
		}
	}

	private Mission[] combinedArray
	{
		get
		{
			//IL_013b: Expected I, but got Obj
			//IL_0151: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0186: Expected I, but got Obj
			//IL_019c: Expected Obj, but got I
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected Obj, but got Unknown
			//IL_01cf: Expected Obj, but got VT
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected Obj, but got Unknown
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Expected Obj, but got Unknown
			//IL_0204: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Expected Obj, but got Unknown
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Expected Obj, but got Unknown
			//IL_0242: Expected Obj, but got VT
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Expected Obj, but got Unknown
			//IL_0271: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Expected Obj, but got Unknown
			//IL_028c: Expected Obj, but got I4
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v47 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			uint value = ((OnlineSettings)(object)saveDataPath).GetValue("mission_skip_with_video_index_update_interval_seconds", (uint)_defaultMissionIndexUpdateInterval);
			DateTime lastTimeMissionWasSkippedForVideo = PlayerSave.lastTimeMissionWasSkippedForVideo;
			nint num3 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v9 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v38 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
			nint num5 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v18 (Il2CppClass<System.DateTime>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v43 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = default;
			object obj4 = obj5 + 24;
			obj4 = lastTimeMissionWasSkippedForVideo;
			object obj6 = obj5 + 16;
			object obj7 = default;
			obj6 = obj7;
			object obj8 = obj5 + 32;
			obj8 = obj4;
			object obj9 = obj5 + 40;
			obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
			DateTime today = CDateTime.Today;
			object obj10 = obj5 + 8;
			object obj11 = default;
			obj10 = obj11;
			obj5 = today;
			obj8 = obj10;
			obj9 = obj5;
			object obj12 = obj8 & 0x3FFFFFFFFFFFFFFFL;
			object obj13 = obj9 & 0x3FFFFFFFFFFFFFFFL;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
			return (Mission[])flag;
		}
	}

	public int currentMissionSet
	{
		get
		{
			//IL_0013: Expected Obj, but got I4
			//IL_0021: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Stat stat = Stat.NotSet;
			int num = default;
			while (stat <= Stat.Goldbar)
			{
				object obj = num + 16;
				object obj2 = (int)stat * 40;
				int newValue = (int)(obj + obj2);
				((StatAward)this).OnStatChanged(stat, newValue);
				Stat stat2 = stat + 1;
				stat = stat2;
			}
			return num;
		}
		set
		{
			//IL_000e: Expected Obj, but got I4
			//IL_0034: Invalid comparison between I and F4
			object obj = value + 248;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if (0f < 1f)
			{
				ResetProgressForMissionIndex(74);
			}
		}
	}

	private Mission[][] missions
	{
		get
		{
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Expected Obj, but got Unknown
			//IL_020c: Expected Obj, but got I4
			//IL_0245: Expected Obj, but got I4
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected Obj, but got Unknown
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected Obj, but got Unknown
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Expected Obj, but got Unknown
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Expected Obj, but got Unknown
			//IL_0057: Expected I, but got Obj
			//IL_006d: Expected Obj, but got I
			//IL_02b1: Expected Obj, but got I
			//IL_00ef: Expected Obj, but got I4
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected Obj, but got Unknown
			//IL_0098: Expected I, but got Obj
			//IL_0170: Expected I, but got Obj
			//IL_0186: Expected Obj, but got I
			//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Expected Obj, but got Unknown
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Expected Obj, but got Unknown
			//IL_01b1: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 48;
			obj = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
			object obj3 = currentSkipForVideoMissionIndex + 1;
			int numberOfBasicMission = GetNumberOfBasicMission();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12 (System.Int32)+C]");
			bool flag = (nint)obj3 >= 0;
			bool flag2 = !flag;
			object obj4 = obj3;
			if (!flag2)
			{
				int numberOfBasicMission2 = GetNumberOfBasicMission();
				nint num = (nint)typeof(MissionsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v67 (Il2CppClass<Missions.MissionsData>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num2 = (nint)typeof(MissionsData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v75 (Il2CppClass<Missions.MissionsData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Mission[][] repeatableMissions = MissionsData.repeatableMissions;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v76 (System.Int32)+C]");
				object obj6 = -repeatableMissions.Length;
				obj4 = obj6;
			}
			object obj7 = obj2 + 88;
			object obj8 = obj2 + 8;
			object obj9 = obj2 + 16;
			object obj10 = obj2 + 24;
			object obj11 = default;
			object obj20 = default;
			while ((nint)obj11 <= 2)
			{
				int numberOfBasicMission3 = GetNumberOfBasicMission();
				object obj12 = numberOfBasicMission3 + 16;
				object obj13 = obj4 << 2;
				object obj14 = obj12 + obj13;
				object obj15 = obj14 + 16;
				object obj16 = obj11 << 3;
				object obj17 = obj15 + obj16;
				obj8 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				obj9 = obj8;
				obj7 = obj9;
				obj = obj7;
				nint num3 = (nint)typeof(MissionsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v43 (Il2CppClass<Missions.MissionsData>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num4 = (nint)typeof(MissionsData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v69 (Il2CppClass<Missions.MissionsData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A42B");
				obj7 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v29+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v29+10]");
				_ = 0;
				object obj19 = obj + 8;
				obj19 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v23+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v23+10]");
				_ = 0;
				_ = 0;
				_ = 0;
				obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A45C");
				obj11 = obj20 + 1;
			}
			Mission[][] result = default;
			return result;
		}
	}

	public int missionSetCount
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Missions.MissionsData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(MissionsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Missions.MissionsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Mission[][] storylineMissions = MissionsData.storylineMissions;
			return storylineMissions.Length;
		}
	}

	public int missionSetStoryCount
	{
		get
		{
			int numberOfBasicMission = GetNumberOfBasicMission();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+C]");
			return 0;
		}
	}

	public static MissionsManager Instance
	{
		get
		{
			//IL_0153: Expected I, but got Obj
			//IL_0169: Expected Obj, but got I
			//IL_01d1: Expected I, but got Obj
			//IL_01e7: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0106: Expected I, but got Obj
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_00b9: Expected I, but got Obj
			nint num = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Missions.AwardsManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AwardsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<Missions.AwardsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (AwardsManager._instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				AwardsManager awardsManager = default;
				awardsManager.UpdateTheNewStatusForTheAwardsOnCleanInstall();
				nint num3 = (nint)typeof(AwardsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33 (Il2CppClass<Missions.AwardsManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(AwardsManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v39 (Il2CppClass<Missions.AwardsManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				AwardsManager._instance = awardsManager;
			}
			nint num5 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<Missions.AwardsManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(AwardsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<Missions.AwardsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (MissionsManager)(object)AwardsManager._instance;
		}
	}

	public static event MissionSetCompleteHandler onMissionSetComplete
	{
		add
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_067d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0682: Expected I, but got Unknown
			//IL_0694: Unknown result type (might be due to invalid IL or missing references)
			//IL_0699: Expected Obj, but got Unknown
			//IL_06a2: Expected Obj, but got I4
			//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bc: Expected Obj, but got Unknown
			//IL_06c5: Expected Obj, but got I4
			//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d3: Expected Obj, but got Unknown
			//IL_06f8: Expected Obj, but got I4
			//IL_0021: Expected I, but got Obj
			//IL_0037: Expected Obj, but got I
			//IL_0933: Expected Obj, but got I4
			//IL_0945: Expected Obj, but got I4
			//IL_0062: Expected I, but got Obj
			//IL_013d: Expected I4, but got Obj
			//IL_013d: Expected Obj, but got I4
			//IL_014f: Expected I, but got Obj
			//IL_0165: Expected Obj, but got I
			//IL_00af: Expected I, but got Obj
			//IL_00c5: Expected Obj, but got I
			//IL_07b6: Expected Obj, but got I4
			//IL_07d0: Expected Obj, but got I
			//IL_075d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0762: Expected Obj, but got Unknown
			//IL_0779: Expected I, but got Obj
			//IL_078f: Expected Obj, but got I
			//IL_0190: Expected I, but got Obj
			//IL_00f0: Expected I, but got Obj
			//IL_0965: Expected Obj, but got I4
			//IL_0800: Expected I, but got Obj
			//IL_0816: Expected Obj, but got I
			//IL_0356: Expected I, but got Obj
			//IL_026d: Expected Obj, but got I4
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Expected Obj, but got Unknown
			//IL_0524: Unknown result type (might be due to invalid IL or missing references)
			//IL_0529: Expected Obj, but got Unknown
			//IL_0532: Unknown result type (might be due to invalid IL or missing references)
			//IL_0537: Expected Obj, but got Unknown
			//IL_0563: Expected Obj, but got I4
			//IL_02c8: Expected I, but got Obj
			//IL_02de: Expected Obj, but got I
			//IL_085b: Expected Obj, but got I
			//IL_0871: Unknown result type (might be due to invalid IL or missing references)
			//IL_0876: Expected Obj, but got Unknown
			//IL_0888: Expected Obj, but got I4
			//IL_0309: Expected I, but got Obj
			//IL_05ca: Expected Obj, but got I
			//IL_0600: Unknown result type (might be due to invalid IL or missing references)
			//IL_0605: Expected Obj, but got Unknown
			//IL_0636: Unknown result type (might be due to invalid IL or missing references)
			//IL_063b: Expected Obj, but got Unknown
			//IL_0429: Expected I, but got Obj
			//IL_043f: Expected Obj, but got I
			//IL_046a: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 80;
			nint num = (nint)(obj2 - -64);
			num = 0;
			object obj3 = obj2 + 40;
			obj3 = 0;
			_ = 0;
			_ = 0;
			object obj4 = obj2 + 24;
			obj4 = 0;
			object obj5 = obj2 + 32;
			obj5 = obj;
			_ = -1;
			int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
			MissionInfo missionInfo = ((MissionsManager)39).GetMissionInfo(currentSkipForVideoMissionIndex);
			bool allowSellHeadstartDuringRun = OnboardingSave.allowSellHeadstartDuringRun;
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v26 (Il2CppClass<Missions.MissionsManager+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num3 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v218 (Il2CppClass<Missions.MissionsManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = _003C_003Ec._003C_003E9__37_0 == null;
			bool flag2 = !flag;
			Func<KeyValuePair<UpgradeType, int>, int> selector = _003C_003Ec._003C_003E9__37_0;
			if (!flag2)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v192 (Il2CppClass<Missions.MissionsManager+<>c>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num5 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v212 (Il2CppClass<Missions.MissionsManager+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num6 = 0;
				_ = 0;
				Func<KeyValuePair<UpgradeType, int>, int> func = default;
				object obj8 = func + 16;
				obj8 = _003C_003Ec._003C_003E9;
				nint num7 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v209 (Il2CppClass<Missions.MissionsManager+<>c>)+5C]");
				object obj9 = (nint)0 + (nint)4;
				obj9 = func;
				selector = func;
			}
			int missionNumber = Enumerable.Sum((IEnumerable<KeyValuePair<UpgradeType, int>>)allowSellHeadstartDuringRun, selector);
			MissionInfo missionInfo2 = ((MissionsManager)41).GetMissionInfo(missionNumber);
			Dictionary<AwardId, PersistentAwardProgress> awardsProgress = PlayerSave.awardsProgress;
			MissionInfo missionInfo3 = ((MissionsManager)37).GetMissionInfo((int)awardsProgress);
			nint num8 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v38 (Il2CppClass<SocialManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num9 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v187 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
			bool flag3 = ((SocialManager)facebookDialogsSupported).HasFacebookAccessToken();
			num = (flag3 ? 1 : 0);
			object obj11 = num & 0xFF;
			int missionNumber2 = ((obj11 != null) ? ((num != 0) ? 1 : (-1)) : 0);
			MissionInfo missionInfo4 = ((MissionsManager)55).GetMissionInfo(missionNumber2);
			CollectCoinsDummy[] defaultDummyList = CollectCoinsDummyData.GetDefaultDummyList();
			int num10 = ((GameStats)(object)defaultDummyList).ConsumeAmountNeededToAdjustScoreBy(52);
			if (num10 >= 0)
			{
				int tier = InventorySave.GetTier(UpgradeType.headstart2000);
				CollectCoinsDummy[] defaultDummyList2 = CollectCoinsDummyData.GetDefaultDummyList();
				object obj12 = defaultDummyList2.Length + 16;
				int num11 = num10 << 3;
				object obj13 = obj12 + num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v100+4]");
				if ((nint)tier >= (nint)0)
				{
					nint num12 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v177 (Il2CppClass<SocialManager>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num13 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v183 (Il2CppClass<SocialManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
					CollectCoinsDummy[] defaultDummyList3 = CollectCoinsDummyData.GetDefaultDummyList();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S1_v104 (CollectCoinsDummy[])+8]");
					object obj15 = (nint)0 + (nint)16;
					int num14 = num10 << 2;
					object camera = obj15 + num14;
					((UIScreenController)facebookDialogsSupported2).SetViewportRectXForCamera((Camera)camera, 100f);
				}
			}
			nint num15 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v50 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num16 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v167 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj17 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj17 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S0_v119+20]");
				if ((nint)0 == 0)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num17 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ S0_v143 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num18 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S0_v160 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			object obj19 = obj5 + 4;
			object obj20 = obj19 + 1;
			obj19 = obj20;
			object obj21 = obj20 << 2;
			object obj22 = obj5 + obj21;
			obj22 = 265;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
				object obj23 = (nint)0 << 2;
				object obj24 = obj5 + obj23;
				if ((nint)obj24 == 265)
				{
					object obj25 = obj5 + 4;
					if ((nint)obj25 > -1)
					{
						object obj26 = obj25 + -1;
						obj25 = obj26;
					}
					return;
				}
			}
			object obj27 = default;
			if (obj27 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		remove
		{
			Delegate obj = MissionsManager.m_onMissionSetComplete;
			MissionSetCompleteHandler missionSetCompleteHandler = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)MissionsManager.m_onMissionSetComplete == obj)
				{
					MissionsManager.m_onMissionSetComplete = missionSetCompleteHandler;
				}
				if ((object)MissionsManager.m_onMissionSetComplete != obj)
				{
					obj = MissionsManager.m_onMissionSetComplete;
					continue;
				}
				break;
			}
		}
	}

	public static event MissionCompleteHandler onMissionComplete
	{
		add
		{
			Delegate obj = MissionsManager.m_onMissionSetComplete;
			MissionSetCompleteHandler missionSetCompleteHandler = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)MissionsManager.m_onMissionSetComplete == obj)
				{
					MissionsManager.m_onMissionSetComplete = missionSetCompleteHandler;
				}
				if ((object)MissionsManager.m_onMissionSetComplete != obj)
				{
					obj = MissionsManager.m_onMissionSetComplete;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = MissionsManager.m_onMissionComplete;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(MissionsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<Missions.MissionsManager>)+5C]");
				object obj3 = (nint)0 + (nint)4;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public void InitCurrentMissionSet(int missionSet, int missionCount, bool resetProgress)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I4
		object obj = this + 8;
		obj = missionSet;
		_templates = (MissionTemplate[])missionCount;
		_defaultSkipWithVideoCooldownSeconds = (resetProgress ? 1 : 0);
	}

	private void DetermineNewSkipForVideoMissionIndex()
	{
		((Award)this).RewardPayedOut();
	}

	public bool CanThisMissionSkipWithVideo(MissionCell.MissionCellPayload payload)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v6+8]");
			object obj2 = default;
			if ((nint)obj2 >= 0)
			{
				return true;
			}
		}
		return false;
	}

	private bool MissionIndexNeedsUpdating()
	{
		return _currentRunProgress != null;
	}

	private unsafe void LogMissionSetRuns()
	{
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got VT
		//IL_001d: Expected I4, but got Obj
		//IL_004f: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I
		object obj = default;
		MissionsManager missionsManager = (MissionsManager)(obj + 8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<int> list = default;
		list._002Ector();
		bool hasSkippedMissionForVideoThisSet = PlayerSave.hasSkippedMissionForVideoThisSet;
		for (ref MissionInfo reference = ref *(MissionInfo*)null; (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) <= (nint)2; reference = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 1))
		{
			missionsManager.GetMissionInfo((int)this, ref reference);
			bool flag = (void*)(hasSkippedMissionForVideoThisSet ? 1 : 0) == System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			bool flag2 = missionsManager._currentMissionSetLoaded != 0;
			object obj2 = flag | flag2;
			if (obj2 == null)
			{
				list.Add((int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (System.Collections.Generic.List`1<System.Int32>)+C]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (System.Collections.Generic.List`1<System.Int32>)+C]");
			bool boolean = ((ObfuscatedMemory)null).GetBoolean((string)0);
			int num = list.get_Item(boolean ? 1 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @929D");
		}
		DateTime today = CDateTime.Today;
		obj = today;
		missionsManager = (MissionsManager)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @929F");
	}

	public void SkipMission(int missionNumber, bool skippedWithVideo)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ S0_v2 (Missions.StayInOneLaneMission)+20]");
		if ((nint)0 != 0)
		{
			MissionProgressHandler missionProgressHandler = (MissionProgressHandler)(onMissionProgressed + 1);
			onMissionProgressed = missionProgressHandler;
			((Award)this).RewardPayedOut();
		}
	}

	private unsafe void Complete(int index, float completedFactor = 1f, bool sendEvenIfInRun = false)
	{
		//IL_0b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Expected Obj, but got Unknown
		//IL_0b6f: Expected Obj, but got I4
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected Obj, but got Unknown
		//IL_0b8c: Expected Obj, but got I4
		//IL_0b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba0: Expected Obj, but got Unknown
		//IL_0ba9: Expected Obj, but got I4
		//IL_0bbd: Expected I, but got Obj
		//IL_0bd3: Expected Obj, but got I
		//IL_0e8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e94: Expected VT, but got Unknown
		//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea2: Expected Obj, but got Unknown
		//IL_0eab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb0: Expected Obj, but got Unknown
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebe: Expected Obj, but got Unknown
		//IL_0ecd: Expected Obj, but got I4
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00e0: Expected I, but got Obj
		//IL_0352: Expected I, but got Obj
		//IL_0368: Expected Obj, but got I
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_0c52: Expected I, but got Obj
		//IL_0c68: Expected Obj, but got I
		//IL_0393: Expected I, but got Obj
		//IL_0466: Expected I, but got Obj
		//IL_047c: Expected Obj, but got I
		//IL_0f16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1b: Expected Obj, but got Unknown
		//IL_0f34: Expected F4, but got I4
		//IL_0f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f46: Expected Obj, but got Unknown
		//IL_0f65: Expected Obj, but got I4
		//IL_016e: Expected I, but got Obj
		//IL_023e: Expected I, but got Obj
		//IL_0254: Expected Obj, but got I
		//IL_01bb: Expected I, but got Obj
		//IL_04a7: Expected I, but got Obj
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got F4
		//IL_0415: Expected F4, but got Obj
		//IL_0410: Expected native int or pointer, but got VT
		//IL_042a: Expected F4, but got I
		//IL_0425: Expected native int or pointer, but got VT
		//IL_04f4: Expected I, but got Obj
		//IL_050a: Expected Obj, but got I
		//IL_027f: Expected I, but got Obj
		//IL_0535: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got F4
		//IL_0301: Expected F4, but got Obj
		//IL_02fc: Expected native int or pointer, but got VT
		//IL_0316: Expected F4, but got I
		//IL_0311: Expected native int or pointer, but got VT
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_060d: Expected Obj, but got I4
		//IL_05c7: Expected Obj, but got I4
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected Obj, but got Unknown
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got Unknown
		//IL_062e: Expected I, but got Obj
		//IL_0644: Expected Obj, but got I
		//IL_05ed: Expected Obj, but got I4
		//IL_0e0d: Expected Obj, but got I4
		//IL_0e16: Expected Obj, but got I4
		//IL_066f: Expected I, but got Obj
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected Obj, but got Unknown
		//IL_0737: Expected I, but got Obj
		//IL_074d: Expected Obj, but got I
		//IL_07cf: Expected Obj, but got I4
		//IL_0778: Expected I, but got Obj
		//IL_0b14: Expected F4, but got Obj
		//IL_0b0f: Expected native int or pointer, but got VT
		//IL_0b29: Expected F4, but got I
		//IL_0b24: Expected native int or pointer, but got VT
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e79: Expected Obj, but got Unknown
		//IL_0a32: Expected F4, but got Obj
		//IL_0a2d: Expected native int or pointer, but got VT
		//IL_0a47: Expected F4, but got I
		//IL_0a42: Expected native int or pointer, but got VT
		//IL_0aaa: Expected F4, but got Obj
		//IL_0aa5: Expected native int or pointer, but got VT
		//IL_0abf: Expected F4, but got I
		//IL_0aba: Expected native int or pointer, but got VT
		//IL_087c: Expected F4, but got Obj
		//IL_0877: Expected native int or pointer, but got VT
		//IL_0891: Expected F4, but got I
		//IL_088c: Expected native int or pointer, but got VT
		//IL_08e6: Expected F4, but got Obj
		//IL_08e1: Expected native int or pointer, but got VT
		//IL_08fb: Expected F4, but got I
		//IL_08f6: Expected native int or pointer, but got VT
		//IL_0950: Expected F4, but got Obj
		//IL_094b: Expected native int or pointer, but got VT
		//IL_0965: Expected F4, but got I
		//IL_0960: Expected native int or pointer, but got VT
		//IL_09c8: Expected F4, but got Obj
		//IL_09c3: Expected native int or pointer, but got VT
		//IL_09dd: Expected F4, but got I
		//IL_09d8: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 72;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 60;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 48;
		obj4 = 0;
		_ = 0;
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<NGUIText>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v337 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 84);
		object obj6 = obj2 + 36;
		object obj7 = obj2 + 24;
		object obj8 = obj2 + 12;
		object obj9 = NGUIText.alignment - 2;
		int num10 = default;
		if (NGUIText.alignment != NGUIText.Alignment.Center)
		{
			if ((nint)obj9 != 1)
			{
				if ((nint)obj9 != 2)
				{
					return;
				}
				nint num3 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v155 (Il2CppClass<NGUIText>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num4 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v331 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num5 = (float)NGUIText.rectWidth * 0.65f;
				if (num5 > completedFactor)
				{
					return;
				}
				nint num6 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v166 (Il2CppClass<NGUIText>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num7 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v325 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num8 = (float)NGUIText.rectWidth - completedFactor;
				float num9 = num8 * 0.5f;
				if (num9 < 1f)
				{
					return;
				}
				object obj12 = _templates - num10;
				object obj14;
				if (sendEvenIfInRun)
				{
					bool flag = (nint)obj12 == int.MinValue;
					bool flag2 = (sendEvenIfInRun ? 1 : 0) == -1;
					object obj13 = flag & flag2;
					obj14 = ((obj13 == null) ? ((object)(obj12 / sendEvenIfInRun)) : ((object)0));
				}
				else
				{
					obj14 = 0;
				}
				if ((nint)obj14 <= 0)
				{
					return;
				}
				object obj15 = obj14 - 1;
				nint num11 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S0_v188 (Il2CppClass<NGUIText>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num12 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S0_v311 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num13 = 1f / (float)obj15;
				float num14 = (float)NGUIText.rectWidth / completedFactor;
				int num15 = (sendEvenIfInRun ? 1 : 0) + num10;
				object obj17 = (sendEvenIfInRun ? 1 : 0) / 2;
				object obj18 = 1;
				int num16 = num15;
				object obj22 = default;
				object obj23 = default;
				while (num16 < (nint)_templates)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
					object obj19 = obj17 + num16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
					float num17 = (float)obj6 - vector.x;
					float num18 = vector.x * num14;
					float num19 = (float)obj6 * num14;
					float b = num19 - num17;
					float t = (float)obj18 * num13;
					nint num20 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S0_v225 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj20 = (nint)0 & (nint)0x200;
					if (obj20 != null)
					{
						nint num21 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ S0_v307 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float a = num18 + num17;
					float num22 = Mathf.LerpUnclamped(a, num19, t);
					float num23 = Mathf.LerpUnclamped(num18, b, t);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
					object obj21 = (sendEvenIfInRun ? 1 : 0) - 1;
					if (!sendEvenIfInRun)
					{
						if ((nint)obj21 != 1)
						{
							if ((nint)obj21 != 2 && (nint)obj21 == 3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
								obj4 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v25+8]");
								_ = 0;
								obj4 = obj22;
								((Vector3*)(nint)vector)->x = (float)obj4;
								Vector3 vector2 = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
								((Vector3*)(nint)vector2)->z = 0f;
								((List<Vector3>)this).set_Item(num16, vector);
								int num24 = num16 + 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
								obj4 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27+8]");
								_ = 0;
								obj4 = obj22;
								((Vector3*)(nint)vector)->x = (float)obj4;
								Vector3 vector3 = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
								((Vector3*)(nint)vector3)->z = 0f;
								((List<Vector3>)this).set_Item(num24, vector);
								int num25 = num24 + 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
								obj4 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v29+8]");
								_ = 0;
								obj4 = obj23;
								((Vector3*)(nint)vector)->x = (float)obj4;
								Vector3 vector4 = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
								((Vector3*)(nint)vector4)->z = 0f;
								((List<Vector3>)this).set_Item(num25, vector);
								int num26 = num25 + 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
								obj4 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
								_ = 0;
								obj4 = obj23;
								int num27 = num26 + 1;
								((Vector3*)(nint)vector)->x = (float)obj4;
								Vector3 vector5 = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
								((Vector3*)(nint)vector5)->z = 0f;
								((List<Vector3>)this).set_Item(num26, vector);
								num16 = num27;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
							obj4 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v25+8]");
							_ = 0;
							obj4 = obj22;
							((Vector3*)(nint)vector)->x = (float)obj4;
							Vector3 vector6 = vector;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
							((Vector3*)(nint)vector6)->z = 0f;
							((List<Vector3>)this).set_Item(num16, vector);
							int num28 = num16 + 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
							obj4 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27+8]");
							_ = 0;
							obj4 = obj23;
							int num29 = num28 + 1;
							((Vector3*)(nint)vector)->x = (float)obj4;
							Vector3 vector7 = vector;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
							((Vector3*)(nint)vector7)->z = 0f;
							((List<Vector3>)this).set_Item(num28, vector);
							num16 = num29;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
						obj4 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v25+8]");
						_ = 0;
						obj4 = obj22;
						((Vector3*)(nint)vector)->x = (float)obj4;
						Vector3 vector8 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
						((Vector3*)(nint)vector8)->z = 0f;
						((List<Vector3>)this).set_Item(num16, vector);
						int num30 = num16 + 1;
						num16 = num30;
					}
					object obj24 = obj18 + 1;
					obj18 = obj24;
				}
				return;
			}
			nint num31 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v120 (Il2CppClass<NGUIText>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num32 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v148 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num33 = (float)NGUIText.rectWidth - completedFactor;
			if (!(num33 < 0f))
			{
				while (num10 < (nint)_templates)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
					obj = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v25+8]");
					_ = 0;
					float num34 = (float)obj + num33;
					obj = num34;
					((Vector3*)(nint)vector)->x = (float)obj;
					Vector3 vector9 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					((Vector3*)(nint)vector9)->z = 0f;
					((List<Vector3>)this).set_Item(num10, vector);
					int num35 = num10 + 1;
					num10 = num35;
				}
			}
			return;
		}
		nint num36 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v37 (Il2CppClass<NGUIText>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num37 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v113 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num38 = (float)NGUIText.rectWidth - completedFactor;
		float num39 = num38 * 0.5f;
		if (num39 < 0f)
		{
			return;
		}
		nint num40 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v49 (Il2CppClass<NGUIText>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num41 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v107 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num42 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v57 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num43 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v103 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float width = (float)NGUIText.rectWidth - completedFactor;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		object obj29 = gUILayoutOption & 1;
		bool flag3 = obj29 == null;
		GUILayoutOption gUILayoutOption2 = GUILayout.Width(NGUIText.rectWidth);
		object obj30 = gUILayoutOption2 & 1;
		bool flag4 = obj30 != null;
		object obj31 = flag3 | flag4;
		float num44;
		if (obj31 != null)
		{
			object obj32 = obj29 ^ 1;
			object obj33 = (object)gUILayoutOption2 & obj32;
			if (obj33 == null)
			{
				num44 = num39;
				goto IL_0cb2;
			}
		}
		nint num45 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S0_v89 (Il2CppClass<NGUIText>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num46 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v95 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num47 = 0.5f * NGUIText.fontScale;
		float num48 = num39 + num47;
		num44 = num48;
		goto IL_0cb2;
		IL_0cb2:
		while (num10 < (nint)_templates)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
			obj3 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v25+8]");
			_ = 0;
			float num49 = (float)obj3 + num44;
			obj3 = num49;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector10 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((Vector3*)(nint)vector10)->z = 0f;
			((List<Vector3>)this).set_Item(num10, vector);
			int num50 = num10 + 1;
			num10 = num50;
		}
	}

	public void RemoveProgressForThis(MissionTarget myTask)
	{
		//IL_000b: Expected I4, but got Obj
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0043: Expected Obj, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0162: Expected Obj, but got I4
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I4
		//IL_010f: Expected I, but got Obj
		if (myTask != MissionTarget.none)
		{
			int num = ApplyCoinDoublers((int)this);
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj2 = default;
			obj = obj2;
			bool working = PoolManager.Working;
			((StayInOneLaneMission)working).OnRunStarted();
		}
		else
		{
			if (_currentRunProgress == null)
			{
				return;
			}
			ApplyChangesToProgressIfNecessary();
			onMissionSetComplete += (MissionSetCompleteHandler)(object)this;
			string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
			int coinsCollectedRun = ((GameStats)(object)privacyPolicyUrl).CoinsCollectedRun;
			if (coinsCollectedRun == 50)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v19 (Il2CppClass<SocialManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num3 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v25 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
				((UIScreenController)facebookDialogsSupported).SetViewportRectXForCamera((Camera)(object)"CollectExactly50Coins", 100f);
			}
			object obj4 = this + 32;
			obj4 = 0;
		}
	}

	private void CheckAllCompleteAndIncrement()
	{
		//IL_01f3: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_0126: Expected I4, but got Obj
		//IL_0248: Expected I4, but got Obj
		//IL_0118: Expected I4, but got Obj
		//IL_015f: Expected I4, but got Obj
		//IL_027e: Expected I4, but got Obj
		//IL_0151: Expected I4, but got Obj
		//IL_0198: Expected I4, but got Obj
		//IL_02bc: Expected Obj, but got I
		//IL_02cc: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0310: Expected I, but got Obj
		//IL_0326: Expected Obj, but got I
		//IL_018a: Expected I4, but got Obj
		//IL_01ab: Expected I, but got Obj
		object obj = 0;
		int num = PlayerSave.currentMissionSet;
		if (num == -1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S3_v4+60]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S4_v5 (should have been resolved before IL gen)");
		int num3 = PlayerSave.currentMissionSet;
		obj = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S4_v8+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S4_v9+48]");
		object obj9 = 0;
		object obj10 = obj9 & 0x7FF;
		object obj11 = obj10 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v106 @ S5_v7 (should have been resolved before IL gen)");
		int totalLength = ((PlayerSave.GetCurrentMissionProgress(0) == 0) ? ((int)"0") : ((int)"1"));
		string values = string.ConcatArray((string[])(object)"", totalLength);
		string values2 = string.ConcatArray((string[])(object)values, (int)",");
		int totalLength2 = ((PlayerSave.GetCurrentMissionProgress(1) == 0) ? ((int)"0") : ((int)"1"));
		string values3 = string.ConcatArray((string[])(object)values2, totalLength2);
		string values4 = string.ConcatArray((string[])(object)values3, (int)",");
		int totalLength3 = ((PlayerSave.GetCurrentMissionProgress(2) == 0) ? ((int)"0") : ((int)"1"));
		string text = string.ConcatArray((string[])(object)values4, totalLength3);
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S4_v12 (Il2CppMethodInfo)+C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S4_v13+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S4_v14+48]");
		object obj14 = 0;
		object obj15 = obj14 & 0x7FF;
		object obj16 = obj15 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S5_v11 (should have been resolved before IL gen)");
		nint num6 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v32 (Il2CppClass<Flurry>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num7 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v35 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private unsafe void OverWriteAchievementsProgress(MissionTarget myTask, int value)
	{
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected I4, but got Unknown
		//IL_0055: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got VT
		//IL_0023: Expected I4, but got Obj
		//IL_0125: Expected Obj, but got I4
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_0174: Expected I, but got Obj
		object obj = default;
		bool flag = (byte)(obj + 8) != 0;
		if (value != 0)
		{
			DateTime today = CDateTime.Today;
			obj = today;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
			PlayerSave.hasSkippedMissionForVideoThisSet = flag;
			PlayerSave.InitializeCurrentMissionProgress(1);
		}
		((OwnBoardsAward)this)._002Ector((AwardStaticData)69, (PersistentAwardProgress)1, (Action<Award>)(-1));
		int numberOfBasicMission = GetNumberOfBasicMission();
		object obj2 = numberOfBasicMission + 16;
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		int num = currentSkipForVideoMissionIndex << 2;
		object obj3 = obj2 + num;
		object obj4 = obj3 + 16;
		object obj5 = (int)myTask << 3;
		object obj6 = obj4 + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v12+4]");
		PlayerSave.SetStatValue((Stat)myTask, 0);
		PlayerSave.SetCurrentMissionProgress((int)myTask, 1);
		if (OnMissionSkipped != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
		}
		((SpawnPool)this).Despawn((Transform)myTask, 1f, (Transform)null);
		nint num2 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v20 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num3 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v26 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
	}

	private void ResetProgressForMissionIndex(int questIndex)
	{
		//IL_0006: Expected I4, but got Obj
		//IL_0051: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I4
		int num3 = default;
		int num4 = default;
		while (true)
		{
			int num = ApplyCoinDoublers((int)this);
			int num2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v3 (System.Int32)+C]");
			if ((nint)num2 < (nint)0)
			{
				bool flag = inRun;
				object obj = (flag ? 1 : 0) + 16;
				object obj2 = num3 * 24;
				object obj3 = obj + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v7+10]");
				if ((nint)0 == questIndex)
				{
					ApplyChangesForVersion(num3);
				}
				num3 = num4 + 1;
				continue;
			}
			break;
		}
	}

	private unsafe void ApplyChangesForVersion(int versionNumber)
	{
		//IL_000e: Expected I4, but got Obj
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I4
		MissionsManager missionsManager = default;
		missionsManager.GetMissionInfo((int)this, ref *(MissionInfo*)versionNumber);
		if (missionsManager._currentMissionSetLoaded == 0)
		{
			PlayerSave.SetStatValue((Stat)versionNumber, 0);
			if (_currentRunProgress != null)
			{
				object obj = _currentRunProgress + 16;
				int num = versionNumber << 2;
				object obj2 = obj + num;
				obj2 = 0;
			}
		}
	}

	private void ApplyChangesToProgressIfNecessary()
	{
		//IL_0294: Expected I4, but got Obj
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_003f: Expected I4, but got Obj
		//IL_0051: Expected Obj, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected I4, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I4
		//IL_026b: Expected F4, but got I4
		//IL_026b: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I4
		//IL_0251: Expected F4, but got I4
		//IL_0251: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		int num = 3;
		while (true)
		{
			int num2 = ApplyCoinDoublers((int)this);
			int num3 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v3 (System.Int32)+C]");
			if ((nint)num3 >= (nint)0)
			{
				break;
			}
			object obj = _currentRunProgress + 16;
			int num4 = num << 2;
			object obj2 = obj + num4;
			int num5 = ApplyCoinDoublers((int)this);
			object obj3 = num5 + 16;
			int num6 = num << 3;
			object obj4 = obj3 + num6;
			int achievementProgress = PlayerSave.GetAchievementProgress(num);
			bool flag = inRun;
			object obj5 = (flag ? 1 : 0) + 16;
			object obj6 = num * 24;
			object obj7 = obj5 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v20+14]");
			if ((nint)0 != 0)
			{
				bool flag2 = inRun;
				object obj8 = (flag2 ? 1 : 0) + 16;
				object obj9 = num * 24;
				object obj10 = obj8 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v39+15]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v13+4]");
					if ((nint)obj2 < 0)
					{
						int stat = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v13+4]");
						PlayerSave.SetStatValue((Stat)stat, 0);
						((SpawnPool)this).Despawn((Transform)num, 1f, (Transform)1);
					}
					goto IL_0273;
				}
			}
			if (_currentRunProgress == null)
			{
				float num7 = achievementProgress;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v13+4]");
				float seconds = num7 / 0f;
				((SpawnPool)this).Despawn((Transform)num, seconds, (Transform)1);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v13+4]");
				int num8 = obj2 / 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v13+4]");
				int num9 = (int)((nint)achievementProgress / (nint)0);
				if (num8 > num9)
				{
					((SpawnPool)this).Despawn((Transform)num, (float)num8, (Transform)1);
				}
				else
				{
					((SpawnPool)this).Despawn((Transform)num, (float)num9, (Transform)1);
				}
			}
			goto IL_0273;
			IL_0273:
			int num10 = num + 1;
			num = num10;
		}
	}

	public void OnChangeIsCharacterOnGround(Character character)
	{
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05d0: Expected Obj, but got I4
		//IL_0051: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I
		//IL_02df: Expected I, but got Obj
		//IL_02f5: Expected Obj, but got I
		//IL_0667: Expected Obj, but got I
		//IL_0677: Expected Obj, but got I
		//IL_0687: Expected Obj, but got I
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected Obj, but got Unknown
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected Obj, but got Unknown
		//IL_0320: Expected I, but got Obj
		//IL_07b3: Expected Obj, but got I4
		//IL_0132: Expected I, but got Obj
		//IL_036d: Expected I, but got Obj
		//IL_0383: Expected Obj, but got I
		//IL_00c1: Expected I, but got Obj
		//IL_06e3: Expected I4, but got Obj
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected Obj, but got Unknown
		//IL_070b: Expected Obj, but got I4
		//IL_071c: Expected Obj, but got I4
		//IL_03ae: Expected I, but got Obj
		//IL_0203: Expected Obj, but got I
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_049c: Expected I, but got Obj
		//IL_04b2: Expected Obj, but got I
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Obj, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_01d4: Expected Obj, but got I
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected I4, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected Obj, but got Unknown
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected Obj, but got Unknown
		//IL_04dd: Expected I, but got Obj
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_0576: Expected Obj, but got I4
		//IL_0584: Expected Obj, but got I4
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_02b6: Expected Obj, but got I
		//IL_02cc: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		int num = ((MissionsManager)null).missionSetCount;
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		int num2 = missionSetStoryCount;
		if (currentSkipForVideoMissionIndex < num2)
		{
			int currentSkipForVideoMissionIndex2 = PlayerSave.currentSkipForVideoMissionIndex;
			bool flag = currentSkipForVideoMissionIndex2 < num;
			nint num3 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v96 (Il2CppClass<Missions.MissionsData>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag2 = obj3 == null;
			if (flag)
			{
				if (!flag2)
				{
					nint num4 = (nint)typeof(MissionsData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v162 (Il2CppClass<Missions.MissionsData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				List<MissionIndicator> missionsModificationsForStoryline = MissionsData.missionsModificationsForStoryline;
			}
			else
			{
				if (!flag2)
				{
					nint num5 = (nint)typeof(MissionsData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v150 (Il2CppClass<Missions.MissionsData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				List<MissionIndicator> missionsModificationsForStoryline = MissionsData.missionsModificationsForRepeatable;
			}
			object obj4 = 0;
			while (true)
			{
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v101 (System.Collections.Generic.List`1<MissionIndicator>)+C]");
				if ((nint)obj5 >= 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				object obj6;
				if (flag)
				{
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					obj6 = -1;
				}
				else
				{
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					object obj7 = (nint)num + (nint)0;
					obj6 = obj7 - 1;
				}
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				if (obj2 == character)
				{
					int currentSkipForVideoMissionIndex3 = PlayerSave.currentSkipForVideoMissionIndex;
					if (currentSkipForVideoMissionIndex3 == (nint)obj6)
					{
						obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						PlayerSave.SetStatValue(Stat.NotSet, 0);
						if (_currentRunProgress != null)
						{
							object obj8 = _currentRunProgress + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							object obj9 = (nint)0 << 2;
							object obj10 = obj8 + obj9;
							obj10 = 0;
						}
					}
				}
				object obj11 = obj4 + 1;
				obj4 = obj11;
			}
		}
		int currentSkipForVideoMissionIndex4 = PlayerSave.currentSkipForVideoMissionIndex;
		if (currentSkipForVideoMissionIndex4 < num)
		{
			return;
		}
		nint num6 = (nint)typeof(MissionsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v23 (Il2CppClass<Missions.MissionsData>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num7 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v86 (Il2CppClass<Missions.MissionsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S2_v5 (Il2CppMethodInfo)+C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S2_v6+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S2_v7+44]");
		object obj15 = 0;
		object obj16 = obj15 & 0x1FFF;
		object obj17 = obj16 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v101 @ S3_v6 (should have been resolved before IL gen)");
		object obj18 = default;
		if ((nint)obj18 <= -1)
		{
			return;
		}
		nint num9 = (nint)typeof(MissionsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v33 (Il2CppClass<Missions.MissionsData>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num10 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v80 (Il2CppClass<Missions.MissionsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int[] array = MissionsData.missionsInsertedForRepeatable.get_Item((int)character);
		object obj20 = array + 12;
		int currentSkipForVideoMissionIndex5 = PlayerSave.currentSkipForVideoMissionIndex;
		object obj21 = currentSkipForVideoMissionIndex5 - num;
		object obj22 = obj21;
		object obj23 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20))
		{
			object obj24 = array + 16;
			object obj25 = obj23 << 2;
			object obj26 = obj24 + obj25;
			object obj27 = obj26 - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22))
			{
				object obj28 = obj22 + 1;
				obj22 = obj28;
			}
			object obj29 = obj23 + 1;
			obj23 = obj29;
		}
		object obj30 = obj22 - obj21;
		int currentSkipForVideoMissionIndex6 = PlayerSave.currentSkipForVideoMissionIndex;
		int num11 = missionSetStoryCount;
		nint num12 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v56 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num13 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S0_v65 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int numberOfBasicMission = GetNumberOfBasicMission();
		int num14 = obj30 + currentSkipForVideoMissionIndex6;
		if (num14 < 0)
		{
			num14 = 0;
		}
		else if (num14 > num11)
		{
			num14 = num11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v61 (System.Int32)+C]");
		if ((nint)0 > (nint)num14)
		{
			int numberOfBasicMission2 = GetNumberOfBasicMission();
			object obj32 = numberOfBasicMission2 + 16;
			object obj33 = num14 << 2;
			object obj34 = obj32 + obj33;
			object obj35 = obj34;
			int myTask = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S2_v19+C]");
			PlayerDidThis((MissionTarget)myTask, 0, 0);
		}
	}

	private void SyncAchievements()
	{
		//IL_0071: Expected Obj, but got I4
		int unreportedGames = PlayerSave.unreportedGames;
		bool flag = unreportedGames <= 2;
		bool flag2 = !flag;
		int num = unreportedGames;
		if (!flag2)
		{
			while (true)
			{
				int num2 = num + 1;
				if (num2 > 3)
				{
					break;
				}
				OnChangeIsCharacterOnGround((Character)num2);
				num = num2;
			}
		}
		PlayerSave.unreportedGames = 3;
	}

	public unsafe bool IsMissionTargetActive(MissionTarget target)
	{
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_0378: Expected Obj, but got I4
		//IL_0391: Expected I, but got Obj
		//IL_03a7: Expected Obj, but got I
		//IL_04db: Expected Obj, but got I
		//IL_04fe: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected VT, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_0180: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got VT
		//IL_03d9: Expected Obj, but got VT
		//IL_03e6: Expected I8, but got Obj
		//IL_03e1: Expected native int or pointer, but got VT
		//IL_03fb: Expected Ref, but got VT
		//IL_0407: Expected Obj, but got I8
		//IL_0429: Expected I, but got Obj
		//IL_043f: Expected Obj, but got I
		//IL_0485: Invalid comparison between F8 and I4
		//IL_01c1: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I4
		//IL_020e: Expected I, but got Obj
		//IL_0293: Expected I, but got Obj
		//IL_02a9: Expected Obj, but got I
		//IL_02d4: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		videoButtonState__BackingField = VideoButtonTrackingState.NotSet;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v78 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17 (System.Boolean)+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+8]");
		bool flag = (nint)0 != 0;
		int numberOfOwnedBoards = ((OwnBoardsAward)flag).GetNumberOfOwnedBoards();
		Mission[] array = combinedArray;
		if (array != null)
		{
			LogMissionSetRuns();
		}
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 32);
		DateTime dateTime = (DateTime)(obj2 + 24);
		object obj5 = obj2 + 8;
		bool hasSkippedMissionForVideoThisSet = PlayerSave.hasSkippedMissionForVideoThisSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [target @ L1 (MissionTarget)+C]");
		if ((nint)0 == (hasSkippedMissionForVideoThisSet ? 1 : 0))
		{
			OfferWallManager instance = OfferWallManager.instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (System.Int32)+8]");
			if (((AdSystemManager)(object)instance).HasPriorityListWrapped((string)0))
			{
				if (PlayerSave.missionSetCompletedCount != 0)
				{
					videoButtonState__BackingField = VideoButtonTrackingState.AlreadyUsedForSet;
					return false;
				}
				DateTime today = CDateTime.Today;
				DateTime unreportedGamesTimeStamp = PlayerSave.unreportedGamesTimeStamp;
				nint num3 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v48 (Il2CppClass<System.DateTime>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v71 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj5 = today;
				obj2 = unreportedGamesTimeStamp;
				((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
				formatProvider = (IFormatProvider)obj2;
				long num5 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
				obj = num5;
				double num6 = (double)obj * 1E-07;
				nint num7 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v34 (Il2CppClass<Info.OnlineSettings>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num8 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v58 (Il2CppClass<Info.OnlineSettings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string saveDataPath = OnlineSettings.GetSaveDataPath();
				uint value = ((OnlineSettings)(object)saveDataPath).GetValue("mission_skip_with_video_cooldown_seconds", (uint)_defaultSkipWithVideoCooldownSeconds);
				if (num6 < (double)(int)value)
				{
					videoButtonState__BackingField = VideoButtonTrackingState.Cooldown;
					return false;
				}
				OfferWallManager instance2 = OfferWallManager.instance;
				bool flag2 = ((AdSystemManager)(object)instance2).IsCaching((string)numberOfOwnedBoards);
				nint num9 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v46 (Il2CppClass<Flurry>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num10 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v53 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (flag2)
				{
					videoButtonState__BackingField = VideoButtonTrackingState.Fill;
					return true;
				}
				videoButtonState__BackingField = VideoButtonTrackingState.NoFill;
				return false;
			}
			return false;
		}
		return false;
	}

	private static int ApplyCoinDoublers(int value)
	{
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 24;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Int32)+24]");
		if ((nint)0 == currentSkipForVideoMissionIndex)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Int32)+28]");
			if ((nint)0 != 0)
			{
				goto IL_028d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Int32)+28]");
		if ((nint)0 == 0)
		{
			object obj5 = value + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj6 = default;
			obj5 = obj6;
		}
		object obj7 = default;
		object obj12 = default;
		while ((nint)obj7 <= 2)
		{
			int numberOfBasicMission = ((MissionsManager)value).GetNumberOfBasicMission();
			object obj8 = numberOfBasicMission + 16;
			int currentSkipForVideoMissionIndex2 = PlayerSave.currentSkipForVideoMissionIndex;
			int num = currentSkipForVideoMissionIndex2 << 2;
			object obj9 = obj8 + num;
			object obj10 = obj9 + 16;
			object obj11 = obj12 << 3;
			object obj13 = obj10 + obj11;
			obj3 = obj13;
			obj4 = obj3;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Int32)+28]");
			object obj14 = (nint)0 + (nint)16;
			object obj15 = obj12 << 3;
			object obj16 = obj14 + obj15;
			obj16 = obj;
			obj7 = obj12 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Int32)+24]");
		if ((nint)0 == -1)
		{
			object obj17 = 0;
			while ((nint)obj17 <= 40)
			{
				CollectCoinsDummy[] defaultDummyList = CollectCoinsDummyData.GetDefaultDummyList();
				object obj18 = defaultDummyList.Length + 16;
				object obj19 = obj17 << 3;
				object obj20 = obj18 + obj19;
				obj3 = obj20;
				obj2 = obj3;
				obj = obj2;
				object obj21 = obj17 << 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Int32)+28]");
				object obj22 = 0 + obj21;
				object obj23 = obj22 + 40;
				obj23 = obj;
				object obj24 = obj17 + 1;
				obj17 = obj24;
			}
		}
		goto IL_028d;
		IL_028d:
		int currentSkipForVideoMissionIndex3 = PlayerSave.currentSkipForVideoMissionIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Int32)+28]");
		return 0;
	}

	private static bool IsOneOf(MissionTarget needle, MissionTarget[] haystack)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		int num = 0;
		while (true)
		{
			int num2 = ApplyCoinDoublers((int)needle);
			int num3 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v3 (System.Int32)+C]");
			if ((nint)num3 < (nint)0)
			{
				bool flag = ((MissionsManager)needle).inRun;
				object obj = (flag ? 1 : 0) + 16;
				object obj2 = num * 24;
				object obj3 = obj + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v10+10]");
				if (0 == (nint)haystack)
				{
					break;
				}
				int num4 = num + 1;
				num = num4;
				continue;
			}
			return false;
		}
		int achievementProgress = PlayerSave.GetAchievementProgress(num);
		int num5 = ApplyCoinDoublers((int)needle);
		object obj4 = num5 + 16;
		int num6 = num << 3;
		object obj5 = obj4 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v15+4]");
		return (nint)achievementProgress < (nint)0;
	}

	public void PlayerDidThis(MissionTarget myTask, int value = 1, int missionToIgnore = -1)
	{
		//IL_0034: Expected Obj, but got I4
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_00b7: Expected I, but got Obj
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		if (currentSkipForVideoMissionIndex == (int)myTask)
		{
			return;
		}
		PlayerSave.currentSkipForVideoMissionIndex = (int)myTask;
		if (missionToIgnore != 0)
		{
			PlayerSave.LoadCurrentMissionProgress((int[])value);
		}
		((MissionsManager)null).CheckAllCompleteAndIncrement();
		LogMissionSetRuns();
		PlayerSave.InitializeCurrentMissionProgress(0);
		PlayerSave.currentMissionSet = 0;
		SaveManager._002Ecctor();
		nint num = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ScoreMultiplierInfo._002Ecctor();
	}

	public MissionInfo[] GetMissionInfo()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0134: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen = UserSave.hasCharacterBeenSeen;
		nint num3 = (nint)typeof(DoubleCoins);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<DoubleCoins>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DoubleCoins);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v20 (Il2CppClass<DoubleCoins>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = hasCharacterBeenSeen & 1;
		object obj4 = (object)this << (int)obj3;
		bool hasDoubleCoinsModifier = DoubleCoins.HasDoubleCoinsModifier;
		return (MissionInfo[])(obj4 << (hasDoubleCoinsModifier ? 1 : 0));
	}

	public MissionInfo GetMissionInfo(int missionNumber)
	{
		//IL_00ab: Expected I4, but got VT
		//IL_0017: Expected Obj, but got VT
		//IL_0029: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I4
		Stat stat = Stat.GoldChainClock;
		MissionInfo missionInfo = default;
		while (true)
		{
			int num = ApplyCoinDoublers((int)missionInfo);
			Stat stat2 = stat;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v3 (System.Int32)+C]");
			if ((nint)stat2 >= (nint)0)
			{
				break;
			}
			bool flag = ((MissionsManager)missionInfo).inRun;
			object obj = (flag ? 1 : 0) + 16;
			object obj2 = (int)stat * 24;
			object obj3 = obj + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+10]");
			if (0 == (nint)this)
			{
				PlayerSave.SetStatValue(stat, missionNumber);
			}
			Stat stat3 = stat + 1;
			stat = stat3;
		}
		return missionInfo;
	}

	private unsafe void GetMissionInfo(int missionNumber, ref MissionInfo info)
	{
		//IL_0041: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I
		int num = default;
		((int*)num)->m_value = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		((StatAward)missionNumber).OnStatChanged((Stat)(int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref info), num);
		MissionsManager missionsManager = (MissionsManager)((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.Int32)+8]");
		_currentMissionTemplateSetLoaded = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.Int32)+10]");
		_defaultSkipWithVideoCooldownSeconds = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.Int32)+18]");
		videoButtonState__BackingField = VideoButtonTrackingState.NotSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.Int32)+20]");
		_currentRunProgress = (int[])0;
	}

	public MissionInfo[] GetNextMissionInfos()
	{
		//IL_0009: Expected Obj, but got I4
		return (MissionInfo[])PlayerSave.currentSkipForVideoMissionIndex;
	}

	private void TestGoToMissionSum(int mission)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected I4, but got Unknown
		//IL_019f: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		if (currentSkipForVideoMissionIndex == mission)
		{
			return;
		}
		int num = missionSetStoryCount;
		if (num > mission)
		{
			int numberOfBasicMission = GetNumberOfBasicMission();
			object obj = numberOfBasicMission + 16;
			int num2 = mission << 2;
			object obj2 = obj + num2;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S2_v17+C]");
			PlayerDidThis((MissionTarget)mission, 0, 1);
			return;
		}
		int currentSkipForVideoMissionIndex2 = PlayerSave.currentSkipForVideoMissionIndex;
		nint num3 = (nint)typeof(MissionsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v15 (Il2CppClass<Missions.MissionsData>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v20 (Il2CppClass<Missions.MissionsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Mission[][] repeatableMissions = MissionsData.repeatableMissions;
		object obj5 = currentSkipForVideoMissionIndex2 - repeatableMissions.Length;
		MissionTarget missionTarget = (MissionTarget)(obj5 + 1);
		int numberOfBasicMission2 = GetNumberOfBasicMission();
		object obj6 = numberOfBasicMission2 + 16;
		object obj7 = (int)missionTarget << 2;
		object obj8 = obj6 + obj7;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v11+C]");
		PlayerDidThis(missionTarget, 0, 1);
	}

	public int GetNumberOfBasicMission()
	{
		//IL_026c: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_022f: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		if (_missions == null)
		{
			nint num = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v12 (Il2CppClass<Missions.MissionsData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(MissionsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v52 (Il2CppClass<Missions.MissionsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = ((MissionsManager)null).missionSetCount;
			object obj2 = this + 48;
			object obj3 = MissionsData.repeatableMissions + 12;
			object obj4 = obj3 + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj5 = default;
			obj2 = obj5;
			object obj6 = 0;
			int num4 = ((MissionsManager)null).missionSetCount;
			if ((nint)obj6 < num4)
			{
				object obj7 = MissionsData.storylineMissions + 16;
				object obj8 = obj6 << 2;
				object obj9 = obj7 + obj8;
				throw new ArrayTypeMismatchException();
			}
			object obj10 = 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				int num5 = ((MissionsManager)null).missionSetCount;
				object obj11 = MissionsData.repeatableMissions + 16;
				object obj12 = obj10 << 2;
				object obj13 = obj11 + obj12;
				throw new ArrayTypeMismatchException();
			}
		}
		return (int)_missions;
	}

	private MissionsManager()
	{
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		Delegate obj = MissionsManager.m_onMissionComplete;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num = (nint)typeof(MissionsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<Missions.MissionsManager>)+5C]");
			object obj3 = (nint)0 + (nint)4;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	private void SetupDefaultMissionSetIfNeeded()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		_currentMissionTemplateSetLoaded = -1;
		_defaultSkipWithVideoCooldownSeconds = 28800;
		_defaultMissionIndexUpdateInterval = 28800;
		_currentMissionSetLoaded = -1;
		((OwnBoardsAward)this).ActivateCurrentAwardTier();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<RefreshType> action = default;
		object obj = action + 16;
		obj = this;
		AppRefreshHandler.hasRefreshed -= action;
		SyncAchievements();
	}

	public static AdLocationInfo GetCurrentLocationInfo(bool isInGame)
	{
		//IL_005b: Expected Obj, but got I4
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		int numberOfBasicMission = ((MissionsManager)isInGame).GetNumberOfBasicMission();
		nint num = (nint)typeof(MissionsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<Missions.MissionsData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v12 (Il2CppClass<Missions.MissionsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Mission[][] repeatableMissions = MissionsData.repeatableMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6 (System.Int32)+C]");
		return (AdLocationInfo)(-repeatableMissions.Length);
	}

	private static void ValidateMissions()
	{
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_018d: Expected I, but got Obj
		//IL_01a3: Expected Obj, but got I
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected I4, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		nint num = (nint)typeof(MissionsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Missions.MissionsData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<Missions.MissionsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Mission[][] storylineMissions = MissionsData.storylineMissions;
		UnityEngine.Object obj2 = default;
		UnityEngine.Object obj8 = default;
		if (storylineMissions.Length < (nint)obj2)
		{
			nint num3 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18 (Il2CppClass<Missions.MissionsData>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(MissionsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v30 (Il2CppClass<Missions.MissionsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Mission[][] storylineMissions2 = MissionsData.storylineMissions;
			object obj4 = obj2 - storylineMissions2.Length;
			Mission[][] storylineMissions3 = MissionsData.storylineMissions;
			Mission[][] repeatableMissions = MissionsData.repeatableMissions;
			object obj7;
			if (repeatableMissions.Length != 0)
			{
				object obj5 = obj4 / repeatableMissions.Length;
				object obj6 = obj5 * repeatableMissions.Length;
				obj7 = obj4 - obj6;
			}
			else
			{
				obj7 = 0;
			}
			obj8 = (UnityEngine.Object)(storylineMissions3.Length + obj7);
		}
		MissionTarget myTask = (MissionTarget)(obj8 - 1);
		int num5 = ((MissionsManager)(object)msg).missionSetStoryCount;
		int value;
		if ((nint)obj8 < num5)
		{
			int numberOfBasicMission = ((MissionsManager)(object)msg).GetNumberOfBasicMission();
			object obj9 = numberOfBasicMission + 16;
			object obj10 = (object)obj8 << 2;
			object obj11 = obj9 + obj10;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S2_v11+C]");
			value = 0;
		}
		else
		{
			value = 0;
		}
		((MissionsManager)(object)msg).PlayerDidThis(myTask, value, 1);
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	private void _003C_002Ector_003Eb__71_0(RefreshType type)
	{
	}
}
