namespace SYBO.Subway.Level;

public class CharacterCollisionTrigger : MonoBehaviour
{
	private EventHandler OnCharacterEnter; //Field offset: 0xC

	public event EventHandler OnCharacterEnter
	{
		 add { } //Length: 112
		 remove { } //Length: 111
	}

	public CharacterCollisionTrigger() { }

	public void add_OnCharacterEnter(EventHandler value) { }

	private void OnTriggerEnter(Collider other) { }

	public void remove_OnCharacterEnter(EventHandler value) { }

}

