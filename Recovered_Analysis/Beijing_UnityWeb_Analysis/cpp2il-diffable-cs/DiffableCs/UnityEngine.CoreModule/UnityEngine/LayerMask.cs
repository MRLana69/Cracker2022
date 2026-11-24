namespace UnityEngine;

public struct LayerMask
{
	private int m_Mask; //Field offset: 0x0

	public int value
	{
		 get { } //Length: 35
		 set { } //Length: 53
	}

	public int get_value() { }

	public static int NameToLayer(string layerName) { }

	public static int op_Implicit(LayerMask mask) { }

	public static LayerMask op_Implicit(int intVal) { }

	public void set_value(int value) { }

}

