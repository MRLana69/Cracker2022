using System;
using Cpp2ILInjected;
using UnityEngine;

public class TopRunEmptyCell : MonoBehaviour
{
	private UISprite background;

	public void InitCell(int rank)
	{
		//IL_00cc: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_005d: Expected Obj, but got I
		//IL_0080: Expected VT, but got Obj
		//IL_00bd: Expected Obj, but got I4
		//IL_00bd: Expected VT, but got Obj
		//IL_00bd: Expected Obj, but got I
		UIEventListener component = ((GameObject)rank).GetComponent<UIEventListener>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+18]");
		string text = ((string)0).ToUpperInvariant();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		((CountryPopup)this)._002Ector();
		object obj2 = default;
		object obj = obj2 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunEmptyCell)+28]");
		UIScrollView uiScrollView = ((ScrollView)0).uiScrollView;
		GameObject gameObject = uiScrollView.gameObject;
		Transform transform = default;
		transform.localPosition = (Vector3)gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+5C]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
		float strength = num - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunEmptyCell)+28]");
		((ScrollView)0).SmoothScrollToOffset((Vector3)obj, (Action)3, strength);
	}
}
