namespace UI;

public class DailyChallengeColorChanger : MonoBehaviour
{
	public UILabel shadowLabel; //Field offset: 0xC
	public Color MyColorActive; //Field offset: 0x10
	public Color MyColorInactive; //Field offset: 0x20
	public Color shadowColorActive; //Field offset: 0x30
	public Color shadowColorInactive; //Field offset: 0x40
	private string _letterColorActiveAsString; //Field offset: 0x50
	private string _letterColorInactiveAsString; //Field offset: 0x54
	private string _shadowColorActiveAsString; //Field offset: 0x58
	private string _shadowColorInactiveAsString; //Field offset: 0x5C
	private UILabel _myLabel; //Field offset: 0x60
	private string _cachedText; //Field offset: 0x64
	private string _cachedDailyWord; //Field offset: 0x68
	private IntMask _cachedDailyMask; //Field offset: 0x6C

	public DailyChallengeColorChanger() { }

	private void Awake() { }

	private void EncodeColors() { }

	private void OnEnable() { }

	private void Update() { }

	private void UpdateDailyWord() { }

}

