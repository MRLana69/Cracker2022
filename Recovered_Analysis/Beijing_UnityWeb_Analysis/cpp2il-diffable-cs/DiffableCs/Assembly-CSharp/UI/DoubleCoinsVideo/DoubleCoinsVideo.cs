namespace UI.DoubleCoinsVideo;

public abstract class DoubleCoinsVideo : MonoBehaviour
{
	public static Action<CelebrationReward> onDoubleCoinsReceived; //Field offset: 0x0
	private const string DOUBLE_COINS_VIDEO_PAYOUT_CAP_KEY = "DoubleCoinsVideoPayoutCap"; //Field offset: 0x0
	private const int DEFAULT_CAP = 3000; //Field offset: 0x0
	protected DoubleCoinsVideoPayload _payload; //Field offset: 0xC
	protected int _amount; //Field offset: 0x10

	public static int payoutCap
	{
		 get { } //Length: 22
	}

	protected DoubleCoinsVideo() { }

	private void <WatchVideo>b__6_0() { }

	public static int get_payoutCap() { }

	public abstract int GetHeight() { }

	public virtual void SetCoinVisualValue(int coinValue) { }

	public abstract void Setup(DoubleCoinsVideoPayload payload) { }

	protected void WatchVideo() { }

}

