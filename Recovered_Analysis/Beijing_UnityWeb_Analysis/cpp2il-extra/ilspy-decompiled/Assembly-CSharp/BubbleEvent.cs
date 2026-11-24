using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class BubbleEvent : CharacterCustomizationProp
{
	private sealed class _003CBlowBubbles_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BubbleEvent _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0051: Expected F4, but got I
				//IL_0051: Expected F4, but got I
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Expected Obj, but got Unknown
				//IL_0090: Expected Obj, but got I4
				//IL_00b1: Expected Obj, but got I
				BubbleEvent bubbleEvent = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (BubbleEvent)+C]");
						IEnumerator enumerator = ((Animation)0).GetEnumerator();
						IEnumerator routine = ((FanFoldOut)(object)bubbleEvent).Play();
						Coroutine coroutine = bubbleEvent.StartCoroutine_Auto(routine);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (BubbleEvent)+14]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (BubbleEvent)+10]");
				float num2 = ScrollRect.RubberDelta((float)num, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CBlowBubbles_003Ed__4(int _003C_003E1__state)
		{
			if (this._003C_003E1__state != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
			}
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00f6: Expected Obj, but got I
			//IL_00ff: Expected Obj, but got I4
			//IL_00c2: Expected I4, but got Obj
			//IL_001b: Expected Obj, but got I
			//IL_0054: Expected Obj, but got I
			//IL_0064: Expected Obj, but got I
			//IL_0074: Expected Obj, but got I
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected Obj, but got Unknown
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected Obj, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list = default;
			list._002Ector((IEnumerable<string>)_003C_003E4__this);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BubbleEvent+<BlowBubbles>d__4)+14]");
			object obj = (nint)0 + (nint)12;
			object obj2 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BubbleEvent+<BlowBubbles>d__4)+14]");
				object obj3 = (nint)0 + (nint)16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				object obj6 = obj5;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S3_v6 (Il2CppMethodInfo)+C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S3_v7+60]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S3_v8+38]");
				object obj9 = 0;
				object obj10 = obj9 & 0x1FFF;
				object obj11 = obj10 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S4_v6 (should have been resolved before IL gen)");
				object obj12 = obj2 + 1;
				obj2 = obj12;
			}
			return (byte)(int)list.ToArray() != 0;
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

	private Animation _animation;

	private float randomMax;

	private float randomMin;

	public override void Initialize(CharacterRig characterRig, bool alternateSetup)
	{
	}

	private IEnumerator BlowBubbles()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BubbleEvent)+24]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+C]");
		return (IEnumerator)0;
	}

	public BubbleEvent()
	{
		CancelInvoke();
	}
}
