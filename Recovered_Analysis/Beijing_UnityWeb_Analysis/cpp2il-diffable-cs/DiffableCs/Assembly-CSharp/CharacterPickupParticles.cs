//Type is in global namespace

public class CharacterPickupParticles : MonoBehaviour
{
	private sealed class <>c__DisplayClass18_0
	{
		public EffectDetails details; //Field offset: 0x8
		public Material material; //Field offset: 0xC

		public <>c__DisplayClass18_0() { }

		internal void <EffectCoroutine>b__0(float t) { }

	}

	private sealed class <EffectCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public EffectDetails details; //Field offset: 0x10
		public CharacterPickupParticles <>4__this; //Field offset: 0x14
		private <>c__DisplayClass18_0 <>8__1; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 327
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <EffectCoroutine>d__18(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class EffectDetails
	{
		public Transform target; //Field offset: 0x8
		public float duration; //Field offset: 0xC
		public AnimationCurve scaleCurve; //Field offset: 0x10
		private Renderer _renderer; //Field offset: 0x14
		private Material _materialInstance; //Field offset: 0x18

		public Material MaterialInstance
		{
			 get { } //Length: 200
		}

		public Renderer Renderer
		{
			 get { } //Length: 6
		}

		public EffectDetails() { }

		public Material get_MaterialInstance() { }

		public Renderer get_Renderer() { }

	}

	public static Vector3 coinEfxOffset; //Field offset: 0x0
	public GameObject CoinEFX; //Field offset: 0xC
	public GameObject PowerUpEFX; //Field offset: 0x10
	public Transform master; //Field offset: 0x14
	public AudioClipInfo CoinPickup; //Field offset: 0x18
	public AudioClipInfo PowerUpPickup; //Field offset: 0x1C
	public float CoinDistanceForStairway; //Field offset: 0x20
	private int coinStairway; //Field offset: 0x24
	private int flyWay; //Field offset: 0x28
	private int[] pentatonicScale; //Field offset: 0x2C
	public AnimationCurve compressCurve; //Field offset: 0x30
	private EffectDetails coinEffect; //Field offset: 0x34
	private EffectDetails powerupEffect; //Field offset: 0x38
	private HuntTokenCollectVFXManager huntTokenCollectVFXManager; //Field offset: 0x3C

	private static CharacterPickupParticles() { }

	public CharacterPickupParticles() { }

	private IEnumerator EffectCoroutine(EffectDetails details) { }

	private void OnJetpackStop() { }

	public void PickedUpCoin(Transform trans) { }

	public void PickedUpDefaultPowerUp() { }

	public void PickedUpHuntToken() { }

	public void PickedUpPowerUp() { }

	private void Start() { }

}

