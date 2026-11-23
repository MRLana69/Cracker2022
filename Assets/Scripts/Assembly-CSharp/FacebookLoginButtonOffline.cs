using UnityEngine;

public class FacebookLoginButtonOffline : MonoBehaviour
{
	private void OnClick()
	{
		SocialManager instance = SocialManager.instance;
		if (instance.FacebookLogin(null))
		{
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.FacebookLogIn(loggedIn: true);
		}
	}
}
