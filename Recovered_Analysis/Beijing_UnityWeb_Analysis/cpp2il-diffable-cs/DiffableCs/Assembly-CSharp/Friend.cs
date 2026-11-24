//Type is in global namespace

public class Friend
{
	public class Status
	{
		public DateTime lastPokeTime; //Field offset: 0x8
		public int gamesCashedIn; //Field offset: 0x10

		public Status() { }

	}

	public const int RELATION_FACEBOOK_MASK = 1; //Field offset: 0x0
	public const int RELATION_GAMECENTER_MASK = 2; //Field offset: 0x0
	public int userid; //Field offset: 0x8
	public int score; //Field offset: 0xC
	public int meters; //Field offset: 0x10
	public int games; //Field offset: 0x14
	public int rank; //Field offset: 0x18
	public GameCenterProfile gcProfile; //Field offset: 0x1C
	public FacebookProfile fbProfile; //Field offset: 0x20
	public OfflineProfile offlineProfile; //Field offset: 0x24
	public Status status; //Field offset: 0x28
	private Action updated; //Field offset: 0x2C

	public event Action updated
	{
		 add { } //Length: 95
		 remove { } //Length: 111
	}

	public int gamesToCashIn
	{
		 get { } //Length: 37
	}

	public string id
	{
		 get { } //Length: 29
	}

	public Texture2D image
	{
		 get { } //Length: 108
	}

	public string name
	{
		 get { } //Length: 165
		 set { } //Length: 111
	}

	public int relation
	{
		 get { } //Length: 37
	}

	public bool shouldBePoked
	{
		 get { } //Length: 45
	}

	public Friend() { }

	public void add_updated(Action value) { }

	public int get_gamesToCashIn() { }

	public string get_id() { }

	public Texture2D get_image() { }

	public string get_name() { }

	public int get_relation() { }

	public bool get_shouldBePoked() { }

	public void InvokeUpdatedHandler() { }

	private bool IsPokeTime(DateTime lastPokeTime) { }

	public void remove_updated(Action value) { }

	public void set_name(string value) { }

}

