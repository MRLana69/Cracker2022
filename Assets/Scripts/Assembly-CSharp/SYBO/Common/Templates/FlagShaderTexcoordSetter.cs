using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;

namespace SYBO.Common.Templates;

public class FlagShaderTexcoordSetter : MonoBehaviour
{
	private void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_011c: Expected Obj, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		MeshFilter component = GetComponent<MeshFilter>();
		if (component == null)
		{
			Transform comp = transform;
			string longName = GameObjectUtil.GetLongName(comp);
			string text = "FlagShaderTexcoordSetter missing MeshFilter on " + longName;
			return;
		}
		Mesh sharedMesh = component.sharedMesh;
		if (sharedMesh == null)
		{
			Transform comp2 = transform;
			string longName2 = GameObjectUtil.GetLongName(comp2);
			string text2 = "FlagShaderTexcoordSetter missing a mesh on " + longName2;
		}
		else if (sharedMesh != null)
		{
			Vector3[] vertices = sharedMesh.vertices;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj3 = 0;
			Vector2[] array = default;
			while (vertices.Length > (nint)obj3)
			{
				object obj4 = obj3 * 12;
				object obj5 = (object)vertices + obj4;
				object obj6 = obj5 + 16;
				object obj7 = obj3 * 12;
				object obj8 = (object)vertices + obj7;
				object obj9 = obj8 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v22+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v40+4]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				obj = 0;
				object obj10 = obj3 << 3;
				object obj11 = (object)array + obj10;
				object obj12 = obj3 + 1;
				obj3 = obj12;
			}
			sharedMesh.uv2 = array;
		}
	}
}
