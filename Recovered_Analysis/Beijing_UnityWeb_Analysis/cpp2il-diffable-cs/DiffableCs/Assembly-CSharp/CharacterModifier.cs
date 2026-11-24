//Type is in global namespace

public abstract class CharacterModifier : MonoBehaviour
{
	private sealed class <Begin>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 19
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Begin>d__16(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum StopSignal
	{
		DONT_STOP = 0,
		STOP = 1,
		STOP_NO_ENDING = 2,
	}

	protected StopSignal stop; //Field offset: 0xC
	private bool _paused; //Field offset: 0x10
	public ActivePowerup _powerup; //Field offset: 0x14
	private bool <TriggeredByMysteryPowerup>k__BackingField; //Field offset: 0x18
	private IEnumerator current; //Field offset: 0x1C

	public IEnumerator Current
	{
		 get { } //Length: 12
		 set { } //Length: 8
	}

	public bool IsAllowedInAlternateRoutes
	{
		 get { } //Length: 3
	}

	public bool Paused
	{
		 get { } //Length: 6
		protected set { } //Length: 111
	}

	public ActivePowerup Powerup
	{
		 get { } //Length: 9
		protected set { } //Length: 11
	}

	public virtual bool ShouldPauseInAlternateRoutes
	{
		 get { } //Length: 3
	}

	public virtual bool ShouldPauseInJetpack
	{
		 get { } //Length: 6
	}

	public StopSignal Stop
	{
		 get { } //Length: 56
		 set { } //Length: 11
	}

	public bool TriggeredByMysteryPowerup
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	protected CharacterModifier() { }

	public virtual IEnumerator Begin() { }

	public virtual void ExpireSoon() { }

	public IEnumerator get_Current() { }

	public bool get_IsAllowedInAlternateRoutes() { }

	public bool get_Paused() { }

	public ActivePowerup get_Powerup() { }

	public virtual bool get_ShouldPauseInAlternateRoutes() { }

	public virtual bool get_ShouldPauseInJetpack() { }

	public StopSignal get_Stop() { }

	public bool get_TriggeredByMysteryPowerup() { }

	public virtual void Pause() { }

	public virtual void Prepare() { }

	public virtual void Reset() { }

	public virtual void Resume() { }

	public void set_Current(IEnumerator value) { }

	protected void set_Paused(bool value) { }

	protected void set_Powerup(ActivePowerup value) { }

	public void set_Stop(StopSignal value) { }

	public void set_TriggeredByMysteryPowerup(bool value) { }

}

