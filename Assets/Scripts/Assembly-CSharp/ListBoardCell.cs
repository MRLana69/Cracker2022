using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ListBoardCell : MonoBehaviour
{
	public BoardScreen BoardScreen;

	public Image icon;

	public HoverboardOverlayHelper HoverboardOverlayHelper;

	private Button click;

	public Hoverboards.BoardType BoardType;

	public int boardId;

	public string boardName;

	private unsafe void Start()
	{
		Button button = click;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(ListBoardCell._003CStart_003Eb__7_0));
		button.m_OnClick.AddListener(unityAction);
	}

	private void _003CStart_003Eb__7_0()
	{
		BoardScreen.SelectedBoard(boardId);
	}
}
