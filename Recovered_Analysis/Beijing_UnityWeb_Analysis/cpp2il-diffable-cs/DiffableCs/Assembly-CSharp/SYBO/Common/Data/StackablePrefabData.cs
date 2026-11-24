namespace SYBO.Common.Data;

public class StackablePrefabData
{
	private List<GameObject> _prefabs; //Field offset: 0x8
	private StackableBuildDirection _stackableBuildDirection; //Field offset: 0xC

	public List<GameObject> Prefabs
	{
		 get { } //Length: 436
	}

	public StackableBuildDirection StackableBuildDirection
	{
		 get { } //Length: 6
	}

	public StackablePrefabData() { }

	public List<GameObject> get_Prefabs() { }

	public StackableBuildDirection get_StackableBuildDirection() { }

}

