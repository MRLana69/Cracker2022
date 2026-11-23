using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class SSEventsLabelTimer : MonoBehaviour
{
	private sealed class _003CChangeEventBtnLabelText_003Ed__5(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SSEventsLabelTimer _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0054: Expected Obj, but got I
			//IL_00d2: Expected F8, but got I8
			//IL_00ac: Expected Obj, but got I
			//IL_0156: Expected F8, but got I4
			//IL_0169: Expected F8, but got I4
			//IL_0452: Invalid comparison between F8 and I4
			//IL_026b: Invalid comparison between F8 and I4
			//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0304: Expected Obj, but got Unknown
			//IL_0177: Invalid comparison between F8 and I4
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected Obj, but got Unknown
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected Obj, but got Unknown
			//IL_0350: Expected Obj, but got I
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Expected Obj, but got Unknown
			//IL_02ec: Expected Obj, but got I
			//IL_025d: Expected Obj, but got I
			//IL_01f8: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			SSEventsLabelTimer sSEventsLabelTimer = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					IEnumerator routine = sSEventsLabelTimer.ChangeEventBtnLabelText();
					Coroutine coroutine = sSEventsLabelTimer.StartCoroutine(routine);
				}
				goto IL_03aa;
			}
			_003C_003E1__state = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SSEventsLabelTimer)+10]");
			if ((UnityEngine.Object)0 == null)
			{
				GameObject gameObject = sSEventsLabelTimer.gameObject;
				UILabel component = gameObject.GetComponent<UILabel>();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SSEventsLabelTimer)+10]");
				if ((UnityEngine.Object)0 == null)
				{
					goto IL_00c9;
				}
			}
			SSEventsManagerController instance = SSEventsManagerController.instance;
			long num = instance.TimeLeftInSeconds();
			goto IL_00c9;
			IL_00c9:
			TimeSpan timeSpan = TimeSpan.FromSeconds(num);
			string format = Strings.Get(StringID.EVENTS_POPUP_BTN_TIMELEFT);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num2 = 0.0 * 2.7777777777777777E-11;
			double num3 = Math.Abs(num2);
			if (!(num3 < 2147483648.0))
			{
				num2 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num4 = 0.0 * 1.6666666666666667E-09;
			double num5 = Math.Abs(num4);
			if (!(num5 < 2147483648.0))
			{
				num4 = -2147483648.0;
			}
			if (!(num2 < 1.0))
			{
				if (num2 != 1.0)
				{
					object obj3 = obj + 4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					string arg = Strings.Get(StringID.HOUR_ABREVIATED_PLURAL);
					object arg2 = default;
					string text = string.Format(format, arg2, arg);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SSEventsLabelTimer)+10]");
					((UILabel)0).text = text;
				}
				else
				{
					_ = 1;
					object obj4 = obj + 4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					string arg3 = Strings.Get(StringID.HOUR_ABREVIATED_SINGULAR);
					object arg4 = default;
					string text2 = string.Format(format, arg4, arg3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SSEventsLabelTimer)+10]");
					((UILabel)0).text = text2;
				}
			}
			else if (!(num4 < 2.0))
			{
				object obj5 = obj + 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				string arg5 = Strings.Get(StringID.MINUTE_ABREVIATED_PLURAL);
				object arg6 = default;
				string text3 = string.Format(format, arg6, arg5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SSEventsLabelTimer)+10]");
				((UILabel)0).text = text3;
			}
			else
			{
				object obj6 = obj + 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				string arg7 = Strings.Get(StringID.MINUTE_ABREVIATED_SINGULAR);
				object arg8 = default;
				string text4 = string.Format(format, arg8, arg7);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SSEventsLabelTimer)+10]");
				((UILabel)0).text = text4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SSEventsLabelTimer)+C]");
			_ = 0;
			object obj7 = default;
			_003C_003E2__current = obj7;
			_003C_003E1__state = 1;
			goto IL_03aa;
			IL_03aa:
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

	private float _timespanToRefreshTimeLabel;

	private UILabel _thisLabel;

	private void Awake()
	{
		Coroutine coroutine = StartCoroutine("ChangeEventBtnLabelText");
	}

	private void OnDisable()
	{
		StopCoroutine("ChangeEventBtnLabelText");
	}

	private void OnEnable()
	{
		Coroutine coroutine = StartCoroutine("ChangeEventBtnLabelText");
	}

	private IEnumerator ChangeEventBtnLabelText()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
