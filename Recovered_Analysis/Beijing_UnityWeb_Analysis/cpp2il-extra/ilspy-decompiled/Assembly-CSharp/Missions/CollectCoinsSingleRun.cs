using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Data.Save;
using SYBO.Subway;
using UI.Screens;
using UnityEngine;

namespace Missions;

public class CollectCoinsSingleRun : Award
{
	private int _progress;

	private int _offset;

	public CollectCoinsSingleRun(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler)
	{
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_00ef: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder2 = default;
		System.Text.StringBuilderCache.Release(stringBuilder2);
		StringBuilder stringBuilder3 = stringBuilder.AppendLine("Award");
		StringBuilder stringBuilder4 = stringBuilder.Append(59);
		StringBuilder stringBuilder5 = stringBuilder.AppendLine("Tier");
		StringBuilder stringBuilder6 = stringBuilder2.AppendLine((string)(object)awardData);
		StringBuilder stringBuilder7 = stringBuilder2.Append(59);
		StringBuilder stringBuilder8 = stringBuilder2.Append(savedProgress);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v31 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v49 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		StringBuilder stringBuilder9 = stringBuilder.Append(59);
		StringBuilder stringBuilder10 = stringBuilder.AppendLine("Time");
		StringBuilder stringBuilder11 = stringBuilder2.Append(59);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int index = default;
		StringBuilder stringBuilder12 = stringBuilder2.FindChunkForIndex(index);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
	}

	protected override int GetProgressForGoal(AwardGoal goal)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_0466: Expected Obj, but got I4
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_026b: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I
		//IL_03ba: Expected Obj, but got I
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I4
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got Unknown
		//IL_04d1: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_04e6: Expected Obj, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0210: Expected Obj, but got I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected I4, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01b4: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		((AwardsManager)(object)this).SaveAllAwards();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = obj;
		object obj6 = default;
		object obj14 = default;
		int result = default;
		object obj29 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v88+8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v92+24]");
				if ((nint)0 != 1)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v88+C]");
				object obj9;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v88+C]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v140+10]");
					obj9 = 0;
				}
				else
				{
					obj9 = 0;
				}
				object obj10 = obj9 + 12;
				object obj15;
				for (obj5 = 0; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10); obj15 = obj5 + 1, obj5 = obj15)
				{
					object obj11 = obj9 + 16;
					object obj12 = obj5 << 2;
					object obj13 = obj11 + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj14 == null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v112+14]");
					if (0 != (nint)goal)
					{
						continue;
					}
					goto IL_04d6;
				}
				continue;
			}
			object obj16 = obj4 + 4;
			object obj17 = obj16 + 1;
			obj16 = obj17;
			object obj18 = obj17 << 2;
			object obj19 = obj4 + obj18;
			obj19 = 141;
			break;
			IL_04d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v88+1C]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v123+10]");
			if ((nint)0 != 1)
			{
				object obj21 = obj4 + 4;
				object obj22 = obj21 + 1;
				obj21 = obj22;
				object obj23 = obj22 << 2;
				object obj24 = obj4 + obj23;
				obj24 = 143;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj25 = obj4 + 4;
				object obj26 = obj25 + 1;
				obj25 = obj26;
				object obj27 = obj26 << 2;
				object obj28 = obj4 + obj27;
				obj28 = 143;
				result = obj29 ^ 1;
			}
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj30 = (nint)0 << 2;
			object obj31 = obj4 + obj30;
			if ((nint)obj31 == 143)
			{
				object obj32 = obj4 + 4;
				if ((nint)obj32 > -1)
				{
					object obj33 = obj32 + -1;
					obj32 = obj33;
				}
				goto IL_0598;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj34 = (nint)0 << 2;
			object obj35 = obj4 + obj34;
			if ((nint)obj35 == 141)
			{
				object obj36 = obj4 + 4;
				if ((nint)obj36 > -1)
				{
					object obj37 = obj36 + -1;
					obj36 = obj37;
				}
				goto IL_0598;
			}
		}
		object obj38 = default;
		if (obj38 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0598;
		IL_0598:
		return result;
	}

	public override bool IsGoalAccomplished(AwardGoal goal)
	{
		return (byte)(_progress - _offset) != 0;
	}

	protected override void ActivateCurrentAwardTier()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 54)
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

	protected unsafe override void DeactivateCurrentAwardTier()
	{
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_014c: Expected I, but got Obj
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<int> action = default;
		object obj = action + 16;
		obj = this;
		((GameStats)(object)privacyPolicyUrl).OnCoinsIncreased -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(CollectCoinsSingleRun.OnRunStarted);
		object obj2 = action2 + 16;
		obj2 = this;
		nint num2 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v14 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v46 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr2;
		((Delegate)action3).method = (nint)__ldftn(CollectCoinsSingleRun.OnRunEnded);
		object obj4 = action3 + 16;
		obj4 = this;
		GameOverScreen.onGameOverScreenShown -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action4 = default;
		object obj5 = action4 + 16;
		obj5 = this;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v36 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v42 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnNavigatedToScreen -= action4;
		RewardPayedOut();
	}

	private void OnFrontScreen(string screenName)
	{
		//IL_002b: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		int completedRunCount = PlayerSave.completedRunCount;
		int stringLength = screenName.m_stringLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenName @ L1 (System.String)+1C]");
		object obj = 0;
		char firstChar = screenName.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S3_v2 (System.Char)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenName @ L1 (System.String)+1C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenName @ L1 (System.String)+18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v5+8]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S4_v3+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S4_v4+48]");
		object obj6 = 0;
		object obj7 = obj6 & 0x7FF;
		object obj8 = obj7 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S5_v4 (should have been resolved before IL gen)");
	}

	protected unsafe override void RecordNewOffsets()
	{
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_007f: Expected I, but got Obj
		//IL_0138: Expected I, but got Obj
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CollectCoinsSingleRun.OnCoinsIncreased);
		object obj = action + 16;
		obj = this;
		((GameStats)(object)privacyPolicyUrl).OnScoreChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<bool, bool, bool, bool> action2 = default;
		object obj2 = action2 + 16;
		obj2 = this;
		nint num2 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v14 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v45 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnRunStarted += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		GameOverScreen gameOverScreen = default;
		((UnityEngine.Object)gameOverScreen).m_CachedPtr = cachedPtr;
		((UIScreen)gameOverScreen)._selectedFooterButton = 0;
		object obj4 = gameOverScreen + 16;
		obj4 = this;
		gameOverScreen.OnEnable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj5 = action3 + 16;
		obj5 = this;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v36 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v41 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnWillShowScreen += action3;
	}

	private void OnRunStarted()
	{
	}

	private void OnRunEnded()
	{
		_offset = 0;
		_progress = 0;
	}

	private void OnCoinsIncreased(int count)
	{
		//IL_002e: Expected Obj, but got I4
		if ((string)count != "FrontScreen")
		{
			_offset = 0;
			_progress = 0;
		}
	}

	private void ResetProgress()
	{
		RewardPayedOut();
	}
}
