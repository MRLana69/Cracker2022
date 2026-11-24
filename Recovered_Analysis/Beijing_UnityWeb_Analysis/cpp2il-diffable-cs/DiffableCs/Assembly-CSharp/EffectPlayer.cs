//Type is in global namespace

public class EffectPlayer : MonoBehaviour
{
	private List<GameObject> _effectList; //Field offset: 0xC
	private float _delay; //Field offset: 0x10
	private float _duration; //Field offset: 0x14
	private float _maxDuration; //Field offset: 0x18
	private float _minimumRotation; //Field offset: 0x1C
	private float _maximumRotation; //Field offset: 0x20
	private bool _doLoop; //Field offset: 0x24
	private int _loopFrame; //Field offset: 0x28
	private bool _doRandomizeStartingIndex; //Field offset: 0x2C
	private float _currentDelay; //Field offset: 0x30
	private int _currentIndex; //Field offset: 0x34
	private float _currentWait; //Field offset: 0x38
	private int _startingIndex; //Field offset: 0x3C
	private float _selectedDuration; //Field offset: 0x40

	public float Duration
	{
		 get { } //Length: 136
	}

	public int LoopFrame
	{
		 set { } //Length: 929
	}

	public EffectPlayer() { }

	private void Awake() { }

	public float get_Duration() { }

	private void OnEnable() { }

	private void Reset() { }

	public void set_LoopFrame(int value) { }

	private void SetActiveIndex(int index) { }

	private void Toggle(GameObject gameObject, bool toggle) { }

	private void Update() { }

}

