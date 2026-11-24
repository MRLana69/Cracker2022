using System;
using System.Collections.Generic;
using Authentication;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Backend.Authentication;
using Kiloo.Common.Backend.Cloud;

namespace Cloud.Internal;

public class CloudSaveConflictResolver
{
	public enum Recommendation
	{
		None,
		Mine,
		Theirs
	}

	private ICloudConflict _conflict;

	private UserData _localData;

	private UserData _cloudData;

	private float recommendationEvaluation__BackingField;

	public Recommendation recommendation
	{
		get
		{
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Expected Obj, but got Unknown
			//IL_000e: Expected I4, but got Obj
			//IL_0057: Expected F8, but got I4
			//IL_01b3: Expected Obj, but got F8
			//IL_0094: Expected F8, but got I4
			//IL_00d1: Expected F8, but got I4
			object obj2 = default;
			object obj = obj2 + 4;
			double num = (double)this * 1E-07;
			if (!(num < 10.0))
			{
				return (Recommendation)">10";
			}
			double num2 = (double)this * 1E-07;
			if (num2 != num2)
			{
				num2 = -2147483648.0;
			}
			else if (!(num2 < 2147483648.0))
			{
				num2 = -2147483648.0;
			}
			else if (!(num2 > -2147483649.0))
			{
				num2 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			obj = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
	}

	public float recommendationEvaluation
	{
		get
		{
			//IL_01fc: Expected I, but got Obj
			//IL_0212: Expected Obj, but got I
			//IL_02c2: Expected Obj, but got I
			//IL_02d2: Expected Obj, but got I
			//IL_02e2: Expected Obj, but got I
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Expected Obj, but got Unknown
			//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_023d: Expected I, but got Obj
			//IL_0253: Expected Obj, but got I
			//IL_033b: Expected I4, but got Obj
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected Obj, but got Unknown
			//IL_037f: Expected F4, but got Obj
			//IL_0085: Expected I, but got Obj
			//IL_009b: Expected Obj, but got I
			//IL_01a1: Expected I, but got Obj
			//IL_00c6: Expected I, but got Obj
			//IL_0113: Expected I, but got Obj
			//IL_0129: Expected Obj, but got I
			//IL_0154: Expected I, but got Obj
			nint num = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Upgrades>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Upgrades);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v61 (Il2CppClass<Info.Upgrades>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
			object obj4 = 0;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
			object obj7 = default;
			if ((nint)obj7 > -1)
			{
				if ((nint)this == 1)
				{
					nint num4 = (nint)typeof(Hoverboard);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v40 (Il2CppClass<Hoverboard>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num5 = (nint)typeof(Hoverboard);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v57 (Il2CppClass<Hoverboard>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v45 (CharacterModifier)+57]");
					if ((nint)0 != 0)
					{
						nint num6 = (nint)typeof(MysteryPowerup);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v48 (Il2CppClass<MysteryPowerup>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num7 = (nint)typeof(MysteryPowerup);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v53 (Il2CppClass<MysteryPowerup>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						return 15f;
					}
				}
				nint num8 = (nint)typeof(Upgrades);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v21 (Il2CppClass<Info.Upgrades>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num9 = (nint)typeof(Upgrades);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v33 (Il2CppClass<Info.Upgrades>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Upgrade upgrade = Upgrades.upgrades.get_Item((UpgradeType)this);
				object obj11 = upgrade.durations + 16;
				CollectCoinsDummy[] array = MigrationSave.ParseDummyData((string)(object)this);
				object obj12 = (object)array << 2;
				object obj13 = obj11 + obj12;
				return (float)obj13;
			}
			return 0f;
		}
		private set
		{
			//IL_000a: Expected Obj, but got F4
			_cloudData = (UserData)value;
		}
	}

	public CloudConflictResolution resolution
	{
		get
		{
			if (recommendationEvaluation__BackingField > 2f)
			{
				return CloudConflictResolution.UsingMine;
			}
			if (recommendationEvaluation__BackingField < -2f)
			{
				return CloudConflictResolution.UsingTheirs;
			}
			return CloudConflictResolution.NotResolved;
		}
	}

	public unsafe DateTime lastModifiedMine
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e5: Expected I4, but got Unknown
			object obj2 = default;
			object obj = obj2 + 68;
			obj = this;
			bool flag = (byte)(obj2 - -64) != 0;
			((bool*)(flag ? 1 : 0))->m_value = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
	}

	public DateTime lastModifiedTheirs
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_001c: Expected Obj, but got I4
			//IL_0050: Expected VT, but got Obj
			object obj2 = default;
			object obj = obj2 + 16;
			obj = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7571");
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			return (DateTime)obj;
		}
	}

	public string sourceMine
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
	}

	public string sourceTheirs
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
	}

	public CloudSaveConflictResolver(ICloudConflict conflict)
	{
		//IL_0010: Expected I4, but got Obj
		string msg = string.ConcatArray((string[])(object)"[CloudSave] ", (int)this);
		SDebug.LogFormat(msg, (object[])(object)conflict);
	}

	public void RefreshLocalUserData()
	{
		//IL_0559: Expected I, but got Obj
		//IL_056f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_059a: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0298: Expected I, but got Obj
		//IL_02ae: Expected Obj, but got I
		//IL_0170: Expected I, but got Obj
		//IL_06c3: Expected I, but got Obj
		//IL_06d9: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_01d3: Expected Obj, but got I
		//IL_02d9: Expected I, but got Obj
		//IL_0674: Expected I, but got Obj
		//IL_068a: Expected Obj, but got I
		//IL_0739: Expected I, but got Obj
		//IL_074f: Expected Obj, but got I
		//IL_01fe: Expected I, but got Obj
		//IL_03a5: Expected I, but got Obj
		//IL_024b: Expected I, but got Obj
		//IL_033f: Expected I, but got Obj
		//IL_0507: Expected I, but got Obj
		//IL_040f: Expected I, but got Obj
		//IL_04a1: Expected I, but got Obj
		string savedKilooTag = SaveManager.GetSavedKilooTag();
		if (savedKilooTag == null)
		{
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v20 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v131 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UserSave.hasCloudSaveCelebrationBeenShown)
			{
				nint num3 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v28 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v127 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (CloudSave.useSimulatedServer)
				{
					nint num5 = (nint)typeof(Auth);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v36 (Il2CppClass<Authentication.Auth>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(Auth);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v123 (Il2CppClass<Authentication.Auth>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					KilooAuth kilooAuth = Auth.kilooAuth;
					if (kilooAuth == null)
					{
						nint num7 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v104 (Il2CppClass<Cloud.CloudSave>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num8 = (nint)typeof(CloudSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v119 (Il2CppClass<Cloud.CloudSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						nint num9 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v109 (Il2CppClass<Cloud.CloudSave>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num10 = (nint)typeof(CloudSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v115 (Il2CppClass<Cloud.CloudSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CloudSave.errorState = CloudSaveErrorState.GameOutdated;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8BEA");
						return;
					}
					nint num11 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v44 (Il2CppClass<Cloud.CloudSave>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num12 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v97 (Il2CppClass<Cloud.CloudSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isAccountMismatch = CloudSave._workingCopy.isAccountMismatch;
					nint num13 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v12 (Il2CppClass<Cloud.CloudSave>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					bool flag = obj7 != null;
					if (isAccountMismatch)
					{
						if (flag)
						{
							nint num14 = (nint)typeof(CloudSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v93 (Il2CppClass<Cloud.CloudSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CloudSave.errorState = CloudSaveErrorState.GameOutdated;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8BEA");
						return;
					}
					if (flag)
					{
						nint num15 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v83 (Il2CppClass<Cloud.CloudSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string kilooTag = CloudSave._workingCopy.kilooTag;
					nint num16 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v18 (Il2CppClass<Cloud.CloudSave>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (kilooTag != null)
					{
						if (obj8 != null)
						{
							nint num17 = (nint)typeof(CloudSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v79 (Il2CppClass<Cloud.CloudSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CloudSave.SetStateOkAndQueueCelebrationIfNeeded();
						return;
					}
					bool flag2 = obj8 != null;
					if (this != null)
					{
						if (flag2)
						{
							nint num18 = (nint)typeof(CloudSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v72 (Il2CppClass<Cloud.CloudSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CloudSave.errorState = CloudSaveErrorState.Unauthenticated;
						return;
					}
					if (flag2)
					{
						nint num19 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v65 (Il2CppClass<Cloud.CloudSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Auth.DeleteKilooAuthDebug();
					return;
				}
			}
		}
		nint num20 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v10 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num21 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudSave.errorState = CloudSaveErrorState.Offline;
	}

	private void AttemptAutoResolution()
	{
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ICloudUserData data = CloudSave.DEBUG_MakeUserData();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		UserData userData = default;
		userData.LoadUserData((Dictionary<string, string>)data);
		object obj2 = this + 12;
		obj2 = userData;
		Log((string)(object)this);
	}

	public void ResolveToMine()
	{
		//IL_0237: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_028b: Expected Obj, but got I
		//IL_029b: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0197: Expected I, but got Obj
		//IL_01ad: Expected Obj, but got I
		//IL_00b6: Expected I, but got Obj
		//IL_01d8: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S5_v6 (should have been resolved before IL gen)");
		string entry = UserData.GetEntry((Dictionary<string, string>)(object)_cloudData, (string)(object)_localData);
		if (entry != null)
		{
			DetermineRecommendation();
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S4_v17 (Il2CppMethodInfo)+C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v18+60]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v19+48]");
			object obj13 = 0;
			object obj14 = obj13 & 0x7FF;
			object obj15 = obj14 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S5_v15 (should have been resolved before IL gen)");
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v32 (Il2CppClass<Flurry>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num5 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v36 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return;
		}
		string entry2 = UserData.GetEntry((Dictionary<string, string>)(object)_localData, (string)(object)_cloudData);
		if (entry2 == null)
		{
			return;
		}
		ResolveToTheirs();
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S4_v12 (Il2CppMethodInfo)+C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S4_v13+60]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S4_v14+48]");
		object obj19 = 0;
		object obj20 = obj19 & 0x7FF;
		object obj21 = obj20 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v106 @ S5_v11 (should have been resolved before IL gen)");
		nint num7 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v21 (Il2CppClass<Flurry>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num8 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v24 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public void ResolveToTheirs()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
	}

	public List<CloudSaveComparisonRow> GetComparisonRows()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		List<CloudSaveComparisonRow> result = default;
		return result;
	}

	private void DetermineRecommendation()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
	}

	private static float Evaluate(float localValue, float cloudValue, float factor)
	{
		//IL_002c: Expected Obj, but got I4
		bool flag = cloudValue < localValue;
		bool flag2 = cloudValue != factor;
		object obj = flag & flag2;
		if (obj != null)
		{
			return cloudValue;
		}
		return localValue;
	}

	private static void Log(string logMessage)
	{
		//IL_001d: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I
		char firstChar = logMessage.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [logMessage @ L0 (System.String)+10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S2_v2 (System.Char)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S3_v2+8]");
		object obj2 = num - 0;
		float num2 = 0f + (float)obj2;
		char firstChar2 = logMessage.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S2_v6 (System.Char)+C]");
		float num3 = 0f * 2E-05f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [logMessage @ L0 (System.String)+10]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S3_v6+C]");
		float num4 = 0f * 2E-05f;
		float num5 = num3 - num4;
		float num6 = num2 + num5;
		char firstChar3 = logMessage.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v11 (System.Char)+10]");
		float num7 = 0f * 0.05f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [logMessage @ L0 (System.String)+10]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v11+10]");
		float num8 = 0f * 0.05f;
		float num9 = num7 - num8;
		float num10 = num6 + num9;
		char firstChar4 = logMessage.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v16 (System.Char)+14]");
		float num11 = 0f * 3f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [logMessage @ L0 (System.String)+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S3_v16+14]");
		float num12 = 0f * 3f;
		float num13 = num11 - num12;
		float num14 = num10 + num13;
		char firstChar5 = logMessage.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [logMessage @ L0 (System.String)+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v21 (System.Char)+28]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S3_v20+28]");
		object obj7 = num15 - 0;
		float num16 = num14 + (float)obj7;
		char firstChar6 = logMessage.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S2_v25 (System.Char)+18]");
		float num17 = 0f * 10f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [logMessage @ L0 (System.String)+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S3_v24+18]");
		float num18 = 0f * 10f;
		float num19 = num17 - num18;
		float num20 = num16 + num19;
		char firstChar7 = logMessage.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S2_v30 (System.Char)+20]");
		float num21 = 0f * 8f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [logMessage @ L0 (System.String)+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S3_v29+20]");
		float num22 = 0f * 8f;
		float num23 = num21 - num22;
		float num24 = num20 + num23;
		char firstChar8 = logMessage.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S2_v35 (System.Char)+1C]");
		float num25 = 0f * 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [logMessage @ L0 (System.String)+10]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S3_v34+1C]");
		float num26 = 0f * 5f;
		float num27 = num25 - num26;
		float num28 = num24 + num27;
		char firstChar9 = logMessage.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S2_v40 (System.Char)+24]");
		float num29 = 0f * 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [logMessage @ L0 (System.String)+10]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S3_v39+24]");
		float num30 = 0f * 5f;
		float num31 = num29 - num30;
		float num32 = num28 + num31;
	}
}
