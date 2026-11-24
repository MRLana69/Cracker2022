namespace UnityEngine.EventSystems;

public class BaseInput : UIBehaviour
{

	public virtual Vector2 compositionCursorPos
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public virtual string compositionString
	{
		 get { } //Length: 85
	}

	public virtual IMECompositionMode imeCompositionMode
	{
		 get { } //Length: 7
		 set { } //Length: 197
	}

	public virtual Vector2 mousePosition
	{
		 get { } //Length: 49
	}

	public virtual bool mousePresent
	{
		 get { } //Length: 7
	}

	public virtual Vector2 mouseScrollDelta
	{
		 get { } //Length: 129
	}

	public virtual int touchCount
	{
		 get { } //Length: 7
	}

	public virtual bool touchSupported
	{
		 get { } //Length: 7
	}

	public BaseInput() { }

	public virtual Vector2 get_compositionCursorPos() { }

	public virtual string get_compositionString() { }

	public virtual IMECompositionMode get_imeCompositionMode() { }

	public virtual Vector2 get_mousePosition() { }

	public virtual bool get_mousePresent() { }

	public virtual Vector2 get_mouseScrollDelta() { }

	public virtual int get_touchCount() { }

	public virtual bool get_touchSupported() { }

	public virtual float GetAxisRaw(string axisName) { }

	public virtual bool GetButtonDown(string buttonName) { }

	public virtual bool GetMouseButton(int button) { }

	public virtual bool GetMouseButtonDown(int button) { }

	public virtual bool GetMouseButtonUp(int button) { }

	public virtual Touch GetTouch(int index) { }

	public virtual void set_compositionCursorPos(Vector2 value) { }

	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

}

