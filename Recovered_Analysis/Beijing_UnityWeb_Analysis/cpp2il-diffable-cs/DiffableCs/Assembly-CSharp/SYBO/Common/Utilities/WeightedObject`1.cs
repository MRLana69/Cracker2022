namespace SYBO.Common.Utilities;

public class WeightedObject`1 : IWeighted
{
	private int _weight; //Field offset: 0x0
	private T _object; //Field offset: 0x0

	public T Object
	{
		 get { } //Length: 6
	}

	public int Weight
	{
		 get { } //Length: 36
	}

	public WeightedObject`1() { }

	public WeightedObject`1(T weightedObject, int weight) { }

	public T get_Object() { }

	public int get_Weight() { }

}

