namespace SYBO.Components.Utilities.Validators;

public abstract class Validator`1
{
	private bool <IsEnabled>k__BackingField; //Field offset: 0x0

	public bool IsEnabled
	{
		 get { } //Length: 106
		 set { } //Length: 11
	}

	public Validator`1() { }

	public bool get_IsEnabled() { }

	public abstract bool IsValid(T value) { }

	public void set_IsEnabled(bool value) { }

	public abstract T Validate(T value) { }

}

