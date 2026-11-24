//Type is in global namespace

public class CharacterPopup : UIScreen
{
	private sealed class <AnimateCharacterModelCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CharacterPopup <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 82
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateCharacterModelCoroutine>d__9(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private CharacterModel _characterModel; //Field offset: 0x28
	private CharacterModel _secondaryCharacterModel; //Field offset: 0x2C
	protected UIModelController uimodelController; //Field offset: 0x30
	private bool _characterHidden; //Field offset: 0x34

	public CharacterPopup() { }

	private IEnumerator AnimateCharacterModelCoroutine() { }

	public override void Hide() { }

	public void HideCharacter() { }

	public override void Init() { }

	protected virtual void OnDisable() { }

	protected void SetCharacter(CharacterId character, Nullable<Vector2> offsetFromAnchor = null, Nullable<Vector3> rotationOffset = null, float scale = 19, bool posing = false, AnimationClip pose = null, bool useSpecialAsset = true) { }

	public void ShowCharacter() { }

}

