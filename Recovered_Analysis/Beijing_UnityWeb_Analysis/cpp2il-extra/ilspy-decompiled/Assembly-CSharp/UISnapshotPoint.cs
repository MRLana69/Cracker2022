using Cpp2ILInjected;
using UnityEngine;

public class UISnapshotPoint : MonoBehaviour
{
	public bool isOrthographic;

	public float nearClip;

	public float farClip;

	public int fieldOfView;

	public float orthoSize;

	public Texture2D thumbnail;

	private void Start()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		object obj = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1f;
		object obj3 = this + 16;
		object obj4 = default;
		obj3 = obj4;
		object obj5 = this + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1f;
		object obj7 = this + 24;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj9 = this + 40;
		object obj10 = default;
		obj9 = obj10;
		_ = 1;
		_ = 1;
		_ = -1;
		_ = 1f;
		CancelInvoke();
	}

	public UISnapshotPoint()
	{
		//IL_002e: Expected I4, but got Obj
		object current = ((CustomYieldInstruction)(object)this).Current;
		if (((string)current).get_Chars((int)"EditorOnly") != '\0')
		{
			SendMessage("EditorOnly");
		}
	}
}
