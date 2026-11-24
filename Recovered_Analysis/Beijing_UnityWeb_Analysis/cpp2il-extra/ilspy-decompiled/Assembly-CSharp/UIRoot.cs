using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using InAppPurchase;
using SYBO.Common;
using UnityEngine;

public class UIRoot : MonoBehaviour
{
	public enum Scaling
	{
		Flexible,
		Constrained,
		ConstrainedOnMobiles
	}

	public enum Constraint
	{
		Fit,
		Fill,
		FitWidth,
		FitHeight
	}

	public static List<UIRoot> list;

	public Scaling scalingStyle;

	public int manualWidth;

	public int manualHeight;

	public int minimumHeight;

	public int maximumHeight;

	public bool fitWidth;

	public bool fitHeight;

	public bool adjustByDPI;

	public bool shrinkPortraitUI;

	private Transform mTrans;

	public unsafe Constraint constraint
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIPanel>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIPanel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return ((InAppPurchaseProvider)(object)this).TryGetLatestRequestedProductInfoForProductId((string)null, out *(ProductRequestResultInfo*)(-1)) ? Constraint.Fill : Constraint.Fit;
		}
	}

	public Scaling activeScaling
	{
		get
		{
			bool flag = fitWidth;
			bool flag2 = fitHeight;
			if (flag)
			{
				if (flag2)
				{
					return Scaling.Flexible;
				}
				return Scaling.ConstrainedOnMobiles;
			}
			if (flag2)
			{
				return (Scaling)3;
			}
			return Scaling.Constrained;
		}
	}

	public int activeHeight
	{
		get
		{
			if (scalingStyle == Scaling.ConstrainedOnMobiles)
			{
				return 0;
			}
			return (int)scalingStyle;
		}
	}

	public float pixelSizeAdjustment
	{
		get
		{
			//IL_000a: Expected I4, but got Obj
			//IL_0017: Expected F4, but got I
			UIRoot uIRoot = default;
			uIRoot.UpdateScale((byte)(int)this != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UIRoot)+4]");
			return 0f;
		}
	}

	public static float GetPixelSizeAdjustment(GameObject go)
	{
		//IL_00d6: Expected I, but got Obj
		//IL_00ec: Expected Obj, but got I
		//IL_015d: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_011a: Expected F4, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ba: Expected VT, but got Obj
		//IL_00ba: Expected VT, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v22 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PropertyBinding propertyBinding = default;
		propertyBinding.Start();
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (PropertyBinding)+4]");
		GUILayoutOption gUILayoutOption = GUILayout.Width(0f);
		if ((nint)gUILayoutOption == -1)
		{
			return 1f;
		}
		return Math3D.AngleVectorPlane((Vector3)go, (Vector3)gUILayoutOption);
	}

	public float GetPixelSizeAdjustment(int height)
	{
		//IL_015e: Expected F4, but got I
		//IL_0031: Expected I, but got Obj
		//IL_0047: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_0072: Expected I, but got Obj
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRoot)+110]");
		if ((nint)0 != height)
		{
			UIRoot root = ((UIRect)this).root;
			UIRoot root2 = ((UIRect)this).root;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)root2).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9CD6");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRoot)+D4]");
				object obj3 = default;
				object obj2 = obj3 * 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRoot)+D4]");
				object obj2 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRoot)+4C]");
		return 0f;
	}

	protected unsafe virtual void Awake()
	{
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected VT, but got Unknown
		//IL_01fd: Expected Ref, but got VT
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0218: Expected Obj, but got F4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_0291: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got F4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0304: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got F4
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got I4
		//IL_036c: Expected Obj, but got F4
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_03a3: Expected I, but got Obj
		//IL_03b9: Expected Obj, but got I
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_0071: Expected I, but got Obj
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_00be: Expected I, but got Obj
		//IL_0159: Expected I, but got Obj
		_ = 1;
		_ = 1;
		_ = 1;
		_ = 3000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 108;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj3 = this + 112;
		object obj4 = default;
		obj3 = obj4;
		nint num = (nint)typeof(Matrix4x4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (Il2CppClass<UnityEngine.Matrix4x4>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Matrix4x4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v105 (Il2CppClass<UnityEngine.Matrix4x4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = default;
		Vector3 vector = (Vector3)(obj6 + 72);
		((Vector3*)vector)->Normalize();
		object obj7 = obj6 + 136;
		obj7 = vector.x;
		_ = vector.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (UnityEngine.Vector3)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (UnityEngine.Vector3)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (UnityEngine.Vector3)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (UnityEngine.Vector3)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9CDA");
		object obj8 = obj6 + 56;
		obj8 = 0;
		_ = 0;
		obj8 = 0f;
		_ = 0f;
		_ = 1f;
		_ = 1f;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v40+8]");
		_ = 0;
		object obj9 = this + 180;
		obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30+8]");
		_ = 0;
		_ = 1f;
		object obj10 = obj6 + 40;
		obj10 = 0;
		_ = 0;
		obj10 = 0f;
		_ = 0f;
		_ = 300f;
		_ = 200f;
		obj7 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v53+8]");
		_ = 0;
		object obj11 = this + 220;
		obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30+8]");
		_ = 0;
		obj6 = 0;
		obj6 = 4f;
		_ = 4f;
		object obj12 = obj6 + 32;
		obj12 = obj6;
		obj7 = obj12;
		nint num3 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v72 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v101 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj14 = obj6 + 24;
		Vector2 one = Vector2.one;
		obj7 = obj14;
		_ = -1;
		_ = -1;
		object obj15 = obj6 + 16;
		Vector2 one2 = Vector2.one;
		obj7 = obj15;
		object obj16 = obj6 + 8;
		Vector2 one3 = Vector2.one;
		obj7 = obj16;
		nint num5 = (nint)typeof(UIRect);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v91 (Il2CppClass<UIRect>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num6 = (nint)typeof(UIRect);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v97 (Il2CppClass<UIRect>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UISnapshotPoint)this).Start();
	}

	protected virtual void OnEnable()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 36;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
	}

	protected virtual void OnDisable()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIRoot>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UIRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
	}

	protected virtual void Start()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIRoot>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UIRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
	}

	private void Update()
	{
		//IL_01b5: Expected I, but got Obj
		//IL_01cb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0139: Expected I, but got Obj
		_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)this).GetComponentsInChildren<T>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)componentsInChildren).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v40 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogWarningFormat("UIRoot should not be active at the same time as UIOrthoCamera. Disabling UIOrthoCamera.", (object[])(object)componentsInChildren);
			string text = ((Component)(object)componentsInChildren).tag;
			Camera component = ((GameObject)(object)text).GetComponent<Camera>();
			((Component)(object)componentsInChildren).tag = null;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				component.depth = 1f;
			}
		}
		else
		{
			Broadcast((string)(object)this, null);
		}
	}

	public void UpdateScale(bool updateAnchors = true)
	{
		//IL_005a: Expected I, but got Obj
		//IL_0070: Expected Obj, but got I
		//IL_0013: Expected Obj, but got I4
		//IL_0021: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I
		//IL_009b: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [updateAnchors @ L1 (System.Boolean)+D8]");
		if ((nint)0 != 0)
		{
			object obj = (updateAnchors ? 1 : 0) + 220;
			object obj2 = (updateAnchors ? 1 : 0) + 220;
			UIRoot uIRoot = (UIRoot)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v19+8]");
			uIRoot = (UIRoot)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v22+C]");
			_ = 0;
			return;
		}
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v14 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((PropertyBinding)this).Start();
	}

	public static void Broadcast(string funcName)
	{
		//IL_000e: Expected Obj, but got I4
		Broadcast(funcName, 1);
	}

	public static void Broadcast(string funcName, object param)
	{
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02d3: Expected Obj, but got I4
		//IL_02e7: Expected I, but got Obj
		//IL_02fd: Expected Obj, but got I
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		//IL_0492: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009c: Expected VT, but got I
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I4
		//IL_0388: Expected Obj, but got F4
		//IL_03c4: Expected Obj, but got I
		//IL_010f: Expected I, but got Obj
		//IL_0179: Expected I, but got Obj
		//IL_018f: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I4
		//IL_01ba: Expected I, but got Obj
		//IL_0224: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_0265: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [funcName @ L0 (System.String)+24]");
		if (((ComputeShader)0).FindKernel(null) == 0)
		{
			return;
		}
		Texture mainTexture = ((UISprite)(object)funcName).mainTexture;
		if ((nint)mainTexture <= 0)
		{
			return;
		}
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [funcName @ L0 (System.String)+24]");
		transform2.localScale = (Vector3)0;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		obj2 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v23 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v71 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num5 = 2f / (float)mainTexture;
		float value = (float)obj2 - num5;
		float num6 = Math.Abs(value);
		if (!(num6 > float.Epsilon))
		{
			transform = (Transform)obj;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v46 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v67 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (UnityEngine.Transform)+4]");
			float value2 = 0f - num5;
			float num9 = Math.Abs(value2);
			if (!(num9 > float.Epsilon))
			{
				transform = (Transform)obj;
				Transform transform4 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				nint num10 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v57 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num11 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v63 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float value3 = (float)(nint)((UnityEngine.Object)transform).m_CachedPtr - num5;
				float num12 = Math.Abs(value3);
				if (!(num12 > float.Epsilon))
				{
					return;
				}
			}
		}
		obj2 = 0;
		_ = 0;
		obj2 = num5;
		transform = (Transform)obj2;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [funcName @ L0 (System.String)+24]");
		((Transform)0).parent = transform;
		if (param != null)
		{
			((GameObject)(object)funcName)._002Ector("UpdateAnchors", (Type[])1);
		}
	}

	public UIRoot()
	{
		//IL_0164: Expected I, but got Obj
		//IL_017a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01b7: Expected I, but got Obj
		//IL_01cd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I4
		nint num = (nint)typeof(UIRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIRoot>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v49 (Il2CppClass<UIRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<UIRoot> list = UIRoot.list;
		int num3 = default;
		int num8 = default;
		while (num3 < list._size)
		{
			nint num4 = (nint)typeof(UIRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v20 (Il2CppClass<UIRoot>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(UIRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v43 (Il2CppClass<UIRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIRoot uIRoot = UIRoot.list.get_Item(num3);
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)uIRoot).FindKernel((string)null) != 0)
			{
				((GameObject)(object)uIRoot)._002Ector((string)(object)this, (Type[])1);
			}
			num3 = num8 + 1;
		}
	}

	static UIRoot()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0049: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		List<UIPanel> list = default;
		UIPanel.list = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v15 (Il2CppClass<UIPanel>)+5C]");
		object obj = (nint)0 + (nint)4;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num2 = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v22 (Il2CppClass<UIPanel>)+5C]");
		object obj3 = (nint)0 + (nint)8;
		object obj4 = default;
		obj3 = obj4;
		UIPanel.mUpdateFrame = -1;
	}
}
