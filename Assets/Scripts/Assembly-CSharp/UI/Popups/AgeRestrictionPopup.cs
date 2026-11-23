using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Cpp2ILInjected;
using DanielLochner.Assets.SimpleScrollSnap;
using Info;
using Kiloo.Common.Timer;
using UI.Popups.AgeRestrictionPopupInternal;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI.Popups;

public class AgeRestrictionPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ListContentElement, bool> _003C_003E9__15_0;

		public static Func<ListContentElement, bool> _003C_003E9__15_1;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal bool _003CCreateElement_003Eb__15_0(ListContentElement m)
		{
			return m.content__BackingField == "Jul";
		}

		internal bool _003CCreateElement_003Eb__15_1(ListContentElement m)
		{
			return m.content__BackingField == "2000";
		}
	}

	private sealed class _003CDelay_003Ed__23(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float second;

		public Action callback;

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
					Action action = callback;
					if (callback != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = second;
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

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public GameObject objectToPosition;

		public Vector3 newRotation;

		public Vector3 newScale;

		public AgeRestrictionPopup _003C_003E4__this;

		internal void _003CPositionModelOnSprite_003Eb__0()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Expected VT, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected VT, but got Unknown
			//IL_01e0: Expected I, but got Obj
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Expected VT, but got Unknown
			//IL_0328: Unknown result type (might be due to invalid IL or missing references)
			//IL_032d: Expected VT, but got Unknown
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected VT, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected VT, but got Unknown
			//IL_014d: Expected Obj, but got VT
			//IL_015a: Expected VT, but got Obj
			object obj2 = default;
			object obj = obj2 - 208;
			UIScreenController instance = UIScreenController.Instance;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
			_ = 0;
			Vector3 position = (Vector3)(obj + 96);
			Vector3 vector = instance.Camera2DNormal.WorldToScreenPoint(position);
			UIScreenController instance2 = UIScreenController.Instance;
			_ = 1065353216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			_ = 0;
			Vector3 position2 = (Vector3)(obj + 80);
			Vector3 vector2 = instance2.Camera3D.ScreenToWorldPoint(position2);
			Transform transform = objectToPosition.transform;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v37 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			float num3 = (float)Vector3.forwardVector * -800f;
			float num4 = num3 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
			float num5 = 0f * -800f;
			float num6 = num5 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
			float num7 = 0f * -800f;
			float num8 = num7 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Vector3 localPosition = (Vector3)(obj - -64);
			transform.localPosition = localPosition;
			Transform transform2 = objectToPosition.transform;
			float num9 = (float)newRotation * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.AgeRestrictionPopup+<>c__DisplayClass29_0)+10]");
			float num10 = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.AgeRestrictionPopup+<>c__DisplayClass29_0)+14]");
			float num11 = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
			_ = 0;
			Vector3 euler = (Vector3)(obj + 48);
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(obj + 32);
			transform2.localRotation = localRotation;
			Transform transform3 = objectToPosition.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.AgeRestrictionPopup+<>c__DisplayClass29_0)+20]");
			_ = 0;
			_ = newScale;
			Vector3 localScale = (Vector3)(obj + 16);
			transform3.localScale = localScale;
			ScaleByUI scaleByUI = objectToPosition.AddComponent<ScaleByUI>();
			AgeRestrictionPopup ageRestrictionPopup = _003C_003E4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.AgeRestrictionPopup+<>c__DisplayClass29_0)+20]");
			_ = 0;
			obj = newScale;
			scaleByUI.startScale = (Vector3)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			scaleByUI.follow = ageRestrictionPopup.center;
		}
	}

	private Button AcceptButton;

	private ListElementHelper ListElementCell;

	private SimpleScrollSnap MonthScroll;

	private Transform MonthContent;

	private List<ListContentElement> _contentListMonth;

	private List<ListElementHelper> _listViewMonth;

	private SimpleScrollSnap YearScroll;

	private Transform YearContent;

	private List<ListContentElement> _contentListYear;

	private List<ListElementHelper> _listViewYear;

	private CharacterScreenController _character;

	private Transform center;

	private UIPopupIn UIPopupIn;

	private unsafe void OnEnable()
	{
		Button acceptButton = AcceptButton;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(AgeRestrictionPopup._003COnEnable_003Eb__12_0));
		acceptButton.m_OnClick.AddListener(unityAction);
		SimpleScrollSnap monthScroll = MonthScroll;
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(AgeRestrictionPopup._003COnEnable_003Eb__12_1));
		monthScroll.onPanelChanged.AddListener(unityAction2);
		SimpleScrollSnap yearScroll = YearScroll;
		UnityAction unityAction3 = default;
		unityAction3._002Ector(this, (nint)__ldftn(AgeRestrictionPopup._003COnEnable_003Eb__12_2));
		yearScroll.onPanelChanged.AddListener(unityAction3);
		UnityAction unityAction4 = default;
		unityAction4._002Ector(this, (nint)__ldftn(AgeRestrictionPopup._003COnEnable_003Eb__12_3));
		OutConplete.AddListener(unityAction4);
	}

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Popups.AgeRestrictionPopup>)+104] (should have been resolved before IL gen)");
		CreateElement();
	}

	private void ClearElement()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<ListElementHelper> listViewMonth = _listViewMonth;
		if (listViewMonth._size == 0)
		{
			goto IL_025b;
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
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
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
					goto IL_0233;
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
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
						}
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 != obj8;
			object obj9 = obj10;
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
				goto IL_0233;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj9 = obj11;
			break;
			IL_0233:
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18BA");
			((List<T>)(object)_listViewMonth).Clear();
			goto IL_025b;
		}
		_ = 0;
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			goto IL_05ac;
		}
		goto IL_063f;
		IL_063f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		return;
		IL_05ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_063f;
		IL_025b:
		List<ListElementHelper> listViewYear = _listViewYear;
		if (listViewYear._size == 0)
		{
			return;
		}
		object obj14 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj15 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj17 = default;
		object obj18 = default;
		object obj19 = default;
		object obj20 = default;
		object obj21 = default;
		while (true)
		{
			_ = 0;
			object obj16 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj17 == null)
				{
					goto IL_0519;
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
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
						}
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj18 != obj19;
			object obj9 = obj20;
			if (flag2)
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
				goto IL_0519;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj9 = obj21;
			break;
			IL_0519:
			object obj22 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18BA");
			((List<T>)(object)_listViewYear).Clear();
			return;
		}
		_ = 0;
		object obj23 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			goto IL_05ac;
		}
		goto IL_063f;
	}

	private void CreateElement()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected Obj, but got Unknown
		//IL_085d: Expected Obj, but got I4
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected I, but got Unknown
		//IL_08aa: Expected Obj, but got I
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_041b: Expected Obj, but got I
		//IL_02ed: Expected I4, but got Obj
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected Obj, but got Unknown
		//IL_0951: Expected Obj, but got I4
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Expected I, but got Unknown
		//IL_099e: Expected Obj, but got I
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected Obj, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected Obj, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_0755: Expected Obj, but got I
		//IL_06a3: Expected I4, but got Obj
		object obj = default;
		AgeRestrictionPopup ageRestrictionPopup = (AgeRestrictionPopup)(obj - 48);
		ageRestrictionPopup.InComplete = null;
		((UIScreen)ageRestrictionPopup)._footerInited = false;
		GameObject gameObject = MonthScroll.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = YearScroll.gameObject;
		gameObject2.SetActive(value: false);
		List<ListContentElement> contentListMonth = ageRestrictionPopup.CreateContentListMonth();
		_contentListMonth = contentListMonth;
		bool flag = _003C_003Ec._003C_003E9__15_0 == null;
		bool flag2 = !flag;
		Func<ListContentElement, bool> predicate = _003C_003Ec._003C_003E9__15_0;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		ListContentElement listContentElement = Enumerable.FirstOrDefault(_contentListMonth, predicate);
		SimpleScrollSnap monthScroll = MonthScroll;
		monthScroll.startingPanel = listContentElement.id;
		object obj2 = ageRestrictionPopup + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		ageRestrictionPopup.InComplete = (UnityEvent)ageRestrictionPopup._selectedFooterButton;
		((UIScreen)ageRestrictionPopup)._footerInited = ((UIScreen)ageRestrictionPopup).addScreen;
		nint cachedPtr = (nint)(ageRestrictionPopup + 32);
		((UnityEngine.Object)ageRestrictionPopup).m_CachedPtr = cachedPtr;
		((UIScreen)ageRestrictionPopup).addScreen = false;
		ageRestrictionPopup._footerPrefab = (GameObject)(nint)((UnityEngine.Object)ageRestrictionPopup).m_CachedPtr;
		object obj4 = default;
		object obj5 = default;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj16 = default;
		object obj17 = default;
		object obj18 = default;
		object obj19 = default;
		object obj20 = default;
		object obj21 = default;
		while (true)
		{
			_ = 0;
			object obj3 = ageRestrictionPopup + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj4 == null)
				{
					goto IL_032d;
				}
				_ = 0;
				UnityEvent outConplete = ageRestrictionPopup.OutConplete;
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
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								bool flag3 = (nint)((UnityEventBase)outConplete).m_PersistentCalls == listContentElement.id;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
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
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag4 = obj5 != obj6;
			object obj7 = obj8;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				((UIScreen)ageRestrictionPopup).addScreen = (byte)(int)obj9 != 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_032d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj7 = obj10;
			}
			_ = 0;
			object obj11 = ageRestrictionPopup + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			AgeRestrictionPopup ageRestrictionPopup2 = (AgeRestrictionPopup)0;
			if (flag5)
			{
				goto IL_0763;
			}
			goto IL_07af;
			IL_0707:
			_ = 0;
			object obj12 = ageRestrictionPopup + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag6 = (nint)0 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			ageRestrictionPopup2 = (AgeRestrictionPopup)0;
			if (!flag6)
			{
				goto IL_0763;
			}
			goto IL_07af;
			IL_07af:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
			IL_0763:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			break;
			IL_032d:
			object obj13 = ageRestrictionPopup + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3690");
			List<ListContentElement> contentListYear = ageRestrictionPopup.CreateContentListYear();
			_contentListYear = contentListYear;
			bool flag7 = _003C_003Ec._003C_003E9__15_1 == null;
			bool flag8 = !flag7;
			Func<ListContentElement, bool> predicate2 = _003C_003Ec._003C_003E9__15_1;
			if (!flag8)
			{
				throw new ArgumentException();
			}
			ListContentElement listContentElement2 = Enumerable.FirstOrDefault(_contentListYear, predicate2);
			SimpleScrollSnap yearScroll = YearScroll;
			yearScroll.startingPanel = listContentElement2.id;
			object obj14 = ageRestrictionPopup + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			ageRestrictionPopup.InComplete = (UnityEvent)ageRestrictionPopup._selectedFooterButton;
			((UIScreen)ageRestrictionPopup)._footerInited = ((UIScreen)ageRestrictionPopup).addScreen;
			nint cachedPtr2 = (nint)(ageRestrictionPopup + 32);
			((UnityEngine.Object)ageRestrictionPopup).m_CachedPtr = cachedPtr2;
			((UIScreen)ageRestrictionPopup).addScreen = false;
			ageRestrictionPopup._footerPrefab = (GameObject)(nint)((UnityEngine.Object)ageRestrictionPopup).m_CachedPtr;
			while (true)
			{
				_ = 0;
				object obj15 = ageRestrictionPopup + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj16 == null)
					{
						break;
					}
					_ = 0;
					UnityEvent outConplete2 = ageRestrictionPopup.OutConplete;
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
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									bool flag9 = (nint)((UnityEventBase)outConplete2).m_PersistentCalls == listContentElement2.id;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											continue;
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
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag10 = obj17 == obj18;
				bool flag11 = !flag10;
				obj7 = obj19;
				if (!flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					((UIScreen)ageRestrictionPopup).addScreen = (byte)(int)obj20 != 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj7 = obj21;
				}
				goto IL_0707;
			}
			break;
		}
		object obj22 = ageRestrictionPopup + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3690");
		GameObject gameObject3 = MonthScroll.gameObject;
		gameObject3.SetActive(value: true);
		GameObject gameObject4 = YearScroll.gameObject;
		gameObject4.SetActive(value: true);
	}

	public override void Show()
	{
		base.Show();
		CharacterModelPreviewFactory instance = CharacterModelPreviewFactory.Instance;
		throw new ArgumentException();
	}

	private void GetComponent()
	{
		if (UIPopupIn == null)
		{
			UIPopupIn componentInChildren = GetComponentInChildren<UIPopupIn>();
			UIPopupIn = componentInChildren;
		}
	}

	private void ShowPopUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.IN);
	}

	public void HidePupUp()
	{
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.OUT_IMPORTANT);
	}

	public override void Hide()
	{
		base.Hide();
		if (_character != null)
		{
			GameObject obj = _character.gameObject;
			UnityEngine.Object.Destroy(obj);
		}
		ClearElement();
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	public unsafe override void LoseFocus()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(AgeRestrictionPopup._003CLoseFocus_003Eb__22_0));
		IEnumerator routine = Delay(0.1f, action);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator Delay(float second, Action callback = null)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public override void GainFocus()
	{
		GameObject gameObject = _character.gameObject;
		gameObject.SetActive(value: true);
		_character.Freeze = 0f;
	}

	private unsafe void AcceptClicked()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected VT, but got Unknown
		//IL_00d3: Expected native int or pointer, but got VT
		//IL_0024: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		SimpleScrollSnap monthScroll = MonthScroll;
		ListElementHelper listElementHelper = _listViewMonth.get_Item(monthScroll.CurrentPanel__BackingField);
		ListContentElement listContentElement = listElementHelper._listContentElement;
		SimpleScrollSnap yearScroll = YearScroll;
		ListElementHelper listElementHelper2 = _listViewYear.get_Item(yearScroll.CurrentPanel__BackingField);
		ListContentElement listContentElement2 = listElementHelper2._listContentElement;
		_ = 0;
		DateTime dateTime = (DateTime)(obj + 8);
		*(DateTime*)(nint)dateTime = new DateTime(listContentElement2.value, listContentElement.value, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		AgeRestriction.RegisterUserBirthday((DateTime)0);
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups("AgeRestrictionPopup");
	}

	private List<ListContentElement> CreateContentListMonth()
	{
		//IL_006a: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_00fe: Expected Obj, but got I
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		DateTimeFormatInfo instance = DateTimeFormatInfo.GetInstance(invariantCulture);
		List<ListContentElement> list = default;
		list._002Ector(13);
		if (instance != null)
		{
			string[] abbreviatedMonthNames = instance.AbbreviatedMonthNames;
			int num = 1;
			int num2 = 0;
			object obj = 0;
			ListContentElement listContentElement = default;
			while ((nint)obj < abbreviatedMonthNames.Length)
			{
				object obj2 = obj << 2;
				object obj3 = (object)abbreviatedMonthNames + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v29+10]");
				string text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v29+10]");
				object obj4;
				if ((nint)0 != 0)
				{
					obj4 = 0;
					if (text._stringLength != 0)
					{
						goto IL_016e;
					}
				}
				obj4 = 1;
				goto IL_016e;
				IL_016e:
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v29+10]");
					listContentElement.content__BackingField = (string)0;
					listContentElement.id = num2;
					listContentElement.value = num;
					list.Add(listContentElement);
					int num3 = num + 1;
					int num4 = num2 + 1;
					num = num3;
					num2 = num4;
				}
				object obj5 = obj + 1;
				obj = obj5;
			}
		}
		return list;
	}

	private unsafe List<ListContentElement> CreateContentListYear()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
		//IL_0086: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		List<ListContentElement> list = default;
		list._002Ector(66);
		_ = 1950;
		bool flag = true;
		ListContentElement listContentElement = default;
		while (flag)
		{
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			listContentElement.content__BackingField = text;
			listContentElement.id = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			listContentElement.value = 0;
			list.Add(listContentElement);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj3 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			bool flag2 = (nint)0 < (nint)2017;
			flag = flag2;
		}
		return list;
	}

	private unsafe static GameObject PlaceModelUnderAnchor(GameObject model, Transform anchor, int layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0064: Expected I, but got Obj
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected VT, but got Unknown
		//IL_00dc: Expected I, but got Obj
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected VT, but got Unknown
		//IL_0154: Expected I, but got Obj
		//IL_0179: Expected F4, but got I
		//IL_0174: Expected native int or pointer, but got VT
		//IL_0187: Expected F4, but got VT
		//IL_0182: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		NGUITools.SetLayer(model, layer);
		Transform transform = model.transform;
		transform.parent = anchor;
		Transform transform2 = model.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 localPosition = vector + 32;
		transform2.localPosition = localPosition;
		Transform transform3 = model.transform;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v34 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Vector3 localEulerAngles = vector + 16;
		transform3.localEulerAngles = localEulerAngles;
		Transform transform4 = model.transform;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform4.localScale = vector;
		return model;
	}

	private unsafe void PositionModelOnSprite(GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		_ = newRotation.z;
		_ = newRotation.x;
		_ = newScale.x;
		_ = newScale.z;
		Action action = default;
		object obj = default;
		action._002Ector(obj, (nint)__ldftn(_003C_003Ec__DisplayClass29_0._003CPositionModelOnSprite_003Eb__0));
		Timer.ExecuteNextFrame(action);
	}

	public AgeRestrictionPopup()
	{
		List<ListElementHelper> list = default;
		list._002Ector();
		_listViewMonth = list;
		List<ListElementHelper> list2 = default;
		list2._002Ector();
		_listViewYear = list2;
		base._002Ector();
	}

	private void _003COnEnable_003Eb__12_0()
	{
		AcceptClicked();
	}

	private void _003COnEnable_003Eb__12_1()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
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
		object obj7;
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
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj8 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					SimpleScrollSnap monthScroll = MonthScroll;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v65+10]");
					bool flag2 = (nint)0 == monthScroll.CurrentPanel__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj9 == obj10;
			bool flag4 = !flag3;
			object obj11 = obj12;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 != 1;
				obj7 = obj;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj11 = obj13;
			}
			_ = 0;
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj15 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18BA");
	}

	private void _003COnEnable_003Eb__12_2()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
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
		object obj7;
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
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj8 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					SimpleScrollSnap yearScroll = YearScroll;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v65+10]");
					bool flag2 = (nint)0 == yearScroll.CurrentPanel__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj9 == obj10;
			bool flag4 = !flag3;
			object obj11 = obj12;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 != 1;
				obj7 = obj;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj11 = obj13;
			}
			_ = 0;
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj15 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18BA");
	}

	private void _003COnEnable_003Eb__12_3()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Popups.AgeRestrictionPopup>)+EC] (should have been resolved before IL gen)");
	}

	private unsafe void _003CShow_003Eb__16_0(CharacterScreenController csc)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0090: Expected native int or pointer, but got VT
		//IL_00c9: Expected native int or pointer, but got VT
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected VT, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		_character = csc;
		GameObject model = csc.gameObject;
		UIModelController instance = UIModelController.Instance;
		Transform anchor = instance.TutorialPopupAnchor.transform;
		GameObject objectToPosition = PlaceModelUnderAnchor(model, anchor, 31);
		_character.Freeze = 0f;
		_ = 0;
		_ = 1096810496;
		_ = 0;
		((Vector3*)(nint)vector)->z = 14f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		_ = -4385098661083742208L;
		_ = 4710765211326349312L;
		_ = -4385098661083742208L;
		((Vector3*)(nint)vector)->x = 14f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Vector3 positionOffset = vector + 32;
		Vector3 newRotation = vector + 16;
		PositionModelOnSprite(objectToPosition, positionOffset, newRotation, vector);
	}

	private void _003CLoseFocus_003Eb__22_0()
	{
		GameObject gameObject = _character.gameObject;
		gameObject.SetActive(value: false);
	}
}
