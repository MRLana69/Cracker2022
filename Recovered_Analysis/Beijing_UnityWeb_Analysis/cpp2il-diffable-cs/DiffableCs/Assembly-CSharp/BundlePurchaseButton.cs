//Type is in global namespace

public class BundlePurchaseButton : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<BundleItem> <>9__24_0; //Field offset: 0x4
		public static Predicate<BundleItem> <>9__24_1; //Field offset: 0x8
		public static Predicate<BundleItem> <>9__24_2; //Field offset: 0xC
		public static Predicate<BundleItem> <>9__24_3; //Field offset: 0x10
		public static Predicate<BundleItem> <>9__24_4; //Field offset: 0x14

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateButton>b__24_0(BundleItem x) { }

		internal bool <UpdateButton>b__24_1(BundleItem x) { }

		internal bool <UpdateButton>b__24_2(BundleItem x) { }

		internal bool <UpdateButton>b__24_3(BundleItem x) { }

		internal bool <UpdateButton>b__24_4(BundleItem x) { }

	}

	private GameObject activeButtonContents; //Field offset: 0xC
	private GameObject inactiveButtonContents; //Field offset: 0x10
	private UILabel titleLabel; //Field offset: 0x14
	private UILabel priceLabel; //Field offset: 0x18
	private UISprite bundle1Icon; //Field offset: 0x1C
	private UISprite bundle2Icon; //Field offset: 0x20
	private UISprite bundle3Icon; //Field offset: 0x24
	private UISprite bundle4Icon; //Field offset: 0x28
	private UISprite bundle5Icon; //Field offset: 0x2C
	private BundleContentSlot coinsSlot; //Field offset: 0x30
	private BundleContentSlot hoverboardsSlot; //Field offset: 0x34
	private BundleContentSlot keysSlot; //Field offset: 0x38
	private BundleContentSlot headstartSlot; //Field offset: 0x3C
	private BundleContentSlot scoreboosterSlot; //Field offset: 0x40
	private BundleTier _lastPurchasedBundle; //Field offset: 0x44

	public BundlePurchaseButton() { }

	private BundleTier GetBundleToSell() { }

	private string GetFormattedAmount(int amount) { }

	private void InitializeButton() { }

	private void OnClick() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnProductRequestDone() { }

	private void OnPurchaseFailure(string data, PurchaseResult ressult) { }

	private void OnPurchaseSuccess(string productId, bool wasRestored, IPurchaseValidationResult validationResult) { }

	private void ShowActiveContents(bool active) { }

	private void ShowBundleIcon() { }

	private void UpdateButton() { }

	private void UpdatePrice() { }

}

