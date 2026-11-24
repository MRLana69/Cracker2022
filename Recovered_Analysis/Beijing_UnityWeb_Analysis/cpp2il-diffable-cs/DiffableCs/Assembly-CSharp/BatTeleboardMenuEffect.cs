//Type is in global namespace

public class BatTeleboardMenuEffect : ATeleboardMenuEffect
{
	private sealed class <DelayEndPoof>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public BatTeleboardMenuEffect <>4__this; //Field offset: 0x10
		public CharacterModel characterModel; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 159
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayEndPoof>d__15(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private EffectPlayer _poof1; //Field offset: 0x14
	private EffectPlayer _poof2; //Field offset: 0x18
	private bool _lastWas1; //Field offset: 0x1C
	private Renderer[] _cachedRenderers; //Field offset: 0x20
	private float _reappearDelay; //Field offset: 0x24
	private float _offsetDistance; //Field offset: 0x28
	private float _scale; //Field offset: 0x2C
	private Camera _camera; //Field offset: 0x30

	public BatTeleboardMenuEffect() { }

	private IEnumerator DelayEndPoof(float duration, CharacterModel characterModel) { }

	public override void EndTeleboardEffect(float duration, CharacterModel characterModel) { }

	public override void Initialize(Transform root, bool boardOnly = false) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void SetRenderersActive(CharacterModel characterModel, bool state) { }

	public override void StartTeleboardEffect(float duration, CharacterModel characterModel) { }

	private void UpdatePoofs(CharacterModel characterModel) { }

}

