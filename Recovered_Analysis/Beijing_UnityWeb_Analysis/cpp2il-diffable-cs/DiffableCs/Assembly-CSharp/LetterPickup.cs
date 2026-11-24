//Type is in global namespace

public class LetterPickup : MonoBehaviour
{
	public const char NO_LETTER = '\u0'; //Field offset: 0x0
	public MeshFilter LetterMesh; //Field offset: 0xC
	public List<Mesh> Letters; //Field offset: 0x10
	public bool shouldSpawnParticles; //Field offset: 0x14
	protected char _letterChar; //Field offset: 0x16

	public LetterPickup() { }

	private void Awake() { }

	protected virtual void OnActivate() { }

	protected virtual void OnDeactivate() { }

}

