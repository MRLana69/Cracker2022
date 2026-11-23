using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class TweenColor : UITweener
{
	public Color from = (Color)4575657222473777152L;

	public Color to = (Color)4575657222473777152L;

	private bool mCached;

	private UIWidget mWidget;

	private Material mMat;

	private Light mLight;

	private SpriteRenderer mSr;

	private Image img;

	public unsafe Color color
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
			Color color = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Color color2 = default;
			((Color*)(nint)color2)->b = 0f;
			((Color*)(nint)color2)->r = (float)obj;
			return color2;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_001b: Expected native int or pointer, but got VT
			//IL_002d: Expected native int or pointer, but got VT
			object obj = default;
			Color color = (Color)(obj - 16);
			((Color*)(nint)color)->b = value.b;
			((Color*)(nint)color)->r = value.r;
			this.value = color;
		}
	}

	public unsafe Color value
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0068: Expected F4, but got VT
			//IL_0063: Expected native int or pointer, but got VT
			//IL_007d: Expected F4, but got I
			//IL_0078: Expected native int or pointer, but got VT
			//IL_00d4: Expected F4, but got I
			//IL_00cf: Expected native int or pointer, but got VT
			//IL_00e1: Expected F4, but got Obj
			//IL_00dc: Expected native int or pointer, but got VT
			//IL_0138: Expected F4, but got I
			//IL_0133: Expected native int or pointer, but got VT
			//IL_0145: Expected F4, but got Obj
			//IL_0140: Expected native int or pointer, but got VT
			//IL_01b7: Expected native int or pointer, but got VT
			//IL_01c5: Expected native int or pointer, but got VT
			//IL_019c: Expected F4, but got I
			//IL_0197: Expected native int or pointer, but got VT
			//IL_01a9: Expected F4, but got Obj
			//IL_01a4: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			if (~(mCached ? 1u : 0u) != 0)
			{
				Cache();
			}
			Color color = default;
			if (mWidget != null)
			{
				UIWidget uIWidget = mWidget;
				((Color*)(nint)color)->r = (float)uIWidget.mColor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v31 (UIWidget)+54]");
				((Color*)(nint)color)->b = 0f;
			}
			else if (mMat != null)
			{
				Color color2 = mMat.color;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((Color*)(nint)color)->b = 0f;
				((Color*)(nint)color)->r = (float)obj;
			}
			else if (mSr != null)
			{
				Color color3 = mSr.color;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((Color*)(nint)color)->b = 0f;
				((Color*)(nint)color)->r = (float)obj;
			}
			else if (mLight != null)
			{
				Color color4 = mLight.color;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((Color*)(nint)color)->b = 0f;
				((Color*)(nint)color)->r = (float)obj;
			}
			else
			{
				((Color*)(nint)color)->b = 0f;
				((Color*)(nint)color)->r = 0f;
			}
			return color;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected VT, but got Unknown
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected VT, but got Unknown
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected VT, but got Unknown
			//IL_023e: Expected Obj, but got F4
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected VT, but got Unknown
			object obj2 = default;
			object obj = obj2 - 80;
			if (~(mCached ? 1u : 0u) != 0)
			{
				Cache();
			}
			if (mWidget != null)
			{
				_ = value.b;
				_ = value.r;
				Color color = (Color)(obj + 16);
				mWidget.color = color;
			}
			else if (mMat != null)
			{
				_ = value.b;
				_ = value.r;
				Color color2 = (Color)(obj + 32);
				mMat.color = color2;
			}
			else if (mSr != null)
			{
				_ = value.b;
				_ = value.r;
				Color color3 = (Color)(obj + 48);
				mSr.color = color3;
			}
			else if (mLight != null)
			{
				_ = value.b;
				_ = value.r;
				Color color4 = (Color)(obj - -64);
				mLight.color = color4;
				float num = value.r + value.g;
				float num2 = num + value.b;
				bool flag = num2 > 0.01f;
				mLight.enabled = flag;
			}
			if (img != null)
			{
				_ = value.b;
				obj = value.r;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
		}
	}

	private void Cache()
	{
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		mCached = true;
		UIWidget component = GetComponent<UIWidget>();
		mWidget = component;
		object obj = this + 116;
		if (img == null)
		{
			Image component2 = GetComponent<Image>();
			img = component2;
		}
		if (!((UnityEngine.Object)obj == null))
		{
			return;
		}
		SpriteRenderer component3 = GetComponent<SpriteRenderer>();
		mSr = component3;
		if (!(mSr == null))
		{
			return;
		}
		Renderer component4 = GetComponent<Renderer>();
		if (component4 != null)
		{
			Material material = component4.material;
			mMat = material;
			return;
		}
		Light component5 = GetComponent<Light>();
		mLight = component5;
		if (mLight == null)
		{
			UIWidget componentInChildren = GetComponentInChildren<UIWidget>();
			mWidget = componentInChildren;
		}
	}

	protected unsafe override void OnUpdate(float factor, bool isFinished)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001f: Expected Obj, but got VT
		//IL_00a1: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I
		//IL_016c: Expected F4, but got I
		//IL_0167: Expected native int or pointer, but got VT
		//IL_018b: Expected F4, but got I
		//IL_0186: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 32);
		object obj2 = to - from;
		float num = Math.Min(factor, 1f);
		bool flag = factor < 0f;
		float num2 = 0f;
		if (!flag)
		{
			num2 = num;
		}
		float num3 = (float)obj2 * num2;
		float num4 = (float)from + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenColor)+64]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenColor)+54]");
		object obj3 = num5 - 0;
		float num6 = (float)obj3 * num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenColor)+54]");
		float num7 = 0f + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenColor)+6C]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenColor)+5C]");
		object obj4 = num8 - 0;
		float num9 = (float)obj4 * num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenColor)+5C]");
		float num10 = 0f + num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenColor)+68]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenColor)+58]");
		object obj5 = num11 - 0;
		float num12 = (float)obj5 * num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenColor)+58]");
		float num13 = 0f + num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
		((Color*)(nint)color)->b = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+10]");
		((Color*)(nint)color)->r = 0f;
		value = color;
	}

	public static TweenColor Begin(GameObject go, float duration, Color color)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0076: Expected VT, but got Obj
		//IL_0088: Expected VT, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		TweenColor tweenColor = UITweener.Begin<TweenColor>(go, duration);
		Color color2 = tweenColor.value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		tweenColor.from = (Color)obj;
		tweenColor.to = (Color)color.r;
		_ = color.b;
		if (!(duration > 0f))
		{
			tweenColor.Sample(1f, isFinished: true);
			tweenColor.enabled = false;
		}
		return tweenColor;
	}

	public override void SetStartToCurrentValue()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		Color color = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		from = (Color)obj;
	}

	public override void SetEndToCurrentValue()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		Color color = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		to = (Color)obj;
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
		Color color = (Color)(obj - 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenColor)+58]");
		((Color*)(nint)color)->b = 0f;
		((Color*)(nint)color)->r = (float)from;
		value = color;
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
		Color color = (Color)(obj - 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenColor)+68]");
		((Color*)(nint)color)->b = 0f;
		((Color*)(nint)color)->r = (float)to;
		value = color;
	}

	public TweenColor()
	{
		//IL_000f: Expected VT, but got I8
		//IL_001e: Expected VT, but got I8
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		base._002Ector();
	}
}
