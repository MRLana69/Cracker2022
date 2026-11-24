using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.UI;
using SYBO.Common.Data;
using SYBO.Subway.Info;
using TopRun;
using TopRun.Internal;
using TopRun.UI;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens.RewardManagement;
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
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected Obj, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Expected Obj, but got Unknown
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected Obj, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected Obj, but got Unknown
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = topRunListT;
			object obj2 = this + 16;
			obj2 = topRunScreen;
			object obj3 = this + 20;
			obj3 = playerCell;
			object obj4 = this + 24;
			obj4 = headerCell;
			object obj5 = this + 28;
			obj5 = spaceCell;
			object obj6 = this + 36;
			obj6 = normalState;
			object obj7 = this + 32;
			obj7 = emptyCell;
			object obj8 = this + 40;
			obj8 = resultState;
			object obj9 = this + 44;
			obj9 = offlineState;
			object obj10 = this + 48;
			obj10 = _facebookButton;
		}

		public override int GetModelType(int index)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunOnlineGameOverScreen+TopRunListAdapter)+8]");
			return (num == 0) ? 1 : 0;
		}

		public void SetNewDataList(List<TopRunCell> topRunListT)
		{
		}

		public unsafe override Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_07b2: Expected I, but got Obj
			//IL_07c8: Expected Obj, but got I
			//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d8: Expected VT, but got Unknown
			//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e6: Expected Obj, but got Unknown
			//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f4: Expected Obj, but got Unknown
			//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0602: Expected Obj, but got Unknown
			//IL_060b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0610: Expected Obj, but got Unknown
			//IL_0619: Unknown result type (might be due to invalid IL or missing references)
			//IL_061e: Expected Obj, but got Unknown
			//IL_062f: Expected Obj, but got I
			//IL_0648: Expected I4, but got Obj
			//IL_0648: Expected Obj, but got I
			//IL_001e: Expected I4, but got Obj
			//IL_0169: Expected Obj, but got I
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Expected Obj, but got Unknown
			//IL_010d: Expected I, but got Obj
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_004b: Expected Obj, but got VT
			//IL_0196: Expected Obj, but got I
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected Obj, but got Unknown
			//IL_00b4: Expected Obj, but got I4
			//IL_00c9: Expected Obj, but got I
			//IL_01c0: Expected Obj, but got I
			//IL_00f2: Expected Obj, but got I4
			//IL_0514: Expected Obj, but got I
			//IL_0522: Expected I, but got Obj
			//IL_0538: Expected Obj, but got I
			//IL_0766: Expected Obj, but got VT
			//IL_077b: Expected F4, but got Obj
			//IL_0776: Expected native int or pointer, but got VT
			//IL_078b: Expected Obj, but got I
			//IL_07ff: Expected F4, but got Obj
			//IL_07fa: Expected native int or pointer, but got VT
			//IL_0814: Expected F4, but got I
			//IL_080f: Expected native int or pointer, but got VT
			//IL_0821: Expected I4, but got VT
			//IL_0563: Expected I, but got Obj
			//IL_06a0: Expected I4, but got Obj
			//IL_06a0: Expected Obj, but got I
			//IL_06b6: Expected Obj, but got I4
			//IL_06b6: Expected Obj, but got I
			//IL_06c4: Expected I, but got Obj
			//IL_06da: Expected Obj, but got I
			//IL_0733: Expected Obj, but got VT
			//IL_0748: Expected F4, but got Obj
			//IL_0743: Expected native int or pointer, but got VT
			//IL_0758: Expected Obj, but got I
			//IL_04c3: Expected I, but got Obj
			//IL_040c: Expected I4, but got Obj
			//IL_040c: Expected Obj, but got I
			//IL_0422: Expected Obj, but got I4
			//IL_0422: Expected Obj, but got I
			//IL_0435: Expected I, but got Obj
			//IL_044b: Expected Obj, but got I
			//IL_02c9: Expected I4, but got Obj
			//IL_02c9: Expected Obj, but got I
			//IL_02df: Expected Obj, but got I4
			//IL_02df: Expected Obj, but got I
			//IL_0700: Expected Obj, but got VT
			//IL_0715: Expected F4, but got Obj
			//IL_0710: Expected native int or pointer, but got VT
			//IL_0725: Expected Obj, but got I
			//IL_02f2: Expected I, but got Obj
			//IL_0308: Expected Obj, but got I
			//IL_0476: Expected I, but got Obj
			//IL_0660: Expected Obj, but got VT
			//IL_0675: Expected F4, but got Obj
			//IL_0670: Expected native int or pointer, but got VT
			//IL_0685: Expected Obj, but got I
			//IL_0333: Expected I, but got Obj
			Container container2 = default;
			Container container3 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				container3.Measure((byte)(int)_topRunScreen != 0);
				object obj = container3 + 84;
				_0021_00210 componentInChildren = (_0021_00210)container3.model.GetComponentInChildren<T>();
				obj = componentInChildren;
				bool hasVertices = ((UIGeometry)(object)container3.model).hasVertices;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Delegate obj2 = default;
				obj2.method_ptr = method_ptr;
				obj2.method = (nint)__ldftn(CountryPopup.OnClickContainer);
				object obj3 = obj2 + 16;
				obj3 = playerPrefab;
				object obj4 = (hasVertices ? 1 : 0) + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v139 (System.Boolean)+14]");
				Delegate obj5 = ((Delegate)0).CombineImpl(obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj6 = default;
				obj4 = obj6;
				object obj7 = (hasVertices ? 1 : 0) + 12;
				obj7 = container3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v4 (Il2CppClass<Strings>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S2_v54 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj9 = default;
			Matrix4x4 matrix4x = (Matrix4x4)(obj9 + 40);
			object obj10 = obj9 + 16;
			object obj11 = obj9 + 32;
			object obj12 = obj9 + 28;
			object obj13 = obj9 + 24;
			object obj14 = obj9 + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v7+8]");
			string text = Strings.GetDefault((string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+C]");
			((UILabel)0).fontSize = (int)text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+10]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v11+C]");
			((UISprite)num3).fillCenter = false;
			object obj16 = default;
			object obj15 = obj16 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v15+10]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v22+10]");
			string text2 = ((string)0).ToLowerInvariant();
			object obj17 = default;
			UIWidget uIWidget;
			if (obj17 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				string text4 = default;
				string text3 = text4.ToLowerInvariant();
				bool flag = text2 != text3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj18 = default;
				bool flag2 = obj18 == null;
				if (flag)
				{
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						string text6 = default;
						string text5 = text6.ToLowerInvariant();
						if (!(text2 != text5))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+14]");
							((UISprite)0).fillCenter = (byte)(int)"icon_timer" != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+14]");
							((Component)0).tag = (string)1;
							nint num4 = (nint)typeof(GlobalColors);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S0_v91 (Il2CppClass<GlobalColors>)+BA]");
							object obj19 = (nint)0 & (nint)0x200;
							if (obj19 != null)
							{
								nint num5 = (nint)typeof(GlobalColors);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S0_v98 (Il2CppClass<GlobalColors>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj10 = GlobalColors.COUNTRY_POPUP_SELECTED_CELL_TEXT_COLOUR;
							obj12 = obj10;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+C]");
							uIWidget = (UIWidget)0;
							goto IL_07e5;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+14]");
					((UISprite)0).fillCenter = (byte)(int)"icon_character_selected" != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+14]");
					((Component)0).tag = (string)1;
					nint num6 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v66 (Il2CppClass<GlobalColors>)+BA]");
					object obj20 = (nint)0 & (nint)0x200;
					if (obj20 != null)
					{
						nint num7 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v73 (Il2CppClass<GlobalColors>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj10 = GlobalColors.COUNTRY_POPUP_SELECTED_CELL_TEXT_COLOUR;
					obj11 = obj10;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+C]");
					uIWidget = (UIWidget)0;
					goto IL_07e5;
				}
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					string text8 = default;
					string text7 = text8.ToLowerInvariant();
					if (text2 != text7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+14]");
						((UISprite)0).fillCenter = (byte)(int)"icon_character_owned" != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+14]");
						((Component)0).tag = (string)1;
						nint num8 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S0_v117 (Il2CppClass<GlobalColors>)+BA]");
						object obj21 = (nint)0 & (nint)0x200;
						if (obj21 != null)
						{
							nint num9 = (nint)typeof(GlobalColors);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S0_v124 (Il2CppClass<GlobalColors>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj10 = GlobalColors.COUNTRY_POPUP_NORMAL_CELL_TEXT_COLOUR;
						obj13 = obj10;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+C]");
						uIWidget = (UIWidget)0;
						goto IL_07e5;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+14]");
			((Component)0).tag = null;
			nint num10 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v40 (Il2CppClass<GlobalColors>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num11 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v47 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj10 = GlobalColors.COUNTRY_POPUP_NORMAL_CELL_TEXT_COLOUR;
			obj14 = obj10;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13+C]");
			uIWidget = (UIWidget)0;
			goto IL_07e5;
			IL_07e5:
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			uIWidget.rawPivot = (UIWidget.Pivot)matrix4x;
			return container3;
		}
	}

	private sealed class _003CAnimateMedalAfterSeconds_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public TopRunOnlineGameOverScreen _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0203: Expected Obj, but got Unknown
				//IL_021f: Expected Obj, but got I4
				//IL_0083: Expected I, but got Obj
				//IL_0121: Expected I, but got Obj
				//IL_0137: Expected Obj, but got I
				//IL_023d: Expected Obj, but got I4
				//IL_0162: Expected I, but got Obj
				//IL_01aa: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						bool flag = ((TopRunPlayerCell)(object)_003C_003E4__this).IsLocalUser();
						if ((flag ? 1 : 0) > -1)
						{
							int myIndexInTheList = _003C_003E4__this.GetMyIndexInTheList();
							nint num = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj = (nint)0 & (nint)0x200;
							if (obj != null)
							{
								nint num2 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)myIndexInTheList).FindKernel(null) != 0)
							{
								((TopRunPlayerCell)myIndexInTheList).ResizeNameIfNeeded();
							}
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = UIScreenController.ShouldShowOnlineScreen();
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = seconds;
				object obj3 = this + 12;
				object obj4 = default;
				obj3 = obj4;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CAnimateMedalAfterSeconds_003Ed__36(int _003C_003E1__state)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0018: Expected Obj, but got I4
			object obj = this + 12;
			obj = _003C_003E1__state;
			((Container)this).hasTransientState = false;
		}

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

	private ScrollView _topRunListView;

	private GameObject _playerPrefab;

	private GameObject _rankHeaderPrefab;

	private GameObject _spaceCell;

	private GameObject _emptyCell;

	private GameObject _facebookLogInButton;

	private UISprite _loadingOverlayBackground;

	private GameObject _normalState;

	private GameObject _resultState;

	private GameObject _offlineState;

	public GameObject loadingOverlay;

	private UIPanel _scrollPanel;

	private GameObject _maintenanceState;

	private UILabel _maintenanceLabel1;

	private UILabel _maintenanceLabel2;

	private UILabel _maintenanceLabel3;

	private Layout _maintenanceLabelLayout;

	private UISprite _maintenanceStateBackground;

	private const int OFFSET_FROM_TOP = -39;

	private TopRunListAdapter _adapter;

	private TopRunStates _currentState;

	private bool _hasBeenInitialized;

	private bool _isLoading;

	private List<TopRunCell> _contentList;

	private const int POSITION_OFFSET_IN_LIST = 2;

	private const int POSITION_OFFSET_IN_LIST_NOFACEBOOK = 1;

	private void Init()
	{
		CancelInvoke();
	}

	private void OnEnable()
	{
		//IL_0074: Expected I4, but got Obj
		//IL_0074: Expected I4, but got Obj
		//IL_0074: Expected I4, but got Obj
		//IL_0074: Expected I4, but got Obj
		//IL_0074: Expected I4, but got Obj
		//IL_0074: Expected I4, but got Obj
		//IL_0074: Expected I4, but got Obj
		//IL_0074: Expected I4, but got Obj
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		if (~(_hasBeenInitialized ? 1u : 0u) != 0)
		{
			SetMaintenanceLabels();
			if (_contentList != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				FileStream fileStream = default;
				fileStream._002Ector((string)(object)_contentList, (FileMode)this, (FileAccess)_playerPrefab, (FileShare)_rankHeaderPrefab, (int)_spaceCell, (FileOptions)_emptyCell, (string)(object)_normalState, (byte)(int)_resultState != 0, (byte)(int)_offlineState != 0, (byte)(int)_facebookLogInButton != 0);
				object obj = this + 84;
				obj = fileStream;
			}
			_hasBeenInitialized = true;
		}
		ScrollToRightPosition();
	}

	private unsafe void OnDisable()
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00eb: Expected I, but got Obj
		//IL_0101: Expected Obj, but got I
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_012c: Expected I, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got I4
		//IL_01d5: Expected I, but got Obj
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_025c: Expected I, but got Obj
		//IL_0272: Expected Obj, but got I
		//IL_029d: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = new NullReferenceException();
			object obj3 = default;
			object obj2 = obj3 + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			TopRunNotificationSlideInManager instance = TopRunNotificationSlideInManager.instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			EventHandler<TournamentChangedEventArgs> eventHandler = default;
			object obj4 = eventHandler + 16;
			obj4 = this;
			((TopRunEventsHandler)(object)instance).OnTopRunChangedEvent -= eventHandler;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(TopRunOnlineGameOverScreen.OnApplicationResumed);
		object obj5 = action + 16;
		obj5 = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v64 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action;
		_isLoading = true;
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v22 (System.Boolean)+7A]");
		if ((nint)0 == 0)
		{
			loadingOverlay.tag = (string)1;
		}
		SetListContent();
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v28 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v58 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v33 (System.Boolean)+7A]");
		if ((nint)0 == 0)
		{
			((TopRunOnlineGameOverScreen)null).SetScrollPanelTopAnchor();
		}
		if (~(_hasBeenInitialized ? 1u : 0u) == 0)
		{
			ScrollToRightPosition();
		}
		else
		{
			OnEnable();
		}
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v41 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v51 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v46 (System.Boolean)+7A]");
		if ((nint)0 != 0)
		{
			IEnumerator routine = ((UIScreenController)this).HideAdsOverlayWithDelay(0.5f);
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	private void OnApplicationResumed()
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00d7: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I
		//IL_0118: Expected I, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = new NullReferenceException();
			object obj3 = default;
			object obj2 = obj3 + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			TopRunNotificationSlideInManager instance = TopRunNotificationSlideInManager.instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			bool flag = default;
			object obj4 = (flag ? 1 : 0) + 16;
			obj4 = this;
			((AwardCollectibleHelper)(object)instance).AddSocialLockCanOverlay(flag);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<string> action = default;
		object obj5 = action + 16;
		obj5 = this;
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v24 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action;
		loadingOverlay.tag = null;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		_ = 0;
	}

	public virtual void OnPlayerChanged(object o, PlayerInfoChangedEventArgs eventArg = null)
	{
		((TopRunNotificationSlideInManager)this).CalculateNextWarningTime();
	}

	private void SetAdapter()
	{
		//IL_014f: Expected I, but got Obj
		//IL_0165: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I4
		//IL_00bc: Expected I, but got Obj
		_isLoading = true;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v39 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (System.Boolean)+7A]");
		if ((nint)0 == 0)
		{
			loadingOverlay.tag = (string)1;
		}
		SetListContent();
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v33 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v23 (System.Boolean)+7A]");
		if ((nint)0 == 0)
		{
			((TopRunOnlineGameOverScreen)null).SetScrollPanelTopAnchor();
		}
		if (~(_hasBeenInitialized ? 1u : 0u) == 0)
		{
			ScrollToRightPosition();
		}
		else
		{
			OnEnable();
		}
	}

	private void ScrollToRightPosition()
	{
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0082: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_topRunListView).FindKernel((string)null) != 0 && _adapter != null)
		{
			_topRunListView.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
		}
		RefreshAdapterIfDataChanged();
	}

	private void TournamentChanged(object sender, EventArgs eventArg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_0292: Expected Obj, but got I4
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_02fa: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (eventArg != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v74+14]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj6 != null)
					{
						object obj7 = obj8 + 20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						object obj9 = obj4 + 4;
						object obj10 = obj9 + 1;
						obj9 = obj10;
						object obj11 = obj10 << 2;
						object obj12 = obj4 + obj11;
						obj12 = 104;
						break;
					}
				}
				continue;
			}
			object obj13 = obj4 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj4 + obj15;
			obj16 = 104;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj4 + obj17;
			if ((nint)obj18 == 104)
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

	public void RefreshAdapterIfDataChanged()
	{
		//IL_01a2: Expected VT, but got I4
		//IL_01b0: Expected I, but got Obj
		//IL_01c6: Expected Obj, but got I
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Expected VT, but got I4
		//IL_024a: Invalid comparison between VT and I4
		//IL_00cc: Expected VT, but got I4
		//IL_00d5: Expected VT, but got I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		bool flag = ((TopRunPlayerCell)this).IsLocalUser();
		Vector3 vector = (Vector3)((flag ? 1 : 0) - 2);
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v39 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<Characters.CharacterId> availableCharacterTokens = MysteryBox.GetAvailableCharacterTokens();
		object obj2 = availableCharacterTokens - 1;
		Vector3 vector2;
		if ((nint)availableCharacterTokens == 1 || ((nint)obj2 != 1 && (nint)obj2 == 2))
		{
			vector2 = vector;
		}
		else
		{
			bool flag2 = ((TopRunPlayerCell)this).IsLocalUser();
			Vector3 vector3 = (Vector3)((flag2 ? 1 : 0) - 1);
			vector2 = vector3;
		}
		Vector3 vector4;
		if (_currentState == TopRunStates.Results)
		{
			vector2 = (Vector3)0;
			vector4 = (Vector3)0;
		}
		else
		{
			vector4 = vector2;
		}
		if (vector4 > (object)(-1))
		{
			Container lastVisibleContainerOnScreen = _topRunListView.GetLastVisibleContainerOnScreen();
			if (lastVisibleContainerOnScreen != null)
			{
				UIScrollView uiScrollView = _topRunListView.uiScrollView;
				object obj3 = uiScrollView + 220;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v15+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
				float num3 = 0f * 0.5f;
				float strength = num3 - lastVisibleContainerOnScreen.height;
				_topRunListView.SmoothScrollToOffset(vector2, (Action)null, strength);
			}
		}
	}

	public void AnimateMedalIfNeeded()
	{
		//IL_0055: Expected I4, but got Obj
		if (_adapter != null)
		{
			SetMaintenanceLabels();
			if (_contentList != null)
			{
				((_003CAnimateMedalAfterSeconds_003Ed__36)(object)_adapter)._002Ector((int)_contentList);
			}
		}
		RefreshAdapterIfDataChanged();
	}

	private IEnumerator AnimateMedalAfterSeconds(float seconds)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		return enumerator;
	}

	private TopRunPlayerCell GetPlayerScriptFromList()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		TopRunPlayerCell topRunPlayerCell = default;
		((UnityEngine.Object)topRunPlayerCell).m_CachedPtr = (IntPtr)0;
		object obj = topRunPlayerCell + 16;
		obj = this;
		return topRunPlayerCell;
	}

	private void RefreshOrFetchNewTournament()
	{
		string text = tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 != null)
		{
			IEnumerator routine = ((UIScreenController)this).HideAdsOverlayWithDelay(0.5f);
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	private void SetScrollPanelTopAnchor()
	{
		//IL_0214: Expected I, but got Obj
		//IL_022a: Expected Obj, but got I
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0091: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got VT
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_00d2: Expected I, but got Obj
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_033d: Expected Obj, but got VT
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_0178: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		nint num = (nint)typeof(TopRunRewardHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<TopRunRewardHelper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v83 (Il2CppClass<TopRunRewardHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 40;
		object obj4 = obj3 + 32;
		object obj5 = obj3 + 24;
		object obj6 = obj3 + 16;
		object obj7 = obj3 + 8;
		TopRunRewardHelper.CalculateBeatenFriendsAward();
		object obj8 = default;
		if (obj8 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj9 = default;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v36 (Il2CppClass<System.DateTime>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v77 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj11 = default;
			obj5 = obj11;
			obj6 = DateTime.MinValue;
			obj4 = obj5;
			obj2 = obj6;
			object obj12 = obj4 & 0x3FFFFFFFFFFFFFFFL;
			object obj13 = obj2 & 0x3FFFFFFFFFFFFFFFL;
			if (obj12 != obj13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
				DateTime today = CDateTime.Today;
				nint num5 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v56 (Il2CppClass<System.DateTime>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num6 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v73 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj15 = default;
				obj7 = obj15;
				obj3 = today;
				obj4 = obj7;
				obj2 = obj3;
				object obj16 = obj4 & 0x3FFFFFFFFFFFFFFFL;
				object obj17 = obj2 & 0x3FFFFFFFFFFFFFFFL;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj18 = default;
					if (obj18 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
						return;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
	}

	private void SetCurrentState()
	{
		UIPanel scrollPanel = _scrollPanel;
		UIRect.AnchorPoint topAnchor = scrollPanel.topAnchor;
		topAnchor.absolute = -39;
		UIPanel scrollPanel2 = _scrollPanel;
		UIRect.AnchorPoint topAnchor2 = scrollPanel2.topAnchor;
		topAnchor2.relative = 0f;
		UIPanel scrollPanel3 = _scrollPanel;
		((ScoreMultiplier.ValueChangedEventArgs)(object)scrollPanel3.topAnchor)._002Ector(0f, -39f);
		_scrollPanel.ResetAndUpdateAnchors();
		_scrollPanel.ResetAnchors();
	}

	private int GetMyIndexInTheList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I4
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I
		//IL_02ac: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_03ff: Expected Obj, but got I4
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		TopRunListAdapter adapter = _adapter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v93 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v114 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v87+20]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v102+38]");
					if ((nint)0 != 0)
					{
						object obj9 = obj4 + 4;
						object obj10 = obj9 + 1;
						obj9 = obj10;
						object obj11 = obj10 << 2;
						object obj12 = obj4 + obj11;
						obj12 = 90;
						break;
					}
				}
				continue;
			}
			object obj13 = obj4 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj4 + obj15;
			obj16 = 88;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj4 + obj17;
			if ((nint)obj18 == 90)
			{
				object obj19 = obj4 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_045f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj21 = (nint)0 << 2;
			object obj22 = obj4 + obj21;
			if ((nint)obj22 == 88)
			{
				object obj23 = obj4 + 4;
				if ((nint)obj23 > -1)
				{
					object obj24 = obj23 + -1;
					obj23 = obj24;
				}
				goto IL_045f;
			}
		}
		object obj25 = default;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_045f;
		IL_045f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v87+20]");
		return 0;
	}

	private unsafe Player GetMyPlayerProfile(bool hasScore = true)
	{
		//IL_0018: Expected Obj, but got I4
		ref GameCenterProfile reference = ref *(GameCenterProfile*)null;
		GameCenterProfile result;
		if ((object)_playerPrefab != null)
		{
			bool flag = ((Dictionary<string, GameCenterProfile>)(object)_playerPrefab).TryGetValue((string)hasScore, out reference);
			bool flag2 = !flag;
			bool flag3 = !flag2;
			result = reference;
			if (!flag3)
			{
				result = null;
			}
		}
		else
		{
			result = null;
		}
		return (Player)(object)result;
	}

	private void SetListContent()
	{
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_014d: Expected I, but got Obj
		//IL_007b: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj2 = default;
			if (obj2 != null)
			{
				nint num = (nint)typeof(TopRunRewardHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v31 (Il2CppClass<TopRunRewardHelper>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(TopRunRewardHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v40 (Il2CppClass<TopRunRewardHelper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CelebrationReward pendingReward = TopRunRewardHelper.GetPendingReward();
				if (pendingReward != null)
				{
					_currentState = TopRunStates.Results;
				}
				else
				{
					_currentState = TopRunStates.Normal;
				}
				return;
			}
		}
		if (~(_isLoading ? 1u : 0u) != 0)
		{
			nint num3 = (nint)typeof(TopRunMaintenance);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v16 (Il2CppClass<TopRun.TopRunMaintenance>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(TopRunMaintenance);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23 (Il2CppClass<TopRun.TopRunMaintenance>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IManager manager = TopRunRoot.manager;
			if (manager != null)
			{
				_currentState = TopRunStates.OfflineMaintenance;
				return;
			}
		}
		_currentState = TopRunStates.Offline;
	}

	private void SetMaintenanceLabels()
	{
		//IL_0b05: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		string text = (string)0;
		object obj = default;
		if (_currentState != TopRunStates.Normal)
		{
			bool flag = obj == null;
			bool flag2 = _currentState != TopRunStates.Results;
			object obj2 = flag | flag2;
			if (obj2 == null)
			{
				goto IL_0065;
			}
		}
		else if (obj != null)
		{
			goto IL_0065;
		}
		bool flag3 = _currentState == TopRunStates.OfflineMaintenance;
		throw new IndexOutOfRangeException();
		IL_0065:
		throw new IndexOutOfRangeException();
	}

	private void AddFBButtonAfterMe(List<TopRunCell> topRunContentList, ref bool isFacebookButtonAdded)
	{
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_0100: Expected I, but got Obj
		string text = tag;
		if (!((GameObject)(object)text).activeInHierarchy)
		{
			return;
		}
		string text2 = tag;
		string text3 = ((GameObject)(object)text2).tag;
		if (text3 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj2 = default;
		if (obj2 != null)
		{
			return;
		}
		_isLoading = false;
		nint num = (nint)typeof(TopRunRewardHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21 (Il2CppClass<TopRunRewardHelper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v30 (Il2CppClass<TopRunRewardHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TopRunRewardHelper.CalculateBeatenFriendsAward();
		SetListContent();
		AnimateMedalIfNeeded();
		loadingOverlay.tag = null;
	}

	public TopRunOnlineGameOverScreen()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_00b8: Expected I, but got Obj
		//IL_00ce: Expected Obj, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0114: Expected I4, but got Obj
		//IL_0123: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		EventArgs e = default;
		TopRunOnlineScreen topRunOnlineScreen = (TopRunOnlineScreen)(e + 8);
		topRunOnlineScreen = (TopRunOnlineScreen)0;
		object obj = e + 4;
		obj = 0;
		e = (EventArgs)0;
		nint num = (nint)typeof(TopRunMaintenance);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppClass<TopRun.TopRunMaintenance>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(TopRunMaintenance);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v29 (Il2CppClass<TopRun.TopRunMaintenance>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		topRunOnlineScreen.TournamentChanged(obj, e);
		object obj3 = this - -64;
		((UILabel)obj3).fontSize = (int)topRunOnlineScreen;
		_maintenanceLabel2.fontSize = (int)obj;
		_maintenanceLabel3.fontSize = (int)e;
		((RewardForVideoButton)(object)_maintenanceLabelLayout).Init((VideoButtonPayload)null);
	}
}
