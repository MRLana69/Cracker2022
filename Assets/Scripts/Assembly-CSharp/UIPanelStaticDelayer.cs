using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
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
					goto IL_00d1;
				}
				_003C_003E1__state = -1;
				num = _003Cnum_003E5__2;
			}
			else
			{
				_003Cnum_003E5__2 = 0;
				_003C_003E1__state = -1;
				num = 0;
			}
			UIPanel uIPanel = panel;
			if (num >= delayFrames)
			{
				uIPanel.widgetsAreStatic = true;
				goto IL_00d1;
			}
			panel.Refresh();
			int num2 = _003Cnum_003E5__2 + 1;
			_003C_003E2__current = null;
			_003Cnum_003E5__2 = num2;
			_003C_003E1__state = 1;
			return true;
			IL_00d1:
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

	private bool inited;

	private int framesToWait = 2;

	private bool refreshOnEnable;

	private UIPanel _panel;

	private void Awake()
	{
		UIPanel component = GetComponent<UIPanel>();
		_panel = component;
		if (_panel != null && framesToWait >= 0)
		{
			OrderStaticDelay();
			inited = true;
		}
	}

	private void OrderStaticDelay()
	{
		UIPanel panel = _panel;
		if (~(panel.widgetsAreStatic ? 1u : 0u) == 0)
		{
			panel.widgetsAreStatic = false;
		}
		IEnumerator routine = SetStaticDelayed(framesToWait, panel);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private void OnEnable()
	{
		if (~(refreshOnEnable ? 1u : 0u) == 0 && ~(inited ? 1u : 0u) == 0)
		{
			OrderStaticDelay();
		}
	}

	public IEnumerator SetStaticDelayed(int delayFrames, UIPanel panel)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
