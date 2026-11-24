namespace UI.Helpers;

public class FirstPurchaseBonusStoreHelper : MonoBehaviour
{
	private float FIRST_PURCHASE_BONUS_STATIC_OBJECTS_HEIGHT; //Field offset: 0xC
	private float FIRST_PURCHASE_BONUS_TOP_STATIC_OBJECTS_HEIGHT; //Field offset: 0x10
	private ScrollViewHeightResizer _scrollViewHeightResizer; //Field offset: 0x14
	private float _staticObjectsHeightStartValue; //Field offset: 0x18
	private float _topStaticObjectsHeightStartValue; //Field offset: 0x1C
	private bool _hasSetiPhoneXOffsetsIfNecessary; //Field offset: 0x20

	public FirstPurchaseBonusStoreHelper() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void OnFirstPurchaseBonusBecameInactive() { }

	private void ResetProperties() { }

	private void SetPropertiesNeededForFirstPurchaseBonus() { }

}

