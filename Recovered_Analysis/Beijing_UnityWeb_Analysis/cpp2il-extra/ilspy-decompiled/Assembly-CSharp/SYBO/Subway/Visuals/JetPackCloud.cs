using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class JetPackCloud : MonoBehaviour
{
	public float scrollSpeed;

	private Material material;

	public float startOffset;

	private void Awake()
	{
		CancelInvoke();
	}

	private unsafe void Update()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got F4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected VT, but got Unknown
		//IL_0057: Expected F4, but got Obj
		//IL_0052: Expected native int or pointer, but got VT
		object obj = this + 16;
		string text = tag;
		Renderer component = ((GameObject)(object)text).GetComponent<Renderer>();
		Material sharedMaterial = component.sharedMaterial;
		obj = sharedMaterial;
		object obj3 = default;
		object obj2 = obj3 + 8;
		obj2 = 0;
		obj2 = startOffset;
		_ = 0f;
		obj3 = obj2;
		Vector2 vector = (Vector2)(obj3 + 16);
		((Vector2*)(nint)vector)->x = (float)obj3;
		material.mainTextureScale = vector;
	}

	public unsafe JetPackCloud()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Expected VT, but got Obj
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected VT, but got Unknown
		//IL_009d: Expected F4, but got Obj
		//IL_0098: Expected native int or pointer, but got VT
		object obj = default;
		Material material = (Material)(obj + 16);
		material.mainTextureOffset = (Vector2)this.material;
		float unscaledTime = Time.unscaledTime;
		float num = unscaledTime * scrollSpeed;
		float num2 = (float)material + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CE");
		object obj2 = obj + 8;
		obj2 = 0;
		object obj3 = default;
		obj2 = obj3;
		_ = 0f;
		obj = obj2;
		Vector2 vector = (Vector2)(obj + 24);
		((Vector2*)(nint)vector)->x = (float)obj;
		this.material.mainTextureScale = vector;
	}
}
