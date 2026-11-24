namespace SYBO.Subway.StateSystem.States;

public class DeathState : State
{
	private sealed class <DelayGameOverScreen>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 197
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayGameOverScreen>d__8(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const float WaitTimeBeforeSkip = 0.5; //Field offset: 0x0
	private const float WaitTimeBeforeScreen = 3; //Field offset: 0x0
	private float _currentWaitTime; //Field offset: 0xC
	private bool _hasShownSaveMePopup; //Field offset: 0x10

	public DeathState(int id) { }

	private IEnumerator DelayGameOverScreen() { }

	public override void Enter(State fromState) { }

	public override void OnUpdate() { }

	private void ReturnToTopMenu() { }

}

