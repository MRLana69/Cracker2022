namespace System.Reflection;

internal class MonoParameterInfo : RuntimeParameterInfo
{

	public override object DefaultValue
	{
		 get { } //Length: 52
	}

	internal MonoParameterInfo(ParameterInfo pinfo, MemberInfo member) { }

	public override object get_DefaultValue() { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

}

