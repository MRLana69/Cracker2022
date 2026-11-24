using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.UI;
using Kiloo.Plugins.Facebook;
using Missions;
using SYBO.Subway.Info;
using UI.ModelCamera;
using UI.Popups.ConsumablesPopupInternal;
using UI.Popups.LimitedCharacterPopupInternal;
using UI.Popups.SecretPopupInternal;
using UnityEngine;

namespace UI.Screens;

public class AwardsScreen : UIScreen
{
	public class AwardListAdapter : ListAdapter<AwardCell>
	{
		public GameObject finishedAwardPrefab;

		public GameObject awardPrefab;

		public GameObject titlePrefab;

		public AwardsScreen screenReference;

		private const int AWARD_TITLE_PREFAB = 0;

		private const int AWARD_CELL_PREFAB = 1;

		private const int AWARD_FINISHED_CELL_PREFAB = 2;

		public AwardListAdapter(List<AwardCell> awardList, GameObject awardCell, GameObject finishedAwardCell, GameObject titleCell, AwardsScreen screenReference)
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected Obj, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected Obj, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected Obj, but got Unknown
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
			object obj6 = this + 16;
			obj6 = awardCell;
			object obj7 = this + 28;
			obj7 = finishedAwardCell;
			object obj8 = this + 20;
			obj8 = titleCell;
			object obj9 = this + 24;
			obj9 = screenReference;
		}

