using System;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.ModelCamera;

public class RenderTextureCamera
{
	private GameObject _cameraGo;

	private Camera _camera;

	private bool isActive__BackingField;

	private UnityEngine.RenderTexture renderTexture__BackingField;

	public unsafe bool isActive
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009e: Expected I4, but got Obj
			//IL_00a2: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(ModelScreenSetups);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.ModelCamera.ModelScreenSetups>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ModelScreenSetups);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UI.ModelCamera.ModelScreenSetups>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)ModelScreenSetups._setups.get_Item((UIModelController.ModelScreen)this) != 0;
		}
		private set
		{
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected VT, but got Unknown
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected Obj, but got Unknown
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00c0: Expected F4, but got Obj
			//IL_00bb: Expected native int or pointer, but got VT
			//IL_00d5: Expected F4, but got I
			//IL_00d0: Expected native int or pointer, but got VT
			//IL_019e: Expected Obj, but got VT
			//IL_019e: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_013c: Expected F4, but got Obj
			//IL_0137: Expected native int or pointer, but got VT
			//IL_0151: Expected F4, but got I
			//IL_014c: Expected native int or pointer, but got VT
			//IL_0166: Expected F4, but got I
			//IL_0177: Expected F4, but got Obj
			//IL_0172: Expected native int or pointer, but got VT
			//IL_018c: Expected F4, but got I
			//IL_0187: Expected native int or pointer, but got VT
			//IL_0054: Expected I, but got Obj
			object obj = default;
			Vector3 vector = (Vector3)(obj + 24);
			object obj2 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.RenderTextureCamera)+2C]");
			if ((nint)0 > (nint)(-1))
			{
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v23 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v35 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 forward = Vector3.forward;
				((Vector3*)(nint)vector)->x = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ModelCamera.RenderTextureCamera)+2C]");
				Vector3 vector2 = vector / 0f;
				((Vector3*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector3*)(nint)vector)->z = 0f;
			}
			else
			{
				object obj4 = this + 20;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v9+8]");
				_ = 0;
				((Vector3*)(nint)vector)->x = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				((Vector3*)(nint)vector)->z = 0f;
			}
			((Transform)value).parent = (Transform)vector;
		}
	}

	public UnityEngine.RenderTexture renderTexture
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = isActive__BackingField;
			return (UnityEngine.RenderTexture)flag;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			isActive__BackingField = flag;
		}
	}

	public int cameraLayer
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)renderTexture__BackingField;
		}
	}

	public unsafe RenderTextureCamera(Camera camera, GameObject cameraGo, UnityEngine.RenderTexture renderTexture)
	{
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0243: Expected I, but got Obj
		//IL_0259: Expected Obj, but got I
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Ref, but got Unknown
		//IL_02bb: Expected Obj, but got VT
		//IL_02e7: Expected I4, but got Obj
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Ref, but got Unknown
		//IL_012f: Expected Obj, but got VT
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 84;
		object obj3 = this + 8;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 96);
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		object obj4 = obj2 + 72;
		object obj5 = this + 32;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v17+8]");
		_ = 0;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v19 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v54 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform = (Transform)obj4;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		ref Quaternion reference = ref *(Quaternion*)(obj2 + 56);
		Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)transform);
		transform = (Transform)reference;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v26 (UnityEngine.Quaternion&)+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		isActive = (byte)(int)camera != 0;
		((AssignTextureAndMaterial)(object)camera)._003CAwake_003Eb__3_0((Material)(object)renderTexture);
		object obj7 = obj2 + 44;
		object obj8 = this + 52;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v37+8]");
		_ = 0;
		transform = (Transform)obj7;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v33+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = transform.eulerAngles;
		object obj9 = obj2 + 32;
		object obj10 = this + 76;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v48+8]");
		_ = 0;
		transform = (Transform)obj9;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v39+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		ref Quaternion reference2 = ref *(Quaternion*)(obj2 + 16);
		Quaternion.Inverse_Injected(ref reference2, out *(Quaternion*)transform);
		transform = (Transform)reference2;
		Transform transform7 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v44 (UnityEngine.Quaternion&)+8]");
		((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
		Vector3 localScale2 = transform.localScale;
		object obj11 = this - -64;
		obj2 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v64+8]");
		_ = 0;
		transform = (Transform)obj2;
		Transform transform8 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
		((Transform)(object)cameraGo).parent = transform;
	}

	public Transform GetAnchor()
	{
		//IL_000f: Expected Obj, but got I4
		return (Transform)_cameraGo.activeSelf;
	}

	public void Activate(CameraSettings overrideCameraSettings)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = overrideCameraSettings;
	}

	public void Deactivate()
	{
	}

	private void ClearRenderTexture(UnityEngine.RenderTexture renderTextureToClear)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a2: Expected I4, but got Obj
		//IL_00bd: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CameraSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UI.CameraSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CameraSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UI.CameraSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UICameraScreenClipping)(object)_camera).CalculateClipping((byte)(int)renderTextureToClear != 0);
		isActive__BackingField = true;
		_cameraGo.tag = (string)1;
	}
}
