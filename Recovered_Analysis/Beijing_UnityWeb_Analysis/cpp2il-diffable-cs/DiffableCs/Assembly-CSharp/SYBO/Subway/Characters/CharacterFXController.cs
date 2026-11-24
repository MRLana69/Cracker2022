namespace SYBO.Subway.Characters;

public class CharacterFXController : MonoBehaviour
{
	private sealed class <DespawnCollisionEffect>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float delay; //Field offset: 0x10
		public bool despawnOnDeath; //Field offset: 0x14
		public CharacterFXController <>4__this; //Field offset: 0x18
		public bool activeDuringHoverboard; //Field offset: 0x1C
		public Transform instance; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 314
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DespawnCollisionEffect>d__17(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DespawnGrindEffect>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CharacterFXController <>4__this; //Field offset: 0x10
		public Character character; //Field offset: 0x14
		public Transform instance; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 181
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DespawnGrindEffect>d__24(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DespawnJumpRollEffect>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Character character; //Field offset: 0x10
		public CharacterFXController <>4__this; //Field offset: 0x14
		public Transform instance; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 327
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DespawnJumpRollEffect>d__21(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private Transform _dizzyStarsPrefab; //Field offset: 0xC
	private float _starHeightOffset; //Field offset: 0x10
	private float _dizzyDuration; //Field offset: 0x14
	private Transform _bushLeavesPrefab; //Field offset: 0x18
	private float _leavesDuration; //Field offset: 0x1C
	private Transform _jumpRollPrefab; //Field offset: 0x20
	private float _jmupRollDespawnAddedDelay; //Field offset: 0x24
	private Transform _grindSparkPrefab; //Field offset: 0x28
	private Game _game; //Field offset: 0x2C
	private Hoverboard _hoverboard; //Field offset: 0x30
	private bool _dizzyStarsHeightOffsetSet; //Field offset: 0x34
	private Transform _dizzyStarsInstance; //Field offset: 0x38
	private IEnumerator _dizzyStarsDespawn; //Field offset: 0x3C

	public CharacterFXController() { }

	private void Awake() { }

	private void Character_OnCriticalHit(CriticalHitType type) { }

	private void Character_OnLanding(Character character) { }

	private void Character_OnStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble) { }

	private IEnumerator DespawnCollisionEffect(Transform instance, float delay, bool activeDuringHoverboard = false, bool despawnOnDeath = false) { }

	private IEnumerator DespawnGrindEffect(Transform instance, Character character) { }

	private IEnumerator DespawnJumpRollEffect(Transform instance, Character character) { }

	private void HandleBushStumble() { }

	private void HandleGrind(Character character) { }

	private void HandleJumpRoll(Character character) { }

	private void HandleSideStumble() { }

	private bool InGrind(Character character) { }

}

