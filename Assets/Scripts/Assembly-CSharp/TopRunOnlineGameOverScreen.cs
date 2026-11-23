using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo;
using Kiloo.Common.UI;
using TopRun;
using TopRun.Internal;
using UnityEngine;

public class TopRunOnlineGameOverScreen : MonoBehaviour
{
	public class TopRunListAdapter : ListAdapter<TopRunCell>
	{
		private TopRunOnlineGameOverScreen _topRunScreen;

		public GameObject playerPrefab;

		public GameObject rankHeaderPrefab;

		public GameObject spacePrefab;

		public GameObject emptyCellPrefab;

		public GameObject facebookButton;

		public GameObject normalStatePrefab;

		public GameObject resultStatePrefab;

		public GameObject offlineStatePrefab;

		private const int PLAYER_PREFAB_ID = 0;

		private const int RANK_PREFAB_ID = 1;

		private const int SPACE_CELL = 2;

		private const int EMPTY_CELL_ID = 3;

		private const int NORMAL_STATE_ID = 4;

		private const int RESULT_STATE_ID = 5;

		private const int OFFLINE_STATE_ID = 6;

		private const int FACEBOOK_BUTTON = 7;

		public TopRunListAdapter(List<TopRunCell> topRunListT, TopRunOnlineGameOverScreen topRunScreen, GameObject playerCell, GameObject headerCell, GameObject spaceCell, GameObject emptyCell, GameObject normalState, GameObject resultState, GameObject offlineState, GameObject _facebookButton)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v4 (Il2CppClass<Il2CppRgctx<Kiloo.Common.UI.ListAdapter`1<TopRunCell>>>)+4] (should have been resolved before IL gen)");
			_topRunScreen = topRunScreen;
			playerPrefab = playerCell;
			rankHeaderPrefab = headerCell;
			spacePrefab = spaceCell;
			normalStatePrefab = normalState;
			resultStatePrefab = resultState;
			offlineStatePrefab = offlineState;
			emptyCellPrefab = emptyCell;
			facebookButton = _facebookButton;
		}

		public new int GetModelType(int index)
		{
			//IL_0005: Expected I, but got Obj
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_005d: Expected I, but got Obj
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected Obj, but got Unknown
			//IL_00a5: Expected I, but got Obj
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected Obj, but got Unknown
			//IL_00ed: Expected I, but got Obj
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected Obj, but got Unknown
			//IL_0135: Expected I, but got Obj
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected Obj, but got Unknown
			//IL_017d: Expected I, but got Obj
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Expected Obj, but got Unknown
			//IL_01c5: Expected I, but got Obj
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Expected Obj, but got Unknown
			nint num = (nint)this;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<TopRunOnlineGameOverScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v2+8]");
			int result;
			if ((nint)0 == 0)
			{
				result = 1;
			}
			else
			{
				nint num2 = (nint)this;
				object obj2 = this + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v7 (Il2CppClass<TopRunOnlineGameOverScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v9+8]");
				bool flag = (nint)0 == 2;
				result = 0;
				if (!flag)
				{
					nint num3 = (nint)this;
					object obj3 = this + 72;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S2_v11 (Il2CppClass<TopRunOnlineGameOverScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v14+8]");
					bool flag2 = (nint)0 == 1;
					result = 2;
					if (!flag2)
					{
						nint num4 = (nint)this;
						object obj4 = this + 72;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S2_v15 (Il2CppClass<TopRunOnlineGameOverScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v19+8]");
						bool flag3 = (nint)0 == 4;
						result = 4;
						if (!flag3)
						{
							nint num5 = (nint)this;
							object obj5 = this + 72;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v108 @ S2_v19 (Il2CppClass<TopRunOnlineGameOverScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v24+8]");
							bool flag4 = (nint)0 == 5;
							result = 5;
							if (!flag4)
							{
								nint num6 = (nint)this;
								object obj6 = this + 72;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v118 @ S2_v23 (Il2CppClass<TopRunOnlineGameOverScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v29+8]");
								bool flag5 = (nint)0 == 6;
								result = 6;
								if (!flag5)
								{
									nint num7 = (nint)this;
									object obj7 = this + 72;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ S4_v2 (Il2CppClass<TopRunOnlineGameOverScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S2_v27+8]");
									bool flag6 = (nint)0 == 7;
									int result2 = 7;
									if (!flag6)
									{
										result2 = 3;
									}
									return result2;
								}
							}
						}
					}
				}
			}
			return result;
		}

		public void SetNewDataList(List<TopRunCell> topRunListT)
		{
			//IL_0029: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunOnlineGameOverScreen+TopRunListAdapter)+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunOnlineGameOverScreen+TopRunListAdapter)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S0_v9+C] (should have been resolved before IL gen)");
			}
		}

		public new unsafe Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_069e: Expected I, but got Obj
			//IL_0486: Expected Obj, but got I
			//IL_04db: Expected Obj, but got I
			//IL_04db: Expected Obj, but got I
			//IL_04fb: Expected Obj, but got I
			//IL_0595: Expected Obj, but got I
			//IL_0525: Expected Obj, but got I
			//IL_0564: Expected Obj, but got I
			//IL_0611: Expected Obj, but got I
			//IL_0681: Expected Obj, but got I
			//IL_0661: Expected Obj, but got I
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S2_v2 (Il2CppClass<TopRunOnlineGameOverScreen+TopRunListAdapter>)+104] (should have been resolved before IL gen)");
			Container container2 = default;
			object tag = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
						if ((nint)0 != 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
							if ((nint)0 == 3)
							{
								goto IL_0306;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
							if ((nint)0 != 4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
								if ((nint)0 != 5)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
									if ((nint)0 != 6)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
										if ((nint)0 != 7)
										{
											goto IL_0306;
										}
										Container container3 = default;
										container3._002Ector(facebookButton);
										FacebookLoginButtonOnline component = container3.model.GetComponent<FacebookLoginButtonOnline>();
										ResizeWidgetOnLoginFB_TopRun component2 = container3.model.GetComponent<ResizeWidgetOnLoginFB_TopRun>();
										container3.tag = tag;
										container2 = container3;
									}
									else
									{
										Container container4 = default;
										container4._002Ector(offlineStatePrefab);
										nint num2 = 0;
										nint num3 = 0;
										IntPtr intPtr = num3;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v327 @ S4_v16 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
										container4.tag = tag;
										container2 = container4;
									}
								}
								else
								{
									Container container5 = default;
									container5._002Ector(resultStatePrefab);
									container2 = container5;
								}
							}
							else
							{
								Container container6 = default;
								container6._002Ector(normalStatePrefab);
								nint num4 = 0;
								nint num5 = 0;
								IntPtr intPtr2 = num5;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v295 @ S4_v12 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
								container6.tag = tag;
								container2 = container6;
							}
						}
						else
						{
							Container container7 = default;
							container7._002Ector(playerPrefab);
							TopRunPlayerCell component3 = container7.model.GetComponent<TopRunPlayerCell>();
							container7.tag = tag;
							container2 = container7;
						}
					}
					else
					{
						Container container8 = default;
						container8._002Ector(spacePrefab);
						container2 = container8;
					}
				}
				else
				{
					Container container9 = default;
					container9._002Ector(rankHeaderPrefab);
					RankHeader component4 = container9.model.GetComponent<RankHeader>();
					container9.tag = tag;
					container2 = container9;
				}
			}
			goto IL_06b6;
			IL_06b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
					if ((nint)0 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v20+18]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+14]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+18]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+C]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+19]");
						((TopRunPlayerCell)num6).InitCell((IPlayer)num7, (byte)num8 != 0, (int)num9, isLocalUserT: false);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v20+18]");
						Action action = default;
						action._002Ector(0, (nint)__ldftn(TopRunPlayerCell.Refresh));
						return container2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
					if ((nint)0 == 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v31+C]");
						nint num10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+C]");
						((TopRunEmptyCell)num10).InitCell(0);
						return container2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
					if ((nint)0 == 4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v36+1C]");
						((TopRunNormalStateHelper)0).InitNormalState();
						return container2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
					if ((nint)0 != 5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
						if ((nint)0 == 6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
							TopRunOnlineGameOverScreen topRunScreen = _topRunScreen;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v41+20]");
							((TopRunOfflineStateHelper)0).SetState(topRunScreen._isLoading ? TopRunOfflineStateHelper.OfflineState.Loading : TopRunOfflineStateHelper.OfflineState.TryAgain, null, _topRunScreen);
							return container2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
						if ((nint)0 == 7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
							SocialManager instance = SocialManager.instance;
							bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
							SocialManager instance2 = SocialManager.instance;
							bool gamecenterIsLoggedIn = instance2.gamecenterIsLoggedIn;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v46+10]");
							((FacebookLoginButtonOnline)0).Init(facebookIsLoggedIn, isNoBonus: true, isAwardsSpecific: false, gamecenterIsLoggedIn, isTopRunSpecific: true, noGCFriends: false, isGameOverScreen: true);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+1A]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v46+14]");
								((ResizeWidgetOnLoginFB_TopRun)0).SetEmptyWidgetSize(0, 0);
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v46+14]");
								((ResizeWidgetOnLoginFB_TopRun)0).SetEmptyWidgetSize(284, 50);
							}
							container2.isMeasured = false;
						}
					}
				}
				return container2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v13+8]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+C]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+10]");
			((RankHeader)num11).InitHeader((int)num12, 0);
			return container2;
			IL_0306:
			Container container10 = default;
			container10._002Ector(emptyCellPrefab);
			TopRunEmptyCell component5 = container10.model.GetComponent<TopRunEmptyCell>();
			container10.tag = tag;
			container2 = container10;
			goto IL_06b6;
		}
	}

	private sealed class _003CAnimateMedalAfterSeconds_003Ed__30(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public TopRunOnlineGameOverScreen _003C_003E4__this;

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

	private const int _offsetFromTop = -39;

	private TopRunListAdapter _adapter;

	private TopRunStates _currentState = TopRunStates.OFFLINE;

	private bool _hasBeenInitialized;

	private bool _isLoading = true;

	private List<TopRunCell> _contentList;

	private const int POSITION_OFFSET_IN_LIST = 2;

	private const int POSITION_OFFSET_IN_LIST_NOFACEBOOK = 1;

	private void Init()
	{
		SetListContent();
		if (_contentList != null)
		{
			TopRunListAdapter topRunListAdapter = default;
			topRunListAdapter._002Ector(_contentList, this, _playerPrefab, _rankHeaderPrefab, _spaceCell, _emptyCell, _normalState, _resultState, _offlineState, _facebookLogInButton);
			_adapter = topRunListAdapter;
		}
		SetScrollPanelTopAnchor();
		SetAdapter();
		_hasBeenInitialized = true;
	}

	private void OnEnable()
	{
		NullReferenceException ex = new NullReferenceException();
		throw new ArgumentException();
	}

	private void OnDisable()
	{
		NullReferenceException ex = new NullReferenceException();
		throw new ArgumentException();
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
		if (~(_hasBeenInitialized ? 1u : 0u) != 0)
		{
			Init();
		}
		else
		{
			SetAdapter();
		}
	}

	public virtual void OnPlayerChanged(object o, PlayerInfoChangedEventArgs eventArg = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected Obj, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		if (eventArg != null)
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v71+14]");
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
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8]");
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

	private void SetAdapter()
	{
		if (_topRunListView != null && _adapter != null)
		{
			_topRunListView.SetAdapter(_adapter);
		}
		ScrollToRightPosition();
	}

	private void ScrollToRightPosition()
	{
		//IL_0013: Expected Obj, but got I4
		int myIndexInTheList = GetMyIndexInTheList();
		int num = myIndexInTheList - 2;
		Globals.LogInState loginState = Globals.GetLoginState();
		object obj = loginState - 1;
		bool flag = loginState == Globals.LogInState.Facebook;
		int num2 = num;
		if (!flag)
		{
			if ((nint)obj != 1)
			{
				bool flag2 = (nint)obj == 2;
				num2 = num;
				if (flag2)
				{
					goto IL_0144;
				}
			}
			int myIndexInTheList2 = GetMyIndexInTheList();
			int num3 = myIndexInTheList2 - 1;
			num2 = num3;
		}
		goto IL_0144;
		IL_0144:
		bool flag3 = _currentState == TopRunStates.RESULTS;
		int num4 = 0;
		if (!flag3)
		{
			num4 = num2;
		}
		if (num4 >= 0)
		{
			UIPanel rootPanel = _topRunListView.rootPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v20 (UIPanel)+D4]");
			float num5 = 0f * 0.5f;
			Container firstVisibleContainerOnScreen = _topRunListView.GetFirstVisibleContainerOnScreen();
			float offset = num5 - firstVisibleContainerOnScreen.height;
			_topRunListView.SetSelection(num4, ContainerPivot.Top, offset);
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

	private void RefreshAdapterIfDataChanged()
	{
		if (_adapter != null)
		{
			SetListContent();
			if (_contentList != null)
			{
				_adapter.SetNewDataList(_contentList);
			}
		}
		ScrollToRightPosition();
		loadingOverlay.SetActive(value: false);
		UIScreenController instance = UIScreenController.Instance;
		if (~(instance.justPaidOutTopRun ? 1u : 0u) != 0)
		{
			IEnumerator routine = AnimateMedalAfterSeconds(0.5f);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	public void AnimateMedalIfNeeded()
	{
		IEnumerator routine = AnimateMedalAfterSeconds(0.5f);
		Coroutine coroutine = StartCoroutine(routine);
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

	private void SetScrollPanelTopAnchor()
	{
		UIPanel scrollPanel = _scrollPanel;
		UIRect.AnchorPoint topAnchor = scrollPanel.topAnchor;
		topAnchor.relative = 0f;
		topAnchor.Set(0f, -39f);
		_scrollPanel.ResetAnchors();
		_scrollPanel.UpdateAnchors();
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
				}
				else
				{
					_currentState = TopRunStates.NORMAL;
				}
				return;
			}
		}
		_currentState = TopRunStates.OFFLINE;
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

	private unsafe void SetListContent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0795: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected I4, but got Unknown
		//IL_088f: Expected Obj, but got I4
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected I4, but got Unknown
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected Obj, but got Unknown
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected Obj, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected I4, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected I4, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Ref, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected I4, but got Unknown
		//IL_0231: Expected Obj, but got I4
		//IL_02e9: Expected Obj, but got I4
		//IL_02f2: Expected Obj, but got I4
		//IL_0305: Expected Obj, but got I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected Obj, but got Unknown
		//IL_043c: Expected Obj, but got I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_03c3: Expected Obj, but got I4
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected Obj, but got Unknown
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected I4, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected I4, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected Obj, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected I4, but got Unknown
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Expected I4, but got Unknown
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected Ref, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected Obj, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected I4, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected I4, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected I4, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected Ref, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		((List<T>)(object)_contentList).Clear();
		if (_currentState <= TopRunStates.RESULTS)
		{
			if (_currentState == TopRunStates.RESULTS)
			{
				TopRunCell topRunCell = default;
				topRunCell.rank = -1;
				topRunCell.cellType = TopRunCellType.STATE_RESULTS;
				_contentList.Add(topRunCell);
				TopRunCell topRunCell2 = default;
				topRunCell2.rank = -1;
				topRunCell2.cellType = TopRunCellType.SPACE_CELL;
				_contentList.Add(topRunCell2);
			}
			TopRunCell topRunCell3 = default;
			topRunCell3.rank = -1;
			topRunCell3.cellType = TopRunCellType.STATE_NORMAL;
			_contentList.Add(topRunCell3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			bool flag = (nint)obj3 < 1;
			bool flag2 = !flag;
			bool flag3 = !flag2;
			object obj4 = 4;
			TopRunCell topRunCell4 = topRunCell3;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object obj5 = default;
				obj4 = obj5;
				TopRunCell topRunCell5 = default;
				topRunCell4 = topRunCell5;
			}
			bool flag4 = (nint)obj3 > 0;
			Player myPlayerProfile = ((TopRunOnlineGameOverScreen)(object)topRunCell4).GetMyPlayerProfile(flag4);
			bool flag5 = flag4;
			object obj6 = 0;
			object obj7 = default;
			List<IPlayer> list = default;
			IEnumerable<IPlayer> collection = default;
			object obj8 = default;
			TopRunCell topRunCell6 = default;
			TopRunCell topRunCell7 = default;
			int bestScore = default;
			object obj10 = default;
			TopRunCell topRunCell9 = default;
			TopRunCell topRunCell10 = default;
			object obj19 = default;
			TopRunCell topRunCell11 = default;
			TopRunCell topRunCell12 = default;
			TopRunCell topRunCell13 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				list._002Ector(collection);
				object obj9;
				if ((nint)obj6 >= 4)
				{
					if (!flag && list._size <= 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
						if ((nint)obj8 < 4)
						{
							goto IL_0894;
						}
					}
					bool flag6 = (nint)obj6 > 4;
					obj9 = 1;
					if (flag6)
					{
						goto IL_08af;
					}
				}
				topRunCell6.rank = -1;
				topRunCell6.cellType = TopRunCellType.SPACE_CELL;
				_contentList.Add(topRunCell6);
				topRunCell7.rank = -1;
				topRunCell7.cellType = TopRunCellType.HEADER;
				int rank = obj6 + 1;
				topRunCell7.rank = rank;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				topRunCell7.bestScore = bestScore;
				_contentList.Add(topRunCell7);
				obj10 = 0;
				obj9 = 0;
				goto IL_08af;
				IL_08e8:
				TopRunCell topRunCell8;
				topRunCell8.isLocalUser = true;
				int rank2 = obj4 + 1;
				topRunCell8.rank = rank2;
				List<TopRunCell> contentList;
				contentList.Add(topRunCell8);
				((TopRunOnlineGameOverScreen)(object)topRunCell8).AddFBButtonAfterMe(_contentList, ref *(bool*)(obj + 15));
				flag5 = false;
				goto IL_0894;
				IL_08af:
				bool flag7 = list._size <= 0;
				bool flag8 = !flag7;
				int num = 0;
				if (!flag8)
				{
					object obj11 = (flag5 ? 1 : 0) ^ -1;
					bool flag9 = obj6 != obj4;
					object obj12 = obj11 | flag9;
					object obj13 = obj12 & 1;
					if (obj13 == null)
					{
						topRunCell9.rank = -1;
						topRunCell9.player = myPlayerProfile;
						topRunCell9.cellType = TopRunCellType.PLAYER;
						topRunCell9.useDarkColour = true;
						contentList = _contentList;
						topRunCell8 = topRunCell9;
						goto IL_08e8;
					}
					bool flag10 = (nint)obj6 == 4;
					object obj14 = flag & flag10;
					object obj15 = obj9 | obj14;
					if (obj15 == null)
					{
						topRunCell10.rank = -1;
						topRunCell10.cellType = TopRunCellType.EMPTY_CELL;
						int rank3 = obj6 + 1;
						topRunCell10.rank = rank3;
						_contentList.Add(topRunCell10);
					}
				}
				else
				{
					while (num < list._size)
					{
						object obj16 = (flag5 ? 1 : 0) ^ -1;
						bool flag11 = obj6 != obj4;
						object obj17 = obj16 | flag11;
						object obj18 = obj17 & 1;
						if (obj18 == null)
						{
							IPlayer player = list.get_Item(num);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							bool flag12 = (nint)obj19 > myPlayerProfile.score__BackingField;
							flag5 = true;
							if (!flag12)
							{
								topRunCell11.rank = -1;
								topRunCell11.player = myPlayerProfile;
								topRunCell11.cellType = TopRunCellType.PLAYER;
								object obj20 = obj10 ^ -1;
								bool useDarkColour = (byte)(obj20 & 1) != 0;
								topRunCell11.useDarkColour = useDarkColour;
								topRunCell11.isLocalUser = true;
								int rank4 = obj4 + 1;
								topRunCell11.rank = rank4;
								_contentList.Add(topRunCell11);
								((TopRunOnlineGameOverScreen)(object)topRunCell11).AddFBButtonAfterMe(_contentList, ref *(bool*)(obj + 15));
								object obj21 = obj10 + 1;
								flag5 = false;
								obj10 = obj21;
							}
						}
						topRunCell12.rank = -1;
						topRunCell12.cellType = TopRunCellType.PLAYER;
						IPlayer player2 = list.get_Item(num);
						topRunCell12.player = player2;
						object obj22 = obj10 ^ -1;
						bool useDarkColour2 = (byte)(obj22 & 1) != 0;
						topRunCell12.useDarkColour = useDarkColour2;
						int rank5 = obj6 + 1;
						topRunCell12.rank = rank5;
						_contentList.Add(topRunCell12);
						object obj23 = obj10 + 1;
						int num2 = num + 1;
						obj10 = obj23;
						num = num2;
					}
				}
				if (obj6 != obj4 || !flag5)
				{
					goto IL_0894;
				}
				topRunCell13.rank = -1;
				topRunCell13.player = myPlayerProfile;
				topRunCell13.cellType = TopRunCellType.PLAYER;
				object obj24 = obj10 ^ -1;
				bool useDarkColour3 = (byte)(obj24 & 1) != 0;
				topRunCell13.useDarkColour = useDarkColour3;
				contentList = _contentList;
				topRunCell8 = topRunCell13;
				goto IL_08e8;
				IL_0894:
				object obj25 = obj6 + 1;
				obj6 = obj25;
			}
			if ((nint)obj3 <= 0)
			{
				TopRunCell topRunCell14 = default;
				topRunCell14.rank = -1;
				topRunCell14.player = myPlayerProfile;
				topRunCell14.cellType = TopRunCellType.PLAYER;
				object obj26 = obj10 ^ -1;
				bool useDarkColour4 = (byte)(obj26 & 1) != 0;
				topRunCell14.useDarkColour = useDarkColour4;
				topRunCell14.isLocalUser = true;
				int rank6 = obj4 + 1;
				topRunCell14.rank = rank6;
				_contentList.Add(topRunCell14);
				((TopRunOnlineGameOverScreen)(object)topRunCell14).AddFBButtonAfterMe(_contentList, ref *(bool*)(obj + 15));
			}
			TopRunCell topRunCell15 = default;
			topRunCell15.rank = -1;
			topRunCell15.cellType = TopRunCellType.SPACE_CELL;
			_contentList.Add(topRunCell15);
			return;
		}
		TopRunCell topRunCell16 = default;
		topRunCell16.rank = -1;
		topRunCell16.cellType = TopRunCellType.STATE_OFFLINE;
		_contentList.Add(topRunCell16);
		object obj27 = 0;
		TopRunCell topRunCell17 = default;
		TopRunCell topRunCell18 = default;
		TopRunCell topRunCell19 = default;
		while (true)
		{
			topRunCell17.rank = -1;
			topRunCell17.cellType = TopRunCellType.SPACE_CELL;
			_contentList.Add(topRunCell17);
			if ((nint)obj27 < 4)
			{
				topRunCell18.rank = -1;
				topRunCell18.cellType = TopRunCellType.HEADER;
				topRunCell18.bestScore = -1;
				int rank7 = obj27 + 1;
				topRunCell18.rank = rank7;
				_contentList.Add(topRunCell18);
				topRunCell19.rank = -1;
				topRunCell19.cellType = TopRunCellType.EMPTY_CELL;
				int rank8 = obj27 + 1;
				topRunCell19.rank = rank8;
				_contentList.Add(topRunCell19);
				object obj28 = obj27 + 1;
				obj27 = obj28;
				continue;
			}
			break;
		}
	}

	private unsafe void AddFBButtonAfterMe(List<TopRunCell> topRunContentList, ref bool isFacebookButtonAdded)
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
				topRunContentList.Add(topRunCell);
				ref bool reference = ref *(bool*)1;
			}
		}
	}

	public TopRunOnlineGameOverScreen()
	{
		List<TopRunCell> list = default;
		list._002Ector();
		_contentList = list;
		base._002Ector();
	}
}
