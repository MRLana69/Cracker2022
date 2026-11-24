namespace Kiloo.Google;

public class GoogleSignInPluginRequest
{
	private bool <silent>k__BackingField; //Field offset: 0x8
	private int <errorCode>k__BackingField; //Field offset: 0xC
	private string <errorMessage>k__BackingField; //Field offset: 0x10
	private IGoogleProfile <profile>k__BackingField; //Field offset: 0x14

	public int errorCode
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public string errorMessage
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public IGoogleProfile profile
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public bool silent
	{
		 get { } //Length: 9
		 set { } //Length: 105
	}

	public GoogleSignInPluginRequest() { }

	public int get_errorCode() { }

	public string get_errorMessage() { }

	public IGoogleProfile get_profile() { }

	public bool get_silent() { }

	public void set_errorCode(int value) { }

	public void set_errorMessage(string value) { }

	public void set_profile(IGoogleProfile value) { }

	public void set_silent(bool value) { }

}

