namespace UnityEngine.EventSystems;

public class AxisEventData : BaseEventData
{
	private Vector2 <moveVector>k__BackingField; //Field offset: 0x10
	private MoveDirection <moveDir>k__BackingField; //Field offset: 0x18

	public MoveDirection moveDir
	{
		 get { } //Length: 12
		 set { } //Length: 51
	}

	public Vector2 moveVector
	{
		 get { } //Length: 14
		 set { } //Length: 11
	}

	public AxisEventData(EventSystem eventSystem) { }

	public MoveDirection get_moveDir() { }

	public Vector2 get_moveVector() { }

	public void set_moveDir(MoveDirection value) { }

	public void set_moveVector(Vector2 value) { }

}

