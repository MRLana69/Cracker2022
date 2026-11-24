//Type is in global namespace

public class CountryCellController : MonoBehaviour
{
	public UILabel countryName; //Field offset: 0xC
	public UISprite countryFlag; //Field offset: 0x10
	public UISprite statusSprite; //Field offset: 0x14
	public string countryLocale; //Field offset: 0x18

	public CountryCellController() { }

	private void OnEnable() { }

}

