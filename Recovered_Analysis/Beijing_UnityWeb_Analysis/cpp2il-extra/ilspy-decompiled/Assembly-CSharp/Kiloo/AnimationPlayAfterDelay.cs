using System;
using System.Collections;
using System.Collections.Generic;
using AppRefresh;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Serialization;
using UnityEngine;

namespace Kiloo;

public class AnimationPlayAfterDelay : MonoBehaviour
{
	private sealed class _003CPlayAnimationAfterDelay_003Ed__3(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimationPlayAfterDelay _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_005d: Expected Obj, but got Unknown
				//IL_0079: Expected Obj, but got I4
				AnimationPlayAfterDelay animationPlayAfterDelay = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						IEnumerator enumerator = animationPlayAfterDelay._animation.GetEnumerator();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
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

	private BaseTimeDelay _timeDelay;

	private Animation _animation;

	public void OnEnable()
	{
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		Delegate obj = AppRefreshHandler.hasRefreshed;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num = (nint)typeof(AppRefreshHandler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AppRefresh.AppRefreshHandler>)+5C]");
			object obj3 = (nint)0 + (nint)12;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	private IEnumerator PlayAnimationAfterDelay()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	public AnimationPlayAfterDelay()
	{
		//IL_0013: Expected Obj, but got I4
		bool flag = BsonBinaryWriterExtensions.CanBeBsonObject((object)this);
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])flag);
	}
}
