using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using SYBO.Subway.Routes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.SceneManagement;

public class UIDrawCall : MonoBehaviour
{
	public enum Clipping
	{
		None = 0,
		TextureMask = 1,
		SoftClip = 3,
		ConstrainButDontClip = 4
	}

	public delegate void OnRenderCallback(Material mat);

	public delegate void OnCreateDrawCall(UIDrawCall dc, MeshFilter filter, MeshRenderer ren);

	public enum ShadowMode
	{
		None,
		Receive,
		CastAndReceive
	}

	private static BetterList<UIDrawCall> mActiveList;

	private static BetterList<UIDrawCall> mInactiveList;

	[NonSerialized]
	public int widgetCount;

	[NonSerialized]
	public int depthStart;

	[NonSerialized]
	public int depthEnd;

	[NonSerialized]
	public UIPanel manager;

	[NonSerialized]
	public UIPanel panel;

	[NonSerialized]
	public Texture2D clipTexture;

	[NonSerialized]
	public bool alwaysOnScreen;

	[NonSerialized]
	public List<Vector3> verts;

	[NonSerialized]
	public List<Vector3> norms;

	[NonSerialized]
	public List<Vector4> tans;

	[NonSerialized]
	public List<Vector2> uvs;

	[NonSerialized]
	public List<Vector4> uv2;

	[NonSerialized]
	public List<Color> cols;

	[NonSerialized]
	private Material mMaterial;

	[NonSerialized]
	private Texture mTexture;

	[NonSerialized]
	private Shader mShader;

	[NonSerialized]
	private int mClipCount;

	[NonSerialized]
	private Transform mTrans;

	[NonSerialized]
	private Mesh mMesh;

	[NonSerialized]
	private MeshFilter mFilter;

	[NonSerialized]
	private MeshRenderer mRenderer;

	[NonSerialized]
	private Material mDynamicMat;

	[NonSerialized]
	private int[] mIndices;

	[NonSerialized]
	private ShadowMode mShadowMode;

	[NonSerialized]
	private bool mRebuildMat;

	[NonSerialized]
	private bool mLegacyShader;

	[NonSerialized]
	private int mRenderQueue;

	[NonSerialized]
	private int mTriangles;

	[NonSerialized]
	public bool isDirty;

	[NonSerialized]
	private bool mTextureClip;

	[NonSerialized]
	private bool mIsNew;

	public OnRenderCallback onRender;

	public OnCreateDrawCall onCreateDrawCall;

	[NonSerialized]
	private string mSortingLayerName;

	[NonSerialized]
	private int mSortingOrder;

	private static ColorSpace mColorSpace;

	private const int maxIndexBufferCache = 10;

	private static List<int[]> mCache;

	protected MaterialPropertyBlock mBlock;

	private static int[] ClipRange;

	private static int[] ClipArgs;

	private static int dx9BugWorkaround;

