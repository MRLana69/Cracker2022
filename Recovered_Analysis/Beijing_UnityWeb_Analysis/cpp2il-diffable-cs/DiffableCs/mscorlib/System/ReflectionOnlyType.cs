namespace System;

internal class ReflectionOnlyType : RuntimeType
{

	public override RuntimeTypeHandle TypeHandle
	{
		 get { } //Length: 156
	}

	private ReflectionOnlyType() { }

	public override RuntimeTypeHandle get_TypeHandle() { }

}

