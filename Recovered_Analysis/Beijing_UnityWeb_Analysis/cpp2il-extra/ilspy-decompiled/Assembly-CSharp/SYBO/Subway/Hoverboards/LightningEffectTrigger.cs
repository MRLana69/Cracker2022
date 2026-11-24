using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Subway.Characters;
using UnityEngine;
using UnityEngine.U2D;

namespace SYBO.Subway.Hoverboards;

public class LightningEffectTrigger : MonoBehaviour
{
	private sealed class _003CDelayedDisable_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LightningEffectTrigger _003C_003E4__this;

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
				LightningEffectTrigger lightningEffectTrigger = _003C_003E4__this;
				object result;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						object obj = 0;
						while (true)
						{
							GameObject[] children = lightningEffectTrigger._children;
							bool flag = (nint)obj >= children.Length;
							result = null;
							if (flag)
							{
								break;
							}
							object obj2 = lightningEffectTrigger._children + 16;
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
								object obj6 = lightningEffectTrigger._children + 16;
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
					_ = lightningEffectTrigger._duration;
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

		public _003CDelayedDisable_003Ed__8(int _003C_003E1__state)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			this._003C_003E1__state = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return (byte)_003C_003E1__state != 0;
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

	private const float InAirThreshold = 0.1f;

	private float _duration;

	private Vector3 _direction;

	private CharacterController _characterController;

	private float _inAirTime;

	private GameObject[] _children;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
		//IL_0143: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I4
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 28;
		CharacterRendering instance = CharacterRendering.Instance;
		obj2 = instance._caughtAnimationState;
		GameObject gameObject = base.gameObject;
		int siblingIndex = ((Transform)(object)gameObject).GetSiblingIndex();
		object obj3 = this + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 36;
		object obj3 = this + 8;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object obj5 = obj2 + 12;
		object obj6 = this + 20;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v17+8]");
		_ = 0;
		obj2 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format = default;
		object arg = default;
		return (IEnumerator)(object)string.Format((IFormatProvider)(object)"[Swipe (start:{0}, end:{1}]", format, arg);
	}

	public unsafe LightningEffectTrigger()
	{
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected VT, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_0272: Expected F4, but got Obj
		//IL_026d: Expected native int or pointer, but got VT
		//IL_0287: Expected F4, but got I
		//IL_0282: Expected native int or pointer, but got VT
		//IL_0294: Expected Ref, but got VT
		//IL_02a1: Expected native int or pointer, but got VT
		//IL_02b3: Expected native int or pointer, but got VT
		//IL_02c1: Expected Obj, but got VT
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0183: Expected I, but got Obj
		string text = ((PhysicsScene*)_characterController)->ToString();
		bool flag = !(_inAirTime < 0.1f);
		object obj = text & flag;
		if (obj != null)
		{
			object obj2 = default;
			object obj5 = default;
			while (true)
			{
				GameObject[] children = _children;
				if ((nint)obj2 >= children.Length)
				{
					break;
				}
				object obj3 = _children + 16;
				object obj4 = obj5 << 2;
				object obj6 = obj3 + obj4;
				((GameObject)obj6).tag = (string)1;
				obj2 = obj5 + 1;
			}
			IEnumerator coroutine = ((MenuLightningEffect)this).DelayedDisable();
			CoroutineUtil.StopCoroutine((Coroutine)(object)coroutine);
			IEnumerator list = ((MenuLightningEffect)this).DelayedDisable();
			Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
		}
		Quaternion quaternion = default;
		Vector3 vector = (Vector3)(quaternion + 32);
		object obj7 = quaternion + 16;
		object obj8 = _children + 16;
		if (((GameObject)obj8).activeInHierarchy)
		{
			GameObject gameObject = base.gameObject;
			object obj9 = this + 16;
			obj7 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S2_v8+8]");
			_ = 0;
			nint num = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v22 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num2 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v32 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v16+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((Quaternion*)quaternion)->SetLookRotation(vector);
			((Vector3*)(nint)vector)->x = quaternion.x;
			((Vector3*)(nint)vector)->z = quaternion.z;
			Quaternion localRotation = ((Transform)vector).localRotation;
		}
		if (text != null)
		{
			_inAirTime = 0f;
			return;
		}
		float unscaledTime = Time.unscaledTime;
		float inAirTime = _inAirTime + unscaledTime;
		_inAirTime = inAirTime;
	}
}
