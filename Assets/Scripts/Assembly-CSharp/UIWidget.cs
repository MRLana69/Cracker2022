using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIWidget : UIRect
{
	public enum Pivot
	{
		TopLeft,
		Top,
		TopRight,
		Left,
		Center,
		Right,
		BottomLeft,
		Bottom,
		BottomRight
	}

	public delegate void OnDimensionsChanged();

	public delegate void OnPostFillCallback(UIWidget widget, int bufferOffset, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols);

	public enum AspectRatioSource
	{
		Free,
		BasedOnWidth,
		BasedOnHeight
	}

	public delegate bool HitCheck(Vector3 worldPos);

	protected Color mColor = (Color)4575657222473777152L;

	protected Pivot mPivot = Pivot.Center;

	protected int mWidth;

	protected int mHeight = 100;

	protected int mDepth;

	public OnDimensionsChanged onChange;

	public OnPostFillCallback onPostFill;

	public UIDrawCall.OnRenderCallback mOnRender;

	public bool autoResizeBoxCollider;

	public bool hideIfOffScreen;

	public AspectRatioSource keepAspectRatio;

	public float aspectRatio = 1f;

	public HitCheck hitCheck;

	[NonSerialized]
	public UIPanel panel;

	[NonSerialized]
	public UIGeometry geometry;

	[NonSerialized]
	public bool fillGeometry;

	[NonSerialized]
	protected bool mPlayMode;

	[NonSerialized]
	protected Vector4 mDrawRegion;

	[NonSerialized]
	private Matrix4x4 mLocalToPanel;

	[NonSerialized]
	private bool mIsVisibleByAlpha;

	[NonSerialized]
	private bool mIsVisibleByPanel;

	[NonSerialized]
	private bool mIsInFront;

	[NonSerialized]
	private float mLastAlpha;

	[NonSerialized]
	private bool mMoved;

	[NonSerialized]
	public UIDrawCall drawCall;

	[NonSerialized]
	protected Vector3[] mCorners;

	[NonSerialized]
	private int mAlphaFrameID;

	private int mMatrixFrame;

	private Vector3 mOldV0;

	private Vector3 mOldV1;

	public UIDrawCall.OnRenderCallback onRender
	{
		get
		{
			return mOnRender;
		}
		set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected Obj, but got Unknown
			if (!(mOnRender != value))
			{
				return;
			}
			object obj = this + 116;
			if (drawCall != null)
			{
				UIDrawCall uIDrawCall = drawCall;
				if (uIDrawCall.onRender != null && obj != null)
				{
					object obj2 = uIDrawCall + 116;
					Delegate obj3 = Delegate.Remove(uIDrawCall.onRender, (Delegate)obj);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
					object obj4 = default;
					obj2 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				}
			}
			mOnRender = value;
			if (drawCall != null)
			{
				UIDrawCall uIDrawCall2 = drawCall;
				Delegate obj5 = Delegate.Combine(uIDrawCall2.onRender, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				UIDrawCall.OnRenderCallback onRenderCallback = default;
				uIDrawCall2.onRender = onRenderCallback;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			}
		}
	}

	public unsafe Vector4 drawRegion
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector4 vector = default;
			((Vector4*)(nint)vector)->x = (float)mDrawRegion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIWidget)+9C]");
			((Vector4*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_0115: Expected VT, but got F4
			//IL_0148: Expected I, but got Obj
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected Obj, but got Unknown
			float num = (float)mDrawRegion - value.x;
			float num2 = num * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+98]");
			float num3 = 0f - value.y;
			float num4 = num3 * num3;
			float num5 = num2 + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+9C]");
			float num6 = 0f - value.z;
			float num7 = num6 * num6;
			float num8 = num5 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+A0]");
			float num9 = 0f - value.w;
			float num10 = num9 * num9;
			float num11 = num8 + num10;
			if (!(num11 < 9.9999994E-11f))
			{
				mDrawRegion = (Vector4)value.x;
				_ = value.z;
				if (~(autoResizeBoxCollider ? 1u : 0u) == 0)
				{
					ResizeCollider();
				}
				nint num12 = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S1_v24 (Il2CppClass<UIWidget>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe Vector2 pivotOffset
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0032: Expected F4, but got I
			//IL_002d: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Vector2 vector = NGUIMath.GetPivotOffset(mPivot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Vector2 vector2 = default;
			((Vector2*)(nint)vector2)->x = 0f;
			return vector2;
		}
	}

	public int width
	{
		get
		{
			return mWidth;
		}
		set
		{
			//IL_02e3: Expected I, but got Obj
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Expected Obj, but got Unknown
			//IL_0036: Expected I, but got Obj
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_018e: Expected Obj, but got I4
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected Obj, but got Unknown
			//IL_010d: Expected Obj, but got I4
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected Obj, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected Obj, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected Obj, but got Unknown
			nint num = (nint)this;
			object obj = this + 240;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIWidget>)+1AC] (should have been resolved before IL gen)");
			int num2 = default;
			if (value >= num2)
			{
				num2 = value;
			}
			if (num2 == mWidth || keepAspectRatio == AspectRatioSource.BasedOnHeight)
			{
				return;
			}
			nint num3 = (nint)this;
			object obj2 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S1_v12 (Il2CppClass<UIWidget>)+DC] (should have been resolved before IL gen)");
			object obj3 = default;
			if (obj3 != null)
			{
				AnchorPoint anchorPoint = leftAnchor;
				if (anchorPoint.target != null)
				{
					AnchorPoint anchorPoint2 = rightAnchor;
					if (anchorPoint2.target != null)
					{
						if (mPivot <= Pivot.BottomRight)
						{
							object obj4 = 1 << (int)mPivot;
							object obj5 = obj4 & 0x49;
							if (obj5 != null)
							{
								float right = (float)num2 - (float)mWidth;
								NGUIMath.AdjustWidget(this, 0f, 0f, right, 0f);
								return;
							}
							object obj6 = obj4 & 0x124;
							if (obj6 != null)
							{
								float left = (float)mWidth - (float)num2;
								NGUIMath.AdjustWidget(this, left, 0f, 0f, 0f);
								return;
							}
						}
						object obj7 = num2 - mWidth;
						object obj8 = obj7 & 1;
						object obj9 = obj7 - obj8;
						if (obj7 != obj8)
						{
							object obj10 = 0 - obj9;
							float left2 = (float)obj10 * 0.5f;
							float right2 = (float)obj9 * 0.5f;
							NGUIMath.AdjustWidget(this, left2, 0f, right2, 0f);
						}
						return;
					}
				}
				AnchorPoint anchorPoint3 = leftAnchor;
				if (anchorPoint3.target != null)
				{
					float right3 = (float)num2 - (float)mWidth;
					NGUIMath.AdjustWidget(this, 0f, 0f, right3, 0f);
				}
				else
				{
					float left3 = (float)mWidth - (float)num2;
					NGUIMath.AdjustWidget(this, left3, 0f, 0f, 0f);
				}
			}
			else
			{
				SetDimensions(num2, mHeight);
			}
		}
	}

	public int height
	{
		get
		{
			return mHeight;
		}
		set
		{
			//IL_0389: Expected I, but got Obj
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected Obj, but got Unknown
			//IL_0036: Expected I, but got Obj
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_025f: Expected Obj, but got I4
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Expected Obj, but got Unknown
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected Obj, but got Unknown
			nint num = (nint)this;
			object obj = this + 248;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIWidget>)+1B4] (should have been resolved before IL gen)");
			int num2 = default;
			if (value >= num2)
			{
				num2 = value;
			}
			if (num2 == mHeight || keepAspectRatio == AspectRatioSource.BasedOnWidth)
			{
				return;
			}
			nint num3 = (nint)this;
			object obj2 = this + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S1_v12 (Il2CppClass<UIWidget>)+E4] (should have been resolved before IL gen)");
			object obj3 = default;
			if (obj3 != null)
			{
				AnchorPoint anchorPoint = bottomAnchor;
				if (anchorPoint.target != null)
				{
					AnchorPoint anchorPoint2 = topAnchor;
					if (anchorPoint2.target != null)
					{
						if (mPivot != Pivot.TopLeft && mPivot != Pivot.Top && mPivot != Pivot.TopRight)
						{
							if (mPivot != Pivot.Left && mPivot != Pivot.Center && mPivot != Pivot.Right && (mPivot == Pivot.BottomLeft || mPivot == Pivot.Bottom || mPivot == Pivot.BottomRight))
							{
								float top = (float)num2 - (float)mHeight;
								NGUIMath.AdjustWidget(this, 0f, 0f, 0f, top);
								return;
							}
							object obj4 = num2 - mHeight;
							object obj5 = obj4 & 1;
							object obj6 = obj4 - obj5;
							if (obj4 != obj5)
							{
								object obj7 = 0 - obj6;
								float bottom = (float)obj7 * 0.5f;
								float top2 = (float)obj6 * 0.5f;
								NGUIMath.AdjustWidget(this, 0f, bottom, 0f, top2);
							}
						}
						else
						{
							float bottom2 = (float)mHeight - (float)num2;
							NGUIMath.AdjustWidget(this, 0f, bottom2, 0f, 0f);
						}
						return;
					}
				}
				AnchorPoint anchorPoint3 = bottomAnchor;
				if (anchorPoint3.target != null)
				{
					float top3 = (float)num2 - (float)mHeight;
					NGUIMath.AdjustWidget(this, 0f, 0f, 0f, top3);
				}
				else
				{
					float bottom3 = (float)mHeight - (float)num2;
					NGUIMath.AdjustWidget(this, 0f, bottom3, 0f, 0f);
				}
			}
			else
			{
				SetDimensions(mWidth, num2);
			}
		}
	}

	public unsafe Color color
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Color color = default;
			((Color*)(nint)color)->r = (float)mColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIWidget)+54]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
		set
		{
			//IL_0115: Expected VT, but got F4
			//IL_0134: Invalid comparison between F4 and I
			//IL_0142: Expected I, but got Obj
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Expected Obj, but got Unknown
			float num = (float)mColor - value.r;
			float num2 = num * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+50]");
			float num3 = 0f - value.g;
			float num4 = num3 * num3;
			float num5 = num2 + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+54]");
			float num6 = 0f - value.b;
			float num7 = num6 * num6;
			float num8 = num5 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+58]");
			float num9 = 0f - value.a;
			float num10 = num9 * num9;
			float num11 = num8 + num10;
			if (!(num11 < 9.9999994E-11f))
			{
				mColor = (Color)value.r;
				_ = value.b;
				float a = value.a;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+58]");
				bool flag = a != 0f;
				nint num12 = (nint)this;
				object obj = this + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S2_v13 (Il2CppClass<UIWidget>)+11C] (should have been resolved before IL gen)");
			}
		}
	}

	public override float alpha
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+58]");
			return 0f;
		}
		set
		{
			//IL_0010: Invalid comparison between F4 and I
			//IL_003c: Expected I, but got Obj
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+58]");
			if (value != 0f)
			{
				nint num = (nint)this;
				object obj = this + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S2_v3 (Il2CppClass<UIWidget>)+11C] (should have been resolved before IL gen)");
			}
		}
	}

	public bool isVisible
	{
		get
		{
			bool flag = (byte)(~(mIsVisibleByPanel ? 1u : 0u)) != 0;
			bool result = false;
			if (!flag)
			{
				bool flag2 = (byte)(~(mIsVisibleByAlpha ? 1u : 0u)) != 0;
				result = false;
				if (!flag2)
				{
					bool flag3 = (byte)(~(mIsInFront ? 1u : 0u)) != 0;
					result = false;
					if (!flag3)
					{
						bool flag4 = finalAlpha > 0.001f;
						bool flag5 = !flag4;
						result = false;
						if (!flag5)
						{
							bool active = NGUITools.GetActive(this);
							result = active;
						}
					}
				}
			}
			return result;
		}
	}

	public bool hasVertices
	{
		get
		{
			UIGeometry uIGeometry = geometry;
			if (geometry == null)
			{
				return false;
			}
			BetterList<Vector3> verts = uIGeometry.verts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v5 (BetterList`1<UnityEngine.Vector3>)+C]");
			return (nint)0 > (nint)0;
		}
	}

	public Pivot rawPivot
	{
		get
		{
			return mPivot;
		}
		set
		{
			//IL_005f: Expected I, but got Obj
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			if (value != mPivot)
			{
				mPivot = value;
				if (~(autoResizeBoxCollider ? 1u : 0u) == 0)
				{
					ResizeCollider();
				}
				nint num = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S1_v7 (Il2CppClass<UIWidget>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe Pivot pivot
	{
		get
		{
			return mPivot;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_003f: Expected I, but got Obj
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected Obj, but got Unknown
			//IL_0088: Expected I, but got Obj
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected Obj, but got Unknown
			//IL_0126: Expected Obj, but got I
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected Obj, but got Unknown
			//IL_015d: Expected Obj, but got I
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected Obj, but got Unknown
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected VT, but got Unknown
			//IL_0205: Expected F4, but got I
			//IL_0200: Expected native int or pointer, but got VT
			//IL_0224: Expected F4, but got I
			//IL_021f: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 112);
			if (value != mPivot)
			{
				nint num = (nint)this;
				object obj2 = this + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S2_v3 (Il2CppClass<UIWidget>)+10C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v7+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v7+10]");
				_ = 0;
				mChanged = true;
				mPivot = value;
				nint num2 = (nint)this;
				object obj3 = this + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S2_v7 (Il2CppClass<UIWidget>)+10C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v14+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v14+10]");
				_ = 0;
				Transform transform = cachedTransform;
				Vector3 position = transform.position;
				Vector3 localPosition = transform.localPosition;
				Transform transform2 = cachedTransform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
				object obj4 = num3 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				object obj5 = 0 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				object obj6 = num4 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				object obj7 = 0 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				_ = 0;
				Vector3 position2 = vector + 16;
				transform2.position = position2;
				Transform transform3 = cachedTransform;
				Vector3 localPosition2 = transform3.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				Transform transform4 = cachedTransform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				((Vector3*)(nint)vector)->x = 0f;
				transform4.localPosition = vector;
			}
		}
	}

	public int depth
	{
		get
		{
			return mDepth;
		}
		set
		{
			if (mDepth == value)
			{
				return;
			}
			if (panel != null)
			{
				panel.RemoveWidget(this);
			}
			mDepth = value;
			if (panel != null)
			{
				panel.AddWidget(this);
				if (!Application.isPlaying)
				{
					panel.SortWidgets();
					UIPanel uIPanel = panel;
					uIPanel.mRebuild = true;
				}
			}
		}
	}

	public int raycastDepth
	{
		get
		{
			//IL_0069: Expected Obj, but got I4
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected I4, but got Unknown
			if (panel == null)
			{
				UIPanel uIPanel = CreatePanel();
			}
			bool flag = panel != null;
			int num = mDepth;
			if (flag)
			{
				UIPanel uIPanel2 = panel;
				object obj = uIPanel2.mDepth * 1000;
				num = obj + num;
			}
			return num;
		}
	}

	public override Vector3[] localCorners
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected Obj, but got Unknown
			//IL_00ba: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 144;
			Vector2 vector = pivotOffset;
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			float num2 = num - 0f;
			float num3 = num2 * (float)mWidth;
			float num4 = num3 + (float)mWidth;
			float num5 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8C]");
			float num6 = num5 - 0f;
			float num7 = num6 * (float)mHeight;
			float num8 = num7 + (float)mHeight;
			Vector3[] array = mCorners;
			_ = 0;
			object obj3 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Vector3[] array2 = mCorners;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Vector3[] array3 = mCorners;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Vector3[] array4 = mCorners;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			return mCorners;
		}
	}

	public unsafe virtual Vector2 localSize
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_005f: Expected Obj, but got I
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected Obj, but got Unknown
			//IL_0091: Expected Obj, but got I
			//IL_00ac: Expected F4, but got Obj
			//IL_00b4: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 32;
			nint num = (nint)this;
			object obj3 = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S2_v2 (Il2CppClass<UIWidget>)+104] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v3+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v3+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v3+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v3+10]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			object obj4 = 0 - obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj5 = num2 - 0;
			object obj6 = obj5 << 32;
			float x = obj4 | obj6;
			Vector2 vector = default;
			((Vector2*)(nint)vector)->x = x;
			return vector;
		}
	}

	public unsafe Vector3 localCenter
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_005f: Expected Obj, but got I
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected Obj, but got Unknown
			//IL_00b8: Expected Obj, but got I
			//IL_00fc: Expected Obj, but got I
			//IL_012b: Expected native int or pointer, but got VT
			//IL_0138: Expected native int or pointer, but got VT
			//IL_0145: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 32;
			nint num = (nint)this;
			object obj3 = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S2_v2 (Il2CppClass<UIWidget>)+104] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v3+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v3+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v3+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v3+28]");
			obj = 0;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			object obj5 = obj4 - 0;
			float num2 = (float)obj5 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			float x = 0f + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
			object obj6 = num3 - 0;
			float num4 = (float)obj6 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
			float y = 0f + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			object obj7 = num5 - 0;
			float num6 = (float)obj7 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			float z = 0f + num6;
			Vector3 vector = default;
			((Vector3*)(nint)vector)->z = z;
			((Vector3*)(nint)vector)->y = y;
			((Vector3*)(nint)vector)->x = x;
			return vector;
		}
	}

	public override Vector3[] worldCorners
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0256: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 144;
			Vector2 vector = pivotOffset;
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			float num2 = num - 0f;
			float num3 = num2 * (float)mWidth;
			float x = num3 + (float)mWidth;
			float num4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+84]");
			float num5 = num4 - 0f;
			float num6 = num5 * (float)mHeight;
			float y = num6 + (float)mHeight;
			Transform transform = cachedTransform;
			Vector3[] array = mCorners;
			Vector3 vector2 = transform.TransformPoint(num3, num6, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			Vector3[] array2 = mCorners;
			Vector3 vector3 = transform.TransformPoint(num3, y, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Vector3[] array3 = mCorners;
			Vector3 vector4 = transform.TransformPoint(x, y, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Vector3[] array4 = mCorners;
			Vector3 vector5 = transform.TransformPoint(x, num6, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			return mCorners;
		}
	}

	public unsafe Vector3 worldCenter
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			//IL_0051: Expected F4, but got I
			//IL_004c: Expected native int or pointer, but got VT
			//IL_0077: Expected F4, but got I
			//IL_0072: Expected native int or pointer, but got VT
			//IL_008c: Expected F4, but got I
			//IL_0087: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			Transform transform = cachedTransform;
			Vector3 vector2 = localCenter;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 vector3 = transform.TransformPoint(vector);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			Vector3 vector4 = default;
			((Vector3*)(nint)vector4)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector4)->x = 0f;
			return vector4;
		}
	}

	public unsafe virtual Vector4 drawingDimensions
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0097: Invalid comparison between VT and F4
			//IL_0263: Invalid comparison between I and F4
			//IL_0342: Invalid comparison between I and F4
			//IL_00e0: Expected F4, but got VT
			//IL_00ef: Invalid comparison between VT and F4
			//IL_03b6: Invalid comparison between I and F4
			//IL_013e: Expected F4, but got I
			//IL_0153: Invalid comparison between I and F4
			//IL_01a2: Expected F4, but got I
			//IL_01b7: Invalid comparison between I and F4
			//IL_0374: Expected native int or pointer, but got VT
			//IL_0381: Expected native int or pointer, but got VT
			//IL_038e: Expected native int or pointer, but got VT
			//IL_039b: Expected native int or pointer, but got VT
			//IL_0206: Expected F4, but got I
			//IL_021b: Invalid comparison between I and F4
			object obj2 = default;
			object obj = obj2 - 16;
			Vector2 vector = pivotOffset;
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			float num2 = num - 0f;
			float num3 = num2 * (float)mWidth;
			float num4 = num3 + (float)mWidth;
			float num5 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			float num6 = num5 - 0f;
			float num7 = num6 * (float)mHeight;
			float num8 = num7 + (float)mHeight;
			bool flag = mDrawRegion != (Vector4)(object)0f;
			bool flag2 = !flag;
			float x = num3;
			if (!flag2)
			{
				float num9 = num4 - num3;
				float num10 = Math.Min((float)mDrawRegion, 1f);
				bool flag3 = mDrawRegion < (object)0f;
				float num11 = 0f;
				if (!flag3)
				{
					num11 = num10;
				}
				float num12 = num9 * num11;
				float num13 = num3 + num12;
				x = num13;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIWidget)+98]");
			bool flag4 = 0f != 0f;
			bool flag5 = !flag4;
			float y = num7;
			if (!flag5)
			{
				float num14 = num8 - num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIWidget)+98]");
				float num15 = Math.Min(0f, 1f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIWidget)+98]");
				bool flag6 = 0f < 0f;
				float num16 = 0f;
				if (!flag6)
				{
					num16 = num15;
				}
				float num17 = num14 * num16;
				float num18 = num7 + num17;
				y = num18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIWidget)+9C]");
			bool flag7 = 0f != 1f;
			bool flag8 = !flag7;
			float z = num4;
			if (!flag8)
			{
				float num19 = num4 - num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIWidget)+9C]");
				float num20 = Math.Min(0f, 1f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIWidget)+9C]");
				bool flag9 = 0f < 0f;
				float num21 = 0f;
				if (!flag9)
				{
					num21 = num20;
				}
				float num22 = num19 * num21;
				float num23 = num3 + num22;
				z = num23;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIWidget)+A0]");
			float w;
			if (0f != 1f)
			{
				float num24 = num8 - num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIWidget)+A0]");
				float num25 = Math.Min(0f, 1f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIWidget)+A0]");
				bool flag10 = 0f < 0f;
				float num26 = 0f;
				if (!flag10)
				{
					num26 = num25;
				}
				float num27 = num24 * num26;
				w = num7 + num27;
			}
			else
			{
				w = num8;
			}
			Vector4 vector2 = default;
			((Vector4*)(nint)vector2)->w = w;
			((Vector4*)(nint)vector2)->z = z;
			((Vector4*)(nint)vector2)->y = y;
			((Vector4*)(nint)vector2)->x = x;
			return vector2;
		}
	}

	public virtual Material material
	{
		get
		{
			return null;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj = default;
			string text = default;
			if (obj != null)
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v8+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text = null;
			}
			string message = text + " has no material setter";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotImplementedException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public virtual Texture mainTexture
	{
		get
		{
			//IL_0026: Expected I, but got Obj
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			nint num = (nint)this;
			object obj = this + 192;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIWidget>)+17C] (should have been resolved before IL gen)");
			UnityEngine.Object obj2 = default;
			if (obj2 != null)
			{
				return ((Material)obj2).mainTexture;
			}
			return null;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj = default;
			string text = default;
			if (obj != null)
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v8+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text = null;
			}
			string message = text + " has no mainTexture setter";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotImplementedException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public virtual Shader shader
	{
		get
		{
			//IL_0026: Expected I, but got Obj
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			nint num = (nint)this;
			object obj = this + 192;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIWidget>)+17C] (should have been resolved before IL gen)");
			UnityEngine.Object obj2 = default;
			if (obj2 != null)
			{
				return ((Material)obj2).shader;
			}
			return null;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj = default;
			string text = default;
			if (obj != null)
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v8+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text = null;
			}
			string message = text + " has no shader setter";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotImplementedException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public unsafe Vector2 relativeSize
	{
		get
		{
			//IL_0013: Expected F4, but got VT
			//IL_000e: Expected native int or pointer, but got VT
			Vector2 vector = default;
			((Vector2*)(nint)vector)->x = (float)Vector2.oneVector;
			return vector;
		}
	}

	public bool hasBoxCollider
	{
		get
		{
			Collider component = GetComponent<Collider>();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			UnityEngine.Object obj = default;
			if (obj != null)
			{
				return true;
			}
			BoxCollider2D component2 = GetComponent<BoxCollider2D>();
			return component2 != null;
		}
	}

	public virtual int minWidth => 2;

	public virtual int minHeight => 2;

	public unsafe virtual Vector4 border
	{
		get
		{
			//IL_0013: Expected I, but got Obj
			//IL_0031: Expected F4, but got VT
			//IL_002c: Expected native int or pointer, but got VT
			//IL_0046: Expected F4, but got I
			//IL_0041: Expected native int or pointer, but got VT
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v3 (Il2CppClass<UnityEngine.Vector4>)+5C]");
			nint num2 = 0;
			Vector4 vector = default;
			((Vector4*)(nint)vector)->x = (float)Vector4.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v4 (Il2CppStaticFields<UnityEngine.Vector4>)+8]");
			((Vector4*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
		}
	}

	public unsafe void SetDimensions(int w, int h)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0166: Expected F4, but got I4
		//IL_017b: Expected I, but got Obj
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected I4, but got Unknown
		//IL_00f5: Expected F8, but got I4
		//IL_01f7: Expected F4, but got I
		//IL_01f2: Expected native int or pointer, but got VT
		//IL_027d: Expected I4, but got F8
		//IL_014a: Expected F8, but got I4
		//IL_02a8: Expected I4, but got F8
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		if (w == mWidth && mHeight == h)
		{
			return;
		}
		mHeight = h;
		mWidth = w;
		if (keepAspectRatio != AspectRatioSource.Free)
		{
			if (keepAspectRatio != AspectRatioSource.BasedOnWidth)
			{
				if (keepAspectRatio == AspectRatioSource.BasedOnHeight)
				{
					float num = (float)h * aspectRatio;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num3 = default;
					double num2 = Math.Abs(num3);
					if (!(num2 < 2147483648.0))
					{
						num3 = -2147483648.0;
					}
					mWidth = (int)num3;
				}
			}
			else
			{
				int num4 = (int)(w / aspectRatio);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num6 = default;
				double num5 = Math.Abs(num6);
				if (!(num5 < 2147483648.0))
				{
					num6 = -2147483648.0;
				}
				mHeight = (int)num6;
			}
		}
		else
		{
			int num7 = w / h;
			aspectRatio = num7;
		}
		mMoved = true;
		if (~(autoResizeBoxCollider ? 1u : 0u) == 0)
		{
			ResizeCollider();
		}
		nint num8 = (nint)this;
		object obj2 = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v122 @ S1_v14 (Il2CppClass<UIWidget>)+1CC] (should have been resolved before IL gen)");
		GameObject gameObject = base.gameObject;
		RectTransform component = gameObject.GetComponent<RectTransform>();
		if (component != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+8]");
			((Vector2*)(nint)vector)->x = 0f;
			component.sizeDelta = vector;
		}
	}

	public override Vector3[] GetSides(Transform relativeTo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_0216: Expected Obj, but got I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected VT, but got Unknown
		//IL_02c2: Expected Obj, but got I
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 208;
		Vector2 vector = pivotOffset;
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		float num2 = num - 0f;
		float num3 = num2 * (float)mWidth;
		float num4 = num3 + (float)mWidth;
		float num5 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C4]");
		float num6 = num5 - 0f;
		float num7 = num6 * (float)mHeight;
		float num8 = num7 + (float)mHeight;
		Transform transform = cachedTransform;
		Vector3[] array = mCorners;
		float num9 = num7 + num8;
		float y = num9 * 0.5f;
		Vector3 vector2 = transform.TransformPoint(num3, y, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		Vector3[] array2 = mCorners;
		float num10 = num3 + num4;
		float x = num10 * 0.5f;
		Vector3 vector3 = transform.TransformPoint(x, num8, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		object obj3 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v39+8]");
		_ = 0;
		Vector3[] array3 = mCorners;
		Vector3 vector4 = transform.TransformPoint(num4, y, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		Vector3[] array4 = mCorners;
		Vector3 vector5 = transform.TransformPoint(x, num7, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		if (relativeTo != null)
		{
			object obj4 = 0;
			while ((nint)obj4 < 4)
			{
				object obj5 = obj4 * 12;
				object obj6 = (object)mCorners + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v74+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v74+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
				_ = 0;
				Vector3 position = (Vector3)(obj + 16);
				Vector3 vector6 = relativeTo.InverseTransformPoint(position);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
				obj = 0;
				object obj7 = obj4 * 12;
				object obj8 = (object)mCorners + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj9 = obj4 + 1;
				obj4 = obj9;
			}
		}
		return mCorners;
	}

	public override float CalculateFinalAlpha(int frameID)
	{
		if (frameID != mAlphaFrameID)
		{
			mAlphaFrameID = frameID;
			UpdateFinalAlpha(frameID);
		}
		return finalAlpha;
	}

	protected void UpdateFinalAlpha(int frameID)
	{
		//IL_00a8: Expected F4, but got I
		//IL_005c: Expected I, but got Obj
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		float num4 = default;
		if (~(mIsVisibleByAlpha ? 1u : 0u) == 0 && ~(mIsInFront ? 1u : 0u) == 0)
		{
			UIRect uIRect = parent;
			if (uIRect != null)
			{
				nint num = (nint)uIRect;
				object obj = uIRect + 88;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ S2_v4 (Il2CppClass<UIRect>)+114] (should have been resolved before IL gen)");
				object obj2 = default;
				float num2 = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+58]");
				float num3 = num2 * 0f;
				num4 = num3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+58]");
				num4 = 0f;
			}
		}
		finalAlpha = num4;
	}

	public override void Invalidate(bool includeChildren)
	{
		mAlphaFrameID = -1;
		mChanged = true;
		if (!(panel != null))
		{
			return;
		}
		bool visibleByPanel;
		if (~(hideIfOffScreen ? 1u : 0u) != 0)
		{
			bool hasCumulativeClipping = panel.hasCumulativeClipping;
			bool flag = !hasCumulativeClipping;
			visibleByPanel = true;
			if (flag)
			{
				goto IL_006f;
			}
		}
		visibleByPanel = panel.IsVisible(this);
		goto IL_006f;
		IL_006f:
		int frameCount = Time.frameCount;
		float num = CalculateCumulativeAlpha(frameCount);
		bool visibleByAlpha = num > 0.001f;
		bool flag2 = UpdateVisibility(visibleByAlpha, visibleByPanel);
		int frameCount2 = Time.frameCount;
		UpdateFinalAlpha(frameCount2);
		if (includeChildren)
		{
			base.Invalidate(includeChildren: true);
		}
	}

	public float CalculateCumulativeAlpha(int frameID)
	{
		//IL_0067: Expected F4, but got I
		//IL_0026: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		UIRect uIRect = parent;
		if (uIRect != null)
		{
			nint num = (nint)uIRect;
			object obj = uIRect + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S2_v3 (Il2CppClass<UIRect>)+114] (should have been resolved before IL gen)");
			object obj2 = default;
			float num2 = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+58]");
			return num2 * 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+58]");
		return 0f;
	}

	public unsafe override void SetRect(float x, float y, float width, float height)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02a0: Expected F4, but got I
		//IL_02b5: Invalid comparison between I and F4
		//IL_0324: Expected F4, but got I
		//IL_0339: Invalid comparison between I and F4
		//IL_0043: Expected F8, but got I4
		//IL_005e: Expected F8, but got I4
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected F8, but got Unknown
		//IL_03d4: Invalid comparison between I and F4
		//IL_040d: Expected I, but got Obj
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected F8, but got Unknown
		//IL_0441: Invalid comparison between I and F4
		//IL_052c: Invalid comparison between Obj and F8
		//IL_045a: Expected I, but got Obj
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_0477: Invalid comparison between Obj and F8
		//IL_0575: Expected F4, but got I
		//IL_0570: Expected native int or pointer, but got VT
		//IL_05a8: Expected F4, but got I
		//IL_05a3: Expected native int or pointer, but got VT
		//IL_05bf: Expected I4, but got F8
		//IL_05c9: Expected I4, but got F8
		//IL_0082: Expected I, but got Obj
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a9: Expected I, but got Obj
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Vector2 vector2 = pivotOffset;
		float num = x + width;
		float num2 = num - x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		float num3 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		bool flag = 0f < 0f;
		float num4 = 0f;
		if (!flag)
		{
			num4 = num3;
		}
		float num5 = num2 * num4;
		float num6 = x + num5;
		float num7 = y + height;
		float num8 = num7 - y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		float num9 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		bool flag2 = 0f < 0f;
		float num10 = 0f;
		if (!flag2)
		{
			num10 = num9;
		}
		float num11 = num8 * num10;
		float num12 = y + num11;
		float num13 = width + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num14 = Math.Abs((double)num13);
		double num15 = ((!(num14 < 2147483648.0)) ? (-2147483648.0) : ((double)num13));
		float num16 = height + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num17 = Math.Abs((double)num16);
		double num18 = ((!(num17 < 2147483648.0)) ? (-2147483648.0) : ((double)num16));
		Transform transform = cachedTransform;
		Vector3 localPosition = transform.localPosition;
		double num19 = num18 & -2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		if (0f != 0.5f)
		{
			num19 = num18;
		}
		float num20 = num6 + 0.5f;
		float num21 = num12 + 0.5f;
		nint num22 = (nint)this;
		object obj2 = this + 240;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v148 @ S1_v27 (Il2CppClass<UIWidget>)+1AC] (should have been resolved before IL gen)");
		double num23 = num15 & -2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		if (0f != 0.5f)
		{
			num23 = num15;
		}
		object obj3 = default;
		bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num23);
		bool flag4 = !flag3;
		double num24 = num23;
		if (!flag4)
		{
			nint num25 = (nint)this;
			object obj4 = this + 240;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ S1_v70 (Il2CppClass<UIWidget>)+1AC] (should have been resolved before IL gen)");
			double num26 = default;
			num24 = num26;
		}
		nint num27 = (nint)this;
		object obj5 = this + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v185 @ S1_v35 (Il2CppClass<UIWidget>)+1B4] (should have been resolved before IL gen)");
		object obj6 = default;
		bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num19);
		bool flag6 = !flag5;
		double num28 = num19;
		if (!flag6)
		{
			nint num29 = (nint)this;
			object obj7 = this + 248;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v198 @ S1_v66 (Il2CppClass<UIWidget>)+1B4] (should have been resolved before IL gen)");
			double num30 = default;
			num28 = num30;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform.localPosition = vector;
		this.width = (int)num24;
		this.height = (int)num28;
		if (isAnchored)
		{
			Transform transform2 = transform.parent;
			AnchorPoint anchorPoint = leftAnchor;
			if ((bool)anchorPoint.target)
			{
				leftAnchor.SetHorizontal(transform2, x);
			}
			AnchorPoint anchorPoint2 = rightAnchor;
			if ((bool)anchorPoint2.target)
			{
				float localPos = x + width;
				rightAnchor.SetHorizontal(transform2, localPos);
			}
			AnchorPoint anchorPoint3 = bottomAnchor;
			if ((bool)anchorPoint3.target)
			{
				bottomAnchor.SetVertical(transform2, y);
			}
			AnchorPoint anchorPoint4 = topAnchor;
			if ((bool)anchorPoint4.target)
			{
				float localPos2 = y + height;
				topAnchor.SetVertical(transform2, localPos2);
			}
		}
	}

	public void ResizeCollider()
	{
		if (NGUITools.GetActive(this))
		{
			GameObject go = gameObject;
			NGUITools.UpdateWidgetCollider(go);
		}
	}

	public static int FullCompareFunc(UIWidget left, UIWidget right)
	{
		int num = UIPanel.CompareFunc(left.panel, right.panel);
		if (num == 0)
		{
			num = PanelCompareFunc(left, right);
		}
		return num;
	}

	public static int PanelCompareFunc(UIWidget left, UIWidget right)
	{
		//IL_003c: Expected I, but got Obj
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_005c: Expected I, but got Obj
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		bool flag = left.mDepth < right.mDepth;
		int result = -1;
		if (!flag)
		{
			bool flag2 = left.mDepth > right.mDepth;
			result = 1;
			if (!flag2)
			{
				nint num = (nint)left;
				object obj = left + 192;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S1_v7 (Il2CppClass<UIWidget>)+17C] (should have been resolved before IL gen)");
				nint num2 = (nint)right;
				object obj2 = right + 192;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S1_v11 (Il2CppClass<UIWidget>)+17C] (should have been resolved before IL gen)");
				UnityEngine.Object obj3 = default;
				UnityEngine.Object obj4 = default;
				bool flag3 = obj3 != obj4;
				result = 0;
				if (flag3)
				{
					bool flag4 = obj3 == null;
					result = -1;
					if (flag4)
					{
						bool flag5 = obj4 == null;
						result = 1;
						if (flag5)
						{
							int instanceID = obj3.GetInstanceID();
							int instanceID2 = obj4.GetInstanceID();
							bool flag6 = instanceID < instanceID2;
							int result2 = -1;
							if (!flag6)
							{
								result2 = 1;
							}
							return result2;
						}
					}
				}
			}
		}
		return result;
	}

	public unsafe Bounds CalculateBounds()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0048: Expected VT, but got I
		//IL_0043: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		Bounds bounds = CalculateBounds(null);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Bounds bounds2 = default;
		((Bounds*)(nint)bounds2)->m_Center = (Vector3)0;
		return bounds2;
	}

	public unsafe Bounds CalculateBounds(Transform relativeParent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_014a: Expected I, but got Obj
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected VT, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected VT, but got Unknown
		//IL_01bc: Expected Ref, but got VT
		//IL_0031: Expected I, but got Obj
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0430: Expected I, but got Obj
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected VT, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected VT, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected VT, but got Unknown
		//IL_04a3: Expected native int or pointer, but got VT
		//IL_04b1: Expected Obj, but got I4
		//IL_0348: Expected I, but got Obj
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected VT, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected VT, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected VT, but got Unknown
		//IL_03bb: Expected native int or pointer, but got VT
		//IL_03c9: Expected Obj, but got I4
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0403: Expected VT, but got Obj
		//IL_03fe: Expected native int or pointer, but got VT
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected VT, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected VT, but got Unknown
		//IL_0257: Expected Ref, but got VT
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected VT, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected VT, but got Unknown
		//IL_02b8: Expected Ref, but got VT
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_00af: Expected F4, but got I
		//IL_00aa: Expected native int or pointer, but got VT
		//IL_00c4: Expected F4, but got I
		//IL_00bf: Expected native int or pointer, but got VT
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected VT, but got Unknown
		//IL_00df: Expected Ref, but got VT
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 352);
		object obj2 = vector + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj9;
		if (relativeParent == null)
		{
			nint num = (nint)this;
			object obj3 = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S3_v25 (Il2CppClass<UIWidget>)+104] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v64+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v64+10]");
			_ = 0;
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v75 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v76 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			_ = Vector3.zeroVector;
			Bounds bounds = (Bounds)(vector + 240);
			Vector3 center = vector + 32;
			Vector3 size = vector + 16;
			*(Bounds*)(nint)bounds = new Bounds(center, size);
			object obj4 = 1;
			object obj7 = default;
			while ((nint)obj4 < 4)
			{
				object obj5 = obj4 * 12;
				object obj6 = obj7 + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S2_v84+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S2_v84+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
				((Vector3*)(nint)vector)->x = 0f;
				Bounds bounds2 = (Bounds)(vector + 240);
				((Bounds*)bounds2)->Encapsulate(vector);
				object obj8 = obj4 + 1;
				obj4 = obj8;
			}
			obj9 = vector + 240;
		}
		else
		{
			Matrix4x4 worldToLocalMatrix = relativeParent.worldToLocalMatrix;
			object obj10 = vector + 288;
			object obj11 = vector + 176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
			nint num4 = (nint)this;
			object obj12 = this + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S3_v7 (Il2CppClass<UIWidget>)+10C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S2_v10+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S2_v10+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
			_ = 0;
			Matrix4x4 matrix4x = (Matrix4x4)(vector + 288);
			Vector3 point = vector + 112;
			Vector3 vector2 = ((Matrix4x4*)matrix4x)->MultiplyPoint3x4(point);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v38 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v39 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			_ = Vector3.zeroVector;
			Bounds bounds3 = (Bounds)(vector + 264);
			Vector3 center2 = vector + 96;
			Vector3 size2 = vector + 80;
			*(Bounds*)(nint)bounds3 = new Bounds(center2, size2);
			object obj13 = 1;
			object obj16 = default;
			while ((nint)obj13 < 4)
			{
				object obj14 = obj13 * 12;
				object obj15 = obj16 + obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S2_v41+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S2_v41+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
				_ = 0;
				Matrix4x4 matrix4x2 = (Matrix4x4)(vector + 288);
				Vector3 point2 = vector - -64;
				Vector3 vector3 = ((Matrix4x4*)matrix4x2)->MultiplyPoint3x4(point2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				_ = 0;
				Bounds bounds4 = (Bounds)(vector + 264);
				Vector3 point3 = vector + 48;
				((Bounds*)bounds4)->Encapsulate(point3);
				object obj17 = obj13 + 1;
				obj13 = obj17;
			}
			obj9 = vector + 264;
		}
		Bounds bounds5 = default;
		((Bounds*)(nint)bounds5)->m_Center = (Vector3)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S1_v13+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S1_v13+8]");
		_ = 0;
		return bounds5;
	}

	public void SetDirty()
	{
		if (drawCall != null)
		{
			UIDrawCall uIDrawCall = drawCall;
			uIDrawCall.isDirty = true;
		}
		else if (isVisible)
		{
			UIGeometry uIGeometry = geometry;
			bool flag;
			if (geometry != null)
			{
				BetterList<Vector3> verts = uIGeometry.verts;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v23 (BetterList`1<UnityEngine.Vector3>)+C]");
				flag = (nint)0 > (nint)0;
			}
			else
			{
				flag = false;
			}
			if (flag)
			{
				UIPanel uIPanel = CreatePanel();
			}
		}
	}

	public void RemoveFromPanel()
	{
		if (panel != null)
		{
			panel.RemoveWidget(this);
			panel = null;
		}
		drawCall = null;
	}

	public virtual void MarkAsChanged()
	{
		if (!NGUITools.GetActive(this))
		{
			return;
		}
		mChanged = true;
		if (panel != null && enabled)
		{
			GameObject go = gameObject;
			if (NGUITools.GetActive(go) && !mPlayMode)
			{
				SetDirty();
				CheckLayer();
			}
		}
	}

	public UIPanel CreatePanel()
	{
		//IL_012b: Expected I, but got Obj
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		if (~(mStarted ? 1u : 0u) == 0 && panel == null && enabled)
		{
			GameObject go = base.gameObject;
			if (NGUITools.GetActive(go))
			{
				Transform trans = cachedTransform;
				GameObject gameObject = cachedGameObject;
				int layer = gameObject.layer;
				UIPanel uIPanel = UIPanel.Find(trans, createIfMissing: true, layer);
				panel = uIPanel;
				if (panel != null)
				{
					mParentFound = false;
					panel.AddWidget(this);
					CheckLayer();
					nint num = (nint)this;
					object obj = this + 96;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ S2_v7 (Il2CppClass<UIWidget>)+11C] (should have been resolved before IL gen)");
				}
			}
		}
		return panel;
	}

	public void CheckLayer()
	{
		if (panel != null)
		{
			GameObject gameObject = panel.gameObject;
			int layer = gameObject.layer;
			GameObject gameObject2 = base.gameObject;
			int layer2 = gameObject2.layer;
			if (layer != layer2)
			{
				GameObject gameObject3 = base.gameObject;
				GameObject gameObject4 = panel.gameObject;
				int layer3 = gameObject4.layer;
				gameObject3.layer = layer3;
			}
		}
	}

	public override void ParentHasChanged()
	{
		base.ParentHasChanged();
		if (panel != null)
		{
			Transform trans = cachedTransform;
			GameObject gameObject = cachedGameObject;
			int layer = gameObject.layer;
			UIPanel uIPanel = UIPanel.Find(trans, createIfMissing: true, layer);
			if (panel != uIPanel)
			{
				RemoveFromPanel();
				UIPanel uIPanel2 = CreatePanel();
			}
		}
	}

	protected virtual void Awake()
	{
		GameObject gameObject = base.gameObject;
		mGo = gameObject;
		bool isPlaying = Application.isPlaying;
		mPlayMode = isPlaying;
	}

	protected unsafe override void OnInit()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00dc: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_0143: Invalid comparison between Obj and F4
		//IL_0094: Expected I, but got Obj
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_0170: Expected I, but got Obj
		//IL_0195: Expected F4, but got I
		//IL_0190: Expected native int or pointer, but got VT
		//IL_01a3: Expected F4, but got VT
		//IL_019e: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		base.OnInit();
		RemoveFromPanel();
		mMoved = true;
		if (mWidth == 100 && mHeight == 100)
		{
			Transform transform = cachedTransform;
			Vector3 localScale = transform.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			object obj2 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
			object obj3 = num2 * 0;
			object obj4 = obj2 + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			object obj5 = num3 * 0;
			object obj6 = obj4 + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)8f))
			{
				nint num4 = (nint)this;
				object obj7 = this + 288;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ S1_v21 (Il2CppClass<UIWidget>)+1DC] (should have been resolved before IL gen)");
				Transform transform2 = cachedTransform;
				nint num5 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v27 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v28 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
				transform2.localScale = vector;
			}
		}
		Update();
	}

	protected virtual void UpgradeFrom265()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004d: Expected F8, but got I4
		//IL_010c: Expected Obj, but got F8
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected I4, but got Unknown
		//IL_008c: Expected F8, but got I4
		//IL_0145: Expected Obj, but got F8
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Transform transform = cachedTransform;
		Vector3 localScale = transform.localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num2 = default;
		double num = Math.Abs(num2);
		if (!(num < 2147483648.0))
		{
			num2 = -2147483648.0;
		}
		object obj3 = num2 >> 31;
		double num3 = num2 + (double)obj3;
		int num4 = num3 ^ obj3;
		mWidth = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num6 = default;
		double num5 = Math.Abs(num6);
		if (!(num5 < 2147483648.0))
		{
			num6 = -2147483648.0;
		}
		object obj4 = num6 >> 31;
		double num7 = num6 + (double)obj4;
		int num8 = num7 ^ obj4;
		mHeight = num8;
		GameObject go = gameObject;
		NGUITools.UpdateWidgetCollider(go, considerInactive: true);
	}

	protected override void OnStart()
	{
		UIPanel uIPanel = CreatePanel();
	}

	protected unsafe override void OnAnchor()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0428: Invalid comparison between I and F4
		//IL_0c68: Expected F4, but got I
		//IL_0c7d: Invalid comparison between I and F4
		//IL_0d86: Expected F4, but got I
		//IL_0d9b: Invalid comparison between I and F4
		//IL_09fc: Expected F8, but got I4
		//IL_0a0f: Expected F8, but got I4
		//IL_0e80: Expected I, but got Obj
		//IL_0e92: Invalid comparison between Obj and F8
		//IL_108e: Expected I, but got Obj
		//IL_10a0: Invalid comparison between Obj and F8
		//IL_0f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4a: Expected Obj, but got Unknown
		//IL_0f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6c: Expected Obj, but got Unknown
		//IL_0fa3: Expected Obj, but got I
		//IL_0fc6: Invalid comparison between Obj and F4
		//IL_0afa: Expected I, but got Obj
		//IL_0fef: Invalid comparison between F8 and I4
		//IL_0b16: Expected I, but got Obj
		//IL_0bdb: Expected I4, but got F8
		//IL_0be5: Expected I4, but got F8
		//IL_0b59: Expected F4, but got I
		//IL_0b54: Expected native int or pointer, but got VT
		//IL_0b78: Expected F4, but got I
		//IL_0b73: Expected native int or pointer, but got VT
		//IL_0bbd: Invalid comparison between I4 and F8
		//IL_0af0: Expected F8, but got I4
		//IL_0aac: Expected F8, but got I4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Transform transform = cachedTransform;
		Transform transform2 = transform.parent;
		Vector3 localPosition = transform.localPosition;
		Vector2 vector2 = pivotOffset;
		AnchorPoint anchorPoint = bottomAnchor;
		AnchorPoint anchorPoint2 = leftAnchor;
		float num21;
		float num22;
		float num23;
		float num24;
		if (anchorPoint2.target == anchorPoint.target)
		{
			AnchorPoint anchorPoint3 = rightAnchor;
			AnchorPoint anchorPoint4 = leftAnchor;
			if (anchorPoint4.target == anchorPoint3.target)
			{
				AnchorPoint anchorPoint5 = topAnchor;
				AnchorPoint anchorPoint6 = leftAnchor;
				if (anchorPoint6.target == anchorPoint5.target)
				{
					Vector3[] sides = leftAnchor.GetSides(transform2);
					if (sides != null)
					{
						AnchorPoint anchorPoint7 = leftAnchor;
						float num = 1f - anchorPoint7.relative;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v285 (UnityEngine.Vector3[])+10]");
						float num2 = 0f * num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v285 (UnityEngine.Vector3[])+28]");
						float num3 = 0f * anchorPoint7.relative;
						float num4 = num2 + num3;
						AnchorPoint anchorPoint8 = leftAnchor;
						float num5 = num4 + (float)anchorPoint8.absolute;
						AnchorPoint anchorPoint9 = rightAnchor;
						float num6 = 1f - anchorPoint9.relative;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v285 (UnityEngine.Vector3[])+10]");
						float num7 = 0f * num6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v285 (UnityEngine.Vector3[])+28]");
						float num8 = 0f * anchorPoint9.relative;
						float num9 = num7 + num8;
						AnchorPoint anchorPoint10 = rightAnchor;
						float num10 = num9 + (float)anchorPoint10.absolute;
						AnchorPoint anchorPoint11 = bottomAnchor;
						float num11 = 1f - anchorPoint11.relative;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v285 (UnityEngine.Vector3[])+38]");
						float num12 = 0f * num11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v285 (UnityEngine.Vector3[])+20]");
						float num13 = 0f * anchorPoint11.relative;
						float num14 = num12 + num13;
						AnchorPoint anchorPoint12 = bottomAnchor;
						float num15 = num14 + (float)anchorPoint12.absolute;
						AnchorPoint anchorPoint13 = topAnchor;
						float num16 = 1f - anchorPoint13.relative;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v285 (UnityEngine.Vector3[])+38]");
						float num17 = 0f * num16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v285 (UnityEngine.Vector3[])+20]");
						float num18 = 0f * anchorPoint13.relative;
						float num19 = num17 + num18;
						AnchorPoint anchorPoint14 = topAnchor;
						float num20 = num19 + (float)anchorPoint14.absolute;
						mIsInFront = true;
						num21 = num15;
						num22 = num10;
						num23 = num5;
						num24 = num20;
					}
					else
					{
						Vector3 localPos = GetLocalPos(leftAnchor, transform2);
						AnchorPoint anchorPoint15 = leftAnchor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
						float num25 = 0f + (float)anchorPoint15.absolute;
						AnchorPoint anchorPoint16 = bottomAnchor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
						float num26 = 0f + (float)anchorPoint16.absolute;
						AnchorPoint anchorPoint17 = rightAnchor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
						float num27 = 0f + (float)anchorPoint17.absolute;
						AnchorPoint anchorPoint18 = topAnchor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
						float num28 = 0f + (float)anchorPoint18.absolute;
						bool flag = (byte)(~(hideIfOffScreen ? 1u : 0u)) != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
						bool flag2 = !(0f < 0f);
						bool flag3 = flag | flag2;
						mIsInFront = flag3;
						num21 = num26;
						num22 = num27;
						num23 = num25;
						num24 = num28;
					}
					goto IL_0c43;
				}
			}
		}
		mIsInFront = true;
		AnchorPoint anchorPoint19 = leftAnchor;
		float num33;
		if ((bool)anchorPoint19.target)
		{
			Vector3[] sides2 = leftAnchor.GetSides(transform2);
			if (sides2 != null)
			{
				AnchorPoint anchorPoint20 = leftAnchor;
				float num29 = 1f - anchorPoint20.relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v250 (UnityEngine.Vector3[])+10]");
				float num30 = 0f * num29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v250 (UnityEngine.Vector3[])+28]");
				float num31 = 0f * anchorPoint20.relative;
				float num32 = num30 + num31;
				AnchorPoint anchorPoint21 = leftAnchor;
				num33 = num32 + (float)anchorPoint21.absolute;
			}
			else
			{
				Vector3 localPos2 = GetLocalPos(leftAnchor, transform2);
				AnchorPoint anchorPoint22 = leftAnchor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				num33 = 0f + (float)anchorPoint22.absolute;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			float num34 = 0f * (float)mWidth;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			num33 = 0f - num34;
		}
		AnchorPoint anchorPoint23 = rightAnchor;
		float num39;
		if ((bool)anchorPoint23.target)
		{
			Vector3[] sides3 = rightAnchor.GetSides(transform2);
			if (sides3 != null)
			{
				AnchorPoint anchorPoint24 = rightAnchor;
				float num35 = 1f - anchorPoint24.relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v235 (UnityEngine.Vector3[])+10]");
				float num36 = 0f * num35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v235 (UnityEngine.Vector3[])+28]");
				float num37 = 0f * anchorPoint24.relative;
				float num38 = num36 + num37;
				AnchorPoint anchorPoint25 = rightAnchor;
				num39 = num38 + (float)anchorPoint25.absolute;
			}
			else
			{
				Vector3 localPos3 = GetLocalPos(rightAnchor, transform2);
				AnchorPoint anchorPoint26 = rightAnchor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				num39 = 0f + (float)anchorPoint26.absolute;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			float num40 = 0f * (float)mWidth;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			float num41 = 0f - num40;
			num39 = num41 + (float)mWidth;
		}
		AnchorPoint anchorPoint27 = bottomAnchor;
		float num46;
		if ((bool)anchorPoint27.target)
		{
			Vector3[] sides4 = bottomAnchor.GetSides(transform2);
			if (sides4 != null)
			{
				AnchorPoint anchorPoint28 = bottomAnchor;
				float num42 = 1f - anchorPoint28.relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v219 (UnityEngine.Vector3[])+38]");
				float num43 = 0f * num42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v219 (UnityEngine.Vector3[])+20]");
				float num44 = 0f * anchorPoint28.relative;
				float num45 = num43 + num44;
				AnchorPoint anchorPoint29 = bottomAnchor;
				num46 = num45 + (float)anchorPoint29.absolute;
			}
			else
			{
				Vector3 localPos4 = GetLocalPos(bottomAnchor, transform2);
				AnchorPoint anchorPoint30 = bottomAnchor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				num46 = 0f + (float)anchorPoint30.absolute;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			float num47 = 0f * (float)mHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			num46 = 0f - num47;
		}
		AnchorPoint anchorPoint31 = topAnchor;
		if ((bool)anchorPoint31.target)
		{
			Vector3[] sides5 = topAnchor.GetSides(transform2);
			if (sides5 != null)
			{
				AnchorPoint anchorPoint32 = topAnchor;
				float num48 = 1f - anchorPoint32.relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S0_v204 (UnityEngine.Vector3[])+38]");
				float num49 = 0f * num48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S0_v204 (UnityEngine.Vector3[])+20]");
				float num50 = 0f * anchorPoint32.relative;
				float num51 = num49 + num50;
				AnchorPoint anchorPoint33 = topAnchor;
				float num52 = num51 + (float)anchorPoint33.absolute;
				num21 = num46;
				num22 = num39;
				num23 = num33;
				num24 = num52;
			}
			else
			{
				Vector3 localPos5 = GetLocalPos(topAnchor, transform2);
				AnchorPoint anchorPoint34 = topAnchor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				float num53 = 0f + (float)anchorPoint34.absolute;
				num21 = num46;
				num22 = num39;
				num23 = num33;
				num24 = num53;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			float num54 = 0f * (float)mHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			float num55 = 0f - num54;
			float num56 = num55 + (float)mHeight;
			num21 = num46;
			num22 = num39;
			num23 = num33;
			num24 = num56;
		}
		goto IL_0c43;
		IL_0c43:
		float num57 = num22 - num23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		float num58 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		bool flag4 = 0f < 0f;
		float num59 = 0f;
		if (!flag4)
		{
			num59 = num58;
		}
		float num60 = num57 * num59;
		float num61 = num23 + num60;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num62 = num24 - num21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		float num63 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		bool flag5 = 0f < 0f;
		float num64 = 0f;
		if (!flag5)
		{
			num64 = num63;
		}
		float num65 = num62 * num64;
		float num66 = num21 + num65;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num67 = num22 - num23;
		double num68 = (double)num67 + 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num69 = Math.Abs(num68);
		if (!(num69 < 2147483648.0))
		{
			num68 = -2147483648.0;
		}
		float num70 = num24 - num21;
		double num71 = (double)num70 + 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num72 = Math.Abs(num71);
		if (!(num72 < 2147483648.0))
		{
			num71 = -2147483648.0;
		}
		bool flag6 = keepAspectRatio == AspectRatioSource.Free;
		double num73 = num68;
		double num74 = num71;
		if (!flag6)
		{
			bool flag7 = aspectRatio == 0f;
			num73 = num68;
			num74 = num71;
			if (!flag7)
			{
				if (keepAspectRatio == AspectRatioSource.BasedOnHeight)
				{
					double num75 = num71 * (double)aspectRatio;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num77 = default;
					double num76 = Math.Abs(num77);
					if (!(num76 < 2147483648.0))
					{
						num77 = -2147483648.0;
					}
					num73 = num77;
					num74 = num71;
				}
				else
				{
					double num78 = num68 / (double)aspectRatio;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num80 = default;
					double num79 = Math.Abs(num80);
					if (!(num79 < 2147483648.0))
					{
						num80 = -2147483648.0;
					}
					num73 = num68;
					num74 = num80;
				}
			}
		}
		nint num81 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v626 @ S1_v27 (Il2CppClass<UIWidget>)+1AC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num73))
		{
			nint num82 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v641 @ S1_v71 (Il2CppClass<UIWidget>)+1AC] (should have been resolved before IL gen)");
			double num83 = default;
			num73 = num83;
		}
		nint num84 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v654 @ S1_v32 (Il2CppClass<UIWidget>)+1B4] (should have been resolved before IL gen)");
		object obj3 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num74))
		{
			nint num85 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v673 @ S1_v68 (Il2CppClass<UIWidget>)+1B4] (should have been resolved before IL gen)");
			double num86 = default;
			num74 = num86;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		object obj5 = default;
		object obj4 = 0 - obj5;
		object obj6 = obj4 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		object obj8 = default;
		object obj7 = 0 - obj8;
		object obj9 = obj7 * obj7;
		object obj10 = obj6 + obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		nint num87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		object obj11 = num87 - 0;
		object obj12 = obj11 * obj11;
		object obj13 = obj10 + obj12;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f))
		{
			Transform transform3 = cachedTransform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			transform3.localPosition = vector;
			if (~(mIsInFront ? 1u : 0u) == 0)
			{
				mChanged = true;
			}
		}
		if (num73 != (double)mWidth || (double)mHeight != num74)
		{
			mHeight = (int)num74;
			mWidth = (int)num73;
			if (~(mIsInFront ? 1u : 0u) == 0)
			{
				mChanged = true;
			}
			if (~(autoResizeBoxCollider ? 1u : 0u) == 0)
			{
				ResizeCollider();
			}
		}
	}

	protected override void OnUpdate()
	{
		if (panel == null)
		{
			UIPanel uIPanel = CreatePanel();
		}
	}

	private void OnApplicationPause(bool paused)
	{
		//IL_0029: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		if (!paused)
		{
			nint num = (nint)this;
			object obj = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<UIWidget>)+1CC] (should have been resolved before IL gen)");
		}
	}

	protected override void OnDisable()
	{
		RemoveFromPanel();
		base.OnDisable();
	}

	private void OnDestroy()
	{
		RemoveFromPanel();
	}

	public bool UpdateVisibility(bool visibleByAlpha, bool visibleByPanel)
	{
		bool result;
		if (visibleByAlpha == mIsVisibleByAlpha)
		{
			bool flag = mIsVisibleByPanel == visibleByPanel;
			result = false;
			if (flag)
			{
				goto IL_007d;
			}
		}
		mIsVisibleByPanel = visibleByPanel;
		mIsVisibleByAlpha = visibleByAlpha;
		mChanged = true;
		result = true;
		goto IL_007d;
		IL_007d:
		return result;
	}

	public unsafe bool UpdateTransform(int frame)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected VT, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected VT, but got Unknown
		//IL_0169: Expected Ref, but got VT
		//IL_01ab: Expected VT, but got I
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected VT, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected VT, but got Unknown
		//IL_0224: Expected Ref, but got VT
		//IL_0266: Expected VT, but got I
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected VT, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected VT, but got Unknown
		//IL_03c3: Expected Ref, but got VT
		//IL_0408: Expected F4, but got I
		//IL_0403: Expected native int or pointer, but got VT
		//IL_042a: Expected F4, but got I
		//IL_0425: Expected native int or pointer, but got VT
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected VT, but got Unknown
		//IL_0447: Expected Ref, but got VT
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_0491: Expected Obj, but got I
		//IL_04c8: Expected Obj, but got I
		//IL_04eb: Invalid comparison between Obj and F4
		//IL_05e1: Expected VT, but got I
		//IL_060d: Expected VT, but got I
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0556: Expected Obj, but got I
		//IL_058d: Expected Obj, but got I
		//IL_05b0: Invalid comparison between Obj and F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 176);
		Transform transform = cachedTransform;
		bool isPlaying = Application.isPlaying;
		mPlayMode = isPlaying;
		if (~(mMoved ? 1u : 0u) == 0)
		{
			mMatrixFrame = -1;
			mMoved = true;
			transform.hasChanged = false;
			Vector2 vector2 = pivotOffset;
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			float num2 = num - 0f;
			float num3 = num2 * (float)mWidth;
			float x = num3 + (float)mWidth;
			float num4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
			float num5 = num4 - 0f;
			float num6 = num5 * (float)mHeight;
			float y = num6 + (float)mHeight;
			Vector3 vector3 = transform.TransformPoint(num3, num6, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			Matrix4x4 matrix4x = (Matrix4x4)(panel + 104);
			Vector3 point = vector + 48;
			Vector3 vector4 = ((Matrix4x4*)matrix4x)->MultiplyPoint3x4(point);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			mOldV0 = (Vector3)0;
			Vector3 vector5 = transform.TransformPoint(x, y, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Matrix4x4 matrix4x2 = (Matrix4x4)(panel + 104);
			Vector3 point2 = vector + 32;
			Vector3 vector6 = ((Matrix4x4*)matrix4x2)->MultiplyPoint3x4(point2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			mOldV1 = (Vector3)0;
		}
		else
		{
			UIPanel uIPanel = panel;
			if (!uIPanel.widgetsAreStatic && transform.hasChanged)
			{
				mMatrixFrame = -1;
				transform.hasChanged = false;
				Vector2 vector7 = pivotOffset;
				float num7 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				float num8 = num7 - 0f;
				float num9 = num8 * (float)mWidth;
				float x2 = num9 + (float)mWidth;
				float num10 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
				float num11 = num10 - 0f;
				float num12 = num11 * (float)mHeight;
				float y2 = num12 + (float)mHeight;
				Vector3 vector8 = transform.TransformPoint(num9, num12, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				_ = 0;
				Matrix4x4 matrix4x3 = (Matrix4x4)(panel + 104);
				Vector3 point3 = vector + 16;
				Vector3 vector9 = ((Matrix4x4*)matrix4x3)->MultiplyPoint3x4(point3);
				Vector3 vector10 = transform.TransformPoint(x2, y2, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				((Vector3*)(nint)vector)->x = 0f;
				Matrix4x4 matrix4x4 = (Matrix4x4)(panel + 104);
				Vector3 vector11 = ((Matrix4x4*)matrix4x4)->MultiplyPoint3x4(vector);
				Vector3 vector12 = mOldV0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				object obj2 = vector12 - 0;
				object obj3 = obj2 * obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+104]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
				object obj4 = num13 - 0;
				object obj5 = obj4 * obj4;
				object obj6 = obj3 + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+108]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				object obj7 = num14 - 0;
				object obj8 = obj7 * obj7;
				object obj9 = obj6 + obj8;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1E-06f))
				{
					Vector3 vector13 = mOldV1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
					object obj10 = vector13 - 0;
					object obj11 = obj10 * obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+110]");
					nint num15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
					object obj12 = num15 - 0;
					object obj13 = obj12 * obj12;
					object obj14 = obj11 + obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIWidget)+114]");
					nint num16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
					object obj15 = num16 - 0;
					object obj16 = obj15 * obj15;
					object obj17 = obj14 + obj16;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1E-06f))
					{
						goto IL_06ad;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				mOldV1 = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				mOldV0 = (Vector3)0;
				mMoved = true;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
				_ = 0;
			}
		}
		goto IL_06ad;
		IL_068c:
		bool flag = mChanged;
		bool result = flag;
		goto IL_06c6;
		IL_06c6:
		return result;
		IL_06ad:
		if (~(mMoved ? 1u : 0u) != 0)
		{
			goto IL_068c;
		}
		OnDimensionsChanged onDimensionsChanged = onChange;
		bool flag2 = onChange == null;
		result = true;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v147.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			result = true;
			if (!mMoved)
			{
				goto IL_068c;
			}
		}
		goto IL_06c6;
	}

	public bool UpdateGeometry(int frame)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0526: Expected I, but got Obj
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_0633: Expected Obj, but got I4
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0087: Expected I, but got Obj
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected Obj, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected Obj, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected Obj, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected VT, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected VT, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Obj, but got Unknown
		//IL_0129: Expected I, but got Obj
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected Obj, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected VT, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected VT, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected VT, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 704;
		nint num = (nint)this;
		object obj3 = this + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S2_v2 (Il2CppClass<UIWidget>)+114] (should have been resolved before IL gen)");
		float num2 = default;
		if (~(mIsVisibleByAlpha ? 1u : 0u) == 0 && mLastAlpha != num2)
		{
			mChanged = true;
		}
		mLastAlpha = num2;
		bool result;
		object obj21;
		if (~(mChanged ? 1u : 0u) == 0)
		{
			if (~(mIsVisibleByAlpha ? 1u : 0u) == 0 && num2 > 0.001f)
			{
				nint num3 = (nint)this;
				object obj4 = this + 224;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S1_v53 (Il2CppClass<UIWidget>)+19C] (should have been resolved before IL gen)");
				UnityEngine.Object obj5 = default;
				if (obj5 != null)
				{
					UIGeometry uIGeometry = geometry;
					BetterList<Vector3> verts = uIGeometry.verts;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v96 (BetterList`1<UnityEngine.Vector3>)+C]");
					bool flag = (nint)0 > (nint)0;
					if (~(fillGeometry ? 1u : 0u) == 0)
					{
						geometry.Clear();
						UIGeometry uIGeometry2 = geometry;
						nint num4 = (nint)this;
						object obj6 = this + 304;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v253 @ S4_v5 (Il2CppClass<UIWidget>)+1EC] (should have been resolved before IL gen)");
					}
					UIGeometry uIGeometry3 = geometry;
					BetterList<Vector3> verts2 = uIGeometry3.verts;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v104 (BetterList`1<UnityEngine.Vector3>)+C]");
					bool flag2 = (nint)0 <= (nint)0;
					result = flag;
					if (!flag2)
					{
						if (frame != mMatrixFrame)
						{
							object obj7 = obj + 640;
							object obj8 = panel + 104;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							Transform transform = cachedTransform;
							Matrix4x4 localToWorldMatrix = transform.localToWorldMatrix;
							object obj9 = obj + 448;
							object obj10 = obj + 576;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							object obj11 = obj + 320;
							object obj12 = obj + 640;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							object obj13 = obj + 256;
							object obj14 = obj + 448;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							Matrix4x4 matrix4x = (Matrix4x4)(obj + 320);
							Matrix4x4 matrix4x2 = (Matrix4x4)(obj + 256);
							Matrix4x4 matrix4x3 = matrix4x * matrix4x2;
							object obj15 = obj + 576;
							object obj16 = obj + 512;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							object obj17 = this + 164;
							object obj18 = obj + 576;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							mMatrixFrame = frame;
						}
						UIPanel uIPanel = panel;
						object obj19 = obj + 192;
						object obj20 = this + 164;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
						Matrix4x4 widgetToPanel = (Matrix4x4)(obj + 192);
						geometry.ApplyTransform(widgetToPanel, uIPanel.generateNormals);
						obj21 = this + 236;
						result = true;
						goto IL_062a;
					}
					goto IL_0688;
				}
			}
			UIGeometry uIGeometry4 = geometry;
			BetterList<Vector3> verts3 = uIGeometry4.verts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v73 (BetterList`1<UnityEngine.Vector3>)+C]");
			if ((nint)0 > (nint)0)
			{
				if (~(fillGeometry ? 1u : 0u) == 0)
				{
					geometry.Clear();
				}
				obj21 = this + 236;
				result = true;
				goto IL_062a;
			}
		}
		else if (~(mMoved ? 1u : 0u) == 0)
		{
			UIGeometry uIGeometry5 = geometry;
			BetterList<Vector3> verts4 = uIGeometry5.verts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v31 (BetterList`1<UnityEngine.Vector3>)+C]");
			if ((nint)0 > (nint)0)
			{
				if (frame != mMatrixFrame)
				{
					object obj22 = obj + 640;
					object obj23 = panel + 104;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
					Transform transform2 = cachedTransform;
					Matrix4x4 localToWorldMatrix2 = transform2.localToWorldMatrix;
					object obj24 = obj + 384;
					object obj25 = obj + 576;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
					object obj26 = obj + 128;
					object obj27 = obj + 640;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
					object obj28 = obj - -64;
					object obj29 = obj + 384;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
					Matrix4x4 matrix4x4 = (Matrix4x4)(obj + 128);
					Matrix4x4 matrix4x5 = (Matrix4x4)(obj - -64);
					Matrix4x4 matrix4x6 = matrix4x4 * matrix4x5;
					object obj30 = obj + 576;
					object obj31 = obj + 512;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
					object obj32 = this + 164;
					object obj33 = obj + 576;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
					mMatrixFrame = frame;
				}
				UIPanel uIPanel2 = panel;
				object obj34 = this + 164;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
				Matrix4x4 widgetToPanel2 = default;
				geometry.ApplyTransform(widgetToPanel2, uIPanel2.generateNormals);
				obj21 = this + 236;
				result = true;
				goto IL_062a;
			}
		}
		obj21 = this + 236;
		result = false;
		goto IL_062a;
		IL_062a:
		obj21 = 0;
		goto IL_0688;
		IL_0688:
		mChanged = false;
		return result;
	}

	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
		geometry.WriteToBuffers(v, u, c, n, t);
	}

	public unsafe virtual void MakePixelPerfect()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected VT, but got Unknown
		//IL_00da: Expected native int or pointer, but got VT
		//IL_00f0: Invalid comparison between I and F4
		//IL_0142: Invalid comparison between I and F4
		//IL_017c: Expected F4, but got I
		//IL_0177: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Transform transform = cachedTransform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Transform transform2 = cachedTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Vector3 localPosition2 = vector + 16;
		transform2.localPosition = localPosition2;
		Transform transform3 = cachedTransform;
		Vector3 localScale = transform3.localScale;
		Transform transform4 = cachedTransform;
		_ = 1065353216;
		((Vector3*)(nint)vector)->z = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		bool flag = !(0f < 0f);
		float num = 1f;
		if (!flag)
		{
			num = -1f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		bool flag2 = !(0f < 0f);
		float num2 = 1f;
		if (!flag2)
		{
			num2 = -1f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		transform4.localScale = vector;
	}

	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	public UIWidget()
	{
		//IL_004b: Expected I4, but got I8
		//IL_005a: Expected VT, but got I8
		//IL_00a2: Expected VT, but got I4
		_ = 4575657222473777152L;
		UIGeometry uIGeometry = default;
		uIGeometry._002Ector();
		geometry = uIGeometry;
		mIsInFront = true;
		mIsVisibleByAlpha = true;
		_ = 4575657222473777152L;
		mDrawRegion = (Vector4)0;
		fillGeometry = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Vector3[] array = default;
		mCorners = array;
		mAlphaFrameID = -1;
		base._002Ector();
	}
}
