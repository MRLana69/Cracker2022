using Info;
using UI.Screens;
using UnityEngine;

namespace UI;

public class FacebookRewardsButton : MonoBehaviour
{
	public UpgradeScreen upgradeScreen;

	private GameObject activeContent;

	private GameObject connectingContent;

	private UIAnchor contentAnchor;

	private UILabel titleLabel;

	private UILabel priceLabel;

	private BundleContentSlot coinsSlot;

	private BundleContentSlot hoverboardsSlot;

	private BundleContentSlot keysSlot;

	private BundleContentSlot headstartSlot;

	private BundleContentSlot characterSlot;

	private void OnEnable()
	{
		if (FacebookRewardsInfo.HasReceivedAllAvailableRewards())
		{
			GameObject obj = gameObject;
			Object.Destroy(obj);
		}
		else
		{
			InitializeButton();
			GoToActiveState();
		}
	}

	private unsafe void InitializeButton()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected I4, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected I4, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected I4, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected I4, but got Unknown
		//IL_01e9: Expected VT, but got I4
		//IL_0205: Expected VT, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		string text = Strings.Get(StringID.FACEBOOK_REWARDS_BUTTON_TITLE);
		titleLabel.text = text;
		string text2 = Strings.Get(StringID.FACEBOOK_REWARDS_BUTTON_LOG_IN);
		priceLabel.text = text2;
		int num = FacebookRewardsInfo.facebookRewardPack.get_Item(FacebookRewardsInfo.FacebookRewardType.Coins);
		int num2 = obj + 12;
		string text3 = ((int*)num2)->ToString();
		string amount = string.Empty + text3;
		coinsSlot.UpdateAmount(amount);
		int num3 = FacebookRewardsInfo.facebookRewardPack.get_Item(FacebookRewardsInfo.FacebookRewardType.Hoverboards);
		int num4 = obj + 12;
		string text4 = ((int*)num4)->ToString();
		string amount2 = string.Empty + text4;
		hoverboardsSlot.UpdateAmount(amount2);
		int num5 = FacebookRewardsInfo.facebookRewardPack.get_Item(FacebookRewardsInfo.FacebookRewardType.Keys);
		int num6 = obj + 12;
		string text5 = ((int*)num6)->ToString();
		string amount3 = string.Empty + text5;
		keysSlot.UpdateAmount(amount3);
		int num7 = FacebookRewardsInfo.facebookRewardPack.get_Item(FacebookRewardsInfo.FacebookRewardType.Headstarts);
		int num8 = obj + 12;
		string text6 = ((int*)num8)->ToString();
		string amount4 = string.Empty + text6;
		headstartSlot.UpdateAmount(amount4);
		characterSlot.UpdateAmount("1");
		PlayerInfo instance = PlayerInfo.Instance;
		UIAnchor uIAnchor = contentAnchor;
		_ = -1073741824;
		Vector2 pixelOffset = (Vector2)1107820544;
		if (!instance._hasPayedOutFacebook)
		{
			pixelOffset = (Vector2)1115684864;
		}
		uIAnchor.pixelOffset = pixelOffset;
		GameObject gameObject = coinsSlot.gameObject;
		bool active = (byte)(~(instance._hasPayedOutFacebook ? 1u : 0u)) != 0;
		gameObject.SetActive(active);
	}

	private void OnClick()
	{
		GoToConnectingState();
	}

	public void GoToActiveState()
	{
		activeContent.SetActive(value: true);
		connectingContent.SetActive(value: false);
		BoxCollider component = GetComponent<BoxCollider>();
		component.enabled = true;
	}

	public void GoToConnectingState()
	{
		activeContent.SetActive(value: false);
		connectingContent.SetActive(value: true);
		BoxCollider component = GetComponent<BoxCollider>();
		component.enabled = false;
	}
}
