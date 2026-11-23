using Cpp2ILInjected;
using UnityEngine;

public class UISlideInBundlesPack : UISlideIn
{
	private UILabel _packNameLabel;

	private UISprite _iconPack;

	public void SetupSlideInOffer(string sum)
	{
		//IL_015a: Expected I, but got Obj
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		StringID key;
		object spriteName;
		if (sum.Equals("pack1"))
		{
			key = StringID.INAPP_DATA_BUNDLE_TIER_ONE;
			spriteName = "icon_pack1";
		}
		else if (sum.Equals("pack2"))
		{
			key = StringID.INAPP_DATA_BUNDLE_TIER_TWO;
			spriteName = "icon_pack2";
		}
		else if (sum.Equals("pack3"))
		{
			key = StringID.INAPP_DATA_BUNDLE_TIER_THREE;
			spriteName = "icon_pack3";
		}
		else if (sum.Equals("pack4"))
		{
			key = StringID.INAPP_DATA_BUNDLE_TIER_FOUR;
			spriteName = "icon_pack4";
		}
		else
		{
			if (!sum.Equals("pack5"))
			{
				goto IL_0138;
			}
			key = StringID.INAPP_DATA_BUNDLE_TIER_FIVE;
			spriteName = "icon_pack5";
		}
		string text = Strings.Get(key);
		_packNameLabel.text = text;
		_iconPack.spriteName = (string)spriteName;
		goto IL_0138;
		IL_0138:
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		nint num = (nint)this;
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S2_v9 (Il2CppClass<UISlideInBundlesPack>)+E4] (should have been resolved before IL gen)");
	}
}
