namespace SYBO.Common.Utilities.Flags;

public class EnumFlagPropertyAttribute : PropertyAttribute
{
	public Type EnumType; //Field offset: 0x8

	public EnumFlagPropertyAttribute(Type enumType) { }

}

