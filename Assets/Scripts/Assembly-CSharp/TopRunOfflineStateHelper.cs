using System;
using Cpp2ILInjected;
using TopRun;
using TopRun.UI;
using UnityEngine;

public class TopRunOfflineStateHelper : MonoBehaviour
{
	public enum OfflineState
	{
		TryAgain,
		Loading
	}

	private UILabel _offlineText;

	private UISprite _offlineOverlay;

	private UILabel _connectionLabel;

	private UILabel _tryAgainText;

	private UISprite _tryAgainBackground;

	private TopRunOnlineScreen _topRunOnlineScreen;

	private TopRunOnlineGameOverScreen _topRunOnlineGameOverScreen;

	private int tryAgainOfflineLabelOffset = 20;

	private int loadingOfflineLabelOffset;

	public void SetState(OfflineState newState, TopRunOnlineScreen topRunScreen = null, TopRunOnlineGameOverScreen topRunGOScreen = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		_topRunOnlineScreen = topRunScreen;
		_topRunOnlineGameOverScreen = topRunGOScreen;
		switch (newState)
		{
		case OfflineState.TryAgain:
			SetTryAgainState();
			return;
		case OfflineState.Loading:
			SetLoadingState();
			return;
		}
		_ = -1;
		obj = (Enum)(object)typeof(OfflineState);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text = obj.ToString();
		string text2 = "No state found for " + text + ".";
	}

	private void SetTryAgainState()
	{
		//IL_00ff: Expected VT, but got I4
		//IL_009d: Expected VT, but got I4
		UIAnchor component = _offlineText.GetComponent<UIAnchor>();
		_ = 0;
		component.pixelOffset = (Vector2)tryAgainOfflineLabelOffset;
		GameObject gameObject = _offlineOverlay.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = _tryAgainBackground.gameObject;
		gameObject2.SetActive(value: true);
		GameObject gameObject3 = _tryAgainText.gameObject;
		gameObject3.SetActive(value: true);
		string text = Strings.Get(StringID.TOPRUN_OFFLINE_BUTTON_TEXT);
		_connectionLabel.text = text;
		_connectionLabel.pivot = UIWidget.Pivot.Left;
		UIAnchor component2 = _connectionLabel.GetComponent<UIAnchor>();
		component2.pixelOffset = (Vector2)1101004800;
		component2.side = UIAnchor.Side.Left;
		GameObject gameObject4 = base.gameObject;
		UIButtonOverlayOff component3 = gameObject4.GetComponent<UIButtonOverlayOff>();
		component3.enabled = true;
	}

	private void SetLoadingState()
	{
		//IL_0103: Expected VT, but got I4
		//IL_00a1: Expected VT, but got I8
		UIAnchor component = _offlineText.GetComponent<UIAnchor>();
		_ = 0;
		component.pixelOffset = (Vector2)loadingOfflineLabelOffset;
		GameObject gameObject = _offlineOverlay.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = _tryAgainBackground.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = _tryAgainText.gameObject;
		gameObject3.SetActive(value: false);
		string text = Strings.Get(StringID.TOPRUN_OFFLINE_BUTTON_TEXT_LOADING);
		_connectionLabel.text = text;
		_connectionLabel.pivot = UIWidget.Pivot.Center;
		UIAnchor component2 = _connectionLabel.GetComponent<UIAnchor>();
		component2.pixelOffset = (Vector2)3242196992L;
		component2.side = UIAnchor.Side.Center;
		GameObject gameObject4 = base.gameObject;
		UIButtonOverlayOff component3 = gameObject4.GetComponent<UIButtonOverlayOff>();
		component3.enabled = false;
	}

	private void OnClick()
	{
		EnableLoadingOverlay();
		SetState(OfflineState.Loading);
		if (TopRunRoot.manager__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	private void EnableLoadingOverlay()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		object obj;
		if (_topRunOnlineScreen != null)
		{
			obj = _topRunOnlineScreen + 100;
		}
		else
		{
			if (!(_topRunOnlineGameOverScreen != null))
			{
				return;
			}
			obj = _topRunOnlineGameOverScreen + 48;
		}
		((GameObject)obj).SetActive(true);
	}

	public TopRunOfflineStateHelper()
	{
		//IL_000f: Expected I4, but got I8
	}
}
