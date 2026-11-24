namespace SYBO.Subway.Level;

public enum EnvironmentType
{
	None = 0,
	Fillers = 1,
	Tube = 2,
	Pillars = 4,
	Gates = 8,
	Station = 16,
	Epic = 32,
	Empty = 64,
	All = int.MaxValue
}
