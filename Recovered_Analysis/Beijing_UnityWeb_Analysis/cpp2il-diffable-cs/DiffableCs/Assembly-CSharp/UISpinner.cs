//Type is in global namespace

public class UISpinner : MonoBehaviour
{
	private UISprite _sprite; //Field offset: 0xC
	private float _speed; //Field offset: 0x10
	private bool _rotateClockWise; //Field offset: 0x14
	private bool _startManually; //Field offset: 0x15
	private bool _enableDisableSprite; //Field offset: 0x16
	private bool _callStartSpinning; //Field offset: 0x17
	private bool _callStopSpinning; //Field offset: 0x18
	private bool _shouldRotate; //Field offset: 0x19
	private float _deltaTime; //Field offset: 0x1C

	public bool IsAnimating
	{
		 get { } //Length: 66
	}

	public UISpinner() { }

	private void Awake() { }

	public bool get_IsAnimating() { }

	private void OnEnable() { }

	public void ResetSpriteRotation() { }

	public void StartSpinning() { }

	public void StopSpinning() { }

	private void Update() { }

}

