//Type is in global namespace

public class AudioLoopInfo
{
	public AudioClip[] clips; //Field offset: 0x8
	public float minStartTime; //Field offset: 0xC
	public float maxStartTime; //Field offset: 0x10
	public float minStartPitch; //Field offset: 0x14
	public float maxStartPitch; //Field offset: 0x18
	public float minStartVolume; //Field offset: 0x1C
	public float maxStartVolume; //Field offset: 0x20
	public float minTargetPitch; //Field offset: 0x24
	public float maxTargetPitch; //Field offset: 0x28
	public float minTargetVolume; //Field offset: 0x2C
	public float maxTargatVolume; //Field offset: 0x30
	public float minStopTime; //Field offset: 0x34
	public float maxStopTime; //Field offset: 0x38
	public float minStopPitch; //Field offset: 0x3C
	public float maxStopPitch; //Field offset: 0x40
	public AudioRolloffMode Rollof; //Field offset: 0x44

	public AudioLoopInfo() { }

}

