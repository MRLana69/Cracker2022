using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;

namespace SYBO.Common.Components.Renderers;

public class CurveParentRenderer : MonoBehaviour
{
	private CurveParent _curveParent;

	private GameObject _curveNode;

	protected void Start()
	{
		CancelInvoke();
	}

	public unsafe CurveParentRenderer()
	{
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_024e: Expected Obj, but got I4
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_026b: Expected Obj, but got I4
		//IL_027f: Expected I, but got Obj
		//IL_0295: Expected Obj, but got I
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected VT, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected VT, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_008d: Expected I4, but got Obj
		//IL_00c0: Expected VT, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_010f: Expected I4, but got Obj
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_02c0: Expected F4, but got Obj
		//IL_02bb: Expected native int or pointer, but got VT
		//IL_02d5: Expected F4, but got I
		//IL_02d0: Expected native int or pointer, but got VT
		//IL_02e2: Expected F4, but got Obj
		//IL_02dd: Expected native int or pointer, but got VT
		//IL_02f7: Expected F4, but got I
		//IL_02f2: Expected native int or pointer, but got VT
		//IL_021a: Expected VT, but got I4
		//IL_021a: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I4
		//IL_01c9: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 80;
		obj = 0;
		_ = 0;
		object obj3 = obj2 - -64;
		obj3 = 0;
		_ = 0;
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v62 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Quaternion quaternion = (Quaternion)(obj2 + 104);
		Vector3 vector = (Vector3)(obj2 + 92);
		ScrollView scrollView = (ScrollView)(obj2 + 48);
		BragCelebrationHandler bragCelebrationHandler = (BragCelebrationHandler)(obj2 + 32);
		object obj5 = obj2 + 16;
		if (((ComputeShader)(object)_curveNode).FindKernel((string)null) == 0)
		{
			return;
		}
		float minTime = _curveParent.MinTime;
		float metersInCurrentGame = ((GameStats)(object)_curveParent).MetersInCurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"CurveNodes";
		int layer = gameObject.layer;
		GameObject parentTransform = base.gameObject;
		HierarchyUtility.Reparent((Transform)layer, (Transform)(object)parentTransform, (Vector3)0);
		float num3 = metersInCurrentGame;
		while (!(num3 > minTime))
		{
			scrollView.FillFromIndex((int)_curveParent, num3, ContainerPivot.Top);
			obj = scrollView;
			_ = ((Object)scrollView).m_CachedPtr;
			bragCelebrationHandler.AnimateUIGameObjectAlpha((GameObject)(object)_curveParent, num3, 0.0125f);
			obj3 = bragCelebrationHandler;
			_ = ((Object)bragCelebrationHandler).m_CachedPtr;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			nint num4 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num5 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((Quaternion*)(nint)quaternion)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			GameObject gameObject2 = Object.Instantiate(_curveNode, vector, quaternion);
			int layer2 = gameObject2.layer;
			int layer3 = gameObject.layer;
			HierarchyUtility.Reparent((Transform)layer2, (Transform)layer3, (Vector3)0);
			float num6 = num3 + 0.0125f;
			num3 = num6;
		}
	}
}
