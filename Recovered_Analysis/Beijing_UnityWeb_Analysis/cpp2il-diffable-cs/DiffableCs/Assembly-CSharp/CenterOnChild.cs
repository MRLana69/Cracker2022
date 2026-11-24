//Type is in global namespace

public class CenterOnChild : MonoBehaviour
{
	private Action selectedObjectChanged; //Field offset: 0xC
	private Action selectedObjectReselected; //Field offset: 0x10
	private UIScrollView mDrag; //Field offset: 0x14
	private GameObject _centeredObject; //Field offset: 0x18
	private GameObject _selectedObject; //Field offset: 0x1C
	public bool characterWasClicked; //Field offset: 0x20

	public event Action selectedObjectChanged
	{
		 add { } //Length: 343
		 remove { } //Length: 111
	}

	public event Action selectedObjectReselected
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public GameObject selectedObject
	{
		 get { } //Length: 15
		private set { } //Length: 111
	}

	public CenterOnChild() { }

	public void add_selectedObjectChanged(Action value) { }

	public void add_selectedObjectReselected(Action value) { }

	public bool CenterOnClosestChildAtPosition(Vector2 clickPositionOnScreen) { }

	public void CenterOnTransform(Transform target, bool instant = false) { }

	public void CharacterFocusedFromClick() { }

	public void ClearCenterObject() { }

	public GameObject get_selectedObject() { }

	private void OnDragFinished() { }

	private void OnEnable() { }

	private void OnSpringFinished() { }

	public void Recenter() { }

	public void remove_selectedObjectChanged(Action value) { }

	public void remove_selectedObjectReselected(Action value) { }

	private void set_selectedObject(GameObject value) { }

}

