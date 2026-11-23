using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.UI;
using Missions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI.Screens;

public class AwardsScreen : UIScreen
{
	public class AwardListAdapter : ListAdapter<AwardCell>
	{
		public GameObject finishedAwardPrefab;

		public GameObject awardPrefab;

		public GameObject titlePrefab;

		public AwardsScreen screenReference;

		public AwardListAdapter(List<AwardCell> awardList, GameObject awardCell, GameObject finishedAwardCell, AwardsScreen screenReference)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v4 (Il2CppClass<Il2CppRgctx<Kiloo.Common.UI.ListAdapter`1<UI.AwardCell>>>)+4] (should have been resolved before IL gen)");
			finishedAwardPrefab = finishedAwardCell;
			awardPrefab = awardCell;
			this.screenReference = screenReference;
		}

		public override int GetModelType(int index)
		{
			//IL_0005: Expected I, but got Obj
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			nint num = (nint)this;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<UI.Screens.AwardsScreen+AwardListAdapter>)+104] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v2+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v2+8]");
				bool flag = (nint)0 == 1;
				int result = 2;
				if (!flag)
				{
					result = 1;
				}
				return result;
			}
			return 1;
		}

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_0176: Expected I, but got Obj
			//IL_0145: Expected Obj, but got I
			//IL_0145: Expected Obj, but got I
			//IL_0167: Expected Obj, but got I
			//IL_0167: Expected Obj, but got I
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S2_v2 (Il2CppClass<UI.Screens.AwardsScreen+AwardListAdapter>)+104] (should have been resolved before IL gen)");
			Container container2 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
					if ((nint)0 != 1)
					{
						container2 = null;
						goto IL_018e;
					}
					Container container3 = default;
					container3._002Ector(finishedAwardPrefab);
					AwardFinishedCellHelper component = container3.model.GetComponent<AwardFinishedCellHelper>();
					container2 = container3;
				}
				else
				{
					Container container4 = default;
					container4._002Ector(awardPrefab);
					AwardCellHelper component2 = container4.model.GetComponent<AwardCellHelper>();
					container2 = container4;
				}
				object tag = default;
				container2.tag = tag;
			}
			goto IL_018e;
			IL_018e:
			if (!isMeasurePass)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v14+8]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+C]");
					((AwardCellHelper)num2).InitCell((Award)0, screenReference);
					return container2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+8]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v14+C]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6+C]");
					((AwardFinishedCellHelper)num3).InitCell((Award)0);
				}
			}
			return container2;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__11_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003COnEnable_003Eb__11_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("MeScreen");
		}
	}

	private sealed class _003CScrollOnTop_003Ed__23(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AwardsScreen _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0093: Expected I, but got Obj
			//IL_00bc: Expected I, but got Obj
			//IL_00ce: Expected I, but got Obj
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Canvas.ForceUpdateCanvases();
					ScrollRect componentInChildren = _003C_003E4__this.GetComponentInChildren<ScrollRect>();
					VerticalLayoutGroup component = componentInChildren.m_Content.GetComponent<VerticalLayoutGroup>();
					nint num = (nint)component;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S1_v13 (Il2CppClass<UnityEngine.UI.VerticalLayoutGroup>)+1A4] (should have been resolved before IL gen)");
					ContentSizeFitter component2 = componentInChildren.m_Content.GetComponent<ContentSizeFitter>();
					nint num2 = (nint)component2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S1_v18 (Il2CppClass<UnityEngine.UI.ContentSizeFitter>)+15C] (should have been resolved before IL gen)");
					nint num3 = (nint)componentInChildren;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v97 @ S3_v3 (Il2CppClass<UnityEngine.UI.ScrollRect>)+244] (should have been resolved before IL gen)");
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = 0.15f;
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

	private GameObject _awardPrefab;

	private GameObject _finishedAwardPrefab;

	private Transform awardContent;

	private int _indexOnHide;

	private AwardListAdapter _adapter;

	private List<AwardCell> _contentList;

	private bool _isSubscribedToChangedScreen;

	private Button closeButton;

	private bool _containsCollectableAward;

	private bool _facebookLoginRunning;

	private unsafe void OnEnable()
	{
		Button button = closeButton;
		bool flag = _003C_003Ec._003C_003E9__11_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__11_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003COnEnable_003Eb__11_0));
			_003C_003Ec._003C_003E9__11_0 = unityAction;
			call = unityAction;
		}
		button.m_OnClick.AddListener(call);
	}

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Screens.AwardsScreen>)+104] (should have been resolved before IL gen)");
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		bool flag = SetListContent();
		IEnumerator routine = ScrollOnTop();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private void RefreshAwards()
	{
		bool containsCollectableAward = SetListContent();
		_containsCollectableAward = containsCollectableAward;
		IEnumerator routine = ScrollOnTop();
		Coroutine coroutine = StartCoroutine(routine);
	}

	public override void Show()
	{
		base.Show();
		PlayerInfo instance = PlayerInfo.Instance;
		if (!instance._hasShownAwardsIntroductionPopup)
		{
			instance._dirty = true;
			instance._hasShownAwardsIntroductionPopup = true;
		}
	}

	public unsafe override void Hide()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Ref, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		base.Hide();
		UIScreenController instance = UIScreenController.Instance;
		if (instance.isShowingPopup)
		{
			return;
		}
		_ = 0;
		object obj3 = obj + 8;
		AwardsManager instance2 = AwardsManager.instance;
		List<Award> sortedListAwards = instance2.GetSortedListAwards(out *(bool*)(obj + 47));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 24;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_020a;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v75+3C]");
					if ((nint)0 != 0)
					{
						_ = 0;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 != obj9;
			object obj10 = obj11;
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
				goto IL_020a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_020a:
			object obj13 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8F4");
			return;
		}
		_ = 0;
		object obj14 = obj + 8;
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

	private void ForceUpdateAnchors()
	{
	}

	public void OnScreenChanged(string screenName)
	{
		if (screenName != "AwardsScreen")
		{
			if (~(_isSubscribedToChangedScreen ? 1u : 0u) == 0)
			{
				UIScreenController instance = UIScreenController.Instance;
				throw new ArgumentException();
			}
		}
		else if (!_isSubscribedToChangedScreen)
		{
			UIScreenController instance2 = UIScreenController.Instance;
			throw new ArgumentException();
		}
	}

	private void PopupClosed(string popupName)
	{
		bool flag = popupName == "CelebrationPopup";
	}

	private void OnFailSlideInFinish()
	{
		FacebookStatusChanged(success: false);
	}

	private void QueueFacebookFailSlideIn(Action onFinishCallback)
	{
		UIScreenController instance = UIScreenController.Instance;
		UIScreenController.SlideIn slideIn = default;
		slideIn._002Ector(UIScreenController.SlideInType.Facebook, UISlideInFacebook.FacebookSlideInState.ConnectFailed, onFinishCallback);
		instance.QueueSlideIn(slideIn);
	}

	private void FacebookStatusChanged(bool success)
	{
		if (success)
		{
			bool flag = FacebookRewardsInfo.HasReceivedAllAvailableRewards();
			UIScreenController instance = UIScreenController.Instance;
			if (!flag)
			{
				instance.PushPopup("FacebookRewardsPopup");
			}
			else
			{
				UIScreenController.SlideIn slideIn = default;
				slideIn._002Ector(UIScreenController.SlideInType.Facebook, UISlideInFacebook.FacebookSlideInState.ConnectSucceeded);
				instance.QueueSlideIn(slideIn);
			}
		}
		HouseKeeper.SetFacebookPayoutActionToDefault();
		_facebookLoginRunning = false;
		RefreshAwards();
	}

	private unsafe bool SetListContent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		((List<T>)(object)_contentList).Clear();
		AwardsManager instance = AwardsManager.instance;
		List<Award> sortedListAwards = instance.GetSortedListAwards(out *(bool*)(obj + 15));
		int num = 0;
		AwardCell awardCell = default;
		while (num < sortedListAwards._size)
		{
			Award award = sortedListAwards.get_Item(num);
			AwardCellType cellType;
			if (award._currentActiveAwardState != AwardState.Finished || ~(award.isInPreview__BackingField ? 1u : 0u) == 0)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(_awardPrefab, awardContent);
				AwardCellHelper component = gameObject.GetComponent<AwardCellHelper>();
				bool flag = component != null;
				bool flag2 = !flag;
				cellType = AwardCellType.AWARD;
				if (!flag2)
				{
					component.InitCell(award, this);
					cellType = AwardCellType.AWARD;
				}
			}
			else
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(_finishedAwardPrefab, awardContent);
				AwardFinishedCellHelper component2 = gameObject2.GetComponent<AwardFinishedCellHelper>();
				bool flag3 = component2 != null;
				bool flag4 = !flag3;
				cellType = AwardCellType.FINISHED_AWARD;
				if (!flag4)
				{
					component2.InitCell(award);
					cellType = AwardCellType.FINISHED_AWARD;
				}
			}
			awardCell.award = award;
			awardCell.cellType = cellType;
			_contentList.Add(awardCell);
			int num2 = num + 1;
			num = num2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		return false;
	}

	private IEnumerator ScrollOnTop()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public AwardsScreen()
	{
		List<AwardCell> list = default;
		list._002Ector();
		_contentList = list;
		base._002Ector();
	}
}
