using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

public class MissionsManager
{
	public delegate void MissionSetCompleteHandler();

	public delegate void MissionCompleteHandler(string msg);

	private int _currentMissionTemplateSetLoaded = -1;

	private MissionTemplate[] _templates;

	private int[] _currentRunProgress;

	private int _currentMissionSetLoaded = -1;

	private Mission[] _combinedArray;

	public MissionSetCompleteHandler onMissionSetComplete;

	public MissionCompleteHandler onMissionComplete;

	private Mission[][] _missions;

	private static MissionsManager _instance;

	private PlayerInfo playerinfo;

	private MissionTemplate[] templates
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_032a: Expected Obj, but got I4
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected Obj, but got Unknown
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected Obj, but got Unknown
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected Obj, but got Unknown
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected Obj, but got Unknown
			//IL_01ca: Expected Obj, but got I4
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Expected Obj, but got Unknown
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected Obj, but got Unknown
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected Obj, but got Unknown
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0214: Expected Obj, but got Unknown
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_023e: Expected Obj, but got Unknown
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Expected Obj, but got Unknown
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Expected Obj, but got Unknown
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d7: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 128;
			PlayerInfo playerInfo = playerinfo;
			MissionTemplate[] result;
			if (_currentMissionTemplateSetLoaded == playerInfo._currentMissionSet)
			{
				result = _templates;
				if (_templates != null)
				{
					goto IL_031c;
				}
			}
			if (_templates == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				MissionTemplate[] array = default;
				_templates = array;
			}
			object obj3 = 0;
			while ((nint)obj3 < 3)
			{
				object obj4 = obj + 104;
				Mission[][] array2 = missions;
				PlayerInfo playerInfo2 = playerinfo;
				int num = playerInfo2._currentMissionSet << 2;
				object obj5 = array2 + num;
				object obj6 = obj3 << 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S2_v18+10]");
				object obj7 = 0 + obj6;
				object obj8 = obj7 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A057");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				_ = 0;
				object obj9 = obj3 * 24;
				object obj10 = (object)_templates + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj11 = obj3 + 1;
				obj3 = obj11;
			}
			if (_currentMissionTemplateSetLoaded == -1)
			{
				object obj12 = 0;
				while ((nint)obj12 < 41)
				{
					object obj13 = obj + 56;
					Achievements instance = Achievements.Instance;
					object obj14 = obj12 << 3;
					object obj15 = (object)instance._achievementArray + obj14;
					object obj16 = obj15 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A057");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
					_ = 0;
					object obj17 = obj - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					object obj18 = obj12 + 3;
					object obj19 = obj18 * 24;
					object obj20 = (object)_templates + obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
					_ = 0;
					object obj21 = obj12 + 1;
					obj12 = obj21;
				}
			}
			PlayerInfo playerInfo3 = playerinfo;
			_currentMissionTemplateSetLoaded = playerInfo3._currentMissionSet;
			result = _templates;
			goto IL_031c;
			IL_031c:
			return result;
		}
	}

	public bool inRun
	{
		get
		{
			return _currentRunProgress != null;
		}
		set
		{
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a0: Expected Obj, but got Unknown
			//IL_028d: Expected I4, but got F8
			//IL_00b9: Expected Obj, but got I4
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected Obj, but got Unknown
			//IL_0313: Expected Obj, but got I4
			//IL_0111: Expected Obj, but got I4
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected Obj, but got Unknown
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected Obj, but got Unknown
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Expected Obj, but got Unknown
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Expected Obj, but got Unknown
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Expected Obj, but got Unknown
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0204: Expected Obj, but got Unknown
			if (value)
			{
				Mission[] array = combinedArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				int[] currentRunProgress = default;
				_currentRunProgress = currentRunProgress;
			}
			else
			{
				if (_currentRunProgress == null)
				{
					return;
				}
				UIScreenController instance = UIScreenController.Instance;
				string topScreenName = instance.GetTopScreenName();
				if (topScreenName != "PauseUI")
				{
					int num = 0;
					while (true)
					{
						Mission[] array2 = combinedArray;
						if (num >= array2.Length)
						{
							break;
						}
						MissionTemplate[] array3 = templates;
						object obj = num * 24;
						object obj2 = (object)array3 + obj;
						object obj3 = obj2 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v36+14]");
						if ((nint)0 != 0)
						{
							MissionTemplate[] array4 = templates;
							object obj4 = num * 24;
							object obj5 = (object)array4 + obj4;
							object obj6 = obj5 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v45+15]");
							if ((nint)0 != 0)
							{
								int num2 = num << 2;
								object obj7 = _currentRunProgress + num2;
								Mission[] array5 = combinedArray;
								int num3 = num << 3;
								object obj8 = array5 + num3;
								object obj9 = obj8 + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v50+10]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v36+4]");
								if (num4 < 0)
								{
									Mission[] array6 = combinedArray;
									int num5 = num << 3;
									object obj10 = array6 + num5;
									object obj11 = obj10 + 16;
									PlayerInfo playerInfo = playerinfo;
									int mission = num;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S2_v28+4]");
									playerInfo.SetCurrentMissionProgress(mission, 0);
									Complete(num);
								}
							}
						}
						int num6 = num + 1;
						num = num6;
					}
				}
				float time = Time.time;
				Character instance2 = Character.Instance;
				double num7 = (double)time - (double)instance2.sameLaneTimeStamp;
				double num8 = Math.Abs(num7);
				int magnitude = ((!(num8 < 2147483648.0)) ? int.MinValue : ((int)num7));
				object obj12 = this + 16;
				PlayerDidThis(MissionTarget.StayInOneLane, magnitude);
				RemoveProgressForThis(MissionTarget.StayInOneLane);
				CheckAllCompleteAndIncrement();
				SyncAchievements();
				GameStats instance3 = GameStats.Instance;
				int coinsCollected = instance3.CoinsCollected;
				if (coinsCollected == 50)
				{
					SocialManager instance4 = SocialManager.instance;
					instance4.ReportAchievement("CollectExactly50Coins", 100f);
				}
				obj12 = 0;
			}
		}
	}

	private Mission[] combinedArray
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected Obj, but got Unknown
			//IL_027a: Expected Obj, but got I4
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected Obj, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected Obj, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected Obj, but got Unknown
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected Obj, but got Unknown
			//IL_0173: Expected Obj, but got I4
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected Obj, but got Unknown
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 48;
			PlayerInfo playerInfo = playerinfo;
			object obj6;
			object obj4;
			if (_currentMissionSetLoaded == playerInfo._currentMissionSet)
			{
				if (_combinedArray != null)
				{
					goto IL_0251;
				}
				object obj3 = this + 24;
				obj4 = obj3;
			}
			else
			{
				object obj5 = this + 24;
				obj4 = obj5;
				obj6 = obj5;
				if (_combinedArray != null)
				{
					goto IL_0271;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj7 = default;
			obj4 = obj7;
			obj6 = obj4;
			goto IL_0271;
			IL_0271:
			object obj8 = 0;
			while ((nint)obj8 < 3)
			{
				Mission[][] array = missions;
				PlayerInfo playerInfo2 = playerinfo;
				int num = playerInfo2._currentMissionSet << 2;
				object obj9 = array + num;
				object obj10 = obj8 << 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v28+10]");
				object obj11 = 0 + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v30+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				object obj12 = obj8 << 3;
				object obj13 = (object)_combinedArray + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj14 = obj8 + 1;
				obj8 = obj14;
			}
			if (_currentMissionSetLoaded == -1)
			{
				object obj15 = 0;
				while ((nint)obj15 < 41)
				{
					Achievements instance = Achievements.Instance;
					object obj16 = obj15 << 3;
					object obj17 = (object)instance._achievementArray + obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v15+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
					_ = 0;
					object obj18 = obj15 + 3;
					object obj19 = obj18 << 3;
					object obj20 = obj6 + obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					_ = 0;
					object obj21 = obj15 + 1;
					obj15 = obj21;
				}
			}
			goto IL_0251;
			IL_0251:
			PlayerInfo playerInfo3 = playerinfo;
			_currentMissionSetLoaded = playerInfo3._currentMissionSet;
			return _combinedArray;
		}
	}

	public int currentMissionSet
	{
		get
		{
			PlayerInfo playerInfo = playerinfo;
			return playerInfo._currentMissionSet;
		}
		set
		{
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected Obj, but got Unknown
			//IL_00fe: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I4
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected I4, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected Obj, but got Unknown
			//IL_00a8: Expected Obj, but got I
			PlayerInfo playerInfo = playerinfo;
			if (value != playerInfo._currentMissionSet)
			{
				int num = missionSetCount;
				PlayerInfo playerInfo2 = playerinfo;
				if (value >= num)
				{
					Mission[][] repeatableMissions = MissionsData.repeatableMissions;
					object obj = playerInfo2._currentMissionSet - repeatableMissions.Length;
					int num2 = obj + 1;
					Mission[][] array = missions;
					int num3 = num2 << 2;
					object obj2 = array + num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v15+10]");
					object obj3 = 0;
					PlayerInfo playerInfo3 = playerinfo;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S2_v16+C]");
					playerInfo3.InitCurrentMissionSet(num2, 0, resetProgress: true);
				}
				else
				{
					Mission[][] array2 = missions;
					int num4 = value << 2;
					object obj4 = array2 + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S2_v4+10]");
					object obj5 = 0;
					PlayerInfo playerInfo4 = playerinfo;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S2_v5+C]");
					playerInfo4.InitCurrentMissionSet(value, 0, resetProgress: true);
				}
			}
		}
	}

	private Mission[][] missions
	{
		get
		{
			//IL_002c: Expected Obj, but got I4
			//IL_0049: Expected Obj, but got I4
			Mission[][] result = _missions;
			if (_missions == null)
			{
				Mission[][] repeatableMissions = MissionsData.repeatableMissions;
				int numberOfBasicMission = ((MissionsManager)null).GetNumberOfBasicMission();
				object obj = repeatableMissions.Length + numberOfBasicMission;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				Mission[][] array = default;
				_missions = array;
				object obj2 = 0;
				int numberOfBasicMission2 = ((MissionsManager)null).GetNumberOfBasicMission();
				if (numberOfBasicMission2 > (nint)obj2)
				{
					object obj3 = obj2 << 2;
					object obj4 = (object)MissionsData.storylineMissions + obj3;
					throw new ArrayTypeMismatchException();
				}
				MissionsManager missionsManager = default;
				bool flag = (nint)missionsManager >= repeatableMissions.Length;
				result = _missions;
				if (!flag)
				{
					int numberOfBasicMission3 = missionsManager.GetNumberOfBasicMission();
					object obj5 = (object)missionsManager << 2;
					object obj6 = (object)repeatableMissions + obj5;
					throw new ArrayTypeMismatchException();
				}
			}
			return result;
		}
	}

	public int missionSetCount
	{
		get
		{
			Mission[][] array = missions;
			return array.Length;
		}
	}

	public int missionSetStoryCount
	{
		get
		{
			Mission[][] array = missions;
			Mission[][] repeatableMissions = MissionsData.repeatableMissions;
			return array.Length - repeatableMissions.Length;
		}
	}

	public static MissionsManager Instance
	{
		get
		{
			bool flag = _instance == null;
			bool flag2 = !flag;
			MissionsManager result = _instance;
			if (!flag2)
			{
				MissionsManager missionsManager = default;
				missionsManager._002Ector();
				_instance = missionsManager;
				result = missionsManager;
			}
			return result;
		}
	}

	private MissionsManager()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		playerinfo = instance;
		PlayerInfo playerInfo = playerinfo;
		if (playerInfo._currentMissionSet == -1)
		{
			Mission[][] array = missions;
			Mission[] array2 = array[0];
			playerInfo.InitCurrentMissionSet(0, array2.Length, resetProgress: true);
		}
		ApplyChangesToProgressIfNecessary();
	}

	public void SkipMission(int missionNumber)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		PlayerDidThis(MissionTarget.SkipMission);
		Mission[][] array = missions;
		PlayerInfo playerInfo = playerinfo;
		int num = playerInfo._currentMissionSet << 2;
		object obj = array + num;
		int num2 = missionNumber << 3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v5+10]");
		object obj2 = (nint)0 + (nint)num2;
		object obj3 = obj2 + 16;
		PlayerInfo playerInfo2 = playerinfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v8+4]");
		playerInfo2.SetCurrentMissionProgress(missionNumber, 0);
		Complete(missionNumber);
	}

	private unsafe void Complete(int mission, float completedFactor = 1f, bool sendEvenIfInRun = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05a0: Expected Obj, but got I4
		//IL_093b: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_009e: Expected Obj, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got I4
		//IL_0693: Expected I4, but got Obj
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Expected Obj, but got Unknown
		//IL_0725: Expected Obj, but got I4
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected I4, but got Unknown
		//IL_0340: Expected Obj, but got I4
		//IL_0786: Expected Obj, but got I4
		//IL_07ef: Expected Obj, but got I4
		//IL_0487: Expected Obj, but got I4
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_054c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (mission <= 2)
		{
			if (completedFactor != 1f)
			{
				return;
			}
			MissionCompleteHandler missionCompleteHandler = onMissionComplete;
			if (onMissionComplete != null)
			{
				Mission[] array = combinedArray;
				int num = mission << 3;
				object obj3 = array + num;
				MissionTemplate[] array2 = templates;
				object obj4 = mission * 24;
				object obj5 = (object)array2 + obj4;
				object obj6 = obj5 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v163+14]");
				bool flag = (nint)0 == 1;
				object obj7 = 12;
				if (!flag)
				{
					obj7 = 8;
				}
				object obj8 = obj6 + obj7;
				string format = Strings.Get((StringID)obj8);
				Mission[] array3 = combinedArray;
				int num2 = mission << 3;
				object obj9 = array3 + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v111+14]");
				_ = 0;
				object obj10 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg = default;
				string text = string.Format(format, arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			PlayerInfo instance = PlayerInfo.Instance;
			Statistics stats = instance._stats;
			int[] values = stats._values;
			int value = values[13] + 1;
			stats.set_Item(Stat.MissionCompleted, value);
			int num3 = 0;
			object obj11 = 0;
			while (num3 < 3)
			{
				object obj12 = obj11 + 1;
				int currentMissionProgress = playerinfo.GetCurrentMissionProgress(num3);
				Mission[] array4 = combinedArray;
				int num4 = num3 << 3;
				object obj13 = array4 + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S3_v20+14]");
				if ((nint)currentMissionProgress < (nint)0)
				{
					obj12 = obj11;
				}
				Mission[] array5 = combinedArray;
				int num5 = num3 << 3;
				object obj14 = array5 + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v96+14]");
				bool flag2 = (nint)currentMissionProgress < (nint)0;
				obj11 = obj12;
				if (flag2)
				{
					break;
				}
				int num6 = num3 + 1;
				num3 = num6;
				obj11 = obj12;
			}
			if ((nint)obj11 >= 2 && _currentRunProgress != null)
			{
				SocialManager instance2 = SocialManager.instance;
				Achievements instance3 = Achievements.Instance;
				string[] achievementIds = instance3._achievementIds;
				instance2.ReportAchievement(achievementIds[36], 100f);
			}
			if (num3 < 3)
			{
				return;
			}
			PlayerInfo instance4 = PlayerInfo.Instance;
			bool flag3 = instance4._missionCompletedSum == 0;
			bool flag4 = !flag3;
			int num7 = instance4._missionCompletedSum;
			if (!flag4)
			{
				num7 = (instance4._missionCompletedSum = instance4._currentMissionSet + 1);
			}
			object obj15 = num7 + 1;
			int num8 = obj + 12;
			string text2 = ((int*)num8)->ToString();
			PlayerDidThis(MissionTarget.MissionSet);
			bool flag5 = _currentRunProgress == null;
			object obj16 = 0;
			if (!flag5)
			{
				while ((nint)obj16 < 3)
				{
					object obj17 = obj16 << 2;
					object obj18 = (object)_currentRunProgress + obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v139+10]");
					if ((nint)0 != 0)
					{
						object obj19 = obj16 << 2;
						object obj20 = (object)_currentRunProgress + obj19;
						_ = 0;
					}
					object obj21 = obj16 + 1;
					obj16 = obj21;
				}
			}
			PlayerInfo playerInfo = playerinfo;
			int num9 = missionSetStoryCount;
			object obj22 = playerInfo._currentMissionSet + 1;
			if (num9 == (nint)obj22)
			{
				PlayerInfo playerInfo2 = playerinfo;
				if (~(playerInfo2._shouldShowMission2Popup ? 1u : 0u) != 0)
				{
					playerInfo2._dirty = true;
					playerInfo2._shouldShowMission2Popup = true;
				}
			}
			PlayerInfo playerInfo3 = playerinfo;
			int num10 = missionSetStoryCount;
			object obj23 = playerInfo3._currentMissionSet + 1;
			if (num10 < (nint)obj23)
			{
				RewardManager.AddRewardToUnlock(CelebrationRewardOrigin.SuperMysteryBox);
				if (_currentRunProgress == null)
				{
					UIScreenController instance5 = UIScreenController.Instance;
					instance5.QueueMysteryBox();
				}
			}
			PlayerInfo playerInfo4 = playerinfo;
			int num11 = missionSetCount;
			object obj24 = num11 - 1;
			PlayerInfo playerInfo5 = playerinfo;
			int num12 = playerInfo5._currentMissionSet;
			if (playerInfo4._currentMissionSet >= (nint)obj24)
			{
				Mission[][] repeatableMissions = MissionsData.repeatableMissions;
				num12 -= repeatableMissions.Length;
			}
			int num13 = num12 + 1;
			PlayerInfo playerInfo6 = playerinfo;
			bool flag6 = playerInfo6._missionCompletedSum == 0;
			bool flag7 = !flag6;
			int num14 = playerInfo6._missionCompletedSum;
			if (!flag7)
			{
				num14 = (playerInfo6._missionCompletedSum = playerInfo6._currentMissionSet + 1);
			}
			int missionCompletedSum = num14 + 1;
			playerInfo6._missionCompletedSum = missionCompletedSum;
			int num15 = missionSetCount;
			bool flag8 = num15 > num13;
			bool flag9 = !flag8;
			int missionCount = 0;
			if (!flag9)
			{
				Mission[][] array6 = missions;
				int num16 = num13 << 2;
				object obj25 = array6 + num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v112+10]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S0_v113+C]");
				missionCount = 0;
			}
			playerinfo.InitCurrentMissionSet(num13, missionCount, resetProgress: true);
			MissionSetCompleteHandler missionSetCompleteHandler = onMissionSetComplete;
			if (onMissionSetComplete != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v489.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			PlayerDidThis(MissionTarget.ReachMissionSet);
			return;
		}
		int[] array7 = null;
		if (!sendEvenIfInRun)
		{
			array7 = _currentRunProgress;
		}
		if (array7 == null)
		{
			object obj27 = mission - 3;
			SocialManager instance6 = default;
			float num17 = default;
			if ((nint)obj27 < 41)
			{
				instance6 = SocialManager.instance;
				Achievements instance7 = Achievements.Instance;
				object obj28 = obj27 << 2;
				object obj29 = (object)instance7._achievementIds + obj28;
				num17 = Math.Min(completedFactor, 1f);
			}
			bool flag10 = completedFactor < 0f;
			float num18 = 0f;
			if (!flag10)
			{
				num18 = num17;
			}
			float percentCompleted = num18 * 100f;
			SocialManager socialManager = instance6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v14+10]");
			socialManager.ReportAchievement((string)0, percentCompleted);
		}
	}

	public void RemoveProgressForThis(MissionTarget myTask)
	{
		//IL_001d: Expected Obj, but got I4
		MissionTemplate[] array = templates;
		if (array == null)
		{
		}
		int num = 0;
		while (true)
		{
			Mission[] array2 = combinedArray;
			if (array2.Length > num)
			{
				MissionTemplate[] array3 = templates;
				object obj = num * 24;
				object obj2 = (object)array3 + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v8+20]");
				if ((nint)myTask == (nint)0)
				{
					ResetProgressForMissionIndex(num);
				}
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}

	private void CheckAllCompleteAndIncrement()
	{
		//IL_0026: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03f7: Expected F4, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_022b: Expected Obj, but got I
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected Obj, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		int num = 3;
		while (true)
		{
			Mission[] array = combinedArray;
			if (array.Length <= num)
			{
				break;
			}
			MissionTemplate[] array2 = templates;
			object obj = num * 24;
			object obj2 = (object)array2 + obj;
			object obj3 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v5+14]");
			float completedFactor;
			if ((nint)0 != 0)
			{
				MissionTemplate[] array3 = templates;
				object obj4 = num * 24;
				object obj5 = (object)array3 + obj4;
				object obj6 = obj5 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v34+15]");
				if ((nint)0 != 0)
				{
					int num2 = num << 2;
					object obj7 = _currentRunProgress + num2;
					Mission[] array4 = combinedArray;
					int num3 = num << 3;
					object obj8 = array4 + num3;
					object obj9 = obj8 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S2_v39+10]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S3_v49+4]");
					if (num4 >= 0)
					{
						goto IL_03fc;
					}
					Mission[] array5 = combinedArray;
					int num5 = num << 3;
					object obj10 = array5 + num5;
					object obj11 = obj10 + 16;
					PlayerInfo playerInfo = playerinfo;
					int mission = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S4_v42+4]");
					playerInfo.SetCurrentMissionProgress(mission, 0);
					completedFactor = 1f;
					goto IL_0418;
				}
			}
			if (_currentRunProgress != null)
			{
				int num6 = num << 2;
				object obj12 = _currentRunProgress + num6;
				Mission[] array6 = combinedArray;
				int num7 = num << 3;
				object obj13 = array6 + num7;
				object obj14 = obj13 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v18+10]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S3_v21+4]");
				object obj15 = num8 / 0;
				int currentMissionProgress = playerinfo.GetCurrentMissionProgress(num);
				Mission[] array7 = combinedArray;
				int num9 = num << 3;
				object obj16 = array7 + num9;
				object obj17 = obj16 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S4_v21+4]");
				int num10 = (int)((nint)currentMissionProgress / (nint)0);
				if ((nint)obj15 > num10)
				{
					int num11 = num << 2;
					object obj18 = _currentRunProgress + num11;
					Mission[] array8 = combinedArray;
					int num12 = num << 3;
					object obj19 = array8 + num12;
					object obj20 = obj19 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S2_v28+10]");
					float num13 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S3_v38+4]");
					completedFactor = num13 / 0f;
				}
				else
				{
					int currentMissionProgress2 = playerinfo.GetCurrentMissionProgress(num);
					Mission[] array9 = combinedArray;
					int num14 = num << 3;
					object obj21 = array9 + num14;
					object obj22 = obj21 + 16;
					float num15 = currentMissionProgress2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S3_v31+4]");
					completedFactor = num15 / 0f;
				}
			}
			else
			{
				int currentMissionProgress3 = playerinfo.GetCurrentMissionProgress(num);
				Mission[] array10 = combinedArray;
				int num16 = num << 3;
				object obj23 = array10 + num16;
				object obj24 = obj23 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S3_v14+4]");
				int num17 = (int)((nint)currentMissionProgress3 / (nint)0);
				completedFactor = num17;
			}
			goto IL_0418;
			IL_03fc:
			int num18 = num + 1;
			num = num18;
			continue;
			IL_0418:
			Complete(num, completedFactor, sendEvenIfInRun: true);
			goto IL_03fc;
		}
	}

	private void OverWriteAchievementsProgress(MissionTarget myTask, int overWrite)
	{
		//IL_0026: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		int num = 3;
		while (true)
		{
			Mission[] array = combinedArray;
			if (array.Length > num)
			{
				MissionTemplate[] array2 = templates;
				object obj = num * 24;
				object obj2 = (object)array2 + obj;
				object obj3 = obj2 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v7+10]");
				if ((nint)myTask == (nint)0)
				{
					playerinfo.SetCurrentMissionProgress(num, overWrite);
				}
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}

	private void ResetProgressForMissionIndex(int questIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		MissionInfo missionInfo = GetMissionInfo(questIndex);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			playerinfo.SetCurrentMissionProgress(questIndex, 0);
			if (_currentRunProgress != null)
			{
				int num = questIndex << 2;
				object obj4 = _currentRunProgress + num;
				_ = 0;
			}
		}
	}

	private void ApplyChangesForVersion(int versionNumber)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_036f: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_01a8: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected I4, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01fd: Expected Obj, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02c7: Expected Obj, but got I
		object obj = default;
		MissionsManager missionsManager = (MissionsManager)(obj - 16);
		int numberOfBasicMission = missionsManager.GetNumberOfBasicMission();
		PlayerInfo playerInfo = playerinfo;
		int num = missionSetCount;
		if (playerInfo._currentMissionSet >= num)
		{
			goto IL_0332;
		}
		PlayerInfo playerInfo2 = playerinfo;
		bool flag = playerInfo2._currentMissionSet < numberOfBasicMission;
		if (!flag)
		{
			goto IL_0039;
		}
		List<MissionIndicator> missionsModificationsForStoryline = MissionsData.missionsModificationsForStoryline;
		object obj2 = 0;
		goto IL_0405;
		IL_0405:
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v69 (System.Collections.Generic.List`1<MissionIndicator>)+C]");
		if ((nint)obj3 < 0)
		{
			goto IL_0039;
		}
		goto IL_0332;
		IL_0332:
		PlayerInfo playerInfo3 = playerinfo;
		if (numberOfBasicMission > playerInfo3._currentMissionSet)
		{
			return;
		}
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S3_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Int32[]>>)+54]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v137 @ S3_v6+4] (should have been resolved before IL gen)");
		object obj6 = default;
		object obj5 = obj6 ^ -1;
		object obj7 = obj5 >> 31;
		if (obj7 == null)
		{
			return;
		}
		int[] array = MissionsData.missionsInsertedForRepeatable.get_Item(versionNumber);
		PlayerInfo playerInfo4 = playerinfo;
		object obj8 = playerInfo4._currentMissionSet - numberOfBasicMission;
		object obj9 = obj8;
		object obj10 = 0;
		while (array.Length > (nint)obj10)
		{
			object obj11 = obj9 + 1;
			object obj12 = obj10 << 2;
			object obj13 = (object)array + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S3_v19+10]");
			object obj14 = -1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
			{
				obj11 = obj9;
			}
			object obj15 = obj10 + 1;
			obj9 = obj11;
			obj10 = obj15;
		}
		PlayerInfo playerInfo5 = playerinfo;
		int num4 = missionSetCount;
		object obj16 = obj9 - obj8;
		int num5 = obj16 + playerInfo5._currentMissionSet;
		if (num5 <= num4)
		{
			num4 = num5;
		}
		bool flag2 = num5 < 0;
		int num6 = 0;
		if (!flag2)
		{
			num6 = num4;
		}
		Mission[][] array2 = missions;
		if (num6 < array2.Length)
		{
			Mission[][] array3 = missions;
			int num7 = num6 << 2;
			object obj17 = array3 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S2_v21+10]");
			object obj18 = 0;
			PlayerInfo playerInfo6 = playerinfo;
			int missionSet = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S2_v22+C]");
			playerInfo6.InitCurrentMissionSet(missionSet, 0, resetProgress: false);
		}
		return;
		IL_0039:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionsManager)+4]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionsManager)+4]");
		object obj20 = (nint)numberOfBasicMission + (nint)0;
		if (!flag)
		{
			obj19 = obj20;
		}
		object obj21 = obj19 - 1;
		if ((nint)missionsManager == versionNumber)
		{
			PlayerInfo playerInfo7 = playerinfo;
			if ((nint)obj21 == playerInfo7._currentMissionSet)
			{
				playerinfo.SetCurrentMissionProgress(missionsManager._currentMissionTemplateSetLoaded, 0);
				if (_currentRunProgress != null)
				{
					int num8 = missionsManager._currentMissionTemplateSetLoaded << 2;
					object obj22 = _currentRunProgress + num8;
					_ = 0;
				}
			}
		}
		object obj23 = obj2 + 1;
		obj2 = obj23;
		goto IL_0405;
	}

	private void ApplyChangesToProgressIfNecessary()
	{
		PlayerInfo playerInfo = playerinfo;
		bool flag = playerInfo._missionsVersionLastUpdate <= 2;
		bool flag2 = !flag;
		int num = playerInfo._missionsVersionLastUpdate;
		PlayerInfo playerInfo2 = playerInfo;
		if (!flag2)
		{
			while (true)
			{
				int num2 = num + 1;
				if (num2 >= 4)
				{
					break;
				}
				ApplyChangesForVersion(num2);
				num = num2;
			}
			playerInfo2 = playerinfo;
		}
		if (playerInfo2._missionsVersionLastUpdate != 3)
		{
			playerInfo2._dirty = true;
			playerInfo2._missionsVersionLastUpdate = 3;
		}
	}

	public void OnChangeIsCharacterOnGround(Character character)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003e: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 - 16;
		Transform transform = character.transform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		if (0f < 1f)
		{
			RemoveProgressForThis(MissionTarget.EarnCoinWithoutTouchingGround);
		}
	}

	private void SyncAchievements()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
		//IL_05bd: Expected Obj, but got I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_018a: Expected Obj, but got I
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected Obj, but got Unknown
		//IL_0287: Expected Obj, but got I
		//IL_0595: Expected Obj, but got I
		//IL_02ed: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 80;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		PlayerInfo playerInfo = playerinfo;
		OverWriteAchievementsProgress(MissionTarget.ReachMissionSet, playerInfo._currentMissionSet);
		int upgradeTierSum = playerinfo.GetUpgradeTierSum();
		OverWriteAchievementsProgress(MissionTarget.HaveUpgrades, upgradeTierSum);
		int overWrite = playerinfo.NumberOfUnlockedTrophyForFirstAchievement();
		OverWriteAchievementsProgress(MissionTarget.HaveTrophiesFirstAchievements, overWrite);
		SocialManager instance = SocialManager.instance;
		bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4F]");
		int overWrite2;
		if ((nint)0 != 0)
		{
			overWrite2 = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4F]");
			if ((nint)0 == 0)
			{
				overWrite2 = -1;
			}
		}
		else
		{
			overWrite2 = 0;
		}
		OverWriteAchievementsProgress(MissionTarget.FacebookLoggedIn, overWrite2);
		Achievements instance2 = Achievements.Instance;
		int achievementIndexInArray = instance2.getAchievementIndexInArray(MissionType.HaveHeadStartLarge);
		if (achievementIndexInArray >= 0)
		{
			int upgradeAmount = playerinfo.GetUpgradeAmount(PowerupType.headstart2000);
			Achievements instance3 = Achievements.Instance;
			int num = achievementIndexInArray << 3;
			object obj4 = instance3._achievementArray + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v89+14]");
			if ((nint)upgradeAmount >= (nint)0)
			{
				SocialManager instance4 = SocialManager.instance;
				Achievements instance5 = Achievements.Instance;
				int num2 = achievementIndexInArray << 2;
				object obj5 = instance5._achievementIds + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v94+10]");
				instance4.ReportAchievement((string)0, 100f);
			}
		}
		object obj6 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BE7");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj7 = obj + 48;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj9 = default;
		object obj10;
		object obj15 = default;
		object obj16 = default;
		object obj18 = default;
		object obj19 = default;
		while (true)
		{
			_ = 0;
			object obj8 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj9 == null;
				obj10 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj11 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v95+20]");
						if ((nint)0 == 0)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj12 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							PlayerInfo playerInfo2 = playerinfo;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
								object obj13 = (nint)0 << 2;
								object obj14 = (object)playerInfo2._collectedCharacterTokens + obj13;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj15 == obj16;
			bool flag3 = !flag2;
			object obj17 = obj18;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj10 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj17 = obj19;
			}
			_ = 0;
			object obj20 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj10 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj21 = obj10 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2CF9");
	}

	public bool IsMissionTargetActive(MissionTarget target)
	{
		//IL_0026: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		int num = 0;
		while (true)
		{
			Mission[] array = combinedArray;
			if (array.Length <= num)
			{
				break;
			}
			MissionTemplate[] array2 = templates;
			object obj = num * 24;
			object obj2 = (object)array2 + obj;
			object obj3 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v7+10]");
			if ((nint)target == (nint)0)
			{
				int currentMissionProgress = playerinfo.GetCurrentMissionProgress(num);
				Mission[] array3 = combinedArray;
				int num2 = num << 3;
				object obj4 = array3 + num2;
				object obj5 = obj4 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v14+4]");
				return (nint)currentMissionProgress < (nint)0;
			}
			int num3 = num + 1;
			num = num3;
		}
		return false;
	}

	public void PlayerDidThisCoinMission(MissionTarget missionTarget)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		int magnitude = 4;
		if (!DoubleCoins.HasDoubleCoinsModifier)
		{
			magnitude = 2;
		}
		int num = 2;
		if (!DoubleCoins.HasDoubleCoinsModifier)
		{
			num = 1;
		}
		if (!instance._hasDoubleCoinsUpgrade)
		{
			magnitude = num;
		}
		PlayerDidThis(missionTarget, magnitude);
	}

	public void PlayerDidThis(MissionTarget myTask, int magnitude = 1, int missionToIgnore = -1)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00fd: Expected F4, but got I4
		//IL_009c: Expected F4, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_097b: Expected Obj, but got I4
		//IL_0596: Expected Obj, but got I4
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected Obj, but got Unknown
		//IL_028e: Expected Obj, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_08a4: Expected F4, but got I4
		//IL_0708: Expected Obj, but got I4
		//IL_09c5: Expected F4, but got I4
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected Obj, but got Unknown
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Expected Obj, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_0659: Expected Obj, but got I
		//IL_0842: Expected I4, but got Obj
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected Obj, but got Unknown
		//IL_0511: Expected I4, but got Obj
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_07e2: Expected I4, but got Obj
		//IL_07eb: Expected F4, but got I4
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected Obj, but got Unknown
		//IL_0785: Expected I4, but got Obj
		//IL_078e: Expected F4, but got I4
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04c2: Expected I4, but got Obj
		//IL_03b6: Expected I4, but got Obj
		//IL_03bf: Expected F4, but got I4
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_0359: Expected I4, but got Obj
		//IL_0362: Expected F4, but got I4
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		MissionTemplate[] array = templates;
		if (array == null)
		{
		}
		int num = 0;
		while (true)
		{
			Mission[] array2 = combinedArray;
			if (array2.Length <= num)
			{
				break;
			}
			if (num != missionToIgnore)
			{
				MissionTemplate[] array3 = templates;
				float num2 = (float)num * 24f;
				float num3 = (float)array3 + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v27 (System.Single)+24]");
				float num4;
				if ((nint)0 != 0)
				{
					bool flag = _currentRunProgress == null;
					num4 = 24f;
					if (flag)
					{
						goto IL_08ff;
					}
				}
				MissionTemplate[] array4 = templates;
				float num5 = (float)num * 24f;
				float num6 = (float)array4 + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v32 (System.Single)+20]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
				bool flag2 = num7 != 0;
				num4 = 24f;
				if (!flag2)
				{
					int currentMissionProgress = playerinfo.GetCurrentMissionProgress(num);
					MissionTemplate[] array5 = templates;
					object obj3 = num * 24;
					object obj4 = (object)array5 + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v40+24]");
					bool flag3 = (nint)0 == 0;
					int num8 = currentMissionProgress;
					if (!flag3)
					{
						bool flag4 = _currentRunProgress == null;
						num8 = currentMissionProgress;
						if (!flag4)
						{
							Mission[] array6 = combinedArray;
							int num9 = num << 3;
							object obj5 = array6 + num9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v99+14]");
							bool flag5 = (nint)currentMissionProgress >= (nint)0;
							num8 = currentMissionProgress;
							if (!flag5)
							{
								bool flag6 = _currentRunProgress == null;
								num8 = currentMissionProgress;
								if (!flag6)
								{
									int num10 = num << 2;
									object obj6 = _currentRunProgress + num10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v160+10]");
									num8 = 0;
								}
							}
						}
					}
					int num11 = magnitude + num8;
					MissionTemplate[] array7 = templates;
					object obj7 = num * 24;
					object obj8 = (object)array7 + obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v48+25]");
					if ((nint)0 != 0)
					{
						Mission[] array8 = combinedArray;
						int num12 = num << 3;
						object obj9 = array8 + num12;
						MissionTemplate[] array9 = templates;
						object obj10 = num * 24;
						object obj11 = (object)array9 + obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v100+14]");
						if ((nint)num11 > (nint)0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v104+24]");
							if ((nint)0 != 0 && _currentRunProgress != null)
							{
								if (_currentRunProgress != null)
								{
									int num13 = num << 2;
									object obj12 = _currentRunProgress + num13;
									num8 = (int)_currentRunProgress;
									num4 = 2f;
								}
								else
								{
									_ = -1;
									obj = (Enum)(object)typeof(MissionTarget);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
									_ = 0;
									string text = obj.ToString();
									string text2 = "_currentRunProgress is null - PlayerDidThis called outside a run for a singleRun mission with MissionTarget: " + text;
									num8 = (int)_currentRunProgress;
									num4 = 0f;
								}
							}
							else
							{
								playerinfo.SetCurrentMissionProgress(num, num11);
								Mission[] array10 = combinedArray;
								int num14 = num << 3;
								object obj13 = array10 + num14;
								float num15 = num11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S3_v35+14]");
								num4 = num15 / 0f;
								Complete(num, num4);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v104+24]");
								num8 = 0;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v104+24]");
							bool flag7 = (nint)0 == 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v104+24]");
							num8 = 0;
							if (!flag7)
							{
								if (_currentRunProgress != null)
								{
									int num16 = num << 2;
									object obj14 = _currentRunProgress + num16;
									num8 = (int)_currentRunProgress;
								}
								else
								{
									_ = -1;
									obj = (Enum)(object)typeof(MissionTarget);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
									_ = 0;
									string text3 = obj.ToString();
									string text4 = "_currentRunProgress is null - PlayerDidThis called outside a run for a singleRun mission with MissionTarget: " + text3;
									num8 = (int)_currentRunProgress;
								}
							}
							Mission[] array11 = combinedArray;
							int num17 = num << 3;
							object obj15 = array11 + num17;
							PlayerInfo playerInfo = playerinfo;
							int mission = num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S2_v46+14]");
							playerInfo.SetCurrentMissionProgress(mission, 0);
							Complete(num);
							num4 = 1f;
						}
					}
					else
					{
						MissionTemplate[] array12 = templates;
						object obj16 = num * 24;
						object obj17 = (object)array12 + obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v52+26]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
							bool flag8 = (nint)0 == 78;
							int num18 = magnitude;
							if (!flag8)
							{
								num18 = num11;
							}
							Mission[] array13 = combinedArray;
							num4 = num << 3;
							float num19 = (float)array13 + num4;
							int num20 = num18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S1_v63 (System.Single)+14]");
							if ((nint)num20 == 0)
							{
								Mission[][] array14 = missions;
								PlayerInfo playerInfo2 = playerinfo;
								int num21 = playerInfo2._currentMissionSet << 2;
								object obj18 = array14 + num21;
								int num22 = num << 3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S2_v36+10]");
								object obj19 = (nint)0 + (nint)num22;
								PlayerInfo playerInfo3 = playerinfo;
								int mission2 = num;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S2_v38+14]");
								playerInfo3.SetCurrentMissionProgress(mission2, 0);
								Complete(num);
								num4 = 1f;
							}
						}
						else
						{
							Mission[] array15 = combinedArray;
							int num23 = num << 3;
							object obj20 = array15 + num23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v56+14]");
							if ((nint)0 > (nint)num11)
							{
								MissionTemplate[] array16 = templates;
								object obj21 = num * 24;
								object obj22 = (object)array16 + obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S0_v66+24]");
								if ((nint)0 != 0)
								{
									if (_currentRunProgress != null)
									{
										int num24 = num << 2;
										object obj23 = _currentRunProgress + num24;
										num8 = (int)_currentRunProgress;
										num4 = 2f;
									}
									else
									{
										_ = -1;
										obj = (Enum)(object)typeof(MissionTarget);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
										_ = 0;
										string text5 = obj.ToString();
										string text6 = "_currentRunProgress is null - PlayerDidThis called outside a run for a singleRun mission with MissionTarget: " + text5;
										num8 = (int)_currentRunProgress;
										num4 = 0f;
									}
								}
								else
								{
									if (_currentRunProgress != null)
									{
										int num25 = num << 2;
										object obj24 = _currentRunProgress + num25;
									}
									playerinfo.SetCurrentMissionProgress(num, num11);
									Mission[] array17 = combinedArray;
									int num26 = num << 3;
									object obj25 = array17 + num26;
									float num27 = num11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S3_v13+14]");
									num4 = num27 / 0f;
									Complete(num, num4);
									num8 = (int)_currentRunProgress;
								}
							}
							else
							{
								Mission[] array18 = combinedArray;
								int num28 = num << 3;
								object obj26 = array18 + num28;
								PlayerInfo playerInfo4 = playerinfo;
								int mission3 = num;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S2_v13+14]");
								playerInfo4.SetCurrentMissionProgress(mission3, 0);
								Mission[] array19 = combinedArray;
								num4 = num << 3;
								float num29 = (float)array19 + num4;
								int num30 = num8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S1_v39 (System.Single)+14]");
								if ((nint)num30 < (nint)0)
								{
									Complete(num);
									num4 = 1f;
								}
							}
						}
					}
				}
			}
			goto IL_08ff;
			IL_08ff:
			int num31 = num + 1;
			num = num31;
		}
	}

	public unsafe MissionInfo[] GetMissionInfo()
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Ref, but got Unknown
		Mission[] array = combinedArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int num = 0;
		MissionInfo[] array3 = default;
		while (true)
		{
			Mission[] array2 = combinedArray;
			if (array2.Length <= num)
			{
				break;
			}
			object obj = num * 40;
			object obj2 = (object)array3 + obj;
			GetMissionInfo(num, ref *(MissionInfo*)(obj2 + 16));
			int num2 = num + 1;
			num = num2;
		}
		return array3;
	}

	public unsafe MissionInfo GetMissionInfo(int missionNumber)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Ref, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		object obj4 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		GetMissionInfo(missionNumber, ref *(MissionInfo*)(obj + 8));
		object obj5 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		MissionInfo result = default;
		return result;
	}

	public unsafe void GetMissionInfo(int missionNumber, ref MissionInfo info)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Mission[] array = combinedArray;
		int num = missionNumber << 3;
		object obj3 = array + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		ref MissionInfo reference = ref *(MissionInfo*)null;
		MissionTemplate[] array2 = templates;
		object obj4 = missionNumber * 24;
		object obj5 = (object)array2 + obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v10+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v10+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v10+10]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		int currentMissionProgress = playerinfo.GetCurrentMissionProgress(missionNumber);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [info @ L2 (MissionInfo&)+4]");
		if ((nint)currentMissionProgress < (nint)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [info @ L2 (MissionInfo&)+1C]");
			if ((nint)0 != 0 && _currentRunProgress != null)
			{
				int num2 = missionNumber << 2;
				object obj6 = _currentRunProgress + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v31+10]");
				_ = 0;
			}
		}
	}

	private void TestGoToMissionSum(int mission)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_003a: Expected Obj, but got I
		int num = missionSetCount;
		int num2 = default;
		bool flag = num > num2;
		bool flag2 = !flag;
		int missionCount = 0;
		if (!flag2)
		{
			Mission[][] array = missions;
			int num3 = num2 << 2;
			object obj = array + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v16+10]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v17+C]");
			missionCount = 0;
		}
		int missionSet = num2 - 1;
		playerinfo.InitCurrentMissionSet(missionSet, missionCount, resetProgress: true);
	}

	public int GetNumberOfBasicMission()
	{
		Mission[][] storylineMissions = MissionsData.storylineMissions;
		return storylineMissions.Length;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
