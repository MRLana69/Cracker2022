using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Managers;
using SYBO.Common.Utilities;
using SYBO.Subway.Inputs;
using UnityEngine;

namespace SYBO.Common.Templates;

public class FlagShaderTexcoordSetter : MonoBehaviour
{
	private void Start()
	{
		//IL_001e: Expected Obj, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		TimeScaleManager timeScaleManager = default;
		timeScaleManager.InputManager_OnInputEvent((object)666, (InputEventArgs)null);
		object obj = this + 8;
		obj = timeScaleManager;
	}

	public FlagShaderTexcoordSetter()
	{
		//IL_0335: Expected I, but got Obj
		//IL_034b: Expected Obj, but got I
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_017f: Expected I, but got Obj
		//IL_0195: Expected Obj, but got I
		//IL_00f0: Expected I, but got Obj
		//IL_01c0: Expected I, but got Obj
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0232: Expected Obj, but got I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0292: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		MeshFilter component = GetComponent<MeshFilter>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v88 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		object obj4 = obj3 + 8;
		if (component != null)
		{
			GameObject obj5 = gameObject;
			string longName = GameObjectUtil.GetLongName(obj5);
			string msg = $"FlagShaderTexcoordSetter missing MeshFilter on {(object[])(object)longName}";
			SDebug.LogFormat(msg, (object[])(object)this);
			return;
		}
		Mesh mesh = component.mesh;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v78 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mesh != null)
		{
			GameObject obj7 = gameObject;
			string longName2 = GameObjectUtil.GetLongName(obj7);
			string msg2 = $"FlagShaderTexcoordSetter missing a mesh on {(object[])(object)longName2}";
			SDebug.LogFormat(msg2, (object[])(object)this);
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v68 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mesh).FindKernel((string)null) != 0)
		{
			Vector3[] normals = mesh.normals;
			object obj9 = normals + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj10 = 0;
			Color32[] array = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
			{
				object obj11 = normals + 16;
				object obj12 = obj10 * 12;
				object obj13 = obj11 + obj12;
				object obj14 = normals + 16;
				object obj15 = obj10 * 12;
				object obj16 = obj14 + obj15;
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v52+4]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v56+8]");
				_ = 0;
				obj3 = obj4;
				obj2 = obj3;
				object obj17 = array + 16;
				object obj18 = obj10 << 3;
				object obj19 = obj17 + obj18;
				obj19 = obj2;
				object obj20 = obj10 + 1;
				obj10 = obj20;
			}
			mesh.colors32 = array;
		}
	}
}
