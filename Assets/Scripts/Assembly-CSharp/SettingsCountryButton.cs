using UnityEngine;

public class SettingsCountryButton : MonoBehaviour
{
	private UILabel currentCountryLabel;

	private void OnEnable()
	{
		CountryManager instance = CountryManager.instance;
		Country currentTournamentCountry = instance.GetCurrentTournamentCountry();
		currentCountryLabel.text = currentTournamentCountry.name__BackingField;
	}
}
