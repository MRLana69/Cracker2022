using System;
using Cpp2ILInjected;
using UnityEngine;

public class FacebookGiftButton : MonoBehaviour
{
	private UILabel title;

	private UILabel description;

	private int earnCurrencyProfileIndex;

	private Action _onClickDelegate;

	public void Init(int earnCurrencyProfileIndex, string earnerTitle, string earnerDesc, Action onClickDelegate, UIScrollView _panel)
	{
		this.earnCurrencyProfileIndex = earnCurrencyProfileIndex;
		title.text = earnerTitle;
		description.text = earnerDesc;
		_onClickDelegate = onClickDelegate;
		GameObject gameObject = base.gameObject;
		UIDragScrollView component = gameObject.GetComponent<UIDragScrollView>();
		component.scrollView = _panel;
	}

	private void OnClick()
	{
		EarnCoinsData.Trigger(earnCurrencyProfileIndex);
		Action onClickDelegate = _onClickDelegate;
		if (_onClickDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v19.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
