using Cpp2ILInjected;
using UnityEngine;

public class ScrollUV : MonoBehaviour
{
	private Vector2 _uvSpeed;

	private MeshRenderer _renderer;

	private Material _material;

	private void Awake()
	{
		GameObject gameObject = base.gameObject;
		MeshRenderer component = gameObject.GetComponent<MeshRenderer>();
		_renderer = component;
		Material material = _renderer.material;
		Material material2 = default;
		material2._002Ector(material);
		_material = material2;
		_renderer.material = _material;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got F4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Vector2 textureOffset = _material.GetTextureOffset("_MainTex");
		float deltaTime = Time.deltaTime;
		float num = (float)_uvSpeed * deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		float num2 = 0f + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollUV)+10]");
		float num3 = 0f * deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		float num4 = 0f + num3;
		object obj3 = num4 << 32;
		object obj4 = num2 | obj3;
		Vector2 value = (Vector2)(obj + 8);
		_material.SetTextureOffset("_MainTex", value);
	}
}
