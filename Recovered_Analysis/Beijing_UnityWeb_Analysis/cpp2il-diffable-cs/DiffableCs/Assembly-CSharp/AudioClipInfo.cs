//Type is in global namespace

public class AudioClipInfo
{
	public AudioClip Clip; //Field offset: 0x8
	public float minPitch; //Field offset: 0xC
	public float maxPitch; //Field offset: 0x10
	public float minVolume; //Field offset: 0x14
	public float maxVolume; //Field offset: 0x18
	public AudioRolloffMode Rollof; //Field offset: 0x1C

	public AudioClipInfo() { }

	public override string ToString() { }

}

