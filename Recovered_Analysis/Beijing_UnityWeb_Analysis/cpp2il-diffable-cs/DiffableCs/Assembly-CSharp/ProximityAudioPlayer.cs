//Type is in global namespace

public class ProximityAudioPlayer : MonoBehaviour
{
	private AudioClipInfo _clipInfo; //Field offset: 0xC
	private float _maxZProximity; //Field offset: 0x10
	private float _minZProximity; //Field offset: 0x14
	private bool _useParentPosition; //Field offset: 0x18
	private bool _muted; //Field offset: 0x19
	private AudioSource _source; //Field offset: 0x1C
	private Character _character; //Field offset: 0x20

	public ProximityAudioPlayer() { }

	private void OnSfxSettingChanged() { }

	public void ProximityBasedPlay() { }

	private void Start() { }

	public void Stop() { }

}

