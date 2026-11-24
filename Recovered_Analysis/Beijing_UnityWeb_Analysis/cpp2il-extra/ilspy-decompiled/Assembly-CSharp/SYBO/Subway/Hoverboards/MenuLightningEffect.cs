using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Subway.Coins;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace SYBO.Subway.Hoverboards;

public class MenuLightningEffect : MonoBehaviour
{
	private sealed class _003CDelayedDisable_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public MenuLightningEffect _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Expected Obj, but got Unknown
				//IL_006f: Expected Obj, but got I4
				//IL_0088: Expected Obj, but got I4
				//IL_009b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a0: Expected Obj, but got Unknown
				//IL_00c9: Expected I, but got Obj
				//IL_00df: Expected Obj, but got I
				//IL_018f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0194: Expected Obj, but got Unknown
				//IL_010a: Expected I, but got Obj
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_015c: Expected Obj, but got Unknown
				MenuLightningEffect menuLightningEffect = _003C_003E4__this;
				object result;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						object obj = 0;
						while (true)
						{
							GameObject[] children = menuLightningEffect._children;
							bool flag = (nint)obj >= children.Length;
							result = null;
							if (flag)
							{
								break;
							}
							object obj2 = menuLightningEffect._children + 16;
							object obj3 = obj << 2;
							object obj4 = obj2 + obj3;
							nint num = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj5 = (nint)0 & (nint)0x200;
							if (obj5 != null)
							{
								nint num2 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)obj4).FindKernel((string)null) != 0)
							{
								object obj6 = menuLightningEffect._children + 16;
								object obj7 = obj << 2;
								object obj8 = obj6 + obj7;
								((GameObject)obj8).tag = null;
							}
							object obj9 = obj + 1;
							obj = obj9;
						}
					}
					else
					{
						result = null;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = menuLightningEffect._duration;
					object obj10 = this + 12;
					object obj11 = default;
					obj10 = obj11;
					_003C_003E1__state = 1;
					result = 1;
				}
				return result;
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

	private float _duration;

	private float _minDelay;

	private float _maxDelay;

	private float _currentDelay;

	private GameObject[] _children;

	private void Awake()
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		_duration = 0.3f;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v23 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 back = Vector3.back;
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 16;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		CancelInvoke();
	}

	private void Update()
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got I4
		GameObject gameObject = base.gameObject;
		int siblingIndex = ((Transform)(object)gameObject).GetSiblingIndex();
		object obj = this + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		Sprite sprite = null;
		GameObject[] children = _children;
		if ((nint)sprite < children.Length)
		{
			GameObject gameObject2 = base.gameObject;
			bool flag = ((SpriteAtlas)(object)gameObject2).CanBindTo(sprite);
			string text = ((Component)flag).tag;
			throw new ArrayTypeMismatchException();
		}
	}

	private IEnumerator DelayedDisable()
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

	public MenuLightningEffect()
	{
		//IL_0134: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		if (!(_currentDelay > 0f))
		{
			float currentDelay = ScrollRect.RubberDelta(_minDelay, _maxDelay);
			_currentDelay = currentDelay;
			return;
		}
		float unscaledTime = Time.unscaledTime;
		float currentDelay2 = _currentDelay - unscaledTime;
		_currentDelay = currentDelay2;
		if (_currentDelay > 0f)
		{
			return;
		}
		object obj = default;
		object obj4 = default;
		while (true)
		{
			GameObject[] children = _children;
			if ((nint)obj >= children.Length)
			{
				break;
			}
			object obj2 = _children + 16;
			object obj3 = obj4 << 2;
			object obj5 = obj2 + obj3;
			((GameObject)obj5).tag = (string)1;
			obj = obj4 + 1;
		}
		bool isOnTopLevel = ((CoinCurve)this).IsOnTopLevel;
		CoroutineUtil.StopCoroutine((Coroutine)isOnTopLevel);
		bool isOnTopLevel2 = ((CoinCurve)this).IsOnTopLevel;
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])isOnTopLevel2);
	}
}
