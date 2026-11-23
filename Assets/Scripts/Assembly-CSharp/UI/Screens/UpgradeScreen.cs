using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens;

public class UpgradeScreen : UIScreen
{
	private sealed class _003CReadYPanelPosAfterFrames_003Ed__18(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public int numberofFrames;

		private int _003Cframes_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0081;
				}
				_003C_003E1__state = -1;
				num = _003Cframes_003E5__2;
			}
			else
			{
				_003Cframes_003E5__2 = 0;
				_003C_003E1__state = -1;
				num = 0;
			}
			if (num < numberofFrames)
			{
				_003C_003E2__current = null;
				int num2 = num + 1;
				_003Cframes_003E5__2 = num2;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_0081;
			IL_0081:
			return false;
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

	private sealed class _003CScrollOnTop_003Ed__21(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UpgradeScreen _003C_003E4__this;

		private ScrollRect _003CScrollRect_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_009a: Expected I, but got Obj
			//IL_00cd: Expected I, but got Obj
			//IL_0164: Expected I, but got Obj
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						ScrollRect scrollRect = _003CScrollRect_003E5__2;
						nint num = (nint)scrollRect;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S3_v3 (Il2CppClass<UnityEngine.UI.ScrollRect>)+244] (should have been resolved before IL gen)");
						ScrollRect scrollRect2 = _003CScrollRect_003E5__2;
						GameObject gameObject = scrollRect2.m_Content.gameObject;
						gameObject.SetActive(value: true);
					}
					return false;
				}
				_003C_003E1__state = -1;
				ScrollRect scrollRect3 = _003CScrollRect_003E5__2;
				GameObject gameObject2 = scrollRect3.m_Content.gameObject;
				gameObject2.SetActive(value: false);
				object obj = default;
				_003C_003E2__current = obj;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			Canvas.ForceUpdateCanvases();
			ScrollRect componentInChildren = _003C_003E4__this.GetComponentInChildren<ScrollRect>();
			_003CScrollRect_003E5__2 = componentInChildren;
			ScrollRect scrollRect4 = _003CScrollRect_003E5__2;
			VerticalLayoutGroup component = scrollRect4.m_Content.GetComponent<VerticalLayoutGroup>();
			nint num2 = (nint)component;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ S1_v8 (Il2CppClass<UnityEngine.UI.VerticalLayoutGroup>)+1A4] (should have been resolved before IL gen)");
			ScrollRect scrollRect5 = _003CScrollRect_003E5__2;
			ContentSizeFitter component2 = scrollRect5.m_Content.GetComponent<ContentSizeFitter>();
			nint num3 = (nint)component2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S1_v13 (Il2CppClass<UnityEngine.UI.ContentSizeFitter>)+15C] (should have been resolved before IL gen)");
			object obj2 = default;
			_003C_003E2__current = obj2;
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

	private sealed class _003CRefreshTable_003Ed__23(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UpgradeScreen _003C_003E4__this;

		public bool isReturningFromCelebration;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected VT, but got Unknown
			//IL_0298: Expected Obj, but got VT
			//IL_02bd: Expected Obj, but got F4
			//IL_02ca: Expected F4, but got Obj
			//IL_02d2: Expected native int or pointer, but got VT
			object obj = default;
			Vector2 vector = (Vector2)(obj + -64);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						UpgradeScreen upgradeScreen = _003C_003E4__this;
						_003C_003E1__state = -1;
						if (_003C_003E4__this.IsJackpotEventActive() && !isReturningFromCelebration)
						{
							PlayerInfo instance = PlayerInfo.Instance;
							bool flag = instance._lastPurchasedBundle != InAppData.BundleTier.BundleTier5;
							float num = 150f;
							if (!flag)
							{
								num = 70f;
							}
							float num2 = num + 80f;
							PlayerInfo instance2 = PlayerInfo.Instance;
							if (!instance2._hasPayedOutFacebook)
							{
								num = num2;
							}
							UIPanel component = upgradeScreen.DragPanel.GetComponent<UIPanel>();
							if (component != null)
							{
								Transform transform = component.transform;
								Vector3 localPosition = transform.localPosition;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
								float num3 = 0f + num;
								Transform transform2 = component.transform;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+38]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
								_ = 0;
								Vector3 localPosition2 = (Vector3)(vector + 8);
								transform2.localPosition = localPosition2;
								object obj2 = component.mClipOffset - Vector2.zeroVector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v39 (UIPanel)+F0]");
								float num4 = 0f - num;
								object obj3 = num4 << 32;
								float x = obj2 | obj3;
								((Vector2*)(nint)vector)->x = x;
								component.clipOffset = vector;
							}
						}
					}
					bool result = default;
					return result;
				}
				_003C_003E1__state = -1;
				object obj4 = default;
				_003C_003E2__current = obj4;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			object obj5 = default;
			_003C_003E2__current = obj5;
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

	public GameObject ConsumablePrefab;

	private GameObject DragPanel;

	private GameObject content;

	public List<UpgradeHelper> cachedUpgradeHelpers;

	private bool _isReturningFromCelebration;

	private bool _facebookLoginRunning;

	private bool init;

	private GameObject[] _skipMissions;

	[NonSerialized]
	public PowerupType[] powerupPermanent;

	public static bool forceScrollRearange;

	private bool _isSubscribedToChangedScreen;

	private IEventManager _activeEventManager;

	private int _indexExpanded;

	private UIScreenController _screenController;

	public int indexExpanded
	{
		get
		{
			return _indexExpanded;
		}
		set
		{
			_indexExpanded = value;
		}
	}

	private void Start()
	{
		IEnumerator routine = ReadYPanelPosAfterFrames(1);
		Coroutine coroutine = StartCoroutine(routine);
		throw new ArgumentException();
	}

	private IEnumerator ReadYPanelPosAfterFrames(int numberofFrames)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public unsafe override void Init()
	{
		//IL_00c9: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UI.Screens.UpgradeScreen>)+104] (should have been resolved before IL gen)");
		MissionsManager instance = MissionsManager.Instance;
		MissionsManager.MissionCompleteHandler missionCompleteHandler = default;
		missionCompleteHandler._002Ector(this, (nint)__ldftn(UpgradeScreen.OnMissionComplete));
		Delegate obj = Delegate.Combine(instance.onMissionComplete, missionCompleteHandler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		MissionsManager.MissionCompleteHandler onMissionComplete = default;
		instance.onMissionComplete = onMissionComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		MissionsManager instance2 = MissionsManager.Instance;
		MissionsManager.MissionSetCompleteHandler missionSetCompleteHandler = default;
		missionSetCompleteHandler._002Ector(this, (nint)__ldftn(UpgradeScreen.OnMissionSetComplete));
		Delegate obj2 = Delegate.Combine(instance2.onMissionSetComplete, missionSetCompleteHandler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		MissionsManager.MissionSetCompleteHandler onMissionSetComplete = default;
		instance2.onMissionSetComplete = onMissionSetComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UIScreenController instance3 = UIScreenController.Instance;
		_screenController = instance3;
		FillTable();
	}

	public override void Show()
	{
		base.Show();
		if (IsJackpotEventActive())
		{
			forceScrollRearange = true;
		}
		if (~(forceScrollRearange ? 1u : 0u) == 0 && !_isReturningFromCelebration)
		{
			forceScrollRearange = false;
			bool flag = DragPanel != null;
		}
		IEnumerator routine = ScrollOnTop();
		Coroutine coroutine = StartCoroutine(routine);
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			IEnumerator routine2 = RefreshTable(_isReturningFromCelebration);
			Coroutine coroutine2 = StartCoroutine(routine2);
		}
	}

	public IEnumerator ScrollOnTop()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private bool IsJackpotEventActive()
	{
		bool result;
		if (_activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			bool flag = (nint)obj == 4;
			result = true;
			if (flag)
			{
				goto IL_0062;
			}
		}
		result = false;
		goto IL_0062;
		IL_0062:
		return result;
	}

	private IEnumerator RefreshTable(bool isReturningFromCelebration)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public override void Hide()
	{
		base.Hide();
		if (~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			HouseKeeper.SetFacebookPayoutActionToDefault();
			_facebookLoginRunning = false;
		}
	}

	public void OnScreenChanged(string screenName)
	{
		if (screenName != "UpgradesUI_shop")
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

	private unsafe void OnDestroy()
	{
		UIScreenController screenController = _screenController;
		if (~(screenController.stoppingFromEditor ? 1u : 0u) != 0)
		{
			MissionsManager instance = MissionsManager.Instance;
			MissionsManager.MissionCompleteHandler missionCompleteHandler = default;
			missionCompleteHandler._002Ector(this, (nint)__ldftn(UpgradeScreen.OnMissionComplete));
			Delegate obj = Delegate.Remove(instance.onMissionComplete, missionCompleteHandler);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			MissionsManager.MissionCompleteHandler onMissionComplete = default;
			instance.onMissionComplete = onMissionComplete;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			MissionsManager instance2 = MissionsManager.Instance;
			MissionsManager.MissionSetCompleteHandler missionSetCompleteHandler = default;
			missionSetCompleteHandler._002Ector(this, (nint)__ldftn(UpgradeScreen.OnMissionSetComplete));
			Delegate obj2 = Delegate.Remove(instance2.onMissionSetComplete, missionSetCompleteHandler);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			MissionsManager.MissionSetCompleteHandler onMissionSetComplete = default;
			instance2.onMissionSetComplete = onMissionSetComplete;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			throw new ArgumentException();
		}
	}

	private void PopupClosed(string popupName)
	{
		if (popupName == "CelebrationPopup")
		{
			_isReturningFromCelebration = true;
		}
	}

	private void FillTable()
	{
		//IL_0037: Expected Obj, but got I4
		if (!init)
		{
			init = true;
			PowerupType[] array = powerupPermanent;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			GameObject[] skipMissions = default;
			_skipMissions = skipMissions;
			object obj = 0;
			PowerupType[] array2 = powerupPermanent;
			if ((nint)obj < array2.Length)
			{
				object obj2 = obj << 2;
				object obj3 = (object)array2 + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v7+10]");
				GameObject gameObject = MakeBuyable(PowerupType._notset);
				throw new ArrayTypeMismatchException();
			}
		}
	}

	private GameObject MakeBuyable(PowerupType powerupType)
	{
		GameObject gameObject = NGUITools.AddChild(content, ConsumablePrefab);
		UIPanel component = DragPanel.GetComponent<UIPanel>();
		UpgradeHelper component2 = gameObject.GetComponent<UpgradeHelper>();
		component2.InitPermanent(powerupType, component);
		UpgradeHelper component3 = gameObject.GetComponent<UpgradeHelper>();
		cachedUpgradeHelpers.Add(component3);
		return gameObject;
	}

	private void OnMissionComplete(string payload)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I
		int num = 0;
		while (true)
		{
			GameObject[] skipMissions = _skipMissions;
			if (skipMissions.Length > num)
			{
				int num2 = num << 2;
				object obj = skipMissions + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v16+10]");
				if ((UnityEngine.Object)0 != null)
				{
					MissionsManager instance = MissionsManager.Instance;
					MissionInfo missionInfo = instance.GetMissionInfo(num);
				}
				int num3 = num + 1;
				num = num3;
				continue;
			}
			break;
		}
	}

	private void OnMissionSetComplete()
	{
		//IL_0060: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			GameObject[] skipMissions = _skipMissions;
			if (skipMissions.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)skipMissions + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v12+10]");
				bool flag = (UnityEngine.Object)0 != null;
				object obj4 = obj + 1;
				obj = obj4;
				continue;
			}
			break;
		}
	}

	public UpgradeScreen()
	{
		Dictionary<PowerupType, Upgrade> upgrades = Upgrades.upgrades;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (System.Collections.Generic.Dictionary`2<PowerupType, Upgrade>)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (System.Collections.Generic.Dictionary`2<PowerupType, Upgrade>)+18]");
		List<UpgradeHelper> list = default;
		list._002Ector((int)(num - 0));
		cachedUpgradeHelpers = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E._219D559C838B542EFF73168D5B12F97DE6CEAD92F977F6725B5D13218A68EEC3));
		powerupPermanent = (PowerupType[])array;
		_indexExpanded = -1;
		base._002Ector();
	}
}
