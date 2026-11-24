//Type is in global namespace

public class TweenVolume : UITweener
{
	public float from; //Field offset: 0x58
	public float to; //Field offset: 0x5C
	private AudioSource mSource; //Field offset: 0x60

	public AudioSource audioSource
	{
		 get { } //Length: 109
	}

	public float value
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public float volume
	{
		 get { } //Length: 15
		 set { } //Length: 17
	}

	public TweenVolume() { }

	public static TweenVolume Begin(GameObject go, float duration, float targetVolume) { }

	public AudioSource get_audioSource() { }

	public float get_value() { }

	public float get_volume() { }

	protected override void OnUpdate(float factor, bool isFinished) { }

	public void set_value(float value) { }

	public void set_volume(float value) { }

	public override void SetEndToCurrentValue() { }

	public override void SetStartToCurrentValue() { }

}

