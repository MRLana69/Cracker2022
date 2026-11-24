namespace UI;

public class DoubleCoinUpgradeHelper : DiscountButton
{
	private Vector3 _shownDiscStickerPos; //Field offset: 0x164
	private Vector3 _shownDiscLabelPos; //Field offset: 0x170
	private Vector3 _shownDiscLabelSingleLinePos; //Field offset: 0x17C
	private string doubleCoinVersion; //Field offset: 0x188
	private bool _inited; //Field offset: 0x18C

	public bool OnSale
	{
		 get { } //Length: 3
	}

	private void _DefaultSetup(string data, bool wasRestored, IPurchaseValidationResult validationResult) { }

	private void _Setup(bool forceEndDiscount = false) { }

	public DoubleCoinUpgradeHelper() { }

	private void DisableDiscount() { }

	private void EnableDiscount() { }

	private void ForceEndDiscount() { }

	public bool get_OnSale() { }

	public void Init() { }

	public static void Log(string msg, Object context = null) { }

	public static void LogError(string msg, Object context = null) { }

	public static void LogWarning(string msg, Object context = null) { }

	private void OnClick() { }

	private void OnDisable() { }

	private void OnEnable() { }

	protected override void ShowNoDiscount(string productString, string backupDescription = "") { }

	protected override void ShowOnPromotion(string productString, string sendDescription, string sendDescription2) { }

	protected override void ShowOnSale(string productString, string sendDescription = "") { }

	private void UpdatePrice() { }

}

