namespace Kiloo.GameCenter;

public class GameCenterLoadPhotoRequest : GameCenterRequest
{
	private string <playerID>k__BackingField; //Field offset: 0x14
	private PhotoSize <size>k__BackingField; //Field offset: 0x18
	private int <textureWidth>k__BackingField; //Field offset: 0x1C
	private int <textureHeight>k__BackingField; //Field offset: 0x20
	private Texture2D <result>k__BackingField; //Field offset: 0x24

	public string playerID
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Texture2D result
	{
		 get { } //Length: 6
		internal set { } //Length: 8
	}

	public PhotoSize size
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public int textureHeight
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int textureWidth
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public GameCenterLoadPhotoRequest() { }

	public string get_playerID() { }

	public Texture2D get_result() { }

	public PhotoSize get_size() { }

	public int get_textureHeight() { }

	public int get_textureWidth() { }

	public void set_playerID(string value) { }

	internal void set_result(Texture2D value) { }

	public void set_size(PhotoSize value) { }

	public void set_textureHeight(int value) { }

	public void set_textureWidth(int value) { }

}

