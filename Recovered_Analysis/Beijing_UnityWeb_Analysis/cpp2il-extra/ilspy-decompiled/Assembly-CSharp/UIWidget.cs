using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using InAppPurchase;
using Kiloo.Common.Extensions;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

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

	public delegate void OnPostFillCallback(UIWidget widget, int bufferOffset, List<Vector3> verts, List<Vector2> uvs, List<Color> cols);

	public enum AspectRatioSource
	{
		Free,
		BasedOnWidth,
		BasedOnHeight
	}

	public delegate bool HitCheck(Vector3 worldPos);

	protected Color mColor;

	protected Pivot mPivot;

	protected int mWidth;

	protected int mHeight;

	protected int mDepth;

	protected Material mMat;

	public OnDimensionsChanged onChange;

	public OnPostFillCallback onPostFill;

	public UIDrawCall.OnRenderCallback mOnRender;

	public bool autoResizeBoxCollider;

	public bool hideIfOffScreen;

	public AspectRatioSource keepAspectRatio;

	public float aspectRatio;

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
			//IL_0250: Expected I, but got Obj
			//IL_0266: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			//IL_0102: Expected I, but got Obj
			//IL_0118: Expected Obj, but got I
			//IL_0143: Expected I, but got Obj
			//IL_019a: Expected I, but got Obj
			//IL_01b0: Expected Obj, but got I
			//IL_01db: Expected I, but got Obj
			AnchorPoint anchorPoint = leftAnchor;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint.target))
			{
				AnchorPoint anchorPoint2 = rightAnchor;
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint2.target))
				{
					AnchorPoint anchorPoint3 = topAnchor;
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint3.target))
					{
						AnchorPoint anchorPoint4 = bottomAnchor;
						nint num7 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num8 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint4.target))
						{
							return null;
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			UIDrawCall.OnRenderCallback result = default;
			return result;
		}
		set
		{
			//IL_01bc: Expected I, but got Obj
			//IL_01d2: Expected Obj, but got I
			//IL_0248: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01fe: Expected Obj, but got I
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Expected Obj, but got Unknown
			//IL_01a9: Expected Obj, but got I4
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected Obj, but got I
			//IL_0112: Expected I, but got Obj
			//IL_0128: Expected Obj, but got I
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Expected Obj, but got Unknown
			//IL_0227: Expected Obj, but got I4
			//IL_0153: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)(nint)((Delegate)value).method_ptr == null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(nint)((Delegate)value).method).FindKernel(null) == 0)
				{
					string text = ((Component)(nint)((Delegate)value).method_ptr).tag;
					bool activeSelf = ((GameObject)(object)text).activeSelf;
					nint num5 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v26 (Il2CppClass<NGUITools>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v32 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj4 = value + 24;
					string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
					obj4 = typeName;
					return;
				}
			}
			object obj5 = value + 24;
			obj5 = 0;
		}
	}

	public Vector4 drawRegion
	{
		get
		{
			//IL_01f7: Expected VT, but got Obj
			//IL_01f7: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_022f: Expected Obj, but got I
			//IL_0259: Unknown result type (might be due to invalid IL or missing references)
			//IL_025e: Expected Obj, but got Unknown
			//IL_0271: Expected I, but got Obj
			//IL_0287: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_02b6: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I
			//IL_0156: Expected I, but got Obj
			//IL_01a5: Expected VT, but got I
			//IL_01b7: Expected Obj, but got I
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Expected Obj, but got Unknown
			//IL_00fd: Expected Obj, but got I
			//IL_011a: Expected Obj, but got I
			//IL_011a: Expected Obj, but got I
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector4)+7C]");
			object realObject = ((System.DelegateSerializationHolder)0).GetRealObject((StreamingContext)this);
			Vector4 vector2 = default;
			if (realObject != null)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector4)+F8]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector4)+F8]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v25+7C]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector4)+7C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector4)+F8]");
							object obj3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v30+7C]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector4)+7C]");
							Delegate obj4 = ((Delegate)num3).RemoveImpl((Delegate)0);
							object obj5 = obj3 + 124;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
							object obj6 = default;
							obj5 = obj6;
						}
					}
				}
				Vector4 vector = default;
				object obj7 = vector + 124;
				obj7 = this;
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector4)+F8]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector4)+F8]");
					vector2 = (Vector4)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v19 (UnityEngine.Vector4)+7C]");
					Delegate obj9 = ((Delegate)0).CombineImpl((Delegate)(object)this);
					object obj10 = vector2 + 124;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
					object obj11 = default;
					obj10 = obj11;
				}
			}
			return vector2;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 156;
			UIWidget uIWidget = (UIWidget)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public Vector2 pivotOffset
	{
		get
		{
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected Obj, but got Unknown
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected Obj, but got Unknown
			//IL_0118: Expected I, but got Obj
			//IL_012e: Expected Obj, but got I
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected Obj, but got Unknown
			//IL_0176: Expected VT, but got I
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected Obj, but got Unknown
			//IL_01a1: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0066: Expected Obj, but got I
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected Obj, but got Unknown
			//IL_00b4: Expected Obj, but got VT
			object obj2 = default;
			object obj = obj2 + 16;
			Vector2 vector = default;
			object obj3 = vector + 156;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
			_ = 0;
			obj2 = this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v14 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v38 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PlayerConnection._003CRegister_003Ec__AnonStorey0 obj5 = (PlayerConnection._003CRegister_003Ec__AnonStorey0)(obj2 + 32);
			obj5 = (PlayerConnection._003CRegister_003Ec__AnonStorey0)obj;
			PlayerConnection._003CRegister_003Ec__AnonStorey0 obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			obj6.messageId = (Guid)0;
			UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers messageTypeSubscribers = (UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers)(obj2 + 48);
			messageTypeSubscribers = (UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers)obj2;
			UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers messageTypeSubscribers2 = messageTypeSubscribers;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			messageTypeSubscribers2.m_messageTypeId = (string)0;
			if (obj5._003C_003Em__0(messageTypeSubscribers))
			{
				messageTypeSubscribers = (UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers)(object)this;
				messageTypeSubscribers.m_messageTypeId = (string)(nint)((UnityEngine.Object)this).m_CachedPtr;
				object obj7 = vector + 156;
				obj7 = messageTypeSubscribers;
				_ = messageTypeSubscribers.m_messageTypeId;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+80]");
				if ((nint)0 != 0)
				{
					((UIWidget)vector).SetDirty();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			return vector;
		}
	}

	public int width
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)mOnRender;
		}
		set
		{
			//IL_0012: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+60]");
			NGUIMath.OverlayPosition((Transform)(object)this, (Transform)0);
		}
	}

	public int height
	{
		get
		{
			return mWidth;
		}
		set
		{
			//IL_00a1: Expected I, but got Obj
			//IL_00b7: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I4
			//IL_0080: Expected Obj, but got I4
			//IL_04a6: Expected I, but got Obj
			//IL_04bc: Expected Obj, but got I
			//IL_00e2: Expected I, but got Obj
			//IL_0139: Expected I, but got Obj
			//IL_014f: Expected Obj, but got I
			//IL_0358: Expected I, but got Obj
			//IL_017a: Expected I, but got Obj
			//IL_02c8: Expected Obj, but got I4
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Expected Obj, but got Unknown
			//IL_0308: Unknown result type (might be due to invalid IL or missing references)
			//IL_030d: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			int num = default;
			bool flag = num <= value;
			bool flag2 = !flag;
			int num2 = num;
			if (!flag2)
			{
				num2 = value;
			}
			if (mWidth == num2 || keepAspectRatio == AspectRatioSource.BasedOnHeight)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj = default;
			if (obj == null)
			{
				Bounds bounds = ((UIWidget)num2).CalculateBounds((Transform)mHeight);
				return;
			}
			AnchorPoint anchorPoint = leftAnchor;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)anchorPoint.target).FindKernel((string)null) != 0)
			{
				AnchorPoint anchorPoint2 = rightAnchor;
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)anchorPoint2.target).FindKernel((string)null) != 0)
				{
					if (mPivot != Pivot.BottomLeft && mPivot != Pivot.Left && mPivot != Pivot.TopLeft)
					{
						if (mPivot != Pivot.BottomRight && mPivot != Pivot.Right && mPivot != Pivot.TopRight)
						{
							object obj4 = num2 - mWidth;
							object obj5 = obj4 & 1;
							object obj6 = obj4 - obj5;
							if (obj4 != obj5)
							{
								object obj7 = 0 - obj6;
								float x = (float)obj7 * 0.5f;
								float num7 = (float)obj6 * 0.5f;
								SetRect(x, 0f, num7, 0f);
							}
						}
						else
						{
							float x2 = (float)mWidth - (float)num2;
							SetRect(x2, 0f, 0f, 0f);
						}
					}
					else
					{
						float num8 = (float)num2 - (float)mWidth;
						SetRect(0f, 0f, num8, 0f);
					}
					return;
				}
			}
			AnchorPoint anchorPoint3 = leftAnchor;
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)anchorPoint3.target).FindKernel((string)null) != 0)
			{
				float num11 = (float)num2 - (float)mWidth;
				SetRect(0f, 0f, num11, 0f);
			}
			else
			{
				float x3 = (float)mWidth - (float)num2;
				SetRect(x3, 0f, 0f, 0f);
			}
		}
	}

	public Color color
	{
		get
		{
			//IL_00a2: Expected Obj, but got I
			//IL_00b0: Expected I, but got Obj
			//IL_00c6: Expected Obj, but got I
			//IL_04cb: Expected Obj, but got I
			//IL_0089: Expected Obj, but got I
			//IL_04fc: Expected Obj, but got I
			//IL_050a: Expected I, but got Obj
			//IL_0520: Expected Obj, but got I
			//IL_00f1: Expected I, but got Obj
			//IL_05f2: Expected Obj, but got I
			//IL_0140: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0444: Expected Obj, but got VT
			//IL_039a: Expected I, but got Obj
			//IL_054f: Expected Obj, but got I
			//IL_040c: Expected Obj, but got VT
			//IL_018f: Expected I, but got Obj
			//IL_05a3: Expected Obj, but got VT
			//IL_05db: Expected Obj, but got VT
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Expected Obj, but got Unknown
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Expected Obj, but got Unknown
			//IL_0347: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Expected Obj, but got Unknown
			//IL_0387: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			UIWidget uIWidget = default;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<UIWidget, UIntPtr>(ref uIWidget) <= System.Runtime.CompilerServices.Unsafe.As<UIWidget, UIntPtr>(ref this);
			bool flag2 = !flag;
			UIWidget uIWidget2 = uIWidget;
			if (!flag2)
			{
				uIWidget2 = this;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+68]");
			Color color = default;
			if (0 != (nint)uIWidget2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+84]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object obj = default;
					if (obj == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+64]");
						Bounds bounds = ((UIWidget)0).CalculateBounds((Transform)(object)uIWidget2);
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+14]");
						object obj2 = 0;
						nint num = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num2 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v20+8]");
						if (((ComputeShader)0).FindKernel(null) != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+18]");
							object obj4 = 0;
							nint num3 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj5 = (nint)0 & (nint)0x200;
							if (obj5 != null)
							{
								nint num4 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v31+8]");
							if (((ComputeShader)0).FindKernel(null) != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+60]");
								if ((nint)0 != 6)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+60]");
									if ((nint)0 != 7)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+60]");
										if ((nint)0 != 8)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+60]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+60]");
												if ((nint)0 != 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+60]");
													if ((nint)0 != 2)
													{
														UIWidget uIWidget3 = uIWidget2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+68]");
														object obj6 = uIWidget3 - 0;
														object obj7 = obj6 & 1;
														object obj8 = obj6 - obj7;
														if (obj6 != obj7)
														{
															object obj9 = 0 - obj8;
															float y = (float)obj9 * 0.5f;
															float num5 = (float)obj8 * 0.5f;
															((UIWidget)color).SetRect(0f, y, 0f, num5);
														}
														goto IL_04b4;
													}
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+68]");
											float y2 = 0f - (float)uIWidget2;
											((UIWidget)color).SetRect(0f, y2, 0f, 0f);
											goto IL_04b4;
										}
									}
								}
								float num6 = (float)uIWidget2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+68]");
								float num7 = num6 - 0f;
								((UIWidget)color).SetRect(0f, 0f, 0f, num7);
								goto IL_04b4;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+14]");
						object obj10 = 0;
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num9 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v25+8]");
						if (((ComputeShader)0).FindKernel(null) != 0)
						{
							float num10 = (float)uIWidget2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+68]");
							float num11 = num10 - 0f;
							((UIWidget)color).SetRect(0f, 0f, 0f, num11);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+68]");
							float y3 = 0f - (float)uIWidget2;
							((UIWidget)color).SetRect(0f, y3, 0f, 0f);
						}
					}
				}
			}
			goto IL_04b4;
			IL_04b4:
			return color;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 80;
			UIWidget uIWidget = (UIWidget)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public unsafe override float alpha
	{
		get
		{
			//IL_0327: Unknown result type (might be due to invalid IL or missing references)
			//IL_032c: Expected Obj, but got Unknown
			//IL_0335: Expected Obj, but got I4
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Expected Obj, but got Unknown
			//IL_0352: Expected Obj, but got I4
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_036c: Expected Obj, but got Unknown
			//IL_0375: Expected Obj, but got F4
			//IL_038d: Expected I, but got Obj
			//IL_03a3: Expected Obj, but got I
			//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ce: Expected VT, but got Unknown
			//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Expected VT, but got Unknown
			//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Expected Obj, but got Unknown
			//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f8: Expected Obj, but got Unknown
			//IL_0401: Unknown result type (might be due to invalid IL or missing references)
			//IL_0406: Expected VT, but got Unknown
			//IL_040f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0414: Expected Obj, but got Unknown
			//IL_041d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0422: Expected Obj, but got Unknown
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0430: Expected Obj, but got Unknown
			//IL_0439: Unknown result type (might be due to invalid IL or missing references)
			//IL_043e: Expected Obj, but got Unknown
			//IL_0448: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0491: Expected I, but got Obj
			//IL_04a7: Expected Obj, but got I
			//IL_02df: Expected I, but got Obj
			//IL_00c2: Expected VT, but got Obj
			//IL_00d0: Expected I, but got Obj
			//IL_00e6: Expected Obj, but got I
			//IL_04db: Expected I, but got Obj
			//IL_04f1: Expected Obj, but got I
			//IL_051b: Expected F4, but got Obj
			//IL_0516: Expected native int or pointer, but got VT
			//IL_052d: Expected F4, but got I
			//IL_0528: Expected native int or pointer, but got VT
			//IL_053a: Expected F4, but got Obj
			//IL_0535: Expected native int or pointer, but got VT
			//IL_054f: Expected F4, but got I
			//IL_054a: Expected native int or pointer, but got VT
			//IL_0560: Expected Ref, but got VT
			//IL_056d: Expected VT, but got Obj
			//IL_057a: Expected native int or pointer, but got VT
			//IL_058c: Expected native int or pointer, but got VT
			//IL_059e: Expected F4, but got Obj
			//IL_0599: Expected native int or pointer, but got VT
			//IL_05b0: Expected F4, but got I
			//IL_05ab: Expected native int or pointer, but got VT
			//IL_0111: Expected I, but got Obj
			//IL_01aa: Expected VT, but got Obj
			//IL_01b7: Expected VT, but got Obj
			//IL_015e: Expected I, but got Obj
			//IL_01d2: Expected F4, but got Obj
			//IL_01cd: Expected native int or pointer, but got VT
			//IL_01e4: Expected F4, but got I
			//IL_01df: Expected native int or pointer, but got VT
			//IL_01f1: Expected F4, but got Obj
			//IL_01ec: Expected native int or pointer, but got VT
			//IL_0206: Expected F4, but got I
			//IL_0201: Expected native int or pointer, but got VT
			//IL_0217: Expected Ref, but got VT
			//IL_0229: Expected F4, but got Obj
			//IL_0224: Expected native int or pointer, but got VT
			//IL_023b: Expected F4, but got I
			//IL_0236: Expected native int or pointer, but got VT
			//IL_0248: Expected native int or pointer, but got VT
			//IL_025a: Expected native int or pointer, but got VT
			//IL_0276: Expected F4, but got Obj
			//IL_0271: Expected native int or pointer, but got VT
			//IL_028b: Expected F4, but got I
			//IL_0286: Expected native int or pointer, but got VT
			//IL_02cc: Expected F4, but got Obj
			Quaternion quaternion = default;
			object obj = quaternion + 136;
			obj = 0;
			_ = 0;
			object obj2 = quaternion + 112;
			obj2 = 0;
			_ = 0;
			_ = 0;
			object obj3 = quaternion + 104;
			obj3 = 0f;
			bool flag = isFullyAnchored;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v111 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = (Vector3)(quaternion + 168);
			Vector3 vector2 = (Vector3)(quaternion + 152);
			Transform transform = (Transform)(quaternion + 88);
			object obj5 = quaternion + 76;
			Quaternion quaternion2 = (Quaternion)(quaternion - -64);
			Transform transform2 = (Transform)(quaternion + 52);
			Transform transform3 = (Transform)(quaternion + 40);
			Transform transform4 = (Transform)(quaternion + 24);
			object obj6 = quaternion + 12;
			if ((UnityEngine.Object)flag != null)
			{
				return 0f;
			}
			if (mCam.transparencySortMode == TransparencySortMode.Default)
			{
				Camera camera = anchorCamera;
				GameObject gameObject = mCam.gameObject;
				transform.rotation = (Quaternion)camera;
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v61 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v106 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 up = Vector3.up;
				nint num5 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v67 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num6 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v102 (Il2CppClass<UnityEngine.Quaternion>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)transform;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v31+8]");
				((Vector3*)(nint)vector)->z = 0f;
				((Quaternion*)quaternion2)->SetLookRotation(vector2, vector);
				transform2.position = (Vector3)camera;
				((Vector3*)(nint)vector2)->x = quaternion2.x;
				((Vector3*)(nint)vector2)->z = quaternion2.z;
				((Vector3*)(nint)vector)->x = (float)transform2;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D0");
				transform3.position = (Vector3)gameObject;
				transform4.rotation = (Quaternion)gameObject;
				Vector3 back = Vector3.back;
				((Vector3*)(nint)vector2)->x = (float)transform4;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform4).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v41+8]");
				((Vector3*)(nint)vector)->z = 0f;
				((Quaternion*)quaternion)->SetLookRotation(vector2, vector);
				((Vector3*)(nint)vector2)->x = (float)transform3;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
				((Vector3*)(nint)vector)->x = quaternion.x;
				((Vector3*)(nint)vector)->z = quaternion.z;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F967");
				((Vector3*)(nint)vector)->x = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D6");
				object obj9 = default;
				if (obj9 != null)
				{
					return (float)obj3;
				}
			}
			float farClipPlane = mCam.farClipPlane;
			float fieldOfView = mCam.fieldOfView;
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S2_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S2_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return Mathf.LerpUnclamped(farClipPlane, fieldOfView, 0.5f);
		}
		set
		{
			UIEventListener uIEventListener = UIEventListener.Get((GameObject)(object)this);
			if ((object)uIEventListener != null && mChildren != null)
			{
				string text = tag;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A07B");
			}
		}
	}

	public bool isVisible => (byte)mHeight != 0;

	public bool hasVertices
	{
		get
		{
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_00b0: Expected I, but got Obj
			if (~(mIsVisibleByPanel ? 1u : 0u) == 0)
			{
				if (~(mIsVisibleByAlpha ? 1u : 0u) == 0)
				{
					if (~(mIsInFront ? 1u : 0u) == 0)
					{
						if (finalAlpha > 0.001f)
						{
							nint num = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v23 (Il2CppClass<NGUITools>)+BA]");
							object obj = (nint)0 & (nint)0x200;
							if (obj != null)
							{
								nint num2 = (nint)typeof(NGUITools);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v29 (Il2CppClass<NGUITools>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							return NGUITools.GetActive((GameObject)(object)this);
						}
						return false;
					}
					return false;
				}
				return false;
			}
			return false;
		}
	}

	public unsafe Pivot rawPivot
	{
		get
		{
			if (geometry != null)
			{
				return geometry.hasTransformed ? Pivot.Top : Pivot.TopLeft;
			}
			return Pivot.TopLeft;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected Obj, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected I, but got Unknown
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected Obj, but got Unknown
			//IL_00ba: Expected Obj, but got I4
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected Obj, but got Unknown
			//IL_0127: Expected Obj, but got I
			object obj = this + 80;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
			_ = 0;
			Gradient gradient = (Gradient)(obj2 + 16);
			gradient = (Gradient)obj2;
			Gradient gradient2 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			gradient2.m_Ptr = (IntPtr)0;
			nint num = (nint)(obj2 + 32);
			((IntPtr*)num)->m_value = (void*)((Pivot*)(int)value)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UIWidget+Pivot)+8]");
			_ = 0;
			if (gradient.Internal_Equals((IntPtr)num))
			{
				object obj3 = this + 80;
				gradient = (Gradient)((Pivot*)(int)value)->value__;
				Gradient gradient3 = gradient;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UIWidget+Pivot)+8]");
				gradient3.m_Ptr = (IntPtr)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v17+C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v7 (UnityEngine.Gradient)+C]");
				bool flag = num2 != 0;
				((IntPtr*)num)->m_value = (void*)((Pivot*)(int)value)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UIWidget+Pivot)+8]");
				_ = 0;
				object obj4 = this + 80;
				obj4 = (object)((IntPtr*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v10 (System.IntPtr)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
		}
	}

	public Pivot pivot
	{
		get
		{
			return mPivot;
		}
		set
		{
			if (mPivot != value)
			{
				mPivot = value;
				if (~(autoResizeBoxCollider ? 1u : 0u) == 0)
				{
					SetDirty();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public int depth
	{
		get
		{
			return (int)mPivot;
		}
		set
		{
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Expected Obj, but got Unknown
			//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e7: Expected Obj, but got Unknown
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Expected Obj, but got Unknown
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Expected Obj, but got Unknown
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0311: Expected Obj, but got Unknown
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			//IL_031f: Expected Obj, but got Unknown
			//IL_0328: Unknown result type (might be due to invalid IL or missing references)
			//IL_032d: Expected Obj, but got Unknown
			//IL_0336: Unknown result type (might be due to invalid IL or missing references)
			//IL_033b: Expected Obj, but got Unknown
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Expected Obj, but got Unknown
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Expected Obj, but got Unknown
			//IL_0360: Unknown result type (might be due to invalid IL or missing references)
			//IL_0365: Expected Obj, but got Unknown
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Expected Obj, but got Unknown
			//IL_037c: Expected Obj, but got I4
			//IL_038b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0390: Expected Obj, but got Unknown
			//IL_0399: Expected Obj, but got I4
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ad: Expected Obj, but got Unknown
			//IL_03b6: Expected Obj, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected Obj, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected Obj, but got Unknown
			//IL_00ba: Expected VT, but got Obj
			//IL_00de: Expected VT, but got Obj
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected Obj, but got Unknown
			//IL_017f: Expected Obj, but got I
			//IL_01e9: Expected VT, but got Obj
			//IL_021b: Expected I, but got Obj
			//IL_0231: Expected Obj, but got I
			//IL_025c: Expected I, but got Obj
			object obj = default;
			Transform transform = (Transform)(obj + 168);
			object obj2 = obj + 120;
			object obj3 = obj + 108;
			Transform transform2 = (Transform)(obj + 96);
			Transform transform3 = (Transform)(obj + 84);
			object obj4 = obj + 72;
			object obj5 = obj + 60;
			object obj6 = obj + 48;
			object obj7 = obj + 36;
			Transform transform4 = (Transform)(obj + 24);
			object obj8 = obj + 12;
			object obj9 = obj + 156;
			obj9 = 0;
			_ = 0;
			object obj10 = obj + 144;
			obj10 = 0;
			_ = 0;
			object obj11 = obj + 132;
			obj11 = 0;
			_ = 0;
			if (mPivot == (Pivot)value)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj13 = default;
			object obj12 = obj13 + 16;
			obj2 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v27+8]");
			_ = 0;
			obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			mPivot = (Pivot)value;
			mChanged = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj15 = default;
			object obj14 = obj15 + 16;
			obj3 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v39+8]");
			_ = 0;
			obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			Camera camera = anchorCamera;
			transform2.position = (Vector3)camera;
			obj11 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			transform3.localPosition = (Vector3)camera;
			obj4 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
			_ = 0;
			obj5 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v34+8]");
			_ = 0;
			object obj16 = obj4 - obj5;
			object obj17 = obj11 + obj16;
			obj11 = obj17;
			object obj18 = obj11 + 4;
			obj6 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
			_ = 0;
			obj7 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v34+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+4]");
			object obj19 = num - 0;
			object obj20 = obj18 + obj19;
			obj18 = obj20;
			Camera camera2 = anchorCamera;
			transform = (Transform)obj11;
			Transform transform5 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v37+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = transform.localPosition;
			Camera camera3 = anchorCamera;
			transform4.localPosition = (Vector3)camera3;
			obj11 = transform4;
			_ = ((UnityEngine.Object)transform4).m_CachedPtr;
			obj8 = transform4;
			_ = ((UnityEngine.Object)transform4).m_CachedPtr;
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v89 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v100 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
			object obj22 = default;
			obj11 = obj22;
			obj = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v37+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			Camera camera4 = anchorCamera;
			transform = (Transform)obj11;
			Transform transform6 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v37+8]");
			((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
		}
	}

	public int raycastDepth => mDepth;

	public override Vector3[] localCorners
	{
		get
		{
			//IL_0136: Expected I, but got Obj
			//IL_014c: Expected Obj, but got I
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0192: Expected Obj, but got I4
			//IL_00b0: Expected I, but got Obj
			//IL_010c: Expected Obj, but got I4
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (panel != null)
			{
				int num3 = minWidth;
			}
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num6 = ((ComputeShader)(object)panel).FindKernel((string)null);
			bool flag = num6 == 0;
			Vector3[] result = (Vector3[])mDepth;
			if (!flag)
			{
				UIPanel uIPanel = panel;
				object obj3 = uIPanel.mDepth * 1000;
				Vector3[] array = (Vector3[])(obj3 + mDepth);
				result = array;
			}
			return result;
		}
	}

	public virtual Vector2 localSize
	{
		get
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_01ed: Expected Obj, but got I
			//IL_00b5: Expected I, but got Obj
			//IL_00cb: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_0220: Expected Obj, but got I
			//IL_009c: Expected Obj, but got VT
			//IL_00f6: Expected I, but got Obj
			//IL_014a: Expected Obj, but got VT
			//IL_014a: Expected Obj, but got I
			//IL_0191: Expected Obj, but got I
			//IL_01a1: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+6C]");
			Vector2 vector = default;
			if (0 != (nint)this)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+90]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Vector2 windowSize = ((UIPanel)vector).GetWindowSize();
				}
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+90]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+90]");
					((UIPanel)0).RemoveWidget((UIWidget)vector);
					if (Application.platform == RuntimePlatform.OSXEditor)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+90]");
						((UIPanel)0).FillAllDrawCalls();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+90]");
						object obj3 = 0;
						_ = 1;
					}
				}
			}
			return vector;
		}
	}

	public unsafe Vector3 localCenter
	{
		get
		{
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected Obj, but got Unknown
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected Obj, but got Unknown
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected Obj, but got Unknown
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected Obj, but got Unknown
			//IL_0119: Expected I, but got Obj
			//IL_012f: Expected Obj, but got I
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected VT, but got Unknown
			//IL_0167: Expected F4, but got Obj
			//IL_0162: Expected native int or pointer, but got VT
			//IL_017c: Expected F4, but got I
			//IL_0177: Expected native int or pointer, but got VT
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected VT, but got Unknown
			//IL_0197: Expected F4, but got Obj
			//IL_0192: Expected native int or pointer, but got VT
			//IL_01ac: Expected F4, but got I
			//IL_01a7: Expected native int or pointer, but got VT
			//IL_01cb: Expected I, but got Obj
			//IL_01e1: Expected Obj, but got I
			//IL_020b: Expected F4, but got Obj
			//IL_0206: Expected native int or pointer, but got VT
			//IL_0220: Expected F4, but got I
			//IL_021b: Expected native int or pointer, but got VT
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj4 = default;
			object obj3 = obj4 + 40;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v6+8]");
			_ = 0;
			object obj5 = obj2 + 12;
			object obj6 = obj4 + 16;
			obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v12+8]");
			_ = 0;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v15 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v39 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = (Vector3)(obj2 + 36);
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector2 = (Vector3)(obj2 + 48);
			((Vector3*)(nint)vector2)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v12+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
			nint num3 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v27 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v35 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Vector3 vector3 = (Vector2)vector2;
			Vector3 result = default;
			return result;
		}
	}

	public override Vector3[] worldCorners
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0018: Expected I4, but got Obj
			//IL_0024: Unsupported input type for neg.
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected Obj, but got Unknown
			//IL_0058: Expected Obj, but got I
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected Obj, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected Obj, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected Obj, but got Unknown
			//IL_008d: Expected Obj, but got I4
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected Obj, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected Obj, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected Obj, but got Unknown
			//IL_0105: Expected Obj, but got I4
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected Obj, but got Unknown
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected Obj, but got Unknown
			//IL_016f: Expected Obj, but got I4
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Expected Obj, but got Unknown
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Expected Obj, but got Unknown
			//IL_01d9: Expected Obj, but got I4
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Expected Obj, but got Unknown
			object obj = default;
			UIWidget uIWidget = (UIWidget)(obj + 8);
			uIWidget.width = (int)this;
			obj = uIWidget;
			object obj2 = 0 - obj;
			object obj3 = obj2 * mWidth;
			object obj4 = obj3 + mWidth;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj5 = -0;
			object obj6 = obj5 * mHeight;
			object obj7 = obj6 + mHeight;
			object obj8 = obj + 52;
			obj8 = 0;
			_ = 0;
			obj8 = obj3;
			_ = 0f;
			object obj9 = obj - -64;
			obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v15+8]");
			_ = 0;
			object obj10 = mCorners + 16;
			obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v21+8]");
			_ = 0;
			object obj11 = obj + 40;
			obj11 = 0;
			_ = 0;
			obj11 = obj3;
			_ = 0f;
			obj9 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v29+8]");
			_ = 0;
			object obj12 = mCorners + 28;
			obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v21+8]");
			_ = 0;
			object obj13 = obj + 28;
			obj13 = 0;
			_ = 0;
			obj13 = obj4;
			_ = 0f;
			obj9 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v42+8]");
			_ = 0;
			object obj14 = mCorners + 40;
			obj14 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v21+8]");
			_ = 0;
			object obj15 = obj + 16;
			obj15 = 0;
			_ = 0;
			obj15 = obj4;
			_ = 0f;
			obj9 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v55+8]");
			_ = 0;
			object obj16 = mCorners + 52;
			obj16 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v21+8]");
			_ = 0;
			return mCorners;
		}
	}

	public unsafe Vector3 worldCenter
	{
		get
		{
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected Obj, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected Obj, but got Unknown
			//IL_00be: Expected I, but got Obj
			//IL_00d4: Expected Obj, but got I
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected VT, but got Unknown
			//IL_010c: Expected F4, but got Obj
			//IL_0107: Expected native int or pointer, but got VT
			//IL_0121: Expected F4, but got I
			//IL_011c: Expected native int or pointer, but got VT
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Expected VT, but got Unknown
			//IL_013c: Expected F4, but got Obj
			//IL_0137: Expected native int or pointer, but got VT
			//IL_0151: Expected F4, but got I
			//IL_014c: Expected native int or pointer, but got VT
			//IL_0013: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj4 = default;
			object obj3 = obj4 + 16;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v6+8]");
			_ = 0;
			object obj5 = obj4 + 40;
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11+8]");
			_ = 0;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v14 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v26 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = (Vector3)(obj2 + 24);
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector2 = (Vector3)(obj2 + 36);
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Vector3 vector3 = Vector3.LerpUnclamped(vector, vector2, 0.5f);
			Vector3 result = default;
			return result;
		}
	}

	public unsafe virtual Vector4 drawingDimensions
	{
		get
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected VT, but got Unknown
			//IL_0034: Expected F4, but got Obj
			//IL_002f: Expected native int or pointer, but got VT
			//IL_0049: Expected F4, but got I
			//IL_0044: Expected native int or pointer, but got VT
			Camera camera = anchorCamera;
			Vector3 vector = worldCenter;
			object obj = default;
			Vector3 vector2 = (Vector3)(obj + 12);
			((Vector3*)(nint)vector2)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Vector3 vector3 = ((Transform)(object)camera).InverseTransformPoint(vector2);
			Vector4 result = default;
			return result;
		}
	}

	public virtual Material material
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0018: Expected I4, but got Obj
			//IL_0024: Unsupported input type for neg.
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected Obj, but got Unknown
			//IL_0058: Expected Obj, but got I
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected Obj, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected Obj, but got Unknown
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected Obj, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected Obj, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected Obj, but got Unknown
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected Obj, but got Unknown
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected Obj, but got Unknown
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected Obj, but got Unknown
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected Obj, but got Unknown
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected Obj, but got Unknown
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Expected Obj, but got Unknown
			object obj = default;
			UIWidget uIWidget = (UIWidget)(obj + 8);
			uIWidget.width = (int)this;
			obj = uIWidget;
			object obj2 = 0 - obj;
			object obj3 = obj2 * mWidth;
			object obj4 = obj3 + mWidth;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj5 = -0;
			object obj6 = obj5 * mHeight;
			object obj7 = obj6 + mHeight;
			Camera camera = anchorCamera;
			object obj8 = obj + 52;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			object obj9 = obj - -64;
			obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v16+8]");
			_ = 0;
			object obj10 = mCorners + 16;
			obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v18+8]");
			_ = 0;
			object obj11 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			obj9 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v26+8]");
			_ = 0;
			object obj12 = mCorners + 28;
			obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v18+8]");
			_ = 0;
			object obj13 = obj + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			obj9 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v35+8]");
			_ = 0;
			object obj14 = mCorners + 40;
			obj14 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v18+8]");
			_ = 0;
			object obj15 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			obj9 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v44+8]");
			_ = 0;
			object obj16 = mCorners + 52;
			obj16 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v18+8]");
			_ = 0;
			return (Material)(object)mCorners;
		}
		set
		{
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0324: Expected Obj, but got Unknown
			//IL_0331: Expected I4, but got Obj
			//IL_033d: Unsupported input type for neg.
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Expected Obj, but got Unknown
			//IL_0381: Expected Obj, but got I
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bd: Expected Obj, but got Unknown
			//IL_03c6: Invalid comparison between Obj and F4
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			//IL_002e: Expected I, but got Obj
			//IL_0044: Expected Obj, but got I
			//IL_03f6: Expected F4, but got Obj
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected Obj, but got Unknown
			//IL_00cd: Invalid comparison between I and F4
			//IL_006f: Expected I, but got Obj
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected Obj, but got Unknown
			//IL_0115: Expected I, but got Obj
			//IL_012b: Expected Obj, but got I
			//IL_0418: Expected F4, but got I
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected Obj, but got Unknown
			//IL_01b4: Invalid comparison between I and F4
			//IL_0156: Expected I, but got Obj
			//IL_042a: Unknown result type (might be due to invalid IL or missing references)
			//IL_042f: Expected Obj, but got Unknown
			//IL_0440: Invalid comparison between I and F4
			//IL_04c7: Expected Obj, but got I4
			//IL_04da: Expected Obj, but got F4
			//IL_04e9: Expected I, but got F4
			//IL_04f3: Expected Obj, but got F4
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Expected Obj, but got Unknown
			//IL_01fa: Expected I, but got Obj
			//IL_0210: Expected Obj, but got I
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Expected Obj, but got Unknown
			//IL_0296: Expected I, but got Obj
			//IL_02ac: Expected Obj, but got I
			//IL_0483: Expected F4, but got I
			//IL_04ad: Expected F4, but got I
			//IL_023b: Expected I, but got Obj
			//IL_02d7: Expected I, but got Obj
			object obj = default;
			UIWidget uIWidget = (UIWidget)(obj + 8);
			uIWidget.width = (int)value;
			obj = uIWidget;
			object obj2 = 0 - obj;
			float num = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Material)+64]");
			float num2 = num * 0f;
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Material)+64]");
			float num4 = num3 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj3 = -0;
			float num5 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Material)+68]");
			float num6 = num5 * 0f;
			float num7 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Material)+68]");
			float num8 = num7 + 0f;
			object obj4 = value + 156;
			float num9;
			if (obj4 == (object)0f)
			{
				num9 = num2;
			}
			else
			{
				object obj5 = value + 156;
				nint num10 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v95 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num11 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v101 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				num9 = Mathf.LerpUnclamped(num2, num4, (float)obj5);
			}
			object obj7 = value + 156;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v27+4]");
			if (0f == 0f)
			{
				float num12 = num6;
			}
			else
			{
				object obj8 = value + 156;
				nint num13 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v80 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num14 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v86 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v77+4]");
				float num12 = Mathf.LerpUnclamped(num6, num8, 0f);
			}
			object obj10 = value + 156;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v32+8]");
			bool flag = 0f != 1f;
			bool flag2 = !flag;
			float num15 = num4;
			if (!flag2)
			{
				object obj11 = value + 156;
				nint num16 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v66 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num17 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v72 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v63+8]");
				float num18 = Mathf.LerpUnclamped(num2, num4, 0f);
				num15 = num18;
			}
			object obj13 = value + 156;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v37+C]");
			bool flag3 = 0f != 1f;
			bool flag4 = !flag3;
			float num19 = num8;
			if (!flag4)
			{
				object obj14 = value + 156;
				nint num20 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v52 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num21 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v58 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v49+C]");
				float num22 = Mathf.LerpUnclamped(num6, num8, 0f);
				num19 = num22;
			}
			UIWidget uIWidget2 = (UIWidget)0;
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
			uIWidget2 = (UIWidget)num9;
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num15;
			leftAnchor = (AnchorPoint)num19;
		}
	}

	public virtual Texture mainTexture
	{
		get
		{
			return (Texture)(object)mMat;
		}
		set
		{
			//IL_0089: Expected I, but got Obj
			//IL_009f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mMat).FindKernel((string)(object)value) != 0)
			{
				MarkAsChanged();
				object obj2 = this + 112;
				obj2 = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public virtual Shader shader
	{
		get
		{
			//IL_008e: Expected I, but got Obj
			//IL_00a4: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0067: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ComputeShader computeShader = default;
			if (computeShader.FindKernel(null) != 0)
			{
				int renderQueue = ((Material)(object)computeShader).renderQueue;
				return (Shader)renderQueue;
			}
			return null;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			string text = default;
			string message = text + " has no mainTexture setter";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotSupportedException ex = default;
			ex._002Ector(message);
			((UIWidget)(object)ex).mainTexture = null;
		}
	}

	public Vector2 relativeSize
	{
		get
		{
			//IL_0026: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			string text2 = default;
			string text = text2 + " has no shader setter";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotSupportedException ex = default;
			ex._002Ector(text);
			((UIWidget)(object)ex).shader = null;
			return (Vector2)text;
		}
	}

	public bool hasBoxCollider
	{
		get
		{
			//IL_0092: Expected I, but got Obj
			//IL_00a8: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0067: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ComputeShader computeShader = default;
			if (computeShader.FindKernel(null) != 0)
			{
				Texture texture = ((Material)(object)computeShader).mainTexture;
				return (byte)(int)texture != 0;
			}
			return false;
		}
	}

	public unsafe virtual int minWidth
	{
		get
		{
			//IL_038a: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_00ce: Expected I, but got Obj
			//IL_00e4: Expected Obj, but got I
			//IL_010f: Expected I, but got Obj
			//IL_0182: Expected I, but got Obj
			//IL_0198: Expected Obj, but got I
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f7: Expected Obj, but got Unknown
			//IL_0309: Expected Obj, but got I4
			//IL_0315: Expected Obj, but got I4
			//IL_0323: Expected I, but got Obj
			//IL_0339: Expected Obj, but got I
			//IL_01c3: Expected I, but got Obj
			//IL_0210: Expected I, but got Obj
			if (~(mStarted ? 1u : 0u) == 0)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (panel != null && isActiveAndEnabled)
				{
					string fileName = tag;
					nint num3 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v12 (Il2CppClass<NGUITools>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v38 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					byte[] array = NGUITools.Load(fileName);
					if (array != null)
					{
						Camera camera = anchorCamera;
						Transform transform = cachedTransform;
						bool activeSelf = ((GameObject)(object)transform).activeSelf;
						nint num5 = (nint)typeof(UIPanel);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v24 (Il2CppClass<UIPanel>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num6 = (nint)typeof(UIPanel);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v38 (Il2CppClass<UIPanel>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj4 = this + 144;
						bool flag = ((InAppPurchaseProvider)(object)camera).TryGetLatestRequestedProductInfoForProductId((string)1, out *(activeSelf ? ((ProductRequestResultInfo*)1) : ((ProductRequestResultInfo*)null)));
						obj4 = flag;
						nint num7 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num8 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)panel).FindKernel((string)null) != 0)
						{
							mParentFound = false;
							panel.RemoveWidget(this);
							ParentHasChanged();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
						}
					}
				}
			}
			return (int)panel;
		}
	}

	public virtual int minHeight => 2;

	public virtual Vector4 border
	{
		get
		{
			if ((object)this == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			Vector4 result = default;
			return result;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((MessageEventArgs)(object)this)._002Ector();
		}
	}

	public void SetDimensions(int w, int h)
	{
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected VT, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_0380: Expected Obj, but got I4
		object obj = default;
		Vector3 vector = (Vector3)(obj + 152);
		object obj2 = obj + 112;
		object obj3 = obj + 100;
		object obj4 = obj + 88;
		object obj5 = obj + 76;
		object obj6 = obj - -64;
		object obj7 = obj + 52;
		object obj8 = obj + 40;
		object obj9 = obj + 28;
		object obj10 = obj + 16;
		object obj11 = obj + 136;
		obj11 = 0;
		_ = 0;
		object obj12 = obj + 124;
		obj12 = 0;
		_ = 0;
		IntPtr cachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37 (System.IntPtr)+C]");
		bool flag = (nint)0 < (nint)1;
		throw new IndexOutOfRangeException();
	}

	public unsafe override Vector3[] GetSides(Transform relativeTo)
	{
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0342: Expected Obj, but got I4
		//IL_0360: Expected I, but got Obj
		//IL_0376: Expected Obj, but got I
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03b9: Expected Obj, but got I4
		//IL_0101: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_01c2: Expected I, but got Obj
		//IL_01d8: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_0134: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_04b0: Expected I, but got Obj
		//IL_04c6: Expected Obj, but got I
		//IL_0203: Expected I, but got Obj
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I4
		//IL_0175: Expected I, but got Obj
		//IL_02ec: Expected I, but got Obj
		//IL_025e: Expected I, but got Obj
		//IL_0274: Expected Obj, but got I
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected Obj, but got Unknown
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected Obj, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected Obj, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
		//IL_029f: Expected I, but got Obj
		Transform transform = default;
		object obj = transform + 24;
		obj = 0;
		_ = 0;
		bool flag = isFullyAnchored;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform2 = (Transform)(transform + 36);
		object obj3 = transform + 12;
		if (((ComputeShader)flag).FindKernel(null) != 0)
		{
			float num3 = alpha;
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v38 (Il2CppClass<NGUITools>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S2_v43 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return NGUITools.GetWorldCorners(mCam, num3, relativeTo);
		}
		Camera camera = anchorCamera;
		transform2.position = (Vector3)camera;
		obj = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		object obj5 = 0;
		while ((nint)obj5 <= 3)
		{
			nint num6 = (nint)typeof(UIRect);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v72 (Il2CppClass<UIRect>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num7 = (nint)typeof(UIRect);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v84 (Il2CppClass<UIRect>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			transform2 = (Transform)obj;
			Transform transform3 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			object obj7 = UIRect.mSides + 16;
			object obj8 = obj5 * 12;
			object obj9 = obj7 + obj8;
			obj9 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			object obj10 = obj5 + 1;
			obj5 = obj10;
		}
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v67 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)relativeTo).FindKernel((string)null) != 0)
		{
			object obj12 = 0;
			while ((nint)obj12 <= 3)
			{
				nint num10 = (nint)typeof(UIRect);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v49 (Il2CppClass<UIRect>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num11 = (nint)typeof(UIRect);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v61 (Il2CppClass<UIRect>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj14 = UIRect.mSides + 16;
				object obj15 = obj12 * 12;
				object obj16 = obj14 + obj15;
				obj3 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S2_v17+8]");
				_ = 0;
				transform2 = (Transform)obj3;
				Transform transform4 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v15+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				transform.Internal_LookAt_Injected(ref *(Vector3*)relativeTo, ref *(Vector3*)transform2);
				transform2 = transform;
				((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
				object obj17 = UIRect.mSides + 16;
				object obj18 = obj12 * 12;
				object obj19 = obj17 + obj18;
				obj19 = transform2;
				_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				object obj20 = obj12 + 1;
				obj12 = obj20;
			}
		}
		nint num12 = (nint)typeof(UIRect);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v31 (Il2CppClass<UIRect>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num13 = (nint)typeof(UIRect);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v38 (Il2CppClass<UIRect>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return UIRect.mSides;
	}

	public override float CalculateFinalAlpha(int frameID)
	{
		//IL_00f2: Expected Obj, but got I4
		//IL_0109: Expected I4, but got Obj
		//IL_011b: Expected Obj, but got I4
		//IL_000e: Expected I4, but got Obj
		//IL_0020: Expected I, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_0061: Expected I, but got Obj
		char[] separator = (char[])(frameID + 1);
		string[] array = ((string)(object)this).Split(separator);
		char c = NGUIMath.DecimalToHexChar((int)array);
		char[] separator2 = (char[])(frameID + 2);
		string[] array2 = ((string)(object)this).Split(separator2);
		char c2 = NGUIMath.DecimalToHexChar((int)array2);
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v19 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = (int)((uint)c << 4);
		int num4 = c2 | num3;
		float num5 = (float)num4 / 255f;
		if (num5 < 0f)
		{
			num5 = 0f;
		}
		else if (num5 > 1f)
		{
			num5 = 1f;
		}
		return num5;
	}

	protected void UpdateFinalAlpha(int frameID)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 up = Vector2.up;
	}

	public override void Invalidate(bool includeChildren)
	{
		//IL_0036: Expected I, but got Obj
		//IL_004c: Expected Obj, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0102: Expected F4, but got I
		//IL_0077: Expected I, but got Obj
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		if (~(mIsVisibleByAlpha ? 1u : 0u) == 0 && ~(mIsInFront ? 1u : 0u) == 0)
		{
			UIRoot uIRoot = root;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num4;
			if (((ComputeShader)(object)uIRoot).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9CD6");
				object obj2 = this + 80;
				object obj3 = default;
				float num3 = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v7+C]");
				num4 = num3 * 0f;
			}
			else
			{
				object obj4 = this + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v10+C]");
				num4 = 0f;
			}
			finalAlpha = num4;
		}
		else
		{
			finalAlpha = 0f;
		}
	}

	public float CalculateCumulativeAlpha(int frameID)
	{
		if (mAlphaFrameID != frameID)
		{
			mAlphaFrameID = frameID;
			Invalidate((byte)frameID != 0);
		}
		return finalAlpha;
	}

	public override void SetRect(float x, float y, float width, float height)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B738");
	}

	public void ResizeCollider()
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got F4
		//IL_0021: Expected Obj, but got F4
		//IL_002c: Expected Obj, but got I4
		//IL_0037: Expected I4, but got F4
		leftAnchor = (AnchorPoint)1;
		rightAnchor = (AnchorPoint)(-100f);
		bottomAnchor = (AnchorPoint)100f;
		topAnchor = (AnchorPoint)35;
		updateAnchors = (AnchorUpdate)30;
		CancelInvoke();
	}

	public unsafe static int FullCompareFunc(UIWidget left, UIWidget right)
	{
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_031f: Expected I4, but got Obj
		//IL_032b: Unsupported input type for neg.
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_0365: Expected Obj, but got I
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Ref, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0048: Expected Obj, but got VT
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00bf: Expected Obj, but got VT
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_011e: Expected Obj, but got VT
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got VT
		//IL_0193: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I
		//IL_0405: Expected I4, but got Obj
		//IL_01d4: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02dc: Expected Obj, but got VT
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		Transform transform = default;
		UIWidget uIWidget = (UIWidget)(transform + 16);
		uIWidget.width = (int)left;
		transform = (Transform)(object)uIWidget;
		object obj = 0 - transform;
		object obj2 = obj * left.mWidth;
		object obj3 = obj2 + left.mWidth;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
		object obj4 = -0;
		object obj5 = obj4 * left.mHeight;
		object obj6 = obj5 + left.mHeight;
		Camera camera = left.anchorCamera;
		object obj7 = transform - -64;
		object obj8 = obj5 + obj6;
		float num = (float)obj8 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
		ref Vector3 reference = ref *(Vector3*)(transform + 76);
		reference = ref *(Vector3*)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v17+8]");
		_ = 0;
		object obj9 = left.mCorners + 16;
		obj9 = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v19 (UnityEngine.Vector3&)+8]");
		_ = 0;
		object obj10 = transform + 52;
		object obj11 = obj2 + obj3;
		float num2 = (float)obj11 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
		reference = ref *(Vector3*)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v27+8]");
		_ = 0;
		object obj12 = left.mCorners + 28;
		obj12 = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v19 (UnityEngine.Vector3&)+8]");
		_ = 0;
		object obj13 = transform + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
		reference = ref *(Vector3*)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v36+8]");
		_ = 0;
		object obj14 = left.mCorners + 40;
		obj14 = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v19 (UnityEngine.Vector3&)+8]");
		_ = 0;
		object obj15 = transform + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
		reference = ref *(Vector3*)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v45+8]");
		_ = 0;
		object obj16 = left.mCorners + 52;
		obj16 = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v19 (UnityEngine.Vector3&)+8]");
		_ = 0;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v60 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)right).FindKernel((string)null) != 0)
		{
			object obj18 = 0;
			while ((nint)obj18 <= 3)
			{
				object obj19 = left.mCorners + 16;
				object obj20 = obj18 * 12;
				object obj21 = obj19 + obj20;
				uIWidget = (UIWidget)obj21;
				UIWidget uIWidget2 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S2_v33+8]");
				((UnityEngine.Object)uIWidget2).m_CachedPtr = (IntPtr)0;
				reference = ref *(Vector3*)uIWidget;
				_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
				transform.Internal_LookAt_Injected(ref *(Vector3*)right, ref reference);
				reference = ref *(Vector3*)transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				object obj22 = left.mCorners + 16;
				object obj23 = obj18 * 12;
				object obj24 = obj22 + obj23;
				obj24 = reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v19 (UnityEngine.Vector3&)+8]");
				_ = 0;
				object obj25 = obj18 + 1;
				obj18 = obj25;
			}
		}
		return (int)left.mCorners;
	}

	public static int PanelCompareFunc(UIWidget left, UIWidget right)
	{
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		//IL_00f3: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected I4, but got Obj
		nint num = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v2 (Il2CppClass<UIPanel>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v9 (Il2CppClass<UIPanel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3[] sides = left.panel.GetSides((Transform)(object)right.panel);
		bool flag = sides == null;
		bool flag2 = !flag;
		bool result = (byte)(int)sides != 0;
		if (!flag2)
		{
			bool flag3 = left.UpdateTransform((int)right);
			result = flag3;
		}
		return result ? 1 : 0;
	}

	public Bounds CalculateBounds()
	{
		//IL_015c: Expected I, but got Obj
		//IL_0172: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ae: Expected Obj, but got VT
		//IL_00ae: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got VT
		//IL_0079: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got VT
		//IL_0115: Expected Obj, but got VT
		//IL_013d: Expected Obj, but got VT
		_ = 1;
		_ = -1;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+90]");
		bool createIfMissing;
		Bounds bounds = default;
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+81]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+90]");
				if (!((UIPanel)0).clipsChildren)
				{
					createIfMissing = true;
					goto IL_00b7;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+90]");
			createIfMissing = ((UIPanel)0).Affects((UIWidget)bounds);
			goto IL_00b7;
		}
		goto IL_018f;
		IL_018f:
		return bounds;
		IL_00b7:
		int renderedFrameCount = Time.renderedFrameCount;
		float num3 = ((UIPanel)bounds).CalculateFinalAlpha(renderedFrameCount);
		bool flag = num3 > 0.001f;
		BMSymbol symbol = ((UIFont)bounds).GetSymbol((string)flag, createIfMissing);
		int renderedFrameCount2 = Time.renderedFrameCount;
		((UIWidget)bounds).Invalidate((byte)renderedFrameCount2 != 0);
		if ((object)this != null)
		{
			((UIRect)bounds).UpdateAnchorsInternal(1);
		}
		goto IL_018f;
	}

	public Bounds CalculateBounds(Transform relativeParent)
	{
		//IL_0174: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_01b5: Expected I, but got Obj
		//IL_00b7: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+64]");
		if (0 == (nint)this)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+68]");
			if (0 == (nint)relativeParent)
			{
				goto IL_0211;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+84]");
		if ((nint)0 == 1)
		{
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v47 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v52 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+64]");
			float num3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+88]");
			float num4 = num3 / 0f;
			GUILayoutOption gUILayoutOption = GUILayout.Width(num4);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+84]");
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+84]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+64]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+68]");
					object obj2 = num5 / 0;
				}
			}
			else
			{
				nint num6 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v35 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+68]");
				float num8 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+88]");
				float num9 = num8 * 0f;
				GUILayoutOption gUILayoutOption2 = GUILayout.Width(num9);
			}
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+80]");
		Bounds bounds = default;
		if ((nint)0 != 0)
		{
			((UIWidget)bounds).SetDirty();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		goto IL_0211;
		IL_0211:
		return bounds;
	}

	public void SetDirty()
	{
		//IL_0191: Expected I, but got Obj
		//IL_01a7: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0208: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		BoxCollider component = GetComponent<BoxCollider>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v28 (Il2CppClass<NGUITools>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v33 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUITools.UpdateWidgetCollider(this, (BoxCollider2D)(object)component);
			return;
		}
		BoxCollider2D component2 = GetComponent<BoxCollider2D>();
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v18 (Il2CppClass<NGUITools>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v23 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.UpdateWidgetCollider((BoxCollider2D)(object)this, (byte)(int)component2 != 0);
	}

	public void RemoveFromPanel()
	{
		//IL_00d6: Expected I, but got Obj
		//IL_00ec: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)drawCall).FindKernel((string)null) != 0)
		{
			UIDrawCall uIDrawCall = drawCall;
			uIDrawCall.isDirty = true;
		}
		else if (hasVertices && rawPivot != Pivot.TopLeft)
		{
			int num3 = minWidth;
		}
	}

	public virtual void MarkAsChanged()
	{
		//IL_0083: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0070: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)panel).FindKernel((string)null) != 0)
		{
			Vector2 windowSize = ((UIPanel)this).GetWindowSize();
			object obj2 = this + 144;
			obj2 = 0;
		}
		object obj3 = this + 248;
		obj3 = 0;
	}

	public UIPanel CreatePanel()
	{
		//IL_0115: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_00b9: Expected I, but got Obj
		Collider component = GetComponent<Collider>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			return (UIPanel)1;
		}
		BoxCollider2D component2 = GetComponent<BoxCollider2D>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = ((ComputeShader)(object)component2).FindKernel((string)null);
		return (UIPanel)num5;
	}

	public void CheckLayer()
	{
		//IL_01e9: Expected I, but got Obj
		//IL_01ff: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00ac: Expected I, but got Obj
		//IL_0126: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I
		//IL_0167: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!NGUITools.GetActive((GameObject)(object)this))
		{
			return;
		}
		mChanged = true;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)panel).FindKernel((string)null) == 0 || !isActiveAndEnabled)
		{
			return;
		}
		string fileName = tag;
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v15 (Il2CppClass<NGUITools>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v22 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] array = NGUITools.Load(fileName);
		if (array != null && ~(mPlayMode ? 1u : 0u) != 0)
		{
			RemoveFromPanel();
			ParentHasChanged();
		}
	}

	public override void ParentHasChanged()
	{
		//IL_0174: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_0108: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)panel).FindKernel((string)null) == 0)
		{
			return;
		}
		string text = panel.tag;
		bool activeSelf = ((GameObject)(object)text).activeSelf;
		string text2 = tag;
		bool activeSelf2 = ((GameObject)(object)text2).activeSelf;
		if (activeSelf == activeSelf2)
		{
			return;
		}
		nint num3 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v15 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v23 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogWarningFormat("You can't place widgets on a layer different than the UIPanel that manages them.\nIf you want to move widgets to a different layer, parent them to a new panel instead.", (object[])(object)this);
		string text3 = tag;
		string text4 = panel.tag;
		bool activeSelf3 = ((GameObject)(object)text4).activeSelf;
		((GameObject)(object)text3).SetActive(activeSelf3);
	}

	protected unsafe override void Awake()
	{
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I4
		//IL_0201: Expected I, but got Obj
		//IL_0217: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I4
		//IL_00c7: Expected I, but got Obj
		//IL_0114: Expected I, but got Obj
		base.OnUpdate();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)panel).FindKernel((string)null) == 0)
		{
			return;
		}
		Camera camera = anchorCamera;
		Transform transform = cachedTransform;
		bool activeSelf = ((GameObject)(object)transform).activeSelf;
		nint num3 = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v15 (Il2CppClass<UIPanel>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v32 (Il2CppClass<UIPanel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((InAppPurchaseProvider)(object)camera).TryGetLatestRequestedProductInfoForProductId((string)1, out *(activeSelf ? ((ProductRequestResultInfo*)1) : ((ProductRequestResultInfo*)null)));
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)panel).FindKernel((string)flag) != 0)
		{
			MarkAsChanged();
			int num7 = minWidth;
		}
	}

	protected override void OnInit()
	{
		Start();
		RuntimePlatform platform = Application.platform;
		bool flag = (byte)(platform & RuntimePlatform.OSXPlayer) != 0;
		mPlayMode = flag;
	}

	protected virtual void UpgradeFrom265()
	{
		base.OnDisable();
		MarkAsChanged();
		mMoved = true;
		UpdateAnchors();
	}

	protected override void OnStart()
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0148: Expected VT, but got Obj
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_01c4: Expected F4, but got Obj
		//IL_0205: Expected F4, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 24);
		Camera camera = anchorCamera;
		transform.localScale = (Vector3)camera;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj3 = obj2 + 12;
		obj3 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v32 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption values = GUILayout.Width((float)obj3);
		int num3 = Mathf.Min((int[])(object)values);
		mWidth = num3;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		GUILayoutOption values2 = GUILayout.Width(0f);
		int num4 = Mathf.Min((int[])(object)values2);
		mHeight = num4;
		string box = tag;
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v32 (Il2CppClass<NGUITools>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v37 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.UpdateWidgetCollider((BoxCollider)(object)box, considerInactive: true);
	}

	protected override void OnAnchor()
	{
		int num = minWidth;
	}

	protected override void OnUpdate()
	{
		//IL_1092: Unknown result type (might be due to invalid IL or missing references)
		//IL_1097: Expected Obj, but got Unknown
		//IL_10a0: Expected Obj, but got I4
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b4: Expected Obj, but got Unknown
		//IL_10bd: Expected Obj, but got I4
		//IL_10cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d1: Expected Obj, but got Unknown
		//IL_10da: Expected Obj, but got I4
		//IL_1100: Unknown result type (might be due to invalid IL or missing references)
		//IL_1105: Expected Obj, but got Unknown
		//IL_1112: Expected VT, but got Obj
		//IL_0021: Expected I4, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_1120: Unknown result type (might be due to invalid IL or missing references)
		//IL_1125: Expected Obj, but got Unknown
		//IL_112e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1133: Expected Obj, but got Unknown
		//IL_113c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1141: Expected Obj, but got Unknown
		//IL_0639: Expected I, but got Obj
		//IL_064f: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_00e5: Expected I, but got Obj
		//IL_00fb: Expected Obj, but got I
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected Obj, but got Unknown
		//IL_067a: Expected I, but got Obj
		//IL_1572: Expected I, but got Obj
		//IL_1588: Expected Obj, but got I
		//IL_06c8: Expected VT, but got Obj
		//IL_0126: Expected I, but got Obj
		//IL_0187: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Expected Obj, but got Unknown
		//IL_0802: Expected I, but got Obj
		//IL_06f3: Expected Obj, but got I4
		//IL_072f: Expected Obj, but got I4
		//IL_15bd: Expected I, but got Obj
		//IL_15d3: Expected Obj, but got I
		//IL_0850: Expected VT, but got Obj
		//IL_01c8: Expected I, but got Obj
		//IL_0216: Expected VT, but got Obj
		//IL_0b1f: Expected Obj, but got I
		//IL_0999: Expected I, but got Obj
		//IL_087b: Expected Obj, but got I4
		//IL_08b7: Expected Obj, but got I4
		//IL_1608: Expected I, but got Obj
		//IL_161e: Expected Obj, but got I
		//IL_09e7: Expected VT, but got Obj
		//IL_0241: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I4
		//IL_0308: Expected Obj, but got I4
		//IL_0357: Expected Obj, but got I4
		//IL_039b: Expected Obj, but got I4
		//IL_03f2: Expected Obj, but got I4
		//IL_0436: Expected Obj, but got I4
		//IL_05fa: Invalid comparison between I and F4
		//IL_11f3: Expected I, but got Obj
		//IL_1209: Expected Obj, but got I
		//IL_0c1e: Expected VT, but got Obj
		//IL_0b49: Expected I, but got Obj
		//IL_0a12: Expected Obj, but got I4
		//IL_0a56: Expected Obj, but got I4
		//IL_14d1: Expected F4, but got Obj
		//IL_14f6: Expected F4, but got I
		//IL_1517: Expected Obj, but got F4
		//IL_0bc4: Expected Obj, but got I
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd9: Expected Obj, but got Unknown
		//IL_0d28: Expected I, but got Obj
		//IL_0c49: Expected Obj, but got I4
		//IL_0c8d: Expected Obj, but got I4
		//IL_1452: Expected I, but got Obj
		//IL_1468: Expected Obj, but got I
		//IL_1682: Expected VT, but got Obj
		//IL_1682: Expected VT, but got Obj
		//IL_16cd: Expected Obj, but got I
		//IL_16f1: Expected Obj, but got I
		//IL_1707: Invalid comparison between Obj and F4
		//IL_0e0d: Expected I, but got Obj
		//IL_0e23: Expected Obj, but got I
		//IL_0f7a: Expected I, but got Obj
		//IL_13e4: Expected I4, but got Obj
		//IL_0eff: Expected I, but got Obj
		//IL_13a9: Expected I4, but got Obj
		//IL_0e8e: Expected I, but got Obj
		UIWidget uIWidget = default;
		object obj = uIWidget + 88;
		obj = 0;
		_ = 0;
		object obj2 = uIWidget + 76;
		obj2 = 0;
		_ = 0;
		object obj3 = uIWidget - -64;
		obj3 = 0;
		_ = 0;
		Camera camera = anchorCamera;
		Transform parentInternal = ((Transform)(object)camera).parentInternal;
		Transform transform = (Transform)(uIWidget + 16);
		transform.localPosition = (Vector3)camera;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		uIWidget.width = (int)this;
		AnchorPoint anchorPoint = leftAnchor;
		AnchorPoint anchorPoint2 = bottomAnchor;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v338 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = uIWidget + 52;
		object obj6 = uIWidget + 40;
		object obj7 = uIWidget + 28;
		float num27;
		float num28;
		float num29;
		float num30;
		if (anchorPoint.target != anchorPoint2.target)
		{
			AnchorPoint anchorPoint3 = leftAnchor;
			AnchorPoint anchorPoint4 = rightAnchor;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S2_v78 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S2_v123 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (anchorPoint3.target != anchorPoint4.target)
			{
				AnchorPoint anchorPoint5 = leftAnchor;
				AnchorPoint anchorPoint6 = topAnchor;
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S2_v84 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S2_v119 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (anchorPoint5.target != anchorPoint6.target)
				{
					bool flag = leftAnchor((Vector3)parentInternal);
					if (flag)
					{
						object obj10 = (flag ? 1 : 0) + 16;
						AnchorPoint anchorPoint7 = leftAnchor;
						float num7 = 1f - anchorPoint7.relative;
						float num8 = (float)obj10 * num7;
						object obj11 = (flag ? 1 : 0) + 40;
						float num9 = (float)obj11 * anchorPoint7.relative;
						float num10 = num8 + num9;
						AnchorPoint anchorPoint8 = leftAnchor;
						float num11 = num10 + (float)anchorPoint8.absolute;
						object obj12 = (flag ? 1 : 0) + 16;
						AnchorPoint anchorPoint9 = rightAnchor;
						float num12 = 1f - anchorPoint9.relative;
						float num13 = (float)obj12 * num12;
						object obj13 = (flag ? 1 : 0) + 40;
						float num14 = (float)obj13 * anchorPoint9.relative;
						float num15 = num13 + num14;
						AnchorPoint anchorPoint10 = rightAnchor;
						float num16 = num15 + (float)anchorPoint10.absolute;
						object obj14 = (flag ? 1 : 0) + 52;
						AnchorPoint anchorPoint11 = bottomAnchor;
						float num17 = 1f - anchorPoint11.relative;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v326+4]");
						float num18 = 0f * num17;
						object obj15 = (flag ? 1 : 0) + 28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S1_v326+4]");
						float num19 = 0f * anchorPoint11.relative;
						float num20 = num18 + num19;
						AnchorPoint anchorPoint12 = bottomAnchor;
						float num21 = num20 + (float)anchorPoint12.absolute;
						object obj16 = (flag ? 1 : 0) + 52;
						AnchorPoint anchorPoint13 = topAnchor;
						float num22 = 1f - anchorPoint13.relative;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v332+4]");
						float num23 = 0f * num22;
						object obj17 = (flag ? 1 : 0) + 28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S1_v336+4]");
						float num24 = 0f * anchorPoint13.relative;
						float num25 = num23 + num24;
						AnchorPoint anchorPoint14 = topAnchor;
						float num26 = num25 + (float)anchorPoint14.absolute;
						mIsInFront = true;
						num27 = num26;
						num28 = num16;
						num29 = num21;
						num30 = num11;
					}
					else
					{
						((UIWidget)(object)transform).OnFill((List<Vector3>)(object)this, (List<Vector2>)(object)leftAnchor, (List<Color>)(object)parentInternal);
						obj3 = transform;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
						uIWidget = (UIWidget)(object)transform;
						((UnityEngine.Object)uIWidget).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
						AnchorPoint anchorPoint15 = leftAnchor;
						float num31 = (float)uIWidget + (float)anchorPoint15.absolute;
						obj5 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
						_ = 0;
						AnchorPoint anchorPoint16 = bottomAnchor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v39+4]");
						float num32 = 0f + (float)anchorPoint16.absolute;
						obj6 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
						_ = 0;
						AnchorPoint anchorPoint17 = rightAnchor;
						float num33 = (float)obj6 + (float)anchorPoint17.absolute;
						obj7 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
						_ = 0;
						AnchorPoint anchorPoint18 = topAnchor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v43+4]");
						float num34 = 0f + (float)anchorPoint18.absolute;
						bool flag2;
						if (~(hideIfOffScreen ? 1u : 0u) == 0)
						{
							transform = (Transform)obj3;
							Transform transform2 = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
							((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
							flag2 = !((float)(nint)((UnityEngine.Object)transform).m_CachedPtr < 0f);
						}
						else
						{
							flag2 = true;
						}
						bool flag3 = flag2;
						mIsInFront = flag3;
						num27 = num34;
						num28 = num33;
						num29 = num32;
						num30 = num31;
					}
					goto IL_11dd;
				}
			}
		}
		mIsInFront = true;
		AnchorPoint anchorPoint19 = leftAnchor;
		nint num35 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v110 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num36 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v248 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num41;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint19.target))
		{
			bool flag4 = leftAnchor((Vector3)parentInternal);
			if (flag4)
			{
				object obj19 = (flag4 ? 1 : 0) + 16;
				AnchorPoint anchorPoint20 = leftAnchor;
				float num37 = 1f - anchorPoint20.relative;
				float num38 = (float)obj19 * num37;
				object obj20 = (flag4 ? 1 : 0) + 40;
				float num39 = (float)obj20 * anchorPoint20.relative;
				float num40 = num38 + num39;
				AnchorPoint anchorPoint21 = leftAnchor;
				num41 = num40 + (float)anchorPoint21.absolute;
			}
			else
			{
				((UIWidget)(object)transform).OnFill((List<Vector3>)(object)this, (List<Vector2>)(object)leftAnchor, (List<Color>)(object)parentInternal);
				AnchorPoint anchorPoint22 = leftAnchor;
				num41 = (float)transform + (float)anchorPoint22.absolute;
			}
		}
		else
		{
			transform = (Transform)obj;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			uIWidget = uIWidget;
			object obj21 = uIWidget * mWidth;
			num41 = (float)transform - (float)obj21;
		}
		AnchorPoint anchorPoint23 = rightAnchor;
		nint num42 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S1_v117 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num43 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S1_v220 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num48;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint23.target))
		{
			bool flag5 = rightAnchor((Vector3)parentInternal);
			if (flag5)
			{
				object obj23 = (flag5 ? 1 : 0) + 16;
				AnchorPoint anchorPoint24 = rightAnchor;
				float num44 = 1f - anchorPoint24.relative;
				float num45 = (float)obj23 * num44;
				object obj24 = (flag5 ? 1 : 0) + 40;
				float num46 = (float)obj24 * anchorPoint24.relative;
				float num47 = num45 + num46;
				AnchorPoint anchorPoint25 = rightAnchor;
				num48 = num47 + (float)anchorPoint25.absolute;
			}
			else
			{
				((UIWidget)(object)transform).OnFill((List<Vector3>)(object)this, (List<Vector2>)(object)rightAnchor, (List<Color>)(object)parentInternal);
				AnchorPoint anchorPoint26 = rightAnchor;
				num48 = (float)transform + (float)anchorPoint26.absolute;
			}
		}
		else
		{
			transform = (Transform)obj;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			uIWidget = uIWidget;
			object obj25 = uIWidget * mWidth;
			object obj26 = (object)transform - obj25;
			num48 = (float)obj26 + (float)mWidth;
		}
		AnchorPoint anchorPoint27 = bottomAnchor;
		nint num49 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S1_v124 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num50 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S1_v190 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num55;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint27.target))
		{
			bool flag6 = bottomAnchor((Vector3)parentInternal);
			if (flag6)
			{
				object obj28 = (flag6 ? 1 : 0) + 52;
				AnchorPoint anchorPoint28 = bottomAnchor;
				float num51 = 1f - anchorPoint28.relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S0_v232+4]");
				float num52 = 0f * num51;
				object obj29 = (flag6 ? 1 : 0) + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ S1_v184+4]");
				float num53 = 0f * anchorPoint28.relative;
				float num54 = num52 + num53;
				AnchorPoint anchorPoint29 = bottomAnchor;
				num55 = num54 + (float)anchorPoint29.absolute;
			}
			else
			{
				((UIWidget)(object)transform).OnFill((List<Vector3>)(object)this, (List<Vector2>)(object)bottomAnchor, (List<Color>)(object)parentInternal);
				AnchorPoint anchorPoint30 = bottomAnchor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (UnityEngine.Transform)+4]");
				num55 = 0f + (float)anchorPoint30.absolute;
			}
		}
		else
		{
			transform = (Transform)obj;
			Transform transform5 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			uIWidget = uIWidget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UIWidget)+4]");
			object obj30 = (nint)0 * (nint)mHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (UnityEngine.Transform)+4]");
			num55 = 0f - (float)obj30;
		}
		AnchorPoint anchorPoint31 = topAnchor;
		nint num56 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ S1_v131 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num57 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ S1_v162 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint31.target))
		{
			transform = (Transform)obj;
			Transform transform6 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
			uIWidget = uIWidget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UIWidget)+4]");
			object obj32 = (nint)0 * (nint)mHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (UnityEngine.Transform)+4]");
			object obj33 = 0 - obj32;
			float num58 = (float)obj33 + (float)mHeight;
			num27 = num58;
			num28 = num48;
			num29 = num55;
			num30 = num41;
		}
		else
		{
			bool flag7 = topAnchor((Vector3)parentInternal);
			float num63;
			if (flag7)
			{
				object obj34 = (flag7 ? 1 : 0) + 52;
				AnchorPoint anchorPoint32 = topAnchor;
				float num59 = 1f - anchorPoint32.relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ S0_v207+4]");
				float num60 = 0f * num59;
				object obj35 = (flag7 ? 1 : 0) + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ S1_v146+4]");
				float num61 = 0f * anchorPoint32.relative;
				float num62 = num60 + num61;
				AnchorPoint anchorPoint33 = topAnchor;
				num63 = num62 + (float)anchorPoint33.absolute;
			}
			else
			{
				((UIWidget)(object)transform).OnFill((List<Vector3>)(object)this, (List<Vector2>)(object)topAnchor, (List<Color>)(object)parentInternal);
				AnchorPoint anchorPoint34 = topAnchor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (UnityEngine.Transform)+4]");
				num63 = 0f + (float)anchorPoint34.absolute;
			}
			num27 = num63;
			num28 = num48;
			num29 = num55;
			num30 = num41;
		}
		goto IL_11dd;
		IL_11dd:
		transform = (Transform)(object)uIWidget;
		nint num64 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v52 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num65 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ S0_v172 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num66 = Mathf.LerpUnclamped(num30, num28, (float)transform);
		uIWidget = uIWidget;
		float a = num29;
		float b = num27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UIWidget)+4]");
		float num67 = Mathf.LerpUnclamped(a, b, 0f);
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		obj2 = num66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v39+8]");
		_ = 0;
		float num68 = num28 - num30;
		float f = num68 + 0.5f;
		int num69 = Mathf.RoundToInt(f);
		float num70 = num27 - num29;
		float f2 = num70 + 0.5f;
		int num71 = Mathf.RoundToInt(f2);
		bool flag8 = keepAspectRatio == AspectRatioSource.Free;
		int num72 = num69;
		int num73 = num71;
		if (!flag8)
		{
			bool flag9 = aspectRatio != 0f;
			bool flag10 = !flag9;
			num72 = num69;
			num73 = num71;
			if (!flag10)
			{
				nint num74 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S0_v145 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj37 = (nint)0 & (nint)0x200;
				bool flag11 = obj37 == null;
				if (keepAspectRatio == AspectRatioSource.BasedOnHeight)
				{
					if (!flag11)
					{
						nint num75 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S0_v168 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num76 = (float)num71 * aspectRatio;
					GUILayoutOption gUILayoutOption = GUILayout.Width(num76);
					num72 = (int)gUILayoutOption;
					num73 = num71;
				}
				else
				{
					if (!flag11)
					{
						nint num77 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ S0_v158 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num78 = (float)num69 / aspectRatio;
					GUILayoutOption gUILayoutOption2 = GUILayout.Width(num78);
					num72 = num69;
					num73 = (int)gUILayoutOption2;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj38 = default;
		if (num72 < (nint)obj38)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			int num79 = default;
			num72 = num79;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj39 = default;
		if (num73 < (nint)obj39)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			int num80 = default;
			num73 = num80;
		}
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		nint num81 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ S0_v90 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj40 = (nint)0 & (nint)0x200;
		if (obj40 != null)
		{
			nint num82 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ S0_v131 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		uIWidget = (UIWidget)obj5;
		UIWidget uIWidget2 = uIWidget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v39+8]");
		((UnityEngine.Object)uIWidget2).m_CachedPtr = (IntPtr)0;
		transform = (Transform)obj6;
		Transform transform7 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v41+8]");
		((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion = Quaternion.FromToRotation((Vector3)uIWidget, (Vector3)transform);
		transform = (Transform)obj7;
		Transform transform8 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v43+8]");
		((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
		object obj41 = (object)transform * (object)transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (UnityEngine.Transform)+4]");
		nint num83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (UnityEngine.Transform)+4]");
		object obj42 = num83 * 0;
		object obj43 = obj41 + obj42;
		object obj44 = (nint)((UnityEngine.Object)transform).m_CachedPtr * (nint)((UnityEngine.Object)transform).m_CachedPtr;
		object obj45 = obj43 + obj44;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f))
		{
			Camera camera2 = anchorCamera;
			transform = (Transform)obj2;
			Transform transform9 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			if (~(mIsInFront ? 1u : 0u) == 0)
			{
				mChanged = true;
			}
		}
		if (mWidth != num72 || mHeight != num73)
		{
			mWidth = num72;
			mHeight = num73;
			if (~(mIsInFront ? 1u : 0u) == 0)
			{
				mChanged = true;
			}
			if (~(autoResizeBoxCollider ? 1u : 0u) == 0)
			{
				SetDirty();
			}
		}
	}

	private void OnApplicationPause(bool paused)
	{
		//IL_000b: Expected Obj, but got I4
		UICamera.Notify((GameObject)(object)this, (string)paused, null);
	}

	protected override void OnDisable()
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (panel != null)
		{
			int num3 = minWidth;
		}
	}

	private void OnDestroy()
	{
		MarkAsChanged();
		base.Awake();
	}

	public bool UpdateVisibility(bool visibleByAlpha, bool visibleByPanel)
	{
		//IL_04b8: Expected I, but got Obj
		//IL_04ce: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_030e: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_042a: Expected I, but got Obj
		//IL_0440: Expected Obj, but got I
		//IL_034f: Expected I, but got Obj
		//IL_039c: Expected I, but got Obj
		//IL_03b2: Expected Obj, but got I
		//IL_0543: Expected I4, but got Obj
		//IL_046b: Expected I, but got Obj
		//IL_03dd: Expected I, but got Obj
		nint num = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIDrawCall>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v128 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<int[]> mCache = UIDrawCall.mCache;
		int num3 = 0;
		int[] array2;
		int[] array3 = default;
		while (true)
		{
			if (num3 < mCache._size)
			{
				nint num4 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v108 (Il2CppClass<UIDrawCall>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(UIDrawCall);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v122 (Il2CppClass<UIDrawCall>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int[] array = UIDrawCall.mCache.get_Item(num3);
				if (array == null || array.Length != (visibleByPanel ? 1 : 0))
				{
					int num6 = num3 + 1;
					num3 = num6;
					continue;
				}
				array2 = array;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj3 = 0;
			while ((nint)obj3 < (visibleByAlpha ? 1 : 0))
			{
				object obj4 = array3 + 16;
				object obj5 = 0 << 2;
				object obj6 = obj4 + obj5;
				obj6 = obj3;
				object obj7 = 0 + 1;
				object obj8 = obj7 + 1;
				object obj9 = array3 + 16;
				object obj10 = obj7 << 2;
				object obj11 = obj9 + obj10;
				object obj12 = obj3 + 1;
				obj11 = obj12;
				object obj13 = array3 + 16;
				object obj14 = obj8 << 2;
				object obj15 = obj13 + obj14;
				object obj16 = obj3 + 2;
				obj15 = obj16;
				object obj17 = obj8 + 1;
				object obj18 = obj17 + 1;
				object obj19 = array3 + 16;
				object obj20 = obj17 << 2;
				object obj21 = obj19 + obj20;
				object obj22 = obj3 + 2;
				obj21 = obj22;
				object obj23 = array3 + 16;
				object obj24 = obj18 << 2;
				object obj25 = obj23 + obj24;
				object obj26 = obj3 + 3;
				obj25 = obj26;
				object obj27 = obj18 + 1;
				object obj28 = array3 + 16;
				object obj29 = obj27 << 2;
				object obj30 = obj28 + obj29;
				obj30 = obj3;
				object obj31 = obj3 + 4;
				obj3 = obj31;
			}
			nint num7 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v31 (Il2CppClass<UIDrawCall>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num8 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v72 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<int[]> mCache2 = UIDrawCall.mCache;
			if (mCache2._size >= 11)
			{
				nint num9 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v59 (Il2CppClass<UIDrawCall>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num10 = (nint)typeof(UIDrawCall);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v66 (Il2CppClass<UIDrawCall>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIDrawCall.mCache.RemoveAt(0);
			}
			nint num11 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v44 (Il2CppClass<UIDrawCall>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num12 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v52 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			array2 = array3;
			break;
		}
		return (byte)(int)array2 != 0;
	}

	public bool UpdateTransform(int frame)
	{
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_0115: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_00ba: Expected I, but got Obj
		//IL_01b1: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		//IL_01f2: Expected I, but got Obj
		int num = mDepth;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [frame @ L1 (System.Int32)+6C]");
		if ((nint)num < (nint)0)
		{
			return true;
		}
		int num2 = mDepth;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [frame @ L1 (System.Int32)+6C]");
		if ((nint)num2 > (nint)0)
		{
			return true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v53 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj2 = default;
		UnityEngine.Object obj3 = default;
		if (obj2 != obj3)
		{
			return false;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (obj2 != null)
		{
			return true;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (obj3 != null)
		{
			return true;
		}
		int hashCode = obj2.GetHashCode();
		int hashCode2 = obj3.GetHashCode();
		if (hashCode < hashCode2)
		{
			return true;
		}
		return true;
	}

	public unsafe bool UpdateGeometry(int frame)
	{
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected VT, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected Obj, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected Obj, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected Obj, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected Obj, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected Obj, but got Unknown
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected Obj, but got Unknown
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected Obj, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected Obj, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected Obj, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected Obj, but got Unknown
		//IL_0670: Expected Obj, but got I4
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected Obj, but got Unknown
		//IL_068d: Expected Obj, but got I4
		//IL_002f: Expected I4, but got Obj
		//IL_0040: Unsupported input type for neg.
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b9: Expected F4, but got Obj
		//IL_00b4: Expected native int or pointer, but got VT
		//IL_00ce: Expected F4, but got I
		//IL_00c9: Expected native int or pointer, but got VT
		//IL_00ea: Expected F4, but got Obj
		//IL_00e5: Expected native int or pointer, but got VT
		//IL_00ff: Expected F4, but got I
		//IL_00fa: Expected native int or pointer, but got VT
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0117: Expected Obj, but got F4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0148: Expected F4, but got Obj
		//IL_0143: Expected native int or pointer, but got VT
		//IL_015d: Expected F4, but got I
		//IL_0158: Expected native int or pointer, but got VT
		//IL_022f: Expected I4, but got Obj
		//IL_0179: Expected F4, but got Obj
		//IL_0174: Expected native int or pointer, but got VT
		//IL_018e: Expected F4, but got I
		//IL_0189: Expected native int or pointer, but got VT
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got F4
		//IL_0240: Unsupported input type for neg.
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_0274: Expected Obj, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02b9: Expected F4, but got Obj
		//IL_02b4: Expected native int or pointer, but got VT
		//IL_02ce: Expected F4, but got I
		//IL_02c9: Expected native int or pointer, but got VT
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_0319: Expected F4, but got Obj
		//IL_0314: Expected native int or pointer, but got VT
		//IL_032e: Expected F4, but got I
		//IL_0329: Expected native int or pointer, but got VT
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_0395: Expected I, but got Obj
		//IL_03ab: Expected Obj, but got I
		//IL_0701: Expected F4, but got Obj
		//IL_06fc: Expected native int or pointer, but got VT
		//IL_0716: Expected F4, but got I
		//IL_0711: Expected native int or pointer, but got VT
		//IL_0723: Expected VT, but got Obj
		//IL_0734: Expected F4, but got Obj
		//IL_072f: Expected native int or pointer, but got VT
		//IL_0749: Expected F4, but got I
		//IL_0744: Expected native int or pointer, but got VT
		//IL_04f8: Expected F4, but got Obj
		//IL_04f3: Expected native int or pointer, but got VT
		//IL_050d: Expected F4, but got I
		//IL_0508: Expected native int or pointer, but got VT
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		//IL_0525: Expected Obj, but got F4
		//IL_053c: Expected F4, but got Obj
		//IL_0537: Expected native int or pointer, but got VT
		//IL_0551: Expected F4, but got I
		//IL_054c: Expected native int or pointer, but got VT
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_0569: Expected Obj, but got F4
		//IL_03d6: Expected I, but got Obj
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0460: Expected I, but got Obj
		//IL_0476: Expected Obj, but got I
		//IL_080c: Expected F4, but got Obj
		//IL_0807: Expected native int or pointer, but got VT
		//IL_0821: Expected F4, but got I
		//IL_081c: Expected native int or pointer, but got VT
		//IL_082e: Expected VT, but got Obj
		//IL_083f: Expected F4, but got Obj
		//IL_083a: Expected native int or pointer, but got VT
		//IL_0854: Expected F4, but got I
		//IL_084f: Expected native int or pointer, but got VT
		//IL_04a1: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 152);
		UIWidget uIWidget = (UIWidget)(obj + 32);
		UIWidget uIWidget2 = (UIWidget)(obj + 16);
		object obj2 = obj + 116;
		object obj3 = obj + 104;
		object obj4 = obj + 92;
		object obj5 = obj + 80;
		object obj6 = obj + 68;
		object obj7 = obj + 56;
		object obj8 = obj + 44;
		object obj9 = obj + 140;
		obj9 = 0;
		_ = 0;
		object obj10 = obj + 128;
		obj10 = 0;
		_ = 0;
		Camera camera = anchorCamera;
		RuntimePlatform platform = Application.platform;
		bool flag = (byte)(platform & RuntimePlatform.OSXPlayer) != 0;
		mPlayMode = flag;
		if (~(mMoved ? 1u : 0u) == 0)
		{
			mMoved = true;
			mMatrixFrame = -1;
			((Transform)(object)camera).get_position_Injected(out *(Vector3*)null);
			uIWidget.width = (int)this;
			uIWidget2 = uIWidget;
			object obj11 = 0 - uIWidget2;
			object obj12 = obj11 * mWidth;
			object obj13 = obj12 + mWidth;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UIWidget)+4]");
			object obj14 = -0;
			object obj15 = obj14 * mHeight;
			object obj16 = obj15 + mHeight;
			object obj17 = panel + 116;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
			((Vector3*)(nint)vector)->x = (float)obj2;
			Vector3 vector3 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			object obj18 = this + 264;
			obj18 = vector.x;
			_ = vector.z;
			object obj19 = panel + 116;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
			((Vector3*)(nint)vector)->x = (float)obj4;
			Vector3 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			object obj20 = this + 276;
			obj20 = vector.x;
			_ = vector.z;
		}
		else
		{
			UIPanel uIPanel = panel;
			if (~(uIPanel.widgetsAreStatic ? 1u : 0u) != 0)
			{
				IEnumerator enumerator = ((Transform)(object)camera).GetEnumerator();
				if (enumerator != null)
				{
					mMatrixFrame = -1;
					((Transform)(object)camera).get_position_Injected(out *(Vector3*)null);
					uIWidget2.width = (int)this;
					obj = uIWidget2;
					object obj21 = 0 - obj;
					object obj22 = obj21 * mWidth;
					object obj23 = obj22 + mWidth;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					object obj24 = -0;
					object obj25 = obj24 * mHeight;
					object obj26 = obj25 + mHeight;
					object obj27 = panel + 116;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
					((Vector3*)(nint)vector)->x = (float)obj2;
					Vector3 vector6 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((Vector3*)(nint)vector6)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
					obj9 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					_ = 0;
					object obj28 = panel + 116;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
					((Vector3*)(nint)vector)->x = (float)obj4;
					Vector3 vector7 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
					((Vector3*)(nint)vector7)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
					obj10 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
					_ = 0;
					object obj29 = this + 264;
					obj6 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S1_v66+8]");
					_ = 0;
					obj7 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
					_ = 0;
					nint num = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v97 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj30 = (nint)0 & (nint)0x200;
					if (obj30 != null)
					{
						nint num2 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S0_v154 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					uIWidget = (UIWidget)obj6;
					UIWidget uIWidget3 = uIWidget;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
					((UnityEngine.Object)uIWidget3).m_CachedPtr = (IntPtr)0;
					((Vector3*)(nint)vector)->x = (float)obj7;
					Vector3 vector8 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
					((Vector3*)(nint)vector8)->z = 0f;
					Quaternion quaternion = Quaternion.FromToRotation((Vector3)uIWidget, vector);
					((Vector3*)(nint)vector)->x = (float)obj8;
					Vector3 vector9 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
					((Vector3*)(nint)vector9)->z = 0f;
					float num3 = vector.x * vector.x;
					float num4 = vector.y * vector.y;
					float num5 = num3 + num4;
					float num6 = vector.z * vector.z;
					float num7 = num5 + num6;
					if (!(num7 > 1E-06f))
					{
						object obj31 = this + 276;
						uIWidget2 = (UIWidget)obj31;
						UIWidget uIWidget4 = uIWidget2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S1_v118+8]");
						((UnityEngine.Object)uIWidget4).m_CachedPtr = (IntPtr)0;
						obj = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+8]");
						_ = 0;
						nint num8 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v132 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj32 = (nint)0 & (nint)0x200;
						if (obj32 != null)
						{
							nint num9 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v150 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						uIWidget = uIWidget2;
						((UnityEngine.Object)uIWidget).m_CachedPtr = ((UnityEngine.Object)uIWidget2).m_CachedPtr;
						((Vector3*)(nint)vector)->x = (float)obj;
						Vector3 vector10 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector3*)(nint)vector10)->z = 0f;
						Quaternion quaternion2 = Quaternion.FromToRotation((Vector3)uIWidget, vector);
						((Vector3*)(nint)vector)->x = (float)obj2;
						Vector3 vector11 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
						((Vector3*)(nint)vector11)->z = 0f;
						float num10 = vector.x * vector.x;
						float num11 = vector.y * vector.y;
						float num12 = num10 + num11;
						float num13 = vector.z * vector.z;
						float num14 = num12 + num13;
						if (!(num14 > 1E-06f))
						{
							goto IL_08e5;
						}
					}
					mMoved = true;
					((Vector3*)(nint)vector)->x = (float)obj9;
					Vector3 vector12 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
					((Vector3*)(nint)vector12)->z = 0f;
					object obj33 = this + 264;
					obj33 = vector.x;
					_ = vector.z;
					((Vector3*)(nint)vector)->x = (float)obj10;
					Vector3 vector13 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+8]");
					((Vector3*)(nint)vector13)->z = 0f;
					object obj34 = this + 276;
					obj34 = vector.x;
					_ = vector.z;
				}
			}
		}
		goto IL_08e5;
		IL_08e5:
		if (~(mMoved ? 1u : 0u) == 0 && onChange != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		if (~(mMoved ? 1u : 0u) == 0)
		{
			return true;
		}
		return mChanged;
	}

	public void WriteToBuffers(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2)
	{
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_041b: Expected Obj, but got I4
		//IL_001d: Invalid comparison between F4 and I4
		//IL_044d: Invalid comparison between Obj and F4
		//IL_0078: Invalid comparison between Obj and F4
		//IL_020d: Expected VT, but got Obj
		//IL_02a0: Expected I, but got Obj
		//IL_02b6: Expected Obj, but got I
		//IL_0239: Expected VT, but got Obj
		//IL_00c3: Expected VT, but got Obj
		//IL_04af: Expected Obj, but got I4
		//IL_0272: Expected VT, but got Obj
		//IL_00ef: Expected VT, but got Obj
		//IL_02e1: Expected I, but got Obj
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_0128: Expected VT, but got Obj
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0177: Expected VT, but got Obj
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_01c1: Expected VT, but got Obj
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_0378: Expected VT, but got Obj
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		object obj = default;
		MessageEventArgs e = (MessageEventArgs)(obj + 112);
		object obj2 = obj + 80;
		object obj3 = obj + 24;
		object obj4 = obj - -64;
		object obj5 = obj + 16;
		object obj6 = obj + 48;
		object obj7 = obj + 32;
		object obj8 = obj + 96;
		obj8 = 0;
		_ = 0;
		if (topAnchor == null)
		{
			return;
		}
		AnchorPoint anchorPoint = topAnchor;
		if (!(anchorPoint.relative > 0f))
		{
			return;
		}
		AnchorPoint anchorPoint2 = topAnchor;
		bool flag = n == null;
		object obj10 = default;
		object obj9 = obj10;
		if (!flag)
		{
			object obj11 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)anchorPoint2.relative))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
				e = (MessageEventArgs)obj2;
				MessageEventArgs e2 = e;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				e2.playerId = 0;
				v.Add((Vector3)e);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77AA");
				obj5 = obj;
				e = (MessageEventArgs)obj5;
				u.Add((Vector2)e);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8875");
				e = (MessageEventArgs)obj4;
				MessageEventArgs e3 = e;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				e3.playerId = 0;
				c.Add((Color)e);
				object obj12 = this + 28;
				obj6 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S1_v88+8]");
				_ = 0;
				e = (MessageEventArgs)obj6;
				MessageEventArgs e4 = e;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				e4.playerId = 0;
				n.Add((Vector3)e);
				object obj13 = this + 40;
				obj7 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S1_v98+8]");
				_ = 0;
				e = (MessageEventArgs)obj7;
				MessageEventArgs e5 = e;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
				e5.playerId = 0;
				t.Add((Vector4)e);
				obj11 = obj10 + 1;
			}
		}
		else
		{
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)anchorPoint2.relative))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
				e = (MessageEventArgs)obj2;
				MessageEventArgs e6 = e;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				e6.playerId = 0;
				v.Add((Vector3)e);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77AA");
				obj3 = obj;
				e = (MessageEventArgs)obj3;
				u.Add((Vector2)e);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8875");
				e = (MessageEventArgs)obj4;
				MessageEventArgs e7 = e;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				e7.playerId = 0;
				c.Add((Color)e);
				object obj14 = obj9 + 1;
				obj9 = obj14;
			}
		}
		if (u2 != null)
		{
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v49 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num2 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v76 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			e._002Ector();
			obj8 = e;
			_ = e.playerId;
			IntPtr cachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
			object obj16 = 0;
			while (true)
			{
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v59 (System.IntPtr)+C]");
				if ((nint)obj17 >= 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
				obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				_ = 0;
				e = (MessageEventArgs)obj8;
				MessageEventArgs e8 = e;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
				e8.playerId = 0;
				u2.Add((Vector4)e);
				object obj18 = obj16 + 1;
				obj16 = obj18;
			}
		}
		if (bottomAnchor != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8940");
		}
	}

	public virtual void MakePixelPerfect()
	{
		MarkAsChanged();
	}

	public unsafe virtual void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0473: Expected Obj, but got I4
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected Obj, but got Unknown
		//IL_0490: Expected Obj, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		//IL_04ad: Expected Obj, but got I4
		//IL_04c1: Expected I, but got Obj
		//IL_04d7: Expected Obj, but got I
		//IL_0636: Expected Obj, but got I
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected VT, but got Unknown
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected Obj, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected Obj, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected Obj, but got Unknown
		//IL_0560: Expected Obj, but got I4
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_00bd: Expected I, but got Obj
		//IL_0584: Expected Obj, but got I
		//IL_0456: Expected VT, but got Obj
		//IL_019f: Expected VT, but got I
		//IL_01c6: Expected VT, but got I
		//IL_014b: Expected I, but got Obj
		//IL_01d8: Expected F4, but got Obj
		//IL_01d3: Expected native int or pointer, but got VT
		//IL_01ea: Expected F4, but got I
		//IL_01e5: Expected native int or pointer, but got VT
		//IL_01ff: Expected Obj, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_029e: Expected Obj, but got I
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02d2: Expected F4, but got Obj
		//IL_02cd: Expected native int or pointer, but got VT
		//IL_02e7: Expected F4, but got I
		//IL_02e2: Expected native int or pointer, but got VT
		//IL_02fc: Expected Obj, but got I
		//IL_0328: Expected I, but got Obj
		//IL_033e: Expected Obj, but got I
		//IL_05ce: Expected F4, but got Obj
		//IL_05c9: Expected native int or pointer, but got VT
		//IL_05e3: Expected F4, but got I
		//IL_05de: Expected native int or pointer, but got VT
		//IL_05f1: Expected I, but got Obj
		//IL_0607: Expected Obj, but got I
		//IL_0369: Expected I, but got Obj
		//IL_067a: Expected Obj, but got F4
		//IL_03b5: Expected F4, but got Obj
		//IL_03b0: Expected native int or pointer, but got VT
		//IL_03ca: Expected F4, but got I
		//IL_03c5: Expected native int or pointer, but got VT
		//IL_03db: Expected Ref, but got VT
		//IL_0400: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 112;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 100;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 88;
		obj4 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v119 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [uvs @ L2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		if ((UnityEngine.Object)0 != null)
		{
			((UIWidget)null).onRender = (UIDrawCall.OnRenderCallback)(object)uvs;
		}
		bool flag = ((UIRect)(object)verts).isFullyAnchored;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v128 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 128);
		Camera camera = (Camera)(obj2 + 72);
		Transform transform = (Transform)(obj2 + 60);
		object obj7 = obj2 + 48;
		object obj8 = obj2 + 36;
		object obj9 = obj2 + 24;
		object obj10 = obj2 + 12;
		if ((UnityEngine.Object)flag == null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v114 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [uvs @ L2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			if ((UnityEngine.Object)0 == null)
			{
				Camera camera2 = camera;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [uvs @ L2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
				camera2.rect = (Rect)0;
				obj = camera;
				_ = ((UnityEngine.Object)camera).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [uvs @ L2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+8]");
				transform.position = (Vector3)0;
				((Vector3*)(nint)vector)->x = (float)transform;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [uvs @ L2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
				Vector3 vector2 = ((Camera)0).ViewportToWorldPoint(vector);
				obj3 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v35+8]");
				_ = 0;
				obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v35+8]");
				_ = 0;
				obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				obj10 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				object obj12 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				object obj13 = obj12 * 0;
				object obj14 = obj13 + obj;
				obj4 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v39+4]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
				object obj15 = num7 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
				object obj16 = obj15 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v41+8]");
				_ = 0;
				((Vector3*)(nint)vector)->x = (float)obj4;
				Vector3 vector3 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				((Vector3*)(nint)vector3)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+44]");
				Vector3 vector4 = ((Camera)0).ScreenToWorldPoint(vector);
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v93 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num9 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v124 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)cols).FindKernel((string)null) != 0)
				{
					((Vector3*)(nint)vector)->x = (float)obj4;
					Vector3 vector5 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
					((Vector3*)(nint)vector5)->z = 0f;
					((Transform)(object)camera).Internal_LookAt_Injected(ref *(Vector3*)cols, ref *(Vector3*)vector);
					obj4 = camera;
					_ = ((UnityEngine.Object)camera).m_CachedPtr;
				}
				((Vector3*)(nint)vector)->x = (float)obj4;
				Vector3 vector6 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				((Vector3*)(nint)vector6)->z = 0f;
				nint num10 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v105 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num11 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S0_v115 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num12 = vector.x + 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				obj4 = num12;
				camera = (Camera)obj4;
				Camera camera3 = camera;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				((UnityEngine.Object)camera3).m_CachedPtr = (IntPtr)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v31 (UnityEngine.Camera)+4]");
				float num13 = 0f + 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				UIWidget uIWidget = (UIWidget)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
				return;
			}
		}
		Camera camera4 = ((UIRect)(object)verts).anchorCamera;
		((Transform)(object)this).localPosition = (Vector3)camera4;
	}

	private void AdaptScale()
	{
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0181: Expected Obj, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got I4
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01c9: Expected VT, but got Obj
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_0209: Expected I, but got Obj
		//IL_021f: Expected Obj, but got I
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00c3: Expected VT, but got Obj
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0110: Invalid comparison between Obj and F4
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02e6: Invalid comparison between I and F4
		//IL_0311: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 + 108;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 96;
		obj3 = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 84);
		Camera camera = anchorCamera;
		transform.localPosition = (Vector3)camera;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj4 = obj2 + 72;
		obj4 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v24 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v46 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		object obj6 = obj2 + 60;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		object obj7 = default;
		obj = obj7;
		object obj8 = obj2 + 48;
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		Camera camera2 = anchorCamera;
		Transform transform2 = (Transform)(obj2 + 120);
		transform2 = (Transform)obj;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform2.eulerAngles;
		Transform transform4 = (Transform)(obj2 + 36);
		Camera camera3 = anchorCamera;
		transform4.localScale = (Vector3)camera3;
		obj3 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		Camera camera4 = anchorCamera;
		object obj9 = obj2 + 24;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		float num3 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f)) ? (-1f) : 1f);
		object obj10 = obj2 + 12;
		obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v61+4]");
		if (!(0f < 0f))
		{
			float num4 = 1f;
		}
		else
		{
			float num4 = -1f;
		}
		obj2 = 0;
		_ = 0;
		obj2 = num3;
		_ = 1f;
		transform2 = (Transform)obj2;
		Transform transform5 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		((Transform)(object)camera4).parent = transform2;
	}

	private unsafe void CreateAndSizeWidget()
	{
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_01e5: Expected VT, but got Obj
		//IL_01f3: Expected I, but got Obj
		//IL_0209: Expected Obj, but got I
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected VT, but got Unknown
		//IL_0258: Expected F4, but got Obj
		//IL_0253: Expected native int or pointer, but got VT
		//IL_026a: Expected F4, but got I
		//IL_0265: Expected native int or pointer, but got VT
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected VT, but got Unknown
		//IL_0285: Expected F4, but got Obj
		//IL_0280: Expected native int or pointer, but got VT
		//IL_029a: Expected F4, but got I
		//IL_0295: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0069: Expected VT, but got Obj
		//IL_0069: Expected Obj, but got VT
		//IL_007b: Expected Obj, but got F4
		//IL_0092: Expected Obj, but got F4
		//IL_00a4: Expected I, but got F4
		//IL_00ad: Expected F4, but got Obj
		//IL_00e1: Expected F4, but got I
		//IL_0122: Expected I, but got Obj
		//IL_0138: Expected Obj, but got I
		//IL_02da: Expected F4, but got Obj
		//IL_02d5: Expected native int or pointer, but got VT
		//IL_02ef: Expected F4, but got I
		//IL_02ea: Expected native int or pointer, but got VT
		//IL_02fc: Expected Obj, but got VT
		//IL_0163: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 24);
		GameObject gameObject = base.gameObject;
		transform.localScale = (Vector3)gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v14 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v43 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 12;
		Vector3 forward = Vector3.forward;
		Quaternion quaternion = (Quaternion)(obj2 + 48);
		((Quaternion*)(nint)quaternion)->x = (float)transform;
		((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Quaternion quaternion2 = (Quaternion)(obj2 + 60);
		((Quaternion*)(nint)quaternion2)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v19+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		if (!(quaternion == quaternion2))
		{
			return;
		}
		GameObject gameObject2 = base.gameObject;
		((Transform)quaternion).localScale = (Vector3)gameObject2;
		obj = quaternion.x;
		_ = quaternion.z;
		transform = (Transform)quaternion.x;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)quaternion.z;
		int num3 = NumberExtensions.CeilToInt((float)transform);
		mWidth = num3;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v19+4]");
		int num4 = NumberExtensions.CeilToInt(0f);
		mHeight = num4;
		autoResizeBoxCollider = true;
		SetDirty();
		GameObject gameObject3 = base.gameObject;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v48 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v56 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 forward2 = Vector3.forward;
		((Quaternion*)(nint)quaternion2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		((Transform)(object)gameObject3).parent = (Transform)quaternion2;
	}

	private void AdaptFromCollider()
	{
		UIExtensions.OffsetToCenter((Transform)(object)this);
	}

	public UIWidget()
	{
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0212: Expected Obj, but got I4
		//IL_0230: Expected I, but got Obj
		//IL_0246: Expected Obj, but got I
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected VT, but got Obj
		//IL_008c: Expected F4, but got Obj
		//IL_00c5: Expected F4, but got I
		//IL_00e0: Expected VT, but got Obj
		//IL_010e: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 108;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 96;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 84;
		obj4 = 0;
		_ = 0;
		BoxCollider component = GetComponent<BoxCollider>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v69 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 120);
		BoxCollider boxCollider = (BoxCollider)(obj2 + 72);
		object obj6 = obj2 + 60;
		object obj7 = obj2 + 48;
		BoxCollider boxCollider2 = (BoxCollider)(obj2 + 36);
		Transform transform2 = (Transform)(obj2 + 24);
		object obj8 = obj2 + 12;
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			boxCollider.size = (Vector3)component;
			obj = boxCollider;
			_ = ((UnityEngine.Object)boxCollider).m_CachedPtr;
			obj6 = boxCollider;
			_ = ((UnityEngine.Object)boxCollider).m_CachedPtr;
			int num3 = NumberExtensions.CeilToInt((float)obj6);
			mWidth = num3;
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v31+4]");
			int num4 = NumberExtensions.CeilToInt(0f);
			mHeight = num4;
			boxCollider2.center = (Vector3)component;
			obj3 = boxCollider2;
			_ = ((UnityEngine.Object)boxCollider2).m_CachedPtr;
			GameObject gameObject = base.gameObject;
			transform2.localPosition = (Vector3)gameObject;
			obj4 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			object obj9 = obj4 + obj8;
			obj4 = obj9;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			_ = 0;
			GameObject gameObject2 = base.gameObject;
			transform = (Transform)obj4;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			autoResizeBoxCollider = true;
			SetDirty();
		}
	}
}
