using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using UnityEngine;

public class SkipTutorialDebugButton : MonoBehaviour
{
	private sealed class _003CResetTapsOnTimeOut_003Ed__4(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SkipTutorialDebugButton _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected Obj, but got Unknown
				//IL_006b: Expected Obj, but got I4
				SkipTutorialDebugButton skipTutorialDebugButton = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						skipTutorialDebugButton._taps = 0;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 1f;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
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

	private const int NUMBER_OF_CLICKS_TO_OPEN = 2;

	private const int TIME_TO_DOUBLE_CLICK = 1;

	private int _taps;

	private void OnClick()
	{
		CancelInvoke();
	}

	private IEnumerator ResetTapsOnTimeOut()
	{
		//IL_000d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SkipTutorialDebugButton)+28]");
		return (IEnumerator)0;
	}

	public SkipTutorialDebugButton()
	{
		//IL_0159: Expected I, but got Obj
		//IL_016f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00cb: Expected I, but got Obj
		//IL_00e1: Expected Obj, but got I
		//IL_010c: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		int taps = _taps + 1;
		_taps = taps;
		IEnumerator list = ((SlideinPowerupHelper)this).DelayResumeButtonsGlow();
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
		if (_taps != 2)
		{
			return;
		}
		_taps = 0;
		nint num3 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v22 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DebugSettingsPopup.SkipTutorialLevelSegment();
	}
}
