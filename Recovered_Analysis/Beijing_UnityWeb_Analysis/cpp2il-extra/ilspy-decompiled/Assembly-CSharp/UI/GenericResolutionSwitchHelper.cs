using System;
using Cpp2ILInjected;
using UnityEngine;

namespace UI;

public class GenericResolutionSwitchHelper : MonoBehaviour
{
	public string highResName;

	private bool _inited = true;

	private void Start()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 32;
		object obj2 = default;
		obj = obj2;
		CancelInvoke();
	}

	private void Init()
	{
		if (~(_inited ? 1u : 0u) != 0)
		{
			this._002Ector();
		}
	}

	public GenericResolutionSwitchHelper()
	{
		//IL_06ff: Expected I, but got Obj
		//IL_0715: Expected Obj, but got I
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected Obj, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected Obj, but got Unknown
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Expected Obj, but got Unknown
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_006b: Expected I4, but got Obj
		//IL_0095: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got F4
		//IL_0112: Expected Obj, but got I4
		//IL_0145: Expected VT, but got Obj
		//IL_0161: Expected VT, but got Obj
		//IL_017d: Expected VT, but got Obj
		//IL_018b: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got F4
		//IL_0236: Expected I, but got Obj
		//IL_024c: Expected Obj, but got I
		//IL_0277: Expected I, but got Obj
		//IL_0446: Expected I, but got Obj
		//IL_045c: Expected Obj, but got I
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02e9: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got F4
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected Obj, but got Unknown
		//IL_03a1: Expected Obj, but got I4
		//IL_03c7: Expected Obj, but got F4
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_0791: Expected Obj, but got VT
		//IL_0487: Expected I, but got Obj
		//IL_0656: Expected I, but got Obj
		//IL_066c: Expected Obj, but got I
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Obj, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_04f9: Expected Obj, but got I4
		//IL_0517: Expected Obj, but got F4
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Obj, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected Obj, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected Obj, but got Unknown
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got Unknown
		//IL_05b1: Expected Obj, but got I4
		//IL_05d7: Expected Obj, but got F4
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected Obj, but got Unknown
		//IL_07e5: Expected Obj, but got VT
		//IL_0697: Expected I, but got Obj
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<DeviceInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v153 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 60);
		object obj3 = obj2 + 48;
		Transform transform2 = (Transform)(obj2 + 36);
		Transform transform3 = (Transform)(obj2 + 24);
		Transform transform4 = (Transform)(obj2 + 12);
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v25 (System.Int32)+18]");
		if ((nint)0 == 0)
		{
			return;
		}
		UISprite component = GetComponent<UISprite>();
		component.fillCenter = (byte)(int)highResName != 0;
		GameObject gameObject = base.gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		obj3 = 0;
		_ = 0;
		obj3 = 0.5f;
		_ = 0.5f;
		_ = 1f;
		transform = (Transform)obj3;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		parentInternal.parent = transform;
		int height = ((UIWidget)component).mWidth << 1;
		component.height = height;
		UIWidget uIWidget = (UIWidget)(((UIWidget)component).mHeight << 1);
		Color color = uIWidget.color;
		GameObject gameObject2 = base.gameObject;
		GameObject gameObject3 = base.gameObject;
		transform2.localPosition = (Vector3)gameObject3;
		GameObject gameObject4 = base.gameObject;
		transform3.localPosition = (Vector3)gameObject4;
		GameObject gameObject5 = base.gameObject;
		transform4.localPosition = (Vector3)gameObject5;
		obj2 = 0;
		_ = 0;
		float num3 = (float)transform2 * 2f;
		obj2 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (UnityEngine.Transform)+4]");
		float num4 = 0f * 2f;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		transform = (Transform)obj2;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject6 = base.gameObject;
		string text = ((Component)(object)gameObject6).tag;
		TweenScale component2 = ((GameObject)(object)text).GetComponent<TweenScale>();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v149 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
		{
			object obj5 = component2 + 88;
			object obj6 = component2 + 88;
			object obj7 = component2 + 88;
			obj3 = 0;
			_ = 0;
			float num7 = (float)obj5 * 2f;
			obj3 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v115+4]");
			float num8 = 0f * 2f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v118+8]");
			_ = 0;
			transform = (Transform)obj3;
			Transform transform7 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			object obj8 = component2 + 88;
			obj8 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj9 = component2 + 100;
			object obj10 = component2 + 100;
			object obj11 = component2 + 100;
			transform2 = (Transform)0;
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			float num9 = (float)obj9 * 2f;
			transform2 = (Transform)num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v134+4]");
			float num10 = 0f * 2f;
			Transform transform8 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v137+8]");
			((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
			transform = transform2;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			object obj12 = component2 + 100;
			obj12 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
		}
		GameObject gameObject7 = base.gameObject;
		string text2 = ((Component)(object)gameObject7).tag;
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)(object)text2).GetComponentInChildren<T>();
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v107 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)componentInChildren).FindKernel(null) != 0)
		{
			object obj14 = componentInChildren + 88;
			object obj15 = componentInChildren + 88;
			object obj16 = componentInChildren + 88;
			obj3 = 0;
			_ = 0;
			float num13 = (float)obj14 * 2f;
			obj3 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v73+4]");
			float num14 = 0f * 2f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v76+8]");
			_ = 0;
			transform = (Transform)obj3;
			Transform transform9 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17+8]");
			((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
			object obj17 = componentInChildren + 88;
			obj17 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj18 = componentInChildren + 100;
			object obj19 = componentInChildren + 100;
			object obj20 = componentInChildren + 100;
			transform2 = (Transform)0;
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			float num15 = (float)obj18 * 2f;
			transform2 = (Transform)num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v92+4]");
			float num16 = 0f * 2f;
			Transform transform10 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S0_v95+8]");
			((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
			transform = transform2;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			object obj21 = componentInChildren + 100;
			obj21 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
		}
		GameObject gameObject8 = base.gameObject;
		string text3 = ((Component)(object)gameObject8).tag;
		_0021_00210 componentInChildren2 = (_0021_00210)((GameObject)(object)text3).GetComponentInChildren<T>();
		nint num17 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S1_v68 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)componentInChildren2).FindKernel(null) != 0)
		{
			SDebug.LogFormat("TweenTransform used and not handled in resolution switcher.", null);
		}
	}
}
