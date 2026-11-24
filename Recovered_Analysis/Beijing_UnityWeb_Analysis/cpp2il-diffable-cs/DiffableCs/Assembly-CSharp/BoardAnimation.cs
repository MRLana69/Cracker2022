//Type is in global namespace

public class BoardAnimation : MonoBehaviour
{
	private sealed class <BoardFloating>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public BoardAnimation <>4__this; //Field offset: 0x10
		private float <currentxPositionSpeedDuration>5__2; //Field offset: 0x14
		private float <currentyPositionSpeedDuration>5__3; //Field offset: 0x18
		private float <currentzPositionSpeedDuration>5__4; //Field offset: 0x1C
		private float <currentxRotationSpeedDuration>5__5; //Field offset: 0x20
		private float <currentyRotationSpeedDuration>5__6; //Field offset: 0x24
		private float <currentzRotationSpeedDuration>5__7; //Field offset: 0x28
		private float <xPositionTimeMultiplier>5__8; //Field offset: 0x2C
		private float <yPositionTimeMultiplier>5__9; //Field offset: 0x30
		private float <zPositionTimeMultiplier>5__10; //Field offset: 0x34
		private float <xRotationTimeMultiplier>5__11; //Field offset: 0x38
		private float <yRotationTimeMultiplier>5__12; //Field offset: 0x3C
		private float <zRotationTimeMultiplier>5__13; //Field offset: 0x40
		private float <xPositionPositionModifer>5__14; //Field offset: 0x44
		private float <yPositionPositionModifer>5__15; //Field offset: 0x48
		private float <zPositionPositionModifer>5__16; //Field offset: 0x4C
		private float <xRotationPositionModifer>5__17; //Field offset: 0x50
		private float <yRotationPositionModifer>5__18; //Field offset: 0x54
		private float <zRotationPositionModifer>5__19; //Field offset: 0x58

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1841
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <BoardFloating>d__20(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private bool _animateFloating; //Field offset: 0xC
	private Transform boardObject; //Field offset: 0x10
	private Vector3 startPosition; //Field offset: 0x14
	private Vector3 startRotation; //Field offset: 0x20
	private float xPositiondifference; //Field offset: 0x2C
	private float yPositiondifference; //Field offset: 0x30
	private float zPositiondifference; //Field offset: 0x34
	private float xPositionSpeed; //Field offset: 0x38
	private float yPositionSpeed; //Field offset: 0x3C
	private float zPositionSpeed; //Field offset: 0x40
	private float xRotationDifference; //Field offset: 0x44
	private float yRotationDifference; //Field offset: 0x48
	private float zRotationDifference; //Field offset: 0x4C
	private float xRotationSpeed; //Field offset: 0x50
	private float yRotationSpeed; //Field offset: 0x54
	private float zRotationSpeed; //Field offset: 0x58
	private float delay; //Field offset: 0x5C
	private bool set; //Field offset: 0x60

	public BoardAnimation() { }

	private IEnumerator BoardFloating() { }

	private void Init(Transform transform) { }

	private void Start() { }

}

