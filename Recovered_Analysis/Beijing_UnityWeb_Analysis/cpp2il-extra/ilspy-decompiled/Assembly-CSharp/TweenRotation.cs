using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UI.Pages;
using UnityEngine;

public class TweenRotation : UITweener
{
	public Vector3 from;

	public Vector3 to;

	public bool quaternionLerp;

	private Transform mTrans;

	public Transform cachedTransform
	{
		get
		{
			//IL_0082: Expected I, but got Obj
			//IL_0098: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mTrans != null)
			{
				object obj2 = this + 116;
				GameObject gameObject = base.gameObject;
				obj2 = gameObject;
			}
			return mTrans;
		}
	}

	public unsafe Quaternion rotation
	{
		get
		{
			//IL_01f7: Expected I, but got Obj
			//IL_020d: Expected Obj, but got I
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Expected Obj, but got Unknown
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Expected VT, but got Unknown
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Expected Obj, but got Unknown
			//IL_0319: Unknown result type (might be due to invalid IL or missing references)
			//IL_031e: Expected Obj, but got Unknown
			//IL_0330: Expected Obj, but got I
			//IL_0063: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01e4: Expected VT, but got Obj
			//IL_01b6: Expected VT, but got Obj
			//IL_00bd: Expected VT, but got Obj
			//IL_00d0: Expected I, but got Obj
			//IL_00e6: Expected Obj, but got I
			//IL_0237: Expected F4, but got Obj
			//IL_0232: Expected native int or pointer, but got VT
			//IL_024c: Expected F4, but got I
			//IL_0247: Expected native int or pointer, but got VT
			//IL_0273: Expected VT, but got Obj
			//IL_02af: Expected F4, but got Obj
			//IL_02aa: Expected native int or pointer, but got VT
			//IL_02be: Expected F4, but got I
			//IL_02b9: Expected native int or pointer, but got VT
			//IL_02d0: Expected F4, but got Obj
			//IL_02dc: Expected VT, but got Obj
			//IL_0111: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v64 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			Transform transform = (Transform)(obj2 + 48);
			Vector3 vector = (Vector3)(obj2 + 36);
			object obj3 = obj2 + 24;
			Transform transform2 = (Transform)(obj2 + 12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L0 (TweenRotation)+78]");
			TweenRotation tweenRotation = default;
			if ((UnityEngine.Object)0 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L0 (TweenRotation)+78]");
				UIDrawCall.OnRenderCallback onRender = ((UIWidget)0).onRender;
				if (onRender != null && !tweenRotation.quaternionLerp)
				{
					obj3 = this;
					_ = ((UnityEngine.Object)this).m_CachedPtr;
					Transform transform3 = tweenRotation.cachedTransform;
					transform2.localPosition = (Vector3)transform3;
					nint num3 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v47 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v60 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = (float)obj3;
					Vector3 vector2 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
					((Vector3*)(nint)vector2)->z = 0f;
					transform = transform2;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					Quaternion quaternion = Quaternion.FromToRotation(vector, (Vector3)transform);
					TweenRotation tweenRotation2 = (TweenRotation)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
					transform = (Transform)(object)this;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
					((Vector3*)(nint)vector)->x = (float)this;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)this).m_CachedPtr;
					Color color = UIColorPicker.Sample((float)transform, vector.y);
					return (Quaternion)tweenRotation;
				}
			}
			bool flag = tweenRotation.quaternionLerp;
			Transform transform4 = tweenRotation.cachedTransform;
			if (flag)
			{
				transform = (Transform)(object)this;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
				Vector3 localPosition = transform.localPosition;
				return (Quaternion)transform4;
			}
			transform = (Transform)(object)this;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
			Vector3 eulerAngles = transform.eulerAngles;
			return (Quaternion)transform4;
		}
		set
		{
			this.value = value;
		}
	}

	public Quaternion value
	{
		get
		{
			((UnityEngine.Object)this).m_CachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
			Vector3 vector = ((TweenScale)this).value;
			Quaternion result = default;
			return result;
		}
		set
		{
			//IL_0009: Expected Obj, but got VT
			//IL_0017: Expected VT, but got Obj
			Transform transform = ((TweenScale)value).cachedTransform;
			((Transform)(object)this).localRotation = (Quaternion)transform;
		}
	}

	protected unsafe override void OnUpdate(float factor, bool isFinished)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected VT, but got Unknown
		//IL_012f: Expected F4, but got Obj
		//IL_012a: Expected native int or pointer, but got VT
		//IL_0144: Expected F4, but got I
		//IL_013f: Expected native int or pointer, but got VT
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_01ae: Expected F4, but got Obj
		//IL_01a9: Expected native int or pointer, but got VT
		//IL_01c3: Expected F4, but got I
		//IL_01be: Expected native int or pointer, but got VT
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected VT, but got Unknown
		//IL_01fd: Expected F4, but got Obj
		//IL_01f8: Expected native int or pointer, but got VT
		//IL_0212: Expected F4, but got I
		//IL_020d: Expected native int or pointer, but got VT
		//IL_021f: Expected F4, but got Obj
		//IL_021a: Expected native int or pointer, but got VT
		//IL_0234: Expected F4, but got I
		//IL_022f: Expected native int or pointer, but got VT
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_007d: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = this + 88;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 60;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Vector3 vector = (Vector3)(obj2 + 84);
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v17+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj6 = obj2 + 36;
		float num3 = 1f - factor;
		Vector3 vector2 = vector / num3;
		object obj7 = obj2 + 24;
		object obj8 = this + 100;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v24+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v25+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj9 = obj2 + 12;
		Vector3 vector3 = vector / factor;
		Vector3 vector4 = (Vector3)(obj2 + 72);
		((Vector3*)(nint)vector4)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v23+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v30+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector5 = vector4 - vector;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion quaternion = ((TweenRotation)vector).rotation;
	}

	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
		//IL_004f: Expected VT, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got F4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_0018: Expected Obj, but got I4
		TweenPosition tweenPosition = UITweener.Begin<TweenPosition>(go, duration);
		TweenPosition tweenPosition2 = default;
		tweenPosition2.value = (Vector3)tweenPosition;
		object obj = tweenPosition2 + 12;
		obj = tweenPosition2;
		_ = ((UnityEngine.Object)tweenPosition2).m_CachedPtr;
		object obj2 = tweenPosition + 88;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v10+8]");
		_ = 0;
		obj = rot.x;
		_ = rot.z;
		object obj3 = tweenPosition + 100;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v10+8]");
		_ = 0;
		if (!(duration > 0f))
		{
			((PageTop)(object)tweenPosition).Delay(1f, (Action)1);
			tweenPosition.tag = null;
		}
		return (TweenRotation)(object)tweenPosition;
	}

	public override void SetStartToCurrentValue()
	{
		((UI2DSprite)(object)this).OnUpdate();
	}

	public override void SetEndToCurrentValue()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0035: Expected VT, but got Obj
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		_ = 0;
		TweenRotation tweenRotation = (TweenRotation)(obj2 + 16);
		tweenRotation.value = (Quaternion)this;
		obj = tweenRotation;
		_ = ((UnityEngine.Object)tweenRotation).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
		object obj3 = obj2 + 48;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 88;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13+8]");
		_ = 0;
	}

	private void SetCurrentValueToStart()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0035: Expected VT, but got Obj
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		_ = 0;
		TweenRotation tweenRotation = (TweenRotation)(obj2 + 16);
		tweenRotation.value = (Quaternion)this;
		obj = tweenRotation;
		_ = ((UnityEngine.Object)tweenRotation).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
		object obj3 = obj2 + 48;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 100;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13+8]");
		_ = 0;
	}

	private unsafe void SetCurrentValueToEnd()
	{
		//IL_0060: Expected Obj, but got Ref
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_00fe: Expected Ref, but got VT
		//IL_0114: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		ref Quaternion reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		object obj2 = this + 88;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
		_ = 0;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v12 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v24 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Quaternion reference2 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 32);
		reference2 = ref *(Quaternion*)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference, out reference2);
		reference2 = ref *(Quaternion*)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		Vector3 vector = ((TweenScale)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).value;
	}

	public unsafe TweenRotation()
	{
		//IL_0060: Expected Obj, but got Ref
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_00fe: Expected Ref, but got VT
		//IL_0114: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		ref Quaternion reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		object obj2 = this + 100;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
		_ = 0;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v12 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v24 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Quaternion reference2 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 32);
		reference2 = ref *(Quaternion*)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference, out reference2);
		reference2 = ref *(Quaternion*)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		Vector3 vector = ((TweenScale)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).value;
	}
}
