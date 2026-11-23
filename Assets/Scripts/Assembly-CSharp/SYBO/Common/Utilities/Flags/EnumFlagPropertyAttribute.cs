using System;
using UnityEngine;

namespace SYBO.Common.Utilities.Flags;

public class EnumFlagPropertyAttribute(Type enumType) : PropertyAttribute
{
	public Type EnumType = enumType;
}
