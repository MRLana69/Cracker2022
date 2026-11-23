using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class SpringPosition : MonoBehaviour
{
	public delegate void OnFinished();

	public static SpringPosition current;

	public Vector3 target;

	public float strength;

	public bool worldSpace;

	public bool ignoreTimeScale;

	public bool updateScrollView;

	public OnFinished onFinished;

	private GameObject eventReceiver;

	public string callWhenFinished;

	private Transform mTrans;

	private float mThreshold;

	private UIScrollView mSv;

	private void Start()
	{
		Transform transform = base.transform;
		mTrans = transform;
		if (~(updateScrollView ? 1u : 0u) == 0)
		{
			GameObject go = gameObject;
			UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>(go);
			mSv = uIScrollView;
		}
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected VT, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected VT, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected VT, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		//IL_036f: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got I
		//IL_03ca: Invalid comparison between F4 and Obj
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_02af: Expected Obj, but got I
		//IL_02e6: Expected Obj, but got I
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected VT, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected VT, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected VT, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_01dd: Invalid comparison between F4 and Obj
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0401: Expected F4, but got I
		//IL_03fc: Expected native int or pointer, but got VT
		//IL_0410: Expected F4, but got VT
		//IL_040b: Expected native int or pointer, but got VT
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected VT, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 208);
		float deltaTime = ((~(ignoreTimeScale ? 1u : 0u) != 0) ? Time.deltaTime : Time.unscaledDeltaTime);
		if (~(worldSpace ? 1u : 0u) == 0)
		{
			if (mThreshold == 0f)
			{
				Vector3 position = mTrans.position;
				Vector3 vector2 = target;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
				object obj2 = vector2 - 0;
				object obj3 = obj2 * obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPosition)+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
				object obj4 = num - 0;
				object obj5 = obj4 * obj4;
				object obj6 = obj3 + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPosition)+14]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
				object obj7 = num2 - 0;
				object obj8 = obj7 * obj7;
				object obj9 = obj6 + obj8;
				float num3 = (float)obj9 * 0.001f;
				mThreshold = num3;
			}
			Vector3 position2 = mTrans.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPosition)+14]");
			_ = 0;
			_ = target;
			Vector3 vector3 = vector + 112;
			Vector3 to = vector + 96;
			Vector3 vector4 = NGUIMath.SpringLerp(vector3, to, strength, deltaTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			_ = 0;
			Vector3 position3 = vector + 80;
			mTrans.position = position3;
			Vector3 position4 = mTrans.position;
			Vector3 vector5 = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			object obj10 = vector5 - 0;
			object obj11 = obj10 * obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPosition)+10]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
			object obj12 = num4 - 0;
			object obj13 = obj12 * obj12;
			object obj14 = obj11 + obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPosition)+14]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			object obj15 = num5 - 0;
			object obj16 = obj15 * obj15;
			object obj17 = obj14 + obj16;
			float num6 = mThreshold;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPosition)+14]");
				_ = 0;
				_ = target;
				Vector3 position5 = vector - -64;
				mTrans.position = position5;
				goto IL_0424;
			}
		}
		else
		{
			if (mThreshold == 0f)
			{
				Vector3 localPosition = mTrans.localPosition;
				Vector3 vector6 = target;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
				object obj18 = vector6 - 0;
				object obj19 = obj18 * obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPosition)+10]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
				object obj20 = num7 - 0;
				object obj21 = obj20 * obj20;
				object obj22 = obj19 + obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPosition)+14]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
				object obj23 = num8 - 0;
				object obj24 = obj23 * obj23;
				object obj25 = obj22 + obj24;
				float num9 = (float)obj25 * 1E-05f;
				mThreshold = num9;
			}
			Vector3 localPosition2 = mTrans.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPosition)+14]");
			_ = 0;
			_ = target;
			Vector3 vector7 = vector + 48;
			Vector3 to2 = vector + 32;
			Vector3 vector8 = NGUIMath.SpringLerp(vector7, to2, strength, deltaTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			_ = 0;
			Vector3 localPosition3 = vector + 16;
			mTrans.localPosition = localPosition3;
			Vector3 localPosition4 = mTrans.localPosition;
			Vector3 vector9 = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			object obj26 = vector9 - 0;
			object obj27 = obj26 * obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPosition)+10]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
			object obj28 = num10 - 0;
			object obj29 = obj28 * obj28;
			object obj30 = obj27 + obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPosition)+14]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			object obj31 = num11 - 0;
			object obj32 = obj31 * obj31;
			object obj33 = obj30 + obj32;
			float num12 = mThreshold;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num12) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPosition)+14]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)target;
				mTrans.localPosition = vector;
				goto IL_0424;
			}
		}
		goto IL_043a;
		IL_0424:
		NotifyListeners();
		enabled = false;
		goto IL_043a;
		IL_043a:
		if (mSv != null)
		{
			UIScrollView uIScrollView = mSv;
			object obj34 = uIScrollView - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v430 @ S2_v6+BC] (should have been resolved before IL gen)");
		}
	}

	private void NotifyListeners()
	{
		//IL_0062: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		current = this;
		OnFinished onFinished = this.onFinished;
		if (this.onFinished != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v19.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		if (!(eventReceiver != null))
		{
			goto IL_0083;
		}
		string text = callWhenFinished;
		object obj;
		if (callWhenFinished != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_00b9;
			}
		}
		obj = 1;
		goto IL_00b9;
		IL_0083:
		current = null;
		return;
		IL_00b9:
		if (obj == null)
		{
			eventReceiver.SendMessage(callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		goto IL_0083;
	}

	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
	{
		//IL_0098: Expected VT, but got F4
		SpringPosition component = go.GetComponent<SpringPosition>();
		bool flag = component == null;
		bool flag2 = !flag;
		SpringPosition springPosition = component;
		if (!flag2)
		{
			SpringPosition springPosition2 = go.AddComponent<SpringPosition>();
			springPosition = springPosition2;
		}
		springPosition.target = (Vector3)pos.x;
		_ = pos.z;
		springPosition.onFinished = null;
		springPosition.strength = strength;
		if (!springPosition.enabled)
		{
			springPosition.mThreshold = 0f;
			springPosition.enabled = true;
		}
		return springPosition;
	}

	public SpringPosition()
	{
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		target = Vector3.zeroVector;
		strength = 10f;
		base._002Ector();
	}
}
