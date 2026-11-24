using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UI.Pages;
using UnityEngine;

public class TweenScale : UITweener
{
	public Vector3 from;

	public Vector3 to;

	public bool updateTable;

	private Transform mTrans;

	private UITable mTable;

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

	public Vector3 value
	{
		get
		{
			//IL_0009: Expected Obj, but got VT
			Vector3 vector = default;
			Transform transform = ((TweenScale)vector).cachedTransform;
			((UnityEngine.Object)this).m_CachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
			Vector3 localScale = ((Transform)(object)this).localScale;
			return vector;
		}
		set
		{
			//IL_0009: Expected Obj, but got VT
			//IL_0017: Expected VT, but got Obj
			AudioSource audioSource = ((TweenVolume)value).audioSource;
			((Transform)(object)this).localScale = (Vector3)audioSource;
		}
	}

	public Vector3 scale
	{
		get
		{
			//IL_0009: Expected Obj, but got VT
			Vector3 vector = default;
			AudioSource audioSource = ((TweenVolume)vector).audioSource;
			((UnityEngine.Object)this).m_CachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
			((Transform)(object)audioSource).parent = (Transform)(object)this;
			return vector;
		}
		set
		{
			this.value = value;
		}
	}

	protected unsafe override void OnUpdate(float factor, bool isFinished)
	{
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Ref, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected VT, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Ref, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Ref, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Ref, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02ad: Expected Obj, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_03c4: Expected F4, but got Obj
		//IL_03c4: Expected F4, but got Obj
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03ff: Expected F4, but got I
		//IL_03ff: Expected F4, but got I
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_043a: Expected F4, but got I
		//IL_043a: Expected F4, but got I
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0033: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I
		//IL_017a: Expected native int or pointer, but got VT
		//IL_0188: Expected native int or pointer, but got VT
		//IL_0195: Expected native int or pointer, but got VT
		//IL_01a2: Expected native int or pointer, but got VT
		//IL_01af: Expected native int or pointer, but got VT
		//IL_01c2: Expected I, but got Obj
		//IL_01d8: Expected Obj, but got I
		//IL_0132: Expected I, but got Obj
		//IL_02d9: Expected Ref, but got VT
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0347: Expected F4, but got VT
		//IL_0342: Expected native int or pointer, but got VT
		//IL_035c: Expected F4, but got I
		//IL_0357: Expected native int or pointer, but got VT
		//IL_0369: Expected Ref, but got VT
		//IL_0387: Expected VT, but got Ref
		//IL_0450: Expected Ref, but got F4
		//IL_0474: Expected Obj, but got VT
		//IL_0074: Expected I, but got Obj
		//IL_03ae: Expected Obj, but got Ref
		//IL_0203: Expected I, but got Obj
		object obj = default;
		ref Quaternion reference = ref *(Quaternion*)(obj + 112);
		Quaternion quaternion = (Quaternion)(obj + 96);
		ref Quaternion reference2 = ref *(Quaternion*)(obj - -64);
		ref Quaternion reference3 = ref *(Quaternion*)(obj + 48);
		object obj2 = obj + 32;
		ref Quaternion reference4 = ref *(Quaternion*)(obj + 16);
		object obj3 = obj + 80;
		obj3 = 0;
		_ = 0;
		if (~(updateTable ? 1u : 0u) == 0)
		{
			object obj4 = this + 88;
			reference2 = ref *(Quaternion*)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v46+8]");
			_ = 0;
			nint num = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v64 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v83 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			reference = ref *(Quaternion*)reference2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
			_ = 0;
			Quaternion.Inverse_Injected(ref reference3, out reference);
			object obj6 = this + 100;
			obj2 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v57+8]");
			_ = 0;
			reference = ref *(Quaternion*)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			_ = 0;
			Quaternion.Inverse_Injected(ref reference4, out reference);
			((Quaternion*)(nint)quaternion)->x = (float)reference3;
			Quaternion quaternion2 = quaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Quaternion&)+8]");
			((Quaternion*)(nint)quaternion2)->z = 0f;
			reference = ref *(Quaternion*)reference4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UnityEngine.Quaternion&)+8]");
			_ = 0;
			Quaternion quaternion3 = Quaternion.SlerpUnclamped(quaternion, (Quaternion)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), factor);
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
		else
		{
			object obj7 = this + 88;
			object obj8 = this + 100;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S2_v5 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S2_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float x = Mathf.LerpUnclamped((float)obj7, (float)obj8, factor);
			object obj10 = this + 88;
			object obj11 = this + 100;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v35+4]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v24+4]");
			float y = Mathf.LerpUnclamped(num5, 0f, factor);
			object obj12 = this + 88;
			object obj13 = this + 100;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v39+8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v28+8]");
			float z = Mathf.LerpUnclamped(num6, 0f, factor);
			((Quaternion*)(nint)quaternion)->x = 0f;
			((Quaternion*)(nint)quaternion)->z = 0f;
			((Quaternion*)(nint)quaternion)->x = x;
			((Quaternion*)(nint)quaternion)->y = y;
			((Quaternion*)(nint)quaternion)->z = z;
			nint num7 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v48 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num8 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v57 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			reference = ref *(Quaternion*)quaternion.x;
			_ = quaternion.z;
			Quaternion.Inverse_Injected(ref reference2, out reference);
			obj3 = reference2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Quaternion&)+8]");
			_ = 0;
		}
		reference = ref *(Quaternion*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
		_ = 0;
		Vector3 vector = ((TweenScale)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).value;
	}

	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_012d: Expected VT, but got Obj
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 40;
		obj = 0;
		_ = 0;
		TweenRotation tweenRotation = (TweenRotation)(obj2 + 24);
		TweenRotation tweenRotation2 = UITweener.Begin<TweenRotation>(go, duration);
		tweenRotation.value = (Quaternion)tweenRotation2;
		obj = tweenRotation;
		_ = ((UnityEngine.Object)tweenRotation).m_CachedPtr;
		object obj3 = obj2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
		object obj4 = obj2 + 56;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v16+8]");
		_ = 0;
		object obj5 = tweenRotation2 + 88;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v18+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = tweenRotation2 + 100;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v18+8]");
		_ = 0;
		if (!(duration > 0f))
		{
			((PageTop)(object)tweenRotation2).Delay(1f, (Action)1);
			tweenRotation2.tag = null;
		}
		return (TweenScale)(object)tweenRotation2;
	}

	public override void SetStartToCurrentValue()
	{
		((UI2DSprite)(object)this).OnUpdate();
	}

	public override void SetEndToCurrentValue()
	{
		//IL_000a: Expected VT, but got Obj
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		TweenScale tweenScale = default;
		tweenScale.value = (Vector3)this;
		object obj = tweenScale + 12;
		obj = tweenScale;
		_ = ((UnityEngine.Object)tweenScale).m_CachedPtr;
		object obj2 = this + 88;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+8]");
		_ = 0;
	}

	private void SetCurrentValueToStart()
	{
		//IL_000a: Expected VT, but got Obj
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		TweenScale tweenScale = default;
		tweenScale.value = (Vector3)this;
		object obj = tweenScale + 12;
		obj = tweenScale;
		_ = ((UnityEngine.Object)tweenScale).m_CachedPtr;
		object obj2 = this + 100;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+8]");
		_ = 0;
	}

	private void SetCurrentValueToEnd()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		object obj = this + 88;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
		_ = 0;
		TweenScale tweenScale = (TweenScale)(obj2 + 12);
		tweenScale = (TweenScale)obj2;
		TweenScale tweenScale2 = tweenScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)tweenScale2).m_CachedPtr = (IntPtr)0;
		Vector3 vector = tweenScale.scale;
	}

	public TweenScale()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		object obj = this + 100;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
		_ = 0;
		TweenScale tweenScale = (TweenScale)(obj2 + 12);
		tweenScale = (TweenScale)obj2;
		TweenScale tweenScale2 = tweenScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)tweenScale2).m_CachedPtr = (IntPtr)0;
		Vector3 vector = tweenScale.scale;
	}
}
