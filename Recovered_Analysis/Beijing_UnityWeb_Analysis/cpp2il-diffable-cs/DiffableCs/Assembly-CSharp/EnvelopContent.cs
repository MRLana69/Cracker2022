//Type is in global namespace

public class EnvelopContent : MonoBehaviour
{
	public Transform targetRoot; //Field offset: 0xC
	public int padLeft; //Field offset: 0x10
	public int padRight; //Field offset: 0x14
	public int padBottom; //Field offset: 0x18
	public int padTop; //Field offset: 0x1C
	public bool ignoreDisabled; //Field offset: 0x20
	private bool mStarted; //Field offset: 0x21

	public EnvelopContent() { }

	public void Execute() { }

	private void OnEnable() { }

	private void Start() { }

}

