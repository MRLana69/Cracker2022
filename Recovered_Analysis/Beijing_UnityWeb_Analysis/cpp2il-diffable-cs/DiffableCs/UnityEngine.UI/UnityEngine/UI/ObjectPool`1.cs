namespace UnityEngine.UI;

internal class ObjectPool`1
{
	private readonly Stack<T> m_Stack; //Field offset: 0x0
	private readonly UnityAction<T> m_ActionOnGet; //Field offset: 0x0
	private readonly UnityAction<T> m_ActionOnRelease; //Field offset: 0x0
	private int <countAll>k__BackingField; //Field offset: 0x0

	public int countActive
	{
		 get { } //Length: 6
	}

	public int countAll
	{
		 get { } //Length: 152
		private set { } //Length: 10
	}

	public int countInactive
	{
		 get { } //Length: 71
	}

	public ObjectPool`1(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }

	public T Get() { }

	public int get_countActive() { }

	public int get_countAll() { }

	public int get_countInactive() { }

	public void Release(T element) { }

	private void set_countAll(int value) { }

}

