using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIPanel : UIRect
{
	public enum RenderQueue
	{
		Automatic,
		StartAt,
		Explicit
	}

	public delegate void OnGeometryUpdated();

	public delegate void OnClippingMoved(UIPanel panel);

	public delegate void UIPanelEvent(Vector3 offset);

	public static List<UIPanel> list;

	public OnGeometryUpdated onGeometryUpdated;

	public bool showInPanelTool = true;

	public bool generateNormals;

	public bool widgetsAreStatic;

	public bool cullWhileDragging = true;

	public bool alwaysOnScreen;

	public bool anchorOffset;

	public bool softBorderPadding = true;

	public RenderQueue renderQueue;

	public int startingRenderQueue = 3000;

	[NonSerialized]
	public List<UIWidget> widgets;

	[NonSerialized]
	public List<UIDrawCall> drawCalls;

	[NonSerialized]
	public Matrix4x4 worldToLocal;

	[NonSerialized]
	public Vector4 drawCallClipRange;

	public OnClippingMoved onClipMove;

	private Texture2D mClipTexture;

	private float mAlpha;

	private UIDrawCall.Clipping mClipping;

	private Vector4 mClipRange;

	private Vector2 mClipSoftness;

	private int mDepth;

	private int mSortingOrder;

	private bool mRebuild;

	private bool mResized;

	private Vector2 mClipOffset;

	private int mMatrixFrame;

	private int mAlphaFrameID;

	private int mLayer;

	private static float[] mTemp;

	private Vector2 mMin;

	private Vector2 mMax;

	private bool mHalfPixelOffset;

	private bool mSortWidgets;

	private bool mUpdateScroll;

	private UIPanel mParentPanel;

	private static Vector3[] mCorners;

	private static int mUpdateFrame;

	private UIDrawCall.OnRenderCallback mOnRender;

	private bool mForced;

	private static Comparison<UIPanel> _003C_003Ef__mg_0024cache0;

	private static Comparison<UIPanel> _003C_003Ef__mg_0024cache1;

	private static Comparison<UIWidget> _003C_003Ef__mg_0024cache2;

	private UIPanelEvent m_onConstrainedTargetToBounds;

	public static int nextUnusedDepth
	{
		get
		{
			List<UIPanel> list = UIPanel.list;
			int num = 0;
			int num2 = int.MinValue;
			while (num < list._size)
			{
				UIPanel uIPanel = UIPanel.list.get_Item(num);
				bool flag = num2 > uIPanel.mDepth;
				int num3 = num2;
				if (!flag)
				{
					num3 = uIPanel.mDepth;
				}
				int num4 = num + 1;
				num = num4;
				num2 = num3;
			}
			int result = num2 + 1;
			if (num2 == int.MinValue)
			{
				result = 0;
			}
			return result;
		}
	}

	public override bool canBeAnchored => mClipping != UIDrawCall.Clipping.None;

	public override float alpha
	{
		get
		{
			return mAlpha;
		}
		set
		{
			float num = Math.Min(value, 1f);
			bool flag = value < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			if (num2 != mAlpha)
			{
				mResized = true;
				mAlphaFrameID = -1;
				mAlpha = num2;
				SetDirty();
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
			if (value != mDepth)
			{
				mDepth = value;
				throw new ArgumentException();
			}
		}
	}

	public int sortingOrder
	{
		get
		{
			return mSortingOrder;
		}
		set
		{
			if (value != mSortingOrder)
			{
				mSortingOrder = value;
				UpdateDrawCalls();
			}
		}
	}

	public float width
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0025: Expected F4, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			Vector2 viewSize = GetViewSize();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			return 0f;
		}
	}

	public float height
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0025: Expected F4, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			Vector2 viewSize = GetViewSize();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			return 0f;
		}
	}

	public bool halfPixelOffset => mHalfPixelOffset;

	public bool usedForUI
	{
		get
		{
			Camera camera = anchorCamera;
			if (camera != null)
			{
				return mCam.orthographic;
			}
			return false;
		}
	}

	public unsafe Vector3 drawCallOffset
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_02bc: Expected I, but got Obj
			//IL_02da: Expected F4, but got VT
			//IL_02d5: Expected native int or pointer, but got VT
			//IL_02ef: Expected F4, but got I
			//IL_02ea: Expected native int or pointer, but got VT
			//IL_0105: Expected F8, but got I4
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected Obj, but got Unknown
			//IL_0151: Expected F8, but got I4
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Expected Obj, but got Unknown
			//IL_0302: Expected native int or pointer, but got VT
			//IL_028e: Expected native int or pointer, but got VT
			//IL_032d: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Camera camera = anchorCamera;
			Vector3 vector = default;
			if (camera != null && mCam.orthographic)
			{
				Vector2 windowSize = GetWindowSize();
				UIRoot uIRoot = root;
				bool flag = uIRoot != null;
				bool flag2 = !flag;
				float num = 1f;
				if (!flag2)
				{
					UIRoot uIRoot2 = root;
					float pixelSizeAdjustment = uIRoot2.pixelSizeAdjustment;
					num = pixelSizeAdjustment;
				}
				float orthographicSize = mCam.orthographicSize;
				bool flag3 = (byte)(~(mHalfPixelOffset ? 1u : 0u)) != 0;
				bool flag4 = mHalfPixelOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num3 = default;
				double num2 = Math.Abs(num3);
				if (!(num2 < 2147483648.0))
				{
					num3 = -2147483648.0;
				}
				object obj3 = num3 & 1;
				bool flag5 = flag3;
				if (obj3 == null)
				{
					flag5 = flag4;
				}
				float num4 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				float num5 = num4 / 0f;
				float num6 = num5 / orthographicSize;
				bool flag6 = mHalfPixelOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num8 = default;
				double num7 = Math.Abs(num8);
				if (!(num7 < 2147483648.0))
				{
					num8 = -2147483648.0;
				}
				object obj4 = num8 & 1;
				if (obj4 == null)
				{
					flag3 = flag6;
				}
				((Vector3*)(nint)vector)->z = 0f;
				float x = 0f - num6;
				if (!flag5)
				{
					x = 0f;
				}
				((Vector3*)(nint)vector)->x = x;
				float y = num6;
				if (!flag3)
				{
					y = 0f;
				}
				((Vector3*)(nint)vector)->y = y;
			}
			else
			{
				nint num9 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v10 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num10 = 0;
				((Vector3*)(nint)vector)->x = (float)Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v11 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				((Vector3*)(nint)vector)->z = 0f;
			}
			return vector;
		}
	}

	public UIDrawCall.Clipping clipping
	{
		get
		{
			return mClipping;
		}
		set
		{
			if (value != mClipping)
			{
				mMatrixFrame = -1;
				mClipping = value;
				mResized = true;
			}
		}
	}

	public UIPanel parentPanel => mParentPanel;

	public int clipCount
	{
		get
		{
			//IL_0018: Expected Obj, but got I4
			int num = 0;
			UIPanel uIPanel = default;
			while (mParentPanel != null)
			{
				object obj = uIPanel.mClipping - 1;
				if (uIPanel.mClipping == UIDrawCall.Clipping.TextureMask || ((nint)obj != 1 && (nint)obj == 2))
				{
					int num2 = num + 1;
					num = num2;
				}
				uIPanel = mParentPanel;
			}
			return num;
		}
	}

	public bool hasClipping
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = mClipping & (UIDrawCall.Clipping)(-3);
			return (nint)obj == 1;
		}
	}

	public bool hasCumulativeClipping
	{
		get
		{
			int num = clipCount;
			return num != 0;
		}
	}

	public bool clipsChildren => hasCumulativeClipping;

	public unsafe Vector2 clipOffset
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			Vector2 vector = default;
			((Vector2*)(nint)vector)->x = (float)mClipOffset;
			return vector;
		}
		set
		{
			//IL_00b6: Expected VT, but got F4
			float value2 = (float)mClipOffset - value.x;
			float num = Math.Abs(value2);
			if (!(num > 0.001f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+F0]");
				float value3 = 0f - value.y;
				float num2 = Math.Abs(value3);
				if (!(num2 > 0.001f))
				{
					return;
				}
			}
			mClipOffset = (Vector2)value.x;
			InvalidateClipping();
			OnClippingMoved onClippingMoved = onClipMove;
			if (onClipMove != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v29.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public Texture2D clipTexture
	{
		get
		{
			return mClipTexture;
		}
		set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			if (mClipTexture != value)
			{
				object obj = this + 188;
				obj = value;
			}
		}
	}

	public unsafe Vector4 clipRange
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector4 vector = default;
			((Vector4*)(nint)vector)->x = (float)mClipRange;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIPanel)+D0]");
			((Vector4*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_001b: Expected native int or pointer, but got VT
			//IL_002d: Expected native int or pointer, but got VT
			object obj = default;
			Vector4 vector = (Vector4)(obj - 16);
			((Vector4*)(nint)vector)->z = value.z;
			((Vector4*)(nint)vector)->x = value.x;
			baseClipRegion = vector;
		}
	}

	public unsafe Vector4 baseClipRegion
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector4 vector = default;
			((Vector4*)(nint)vector)->x = (float)mClipRange;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIPanel)+D0]");
			((Vector4*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_0106: Expected VT, but got F4
			float value2 = (float)mClipRange - value.x;
			float num = Math.Abs(value2);
			if (!(num > 0.001f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+CC]");
				float value3 = 0f - value.y;
				float num2 = Math.Abs(value3);
				if (!(num2 > 0.001f))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D0]");
					float value4 = 0f - value.z;
					float num3 = Math.Abs(value4);
					if (!(num3 > 0.001f))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D4]");
						float value5 = 0f - value.w;
						float num4 = Math.Abs(value5);
						if (!(num4 > 0.001f))
						{
							return;
						}
					}
				}
			}
			mResized = true;
			_ = value.z;
			mClipRange = (Vector4)value.x;
			mMatrixFrame = -1;
			UIScrollView component = GetComponent<UIScrollView>();
			if (component != null)
			{
				component.UpdatePosition();
			}
			OnClippingMoved onClippingMoved = onClipMove;
			if (onClipMove != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v74.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe Vector4 finalClipRegion
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0091: Expected F4, but got I
			//IL_008c: Expected native int or pointer, but got VT
			//IL_00a6: Expected F4, but got I
			//IL_00a1: Expected native int or pointer, but got VT
			//IL_00ae: Expected native int or pointer, but got VT
			//IL_00bb: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Vector2 viewSize = GetViewSize();
			float x = default;
			float y;
			if (mClipping != UIDrawCall.Clipping.None)
			{
				x = (float)mClipRange + (float)mClipOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIPanel)+CC]");
				float num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIPanel)+F0]");
				y = num + 0f;
			}
			else
			{
				y = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			Vector4 vector = default;
			((Vector4*)(nint)vector)->w = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((Vector4*)(nint)vector)->z = 0f;
			((Vector4*)(nint)vector)->y = y;
			((Vector4*)(nint)vector)->x = x;
			return vector;
		}
	}

	public unsafe Vector2 clipSoftness
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			Vector2 vector = default;
			((Vector2*)(nint)vector)->x = (float)mClipSoftness;
			return vector;
		}
		set
		{
			//IL_0038: Expected Obj, but got F4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			//IL_00ab: Expected VT, but got F4
			float num = (float)mClipSoftness - value.x;
			float num2 = num * num;
			object obj = value.x >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+DC]");
			object obj2 = 0 - obj;
			object obj3 = obj2 * obj2;
			float num3 = num2 + (float)obj3;
			if (!(num3 < 9.9999994E-11f))
			{
				mClipSoftness = (Vector2)value.x;
			}
		}
	}

	public override Vector3[] localCorners
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_019a: Expected Obj, but got VT
			//IL_01f5: Expected Obj, but got I
			//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c1: Expected Obj, but got Unknown
			//IL_0018: Expected I, but got Obj
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			//IL_0040: Expected Obj, but got I4
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected Obj, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected VT, but got Unknown
			//IL_00ea: Expected Obj, but got I
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected Obj, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 208;
			Vector3[] result;
			if (mClipping == UIDrawCall.Clipping.None)
			{
				nint num = (nint)this;
				object obj3 = this + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v65 (Il2CppClass<UIPanel>)+10C] (should have been resolved before IL gen)");
				Transform transform = cachedTransform;
				object obj4 = 0;
				Vector3[] array = default;
				while (true)
				{
					bool flag = (nint)obj4 >= 4;
					result = array;
					if (flag)
					{
						break;
					}
					object obj5 = obj4 * 12;
					object obj6 = (object)array + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v72+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v72+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
					_ = 0;
					Vector3 position = (Vector3)(obj + 16);
					Vector3 vector = transform.InverseTransformPoint(position);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
					obj = 0;
					object obj7 = obj4 * 12;
					object obj8 = (object)array + obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					object obj9 = obj4 + 1;
					obj4 = obj9;
				}
			}
			else
			{
				object obj10 = mClipOffset + mClipRange;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D0]");
				float num2 = 0f * 0.5f;
				float num3 = (float)obj10 - num2;
				float num4 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D0]");
				float num5 = num4 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+F0]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+CC]");
				object obj11 = num6 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D4]");
				float num7 = 0f * 0.5f;
				float num8 = (float)obj11 - num7;
				float num9 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D4]");
				float num10 = num9 + 0f;
				Vector3[] array2 = mCorners;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Vector3[] array3 = mCorners;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				_ = 0;
				object obj12 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v36+8]");
				_ = 0;
				Vector3[] array4 = mCorners;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				_ = 0;
				Vector3[] array5 = mCorners;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				result = mCorners;
			}
			return result;
		}
	}

	public override Vector3[] worldCorners
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got VT
			//IL_007f: Expected Obj, but got I
			//IL_048c: Expected Obj, but got I
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Expected Obj, but got Unknown
			//IL_056f: Expected Obj, but got I4
			//IL_057d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0582: Expected Obj, but got Unknown
			//IL_0599: Unknown result type (might be due to invalid IL or missing references)
			//IL_059e: Expected Obj, but got Unknown
			//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b3: Expected Obj, but got Unknown
			//IL_05d0: Expected Obj, but got I
			//IL_05ed: Expected Obj, but got I
			//IL_0608: Unknown result type (might be due to invalid IL or missing references)
			//IL_060d: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 272;
			if (mClipping != UIDrawCall.Clipping.None)
			{
				object obj3 = mClipOffset + mClipRange;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D0]");
				float num = 0f * 0.5f;
				float num2 = (float)obj3 - num;
				float num3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D0]");
				float x = num3 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+F0]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+CC]");
				object obj4 = num4 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D4]");
				float num5 = 0f * 0.5f;
				float num6 = (float)obj4 - num5;
				float num7 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D4]");
				float y = num7 + 0f;
				Transform transform = cachedTransform;
				Vector3[] array = mCorners;
				Vector3 vector = transform.TransformPoint(num2, num6, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
				_ = 0;
				Vector3[] array2 = mCorners;
				Vector3 vector2 = transform.TransformPoint(num2, y, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
				_ = 0;
				Vector3[] array3 = mCorners;
				Vector3 vector3 = transform.TransformPoint(x, y, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Vector3[] array4 = mCorners;
				Vector3 vector4 = transform.TransformPoint(x, num6, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
				_ = 0;
				object obj5 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S1_v141+8]");
				_ = 0;
			}
			else
			{
				Camera camera = anchorCamera;
				if (camera != null)
				{
					float num8 = cameraRayDistance;
					return NGUITools.GetWorldCorners(mCam, num8);
				}
				Vector2 viewSize = GetViewSize();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
				float num9 = 0f * -0.5f;
				float num10 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
				float num11 = num10 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+104]");
				float num12 = 0f * -0.5f;
				float num13 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+104]");
				float num14 = num13 + 0f;
				Vector3[] array5 = mCorners;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				_ = 0;
				Vector3[] array6 = mCorners;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				Vector3[] array7 = mCorners;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Vector3[] array8 = mCorners;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				if (~(anchorOffset ? 1u : 0u) == 0)
				{
					if (!(mCam == null))
					{
						Transform transform2 = mCam.transform;
						Transform transform3 = transform2.parent;
						Transform transform4 = cachedTransform;
						if (!(transform3 != transform4))
						{
							goto IL_0639;
						}
					}
					Transform transform5 = cachedTransform;
					Vector3 position = transform5.position;
					object obj6 = 0;
					while ((nint)obj6 < 4)
					{
						object obj7 = obj6 * 12;
						object obj8 = (object)mCorners + obj7;
						object obj9 = obj8 + 16;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
						object obj11 = obj10 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v112+4]");
						nint num15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+104]");
						object obj12 = num15 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v112+8]");
						nint num16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
						object obj13 = num16 + 0;
						obj9 = obj11;
						object obj14 = obj6 + 1;
						obj6 = obj14;
					}
				}
			}
			goto IL_0639;
			IL_0639:
			return mCorners;
		}
	}

	public event UIPanelEvent onConstrainedTargetToBounds
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 288;
			Delegate obj2 = this.m_onConstrainedTargetToBounds;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 288;
			Delegate obj2 = this.m_onConstrainedTargetToBounds;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public static int CompareFunc(UIPanel a, UIPanel b)
	{
		bool flag = a != b;
		bool flag2 = !flag;
		int result = 0;
		if (!flag2)
		{
			bool flag3 = a != null;
			bool flag4 = !flag3;
			result = 0;
			if (!flag4)
			{
				bool flag5 = b != null;
				bool flag6 = !flag5;
				result = 0;
				if (!flag6)
				{
					bool flag7 = a.mDepth < b.mDepth;
					result = -1;
					if (!flag7)
					{
						bool flag8 = a.mDepth > b.mDepth;
						result = 1;
						if (!flag8)
						{
							int instanceID = a.GetInstanceID();
							int instanceID2 = b.GetInstanceID();
							bool flag9 = instanceID < instanceID2;
							int result2 = -1;
							if (!flag9)
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

	private void InvalidateClipping()
	{
		mMatrixFrame = -1;
		mResized = true;
		List<UIPanel> list = UIPanel.list;
		int num = 0;
		while (num < list._size)
		{
			UIPanel uIPanel = UIPanel.list.get_Item(num);
			if (uIPanel != this && uIPanel.mParentPanel == this)
			{
				uIPanel.InvalidateClipping();
			}
			int num2 = num + 1;
			num = num2;
		}
	}

	public override Vector3[] GetSides(Transform relativeTo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got VT
		//IL_007f: Expected Obj, but got I
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_0313: Expected Obj, but got I4
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		//IL_04fe: Expected Obj, but got I
		//IL_051b: Expected Obj, but got I
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected Obj, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected VT, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_057d: Expected Obj, but got I4
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected VT, but got Unknown
		//IL_0627: Expected Obj, but got I
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected Obj, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 256;
		Vector3[] result;
		if (mClipping != UIDrawCall.Clipping.None)
		{
			object obj3 = mClipOffset + mClipRange;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D0]");
			float num = 0f * 0.5f;
			float num2 = (float)obj3 - num;
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D0]");
			float num4 = num3 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+F0]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+CC]");
			object obj4 = num5 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D4]");
			float num6 = 0f * 0.5f;
			float num7 = (float)obj4 - num6;
			float num8 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+D4]");
			float num9 = num8 + 0f;
			Transform transform = cachedTransform;
			Vector3[] array = UIRect.mSides;
			float num10 = num7 + num9;
			float y = num10 * 0.5f;
			Vector3 vector = transform.TransformPoint(num2, y, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			_ = 0;
			Vector3[] array2 = UIRect.mSides;
			float num11 = num2 + num4;
			float x = num11 * 0.5f;
			Vector3 vector2 = transform.TransformPoint(x, num9, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			Vector3[] array3 = UIRect.mSides;
			Vector3 vector3 = transform.TransformPoint(num4, y, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
			_ = 0;
			Vector3[] array4 = UIRect.mSides;
			Vector3 vector4 = transform.TransformPoint(x, num7, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
			_ = 0;
			object obj5 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v112+8]");
			_ = 0;
			if (relativeTo != null)
			{
				object obj6 = 0;
				while ((nint)obj6 < 4)
				{
					object obj7 = obj6 * 12;
					object obj8 = (object)UIRect.mSides + obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S1_v124+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S1_v124+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
					_ = 0;
					Vector3 position = (Vector3)(obj + 48);
					Vector3 vector5 = relativeTo.InverseTransformPoint(position);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
					_ = 0;
					object obj9 = obj6 * 12;
					object obj10 = (object)UIRect.mSides + obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
					_ = 0;
					object obj11 = obj6 + 1;
					obj6 = obj11;
				}
			}
			result = UIRect.mSides;
		}
		else
		{
			Camera camera = anchorCamera;
			if (camera != null && ~(anchorOffset ? 1u : 0u) == 0)
			{
				float num12 = cameraRayDistance;
				Vector3[] sides = NGUITools.GetSides(mCam, num12);
				Transform transform2 = cachedTransform;
				Vector3 position2 = transform2.position;
				object obj12 = default;
				object obj14 = default;
				while ((nint)obj12 < 4)
				{
					object obj13 = obj14 * 12;
					object obj15 = (object)sides + obj13;
					object obj16 = obj15 + 16;
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
					object obj18 = obj17 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S0_v71+4]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F4]");
					object obj19 = num13 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S0_v71+8]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
					object obj20 = num14 + 0;
					obj16 = obj18;
					obj12 = obj14 + 1;
				}
				bool flag = relativeTo != null;
				bool flag2 = !flag;
				result = sides;
				if (!flag2)
				{
					object obj21 = 0;
					while (true)
					{
						bool flag3 = (nint)obj21 >= 4;
						result = sides;
						if (flag3)
						{
							break;
						}
						object obj22 = obj21 * 12;
						object obj23 = (object)sides + obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ S1_v19+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ S1_v19+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
						_ = 0;
						Vector3 position3 = (Vector3)(obj + 16);
						Vector3 vector6 = relativeTo.InverseTransformPoint(position3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
						obj = 0;
						object obj24 = obj21 * 12;
						object obj25 = (object)sides + obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						object obj26 = obj21 + 1;
						obj21 = obj26;
					}
				}
			}
			else
			{
				Vector3[] sides2 = base.GetSides(relativeTo);
				result = sides2;
			}
		}
		return result;
	}

	public override void Invalidate(bool includeChildren)
	{
		mAlphaFrameID = -1;
		base.Invalidate(includeChildren);
	}

	public override float CalculateFinalAlpha(int frameID)
	{
		//IL_0063: Expected I, but got Obj
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		if (frameID == mAlphaFrameID)
		{
			return finalAlpha;
		}
		mAlphaFrameID = frameID;
		UIRect uIRect = parent;
		UIRect uIRect2 = parent;
		float result;
		if (uIRect2 != null)
		{
			nint num = (nint)uIRect;
			object obj = uIRect + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ S3_v4 (Il2CppClass<UIRect>)+114] (should have been resolved before IL gen)");
			object obj2 = default;
			result = (float)obj2 * mAlpha;
		}
		else
		{
			result = mAlpha;
		}
		finalAlpha = result;
		return result;
	}

	public unsafe override void SetRect(float x, float y, float width, float height)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0029: Expected F8, but got I4
		//IL_0044: Expected F8, but got I4
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0315: Expected F4, but got I
		//IL_0310: Expected native int or pointer, but got VT
		//IL_0368: Expected F4, but got I
		//IL_0363: Expected native int or pointer, but got VT
		//IL_0052: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I4
		object obj = default;
		Vector4 vector = (Vector4)(obj - 48);
		float num = width + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num2 = Math.Abs((double)num);
		double num3 = ((!(num2 < 2147483648.0)) ? (-2147483648.0) : ((double)num));
		float num4 = height + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num5 = Math.Abs((double)num4);
		double num6 = ((!(num5 < 2147483648.0)) ? (-2147483648.0) : ((double)num4));
		Transform transform = cachedTransform;
		Vector3 localPosition = transform.localPosition;
		object obj2 = num3 & -2;
		if ((nint)obj2 <= 2)
		{
			obj2 = 2;
		}
		object obj3 = num6 & -2;
		if ((nint)obj3 <= 2)
		{
			obj3 = 2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+18]");
		((Vector4*)(nint)vector)->z = 0f;
		float num7 = x + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		float num8 = y + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+10]");
		((Vector4*)(nint)vector)->x = 0f;
		baseClipRegion = vector;
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

	public unsafe bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected VT, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected VT, but got Unknown
		//IL_04bc: Expected Ref, but got VT
		//IL_04d5: Expected F4, but got I
		//IL_04d0: Expected native int or pointer, but got VT
		//IL_04ea: Expected F4, but got I
		//IL_04e5: Expected native int or pointer, but got VT
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected VT, but got Unknown
		//IL_0519: Expected Ref, but got VT
		//IL_0028: Expected F4, but got I
		//IL_0023: Expected native int or pointer, but got VT
		//IL_003d: Expected F4, but got I
		//IL_0038: Expected native int or pointer, but got VT
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected VT, but got Unknown
		//IL_006c: Expected Ref, but got VT
		//IL_0085: Expected F4, but got I
		//IL_0080: Expected native int or pointer, but got VT
		//IL_009a: Expected F4, but got I
		//IL_0095: Expected native int or pointer, but got VT
		//IL_00a7: Expected native int or pointer, but got VT
		//IL_00b9: Expected native int or pointer, but got VT
		//IL_00cb: Expected Ref, but got VT
		//IL_00e9: Expected F4, but got I
		//IL_00e4: Expected native int or pointer, but got VT
		//IL_00fe: Expected F4, but got I
		//IL_00f9: Expected native int or pointer, but got VT
		//IL_01c1: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got I4
		//IL_0675: Invalid comparison between F4 and VT
		//IL_02f5: Expected Obj, but got I4
		//IL_038f: Expected Obj, but got I4
		//IL_01f1: Invalid comparison between F4 and I
		//IL_041e: Invalid comparison between F4 and I
		//IL_028b: Invalid comparison between F4 and I
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0325: Invalid comparison between F4 and I
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Obj, but got Unknown
		//IL_023b: Expected F4, but got I
		//IL_043c: Invalid comparison between F4 and VT
		//IL_03bf: Invalid comparison between F4 and I
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected Obj, but got Unknown
		//IL_02d5: Expected F4, but got I
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected Obj, but got Unknown
		//IL_036f: Expected F4, but got I
		//IL_0460: Invalid comparison between I and F4
		//IL_0409: Expected F4, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		UpdateTransformMatrix();
		_ = a.z;
		_ = a.x;
		Matrix4x4 matrix4x = (Matrix4x4)(this + 104);
		Vector3 point = vector + 48;
		Vector3 vector2 = ((Matrix4x4*)matrix4x)->MultiplyPoint3x4(point);
		Vector3 vector3 = a;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 vector4 = a;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector4)->x = 0f;
		_ = b.z;
		_ = b.x;
		Vector3 point2 = vector + 32;
		Vector3 vector5 = ((Matrix4x4*)matrix4x)->MultiplyPoint3x4(point2);
		Vector3 vector6 = b;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Vector3*)(nint)vector6)->z = 0f;
		Vector3 vector7 = b;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector7)->x = 0f;
		_ = c.z;
		_ = c.x;
		Vector3 point3 = vector + 16;
		Vector3 vector8 = ((Matrix4x4*)matrix4x)->MultiplyPoint3x4(point3);
		Vector3 vector9 = c;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Vector3*)(nint)vector9)->z = 0f;
		Vector3 vector10 = c;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector10)->x = 0f;
		((Vector3*)(nint)vector)->z = d.z;
		((Vector3*)(nint)vector)->x = d.x;
		Vector3 vector11 = ((Matrix4x4*)matrix4x)->MultiplyPoint3x4(vector);
		Vector3 vector12 = d;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Vector3*)(nint)vector12)->z = 0f;
		Vector3 vector13 = d;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector13)->x = 0f;
		float[] array = mTemp;
		array[0] = a.x;
		float[] array2 = mTemp;
		array2[1] = b.x;
		float[] array3 = mTemp;
		array3[2] = c.x;
		float[] array4 = mTemp;
		array4[3] = d.x;
		float[] array5 = mTemp;
		float num = default;
		if (array5.Length != 0)
		{
			num = array5[0];
			object obj2 = 1;
			while ((nint)obj2 < array5.Length)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)array5 + obj3;
				float num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v106+10]");
				if (num2 > 0f)
				{
					object obj5 = obj2 << 2;
					object obj6 = (object)array5 + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v166+10]");
					num = 0f;
				}
				object obj7 = obj2 + 1;
				obj2 = obj7;
			}
		}
		float[] array6 = mTemp;
		float num3 = default;
		if (array6.Length != 0)
		{
			num3 = array6[0];
			object obj8 = 1;
			while ((nint)obj8 < array6.Length)
			{
				object obj9 = obj8 << 2;
				object obj10 = (object)array6 + obj9;
				float num4 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S1_v97+10]");
				if (num4 < 0f)
				{
					object obj11 = obj8 << 2;
					object obj12 = (object)array6 + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v152+10]");
					num3 = 0f;
				}
				object obj13 = obj8 + 1;
				obj8 = obj13;
			}
		}
		float[] array7 = mTemp;
		array7[0] = a.y;
		float[] array8 = mTemp;
		array8[1] = b.y;
		float[] array9 = mTemp;
		array9[2] = c.y;
		float[] array10 = mTemp;
		array10[3] = d.y;
		float[] array11 = mTemp;
		float num5 = default;
		if (array11.Length != 0)
		{
			num5 = array11[0];
			object obj14 = 1;
			while (array11.Length > (nint)obj14)
			{
				object obj15 = obj14 << 2;
				object obj16 = (object)array11 + obj15;
				float num6 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S1_v88+10]");
				if (num6 > 0f)
				{
					object obj17 = obj14 << 2;
					object obj18 = (object)array11 + obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v138+10]");
					num5 = 0f;
				}
				object obj19 = obj14 + 1;
				obj14 = obj19;
			}
		}
		float[] array12 = mTemp;
		float num7 = default;
		if (array12.Length != 0)
		{
			num7 = array12[0];
			object obj20 = 1;
			while (array12.Length > (nint)obj20)
			{
				object obj21 = obj20 << 2;
				object obj22 = (object)array12 + obj21;
				float num8 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S1_v79+10]");
				if (num8 < 0f)
				{
					object obj23 = obj20 << 2;
					object obj24 = (object)array12 + obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v124+10]");
					num7 = 0f;
				}
				object obj25 = obj20 + 1;
				obj20 = obj25;
			}
		}
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3) >= System.Runtime.CompilerServices.Unsafe.As<Vector2, UIntPtr>(ref mMin))
		{
			float num9 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+104]");
			if (!(num9 < 0f) && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) <= System.Runtime.CompilerServices.Unsafe.As<Vector2, UIntPtr>(ref mMax))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+10C]");
				bool flag = 0f < num5;
				return !flag;
			}
		}
		return false;
	}

	public unsafe bool IsVisible(Vector3 worldPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00f2: Expected native int or pointer, but got VT
		//IL_0104: Expected native int or pointer, but got VT
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected VT, but got Unknown
		//IL_0121: Expected Ref, but got VT
		//IL_013c: Invalid comparison between I and VT
		//IL_01a0: Invalid comparison between I and VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		bool result = default;
		if (!(mAlpha < 0.001f))
		{
			bool flag = mClipping == UIDrawCall.Clipping.None;
			result = true;
			if (!flag)
			{
				if (mClipping != UIDrawCall.Clipping.TextureMask && mClipping != (UIDrawCall.Clipping)2 && mClipping != UIDrawCall.Clipping.SoftClip)
				{
					bool flag2 = mClipping == UIDrawCall.Clipping.ConstrainButDontClip;
					result = true;
					if (flag2)
					{
						goto IL_01eb;
					}
				}
				UpdateTransformMatrix();
				((Vector3*)(nint)vector)->z = worldPos.z;
				((Vector3*)(nint)vector)->x = worldPos.x;
				Matrix4x4 matrix4x = (Matrix4x4)(this + 104);
				Vector3 vector2 = ((Matrix4x4*)matrix4x)->MultiplyPoint3x4(vector);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0) < System.Runtime.CompilerServices.Unsafe.As<Vector2, UIntPtr>(ref mMin);
				result = false;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+104]");
					bool flag4 = num < 0;
					result = false;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
						bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0) > System.Runtime.CompilerServices.Unsafe.As<Vector2, UIntPtr>(ref mMax);
						result = false;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+10C]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
							bool flag6 = num2 < 0;
							return !flag6;
						}
					}
				}
			}
		}
		goto IL_01eb;
		IL_01eb:
		return result;
	}

	public unsafe bool IsVisible(UIWidget w)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I
		//IL_0202: Expected F4, but got I
		//IL_01fd: Expected native int or pointer, but got VT
		//IL_023e: Expected F4, but got I
		//IL_0239: Expected native int or pointer, but got VT
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected VT, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected VT, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected VT, but got Unknown
		//IL_010e: Expected I, but got Obj
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		bool flag;
		UIPanel uIPanel = default;
		object obj2 = default;
		while (true)
		{
			flag = mParentPanel != null;
			if (!flag)
			{
				break;
			}
			if ((uIPanel.mClipping != UIDrawCall.Clipping.None && (uIPanel.mClipping == UIDrawCall.Clipping.TextureMask || uIPanel.mClipping == (UIDrawCall.Clipping)2 || uIPanel.mClipping == UIDrawCall.Clipping.SoftClip || uIPanel.mClipping != UIDrawCall.Clipping.ConstrainButDontClip)) || ~(w.hideIfOffScreen ? 1u : 0u) == 0)
			{
				if (obj2 == null)
				{
					nint num = (nint)w;
					object obj3 = w + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ S1_v45 (Il2CppClass<UIWidget>)+10C] (should have been resolved before IL gen)");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v47+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v47+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v47+24]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v47+1C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v47+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v47+28]");
				_ = 0;
				object obj4 = vector - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v47+3C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v47+34]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				((Vector3*)(nint)vector)->x = 0f;
				Vector3 a = vector + 48;
				Vector3 b = vector + 32;
				Vector3 c = vector + 16;
				if (!mParentPanel.IsVisible(a, b, c, vector))
				{
					break;
				}
			}
			uIPanel = mParentPanel;
		}
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public bool Affects(UIWidget w)
	{
		if (w != null && w.panel != null)
		{
			while (mParentPanel != null)
			{
				if (mParentPanel == w.panel)
				{
					return true;
				}
				if (!mParentPanel.hasCumulativeClipping)
				{
					break;
				}
			}
		}
		return false;
	}

	public void RebuildAllDrawCalls()
	{
		mRebuild = true;
	}

	public void SetDirty()
	{
		//IL_0046: Expected I, but got Obj
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		List<UIDrawCall> list = drawCalls;
		int num = 0;
		while (num < list._size)
		{
			UIDrawCall uIDrawCall = drawCalls.get_Item(num);
			uIDrawCall.isDirty = true;
			int num2 = num + 1;
			num = num2;
		}
		nint num3 = (nint)this;
		object obj = this + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S2_v3 (Il2CppClass<UIPanel>)+11C] (should have been resolved before IL gen)");
	}

	private void Awake()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		GameObject gameObject = base.gameObject;
		mGo = gameObject;
		Transform transform = base.transform;
		mTrans = transform;
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.WindowsPlayer)
		{
			mHalfPixelOffset = true;
			object obj = this + 272;
		}
		else
		{
			RuntimePlatform platform2 = Application.platform;
			bool flag = platform2 == RuntimePlatform.WindowsEditor;
			mHalfPixelOffset = flag;
			if (platform2 != RuntimePlatform.WindowsEditor)
			{
				return;
			}
			object obj = this + 272;
		}
		string graphicsDeviceVersion = SystemInfo.GetGraphicsDeviceVersion();
		if (graphicsDeviceVersion.Contains("Direct3D"))
		{
			int graphicsShaderLevel = SystemInfo.GetGraphicsShaderLevel();
			bool flag2 = graphicsShaderLevel < 40;
			object obj = flag2;
		}
	}

	private void FindParent()
	{
		Transform transform = cachedTransform;
		Transform transform2 = transform.parent;
		UIPanel uIPanel;
		if (transform2 != null)
		{
			GameObject go = transform2.gameObject;
			uIPanel = NGUITools.FindInParents<UIPanel>(go);
		}
		else
		{
			uIPanel = null;
		}
		mParentPanel = uIPanel;
	}

	public override void ParentHasChanged()
	{
		base.ParentHasChanged();
		FindParent();
	}

	protected override void OnStart()
	{
		int layer = mGo.layer;
		mLayer = layer;
	}

	protected override void OnEnable()
	{
		//IL_001b: Expected I, but got Obj
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		mRebuild = true;
		mMatrixFrame = -1;
		nint num = (nint)this;
		object obj = this + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v4 (Il2CppClass<UIPanel>)+15C] (should have been resolved before IL gen)");
		base.OnEnable();
		mMatrixFrame = -1;
	}

	protected override void OnInit()
	{
		if (list.Contains(this))
		{
			return;
		}
		base.OnInit();
		FindParent();
		Rigidbody component = GetComponent<Rigidbody>();
		if (component == null && mParentPanel == null)
		{
			Camera camera = anchorCamera;
			bool flag = camera != null;
			bool flag2 = !flag;
			UICamera uICamera = null;
			if (!flag2)
			{
				UICamera component2 = mCam.GetComponent<UICamera>();
				uICamera = component2;
			}
			if (uICamera != null && uICamera.eventType <= UICamera.EventType.UI_3D)
			{
				GameObject gameObject = base.gameObject;
				Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
				rigidbody.isKinematic = true;
				rigidbody.useGravity = false;
			}
		}
		mRebuild = true;
		mMatrixFrame = -1;
		list.Add(this);
		throw new ArgumentException();
	}

	protected override void OnDisable()
	{
		List<UIDrawCall> list = drawCalls;
		int num = 0;
		while (num < list._size)
		{
			UIDrawCall uIDrawCall = drawCalls.get_Item(num);
			if (uIDrawCall != null)
			{
				UIDrawCall.Destroy(uIDrawCall);
			}
			int num2 = num + 1;
			num = num2;
		}
		((List<T>)(object)drawCalls).Clear();
		bool flag = UIPanel.list.Remove(this);
		mMatrixFrame = -1;
		List<UIPanel> list2 = UIPanel.list;
		if (list2._size == 0)
		{
			UIDrawCall.ReleaseAll();
			mUpdateFrame = -1;
		}
		base.OnDisable();
	}

	private void UpdateTransformMatrix()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got VT
		//IL_0122: Expected VT, but got F4
		//IL_014f: Expected VT, but got F4
		object obj2 = default;
		object obj = obj2 - 128;
		int frameCount = Time.frameCount;
		if (frameCount != mMatrixFrame)
		{
			mMatrixFrame = frameCount;
			Transform transform = cachedTransform;
			Matrix4x4 worldToLocalMatrix = transform.worldToLocalMatrix;
			object obj3 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
			object obj4 = this + 104;
			object obj5 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
			Vector2 viewSize = GetViewSize();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			float num = 0f * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+F0]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+CC]");
			object obj6 = num2 + 0;
			object obj7 = mClipOffset + mClipRange;
			float num3 = (float)obj * 0.5f;
			float num4 = (float)obj7 - num3;
			mMin = (Vector2)num4;
			float num5 = (float)obj6 - num;
			float num6 = (float)obj7 + num3;
			mMax = (Vector2)num6;
			float num7 = (float)obj6 + num;
		}
	}

	protected unsafe override void OnAnchor()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_09ad: Expected Obj, but got I
		//IL_09d9: Expected Obj, but got I
		//IL_0a07: Expected F4, but got VT
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected Obj, but got Unknown
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected Obj, but got Unknown
		//IL_0b3c: Expected F4, but got I
		//IL_0b76: Expected F4, but got I
		//IL_0b71: Expected native int or pointer, but got VT
		//IL_0bf1: Expected F4, but got I
		//IL_0bec: Expected native int or pointer, but got VT
		object obj = default;
		Vector4 vector = (Vector4)(obj - 48);
		if (mClipping == UIDrawCall.Clipping.None)
		{
			return;
		}
		Transform transform = cachedTransform;
		Transform transform2 = transform.parent;
		Vector2 viewSize = GetViewSize();
		Vector3 localPosition = transform.localPosition;
		AnchorPoint anchorPoint = bottomAnchor;
		AnchorPoint anchorPoint2 = leftAnchor;
		float num20;
		float num21;
		float num22;
		float num23;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v170 (UnityEngine.Vector3[])+10]");
						float num2 = 0f * num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v170 (UnityEngine.Vector3[])+28]");
						float num3 = 0f * anchorPoint7.relative;
						float num4 = num2 + num3;
						AnchorPoint anchorPoint8 = leftAnchor;
						float num5 = num4 + (float)anchorPoint8.absolute;
						AnchorPoint anchorPoint9 = rightAnchor;
						float num6 = 1f - anchorPoint9.relative;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v170 (UnityEngine.Vector3[])+10]");
						float num7 = 0f * num6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v170 (UnityEngine.Vector3[])+28]");
						float num8 = 0f * anchorPoint9.relative;
						float num9 = num7 + num8;
						AnchorPoint anchorPoint10 = rightAnchor;
						float num10 = num9 + (float)anchorPoint10.absolute;
						AnchorPoint anchorPoint11 = bottomAnchor;
						float num11 = 1f - anchorPoint11.relative;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v170 (UnityEngine.Vector3[])+38]");
						float num12 = 0f * num11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v170 (UnityEngine.Vector3[])+20]");
						float num13 = 0f * anchorPoint11.relative;
						float num14 = num12 + num13;
						AnchorPoint anchorPoint12 = bottomAnchor;
						float num15 = num14 + (float)anchorPoint12.absolute;
						AnchorPoint anchorPoint13 = topAnchor;
						float num16 = 1f - anchorPoint13.relative;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v170 (UnityEngine.Vector3[])+38]");
						float num17 = 0f * num16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v170 (UnityEngine.Vector3[])+20]");
						float num18 = 0f * anchorPoint13.relative;
						float num19 = num17 + num18;
						AnchorPoint anchorPoint14 = topAnchor;
						num20 = num19 + (float)anchorPoint14.absolute;
						num21 = num15;
						num22 = num5;
						num23 = num10;
					}
					else
					{
						Vector3 localPos = GetLocalPos(leftAnchor, transform2);
						AnchorPoint anchorPoint15 = leftAnchor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+20]");
						float num24 = 0f + (float)anchorPoint15.absolute;
						AnchorPoint anchorPoint16 = bottomAnchor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+24]");
						float num25 = 0f + (float)anchorPoint16.absolute;
						AnchorPoint anchorPoint17 = rightAnchor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+20]");
						float num26 = 0f + (float)anchorPoint17.absolute;
						AnchorPoint anchorPoint18 = topAnchor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+24]");
						num20 = 0f + (float)anchorPoint18.absolute;
						num21 = num25;
						num22 = num24;
						num23 = num26;
					}
					goto IL_0990;
				}
			}
		}
		AnchorPoint anchorPoint19 = leftAnchor;
		float num31;
		if ((bool)anchorPoint19.target)
		{
			Vector3[] sides2 = leftAnchor.GetSides(transform2);
			if (sides2 != null)
			{
				AnchorPoint anchorPoint20 = leftAnchor;
				float num27 = 1f - anchorPoint20.relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v135 (UnityEngine.Vector3[])+10]");
				float num28 = 0f * num27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v135 (UnityEngine.Vector3[])+28]");
				float num29 = 0f * anchorPoint20.relative;
				float num30 = num28 + num29;
				AnchorPoint anchorPoint21 = leftAnchor;
				num31 = num30 + (float)anchorPoint21.absolute;
			}
			else
			{
				Vector3 localPos2 = GetLocalPos(leftAnchor, transform2);
				AnchorPoint anchorPoint22 = leftAnchor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+20]");
				num31 = 0f + (float)anchorPoint22.absolute;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+20]");
			float num32 = 0f * 0.5f;
			num31 = (float)mClipRange - num32;
		}
		AnchorPoint anchorPoint23 = rightAnchor;
		float num37;
		if ((bool)anchorPoint23.target)
		{
			Vector3[] sides3 = rightAnchor.GetSides(transform2);
			if (sides3 != null)
			{
				AnchorPoint anchorPoint24 = rightAnchor;
				float num33 = 1f - anchorPoint24.relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v119 (UnityEngine.Vector3[])+10]");
				float num34 = 0f * num33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v119 (UnityEngine.Vector3[])+28]");
				float num35 = 0f * anchorPoint24.relative;
				float num36 = num34 + num35;
				AnchorPoint anchorPoint25 = rightAnchor;
				num37 = num36 + (float)anchorPoint25.absolute;
			}
			else
			{
				Vector3 localPos3 = GetLocalPos(rightAnchor, transform2);
				AnchorPoint anchorPoint26 = rightAnchor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+20]");
				num37 = 0f + (float)anchorPoint26.absolute;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+20]");
			float num38 = 0f * 0.5f;
			num37 = (float)mClipRange + num38;
		}
		AnchorPoint anchorPoint27 = bottomAnchor;
		float num43;
		if ((bool)anchorPoint27.target)
		{
			Vector3[] sides4 = bottomAnchor.GetSides(transform2);
			if (sides4 != null)
			{
				AnchorPoint anchorPoint28 = bottomAnchor;
				float num39 = 1f - anchorPoint28.relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v103 (UnityEngine.Vector3[])+38]");
				float num40 = 0f * num39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v103 (UnityEngine.Vector3[])+20]");
				float num41 = 0f * anchorPoint28.relative;
				float num42 = num40 + num41;
				AnchorPoint anchorPoint29 = bottomAnchor;
				num43 = num42 + (float)anchorPoint29.absolute;
			}
			else
			{
				Vector3 localPos4 = GetLocalPos(bottomAnchor, transform2);
				AnchorPoint anchorPoint30 = bottomAnchor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+24]");
				num43 = 0f + (float)anchorPoint30.absolute;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+24]");
			float num44 = 0f * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+CC]");
			num43 = 0f - num44;
		}
		AnchorPoint anchorPoint31 = topAnchor;
		if ((bool)anchorPoint31.target)
		{
			Vector3[] sides5 = topAnchor.GetSides(transform2);
			if (sides5 != null)
			{
				AnchorPoint anchorPoint32 = topAnchor;
				float num45 = 1f - anchorPoint32.relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ S0_v87 (UnityEngine.Vector3[])+38]");
				float num46 = 0f * num45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ S0_v87 (UnityEngine.Vector3[])+20]");
				float num47 = 0f * anchorPoint32.relative;
				float num48 = num46 + num47;
				AnchorPoint anchorPoint33 = topAnchor;
				num20 = num48 + (float)anchorPoint33.absolute;
				num21 = num43;
				num22 = num31;
				num23 = num37;
			}
			else
			{
				Vector3 localPos5 = GetLocalPos(topAnchor, transform2);
				AnchorPoint anchorPoint34 = topAnchor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+24]");
				num20 = 0f + (float)anchorPoint34.absolute;
				num21 = num43;
				num22 = num31;
				num23 = num37;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+24]");
			float num49 = 0f * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+CC]");
			num20 = 0f + num49;
			num21 = num43;
			num22 = num31;
			num23 = num37;
		}
		goto IL_0990;
		IL_0990:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+24]");
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+F0]");
		object obj2 = num50 + 0;
		float num51 = num20 - (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+24]");
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+F0]");
		object obj3 = num52 + 0;
		float num53 = num21 - (float)obj3;
		float num54 = num51 - num53;
		float num55 = Math.Max((float)mClipSoftness, 2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+20]");
		object obj4 = 0 + mClipOffset;
		float num56 = num23 - (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+20]");
		object obj5 = 0 + mClipOffset;
		float num57 = num22 - (float)obj5;
		float num58 = num56 - num57;
		if (!(num58 < num55))
		{
			num55 = num58;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+DC]");
		float num59 = Math.Max(0f, 2f);
		if (!(num54 < num59))
		{
			num59 = num54;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+18]");
		((Vector4*)(nint)vector)->z = 0f;
		float num60 = num51 - num53;
		float num61 = num60 * 0.5f;
		float num62 = num53 + num61;
		float num63 = num56 - num57;
		float num64 = num63 * 0.5f;
		float num65 = num57 + num64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+10]");
		((Vector4*)(nint)vector)->x = 0f;
		baseClipRegion = vector;
	}

	private void LateUpdate()
	{
		int frameCount = Time.frameCount;
		if (mUpdateFrame == frameCount)
		{
			return;
		}
		int frameCount2 = Time.frameCount;
		mUpdateFrame = frameCount2;
		List<UIPanel> list = UIPanel.list;
		int num = 0;
		List<UIPanel> list2;
		while (true)
		{
			list2 = UIPanel.list;
			if (num >= list._size)
			{
				break;
			}
			UIPanel uIPanel = list2.get_Item(num);
			uIPanel.UpdateSelf();
			int num2 = num + 1;
			num = num2;
		}
		int num3 = 3000;
		int num4 = 0;
		while (num4 < list2._size)
		{
			UIPanel uIPanel2 = UIPanel.list.get_Item(num4);
			if (uIPanel2.renderQueue != RenderQueue.Automatic)
			{
				if (uIPanel2.renderQueue == RenderQueue.StartAt)
				{
					uIPanel2.UpdateDrawCalls();
					List<UIDrawCall> list3 = uIPanel2.drawCalls;
					if (list3._size != 0)
					{
						List<UIDrawCall> list4 = uIPanel2.drawCalls;
						int num5 = uIPanel2.startingRenderQueue + list4._size;
						bool flag = num5 < num3;
						int num6 = num3;
						if (!flag)
						{
							num6 = num5;
						}
						num3 = num6;
					}
				}
				else
				{
					uIPanel2.UpdateDrawCalls();
					List<UIDrawCall> list5 = uIPanel2.drawCalls;
					if (list5._size != 0)
					{
						int num7 = uIPanel2.startingRenderQueue + 1;
						bool flag2 = num7 < num3;
						int num8 = num3;
						if (!flag2)
						{
							num8 = num7;
						}
						num3 = num8;
					}
				}
			}
			else
			{
				uIPanel2.startingRenderQueue = num3;
				uIPanel2.UpdateDrawCalls();
				List<UIDrawCall> list6 = uIPanel2.drawCalls;
				int num9 = list6._size + num3;
				num3 = num9;
			}
			int num10 = num4 + 1;
			num4 = num10;
		}
	}

	private void UpdateSelf()
	{
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		UpdateTransformMatrix();
		UpdateLayers();
		UpdateWidgets();
		if (~(mRebuild ? 1u : 0u) != 0)
		{
			int num = 0;
			while (true)
			{
				List<UIDrawCall> list = drawCalls;
				if (num >= list._size)
				{
					break;
				}
				UIDrawCall uIDrawCall = drawCalls.get_Item(num);
				if (~(uIDrawCall.isDirty ? 1u : 0u) == 0 && !FillDrawCall(uIDrawCall))
				{
					UIDrawCall.Destroy(uIDrawCall);
					drawCalls.RemoveAt(num);
				}
				else
				{
					int num2 = num + 1;
					num = num2;
				}
			}
		}
		else
		{
			mRebuild = false;
			FillAllDrawCalls();
		}
		if (~(mUpdateScroll ? 1u : 0u) == 0)
		{
			mUpdateScroll = false;
			UIScrollView component = GetComponent<UIScrollView>();
			if (component != null)
			{
				object obj = component - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S2_v6+BC] (should have been resolved before IL gen)");
			}
		}
	}

	public void SortWidgets()
	{
		mSortWidgets = false;
		throw new ArgumentException();
	}

	private void FillAllDrawCalls()
	{
		//IL_0583: Expected Obj, but got I
		//IL_013d: Expected I, but got Obj
		//IL_014f: Expected I, but got Obj
		//IL_0161: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_046a: Expected Obj, but got I
		//IL_046a: Expected Obj, but got I
		//IL_046a: Expected Obj, but got I
		//IL_0435: Expected Obj, but got I
		//IL_0435: Expected Obj, but got I
		//IL_0435: Expected Obj, but got I
		//IL_0435: Expected Obj, but got I
		//IL_0435: Expected Obj, but got I
		if (!Application.isPlaying)
		{
			return;
		}
		int num = 0;
		while (true)
		{
			List<UIDrawCall> list = drawCalls;
			if (list._size <= num)
			{
				break;
			}
			UIDrawCall dc = drawCalls.get_Item(num);
			UIDrawCall.Destroy(dc);
			int num2 = num + 1;
			num = num2;
		}
		((List<T>)(object)drawCalls).Clear();
		if (~(mSortWidgets ? 1u : 0u) == 0)
		{
			SortWidgets();
		}
		UnityEngine.Object obj = null;
		int num3 = 0;
		int num4 = default;
		UnityEngine.Object obj2 = default;
		UnityEngine.Object obj3 = default;
		UnityEngine.Object obj4 = default;
		UnityEngine.Object obj5 = default;
		UnityEngine.Object obj6 = default;
		UnityEngine.Object obj8 = default;
		UIDrawCall.OnRenderCallback onRenderCallback = default;
		int num18 = default;
		while (true)
		{
			List<UIWidget> list2 = widgets;
			if (num4 >= list2._size)
			{
				break;
			}
			UIWidget uIWidget = widgets.get_Item(num4);
			UnityEngine.Object obj7;
			int num8;
			if (uIWidget.isVisible)
			{
				UIGeometry geometry = uIWidget.geometry;
				bool flag;
				if (uIWidget.geometry != null)
				{
					BetterList<Vector3> verts = geometry.verts;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v163 (BetterList`1<UnityEngine.Vector3>)+C]");
					flag = (nint)0 > (nint)0;
				}
				else
				{
					flag = false;
				}
				if (flag)
				{
					nint num5 = (nint)uIWidget;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v216 @ S1_v26 (Il2CppClass<UIWidget>)+17C] (should have been resolved before IL gen)");
					nint num6 = (nint)uIWidget;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ S1_v29 (Il2CppClass<UIWidget>)+18C] (should have been resolved before IL gen)");
					nint num7 = (nint)uIWidget;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ S1_v32 (Il2CppClass<UIWidget>)+19C] (should have been resolved before IL gen)");
					if (obj == obj2 && obj3 == obj4 && obj5 == obj6)
					{
						obj3 = obj3;
						obj7 = obj;
						obj5 = obj5;
						num8 = num3;
					}
					else
					{
						if (obj8 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ L2_v5 (UnityEngine.Object)+28]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v140+C]");
							if ((nint)0 != 0)
							{
								drawCalls.Add((UIDrawCall)obj8);
								((UIDrawCall)obj8).UpdateGeometry(num3);
								_ = mOnRender;
								mOnRender = null;
								obj8 = null;
								obj3 = obj4;
								obj7 = obj2;
								obj5 = obj6;
								num8 = 0;
								goto IL_064e;
							}
						}
						obj3 = obj4;
						obj7 = obj2;
						obj5 = obj6;
						num8 = num3;
					}
					goto IL_064e;
				}
			}
			uIWidget.drawCall = null;
			goto IL_06ca;
			IL_064e:
			if (obj7 == null && obj5 == null && obj3 == null)
			{
				num3 = num8;
			}
			else
			{
				if (obj8 == null)
				{
					UIDrawCall uIDrawCall = UIDrawCall.Create(this, (Material)obj7, (Texture)obj3, (Shader)obj5);
					uIDrawCall.panel = this;
					uIDrawCall.depthEnd = uIWidget.mDepth;
					uIDrawCall.depthStart = uIWidget.mDepth;
					obj8 = uIDrawCall;
				}
				else
				{
					int num9 = uIWidget.mDepth;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ L2_v5 (UnityEngine.Object)+10]");
					if ((nint)num9 < (nint)0)
					{
						_ = uIWidget.mDepth;
					}
					int num10 = uIWidget.mDepth;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ L2_v5 (UnityEngine.Object)+14]");
					if ((nint)num10 > (nint)0)
					{
						_ = uIWidget.mDepth;
					}
				}
				uIWidget.drawCall = (UIDrawCall)obj8;
				int num11 = num8 + 1;
				if (~(generateNormals ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ L2_v5 (UnityEngine.Object)+28]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ L2_v5 (UnityEngine.Object)+34]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ L2_v5 (UnityEngine.Object)+38]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ L2_v5 (UnityEngine.Object)+2C]");
					nint num15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ L2_v5 (UnityEngine.Object)+30]");
					uIWidget.WriteToBuffers((BetterList<Vector3>)num12, (BetterList<Vector2>)num13, (BetterList<Color32>)num14, (BetterList<Vector3>)num15, (BetterList<Vector4>)0);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ L2_v5 (UnityEngine.Object)+28]");
					nint num16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ L2_v5 (UnityEngine.Object)+34]");
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ L2_v5 (UnityEngine.Object)+38]");
					uIWidget.WriteToBuffers((BetterList<Vector3>)num16, (BetterList<Vector2>)num17, (BetterList<Color32>)0, null, null);
				}
				bool flag2 = uIWidget.mOnRender == null;
				num3 = num11;
				if (!flag2)
				{
					if (mOnRender == null)
					{
						mOnRender = uIWidget.mOnRender;
						num3 = num11;
					}
					else
					{
						Delegate obj10 = Delegate.Combine(mOnRender, uIWidget.mOnRender);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
						mOnRender = onRenderCallback;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
						num3 = num11;
					}
				}
			}
			obj = obj7;
			goto IL_06ca;
			IL_06ca:
			num4 = num18 + 1;
		}
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ L2_v5 (UnityEngine.Object)+28]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v36+C]");
			if ((nint)0 != 0)
			{
				drawCalls.Add((UIDrawCall)obj8);
				((UIDrawCall)obj8).UpdateGeometry(num3);
				_ = mOnRender;
				mOnRender = null;
			}
		}
	}

	private bool FillDrawCall(UIDrawCall dc)
	{
		if (dc != null)
		{
			dc.isDirty = false;
			int num = 0;
			int num3 = default;
			UIDrawCall.OnRenderCallback onRenderCallback = default;
			while (true)
			{
				List<UIWidget> list = widgets;
				if (num >= list._size)
				{
					break;
				}
				UIWidget uIWidget = widgets.get_Item(num);
				if (uIWidget == null)
				{
					widgets.RemoveAt(num);
					continue;
				}
				if (uIWidget.drawCall == dc)
				{
					if (uIWidget.isVisible)
					{
						UIGeometry geometry = uIWidget.geometry;
						bool flag;
						if (uIWidget.geometry != null)
						{
							IntPtr cachedPtr = ((UnityEngine.Object)(object)geometry).m_CachedPtr;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v79 (System.IntPtr)+C]");
							flag = (nint)0 > (nint)0;
						}
						else
						{
							flag = false;
						}
						if (flag)
						{
							int num2 = num3 + 1;
							if (~(generateNormals ? 1u : 0u) == 0)
							{
								uIWidget.WriteToBuffers(dc.verts, dc.uvs, dc.cols, dc.norms, dc.tans);
							}
							else
							{
								uIWidget.WriteToBuffers(dc.verts, dc.uvs, dc.cols, null, null);
							}
							bool flag2 = uIWidget.mOnRender == null;
							num3 = num2;
							if (!flag2)
							{
								if (mOnRender == null)
								{
									mOnRender = uIWidget.mOnRender;
									num3 = num2;
								}
								else
								{
									Delegate obj = Delegate.Combine(mOnRender, uIWidget.mOnRender);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
									mOnRender = onRenderCallback;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
									num3 = num2;
								}
							}
							goto IL_033b;
						}
					}
					uIWidget.drawCall = null;
				}
				goto IL_033b;
				IL_033b:
				int num4 = num + 1;
				num = num4;
			}
			BetterList<Vector3> verts = dc.verts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v19 (BetterList`1<UnityEngine.Vector3>)+C]");
			if ((nint)0 == 0)
			{
				return false;
			}
			dc.UpdateGeometry(num3);
			dc.onRender = mOnRender;
			mOnRender = null;
			return true;
		}
		return false;
	}

	private unsafe void UpdateDrawCalls()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_04a7: Expected I, but got Obj
		//IL_003c: Expected VT, but got I
		//IL_047a: Invalid comparison between I and F4
		//IL_04e5: Invalid comparison between I and F4
		//IL_028e: Expected Obj, but got I
		//IL_029e: Expected F8, but got I
		//IL_02ae: Expected F8, but got I
		//IL_00d0: Expected VT, but got F4
		//IL_014b: Expected F8, but got I
		//IL_015b: Expected F8, but got I
		//IL_0546: Expected Obj, but got I
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected VT, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected VT, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_036b: Expected F4, but got I
		//IL_0366: Expected native int or pointer, but got VT
		//IL_0380: Expected F4, but got I
		//IL_037b: Expected native int or pointer, but got VT
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected VT, but got Unknown
		//IL_024c: Expected F8, but got I
		//IL_025c: Expected F8, but got I
		//IL_026c: Expected Obj, but got I
		//IL_01a8: Expected F8, but got I4
		//IL_01e7: Expected F8, but got I4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Transform transform = cachedTransform;
		bool flag = usedForUI;
		if (mClipping != UIDrawCall.Clipping.None)
		{
			Vector4 vector2 = finalClipRegion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			drawCallClipRange = (Vector4)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+B0]");
			float num = 0f * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+B4]");
			float num2 = 0f * 0.5f;
		}
		else
		{
			nint num3 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v161 (Il2CppClass<UnityEngine.Vector4>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v162 (Il2CppStaticFields<UnityEngine.Vector4>)+8]");
			_ = 0;
			drawCallClipRange = Vector4.zeroVector;
		}
		int num5 = Screen.width;
		int num6 = Screen.height;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+B0]");
		if (0f == 0f)
		{
			float num7 = (float)num5 * 0.5f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+B4]");
		if (0f == 0f)
		{
			float num8 = (float)num6 * 0.5f;
		}
		if (~(mHalfPixelOffset ? 1u : 0u) == 0)
		{
			float num9 = (float)drawCallClipRange - 0.5f;
			drawCallClipRange = (Vector4)num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+AC]");
			float num10 = 0f + 0.5f;
		}
		if (flag)
		{
			Transform transform2 = cachedTransform;
			Transform transform3 = transform2.parent;
			Transform transform4 = cachedTransform;
			Vector3 localPosition = transform4.localPosition;
			bool flag2 = mClipping == UIDrawCall.Clipping.None;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			double num11 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			double num12 = 0.0;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num14 = default;
				double num13 = Math.Abs(num14);
				if (!(num13 < 2147483648.0))
				{
					num14 = -2147483648.0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num16 = default;
				double num15 = Math.Abs(num16);
				if (!(num15 < 2147483648.0))
				{
					num16 = -2147483648.0;
				}
				num11 = num14;
				num12 = num16;
			}
			bool flag3 = transform3 != null;
			bool flag4 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			object obj2 = 0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				_ = 0;
				Vector3 position = vector + 48;
				Vector3 vector3 = transform3.TransformPoint(position);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				num11 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				num12 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				obj2 = 0;
			}
			Vector3 vector4 = drawCallOffset;
			double num17 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			double num18 = num17 + 0.0;
			double num19 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			double num20 = num19 + 0.0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			object obj4 = obj3 + 0;
			double num21 = num18;
			double num22 = num20;
		}
		else
		{
			Vector3 position2 = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			double num21 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			double num22 = 0.0;
		}
		Quaternion rotation = transform.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Vector3 lossyScale = transform.lossyScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		int num23 = 0;
		while (true)
		{
			List<UIDrawCall> list = drawCalls;
			if (num23 >= list._size)
			{
				break;
			}
			UIDrawCall uIDrawCall = drawCalls.get_Item(num23);
			Transform transform5 = uIDrawCall.cachedTransform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 position3 = vector + 32;
			transform5.position = position3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Quaternion rotation2 = (Quaternion)(vector + 16);
			transform5.rotation = rotation2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			((Vector3*)(nint)vector)->x = 0f;
			transform5.localScale = vector;
			int num24 = num23 + startingRenderQueue;
			if (renderQueue == RenderQueue.Explicit)
			{
				num24 = startingRenderQueue;
			}
			uIDrawCall.renderQueue = num24;
			bool flag5 = (byte)(~(alwaysOnScreen ? 1u : 0u)) != 0;
			bool flag6 = false;
			if (!flag5)
			{
				bool flag7 = mClipping == UIDrawCall.Clipping.None;
				flag6 = true;
				if (!flag7)
				{
					flag6 = mClipping == UIDrawCall.Clipping.ConstrainButDontClip;
				}
			}
			uIDrawCall.alwaysOnScreen = flag6;
			uIDrawCall.sortingOrder = mSortingOrder;
			uIDrawCall.clipTexture = mClipTexture;
			int num25 = num23 + 1;
			num23 = num25;
		}
	}

	private void UpdateLayers()
	{
		GameObject gameObject = cachedGameObject;
		int layer = gameObject.layer;
		if (mLayer == layer)
		{
			return;
		}
		int layer2 = mGo.layer;
		mLayer = layer2;
		List<UIWidget> list = widgets;
		int num = 0;
		while (num < list._size)
		{
			UIWidget uIWidget = widgets.get_Item(num);
			if ((bool)uIWidget)
			{
				UIRect uIRect = uIWidget.parent;
				if (uIRect == this)
				{
					GameObject gameObject2 = uIWidget.gameObject;
					gameObject2.layer = mLayer;
				}
			}
			int num2 = num + 1;
			num = num2;
		}
		ResetAnchors();
		int num3 = 0;
		while (true)
		{
			List<UIDrawCall> list2 = drawCalls;
			if (num3 < list2._size)
			{
				UIDrawCall uIDrawCall = drawCalls.get_Item(num3);
				GameObject gameObject3 = uIDrawCall.gameObject;
				gameObject3.layer = mLayer;
				int num4 = num3 + 1;
				num3 = num4;
				continue;
			}
			break;
		}
	}

	private void UpdateWidgets()
	{
		//IL_000e: Expected Obj, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected I4, but got Unknown
		//IL_004c: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_00c3: Expected Obj, but got I4
		//IL_0415: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I4
		//IL_0322: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I4
		bool flag = hasCumulativeClipping;
		bool flag2 = default;
		if (~(cullWhileDragging ? 1u : 0u) != 0)
		{
			object obj = 0;
			object obj6 = default;
			while (true)
			{
				BetterList<UIScrollView> betterList = UIScrollView.list;
				if (betterList.size <= (nint)obj)
				{
					break;
				}
				BetterList<UIScrollView> betterList2 = UIScrollView.list;
				object obj2 = obj << 2;
				object obj3 = (object)betterList2.buffer + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v112+10]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v113+68]");
				if ((UnityEngine.Object)0 == this)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v113+88]");
					object obj5;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v113+C4]");
						obj5 = 0;
					}
					else
					{
						obj5 = 0;
					}
					obj6 = 1;
					if (obj5 == null)
					{
						obj6 = obj6;
					}
				}
				object obj7 = obj + 1;
				obj = obj7;
			}
			flag2 = (byte)(obj6 & 1) != 0;
		}
		if (flag2 != mForced)
		{
			mResized = true;
			mForced = flag2;
		}
		int frameCount = Time.frameCount;
		List<UIWidget> list = widgets;
		int num3;
		object obj8 = default;
		for (int num = 0; num < list._size; num3 = num + 1, num = num3)
		{
			UIWidget uIWidget = widgets.get_Item(num);
			if (!(uIWidget.panel == this) || !uIWidget.enabled)
			{
				continue;
			}
			bool visibleByAlpha;
			bool visibleByPanel;
			if (uIWidget.UpdateTransform(frameCount) || ~(mResized ? 1u : 0u) == 0)
			{
				if (flag2)
				{
					visibleByAlpha = true;
					goto IL_022a;
				}
				float num2 = uIWidget.CalculateCumulativeAlpha(frameCount);
				bool flag3 = num2 > 0.001f;
				if (!flag)
				{
					visibleByAlpha = flag3;
					if (!uIWidget.hideIfOffScreen)
					{
						goto IL_022a;
					}
				}
				visibleByPanel = IsVisible(uIWidget);
				visibleByAlpha = flag3;
				goto IL_0253;
			}
			goto IL_026e;
			IL_026e:
			if (!uIWidget.UpdateGeometry(frameCount))
			{
				continue;
			}
			obj8 = 1;
			if (!mRebuild)
			{
				if (uIWidget.drawCall != null)
				{
					UIDrawCall drawCall = uIWidget.drawCall;
					drawCall.isDirty = true;
					obj8 = 1;
				}
				else
				{
					UIDrawCall uIDrawCall = FindDrawCall(uIWidget);
					obj8 = 1;
				}
			}
			continue;
			IL_0253:
			bool flag4 = uIWidget.UpdateVisibility(visibleByAlpha, visibleByPanel);
			goto IL_026e;
			IL_022a:
			visibleByPanel = true;
			goto IL_0253;
		}
		if (obj8 != null)
		{
			OnGeometryUpdated onGeometryUpdated = this.onGeometryUpdated;
			if (this.onGeometryUpdated != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v152.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		mResized = false;
	}

	public UIDrawCall FindDrawCall(UIWidget w)
	{
		//IL_0225: Expected I, but got Obj
		//IL_0237: Expected I, but got Obj
		//IL_02e6: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		nint num = (nint)w;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIWidget>)+17C] (should have been resolved before IL gen)");
		nint num2 = (nint)w;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v6 (Il2CppClass<UIWidget>)+18C] (should have been resolved before IL gen)");
		int num3 = 0;
		UnityEngine.Object obj4 = default;
		UnityEngine.Object obj5 = default;
		UIDrawCall result;
		while (true)
		{
			List<UIDrawCall> list = drawCalls;
			UIDrawCall uIDrawCall;
			if (num3 < list._size)
			{
				uIDrawCall = drawCalls.get_Item(num3);
				object obj;
				if (num3 != 0)
				{
					int index = num3 - 1;
					UIDrawCall uIDrawCall2 = drawCalls.get_Item(index);
					obj = uIDrawCall2.depthEnd + 1;
				}
				else
				{
					obj = int.MinValue;
				}
				List<UIDrawCall> list2 = drawCalls;
				object obj2 = num3 + 1;
				bool flag;
				if (list2._size == (nint)obj2)
				{
					flag = false;
				}
				else
				{
					int index2 = num3 + 1;
					UIDrawCall uIDrawCall3 = drawCalls.get_Item(index2);
					object obj3 = uIDrawCall3.depthStart - 1;
					flag = w.mDepth > (nint)obj3;
				}
				if (w.mDepth < (nint)obj || flag)
				{
					int num4 = num3 + 1;
					num3 = num4;
					continue;
				}
				if (uIDrawCall.mMaterial == obj4 && uIDrawCall.mTexture == obj5)
				{
					bool isVisible = w.isVisible;
					bool flag2 = !isVisible;
					result = null;
					if (flag2)
					{
						break;
					}
					w.drawCall = uIDrawCall;
					UIGeometry geometry = w.geometry;
					bool flag3;
					if (w.geometry != null)
					{
						BetterList<Vector3> verts = geometry.verts;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v75 (BetterList`1<UnityEngine.Vector3>)+C]");
						flag3 = (nint)0 > (nint)0;
					}
					else
					{
						flag3 = false;
					}
					if (!flag3)
					{
						return uIDrawCall;
					}
					goto IL_02dd;
				}
			}
			uIDrawCall = null;
			goto IL_02dd;
			IL_02dd:
			object obj6 = 1;
			result = uIDrawCall;
			break;
		}
		return result;
	}

	public void AddWidget(UIWidget w)
	{
		mUpdateScroll = true;
		List<UIWidget> list = widgets;
		if (list._size == 0)
		{
			widgets.Add(w);
		}
		else if (~(mSortWidgets ? 1u : 0u) == 0)
		{
			widgets.Add(w);
			SortWidgets();
		}
		else
		{
			UIWidget right = widgets.get_Item(0);
			int num = UIWidget.PanelCompareFunc(w, right);
			List<UIWidget> list2 = widgets;
			if (num == -1)
			{
				list2.Insert(0, w);
			}
			else
			{
				int num2 = list2._size;
				while (num2 > 0)
				{
					int num3 = num2 - 1;
					UIWidget right2 = widgets.get_Item(num3);
					int num4 = UIWidget.PanelCompareFunc(w, right2);
					bool flag = num4 == -1;
					num2 = num3;
					if (!flag)
					{
						int index = num3 + 1;
						widgets.Insert(index, w);
						break;
					}
				}
			}
		}
		UIDrawCall uIDrawCall = FindDrawCall(w);
	}

	public void RemoveWidget(UIWidget w)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		if (widgets.Remove(w) && w.drawCall != null)
		{
			object obj = w + 240;
			UIDrawCall drawCall = w.drawCall;
			if (w.mDepth == drawCall.depthStart || w.mDepth == drawCall.depthEnd)
			{
				mRebuild = true;
			}
			drawCall.isDirty = true;
			obj = 0;
		}
	}

	public void Refresh()
	{
		mRebuild = true;
		mUpdateFrame = -1;
		List<UIPanel> list = UIPanel.list;
		if (list._size >= 1)
		{
			UIPanel uIPanel = UIPanel.list.get_Item(0);
			LateUpdate();
		}
	}

	public unsafe virtual Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01a7: Expected Obj, but got F4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01d1: Expected Obj, but got F4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_0200: Expected Obj, but got F4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0220: Expected Obj, but got F4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected F4, but got Unknown
		//IL_023f: Expected native int or pointer, but got VT
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected VT, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected VT, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected VT, but got Unknown
		//IL_0290: Expected native int or pointer, but got VT
		//IL_02ab: Expected F4, but got I
		//IL_02b3: Expected native int or pointer, but got VT
		//IL_02cd: Expected F4, but got I
		//IL_02c8: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 80);
		Vector4 vector2 = finalClipRegion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+48]");
		float num = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
		float num2 = 0f - num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+4C]");
		float num3 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+44]");
		float num4 = 0f - num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
		float num5 = 0f + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+44]");
		float num6 = 0f + num3;
		bool flag = (byte)(~(softBorderPadding ? 1u : 0u)) != 0;
		float num7 = num4;
		float num8 = num2;
		float num9 = num6;
		float num10 = num5;
		if (!flag)
		{
			bool flag2 = mClipping != UIDrawCall.Clipping.SoftClip;
			num7 = num4;
			num8 = num2;
			num9 = num6;
			num10 = num5;
			if (!flag2)
			{
				float num11 = num2 + (float)mClipSoftness;
				float num12 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIPanel)+DC]");
				float num13 = num12 + 0f;
				float num14 = num5 - (float)mClipSoftness;
				float num15 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIPanel)+DC]");
				float num16 = num15 - 0f;
				num7 = num13;
				num8 = num11;
				num9 = num16;
				num10 = num14;
			}
		}
		object obj2 = min.y << 32;
		object obj3 = obj2 | min.x;
		object obj4 = max.y << 32;
		object obj5 = obj4 | max.x;
		object obj6 = num7 << 32;
		object obj7 = num8 | obj6;
		object obj8 = num9 << 32;
		float x = num10 | obj8;
		((Vector2*)(nint)vector)->x = x;
		Vector2 minRect = vector + 24;
		Vector2 maxRect = vector + 16;
		Vector2 minArea = vector + 8;
		Vector2 vector3 = NGUIMath.ConstrainRect(minRect, maxRect, minArea, vector);
		Vector3 vector4 = default;
		((Vector3*)(nint)vector4)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
		float y = (nint)0 >> 32;
		((Vector3*)(nint)vector4)->y = y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
		((Vector3*)(nint)vector4)->x = 0f;
		return vector4;
	}

	public unsafe bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04b6: Expected F4, but got I
		//IL_04c6: Expected F4, but got I
		//IL_04d6: Expected F4, but got I
		//IL_04e6: Expected F4, but got I
		//IL_0504: Expected Obj, but got F4
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_0524: Expected Obj, but got F4
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected Obj, but got Unknown
		//IL_0054: Expected F4, but got I
		//IL_0064: Expected F4, but got I
		//IL_0074: Expected F4, but got I
		//IL_0084: Expected F4, but got I
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected VT, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected VT, but got Unknown
		//IL_00e0: Expected F4, but got I
		//IL_00f0: Expected F4, but got I
		//IL_0100: Expected F4, but got I
		//IL_0110: Expected F4, but got I
		//IL_039e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 160;
		Vector3 min = targetBounds.min;
		Vector3 max = targetBounds.max;
		float num = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
		float num2 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
		float num3 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
		float num4 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
		float num5 = 0f;
		if (mClipping == UIDrawCall.Clipping.None)
		{
			UIRoot uIRoot = root;
			bool flag = uIRoot != null;
			bool flag2 = !flag;
			num = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			num2 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
			num3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			num4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
			num5 = 0f;
			if (!flag2)
			{
				float pixelSizeAdjustment = uIRoot.pixelSizeAdjustment;
				if (pixelSizeAdjustment == 1f)
				{
					num = 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					num2 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
					num3 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					num4 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
					num5 = 0f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
					float num6 = 0f / pixelSizeAdjustment;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					float num7 = 0f / pixelSizeAdjustment;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
					float num8 = 0f / pixelSizeAdjustment;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					float num9 = 0f / pixelSizeAdjustment;
					num = pixelSizeAdjustment;
					num2 = num7;
					num3 = num6;
					num4 = num9;
					num5 = num8;
				}
			}
		}
		object obj3 = num5 << 32;
		object obj4 = num4 | obj3;
		object obj5 = num3 << 32;
		object obj6 = num2 | obj5;
		object obj7 = obj + 144;
		object obj8 = obj + 72;
		object obj9 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @538A");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
		float num10 = 0f * num;
		float num11 = num10 * num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
		float num12 = 0f * num;
		float num13 = num12 * num12;
		float num14 = num11 + num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
		float num15 = 0f * num;
		float num16 = num15 * num15;
		float num17 = num14 + num16;
		bool flag3 = num17 > 0f;
		bool flag4 = !flag3;
		bool result = false;
		if (!flag4)
		{
			if (immediate)
			{
				Vector3 localPosition = target.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				float num18 = 0f + num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
				float num19 = 0f + num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				float num20 = 0f + num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
				_ = 0;
				Vector3 localPosition2 = (Vector3)(obj + 32);
				target.localPosition = localPosition2;
				_ = targetBounds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [targetBounds @ L2 (UnityEngine.Bounds&)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				float num21 = 0f + num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
				float num22 = 0f + num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				float num23 = 0f + num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				ref Bounds reference = ref *(Bounds*)null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				SpringPosition component = target.GetComponent<SpringPosition>();
				if (component != null)
				{
					component.enabled = false;
				}
				UIPanelEvent uIPanelEvent = this.m_onConstrainedTargetToBounds;
				bool flag5 = this.m_onConstrainedTargetToBounds == null;
				result = true;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v321.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					result = true;
				}
			}
			else
			{
				GameObject go = target.gameObject;
				Vector3 localPosition3 = target.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				float num24 = 0f + num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
				float num25 = 0f + num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				float num26 = 0f + num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Vector3 pos = (Vector3)(obj + 48);
				SpringPosition springPosition = SpringPosition.Begin(go, pos, 13f);
				springPosition.worldSpace = false;
				result = true;
			}
		}
		return result;
	}

	public unsafe bool ConstrainTargetToBounds(Transform target, bool immediate)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		Transform relativeTo = cachedTransform;
		Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(relativeTo, target);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		return ConstrainTargetToBounds(target, ref *(Bounds*)(obj + 24), immediate);
	}

	public static UIPanel Find(Transform trans)
	{
		return Find(trans, createIfMissing: false, -1);
	}

	public static UIPanel Find(Transform trans, bool createIfMissing)
	{
		return Find(trans, createIfMissing, -1);
	}

	public static UIPanel Find(Transform trans, bool createIfMissing, int layer)
	{
		Transform transform = default;
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>(transform);
		bool flag = uIPanel == null;
		UIPanel result = uIPanel;
		if (flag)
		{
			Transform transform3 = default;
			while (true)
			{
				Transform transform2 = transform3.parent;
				if (!(transform2 != null))
				{
					break;
				}
				transform3 = transform.parent;
			}
			bool flag2 = !createIfMissing;
			result = null;
			if (!flag2)
			{
				UIPanel uIPanel2 = NGUITools.CreateUI(transform3, advanced3D: false, layer);
				result = uIPanel2;
			}
		}
		return result;
	}

	public unsafe Vector2 GetWindowSize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009b: Expected F4, but got I
		//IL_00ab: Expected F4, but got I
		//IL_0138: Expected native int or pointer, but got VT
		//IL_0145: Expected native int or pointer, but got VT
		//IL_0078: Expected I4, but got F8
		object obj2 = default;
		object obj = obj2 - 16;
		UIRoot uIRoot = root;
		Vector2 screenSize = NGUITools.screenSize;
		float x;
		float y;
		if (!(uIRoot != null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			x = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			y = 0f;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num2 = default;
			double num = Math.Abs(num2);
			int num3 = ((!(num < 2147483648.0)) ? int.MinValue : ((int)num2));
			float pixelSizeAdjustment = uIRoot.GetPixelSizeAdjustment(num3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			float num4 = 0f * pixelSizeAdjustment;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			y = 0f * pixelSizeAdjustment;
			x = num4;
		}
		Vector2 vector = default;
		((Vector2*)(nint)vector)->y = y;
		((Vector2*)(nint)vector)->x = x;
		return vector;
	}

	public unsafe Vector2 GetViewSize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0050: Expected F4, but got I
		//IL_004b: Expected native int or pointer, but got VT
		//IL_0028: Expected F4, but got I
		//IL_0023: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Vector2 vector = default;
		if (mClipping != UIDrawCall.Clipping.None)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIPanel)+D0]");
			((Vector2*)(nint)vector)->x = 0f;
		}
		else
		{
			Vector2 screenSize = NGUITools.screenSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((Vector2*)(nint)vector)->x = 0f;
		}
		return vector;
	}

	public UIPanel()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_00a9: Expected VT, but got I8
		//IL_00be: Expected VT, but got I4
		//IL_00de: Expected VT, but got I4
		List<UIWidget> list = default;
		list._002Ector();
		widgets = list;
		List<UIDrawCall> list2 = default;
		list2._002Ector();
		drawCalls = list2;
		object obj = this + 104;
		nint num = (nint)typeof(Matrix4x4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v15 (Il2CppClass<UnityEngine.Matrix4x4>)+5C]");
		object obj2 = -(-64);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2AB");
		mClipSoftness = (Vector2)4647714816528482304L;
		_ = 4848124999998242816L;
		mClipRange = (Vector4)0;
		mAlpha = 1f;
		_ = 4575657222473777152L;
		drawCallClipRange = (Vector4)0;
		mLayer = -1;
		mMatrixFrame = -1;
		mClipOffset = Vector2.zeroVector;
		mMin = Vector2.zeroVector;
		mMax = Vector2.zeroVector;
		base._002Ector();
	}

	static UIPanel()
	{
		List<UIPanel> list = default;
		list._002Ector();
		UIPanel.list = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		float[] array = default;
		mTemp = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Vector3[] array2 = default;
		mCorners = array2;
		mUpdateFrame = -1;
	}
}
