using Cpp2ILInjected;
using UnityEngine;

public class ScrollUV : MonoBehaviour
{
	private Vector2 _uvSpeed;

	private MeshRenderer _renderer;

	private Material _material;

	private void Awake()
	{
		CancelInvoke();
	}

	private void Update()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		object obj = this + 20;
		string text = tag;
		MeshRenderer component = ((GameObject)(object)text).GetComponent<MeshRenderer>();
		obj = component;
		Material sharedMaterial = _renderer.sharedMaterial;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Material material = default;
		material._002Ector((string)(object)sharedMaterial);
		object obj2 = this + 24;
		obj2 = material;
		_renderer.sharedMaterials = (Material[])(object)_material;
	}

	public unsafe ScrollUV()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0071: Expected I4, but got Obj
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got VT
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected VT, but got Unknown
		//IL_0108: Expected F4, but got Obj
		//IL_0103: Expected native int or pointer, but got VT
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected VT, but got Unknown
		//IL_0158: Expected F4, but got Obj
		//IL_0153: Expected native int or pointer, but got VT
		//IL_0165: Expected F4, but got Obj
		//IL_0160: Expected native int or pointer, but got VT
		//IL_0183: Expected F4, but got Obj
		//IL_017e: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 40;
		Vector2 textureOffset = _material.GetTextureOffset((int)"_MainTex");
		object obj3 = obj2 + 16;
		obj3 = _uvSpeed;
		float unscaledTime = Time.unscaledTime;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v11 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v29 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 32;
		obj5 = obj3;
		Vector2 vector = (Vector2)(obj2 + 56);
		((Vector2*)(nint)vector)->x = (float)obj5;
		object obj6 = obj2 + 8;
		Vector2 vector2 = vector / unscaledTime;
		object obj7 = obj2 + 24;
		obj7 = obj;
		Vector2 vector3 = (Vector2)(obj2 + 48);
		((Vector2*)(nint)vector3)->x = (float)obj7;
		((Vector2*)(nint)vector)->x = (float)obj6;
		Vector2 vector4 = vector3 - vector;
		((Vector2*)(nint)vector)->x = (float)obj2;
		_material.SetTextureScale("_MainTex", vector);
	}
}
