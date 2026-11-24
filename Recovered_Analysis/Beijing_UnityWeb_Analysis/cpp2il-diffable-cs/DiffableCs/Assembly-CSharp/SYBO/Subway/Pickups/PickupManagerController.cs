namespace SYBO.Subway.Pickups;

public class PickupManagerController
{
	private sealed class <RewardDailyLetterCoroutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 209
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RewardDailyLetterCoroutine>d__16(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private PickupManager _pickupManager; //Field offset: 0x8
	private List<Action> _refreshEventSpecificPickupsFunctions; //Field offset: 0xC

	public PickupManagerController(PickupManager pickupManager) { }

	private void AddAnyEventSpecificPickers() { }

	public void Destroy() { }

	private bool IsCharacterLetterPickupSpawnable() { }

	private bool IsCharacterNameEventActive() { }

	private void PickupManager_OnPickerRemoved(PickerRemoveRequestEventArgs pickerRemoveEvent) { }

	private void PickupManager_OnPickupCollected(object sender, PickupEventArgs args) { }

	private void RefreshEventSpecificPickups() { }

	private void RefreshEventSpecificPickups_LetterHuntCharacter() { }

	private void RefreshEventSpecificPickups_LetterHuntDaily() { }

	private void RefreshEventSpecificPickups_MysteryPowerup() { }

	private void RefreshEventSpecificPickups_SuperMysteryBox() { }

	private void RefreshEventSpecificPickups_TokenHunt() { }

	public static IEnumerator RewardDailyLetterCoroutine() { }

	private void SetupEventSpecificPickups() { }

	public void Update() { }

}

