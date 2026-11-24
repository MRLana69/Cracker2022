//Type is in global namespace

public class CharacterModelPreview : MonoBehaviour
{
	private GameObject _rigPrefab; //Field offset: 0xC
	private SkinnedMeshRenderer[] _renderes; //Field offset: 0x10

	public SkinnedMeshRenderer[] Renderes
	{
		 get { } //Length: 67
	}

	public CharacterModelPreview() { }

	private void Awake() { }

	private void BuildRig() { }

	public SkinnedMeshRenderer[] get_Renderes() { }

}

