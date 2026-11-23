using Cpp2ILInjected;
using UnityEngine;

public class TweenPosition : UITweener
{
	public Vector3 from;

	public Vector3 to;

	public bool worldSpace;

	private Transform mTrans;

	private UIRect mRect;

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

	public unsafe Vector3 position
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

	public unsafe Vector3 value
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_006a: Expected F4, but got I
			//IL_0065: Expected native int or pointer, but got VT
			//IL_0077: Expected F4, but got Obj
			//IL_0072: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Transform transform = cachedTransform;
			if (~(worldSpace ? 1u : 0u) == 0)
			{
				Vector3 vector = transform.position;
			}
			else
			{
				Vector3 localPosition = transform.localPosition;
			}
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
			//IL_00b8: Expected native int or pointer, but got VT
			//IL_00ca: Expected native int or pointer, but got VT
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected VT, but got Unknown
			//IL_0159: Expected native int or pointer, but got VT
			//IL_0166: Expected native int or pointer, but got VT
			//IL_0173: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			if (!(mRect != null) || !mRect.isAnchored || ~(worldSpace ? 1u : 0u) == 0)
			{
				Transform transform = cachedTransform;
				if (~(worldSpace ? 1u : 0u) == 0)
				{
					_ = value.z;
					_ = value.x;
					Vector3 vector2 = vector + 16;
					transform.position = vector2;
				}
				else
				{
					((Vector3*)(nint)vector)->z = value.z;
					((Vector3*)(nint)vector)->x = value.x;
					transform.localPosition = vector;
				}
			}
			else
			{
				Transform transform2 = cachedTransform;
				Vector3 localPosition = transform2.localPosition;
				float num = value.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				float x = num - 0f;
				float num2 = value.y;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				float y = num2 - 0f;
				float num3 = value.z;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				float z = num3 - 0f;
				((Vector3*)(nint)value)->z = z;
				((Vector3*)(nint)value)->y = y;
				((Vector3*)(nint)value)->x = x;
				NGUIMath.MoveRect(mRect, x, y);
			}
		}
	}

	private void Awake()
	{
		UIRect component = GetComponent<UIRect>();
		mRect = component;
	}

	protected unsafe override void OnUpdate(float factor, bool isFinished)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00e3: Expected F4, but got I
		//IL_00de: Expected native int or pointer, but got VT
		//IL_0102: Expected F4, but got I
		//IL_00fd: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		float num = 1f - factor;
		float num2 = (float)from * num;
		float num3 = (float)to * factor;
		float num4 = num2 + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenPosition)+54]");
		float num5 = 0f * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenPosition)+60]");
		float num6 = 0f * factor;
		float num7 = num5 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenPosition)+58]");
		float num8 = 0f * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenPosition)+64]");
		float num9 = 0f * factor;
		float num10 = num8 + num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		value = vector;
	}

	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0076: Expected VT, but got Obj
		//IL_0088: Expected VT, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		TweenPosition tweenPosition = UITweener.Begin<TweenPosition>(go, duration);
		Vector3 vector = tweenPosition.value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		tweenPosition.from = (Vector3)obj;
		tweenPosition.to = (Vector3)pos.x;
		_ = pos.z;
		if (!(duration > 0f))
		{
			tweenPosition.Sample(1f, isFinished: true);
			tweenPosition.enabled = false;
		}
		return tweenPosition;
	}

	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos, bool worldSpace)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0083: Expected VT, but got Obj
		//IL_0095: Expected VT, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		TweenPosition tweenPosition = UITweener.Begin<TweenPosition>(go, duration);
		tweenPosition.worldSpace = worldSpace;
		Vector3 vector = tweenPosition.value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		tweenPosition.from = (Vector3)obj;
		tweenPosition.to = (Vector3)pos.x;
		_ = pos.z;
		if (!(duration > 0f))
		{
			tweenPosition.Sample(1f, isFinished: true);
			tweenPosition.enabled = false;
		}
		return tweenPosition;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenPosition)+58]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenPosition)+64]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)to;
		value = vector;
	}
}
