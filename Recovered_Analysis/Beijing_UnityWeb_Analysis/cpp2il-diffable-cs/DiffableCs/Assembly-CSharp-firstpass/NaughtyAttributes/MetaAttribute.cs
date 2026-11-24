namespace NaughtyAttributes;

public abstract class MetaAttribute : NaughtyAttribute
{
	private int order; //Field offset: 0x8

	public int Order
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	protected MetaAttribute() { }

	public int get_Order() { }

	public void set_Order(int value) { }

}

