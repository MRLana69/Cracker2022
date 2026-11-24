using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIScaleDown3dModels : MonoBehaviour
{
	public enum ScaleAnchorType
	{
		CharacterAnchor,
		GameOverAnchor,
		TutorialPupupAnchor
	}

	public ScaleAnchorType anchorType;

	private void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got F4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_004e: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		obj = 390f;
		_ = 520f;
		obj2 = obj;
		object obj3 = obj2 + 16;
		obj3 = obj2;
		anchorType = (ScaleAnchorType)obj3;
		CancelInvoke();
	}

	public UIScaleDown3dModels()
	{
		//IL_0818: Expected I, but got Obj
		//IL_082e: Expected Obj, but got I
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Expected Obj, but got Unknown
		//IL_00c2: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0065: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got F4
		//IL_01b2: Expected I, but got Obj
		//IL_01c8: Expected Obj, but got I
		//IL_0103: Expected I, but got Obj
		//IL_0155: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got F4
		//IL_03d4: Expected I, but got Obj
		//IL_03ea: Expected Obj, but got I
		//IL_01f3: Expected I, but got Obj
		//IL_05f6: Expected I, but got Obj
		//IL_060c: Expected Obj, but got I
		//IL_0415: Expected I, but got Obj
		//IL_037c: Expected Obj, but got I4
		//IL_038b: Expected Obj, but got F4
		//IL_08d1: Expected Obj, but got I4
		//IL_08e0: Expected Obj, but got F4
		//IL_0637: Expected I, but got Obj
		//IL_059e: Expected Obj, but got I4
		//IL_05ad: Expected Obj, but got F4
		//IL_0967: Expected Obj, but got I4
		//IL_0976: Expected Obj, but got F4
		//IL_028e: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got F4
		//IL_07c0: Expected Obj, but got I4
		//IL_07cf: Expected Obj, but got F4
		//IL_031a: Expected Obj, but got I4
		//IL_0329: Expected Obj, but got F4
		//IL_09fd: Expected Obj, but got I4
		//IL_0a0c: Expected Obj, but got F4
		//IL_04b0: Expected Obj, but got I4
		//IL_04bf: Expected Obj, but got F4
		//IL_053c: Expected Obj, but got I4
		//IL_054b: Expected Obj, but got F4
		//IL_06d2: Expected Obj, but got I4
		//IL_06e1: Expected Obj, but got F4
		//IL_075e: Expected Obj, but got I4
		//IL_076d: Expected Obj, but got F4
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<DeviceInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v131 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 12);
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (System.Int32)+14]");
		if ((nint)0 == 1)
		{
			GameObject gameObject = base.gameObject;
			obj2 = 0;
			_ = 0;
			obj2 = 0.9f;
			_ = 0.9f;
			_ = 0.9f;
			transform = (Transform)obj2;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			((Transform)(object)gameObject).parent = transform;
			return;
		}
		nint num3 = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22 (Il2CppClass<DeviceInfo>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v125 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS2 = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v27 (System.Int32)+14]");
		if ((nint)0 == 5)
		{
			GameObject gameObject2 = base.gameObject;
			obj2 = 0;
			_ = 0;
			obj2 = 0.75f;
			_ = 0.75f;
			_ = 0.75f;
			transform = (Transform)obj2;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			((Transform)(object)gameObject2).parent = transform;
			return;
		}
		nint num5 = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v31 (Il2CppClass<DeviceInfo>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v119 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS3 = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v36 (System.Int32)+14]");
		if ((nint)0 == 2)
		{
			if (anchorType != ScaleAnchorType.CharacterAnchor)
			{
				if (anchorType == ScaleAnchorType.TutorialPupupAnchor)
				{
					GameObject gameObject3 = base.gameObject;
					obj2 = 0;
					_ = 0;
					obj2 = 75f;
					_ = 10f;
					_ = 30f;
					transform = (Transform)obj2;
					Transform transform4 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles = transform.eulerAngles;
				}
				else if (anchorType == ScaleAnchorType.GameOverAnchor)
				{
					GameObject gameObject4 = base.gameObject;
					obj2 = 0;
					_ = 0;
					obj2 = -75f;
					_ = 10f;
					_ = 30f;
					transform = (Transform)obj2;
					Transform transform5 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles2 = transform.eulerAngles;
				}
			}
			else
			{
				GameObject gameObject5 = base.gameObject;
				obj2 = 0;
				_ = 0;
				obj2 = -80f;
				_ = -39f;
				_ = 20f;
				transform = (Transform)obj2;
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles3 = transform.eulerAngles;
			}
			GameObject gameObject6 = base.gameObject;
			obj2 = 0;
			_ = 0;
			obj2 = 0.85f;
			_ = 0.85f;
			_ = 0.85f;
			transform = (Transform)obj2;
			Transform transform7 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			((Transform)(object)gameObject6).parent = transform;
			return;
		}
		nint num7 = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v40 (Il2CppClass<DeviceInfo>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v97 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS4 = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v45 (System.Int32)+14]");
		if ((nint)0 == 3)
		{
			if (anchorType != ScaleAnchorType.CharacterAnchor)
			{
				if (anchorType == ScaleAnchorType.TutorialPupupAnchor)
				{
					GameObject gameObject7 = base.gameObject;
					obj2 = 0;
					_ = 0;
					obj2 = 75f;
					_ = 10f;
					_ = 30f;
					transform = (Transform)obj2;
					Transform transform8 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles4 = transform.eulerAngles;
				}
				else if (anchorType == ScaleAnchorType.GameOverAnchor)
				{
					GameObject gameObject8 = base.gameObject;
					obj2 = 0;
					_ = 0;
					obj2 = -75f;
					_ = 10f;
					_ = 30f;
					transform = (Transform)obj2;
					Transform transform9 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles5 = transform.eulerAngles;
				}
			}
			else
			{
				GameObject gameObject9 = base.gameObject;
				obj2 = 0;
				_ = 0;
				obj2 = -80f;
				_ = -39f;
				_ = 20f;
				transform = (Transform)obj2;
				Transform transform10 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles6 = transform.eulerAngles;
			}
			GameObject gameObject10 = base.gameObject;
			obj2 = 0;
			_ = 0;
			obj2 = 0.85f;
			_ = 0.85f;
			_ = 0.85f;
			transform = (Transform)obj2;
			Transform transform11 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
			((Transform)(object)gameObject10).parent = transform;
			return;
		}
		nint num9 = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v49 (Il2CppClass<DeviceInfo>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v75 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS5 = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v54 (System.Int32)+14]");
		if ((nint)0 != 4)
		{
			return;
		}
		if (anchorType != ScaleAnchorType.CharacterAnchor)
		{
			if (anchorType == ScaleAnchorType.TutorialPupupAnchor)
			{
				GameObject gameObject11 = base.gameObject;
				obj2 = 0;
				_ = 0;
				obj2 = 75f;
				_ = 10f;
				_ = 30f;
				transform = (Transform)obj2;
				Transform transform12 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform12).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles7 = transform.eulerAngles;
			}
			else if (anchorType == ScaleAnchorType.GameOverAnchor)
			{
				GameObject gameObject12 = base.gameObject;
				obj2 = 0;
				_ = 0;
				obj2 = -75f;
				_ = 10f;
				_ = 30f;
				transform = (Transform)obj2;
				Transform transform13 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform13).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles8 = transform.eulerAngles;
			}
		}
		else
		{
			GameObject gameObject13 = base.gameObject;
			obj2 = 0;
			_ = 0;
			obj2 = -80f;
			_ = -39f;
			_ = 20f;
			transform = (Transform)obj2;
			Transform transform14 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform14).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles9 = transform.eulerAngles;
		}
		GameObject gameObject14 = base.gameObject;
		obj2 = 0;
		_ = 0;
		obj2 = 0.85f;
		_ = 0.85f;
		_ = 0.85f;
		transform = (Transform)obj2;
		Transform transform15 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform15).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject14).parent = transform;
	}
}
