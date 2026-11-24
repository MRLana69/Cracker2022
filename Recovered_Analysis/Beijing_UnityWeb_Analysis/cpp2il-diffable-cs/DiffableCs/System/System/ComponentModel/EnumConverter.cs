namespace System.ComponentModel;

public class EnumConverter : TypeConverter
{
	private StandardValuesCollection values; //Field offset: 0x8
	private Type type; //Field offset: 0xC

	public EnumConverter(Type type) { }

}

