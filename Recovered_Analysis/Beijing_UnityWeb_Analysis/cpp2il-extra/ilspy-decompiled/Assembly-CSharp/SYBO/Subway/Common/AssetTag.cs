using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Benchmarking;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Benchmarking.Processors;
using UI.Generic.Layout;
using UI.Screens;
using UI.Screens.PauseScreenInternal;
using UI.Screens.RewardManagement;
using UnityEngine;
using UnityEngine.Networking;

namespace SYBO.Subway.Common;

public class AssetTag : MonoBehaviour
{
	private AssetTagThemeUsage _themeUsage;

	public AssetTagThemeUsage ThemeUsage
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			AssetTagThemeUsage assetTagThemeUsage = default;
			object obj = assetTagThemeUsage + 16;
			obj = this;
			return assetTagThemeUsage;
		}
	}

	public bool HasTag(AssetTagThemeUsage themeTags)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I4
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I4
		//IL_0280: Expected I4, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CertificateHandler certificateHandler = default;
		certificateHandler.Release();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 66)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				goto IL_027b;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_027b;
		IL_027b:
		return (byte)(int)certificateHandler != 0;
	}

	public void AddTags(AssetTagThemeUsage themeTags)
	{
		//IL_0047: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_011c: Expected Obj, but got I4
		//IL_000f: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I
		//IL_009a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Common.AssetTag)+1C]");
		if ((nint)0 != 0)
		{
			List<string> routine = ((GoogleSheetsProcessor)(object)this).Serialize((IBenchmarkMetric[])themeTags);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Common.AssetTag)+18]");
			Coroutine coroutine = ((MonoBehaviour)0).StartCoroutine_Auto((IEnumerator)routine);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Common.AssetTag)+18]");
		string obj = ((Component)0).tag;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj);
		object obj3 = this + 24;
		obj3 = 0;
	}

	public void ClearTags(AssetTagThemeUsage themeTags)
	{
		AssetTagThemeUsage themeUsage = _themeUsage | themeTags;
		_themeUsage = themeUsage;
	}

	public AssetTag()
	{
		//IL_0272: Expected I, but got Obj
		//IL_0288: Expected Obj, but got I
		//IL_0302: Expected I, but got Obj
		//IL_0318: Expected Obj, but got I
		//IL_03aa: Expected I, but got Obj
		//IL_03c0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I4
		//IL_01ca: Expected I, but got Obj
		//IL_01e0: Expected Obj, but got I
		//IL_020b: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Common.AssetTag)+28]");
		bool dEBUG_DISPLAY_ALL_CHARS = (nint)0 != 0;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v77 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Globals.DEBUG_DISPLAY_ALL_CHARS = dEBUG_DISPLAY_ALL_CHARS;
		nint num3 = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v71 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreen.forceRefreshOnCharacterScreen = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Common.AssetTag)+29]");
		bool dEBUG_DISPLAY_ALL_BOARDS = (nint)0 != 0;
		Globals.DEBUG_DISPLAY_ALL_BOARDS = dEBUG_DISPLAY_ALL_BOARDS;
		nint num5 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v26 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v67 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		((UnityEngine.Object)instance).m_CachedPtr = (IntPtr)1;
		if (~(Globals.DEBUG_USE_CELEBRATION_TESTER ? 1u : 0u) != 0)
		{
			nint num7 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v40 (Il2CppClass<RewardManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v63 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PurchaseHandler instance2 = PurchaseHandler.Instance;
			if ((nint)instance2 < 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
				dailyChallengeRewardHelper.Refresh();
				((UnityEngine.Object)dailyChallengeRewardHelper).m_CachedPtr = (IntPtr)1;
				dailyChallengeRewardHelper._checkmark = (UISprite)1;
				dailyChallengeRewardHelper._rewardLayout = (Layout)1;
				nint num9 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v54 (Il2CppClass<RewardManager>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v59 (Il2CppClass<RewardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				RewardManager.AddMysteryBoxToUnlock((CelebrationReward)(object)dailyChallengeRewardHelper);
			}
		}
		((SubwayBenchmark)(object)this).Terminate();
	}
}
