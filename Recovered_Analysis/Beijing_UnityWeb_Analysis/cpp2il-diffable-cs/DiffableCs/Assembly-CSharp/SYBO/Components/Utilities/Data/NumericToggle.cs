namespace SYBO.Components.Utilities.Data;

public abstract class NumericToggle
{
	public const string DefaultMessage = "(Default)"; //Field offset: 0x0
	public const int UnsetInt = -1; //Field offset: 0x0
	private bool _isEnabled; //Field offset: 0x8
	private bool _isEnabledOriginal; //Field offset: 0x9
	private string _inspectorMessage; //Field offset: 0xC
	private string _inspectorMessageOriginal; //Field offset: 0x10
	private bool _showInspectorMessage; //Field offset: 0x14

	public string InspectorMessage
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public string InspectorMessageOriginal
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public bool IsEnabled
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public bool IsEnabledOriginal
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool ShowInspectorMessage
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	protected NumericToggle() { }

	public string get_InspectorMessage() { }

	public string get_InspectorMessageOriginal() { }

	public bool get_IsEnabled() { }

	public bool get_IsEnabledOriginal() { }

	public bool get_ShowInspectorMessage() { }

	protected abstract bool IsOriginalValue() { }

	public virtual void OnChanged() { }

	public void set_InspectorMessage(string value) { }

	public void set_InspectorMessageOriginal(string value) { }

	public void set_IsEnabled(bool value) { }

	public void set_IsEnabledOriginal(bool value) { }

	public void set_ShowInspectorMessage(bool value) { }

}

