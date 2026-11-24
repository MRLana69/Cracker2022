//Type is in global namespace

public class CharacterModifierCollection
{
	public static float TIME_LEFT_FOR_EXPIRE_SOON; //Field offset: 0x0
	private EventHandler<CharacterModifierCollectionChangedEventArgs> OnChanged; //Field offset: 0x8
	private CoinMagnet coinMagnet; //Field offset: 0xC
	private SuperSneakers superSneakers; //Field offset: 0x10
	private Hoverboard hoverboard; //Field offset: 0x14
	private DoubleScoreMultiplier doubleScoreMultiplier; //Field offset: 0x18
	private DoubleCoins doubleCoins; //Field offset: 0x1C
	private DoubleJump doubleJump; //Field offset: 0x20
	private PlusMultiplier plusMultiplier; //Field offset: 0x24
	private List<CharacterModifier> modifiers; //Field offset: 0x28
	private List<CharacterModifier> deadModifiers; //Field offset: 0x2C

	public event EventHandler<CharacterModifierCollectionChangedEventArgs> OnChanged
	{
		 add { } //Length: 11
		 remove { } //Length: 111
	}

	public CoinMagnet CoinMagnet
	{
		 get { } //Length: 6
	}

	public DoubleCoins DoubleCoins
	{
		 get { } //Length: 6
	}

	public DoubleJump DoubleJump
	{
		 get { } //Length: 6
	}

	public DoubleScoreMultiplier DoubleScoreMultiplier
	{
		 get { } //Length: 6
	}

	public Hoverboard Hoverboard
	{
		 get { } //Length: 6
	}

	public PlusMultiplier PlusMultiplier
	{
		 get { } //Length: 6
	}

	public SuperSneakers SuperSneakes
	{
		 get { } //Length: 6
	}

	private static CharacterModifierCollection() { }

	public CharacterModifierCollection() { }

	public void Add(CharacterModifier modifier) { }

	public void add_OnChanged(EventHandler<CharacterModifierCollectionChangedEventArgs> value) { }

	public void ExpireSoon() { }

	public CoinMagnet get_CoinMagnet() { }

	public DoubleCoins get_DoubleCoins() { }

	public DoubleJump get_DoubleJump() { }

	public DoubleScoreMultiplier get_DoubleScoreMultiplier() { }

	public Hoverboard get_Hoverboard() { }

	public PlusMultiplier get_PlusMultiplier() { }

	public SuperSneakers get_SuperSneakes() { }

	public bool IsActive(CharacterModifier modifier) { }

	public void Pause() { }

	public void PauseInAlternateRoutes() { }

	public void PauseInJetpackMode() { }

	private void RaiseOnEventChanged(CharacterModifierCollectionChangedEventArgs characterModifierCollectionChangedEventArgs) { }

	public void remove_OnChanged(EventHandler<CharacterModifierCollectionChangedEventArgs> value) { }

	public void Reset() { }

	public void Resume() { }

	public void Stop() { }

	public void StopWithNoEnding() { }

	public void Update() { }

}

