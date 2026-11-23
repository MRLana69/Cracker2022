using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CountryCellController : MonoBehaviour
{
	public CountryPopup countryPopup;

	public TMP_Text countryName;

	public Image countryFlag;

	public Image statusSprite;

	public string countryLocale;

	public Button click;

	private unsafe void OnEnable()
	{
		Button button = click;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(CountryCellController._003COnEnable_003Eb__6_0));
		button.m_OnClick.AddListener(unityAction);
	}

	private void _003COnEnable_003Eb__6_0()
	{
		countryPopup.OnClick(countryLocale);
	}
}
