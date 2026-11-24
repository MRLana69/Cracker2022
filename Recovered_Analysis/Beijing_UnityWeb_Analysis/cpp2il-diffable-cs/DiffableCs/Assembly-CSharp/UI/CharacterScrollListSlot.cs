namespace UI;

public class CharacterScrollListSlot : MonoBehaviour
{
	public int index; //Field offset: 0xC
	public CharacterId characterId; //Field offset: 0x10
	public int themeIndex; //Field offset: 0x14
	public GameObject model; //Field offset: 0x18
	public ScrollListCharacterUI ui; //Field offset: 0x1C
	public CharacterModelRequest request; //Field offset: 0x20

	public bool modelReady
	{
		 get { } //Length: 390
	}

	public CharacterScrollListSlot() { }

	public void DestroyModel() { }

	public bool get_modelReady() { }

	public void SetEnabledState(bool modelEnabled, bool uiEnabled) { }

}

