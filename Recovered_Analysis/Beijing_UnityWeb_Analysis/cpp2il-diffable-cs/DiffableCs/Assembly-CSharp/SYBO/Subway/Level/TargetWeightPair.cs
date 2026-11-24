namespace SYBO.Subway.Level;

public class TargetWeightPair
{
	private GameObject _target; //Field offset: 0x8
	private float _weight; //Field offset: 0xC

	public GameObject Target
	{
		 get { } //Length: 6
	}

	public float Weight
	{
		 get { } //Length: 6
	}

	public TargetWeightPair() { }

	public GameObject get_Target() { }

	public float get_Weight() { }

}

