using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using UnityEngine;

public class ScrollViewHeightResizer : MonoBehaviour
{
	private GameObject _scrollBar;

	private GameObject _scrollCollider;

	private UIPanel _scrollPanel;

	private GameObject _grid;

	private float _staticObjectsHeight;

	private float _centerOffset;

	private float _topStaticObjectsHeight;

	private bool _addTopCollider;

	private bool _addBottomcollider;

	private float _zDepth;

	private bool isCalculated;

	private UITable _table;

	private Action m_onRearrangedScrollView;

	private bool rearrange;

	public float staticObjectsHeight
	{
		get
		{
			//IL_0007: Expected F4, but got I4
			return isCalculated ? 1 : 0;
		}
		set
		{
			//IL_000a: Expected I4, but got F4
			isCalculated = (byte)(int)value != 0;
		}
	}

	public float topStaticObjectsHeight
	{
		get
		{
			return _staticObjectsHeight;
		}
		set
		{
			_staticObjectsHeight = value;
		}
	}

	public Vector4 clipping
	{
		get
		{
			//IL_0034: Expected Obj, but got I
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector4)+38]");
			Delegate obj = (Delegate)0;
			Vector4 vector = default;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)(object)this);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = vector + 56;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 == obj)
				{
					break;
				}
				obj = (Delegate)obj3;
			}
			return vector;
		}
	}

	public float Height
	{
		get
		{
			return _topStaticObjectsHeight;
		}
		set
		{
			_topStaticObjectsHeight = value;
		}
	}

	public Vector3 scrollPanelPosition
	{
		get
		{
			if (~(isCalculated ? 1u : 0u) != 0)
			{
				AddColliders();
			}
			Vector2 clipSoftness = _scrollPanel.clipSoftness;
			Vector3 result = default;
			return result;
		}
	}

	public event Action onRearrangedScrollView
	{
		add
		{
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected Obj, but got Unknown
			//IL_0062: Expected I4, but got Obj
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected Obj, but got Unknown
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected Obj, but got Unknown
			//IL_0031: Expected I4, but got Obj
			//IL_0145: Expected F4, but got I4
			object obj = ((Delegate)value).m_target - (nint)((Delegate)value).extra_arg;
			int fontSize;
			if ((nint)obj == 1)
			{
				Dictionary<string, string>.ValueCollection values = ((Dictionary<string, string>)(object)value).Values;
				string text = Enumerable.ElementAt(values, 0);
				fontSize = (int)text;
			}
			else
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args = default;
				string text2 = $"{args} selected";
				fontSize = (int)text2;
			}
			((UILabel)(object)_grid).fontSize = fontSize;
			object obj3 = this + 40;
			obj3 = value;
			object obj4 = this + 36;
			string text3;
			if ((nint)obj > 0)
			{
				Dictionary<string, string>.ValueCollection values2 = ((Dictionary<string, string>)(object)value).Values;
				text3 = Enumerable.ElementAt(values2, 0);
			}
			else
			{
				text3 = "";
			}
			obj4 = text3;
			_centerOffset = 1f;
			((ScrollPanelPixelPerfect)this).Start();
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onRearrangedScrollView;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 56;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private void Update()
	{
		CancelInvoke();
	}

	private void Start()
	{
		if (~(rearrange ? 1u : 0u) == 0)
		{
			AddColliders();
			rearrange = false;
		}
	}

	public void RearrangeWidgets()
	{
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0270: Expected Obj, but got VT
		//IL_027e: Expected I, but got Obj
		//IL_0294: Expected Obj, but got I
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_00b1: Expected I, but got Obj
		//IL_01ac: Expected I, but got Obj
		//IL_01c2: Expected Obj, but got I
		//IL_014f: Expected I, but got Obj
		//IL_01ed: Expected I, but got Obj
		rearrange = false;
		object obj = this + 52;
		_0021_00210 componentInChildren = (_0021_00210)_grid.GetComponentInChildren<T>();
		obj = componentInChildren;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v52 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_scrollBar != null)
		{
			SDebug.LogFormat("ScrollBar not set in ScrollViewHeightResizer", null);
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_scrollCollider != null)
		{
			SDebug.LogFormat("ScrollCollider not set in ScrollViewHeightResizer", null);
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_scrollPanel != null)
		{
			SDebug.LogFormat("ScrollPanel not set in ScrollViewHeightResizer", null);
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_grid != null)
		{
			SDebug.LogFormat("Grid not set in ScrollViewHeightResizer", null);
		}
		AddColliders();
	}

	private void AddColliders()
	{
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected Obj, but got Unknown
		//IL_0710: Expected Obj, but got I4
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected Obj, but got Unknown
		//IL_072d: Expected Obj, but got I4
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Obj, but got Unknown
		//IL_074a: Expected Obj, but got I4
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected Obj, but got Unknown
		//IL_0767: Expected Obj, but got I4
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected Obj, but got Unknown
		//IL_0784: Expected Obj, but got I4
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected Obj, but got Unknown
		//IL_07a1: Expected Obj, but got I4
		//IL_07b5: Expected I, but got Obj
		//IL_07cb: Expected Obj, but got I
		//IL_0a48: Expected I, but got Obj
		//IL_0a5e: Expected Obj, but got I
		//IL_07f2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_083f: Expected I, but got Obj
		//IL_0855: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0aae: Expected Obj, but got I
		//IL_0ae6: Expected I, but got Obj
		//IL_0afc: Expected Obj, but got I
		//IL_082c: Expected Obj, but got I
		//IL_0145: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected Obj, but got Unknown
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Expected Obj, but got Unknown
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected Obj, but got Unknown
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Expected Obj, but got Unknown
		//IL_0950: Expected VT, but got Obj
		//IL_0192: Expected I, but got Obj
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0296: Expected Obj, but got VT
		//IL_01df: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_031b: Expected VT, but got I4
		//IL_0964: Expected Obj, but got I4
		//IL_0220: Expected I, but got Obj
		//IL_038c: Expected Obj, but got I
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03e0: Expected VT, but got I4
		//IL_0456: Expected VT, but got I4
		//IL_04ab: Expected Obj, but got I4
		//IL_04be: Expected I, but got Obj
		//IL_04d4: Expected Obj, but got I
		//IL_055a: Expected VT, but got I4
		//IL_04ff: Expected I, but got Obj
		//IL_059d: Expected I, but got Obj
		//IL_05b3: Expected Obj, but got I
		//IL_05de: Expected I, but got Obj
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected Obj, but got Unknown
		//IL_0639: Expected I, but got Obj
		//IL_064f: Expected Obj, but got I
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected Obj, but got Unknown
		//IL_067a: Expected I, but got Obj
		Transform transform = default;
		object obj = transform + 144;
		obj = 0;
		_ = 0;
		object obj2 = transform + 128;
		obj2 = 0;
		_ = 0;
		object obj3 = transform + 116;
		obj3 = 0;
		_ = 0;
		object obj4 = transform + 104;
		obj4 = 0;
		_ = 0;
		object obj5 = transform + 92;
		obj5 = 0;
		_ = 0;
		object obj6 = transform + 80;
		obj6 = 0;
		_ = 0;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v189 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v166 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj10;
		if (((ComputeShader)flag).FindKernel(null) != 0)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v178 (Il2CppClass<UIScreenController>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v185 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v183 (System.Boolean)+3C]");
			obj10 = (UnityEngine.Object)0;
		}
		else
		{
			obj10 = null;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v172 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = obj10 != null;
		_0021_00210 componentInChildren = (_0021_00210)_scrollBar.GetComponentInChildren<T>();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v34 (UnityEngine.Object)+14]");
		object obj12 = (nint)0 / (nint)2;
		float num9 = (float)obj12 + _centerOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v34 (UnityEngine.Object)+14]");
		float num10 = 0f - _staticObjectsHeight;
		nint num11 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v53 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num12 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v168 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = IPhoneXSupport.CheckIsiPhoneXDevice();
		bool flag5 = !flag4;
		float width = num10;
		if (!flag5)
		{
			nint num13 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v156 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num14 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v162 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj15 = IPhoneXSupport.OFFSET_TOP + IPhoneXSupport.OFFSET_BOTTOM;
			float num15 = num10 - (float)obj15;
			width = num15;
		}
		object obj16 = transform - -64;
		object obj17 = _scrollPanel + 220;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v43+8]");
		_ = 0;
		obj = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v61+8]");
		_ = 0;
		UIPanel uIPanel = (UIPanel)(transform + 160);
		uIPanel = (UIPanel)obj;
		UIPanel uIPanel2 = uIPanel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)uIPanel2).m_CachedPtr = (IntPtr)0;
		Vector4 finalClipRegion = uIPanel.finalClipRegion;
		Transform transform2 = (Transform)(transform + 48);
		GameObject gameObject = _scrollPanel.gameObject;
		transform2.localPosition = (Vector3)gameObject;
		obj2 = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		object obj18 = transform + 40;
		UIPanel scrollPanel = _scrollPanel;
		obj18 = scrollPanel.mClipOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v74+4]");
		float num16 = 0f * -1f;
		GameObject gameObject2 = _scrollPanel.gameObject;
		uIPanel = (UIPanel)obj2;
		UIPanel uIPanel3 = uIPanel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((UnityEngine.Object)uIPanel3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = ((Transform)(object)uIPanel).eulerAngles;
		Transform transform3 = (Transform)(transform + 24);
		int layer = _grid.layer;
		transform3.localPosition = (Vector3)layer;
		obj3 = transform3;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		_ = 0f;
		int layer2 = _grid.layer;
		uIPanel = (UIPanel)obj3;
		UIPanel uIPanel4 = uIPanel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((UnityEngine.Object)uIPanel4).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = ((Transform)(object)uIPanel).eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v34 (UnityEngine.Object)+14]");
		object obj19 = (nint)0 / (nint)2;
		float num17 = (float)obj19 + _centerOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v34 (UnityEngine.Object)+14]");
		float num18 = 0f - _staticObjectsHeight;
		Transform transform4 = (Transform)(transform + 12);
		int layer3 = _scrollCollider.layer;
		transform4.localPosition = (Vector3)layer3;
		obj4 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		int layer4 = _scrollCollider.layer;
		uIPanel = (UIPanel)obj4;
		UIPanel uIPanel5 = uIPanel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		((UnityEngine.Object)uIPanel5).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles3 = ((Transform)(object)uIPanel).eulerAngles;
		int layer5 = _scrollCollider.layer;
		transform.localScale = (Vector3)layer5;
		obj5 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		int layer6 = _scrollCollider.layer;
		uIPanel = (UIPanel)obj5;
		UIPanel uIPanel6 = uIPanel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
		((UnityEngine.Object)uIPanel6).m_CachedPtr = (IntPtr)0;
		((Transform)layer6).parent = (Transform)(object)uIPanel;
		nint num19 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S1_v122 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num20 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S1_v155 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		Color color = ((UIWidget)(object)gUILayoutOption).color;
		Color color2 = ((UIWidget)(object)gUILayoutOption).color;
		int layer7 = _scrollBar.layer;
		((Transform)(object)uIPanel).localPosition = (Vector3)layer7;
		obj6 = uIPanel;
		_ = ((UnityEngine.Object)uIPanel).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v34 (UnityEngine.Object)+14]");
		float num21 = 0f - _topStaticObjectsHeight;
		nint num22 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S0_v117 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num23 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v151 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			object obj22 = obj6 + 4;
			nint num24 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v140 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num25 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S0_v145 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj24 = obj22 - IPhoneXSupport.OFFSET_TOP;
			obj22 = obj24;
		}
		int layer8 = _scrollBar.layer;
		uIPanel = (UIPanel)obj6;
		UIPanel uIPanel7 = uIPanel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
		((UnityEngine.Object)uIPanel7).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles4 = ((Transform)(object)uIPanel).eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		this._002Ector();
		isCalculated = true;
		if (this.m_onRearrangedScrollView != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public ScrollViewHeightResizer()
	{
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_0556: Expected Obj, but got I4
		//IL_056a: Expected I, but got Obj
		//IL_0580: Expected Obj, but got I
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected Obj, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected Obj, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I4
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I4
		//IL_0333: Expected I, but got Obj
		//IL_0349: Expected Obj, but got I
		//IL_05b4: Expected Obj, but got I4
		//IL_05fd: Expected Obj, but got I4
		//IL_0130: Expected I4, but got Obj
		//IL_0130: Expected Obj, but got I4
		//IL_00e3: Expected I, but got Obj
		//IL_03c1: Expected I4, but got Obj
		//IL_03c1: Expected Obj, but got I4
		//IL_0374: Expected I, but got Obj
		//IL_015a: Expected VT, but got I4
		//IL_03e2: Expected VT, but got I4
		//IL_017b: Expected VT, but got I4
		//IL_0403: Expected VT, but got I4
		//IL_0469: Expected VT, but got I4
		//IL_0472: Expected Obj, but got I4
		//IL_021d: Expected VT, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_0484: Expected Obj, but got I4
		//IL_0493: Expected Obj, but got F4
		//IL_04e5: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got F4
		//IL_0289: Expected Obj, but got I4
		//IL_04f7: Expected Obj, but got I4
		//IL_0505: Expected Obj, but got I4
		//IL_053a: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 60;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v81 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 48);
		Transform transform2 = (Transform)(obj2 + 36);
		Transform transform3 = (Transform)(obj2 + 24);
		object obj4 = obj2 + 12;
		BoxCollider boxCollider = (BoxCollider)(obj2 + 72);
		Vector3 one = Vector3.one;
		obj = boxCollider;
		_ = ((UnityEngine.Object)boxCollider).m_CachedPtr;
		_ = _zDepth;
		if (~(isCalculated ? 1u : 0u) == 0)
		{
			return;
		}
		if (~(_addTopCollider ? 1u : 0u) == 0)
		{
			string text = tag;
			int layer = ((GameObject)(object)text).layer;
			string go = ((Component)layer).tag;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v73 (Il2CppClass<NGUITools>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v114 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = NGUITools.CalculateRaycastDepth((GameObject)(object)go);
			BoxCollider boxCollider2 = ((GameObject)num5).AddComponent<BoxCollider>();
			boxCollider = (BoxCollider)obj;
			BoxCollider boxCollider3 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)boxCollider3).m_CachedPtr = (IntPtr)0;
			Vector3 size = boxCollider.size;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num5, (byte)(int)"TopScrollBlocker" != 0);
			int sleepTimeout = Screen.sleepTimeout;
			int layer2 = _scrollCollider.layer;
			transform.localPosition = (Vector3)layer2;
			int layer3 = _scrollCollider.layer;
			transform2.localScale = (Vector3)layer3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (UnityEngine.Transform)+4]");
			float num6 = 0f * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17 (UnityEngine.Transform)+4]");
			float num7 = 0f + num6;
			float num8 = (float)sleepTimeout - num7;
			int sleepTimeout2 = Screen.sleepTimeout;
			float num9 = num8 * 0.5f;
			float num10 = (float)sleepTimeout2 - num9;
			int height = Screen.height;
			string text2 = tag;
			int layer4 = ((GameObject)(object)text2).layer;
			transform3.localPosition = (Vector3)layer4;
			int layer5 = ((GameObject)num5).layer;
			obj4 = 0;
			_ = 0;
			obj4 = 0f;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			boxCollider = (BoxCollider)obj4;
			BoxCollider boxCollider4 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
			((UnityEngine.Object)boxCollider4).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = ((Transform)(object)boxCollider).eulerAngles;
			int layer6 = ((GameObject)num5).layer;
			obj2 = 0;
			_ = 0;
			obj2 = height;
			_ = 1f;
			boxCollider = (BoxCollider)obj2;
			BoxCollider boxCollider5 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)boxCollider5).m_CachedPtr = (IntPtr)0;
			((Transform)layer6).parent = (Transform)(object)boxCollider;
		}
		if (~(_addBottomcollider ? 1u : 0u) != 0)
		{
			return;
		}
		string text3 = tag;
		int layer7 = ((GameObject)(object)text3).layer;
		string go2 = ((Component)layer7).tag;
		nint num11 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v25 (Il2CppClass<NGUITools>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v65 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num13 = NGUITools.CalculateRaycastDepth((GameObject)(object)go2);
		BoxCollider boxCollider6 = ((GameObject)num13).AddComponent<BoxCollider>();
		boxCollider = (BoxCollider)obj;
		BoxCollider boxCollider7 = boxCollider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)boxCollider7).m_CachedPtr = (IntPtr)0;
		Vector3 size2 = boxCollider.size;
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num13, (byte)(int)"BottomScrollBlocker" != 0);
		int layer8 = _scrollCollider.layer;
		transform.localPosition = (Vector3)layer8;
		int layer9 = _scrollCollider.layer;
		transform2.localScale = (Vector3)layer9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (UnityEngine.Transform)+4]");
		float num14 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17 (UnityEngine.Transform)+4]");
		float num15 = 0f - num14;
		int height2 = Screen.height;
		string text4 = tag;
		int layer10 = ((GameObject)(object)text4).layer;
		transform3.localPosition = (Vector3)layer10;
		int layer11 = ((GameObject)num13).layer;
		obj4 = 0;
		_ = 0;
		obj4 = 0f;
		float num16 = num15 * 0.5f;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		boxCollider = (BoxCollider)obj4;
		BoxCollider boxCollider8 = boxCollider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
		((UnityEngine.Object)boxCollider8).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = ((Transform)(object)boxCollider).eulerAngles;
		int layer12 = ((GameObject)num13).layer;
		obj2 = 0;
		_ = 0;
		obj2 = height2;
		_ = 1f;
		boxCollider = (BoxCollider)obj2;
		BoxCollider boxCollider9 = boxCollider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)boxCollider9).m_CachedPtr = (IntPtr)0;
		((Transform)layer12).parent = (Transform)(object)boxCollider;
	}
}
