namespace JetBrains.Annotations;

public sealed class ContractAnnotationAttribute : Attribute
{
	private string <Contract>k__BackingField; //Field offset: 0x8
	private bool <ForceFullStates>k__BackingField; //Field offset: 0xC

	private string Contract
	{
		 set { } //Length: 18
	}

	private bool ForceFullStates
	{
		 set { } //Length: 11
	}

	public ContractAnnotationAttribute(string contract) { }

	public ContractAnnotationAttribute(string contract, bool forceFullStates) { }

	private void set_Contract(string value) { }

	private void set_ForceFullStates(bool value) { }

}

