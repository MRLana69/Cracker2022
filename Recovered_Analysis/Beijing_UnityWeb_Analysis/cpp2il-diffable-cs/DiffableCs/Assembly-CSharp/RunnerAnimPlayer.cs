//Type is in global namespace

public class RunnerAnimPlayer : AnimationSoundPlayer
{
	private Game game; //Field offset: 0x1C
	public AudioClipInfo run__LeftFoot; //Field offset: 0x20
	public AudioClipInfo run__RightFoot; //Field offset: 0x24
	public AudioClipInfo superRun__LeftFoot; //Field offset: 0x28
	public AudioClipInfo superRun__RightFoot; //Field offset: 0x2C
	public AudioClipInfo groundLeft; //Field offset: 0x30
	public AudioClipInfo groundRight; //Field offset: 0x34
	public AudioClipInfo groundLeft_super; //Field offset: 0x38
	public AudioClipInfo groundRight_super; //Field offset: 0x3C
	public AudioClipInfo jump; //Field offset: 0x40
	public AudioClipInfo roll; //Field offset: 0x44
	public AudioClipInfo landing; //Field offset: 0x48
	public AudioClipInfo h_jump; //Field offset: 0x4C
	public AudioClipInfo h_roll; //Field offset: 0x50
	public AudioClipInfo h_kick; //Field offset: 0x54
	public AudioClipInfo h_miniKick; //Field offset: 0x58
	public AudioClipInfo h_long; //Field offset: 0x5C
	public AudioClipInfo h_mid; //Field offset: 0x60
	public AudioClipInfo h_short; //Field offset: 0x64
	public AudioClipInfo h_landingGrind; //Field offset: 0x68
	public AudioClipInfo superJump; //Field offset: 0x6C
	public AudioClipInfo idlePaintSpray; //Field offset: 0x70
	public AudioClipInfo idlePaintSprayHigh; //Field offset: 0x74
	public AudioClipInfo idlePaintShake; //Field offset: 0x78
	public AudioClipInfo deathMovingTrain; //Field offset: 0x7C
	public AudioClipInfo deathBodyfall; //Field offset: 0x80
	public AudioStateLoop audioStateLoop; //Field offset: 0x84
	public bool playPaintSound; //Field offset: 0x88

	public RunnerAnimPlayer() { }

	public void Initialize() { }

	public void InitializeHoverboardClips() { }

	public void PlayIdlePaintSound(KeyFrameAudio info) { }

	public void PlayJumpSound(KeyFrameAudio info) { }

	public void PlayOrMutePaintSound(bool doPlay) { }

}

