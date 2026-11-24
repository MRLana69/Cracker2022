namespace SYBO.Subway.StateSystem.States.Settings;

public class JetpackStateSettings
{
	private float _speedup; //Field offset: 0xC
	private float _coinOffset; //Field offset: 0x10

	public float CoinOffset
	{
		 get { } //Length: 6
	}

	public float Speedup
	{
		 get { } //Length: 6
	}

	public JetpackStateSettings() { }

	public float get_CoinOffset() { }

	public float get_Speedup() { }

}

