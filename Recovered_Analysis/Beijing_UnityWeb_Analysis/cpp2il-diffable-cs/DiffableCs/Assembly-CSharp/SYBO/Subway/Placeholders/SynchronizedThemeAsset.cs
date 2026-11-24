namespace SYBO.Subway.Placeholders;

public class SynchronizedThemeAsset : MonoBehaviour
{
	private List<Component> _themedComponents; //Field offset: 0xC
	public bool _canSynchronize; //Field offset: 0x10

	public bool CanSynchronize
	{
		 get { } //Length: 6
		 set { } //Length: 126
	}

	public List<Component> ThemedComponents
	{
		 get { } //Length: 104
	}

	public SynchronizedThemeAsset() { }

	public bool get_CanSynchronize() { }

	public List<Component> get_ThemedComponents() { }

	public void set_CanSynchronize(bool value) { }

}

