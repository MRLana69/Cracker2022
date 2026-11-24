namespace UI.MessageCenter;

public class BackBtnBehaviour : MonoBehaviour
{
	public enum ScreenChangeType
	{
		PushScreen = 0,
		ClosePopup = 1,
		ExitGame = 2,
		SaveMePopup = 3,
		NotEnoughCurrency = 4,
	}

	public ScreenChangeType screenChangeType; //Field offset: 0xC
	public string screenNameToOpen; //Field offset: 0x10

	public BackBtnBehaviour() { }

	private static void LogFlurry() { }

	private void Send() { }

	private void Update() { }

}

