namespace SYBO.Common.Utilities;

public class SyboRandom
{
	private IRandomGen _randomGen; //Field offset: 0x8

	public SyboRandom() { }

	public SyboRandom(IRandomGen randomGen) { }

	public bool Bool() { }

	public static IRandomGen MakeRandomGen() { }

	public float NextFloat() { }

	public uint NextUint() { }

	public T RandomElement(T[] array) { }

	public T RandomElement(IList<T> array) { }

	public int RandomElementIndex(ICollection<T> array) { }

	public T RandomElementNoRepeats(T[] array, T lastPickedElement) { }

	public T RandomElementNoRepeats(IList<T> array, T lastPickedElement) { }

	public int Range(int min, int max) { }

	public float Range(float min, float max) { }

	public void SetGenerator(IRandomGen randomGen) { }

	public void Shuffle(IList<T> list) { }

	public float Value() { }

}

