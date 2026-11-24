namespace SYBO.Components.Logging;

public class GestureUnlock : MonoBehaviour
{
	public Vector2[] Gesture; //Field offset: 0xC
	public float InchWidth; //Field offset: 0x10
	public int Position; //Field offset: 0x14
	public Behaviour Target; //Field offset: 0x18
	public UnityEvent OnUnlock; //Field offset: 0x1C

	public GestureUnlock() { }

	private bool AtPosition(Vector2 input, Vector2 point) { }

	private bool DistanceGreen(Vector2 input, Vector2 point1, Vector2 point2) { }

	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b) { }

	private Vector2 GetMouseScreenPosition() { }

	private void OnDrawGizmosSelected() { }

	private void Update() { }

}

