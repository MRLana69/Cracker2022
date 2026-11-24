namespace JetBrains.Annotations;

public sealed class UsedImplicitlyAttribute : Attribute
{
	private ImplicitUseKindFlags <UseKindFlags>k__BackingField; //Field offset: 0x8
	private ImplicitUseTargetFlags <TargetFlags>k__BackingField; //Field offset: 0xC

	private ImplicitUseTargetFlags TargetFlags
	{
		 set { } //Length: 8
	}

	private ImplicitUseKindFlags UseKindFlags
	{
		 set { } //Length: 15
	}

	public UsedImplicitlyAttribute() { }

	public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags) { }

	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags) { }

	private void set_TargetFlags(ImplicitUseTargetFlags value) { }

	private void set_UseKindFlags(ImplicitUseKindFlags value) { }

}

