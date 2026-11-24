namespace Kiloo;

public abstract class BaseTimeDelay : MonoBehaviour
{

	public abstract float delay
	{
		 get { } //Length: 0
	}

	protected BaseTimeDelay() { }

	public abstract float get_delay() { }

}

