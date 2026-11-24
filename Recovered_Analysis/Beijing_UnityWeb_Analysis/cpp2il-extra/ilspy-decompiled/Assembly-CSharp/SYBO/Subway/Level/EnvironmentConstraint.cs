using System;
using System.Runtime.InteropServices;

namespace SYBO.Subway.Level;

[Serializable]
[StructLayout((LayoutKind)0, Size = 12)]
public struct EnvironmentConstraint
{
	public EnvironmentType Type;

	public EnvironmentDensity SideDensity;

	public EnvironmentSegmentLength SegmentLength;
}
