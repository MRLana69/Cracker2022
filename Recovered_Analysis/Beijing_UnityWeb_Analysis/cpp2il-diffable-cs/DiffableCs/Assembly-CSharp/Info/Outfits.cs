namespace Info;

public class Outfits : ScriptableObject
{
	private sealed class <>c__DisplayClass6_0
	{
		public CharacterId key; //Field offset: 0x8

		public <>c__DisplayClass6_0() { }

		internal bool <HasCharacter>b__0(OutfitSet outfitSet) { }

	}

	private static Outfits _instance; //Field offset: 0x0
	public OutfitSet[] outfitSets; //Field offset: 0xC

	public static Outfits instance
	{
		 get { } //Length: 91
	}

	private static Outfits() { }

	public Outfits() { }

	public static Outfits get_instance() { }

	public static Outfit GetOutfitForCharacter(CharacterId character, int outfitIndex) { }

	public static int GetThemeCount(CharacterId character) { }

	public static bool HasCharacter(CharacterId key) { }

	public static List<Outfit> TryGetOutfitsForCharacter(CharacterId character) { }

}

