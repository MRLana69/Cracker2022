//Type is in global namespace

public class EnemiesRig : MonoBehaviour
{
	private Animation _guardAnimation; //Field offset: 0xC
	private Animation _dogAnimation; //Field offset: 0x10

	public Animation DogAnimation
	{
		 get { } //Length: 6
	}

	public Animation GuardAnimation
	{
		 get { } //Length: 6
	}

	public EnemiesRig() { }

	public Animation get_DogAnimation() { }

	public Animation get_GuardAnimation() { }

}

