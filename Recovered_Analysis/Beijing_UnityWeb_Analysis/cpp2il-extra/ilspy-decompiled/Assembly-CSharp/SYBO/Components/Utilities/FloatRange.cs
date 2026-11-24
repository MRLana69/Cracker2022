using System;
using System.Runtime.InteropServices;

namespace SYBO.Components.Utilities;

[Serializable]
[StructLayout((LayoutKind)0, Size = 8)]
public struct FloatRange
{
	public float Low;

	public float High;
}
