using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using InAppPurchase;
using Info;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Extensions;
using Kiloo.Common.Utility;
using Missions;
using SYBO.Subway.Info;
using UI.FreeStuff;
using UI.MessageCenter;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI.Screens;

public class BoardBundlePopupManager
{
	private sealed class _003CStartTimer_003Ed__32(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BoardBundlePopupManager _003C_003E4__this;

		public long endTime;

		private long _003CcurrentTime_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d5: Expected Obj, but got Unknown
				//IL_00de: Expected Obj, but got I4
				//IL_00f2: Expected Obj, but got I4
				BoardBundlePopupManager boardBundlePopupManager = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					long currentTimestamp = ((PromotionManager)null).GetCurrentTimestamp();
					_003CcurrentTime_003E5__2 = currentTimestamp;
				}
				if (_003CcurrentTime_003E5__2 < endTime)
				{
					long currentTimestamp2 = ((PromotionManager)null).GetCurrentTimestamp();
					_003CcurrentTime_003E5__2 = currentTimestamp2;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				TransformExtensions.Reset((Transform)(object)boardBundlePopupManager.m_onBoardBundleStartedHandler);
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

	private sealed class _003CExpireTimer_003Ed__33(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BoardBundlePopupManager _003C_003E4__this;

		public long endTime;

		private long _003CcurrentTime_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d5: Expected Obj, but got Unknown
				//IL_00de: Expected Obj, but got I4
				//IL_00f2: Expected Obj, but got I4
				BoardBundlePopupManager boardBundlePopupManager = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					long currentTimestamp = ((PromotionManager)null).GetCurrentTimestamp();
					_003CcurrentTime_003E5__2 = currentTimestamp;
				}
				if (_003CcurrentTime_003E5__2 < endTime)
				{
					long currentTimestamp2 = ((PromotionManager)null).GetCurrentTimestamp();
					_003CcurrentTime_003E5__2 = currentTimestamp2;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				TransformExtensions.Reset((Transform)(object)boardBundlePopupManager.m_onBoardBundleExpiredHandler);
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

	private Action m_onBoardBundleStartedHandler;

	private Action m_onBoardBundleExpiredHandler;

	public const string BUNDLE_TIER_01 = "com.kiloo.subwayboard.mumbai.bundletier1";

	public const string BUNDLE_TIER_02 = "com.kiloo.subwayboard.mumbai.bundletier2";

	public readonly string BUNDLE_BOARD;

	public readonly HoverboardThemes.ThemeIdentifier firstCustomSet;

	public readonly HoverboardThemes.ThemeIdentifier secondCustomSet;

	private readonly Boards.BoardId BOARD_TYPE;

	private const bool BOARD_BUNDLE_ACTIVE = false;

	private IEnumerator _startTimerCoroutine;

	private IEnumerator _endTimerCoroutine;

	private Action _onSuccess;

	private static BoardBundlePopupManager _instance;

	public static BoardBundlePopupManager instance
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a2: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (BoardBundlePopupManager)((ComputeShader)(object)UI.MessageCenter.MessageCenter._instance).FindKernel((string)null);
		}
	}