	public static BetterList<UIDrawCall> list
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			TextEditor textEditor = default;
			textEditor.ClearCursorPos();
			string text = global::Locale.GetText((string)(object)textEditor);
			GUIContent content = textEditor.m_Content;
			return (BetterList<UIDrawCall>)(object)content.m_Text;
		}
	}

	public static BetterList<UIDrawCall> activeList
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIDrawCall>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return mActiveList;
		}
	}

	public static BetterList<UIDrawCall> inactiveList
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIDrawCall>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return mActiveList;
		}
	}

	public unsafe int renderQueue
	{
		get
		{
			return 0;
		}
		set
		{
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected Obj, but got Unknown
			//IL_00cd: Expected Obj, but got I4
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected VT, but got Unknown
			//IL_00ef: Expected Obj, but got I4
			//IL_00fc: Expected F4, but got Obj
			//IL_00f7: Expected native int or pointer, but got VT
			//IL_0111: Expected F4, but got I
			//IL_010c: Expected native int or pointer, but got VT
			//IL_011e: Expected Obj, but got F4
			//IL_0028: Expected I, but got Obj
			//IL_003e: Expected Obj, but got I
			//IL_0184: Expected F4, but got Obj
			//IL_017f: Expected native int or pointer, but got VT
			//IL_0199: Expected F4, but got I
			//IL_0194: Expected native int or pointer, but got VT
			//IL_0069: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 16;
			object obj3 = obj2 + 32;
			obj3 = 0;
			_ = 0;
			Color color = (Color)(obj2 + 48);
			object obj4 = value + 80;
			((Color*)(nint)color)->r = (float)obj4;
			Color color2 = color;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9+8]");
			((Color*)(nint)color2)->b = 0f;
			obj3 = color.r;
			_ = color.b;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+4C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj5 = default;
			if (obj5 != null)
			{
				obj = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				nint num = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (Il2CppClass<NGUITools>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v37 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Color*)(nint)color)->r = (float)obj;
				Color color3 = color;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((Color*)(nint)color3)->b = 0f;
				Color color4 = NGUITools.GammaToLinearSpace(color);
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
			}
			UIDrawCall uIDrawCall = (UIDrawCall)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public int sortingOrder
	{
		get
		{
			return mRenderQueue;
		}
		set
		{
			//IL_001d: Expected I, but got Obj
			//IL_0033: Expected Obj, but got I
			//IL_005e: Expected I, but got Obj
			//IL_00ac: Expected Obj, but got I4
			if (mRenderQueue == value)
			{
				return;
			}
			mRenderQueue = value;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mDynamicMat).FindKernel((string)null) != 0)
			{
				mDynamicMat.EnableKeyword((string)value);
			}
		}
	}

	public string sortingLayerName
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)mSortingOrder;
		}
		set
		{
			//IL_000f: Expected I4, but got Obj
			//IL_001d: Expected I, but got Obj
			//IL_0033: Expected Obj, but got I
			//IL_005e: Expected I, but got Obj
			if (mSortingOrder == (nint)value)
			{
				return;
			}
			mSortingOrder = (int)value;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mRenderer).FindKernel((string)null) != 0)
			{
				mRenderer.materials = (Material[])(object)value;
			}
		}
	}

	public int finalRenderQueue
	{
		get
		{
			//IL_00fe: Expected I4, but got Obj
			//IL_003a: Expected I, but got Obj
			//IL_0050: Expected Obj, but got I
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected Obj, but got Unknown
			//IL_00e1: Expected Obj, but got I4
			//IL_007b: Expected I, but got Obj
			string text = mSortingLayerName;
			if (mSortingLayerName == null || text.m_stringLength == 0)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (mRenderer != null)
				{
					return 0;
				}
				object obj2 = this + 132;
				int sortingLayerID = mRenderer.sortingLayerID;
				obj2 = sortingLayerID;
			}
			return (int)mSortingLayerName;
		}
	}

	public Transform cachedTransform
	{
		get
		{
			//IL_008b: Expected I, but got Obj
			//IL_00a1: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I4
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
			if (((ComputeShader)(object)mDynamicMat).FindKernel((string)null) != 0)
			{
				return (Transform)(object)mDynamicMat.GetShaderKeywords();
			}
			return (Transform)mRenderQueue;
		}
	}

	public Material baseMaterial
	{
		get
		{
			//IL_0082: Expected I, but got Obj
			//IL_0098: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mTrans != null)
			{
				object obj2 = this + 80;
				GameObject gameObject = base.gameObject;
				obj2 = gameObject;
			}
			return (Material)(object)mTrans;
		}
		set
		{
			//IL_00b7: Expected I, but got Obj
			//IL_00cd: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0061: Expected I4, but got Obj
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected Obj, but got Unknown
			//IL_00a4: Expected I4, but got Obj
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
			if (((ComputeShader)(object)mRenderer).FindKernel((string)null) != 0 && mSortingLayerName.get_Chars((int)value) != '\0')
			{
				object obj2 = this + 132;
				obj2 = value;
				mRenderer.sortingOrder = (int)value;
			}
		}
	}

	public Material dynamicMaterial
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			return (Material)(this - -64);
		}
	}

	public Texture mainTexture
	{
		get
		{
			return (Texture)(object)mDynamicMat;
		}
		set
		{
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected Obj, but got Unknown
			//IL_008e: Expected I, but got Obj
			//IL_00a4: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			object obj = this - -64;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj).FindKernel((string)(object)value) != 0)
			{
				object obj3 = this - -64;
				obj3 = value;
				mRebuildMat = true;
			}
		}
	}

	public Shader shader
	{
		get
		{
			return (Shader)(object)mTexture;
		}
		set
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected Obj, but got Unknown
			//IL_009c: Expected VT, but got Obj
			//IL_009c: Expected I4, but got Obj
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected Obj, but got Unknown
			//IL_0030: Expected Obj, but got I
			object obj = this + 68;
			obj = value;
			if (mBlock == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				IntPtr intPtr = default;
				MaterialPropertyBlock.DestroyImpl(intPtr);
				object obj2 = this + 140;
				obj2 = (nint)intPtr;
			}
			bool flag = (object)value == null;
			bool flag2 = !flag;
			RenderTexture renderTexture = (RenderTexture)(object)value;
			if (!flag2)
			{
				RenderTexture active = RenderTexture.GetActive();
				renderTexture = active;
			}
			((Material)(object)mBlock).SetColorImpl((int)"_MainTex", (Color)renderTexture);
		}
	}

	public ShadowMode shadowMode
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (ShadowMode)mShader;
		}
		set
		{
			//IL_0083: Expected I, but got Obj
			//IL_0099: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			//IL_0065: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mShader).FindKernel((string)value) != 0)
			{
				object obj2 = this + 72;
				obj2 = value;
				mRebuildMat = true;
			}
		}
	}

	public int triangles => (int)mShadowMode;

	public bool isClipped
	{
		get
		{
			//IL_007d: Expected I, but got Obj
			//IL_0093: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mMesh).FindKernel((string)null) != 0)
			{
				return (byte)mTriangles != 0;
			}
			return false;
		}
	}

	private void CreateMaterial()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got F4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		_ = 4;
		_ = 1f;
		object obj2 = default;
		object obj = obj2 + 16;
		Color black = Color.black;
		object obj3 = obj2 + 32;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v7+8]");
		_ = 0;
		object obj4 = this + 312;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 0.7f;
		_ = 0.7f;
		_ = 0.7f;
		_ = 1f;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 328;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9+8]");
		_ = 0;
		_ = 1;
		_ = 1;
		_ = 1;
		_ = 1;
		_ = 1;
		((AnimatedAlpha)this).OnEnable();
	}

	private Material RebuildMaterial()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = mClipCount != 0;
		return (Material)flag;
	}

	private void UpdateMaterials()
	{
		//IL_0b0e: Expected I, but got Obj
		//IL_0b24: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_0b81: Expected I4, but got Obj
		//IL_0b81: Expected I4, but got Obj
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0c2a: Expected I4, but got Obj
		//IL_0c2a: Expected I4, but got Obj
		//IL_0c41: Expected I4, but got Obj
		//IL_0c41: Expected I4, but got Obj
		//IL_0c53: Expected I, but got Obj
		//IL_0c69: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got I4
		//IL_02a0: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0cc1: Expected I, but got Obj
		//IL_0cd7: Expected Obj, but got I
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected Obj, but got Unknown
		//IL_06b6: Expected I, but got Obj
		//IL_06cc: Expected Obj, but got I
		//IL_0641: Expected I, but got Obj
		//IL_06f7: Expected I, but got Obj
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected Obj, but got Unknown
		//IL_0aa4: Expected I4, but got Obj
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Obj, but got Unknown
		//IL_0abc: Expected I4, but got Obj
		//IL_0acc: Expected Obj, but got I4
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected Obj, but got Unknown
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected Obj, but got Unknown
		//IL_0796: Expected I4, but got Obj
		//IL_07ae: Expected I4, but got Obj
		//IL_07be: Expected Obj, but got I4
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected Obj, but got Unknown
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Expected Obj, but got Unknown
		//IL_0806: Expected Obj, but got I4
		//IL_0864: Expected I, but got Obj
		//IL_087a: Expected Obj, but got I
		//IL_0819: Expected Obj, but got I4
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected Obj, but got Unknown
		//IL_08a5: Expected I, but got Obj
		mTextureClip = false;
		mLegacyShader = false;
		bool hasClipping = panel.hasClipping;
		mClipCount = (hasClipping ? 1 : 0);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v223 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text;
		if (((ComputeShader)(object)mShader).FindKernel((string)null) != 0)
		{
			UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)mShader);
			text = (string)(object)obj2;
		}
		else
		{
			object obj3 = this - -64;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v210 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v218 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj3).FindKernel((string)null) != 0)
			{
				object obj5 = this - -64;
				Texture original = ((Material)obj5).mainTexture;
				UnityEngine.Object obj6 = UnityEngine.Object.Instantiate((UnityEngine.Object)original);
				text = (string)(object)obj6;
			}
			else
			{
				text = "Unlit/Transparent Colored";
			}
		}
		string text2 = text.Remove((int)"GUI/Text Shader", (int)"Unlit/Text");
		bool flag = text2.m_stringLength >= 3;
		bool flag2 = !flag;
		string text3 = text2;
		if (!flag2)
		{
			char[] separator = (char[])(text2.m_stringLength - 2);
			string[] array = text2.Split(separator);
			object obj7 = array & 0xFFFF;
			bool flag3 = (nint)obj7 == 32;
			bool flag4 = !flag3;
			text3 = text2;
			if (!flag4)
			{
				char[] separator2 = (char[])(text2.m_stringLength - 1);
				string[] array2 = text2.Split(separator2);
				object obj8 = array2 + -49;
				object obj9 = obj8 << 16;
				object obj10 = obj9 >> 16;
				object obj11 = obj10 & 0xFFFF;
				bool flag5 = (nint)obj11 <= 8;
				bool flag6 = !flag5;
				text3 = text2;
				if (!flag6)
				{
					int length = text2.m_stringLength - 2;
					string text4 = text2.InternalSubString(0, length);
					text3 = text4;
				}
			}
		}
		string text5 = text3.ToLower((CultureInfo)(object)"Hidden/");
		if (text5 != null)
		{
			string text6 = text3.Trim((char[])7);
			text3 = text6;
		}
		string text7 = text3.Remove((int)" (SoftClip)", (int)"");
		string type = text7.Remove((int)" (TextureClip)", (int)"");
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v163 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)panel).FindKernel((string)null) != 0)
		{
			UIPanel uIPanel = panel;
			if (uIPanel.mClipping == Clipping.TextureMask)
			{
				mTextureClip = true;
				object obj13 = ((IConvertible)"Hidden/").ToType((Type)(object)type, (IFormatProvider)(object)" (TextureClip)");
				int num7 = Shader.PropertyToID((string)obj13);
				shadowMode = (ShadowMode)num7;
				goto IL_0cb3;
			}
		}
		if (mClipCount == 0)
		{
			int num8 = Shader.PropertyToID(type);
			shadowMode = (ShadowMode)num8;
			goto IL_0cb3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
		IL_0cb3:
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S1_v124 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mShader != null)
		{
			int num11 = Shader.PropertyToID("Unlit/Transparent Colored");
			shadowMode = (ShadowMode)num11;
		}
		object obj15 = this - -64;
		nint num12 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v114 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj15).FindKernel((string)null) != 0)
		{
			object contents = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Material material = default;
			material._002Ector((string)contents);
			object obj17 = this + 96;
			obj17 = material;
			object original2 = this - -64;
			UnityEngine.Object obj18 = UnityEngine.Object.Instantiate((UnityEngine.Object)original2);
			string text8 = string.ConcatArray((string[])(object)"[NGUI] ", (int)obj18);
			UnityEngine.Object.DestroyImmediate(mDynamicMat, (byte)(int)text8 != 0);
			UnityEngine.Object.CheckNullArgument((object)mDynamicMat, (string)60);
			object obj19 = this - -64;
			Color color = ((Light)obj19).color;
			object obj20 = this - -64;
			LightType type2 = ((Light)obj20).type;
			object obj21 = type2 + 12;
			object obj22 = default;
			object obj25 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21))
			{
				object obj23 = type2 + 16;
				object obj24 = obj25 << 2;
				object keyword = obj23 + obj24;
				mDynamicMat.DisableKeyword((string)keyword);
				obj22 = obj25 + 1;
			}
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num15 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S1_v112 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mShader).FindKernel((string)null) != 0)
			{
				Color color2 = ((Material)(object)mShader).color;
			}
			else if (mClipCount != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Material material2 = default;
			material2._002Ector((Material)(object)mShader);
			object obj27 = this + 96;
			obj27 = material2;
			UnityEngine.Object obj28 = UnityEngine.Object.Instantiate((UnityEngine.Object)mShader);
			string text9 = string.ConcatArray((string[])(object)"[NGUI] ", (int)obj28);
			UnityEngine.Object.DestroyImmediate(mDynamicMat, (byte)(int)text9 != 0);
			UnityEngine.Object.CheckNullArgument((object)mDynamicMat, (string)60);
		}
	}

	public void UpdateGeometry(int widgetCount)
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I4
		if (mShadowMode == (ShadowMode)widgetCount)
		{
			return;
		}
		mShadowMode = (ShadowMode)widgetCount;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mRenderer).FindKernel((string)null) == 0)
		{
			return;
		}
		if (mShadowMode == ShadowMode.None)
		{
			mRenderer.receiveShadows = false;
			mRenderer.sortingLayerName = null;
			return;
		}
		if (mShadowMode == ShadowMode.Receive)
		{
			mRenderer.receiveShadows = false;
		}
		else
		{
			mRenderer.receiveShadows = true;
		}
		mRenderer.sortingLayerName = (string)1;
	}

	private unsafe int[] GenerateCachedIndexBuffer(int vertexCount, int indexCount)
	{
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdc: Expected I, but got Unknown
		//IL_0be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bea: Expected Obj, but got Unknown
		//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf8: Expected Obj, but got Unknown
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected Obj, but got Unknown
		//IL_0c0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c14: Expected Obj, but got Unknown
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Expected Obj, but got Unknown
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected Obj, but got Unknown
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected Obj, but got Unknown
		//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4c: Expected Obj, but got Unknown
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5a: Expected Obj, but got Unknown
		//IL_0c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c68: Expected Obj, but got Unknown
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Expected Obj, but got Unknown
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected Obj, but got Unknown
		//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c92: Expected Obj, but got Unknown
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected Obj, but got Unknown
		//IL_0ca9: Expected Obj, but got I4
		//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Expected Obj, but got Unknown
		//IL_0cc0: Expected Obj, but got F4
		//IL_0ccd: Expected Obj, but got F8
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0d0f: Expected I, but got Obj
		//IL_000e: Expected Obj, but got I4
		//IL_0062: Expected I, but got Obj
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_0d6f: Expected I, but got Obj
		//IL_057b: Expected I, but got Obj
		//IL_0591: Expected Obj, but got I
		//IL_015f: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I4
		//IL_0f3a: Expected I, but got Obj
		//IL_01ac: Expected I, but got Obj
		//IL_01c2: Expected Obj, but got I
		//IL_0886: Expected I, but got Obj
		//IL_089c: Expected Obj, but got I
		//IL_05bc: Expected I, but got Obj
		//IL_0dbe: Expected I, but got Obj
		//IL_1073: Expected I, but got Obj
		//IL_0609: Expected I, but got Obj
		//IL_061f: Expected Obj, but got I
		//IL_02a5: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I
		//IL_01ed: Expected I, but got Obj
		//IL_08c7: Expected I, but got Obj
		//IL_0f89: Expected I, but got Obj
		//IL_0e0d: Expected I, but got Obj
		//IL_0914: Expected I, but got Obj
		//IL_092a: Expected Obj, but got I
		//IL_0702: Expected I, but got Obj
		//IL_0718: Expected Obj, but got I
		//IL_064a: Expected I, but got Obj
		//IL_03d7: Expected I, but got Obj
		//IL_03ed: Expected Obj, but got I
		//IL_02e6: Expected I, but got Obj
		//IL_10cc: Expected I, but got Obj
		//IL_0fd8: Expected I, but got Obj
		//IL_06a0: Expected Ref, but got F4
		//IL_0e8b: Expected I, but got Obj
		//IL_0333: Expected I, but got Obj
		//IL_0349: Expected Obj, but got I
		//IL_0a5d: Expected I, but got Obj
		//IL_0a73: Expected Obj, but got I
		//IL_0955: Expected I, but got Obj
		//IL_07c4: Expected I, but got Obj
		//IL_07da: Expected Obj, but got I
		//IL_0743: Expected I, but got Obj
		//IL_0418: Expected I, but got Obj
		//IL_0277: Expected I, but got Obj
		//IL_0292: Expected Obj, but got I4
		//IL_1154: Expected I, but got Obj
		//IL_09a2: Expected I, but got Obj
		//IL_09b8: Expected Obj, but got I
		//IL_1027: Expected I, but got Obj
		//IL_0465: Expected I, but got Obj
		//IL_047b: Expected Obj, but got I
		//IL_0374: Expected I, but got Obj
		//IL_0b1f: Expected I, but got Obj
		//IL_0b35: Expected Obj, but got I
		//IL_0a9e: Expected I, but got Obj
		//IL_1117: Expected Ref, but got F8
		//IL_0805: Expected I, but got Obj
		//IL_06d4: Expected I, but got Obj
		//IL_06ef: Expected Obj, but got I4
		//IL_11a3: Expected I, but got Obj
		//IL_09e3: Expected I, but got Obj
		//IL_04a6: Expected I, but got Obj
		//IL_0b60: Expected I, but got Obj
		//IL_0a2f: Expected I, but got Obj
		//IL_0a4a: Expected Obj, but got I4
		IFormatProvider formatProvider = default;
		nint num = (nint)(formatProvider + 8);
		object obj = formatProvider + 72;
		object obj2 = formatProvider + 68;
		object obj3 = formatProvider - -64;
		object obj4 = formatProvider + 60;
		object obj5 = formatProvider + 56;
		object obj6 = formatProvider + 52;
		object obj7 = formatProvider + 48;
		object obj8 = formatProvider + 44;
		object obj9 = formatProvider + 40;
		object obj10 = formatProvider + 36;
		object obj11 = formatProvider + 24;
		object obj12 = formatProvider + 20;
		object obj13 = formatProvider + 16;
		IFormatProvider formatProvider2 = (IFormatProvider)(formatProvider + 32);
		formatProvider2 = (IFormatProvider)0;
		IFormatProvider formatProvider3 = (IFormatProvider)(formatProvider + 28);
		formatProvider3 = (IFormatProvider)0f;
		formatProvider = (IFormatProvider)0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj14 = default;
		int[] result;
		if (obj14 != null)
		{
			result = (int[])1;
		}
		else
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v47 (Il2CppClass<System.Type>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v301 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = typeof(string);
			((IntPtr*)num)->m_value = (void*)(nint)obj;
			Type type = Type.internal_from_handle((IntPtr)num);
			bool flag = indexCount == (nint)type;
			bool flag2 = (object)this == null;
			if (flag)
			{
				object obj16 = default;
				if (flag2)
				{
					obj16 = "null";
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				}
				UIDrawCall uIDrawCall = (UIDrawCall)obj16;
				result = (int[])1;
			}
			else if (flag2)
			{
				result = null;
			}
			else
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v59 (Il2CppClass<System.Type>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v294 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(int);
				((IntPtr*)num)->m_value = (void*)(nint)obj2;
				Type type2 = Type.internal_from_handle((IntPtr)num);
				if (indexCount == (nint)type2)
				{
					nint num6 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v221 (Il2CppClass<System.Type>)+BA]");
					object obj18 = (nint)0 & (nint)0x200;
					if (obj18 != null)
					{
						nint num7 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v290 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj3 = typeof(string);
					((IntPtr*)num)->m_value = (void*)(nint)obj3;
					Type type3 = Type.internal_from_handle((IntPtr)num);
					if (vertexCount == (nint)type3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
						int num8 = default;
						bool flag3 = ((int*)num8)->System_002EIConvertible_002EToBoolean(formatProvider2);
						bool flag4 = !flag3;
						result = null;
						if (!flag4)
						{
							((IntPtr*)num)->m_value = (void*)(nint)formatProvider2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							object obj19 = default;
							UIDrawCall uIDrawCall = (UIDrawCall)obj19;
							result = (int[])1;
						}
					}
					else
					{
						nint num9 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v232 (Il2CppClass<System.Type>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						if (obj20 != null)
						{
							nint num10 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v282 (Il2CppClass<System.Type>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj4 = typeof(float);
						((IntPtr*)num)->m_value = (void*)(nint)obj4;
						Type type4 = Type.internal_from_handle((IntPtr)num);
						if (vertexCount == (nint)type4)
						{
							nint num11 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v271 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj21 = (nint)0 & (nint)0x200;
							if (obj21 != null)
							{
								nint num12 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S0_v278 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							throw new NullReferenceException();
						}
						nint num13 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S0_v243 (Il2CppClass<System.Type>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						if (obj22 != null)
						{
							nint num14 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S0_v264 (Il2CppClass<System.Type>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj5 = typeof(double);
						((IntPtr*)num)->m_value = (void*)(nint)obj5;
						Type type5 = Type.internal_from_handle((IntPtr)num);
						bool flag5 = vertexCount != (nint)type5;
						result = null;
						if (!flag5)
						{
							nint num15 = (nint)typeof(Math);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ S0_v253 (Il2CppClass<System.Math>)+BA]");
							object obj23 = (nint)0 & (nint)0x200;
							if (obj23 != null)
							{
								nint num16 = (nint)typeof(Math);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S0_v260 (Il2CppClass<System.Math>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							throw new NullReferenceException();
						}
					}
				}
				else
				{
					nint num17 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v70 (Il2CppClass<System.Type>)+BA]");
					object obj24 = (nint)0 & (nint)0x200;
					if (obj24 != null)
					{
						nint num18 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v214 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj6 = typeof(float);
					((IntPtr*)num)->m_value = (void*)(nint)obj6;
					Type type6 = Type.internal_from_handle((IntPtr)num);
					if (indexCount == (nint)type6)
					{
						nint num19 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v163 (Il2CppClass<System.Type>)+BA]");
						object obj25 = (nint)0 & (nint)0x200;
						if (obj25 != null)
						{
							nint num20 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v210 (Il2CppClass<System.Type>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj7 = typeof(string);
						((IntPtr*)num)->m_value = (void*)(nint)obj7;
						Type type7 = Type.internal_from_handle((IntPtr)num);
						if (vertexCount == (nint)type7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
							float num21 = default;
							bool flag6 = ((float*)num21)->System_002EIConvertible_002EToBoolean(formatProvider3);
							bool flag7 = !flag6;
							result = null;
							if (!flag7)
							{
								((IntPtr*)num)->m_value = (void*)(nint)formatProvider3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
								object obj26 = default;
								UIDrawCall uIDrawCall = (UIDrawCall)obj26;
								result = (int[])1;
							}
						}
						else
						{
							nint num22 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S0_v174 (Il2CppClass<System.Type>)+BA]");
							object obj27 = (nint)0 & (nint)0x200;
							if (obj27 != null)
							{
								nint num23 = (nint)typeof(Type);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v202 (Il2CppClass<System.Type>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj8 = typeof(double);
							((IntPtr*)num)->m_value = (void*)(nint)obj8;
							Type type8 = Type.internal_from_handle((IntPtr)num);
							if (vertexCount == (nint)type8)
							{
								throw new NullReferenceException();
							}
							nint num24 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S0_v185 (Il2CppClass<System.Type>)+BA]");
							object obj28 = (nint)0 & (nint)0x200;
							if (obj28 != null)
							{
								nint num25 = (nint)typeof(Type);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S0_v195 (Il2CppClass<System.Type>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj9 = typeof(int);
							((IntPtr*)num)->m_value = (void*)(nint)obj9;
							Type type9 = Type.internal_from_handle((IntPtr)num);
							bool flag8 = vertexCount != (nint)type9;
							result = null;
							if (!flag8)
							{
								throw new NullReferenceException();
							}
						}
					}
					else
					{
						nint num26 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v81 (Il2CppClass<System.Type>)+BA]");
						object obj29 = (nint)0 & (nint)0x200;
						if (obj29 != null)
						{
							nint num27 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v156 (Il2CppClass<System.Type>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj10 = typeof(double);
						((IntPtr*)num)->m_value = (void*)(nint)obj10;
						Type type10 = Type.internal_from_handle((IntPtr)num);
						if (indexCount == (nint)type10)
						{
							nint num28 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v94 (Il2CppClass<System.Type>)+BA]");
							object obj30 = (nint)0 & (nint)0x200;
							if (obj30 != null)
							{
								nint num29 = (nint)typeof(Type);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S0_v152 (Il2CppClass<System.Type>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj11 = typeof(string);
							((IntPtr*)num)->m_value = (void*)(nint)obj11;
							Type type11 = Type.internal_from_handle((IntPtr)num);
							if (vertexCount == (nint)type11)
							{
								nint num30 = (nint)typeof(double);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S0_v140 (Il2CppClass<System.Double>)+BA]");
								object obj31 = (nint)0 & (nint)0x200;
								if (obj31 != null)
								{
									nint num31 = (nint)typeof(double);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ S0_v148 (Il2CppClass<System.Double>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
								double num32 = default;
								bool flag9 = ((double*)num32)->System_002EIConvertible_002EToBoolean(formatProvider);
								bool flag10 = !flag9;
								result = null;
								if (!flag10)
								{
									((IntPtr*)num)->m_value = (void*)(nint)formatProvider;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
									object obj32 = default;
									UIDrawCall uIDrawCall = (UIDrawCall)obj32;
									result = (int[])1;
								}
								goto IL_0d4f;
							}
							nint num33 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S0_v105 (Il2CppClass<System.Type>)+BA]");
							object obj33 = (nint)0 & (nint)0x200;
							if (obj33 != null)
							{
								nint num34 = (nint)typeof(Type);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ S0_v133 (Il2CppClass<System.Type>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj12 = typeof(float);
							((IntPtr*)num)->m_value = (void*)(nint)obj12;
							Type type12 = Type.internal_from_handle((IntPtr)num);
							if (vertexCount == (nint)type12)
							{
								throw new NullReferenceException();
							}
							nint num35 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S0_v116 (Il2CppClass<System.Type>)+BA]");
							object obj34 = (nint)0 & (nint)0x200;
							if (obj34 != null)
							{
								nint num36 = (nint)typeof(Type);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ S0_v126 (Il2CppClass<System.Type>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj13 = typeof(int);
							((IntPtr*)num)->m_value = (void*)(nint)obj13;
							Type type13 = Type.internal_from_handle((IntPtr)num);
							if (vertexCount == (nint)type13)
							{
								throw new NullReferenceException();
							}
						}
						result = null;
					}
				}
			}
		}
		goto IL_0d4f;
		IL_0d4f:
		return result;
	}

	private void OnWillRenderObject()
	{
		//IL_01a6: Expected I, but got Obj
		//IL_01bc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_00c5: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (panel != null)
		{
			return;
		}
		if (~(mRebuildMat ? 1u : 0u) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(mDynamicMat != null))
			{
				bool hasClipping = panel.hasClipping;
				if (mClipCount == (hasClipping ? 1 : 0))
				{
					bool flag = mTextureClip;
					UIPanel uIPanel = panel;
					bool flag2 = uIPanel.mClipping == Clipping.TextureMask;
					object obj3 = flag ^ flag2;
					if (obj3 == null)
					{
						return;
					}
				}
			}
		}
		UIDrawCall uIDrawCall = Create((string)(object)this);
		mRebuildMat = false;
	}

	private void SetClipping(int index, Vector4 cr, Vector2 soft, float angle)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private unsafe void Awake()
	{
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3b: Expected Obj, but got Unknown
		//IL_0b44: Expected Obj, but got I4
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected Obj, but got Unknown
		//IL_0b61: Expected Obj, but got I4
		//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Expected Obj, but got Unknown
		//IL_0b78: Expected Obj, but got I4
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected Obj, but got Unknown
		//IL_0b95: Expected Obj, but got I4
		//IL_0ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Expected Obj, but got Unknown
		//IL_0bb2: Expected Obj, but got I4
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Expected Obj, but got Unknown
		//IL_0bcf: Expected Obj, but got I4
		//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be3: Expected Obj, but got Unknown
		//IL_0bec: Expected Obj, but got I4
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c00: Expected Obj, but got Unknown
		//IL_0c09: Expected Obj, but got I4
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c25: Expected Obj, but got Unknown
		//IL_0c2e: Expected Obj, but got I4
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3c: Expected Obj, but got Unknown
		//IL_0c45: Expected Obj, but got I4
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Expected Obj, but got Unknown
		//IL_0c5c: Expected Obj, but got I4
		//IL_0094: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I
		//IL_0016: Expected I4, but got Obj
		//IL_0c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca3: Expected VT, but got Unknown
		//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb1: Expected Obj, but got Unknown
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected Obj, but got Unknown
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected Obj, but got Unknown
		//IL_0cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdb: Expected Obj, but got Unknown
		//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Expected Obj, but got Unknown
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Expected Obj, but got Unknown
		//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected Obj, but got Unknown
		//IL_0d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d13: Expected Obj, but got Unknown
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected Obj, but got Unknown
		//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2f: Expected Obj, but got Unknown
		//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3d: Expected Obj, but got Unknown
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Expected Obj, but got Unknown
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Expected Obj, but got Unknown
		//IL_0d62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d67: Expected Obj, but got Unknown
		//IL_0d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d75: Expected Obj, but got Unknown
		//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d83: Expected Obj, but got Unknown
		//IL_0d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d91: Expected Obj, but got Unknown
		//IL_00d5: Expected I, but got Obj
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0169: Expected F4, but got Obj
		//IL_0164: Expected native int or pointer, but got VT
		//IL_017e: Expected F4, but got I
		//IL_0179: Expected native int or pointer, but got VT
		//IL_018b: Expected Obj, but got F4
		//IL_01ac: Expected Obj, but got VT
		//IL_01b5: Expected Obj, but got F4
		//IL_01cc: Invalid comparison between Obj and F4
		//IL_124d: Expected I, but got Obj
		//IL_1263: Expected Obj, but got I
		//IL_0308: Expected F4, but got VT
		//IL_0303: Expected native int or pointer, but got VT
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_03b8: Expected Obj, but got I
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected Obj, but got Unknown
		//IL_03d1: Unsupported input type for neg.
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_0456: Expected Obj, but got F4
		//IL_0464: Expected Obj, but got F4
		//IL_0477: Expected Obj, but got F4
		//IL_0480: Invalid comparison between Obj and F4
		//IL_0dd2: Expected F4, but got Obj
		//IL_0dcd: Expected native int or pointer, but got VT
		//IL_0f9f: Expected native int or pointer, but got VT
		//IL_128e: Expected I, but got Obj
		//IL_12a4: Expected Obj, but got I
		//IL_01f8: Expected F4, but got Obj
		//IL_01f3: Expected native int or pointer, but got VT
		//IL_020d: Expected F4, but got I
		//IL_0208: Expected native int or pointer, but got VT
		//IL_0231: Expected Obj, but got F4
		//IL_05a8: Expected I, but got Obj
		//IL_12d6: Expected F4, but got Obj
		//IL_12d1: Expected native int or pointer, but got VT
		//IL_12fa: Expected F4, but got Obj
		//IL_12f5: Expected native int or pointer, but got VT
		//IL_1309: Expected I4, but got VT
		//IL_1317: Expected I, but got Obj
		//IL_132d: Expected Obj, but got I
		//IL_04ac: Expected F4, but got Obj
		//IL_04a7: Expected native int or pointer, but got VT
		//IL_04be: Expected F4, but got I4
		//IL_04b9: Expected native int or pointer, but got VT
		//IL_04cb: Expected Obj, but got F4
		//IL_04e7: Expected Obj, but got F4
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0e: Expected Obj, but got Unknown
		//IL_0eb5: Expected Obj, but got I4
		//IL_0ebf: Unsupported input type for neg.
		//IL_0ebf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec4: Expected Obj, but got Unknown
		//IL_0ed1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed6: Expected Obj, but got Unknown
		//IL_0eef: Expected Obj, but got I
		//IL_0eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f04: Expected Obj, but got Unknown
		//IL_0f50: Expected F4, but got Obj
		//IL_0f4b: Expected native int or pointer, but got VT
		//IL_0f65: Expected F4, but got I
		//IL_0f60: Expected native int or pointer, but got VT
		//IL_0243: Expected F4, but got Obj
		//IL_023e: Expected native int or pointer, but got VT
		//IL_0258: Expected F4, but got I
		//IL_0253: Expected native int or pointer, but got VT
		//IL_0fe6: Expected F4, but got Obj
		//IL_0fe1: Expected native int or pointer, but got VT
		//IL_0ff3: Expected Obj, but got VT
		//IL_1000: Expected F4, but got Obj
		//IL_0ffb: Expected native int or pointer, but got VT
		//IL_1012: Expected F4, but got I
		//IL_100d: Expected native int or pointer, but got VT
		//IL_1026: Expected I4, but got Obj
		//IL_04f9: Expected F4, but got Obj
		//IL_04f4: Expected native int or pointer, but got VT
		//IL_050b: Expected F4, but got I4
		//IL_0506: Expected native int or pointer, but got VT
		//IL_0518: Expected Obj, but got F4
		//IL_0294: Expected I, but got Obj
		//IL_054c: Expected I, but got Obj
		//IL_135a: Expected Obj, but got I
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_065c: Expected F4, but got Obj
		//IL_0657: Expected native int or pointer, but got VT
		//IL_0671: Expected F4, but got I
		//IL_066c: Expected native int or pointer, but got VT
		//IL_067e: Expected Obj, but got F4
		//IL_0696: Expected I, but got Obj
		//IL_06ac: Expected Obj, but got I
		//IL_06d7: Expected I, but got Obj
		//IL_11f7: Expected Obj, but got I
		//IL_1221: Expected F4, but got Obj
		//IL_121c: Expected native int or pointer, but got VT
		//IL_1238: Expected VT, but got I4
		//IL_0744: Expected VT, but got Obj
		//IL_0751: Expected F4, but got Obj
		//IL_074c: Expected native int or pointer, but got VT
		//IL_0763: Expected F4, but got I
		//IL_075e: Expected native int or pointer, but got VT
		//IL_0774: Expected Ref, but got VT
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected Obj, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected Obj, but got Unknown
		//IL_0811: Expected VT, but got Obj
		//IL_0866: Expected VT, but got Obj
		//IL_08aa: Expected I, but got Obj
		//IL_08c0: Expected Obj, but got I
		//IL_10c9: Expected F4, but got Obj
		//IL_10c4: Expected native int or pointer, but got VT
		//IL_10de: Expected F4, but got I
		//IL_10d9: Expected native int or pointer, but got VT
		//IL_10eb: Expected VT, but got Obj
		//IL_1111: Expected F4, but got Obj
		//IL_110c: Expected native int or pointer, but got VT
		//IL_1126: Expected F4, but got I
		//IL_1121: Expected native int or pointer, but got VT
		//IL_0976: Expected I, but got Obj
		//IL_098c: Expected Obj, but got I
		//IL_08eb: Expected I, but got Obj
		//IL_116d: Expected F4, but got Obj
		//IL_0a85: Expected I, but got Obj
		//IL_0a9b: Expected Obj, but got I
		//IL_09b7: Expected I, but got Obj
		//IL_09e9: Expected F4, but got Obj
		//IL_09e4: Expected native int or pointer, but got VT
		//IL_09fe: Expected F4, but got I
		//IL_09f9: Expected native int or pointer, but got VT
		//IL_0a0c: Expected I, but got Obj
		//IL_0a22: Expected Obj, but got I
		//IL_0af8: Expected F4, but got Obj
		//IL_0af3: Expected native int or pointer, but got VT
		//IL_0b0d: Expected F4, but got I
		//IL_0b08: Expected native int or pointer, but got VT
		//IL_0ac6: Expected I, but got Obj
		//IL_0a4d: Expected I, but got Obj
		Transform transform = default;
		object obj = transform + 376;
		obj = 0;
		_ = 0;
		object obj2 = transform + 88;
		obj2 = 0;
		object obj3 = transform + 360;
		obj3 = 0;
		_ = 0;
		object obj4 = transform + 344;
		obj4 = 0;
		_ = 0;
		object obj5 = transform + 332;
		obj5 = 0;
		_ = 0;
		object obj6 = transform + 320;
		obj6 = 0;
		_ = 0;
		object obj7 = transform + 304;
		obj7 = 0;
		_ = 0;
		string text = (string)(transform + 288);
		text = (string)0;
		text.m_stringLength = 0;
		object obj8 = transform + 80;
		obj8 = 0;
		object obj9 = transform + 72;
		obj9 = 0;
		object obj10 = transform - -64;
		obj10 = 0;
		OnWillRenderObject();
		if (mBlock != null)
		{
			mRenderer.enabled = (byte)(int)mBlock != 0;
		}
		if (onRender != null)
		{
			bool flag = (object)mDynamicMat == null;
			bool flag2 = !flag;
			Material result = mDynamicMat;
			if (!flag2)
			{
				object obj11 = this - -64;
				result = (Material)obj11;
			}
			onRender.EndInvoke((IAsyncResult)result);
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v346 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Matrix4x4 matrix4x = (Matrix4x4)(transform + 112);
		PlayerConnection playerConnection = (PlayerConnection)(transform + 96);
		Transform transform2 = (Transform)(transform + 48);
		Transform transform3 = (Transform)(transform + 256);
		object obj13 = transform + 240;
		object obj14 = transform + 224;
		Transform transform4 = (Transform)(transform + 208);
		object obj15 = transform + 192;
		object obj16 = transform + 176;
		object obj17 = transform + 164;
		object obj18 = transform + 152;
		object obj19 = transform + 140;
		object obj20 = transform + 128;
		object obj21 = transform + 272;
		object obj22 = transform + 40;
		object obj23 = transform + 32;
		object obj24 = transform + 24;
		object obj25 = transform + 16;
		if (mDynamicMat != null || mClipCount == 0)
		{
			return;
		}
		if (~(mTextureClip ? 1u : 0u) == 0)
		{
			object obj26 = panel + 180;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj26;
			Matrix4x4 matrix4x2 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S1_v291+8]");
			((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
			obj = matrix4x.m00;
			_ = matrix4x.m20;
			UIPanel uIPanel = panel;
			playerConnection = (PlayerConnection)uIPanel.mClipSoftness;
			obj2 = 1000f;
			_ = 1000f;
			transform2 = (Transform)(object)playerConnection;
			if (System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
			{
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
				Matrix4x4 matrix4x3 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
				playerConnection = playerConnection;
				float num3 = matrix4x.m20 / (float)playerConnection;
				obj2 = num3;
			}
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)playerConnection;
			if (matrix4x.m10 > 0f)
			{
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
				Matrix4x4 matrix4x4 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
				playerConnection = playerConnection;
				float num4 = matrix4x.m30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v54 (UnityEngine.Networking.PlayerConnection.PlayerConnection)+4]");
				float num5 = num4 / 0f;
			}
			nint num6 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S1_v311 (Il2CppClass<UIDrawCall>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num7 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S1_v322 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj28 = ClipRange + 16;
			playerConnection = (PlayerConnection)obj;
			PlayerConnection playerConnection2 = playerConnection;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)playerConnection2).m_CachedPtr = (IntPtr)0;
			transform2 = (Transform)obj;
			Transform transform5 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			transform3 = (Transform)obj;
			Transform transform6 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
			obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			transform4 = (Transform)obj;
			Transform transform7 = transform4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			obj15 = 0;
			_ = 0;
			object obj29 = 0 - playerConnection;
			object obj30 = obj29 / (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			obj15 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v58 (UnityEngine.Transform)+4]");
			object obj31 = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v60+C]");
			object obj32 = obj31 / 0;
			float num8 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v62+8]");
			float num9 = num8 / 0f;
			float num10 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v64 (UnityEngine.Transform)+C]");
			float num11 = num10 / 0f;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj15;
			Matrix4x4 matrix4x5 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v66+8]");
			((Matrix4x4*)(nint)matrix4x5)->m20 = 0f;
			mDynamicMat.SetMatrix((string)obj28, matrix4x);
			Color color = ((Material)(object)"_ClipTex").GetColor((string)(object)clipTexture);
			return;
		}
		UIPanel uIPanel2 = panel;
		if (~(mLegacyShader ? 1u : 0u) == 0)
		{
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)uIPanel2.mClipSoftness;
			object obj33 = panel + 180;
			playerConnection = (PlayerConnection)obj33;
			PlayerConnection playerConnection3 = playerConnection;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S1_v204+8]");
			((UnityEngine.Object)playerConnection3).m_CachedPtr = (IntPtr)0;
			text = (string)(object)playerConnection;
			text.m_stringLength = (int)(nint)((UnityEngine.Object)playerConnection).m_CachedPtr;
			transform2 = (Transform)(object)playerConnection;
			((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)playerConnection).m_CachedPtr;
			transform3 = (Transform)(object)text;
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)text.m_stringLength;
			obj13 = text;
			_ = text.m_stringLength;
			obj14 = text;
			_ = text.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v60+4]");
			object obj34 = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v62+C]");
			object obj35 = obj34 / 0;
			object obj36 = 0 - transform2;
			object obj37 = obj36 / (nint)((UnityEngine.Object)transform3).m_CachedPtr;
			obj8 = obj37;
			transform4 = (Transform)(object)text;
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)text.m_stringLength;
			obj15 = text;
			_ = text.m_stringLength;
			float num12 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v66+C]");
			float num13 = num12 / 0f;
			float num14 = 1f / (float)(nint)((UnityEngine.Object)transform4).m_CachedPtr;
			obj9 = num14;
			obj10 = 1000f;
			_ = 1000f;
			transform = (Transform)matrix4x.m00;
			if (System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
			{
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)text;
				((Matrix4x4*)(nint)matrix4x)->m20 = text.m_stringLength;
				playerConnection = (PlayerConnection)matrix4x.m00;
				float num15 = matrix4x.m20 / (float)playerConnection;
				obj10 = num15;
			}
			((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x.m00;
			if (matrix4x.m10 > 0f)
			{
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)text;
				((Matrix4x4*)(nint)matrix4x)->m20 = text.m_stringLength;
				playerConnection = (PlayerConnection)matrix4x.m00;
				float num16 = matrix4x.m30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v54 (UnityEngine.Networking.PlayerConnection.PlayerConnection)+4]");
				float num17 = num16 / 0f;
			}
			obj23 = obj8;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj23;
			mDynamicMat.mainTextureScale = (Vector2)matrix4x;
			obj24 = obj9;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj24;
			mDynamicMat.renderQueue = (int)matrix4x;
			nint num18 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ S1_v262 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj38 = (nint)0 & (nint)0x200;
			if (obj38 != null)
			{
				nint num19 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ S1_v271 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj25 = obj10;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj25;
			playerConnection.RegisterConnection((UnityAction<int>)matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)playerConnection;
			((Matrix4x4*)(nint)matrix4x)->m20 = (nint)((UnityEngine.Object)playerConnection).m_CachedPtr;
			mDynamicMat.SetVector((int)"_ClipSharpness", (Vector4)matrix4x);
			return;
		}
		ComputeShader computeShader = (ComputeShader)(object)panel;
		object obj47 = default;
		while (true)
		{
			nint num20 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ S0_v103 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			if (obj39 != null)
			{
				nint num21 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ S0_v244 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (computeShader.FindKernel(null) == 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ L6_v5 (UnityEngine.ComputeShader)+D8]");
			bool flag3;
			if ((nint)0 == 3)
			{
				flag3 = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ L6_v5 (UnityEngine.ComputeShader)+D8]");
				flag3 = (nint)0 == 1;
			}
			if (!flag3)
			{
				goto IL_134a;
			}
			object obj40 = computeShader + 180;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj40;
			Matrix4x4 matrix4x6 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S1_v63+8]");
			((Matrix4x4*)(nint)matrix4x6)->m20 = 0f;
			obj3 = matrix4x.m00;
			_ = matrix4x.m20;
			nint num22 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S0_v124 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj41 = (nint)0 & (nint)0x200;
			if (obj41 != null)
			{
				nint num23 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ S0_v236 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (computeShader.FindKernel((string)(object)panel) != 0)
			{
				Camera anchorCamera = ((UIRect)(object)computeShader).anchorCamera;
				Camera anchorCamera2 = panel.anchorCamera;
				transform2.position = (Vector3)anchorCamera2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)transform2;
				((Matrix4x4*)(nint)matrix4x)->m20 = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				transform3.Internal_LookAt_Injected(ref *(Vector3*)anchorCamera, ref *(Vector3*)matrix4x);
				obj4 = transform3;
				_ = ((UnityEngine.Object)transform3).m_CachedPtr;
				obj13 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+8]");
				_ = 0;
				object obj42 = obj3 - obj13;
				obj3 = obj42;
				object obj43 = obj3 + 4;
				obj14 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+8]");
				_ = 0;
				object obj44 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v62+4]");
				object obj45 = obj44 - 0;
				obj43 = obj45;
				Camera anchorCamera3 = panel.anchorCamera;
				transform4.rotation = (Quaternion)anchorCamera3;
				obj7 = transform4;
				_ = ((UnityEngine.Object)transform4).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
				obj5 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v66+8]");
				_ = 0;
				Camera anchorCamera4 = ((UIRect)(object)computeShader).anchorCamera;
				transform.rotation = (Quaternion)anchorCamera4;
				obj7 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
				obj17 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
				_ = 0;
				nint num24 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ S0_v173 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj46 = (nint)0 & (nint)0x200;
				if (obj46 != null)
				{
					nint num25 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ S0_v232 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				playerConnection = (PlayerConnection)obj16;
				PlayerConnection playerConnection4 = playerConnection;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v68+8]");
				((UnityEngine.Object)playerConnection4).m_CachedPtr = (IntPtr)0;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj17;
				Matrix4x4 matrix4x7 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v70+8]");
				((Matrix4x4*)(nint)matrix4x7)->m20 = 0f;
				Quaternion quaternion = Quaternion.FromToRotation((Vector3)playerConnection, (Vector3)matrix4x);
				obj6 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v72+8]");
				_ = 0;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj18;
				Matrix4x4 matrix4x8 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v72+8]");
				((Matrix4x4*)(nint)matrix4x8)->m20 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B70F");
				obj6 = obj47;
				playerConnection = (PlayerConnection)obj6;
				PlayerConnection playerConnection5 = playerConnection;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
				((UnityEngine.Object)playerConnection5).m_CachedPtr = (IntPtr)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B70F");
				obj19 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B70F");
				obj20 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
				_ = 0;
				nint num26 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ S0_v198 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj48 = (nint)0 & (nint)0x200;
				if (obj48 != null)
				{
					nint num27 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ S0_v229 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num28 = Math.Abs((float)obj20);
				if (!(num28 > 0.001f))
				{
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
					Matrix4x4 matrix4x9 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
					((Matrix4x4*)(nint)matrix4x9)->m20 = 0f;
					nint num29 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ S1_v191 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj49 = (nint)0 & (nint)0x200;
					if (obj49 != null)
					{
						nint num30 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1042 @ S1_v196 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num31 = Math.Abs(matrix4x.m10);
					if (!(num31 > 0.001f))
					{
						goto IL_0aeb;
					}
				}
				nint num32 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ S0_v214 (Il2CppClass<UnityEngine.Debug>)+BA]");
				object obj50 = (nint)0 & (nint)0x200;
				if (obj50 != null)
				{
					nint num33 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ S0_v220 (Il2CppClass<UnityEngine.Debug>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Debug.LogWarningFormat("Panel can only be clipped properly if X and Y rotation is left at 0", (object[])(object)panel);
				goto IL_0aeb;
			}
			float duration = 0f;
			goto IL_11d2;
			IL_0aeb:
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Matrix4x4 matrix4x10 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
			((Matrix4x4*)(nint)matrix4x10)->m20 = 0f;
			duration = matrix4x.m20;
			goto IL_11d2;
			IL_11d2:
			obj21 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ L6_v5 (UnityEngine.ComputeShader)+EC]");
			obj22 = 0;
			playerConnection = (PlayerConnection)obj21;
			PlayerConnection playerConnection6 = playerConnection;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v78+8]");
			((UnityEngine.Object)playerConnection6).m_CachedPtr = (IntPtr)0;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj22;
			((RouteCollection)(object)this).DrawBounds((Bounds)0, (Transform)(object)playerConnection, (Color)matrix4x, duration);
			goto IL_134a;
			IL_134a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ L6_v5 (UnityEngine.ComputeShader)+12C]");
			computeShader = (ComputeShader)0;
		}
	}

	private void OnEnable()
	{
		//IL_04aa: Expected I, but got Obj
		//IL_04c0: Expected Obj, but got I
		//IL_0600: Expected I, but got Obj
		//IL_0616: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0641: Expected I, but got Obj
		//IL_0657: Expected Obj, but got I
		//IL_0158: Expected I, but got Obj
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_056d: Expected I, but got Obj
		//IL_0583: Expected Obj, but got I
		//IL_0301: Expected I, but got Obj
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got I4
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0249: Expected I, but got Obj
		//IL_025f: Expected Obj, but got I
		//IL_027c: Expected I, but got Obj
		//IL_010b: Expected I, but got Obj
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_0506: Expected Obj, but got I
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03f2: Expected I, but got Obj
		//IL_0408: Expected Obj, but got I
		//IL_0425: Expected I, but got Obj
		//IL_0298: Expected I, but got Obj
		//IL_02c8: Expected I, but got Obj
		//IL_0529: Expected Obj, but got I
		//IL_0441: Expected I, but got Obj
		//IL_0471: Expected I, but got Obj
		//IL_02ee: Expected I, but got Obj
		//IL_0497: Expected I, but got Obj
		nint num = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIDrawCall>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v122 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (dx9BugWorkaround == -1)
		{
			string dataPath = Application.dataPath;
			int num3;
			if ((nint)dataPath == 2)
			{
				int frameCount = Time.frameCount;
				if (frameCount > 39)
				{
					num3 = 0;
				}
				else
				{
					int graphicsShaderLevel = SystemInfo.GetGraphicsShaderLevel();
					bool flag = ((string)graphicsShaderLevel).EndsWith("Direct3D");
					num3 = (flag ? 1 : 0);
				}
			}
			else
			{
				num3 = 0;
			}
			nint num4 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v100 (Il2CppClass<UIDrawCall>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v106 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			dx9BugWorkaround = num3;
		}
		nint num6 = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<UIDrawCall>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v89 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (ClipRange == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj5 = default;
			object obj4 = obj5 + 16;
			Shader shader = ((Material)(object)"_ClipRange0").shader;
			obj4 = shader;
			object obj6 = obj5 + 20;
			Shader shader2 = ((Material)(object)"_ClipRange1").shader;
			obj6 = shader2;
			object obj7 = obj5 + 24;
			Shader shader3 = ((Material)(object)"_ClipRange2").shader;
			obj7 = shader3;
			object obj8 = obj5 + 28;
			Shader shader4 = ((Material)(object)"_ClipRange4").shader;
			obj8 = shader4;
			nint num8 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v76 (Il2CppClass<UIDrawCall>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			bool flag2 = obj9 == null;
			nint num9 = (nint)typeof(UIDrawCall);
			if (!flag2)
			{
				nint num10 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v83 (Il2CppClass<UIDrawCall>)+74]");
				bool flag3 = (nint)0 == 0;
				bool flag4 = !flag3;
				num9 = (nint)typeof(UIDrawCall);
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num9 = (nint)typeof(UIDrawCall);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ L0_v15 (Il2CppClass<UIDrawCall>)+5C]");
			object obj10 = (nint)0 + (nint)16;
			obj10 = obj5;
		}
		nint num11 = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v26 (Il2CppClass<UIDrawCall>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v59 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (ClipArgs != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj13 = default;
		object obj12 = obj13 + 16;
		Shader shader5 = ((Material)(object)"_ClipArgs0").shader;
		obj12 = shader5;
		object obj14 = obj13 + 20;
		Shader shader6 = ((Material)(object)"_ClipArgs1").shader;
		obj14 = shader6;
		object obj15 = obj13 + 24;
		Shader shader7 = ((Material)(object)"_ClipArgs2").shader;
		obj15 = shader7;
		object obj16 = obj13 + 28;
		Shader shader8 = ((Material)(object)"_ClipArgs3").shader;
		obj16 = shader8;
		nint num13 = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v46 (Il2CppClass<UIDrawCall>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		bool flag5 = obj17 == null;
		nint num14 = (nint)typeof(UIDrawCall);
		if (!flag5)
		{
			nint num15 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v53 (Il2CppClass<UIDrawCall>)+74]");
			bool flag6 = (nint)0 == 0;
			bool flag7 = !flag6;
			num14 = (nint)typeof(UIDrawCall);
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num14 = (nint)typeof(UIDrawCall);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ L0_v11 (Il2CppClass<UIDrawCall>)+5C]");
		object obj18 = (nint)0 + (nint)20;
		obj18 = obj13;
	}

	private void OnDisable()
	{
		mRebuildMat = true;
	}

	private void OnDestroy()
	{
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_014b: Expected Obj, but got I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_015f: Expected Obj, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got I4
		//IL_0181: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01d3: Expected Obj, but got I4
		//IL_00ba: Expected I, but got Obj
		depthStart = int.MaxValue;
		depthEnd = int.MinValue;
		object obj = this + 28;
		obj = 0;
		object obj2 = this + 24;
		obj2 = 0;
		object obj3 = this - -64;
		obj3 = 0;
		object obj4 = this + 68;
		obj4 = 0;
		object obj5 = this + 32;
		obj5 = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mRenderer).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
		}
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v22 (Il2CppClass<NGUITools>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v29 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.Broadcast((string)(object)mDynamicMat);
		object obj8 = this + 96;
		obj8 = 0;
	}

	public static UIDrawCall Create(UIPanel panel, Material mat, Texture tex, Shader shader)
	{
		//IL_0152: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0193: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I
		//IL_022b: Expected VT, but got Obj
		//IL_013a: Expected Obj, but got I4
		//IL_0080: Expected I, but got Obj
		//IL_01dd: Expected Obj, but got VT
		//IL_01ea: Expected I4, but got Obj
		//IL_01ea: Expected Obj, but got VT
		//IL_00dc: Expected Obj, but got I
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got VT
		//IL_012c: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((((ComputeShader)(object)mat).FindKernel((string)null) == 0) ? null : ((UIAtlas)(object)mat).GetRandomSprite((string)(object)tex));
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_0021_00210 val = (_0021_00210)NGUITools.Draw<T>((string)(object)panel, (NGUITools.OnInitFunc<T>)(object)shader);
		object obj6;
		if (text != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v12 (System.String)+20]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v12 (System.String)+1C]");
			object obj3 = num5 | 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v12 (System.String)+24]");
			object obj4 = obj3 | 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v12 (System.String)+28]");
			object obj5 = obj4 | 0;
			if (obj5 != null)
			{
				obj6 = 1;
				goto IL_01c6;
			}
		}
		obj6 = 0;
		goto IL_01c6;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		((UISprite)val).spriteName = (string)(object)mat;
		((UISprite)val).fillCenter = (byte)(int)tex != 0;
		return (UIDrawCall)val;
	}

	private unsafe static UIDrawCall Create(string name, UIPanel pan, Material mat, Texture tex, Shader shader)
	{
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected I4, but got Unknown
		//IL_0020: Expected I4, but got Obj
		//IL_002c: Expected Obj, but got I4
		//IL_0742: Expected Obj, but got I
		//IL_074f: Expected I4, but got Obj
		//IL_009f: Expected Obj, but got I4
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected Obj, but got Unknown
		//IL_07be: Expected Obj, but got I4
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected Obj, but got Unknown
		//IL_07d5: Expected Obj, but got I4
		//IL_0814: Expected Obj, but got I4
		//IL_0471: Expected I4, but got Obj
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected I4, but got Unknown
		//IL_0493: Expected I4, but got Obj
		//IL_0422: Expected I, but got Obj
		//IL_033d: Expected I4, but got Obj
		//IL_04a9: Expected Obj, but got I4
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_045a: Expected Obj, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Expected Obj, but got Unknown
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0525: Expected I4, but got Obj
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_036a: Expected I, but got Obj
		//IL_0380: Expected Obj, but got I
		//IL_03ab: Expected I, but got Obj
		object obj = default;
		CallingConvention callingConvention = (CallingConvention)(obj + 4);
		if ((nint)pan == -1)
		{
			return null;
		}
		int num = name.IndexOf((string)(object)mat, (StringComparison)pan);
		UIPanel uIPanel = (UIPanel)num;
		if (num == -1)
		{
			return null;
		}
		bool flag = num >= 6;
		bool flag2 = !flag;
		int num2 = num;
		if (!flag2)
		{
			char[] array = (char[])(num - 5);
			char[] array2 = array;
			while ((nint)array2 >= 0)
			{
				string[] array3 = name.Split(array2);
				object obj2 = array3 & 0xFFFF;
				if ((nint)obj2 == 91)
				{
					char[] separator = (char[])(array2 + 1);
					string[] array4 = name.Split(separator);
					object obj3 = array4 & 0xFFFF;
					if ((nint)obj3 == 117)
					{
						char[] separator2 = (char[])(array2 + 2);
						string[] array5 = name.Split(separator2);
						object obj4 = array5 & 0xFFFF;
						if ((nint)obj4 == 114)
						{
							char[] separator3 = (char[])(array2 + 3);
							string[] array6 = name.Split(separator3);
							object obj5 = array6 & 0xFFFF;
							if ((nint)obj5 == 108)
							{
								char[] separator4 = (char[])(array2 + 4);
								string[] array7 = name.Split(separator4);
								object obj6 = array7 & 0xFFFF;
								if ((nint)obj6 == 61)
								{
									object obj7 = (nint)((UnityEngine.Object)mat).m_CachedPtr + pan;
									uIPanel = (UIPanel)obj7;
									nint num3 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v153 (Il2CppClass<NGUIText>)+BA]");
									object obj8 = (nint)0 & (nint)0x200;
									if (obj8 != null)
									{
										nint num4 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v159 (Il2CppClass<NGUIText>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									return Create(name, pan, mat, tex, shader);
								}
							}
						}
					}
					char[] separator5 = (char[])(array2 + 1);
					string[] array8 = name.Split(separator5);
					object obj9 = array8 & 0xFFFF;
					if ((nint)obj9 == 47)
					{
						char[] separator6 = (char[])(array2 + 2);
						string[] array9 = name.Split(separator6);
						object obj10 = array9 & 0xFFFF;
						if ((nint)obj10 == 117)
						{
							char[] separator7 = (char[])(array2 + 3);
							string[] array10 = name.Split(separator7);
							object obj11 = array10 & 0xFFFF;
							if ((nint)obj11 == 114)
							{
								char[] separator8 = (char[])(array2 + 4);
								string[] array11 = name.Split(separator8);
								object obj12 = array11 & 0xFFFF;
								if ((nint)obj12 == 108)
								{
									break;
								}
							}
						}
					}
				}
				char[] array12 = (char[])(array2 - 1);
				array2 = array12;
			}
			num2 = (int)pan;
		}
		int num5 = (int)((nint)((UnityEngine.Object)mat).m_CachedPtr + num2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		obj = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		int num6 = name.IndexOf((string)(object)unmanagedFunctionPointerAttribute, num5);
		bool flag3 = num6 == -1;
		bool flag4 = !flag3;
		int num7 = num6;
		if (!flag4)
		{
			nint num8 = (nint)name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v92 (Il2CppClass<System.String>)+8]");
			num7 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		string text = default;
		object obj13 = text + 16;
		obj13 = 47;
		object obj14 = text + 18;
		obj14 = 32;
		int num9 = name.IndexOf(text, num5);
		bool flag5 = num9 == -1;
		bool flag6 = num9 == num5;
		object obj15 = flag5 | flag6;
		if (obj15 != null)
		{
			object obj16 = (nint)((UnityEngine.Object)mat).m_CachedPtr + pan;
			uIPanel = (UIPanel)obj16;
			return (UIDrawCall)1;
		}
		string text2 = name.InternalSubString(0, (int)pan);
		int length = num7 - pan;
		string text3 = name.InternalSubString((int)pan, length);
		string text4 = name.Trim((char[])num7);
		int length2 = num9 - num5;
		string text5 = name.InternalSubString(num5, length2);
		bool flag7 = (object)tex == null || ((UnityEngine.Object)tex).m_CachedPtr == (IntPtr)0;
		bool flag8 = !flag7;
		bool flag9 = !flag8;
		string text6 = text2;
		if (!flag9)
		{
			string text7 = string.ConcatArray((string[])(object)text2, (int)tex);
			text6 = text7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private static UIDrawCall Create(string name)
	{
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v32 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L0 (System.String)+60]");
		NGUITools.Broadcast((string)0);
		((UIDrawCall)(object)name).UpdateMaterials();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L0 (System.String)+60]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L0 (System.String)+70]");
		((Material)num3).EnableKeyword((string)0);
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L0 (System.String)+5C]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L0 (System.String)+60]");
		return (UIDrawCall)0;
	}

	public static void ClearAll()
	{
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Vector2[] mTempPos = default;
		UIBasicSprite.mTempPos = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num = (nint)typeof(UIBasicSprite);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v15 (Il2CppClass<UIBasicSprite>)+5C]");
		object obj = (nint)0 + (nint)4;
		object obj2 = default;
		obj = obj2;
	}

	public static void ReleaseAll()
	{
		//IL_02c1: Expected I, but got Obj
		//IL_02d7: Expected Obj, but got I
		//IL_040f: Expected I, but got Obj
		//IL_0425: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_026b: Expected I, but got Obj
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_0362: Expected I, but got Obj
		//IL_0378: Expected Obj, but got I
		//IL_0079: Expected I, but got Obj
		//IL_00c6: Expected I, but got Obj
		//IL_0120: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_0205: Expected I, but got Obj
		//IL_0194: Expected I, but got Obj
		RuntimePlatform platform = Application.platform;
		nint num = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<UIDrawCall>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v90 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BetterList<UIDrawCall> betterList = mActiveList;
		int num3 = betterList.size;
		bool flag;
		while (true)
		{
			nint num4 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v18 (Il2CppClass<UIDrawCall>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			flag = obj2 != null;
			if (num3 < 1)
			{
				break;
			}
			if (flag)
			{
				nint num5 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v84 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UIDrawCall> betterList2 = mActiveList;
			object obj3 = betterList2.buffer + 16;
			int num6 = num3 - 1;
			int num7 = num6 << 2;
			object obj4 = obj3 + num7;
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v80 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)obj4))
			{
				string text = ((Component)obj4).tag;
				nint num10 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v59 (Il2CppClass<NGUITools>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				bool flag2 = obj6 == null;
				if (platform != RuntimePlatform.OSXEditor)
				{
					if (!flag2)
					{
						nint num11 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v76 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					NGUITools.SetActiveChildren((GameObject)(object)text, state: false);
				}
				else
				{
					if (!flag2)
					{
						nint num12 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v68 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					NGUITools.Broadcast(text);
				}
			}
			num3 = num6;
		}
		if (flag)
		{
			nint num13 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v31 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BetterList<UIDrawCall> betterList3 = mActiveList;
		betterList3.size = 0;
	}

	public static void ReleaseInactive()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIDrawCall>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ReleaseAll();
		UIDrawCall._002Ecctor();
	}

	public static int Count(UIPanel panel)
	{
		//IL_03e7: Expected I, but got Obj
		//IL_03fd: Expected Obj, but got I
		//IL_027f: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0292: Expected I, but got Obj
		//IL_02a8: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0489: Expected I, but got Obj
		//IL_049f: Expected Obj, but got I
		//IL_037b: Expected I, but got Obj
		//IL_0391: Expected Obj, but got I
		//IL_04d2: Expected I4, but got Obj
		//IL_02d3: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0320: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_01e8: Expected I, but got Obj
		//IL_01fe: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_045b: Expected I4, but got Obj
		//IL_01c8: Expected I4, but got Obj
		//IL_0229: Expected I, but got Obj
		_00210[] array;
		GameObject gameObject = default;
		while (true)
		{
			nint num = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v6 (Il2CppClass<UIDrawCall>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v93 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UIDrawCall> betterList = mInactiveList;
			if (betterList.size >= 1)
			{
				nint num3 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v47 (Il2CppClass<UIDrawCall>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UIDrawCall);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v87 (Il2CppClass<UIDrawCall>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				array = (_00210[])(object)((BetterList<>)(object)mInactiveList).ToArray();
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v83 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)array).FindKernel((string)null) == 0)
				{
					continue;
				}
				nint num7 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v64 (Il2CppClass<UIDrawCall>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UIDrawCall);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v77 (Il2CppClass<UIDrawCall>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			gameObject.layer = (int)panel;
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UnityEngine.UnitySynchronizationContext)(object)gameObject).Exec();
			UIDrawCall uIDrawCall = gameObject.AddComponent<UIDrawCall>();
			nint num11 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v28 (Il2CppClass<UIDrawCall>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v36 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mActiveList.Add(uIDrawCall);
			return (int)uIDrawCall;
		}
		mActiveList.Add((UIDrawCall)(object)array);
		if ((object)panel != null)
		{
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)array, (byte)(int)panel != 0);
		}
		string go = ((Component)(object)array).tag;
		nint num13 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v22 (Il2CppClass<NGUITools>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num14 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v27 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.SetActiveChildren((GameObject)(object)go, state: true);
		return (int)array;
	}

	public static void Destroy(UIDrawCall dc)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.Broadcast((string)(object)dc.mMesh);
		object obj2 = dc + 84;
		obj2 = 0;
	}

	public static void MoveToScene(Scene scene)
	{
		//IL_039f: Expected I, but got Obj
		//IL_03b5: Expected Obj, but got I
		//IL_04eb: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I4
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_0080: Expected Obj, but got VT
		//IL_0092: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I
		//IL_045d: Expected Obj, but got VT
		//IL_026a: Expected I, but got Obj
		//IL_03ef: Expected Obj, but got VT
		//IL_03fc: Expected Obj, but got VT
		//IL_040e: Expected I, but got Obj
		//IL_0424: Expected Obj, but got I
		//IL_00d3: Expected I, but got Obj
		//IL_02b2: Expected Obj, but got VT
		//IL_02c4: Expected I, but got Obj
		//IL_02da: Expected Obj, but got I
		//IL_01b7: Expected I, but got Obj
		//IL_0496: Expected I, but got Obj
		//IL_04ac: Expected Obj, but got I
		//IL_0204: Expected I, but got Obj
		//IL_04d7: Expected Obj, but got VT
		//IL_0305: Expected I, but got Obj
		//IL_0352: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v65 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)scene))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [scene @ L0 (UnityEngine.SceneManagement.Scene)+80]");
		if ((nint)0 != 0)
		{
			string t = ((Component)scene).tag;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v41 (Il2CppClass<NGUITools>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v46 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUITools.DestroyChildren((Transform)(object)t);
			return;
		}
		object obj3 = scene + 124;
		obj3 = 0;
		RuntimePlatform platform = Application.platform;
		nint num5 = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v8 (Il2CppClass<UIDrawCall>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		bool flag = obj4 != null;
		if (platform == RuntimePlatform.OSXEditor)
		{
			if (flag)
			{
				nint num6 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v57 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = mActiveList.Remove((UIDrawCall)scene);
			string funcName = ((Component)scene).tag;
			nint num7 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v30 (Il2CppClass<NGUITools>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v35 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUITools.Broadcast(funcName);
			return;
		}
		if (flag)
		{
			nint num9 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v43 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!mActiveList.Remove((UIDrawCall)scene))
		{
			return;
		}
		string go = ((Component)scene).tag;
		nint num10 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v15 (Il2CppClass<NGUITools>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num11 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v23 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.SetActiveChildren((GameObject)(object)go, state: false);
		nint num12 = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v29 (Il2CppClass<UIDrawCall>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num13 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v37 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mInactiveList.Add((UIDrawCall)scene);
		_ = 1;
	}

	public UIDrawCall()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected Obj, but got Unknown
		//IL_0533: Expected I, but got Obj
		//IL_0549: Expected Obj, but got I
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_05f0: Expected I, but got Obj
		//IL_0606: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I
		//IL_02a4: Expected I, but got Obj
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_0387: Expected Obj, but got I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0454: Expected Obj, but got I
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected Obj, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		nint num = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<UIDrawCall>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v173 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 16;
		object obj6 = obj2 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A12D");
		BetterList<UIDrawCall> betterList = default;
		IEnumerator<UIDrawCall> enumerator = betterList.GetEnumerator();
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj6 = this;
			obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj8 = obj3 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj3 + obj10;
		obj11 = 50;
		object obj12 = 0;
		if (enumerator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj3 + obj13;
			if ((nint)obj14 == 50)
			{
				object obj15 = obj3 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				goto IL_05e2;
			}
		}
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_05e2;
		IL_05e2:
		nint num3 = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v44 (Il2CppClass<UIDrawCall>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num4 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v116 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A12F");
		BetterList<UIDrawCall> betterList2 = default;
		IEnumerator<UIDrawCall> enumerator2 = betterList2.GetEnumerator();
		object obj18 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj18 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj2 = this;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj19 = obj3 + 4;
		object obj20 = obj19 + 1;
		obj19 = obj20;
		object obj21 = obj20 << 2;
		object obj22 = obj3 + obj21;
		obj22 = 100;
		if (enumerator2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = obj3 + obj23;
			if ((nint)obj24 == 100)
			{
				object obj25 = obj3 + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				return;
			}
		}
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	static UIDrawCall()
	{
		//IL_0221: Expected I, but got Obj
		//IL_0237: Expected Obj, but got I
		//IL_02f6: Expected I, but got Obj
		//IL_030c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01d4: Expected I, but got Obj
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_02a7: Expected I, but got Obj
		//IL_02bd: Expected Obj, but got I
		//IL_0079: Expected I, but got Obj
		//IL_00c6: Expected I, but got Obj
		//IL_0120: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_0161: Expected I, but got Obj
		nint num = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIDrawCall>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v66 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BetterList<UIDrawCall> betterList = mInactiveList;
		int num3 = betterList.size;
		bool flag;
		while (true)
		{
			nint num4 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v16 (Il2CppClass<UIDrawCall>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			flag = obj2 != null;
			if (num3 < 1)
			{
				break;
			}
			if (flag)
			{
				nint num5 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v60 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UIDrawCall> betterList2 = mInactiveList;
			object obj3 = betterList2.buffer + 16;
			int num6 = num3 - 1;
			int num7 = num6 << 2;
			object obj4 = obj3 + num7;
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)obj4))
			{
				string funcName = ((Component)obj4).tag;
				nint num10 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v17 (Il2CppClass<NGUITools>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num11 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v22 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.Broadcast(funcName);
			}
			num3 = num6;
		}
		if (flag)
		{
			nint num12 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v29 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BetterList<UIDrawCall> betterList3 = mInactiveList;
		betterList3.size = 0;
	}
}
