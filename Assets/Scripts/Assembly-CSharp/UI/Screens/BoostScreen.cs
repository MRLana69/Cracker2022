using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens;

public class BoostScreen : UIScreen
{
	private sealed class _003CReadYPanelPosAfterFrames_003Ed__17(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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

	private sealed class _003CScrollOnTop_003Ed__20(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BoostScreen _003C_003E4__this;

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

	public GameObject ConsumablePrefab;

	private GameObject DragPanel;

	private GameObject content;

	public List<UpgradeHelper> cachedUpgradeHelpers;

	private bool _isReturningFromCelebration;

	private bool init;

	[NonSerialized]
	public PowerupType[] powerupSingleUse;

	[NonSerialized]
	public PowerupType[] powerupSkipMission;

	public static bool forceScrollRearange;

	private bool _isSubscribedToChangedScreen;

	private IEventManager _activeEventManager;

	private int _numberOfObjects;

	private int _indexExpanded;

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

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Screens.BoostScreen>)+104] (should have been resolved before IL gen)");
		InitTable();
	}

	public override void Show()
	{
		base.Show();
		IEnumerator routine = ScrollOnTop();
		Coroutine coroutine = StartCoroutine(routine);
	}

	public IEnumerator ScrollOnTop()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public override void Hide()
	{
		base.Hide();
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

	private void PopupClosed(string popupName)
	{
		if (popupName == "CelebrationPopup")
		{
			_isReturningFromCelebration = true;
		}
	}

	public void InitTable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		//IL_04a4: Expected Obj, but got I4
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_0164: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		//IL_0256: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_030f: Expected Obj, but got I
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got Unknown
		//IL_03f6: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj3 = obj + 48;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		object obj5 = default;
		PowerupType[] array;
		object obj6 = default;
		object obj7 = default;
		object obj8;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		BoostScreen boostScreen = default;
		while (true)
		{
			_ = 0;
			object obj4 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					goto IL_0229;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 == 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					array = (PowerupType[])0;
					if (!flag)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag2 = (nint)0 == 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						array = (PowerupType[])0;
						if (!flag2)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							array = (PowerupType[])0;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					array = (PowerupType[])0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				array = (PowerupType[])0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj6 != obj7;
			obj8 = obj9;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				obj = obj10;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0229;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj11;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			boostScreen = (BoostScreen)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
			IL_0229:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B2D7");
			((List<T>)(object)cachedUpgradeHelpers).Clear();
			array = powerupSingleUse;
			obj8 = 0;
			break;
		}
		while (array.Length > (nint)obj8)
		{
			object obj12 = obj8 << 2;
			object obj13 = (object)array + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v40+10]");
			GameObject gameObject = ((BoostScreen)num).MakeBuyable(PowerupType._notset);
			int numberOfObjects = boostScreen._numberOfObjects + 1;
			boostScreen._numberOfObjects = numberOfObjects;
			object obj14 = obj8 + 1;
			obj8 = obj14;
		}
		int num2 = 0;
		while (true)
		{
			PowerupType[] array2 = boostScreen.powerupSkipMission;
			if (array2.Length > num2)
			{
				MissionsManager instance = MissionsManager.Instance;
				MissionInfo missionInfo = instance.GetMissionInfo(num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
				object obj15 = (nint)0 & (nint)1;
				if (obj15 == null)
				{
					int num3 = num2 << 2;
					object obj16 = boostScreen.powerupSkipMission + num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S1_v37+10]");
					GameObject gameObject2 = ((BoostScreen)num4).MakeBuyable(PowerupType._notset);
				}
				int numberOfObjects2 = boostScreen._numberOfObjects + 1;
				boostScreen._numberOfObjects = numberOfObjects2;
				int num5 = num2 + 1;
				num2 = num5;
				continue;
			}
			break;
		}
	}

	private GameObject MakeBuyable(PowerupType powerupType)
	{
		GameObject gameObject = NGUITools.AddChild(content, ConsumablePrefab);
		UIPanel component = DragPanel.GetComponent<UIPanel>();
		UpgradeHelper component2 = gameObject.GetComponent<UpgradeHelper>();
		component2.InitSingle(this, powerupType, component);
		cachedUpgradeHelpers.Add(component2);
		return gameObject;
	}

	public BoostScreen()
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
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E.B740D6915718E2FD5C35A66EA74CBB8DD7C12AA89EAC7074E2127A0F02859FD5));
		powerupSingleUse = (PowerupType[])array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array2 = default;
		RuntimeHelpers.InitializeArray(array2, __ldtoken(_003CPrivateImplementationDetails_003E._5B10CE92F0BB26735E806ACCA27751E9CF0A7859C9D0FCDBD4011C0C5E60C8C9));
		powerupSkipMission = (PowerupType[])array2;
		_indexExpanded = -1;
		base._002Ector();
	}
}
