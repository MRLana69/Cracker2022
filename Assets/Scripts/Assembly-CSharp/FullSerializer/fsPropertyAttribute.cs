using System;

namespace FullSerializer;

public sealed class fsPropertyAttribute : Attribute
{
	public string Name;

	public Type Converter;

	public fsPropertyAttribute()
	{
		Name = string.Empty;
	}

	public fsPropertyAttribute(string name)
	{
		Name = name;
	}
}
