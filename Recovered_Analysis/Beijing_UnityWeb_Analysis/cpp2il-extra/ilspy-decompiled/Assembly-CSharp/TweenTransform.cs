using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Pages;
using UnityEngine;

public class TweenTransform : UITweener
{
	public Transform from;

	public Transform to;

	public bool parentWhenFinished;

	private Transform mTrans;

	private Vector3 mPos;

	private Quaternion mRot;

	private Vector3 mScale;

	protected unsafe override void OnUpdate(float factor, bool isFinished)
	{
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0260: Expected I, but got Obj
		//IL_0276: Expected Obj, but got I
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected VT, but got Unknown
		//IL_03ac: Expected F4, but got Obj
		//IL_03a7: Expected native int or pointer, but got VT
		//IL_03c1: Expected F4, but got I
		//IL_03bc: Expected native int or pointer, but got VT
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected Obj, but got Unknown
		//IL_042b: Expected F4, but got Obj
		//IL_0426: Expected native int or pointer, but got VT
		//IL_0440: Expected F4, but got I
		//IL_043b: Expected native int or pointer, but got VT
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected VT, but got Unknown
		//IL_047a: Expected F4, but got Obj
		//IL_0475: Expected native int or pointer, but got VT
		//IL_048f: Expected F4, but got I
		//IL_048a: Expected native int or pointer, but got VT
		//IL_049c: Expected F4, but got Obj
		//IL_0497: Expected native int or pointer, but got VT
		//IL_04b1: Expected F4, but got I
		//IL_04ac: Expected native int or pointer, but got VT
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_007d: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_014c: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_030b: Expected I, but got Obj
		//IL_0321: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I
		//IL_018d: Expected I, but got Obj
		//IL_01da: Expected I, but got Obj
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v67 (Il2CppClass<UnityEngine.Vector3>)+74]");
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
		Vector3 scale = ((TweenScale)vector).scale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenTransform)+70]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenTransform)+78]");
		if ((UnityEngine.Object)0 != null)
		{
			string go = tag;
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v53 (Il2CppClass<NGUITools>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num7 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v63 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj12 = this + 120;
			UITable uITable = NGUITools.FindInParents<UITable>((GameObject)(object)go);
			obj12 = uITable;
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v64 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S1_v70 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenTransform)+78]");
			if ((UnityEngine.Object)0 != null)
			{
				_ = 0;
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenTransform)+78]");
		((UITable)0).Sort((List<Transform>)1);
	}

	public static TweenTransform Begin(GameObject go, float duration, Transform to)
	{
		//IL_004f: Expected VT, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_0018: Expected Obj, but got I4
		TweenScale tweenScale = UITweener.Begin<TweenScale>(go, duration);
		TweenScale tweenScale2 = default;
		tweenScale2.value = (Vector3)tweenScale;
		object obj = tweenScale2 + 12;
		obj = tweenScale2;
		_ = ((UnityEngine.Object)tweenScale2).m_CachedPtr;
		object obj2 = tweenScale + 88;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v10+8]");
		_ = 0;
		obj = to;
		_ = ((UnityEngine.Object)to).m_CachedPtr;
		object obj3 = tweenScale + 100;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v10+8]");
		_ = 0;
		if (!(duration > 0f))
		{
			((PageTop)(object)tweenScale).Delay(1f, (Action)1);
			tweenScale.tag = null;
		}
		return (TweenTransform)(object)tweenScale;
	}

	public static TweenTransform Begin(GameObject go, float duration, Transform from, Transform to)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected I4, but got Unknown
		//IL_006a: Expected VT, but got Obj
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_0018: Expected Obj, but got I4
		TweenPosition tweenPosition = UITweener.Begin<TweenPosition>(go, duration);
		bool worldSpace = (byte)(to & 1) != 0;
		tweenPosition.worldSpace = worldSpace;
		TweenPosition tweenPosition2 = default;
		tweenPosition2.value = (Vector3)tweenPosition;
		object obj = tweenPosition2 + 12;
		obj = tweenPosition2;
		_ = ((UnityEngine.Object)tweenPosition2).m_CachedPtr;
		object obj2 = tweenPosition + 88;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v12+8]");
		_ = 0;
		obj = from;
		_ = ((UnityEngine.Object)from).m_CachedPtr;
		object obj3 = tweenPosition + 100;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v12+8]");
		_ = 0;
		if (!(duration > 0f))
		{
			((PageTop)(object)tweenPosition).Delay(1f, (Action)1);
			tweenPosition.tag = null;
		}
		return (TweenTransform)(object)tweenPosition;
	}

	public TweenTransform()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v29 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		Vector3 forward = Vector3.forward;
		object obj4 = obj3 + 24;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		_ = 0;
		object obj5 = this + 88;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		Vector3 forward2 = Vector3.forward;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = this + 100;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		((UI2DSprite)(object)this).OnUpdate();
	}
}
