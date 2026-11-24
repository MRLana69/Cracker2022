//Type is in global namespace

public class CharacterLetterPickup : LetterPickup
{
	private sealed class <RewardCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CharacterLetterPickup <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 79
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RewardCoroutine>d__14(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}


	private bool HasDailyLetter
	{
		 get { } //Length: 6
	}

	public char Letter
	{
		 set { } //Length: 167
	}

	public CharacterLetterPickup() { }

	private void CharacterNameEventManager_OnLetterCollected(object sender, LetterCollectedEventArgs letterCollectedEventArgs) { }

	private void DeactivatePickupIfEventHasCompleted() { }

	private bool get_HasDailyLetter() { }

	private Nullable<char> GetNextCharacterLetterToSpawn() { }

	public static bool IsCharacterLetterPickupSpawnable() { }

	public static bool IsCharacterNameEventActive() { }

	protected override void OnActivate() { }

	protected override void OnDeactivate() { }

	private void ReportLetterWasPickedup() { }

	public void Reward() { }

	private IEnumerator RewardCoroutine() { }

	public void set_Letter(char value) { }

	private void SSEventsManagerController_OnSSEventChangedHandler() { }

}

