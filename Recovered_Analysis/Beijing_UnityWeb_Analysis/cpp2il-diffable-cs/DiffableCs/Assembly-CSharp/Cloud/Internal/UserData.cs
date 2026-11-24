namespace Cloud.Internal;

public class UserData
{
	public const string MULTIPLIER_KEY = "multiplier"; //Field offset: 0x0
	public const string OUTFITS_KEY = "outfits"; //Field offset: 0x0
	public const string BOARD_KEY = "board"; //Field offset: 0x0
	public const string CHARACTERS_KEY = "characters"; //Field offset: 0x0
	public const string BOARDTHEMES_KEY = "boardThemes"; //Field offset: 0x0
	public const string UPGRADES_KEY = "upgrades"; //Field offset: 0x0
	public const string KEYS_KEY = "keys"; //Field offset: 0x0
	public const string HIGHSCORE_KEY = "highscore"; //Field offset: 0x0
	public const string AWARDS_KEY = "awards"; //Field offset: 0x0
	public int multiplier; //Field offset: 0x8
	public int highScore; //Field offset: 0xC
	public int keys; //Field offset: 0x10
	public int upgradeTiers; //Field offset: 0x14
	public int characters; //Field offset: 0x18
	public int outfits; //Field offset: 0x1C
	public int boards; //Field offset: 0x20
	public int boardThemes; //Field offset: 0x24
	public float awardsPercentage; //Field offset: 0x28

	public UserData(ICloudUserData data) { }

	public string AsString() { }

	private static string GetEntry(Dictionary<string, string> dict, string key) { }

	private void LoadUserData(Dictionary<string, string> data) { }

	public bool StrictlyBetterThan(UserData other) { }

}

