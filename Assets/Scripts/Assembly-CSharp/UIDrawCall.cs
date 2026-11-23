using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

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

	private static BetterList<UIDrawCall> mActiveList;

	private static BetterList<UIDrawCall> mInactiveList;

	[NonSerialized]
	public int widgetCount;

	[NonSerialized]
	public int depthStart = int.MaxValue;

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
	public BetterList<Vector3> verts;

	[NonSerialized]
	public BetterList<Vector3> norms;

	[NonSerialized]
	public BetterList<Vector4> tans;

	[NonSerialized]
	public BetterList<Vector2> uvs;

	[NonSerialized]
	public BetterList<Color32> cols;

	private Material mMaterial;

	private Texture mTexture;

	private Shader mShader;

	private int mClipCount;

	private Transform mTrans;

	private Mesh mMesh;

	private MeshFilter mFilter;

	private MeshRenderer mRenderer;

	private Material mDynamicMat;

	private int[] mIndices;

	private bool mRebuildMat;

	private bool mLegacyShader;

	private int mRenderQueue;

	private int mTriangles;

	[NonSerialized]
	public bool isDirty;

	[NonSerialized]
	private bool mTextureClip;

	public OnRenderCallback onRender;

	private const int maxIndexBufferCache = 10;

	private static List<int[]> mCache;

	private static int[] ClipRange;

	private static int[] ClipArgs;

	public static BetterList<UIDrawCall> list => mActiveList;

	public static BetterList<UIDrawCall> activeList => mActiveList;

	public static BetterList<UIDrawCall> inactiveList => mInactiveList;

	public int renderQueue
	{
		get
		{
			return mRenderQueue;
		}
		set
		{
			if (mRenderQueue != value)
			{
				mRenderQueue = value;
				if (mDynamicMat != null)
				{
					mDynamicMat.renderQueue = value;
				}
			}
		}
	}

	public int sortingOrder
	{
		get
		{
			if (mRenderer != null)
			{
				return mRenderer.sortingOrder;
			}
			return 0;
		}
		set
		{
			if (mRenderer != null)
			{
				int num = mRenderer.sortingOrder;
				if (num != value)
				{
					mRenderer.sortingOrder = value;
				}
			}
		}
	}

	public int finalRenderQueue
	{
		get
		{
			if (mDynamicMat != null)
			{
				return mDynamicMat.renderQueue;
			}
			return mRenderQueue;
		}
	}

	public Transform cachedTransform
	{
		get
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object result = this + 76;
			if (mTrans == null)
			{
				Transform transform = base.transform;
				mTrans = transform;
			}
			return (Transform)result;
		}
	}

	public Material baseMaterial
	{
		get
		{
			return mMaterial;
		}
		set
		{
			if (mMaterial != value)
			{
				mMaterial = value;
				mRebuildMat = true;
			}
		}
	}

	public Material dynamicMaterial => mDynamicMat;

	public Texture mainTexture
	{
		get
		{
			return mTexture;
		}
		set
		{
			mTexture = value;
			if (mDynamicMat != null)
			{
				mDynamicMat.mainTexture = value;
			}
		}
	}

	public Shader shader
	{
		get
		{
			return mShader;
		}
		set
		{
			if (mShader != value)
			{
				mShader = value;
				mRebuildMat = true;
			}
		}
	}

	public int triangles
	{
		get
		{
			if (mMesh != null)
			{
				return mTriangles;
			}
			return 0;
		}
	}

	public bool isClipped => mClipCount != 0;

	private unsafe void CreateMaterial()
	{
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected I4, but got Unknown
		//IL_015e: Expected Obj, but got I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0497: Expected Obj, but got I4
		//IL_04ce: Expected Obj, but got I
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected Obj, but got Unknown
		mLegacyShader = false;
		mTextureClip = false;
		int clipCount = panel.clipCount;
		mClipCount = clipCount;
		string text;
		if (!(mShader != null))
		{
			if (mMaterial != null)
			{
				Shader shader = mMaterial.shader;
				text = shader.name;
			}
			else
			{
				text = "Unlit/Transparent Colored";
			}
		}
		else
		{
			text = mShader.name;
		}
		string text2 = text.Replace("GUI/Text Shader", "Unlit/Text");
		bool flag = text2._stringLength < 3;
		string text3 = text2;
		if (!flag)
		{
			int index = text2._stringLength - 2;
			char c = text2.get_Chars(index);
			bool flag2 = c != ' ';
			text3 = text2;
			if (!flag2)
			{
				int index2 = text2._stringLength - 1;
				char c2 = text2.get_Chars(index2);
				object obj = c2 - 49;
				object obj2 = obj & 0xFFFF;
				bool flag3 = (nint)obj2 > 8;
				text3 = text2;
				if (!flag3)
				{
					int length = text2._stringLength - 2;
					string text4 = text2.Substring(0, length);
					text3 = text4;
				}
			}
		}
		int num = this + 72;
		string text5 = ((!text3.StartsWith("Hidden/")) ? text3 : text3.Substring(7));
		string text6 = text5.Replace(" (SoftClip)", string.Empty);
		string text7 = text6.Replace(" (TextureClip)", string.Empty);
		UIPanel uIPanel = panel;
		string text8;
		if (uIPanel.mClipping == Clipping.TextureMask)
		{
			mTextureClip = true;
			text8 = "Hidden/" + text7 + " (TextureClip)";
		}
		else
		{
			bool flag4 = ((int*)num)->m_value == 0;
			text8 = text7;
			if (!flag4)
			{
				string text9 = ((int*)num)->ToString();
				string text10 = "Hidden/" + text7 + " " + text9;
				Shader shader2 = Shader.Find(text10);
				this.shader = shader2;
				if (mShader == null)
				{
					string text11 = ((int*)num)->ToString();
					string text12 = text7 + " " + text11;
					Shader shader3 = Shader.Find(text12);
					this.shader = shader3;
				}
				if (!(mShader == null) || ((int*)num)->m_value != 1)
				{
					goto IL_0388;
				}
				mLegacyShader = true;
				text8 = text7 + " (SoftClip)";
			}
		}
		Shader shader4 = Shader.Find(text8);
		this.shader = shader4;
		goto IL_0388;
		IL_0388:
		if (mShader == null)
		{
			Shader shader5 = Shader.Find("Unlit/Transparent Colored");
			this.shader = shader5;
		}
		if (mMaterial != null)
		{
			Material material = default;
			material._002Ector(mMaterial);
			mDynamicMat = material;
			string text13 = mMaterial.name;
			string text14 = "[NGUI] " + text13;
			mDynamicMat.name = text14;
			mDynamicMat.hideFlags = (HideFlags)60;
			mDynamicMat.CopyPropertiesFromMaterial(mMaterial);
			string[] shaderKeywords = mMaterial.shaderKeywords;
			object obj3 = 0;
			while (shaderKeywords.Length > (nint)obj3)
			{
				object obj4 = obj3 << 2;
				object obj5 = (object)shaderKeywords + obj4;
				Material material2 = mDynamicMat;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S1_v56+10]");
				material2.EnableKeyword((string)0);
				object obj6 = obj3 + 1;
				obj3 = obj6;
			}
			if (mShader != null)
			{
				mDynamicMat.shader = mShader;
			}
			else if (((int*)num)->m_value != 0)
			{
				string text15 = ((int*)num)->ToString();
				string text16 = text7 + " shader doesn't have a clipped shader version for " + text15 + " clip regions";
			}
		}
		else
		{
			Material material3 = default;
			material3._002Ector(mShader);
			mDynamicMat = material3;
			string text17 = mShader.name;
			string text18 = "[NGUI] " + text17;
			mDynamicMat.name = text18;
			mDynamicMat.hideFlags = (HideFlags)60;
		}
	}

	private Material RebuildMaterial()
	{
		NGUITools.DestroyImmediate(mDynamicMat);
		CreateMaterial();
		mDynamicMat.renderQueue = mRenderQueue;
		if (mTexture != null)
		{
			mDynamicMat.mainTexture = mTexture;
		}
		if (mRenderer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		return mDynamicMat;
	}

	private void UpdateMaterials()
	{
		if (!mRebuildMat && mDynamicMat != null)
		{
			int clipCount = panel.clipCount;
			if (mClipCount == clipCount)
			{
				UIPanel uIPanel = panel;
				bool flag = uIPanel.mClipping == Clipping.TextureMask;
				if (mTextureClip == flag)
				{
					Material sharedMaterial = mRenderer.sharedMaterial;
					if (sharedMaterial != mDynamicMat)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						throw new ArrayTypeMismatchException();
					}
					return;
				}
			}
		}
		Material material = RebuildMaterial();
		mRebuildMat = false;
	}

	public unsafe void UpdateGeometry(int widgetCount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected I4, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected I4, but got Unknown
		//IL_0a59: Expected Obj, but got I
		//IL_0a73: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0b29: Expected Obj, but got I
		//IL_0b4a: Expected Obj, but got I
		//IL_0b70: Expected Obj, but got I
		//IL_0b91: Expected Obj, but got I
		//IL_0bb7: Expected Obj, but got I
		//IL_0bd8: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I
		//IL_05be: Expected Obj, but got I
		//IL_0295: Expected Obj, but got I
		//IL_0c0d: Expected Obj, but got I
		//IL_0c2e: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I
		//IL_051d: Expected Obj, but got I
		//IL_053e: Expected Obj, but got I
		//IL_0620: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I
		//IL_05a9: Expected Obj, but got I
		//IL_0665: Expected Obj, but got I
		//IL_06aa: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		this.widgetCount = widgetCount;
		BetterList<Vector3> betterList = verts;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (BetterList`1<UnityEngine.Vector3>)+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (BetterList`1<UnityEngine.Vector3>)+C]");
		int num4;
		bool flag2;
		bool flag6 = default;
		if ((nint)0 >= (nint)1)
		{
			BetterList<Vector2> betterList2 = uvs;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (BetterList`1<UnityEngine.Vector3>)+C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v25 (BetterList`1<UnityEngine.Vector2>)+C]");
			if (num == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (BetterList`1<UnityEngine.Vector3>)+C]");
				if ((int)((nint)0 & (nint)3) == 0)
				{
					BetterList<Color32> betterList3 = cols;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (BetterList`1<UnityEngine.Vector3>)+C]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v29 (BetterList`1<UnityEngine.Color32>)+C]");
					if (num2 == 0)
					{
						if (mFilter == null)
						{
							GameObject gameObject = base.gameObject;
							MeshFilter component = gameObject.GetComponent<MeshFilter>();
							mFilter = component;
						}
						if (mFilter == null)
						{
							GameObject gameObject2 = base.gameObject;
							MeshFilter meshFilter = gameObject2.AddComponent<MeshFilter>();
							mFilter = meshFilter;
						}
						BetterList<Vector3> betterList4 = verts;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v73 (BetterList`1<UnityEngine.Vector3>)+C]");
						if ((nint)0 <= (nint)64999)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (BetterList`1<UnityEngine.Vector3>)+C]");
							int num3 = (int)((nint)0 >> 1);
							num4 = num3 * 3;
							int[] array = mIndices;
							bool flag = mIndices == null;
							flag2 = true;
							if (!flag)
							{
								bool flag3 = array.Length != num4;
								flag2 = flag3;
							}
							if (mMesh == null)
							{
								Mesh mesh = default;
								mesh._002Ector();
								mMesh = mesh;
								mMesh.hideFlags = HideFlags.DontSave;
								string text2;
								if (mMaterial != null)
								{
									string text = mMaterial.name;
									text2 = "[NGUI] " + text;
								}
								else
								{
									text2 = "[NGUI] Mesh";
								}
								mMesh.name = text2;
								mMesh.MarkDynamic();
								flag2 = true;
							}
							BetterList<Vector2> betterList5 = uvs;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v128 (BetterList`1<UnityEngine.Vector2>)+8]");
							object obj3 = 0;
							BetterList<Vector3> betterList6 = verts;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S1_v63 (BetterList`1<UnityEngine.Vector3>)+8]");
							object obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v129+C]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v64+C]");
							if (num5 == 0)
							{
								BetterList<Color32> betterList7 = cols;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v219 (BetterList`1<UnityEngine.Color32>)+8]");
								object obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v220+C]");
								nint num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v129+C]");
								if (num6 == 0)
								{
									BetterList<Vector3> betterList8 = norms;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v224 (BetterList`1<UnityEngine.Vector3>)+8]");
									object obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v224 (BetterList`1<UnityEngine.Vector3>)+8]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v225+C]");
										nint num7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v129+C]");
										if (num7 != 0)
										{
											goto IL_0aca;
										}
									}
									BetterList<Vector4> betterList9 = tans;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S0_v228 (BetterList`1<UnityEngine.Vector4>)+8]");
									object obj7 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S0_v228 (BetterList`1<UnityEngine.Vector4>)+8]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v229+C]");
										nint num8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v129+C]");
										if (num8 != 0)
										{
											goto IL_0aca;
										}
									}
									bool flag4 = panel != null;
									bool flag5 = !flag4;
									flag6 = true;
									if (!flag5)
									{
										UIPanel uIPanel = panel;
										bool flag7 = uIPanel.renderQueue == UIPanel.RenderQueue.Automatic;
										flag6 = true;
										if (!flag7)
										{
											bool flag8 = mMesh != null;
											flag6 = false;
											if (flag8)
											{
												int vertexCount = mMesh.vertexCount;
												BetterList<Vector3> betterList10 = verts;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S1_v131 (BetterList`1<UnityEngine.Vector3>)+8]");
												object obj8 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ S1_v132+C]");
												bool flag9 = (nint)vertexCount == 0;
												flag6 = flag9;
											}
										}
									}
								}
							}
							goto IL_0aca;
						}
						mTriangles = 0;
						Mesh mesh2 = mFilter.mesh;
						if (mesh2 != null)
						{
							Mesh mesh3 = mFilter.mesh;
							mesh3.Clear();
						}
						int num9 = verts + 12;
						string text3 = ((int*)num9)->ToString();
						string text4 = "Too many vertices on one panel: " + text3;
						goto IL_0895;
					}
				}
			}
		}
		Mesh mesh4 = mFilter.mesh;
		if (mesh4 != null)
		{
			Mesh mesh5 = mFilter.mesh;
			mesh5.Clear();
		}
		int num10 = obj + 12;
		string text5 = ((int*)num10)->ToString();
		string text6 = "UIWidgets must fill the buffer with 4 vertices per quad. Found " + text5;
		goto IL_0919;
		IL_085f:
		if (!alwaysOnScreen)
		{
			goto IL_086f;
		}
		goto IL_087f;
		IL_087f:
		mFilter.mesh = mMesh;
		goto IL_0895;
		IL_086f:
		mMesh.RecalculateBounds();
		goto IL_087f;
		IL_0aca:
		BetterList<Vector3> betterList11 = verts;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S1_v68 (BetterList`1<UnityEngine.Vector3>)+C]");
		int num11 = (int)((nint)0 >> 1);
		mTriangles = num11;
		BetterList<Vector3> betterList18;
		if (flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S1_v68 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj9 = 0;
			int vertexCount2 = mMesh.vertexCount;
			BetterList<Vector3> betterList12 = verts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v178+C]");
			if (0 < unchecked((nint)"\nAborting"))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v184 (BetterList`1<UnityEngine.Vector3>)+8]");
				Vector3[] array2 = (Vector3[])0;
				bool flag10 = array2.Length != vertexCount2;
				bool flag11 = !flag10;
				Vector3[] vertices = array2;
				if (!flag11)
				{
					mMesh.Clear();
					BetterList<Vector3> betterList13 = verts;
					flag2 = true;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S0_v214 (BetterList`1<UnityEngine.Vector3>)+8]");
					vertices = (Vector3[])0;
				}
				mMesh.vertices = vertices;
				BetterList<Vector2> betterList14 = uvs;
				Mesh mesh6 = mMesh;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S1_v111 (BetterList`1<UnityEngine.Vector2>)+8]");
				mesh6.uv = (Vector2[])0;
				BetterList<Color32> betterList15 = cols;
				Mesh mesh7 = mMesh;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ S1_v114 (BetterList`1<UnityEngine.Color32>)+8]");
				mesh7.colors32 = (Color32[])0;
				BetterList<Vector3> betterList16 = norms;
				if (norms != null)
				{
					Mesh mesh8 = mMesh;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ S0_v199 (BetterList`1<UnityEngine.Vector3>)+8]");
					mesh8.normals = (Vector3[])0;
				}
				BetterList<Vector4> betterList17 = tans;
				if (tans == null)
				{
					goto IL_07f3;
				}
				Mesh mesh9 = mMesh;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ S0_v202 (BetterList`1<UnityEngine.Vector4>)+8]");
				mesh9.tangents = (Vector4[])0;
				if (flag2)
				{
					goto IL_080c;
				}
				goto IL_085f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v184 (BetterList`1<UnityEngine.Vector3>)+C]");
			bool flag12 = (nint)vertexCount2 == 0;
			betterList18 = betterList12;
			if (flag12)
			{
				goto IL_0b0d;
			}
		}
		mMesh.Clear();
		flag2 = true;
		betterList18 = verts;
		goto IL_0b0d;
		IL_0919:
		BetterList<Vector3> betterList19 = verts;
		_ = 0;
		BetterList<Vector2> betterList20 = uvs;
		_ = 0;
		BetterList<Color32> betterList21 = cols;
		_ = 0;
		BetterList<Vector3> betterList22 = norms;
		_ = 0;
		BetterList<Vector4> betterList23 = tans;
		_ = 0;
		return;
		IL_0895:
		if (mRenderer == null)
		{
			GameObject gameObject3 = base.gameObject;
			MeshRenderer component2 = gameObject3.GetComponent<MeshRenderer>();
			mRenderer = component2;
		}
		if (mRenderer == null)
		{
			GameObject gameObject4 = base.gameObject;
			MeshRenderer meshRenderer = gameObject4.AddComponent<MeshRenderer>();
			mRenderer = meshRenderer;
		}
		UpdateMaterials();
		goto IL_0919;
		IL_080c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (BetterList`1<UnityEngine.Vector3>)+C]");
		int[] array3 = GenerateCachedIndexBuffer(0, num4);
		mIndices = array3;
		mMesh.triangles = mIndices;
		goto IL_0846;
		IL_0b0d:
		nint num12 = 0;
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S3_v6 (Il2CppRgctx<BetterList`1<UnityEngine.Vector3>>)+2C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v452 @ S3_v7+4] (should have been resolved before IL gen)");
		Mesh mesh10 = mMesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ L2_v11 (BetterList`1<UnityEngine.Vector3>)+8]");
		mesh10.vertices = (Vector3[])0;
		BetterList<Vector2> betterList24 = uvs;
		nint num14 = 0;
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S3_v11 (Il2CppRgctx<BetterList`1<UnityEngine.Vector2>>)+2C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v493 @ S3_v12+4] (should have been resolved before IL gen)");
		Mesh mesh11 = mMesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S1_v76 (BetterList`1<UnityEngine.Vector2>)+8]");
		mesh11.uv = (Vector2[])0;
		BetterList<Color32> betterList25 = cols;
		nint num16 = 0;
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ S3_v16 (Il2CppRgctx<BetterList`1<UnityEngine.Color32>>)+2C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v529 @ S3_v17+4] (should have been resolved before IL gen)");
		Mesh mesh12 = mMesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ S1_v80 (BetterList`1<UnityEngine.Color32>)+8]");
		mesh12.colors32 = (Color32[])0;
		BetterList<Vector3> betterList26 = norms;
		if (norms != null)
		{
			nint num18 = 0;
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S3_v27 (Il2CppRgctx<BetterList`1<UnityEngine.Vector3>>)+2C]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v597 @ S3_v28+4] (should have been resolved before IL gen)");
			Mesh mesh13 = mMesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ S0_v143 (BetterList`1<UnityEngine.Vector3>)+8]");
			mesh13.normals = (Vector3[])0;
		}
		BetterList<Vector4> betterList27 = tans;
		if (tans != null)
		{
			nint num20 = 0;
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ S3_v22 (Il2CppRgctx<BetterList`1<UnityEngine.Vector4>>)+2C]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v638 @ S3_v23+4] (should have been resolved before IL gen)");
			Mesh mesh14 = mMesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ S0_v146 (BetterList`1<UnityEngine.Vector4>)+8]");
			mesh14.tangents = (Vector4[])0;
		}
		goto IL_07f3;
		IL_0846:
		if (flag6)
		{
			goto IL_085f;
		}
		goto IL_086f;
		IL_07f3:
		if (flag2)
		{
			goto IL_080c;
		}
		goto IL_0846;
	}

	private int[] GenerateCachedIndexBuffer(int vertexCount, int indexCount)
	{
		//IL_008d: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		List<int[]> list = mCache;
		int num = 0;
		int[] result;
		int[] array2 = default;
		while (true)
		{
			if (num < list._size)
			{
				int[] array = mCache.get_Item(num);
				if (array != null)
				{
					bool flag = array.Length == indexCount;
					result = array;
					if (flag)
					{
						break;
					}
				}
				int num2 = num + 1;
				num = num2;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj = 0;
			while ((nint)obj < vertexCount)
			{
				object obj2 = 0 << 2;
				object obj3 = (object)array2 + obj2;
				object obj4 = 0 + 1;
				object obj5 = obj4 + 1;
				object obj6 = obj4 << 2;
				object obj7 = (object)array2 + obj6;
				object obj8 = obj + 1;
				object obj9 = obj5 << 2;
				object obj10 = (object)array2 + obj9;
				object obj11 = obj + 2;
				object obj12 = obj5 + 1;
				object obj13 = obj12 + 1;
				object obj14 = obj12 << 2;
				object obj15 = (object)array2 + obj14;
				object obj16 = obj + 2;
				object obj17 = obj13 << 2;
				object obj18 = (object)array2 + obj17;
				object obj19 = obj + 3;
				object obj20 = obj13 + 1;
				object obj21 = obj20 << 2;
				object obj22 = (object)array2 + obj21;
				object obj23 = obj + 4;
				obj = obj23;
			}
			List<int[]> list2 = mCache;
			if (list2._size >= 11)
			{
				mCache.RemoveAt(0);
			}
			mCache.Add(array2);
			result = array2;
			break;
		}
		return result;
	}

	private unsafe void OnWillRenderObject()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected VT, but got Unknown
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected VT, but got Unknown
		//IL_07aa: Invalid comparison between I and F4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected VT, but got Unknown
		//IL_0879: Expected Obj, but got I
		//IL_088a: Invalid comparison between I and F4
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Expected VT, but got Unknown
		//IL_05fb: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected Obj, but got Unknown
		//IL_024a: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I
		//IL_081f: Expected F4, but got I
		//IL_081a: Expected native int or pointer, but got VT
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Expected VT, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected VT, but got Unknown
		//IL_0312: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected VT, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got I
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected VT, but got Unknown
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected VT, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected VT, but got Unknown
		object obj = default;
		Vector2 vector = (Vector2)(obj - 288);
		_ = 0;
		_ = 0;
		UpdateMaterials();
		OnRenderCallback onRenderCallback = onRender;
		if (onRender != null)
		{
			Material material = mDynamicMat;
			if ((object)mDynamicMat == null)
			{
				material = mMaterial;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v24.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		if (!(mDynamicMat != null) || mClipCount == 0)
		{
			return;
		}
		if (~(mTextureClip ? 1u : 0u) == 0)
		{
			UIPanel uIPanel = panel;
			int[] clipRange = ClipRange;
			float num = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v181 (UIPanel)+B0]");
			float num2 = num / 0f;
			float num3 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v181 (UIPanel)+B4]");
			float num4 = num3 / 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+F8]");
			_ = 0;
			float num5 = 0f - (float)uIPanel.drawCallClipRange;
			float num6 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v181 (UIPanel)+B0]");
			float num7 = num6 / 0f;
			float num8 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v181 (UIPanel)+AC]");
			float num9 = num8 - 0f;
			float num10 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v181 (UIPanel)+B4]");
			float num11 = num10 / 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+F0]");
			_ = 0;
			Vector4 value = (Vector4)(vector + 136);
			mDynamicMat.SetVector(clipRange[0], value);
			mDynamicMat.SetTexture("_ClipTex", clipTexture);
			return;
		}
		object obj2 = this + 28;
		if (~(mLegacyShader ? 1u : 0u) != 0)
		{
			object obj3 = obj2;
			while (true)
			{
				UnityEngine.Object obj4 = (UnityEngine.Object)obj3;
				if (!((UnityEngine.Object)obj3 != null))
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v64 (UnityEngine.Object)+C4]");
				object obj5 = (nint)0 & (nint)(-3);
				if ((nint)obj5 == 1)
				{
					bool flag = (UnityEngine.Object)obj3 != (UnityEngine.Object)obj2;
					bool flag2 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v64 (UnityEngine.Object)+A8]");
					object obj6 = 0;
					float angle = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v64 (UnityEngine.Object)+AC]");
					object obj7 = 0;
					if (!flag2)
					{
						Transform transform = ((UIRect)obj3).cachedTransform;
						Transform transform2 = ((UIRect)obj2).cachedTransform;
						Vector3 position = transform2.position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D0]");
						_ = 0;
						Vector3 position2 = (Vector3)(vector + 88);
						Vector3 vector2 = transform.InverseTransformPoint(position2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v64 (UnityEngine.Object)+A8]");
						nint num12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D0]");
						object obj8 = num12 - 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v64 (UnityEngine.Object)+AC]");
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D4]");
						object obj9 = num13 - 0;
						Transform transform3 = ((UIRect)obj2).cachedTransform;
						Quaternion rotation = transform3.rotation;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D0]");
						_ = 0;
						Quaternion rotation2 = (Quaternion)(vector + 72);
						Vector3 vector3 = Quaternion.Internal_ToEulerRad(rotation2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D0]");
						float num14 = 0f * 57.29578f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D4]");
						float num15 = 0f * 57.29578f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D8]");
						float num16 = 0f * 57.29578f;
						object obj10 = vector - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+118]");
						obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+110]");
						_ = 0;
						Vector3 euler = (Vector3)(vector + 56);
						Vector3 vector4 = Quaternion.Internal_MakePositive(euler);
						Transform transform4 = ((UIRect)obj3).cachedTransform;
						Quaternion rotation3 = transform4.rotation;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D0]");
						_ = 0;
						Quaternion rotation4 = (Quaternion)(vector + 40);
						Vector3 vector5 = Quaternion.Internal_ToEulerRad(rotation4);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D0]");
						float num17 = 0f * 57.29578f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D4]");
						float num18 = 0f * 57.29578f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D8]");
						float num19 = 0f * 57.29578f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+118]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+110]");
						_ = 0;
						Vector3 euler2 = (Vector3)(vector + 24);
						Vector3 vector6 = Quaternion.Internal_MakePositive(euler2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D4]");
						float num20 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D4]");
						float angle2 = num20 - 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D8]");
						float num21 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D8]");
						float angle3 = num21 - 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D0]");
						float num22 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+D0]");
						float angle4 = num22 - 0f;
						float num23 = NGUIMath.WrapAngle(angle4);
						float num24 = NGUIMath.WrapAngle(angle2);
						float num25 = NGUIMath.WrapAngle(angle3);
						obj6 = obj8;
						angle = num25;
						obj7 = obj9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v64 (UnityEngine.Object)+B0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v64 (UnityEngine.Object)+B0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v64 (UnityEngine.Object)+D8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v64 (UnityEngine.Object)+D8]");
					((Vector2*)(nint)vector)->x = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+C0]");
					_ = 0;
					Vector4 cr = (Vector4)(vector + 8);
					SetClipping(0, cr, vector, angle);
				}
				object obj11 = obj3 + 276;
				obj3 = obj11;
			}
		}
		else
		{
			object obj12 = obj2;
			float num26 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v33+A8]");
			float num27 = num26 - 0f;
			float num28 = num27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v33+B0]");
			float num29 = num28 / 0f;
			float num30 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v33+AC]");
			float num31 = num30 - 0f;
			float num32 = num31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v33+B4]");
			float num33 = num32 / 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+B0]");
			_ = 0;
			Vector2 mainTextureOffset = vector + 128;
			mDynamicMat.mainTextureOffset = mainTextureOffset;
			float num34 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v33+B4]");
			float num35 = num34 / 0f;
			float num36 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v33+B0]");
			float num37 = num36 / 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A8]");
			_ = 0;
			Vector2 mainTextureScale = vector + 120;
			mDynamicMat.mainTextureScale = mainTextureScale;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v33+B4]");
			float num38 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v33+DC]");
			float num39 = num38 / 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v33+DC]");
			if (!(0f > 0f))
			{
				num39 = 1000f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v33+B0]");
			nint num40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v33+D8]");
			object obj13 = num40 / 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v33+D8]");
			if (!(0f > 0f))
			{
				obj13 = 1148846080;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+98]");
			_ = 0;
			Vector4 value2 = (Vector4)(vector + 104);
			mDynamicMat.SetVector("_ClipSharpness", value2);
		}
	}

	private unsafe void SetClipping(int index, Vector4 cr, Vector2 soft, float angle)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected VT, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_01a7: Expected F4, but got I
		//IL_01a2: Expected native int or pointer, but got VT
		//IL_01c6: Expected F4, but got I
		//IL_01c1: Expected native int or pointer, but got VT
		object obj = default;
		Vector4 vector = (Vector4)(obj + -64);
		float num = angle * (-(float)Math.PI / 180f);
		bool flag = soft.x > 0f;
		bool flag2 = !flag;
		float num2 = 1000f;
		if (!flag2)
		{
			float num3 = cr.z / soft.x;
			num2 = num3;
		}
		bool flag3 = soft.y > 0f;
		bool flag4 = !flag3;
		float num4 = 1000f;
		if (!flag4)
		{
			float num5 = cr.w / soft.y;
			num4 = num5;
		}
		int[] clipRange = ClipRange;
		if (index < clipRange.Length)
		{
			int num6 = index << 2;
			object obj2 = ClipRange + num6;
			float num7 = 0f - cr.x;
			float num8 = 0f - cr.y;
			float num9 = 1f / cr.z;
			float num10 = 1f / cr.w;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+38]");
			_ = 0;
			float num11 = num7 / cr.z;
			float num12 = num8 / cr.w;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+30]");
			_ = 0;
			Vector4 value = vector + 16;
			Material material = mDynamicMat;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v34+10]");
			material.SetVector(0, value);
			int num13 = index << 2;
			object obj3 = ClipArgs + num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @332");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+28]");
			((Vector4*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+20]");
			((Vector4*)(nint)vector)->x = 0f;
			Material material2 = mDynamicMat;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v55+10]");
			material2.SetVector(0, vector);
		}
	}

	private void Awake()
	{
		if (ClipRange == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			int num = Shader.PropertyToID("_ClipRange0");
			int[] array = default;
			array[0] = num;
			int num2 = Shader.PropertyToID("_ClipRange1");
			array[1] = num2;
			int num3 = Shader.PropertyToID("_ClipRange2");
			array[2] = num3;
			int num4 = Shader.PropertyToID("_ClipRange4");
			array[3] = num4;
			ClipRange = array;
		}
		if (ClipArgs == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			int num5 = Shader.PropertyToID("_ClipArgs0");
			int[] array2 = default;
			array2[0] = num5;
			int num6 = Shader.PropertyToID("_ClipArgs1");
			array2[1] = num6;
			int num7 = Shader.PropertyToID("_ClipArgs2");
			array2[2] = num7;
			int num8 = Shader.PropertyToID("_ClipArgs3");
			array2[3] = num8;
			ClipArgs = array2;
		}
	}

	private void OnEnable()
	{
		mRebuildMat = true;
	}

	private void OnDisable()
	{
		//IL_004c: Expected I4, but got I8
		panel = null;
		depthStart = int.MaxValue;
		manager = null;
		mMaterial = null;
		mTexture = null;
		clipTexture = null;
		if (mRenderer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
		}
		NGUITools.DestroyImmediate(mDynamicMat);
		mDynamicMat = null;
	}

	private void OnDestroy()
	{
		NGUITools.DestroyImmediate(mMesh);
		mMesh = null;
	}

	public static UIDrawCall Create(UIPanel panel, Material mat, Texture tex, Shader shader)
	{
		return Create(null, panel, mat, tex, shader);
	}

	private static UIDrawCall Create(string name, UIPanel pan, Material mat, Texture tex, Shader shader)
	{
		UIDrawCall uIDrawCall = Create(name);
		GameObject gameObject = uIDrawCall.gameObject;
		GameObject cachedGameObject = pan.cachedGameObject;
		int layer = cachedGameObject.layer;
		gameObject.layer = layer;
		uIDrawCall.baseMaterial = mat;
		uIDrawCall.mainTexture = tex;
		uIDrawCall.shader = shader;
		uIDrawCall.renderQueue = pan.startingRenderQueue;
		uIDrawCall.sortingOrder = pan.mSortingOrder;
		uIDrawCall.manager = pan;
		return uIDrawCall;
	}

	private static UIDrawCall Create(string name)
	{
		BetterList<UIDrawCall> betterList = mInactiveList;
		if (betterList.size >= 1)
		{
			UIDrawCall uIDrawCall = mInactiveList.Pop();
			mActiveList.Add(uIDrawCall);
			if (name != null)
			{
				uIDrawCall.name = name;
			}
			GameObject go = uIDrawCall.gameObject;
			NGUITools.SetActive(go, state: true);
			return uIDrawCall;
		}
		GameObject gameObject = default;
		gameObject._002Ector(name);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UIDrawCall uIDrawCall2 = gameObject.AddComponent<UIDrawCall>();
		mActiveList.Add(uIDrawCall2);
		return uIDrawCall2;
	}

	public static void ClearAll()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		bool isPlaying = Application.isPlaying;
		BetterList<UIDrawCall> betterList = mActiveList;
		int num = betterList.size;
		BetterList<UIDrawCall> betterList2;
		while (true)
		{
			betterList2 = mActiveList;
			if (num <= 0)
			{
				break;
			}
			int num2 = num - 1;
			int num3 = num2 << 2;
			object obj = betterList2.buffer + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v30+10]");
			bool flag = (UnityEngine.Object)0;
			bool flag2 = !flag;
			num = num2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v30+10]");
				GameObject gameObject = ((Component)0).gameObject;
				if (isPlaying)
				{
					NGUITools.SetActive(gameObject, state: false);
				}
				else
				{
					NGUITools.DestroyImmediate(gameObject);
				}
				num = num2;
			}
		}
		betterList2.size = 0;
	}

	public static void ReleaseAll()
	{
		ClearAll();
		ReleaseInactive();
	}

	public static void ReleaseInactive()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		BetterList<UIDrawCall> betterList = mInactiveList;
		int num = betterList.size;
		BetterList<UIDrawCall> betterList2;
		while (true)
		{
			betterList2 = mInactiveList;
			if (num <= 0)
			{
				break;
			}
			int num2 = num - 1;
			int num3 = num2 << 2;
			object obj = betterList2.buffer + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v28+10]");
			bool flag = (UnityEngine.Object)0;
			bool flag2 = !flag;
			num = num2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v28+10]");
				GameObject obj2 = ((Component)0).gameObject;
				NGUITools.DestroyImmediate(obj2);
				num = num2;
			}
		}
		betterList2.size = 0;
	}

	public static int Count(UIPanel panel)
	{
		//IL_0093: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		object obj = 0;
		int num = default;
		while (true)
		{
			BetterList<UIDrawCall> betterList = mActiveList;
			if (betterList.size <= (nint)obj)
			{
				break;
			}
			BetterList<UIDrawCall> betterList2 = mActiveList;
			object obj2 = obj << 2;
			object obj3 = (object)betterList2.buffer + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v25+10]");
			object obj4 = 0;
			num++;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v26+18]");
			if ((UnityEngine.Object)0 != panel)
			{
				num = num;
			}
			object obj5 = obj + 1;
			obj = obj5;
		}
		return num;
	}

	public static void Destroy(UIDrawCall dc)
	{
		if (!dc)
		{
			return;
		}
		dc.onRender = null;
		bool isPlaying = Application.isPlaying;
		bool flag = mActiveList.Remove(dc);
		if (isPlaying)
		{
			if (flag)
			{
				GameObject go = dc.gameObject;
				NGUITools.SetActive(go, state: false);
				mInactiveList.Add(dc);
			}
		}
		else
		{
			GameObject obj = dc.gameObject;
			NGUITools.DestroyImmediate(obj);
		}
	}

	public UIDrawCall()
	{
		//IL_0054: Expected I4, but got I8
		BetterList<Vector3> betterList = default;
		verts = betterList;
		BetterList<Vector3> betterList2 = default;
		norms = betterList2;
		BetterList<Vector4> betterList3 = default;
		tans = betterList3;
		BetterList<Vector2> betterList4 = default;
		uvs = betterList4;
		BetterList<Color32> betterList5 = default;
		cols = betterList5;
		mRenderQueue = 3000;
		mRebuildMat = true;
		base._002Ector();
	}

	static UIDrawCall()
	{
		BetterList<UIDrawCall> betterList = default;
		mActiveList = betterList;
		BetterList<UIDrawCall> betterList2 = default;
		mInactiveList = betterList2;
		List<int[]> list = default;
		list._002Ector(10);
		mCache = list;
		ClipRange = null;
		ClipArgs = null;
	}
}
