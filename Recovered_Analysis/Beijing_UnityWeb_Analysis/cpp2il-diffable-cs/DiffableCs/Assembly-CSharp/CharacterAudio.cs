//Type is in global namespace

public class CharacterAudio : MonoBehaviour
{
	private AudioClipInfo DodgeLeft; //Field offset: 0xC
	private AudioClipInfo TeleboardDodgeLeft; //Field offset: 0x10
	private AudioClipInfo H_Left; //Field offset: 0x14
	private AudioClipInfo H_Right; //Field offset: 0x18
	private AudioClipInfo StumbleSound; //Field offset: 0x1C
	private AudioClipInfo StumbleBushSound; //Field offset: 0x20
	private AudioClipInfo StumbleSideSound; //Field offset: 0x24
	private AudioClipInfo PowerupSound; //Field offset: 0x28
	private AudioClipInfo PowerdownSound; //Field offset: 0x2C
	private AudioClipInfo[] TurboHeadstartSound; //Field offset: 0x30
	private AudioClipInfo[] ScooreBoosterSound; //Field offset: 0x34
	public AudioClipInfo DodgeRight; //Field offset: 0x38
	public AudioClipInfo TeleboardDodgeRight; //Field offset: 0x3C
	private Hoverboard hoverboard; //Field offset: 0x40
	private Character character; //Field offset: 0x44
	private AudioStateLoop audioStateLoop; //Field offset: 0x48
	private Game game; //Field offset: 0x4C
	private Dictionary<StumbleType, AudioClipInfo> stumbleClips; //Field offset: 0x50

	public CharacterAudio() { }

	public void Awake() { }

	private void HandleOnChangeTrack(OnChangeTrackDirection direction) { }

	private void HandleOnScoreBoostActivated(int scoreboosterTier) { }

	private void HandleOnStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble) { }

	private void HandleOnTurboHeadstartInput(int version) { }

	private void JetpackOnStart() { }

	private void JetpackOnStop() { }

	private void PogostickStop() { }

}

