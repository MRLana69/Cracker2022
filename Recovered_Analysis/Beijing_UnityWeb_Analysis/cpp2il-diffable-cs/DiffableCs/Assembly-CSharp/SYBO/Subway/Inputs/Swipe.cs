namespace SYBO.Subway.Inputs;

public class Swipe
{
	public Vector3 start; //Field offset: 0x8
	public Vector3 end; //Field offset: 0x14
	public float startTime; //Field offset: 0x20
	public float endTime; //Field offset: 0x24

	public Swipe() { }

	public override string ToString() { }

}

