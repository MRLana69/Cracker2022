using System;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.Routes;

public abstract class AlternateRoute : Route
{
	protected Game _game;

	public abstract CharacterRendering.ICustomAnimationClipList AlternateRouteAnimationClipList { get; }

	public unsafe override void Initialize(RouteManager routeManager, Vector3 originGamePosition, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, RouteType previousRouteType, SyboRandom randomGenerator)
	{
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_06c5: Expected Obj, but got I4
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_06ec: Expected Obj, but got F4
		//IL_06fe: Expected I, but got F4
		//IL_070c: Expected I, but got Obj
		//IL_0722: Expected Obj, but got I
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected Obj, but got Unknown
		//IL_0b1d: Expected I, but got Obj
		//IL_0b33: Expected Obj, but got I
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected VT, but got Unknown
		//IL_075a: Expected F4, but got Obj
		//IL_0755: Expected native int or pointer, but got VT
		//IL_076c: Expected F4, but got I
		//IL_0767: Expected native int or pointer, but got VT
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected Obj, but got Unknown
		//IL_07a8: Expected VT, but got Obj
		//IL_07a8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00b1: Expected VT, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_08b5: Expected I, but got Obj
		//IL_08cb: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got F4
		//IL_0115: Expected I, but got F4
		//IL_0123: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Expected Obj, but got Unknown
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected Obj, but got Unknown
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7a: Expected Obj, but got Unknown
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Expected Obj, but got Unknown
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Expected Obj, but got Unknown
		//IL_0ba0: Expected Obj, but got I4
		//IL_07e2: Expected I, but got Obj
		//IL_07f8: Expected Obj, but got I
		//IL_0246: Expected I, but got Obj
		//IL_0822: Expected F4, but got Obj
		//IL_081d: Expected native int or pointer, but got VT
		//IL_0834: Expected F4, but got I
		//IL_082f: Expected native int or pointer, but got VT
		//IL_0862: Expected VT, but got Obj
		//IL_0880: Expected Obj, but got I4
		//IL_0164: Expected I, but got Obj
		//IL_0293: Expected I, but got Obj
		//IL_02a9: Expected Obj, but got I
		//IL_01b1: Expected I, but got Obj
		//IL_0221: Expected VT, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_02d4: Expected I, but got Obj
		//IL_0320: Expected Obj, but got F4
		//IL_0332: Expected I, but got F4
		//IL_0344: Expected F4, but got I4
		//IL_033f: Expected native int or pointer, but got VT
		//IL_0359: Expected F4, but got I
		//IL_0354: Expected native int or pointer, but got VT
		//IL_0367: Expected I, but got Obj
		//IL_037d: Expected Obj, but got I
		//IL_0945: Expected Obj, but got I4
		//IL_0421: Expected F4, but got I4
		//IL_03a8: Expected I, but got Obj
		//IL_042f: Expected Obj, but got I4
		//IL_0446: Expected Obj, but got F4
		//IL_045a: Expected I, but got F4
		//IL_0468: Expected I, but got Obj
		//IL_047e: Expected Obj, but got I
		//IL_0973: Expected I, but got Obj
		//IL_0989: Expected Obj, but got I
		//IL_09b3: Expected F4, but got Obj
		//IL_09ae: Expected native int or pointer, but got VT
		//IL_09c5: Expected F4, but got I
		//IL_09c0: Expected native int or pointer, but got VT
		//IL_0a03: Expected VT, but got Obj
		//IL_0a03: Expected Obj, but got I4
		//IL_04a9: Expected I, but got Obj
		//IL_0542: Expected VT, but got I4
		//IL_04f6: Expected I, but got Obj
		//IL_0598: Expected Obj, but got I4
		//IL_05a7: Expected Obj, but got F4
		//IL_05b8: Expected Obj, but got I
		//IL_05d1: Expected I, but got Obj
		//IL_05e7: Expected Obj, but got I
		//IL_0a50: Expected VT, but got Obj
		//IL_0a61: Expected F4, but got Obj
		//IL_0a5c: Expected native int or pointer, but got VT
		//IL_0a73: Expected F4, but got I
		//IL_0a6e: Expected native int or pointer, but got VT
		//IL_0a9d: Expected VT, but got Obj
		//IL_0612: Expected I, but got Obj
		//IL_0682: Expected VT, but got I4
		//IL_0682: Expected Obj, but got I4
		//IL_0682: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 128;
		obj = 0;
		_ = 0;
		_ = 0;
		Renderer renderer = (Renderer)(obj2 + 104);
		renderer = (Renderer)originGamePosition.x;
		((UnityEngine.Object)renderer).m_CachedPtr = (IntPtr)originGamePosition.z;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v173 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 88;
		Vector2 zero = Vector2.zero;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v169 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 152);
		((Vector3*)(nint)vector)->x = (float)renderer;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)renderer).m_CachedPtr;
		Transform transform = (Transform)(obj2 + 168);
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)chunkBuildMode, vector, (Quaternion)transform);
		int layer = gameObject.layer;
		int layer2 = ((GameObject)(object)routeManager).layer;
		HierarchyUtility.Reparent((Transform)layer, (Transform)layer2, (Vector3)1);
		ComputeShader computeShader;
		if (((ComputeShader)(object)randomGenerator).FindKernel((string)null) != 0)
		{
			renderer = (Renderer)0;
			((UnityEngine.Object)renderer).m_CachedPtr = (IntPtr)0;
			renderer = (Renderer)0f;
			_ = 0f;
			((UnityEngine.Object)renderer).m_CachedPtr = (IntPtr)0f;
			nint num5 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v140 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v165 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero2 = Vector2.zero;
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v146 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v161 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)renderer;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)renderer).m_CachedPtr;
			transform = (Transform)obj4;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			GameObject gameObject2 = UnityEngine.Object.Instantiate((GameObject)(object)randomGenerator, vector, (Quaternion)transform);
			int layer3 = gameObject2.layer;
			transform = (Transform)((SectionSpawnMode*)(int)sectionSpawnMode)->value__;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sectionSpawnMode @ L3 (SYBO.Subway.Routes.Builders.SectionSpawnMode)+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = transform.localPosition;
			int layer4 = gameObject2.layer;
			int layer5 = ((GameObject)(object)routeManager).layer;
			HierarchyUtility.Reparent((Transform)layer4, (Transform)layer5, (Vector3)1);
			computeShader = (ComputeShader)(object)gameObject2;
		}
		else
		{
			computeShader = null;
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v129 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform5 = (Transform)(obj2 + 72);
		Renderer renderer2 = (Renderer)(obj2 + 48);
		object obj9 = obj2 + 36;
		object obj10 = obj2 + 24;
		object obj11 = obj2 + 12;
		if (((ComputeShader)previousRouteType).FindKernel(null) == 0)
		{
			return;
		}
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v62 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v125 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (computeShader.FindKernel(null) == 0)
		{
			return;
		}
		transform = (Transform)originGamePosition.x;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)originGamePosition.z;
		((Vector3*)(nint)vector)->x = ((SectionSpawnMode*)(int)sectionSpawnMode)->value__;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sectionSpawnMode @ L3 (SYBO.Subway.Routes.Builders.SectionSpawnMode)+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		nint num13 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S2_v14 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num14 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S2_v63 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v33 (UnityEngine.Transform)+4]");
		float value = 0f - vector.y;
		float num15 = Math.Abs(value);
		Renderer component = ((GameObject)previousRouteType).GetComponent<Renderer>();
		renderer.SetMaterial((Material)(object)component);
		obj = renderer;
		_ = ((UnityEngine.Object)renderer).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (UnityEngine.Renderer)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		float num16 = num15;
		float num17 = 0f;
		while (num16 > 0f)
		{
			renderer = (Renderer)0;
			((UnityEngine.Object)renderer).m_CachedPtr = (IntPtr)0;
			renderer = (Renderer)0f;
			_ = 0f;
			((UnityEngine.Object)renderer).m_CachedPtr = (IntPtr)0f;
			nint num18 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v92 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num19 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S0_v121 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero3 = Vector2.zero;
			nint num20 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v98 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num21 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S0_v117 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)renderer;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)renderer).m_CachedPtr;
			transform = (Transform)obj4;
			Transform transform6 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21+8]");
			((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
			float num22 = num17 + 1f;
			GameObject gameObject3 = UnityEngine.Object.Instantiate((GameObject)previousRouteType, vector, (Quaternion)transform);
			int layer6 = gameObject3.layer;
			int layer7 = gameObject.layer;
			transform5.position = (Vector3)layer7;
			Renderer component2 = gameObject3.GetComponent<Renderer>();
			renderer2.SetMaterial((Material)(object)component2);
			obj = renderer2;
			_ = ((UnityEngine.Object)renderer2).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v49 (UnityEngine.Renderer)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			obj10 = 0;
			_ = 0;
			obj10 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v51+4]");
			object obj16 = -0;
			_ = 0f;
			nint num23 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S1_v94 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num24 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S1_v113 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			transform = (Transform)obj10;
			Transform transform7 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v53+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			Quaternion quaternion = Quaternion.AngleAxis(num22, (Vector3)transform);
			((Vector3*)(nint)vector)->x = (float)transform5;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform5).m_CachedPtr;
			transform = (Transform)obj11;
			Transform transform8 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v55+8]");
			((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
			Vector3 vector3 = vector - (Vector3)transform;
			transform = (Transform)obj2;
			Transform transform9 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition2 = transform.localPosition;
			int layer8 = gameObject3.layer;
			int layer9 = ((GameObject)(object)routeManager).layer;
			HierarchyUtility.Reparent((Transform)layer8, (Transform)layer9, (Vector3)1);
			float num25 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21+4]");
			float num26 = num25 - 0f;
			num16 = num26;
			num17 = num22;
		}
	}

	protected AlternateRoute()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DefaultRouteBuilder);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Routes.Builders.DefaultRouteBuilder>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(DefaultRouteBuilder);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<SYBO.Subway.Routes.Builders.DefaultRouteBuilder>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((RouteBuilder)(object)this)._002Ector();
	}
}
