namespace Mono;

internal struct RuntimeGenericParamInfoHandle
{
	private GenericParamInfo* value; //Field offset: 0x0

	internal GenericParameterAttributes Attributes
	{
		 get { } //Length: 12
	}

	internal Type[] Constraints
	{
		 get { } //Length: 12
	}

	internal RuntimeGenericParamInfoHandle(nint ptr) { }

	internal GenericParameterAttributes get_Attributes() { }

	internal Type[] get_Constraints() { }

	private Type[] GetConstraints() { }

	private int GetConstraintsCount() { }

}

