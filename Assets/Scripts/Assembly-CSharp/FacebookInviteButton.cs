using System;
using UnityEngine;

public class FacebookInviteButton : MonoBehaviour
{
	private void OnClick()
	{
		SocialManager instance = SocialManager.instance;
		bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
		SocialManager instance2 = SocialManager.instance;
		if (facebookIsLoggedIn)
		{
			instance2.RecommendAppFacebook();
			return;
		}
		UIScreenController instance3 = UIScreenController.Instance;
		throw new ArgumentException();
	}
}
