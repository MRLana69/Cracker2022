namespace UnityEngine.UI;

public class AnimationTriggers
{
	private const string kDefaultNormalAnimName = "Normal"; //Field offset: 0x0
	private const string kDefaultHighlightedAnimName = "Highlighted"; //Field offset: 0x0
	private const string kDefaultPressedAnimName = "Pressed"; //Field offset: 0x0
	private const string kDefaultSelectedAnimName = "Selected"; //Field offset: 0x0
	private const string kDefaultDisabledAnimName = "Disabled"; //Field offset: 0x0
	private string m_NormalTrigger; //Field offset: 0x8
	private string m_HighlightedTrigger; //Field offset: 0xC
	private string m_PressedTrigger; //Field offset: 0x10
	private string m_SelectedTrigger; //Field offset: 0x14
	private string m_DisabledTrigger; //Field offset: 0x18

	public string disabledTrigger
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string highlightedTrigger
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string normalTrigger
	{
		 get { } //Length: 356
		 set { } //Length: 53
	}

	public string pressedTrigger
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string selectedTrigger
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public AnimationTriggers() { }

	public string get_disabledTrigger() { }

	public string get_highlightedTrigger() { }

	public string get_normalTrigger() { }

	public string get_pressedTrigger() { }

	public string get_selectedTrigger() { }

	public void set_disabledTrigger(string value) { }

	public void set_highlightedTrigger(string value) { }

	public void set_normalTrigger(string value) { }

	public void set_pressedTrigger(string value) { }

	public void set_selectedTrigger(string value) { }

}

