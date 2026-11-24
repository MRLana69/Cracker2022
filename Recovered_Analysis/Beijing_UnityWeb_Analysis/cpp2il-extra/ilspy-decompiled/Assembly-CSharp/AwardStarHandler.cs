using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class AwardStarHandler : MonoBehaviour
{
	private sealed class _003CAnimateStar_003Ed__5(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AwardStarHandler _003C_003E4__this;

		public Animation starAnimation;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Expected Obj, but got Unknown
				//IL_00a9: Expected Obj, but got I4
				//IL_012d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0132: Expected Obj, but got Unknown
				//IL_014e: Expected Obj, but got I4
				AwardStarHandler awardStarHandler = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1 && _003C_003E1__state != 2)
					{
						return null;
					}
					_003C_003E1__state = -1;
					if (~(awardStarHandler.animeStars ? 1u : 0u) == 0)
					{
						IEnumerator enumerator = starAnimation.GetEnumerator();
						float num = ScrollRect.RubberDelta(awardStarHandler.minSecondsToNextAnim, awardStarHandler.maxSecondsToNextAnim);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj = this + 12;
						object obj2 = default;
						obj = obj2;
						_003C_003E1__state = 2;
						return 1;
					}
					return null;
				}
				_003C_003E1__state = -1;
				float num2 = ScrollRect.RubberDelta(awardStarHandler.minSecondsToNextAnim, awardStarHandler.maxSecondsToNextAnim);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj3 = this + 12;
				object obj4 = default;
				obj3 = obj4;
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

	private Animation[] _stars;

	private float minSecondsToNextAnim;

	private float maxSecondsToNextAnim;

	public bool animeStars;

	public void ActivateStars()
	{
		CancelInvoke();
	}

	private IEnumerator AnimateStar(Animation starAnimation)
	{
		if ((object)starAnimation != null)
		{
			return (IEnumerator)(object)"icon_award_bg_completed";
		}
		return (IEnumerator)(object)"icon_award_bg_completed_small";
	}

	public AwardStarHandler()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0053: Expected I4, but got Obj
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		object obj = _stars + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _stars + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			string formattedAmount = ((BundlePurchaseButton)this).GetFormattedAmount((int)obj5);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)formattedAmount);
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
	}
}
