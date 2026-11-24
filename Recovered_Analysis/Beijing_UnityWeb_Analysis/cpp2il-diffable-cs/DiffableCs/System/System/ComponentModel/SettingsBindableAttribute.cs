namespace System.ComponentModel;

public sealed class SettingsBindableAttribute : Attribute
{
	public static readonly SettingsBindableAttribute Yes; //Field offset: 0x0
	public static readonly SettingsBindableAttribute No; //Field offset: 0x4
	private bool _bindable; //Field offset: 0x8

	public bool Bindable
	{
		 get { } //Length: 9
	}

	private static SettingsBindableAttribute() { }

	public SettingsBindableAttribute(bool bindable) { }

	public override bool Equals(object obj) { }

	public bool get_Bindable() { }

	public override int GetHashCode() { }

}