	public event Action onBoardBundleStartedHandler
	{
		add
		{
			//IL_02bf: Expected I, but got Obj
			//IL_02d5: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_021b: Expected I, but got Obj
			//IL_0231: Expected Obj, but got I
			//IL_01a8: Expected I, but got Obj
			//IL_0054: Expected I, but got Obj
			//IL_02ac: Expected Obj, but got I4
			//IL_0125: Expected I, but got Obj
			//IL_0290: Expected Obj, but got I4
			//IL_00ba: Expected I, but got Obj
			if (value != null)
			{
				nint num = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v23 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v46 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool allAssetBundlesDownloaded = UserSave.allAssetBundlesDownloaded;
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v9 (Il2CppClass<UIScreenController>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				bool flag = obj2 != null;
				if (allAssetBundlesDownloaded)
				{
					if (flag)
					{
						nint num4 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v42 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag2 = UIScreenController.ShouldShowOnlineScreen();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					string text = default;
					text.m_stringLength = 13;
					_ = 1;
					((UIScreenController)flag2)._QueueMessage(text);
				}
				else
				{
					if (flag)
					{
						nint num5 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag3 = UIScreenController.ShouldShowOnlineScreen();
					((UIScreenController)flag3).QueuePopup("FBPromotionPopup");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.BoardBundlePopupManager)+4F]");
				if ((nint)0 != 0)
				{
					((AwardsScreen)this).QueueFacebookFailSlideIn((Action)null);
				}
			}
			nint num6 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v8 (Il2CppClass<HouseKeeper>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v15 (Il2CppClass<HouseKeeper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HouseKeeper.DeleteSoundOptionBeforeVideoAds();
			_ = 0;
			((AwardsScreen)this).Show();
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onBoardBundleStartedHandler;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
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

	public event Action onBoardBundleExpiredHandler
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onBoardBundleStartedHandler;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onBoardBundleExpiredHandler;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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

	private BoardBundlePopupManager()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 72;
		object obj2 = default;
		obj = obj2;
		((UpgradeScreen)this).Start();
	}

	public unsafe Boards.BoardId GetBoardType()
	{
		//IL_0176: Expected I, but got Obj
		//IL_018c: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_022e: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I4
		AwardTierType awardTierType = default;
		((AwardTierType*)(int)awardTierType)->value__ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		nint num = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v34 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MissionsManager missionsManager = MissionsManager.Instance;
		int numberOfFinishedAwardsExactTier = ((AwardsManager)(object)missionsManager).GetNumberOfFinishedAwardsExactTier(awardTierType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AwardCell awardCell = default;
		awardCell.cellType = AwardCellType.TITLE;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.BoardBundlePopupManager)+48]");
		((List<AwardCell>)0).Add(awardCell);
		int num3 = 0;
		AwardCell awardCell2 = default;
		while (true)
		{
			int num4 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v18 (System.Int32)+C]");
			if ((nint)num4 >= (nint)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Award award = ((List<Award>)numberOfFinishedAwardsExactTier).get_Item(num3);
			PersistentAwardProgress savedProgress = award.savedProgress;
			AwardCellType cellType;
			if (savedProgress.currentActiveAwardState == AwardState.Finished)
			{
				Award award2 = ((List<Award>)numberOfFinishedAwardsExactTier).get_Item(num3);
				cellType = ((~(award2.isInPreview__BackingField ? 1u : 0u) == 0) ? AwardCellType.AWARD : AwardCellType.FINISHED_AWARD);
			}
			else
			{
				cellType = AwardCellType.AWARD;
			}
			awardCell2.cellType = cellType;
			object obj2 = awardCell2 + 12;
			Award award3 = ((List<Award>)numberOfFinishedAwardsExactTier).get_Item(num3);
			obj2 = award3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.BoardBundlePopupManager)+48]");
			((List<AwardCell>)0).Add(awardCell2);
			int num5 = num3 + 1;
			num3 = num5;
		}
		return (((AwardTierType*)(int)awardTierType)->value__ != 0) ? Boards.BoardId.bouncer : Boards.BoardId.normal;
	}

	public unsafe void DebugModeChanged()
	{
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02be: Expected I, but got Obj
		//IL_02d4: Expected Obj, but got I
		//IL_030e: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_01e8: Expected I, but got Obj
		//IL_01fe: Expected Obj, but got I
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected Obj, but got Unknown
		//IL_03a3: Expected Obj, but got I4
		//IL_03af: Expected Obj, but got I4
		//IL_0229: Expected I, but got Obj
		ref InAppItemModel reference = ref *(InAppItemModel*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(BoardBundlePopupManager.StartTimer);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v80 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action;
		((BoardScreen)this).Init();
		nint num3 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v74 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!InAppData.inAppData.TryGetValue("com.kiloo.subwayboard.mumbai.bundletier2", out reference))
		{
			return;
		}
		int num5 = 0;
		HoverboardThemes.ThemeIdentifier themeIdentifier2 = default;
		while (true)
		{
			InAppItemModel inAppItemModel = reference;
			List<InAppItemModel.BundleItem> bundleContents = inAppItemModel.bundleContents;
			if (num5 >= bundleContents._size)
			{
				break;
			}
			InAppItemModel inAppItemModel2 = reference;
			InAppItemModel.BundleItem bundleItem = inAppItemModel2.bundleContents.get_Item(num5);
			bool flag = bundleItem.type__BackingField == InAppItemModel.ItemType.Board;
			InAppItemModel inAppItemModel3 = reference;
			InAppItemModel.BundleItem bundleItem2 = inAppItemModel3.bundleContents.get_Item(num5);
			if (flag)
			{
				HoverboardThemes.ThemeIdentifier themeIdentifier = bundleItem2.themeIdentifier;
				BOARD_TYPE = (Boards.BoardId)themeIdentifier;
			}
			else if (bundleItem2.type__BackingField == InAppItemModel.ItemType.BoardAbility)
			{
				InAppItemModel inAppItemModel4 = reference;
				InAppItemModel.BundleItem bundleItem3 = inAppItemModel4.bundleContents.get_Item(num5);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A235");
				if (num5 == 1)
				{
					firstCustomSet = themeIdentifier2;
				}
				else
				{
					secondCustomSet = themeIdentifier2;
				}
			}
			int num6 = num5 + 1;
			num5 = num6;
		}
		nint num7 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v42 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v48 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 16;
		bool flag2 = InAppData.IsUsingCustomIapIdForBoard((Boards.Board)BOARD_TYPE);
		obj5 = flag2;
	}

	public bool IsBoardBundleSaleActive()
	{
		return (byte)BOARD_TYPE != 0;
	}

	public bool ShouldButtonBeVisible()
	{
		//IL_0132: Expected I, but got Obj
		//IL_0148: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ENABLE_BOARD_BUNDLE ? 1u : 0u) == 0)
		{
			return true;
		}
		nint num3 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v5 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v14 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!CharacterManager.IsCharacterOwned((Characters.CharacterId)BOARD_TYPE))
		{
			long boardBundleExpireTimestamp = GetBoardBundleExpireTimestamp();
			TimeSpan timeLeft = GetTimeLeft();
			long currentTimestamp = ((PromotionManager)null).GetCurrentTimestamp();
		}
		return false;
	}

	public string GetBundleIconName()
	{
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (BoardManager.HasAllThemesBeenSeen(BOARD_TYPE))
		{
			return null;
		}
		bool flag = ShouldButtonBeVisible();
		return (string)flag;
	}

	public long GetBoardBundleStartTimestamp()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I8, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (long)UserSave.lastTimeAppWasUpdatedOrInstalled;
	}

