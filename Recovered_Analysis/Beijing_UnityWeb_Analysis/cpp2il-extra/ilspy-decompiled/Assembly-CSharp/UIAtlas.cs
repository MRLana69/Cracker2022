using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIAtlas : MonoBehaviour
{
	[Serializable]
	private class Sprite
	{
		public string name = (string)2;

		public Rect outer = (Rect)0.5f;

		public Rect inner;

		public bool rotated;

		public float paddingLeft;

		public float paddingRight;

		public float paddingTop;

		public float paddingBottom;

		public unsafe bool hasPadding
		{
			get
			{
				//IL_0148: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Expected I, but got Unknown
				//IL_0022: Expected I, but got Obj
				//IL_0038: Expected Obj, but got I
				//IL_00bf: Expected I, but got Obj
				//IL_00d5: Expected Obj, but got I
				//IL_0063: Expected I, but got Obj
				//IL_01c6: Expected I, but got Obj
				//IL_01db: Expected I4, but got Obj
				//IL_0100: Expected I, but got Obj
				object obj = default;
				nint num = (nint)(obj + 4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas+Sprite)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
				}
				else
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num3 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if ((UnityEngine.Object)(object)name != null)
					{
						nint num4 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v20 (Il2CppClass<System.Type>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num5 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v28 (Il2CppClass<System.Type>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj = typeof(void);
						((IntPtr*)num)->m_value = (void*)(nint)obj;
						Type type = Type.internal_from_handle((IntPtr)num);
						return (byte)(int)type != 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
				}
				bool result = default;
				return result;
			}
		}

		public Sprite()
		{
			//IL_00e6: Expected Obj, but got I4
			//IL_00f1: Expected VT, but got F4
			//IL_00fa: Expected Obj, but got I4
			//IL_0103: Expected Obj, but got F4
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected Obj, but got Unknown
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Expected Obj, but got Unknown
			//IL_0148: Expected I, but got Obj
			//IL_015e: Expected Obj, but got I
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Expected Obj, but got Unknown
			//IL_0258: Expected VT, but got Obj
			//IL_0266: Expected I, but got Obj
			//IL_027c: Expected Obj, but got I
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected Obj, but got Unknown
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Expected Obj, but got Unknown
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected Obj, but got Unknown
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected Obj, but got Unknown
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected Obj, but got Unknown
			//IL_0060: Expected I, but got Obj
			object obj = 0;
			obj = 0.25f;
			_ = 0.75f;
			object obj2 = obj + 16;
			obj2 = obj;
			object obj3 = obj + 60;
			obj3 = obj2;
			nint num = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v59 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = obj + 8;
			Vector2 one = Vector2.one;
			obj3 = obj5;
			inner = (Rect)obj3;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v55 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj7 = obj + 48;
			Vector3 one2 = Vector3.one;
			obj3 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v33+8]");
			_ = 0;
			object obj8 = this + 36;
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16+8]");
			_ = 0;
			object obj9 = obj + 36;
			Vector3 one3 = Vector3.one;
			obj3 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v40+8]");
			_ = 0;
			object obj10 = this + 48;
			obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16+8]");
			_ = 0;
			object obj11 = obj + 24;
			Vector3 forward = Vector3.forward;
			obj3 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v47+8]");
			_ = 0;
			object obj12 = this + 60;
			obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16+8]");
			_ = 0;
			_ = 1f;
		}
	}

	private enum Coordinates
	{
		Pixels,
		TexCoords
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UISpriteData> _003C_003E9__29_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LanguageSelection._003C_003Ec obj = default;
			LanguageSelection._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected Obj, but got Unknown
			//IL_0030: Expected Obj, but got I4
			//IL_003f: Expected Obj, but got F4
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected Obj, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			//IL_009d: Expected Obj, but got I4
			//IL_00ac: Expected Obj, but got F4
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = "Unity Bug";
			object obj3 = default;
			object obj2 = obj3 + 16;
			obj2 = 0;
			_ = 0;
			obj2 = 0f;
			_ = 0f;
			_ = 1f;
			_ = 1f;
			object obj4 = obj3 + 32;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
			_ = 0;
			object obj5 = this + 12;
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
			_ = 0;
			obj3 = 0;
			_ = 0;
			obj3 = 0f;
			_ = 0f;
			_ = 1f;
			_ = 1f;
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj6 = this + 28;
			obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
			_ = 0;
		}

		internal int _003CSortAlphabetically_003Eb__29_0(UISpriteData s1, UISpriteData s2)
		{
			//IL_0009: Expected Obj, but got I4
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
			int result = default;
			return result;
		}
	}

	private Material material;

	private List<UISpriteData> mSprites;

	private float mPixelSize;

	private UIAtlas mReplacement;

	private Coordinates mCoordinates;

	private List<Sprite> sprites;

	private int mPMA;

	private Dictionary<string, int> mSpriteIndices;

	public Material spriteMaterial
	{
		get
		{
			return (Material)(object)mSprites;
		}
		set
		{
			mSprites = (List<UISpriteData>)(object)value;
		}
	}

	public bool premultipliedAlpha
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0066: Expected I4, but got Obj
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			UIAtlas uIAtlas = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIAtlas.mReplacement).FindKernel((string)null) != 0)
					{
						uIAtlas = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					return (byte)(int)uIAtlas.material != 0;
				}
				while (obj == null);
			}
		}
	}

	public List<UISpriteData> spriteList
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0278: Expected Obj, but got I4
			//IL_00a4: Expected I, but got Obj
			//IL_00ba: Expected Obj, but got I
			//IL_0282: Expected Obj, but got I4
			//IL_0227: Expected I, but got Obj
			//IL_023d: Expected Obj, but got I
			//IL_00e5: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I4
			//IL_013f: Expected I, but got Obj
			//IL_0155: Expected Obj, but got I
			//IL_0180: Expected I, but got Obj
			//IL_01c8: Expected Obj, but got I4
			UIAtlas uIAtlas = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIAtlas.mReplacement).FindKernel((string)null) != 0)
					{
						uIAtlas = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					if (uIAtlas.mPMA == -1)
					{
						bool flag = uIAtlas.premultipliedAlpha;
						nint num3 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num4 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num7;
						if (((ComputeShader)flag).FindKernel(null) != 0)
						{
							Texture mainTexture = ((Material)flag).mainTexture;
							nint num5 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S2_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj3 = (nint)0 & (nint)0x200;
							if (obj3 != null)
							{
								nint num6 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S2_v20 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)(object)mainTexture).FindKernel((string)null) != 0)
							{
								Texture mainTexture2 = ((Material)flag).mainTexture;
								UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)mainTexture2);
								bool flag2 = ((string)(object)obj4).EndsWith("Premultiplied");
								num7 = (flag2 ? 1 : 0);
							}
							else
							{
								num7 = 0;
							}
						}
						else
						{
							num7 = 0;
						}
						uIAtlas.mPMA = num7;
					}
					bool flag3 = uIAtlas.mPMA == 1;
					return (List<UISpriteData>)flag3;
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_000e: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected Obj, but got Unknown
			//IL_00ab: Expected I, but got Obj
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected Obj, but got Unknown
			//IL_015d: Expected I, but got Obj
			//IL_0173: Expected Obj, but got I
			UIAtlas uIAtlas = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIAtlas.mReplacement).FindKernel((string)null) != 0)
					{
						uIAtlas = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (uIAtlas.material != null)
					{
						uIAtlas.mPMA = 0;
						object obj3 = uIAtlas + 12;
						obj3 = value;
					}
					else
					{
						uIAtlas._002Ector();
						uIAtlas.mPMA = -1;
						object obj4 = uIAtlas + 12;
						obj4 = value;
						uIAtlas._002Ector();
					}
					return;
				}
				while (obj == null);
			}
		}
	}

	public Texture texture
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_00c0: Expected I, but got Obj
			//IL_00d6: Expected Obj, but got I
			UIAtlas uIAtlas = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIAtlas.mReplacement).FindKernel((string)null) != 0)
					{
						uIAtlas = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					List<UISpriteData> list = uIAtlas.mSprites;
					if (list._size == 0)
					{
						bool stickyPress = ((UICamera)(object)uIAtlas).stickyPress;
					}
					return (Texture)(object)uIAtlas.mSprites;
				}
				while (obj == null);
			}
		}
	}

	public float pixelSize
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+1A8]");
			return 0f;
		}
		set
		{
			//IL_00b1: Expected I, but got Obj
			//IL_00c7: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (value < 0f)
			{
				float num3 = 0f;
			}
			else if (value > 1f)
			{
				float num3 = 1f;
			}
			else
			{
				float num3 = value;
			}
		}
	}

	public UIAtlas replacement
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I4
			//IL_0121: Expected I, but got Obj
			//IL_0137: Expected Obj, but got I
			UIAtlas uIAtlas = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIAtlas.mReplacement).FindKernel((string)null) != 0)
					{
						uIAtlas = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)uIAtlas.material).FindKernel((string)null) != 0)
					{
						int renderQueue = uIAtlas.material.renderQueue;
						return (UIAtlas)renderQueue;
					}
					return null;
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_000e: Expected I, but got Obj
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			UIAtlas uIAtlas = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIAtlas.mReplacement).FindKernel((string)null) != 0)
					{
						uIAtlas = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					object obj2 = uIAtlas + 16;
					obj2 = value;
					return;
				}
				while (obj == null);
			}
		}
	}

	public unsafe UISpriteData GetSprite(string name)
	{
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected I4, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected VT, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected Obj, but got Unknown
		//IL_004b: Invalid comparison between Obj and F4
		//IL_0078: Expected Obj, but got I4
		//IL_035f: Expected Obj, but got I
		//IL_0534: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_07ec: Expected Obj, but got I
		//IL_0818: Expected I4, but got F4
		//IL_0877: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0477: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		//IL_03d4: Expected VT, but got Obj
		//IL_03e2: Expected I, but got Obj
		//IL_03f8: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		//IL_0889: Expected F4, but got Obj
		//IL_0884: Expected native int or pointer, but got VT
		//IL_089e: Expected F4, but got I
		//IL_0899: Expected native int or pointer, but got VT
		//IL_08b3: Expected F4, but got I
		//IL_08ae: Expected native int or pointer, but got VT
		//IL_08c8: Expected F4, but got I
		//IL_08c3: Expected native int or pointer, but got VT
		//IL_08dd: Expected F4, but got I
		//IL_08d8: Expected native int or pointer, but got VT
		//IL_08f2: Expected F4, but got I
		//IL_08ed: Expected native int or pointer, but got VT
		//IL_0907: Expected F4, but got I
		//IL_0902: Expected native int or pointer, but got VT
		//IL_091c: Expected F4, but got I
		//IL_0917: Expected native int or pointer, but got VT
		//IL_0929: Expected I4, but got Obj
		//IL_098e: Expected VT, but got I4
		//IL_099f: Expected I4, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I
		//IL_0423: Expected I, but got Obj
		//IL_059b: Expected Obj, but got I
		//IL_05c7: Expected I4, but got F4
		//IL_0626: Expected Obj, but got I
		//IL_063b: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_025b: Expected VT, but got Obj
		//IL_0269: Expected I, but got Obj
		//IL_027f: Expected Obj, but got I
		//IL_064d: Expected F4, but got Obj
		//IL_0648: Expected native int or pointer, but got VT
		//IL_0662: Expected F4, but got I
		//IL_065d: Expected native int or pointer, but got VT
		//IL_0677: Expected F4, but got I
		//IL_0672: Expected native int or pointer, but got VT
		//IL_068c: Expected F4, but got I
		//IL_0687: Expected native int or pointer, but got VT
		//IL_06a1: Expected F4, but got I
		//IL_069c: Expected native int or pointer, but got VT
		//IL_06b6: Expected F4, but got I
		//IL_06b1: Expected native int or pointer, but got VT
		//IL_06cb: Expected F4, but got I
		//IL_06c6: Expected native int or pointer, but got VT
		//IL_06e0: Expected F4, but got I
		//IL_06db: Expected native int or pointer, but got VT
		//IL_06ed: Expected I4, but got Obj
		//IL_0752: Expected VT, but got I4
		//IL_0763: Expected I4, but got Obj
		//IL_02aa: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9CD6");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+EC]");
		object obj = default;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+F0]");
			if (0 != (nint)obj)
			{
				_ = 1;
			}
		}
		object obj2 = default;
		int num = obj2 + 256;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 192);
		object obj3 = obj2 + 128;
		Transform transform = (Transform)(obj2 - -64);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+2C]");
		if ((nint)0 != 0)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+EC]");
			bool flag2 = (nint)0 != 0;
			object obj4 = flag & flag2;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v101 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v186 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				ComputeShader computeShader = default;
				if (computeShader.FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+94]");
					bool hasTransformed = ((UIGeometry)0).hasTransformed;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+98]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+94]");
						((UIGeometry)0)._002Ector();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+94]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+94]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+94]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+94]");
					if (!((UIGeometry)0).hasTransformed)
					{
						_ = 0;
						return (UISpriteData)hasTransformed;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+104]");
					if (0 != (nint)name)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A73B");
						Camera anchorCamera = ((UIRect)this).anchorCamera;
						transform.Rotate((Vector3)anchorCamera);
						nint num4 = (nint)typeof(Matrix4x4);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v122 (Il2CppClass<UnityEngine.Matrix4x4>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num5 = (nint)typeof(Matrix4x4);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S0_v153 (Il2CppClass<UnityEngine.Matrix4x4>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
						Matrix4x4 matrix4x2 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+8]");
						((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
						Matrix4x4 matrix4x3 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+10]");
						((Matrix4x4*)(nint)matrix4x3)->m01 = 0f;
						Matrix4x4 matrix4x4 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+18]");
						((Matrix4x4*)(nint)matrix4x4)->m21 = 0f;
						Matrix4x4 matrix4x5 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+20]");
						((Matrix4x4*)(nint)matrix4x5)->m02 = 0f;
						Matrix4x4 matrix4x6 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+28]");
						((Matrix4x4*)(nint)matrix4x6)->m22 = 0f;
						Matrix4x4 matrix4x7 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+30]");
						((Matrix4x4*)(nint)matrix4x7)->m03 = 0f;
						Matrix4x4 matrix4x8 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+38]");
						((Matrix4x4*)(nint)matrix4x8)->m23 = 0f;
						((int*)num)->m_value = (int)transform;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (UnityEngine.Transform)+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (UnityEngine.Transform)+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (UnityEngine.Transform)+20]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (UnityEngine.Transform)+28]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (UnityEngine.Transform)+30]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (UnityEngine.Transform)+38]");
						_ = 0;
						Vector4 vector = matrix4x * (Vector4)num;
						((int*)num)->m_value = (int)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+28]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+30]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+38]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A73C");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A73D");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+90]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S1_v113+55]");
					bool h = (nint)0 != 0;
					((int*)num)->m_value = (int)matrix4x.m00;
					_ = matrix4x.m20;
					_ = matrix4x.m01;
					_ = matrix4x.m21;
					_ = matrix4x.m02;
					_ = matrix4x.m22;
					_ = matrix4x.m03;
					_ = matrix4x.m23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+94]");
					((UIWidget)0).SetDimensions(num, h ? 1 : 0);
					_ = 0;
					_ = 0;
					return (UISpriteData)1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+94]");
			if (((UIGeometry)0).hasTransformed)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+98]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+94]");
					((UIGeometry)0)._002Ector();
				}
				goto IL_0462;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+F4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+94]");
				if (((UIGeometry)0).hasTransformed)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+104]");
					if (0 != (nint)name)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A73B");
						Camera anchorCamera2 = ((UIRect)this).anchorCamera;
						transform.Rotate((Vector3)anchorCamera2);
						nint num6 = (nint)typeof(Matrix4x4);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v49 (Il2CppClass<UnityEngine.Matrix4x4>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num7 = (nint)typeof(Matrix4x4);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v80 (Il2CppClass<UnityEngine.Matrix4x4>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
						Matrix4x4 matrix4x9 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+8]");
						((Matrix4x4*)(nint)matrix4x9)->m20 = 0f;
						Matrix4x4 matrix4x10 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+10]");
						((Matrix4x4*)(nint)matrix4x10)->m01 = 0f;
						Matrix4x4 matrix4x11 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+18]");
						((Matrix4x4*)(nint)matrix4x11)->m21 = 0f;
						Matrix4x4 matrix4x12 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+20]");
						((Matrix4x4*)(nint)matrix4x12)->m02 = 0f;
						Matrix4x4 matrix4x13 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+28]");
						((Matrix4x4*)(nint)matrix4x13)->m22 = 0f;
						Matrix4x4 matrix4x14 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+30]");
						((Matrix4x4*)(nint)matrix4x14)->m03 = 0f;
						Matrix4x4 matrix4x15 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+38]");
						((Matrix4x4*)(nint)matrix4x15)->m23 = 0f;
						((int*)num)->m_value = (int)transform;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (UnityEngine.Transform)+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (UnityEngine.Transform)+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (UnityEngine.Transform)+20]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (UnityEngine.Transform)+28]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (UnityEngine.Transform)+30]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (UnityEngine.Transform)+38]");
						_ = 0;
						Vector4 vector2 = matrix4x * (Vector4)num;
						((int*)num)->m_value = (int)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+28]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+30]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+38]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A73C");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A73D");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+90]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v23+55]");
					bool h2 = (nint)0 != 0;
					((int*)num)->m_value = (int)matrix4x.m00;
					_ = matrix4x.m20;
					_ = matrix4x.m01;
					_ = matrix4x.m21;
					_ = matrix4x.m02;
					_ = matrix4x.m22;
					_ = matrix4x.m03;
					_ = matrix4x.m23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAtlas)+94]");
					((UIWidget)0).SetDimensions(num, h2 ? 1 : 0);
					goto IL_0462;
				}
			}
		}
		_ = 0;
		_ = 0;
		return null;
		IL_0462:
		_ = 0;
		_ = 0;
		return (UISpriteData)1;
	}

	public unsafe string GetRandomSprite(string startsWith)
	{
		//IL_036e: Expected I, but got Obj
		//IL_0384: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		ref int reference = ref *(int*)null;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v99 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string result;
		if (((ComputeShader)(object)mReplacement).FindKernel((string)null) != 0)
		{
			result = mReplacement.GetRandomSprite(startsWith);
		}
		else if (startsWith == null || startsWith.m_stringLength == 0)
		{
			result = null;
		}
		else
		{
			List<UISpriteData> list = mSprites;
			if (list._size == 0)
			{
				bool stickyPress = ((UICamera)this).stickyPress;
			}
			List<UISpriteData> list2 = mSprites;
			if (list2._size != 0)
			{
				Dictionary<string, int> dictionary = mSpriteIndices;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v39 (System.Collections.Generic.Dictionary`2<System.String, System.Int32>)+10]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v39 (System.Collections.Generic.Dictionary`2<System.String, System.Int32>)+1C]");
				object obj2 = num3 - 0;
				List<UISpriteData> list3 = mSprites;
				if ((nint)obj2 != list3._size)
				{
					SortAlphabetically();
				}
				if (mSpriteIndices.TryGetValue(startsWith, out reference))
				{
					if (reference >= 0)
					{
						List<UISpriteData> list4 = mSprites;
						if (reference < list4._size)
						{
							UISpriteData uISpriteData = mSprites.get_Item(reference);
							result = (string)(object)uISpriteData;
							goto IL_03f5;
						}
					}
					SortAlphabetically();
					bool flag = mSpriteIndices.TryGetValue(startsWith, out reference);
					bool flag2 = !flag;
					result = null;
					if (!flag2)
					{
						UISpriteData uISpriteData2 = mSprites.get_Item(reference);
						result = (string)(object)uISpriteData2;
					}
				}
				else
				{
					List<UISpriteData> list5 = mSprites;
					int num4 = 0;
					while (true)
					{
						bool flag3 = num4 >= list5._size;
						result = null;
						if (flag3)
						{
							break;
						}
						UISpriteData uISpriteData3 = mSprites.get_Item(num4);
						string text = uISpriteData3.name;
						bool flag4 = uISpriteData3.name == null || text.m_stringLength == 0;
						if (flag4 || startsWith == uISpriteData3.name)
						{
							int num5 = num4 + 1;
							num4 = num5;
							continue;
						}
						SortAlphabetically();
						result = (string)(object)uISpriteData3;
						break;
					}
				}
			}
			else
			{
				result = null;
			}
		}
		goto IL_03f5;
		IL_03f5:
		return result;
	}

	public void MarkSpriteListAsChanged()
	{
		//IL_005e: Expected F4, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00e1: Expected I4, but got Obj
		//IL_00fc: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		mPixelSize = 8f;
		mReplacement = (UIAtlas)1;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v25 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 8;
		Vector2 one = Vector2.one;
		object obj4 = obj3 + 16;
		obj4 = obj2;
		mCoordinates = (Coordinates)obj4;
		Vector2 one2 = Vector2.one;
		obj4 = obj3;
		mPMA = (int)obj4;
		CancelInvoke();
	}

	public void SortAlphabetically()
	{
		throw new IndexOutOfRangeException();
	}

	public BetterList<string> GetListOfSprites()
	{
		return (BetterList<string>)(object)mReplacement;
	}

	public BetterList<string> GetListOfSprites(string match)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_024a: Expected Obj, but got I4
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02ef: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		string startsWith = default;
		string randomSprite = GetRandomSprite(startsWith);
		List<string> list = default;
		if (randomSprite == null)
		{
			Texture texture = this.texture;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			list._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
			}
			object obj7 = obj4 + 4;
			object obj8 = obj7 + 1;
			obj7 = obj8;
			object obj9 = obj8 << 2;
			object obj10 = obj4 + obj9;
			obj10 = 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj4 + obj11;
				if ((nint)obj12 == 88)
				{
					object obj13 = obj4 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					goto IL_032d;
				}
			}
			object obj15 = default;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_032d;
		}
		string result = default;
		return (BetterList<string>)(object)result;
		IL_032d:
		if (list._size > 0)
		{
			int index = UnityEngine.Random.RandomRangeInt(0, list._size);
			return (BetterList<string>)(object)list.get_Item(index);
		}
		return null;
	}

	private bool References(UIAtlas atlas)
	{
		//IL_047a: Expected I, but got Obj
		//IL_0490: Expected Obj, but got I
		//IL_0018: Expected I, but got Obj
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0228: Expected Obj, but got I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_01fa: Expected Obj, but got I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_0467: Expected Obj, but got I4
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		UIAtlas uIAtlas = this;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v59 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)uIAtlas.mReplacement))
			{
				break;
			}
			uIAtlas = uIAtlas.mReplacement;
		}
		bool result;
		if ((object)atlas == null || ((UnityEngine.Object)atlas).m_CachedPtr == (IntPtr)0)
		{
			bool flag = uIAtlas.Upgrade();
			result = flag;
		}
		else
		{
			List<UISpriteData> list = uIAtlas.mSprites;
			if (list._size == 0)
			{
				bool stickyPress = ((UICamera)(object)uIAtlas).stickyPress;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<UISpriteData> list2 = uIAtlas.mSprites;
			int num3 = 0;
			bool flag2 = default;
			string[] array2 = default;
			while (true)
			{
				if (num3 < list2._size)
				{
					UISpriteData uISpriteData = uIAtlas.mSprites.get_Item(num3);
					if (uISpriteData != null)
					{
						string text = uISpriteData.name;
						if (uISpriteData.name != null && text.m_stringLength != 0)
						{
							string[] array = ((string)(object)atlas).Split((char[])(object)uISpriteData.name, (StringSplitOptions)5);
							if (array != null)
							{
								((BetterList<string>)flag2).Add(uISpriteData.name);
								result = flag2;
								break;
							}
						}
					}
					int num4 = num3 + 1;
					num3 = num4;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj2 = array2 + 16;
				obj2 = 32;
				string[] array3 = ((string)(object)atlas).Split(array2, StringSplitOptions.RemoveEmptyEntries);
				object obj3 = array3 + 12;
				string text2 = null;
				if (System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref text2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
				{
					object obj4 = array3 + 16;
					object obj5 = (object)text2 << 2;
					object obj6 = obj4 + obj5;
					string text3 = ((string)obj6).ToLowerInvariant();
					throw new ArrayTypeMismatchException();
				}
				List<UISpriteData> list3 = uIAtlas.mSprites;
				int num5 = 0;
				int size = list2._size;
				while (true)
				{
					bool flag3 = num5 >= list3._size;
					result = flag2;
					if (flag3)
					{
						break;
					}
					UISpriteData uISpriteData2 = uIAtlas.mSprites.get_Item(num5);
					if (uISpriteData2 != null)
					{
						string text4 = uISpriteData2.name;
						bool flag4 = uISpriteData2.name == null || text4.m_stringLength == 0;
						bool flag5 = !flag4;
						bool flag6 = !flag5;
						text2 = uISpriteData2.name;
						if (!flag6)
						{
							string text5 = uISpriteData2.name.ToLowerInvariant();
							text2 = null;
							size = 0;
							while (size < (nint)obj3)
							{
								object obj7 = array3 + 16;
								int num6 = size << 2;
								object value = obj7 + num6;
								if (text5.EndsWith((string)value))
								{
									string text6 = text2 + 1;
									text2 = text6;
								}
								int num7 = size + 1;
								size = num7;
							}
							if (text2 == obj3)
							{
								((BetterList<string>)flag2).Add(uISpriteData2.name);
							}
						}
					}
					int num8 = num5 + 1;
					num5 = num8;
				}
				break;
			}
		}
		return result;
	}

	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
		//IL_000e: Expected I, but got Obj
		//IL_005b: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_009c: Expected I, but got Obj
		//IL_012a: Expected I, but got Obj
		//IL_0197: Expected I, but got Obj
		//IL_01ad: Expected Obj, but got I
		UIAtlas uIAtlas = default;
		UIAtlas uIAtlas2 = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
			while (true)
			{
				bool flag = b == null;
				bool result = false;
				if (flag)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num3 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag2 = b == uIAtlas.mReplacement;
					result = true;
					if (flag2)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num5 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)uIAtlas2.mReplacement).FindKernel((string)null) != 0)
						{
							uIAtlas2 = uIAtlas.mReplacement;
							nint num6 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj3 = (nint)0 & (nint)0x200;
							if (obj3 != null)
							{
								break;
							}
							continue;
						}
						result = false;
					}
				}
				return result;
			}
		}
	}

	public unsafe void MarkAsChanged()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_01d5: Expected native int or pointer, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_016e: Expected I, but got Obj
		//IL_0184: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UIAtlas+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v40 (Il2CppClass<UIAtlas+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__29_0 == null;
		bool flag2 = !flag;
		Queue<_00210> q = (Queue<_00210>)(object)_003C_003Ec._003C_003E9__29_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v14 (Il2CppClass<UIAtlas+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v34 (Il2CppClass<UIAtlas+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			Queue<_00210> queue = default;
			queue._array = (_00210[])num5;
			queue._size = 0;
			object obj3 = queue + 16;
			obj3 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v31 (Il2CppClass<UIAtlas+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = queue;
			q = queue;
		}
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)mSprites, new Queue<T>.Enumerator((Queue<T>)(object)q));
	}

	private bool Upgrade()
	{
		//IL_000e: Expected I, but got Obj
		//IL_0180: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I4
		UIAtlas uIAtlas = default;
		bool flag = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
			object obj;
			do
			{
				if (((ComputeShader)(object)uIAtlas.mReplacement).FindKernel((string)null) != 0)
				{
					uIAtlas = mReplacement;
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
					obj = (nint)0 & (nint)0x200;
					continue;
				}
				List<UISpriteData> list = uIAtlas.mSprites;
				if (list._size == 0)
				{
					bool stickyPress = ((UICamera)(object)uIAtlas).stickyPress;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				List<UISpriteData> list2 = uIAtlas.mSprites;
				int num3 = 0;
				while (num3 < list2._size)
				{
					UISpriteData uISpriteData = uIAtlas.mSprites.get_Item(num3);
					if (uISpriteData != null)
					{
						string text = uISpriteData.name;
						if (uISpriteData.name != null && text.m_stringLength != 0)
						{
							((BetterList<string>)flag).Add(uISpriteData.name);
						}
					}
					int num4 = num3 + 1;
					num3 = num4;
				}
				return flag;
			}
			while (obj == null);
		}
	}

	public unsafe UIAtlas()
	{
		//IL_0497: Expected I, but got Obj
		//IL_04ad: Expected Obj, but got I
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_04dc: Expected Obj, but got I4
		//IL_00b1: Expected I, but got Obj
		//IL_019b: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got I
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected I, but got Unknown
		//IL_0536: Expected I, but got Obj
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0224: Expected Obj, but got I4
		//IL_01dc: Expected I, but got Obj
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_02e6: Expected I, but got Obj
		//IL_02fc: Expected Obj, but got I
		//IL_05a0: Expected Obj, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0327: Expected I, but got Obj
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_03a5: Expected I, but got Obj
		//IL_03bb: Expected Obj, but got I
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_03e6: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mReplacement).FindKernel((string)null) != 0)
		{
			mReplacement._002Ector();
		}
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v13 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v99 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string typeName = NGUITools.GetTypeName<T>();
		object obj3 = 0;
		while ((nint)obj3 < (int)typeName.m_firstChar)
		{
			object obj4 = typeName + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			UISprite uISprite = (UISprite)obj6;
			if (UICamera.CompareFunc((UICamera)(object)this, (UICamera)(object)uISprite.mAtlas) != 0)
			{
				uISprite.spriteName = null;
				uISprite.spriteName = (string)(object)uISprite.mAtlas;
			}
			object obj7 = obj3 + 1;
			obj3 = obj7;
		}
		nint num5 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v28 (Il2CppClass<System.Type>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v86 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(UIFont);
		nint num7 = (nint)(typeFromHandle + 4);
		((IntPtr*)num7)->m_value = (void*)(nint)typeFromHandle;
		Type path = Type.internal_from_handle((IntPtr)num7);
		UnityEngine.Object obj9 = Resources.Load((string)(object)path);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj10 = 0;
		object obj13 = default;
		while (true)
		{
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v38+C]");
			if ((nint)obj11 >= 0)
			{
				break;
			}
			object obj12 = obj13 + 16;
			object obj14 = obj10 << 2;
			object obj15 = obj12 + obj14;
			Material b = ((UIFont)obj15).material;
			if (UICamera.CompareFunc((UICamera)(object)this, (UICamera)(object)b) != 0)
			{
				Material material = ((UIFont)obj15).material;
				((UIFont)obj15).material = null;
				((UIFont)obj15).material = material;
			}
			object obj16 = obj10 + 1;
			obj10 = obj16;
		}
		nint num8 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v45 (Il2CppClass<NGUITools>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num9 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v73 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string typeName2 = NGUITools.GetTypeName<T>();
		object obj18 = 0;
		while ((nint)obj18 < (int)typeName2.m_firstChar)
		{
			object obj19 = typeName2 + 16;
			object obj20 = obj18 << 2;
			object obj21 = obj19 + obj20;
			UILabel uILabel = (UILabel)obj21;
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)uILabel.mFont).FindKernel((string)null) != 0)
			{
				Material b2 = uILabel.mFont.material;
				if (UICamera.CompareFunc((UICamera)(object)this, (UICamera)(object)b2) != 0)
				{
					uILabel.trueTypeFont = null;
					uILabel.trueTypeFont = (Font)(object)uILabel.mFont;
				}
			}
			object obj23 = obj18 + 1;
			obj18 = obj23;
		}
	}
}
