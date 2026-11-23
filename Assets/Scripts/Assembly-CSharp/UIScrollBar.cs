using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIScrollBar : UISlider
{
	private enum Direction
	{
		Horizontal,
		Vertical,
		Upgraded
	}

	protected float mSize = 1f;

	private float mScroll;

	private Direction mDir = Direction.Upgraded;

	public float scrollValue
	{
		get
		{
			return value;
		}
		set
		{
			base.value = value;
		}
	}

	public float barSize
	{
		get
		{
			return mSize;
		}
		set
		{
			//IL_0118: Expected I, but got Obj
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected Obj, but got Unknown
			float num = Math.Min(value, 1f);
			bool flag = value < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			if (num2 == mSize)
			{
				return;
			}
			mIsDirty = true;
			mSize = num2;
			if (NGUITools.GetActive(this))
			{
				if (UIProgressBar.current == null && onChange != null)
				{
					UIProgressBar.current = this;
					EventDelegate.Execute(onChange);
					UIProgressBar.current = null;
				}
				nint num3 = (nint)this;
				object obj = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S1_v13 (Il2CppClass<UIScrollBar>)+F4] (should have been resolved before IL gen)");
			}
		}
	}

	protected override void Upgrade()
	{
		if (mDir != Direction.Upgraded)
		{
			mDir = Direction.Upgraded;
			mValue = mScroll;
			bool flag = true;
			if (!mInverted)
			{
				flag = true;
			}
			if (mDir == Direction.Horizontal)
			{
				flag = mInverted;
			}
			mFill = (flag ? FillDirection.RightToLeft : FillDirection.LeftToRight);
		}
	}

	protected unsafe override void OnStart()
	{
		base.OnStart();
		if (!(mFG != null))
		{
			return;
		}
		GameObject gameObject = mFG.gameObject;
		GameObject gameObject2 = base.gameObject;
		if (!(gameObject != gameObject2))
		{
			return;
		}
		Collider component = mFG.GetComponent<Collider>();
		if (!(component != null))
		{
			Collider2D component2 = mFG.GetComponent<Collider2D>();
			if (!(component2 != null))
			{
				return;
			}
		}
		GameObject go = mFG.gameObject;
		UIEventListener uIEventListener = UIEventListener.Get(go);
		UIEventListener.BoolDelegate boolDelegate = default;
		boolDelegate._002Ector(this, (nint)__ldftn(UISlider.OnPressForeground));
		Delegate obj = Delegate.Combine(uIEventListener.onPress, boolDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UIEventListener.BoolDelegate onPress = default;
		uIEventListener.onPress = onPress;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UIEventListener.VectorDelegate vectorDelegate = default;
		vectorDelegate._002Ector(this, (nint)__ldftn(UISlider.OnDragForeground));
		Delegate obj2 = Delegate.Combine(uIEventListener.onDrag, vectorDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UIEventListener.VectorDelegate onDrag = default;
		uIEventListener.onDrag = onDrag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UIWidget uIWidget = mFG;
		uIWidget.autoResizeBoxCollider = true;
	}

	protected unsafe override float LocalToValue(Vector2 localPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_027d: Expected native int or pointer, but got VT
		//IL_02ff: Expected I, but got Obj
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_0466: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_022b: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		float result;
		if (mFG != null)
		{
			float num = Math.Min(mSize, 1f);
			bool flag = mSize < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			float num3 = num2 * 0.5f;
			float num4 = 1f - num3;
			UIWidget uIWidget = mFG;
			nint num5 = (nint)uIWidget;
			object obj2 = uIWidget + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ S1_v14 (Il2CppClass<UIWidget>)+104] (should have been resolved before IL gen)");
			object obj4 = default;
			object obj3 = obj4 + 16;
			if (mFill < FillDirection.BottomToTop)
			{
				object obj5 = obj4 + 16;
				object obj6 = obj4 + 40;
				object obj7 = obj6 - obj5;
				float num6 = Math.Min(num4, 1f);
				bool flag2 = num4 < 0f;
				float num7 = 0f;
				if (!flag2)
				{
					num7 = num6;
				}
				float num8 = (float)obj7 * num7;
				float num9 = (float)obj5 + num8;
				object obj8 = obj4 + 40;
				object obj9 = obj8 - obj3;
				float num10 = Math.Min(num3, 1f);
				bool flag3 = num3 < 0f;
				float num11 = 0f;
				if (!flag3)
				{
					num11 = num10;
				}
				float num12 = (float)obj9 * num11;
				float num13 = (float)obj3 + num12;
				float num14 = num9 - num13;
				if (num14 == 0f)
				{
					result = value;
				}
				else
				{
					float num15 = num9 - localPos.x;
					result = num15 / num14;
					object obj10 = mFill & (FillDirection)(-3);
					if ((nint)obj10 != 1)
					{
						float num16 = localPos.x - num13;
						result = num16 / num14;
					}
				}
			}
			else
			{
				object obj11 = obj4 + 52;
				object obj12 = obj4 + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v21+4]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v31+4]");
				object obj13 = num17 - 0;
				float num18 = Math.Min(num4, 1f);
				bool flag4 = num4 < 0f;
				float num19 = 0f;
				if (!flag4)
				{
					num19 = num18;
				}
				float num20 = (float)obj13 * num19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v31+4]");
				float num21 = 0f + num20;
				object obj14 = obj4 + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S2_v16+4]");
				nint num22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v26+4]");
				object obj15 = num22 - 0;
				float num23 = Math.Min(num3, 1f);
				bool flag5 = num3 < 0f;
				float num24 = 0f;
				if (!flag5)
				{
					num24 = num23;
				}
				float num25 = (float)obj15 * num24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v26+4]");
				float num26 = 0f + num25;
				float num27 = num21 - num26;
				if (num27 == 0f)
				{
					result = value;
				}
				else
				{
					float num28 = num21 - localPos.y;
					result = num28 / num27;
					object obj16 = mFill & (FillDirection)(-3);
					if ((nint)obj16 != 1)
					{
						float num29 = localPos.y - num26;
						result = num29 / num27;
					}
				}
			}
		}
		else
		{
			((Vector2*)(nint)vector)->x = localPos.x;
			_ = localPos.x;
			result = base.LocalToValue(vector);
		}
		return result;
	}

	public unsafe override void ForceUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_03b4: Expected Obj, but got I4
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected VT, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0179: Expected I, but got Obj
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_01ae: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected VT, but got Unknown
		//IL_0291: Expected F4, but got I
		//IL_028c: Expected native int or pointer, but got VT
		//IL_02b3: Expected F4, but got I
		//IL_02ae: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		if (mFG != null)
		{
			mIsDirty = false;
			float num = Math.Min(mSize, 1f);
			bool flag = mSize < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			float num3 = num2 * 0.5f;
			float num4 = 1f - num3;
			float num5 = num4 - num3;
			float num6 = value;
			float num7 = Math.Min(num6, 1f);
			bool flag2 = num6 < 0f;
			float num8 = 0f;
			if (!flag2)
			{
				num8 = num7;
			}
			float num9 = num5 * num8;
			float num10 = num3 + num9;
			float num11 = num10 - num3;
			float num12 = num10 + num3;
			object obj2 = mFill & (FillDirection)(-3);
			bool flag3 = (nint)obj2 == 1;
			if (mFill < FillDirection.BottomToTop)
			{
				if (!flag3)
				{
					float num13 = num12;
					float num14 = num11;
				}
				else
				{
					float num15 = 1f - num12;
					float num16 = 1f - num11;
					float num13 = num16;
					float num14 = num15;
				}
				object obj3 = vector + 112;
				float num17 = 1f;
				float num18 = 0f;
			}
			else
			{
				if (!flag3)
				{
					float num18 = num11;
				}
				else
				{
					float num19 = 1f - num12;
					num12 = 1f - num11;
					float num18 = num19;
				}
				_ = 0;
				object obj3 = vector + 96;
				float num13 = 1f;
				float num17 = num12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v34+8]");
			_ = 0;
			Vector4 drawRegion = (Vector4)(vector + 32);
			mFG.drawRegion = drawRegion;
			if (thumb != null)
			{
				object obj4 = vector + 80;
				UIWidget uIWidget = mFG;
				nint num20 = (nint)uIWidget;
				object obj5 = uIWidget + 184;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v212 @ S2_v14 (Il2CppClass<UIWidget>)+174] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				nint num21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				object obj6 = num21 - 0;
				float num22 = (float)obj6 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				float num23 = 0f + num22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
				nint num24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
				object obj7 = num24 - 0;
				float num25 = (float)obj7 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
				float num26 = 0f + num25;
				Transform transform = mFG.cachedTransform;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				_ = 0;
				Vector3 position = vector + 16;
				Vector3 vector2 = transform.TransformPoint(position);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				((Vector3*)(nint)vector)->x = 0f;
				SetThumbPosition(vector);
			}
		}
		else
		{
			base.ForceUpdate();
		}
	}
}
