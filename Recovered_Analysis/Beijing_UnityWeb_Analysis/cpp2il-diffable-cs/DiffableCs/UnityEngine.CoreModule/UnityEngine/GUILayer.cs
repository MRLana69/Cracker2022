namespace UnityEngine;

public class GUILayer : Behaviour
{

	public GUIElement HitTest(Vector3 screenPosition) { }

	private GUIElement HitTest(Vector2 screenPosition) { }

	private GUIElement HitTest_Injected(ref Vector2 screenPosition) { }

}

