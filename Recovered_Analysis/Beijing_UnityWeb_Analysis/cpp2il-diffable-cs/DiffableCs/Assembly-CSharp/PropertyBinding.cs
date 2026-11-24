//Type is in global namespace

public class PropertyBinding : MonoBehaviour
{
	public enum Direction
	{
		SourceUpdatesTarget = 0,
		TargetUpdatesSource = 1,
		BiDirectional = 2,
	}

	public enum UpdateCondition
	{
		OnStart = 0,
		OnUpdate = 1,
		OnLateUpdate = 2,
		OnFixedUpdate = 3,
	}

	public PropertyReference source; //Field offset: 0xC
	public PropertyReference target; //Field offset: 0x10
	public Direction direction; //Field offset: 0x14
	public UpdateCondition update; //Field offset: 0x18
	public bool editMode; //Field offset: 0x1C
	private object mLastValue; //Field offset: 0x20

	public PropertyBinding() { }

	private void FixedUpdate() { }

	private void LateUpdate() { }

	private void OnValidate() { }

	private void Start() { }

	private void Update() { }

	public void UpdateTarget() { }

}

