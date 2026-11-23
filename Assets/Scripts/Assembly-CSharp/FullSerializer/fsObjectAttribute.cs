using System;

namespace FullSerializer;

public sealed class fsObjectAttribute : Attribute
{
	public Type[] PreviousModels;

	public string VersionString;

	public fsMemberSerialization MemberSerialization = fsMemberSerialization.Default;

	public Type Converter;

	public Type Processor;

	public fsObjectAttribute()
	{
	}

	public fsObjectAttribute(string versionString, Type[] previousModels)
	{
		VersionString = versionString;
		PreviousModels = previousModels;
	}
}
