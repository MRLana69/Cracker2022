using Cpp2ILInjected;
using UnityEngine;

public class ScrollViewCollider : MonoBehaviour
{
	private GameObject _scrollCollider;

	private bool _addTopCollider;

	private bool _addBottomCollider;

	private float _zDepth;

	private bool _added;

	private void Start()
	{
		AddTopAndBottomColliders();
	}

	public unsafe void AddTopAndBottomColliders()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected VT, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected VT, but got Unknown
		//IL_0411: Expected Obj, but got I4
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected Obj, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected VT, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected VT, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected VT, but got Unknown
		//IL_04f5: Expected native int or pointer, but got VT
		//IL_0519: Expected F4, but got I
		//IL_0514: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 208);
		if (_scrollCollider != null)
		{
			if (~(_addTopCollider ? 1u : 0u) == 0 && !_added)
			{
				GameObject gameObject = base.gameObject;
				Transform transform = gameObject.transform;
				Transform parent = transform.parent;
				GameObject parent2 = parent.gameObject;
				GameObject gameObject2 = NGUITools.AddChild(parent2);
				BoxCollider boxCollider = gameObject2.AddComponent<BoxCollider>();
				_ = _zDepth;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
				_ = 0;
				_ = Vector3.zeroVector;
				_ = Vector3.zeroVector;
				Vector3 center = vector + 80;
				boxCollider.center = center;
				gameObject2.name = "TopScrollBlocker";
				int height = Screen.height;
				Transform transform2 = _scrollCollider.transform;
				Vector3 localScale = transform2.localScale;
				Transform transform3 = _scrollCollider.transform;
				Vector3 localPosition = transform3.localPosition;
				int num = height / 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				float num2 = 0f * 0.5f;
				float num3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				float num4 = num3 + 0f;
				float num5 = (float)num - num4;
				int height2 = Screen.height;
				int num6 = height2 / 2;
				float num7 = num5 * 0.5f;
				float num8 = (float)num6 - num7;
				int width = Screen.width;
				GameObject gameObject3 = base.gameObject;
				Transform transform4 = gameObject3.transform;
				Vector3 localPosition2 = transform4.localPosition;
				Transform transform5 = gameObject2.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				_ = 0;
				Vector3 localPosition3 = vector - -64;
				transform5.localPosition = localPosition3;
				Transform transform6 = gameObject2.transform;
				_ = 1065353216;
				_ = 1065353216;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
				_ = 0;
				Vector3 localScale2 = vector + 48;
				transform6.localScale = localScale2;
			}
			if (~(_addBottomCollider ? 1u : 0u) == 0 && !_added)
			{
				GameObject gameObject4 = base.gameObject;
				Transform transform7 = gameObject4.transform;
				Transform parent3 = transform7.parent;
				GameObject parent4 = parent3.gameObject;
				GameObject gameObject5 = NGUITools.AddChild(parent4);
				BoxCollider boxCollider2 = gameObject5.AddComponent<BoxCollider>();
				_ = _zDepth;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				_ = 0;
				_ = Vector3.zeroVector;
				_ = Vector3.zeroVector;
				Vector3 center2 = vector + 32;
				boxCollider2.center = center2;
				gameObject5.name = "BottomScrollBlocker";
				int height3 = Screen.height;
				Transform transform8 = _scrollCollider.transform;
				Vector3 localScale3 = transform8.localScale;
				Transform transform9 = _scrollCollider.transform;
				Vector3 localPosition4 = transform9.localPosition;
				int num9 = height3 / 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				float num10 = 0f * 0.5f;
				float num11 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				float num12 = num11 - 0f;
				float num13 = (float)num9 - num12;
				int height4 = Screen.height;
				object obj2 = -height4;
				object obj3 = obj2 / 2;
				float num14 = num13 * 0.5f;
				float num15 = (float)obj3 + num14;
				int width2 = Screen.width;
				GameObject gameObject6 = base.gameObject;
				Transform transform10 = gameObject6.transform;
				Vector3 localPosition5 = transform10.localPosition;
				Transform transform11 = gameObject5.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				_ = 0;
				Vector3 localPosition6 = vector + 16;
				transform11.localPosition = localPosition6;
				Transform transform12 = gameObject5.transform;
				_ = 1065353216;
				((Vector3*)(nint)vector)->z = 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				((Vector3*)(nint)vector)->x = 0f;
				transform12.localScale = vector;
			}
			_added = true;
		}
	}
}
