using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo;
using Kiloo.Common.UI;
using TopRun.Internal;
using UI.Screens;
using UnityEngine;

namespace TopRun.UI;

public class TopRunOnlineScreen : UIScreen
{
	public class TopRunListAdapter : ListAdapter<TopRunCell>
	{
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			public TopRunCell topRunCell;

			internal void _003CGetContainer_003Eb__0()
			{
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Expected Obj, but got Unknown
				//IL_0043: Expected Obj, but got I4
				TopRunCell topRunCell = this.topRunCell;
				if (topRunCell.OnUpdateCell != null)
				{
					object obj = topRunCell + 28;
					obj = 0;
				}
			}
		}

		public GameObject playerPrefab;

		public GameObject rankHeaderPrefab;

		public GameObject spacePrefab;

		public GameObject emptyCell;

		public GameObject facebookButton;

		private const int PLAYER_PREFAB = 0;

		private const int RANK_PREFAB = 1;

		private const int SPACE_CELL = 2;

		private const int EMPTY_CELL = 3;

		private const int FACEBOOK_BUTTON = 4;

		public TopRunListAdapter(List<TopRunCell> topRunListT, GameObject playerCell, GameObject headerCell, GameObject spaceCell, GameObject emptyCellPrefab, GameObject _facebookButton)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v4 (Il2CppClass<Il2CppRgctx<Kiloo.Common.UI.ListAdapter`1<TopRunCell>>>)+4] (should have been resolved before IL gen)");
			playerPrefab = playerCell;
			rankHeaderPrefab = headerCell;
			spacePrefab = spaceCell;
			emptyCell = emptyCellPrefab;
			facebookButton = _facebookButton;
		}

		public void SetNewDataList(List<TopRunCell> topRunListT)
		{
			//IL_0029: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.UI.TopRunOnlineScreen+TopRunListAdapter)+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.UI.TopRunOnlineScreen+TopRunListAdapter)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S0_v9+C] (should have been resolved before IL gen)");
			}
		}

		public override int GetModelType(int index)
		{
			//IL_0005: Expected I, but got Obj
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_004d: Expected I, but got Obj
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected Obj, but got Unknown
			//IL_0095: Expected I, but got Obj
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected Obj, but got Unknown
			//IL_00dd: Expected I, but got Obj
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected Obj, but got Unknown
			nint num = (nint)this;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S2_v2 (Il2CppClass<TopRun.UI.TopRunOnlineScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v3+8]");
			bool flag = (nint)0 == 1;
			int result = 2;
			if (!flag)
			{
				nint num2 = (nint)this;
				object obj2 = this + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v7 (Il2CppClass<TopRun.UI.TopRunOnlineScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v10+8]");
				bool flag2 = (nint)0 == 0;
				result = 1;
				if (!flag2)
				{
					nint num3 = (nint)this;
					object obj3 = this + 72;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S2_v11 (Il2CppClass<TopRun.UI.TopRunOnlineScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v15+8]");
					bool flag3 = (nint)0 == 3;
					result = 3;
					if (!flag3)
					{
						nint num4 = (nint)this;
						object obj4 = this + 72;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S2_v15 (Il2CppClass<TopRun.UI.TopRunOnlineScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v19+8]");
						bool flag4 = (nint)0 == 7;
						return (int)((flag4 ? 1u : 0u) << 2);
					}
				}
			}
			return result;
		}

		public unsafe override Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_061a: Expected I, but got Obj
			//IL_0647: Expected Obj, but got I
			//IL_03ef: Expected Obj, but got I
			//IL_0418: Expected Obj, but got I
			//IL_0015: Expected Obj, but got I
			//IL_043c: Expected Obj, but got I
			//IL_047d: Expected Obj, but got I
			//IL_047d: Expected Obj, but got I
			//IL_05ee: Expected Obj, but got I
			//IL_060b: Expected Obj, but got I
			//IL_0289: Expected Obj, but got I
			//IL_04a0: Expected Obj, but got I
			//IL_04bb: Expected Obj, but got I
			//IL_053c: Expected Obj, but got I
			//IL_0551: Expected Obj, but got I
			//IL_05bc: Expected Obj, but got I
			//IL_059c: Expected Obj, but got I
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S3_v2 (Il2CppClass<TopRun.UI.TopRunOnlineScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
			Container container2 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v58+8]");
				object tag = default;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v58+8]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v58+8]");
						if ((nint)0 != 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v58+8]");
							if ((nint)0 == 3)
							{
								Container container3 = default;
								container3._002Ector(emptyCell);
								TopRunEmptyCell component = container3.model.GetComponent<TopRunEmptyCell>();
								container3.tag = tag;
								container2 = container3;
								goto IL_0637;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v58+8]");
							if ((nint)0 != 4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v58+8]");
								if ((nint)0 != 5)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v58+8]");
									if ((nint)0 != 6)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v58+8]");
										if ((nint)0 == 7)
										{
											Container container4 = default;
											container4._002Ector(facebookButton);
											FacebookLoginButtonOnline component2 = container4.model.GetComponent<FacebookLoginButtonOnline>();
											ResizeWidgetOnLoginFB_TopRun component3 = container4.model.GetComponent<ResizeWidgetOnLoginFB_TopRun>();
											container4.tag = tag;
											container2 = container4;
											goto IL_0637;
										}
									}
								}
							}
						}
						Container container5 = default;
						container5._002Ector(playerPrefab);
						TopRunPlayerCell component4 = container5.model.GetComponent<TopRunPlayerCell>();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+8]");
						object obj2 = 0;
						container5.tag = tag;
						Action action = default;
						object obj3 = default;
						action._002Ector(obj3, (nint)__ldftn(_003C_003Ec__DisplayClass13_0._003CGetContainer_003Eb__0));
						container5.onRecycleContainer = action;
						container2 = container5;
					}
					else
					{
						Container container6 = default;
						container6._002Ector(spacePrefab);
						container2 = container6;
					}
				}
				else
				{
					Container container7 = default;
					container7._002Ector(rankHeaderPrefab);
					RankHeader component5 = container7.model.GetComponent<RankHeader>();
					container7.tag = tag;
					container2 = container7;
				}
			}
			goto IL_0637;
			IL_0637:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v11+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v11+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v11+8]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v11+8]");
						if ((nint)0 != 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v11+8]");
							if ((nint)0 != 4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v11+8]");
								if ((nint)0 != 5)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v11+8]");
									if ((nint)0 != 6)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v11+8]");
										if ((nint)0 == 7)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
											SocialManager instance = SocialManager.instance;
											bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
											SocialManager instance2 = SocialManager.instance;
											bool gamecenterIsLoggedIn = instance2.gamecenterIsLoggedIn;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v40+10]");
											((FacebookLoginButtonOnline)0).Init(facebookIsLoggedIn, isNoBonus: true, isAwardsSpecific: false, gamecenterIsLoggedIn, isTopRunSpecific: true);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+8]");
											object obj5 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v45+1A]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v40+14]");
												((ResizeWidgetOnLoginFB_TopRun)0).SetEmptyWidgetSize(0, 0);
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v40+14]");
												((ResizeWidgetOnLoginFB_TopRun)0).SetEmptyWidgetSize(284, 50);
											}
											container2.isMeasured = false;
											return container2;
										}
									}
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+8]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v36+C]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v21+C]");
						((TopRunEmptyCell)num2).InitCell(0);
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+8]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v22+18]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v14+14]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v14+18]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v14+C]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v14+19]");
						((TopRunPlayerCell)num3).InitCell((IPlayer)num4, (byte)num5 != 0, (int)num6, isLocalUserT: false);
						if (!isMeasurePass)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+8]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v22+18]");
							Action action2 = default;
							action2._002Ector(0, (nint)__ldftn(TopRunPlayerCell.Refresh));
							return container2;
						}
					}
				}
				return container2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v15+8]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v8+C]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v8+10]");
			((RankHeader)num7).InitHeader((int)num8, 0);
			return container2;
		}
	}

	private sealed class _003CAnimateMedalAfterSeconds_003Ed__30(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public TopRunOnlineScreen _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					int myIndexInTheList = _003C_003E4__this.GetMyIndexInTheList();
					if (myIndexInTheList >= 0)
					{
						TopRunPlayerCell playerScriptFromList = _003C_003E4__this.GetPlayerScriptFromList();
						if (playerScriptFromList != null)
						{
							playerScriptFromList.AnimateMedalIfNeeded();
						}
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			UIScreenController instance = UIScreenController.Instance;
			instance.justPaidOutTopRun = false;
			_ = seconds;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private ScrollView _topRunListView;

	private UILabel _titleLabel;

	private UISprite _flagSrite;

	private UILabel _countryLabel;

	private GameObject _playerPrefab;

	private GameObject _rankHeaderPrefab;

	private GameObject _spaceCell;

	private GameObject _emptyCell;

	private GameObject _facebookLogInButton;

	private GameObject _normalState;

	private GameObject _resultState;

	private GameObject _offlineState;

	public GameObject loadingOverlay;

	private UIPanel _scrollPanel;

	private UIPanel _scrollBarPanel;

	private TopRunListAdapter _adapter;

	private TopRunStates _currentState = TopRunStates.OFFLINE;

	private bool _isLoading = true;

	private List<TopRunCell> _contentList;

	private int noMedalRankThreshold;

	private const int NORMAL_STATE_NORMAL_OFFSET = -9;

	private const int NORMAL_STATE_RESULTS_OFFSET = -110;

	private const int SCROLL_PANEL_NORMAL_OFFSET = -5;

	private const int SCROLL_PANEL_RESULTS_OFFSET = -15;

	private const int POSITION_OFFSET_IN_LIST = 2;

	public override void Init()
	{
		//IL_004b: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<TopRun.UI.TopRunOnlineScreen>)+104] (should have been resolved before IL gen)");
		SetListContent();
		if (_contentList != null)
		{
			TopRunListAdapter topRunListAdapter = default;
			topRunListAdapter._002Ector(_contentList, _playerPrefab, _rankHeaderPrefab, _spaceCell, _emptyCell, _facebookLogInButton);
			_adapter = topRunListAdapter;
		}
	}

	private void TournamentChanged(object sender, EventArgs eventArg)
	{
		GameObject gameObject = base.gameObject;
		if (!gameObject.activeSelf)
		{
			return;
		}
		GameObject gameObject2 = base.gameObject;
		if (gameObject2.activeInHierarchy)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			if (obj == null)
			{
				_isLoading = false;
				TopRunRewardHelper.RefreshPendingResults();
				SetCurrentState();
				RefreshAdapterIfDataChanged();
			}
		}
	}

	private void OnApplicationResumed()
	{
		_isLoading = true;
		UIScreenController instance = UIScreenController.Instance;
		if (~(instance.justPaidOutTopRun ? 1u : 0u) != 0)
		{
			loadingOverlay.SetActive(value: true);
		}
		SetCurrentState();
		UIScreenController instance2 = UIScreenController.Instance;
		if (~(instance2.justPaidOutTopRun ? 1u : 0u) != 0)
		{
			RefreshOrFetchNewTournament();
		}
	}

	private void RefreshAdapterIfDataChanged()
	{
		if (_adapter != null)
		{
			SetListContent();
			if (_contentList != null)
			{
				_adapter.SetNewDataList(_contentList);
			}
			SetScreenTop_UI();
			ForceUpdateAnchors();
		}
		ScrollToMyPosition();
		loadingOverlay.SetActive(value: false);
		UIScreenController instance = UIScreenController.Instance;
		if (~(instance.justPaidOutTopRun ? 1u : 0u) != 0)
		{
			IEnumerator routine = AnimateMedalAfterSeconds(0.5f);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator AnimateMedalAfterSeconds(float seconds)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private TopRunPlayerCell GetPlayerScriptFromList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		TopRunListAdapter adapter = _adapter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			TopRunPlayerCell result;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					result = null;
					goto IL_0230;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj8 == null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v66+20]");
							TopRunPlayerCell topRunPlayerCell = (TopRunPlayerCell)0;
							if (~(topRunPlayerCell.isLocalUser ? 1u : 0u) != 0)
							{
								continue;
							}
							result = topRunPlayerCell;
							goto IL_0230;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj9 != obj10;
			object obj11 = obj12;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = (nint)0 == 1;
			result = null;
			if (!flag2)
			{
				goto IL_0230;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj11 = obj13;
			break;
			IL_0230:
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1988");
			return result;
		}
		_ = 0;
		object obj15 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		TopRunPlayerCell result2 = default;
		return result2;
	}

	private void OnEnable()
	{
		TopRunEventsHandler instance = TopRunEventsHandler.instance;
		throw new ArgumentException();
	}

	private void OnDisable()
	{
		TopRunEventsHandler instance = TopRunEventsHandler.instance;
		throw new ArgumentException();
	}

	public virtual void OnPlayerChanged(object o, PlayerInfoChangedEventArgs eventArg = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		if (eventArg == null)
		{
			return;
		}
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_02f5;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v70+14]");
					if ((nint)0 == 0)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj8 == null)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [eventArg @ L2 (System.Object)+8]");
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									goto IL_02f5;
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
			bool flag = obj9 != obj10;
			object obj11 = obj12;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_02f5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj11 = obj13;
			break;
			IL_02f5:
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1988");
			return;
		}
		_ = 0;
		object obj15 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	public override void Show()
	{
		base.Show();
		SetScreenTop_UI();
		ForceUpdateAnchors();
		if (_topRunListView != null && _adapter != null)
		{
			_topRunListView.SetAdapter(_adapter);
		}
		ScrollToMyPosition();
	}

	private void ScrollToMyPosition()
	{
		int myIndexInTheList = GetMyIndexInTheList();
		int num = myIndexInTheList - 2;
		if (num >= 0)
		{
			UIPanel rootPanel = _topRunListView.rootPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v8 (UIPanel)+D4]");
			float num2 = 0f * 0.5f;
			Container firstVisibleContainerOnScreen = _topRunListView.GetFirstVisibleContainerOnScreen();
			float offset = num2 - firstVisibleContainerOnScreen.height;
			_topRunListView.SetSelection(num, ContainerPivot.Top, offset);
		}
	}

	private int GetMyIndexInTheList()
	{
		bool flag = _contentList == null;
		List<TopRunCell> contentList = _contentList;
		int num = -1;
		int num2 = 0;
		int result = -1;
		if (!flag)
		{
			while (true)
			{
				bool flag2 = num2 >= contentList._size;
				result = num;
				if (flag2)
				{
					break;
				}
				TopRunCell topRunCell = _contentList.get_Item(num2);
				if (topRunCell.cellType == TopRunCellType.PLAYER)
				{
					TopRunCell topRunCell2 = _contentList.get_Item(num2);
					int num3 = num2;
					if (!topRunCell2.isLocalUser)
					{
						num3 = num;
					}
					num = num3;
				}
				int num4 = num2 + 1;
				contentList = _contentList;
				num2 = num4;
			}
		}
		return result;
	}

	private void RefreshOrFetchNewTournament()
	{
		//IL_00e6: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		TopRunRewardHelper.RefreshPendingResults();
		if (TopRunRoot.manager__BackingField == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		object obj2;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
			DateTime dateTime = default;
			if (dateTime != DateTime.MinValue)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
				DateTime utcNow = CDateTime.UtcNow;
				DateTime dateTime2 = default;
				if (dateTime2 < utcNow)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					obj2 = 20;
					object obj3 = default;
					if (obj3 != null)
					{
						goto IL_00f1;
					}
				}
			}
		}
		obj2 = 21;
		goto IL_00f1;
		IL_00f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
	}

	private void SetCurrentState()
	{
		if (TopRunRoot.manager__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			if (obj != null)
			{
				if (TopRunRewardHelper.ShouldShowResults())
				{
					_currentState = TopRunStates.RESULTS;
					UIWidget component = _normalState.GetComponent<UIWidget>();
					UIRect.AnchorPoint topAnchor = component.topAnchor;
					topAnchor.absolute = -110;
					UIPanel scrollPanel = _scrollPanel;
					UIRect.AnchorPoint topAnchor2 = scrollPanel.topAnchor;
					Transform target = _normalState.transform;
					topAnchor2.target = target;
					UIPanel scrollPanel2 = _scrollPanel;
					UIRect.AnchorPoint topAnchor3 = scrollPanel2.topAnchor;
					topAnchor3.absolute = -15;
					_resultState.SetActive(value: true);
					_normalState.SetActive(value: true);
					_offlineState.SetActive(value: false);
					nint num = 0;
					nint num2 = 0;
					IntPtr intPtr = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v200 @ S3_v13 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
					UnityEngine.Object obj2 = default;
					if (obj2 != null)
					{
						((TopRunNormalStateHelper)obj2).InitNormalState();
					}
				}
				else
				{
					_currentState = TopRunStates.NORMAL;
					UIWidget component2 = _normalState.GetComponent<UIWidget>();
					UIRect.AnchorPoint topAnchor4 = component2.topAnchor;
					topAnchor4.absolute = -9;
					UIPanel scrollPanel3 = _scrollPanel;
					UIRect.AnchorPoint topAnchor5 = scrollPanel3.topAnchor;
					Transform target2 = _normalState.transform;
					topAnchor5.target = target2;
					UIPanel scrollPanel4 = _scrollPanel;
					UIRect.AnchorPoint topAnchor6 = scrollPanel4.topAnchor;
					topAnchor6.absolute = -5;
					_resultState.SetActive(value: false);
					_normalState.SetActive(value: true);
					_offlineState.SetActive(value: false);
					nint num3 = 0;
					nint num4 = 0;
					IntPtr intPtr2 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ S3_v9 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
					UnityEngine.Object obj3 = default;
					if (obj3 != null)
					{
						((TopRunNormalStateHelper)obj3).InitNormalState();
					}
				}
				return;
			}
		}
		_currentState = TopRunStates.OFFLINE;
		UIPanel scrollPanel5 = _scrollPanel;
		UIRect.AnchorPoint topAnchor7 = scrollPanel5.topAnchor;
		Transform target3 = _offlineState.transform;
		topAnchor7.target = target3;
		UIPanel scrollPanel6 = _scrollPanel;
		UIRect.AnchorPoint topAnchor8 = scrollPanel6.topAnchor;
		topAnchor8.absolute = -5;
		_resultState.SetActive(value: false);
		_normalState.SetActive(value: false);
		_offlineState.SetActive(value: true);
		nint num5 = 0;
		nint num6 = 0;
		IntPtr intPtr3 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ S3_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		UnityEngine.Object obj4 = default;
		if (obj4 != null)
		{
			((TopRunOfflineStateHelper)obj4).SetState(_isLoading ? TopRunOfflineStateHelper.OfflineState.Loading : TopRunOfflineStateHelper.OfflineState.TryAgain, this, (TopRunOnlineGameOverScreen)null);
		}
	}

	private void ForceUpdateAnchors()
	{
		_scrollPanel.ResetAnchors();
		UIPanel scrollPanel = _scrollPanel;
		UIRect.AnchorPoint topAnchor = scrollPanel.topAnchor;
		topAnchor.rect.ForceUpdate();
		UIPanel scrollPanel2 = _scrollPanel;
		UIRect.AnchorPoint bottomAnchor = scrollPanel2.bottomAnchor;
		bottomAnchor.rect.ForceUpdate();
		UIPanel scrollPanel3 = _scrollPanel;
		UIRect.AnchorPoint leftAnchor = scrollPanel3.leftAnchor;
		leftAnchor.rect.ForceUpdate();
		UIPanel scrollPanel4 = _scrollPanel;
		UIRect.AnchorPoint rightAnchor = scrollPanel4.rightAnchor;
		rightAnchor.rect.ForceUpdate();
		_scrollPanel.UpdateAnchors();
	}

	private unsafe void SetScreenTop_UI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0022: Expected Obj, but got VT
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got VT
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got VT
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected VT, but got Unknown
		//IL_010a: Expected Obj, but got VT
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got VT
		//IL_0166: Expected F4, but got I
		//IL_0161: Expected native int or pointer, but got VT
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got VT
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01d1: Expected F4, but got I
		//IL_01cc: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj + -64);
		string text = Strings.Get(StringID.TOPRUN_SCREEN_TITLE);
		_titleLabel.text = text;
		object obj2 = GlobalColors.TOPRUN_SCREEN_TITLE_COLOUR >> 16;
		object obj3 = obj2 & 0xFF;
		float num = (float)obj3 / 255f;
		object obj4 = GlobalColors.TOPRUN_SCREEN_TITLE_COLOUR >> 24;
		float num2 = (float)obj4 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+38]");
		_ = 0;
		object obj5 = GlobalColors.TOPRUN_SCREEN_TITLE_COLOUR & 0xFF;
		float num3 = (float)obj5 / 255f;
		object obj6 = GlobalColors.TOPRUN_SCREEN_TITLE_COLOUR >> 8;
		object obj7 = obj6 & 0xFF;
		float num4 = (float)obj7 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+30]");
		_ = 0;
		Color color2 = color + 16;
		_titleLabel.color = color2;
		object obj8 = GlobalColors.TOPRUN_COUNTRY_NAME_COLOUR >> 16;
		object obj9 = obj8 & 0xFF;
		float num5 = (float)obj9 / 255f;
		object obj10 = GlobalColors.TOPRUN_COUNTRY_NAME_COLOUR >> 24;
		float num6 = (float)obj10 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
		((Color*)(nint)color)->b = 0f;
		object obj11 = GlobalColors.TOPRUN_COUNTRY_NAME_COLOUR & 0xFF;
		float num7 = (float)obj11 / 255f;
		object obj12 = GlobalColors.TOPRUN_COUNTRY_NAME_COLOUR >> 8;
		object obj13 = obj12 & 0xFF;
		float num8 = (float)obj13 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
		((Color*)(nint)color)->r = 0f;
		_countryLabel.color = color;
		CountryManager instance = CountryManager.instance;
		Country currentTournamentCountry = instance.GetCurrentTournamentCountry();
		_flagSrite.spriteName = currentTournamentCountry.flag__BackingField;
		CountryManager instance2 = CountryManager.instance;
		Country currentTournamentCountry2 = instance2.GetCurrentTournamentCountry();
		string text2 = currentTournamentCountry2.name__BackingField.ToUpper();
		_countryLabel.text = text2;
	}

	private unsafe void SetListContent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_073c: Expected Obj, but got I4
		//IL_087d: Expected Obj, but got I4
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected I4, but got Unknown
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected I4, but got Unknown
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected Obj, but got Unknown
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected Obj, but got Unknown
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected I4, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected Ref, but got Unknown
		//IL_02e0: Expected Obj, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_0438: Expected Obj, but got I4
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected I4, but got Unknown
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Expected Obj, but got Unknown
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected I4, but got Unknown
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected I4, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_03cc: Expected Obj, but got I4
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected Ref, but got Unknown
		//IL_02cd: Expected Obj, but got I4
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected Obj, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected I4, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected I4, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected I4, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Ref, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_currentState <= TopRunStates.RESULTS)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			Player player;
			int num;
			if ((nint)obj3 >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				TopRunOnlineScreen topRunOnlineScreen = default;
				Player myPlayerProfile = topRunOnlineScreen.GetMyPlayerProfile();
				player = myPlayerProfile;
				int num2 = default;
				num = num2;
			}
			else
			{
				Player myPlayerProfile2 = ((TopRunOnlineScreen)null).GetMyPlayerProfile(false);
				player = myPlayerProfile2;
				num = noMedalRankThreshold;
			}
			((List<T>)(object)_contentList).Clear();
			bool flag = (nint)obj3 > 0;
			bool flag2 = flag;
			object obj4 = 0;
			object obj5 = default;
			List<IPlayer> list = default;
			IEnumerable<IPlayer> collection = default;
			object obj6 = default;
			TopRunCell topRunCell = default;
			TopRunCell topRunCell3 = default;
			int bestScore = default;
			object obj7 = default;
			TopRunCell topRunCell4 = default;
			TopRunCell topRunCell5 = default;
			object obj16 = default;
			TopRunCell topRunCell6 = default;
			TopRunCell topRunCell7 = default;
			TopRunCell topRunCell8 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				list._002Ector(collection);
				bool flag3 = (nint)obj4 < noMedalRankThreshold;
				int num3 = noMedalRankThreshold;
				if (!flag3)
				{
					bool flag4 = (nint)obj3 >= 1;
					if (list._size >= 1)
					{
						flag4 = false;
					}
					if (!flag4)
					{
						num3 = noMedalRankThreshold;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
						bool flag5 = (nint)obj6 < noMedalRankThreshold;
						num3 = noMedalRankThreshold;
						if (flag5)
						{
							goto IL_08a6;
						}
					}
				}
				if (num3 >= (nint)obj4)
				{
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
						if ((nint)0 == 0)
						{
							goto IL_0253;
						}
					}
					topRunCell.rank = -1;
					topRunCell.cellType = TopRunCellType.SPACE_CELL;
					_contentList.Add(topRunCell);
					goto IL_0253;
				}
				goto IL_08c1;
				IL_08fa:
				TopRunCell topRunCell2;
				topRunCell2.isLocalUser = true;
				int rank = num + 1;
				topRunCell2.rank = rank;
				List<TopRunCell> contentList;
				contentList.Add(topRunCell2);
				((TopRunOnlineScreen)(object)topRunCell2).AddFBButtonAfterMe(_contentList, ref *(bool*)(obj + 15));
				flag2 = false;
				goto IL_08a6;
				IL_0253:
				topRunCell3.rank = -1;
				topRunCell3.cellType = TopRunCellType.HEADER;
				int rank2 = obj4 + 1;
				topRunCell3.rank = rank2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				topRunCell3.bestScore = bestScore;
				_contentList.Add(topRunCell3);
				obj7 = 0;
				goto IL_08c1;
				IL_08a6:
				object obj8 = obj4 + 1;
				obj4 = obj8;
				continue;
				IL_08c1:
				bool flag6 = list._size <= 0;
				bool flag7 = !flag6;
				int num4 = 0;
				if (!flag7)
				{
					object obj9 = (flag2 ? 1 : 0) ^ -1;
					bool flag8 = (nint)obj4 != num;
					object obj10 = obj9 | flag8;
					object obj11 = obj10 & 1;
					if (obj11 == null)
					{
						topRunCell4.rank = -1;
						topRunCell4.player = player;
						topRunCell4.cellType = TopRunCellType.PLAYER;
						topRunCell4.useDarkColour = true;
						contentList = _contentList;
						topRunCell2 = topRunCell4;
						goto IL_08fa;
					}
					if ((nint)obj4 <= noMedalRankThreshold)
					{
						bool flag9 = noMedalRankThreshold == (nint)obj4;
						bool flag10 = (nint)obj3 < 1;
						object obj12 = flag9 & flag10;
						if (obj12 == null)
						{
							topRunCell5.rank = -1;
							topRunCell5.cellType = TopRunCellType.EMPTY_CELL;
							int rank3 = obj4 + 1;
							topRunCell5.rank = rank3;
							_contentList.Add(topRunCell5);
						}
					}
				}
				else
				{
					while (num4 < list._size)
					{
						object obj13 = (flag2 ? 1 : 0) ^ -1;
						bool flag11 = (nint)obj4 != num;
						object obj14 = obj13 | flag11;
						object obj15 = obj14 & 1;
						if (obj15 == null)
						{
							IPlayer player2 = list.get_Item(num4);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							bool flag12 = (nint)obj16 > player.score__BackingField;
							flag2 = true;
							if (!flag12)
							{
								topRunCell6.rank = -1;
								topRunCell6.player = player;
								topRunCell6.cellType = TopRunCellType.PLAYER;
								object obj17 = obj7 ^ -1;
								bool useDarkColour = (byte)(obj17 & 1) != 0;
								topRunCell6.useDarkColour = useDarkColour;
								topRunCell6.isLocalUser = true;
								int rank4 = num + 1;
								topRunCell6.rank = rank4;
								_contentList.Add(topRunCell6);
								((TopRunOnlineScreen)(object)topRunCell6).AddFBButtonAfterMe(_contentList, ref *(bool*)(obj + 15));
								object obj18 = obj7 + 1;
								obj7 = obj18;
								flag2 = false;
							}
						}
						topRunCell7.rank = -1;
						topRunCell7.cellType = TopRunCellType.PLAYER;
						IPlayer player3 = list.get_Item(num4);
						topRunCell7.player = player3;
						object obj19 = obj7 ^ -1;
						bool useDarkColour2 = (byte)(obj19 & 1) != 0;
						topRunCell7.useDarkColour = useDarkColour2;
						int rank5 = obj4 + 1;
						topRunCell7.rank = rank5;
						_contentList.Add(topRunCell7);
						object obj20 = obj7 + 1;
						int num5 = num4 + 1;
						obj7 = obj20;
						num4 = num5;
					}
				}
				if ((nint)obj4 != num || !flag2)
				{
					goto IL_08a6;
				}
				topRunCell8.rank = -1;
				topRunCell8.player = player;
				topRunCell8.cellType = TopRunCellType.PLAYER;
				object obj21 = obj7 ^ -1;
				bool useDarkColour3 = (byte)(obj21 & 1) != 0;
				topRunCell8.useDarkColour = useDarkColour3;
				contentList = _contentList;
				topRunCell2 = topRunCell8;
				goto IL_08fa;
			}
			if ((nint)obj3 <= 0)
			{
				TopRunCell topRunCell9 = default;
				topRunCell9.rank = -1;
				topRunCell9.player = player;
				topRunCell9.cellType = TopRunCellType.PLAYER;
				object obj22 = obj7 ^ -1;
				bool useDarkColour4 = (byte)(obj22 & 1) != 0;
				topRunCell9.useDarkColour = useDarkColour4;
				topRunCell9.isLocalUser = true;
				int rank6 = num + 1;
				topRunCell9.rank = rank6;
				_contentList.Add(topRunCell9);
				((TopRunOnlineScreen)(object)topRunCell9).AddFBButtonAfterMe(_contentList, ref *(bool*)(obj + 15));
			}
		}
		else
		{
			((List<T>)(object)_contentList).Clear();
			object obj23 = 0;
			TopRunCell topRunCell10 = default;
			TopRunCell topRunCell11 = default;
			TopRunCell topRunCell12 = default;
			while (noMedalRankThreshold > (nint)obj23)
			{
				if (obj23 != null)
				{
					topRunCell10.rank = -1;
					topRunCell10.cellType = TopRunCellType.SPACE_CELL;
					_contentList.Add(topRunCell10);
				}
				topRunCell11.rank = -1;
				topRunCell11.cellType = TopRunCellType.HEADER;
				topRunCell11.bestScore = -1;
				int rank7 = obj23 + 1;
				topRunCell11.rank = rank7;
				_contentList.Add(topRunCell11);
				topRunCell12.rank = -1;
				topRunCell12.cellType = TopRunCellType.EMPTY_CELL;
				int rank8 = obj23 + 1;
				topRunCell12.rank = rank8;
				_contentList.Add(topRunCell12);
				object obj24 = obj23 + 1;
				obj23 = obj24;
			}
		}
		TopRunCell topRunCell13 = default;
		topRunCell13.rank = -1;
		topRunCell13.cellType = TopRunCellType.SPACE_CELL;
		_contentList.Add(topRunCell13);
	}

	private unsafe void AddFBButtonAfterMe(List<TopRunCell> contentList, ref bool isFacebookButtonAdded)
	{
		if (!isFacebookButtonAdded)
		{
			SocialManager instance = SocialManager.instance;
			if (!instance.facebookIsLoggedIn && !AgeRestriction.isRestricted)
			{
				TopRunCell topRunCell = default;
				topRunCell.rank = -1;
				topRunCell.noPadding = true;
				topRunCell.cellType = TopRunCellType.FACEBOOK_BUTTON;
				contentList.Add(topRunCell);
				ref bool reference = ref *(bool*)1;
			}
		}
	}

	private Player GetMyPlayerProfile(bool hasScore = true)
	{
		bool flag = !hasScore;
		int num = 0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int num2 = default;
			num = num2;
		}
		Player player = default;
		player.isFriend__BackingField = true;
		player.score__BackingField = num;
		SocialManager instance = SocialManager.instance;
		if (instance._fbState == SocialManager.FacebookState.LoggedIn)
		{
			SocialManager instance2 = SocialManager.instance;
			if (instance2._fbProfile != null)
			{
				SocialManager instance3 = SocialManager.instance;
				player.facebookProfile__BackingField = instance3._fbProfile;
			}
		}
		return player;
	}

	public TopRunOnlineScreen()
	{
		List<TopRunCell> list = default;
		list._002Ector();
		_contentList = list;
		noMedalRankThreshold = 4;
		base._002Ector();
	}
}
