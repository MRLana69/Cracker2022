namespace Kiloo;

public class RandomTimeDelay : BaseTimeDelay
{
	private float _maxTimeDelay; //Field offset: 0xC
	private float _minTimeDelay; //Field offset: 0x10

	public override float delay
	{
		 get { } //Length: 6
	}

	public RandomTimeDelay() { }

	public override float get_delay() { }

}

