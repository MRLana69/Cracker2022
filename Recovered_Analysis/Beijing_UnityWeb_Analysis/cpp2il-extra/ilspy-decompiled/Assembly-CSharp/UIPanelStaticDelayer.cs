using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class UIPanelStaticDelayer : MonoBehaviour
{
	private sealed class _003CSetStaticDelayed_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPanel panel;

		public int delayFrames;

		private int _003Cnum_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00db: Expected Obj, but got Unknown
				//IL_00e4: Expected Obj, but got I4
				//IL_00f8: Expected Obj, but got I4
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
					_003Cnum_003E5__2 = 0;
				}
				UIPanel uIPanel = panel;
				if (_003Cnum_003E5__2 < delayFrames)
				{
					uIPanel._002Ector();
					int num = _003Cnum_003E5__2 + 1;
					_003Cnum_003E5__2 = num;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				uIPanel.widgetsAreStatic = true;
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

	private bool inited;

	private int framesToWait;

	private bool refreshOnEnable;

	private UIPanel _panel;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_001d: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got F4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got F4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f9: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got F4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got F4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		_ = 1;
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		obj = -60f;
		_ = 0f;
		_ = 0f;
		object obj3 = obj2 + 48;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+8]");
		_ = 0;
		object obj4 = this + 96;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+8]");
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = 0;
		_ = 0;
		obj5 = 0f;
		_ = 0f;
		_ = 180f;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
		_ = 0;
		object obj6 = this + 108;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+8]");
		_ = 0;
		object obj7 = obj2 + 12;
		obj7 = 0;
		_ = 0;
		obj7 = -60f;
		_ = -150f;
		_ = -100f;
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v29+8]");
		_ = 0;
		object obj8 = this + 136;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 382f;
		_ = -125f;
		_ = 750f;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj9 = this + 148;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+8]");
		_ = 0;
		CancelInvoke();
	}

	private void OrderStaticDelay()
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00bd: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj = this + 24;
		UIPanel component = GetComponent<UIPanel>();
		obj = component;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(_panel != null) && framesToWait > -1)
		{
			OnEnable();
			inited = true;
		}
	}

	private void OnEnable()
	{
		//IL_0055: Expected Obj, but got I4
		UIPanel panel = _panel;
		if (~(panel.widgetsAreStatic ? 1u : 0u) == 0)
		{
			UIPanel panel2 = _panel;
			panel2.widgetsAreStatic = false;
		}
		UIScreen routine = ((UIScreenController)null)._LoadScreenToCache((string)framesToWait, (GameObject)(object)_panel);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)routine);
	}

	public IEnumerator SetStaticDelayed(int delayFrames, UIPanel panel)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_03bf: Expected Obj, but got I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got Unknown
		//IL_03e2: Expected Obj, but got I4
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01e5: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I
		//IL_0064: Expected I, but got Obj
		//IL_007a: Expected Obj, but got I
		//IL_04ef: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_00a5: Expected I, but got Obj
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v105 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v131 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if ((nint)obj9 == delayFrames)
					{
						object obj10 = obj5 + 4;
						object obj11 = obj10 + 1;
						obj10 = obj11;
						object obj12 = obj11 << 2;
						object obj13 = obj5 + obj12;
						obj13 = 83;
						break;
					}
				}
				continue;
			}
			object obj14 = obj5 + 4;
			object obj15 = obj14 + 1;
			obj14 = obj15;
			object obj16 = obj15 << 2;
			object obj17 = obj5 + obj16;
			obj17 = 81;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj18 = (nint)0 << 2;
			object obj19 = obj5 + obj18;
			if ((nint)obj19 == 83)
			{
				object obj20 = obj5 + 4;
				if ((nint)obj20 > -1)
				{
					object obj21 = obj20 + -1;
					obj20 = obj21;
				}
				goto IL_04e9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj22 = (nint)0 << 2;
			object obj23 = obj5 + obj22;
			if ((nint)obj23 == 81)
			{
				object obj24 = obj5 + 4;
				if ((nint)obj24 > -1)
				{
					object obj25 = obj24 + -1;
					obj24 = obj25;
				}
				goto IL_04e9;
			}
		}
		object obj26 = default;
		if (obj26 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_04e9;
		IL_04e9:
		return (IEnumerator)1;
	}

	public UIPanelStaticDelayer()
	{
		if (~(refreshOnEnable ? 1u : 0u) == 0 && ~(inited ? 1u : 0u) == 0)
		{
			OnEnable();
		}
	}
}