	public long GetBoardBundleExpireTimestamp()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got VT
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v16 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TimeSpan timeSpan = BoardManager.BoardExpirationTimespan(BOARD_TYPE);
		nint num3 = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v12 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v21 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = timeSpan;
		string text = (string)(obj3 + 8);
		text = (string)obj3;
		return TimeUtility.RFC1123StringToUnixTime(text);
	}

	public TimeSpan GetTimeLeft()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got VT
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_010b: Expected VT, but got I8
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v16 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime dateTime = BoardManager.BoardStartAvailabilityDate(BOARD_TYPE);
		nint num3 = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v12 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v21 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = dateTime;
		string text = (string)(obj3 + 8);
		text = (string)obj3;
		return (TimeSpan)TimeUtility.RFC1123StringToUnixTime(text);
	}

	public void PurchaseBoardBundle(string productId, Action onSuccess)
	{
		((RewardForVideoButton)this).OnVideoWatched(false);
	}

	private unsafe void OnPurchaseFailedOrCancelled(string id, PurchaseResult result)
	{
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I4
		//IL_01a2: Expected I, but got Obj
		//IL_01b8: Expected Obj, but got I
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0180: Expected I4, but got Obj
		object obj = this + 40;
		obj = result;
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v22 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
		((Delegate)onPurchaseSuccess).method_ptr = method_ptr;
		((Delegate)onPurchaseSuccess).method = (nint)__ldftn(BoardBundlePopupManager.OnPurchaseSuccess);
		object obj3 = onPurchaseSuccess + 16;
		obj3 = this;
		((InAppManager)(object)activeInAppOffers).onPurchaseSuccess -= onPurchaseSuccess;
		Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		InAppManager.OnPurchaseCanceled onPurchaseCanceled = default;
		((Delegate)onPurchaseCanceled).method_ptr = method_ptr2;
		((Delegate)onPurchaseCanceled).method = (nint)__ldftn(BoardBundlePopupManager.OnPurchaseFailedOrCancelled);
		object obj4 = onPurchaseCanceled + 16;
		obj4 = this;
		((InAppManager)(object)activeInAppOffers2).onPurchaseCanceled -= onPurchaseCanceled;
		Dictionary<string, InAppItemModel> activeInAppOffers3 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		InAppManager.OnPurchaseFailure onPurchaseFailure = default;
		((Delegate)onPurchaseFailure).method_ptr = method_ptr3;
		((Delegate)onPurchaseFailure).method = (nint)__ldftn(BoardBundlePopupManager.OnPurchaseFailedOrCancelled);
		object obj5 = onPurchaseFailure + 16;
		obj5 = this;
		((InAppManager)(object)activeInAppOffers3).onPurchaseFailure -= onPurchaseFailure;
		Dictionary<string, InAppItemModel> activeInAppOffers4 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		InAppManager.OnPurchaseItemNotAvailable onPurchaseItemNotAvailable = default;
		((Delegate)onPurchaseItemNotAvailable).method_ptr = method_ptr4;
		((Delegate)onPurchaseItemNotAvailable).method = (nint)__ldftn(BoardBundlePopupManager.OnPurchaseFailedOrCancelled);
		object obj6 = onPurchaseItemNotAvailable + 16;
		obj6 = this;
		((InAppManager)(object)activeInAppOffers4).onPurchaseItemNotAvailable -= onPurchaseItemNotAvailable;
		Dictionary<string, InAppItemModel> activeInAppOffers5 = InAppManager.GetActiveInAppOffers();
		((InAppManager)(object)activeInAppOffers5).InitFinishedCallback((byte)(int)id != 0);
	}

	private void OnPurchaseSuccess(string productid, bool wasrestored, IPurchaseValidationResult validationresult)
	{
		//IL_0169: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00d3: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I
		//IL_0114: Expected I, but got Obj
		bool flag = WelcomePackManager.IsWelcomePackActive();
		bool flag2 = productid != (string)flag;
		object obj = (flag2 ? 1 : 0) ^ 1;
		object obj2 = obj | wasrestored;
		if (obj2 != null)
		{
			return;
		}
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v32 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.BoardBundlePopupManager)+44]");
		object obj4 = 0;
		bool flag4 = flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v9+24]");
		((UIScreenController)flag4).ShowUnlockAnimationForHoverboardBundle(Boards.BoardId.normal, (List<HoverboardThemes.ThemeIdentifier>)(object)productid);
		if (validationresult == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj5 = default;
		if ((nint)obj5 != 1)
		{
			return;
		}
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v25 (Il2CppClass<Flurry>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v28 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void StartTimer()
	{
		//IL_0081: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ENABLE_BOARD_BUNDLE ? 1u : 0u) == 0)
		{
			TransformExtensions.Reset((Transform)(object)this.m_onBoardBundleStartedHandler);
		}
		else
		{
			TransformExtensions.Reset((Transform)(object)this.m_onBoardBundleExpiredHandler);
		}
	}

	private IEnumerator StartTimer(long endTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 2;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator ExpireTimer(long endTime)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private long GetCurrentTimestamp()
	{
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		TimeSpan timeLeft = GetTimeLeft();
		long currentTimestamp = ((PromotionManager)null).GetCurrentTimestamp();
		nint num = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v7 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = timeLeft - currentTimestamp;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
		long result = default;
		return result;
	}

	private static void LogErr(string msg, UnityEngine.Object context = null)
	{
		//IL_002d: Expected Obj, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		Delegate obj = (Delegate)msg.m_firstChar;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)context);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = msg + 12;
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

	private static void Log(string msg, UnityEngine.Object context = null)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[BoardBundle] ", (int)msg);
		SDebug.LogFormat(msg2, (object[])(object)context);
	}

	unsafe static BoardBundlePopupManager()
	{
		//IL_1146: Unknown result type (might be due to invalid IL or missing references)
		//IL_114b: Expected Obj, but got Unknown
		//IL_115d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1162: Expected Obj, but got Unknown
		//IL_1174: Unknown result type (might be due to invalid IL or missing references)
		//IL_1179: Expected Obj, but got Unknown
		//IL_1190: Expected I, but got Obj
		//IL_11a6: Expected Obj, but got I
		//IL_11e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e9: Expected Obj, but got Unknown
		//IL_11fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1200: Expected Obj, but got Unknown
		//IL_1229: Unknown result type (might be due to invalid IL or missing references)
		//IL_122e: Expected Obj, but got Unknown
		//IL_1240: Unknown result type (might be due to invalid IL or missing references)
		//IL_1245: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_009b: Expected I, but got Obj
		//IL_00b1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_1265: Unknown result type (might be due to invalid IL or missing references)
		//IL_126a: Expected Obj, but got Unknown
		//IL_12ab: Expected I, but got Obj
		//IL_12c1: Expected Obj, but got I
		//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ec: Expected Obj, but got Unknown
		//IL_1303: Expected Obj, but got I4
		//IL_1321: Unknown result type (might be due to invalid IL or missing references)
		//IL_1326: Expected VT, but got Unknown
		//IL_1333: Expected I4, but got Obj
		//IL_132e: Expected native int or pointer, but got VT
		//IL_1349: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Expected Obj, but got Unknown
		//IL_1364: Unknown result type (might be due to invalid IL or missing references)
		//IL_1369: Expected Obj, but got Unknown
		//IL_137e: Expected I4, but got Obj
		//IL_1379: Expected native int or pointer, but got VT
		//IL_1387: Expected Obj, but got VT
		//IL_00dc: Expected I, but got Obj
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I4
		//IL_01af: Expected I4, but got Obj
		//IL_01aa: Expected native int or pointer, but got VT
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_0129: Expected I, but got Obj
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_01ff: Expected I4, but got Obj
		//IL_01fa: Expected native int or pointer, but got VT
		//IL_0208: Expected Obj, but got VT
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0235: Expected I4, but got Obj
		//IL_0230: Expected native int or pointer, but got VT
		//IL_023e: Expected Obj, but got VT
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_026c: Expected Obj, but got I4
		//IL_028e: Expected I4, but got Obj
		//IL_0289: Expected native int or pointer, but got VT
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02d9: Expected I4, but got Obj
		//IL_02d4: Expected native int or pointer, but got VT
		//IL_02e2: Expected Obj, but got VT
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0310: Expected Obj, but got I4
		//IL_0332: Expected I4, but got Obj
		//IL_032d: Expected native int or pointer, but got VT
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_0382: Expected I4, but got Obj
		//IL_037d: Expected native int or pointer, but got VT
		//IL_038b: Expected Obj, but got VT
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected Obj, but got Unknown
		//IL_03b8: Expected I4, but got Obj
		//IL_03b3: Expected native int or pointer, but got VT
		//IL_03c1: Expected Obj, but got VT
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_03ef: Expected Obj, but got I4
		//IL_0411: Expected I4, but got Obj
		//IL_040c: Expected native int or pointer, but got VT
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected Obj, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_045c: Expected I4, but got Obj
		//IL_0457: Expected native int or pointer, but got VT
		//IL_0465: Expected Obj, but got VT
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0493: Expected Obj, but got I4
		//IL_04b5: Expected I4, but got Obj
		//IL_04b0: Expected native int or pointer, but got VT
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_0505: Expected I4, but got Obj
		//IL_0500: Expected native int or pointer, but got VT
		//IL_0512: Expected Obj, but got VT
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		VideoButtonPayload videoButtonPayload = default;
		object obj = videoButtonPayload + 12;
		obj = "icon_upgrades_hoverboard";
		object obj2 = videoButtonPayload + 28;
		obj2 = "FREE_STUFF_VIDEO_REWARD_HOVERBOARD_TITLE";
		object obj3 = videoButtonPayload + 32;
		obj3 = "FREE_STUFF_VIDEO_REWARD_HOVERBOARD_FORMAT";
		nint num = (nint)typeof(RewardForVideoButtonHelper._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20 (Il2CppClass<UI.FreeStuff.RewardForVideoButtonHelper+<>c>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(RewardForVideoButtonHelper._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v441 (Il2CppClass<UI.FreeStuff.RewardForVideoButtonHelper+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = RewardForVideoButtonHelper._003C_003Ec._003C_003E9;
		object obj7 = videoButtonPayload + 20;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		object obj9 = default;
		object obj8 = obj9 + 16;
		obj8 = RewardForVideoButtonHelper._003C_003Ec._003C_003E9;
		object obj10 = videoButtonPayload + 16;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj12 = default;
		object obj11 = obj12 + 16;
		obj11 = RewardForVideoButtonHelper._003C_003Ec._003C_003E9;
		object obj13 = videoButtonPayload + 24;
		obj13 = obj12;
		nint num6 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v66 (Il2CppClass<AdLocations>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num7 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v435 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj15 = videoButtonPayload + 36;
		obj15 = AdLocations.HOVERBOARD_FREE_VIDEOS;
		videoButtonPayload.rewardType__BackingField = CelebrationRewardType.powerup;
		videoButtonPayload.upgradeType__BackingField = UpgradeType.hoverboard;
		videoButtonPayload.unlockItemSource__BackingField = UnlockItemSource.FreeHoverboards;
		nint num8 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v76 (Il2CppClass<UI.ColorData>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num9 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v431 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj18 = default;
		object obj17 = obj18 + 416;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj19 = (flag ? 1 : 0) + 92;
		obj17 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v50+8]");
		_ = 0;
		Color32 color = (Color32)(obj18 + 496);
		((Color32*)(nint)color)->rgba = (int)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v81+8]");
		_ = 0;
		object obj20 = obj18 + 408;
		Color color2 = color;
		object obj21 = obj18 + 492;
		obj21 = obj20;
		((Color32*)(nint)color)->rgba = (int)obj21;
		Color32 firstColorDark = ((VideoButtonPayload)color).firstColorDark;
		object obj22 = obj18 + 392;
		bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj23 = (flag2 ? 1 : 0) + 124;
		obj22 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v70+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v93+8]");
		_ = 0;
		object obj24 = obj18 + 388;
		Color color3 = color;
		object obj25 = obj18 + 488;
		obj25 = obj24;
		((Color32*)(nint)color)->rgba = (int)obj25;
		Color32 firstHighlightColor = ((VideoButtonPayload)color).firstHighlightColor;
		object obj26 = obj18 + 484;
		Color32 color4 = RewardForVideoButtonHelper.SunHighlight();
		((Color32*)(nint)color)->rgba = (int)obj26;
		Color32 secondColor = ((VideoButtonPayload)color).secondColor;
		object obj27 = obj18 + 368;
		bool flag3 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj28 = (flag3 ? 1 : 0) + 316;
		obj27 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S1_v94+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v108+8]");
		_ = 0;
		object obj29 = obj18 + 360;
		Color color5 = color;
		object obj30 = obj18 + 480;
		obj30 = obj29;
		((Color32*)(nint)color)->rgba = (int)obj30;
		Color32 secondColorDark = ((VideoButtonPayload)color).secondColorDark;
		object obj31 = obj18 + 344;
		bool flag4 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj32 = (flag4 ? 1 : 0) + 556;
		obj31 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S1_v113+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v119+8]");
		_ = 0;
		object obj33 = obj18 + 336;
		Color color6 = color;
		object obj34 = obj18 + 476;
		obj34 = obj33;
		((Color32*)(nint)color)->rgba = (int)obj34;
		Color32 secondHighlightColor = ((VideoButtonPayload)color).secondHighlightColor;
		VideoButtonPayload videoButtonPayload2 = (VideoButtonPayload)(obj18 + 472);
		videoButtonPayload2._002Ector();
		((Color32*)(nint)color)->rgba = (int)videoButtonPayload2;
		Color32 titleColor = ((VideoButtonPayload)color).titleColor;
		object obj35 = obj18 + 320;
		bool flag5 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj36 = (flag5 ? 1 : 0) + 268;
		obj35 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S1_v137+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v134+8]");
		_ = 0;
		object obj37 = obj18 + 312;
		Color color7 = color;
		object obj38 = obj18 + 468;
		obj38 = obj37;
		((Color32*)(nint)color)->rgba = (int)obj38;
		Color32 descriptionColor = ((VideoButtonPayload)color).descriptionColor;
		object obj39 = obj18 + 296;
		bool flag6 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj40 = (flag6 ? 1 : 0) + 604;
		obj39 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S1_v156+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S0_v145+8]");
		_ = 0;
		object obj41 = obj18 + 288;
		Color color8 = color;
		object obj42 = obj18 + 464;
		obj42 = obj41;
		((Color32*)(nint)color)->rgba = (int)obj42;
		videoButtonPayload.flurryName = (string)color;
		object obj43 = videoButtonPayload + 84;
		obj43 = "Hoverboards";
		throw new ArrayTypeMismatchException();
	}
}
