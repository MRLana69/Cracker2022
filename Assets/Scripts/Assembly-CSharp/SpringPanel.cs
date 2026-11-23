using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class SpringPanel : MonoBehaviour
{
	public delegate void OnFinished();

	public static SpringPanel current;

	public Vector3 target;

	public float strength;

	public OnFinished onFinished;

	private UIPanel mPanel;

	private Transform mTrans;

	private UIScrollView mDrag;

	private void Start()
	{
		UIPanel component = GetComponent<UIPanel>();
		mPanel = component;
		UIScrollView component2 = GetComponent<UIScrollView>();
		mDrag = component2;
		Transform transform = base.transform;
		mTrans = transform;
	}

	private void Update()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SpringPanel>)+DC] (should have been resolved before IL gen)");
	}

	protected unsafe virtual void AdvanceTowardsPosition()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected VT, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected VT, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00d3: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		//IL_012d: Invalid comparison between Obj and F4
		//IL_014e: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_016e: Expected VT, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected VT, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0276: Expected F4, but got I
		//IL_0271: Expected native int or pointer, but got VT
		//IL_0197: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I
		//IL_0358: Invalid comparison between Obj and F4
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		object obj = default;
		Vector2 vector = (Vector2)(obj - 112);
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		Vector3 localPosition = mTrans.localPosition;
		Vector3 localPosition2 = mTrans.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPanel)+14]");
		_ = 0;
		_ = target;
		Vector3 vector2 = (Vector3)(vector + 40);
		Vector3 to = (Vector3)(vector + 24);
		Vector3 vector3 = NGUIMath.SpringLerp(vector2, to, strength, unscaledDeltaTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+60]");
		object obj2 = 0 - target;
		object obj3 = obj2 * obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+64]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPanel)+10]");
		object obj4 = num - 0;
		object obj5 = obj4 * obj4;
		object obj6 = obj3 + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+68]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPanel)+14]");
		object obj7 = num2 - 0;
		object obj8 = obj7 * obj7;
		object obj9 = obj6 + obj8;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.01f);
		bool flag2 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+68]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+64]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+60]");
		Vector3 vector4 = (Vector3)0;
		if (!flag2)
		{
			enabled = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPanel)+14]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpringPanel)+10]");
			obj11 = 0;
			vector4 = target;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
		_ = 0;
		Vector3 localPosition3 = (Vector3)(vector + 8);
		mTrans.localPosition = localPosition3;
		UIPanel uIPanel = mPanel;
		Vector3 vector5 = vector4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+60]");
		object obj12 = vector5 - 0;
		object obj13 = uIPanel.mClipOffset - obj12;
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+64]");
		object obj15 = obj14 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v46 (UIPanel)+F0]");
		object obj16 = 0 - obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+38]");
		((Vector2*)(nint)vector)->x = 0f;
		mPanel.clipOffset = vector;
		if (mDrag != null)
		{
			UIScrollView uIScrollView = mDrag;
			object obj17 = uIScrollView - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v193 @ S2_v26+BC] (should have been resolved before IL gen)");
		}
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.01f) && this.onFinished != null)
		{
			current = this;
			OnFinished onFinished = this.onFinished;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v234.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			current = null;
		}
	}

	public static SpringPanel Begin(GameObject go, Vector3 pos, float strength)
	{
		//IL_0072: Expected VT, but got F4
		SpringPanel component = go.GetComponent<SpringPanel>();
		bool flag = component == null;
		bool flag2 = !flag;
		SpringPanel springPanel = component;
		if (!flag2)
		{
			SpringPanel springPanel2 = go.AddComponent<SpringPanel>();
			springPanel = springPanel2;
		}
		springPanel.target = (Vector3)pos.x;
		_ = pos.z;
		springPanel.onFinished = null;
		springPanel.strength = strength;
		springPanel.enabled = true;
		return springPanel;
	}

	public SpringPanel()
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
