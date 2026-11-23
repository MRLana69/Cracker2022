using SYBO.Subway.Info;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ListCharacterCell : MonoBehaviour
{
	public CharacterScreen CharacterScreen;

	public Image icon;

	public CharacterOverlayHelper CharacterOverlayHelper;

	private Button click;

	public Characters.CharacterType characterType;

	public int characterId;

	private unsafe void OnEnable()
	{
		Button button = click;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(ListCharacterCell._003COnEnable_003Eb__6_0));
		button.m_OnClick.AddListener(unityAction);
	}

	private void _003COnEnable_003Eb__6_0()
	{
		CharacterScreen.SelectedCharacter(characterId);
	}
}
