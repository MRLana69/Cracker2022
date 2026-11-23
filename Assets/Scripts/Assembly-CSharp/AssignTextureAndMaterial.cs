using System;
using Cpp2ILInjected;
using UnityEngine;

public class AssignTextureAndMaterial : MonoBehaviour
{
	private string _textureName;

	private Material _material;

	private void Awake()
	{
		throw new ArgumentException();
	}

	private void OnDestroy()
	{
		Texture mainTexture = _material.mainTexture;
		if (mainTexture != null)
		{
			UnityEngine.Object.Destroy(mainTexture);
		}
		UnityEngine.Object.Destroy(_material);
	}

	private void _003CAwake_003Eb__2_0(Material onSucess)
	{
		//IL_0084: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		_material = onSucess;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		object obj = 0;
		object obj4 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v7+C]");
			if (0 > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = obj4 + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v14+10]");
				((Renderer)0).material = _material;
				object obj5 = obj + 1;
				obj = obj5;
				continue;
			}
			break;
		}
	}
}
