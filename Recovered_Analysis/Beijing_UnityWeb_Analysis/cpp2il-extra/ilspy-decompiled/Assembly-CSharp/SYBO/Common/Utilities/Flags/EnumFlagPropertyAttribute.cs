using System;
using UnityEngine;

namespace SYBO.Common.Utilities.Flags;

public class EnumFlagPropertyAttribute : PropertyAttribute
{
	public Type EnumType;

	public EnumFlagPropertyAttribute(Type enumType)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = enumType;
	}
}
