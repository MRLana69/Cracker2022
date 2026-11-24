using UnityEngine;

public class ModelTrigger : MonoBehaviour
{
	public enum ModelPosition
	{
		CharacterScreen,
		LoseScreen
	}

	public ModelPosition modelPosition;

	public ModelTrigger()
	{
		CancelInvoke();
	}
}
