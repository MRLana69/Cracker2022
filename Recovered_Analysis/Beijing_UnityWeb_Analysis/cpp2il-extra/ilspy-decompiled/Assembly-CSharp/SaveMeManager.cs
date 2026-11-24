using System;
using System.Collections;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Missions;
using SYBO.Subway;
using UI.Screens;
using UnityEngine;

public static class SaveMeManager
{
	private static readonly int NUMBER_OF_RUNS_BEFORE_SAVE_ME_FUNCTIONALITY;

	private static int _numberOfUsedKeysInCurrentRun;

	private static bool _hasReviveWithAdsBeenAvailableInCurrentRun;

	public static bool isPurchaseMadeFromIngame;

	public static bool isPurchaseRunningIngame;

	private static bool WatchedReviveAdInCurrentRun__BackingField;

	private static int SaveMePopupCountInCurrentRun__BackingField;

	private static int ReviveCountInCurrentRun__BackingField;

	public unsafe static bool WatchedReviveAdInCurrentRun
	{
		get
		{
			//IL_01a4: Expected I, but got Obj
			//IL_01ba: Expected Obj, but got I
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Expected I, but got Unknown
			//IL_0303: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_01f2: Expected I, but got Obj
			//IL_020d: Expected I, but got Obj
			//IL_0223: Expected Obj, but got I
			//IL_0265: Expected I, but got Obj
			//IL_027b: Expected Obj, but got I
			//IL_0298: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_02bc: Expected Obj, but got I
			//IL_02c4: Expected Obj, but got I4
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			//IL_016b: Expected I, but got Obj
			//IL_0191: Expected I, but got Obj
			nint num = (nint)typeof(SuperSneakers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SuperSneakers>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SuperSneakers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v54 (Il2CppClass<SuperSneakers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 4);
			bool flag = (object)SuperSneakers.instance == null;
			bool flag2 = !flag;
			bool result = (byte)(int)SuperSneakers.instance != 0;
			if (!flag2)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<System.Type>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v50 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(SuperSneakers);
				((IntPtr*)num3)->m_value = (void*)(nint)obj2;
				Type type = Type.internal_from_handle((IntPtr)num3);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((UnityEngine.Object)(object)type).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				nint num8 = (nint)typeof(SuperSneakers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<SuperSneakers>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				bool flag3 = obj5 == null;
				nint num9 = (nint)typeof(SuperSneakers);
				if (!flag3)
				{
					nint num10 = (nint)typeof(SuperSneakers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v44 (Il2CppClass<SuperSneakers>)+74]");
					bool flag4 = (nint)0 == 0;
					bool flag5 = !flag4;
					num9 = (nint)typeof(SuperSneakers);
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num9 = (nint)typeof(SuperSneakers);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ L0_v8 (Il2CppClass<SuperSneakers>)+5C]");
				object obj6 = (nint)0 + (nint)4;
				bool flag6 = default;
				obj6 = flag6;
				result = flag6;
			}
			return result;
		}
		set
		{
			_ = 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
	}

	public static int SaveMePopupCountInCurrentRun
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return WatchedReviveAdInCurrentRun__BackingField ? 1 : 0;
		}
		private set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = value & 1;
			WatchedReviveAdInCurrentRun__BackingField = (byte)num3 != 0;
		}
	}

	public static int ReviveCountInCurrentRun
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return SaveMePopupCountInCurrentRun__BackingField;
		}
		private set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveMePopupCountInCurrentRun__BackingField = value;
		}
	}

	public static bool IsRevivalVideoCached
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)ReviveCountInCurrentRun__BackingField != 0;
		}
	}

	static SaveMeManager()
	{
	}

	public unsafe static void IncrementNumberOfUsedKeys()
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I4
		//IL_00d5: Expected I, but got Obj
		//IL_00eb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		NUMBER_OF_RUNS_BEFORE_SAVE_ME_FUNCTIONALITY = 4;
		_numberOfUsedKeysInCurrentRun = 1;
		_hasReviveWithAdsBeenAvailableInCurrentRun = false;
		isPurchaseMadeFromIngame = false;
		isPurchaseRunningIngame = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)(delegate*<void>)(&HandleOnMenuScreenShown);
		object obj = action + 16;
		obj = 0;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v27 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v32 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnMenuScreenShown -= action;
	}

	public static void IncrementSaveMePopupCountInCurrentRun()
	{
		//IL_012c: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00df: Expected I, but got Obj
		//IL_0079: Expected I, but got Obj
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _numberOfUsedKeysInCurrentRun < 1;
		nint num3 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v5 (Il2CppClass<SaveMeManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag2 = obj2 != null;
		if (flag)
		{
			if (flag2)
			{
				nint num4 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v30 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_numberOfUsedKeysInCurrentRun = 1;
			return;
		}
		if (flag2)
		{
			nint num5 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v20 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int numberOfUsedKeysInCurrentRun = _numberOfUsedKeysInCurrentRun << 1;
		_numberOfUsedKeysInCurrentRun = numberOfUsedKeysInCurrentRun;
	}

	public static void IncrementRevivalCountInCurrentRun()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72B2");
		object obj3 = default;
		object obj2 = obj3 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72B3");
	}

	public static int GetNumberOfKeysToSaveMe()
	{
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		OfferWallManager instance = OfferWallManager.instance;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v10 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return ((AdSystemManager)(object)instance).IsCaching((string)(object)AdLocations.REVIVAL_VIDEOS) ? 1 : 0;
	}

	public static bool IsReviveWithAdsAvailable()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)_numberOfUsedKeysInCurrentRun != 0;
	}

	public static void ResetSaveMeForNewRun()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72B5");
		object obj3 = default;
		object obj2 = obj3 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72B6");
	}

	public static bool IsSaveMePopupEnabled()
	{
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected I4, but got Unknown
		//IL_0062: Expected I, but got Obj
		bool isInitialized = AdSystemManager.isInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+D]");
		if ((nint)0 != 0)
		{
			return false;
		}
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v17 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72B9");
		object obj2 = default;
		return (byte)(obj2 ^ 1) != 0;
	}

	public static void SkipReviveIfPurchaseFailed()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_numberOfUsedKeysInCurrentRun = 1;
		_hasReviveWithAdsBeenAvailableInCurrentRun = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72B3");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72BB");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72B6");
	}

	public static void SendReviveIfPurchaseSucceeded()
	{
		//IL_02cb: Expected I, but got Obj
		//IL_02e1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0311: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0107: Expected I, but got Obj
		//IL_011d: Expected Obj, but got I
		//IL_0148: Expected I, but got Obj
		//IL_0195: Expected I, but got Obj
		//IL_01ab: Expected Obj, but got I
		//IL_0366: Expected I, but got Obj
		//IL_037c: Expected Obj, but got I
		//IL_0401: Expected I, but got Obj
		//IL_0417: Expected Obj, but got I
		//IL_01d6: Expected I, but got Obj
		//IL_0223: Expected I, but got Obj
		//IL_0270: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v79 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController instance = UIScreenController.Instance;
		if ((object)instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v75 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		if (!((string)(object)enumerator != "IngameUI"))
		{
			return;
		}
		nint num5 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v23 (Il2CppClass<SaveMeManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v69 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(isPurchaseMadeFromIngame ? 1u : 0u) != 0)
		{
			return;
		}
		nint num7 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v31 (Il2CppClass<SaveMeManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v63 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		isPurchaseMadeFromIngame = false;
		isPurchaseRunningIngame = false;
		nint num9 = (nint)typeof(Revive);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v41 (Il2CppClass<Revive>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(Revive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v59 (Il2CppClass<Revive>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceToken = RemoteNotificationControl.GetDeviceToken();
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)deviceToken).FindKernel((string)null) != 0)
		{
			((Revive)(object)deviceToken)._002Ector();
		}
	}

	private static void HandleOnMenuScreenShown()
	{
		//IL_0668: Expected I, but got Obj
		//IL_067e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_06ae: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0143: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_0184: Expected I, but got Obj
		//IL_01da: Expected I, but got Obj
		//IL_01f0: Expected Obj, but got I
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected Obj, but got Unknown
		//IL_031c: Expected I, but got Obj
		//IL_0332: Expected Obj, but got I
		//IL_021b: Expected I, but got Obj
		//IL_079a: Expected I, but got Obj
		//IL_07b0: Expected Obj, but got I
		//IL_0268: Expected I, but got Obj
		//IL_027e: Expected Obj, but got I
		//IL_08f4: Expected I, but got Obj
		//IL_090a: Expected Obj, but got I
		//IL_035d: Expected I, but got Obj
		//IL_076a: Expected I4, but got Obj
		//IL_03aa: Expected I, but got Obj
		//IL_0309: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_02a9: Expected I, but got Obj
		//IL_04d2: Expected I, but got Obj
		//IL_04e8: Expected Obj, but got I
		//IL_03f7: Expected I, but got Obj
		//IL_0831: Expected I, but got Obj
		//IL_0847: Expected Obj, but got I
		//IL_0444: Expected I, but got Obj
		//IL_045a: Expected Obj, but got I
		//IL_0876: Expected Obj, but got I4
		//IL_0887: Expected Obj, but got I4
		//IL_0513: Expected I, but got Obj
		//IL_0814: Expected Obj, but got I4
		//IL_05b7: Expected I, but got Obj
		//IL_05cd: Expected Obj, but got I
		//IL_0560: Expected I, but got Obj
		//IL_0485: Expected I, but got Obj
		//IL_05f8: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v152 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController instance = UIScreenController.Instance;
		if ((object)instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v148 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		bool flag2;
		if (enumerator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v20 (System.Collections.IEnumerator)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (flag2 || !string.Equals((string)(object)enumerator, "IngameUI"))
		{
			return;
		}
		nint num5 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v26 (Il2CppClass<SaveMeManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v138 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(isPurchaseMadeFromIngame ? 1u : 0u) != 0)
		{
			return;
		}
		int coins = InventorySave.coins;
		nint num7 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v10 (Il2CppClass<SaveMeManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v41 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72BF");
		object obj6 = default;
		object obj5 = coins - obj6;
		if ((nint)obj5 >= 0)
		{
			nint num9 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v126 (Il2CppClass<SaveMeManager>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v134 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72BF");
			int amount = default;
			InventorySave.LogEarnedEvent(amount, (InAppItemModel.ItemType)"InRun", "N/A");
			StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72BF");
			PersistentAwardProgress savedProgress = default;
			((OwnBoardsAward)(object)instance2)._002Ector((AwardStaticData)71, savedProgress, (Action<Award>)(-1));
		}
		nint num11 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v39 (Il2CppClass<SaveMeManager>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num12 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v119 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		isPurchaseMadeFromIngame = false;
		isPurchaseRunningIngame = false;
		nint num13 = (nint)typeof(Revive);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v49 (Il2CppClass<Revive>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num14 = (nint)typeof(Revive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v115 (Il2CppClass<Revive>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceToken = RemoteNotificationControl.GetDeviceToken();
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v111 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)deviceToken).FindKernel((string)null) != 0)
		{
			nint num17 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v102 (Il2CppClass<SaveMeManager>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num18 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v107 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = IsSaveMePopupEnabled();
			((SocialManager)(object)deviceToken).WWWUnregisterDeviceCompleted(SocialManager.WWWRequestResult.Success, (string)flag3, (object)null);
		}
		nint num19 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v64 (Il2CppClass<SaveMeManager>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num20 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v97 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IncrementSaveMePopupCountInCurrentRun();
		ResetSaveMeForNewRun();
		nint num21 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v71 (Il2CppClass<UIScreenController>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num22 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v93 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator screenName = ((UIScreenController)flag4).DelayHideMainCamera();
		UIScreen uIScreen = ((UIScreenController)flag4)._ActivateScreen((string)(object)screenName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num23 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v80 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num24 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v89 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj15 = default;
		if (obj15 != null)
		{
			SDebug.LogFormat("IngameScreen == NULL", null);
		}
		else
		{
			((IngameScreen)obj15).OnHeadstartActivated(1);
		}
	}
}
