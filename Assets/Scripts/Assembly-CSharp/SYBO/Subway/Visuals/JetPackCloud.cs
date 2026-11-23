using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class JetPackCloud : MonoBehaviour
{
	public float scrollSpeed = 0.5f;

	private Material material;

	public float startOffset;

	private unsafe void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003f: Expected F4, but got I
		//IL_003a: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		GameObject gameObject = base.gameObject;
		Renderer component = gameObject.GetComponent<Renderer>();
		Material material = component.material;
		this.material = material;
		_ = 0;
		_ = startOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+8]");
		((Vector2*)(nint)vector)->x = 0f;
		this.material.mainTextureOffset = vector;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Vector2 mainTextureOffset = material.mainTextureOffset;
		float deltaTime = Time.deltaTime;
		float num = deltaTime * scrollSpeed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		float num2 = 0f + num;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @440");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Vector2 mainTextureOffset2 = (Vector2)(obj + 8);
		material.mainTextureOffset = mainTextureOffset2;
	}
}
