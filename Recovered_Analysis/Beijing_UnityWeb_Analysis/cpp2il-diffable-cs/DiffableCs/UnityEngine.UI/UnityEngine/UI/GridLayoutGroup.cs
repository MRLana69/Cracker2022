namespace UnityEngine.UI;

public class GridLayoutGroup : LayoutGroup
{
	public enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	public enum Constraint
	{
		Flexible = 0,
		FixedColumnCount = 1,
		FixedRowCount = 2,
	}

	public enum Corner
	{
		UpperLeft = 0,
		UpperRight = 1,
		LowerLeft = 2,
		LowerRight = 3,
	}

	protected Corner m_StartCorner; //Field offset: 0x38
	protected Axis m_StartAxis; //Field offset: 0x3C
	protected Vector2 m_CellSize; //Field offset: 0x40
	protected Vector2 m_Spacing; //Field offset: 0x48
	protected Constraint m_Constraint; //Field offset: 0x50
	protected int m_ConstraintCount; //Field offset: 0x54

	public Vector2 cellSize
	{
		 get { } //Length: 56
		 set { } //Length: 14
	}

	public Constraint constraint
	{
		 get { } //Length: 6
		 set { } //Length: 101
	}

	public int constraintCount
	{
		 get { } //Length: 6
		 set { } //Length: 57
	}

	public Vector2 spacing
	{
		 get { } //Length: 100
		 set { } //Length: 11
	}

	public Axis startAxis
	{
		 get { } //Length: 6
		 set { } //Length: 56
	}

	public Corner startCorner
	{
		 get { } //Length: 114
		 set { } //Length: 99
	}

	protected GridLayoutGroup() { }

	public override void CalculateLayoutInputHorizontal() { }

	public override void CalculateLayoutInputVertical() { }

	public Vector2 get_cellSize() { }

	public Constraint get_constraint() { }

	public int get_constraintCount() { }

	public Vector2 get_spacing() { }

	public Axis get_startAxis() { }

	public Corner get_startCorner() { }

	public void set_cellSize(Vector2 value) { }

	public void set_constraint(Constraint value) { }

	public void set_constraintCount(int value) { }

	public void set_spacing(Vector2 value) { }

	public void set_startAxis(Axis value) { }

	public void set_startCorner(Corner value) { }

	private void SetCellsAlongAxis(int axis) { }

	public override void SetLayoutHorizontal() { }

	public override void SetLayoutVertical() { }

}

