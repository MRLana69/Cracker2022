using Cpp2ILInjected;
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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object result = this + 108;
			if (mTrans == null)
			{
				Transform transform = base.transform;
				mTrans = transform;
			}
			return (Transform)result;
		}
	}

	public unsafe Vector3 value
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_003f: Expected F4, but got I
			//IL_003a: Expected native int or pointer, but got VT
			//IL_004c: Expected F4, but got Obj
			//IL_0047: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Transform transform = cachedTransform;
			Vector3 localScale = transform.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Vector3 vector = default;
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj;
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0025: Expected native int or pointer, but got VT
			//IL_0037: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 16);
			Transform transform = cachedTransform;
			((Vector3*)(nint)vector)->z = value.z;
			((Vector3*)(nint)vector)->x = value.x;
			transform.localScale = vector;
		}
	}

	public unsafe Vector3 scale
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			//IL_003a: Expected F4, but got Obj
			//IL_0035: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Vector3 vector = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Vector3 vector2 = default;
			((Vector3*)(nint)vector2)->z = 0f;
			((Vector3*)(nint)vector2)->x = (float)obj;
			return vector2;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_001b: Expected native int or pointer, but got VT
			//IL_002d: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 16);
			((Vector3*)(nint)vector)->z = value.z;
			((Vector3*)(nint)vector)->x = value.x;
			this.value = vector;
		}
	}

	protected unsafe override void OnUpdate(float factor, bool isFinished)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0199: Expected F4, but got I
		//IL_0194: Expected native int or pointer, but got VT
		//IL_01b8: Expected F4, but got I
		//IL_01b3: Expected native int or pointer, but got VT
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		float num = 1f - factor;
		float num2 = (float)from * num;
		float num3 = (float)to * factor;
		float num4 = num2 + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenScale)+54]");
		float num5 = 0f * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenScale)+60]");
		float num6 = 0f * factor;
		float num7 = num5 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenScale)+58]");
		float num8 = 0f * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenScale)+64]");
		float num9 = 0f * factor;
		float num10 = num8 + num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		value = vector;
		if (~(updateTable ? 1u : 0u) != 0)
		{
			return;
		}
		object obj2 = this + 112;
		if (mTable == null)
		{
			GameObject go = gameObject;
			UITable uITable = NGUITools.FindInParents<UITable>(go);
			mTable = uITable;
			if (mTable == null)
			{
				updateTable = false;
				return;
			}
		}
		((UITable)obj2).repositionNow = true;
	}

	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0076: Expected VT, but got Obj
		//IL_0088: Expected VT, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		TweenScale tweenScale = UITweener.Begin<TweenScale>(go, duration);
		Vector3 vector = tweenScale.value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		tweenScale.from = (Vector3)obj;
		tweenScale.to = (Vector3)scale.x;
		_ = scale.z;
		if (!(duration > 0f))
		{
			tweenScale.Sample(1f, isFinished: true);
			tweenScale.enabled = false;
		}
		return tweenScale;
	}

	public override void SetStartToCurrentValue()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 vector = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		from = (Vector3)obj;
	}

	public override void SetEndToCurrentValue()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 vector = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		to = (Vector3)obj;
	}

	private unsafe void SetCurrentValueToStart()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0023: Expected F4, but got I
		//IL_001e: Expected native int or pointer, but got VT
		//IL_0032: Expected F4, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenScale)+58]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)from;
		value = vector;
	}

	private unsafe void SetCurrentValueToEnd()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0023: Expected F4, but got I
		//IL_001e: Expected native int or pointer, but got VT
		//IL_0032: Expected F4, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenScale)+64]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)to;
		value = vector;
	}

	public TweenScale()
	{
		//IL_0013: Expected I, but got Obj
		//IL_004e: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		_ = 0;
		from = Vector3.oneVector;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		_ = 0;
		to = Vector3.oneVector;
		base._002Ector();
	}
}
