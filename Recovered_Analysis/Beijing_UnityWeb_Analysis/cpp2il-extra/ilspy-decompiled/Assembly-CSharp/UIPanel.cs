using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using InAppPurchase;
using SYBO.Common;
using UI.SlideIns;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.SceneManagement;

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

	public delegate Material OnCreateMaterial(UIWidget widget, Material mat);

	public static List<UIPanel> list;

	public OnGeometryUpdated onGeometryUpdated;

	public bool showInPanelTool;

	public bool generateNormals;

	public bool generateUV2;

	public UIDrawCall.ShadowMode shadowMode;

	public bool widgetsAreStatic;

	public bool cullWhileDragging;

	public bool alwaysOnScreen;

	public bool anchorOffset;

	public bool softBorderPadding;

	public RenderQueue renderQueue;

	public int startingRenderQueue;

	[NonSerialized]
	public List<UIWidget> widgets;

	[NonSerialized]
	public List<UIDrawCall> drawCalls;

	[NonSerialized]
	public Matrix4x4 worldToLocal;

	[NonSerialized]
	public Vector4 drawCallClipRange;

	public OnClippingMoved onClipMove;

	public OnCreateMaterial onCreateMaterial;

	public UIDrawCall.OnCreateDrawCall onCreateDrawCall;

	private Texture2D mClipTexture;

	private float mAlpha;

	private UIDrawCall.Clipping mClipping;

	private Vector4 mClipRange;

	private Vector2 mClipSoftness;

	private int mDepth;

	private int mSortingOrder;

	private string mSortingLayerName;

	private bool mRebuild = true;

	private bool mResized;

	private Vector2 mClipOffset;

	private int mMatrixFrame;

	private int mAlphaFrameID;

	private int mLayer;

	private static float[] mTemp;

	private Vector2 mMin;

	private Vector2 mMax;

	private bool mSortWidgets;

	private bool mUpdateScroll;

	public bool useSortingOrder;

	private UIPanel mParentPanel;

	private static Vector3[] mCorners;

	private static int mUpdateFrame;

	[NonSerialized]
	private bool mHasMoved;

	private UIDrawCall.OnRenderCallback mOnRender;

	private bool mForced;

	public string sortingLayerName
	{
		get
		{
			UIPanel uIPanel = mParentPanel;
			if ((object)mParentPanel != null && ((UnityEngine.Object)uIPanel).m_CachedPtr != (IntPtr)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+1AC]");
				if ((nint)0 == 0)
				{
					return (string)(object)mParentPanel;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+1AC]");
				if ((nint)0 == 2)
				{
					return ((string)(object)mParentPanel).ToLowerInvariant();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+1AC]");
				if ((nint)0 == 1)
				{
					return ((string)(object)mParentPanel).ToUpperInvariant();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+1AC]");
				if ((nint)0 == 255)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+1F0]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8DFD");
						string result = default;
						return result;
					}
				}
			}
			return (string)(object)mParentPanel;
		}
		set
		{
			//IL_005d: Expected I, but got Obj
			//IL_0073: Expected Obj, but got I
			//IL_0273: Expected I, but got Obj
			//IL_0289: Expected Obj, but got I
			//IL_009e: Expected I, but got Obj
			//IL_00f8: Expected I, but got Obj
			//IL_010e: Expected Obj, but got I
			//IL_02b4: Expected I, but got Obj
			//IL_0501: Expected VT, but got Obj
			//IL_050f: Expected I, but got Obj
			//IL_0525: Expected Obj, but got I
			//IL_030e: Expected I, but got Obj
			//IL_0324: Expected Obj, but got I
			//IL_054c: Expected Obj, but got VT
			//IL_0139: Expected I, but got Obj
			//IL_05ea: Expected VT, but got Obj
			//IL_05f8: Expected I, but got Obj
			//IL_060e: Expected Obj, but got I
			//IL_057a: Expected I4, but got Obj
			//IL_0186: Expected I, but got Obj
			//IL_0635: Expected Obj, but got VT
			//IL_034f: Expected I, but got Obj
			//IL_01d3: Expected I, but got Obj
			//IL_01e9: Expected Obj, but got I
			//IL_0663: Expected I4, but got Obj
			//IL_039c: Expected I, but got Obj
			//IL_0594: Expected Obj, but got I
			//IL_03f6: Expected I, but got Obj
			//IL_040c: Expected Obj, but got I
			//IL_0214: Expected I, but got Obj
			//IL_0687: Expected Obj, but got I
			//IL_0437: Expected I, but got Obj
			//IL_0483: Expected Obj, but got VT
			if (value == null || value.m_stringLength == 0)
			{
				return;
			}
			UIWidget component = GetComponent<UIWidget>();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v73 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ComputeShader computeShader = default;
			if (computeShader.FindKernel(null) != 0)
			{
				string trans = ((Component)(object)computeShader).tag;
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v35 (Il2CppClass<NGUITools>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v56 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				_0021_00210 val = (_0021_00210)NGUITools.FindInParents<T>((Transform)(object)trans);
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v57 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v69 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)val).FindKernel(null) != 0)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v52 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55 (T)+C]");
					if ((UnityEngine.Object)0 != computeShader)
					{
						Color defaultColor = ((UIInput)(object)value).defaultColor;
						return;
					}
				}
				((UILabel)(object)computeShader).fontSize = (int)value;
				return;
			}
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ComputeShader computeShader2 = default;
			if (computeShader2.FindKernel(null) == 0)
			{
				return;
			}
			string trans2 = ((Component)(object)computeShader2).tag;
			nint num11 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v15 (Il2CppClass<NGUITools>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v29 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_0021_00210 val2 = (_0021_00210)NGUITools.FindInParents<T>((Transform)(object)trans2);
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)val2).FindKernel(null) != 0)
			{
				string text = ((Component)(object)computeShader2).tag;
				nint num15 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S2_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num16 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S2_v16 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v30 (T)+C]");
				if ((UnityEngine.Object)0 != (UnityEngine.Object)(object)text)
				{
					((UIButton)val2).normalSprite2D = (Sprite)(object)value;
				}
			}
			((UISprite)(object)computeShader2).fillCenter = (byte)(int)value != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public static int nextUnusedDepth
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009d: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (int)((UIFont)null).bmFont;
		}
	}

	public override bool canBeAnchored
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)mSortingLayerName != 0;
		}
	}

	public override float alpha
	{
		get
		{
			//IL_004a: Expected F4, but got I
			//IL_0035: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+194]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+198]");
				return 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+18C]");
			return 0f;
		}
		set
		{
			//IL_0075: Expected I, but got Obj
			//IL_008b: Expected Obj, but got I
			//IL_00bd: Expected F4, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPanel)+19C]");
			if (BaseInputModule.DetermineMoveDirection(0f, value) == MoveDirection.Left)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public int depth
	{
		get
		{
			return (mClipping != UIDrawCall.Clipping.None) ? 1 : 0;
		}
		set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0018: Expected Obj, but got I4
			//IL_0026: Expected I, but got Obj
			//IL_003c: Expected Obj, but got I
			//IL_00f6: Expected Obj, but got I
			//IL_0106: Expected Obj, but got I
			//IL_0116: Expected Obj, but got I
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Expected Obj, but got Unknown
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected Obj, but got Unknown
			//IL_0067: Expected I, but got Obj
			if (mSortingLayerName.get_Chars(value) == '\0')
			{
				return;
			}
			object obj = this + 252;
			obj = value;
			nint num = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<UIPanel>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v17 (Il2CppClass<UIPanel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<UIPanel> list = UIPanel.list;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S5_v3 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S5_v4+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S5_v5+8C]");
			object obj5 = 0;
			object obj6 = obj5 & 0x7FF;
			object obj7 = obj6 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S6_v5 (should have been resolved before IL gen)");
			UIWidget w = default;
			AddWidget(w);
		}
	}

	public int sortingOrder
	{
		get
		{
			return mDepth;
		}
		set
		{
			//IL_001d: Expected I, but got Obj
			//IL_0033: Expected Obj, but got I
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected Obj, but got Unknown
			//IL_00f9: Expected Obj, but got I4
			//IL_005e: Expected I, but got Obj
			if (mDepth == value)
			{
				return;
			}
			mDepth = value;
			nint num = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<UIPanel>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v18 (Il2CppClass<UIPanel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			object obj3 = default;
			object obj2 = obj3 + 16;
			obj2 = 0;
			throw new NullReferenceException();
		}
	}

	public float width => mAlpha;

	public float height
	{
		get
		{
			//IL_000a: Expected I4, but got Obj
			//IL_000f: Expected F4, but got Obj
			UIRoot uIRoot = default;
			uIRoot.UpdateScale((byte)(int)this != 0);
			return (float)uIRoot;
		}
	}

	public bool halfPixelOffset => (byte)mSortingOrder != 0;

	public bool usedForUI => false;

	public Vector3 drawCallOffset
	{
		get
		{
			//IL_0015: Expected I, but got Obj
			//IL_002b: Expected Obj, but got I
			//IL_00e8: Expected Obj, but got I
			//IL_00f8: Expected Obj, but got I
			//IL_0108: Expected VT, but got I
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected Obj, but got Unknown
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected Obj, but got Unknown
			//IL_0140: Expected Obj, but got VT
			//IL_0056: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector3)+F8]");
			Vector3 result = default;
			if (0 != (nint)this)
			{
				nint num = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<UIPanel>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UIPanel);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v16 (Il2CppClass<UIPanel>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				List<UIPanel> list = UIPanel.list;
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S5_v3 (Il2CppMethodInfo)+C]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S5_v4+60]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S5_v5+8C]");
				result = (Vector3)0;
				object obj4 = result.x & 0x7FF;
				object obj5 = obj4 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S6_v5 (should have been resolved before IL gen)");
				Vector3 vector = default;
				UIWidget w = default;
				((UIPanel)vector).AddWidget(w);
			}
			return result;
		}
	}

	public UIDrawCall.Clipping clipping
	{
		get
		{
			//IL_0094: Expected I, but got Obj
			//IL_00aa: Expected Obj, but got I
			//IL_00d1: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			bool flag = isFullyAnchored;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag).FindKernel(null) != 0)
			{
				return (UIDrawCall.Clipping)mCam.transparencySortMode;
			}
			return UIDrawCall.Clipping.None;
		}
		set
		{
			//IL_02cb: Expected Obj, but got I4
			//IL_02dd: Expected I, but got Obj
			//IL_02f3: Expected Obj, but got I
			//IL_0319: Unknown result type (might be due to invalid IL or missing references)
			//IL_031e: Expected Obj, but got Unknown
			//IL_0328: Expected Obj, but got I4
			//IL_0241: Expected I, but got Obj
			//IL_0257: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0063: Expected Obj, but got I
			//IL_0282: Expected I, but got Obj
			//IL_008d: Expected Obj, but got I4
			//IL_009a: Expected Obj, but got I4
			//IL_00b1: Expected I, but got Obj
			//IL_00c7: Expected Obj, but got I
			//IL_0353: Expected Obj, but got I4
			//IL_00f2: Expected I, but got Obj
			//IL_038d: Expected Obj, but got I
			//IL_03a7: Expected I, but got Obj
			//IL_03bd: Expected Obj, but got I
			//IL_013a: Expected Obj, but got I4
			//IL_0147: Expected Obj, but got I4
			//IL_03e3: Expected F4, but got Obj
			//IL_03fd: Expected I, but got Obj
			//IL_0413: Expected Obj, but got I
			//IL_0441: Expected F4, but got I
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Expected Obj, but got Unknown
			//IL_049a: Expected Obj, but got I4
			//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b3: Expected Obj, but got Unknown
			//IL_0171: Expected I, but got Obj
			//IL_01be: Expected I, but got Obj
			//IL_04d8: Expected Obj, but got F4
			//IL_0501: Expected I, but got F4
			bool flag = ((UIRect)value).isFullyAnchored;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = default;
			object obj2 = obj3 + 8;
			if (((ComputeShader)flag).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UIDrawCall+Clipping)+44]");
				if (((Camera)0).transparencySortMode != TransparencySortMode.Default)
				{
					Vector2 viewSize = ((UIPanel)value).GetViewSize();
					bool flag2 = ((UIRect)value).isAnchored;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num5;
					if (((ComputeShader)flag2).FindKernel(null) != 0)
					{
						bool flag3 = ((UIRect)value).isAnchored;
						num5 = UIRoot.GetPixelSizeAdjustment((GameObject)flag3);
					}
					else
					{
						num5 = 1f;
					}
					obj2 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UIDrawCall+Clipping)+44]");
					float num6 = ((Camera)0).depth;
					obj3 = obj2;
					nint num7 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S3_v5 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num8 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S3_v22 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					GUILayoutOption gUILayoutOption = GUILayout.Width((float)obj3);
					obj2 = obj2;
					nint num9 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S3_v12 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num10 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S3_v18 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16+4]");
					GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
					object obj7 = gUILayoutOption2 & 1;
					bool flag4 = obj7 == null;
					float num11 = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16+4]");
					float num12 = num11 / 0f;
					float num13 = num12 / num6;
					float num14 = 0f - num13;
					UIPanel uIPanel = (UIPanel)0;
					((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
					object obj8 = gUILayoutOption & 1;
					float num15 = ((obj8 == null) ? 0f : num14);
					uIPanel = (UIPanel)num15;
					if (flag4)
					{
						float num16 = 0f;
					}
					else
					{
						float num16 = num13;
					}
					((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0f;
					return;
				}
			}
			nint num17 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num18 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
		}
	}

	public UIPanel parentPanel
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (UIPanel)mClipping;
		}
	}

	public int clipCount
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)mParentPanel;
		}
	}

	public bool hasClipping
	{
		get
		{
			//IL_0119: Expected I, but got Obj
			//IL_012f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			UIPanel uIPanel = this;
			bool flag = false;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)uIPanel).FindKernel((string)null) == 0)
				{
					break;
				}
				if (uIPanel.mClipping == UIDrawCall.Clipping.SoftClip || uIPanel.mClipping == UIDrawCall.Clipping.TextureMask)
				{
					bool flag2 = (byte)((flag ? 1u : 0u) + 1u) != 0;
					flag = flag2;
				}
				uIPanel = uIPanel.mParentPanel;
			}
			return flag;
		}
	}

	public bool hasCumulativeClipping
	{
		get
		{
			if (mClipping == UIDrawCall.Clipping.SoftClip)
			{
				return true;
			}
			return mClipping == UIDrawCall.Clipping.TextureMask;
		}
	}

	public bool clipsChildren => hasClipping;

	public Vector2 clipOffset
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+D8]");
			if (0 != (nint)this)
			{
				_ = 1;
				_ = -1;
			}
			Vector2 result = default;
			return result;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector2)+104]");
			UIPanel uIPanel = (UIPanel)0;
		}
	}

	public Texture2D clipTexture
	{
		get
		{
			//IL_000a: Expected Obj, but got I4
			return (Texture2D)clipsChildren;
		}
		set
		{
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected Obj, but got Unknown
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Expected Obj, but got Unknown
			//IL_0177: Expected I, but got Obj
			//IL_018d: Expected Obj, but got I
			//IL_0112: Expected VT, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			//IL_0073: Expected I, but got Obj
			//IL_0089: Expected Obj, but got I
			//IL_00b4: Expected I, but got Obj
			object obj = this + 260;
			object obj3 = default;
			object obj2 = obj3 + 8;
			obj2 = value;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v41 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float value2 = (float)obj - (float)obj2;
			float num3 = Math.Abs(value2);
			if (!(num3 > 0.001f))
			{
				object obj5 = this + 260;
				obj2 = value;
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num5 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S2_v10 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v36+4]");
				float num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
				float value3 = num6 - 0f;
				float num7 = Math.Abs(value3);
				if (!(num7 > 0.001f))
				{
					return;
				}
			}
			obj3 = value;
			obj2 = obj3;
			mClipOffset = (Vector2)obj2;
			RebuildAllDrawCalls();
			if (onClipMove != null)
			{
				onClipMove.EndInvoke((IAsyncResult)this);
			}
		}
	}

	public Vector4 clipRange
	{
		get
		{
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector4)+D0]");
			Vector4 vector = default;
			if (((ComputeShader)0).FindKernel((string)(object)this) != 0)
			{
				object obj2 = vector + 208;
				obj2 = this;
			}
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 220;
			UIPanel uIPanel = (UIPanel)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public Vector4 baseClipRegion
	{
		get
		{
			((UnityEngine.Object)this).m_CachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
			Vector4 vector = finalClipRegion;
			Vector4 result = default;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 220;
			UIPanel uIPanel = (UIPanel)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public Vector4 finalClipRegion
	{
		get
		{
			//IL_0370: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Expected Obj, but got Unknown
			//IL_038f: Expected I, but got Obj
			//IL_03a5: Expected Obj, but got I
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Expected Obj, but got Unknown
			//IL_0293: Expected Obj, but got VT
			//IL_02a5: Expected I, but got Obj
			//IL_02bb: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected Obj, but got Unknown
			//IL_007a: Expected I, but got Obj
			//IL_0090: Expected Obj, but got I
			//IL_02e6: Expected I, but got Obj
			//IL_00bb: Expected I, but got Obj
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected Obj, but got Unknown
			//IL_0122: Expected I, but got Obj
			//IL_0138: Expected Obj, but got I
			//IL_0163: Expected I, but got Obj
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Expected Obj, but got Unknown
			//IL_01ca: Expected I, but got Obj
			//IL_01e0: Expected Obj, but got I
			//IL_020b: Expected I, but got Obj
			Vector4 vector = default;
			object obj = vector + 220;
			object obj2 = this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v71 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float value = (float)obj - (float)obj2;
			float num3 = Math.Abs(value);
			if (!(num3 > 0.001f))
			{
				object obj4 = vector + 220;
				obj2 = this;
				_ = ((UnityEngine.Object)this).m_CachedPtr;
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num5 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S2_v40 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v54+4]");
				float num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				float value2 = num6 - 0f;
				float num7 = Math.Abs(value2);
				if (!(num7 > 0.001f))
				{
					object obj6 = vector + 220;
					obj2 = this;
					_ = ((UnityEngine.Object)this).m_CachedPtr;
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S2_v19 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num9 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S2_v36 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v60+8]");
					float num10 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					float value3 = num10 - 0f;
					float num11 = Math.Abs(value3);
					if (!(num11 > 0.001f))
					{
						object obj8 = vector + 220;
						obj2 = this;
						_ = ((UnityEngine.Object)this).m_CachedPtr;
						nint num12 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S2_v28 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num13 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S2_v32 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v66+C]");
						float num14 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
						float value4 = num14 - 0f;
						float num15 = Math.Abs(value4);
						if (!(num15 > 0.001f))
						{
							goto IL_049d;
						}
					}
				}
			}
			_ = 1;
			obj2 = this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			object obj10 = vector + 220;
			obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			_ = -1;
			UIScrollView component = ((Component)vector).GetComponent<UIScrollView>();
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num17 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				component.OnScrollBar();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector4)+C4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
			}
			goto IL_049d;
			IL_049d:
			return vector;
		}
	}

	public unsafe Vector2 clipSoftness
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected Obj, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected Obj, but got Unknown
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected Obj, but got Unknown
			//IL_006b: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			//IL_0088: Expected Obj, but got I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected Obj, but got Unknown
			//IL_00a6: Expected I4, but got Obj
			//IL_018d: Expected Obj, but got F4
			//IL_01cb: Expected VT, but got Obj
			//IL_01f2: Expected VT, but got Obj
			//IL_01f2: Expected Obj, but got I4
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected Obj, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected Obj, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected Obj, but got Unknown
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected Obj, but got Unknown
			//IL_010a: Expected native int or pointer, but got VT
			//IL_012c: Expected native int or pointer, but got VT
			//IL_0158: Expected native int or pointer, but got VT
			//IL_023f: Expected Obj, but got F4
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Expected Obj, but got Unknown
			//IL_0284: Expected Obj, but got F4
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Expected Obj, but got Unknown
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Expected Obj, but got Unknown
			//IL_02fb: Expected F4, but got Obj
			//IL_02f6: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 + 16;
			object obj3 = obj2 + 8;
			Transform transform = (Transform)(obj2 + 72);
			object obj4 = obj2 + 60;
			object obj5 = obj2 + 48;
			object obj6 = obj2 + 36;
			object obj7 = obj2 + 96;
			obj7 = 0;
			_ = 0;
			object obj8 = obj2 + 84;
			obj8 = 0;
			_ = 0;
			UIRoot uIRoot = (UIRoot)(obj2 + 24);
			uIRoot.UpdateScale((byte)(int)this != 0);
			Vector2 vector = default;
			if (mClipping != UIDrawCall.Clipping.None)
			{
				object obj9 = this + 220;
				object obj10 = this + 260;
				object obj11 = this + 220;
				object obj12 = this + 260;
				uIRoot = uIRoot;
				obj = uIRoot;
				((Vector2*)(nint)vector)->x = 0f;
				_ = 0;
				float x = (float)obj9 + (float)obj10;
				((Vector2*)(nint)vector)->x = x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v77+4]");
				float num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v80+4]");
				float y = num + 0f;
				((Vector2*)(nint)vector)->y = y;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
				_ = 0;
			}
			else
			{
				obj = uIRoot;
				obj3 = uIRoot;
				obj7 = 0f;
				_ = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+4]");
				_ = 0;
				bool flag = isFullyAnchored;
				Camera camera = anchorCamera;
				transform.position = (Vector3)camera;
				uIRoot = (UIRoot)(object)transform;
				((UnityEngine.Object)uIRoot).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
				Vector3 vector2 = ((Camera)flag).WorldToViewportPoint((Vector3)uIRoot);
				obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+8]");
				_ = 0;
				uIRoot = uIRoot;
				float num2 = (float)uIRoot * 0.5f;
				float num3 = (float)obj8 - num2;
				obj8 = num3;
				object obj13 = obj8 + 4;
				obj2 = uIRoot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				float num4 = 0f * 0.5f;
				float num5 = (float)obj13 - num4;
				obj13 = num5;
				obj5 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v20+8]");
				_ = 0;
				object obj14 = obj7 - obj5;
				obj7 = obj14;
				object obj15 = obj7 + 4;
				obj6 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v20+8]");
				_ = 0;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15+4]");
				object obj17 = obj16 - 0;
				obj15 = obj17;
				((Vector2*)(nint)vector)->x = (float)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17+8]");
				_ = 0;
			}
			return vector;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector2)+EC]");
			UIPanel uIPanel = (UIPanel)0;
		}
	}

	public override Vector3[] localCorners => (Vector3[])(object)mClipTexture;

	public unsafe override Vector3[] worldCorners
	{
		get
		{
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Expected Ref, but got Unknown
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Expected Obj, but got Unknown
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b6: Expected Obj, but got Unknown
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Expected Obj, but got Unknown
			//IL_01b3: Expected Obj, but got I4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected Obj, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected Obj, but got Unknown
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected Obj, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected Obj, but got Unknown
			//IL_00af: Expected Obj, but got I
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected Obj, but got Unknown
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected Obj, but got Unknown
			//IL_0111: Expected I, but got Obj
			//IL_0127: Expected Obj, but got I
			//IL_02ec: Expected Obj, but got I4
			//IL_02fa: Expected Obj, but got F4
			//IL_0324: Unknown result type (might be due to invalid IL or missing references)
			//IL_0329: Expected Obj, but got Unknown
			//IL_0336: Expected Obj, but got VT
			//IL_034c: Expected Obj, but got I4
			//IL_0362: Expected Obj, but got F4
			//IL_0375: Expected I, but got F4
			//IL_0391: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Expected Obj, but got Unknown
			//IL_03a3: Expected Obj, but got VT
			//IL_03b9: Expected Obj, but got I4
			//IL_03c7: Expected Obj, but got F4
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Expected Obj, but got Unknown
			//IL_0403: Expected Obj, but got VT
			//IL_0419: Expected Obj, but got I4
			//IL_0427: Expected Obj, but got F4
			//IL_0451: Unknown result type (might be due to invalid IL or missing references)
			//IL_0456: Expected Obj, but got Unknown
			//IL_0463: Expected Obj, but got VT
			//IL_0152: Expected I, but got Obj
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected Obj, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected Obj, but got Unknown
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Expected Obj, but got Unknown
			//IL_0245: Unknown result type (might be due to invalid IL or missing references)
			//IL_024a: Expected Obj, but got Unknown
			//IL_0264: Expected Obj, but got VT
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Expected Obj, but got Unknown
			object obj = default;
			ref Vector3 reference = ref *(Vector3*)(obj + 48);
			object obj2 = obj + 36;
			Transform transform = (Transform)(obj + 24);
			object obj3 = obj + 12;
			Vector3[] result;
			if (mClipping != UIDrawCall.Clipping.None)
			{
				object obj4 = this + 260;
				object obj5 = this + 220;
				object obj6 = obj4 + obj5;
				object obj7 = this + 220;
				float num = 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S2_v10+8]");
				float num2 = num * 0f;
				float num3 = (float)obj6 - num2;
				object obj8 = this + 220;
				float num4 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v42+8]");
				float num5 = num4 + 0f;
				object obj9 = this + 260;
				object obj10 = this + 220;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v49+4]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v46+4]");
				object obj11 = num6 + 0;
				object obj12 = this + 220;
				float num7 = 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v15+C]");
				float num8 = num7 * 0f;
				float num9 = (float)obj11 - num8;
				object obj13 = this + 220;
				float num10 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v51+C]");
				float num11 = num10 + 0f;
				nint num12 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v55 (Il2CppClass<UIPanel>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num13 = (nint)typeof(UIPanel);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v86 (Il2CppClass<UIPanel>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = 0;
				_ = 0;
				obj2 = num3;
				_ = 0f;
				reference = ref *(Vector3*)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				object obj15 = mCorners + 16;
				obj15 = reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
				_ = 0;
				transform = (Transform)0;
				((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
				transform = (Transform)num3;
				((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0f;
				reference = ref *(Vector3*)transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				object obj16 = mCorners + 28;
				obj16 = reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
				_ = 0;
				obj3 = 0;
				_ = 0;
				obj3 = num5;
				_ = 0f;
				reference = ref *(Vector3*)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				_ = 0;
				object obj17 = mCorners + 40;
				obj17 = reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
				_ = 0;
				obj = 0;
				_ = 0;
				obj = num5;
				_ = 0f;
				reference = ref *(Vector3*)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				object obj18 = mCorners + 52;
				obj18 = reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
				_ = 0;
				result = mCorners;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Camera camera = anchorCamera;
				object obj19 = 0;
				Vector3[] array = default;
				while (true)
				{
					bool flag = (nint)obj19 <= 3;
					bool flag2 = !flag;
					result = array;
					if (flag2)
					{
						break;
					}
					object obj20 = array + 16;
					object obj21 = obj19 * 12;
					object obj22 = obj20 + obj21;
					obj2 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S1_v14+8]");
					_ = 0;
					reference = ref *(Vector3*)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					transform.Internal_LookAt_Injected(ref *(Vector3*)camera, ref reference);
					reference = ref *(Vector3*)transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					object obj23 = array + 16;
					object obj24 = obj19 * 12;
					object obj25 = obj23 + obj24;
					obj25 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					object obj26 = obj19 + 1;
					obj19 = obj26;
				}
			}
			return result;
		}
	}

	public static int CompareFunc(UIPanel a, UIPanel b)
	{
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00bd: Expected I4, but got Obj
		//IL_00d1: Expected I, but got Obj
		//IL_00e7: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		((UILabel)(object)a)._002Ector();
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v18 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUIText.encoding = false;
		NGUIText.symbolStyle = NGUIText.SymbolStyle.None;
		int result = (int)NGUIText.GetEndOfLineThatFits((string)(object)b);
		NGUIText.bitmapFont = null;
		nint num3 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v11 (Il2CppClass<NGUIText>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = 0;
		return result;
	}

	private void InvalidateClipping()
	{
		CancelInvoke();
	}

	public override Vector3[] GetSides(Transform relativeTo)
	{
		//IL_0277: Expected I, but got Obj
		//IL_028d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)this).FindKernel((string)(object)relativeTo) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)this).FindKernel((string)null) != 0)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)relativeTo).FindKernel((string)null) != 0)
				{
					int num7 = mDepth;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [relativeTo @ L1 (UnityEngine.Transform)+F4]");
					if ((nint)num7 < (nint)0)
					{
						return (Vector3[])(-1);
					}
					int num8 = mDepth;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [relativeTo @ L1 (UnityEngine.Transform)+F4]");
					if ((nint)num8 > (nint)0)
					{
						return (Vector3[])1;
					}
					int hashCode = base.GetHashCode();
					int hashCode2 = relativeTo.GetHashCode();
					if (hashCode < hashCode2)
					{
						return (Vector3[])(-1);
					}
					return (Vector3[])1;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public unsafe override void Invalidate(bool includeChildren)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_008e: Expected Obj, but got VT
		//IL_009c: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected VT, but got Unknown
		//IL_011c: Expected F4, but got Obj
		//IL_0117: Expected native int or pointer, but got VT
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_013f: Expected Ref, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_0071: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = mClipSoftness;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v32 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 16;
		obj4 = obj;
		object obj5 = obj2 + 8;
		obj5 = ((bool*)(includeChildren ? 1 : 0))->m_value;
		Vector4 vector = (Vector4)(obj2 + 32);
		((Vector4*)(nint)vector)->x = (float)obj4;
		object obj6 = obj2 + 40;
		obj6 = obj5;
		if (((Vector4*)vector)->Equals(obj6))
		{
			obj2 = ((bool*)(includeChildren ? 1 : 0))->m_value;
			obj6 = obj2;
			mClipSoftness = (Vector2)obj6;
		}
	}

	public override float CalculateFinalAlpha(int frameID)
	{
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_009e: Expected F4, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		UIRoot uIRoot = root;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIRoot).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9CD6");
			object obj2 = this + 80;
			object obj3 = default;
			float num3 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v9+C]");
			return num3 * 0f;
		}
		object obj4 = this + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v16+C]");
		return 0f;
	}

	public override void SetRect(float x, float y, float width, float height)
	{
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_04db: Expected Obj, but got I4
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Obj, but got Unknown
		//IL_04f9: Expected I4, but got Obj
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		//IL_051d: Expected I, but got Obj
		//IL_0533: Expected Obj, but got I
		//IL_0570: Expected F4, but got Obj
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected Obj, but got Unknown
		//IL_05b2: Expected F4, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009b: Expected VT, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_0608: Expected Obj, but got F4
		//IL_0630: Invalid comparison between Obj and F4
		//IL_00fc: Expected I, but got Obj
		//IL_069f: Invalid comparison between I and F4
		//IL_072c: Expected Obj, but got I4
		//IL_01fe: Expected I, but got Obj
		//IL_0214: Expected Obj, but got I
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_023f: Expected I, but got Obj
		//IL_036d: Expected I, but got Obj
		//IL_0383: Expected Obj, but got I
		//IL_02ef: Expected I, but got Obj
		//IL_041d: Expected I, but got Obj
		//IL_0433: Expected Obj, but got I
		//IL_03ae: Expected I, but got Obj
		//IL_045e: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		UIWidget uIWidget = (UIWidget)(obj2 + 24);
		uIWidget.width = (int)this;
		object obj3 = obj2 + 16;
		obj3 = uIWidget;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v18 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v95 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float b = x + width;
		float num3 = Mathf.LerpUnclamped(x, b, (float)obj3);
		object obj5 = obj2 + 8;
		obj5 = uIWidget;
		float b2 = y + height;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v25+4]");
		float num4 = Mathf.LerpUnclamped(y, b2, 0f);
		float f = width + 0.5f;
		int num5 = Mathf.RoundToInt(f);
		float f2 = height + 0.5f;
		int num6 = Mathf.RoundToInt(f2);
		obj2 = uIWidget;
		uIWidget = uIWidget;
		Camera camera = anchorCamera;
		((Transform)(object)uIWidget).localPosition = (Vector3)camera;
		obj = uIWidget;
		_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
		nint num7 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v30 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v106 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num9 = num5 & -2;
		float num10 = num3 + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		obj = num10;
		float num11 = num4 + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		int num12;
		if (obj2 == (object)0.5f)
		{
			num12 = num9;
			num5 = num9;
		}
		else
		{
			num12 = num5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj7 = default;
		int num13 = default;
		if (num5 < (nint)obj7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		}
		else
		{
			num13 = num12;
		}
		int num14 = num6 & -2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (UIWidget)+4]");
		int num15;
		if (0f == 0.5f)
		{
			num15 = num14;
		}
		else
		{
			num15 = num6;
			num14 = num6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj8 = default;
		if (num14 < (nint)obj8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			int num16 = default;
			num15 = num16;
		}
		uIWidget = (UIWidget)obj;
		UIWidget uIWidget2 = uIWidget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)uIWidget2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = ((Transform)(object)uIWidget).eulerAngles;
		((UIWidget)this).height = num13;
		Color color = ((UIWidget)num15).color;
		UIDrawCall.OnRenderCallback onRender = ((UIWidget)this).onRender;
		if (onRender == null)
		{
			return;
		}
		Transform parentInternal = ((Transform)(object)camera).parentInternal;
		AnchorPoint anchorPoint = leftAnchor;
		nint num17 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v100 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint.target))
		{
			leftAnchor.SetVertical(parentInternal, x);
		}
		AnchorPoint anchorPoint2 = rightAnchor;
		nint num19 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v65 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num20 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S1_v95 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint2.target))
		{
			float localPos = x + width;
			rightAnchor.SetVertical(parentInternal, localPos);
		}
		AnchorPoint anchorPoint3 = bottomAnchor;
		nint num21 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num22 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S1_v90 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint3.target))
		{
			bottomAnchor((GameObject)(object)parentInternal, y);
		}
		AnchorPoint anchorPoint4 = topAnchor;
		nint num23 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num24 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S1_v85 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint4.target))
		{
			float delta = y + height;
			topAnchor((GameObject)(object)parentInternal, delta);
		}
	}

	public bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_007e: Expected Obj, but got VT
		//IL_007e: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got VT
		//IL_008b: Expected Obj, but got I4
		//IL_009d: Expected I4, but got VT
		//IL_009d: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got VT
		nint num = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIDrawCall>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = UIDrawCall.Count(this);
		string text = ((Component)num3).tag;
		Transform transform = ((UIRect)a).cachedTransform;
		bool activeSelf = ((GameObject)(object)transform).activeSelf;
		((GameObject)(object)text).SetActive(activeSelf);
		((UIDrawCall)num3).mainTexture = (Texture)b;
		((UIDrawCall)num3).shader = (Shader)c;
		((UIDrawCall)num3).shadowMode = (UIDrawCall.ShadowMode)d;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ L1 (UnityEngine.Vector3)+68]");
		((UIDrawCall)num3).sortingOrder = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ L1 (UnityEngine.Vector3)+F8]");
		((UIDrawCall)num3).sortingLayerName = (string)0;
		object obj2 = num3 + 24;
		obj2 = a;
		return (byte)num3 != 0;
	}

	public unsafe bool IsVisible(Vector3 worldPos)
	{
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected Obj, but got Unknown
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected VT, but got Unknown
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected Obj, but got Unknown
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected Obj, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected Obj, but got Unknown
		//IL_0818: Expected Obj, but got I4
		//IL_03ee: Expected I, but got Obj
		//IL_0404: Expected Obj, but got I
		//IL_0a5b: Expected Obj, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0159: Expected I, but got Obj
		//IL_016f: Expected Obj, but got I
		//IL_0a86: Expected Obj, but got VT
		//IL_042f: Expected I, but got Obj
		//IL_0854: Expected Obj, but got F4
		//IL_0866: Expected I, but got F4
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected Obj, but got Unknown
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_026d: Expected I, but got Obj
		//IL_0283: Expected Obj, but got I
		//IL_019a: Expected I, but got Obj
		//IL_0b9e: Expected I4, but got Obj
		//IL_08e5: Expected Obj, but got VT
		//IL_049f: Expected I, but got Obj
		//IL_04b5: Expected Obj, but got I
		//IL_0914: Expected I, but got Obj
		//IL_092a: Expected Obj, but got I
		//IL_02ae: Expected I, but got Obj
		//IL_0ab9: Expected VT, but got Obj
		//IL_02f6: Expected Obj, but got I4
		//IL_053a: Expected Obj, but got I4
		//IL_04e0: Expected I, but got Obj
		//IL_0397: Expected I, but got Obj
		//IL_0636: Expected I, but got Obj
		//IL_064c: Expected Obj, but got I
		//IL_0309: Expected I, but got Obj
		//IL_031f: Expected Obj, but got I
		//IL_0b70: Expected Obj, but got VT
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected Obj, but got Unknown
		//IL_05a8: Expected I, but got Obj
		//IL_05be: Expected Obj, but got I
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected Obj, but got Unknown
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0964: Expected Obj, but got Unknown
		//IL_097e: Expected F4, but got Obj
		//IL_0979: Expected native int or pointer, but got VT
		//IL_0993: Expected F4, but got I
		//IL_098e: Expected native int or pointer, but got VT
		//IL_09a0: Expected Obj, but got F4
		//IL_09b2: Expected I, but got F4
		//IL_09c3: Expected Ref, but got VT
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected Obj, but got Unknown
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected Obj, but got Unknown
		//IL_0a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Expected Obj, but got Unknown
		//IL_0677: Expected I, but got Obj
		//IL_0acb: Expected F4, but got Obj
		//IL_0ac6: Expected native int or pointer, but got VT
		//IL_0add: Expected F4, but got I
		//IL_0ad8: Expected native int or pointer, but got VT
		//IL_0b07: Expected VT, but got Obj
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2e: Expected Obj, but got Unknown
		//IL_034a: Expected I, but got Obj
		//IL_06bf: Expected Obj, but got I4
		//IL_05e9: Expected I, but got Obj
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected Obj, but got Unknown
		//IL_0707: Expected F4, but got Obj
		//IL_0702: Expected native int or pointer, but got VT
		//IL_071c: Expected F4, but got I
		//IL_0717: Expected native int or pointer, but got VT
		//IL_0729: Expected Obj, but got F4
		//IL_073b: Expected I, but got F4
		//IL_074c: Expected Ref, but got VT
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected Obj, but got Unknown
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected Obj, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected Obj, but got Unknown
		object obj = default;
		Transform transform = (Transform)(obj + 60);
		Vector3 vector = (Vector3)(obj + 48);
		Transform transform2 = (Transform)(obj + 24);
		object obj2 = obj + 12;
		object obj3 = obj + 36;
		obj3 = 0;
		_ = 0;
		Vector3[] sides;
		Vector3[] array2;
		if (mClipping != UIDrawCall.Clipping.None)
		{
			object obj4 = this + 260;
			object obj5 = this + 220;
			object obj6 = obj4 + obj5;
			object obj7 = this + 220;
			float num = 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S2_v33+8]");
			float num2 = num * 0f;
			float num3 = (float)obj6 - num2;
			object obj8 = this + 220;
			float num4 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S2_v36+8]");
			float num5 = num4 + 0f;
			float num6 = num3 + num5;
			float num7 = num6 * 0.5f;
			object obj9 = this + 260;
			object obj10 = this + 220;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v102+4]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v97+4]");
			object obj11 = num8 + 0;
			object obj12 = this + 220;
			float num9 = 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S2_v40+C]");
			float num10 = num9 * 0f;
			float num11 = (float)obj11 - num10;
			object obj13 = this + 220;
			float num12 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v43+C]");
			float num13 = num12 + 0f;
			float num14 = num11 + num13;
			float num15 = num14 * 0.5f;
			Camera camera = anchorCamera;
			nint num16 = (nint)typeof(UIRect);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v111 (Il2CppClass<UIRect>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num17 = (nint)typeof(UIRect);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v187 (Il2CppClass<UIRect>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			transform = (Transform)vector.x;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
			object obj15 = UIRect.mSides + 16;
			obj15 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			transform = transform2;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			object obj16 = UIRect.mSides + 28;
			obj16 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			transform = (Transform)obj2;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			object obj17 = UIRect.mSides + 40;
			obj17 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			transform = (Transform)obj;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			object obj18 = UIRect.mSides + 52;
			obj18 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v139 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num19 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S0_v183 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)worldPos).FindKernel(null) != 0)
			{
				object obj20 = 0;
				while ((nint)obj20 <= 3)
				{
					nint num20 = (nint)typeof(UIRect);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v165 (Il2CppClass<UIRect>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num21 = (nint)typeof(UIRect);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v177 (Il2CppClass<UIRect>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj22 = UIRect.mSides + 16;
					object obj23 = obj20 * 12;
					object obj24 = obj22 + obj23;
					((Vector3*)(nint)vector)->x = (float)obj24;
					Vector3 vector2 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S2_v73+8]");
					((Vector3*)(nint)vector2)->z = 0f;
					transform = (Transform)vector.x;
					((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
					transform2.Internal_LookAt_Injected(ref *(Vector3*)worldPos, ref *(Vector3*)transform);
					transform = transform2;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					object obj25 = UIRect.mSides + 16;
					object obj26 = obj20 * 12;
					object obj27 = obj25 + obj26;
					obj27 = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					object obj28 = obj20 + 1;
					obj20 = obj28;
				}
			}
			nint num22 = (nint)typeof(UIRect);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v147 (Il2CppClass<UIRect>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num23 = (nint)typeof(UIRect);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S0_v154 (Il2CppClass<UIRect>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			sides = UIRect.mSides;
		}
		else
		{
			bool flag = isFullyAnchored;
			nint num24 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num25 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v82 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag).FindKernel(null) != 0 && ~(anchorOffset ? 1u : 0u) == 0)
			{
				float num26 = ((UIWidget)this).alpha;
				nint num27 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S2_v8 (Il2CppClass<NGUITools>)+BA]");
				object obj31 = (nint)0 & (nint)0x200;
				if (obj31 != null)
				{
					nint num28 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S2_v27 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3[] array = NGUITools.GetWorldCorners(mCam, num26);
				Camera camera2 = anchorCamera;
				transform.position = (Vector3)camera2;
				obj3 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				object obj32 = 0;
				while ((nint)obj32 <= 3)
				{
					object obj33 = array + 16;
					object obj34 = obj32 * 12;
					object obj35 = obj33 + obj34;
					transform2 = (Transform)obj35;
					Transform transform5 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S1_v59+8]");
					((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
					obj2 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+8]");
					_ = 0;
					nint num29 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S0_v77 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj36 = (nint)0 & (nint)0x200;
					if (obj36 != null)
					{
						nint num30 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ S0_v90 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = (float)transform2;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
					transform = (Transform)obj2;
					Transform transform6 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
					Vector3 vector3 = vector - (Vector3)transform;
					obj35 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					object obj37 = obj32 + 1;
					obj32 = obj37;
				}
				nint num31 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj38 = (nint)0 & (nint)0x200;
				if (obj38 != null)
				{
					nint num32 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ S0_v68 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num33 = ((ComputeShader)worldPos).FindKernel(null);
				bool flag2 = num33 == 0;
				array2 = array;
				if (!flag2)
				{
					object obj39 = 0;
					while ((nint)obj39 <= 3)
					{
						object obj40 = array + 16;
						object obj41 = obj39 * 12;
						object obj42 = obj40 + obj41;
						((Vector3*)(nint)vector)->x = (float)obj42;
						Vector3 vector4 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ S1_v36+8]");
						((Vector3*)(nint)vector4)->z = 0f;
						transform = (Transform)vector.x;
						((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
						transform2.Internal_LookAt_Injected(ref *(Vector3*)worldPos, ref *(Vector3*)transform);
						transform = transform2;
						((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
						object obj43 = array + 16;
						object obj44 = obj39 * 12;
						object obj45 = obj43 + obj44;
						obj45 = transform;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
						object obj46 = obj39 + 1;
						obj39 = obj46;
					}
					array2 = array;
				}
				goto IL_0b99;
			}
			sides = ((UIWidget)this).GetSides((Transform)worldPos);
		}
		array2 = sides;
		goto IL_0b99;
		IL_0b99:
		return (byte)(int)array2 != 0;
	}

	public bool IsVisible(UIWidget w)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 24;
		object obj3 = obj2 + 12;
		obj3 = 0;
		_ = 0;
		if (mAlpha < 0.001f)
		{
			return false;
		}
		if (mClipping != UIDrawCall.Clipping.None)
		{
			if (mClipping == UIDrawCall.Clipping.ConstrainButDontClip)
			{
				return true;
			}
			OnAnchor();
			obj = w;
			_ = ((UnityEngine.Object)w).m_CachedPtr;
			object obj4 = this + 116;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = this + 280;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				return false;
			}
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			_ = 0;
			object obj6 = this + 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v34+4]");
			if (num < 0)
			{
				return false;
			}
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			_ = 0;
			object obj7 = this + 288;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
			{
				return false;
			}
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			_ = 0;
			object obj8 = this + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v48+4]");
			bool flag = num2 > 0;
			return !flag;
		}
		return true;
	}

	public unsafe bool Affects(UIWidget w)
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected I4, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0188: Expected Obj, but got I4
		//IL_01a5: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0271: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 84;
		AsyncCallback asyncCallback = (AsyncCallback)(obj2 + 72);
		ProductRequestResultInfo[] array = (ProductRequestResultInfo[])(obj2 + 60);
		bool flag = (byte)(obj2 + 48) != 0;
		object obj3 = obj2 + 36;
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 12;
		object obj6 = 0;
		UIPanel uIPanel = this;
		bool result;
		object obj8 = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v69 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = ((ComputeShader)(object)uIPanel).FindKernel((string)null);
			bool flag2 = num3 == 0;
			result = true;
			if (flag2)
			{
				break;
			}
			if ((uIPanel.mClipping == UIDrawCall.Clipping.None || uIPanel.mClipping == UIDrawCall.Clipping.ConstrainButDontClip) && !w.hideIfOffScreen)
			{
				uIPanel = uIPanel.mParentPanel;
				continue;
			}
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				obj6 = obj8;
			}
			object obj9 = obj6 + 16;
			obj3 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v20+8]");
			_ = 0;
			object obj10 = obj6 + 28;
			obj4 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v25+8]");
			_ = 0;
			object obj11 = obj6 + 40;
			obj5 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v30+8]");
			_ = 0;
			object obj12 = obj6 + 52;
			obj2 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v35+8]");
			_ = 0;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj3 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			_ = 0;
			array = (ProductRequestResultInfo[])obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			_ = 0;
			asyncCallback = (AsyncCallback)obj5;
			AsyncCallback asyncCallback2 = asyncCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((Delegate)asyncCallback2).method_ptr = (IntPtr)0;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			IAsyncResult asyncResult = ((ProductInfoRequestDelegate)(object)uIPanel).BeginInvoke(flag, array, asyncCallback, obj);
			if (asyncResult != null)
			{
				uIPanel = uIPanel.mParentPanel;
				continue;
			}
			result = false;
			break;
		}
		return result;
	}

	public void RebuildAllDrawCalls()
	{
		//IL_01ee: Expected I, but got Obj
		//IL_0204: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0241: Expected I, but got Obj
		//IL_0257: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		mResized = true;
		mMatrixFrame = -1;
		nint num = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UIPanel>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v54 (Il2CppClass<UIPanel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<UIPanel> list = UIPanel.list;
		int num3 = default;
		int num10 = default;
		while (num3 < list._size)
		{
			nint num4 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v22 (Il2CppClass<UIPanel>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v48 (Il2CppClass<UIPanel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIPanel uIPanel = UIPanel.list.get_Item(num3);
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)uIPanel).FindKernel((string)(object)this) != 0)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num9 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (uIPanel.mParentPanel != this)
				{
					uIPanel.RebuildAllDrawCalls();
				}
			}
			num3 = num10 + 1;
		}
	}

	public void SetDirty()
	{
		mRebuild = true;
	}

	protected override void Awake()
	{
		List<UIDrawCall> list = drawCalls;
		int num = 0;
		while (num < list._size)
		{
			UIDrawCall uIDrawCall = drawCalls.get_Item(num);
			uIDrawCall.isDirty = true;
			int num2 = num + 1;
			num = num2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	private void FindParent()
	{
		Start();
	}

	public override void ParentHasChanged()
	{
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		Camera camera = anchorCamera;
		Transform parentInternal = ((Transform)(object)camera).parentInternal;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 300;
		UIPanel uIPanel;
		if (((ComputeShader)(object)parentInternal).FindKernel((string)null) != 0)
		{
			string go = parentInternal.tag;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v5 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S2_v11 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uIPanel = NGUITools.FindInParents<UIPanel>((GameObject)(object)go);
		}
		else
		{
			uIPanel = null;
		}
		obj2 = uIPanel;
	}

	protected override void OnStart()
	{
		base.OnUpdate();
		ParentHasChanged();
	}

	protected override void OnEnable()
	{
		Transform transform = cachedTransform;
		bool activeSelf = ((GameObject)(object)transform).activeSelf;
		mLayer = (activeSelf ? 1 : 0);
	}

	protected override void OnInit()
	{
		mRebuild = true;
		mAlphaFrameID = -1;
		mMatrixFrame = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		base.OnInit();
		mMatrixFrame = -1;
	}

	protected override void OnDisable()
	{
		//IL_036e: Expected I, but got Obj
		//IL_0384: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_048c: Expected I, but got Obj
		//IL_04a2: Expected Obj, but got I
		//IL_00bc: Expected I, but got Obj
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_0556: Expected Obj, but got I4
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_0320: Expected I, but got Obj
		//IL_014a: Expected I, but got Obj
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I4
		//IL_023a: Expected VT, but got Obj
		//IL_01e2: Expected I, but got Obj
		//IL_042a: Expected I, but got Obj
		//IL_0440: Expected Obj, but got I
		//IL_04fc: Expected Obj, but got VT
		//IL_024d: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I4
		nint num = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIPanel>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v85 (Il2CppClass<UIPanel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (list.Contains(this))
		{
			return;
		}
		base.OnDisable();
		ParentHasChanged();
		Rigidbody component = GetComponent<Rigidbody>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v81 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (component != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mParentPanel != null)
			{
				bool flag = isFullyAnchored;
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				_0021_00210 val = ((((ComputeShader)flag).FindKernel(null) == 0) ? ((_0021_00210)null) : ((_0021_00210)((Component)mCam).GetComponentInChildren<T>()));
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v57 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v73 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)val).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v55 (T)+C]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v55 (T)+C]");
						if ((nint)0 != 0)
						{
							goto IL_045d;
						}
					}
					string text = tag;
					Rigidbody rigidbody = ((GameObject)(object)text).AddComponent<Rigidbody>();
					Vector3 position = ((Rigidbody)1).position;
					rigidbody.isKinematic = false;
				}
			}
		}
		goto IL_045d;
		IL_045d:
		mRebuild = true;
		mAlphaFrameID = -1;
		mMatrixFrame = -1;
		nint num11 = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v32 (Il2CppClass<UIPanel>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v43 (Il2CppClass<UIPanel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num13 = 0;
		_ = 0;
		object obj8 = default;
		object obj7 = obj8 + 16;
		obj7 = 0;
		throw new NullReferenceException();
	}

	private void UpdateTransformMatrix()
	{
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_0067: Expected I, but got Obj
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_030a: Expected VT, but got Obj
		//IL_00f5: Expected I, but got Obj
		List<UIDrawCall> list = drawCalls;
		int num = 0;
		while (num < list._size)
		{
			UIDrawCall uIDrawCall = drawCalls.get_Item(num);
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v70 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v89 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)uIDrawCall).FindKernel((string)null) != 0)
			{
				nint num4 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v80 (Il2CppClass<UIDrawCall>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(UIDrawCall);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v85 (Il2CppClass<UIDrawCall>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIDrawCall.MoveToScene((Scene)uIDrawCall);
			}
			int num6 = num + 1;
			num = num6;
		}
		throw new IndexOutOfRangeException();
	}

	protected unsafe override void OnAnchor()
	{
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected VT, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_005e: Expected F4, but got Obj
		//IL_0059: Expected native int or pointer, but got VT
		//IL_00cd: Expected I4, but got Obj
		//IL_00e0: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_01f1: Expected F4, but got Obj
		//IL_01ec: Expected native int or pointer, but got VT
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0259: Expected Obj, but got I
		//IL_0266: Expected F4, but got Obj
		//IL_0261: Expected native int or pointer, but got VT
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_028d: Expected Obj, but got F4
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0121: Expected I, but got Obj
		object obj = default;
		Vector2 vector = (Vector2)(obj + 48);
		object obj2 = obj + 112;
		UIRoot uIRoot = (UIRoot)(obj + 40);
		object obj3 = obj + 32;
		object obj4 = obj + 24;
		object obj5 = obj + 16;
		object obj6 = obj + 8;
		int renderedFrameCount = Time.renderedFrameCount;
		if (!mHasMoved && mMatrixFrame == renderedFrameCount)
		{
			return;
		}
		mMatrixFrame = renderedFrameCount;
		Camera camera = anchorCamera;
		Matrix4x4 localToWorldMatrix = ((Transform)(object)camera).localToWorldMatrix;
		((Vector2*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9CDA");
		uIRoot.UpdateScale((byte)(int)this != 0);
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v42 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v69 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj4 = uIRoot;
		((Vector2*)(nint)vector)->x = (float)obj4;
		Vector2 vector2 = vector / 0.5f;
		object obj8 = this + 260;
		object obj9 = this + 220;
		object obj10 = obj8 + obj9;
		object obj11 = this + 260;
		object obj12 = this + 220;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v54+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v45+4]");
		object obj13 = num3 + 0;
		((Vector2*)(nint)vector)->x = (float)obj3;
		object obj14 = this + 280;
		float num4 = (float)obj10 - vector.x;
		obj14 = num4;
		obj5 = obj3;
		object obj15 = this + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
		object obj16 = obj13 - 0;
		obj6 = obj3;
		object obj17 = this + 288;
		object obj18 = obj10 + obj6;
		obj17 = obj18;
		obj = obj3;
		object obj19 = this + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		object obj20 = obj13 + 0;
	}

	private unsafe void LateUpdate()
	{
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Expected VT, but got Unknown
		//IL_0d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Expected Obj, but got Unknown
		//IL_0d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Expected Obj, but got Unknown
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Expected Obj, but got Unknown
		//IL_002b: Expected I4, but got Obj
		//IL_0038: Expected VT, but got Obj
		//IL_004b: Expected I, but got Obj
		//IL_0061: Expected Obj, but got I
		//IL_0d70: Expected F4, but got Obj
		//IL_0d6b: Expected native int or pointer, but got VT
		//IL_0da9: Expected I, but got Obj
		//IL_0dbf: Expected Obj, but got I
		//IL_008c: Expected I, but got Obj
		//IL_05ab: Expected I, but got Obj
		//IL_05c1: Expected Obj, but got I
		//IL_00d9: Expected I, but got Obj
		//IL_013a: Expected I, but got Obj
		//IL_0150: Expected Obj, but got I
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected Obj, but got Unknown
		//IL_073b: Expected F4, but got Obj
		//IL_0736: Expected native int or pointer, but got VT
		//IL_05ec: Expected I, but got Obj
		//IL_12a9: Expected I, but got Obj
		//IL_12bf: Expected Obj, but got I
		//IL_063a: Expected VT, but got Obj
		//IL_017b: Expected I, but got Obj
		//IL_06fb: Expected Obj, but got VT
		//IL_01dc: Expected I, but got Obj
		//IL_01f2: Expected Obj, but got I
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_08c1: Expected F4, but got Obj
		//IL_08bc: Expected native int or pointer, but got VT
		//IL_0772: Expected I, but got Obj
		//IL_0665: Expected Obj, but got I4
		//IL_06a1: Expected Obj, but got I4
		//IL_12f4: Expected I, but got Obj
		//IL_130a: Expected Obj, but got I
		//IL_07c0: Expected VT, but got Obj
		//IL_021d: Expected I, but got Obj
		//IL_0881: Expected Obj, but got VT
		//IL_026b: Expected VT, but got Obj
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Expected Obj, but got Unknown
		//IL_0a57: Expected F4, but got Obj
		//IL_0a52: Expected native int or pointer, but got VT
		//IL_08f8: Expected I, but got Obj
		//IL_07eb: Expected Obj, but got I4
		//IL_0827: Expected Obj, but got I4
		//IL_0513: Expected I, but got Obj
		//IL_0529: Expected Obj, but got I
		//IL_133f: Expected I, but got Obj
		//IL_1355: Expected Obj, but got I
		//IL_0946: Expected VT, but got Obj
		//IL_0fae: Expected F4, but got Obj
		//IL_0fa9: Expected native int or pointer, but got VT
		//IL_0fd2: Expected F4, but got Obj
		//IL_0fcd: Expected native int or pointer, but got VT
		//IL_1002: Expected Obj, but got F4
		//IL_0296: Expected Obj, but got I4
		//IL_02d2: Expected Obj, but got I4
		//IL_0321: Expected Obj, but got I4
		//IL_035d: Expected Obj, but got I4
		//IL_03ac: Expected Obj, but got I4
		//IL_03f0: Expected Obj, but got I4
		//IL_0447: Expected Obj, but got I4
		//IL_048b: Expected Obj, but got I4
		//IL_0a17: Expected Obj, but got VT
		//IL_0e85: Expected F4, but got Obj
		//IL_0e80: Expected native int or pointer, but got VT
		//IL_0e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e90: Expected Obj, but got Unknown
		//IL_0ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec6: Expected Obj, but got Unknown
		//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Expected Obj, but got Unknown
		//IL_0f12: Expected Obj, but got I
		//IL_0f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f34: Expected Obj, but got Unknown
		//IL_0f51: Expected Obj, but got I
		//IL_0f6e: Expected I, but got Obj
		//IL_0f84: Expected Obj, but got I
		//IL_0554: Expected I, but got Obj
		//IL_0b45: Expected VT, but got Obj
		//IL_0a96: Expected I, but got Obj
		//IL_0971: Expected Obj, but got I4
		//IL_09b5: Expected Obj, but got I4
		//IL_125c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1261: Expected Obj, but got Unknown
		//IL_126a: Invalid comparison between F4 and Obj
		//IL_1283: Expected F4, but got Obj
		//IL_0c2e: Expected Obj, but got VT
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Expected Obj, but got Unknown
		//IL_0aed: Expected F4, but got Obj
		//IL_0ae8: Expected native int or pointer, but got VT
		//IL_115d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1162: Expected Obj, but got Unknown
		//IL_1173: Invalid comparison between F4 and I
		//IL_1194: Expected F4, but got I
		//IL_0c7c: Expected I, but got Obj
		//IL_0b70: Expected Obj, but got I4
		//IL_0bb4: Expected Obj, but got I4
		//IL_137b: Expected Obj, but got I4
		//IL_1391: Expected Obj, but got F4
		//IL_11af: Expected I, but got F4
		//IL_11e3: Expected I4, but got F4
		//IL_11f0: Expected F4, but got Obj
		//IL_11eb: Expected native int or pointer, but got VT
		//IL_1203: Expected Obj, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj + 48);
		UIRoot uIRoot = (UIRoot)(obj + 32);
		Transform transform = (Transform)(obj + 16);
		object obj2 = obj + 8;
		if (mClipping == UIDrawCall.Clipping.None)
		{
			return;
		}
		Camera camera = anchorCamera;
		Transform parentInternal = ((Transform)(object)camera).parentInternal;
		uIRoot.UpdateScale((byte)(int)this != 0);
		transform.localPosition = (Vector3)camera;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v28 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v248 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector2*)(nint)vector)->x = (float)transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector2 = vector;
		AnchorPoint anchorPoint = leftAnchor;
		AnchorPoint anchorPoint2 = bottomAnchor;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v244 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num28;
		float num29;
		float num30;
		float num31;
		if (anchorPoint.target != anchorPoint2.target)
		{
			AnchorPoint anchorPoint3 = leftAnchor;
			AnchorPoint anchorPoint4 = rightAnchor;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S2_v86 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S2_v125 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (anchorPoint3.target != anchorPoint4.target)
			{
				AnchorPoint anchorPoint5 = leftAnchor;
				AnchorPoint anchorPoint6 = topAnchor;
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S2_v92 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S2_v121 (Il2CppClass<UnityEngine.Object>)+74]");
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
						object obj7 = (flag ? 1 : 0) + 16;
						AnchorPoint anchorPoint7 = leftAnchor;
						float num9 = 1f - anchorPoint7.relative;
						float num10 = (float)obj7 * num9;
						object obj8 = (flag ? 1 : 0) + 40;
						float num11 = (float)obj8 * anchorPoint7.relative;
						float num12 = num10 + num11;
						AnchorPoint anchorPoint8 = leftAnchor;
						float num13 = num12 + (float)anchorPoint8.absolute;
						object obj9 = (flag ? 1 : 0) + 16;
						AnchorPoint anchorPoint9 = rightAnchor;
						float num14 = 1f - anchorPoint9.relative;
						float num15 = (float)obj9 * num14;
						object obj10 = (flag ? 1 : 0) + 40;
						float num16 = (float)obj10 * anchorPoint9.relative;
						float num17 = num15 + num16;
						AnchorPoint anchorPoint10 = rightAnchor;
						float num18 = num17 + (float)anchorPoint10.absolute;
						object obj11 = (flag ? 1 : 0) + 52;
						AnchorPoint anchorPoint11 = bottomAnchor;
						float num19 = 1f - anchorPoint11.relative;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v233+4]");
						float num20 = 0f * num19;
						object obj12 = (flag ? 1 : 0) + 28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ S1_v243+4]");
						float num21 = 0f * anchorPoint11.relative;
						float num22 = num20 + num21;
						AnchorPoint anchorPoint12 = bottomAnchor;
						float num23 = num22 + (float)anchorPoint12.absolute;
						object obj13 = (flag ? 1 : 0) + 52;
						AnchorPoint anchorPoint13 = topAnchor;
						float num24 = 1f - anchorPoint13.relative;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S0_v239+4]");
						float num25 = 0f * num24;
						object obj14 = (flag ? 1 : 0) + 28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S1_v253+4]");
						float num26 = 0f * anchorPoint13.relative;
						float num27 = num25 + num26;
						AnchorPoint anchorPoint14 = topAnchor;
						num28 = num27 + (float)anchorPoint14.absolute;
						num29 = num18;
						num30 = num13;
						num31 = num23;
					}
					else
					{
						((UIWidget)(object)uIRoot).OnFill((List<Vector3>)(object)this, (List<Vector2>)(object)leftAnchor, (List<Color>)(object)parentInternal);
						nint num32 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ S0_v194 (Il2CppClass<UnityEngine.Vector2>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num33 = (nint)typeof(Vector2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S0_v216 (Il2CppClass<UnityEngine.Vector2>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector2*)(nint)vector)->x = (float)uIRoot;
						_ = ((UnityEngine.Object)uIRoot).m_CachedPtr;
						Vector3 vector3 = vector;
						((Vector2*)(nint)vector)->x = (float)transform;
						AnchorPoint anchorPoint15 = leftAnchor;
						float num34 = vector.x + (float)anchorPoint15.absolute;
						obj2 = vector.x;
						AnchorPoint anchorPoint16 = bottomAnchor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
						float num35 = 0f + (float)anchorPoint16.absolute;
						obj = obj2;
						AnchorPoint anchorPoint17 = rightAnchor;
						float num36 = (float)obj + (float)anchorPoint17.absolute;
						AnchorPoint anchorPoint18 = topAnchor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						num28 = 0f + (float)anchorPoint18.absolute;
						num29 = num36;
						num30 = num34;
						num31 = num35;
					}
					goto IL_0e78;
				}
			}
		}
		AnchorPoint anchorPoint19 = leftAnchor;
		nint num37 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num38 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v183 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num43;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint19.target))
		{
			bool flag2 = leftAnchor((Vector3)parentInternal);
			if (flag2)
			{
				object obj17 = (flag2 ? 1 : 0) + 16;
				AnchorPoint anchorPoint20 = leftAnchor;
				float num39 = 1f - anchorPoint20.relative;
				float num40 = (float)obj17 * num39;
				object obj18 = (flag2 ? 1 : 0) + 40;
				float num41 = (float)obj18 * anchorPoint20.relative;
				float num42 = num40 + num41;
				AnchorPoint anchorPoint21 = leftAnchor;
				num43 = num42 + (float)anchorPoint21.absolute;
			}
			else
			{
				((UIWidget)vector).OnFill((List<Vector3>)(object)this, (List<Vector2>)(object)leftAnchor, (List<Color>)(object)parentInternal);
				AnchorPoint anchorPoint22 = leftAnchor;
				num43 = vector.x + (float)anchorPoint22.absolute;
			}
		}
		else
		{
			object obj19 = this + 220;
			((Vector2*)(nint)vector)->x = (float)uIRoot;
			float num44 = 0.5f * vector.x;
			num43 = (float)obj19 - num44;
		}
		AnchorPoint anchorPoint23 = rightAnchor;
		nint num45 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S1_v73 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num46 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S1_v159 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num51;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint23.target))
		{
			bool flag3 = rightAnchor((Vector3)parentInternal);
			if (flag3)
			{
				object obj21 = (flag3 ? 1 : 0) + 16;
				AnchorPoint anchorPoint24 = rightAnchor;
				float num47 = 1f - anchorPoint24.relative;
				float num48 = (float)obj21 * num47;
				object obj22 = (flag3 ? 1 : 0) + 40;
				float num49 = (float)obj22 * anchorPoint24.relative;
				float num50 = num48 + num49;
				AnchorPoint anchorPoint25 = rightAnchor;
				num51 = num50 + (float)anchorPoint25.absolute;
			}
			else
			{
				((UIWidget)vector).OnFill((List<Vector3>)(object)this, (List<Vector2>)(object)rightAnchor, (List<Color>)(object)parentInternal);
				AnchorPoint anchorPoint26 = rightAnchor;
				num51 = vector.x + (float)anchorPoint26.absolute;
			}
		}
		else
		{
			object obj23 = this + 220;
			((Vector2*)(nint)vector)->x = (float)uIRoot;
			float num52 = 0.5f * vector.x;
			num51 = (float)obj23 + num52;
		}
		AnchorPoint anchorPoint27 = bottomAnchor;
		nint num53 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S1_v80 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num54 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S1_v135 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num59;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint27.target))
		{
			bool flag4 = bottomAnchor((Vector3)parentInternal);
			if (flag4)
			{
				object obj25 = (flag4 ? 1 : 0) + 52;
				AnchorPoint anchorPoint28 = bottomAnchor;
				float num55 = 1f - anchorPoint28.relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S0_v138+4]");
				float num56 = 0f * num55;
				object obj26 = (flag4 ? 1 : 0) + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ S1_v129+4]");
				float num57 = 0f * anchorPoint28.relative;
				float num58 = num56 + num57;
				AnchorPoint anchorPoint29 = bottomAnchor;
				num59 = num58 + (float)anchorPoint29.absolute;
			}
			else
			{
				((UIWidget)vector).OnFill((List<Vector3>)(object)this, (List<Vector2>)(object)bottomAnchor, (List<Color>)(object)parentInternal);
				AnchorPoint anchorPoint30 = bottomAnchor;
				num59 = vector.y + (float)anchorPoint30.absolute;
			}
		}
		else
		{
			object obj27 = this + 220;
			((Vector2*)(nint)vector)->x = (float)uIRoot;
			float num60 = 0.5f * vector.y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S0_v126+4]");
			num59 = 0f - num60;
		}
		AnchorPoint anchorPoint31 = topAnchor;
		nint num61 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ S1_v87 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num62 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ S1_v111 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint31.target))
		{
			object obj29 = this + 220;
			((Vector2*)(nint)vector)->x = (float)uIRoot;
			float num63 = 0.5f * vector.y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ S0_v122+4]");
			num28 = 0f + num63;
			num29 = num51;
			num30 = num43;
			num31 = num59;
		}
		else
		{
			bool flag5 = topAnchor((Vector3)parentInternal);
			if (flag5)
			{
				object obj30 = (flag5 ? 1 : 0) + 52;
				AnchorPoint anchorPoint32 = topAnchor;
				float num64 = 1f - anchorPoint32.relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ S0_v116+4]");
				float num65 = 0f * num64;
				object obj31 = (flag5 ? 1 : 0) + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ S1_v101+4]");
				float num66 = 0f * anchorPoint32.relative;
				float num67 = num65 + num66;
				AnchorPoint anchorPoint33 = topAnchor;
				num28 = num67 + (float)anchorPoint33.absolute;
				num29 = num51;
				num30 = num43;
				num31 = num59;
			}
			else
			{
				((UIWidget)vector).OnFill((List<Vector3>)(object)this, (List<Vector2>)(object)topAnchor, (List<Color>)(object)parentInternal);
				AnchorPoint anchorPoint34 = topAnchor;
				num28 = vector.y + (float)anchorPoint34.absolute;
				num29 = num51;
				num30 = num43;
				num31 = num59;
			}
		}
		goto IL_0e78;
		IL_0e78:
		((Vector2*)(nint)vector)->x = (float)obj2;
		object obj32 = this + 260;
		float num68 = vector.x + (float)obj32;
		float num69 = num30 - num68;
		uIRoot = (UIRoot)obj2;
		object obj33 = this + 260;
		object obj34 = (object)uIRoot + obj33;
		float num70 = num29 - (float)obj34;
		transform = (Transform)obj2;
		object obj35 = this + 260;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Transform)+4]");
		nint num71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S3_v10+4]");
		object obj36 = num71 + 0;
		float num72 = num31 - (float)obj36;
		obj2 = obj2;
		object obj37 = this + 260;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
		nint num73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ S2_v21+4]");
		object obj38 = num73 + 0;
		float num74 = num28 - (float)obj38;
		nint num75 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S0_v54 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj39 = (nint)0 & (nint)0x200;
		if (obj39 != null)
		{
			nint num76 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ S0_v83 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num77 = Mathf.LerpUnclamped(num69, num70, 0.5f);
		float num78 = Mathf.LerpUnclamped(num72, num74, 0.5f);
		float num79 = num70 - num69;
		float num80 = num74 - num72;
		object obj40 = this + 236;
		bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2f) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40);
		bool flag7 = !flag6;
		float num81 = (float)obj40;
		if (!flag7)
		{
			num81 = 2f;
		}
		object obj41 = this + 236;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ S1_v43+4]");
		bool flag8 = 2f > 0f;
		bool flag9 = !flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ S1_v43+4]");
		float num82 = 0f;
		if (!flag9)
		{
			num82 = 2f;
		}
		uIRoot = (UIRoot)0;
		((UnityEngine.Object)uIRoot).m_CachedPtr = (IntPtr)0;
		uIRoot = (UIRoot)num77;
		float num83 = ((!(num79 < num81)) ? num79 : num81);
		((UnityEngine.Object)uIRoot).m_CachedPtr = (IntPtr)num83;
		float num84 = ((!(num80 < num82)) ? num80 : num82);
		uIRoot.scalingStyle = (UIRoot.Scaling)num84;
		((Vector2*)(nint)vector)->x = (float)uIRoot;
		_ = ((UnityEngine.Object)uIRoot).m_CachedPtr;
		Vector4 vector4 = ((UIPanel)vector).finalClipRegion;
	}

	private void UpdateSelf()
	{
		//IL_047b: Expected I, but got Obj
		//IL_0491: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_0512: Expected I, but got Obj
		//IL_0528: Expected Obj, but got I
		//IL_00aa: Expected I, but got Obj
		//IL_018c: Expected I, but got Obj
		//IL_011b: Expected I, but got Obj
		//IL_01d9: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I
		//IL_0449: Expected Obj, but got I4
		//IL_021a: Expected I, but got Obj
		//IL_027a: Expected Obj, but got I4
		//IL_0395: Expected I, but got Obj
		//IL_03ab: Expected Obj, but got I
		//IL_02de: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_03d6: Expected I, but got Obj
		//IL_031f: Expected I, but got Obj
		nint num = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIPanel>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v151 (Il2CppClass<UIPanel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int renderedFrameCount = Time.renderedFrameCount;
		if (mUpdateFrame == renderedFrameCount)
		{
			return;
		}
		int renderedFrameCount2 = Time.renderedFrameCount;
		nint num3 = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v18 (Il2CppClass<UIPanel>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v145 (Il2CppClass<UIPanel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mUpdateFrame = renderedFrameCount2;
		List<UIPanel> list = UIPanel.list;
		int num5 = 0;
		bool flag;
		while (true)
		{
			nint num6 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v34 (Il2CppClass<UIPanel>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			flag = obj3 == null;
			if (num5 >= list._size)
			{
				break;
			}
			if (!flag)
			{
				nint num7 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v139 (Il2CppClass<UIPanel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIPanel uIPanel = UIPanel.list.get_Item(num5);
			uIPanel.SortWidgets();
			int num8 = num5 + 1;
			num5 = num8;
		}
		if (!flag)
		{
			nint num9 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v124 (Il2CppClass<UIPanel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<UIPanel> list2 = UIPanel.list;
		int num10 = 0;
		int num11 = 3000;
		int num21;
		for (; num10 < list2._size; num21 = num10 + 1, num10 = num21)
		{
			nint num12 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v55 (Il2CppClass<UIPanel>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num13 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v118 (Il2CppClass<UIPanel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIPanel uIPanel2 = UIPanel.list.get_Item(num10);
			int num17;
			if (uIPanel2.renderQueue != RenderQueue.Automatic)
			{
				bool flag2 = uIPanel2.renderQueue == RenderQueue.StartAt;
				uIPanel2.AddWidget((UIWidget)num10);
				List<UIDrawCall> list3 = uIPanel2.drawCalls;
				bool flag3 = list3._size == 0;
				if (flag2)
				{
					if (flag3)
					{
						continue;
					}
					List<UIDrawCall> list4 = uIPanel2.drawCalls;
					nint num14 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v105 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num15 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v114 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num16 = list4._size + uIPanel2.startingRenderQueue;
					num17 = ((num11 <= num16) ? num16 : num11);
				}
				else
				{
					if (flag3)
					{
						continue;
					}
					nint num18 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v84 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num19 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v92 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num20 = uIPanel2.startingRenderQueue + 1;
					num17 = ((num11 <= num20) ? num20 : num11);
				}
			}
			else
			{
				uIPanel2.startingRenderQueue = num11;
				uIPanel2.AddWidget((UIWidget)num10);
				List<UIDrawCall> list5 = uIPanel2.drawCalls;
				num17 = list5._size + num11;
			}
			num11 = num17;
		}
	}

	public unsafe void SortWidgets()
	{
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected I4, but got Unknown
		//IL_016a: Expected I, but got Obj
		//IL_0180: Expected Obj, but got I
		//IL_01ab: Expected I, but got Obj
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_0271: Expected VT, but got Obj
		//IL_00ed: Expected I, but got Obj
		Camera camera = anchorCamera;
		IEnumerator enumerator = ((Transform)(object)camera).GetEnumerator();
		bool flag = (byte)(enumerator & 1) != 0;
		mHasMoved = flag;
		OnAnchor();
		UpdateWidgets();
		Refresh();
		if (~(mRebuild ? 1u : 0u) == 0)
		{
			mRebuild = false;
			UpdateLayers();
		}
		else
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
				if (~(uIDrawCall.isDirty ? 1u : 0u) == 0)
				{
					UIDrawCall uIDrawCall2 = FindDrawCall((UIWidget)(object)uIDrawCall);
					if ((object)uIDrawCall2 == null)
					{
						nint num2 = (nint)typeof(UIDrawCall);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v53 (Il2CppClass<UIDrawCall>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num3 = (nint)typeof(UIDrawCall);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v60 (Il2CppClass<UIDrawCall>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UIDrawCall.MoveToScene((Scene)uIDrawCall);
						drawCalls.RemoveAt(num);
						continue;
					}
				}
				int num4 = num + 1;
				num = num4;
			}
		}
		if (~(mUpdateScroll ? 1u : 0u) == 0)
		{
			mUpdateScroll = false;
			UIScrollView component = GetComponent<UIScrollView>();
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				component.InvalidateBounds();
			}
		}
		if (~(mHasMoved ? 1u : 0u) == 0)
		{
			mHasMoved = false;
			mTrans.get_position_Injected(out *(Vector3*)null);
		}
	}

	private unsafe void FillAllDrawCalls()
	{
		//IL_002d: Expected Obj, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I4
		//IL_0059: Expected native int or pointer, but got Obj
		mSortWidgets = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Queue<_00210> queue = default;
		queue._array = (_00210[])num;
		queue._size = 0;
		object obj = queue + 16;
		obj = 0;
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)widgets, new Queue<T>.Enumerator((Queue<T>)(object)queue));
	}

	public bool FillDrawCall(UIDrawCall dc)
	{
		//IL_027d: Expected I, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02c2: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_01a6: Expected I, but got Obj
		//IL_01bc: Expected Obj, but got I
		//IL_014b: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I
		//IL_01e7: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v60 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (dc != null)
		{
			return false;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dc @ L1 (UIDrawCall)+90]");
		if ((UnityEngine.Object)0 != null)
		{
			return false;
		}
		do
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v50 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mParentPanel).FindKernel((string)null) == 0)
			{
				return false;
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIPanel uIPanel = mParentPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dc @ L1 (UIDrawCall)+90]");
			if (uIPanel != (UnityEngine.Object)0)
			{
				return true;
			}
		}
		while (mParentPanel.clipsChildren);
		return false;
	}

	private void UpdateDrawCalls(int sortOrder)
	{
		mAlphaFrameID = -1;
		UpdateAnchorsInternal(sortOrder);
	}

	private void UpdateLayers()
	{
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_094e: Expected VT, but got Obj
		//IL_0067: Expected I, but got Obj
		int num = 0;
		while (true)
		{
			List<UIDrawCall> list = drawCalls;
			if (num >= list._size)
			{
				break;
			}
			UIDrawCall uIDrawCall = drawCalls.get_Item(num);
			nint num2 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v100 (Il2CppClass<UIDrawCall>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v106 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIDrawCall.MoveToScene((Scene)uIDrawCall);
			int num4 = num + 1;
			num = num4;
		}
		throw new IndexOutOfRangeException();
	}

	private void UpdateWidgets()
	{
		//IL_0057: Expected I, but got Obj
		//IL_006d: Expected Obj, but got I
		//IL_0098: Expected I, but got Obj
		//IL_00f2: Expected I, but got Obj
		//IL_0108: Expected Obj, but got I
		//IL_0133: Expected I, but got Obj
		Transform transform = cachedTransform;
		bool activeSelf = ((GameObject)(object)transform).activeSelf;
		if (mLayer == (activeSelf ? 1 : 0))
		{
			return;
		}
		bool activeSelf2 = mGo.activeSelf;
		mLayer = (activeSelf2 ? 1 : 0);
		List<UIWidget> list = widgets;
		int num = 0;
		while (num < list._size)
		{
			UIWidget uIWidget = widgets.get_Item(num);
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v50 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)uIWidget))
			{
				UIRoot uIRoot = uIWidget.root;
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (uIRoot != this)
				{
					string text = uIWidget.tag;
					((GameObject)(object)text).SetActive((byte)mLayer != 0);
				}
			}
			int num6 = num + 1;
			num = num6;
		}
		ResetAndUpdateAnchors();
		int num7 = 0;
		while (true)
		{
			List<UIDrawCall> list2 = drawCalls;
			if (num7 < list2._size)
			{
				UIDrawCall uIDrawCall = drawCalls.get_Item(num7);
				string text2 = uIDrawCall.tag;
				((GameObject)(object)text2).SetActive((byte)mLayer != 0);
				int num8 = num7 + 1;
				num7 = num8;
				continue;
			}
			break;
		}
	}

	public UIDrawCall FindDrawCall(UIWidget w)
	{
		//IL_03ee: Expected I, but got Obj
		//IL_0404: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03be: Expected Obj, but got I4
		//IL_03c7: Expected Obj, but got I4
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		//IL_016e: Expected I, but got Obj
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04bc: Expected Obj, but got I4
		//IL_02ab: Expected VT, but got I4
		//IL_0231: Expected Obj, but got I4
		//IL_023e: Expected VT, but got I4
		//IL_0525: Expected VT, but got I4
		//IL_0525: Expected I4, but got Obj
		//IL_052f: Expected VT, but got I4
		//IL_029d: Expected VT, but got Obj
		//IL_0272: Expected VT, but got I4
		//IL_04f1: Expected I4, but got Obj
		//IL_0264: Expected VT, but got Obj
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v96 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)w).FindKernel((string)null) != 0)
		{
			w.onPostFill = null;
			bool flag = false;
			int num3 = default;
			object obj6 = default;
			int num8 = default;
			while (true)
			{
				List<UIWidget> list = widgets;
				if (num3 >= list._size)
				{
					break;
				}
				UIWidget uIWidget = widgets.get_Item(num3);
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v92 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (uIWidget != null)
				{
					widgets.RemoveAt(num3);
					continue;
				}
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v86 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (uIWidget.drawCall != w)
				{
					if (uIWidget.hasVertices && uIWidget.rawPivot != UIWidget.Pivot.TopLeft)
					{
						bool flag2 = (byte)((flag ? 1u : 0u) + 1u) != 0;
						if (~(generateNormals ? 1u : 0u) == 0)
						{
							UIGeometry highlight = (UIGeometry)((UIRect)w).mChanged;
							Color caretColor = (Color)((UIRect)w).mUpdateFrame;
							((UILabel)uIWidget).PrintOverlay(highlightColor: (~(generateUV2 ? 1u : 0u) != 0) ? ((Color)0) : ((Color)((UIRect)w).mRoot), start: (int)((UIRect)w).mChildren, end: ((UIRect)w).mAnchorsCached ? 1 : 0, caret: (UIGeometry)(object)((UIRect)w).mParent, highlight: highlight, caretColor: caretColor);
						}
						else
						{
							((UILabel)uIWidget).PrintOverlay(highlightColor: (~(generateUV2 ? 1u : 0u) != 0) ? ((Color)0) : ((Color)((UIRect)w).mRoot), start: (int)((UIRect)w).mChildren, end: ((UIRect)w).mAnchorsCached ? 1 : 0, caret: (UIGeometry)(object)((UIRect)w).mParent, highlight: (UIGeometry)null, caretColor: (Color)0);
							Color caretColor = (Color)0;
							UIGeometry highlight = null;
						}
						bool flag3 = uIWidget.mOnRender == null;
						flag = flag2;
						if (!flag3)
						{
							if (mOnRender != null)
							{
								object obj4 = this + 308;
								Delegate obj5 = ((Delegate)mOnRender).CombineImpl((Delegate)uIWidget.mOnRender);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
								obj4 = obj6;
							}
							else
							{
								object obj7 = this + 308;
								obj7 = uIWidget.mOnRender;
							}
							flag = flag2;
						}
					}
					else
					{
						object obj8 = uIWidget + 248;
						obj8 = 0;
					}
				}
				num3 = num8 + 1;
			}
			BetterList<UIRect> betterList = ((UIRect)w).mChildren;
			if (betterList.size != 0)
			{
				((UIEventListener)(object)w).OnHover(flag);
				object obj9 = w + 124;
				obj9 = mOnRender;
				object obj10 = this + 308;
				obj10 = 0;
				return (UIDrawCall)1;
			}
			return null;
		}
		return null;
	}

	public void AddWidget(UIWidget w)
	{
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		//IL_04fa: Expected Obj, but got I4
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got Unknown
		//IL_0517: Expected Obj, but got I4
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_0534: Expected Obj, but got I4
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got F4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got F4
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected Obj, but got Unknown
		//IL_059b: Invalid comparison between I and F4
		//IL_00e0: Expected I, but got Obj
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected Obj, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Obj, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected Obj, but got Unknown
		//IL_0637: Invalid comparison between I and F4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_02e0: Expected VT, but got Obj
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0750: Expected VT, but got Obj
		//IL_076f: Expected I4, but got Obj
		//IL_019c: Expected VT, but got Obj
		//IL_01c1: Expected I, but got Obj
		//IL_01d7: Expected Obj, but got I
		//IL_06a0: Expected I4, but got Obj
		//IL_06ae: Expected I, but got Obj
		//IL_06c4: Expected Obj, but got I
		//IL_0202: Expected I, but got Obj
		//IL_0725: Expected VT, but got Obj
		//IL_0725: Expected VT, but got Obj
		//IL_026b: Expected VT, but got Obj
		//IL_0294: Expected I, but got Obj
		//IL_049e: Expected Obj, but got I4
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected Obj, but got Unknown
		object obj = default;
		Transform transform = (Transform)(obj + 96);
		MessageEventArgs e = (MessageEventArgs)(obj + 80);
		object obj2 = obj - -64;
		obj2 = 0;
		_ = 0;
		object obj3 = obj + 48;
		obj3 = 0;
		_ = 0;
		object obj4 = obj + 36;
		obj4 = 0;
		_ = 0;
		Camera camera = anchorCamera;
		UIDrawCall.Clipping clipping = this.clipping;
		if (mClipping != UIDrawCall.Clipping.None)
		{
			Vector2 vector = clipSoftness;
			transform = (Transform)(object)e;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)e.playerId;
			object obj5 = this + 180;
			obj5 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj6 = this + 188;
			float num = (float)obj6 * 0.5f;
			obj6 = num;
			object obj7 = this + 192;
			float num2 = (float)obj7 * 0.5f;
			obj7 = num2;
		}
		else
		{
			nint num3 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v144 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v154 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			e._002Ector();
			transform = (Transform)(object)e;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)e.playerId;
			object obj9 = this + 180;
			obj9 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
		}
		int num5 = Screen.height;
		int sleepTimeout = Screen.sleepTimeout;
		object obj10 = this + 180;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v33+8]");
		if (0f == 0f)
		{
			object obj11 = this + 180;
			float num6 = (float)num5 * 0.5f;
		}
		object obj12 = obj + 24;
		UIPanel uIPanel = (UIPanel)(obj + 12);
		object obj13 = this + 180;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v42+C]");
		if (0f == 0f)
		{
			object obj14 = this + 180;
			float num7 = (float)sleepTimeout * 0.5f;
		}
		if (clipping != UIDrawCall.Clipping.None)
		{
			Camera camera2 = anchorCamera;
			Transform parentInternal = ((Transform)(object)camera2).parentInternal;
			Camera camera3 = anchorCamera;
			transform.localPosition = (Vector3)camera3;
			obj2 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v104 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v135 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)parentInternal).FindKernel((string)null) != 0)
			{
				transform = (Transform)obj2;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				Vector3 vector2 = parentInternal.InverseTransformPoint((Vector3)transform);
				obj2 = e;
				_ = e.playerId;
			}
			obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			uIPanel.clipping = (UIDrawCall.Clipping)this;
			nint num10 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v115 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num11 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v126 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			e = (MessageEventArgs)obj12;
			MessageEventArgs e2 = e;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v38+8]");
			e2.playerId = 0;
			transform = (Transform)(object)uIPanel;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)uIPanel).m_CachedPtr;
			Vector3 vector3 = (Vector3)e - (Vector3)transform;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
		else
		{
			transform.position = (Vector3)camera;
			obj2 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
		}
		transform.rotation = (Quaternion)camera;
		obj3 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		((Transform)(object)e).hasChanged = (byte)(int)camera != 0;
		obj4 = e;
		_ = e.playerId;
		int num12 = 0;
		while (true)
		{
			List<UIDrawCall> list = drawCalls;
			if (num12 >= list._size)
			{
				break;
			}
			UIDrawCall uIDrawCall = drawCalls.get_Item(num12);
			Material baseMaterial = uIDrawCall.baseMaterial;
			transform = (Transform)obj2;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = transform.localPosition;
			transform = (Transform)obj3;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Quaternion localRotation = transform.localRotation;
			transform = (Transform)obj4;
			Transform transform5 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			((Transform)(object)baseMaterial).parent = transform;
			bool flag = renderQueue != RenderQueue.Explicit;
			bool flag2 = !flag;
			int num13 = startingRenderQueue;
			if (!flag2)
			{
				int num14 = num12 + startingRenderQueue;
				num13 = num14;
			}
			uIDrawCall.sortingOrder = num13;
			bool flag3 = ~(alwaysOnScreen ? 1u : 0u) == 0 && (mClipping == UIDrawCall.Clipping.None || mClipping == UIDrawCall.Clipping.ConstrainButDontClip);
			bool flag4 = flag3;
			uIDrawCall.alwaysOnScreen = flag4;
			string text;
			if (~(useSortingOrder ? 1u : 0u) == 0)
			{
				if (mSortingOrder == 0)
				{
					bool flag5 = renderQueue == RenderQueue.Automatic;
					text = (string)(object)w;
					if (flag5)
					{
						goto IL_07ba;
					}
				}
				text = (string)mSortingOrder;
			}
			else
			{
				text = null;
			}
			goto IL_07ba;
			IL_07ba:
			uIDrawCall.sortingLayerName = text;
			Material baseMaterial2 = (Material)(object)((~(useSortingOrder ? 1u : 0u) != 0) ? null : mSortingLayerName);
			uIDrawCall.baseMaterial = baseMaterial2;
			object obj17 = uIDrawCall + 32;
			obj17 = mClipTexture;
			uIDrawCall.UpdateGeometry((int)shadowMode);
			int num15 = num12 + 1;
			num12 = num15;
		}
	}

	public void RemoveWidget(UIWidget w)
	{
		//IL_0199: Expected I4, but got Obj
		//IL_005e: Expected I4, but got Obj
		//IL_00f0: Expected I4, but got Obj
		mUpdateScroll = true;
		List<UIWidget> list = widgets;
		if (list._size != 0)
		{
			if (~(mSortWidgets ? 1u : 0u) == 0)
			{
				widgets.Add(w);
				FillAllDrawCalls();
			}
			else
			{
				UIWidget uIWidget = widgets.get_Item(0);
				bool flag = w.UpdateTransform((int)uIWidget);
				bool flag2 = (flag ? 1 : 0) == -1;
				List<UIWidget> list2 = widgets;
				if (flag2)
				{
					list2.Insert(0, w);
				}
				else
				{
					int num = list2._size;
					while (num >= 1)
					{
						int num2 = num - 1;
						UIWidget uIWidget2 = widgets.get_Item(num2);
						bool flag3 = w.UpdateTransform((int)uIWidget2);
						bool flag4 = (flag3 ? 1 : 0) == -1;
						num = num2;
						if (!flag4)
						{
							int index = num2 + 1;
							widgets.Insert(index, w);
							break;
						}
					}
				}
			}
		}
		else
		{
			widgets.Add(w);
		}
		UIPanel uIPanel = Find((Transform)(object)this, (byte)(int)w != 0);
	}

	public void Refresh()
	{
		//IL_0043: Expected Obj, but got I4
		//IL_07f3: Expected I, but got Obj
		//IL_0809: Expected Obj, but got I
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_0207: Expected Obj, but got I4
		//IL_0056: Expected I, but got Obj
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_07b1: Expected Obj, but got I4
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected Obj, but got Unknown
		//IL_066b: Expected I, but got Obj
		//IL_0681: Expected Obj, but got I
		//IL_07c8: Expected Obj, but got I
		//IL_00e4: Expected I, but got Obj
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_0131: Expected I, but got Obj
		//IL_0274: Expected I, but got Obj
		//IL_028a: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I4
		//IL_02b5: Expected I, but got Obj
		//IL_01a5: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I4
		//IL_0738: Expected Obj, but got I4
		//IL_0478: Expected Obj, but got I4
		//IL_074b: Expected Obj, but got I4
		//IL_04cb: Expected I, but got Obj
		//IL_04e1: Expected Obj, but got I
		//IL_0575: Expected I4, but got Obj
		//IL_050c: Expected I, but got Obj
		bool flag = clipsChildren;
		bool flag2;
		bool flag3;
		if (~(cullWhileDragging ? 1u : 0u) == 0)
		{
			if (~(mForced ? 1u : 0u) == 0)
			{
				flag2 = false;
				goto IL_0231;
			}
			flag3 = false;
		}
		else
		{
			object obj = 0;
			object obj3 = default;
			object obj11 = default;
			while (true)
			{
				nint num = (nint)typeof(UIScrollView);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v92 (Il2CppClass<UIScrollView>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(UIScrollView);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v135 (Il2CppClass<UIScrollView>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BetterList<UIScrollView> betterList = UIScrollView.list;
				if ((nint)obj3 >= betterList.size)
				{
					break;
				}
				nint num3 = (nint)typeof(UIScrollView);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v104 (Il2CppClass<UIScrollView>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(UIScrollView);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v129 (Il2CppClass<UIScrollView>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BetterList<UIScrollView> betterList2 = UIScrollView.list;
				object obj5 = betterList2.buffer + 16;
				object obj6 = obj3 << 2;
				object obj7 = obj5 + obj6;
				object obj8 = obj7;
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v70 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v76 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v116+68]");
				if ((UnityEngine.Object)0 != this)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v116+88]");
					object obj10;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v116+C4]");
						obj10 = 0;
					}
					else
					{
						obj10 = 0;
					}
					if (obj10 != null)
					{
						obj = 1;
					}
				}
				obj3 = obj11 + 1;
			}
			object obj12 = obj & 1;
			flag3 = obj12 != null;
			bool flag4 = mForced;
			object obj13 = flag3 ^ flag4;
			if (obj13 != null)
			{
				flag2 = flag3;
				goto IL_0231;
			}
		}
		goto IL_078c;
		IL_0231:
		mForced = flag2;
		mResized = true;
		flag3 = flag2;
		goto IL_078c;
		IL_078c:
		int renderedFrameCount = Time.renderedFrameCount;
		List<UIWidget> list = widgets;
		int num7 = 0;
		object obj14 = 0;
		int num13;
		for (; num7 < list._size; num13 = num7 + 1, num7 = num13)
		{
			UIWidget uIWidget = widgets.get_Item(num7);
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(uIWidget.panel != this) || !uIWidget.isActiveAndEnabled)
			{
				continue;
			}
			if (!uIWidget.UpdateGeometry(renderedFrameCount) && !mResized && (~(mHasMoved ? 1u : 0u) != 0 || ~(alwaysOnScreen ? 1u : 0u) == 0))
			{
				goto IL_046b;
			}
			bool flag5;
			bool flag6;
			if (flag3)
			{
				flag5 = true;
				flag6 = true;
			}
			else
			{
				float num10 = ((UIPanel)(object)uIWidget).CalculateFinalAlpha(renderedFrameCount);
				bool flag7 = num10 > 0.001f;
				if (~(alwaysOnScreen ? 1u : 0u) == 0)
				{
					flag5 = flag7;
					flag6 = true;
				}
				else
				{
					if (!flag)
					{
						bool flag8 = (byte)(~(uIWidget.hideIfOffScreen ? 1u : 0u)) != 0;
						flag5 = flag7;
						flag6 = true;
						if (flag8)
						{
							goto IL_0715;
						}
					}
					flag6 = Affects(uIWidget);
					flag5 = flag7;
				}
			}
			goto IL_0715;
			IL_046b:
			UISpriteData sprite = ((UIAtlas)(object)uIWidget).GetSprite((string)renderedFrameCount);
			if (sprite == null)
			{
				continue;
			}
			if (~(mRebuild ? 1u : 0u) != 0)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)uIWidget.drawCall).FindKernel((string)null) != 0)
				{
					UIDrawCall drawCall = uIWidget.drawCall;
					drawCall.isDirty = true;
				}
				else
				{
					UIPanel uIPanel = Find((Transform)(object)this, (byte)(int)uIWidget != 0);
				}
			}
			obj14 = 1;
			continue;
			IL_0715:
			bool createIfMissing = flag6;
			BMSymbol symbol = ((UIFont)(object)uIWidget).GetSymbol((string)flag5, createIfMissing);
			goto IL_046b;
		}
		if (obj14 != null && onGeometryUpdated != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		mResized = false;
	}

	public unsafe virtual Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
	{
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_015f: Expected Obj, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_017d: Expected I4, but got Obj
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_01f8: Expected F4, but got Obj
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_022e: Expected F4, but got I
		//IL_022e: Expected F4, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0278: Expected F4, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0291: Invalid comparison between VT and I
		//IL_0124: Expected native int or pointer, but got VT
		//IL_0131: Expected native int or pointer, but got VT
		//IL_013e: Expected native int or pointer, but got VT
		//IL_00b0: Expected Obj, but got F4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00d5: Expected Obj, but got F4
		//IL_0103: Expected VT, but got Obj
		//IL_0103: Expected I4, but got VT
		//IL_0103: Expected Obj, but got VT
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 + 44;
		obj = 0;
		_ = 0;
		UIWidget uIWidget = (UIWidget)(obj2 + 32);
		uIWidget.width = (int)this;
		object obj3 = obj2 + 16;
		obj3 = uIWidget;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v53 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float b = 0f - (float)renderQueue;
		float num3 = Mathf.LerpUnclamped(0f, b, (float)obj3);
		object obj5 = obj2 + 8;
		obj5 = uIWidget;
		int num4 = startingRenderQueue;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S2_v5+4]");
		float num5 = Mathf.LerpUnclamped(num4, 0f, 0f);
		object obj6 = this + 472;
		obj2 = uIWidget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S2_v8+4]");
		float a = 0f - (float)startingRenderQueue;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		float num6 = Mathf.LerpUnclamped(a, 0f, 0f);
		float num7 = num5 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		Vector2 vector2 = default;
		float num9 = default;
		float num11 = default;
		Vector2 vector3 = default;
		while (true)
		{
			Vector2 vector = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [min @ L2 (UnityEngine.Vector2)+C]");
			if (vector >= (object)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16+8]");
			_ = 0;
			float num8 = (float)obj + num9;
			obj = num8;
			object obj7 = obj + 4;
			float num10 = (float)obj7 + num11;
			obj7 = num10;
			uIWidget = (UIWidget)obj;
			UIWidget uIWidget2 = uIWidget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)uIWidget2).m_CachedPtr = (IntPtr)0;
			((List<Vector3>)min).set_Item((int)vector2, (Vector3)uIWidget);
			vector2 = vector3 + 1;
		}
		Vector3 vector4 = default;
		((Vector3*)(nint)vector4)->x = 0f;
		((Vector3*)(nint)vector4)->x = num9;
		((Vector3*)(nint)vector4)->y = num11;
		return vector4;
	}

	public unsafe bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
	{
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_00c1: Expected I4, but got Obj
		//IL_00d5: Expected I, but got Obj
		//IL_00eb: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		((UILabel)this)._002Ector();
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v18 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUIText.rectHeight = (immediate ? 1 : 0);
		NGUIText.regionHeight = (immediate ? 1 : 0);
		bool result = (byte)(int)NGUITools.AddChild((GameObject)(object)target, (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref targetBounds) != 0, 0) != 0;
		NGUIText.bitmapFont = null;
		nint num3 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11 (Il2CppClass<NGUIText>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = 0;
		return result;
	}

	public unsafe bool ConstrainTargetToBounds(Transform target, bool immediate)
	{
		return ConstrainTargetToBounds(target, ref *(immediate ? ((Bounds*)1) : ((Bounds*)null)), immediate: true);
	}

	public static UIPanel Find(Transform trans)
	{
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected Obj, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected Obj, but got Unknown
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected Obj, but got Unknown
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected Obj, but got Unknown
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected Obj, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected Obj, but got Unknown
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected Obj, but got Unknown
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected Obj, but got Unknown
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected Obj, but got Unknown
		//IL_07cc: Expected Obj, but got I4
		//IL_025c: Expected I, but got Obj
		//IL_0272: Expected Obj, but got I
		//IL_089d: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0136: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_0384: Expected I4, but got Obj
		//IL_0400: Expected I, but got Obj
		//IL_0416: Expected Obj, but got I
		//IL_029d: Expected I, but got Obj
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected Obj, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected Obj, but got Unknown
		//IL_08f2: Expected Obj, but got I4
		//IL_0900: Expected Obj, but got F4
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Expected Obj, but got Unknown
		//IL_0952: Expected Obj, but got I4
		//IL_0960: Expected Obj, but got F4
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected Obj, but got Unknown
		//IL_09b2: Expected Obj, but got I4
		//IL_09c0: Expected Obj, but got F4
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Expected Obj, but got Unknown
		//IL_0a12: Expected Obj, but got I4
		//IL_0a20: Expected Obj, but got F4
		//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a57: Expected Obj, but got Unknown
		//IL_02f7: Expected I, but got Obj
		//IL_030d: Expected Obj, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0177: Expected I, but got Obj
		//IL_0b04: Expected I, but got Obj
		//IL_0b1a: Expected Obj, but got I
		//IL_0441: Expected I, but got Obj
		//IL_08d3: Expected Obj, but got I
		//IL_048e: Expected I, but got Obj
		//IL_04a4: Expected Obj, but got I
		//IL_0338: Expected I, but got Obj
		//IL_06f8: Expected I, but got Obj
		//IL_0aa0: Expected Obj, but got I
		//IL_05ea: Expected VT, but got Obj
		//IL_04cf: Expected I, but got Obj
		//IL_060a: Expected Obj, but got I4
		//IL_051f: Expected Obj, but got I
		//IL_0550: Expected I, but got Obj
		//IL_0566: Expected Obj, but got I
		//IL_061d: Expected I, but got Obj
		//IL_0633: Expected Obj, but got I
		//IL_0591: Expected I, but got Obj
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Expected Obj, but got Unknown
		//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Expected Obj, but got Unknown
		//IL_0b99: Expected I, but got Obj
		//IL_0baf: Expected Obj, but got I
		//IL_0c3e: Expected VT, but got Obj
		//IL_0c3e: Expected VT, but got Obj
		//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c65: Expected Obj, but got Unknown
		//IL_065e: Expected I, but got Obj
		//IL_06ab: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 128);
		UIRoot uIRoot = (UIRoot)(obj + 56);
		object obj2 = obj + 40;
		object obj3 = obj + 24;
		object obj4 = obj + 8;
		object obj5 = obj + 104;
		object obj6 = obj + 92;
		object obj7 = obj + 80;
		object obj8 = obj + 68;
		object obj9 = obj + 116;
		obj9 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L0 (UnityEngine.Transform)+D8]");
		if ((nint)0 != 0)
		{
			object obj10 = trans + 260;
			object obj11 = trans + 220;
			object obj12 = obj10 + obj11;
			object obj13 = trans + 220;
			float num = 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S2_v76+8]");
			float num2 = num * 0f;
			float num3 = (float)obj12 - num2;
			object obj14 = trans + 220;
			float num4 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v153+8]");
			float num5 = num4 + 0f;
			object obj15 = trans + 260;
			object obj16 = trans + 220;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v161+4]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v157+4]");
			object obj17 = num6 + 0;
			object obj18 = trans + 220;
			float num7 = 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S2_v81+C]");
			float num8 = num7 * 0f;
			float num9 = (float)obj17 - num8;
			object obj19 = trans + 220;
			float num10 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v162+C]");
			float num11 = num10 + 0f;
			Camera camera = ((UIRect)(object)trans).anchorCamera;
			nint num12 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v169 (Il2CppClass<UIPanel>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num13 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v196 (Il2CppClass<UIPanel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			transform = (Transform)(object)uIRoot;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)uIRoot).m_CachedPtr;
			object obj21 = mCorners + 16;
			obj21 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			transform = (Transform)obj2;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			object obj22 = mCorners + 28;
			obj22 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			transform = (Transform)obj3;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			object obj23 = mCorners + 40;
			obj23 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB82");
			transform = (Transform)obj4;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			object obj24 = mCorners + 52;
			obj24 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
		}
		else
		{
			bool flag = ((UIRect)(object)trans).isFullyAnchored;
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num15 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v142 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag).FindKernel(null) != 0)
			{
				float waitTime = ((UIWidget)(object)trans).alpha;
				nint num16 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S2_v65 (Il2CppClass<NGUITools>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num17 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S2_v70 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L0 (UnityEngine.Transform)+44]");
				return (UIPanel)((UISlideIn)0).InvokeDidShowCallback(waitTime);
			}
			uIRoot.UpdateScale((byte)(int)trans != 0);
			obj2 = uIRoot;
			float num18 = -0.5f * (float)obj2;
			obj3 = uIRoot;
			float num19 = -0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
			float num20 = num19 * 0f;
			obj4 = uIRoot;
			float num21 = num18 + (float)obj4;
			obj = uIRoot;
			float num22 = num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			float num23 = num22 + 0f;
			nint num24 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v64 (Il2CppClass<UIPanel>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num25 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v145 (Il2CppClass<UIPanel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = 0;
			_ = 0;
			obj5 = num18;
			_ = 0f;
			transform = (Transform)obj5;
			Transform transform5 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			object obj28 = mCorners + 16;
			obj28 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			obj6 = 0;
			_ = 0;
			obj6 = num18;
			_ = 0f;
			transform = (Transform)obj6;
			Transform transform6 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
			object obj29 = mCorners + 28;
			obj29 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			obj7 = 0;
			_ = 0;
			obj7 = num21;
			_ = 0f;
			transform = (Transform)obj7;
			Transform transform7 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			object obj30 = mCorners + 40;
			obj30 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			obj8 = 0;
			_ = 0;
			obj8 = num21;
			_ = 0f;
			transform = (Transform)obj8;
			Transform transform8 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
			((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
			object obj31 = mCorners + 52;
			obj31 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L0 (UnityEngine.Transform)+5F]");
			if ((nint)0 != 0)
			{
				nint num26 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S1_v90 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj32 = (nint)0 & (nint)0x200;
				if (obj32 != null)
				{
					nint num27 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ S1_v136 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L0 (UnityEngine.Transform)+44]");
				if (!((UnityEngine.Object)0 != null))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L0 (UnityEngine.Transform)+44]");
					GameObject gameObject = ((Component)0).gameObject;
					Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
					Camera camera2 = ((UIRect)(object)trans).anchorCamera;
					nint num28 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S2_v54 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj33 = (nint)0 & (nint)0x200;
					if (obj33 != null)
					{
						nint num29 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S2_v59 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)parentInternal).FindKernel((string)(object)camera2) == 0)
					{
						goto IL_0af6;
					}
				}
				Camera camera3 = ((UIRect)(object)trans).anchorCamera;
				transform.position = (Vector3)camera3;
				obj9 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				object obj34 = 0;
				while ((nint)obj34 <= 3)
				{
					nint num30 = (nint)typeof(UIPanel);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ S0_v107 (Il2CppClass<UIPanel>)+BA]");
					object obj35 = (nint)0 & (nint)0x200;
					if (obj35 != null)
					{
						nint num31 = (nint)typeof(UIPanel);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ S0_v133 (Il2CppClass<UIPanel>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj36 = mCorners + 16;
					object obj37 = obj34 * 12;
					object obj38 = obj36 + obj37;
					obj2 = obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ S1_v109+8]");
					_ = 0;
					obj3 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
					_ = 0;
					nint num32 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S0_v116 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj39 = (nint)0 & (nint)0x200;
					if (obj39 != null)
					{
						nint num33 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S0_v129 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					uIRoot = (UIRoot)obj2;
					UIRoot uIRoot2 = uIRoot;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((UnityEngine.Object)uIRoot2).m_CachedPtr = (IntPtr)0;
					transform = (Transform)obj3;
					Transform transform9 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
					Vector3 vector = (Vector3)uIRoot - (Vector3)transform;
					obj38 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					_ = 0;
					object obj40 = obj34 + 1;
					obj34 = obj40;
				}
			}
		}
		goto IL_0af6;
		IL_0af6:
		nint num34 = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v33 (Il2CppClass<UIPanel>)+BA]");
		object obj41 = (nint)0 & (nint)0x200;
		if (obj41 != null)
		{
			nint num35 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v40 (Il2CppClass<UIPanel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (UIPanel)(object)mCorners;
	}

	public static UIPanel Find(Transform trans, bool createIfMissing)
	{
		//IL_03d6: Expected Obj, but got I
		//IL_001a: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I4
		//IL_0347: Expected Obj, but got I4
		//IL_0357: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I4
		//IL_03a9: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04b6: Expected I, but got Obj
		//IL_04cc: Expected Obj, but got I
		//IL_00f7: Expected I, but got Obj
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0185: Expected I, but got Obj
		//IL_01d2: Expected I, but got Obj
		//IL_01e8: Expected Obj, but got I
		//IL_0213: Expected I, but got Obj
		//IL_025b: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		int num2 = default;
		int num3 = default;
		UnityEngine.Object obj11 = default;
		UnityEngine.Object obj13 = default;
		UnityEngine.Object obj15 = default;
		UIDrawCall result;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L0 (UnityEngine.Transform)+70]");
			object obj = 0;
			int num = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v7+C]");
			if ((nint)num < (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L0 (UnityEngine.Transform)+70]");
				UIDrawCall uIDrawCall = ((List<UIDrawCall>)0).get_Item(num2);
				object obj2;
				if (num2 != 0)
				{
					int index = num2 - 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L0 (UnityEngine.Transform)+70]");
					UIDrawCall uIDrawCall2 = ((List<UIDrawCall>)0).get_Item(index);
					obj2 = uIDrawCall2.depthEnd + 1;
				}
				else
				{
					obj2 = int.MinValue;
				}
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [createIfMissing @ L1 (System.Boolean)+6C]");
				bool flag = (nint)obj3 > 0;
				object obj4 = num2 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L0 (UnityEngine.Transform)+70]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S2_v8+C]");
				object obj6;
				if (obj4 == null)
				{
					obj6 = int.MaxValue;
				}
				else
				{
					int index2 = num2 + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L0 (UnityEngine.Transform)+70]");
					UIDrawCall uIDrawCall3 = ((List<UIDrawCall>)0).get_Item(index2);
					obj6 = uIDrawCall3.depthStart - 1;
				}
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [createIfMissing @ L1 (System.Boolean)+6C]");
				bool flag2 = (nint)obj7 < 0;
				object obj8 = flag | flag2;
				if (obj8 != null)
				{
					num2 = num3 + 1;
					continue;
				}
				object obj9 = uIDrawCall - -64;
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((UnityEngine.Object)obj9 != obj11)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num7 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (uIDrawCall.mShader != obj13)
					{
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num9 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (uIDrawCall.mTexture != obj15)
						{
							if (!((UIWidget)createIfMissing).hasVertices)
							{
								result = null;
								break;
							}
							object obj16 = (createIfMissing ? 1 : 0) + 248;
							obj16 = uIDrawCall;
							UIWidget.Pivot rawPivot = ((UIWidget)createIfMissing).rawPivot;
							bool flag3 = rawPivot == UIWidget.Pivot.TopLeft;
							result = uIDrawCall;
							if (!flag3)
							{
								uIDrawCall.isDirty = true;
								result = uIDrawCall;
							}
							break;
						}
					}
				}
				_ = 1;
				result = null;
				break;
			}
			_ = 1;
			result = null;
			break;
		}
		return (UIPanel)(object)result;
	}

	public static UIPanel Find(Transform trans, bool createIfMissing, int layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		//IL_0049: Expected VT, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I4
		object obj = default;
		AsyncCallback asyncCallback = (AsyncCallback)(obj + 24);
		asyncCallback = (AsyncCallback)0;
		((Delegate)asyncCallback).method_ptr = (IntPtr)0;
		((Delegate)asyncCallback).m_target = null;
		Camera camera = ((UIRect)(object)trans).anchorCamera;
		Vector2 vector = NGUIMath.ScreenToPixels((Vector2)camera, (Transform)createIfMissing);
		asyncCallback = (AsyncCallback)obj;
		AsyncCallback asyncCallback2 = asyncCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Delegate)asyncCallback2).method_ptr = (IntPtr)0;
		AsyncCallback asyncCallback3 = asyncCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		((Delegate)asyncCallback3).m_target = 0;
		return (UIPanel)((InitDelegate)(object)trans).BeginInvoke(createIfMissing, asyncCallback, (object)layer);
	}

	public Vector2 GetWindowSize()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
		object obj = default;
		if (obj != null)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)mSortingOrder).FindKernel(null) != 0)
			{
				int num3 = mSortingOrder;
				List<UIWidget> list = widgets;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v11 (System.Int32)+10]");
				if (list != null)
				{
					int num4 = mSortingOrder;
					List<UIWidget> list2 = widgets;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v20 (System.Int32)+14]");
					if (list2 != null)
					{
						goto IL_015c;
					}
				}
				_ = 1;
				goto IL_015c;
			}
		}
		goto IL_012a;
		IL_012a:
		Vector2 result = default;
		return result;
		IL_015c:
		int num5 = mSortingOrder;
		_ = 1;
		object obj3 = this + 248;
		obj3 = 0;
		goto IL_012a;
	}

	public unsafe Vector2 GetViewSize()
	{
		//IL_019a: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01f2: Expected I, but got Obj
		//IL_0208: Expected Obj, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I4
		//IL_0266: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0281: Expected F4, but got I
		//IL_027c: Expected native int or pointer, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_00b5: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		//IL_0297: Expected F4, but got I
		//IL_02a8: Expected VT, but got Obj
		//IL_02a8: Expected VT, but got I4
		//IL_02ba: Expected I, but got Obj
		//IL_02d0: Expected Obj, but got I
		//IL_030a: Expected VT, but got Obj
		//IL_0316: Expected I, but got Obj
		//IL_00f6: Expected I, but got Obj
		//IL_0143: Expected I, but got Obj
		bool flag = isAnchored;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v65 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		PropertyBinding propertyBinding = (PropertyBinding)(obj2 + 24);
		propertyBinding.Start();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v61 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 16;
		object obj5 = obj2 + 8;
		int num5 = ((ComputeShader)flag).FindKernel(null);
		bool flag2 = num5 == 0;
		nint num6 = (nint)propertyBinding;
		if (!flag2)
		{
			obj4 = propertyBinding;
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v37 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v57 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v25+4]");
			GUILayoutOption gUILayoutOption = GUILayout.Width(0f);
			float num9 = Math3D.AngleVectorPlane((Vector3)flag, (Vector3)gUILayoutOption);
			nint num10 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v44 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num11 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v53 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = propertyBinding;
			propertyBinding = (PropertyBinding)obj5;
			Vector2 vector = (Vector2)propertyBinding / num9;
			num6 = (nint)obj2;
		}
		Vector2 vector2 = default;
		((Vector2*)(nint)vector2)->x = num6;
		return vector2;
	}

	public UIPanel()
	{
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UIPanel>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v38 (Il2CppClass<UIPanel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mUpdateFrame = -1;
		List<UIPanel> list = UIPanel.list;
		if (list._size <= 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v23 (Il2CppClass<UIPanel>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v32 (Il2CppClass<UIPanel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIPanel uIPanel = UIPanel.list.get_Item(0);
		((UIPanel)null).UpdateSelf();
	}

	static UIPanel()
	{
		//IL_00b2: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_001c: Expected I, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BetterList<UILabel> mList = default;
		UILabel.mList = mList;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(UILabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17 (Il2CppClass<UILabel>)+5C]");
		object obj6 = (nint)0 + (nint)4;
		object obj7 = default;
		obj6 = obj7;
		UILabel.mTexRebuildAdded = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Vector3> list = default;
		list._002Ector();
		nint num3 = (nint)typeof(UILabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27 (Il2CppClass<UILabel>)+5C]");
		object obj8 = (nint)0 + (nint)16;
		obj8 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<int> list2 = default;
		list2._002Ector();
		nint num4 = (nint)typeof(UILabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v34 (Il2CppClass<UILabel>)+5C]");
		object obj9 = (nint)0 + (nint)20;
		obj9 = list2;
	}
}
