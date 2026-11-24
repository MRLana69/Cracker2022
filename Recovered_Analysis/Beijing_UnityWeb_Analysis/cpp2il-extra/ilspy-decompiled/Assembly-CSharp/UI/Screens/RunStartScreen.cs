using System;
using System.Collections;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Components.Analytics.Integration;
using SYBO.Subway;
using SYBO.Subway.Promotion;
using TopRun.Internal;
using UnityEngine;

namespace UI.Screens;

public abstract class RunStartScreen : UIScreen
{
	public virtual void StartRun()
	{
		//IL_0166: Expected I, but got Obj
		//IL_017c: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I4
		//IL_009e: Invalid comparison between VT and I8
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_012e: Expected I8, but got VT
		//IL_013a: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		bool isCurrentPromotionActive = ((PromotionManager)(object)this).IsCurrentPromotionActive;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!((UnityEngine.Object)isCurrentPromotionActive != null))
		{
			long expireTimeUnix = ((PromotionDefinition)isCurrentPromotionActive).ExpireTimeUnix;
			TimeSpan timeLeft = ((PromotionDefinition)isCurrentPromotionActive).TimeLeft;
			DateTime randomisedPlayerIdExpiry = ((Manager)null).GetRandomisedPlayerIdExpiry();
			CoroutineUtil.StopCoroutine((Coroutine)(nint)((UnityEngine.Object)this).m_CachedPtr);
			CoroutineUtil.StopCoroutine((Coroutine)showOldFooterSection);
			if (randomisedPlayerIdExpiry < (object)expireTimeUnix)
			{
				object obj2 = this + 8;
				IEnumerator enumerator = ((PromotionManager)(object)this).ExpireTimer(expireTimeUnix);
				obj2 = enumerator;
				Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(nint)((UnityEngine.Object)this).m_CachedPtr);
			}
			if (randomisedPlayerIdExpiry < timeLeft)
			{
				object obj3 = this + 12;
				bool flag = ((AnalyticsIntegration)(object)this).IsTicksSinceLastActiveOverForegroundChangeThreshold((long)timeLeft);
				obj3 = flag;
				Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])showOldFooterSection);
			}
		}
	}

	private void StartRunAfterBreak()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		bool isInitialized = AdSystemManager.isInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		object obj3 = (isInitialized ? 1 : 0) + 16;
		obj3 = obj2;
		bool isInitialized2 = AdSystemManager.isInitialized;
		((PokiUnitySDK)isInitialized2).rewardedBreak();
	}

	protected RunStartScreen()
	{
		//IL_033e: Expected I, but got Obj
		//IL_0354: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0388: Expected I, but got Obj
		//IL_039e: Expected Obj, but got I
		//IL_03c5: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_042e: Expected I, but got Obj
		//IL_0444: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0473: Expected Obj, but got I4
		//IL_0481: Expected I, but got Obj
		//IL_0497: Expected Obj, but got I
		//IL_020a: Expected I, but got Obj
		//IL_0408: Expected Obj, but got I4
		//IL_04cb: Expected Obj, but got I4
		//IL_04d9: Expected I, but got Obj
		//IL_04ef: Expected Obj, but got I
		//IL_0257: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_02a4: Expected I, but got Obj
		//IL_02f1: Expected I, but got Obj
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v82 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.RefreshOnlineSettingsAndInappsIfNeeded();
		bool touchSupported = Input.touchSupported;
		if ((touchSupported ? 1 : 0) > (true ? 1 : 0))
		{
			return;
		}
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v78 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)isInstantiated).FindKernel(null) == 0)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v68 (Il2CppClass<UIScreenController>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v74 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).SwitchScreen("GameOverScreen");
			return;
		}
		nint num9 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v25 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v63 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		((SSEventsManagerController)(object)flurryUserId).CurrentEventHasBeenTriedNow();
		nint num11 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v32 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v59 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated2 = Game.IsInstantiated;
		((Game)isInstantiated2).Update();
		nint num13 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v39 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num14 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v55 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).SwitchScreen("IngameUI");
		nint num15 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v46 (Il2CppClass<SaveMeManager>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num16 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v51 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveMeManager.SkipReviveIfPurchaseFailed();
	}
}