		public override int GetModelType(int index)
		{
			//IL_001b: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+190]");
			return ((string)0 != "mission_progress_dot_completed") ? 1 : 0;
		}

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_02f3: Expected Obj, but got I
			//IL_02f3: Expected Obj, but got I
			//IL_00c1: Expected I4, but got Obj
			//IL_0315: Expected Obj, but got I
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected Obj, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected Obj, but got Unknown
			//IL_012a: Expected I4, but got Obj
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected Obj, but got Unknown
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected Obj, but got Unknown
			//IL_0193: Expected I4, but got Obj
			//IL_0360: Expected Obj, but got I
			//IL_0360: Expected Obj, but got I
			//IL_0360: Expected Obj, but got I
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Expected Obj, but got Unknown
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Expected Obj, but got Unknown
			//IL_01fc: Expected I4, but got Obj
			//IL_0375: Expected Obj, but got I
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Expected Obj, but got Unknown
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Container container2 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
				object obj2 = default;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
						if ((nint)0 != 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
							if ((nint)0 == 3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								Container container3 = default;
								container3.Measure((byte)(int)screenReference != 0);
								object obj = obj2 + 8;
								SecretHelper component = container3.model.GetComponent<SecretHelper>();
								obj = component;
								object obj3 = container3 + 84;
								obj3 = obj2;
								container2 = container3;
							}
							else
							{
								container2 = null;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							Container container4 = default;
							container4.Measure((byte)(int)titlePrefab != 0);
							object obj4 = obj2 + 8;
							SecretHelper component2 = container4.model.GetComponent<SecretHelper>();
							obj4 = component2;
							object obj5 = container4 + 84;
							obj5 = obj2;
							container2 = container4;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Container container5 = default;
						container5.Measure((byte)(int)awardPrefab != 0);
						object obj6 = obj2 + 8;
						SecretHelper component3 = container5.model.GetComponent<SecretHelper>();
						obj6 = component3;
						object obj7 = container5 + 84;
						obj7 = obj2;
						container2 = container5;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Container container6 = default;
					container6.Measure((byte)(int)finishedAwardPrefab != 0);
					object obj8 = obj2 + 8;
					SecretHelper component4 = container6.model.GetComponent<SecretHelper>();
					obj8 = component4;
					object obj9 = container6 + 84;
					obj9 = obj2;
					container2 = container6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
						if ((nint)0 == 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v15+8]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+C]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+10]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+18]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+1C]");
							((ModelScreenData)num)._002Ector((GameObject)num2, (Camera)num3, (Characters.CharacterId)num4, 0);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							string text = default;
							string msg = "No cell type match for: " + text;
							SDebug.LogFormat(msg, null);
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v15+8]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+14]");
					((LimitedCharacterPopupManager)num5).currentThemeIndex = 0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v15+8]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+C]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+10]");
				((SellConsumablesHelper)num6).ShowVideoForConsumable((byte)num7 != 0, (Action)0);
			}
			return container2;
		}
	}

	private GameObject _awardPrefab;

	private GameObject _finishedAwardPrefab;

	private GameObject _titlePrefab;

	private ScrollView _awardListView;

	private UIPanel _scrollPanel;

	public UIPanel _scrollBarPanel;

	private int _indexOnHide;

	private AwardListAdapter _adapter;

	private List<AwardCell> _contentList;

	private bool _isSubscribedToChangedScreen;

	private bool _isReturningFromCelebration;

	private bool _containsCollectableAward;

	private bool _facebookLoginRunning;

	private bool _hasSetiPhoneXOffsetsIfNecessary;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	private void RefreshAwards()
	{
		//IL_01a2: Expected I, but got Obj
		//IL_01b8: Expected Obj, but got I
		//IL_005c: Expected I, but got Obj
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0125: Expected I, but got Obj
		ShowIfInactive();
		PopupClosed("AwardsScreen");
		if (_contentList != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			FriendsOnlineScreen.CollectCoinsListAdapter collectCoinsListAdapter = default;
			collectCoinsListAdapter._002Ector((List<CollectCoinsCell>)(object)_contentList, _awardPrefab, _finishedAwardPrefab, _titlePrefab, (FriendsOnlineScreen)(object)this);
			object obj = this + 68;
			obj = collectCoinsListAdapter;
		}
		nint num = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v11 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v43 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IPhoneXSupport.CheckIsiPhoneXDevice() || ~(_hasSetiPhoneXOffsetsIfNecessary ? 1u : 0u) == 0)
		{
			return;
		}
		UIPanel scrollPanel = _scrollPanel;
		UIRect.AnchorPoint topAnchor = scrollPanel.topAnchor;
		nint num3 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v26 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v37 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int absolute = topAnchor.absolute - IPhoneXSupport.OFFSET_TOP;
		topAnchor.absolute = absolute;
		UIPanel scrollPanel2 = _scrollPanel;
		UIRect.AnchorPoint bottomAnchor = scrollPanel2.bottomAnchor;
		int absolute2 = IPhoneXSupport.OFFSET_BOTTOM + bottomAnchor.absolute;
		bottomAnchor.absolute = absolute2;
		_hasSetiPhoneXOffsetsIfNecessary = true;
	}

	public override void Show()
	{
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0082: Expected I4, but got Obj
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00c6: Expected VT, but got Obj
		Boards.BoardId boardType = ((BoardBundlePopupManager)(object)this).GetBoardType();
		bool containsCollectableAward = (byte)(boardType & Boards.BoardId.bouncer) != 0;
		_containsCollectableAward = containsCollectableAward;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_awardListView).FindKernel((string)null) != 0 && _adapter != null)
		{
			_awardListView.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
			if (~(_containsCollectableAward ? 1u : 0u) != 0)
			{
				object obj2 = this - -64;
				_awardListView.SmoothScrollToOffset((Vector3)obj2, (Action)null, 0f);
			}
		}
	}

	public override void GainFocus()
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0092: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		base.Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v23 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnNavigatedToScreen -= action;
		FacebookLoginClicked();
		Show();
	}

	public override void LoseFocus()
	{
		FacebookLoginClicked();
		Show();
	}

	public override void Hide()
	{
	}

	private unsafe void ForceUpdateAnchors()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected I4, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0342: Expected Obj, but got I4
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got Unknown
		//IL_03a3: Expected I, but got Obj
		//IL_03b9: Expected Obj, but got I
		//IL_0419: Expected I, but got Obj
		//IL_042f: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0505: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0094: Expected I, but got Obj
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0130: Expected I, but got Obj
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected Obj, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_04bd: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		AwardTierType awardTierType = (AwardTierType)(obj2 + 40);
		((AwardTierType*)(int)awardTierType)->value__ = 0;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj5 = action + 16;
		obj5 = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v30 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v128 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnWillShowScreen += action;
		Container lastVisibleContainerOnScreen = _awardListView.GetLastVisibleContainerOnScreen();
		if (lastVisibleContainerOnScreen != null)
		{
			object obj7 = this - -64;
			object obj8 = lastVisibleContainerOnScreen - -64;
			obj7 = obj8;
		}
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v40 (Il2CppClass<UIScreenController>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v122 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		if (((UIScreenController)flag).IsPopupQueueEmpty())
		{
			return;
		}
		((AwardTierType*)(int)awardTierType)->value__ = 0;
		nint num6 = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v52 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num7 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v118 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MissionsManager instance = MissionsManager.Instance;
		int numberOfFinishedAwardsExactTier = ((AwardsManager)(object)instance).GetNumberOfFinishedAwardsExactTier(awardTierType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj11 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
		}
		object obj13 = obj4 + 4;
		object obj14 = obj13 + 1;
		obj13 = obj14;
		object obj15 = obj14 << 2;
		object obj16 = obj4 + obj15;
		obj16 = 132;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj4 + obj17;
			if ((nint)obj18 == 132)
			{
				object obj19 = obj4 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				return;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void OnScreenChanged(string screen)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		if (screen != null)
		{
			return;
		}
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 13;
		_ = 0;
		((UIScreenController)flag)._QueueMessage(text);
	}

	private void PopupClosed(string popupName)
	{
		//IL_01d2: Expected I4, but got Obj
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_0185: Expected I, but got Obj
		//IL_00a8: Expected I, but got Obj
		char c = popupName.get_Chars((int)"AwardsScreen");
		bool isSubscribedToChangedScreen = _isSubscribedToChangedScreen;
		if (c != '\0')
		{
			if (!isSubscribedToChangedScreen)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			UIScreenController uIScreenController = default;
			((UnityEngine.Object)uIScreenController).m_CachedPtr = cachedPtr;
			uIScreenController.popupAnchor = (GameObject)0;
			object obj = uIScreenController + 16;
			obj = this;
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v42 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uIScreenController.Awake();
			_isReturningFromCelebration = false;
			_isSubscribedToChangedScreen = false;
		}
		else
		{
			if (isSubscribedToChangedScreen)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			Action<string> action = default;
			object obj3 = action + 16;
			obj3 = this;
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v20 (Il2CppClass<UIScreenController>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v26 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIScreenController.OnPopupClosed -= action;
			_isSubscribedToChangedScreen = true;
		}
	}

	public void FacebookLoginClicked()
	{
		_scrollPanel.ResetAndUpdateAnchors();
		_scrollPanel.ResetAnchors();
	}

	public void OnFacebookLoginResult(bool loggedIn)
	{
		//IL_0023: Expected Obj, but got I4
		if ((string)loggedIn != "CelebrationPopup")
		{
			_isReturningFromCelebration = true;
		}
	}

	private void OnFailSlideInFinish()
	{
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01d1: Expected I, but got Obj
		//IL_01e7: Expected Obj, but got I
		//IL_0227: Expected I, but got Obj
		//IL_023d: Expected Obj, but got I
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_029b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_02bb: Expected Obj, but got I4
		//IL_02bb: Expected Obj, but got I4
		//IL_0107: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		nint num2 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<HouseKeeper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v51 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7855");
		_facebookLoginRunning = true;
		nint num4 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppClass<SocialManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v47 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = this;
		if (SocialManager.IsOAuthException((FacebookError)facebookDialogsSupported, obj6))
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v37 (Il2CppClass<UIScreenController>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v43 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).QueueMessage((string)1);
		}
		Container lastVisibleContainerOnScreen = _awardListView.GetLastVisibleContainerOnScreen();
		if (lastVisibleContainerOnScreen != null)
		{
			object obj8 = this - -64;
			object obj9 = lastVisibleContainerOnScreen - -64;
			obj8 = obj9;
		}
	}

	private void QueueFacebookFailSlideIn(Action onFinishCallback)
	{
		//IL_004f: Expected Obj, but got I4
		if (onFinishCallback == null && ~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			_facebookLoginRunning = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			((AwardsScreen)null).FacebookStatusChanged(flag);
		}
	}

	private void FacebookStatusChanged(bool success)
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 13;
		_ = 0;
		object obj2 = text + 24;
		obj2 = success;
		((UIScreenController)flag)._QueueMessage(text);
	}

	private bool SetListContent()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	public AwardsScreen()
	{
		((BoardBundlePopupManager)(object)this).onBoardBundleStartedHandler += null;
	}
}
