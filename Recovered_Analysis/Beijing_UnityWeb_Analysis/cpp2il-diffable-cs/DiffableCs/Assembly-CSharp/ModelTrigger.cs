//Type is in global namespace

public class ModelTrigger : MonoBehaviour
{
	public enum ModelPosition
	{
		CharacterScreen = 0,
		LoseScreen = 1,
	}

	public ModelPosition modelPosition; //Field offset: 0xC

	public ModelTrigger() { }

}

