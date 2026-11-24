using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class UITooltip : MonoBehaviour
{
	protected static UITooltip mInstance;

	public Camera uiCamera;

	public UILabel text;

	public GameObject tooltipRoot;

	public UISprite background;

	public float appearSpeed;

	public bool scalingTransitions;

	protected GameObject mTooltip;

	protected Transform mTrans;

	protected float mTarget;

	protected float mCurrent;

	protected Vector3 mPos;

	protected Vector3 mSize;

	protected UIWidget[] mWidgets;

	public static bool isVisible
	{
		get
		{
			//IL_0196: Expected I, but got Obj
			//IL_01ac: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_01e9: Expected I, but got Obj
			//IL_01ff: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			nint num = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIPanel>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v57 (Il2CppClass<UIPanel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<UIPanel> list = UIPanel.list;
			int num3 = int.MinValue;
			int num4 = default;
			int num9 = default;
			while (num4 < list._size)
			{
				nint num5 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27 (Il2CppClass<UIPanel>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num6 = (nint)typeof(UIPanel);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v51 (Il2CppClass<UIPanel>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIPanel uIPanel = UIPanel.list.get_Item(num4);
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v37 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v47 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (num3 <= uIPanel.mDepth)
				{
					num3 = uIPanel.mDepth;
				}
				num4 = num9 + 1;
			}
			if (num3 == int.MinValue)
			{
				return false;
			}
			return (byte)(num3 + 1) != 0;
		}
	}

	private void Awake()
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got F4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0128: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01b7: Expected I, but got Obj
		//IL_01cd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		MessageEventArgs e = default;
		object obj = e + 16;
		obj = 0;
		_ = 0;
		obj = 0f;
		_ = 0f;
		_ = 1f;
		_ = 1f;
		object obj2 = e + 32;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj3 = this + 396;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+8]");
		_ = 0;
		nint num = (nint)typeof(Vector4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v22 (Il2CppClass<UnityEngine.Vector4>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v45 (Il2CppClass<UnityEngine.Vector4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		e._002Ector();
		obj2 = e;
		_ = e.playerId;
		object obj5 = this + 420;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+8]");
		_ = 0;
		_ = 1f;
		_ = -1;
		nint num3 = (nint)typeof(UIBasicSprite);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35 (Il2CppClass<UIBasicSprite>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v41 (Il2CppClass<UIBasicSprite>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UIDrawCall)this).CreateMaterial();
	}

	private void OnDestroy()
	{
		mInstance = this;
	}

	protected virtual void Start()
	{
		mInstance = null;
	}

	protected virtual void Update()
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_017f: Expected VT, but got Obj
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01cd: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got I4
		//IL_00bd: Expected I, but got Obj
		object obj = this + 40;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		object obj2 = this + 76;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v2 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v39 @ S4_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		obj2 = obj7;
		Transform transform = default;
		transform.localPosition = (Vector3)mTrans;
		object obj8 = transform + 12;
		obj8 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj9 = this + 52;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v14+8]");
		_ = 0;
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (uiCamera != null)
		{
			string text = tag;
			bool activeSelf = ((GameObject)(object)text).activeSelf;
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v29 (Il2CppClass<NGUITools>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num5 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v35 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj12 = this + 12;
			string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
			obj12 = typeName;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
	}

	protected virtual void SetAlpha(float val)
	{
	}

	protected unsafe virtual void SetText(string tooltipText)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected I, but got Unknown
		//IL_0066: Expected I, but got Obj
		//IL_00a7: Expected I, but got Obj
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I
		object obj = this + 328;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
		_ = 0;
		Gradient gradient = (Gradient)(obj2 + 16);
		gradient = (Gradient)obj2;
		Gradient gradient2 = gradient;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		gradient2.m_Ptr = (IntPtr)0;
		nint num = (nint)(obj2 + 32);
		((IntPtr*)num)->m_value = (void*)(nint)tooltipText;
		_ = tooltipText.m_stringLength;
		if (gradient.Internal_Equals((IntPtr)num))
		{
			((IntPtr*)num)->m_value = (void*)(nint)tooltipText;
			_ = tooltipText.m_stringLength;
			object obj3 = this + 328;
			obj3 = (object)((IntPtr*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v10 (System.IntPtr)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+134]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public unsafe static void ShowText(string text)
	{
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_03c8: Expected Obj, but got I4
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03e5: Expected Obj, but got I4
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected Obj, but got Unknown
		//IL_0402: Expected Obj, but got I4
		//IL_0416: Expected I, but got Obj
		//IL_042c: Expected Obj, but got I
		//IL_073e: Expected I, but got Obj
		//IL_0754: Expected Obj, but got I
		//IL_045e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected VT, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected VT, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Obj, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected Obj, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_058b: Expected F4, but got I
		//IL_058b: Expected F4, but got I
		//IL_0605: Expected Obj, but got I
		//IL_0119: Expected I, but got Obj
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_019b: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got I
		//IL_0641: Expected F4, but got Obj
		//IL_063c: Expected native int or pointer, but got VT
		//IL_0656: Expected F4, but got I
		//IL_0651: Expected native int or pointer, but got VT
		//IL_06a3: Expected Obj, but got I
		//IL_06d3: Expected F4, but got Obj
		//IL_06ce: Expected native int or pointer, but got VT
		//IL_06e8: Expected F4, but got I
		//IL_06e3: Expected native int or pointer, but got VT
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0260: Expected F4, but got Obj
		//IL_025b: Expected native int or pointer, but got VT
		//IL_0275: Expected F4, but got I
		//IL_0270: Expected native int or pointer, but got VT
		//IL_0282: Expected F4, but got Obj
		//IL_027d: Expected native int or pointer, but got VT
		//IL_0297: Expected F4, but got I
		//IL_0292: Expected native int or pointer, but got VT
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02d8: Expected F4, but got Obj
		//IL_02d3: Expected native int or pointer, but got VT
		//IL_02ed: Expected F4, but got I
		//IL_02e8: Expected native int or pointer, but got VT
		//IL_02fa: Expected F4, but got Obj
		//IL_02f5: Expected native int or pointer, but got VT
		//IL_030f: Expected F4, but got I
		//IL_030a: Expected native int or pointer, but got VT
		//IL_0328: Expected F4, but got I
		//IL_01dc: Expected I, but got Obj
		//IL_0353: Expected F4, but got Obj
		//IL_034e: Expected native int or pointer, but got VT
		//IL_0368: Expected F4, but got I
		//IL_0363: Expected native int or pointer, but got VT
		//IL_0371: Expected Obj, but got VT
		//IL_0382: Expected F4, but got Obj
		//IL_037d: Expected native int or pointer, but got VT
		//IL_0397: Expected F4, but got I
		//IL_0392: Expected native int or pointer, but got VT
		//IL_03ac: Expected Obj, but got VT
		//IL_03ac: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 144;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 132;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 120;
		obj4 = 0;
		_ = 0;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v13 (Il2CppClass<UICamera>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v121 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A6EF");
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S2_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+24]");
		string text2 = default;
		if (((ComputeShader)0).FindKernel(text2) != 0)
		{
			object obj7 = text + 36;
			obj7 = 0;
			_ = 0f;
		}
		Vector3 vector = (Vector3)(obj2 + 168);
		Vector3 vector2 = (Vector3)(obj2 + 156);
		object obj8 = obj2 + 96;
		object obj9 = obj2 + 84;
		object obj10 = obj2 + 72;
		object obj11 = obj2 + 60;
		object obj12 = obj2 + 48;
		object obj13 = obj2 + 108;
		object obj14 = obj2 + 36;
		object obj15 = obj2 + 24;
		object obj16 = obj2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+30]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+2C]");
		if (num5 == 0)
		{
			return;
		}
		float fixedDeltaTime = Time.fixedDeltaTime;
		nint num6 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v57 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v123 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num8 = fixedDeltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+1C]");
		float t = num8 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+30]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+2C]");
		float num10 = Mathf.LerpUnclamped(num9, 0f, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+30]");
		float num11 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+2C]");
		float value = num11 - 0f;
		float num12 = Math.Abs(value);
		if (num12 < 0.001f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+2C]");
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+30]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+30]");
		object obj18 = num13 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+20]");
		if ((nint)0 == 0)
		{
			return;
		}
		object obj19 = text - -64;
		obj8 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v43+8]");
		_ = 0;
		nint num14 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v74 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num15 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v118 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v26+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector3 = vector / 0.25f;
		obj = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v28+8]");
		_ = 0;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v28+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v30+4]");
		object obj21 = -0;
		Vector3 forward = Vector3.forward;
		obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v32+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v36+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+30]");
		float num16 = 0f * 0.5f;
		float num17 = 1.5f - num16;
		Vector3 vector4 = vector / num17;
		obj3 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v34+8]");
		_ = 0;
		object obj22 = text + 52;
		obj14 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S1_v79+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = (float)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v38+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
		object obj23 = text + 52;
		obj16 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S1_v93+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = (float)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v40+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v42+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+30]");
		Vector3 vector5 = Vector3.LerpUnclamped(vector2, vector, 0f);
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+28]");
		((Transform)0).parent = (Transform)vector;
	}

	public static void Show(string text)
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mInstance).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	public static void Hide()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		Dictionary<string, BetterList<UITextList.Paragraph>> mHistory = default;
		UITextList.mHistory = mHistory;
	}

	public UITooltip()
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mInstance).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}
}
