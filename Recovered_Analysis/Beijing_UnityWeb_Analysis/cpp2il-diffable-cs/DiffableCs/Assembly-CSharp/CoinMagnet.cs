//Type is in global namespace

public class CoinMagnet : CharacterModifier
{
	private sealed class <Begin>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CoinMagnet <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 511
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

	private static CoinMagnet instance; //Field offset: 0x0
	private bool isActive; //Field offset: 0x20
	public float pullSpeed; //Field offset: 0x24
	private Character character; //Field offset: 0x28
	private CollisionNotifier coinMagnetCollider; //Field offset: 0x2C
	private CharacterRendering characterRendering; //Field offset: 0x30
	private Transform coinEFX; //Field offset: 0x34
	private Game game; //Field offset: 0x38
	public AudioClipInfo powerDownSound; //Field offset: 0x3C

	public static CoinMagnet Instance
	{
		 get { } //Length: 306
	}

	public bool IsActive
	{
		 get { } //Length: 6
	}

	private static CoinMagnet() { }

	public CoinMagnet() { }

	public void Awake() { }

	public override IEnumerator Begin() { }

	public void CoinHit(Collider collider) { }

	private void Game_OnCharacterModelRecreated() { }

	public static CoinMagnet get_Instance() { }

	public bool get_IsActive() { }

	public void Initialize() { }

	private void OnDestroy() { }

	public override void Reset() { }

	private void SetUpHoldAnimation() { }

	private void StopCoinMagnet() { }

	public void Update() { }

}

