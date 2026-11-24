using System.Runtime.InteropServices;

[StructLayout((LayoutKind)0, Size = 52)]
public struct MissionInfo
{
	public Mission mission;

	public MissionTemplate template;

	public int progress;

	public bool complete;
}
