using Info;
using UnityEngine;

namespace UI.Screens;

public class FriendsFooter : MonoBehaviour
{
	private UILabel _menuLabel;

	private UILabel _friendsLabel;

	private UILabel _leaderboardLabel;

	private UILabel _toprunLabel;

	private GameObject _collectButton;

	private void Awake()
	{
		string text = Strings.Get(StringID.FRIENDS_FOOTER_MENU);
		_menuLabel.text = text;
		string text2 = Strings.Get(StringID.FRIENDS_FOOTER_COLLECT);
		_friendsLabel.text = text2;
		string text3 = Strings.Get(StringID.FRIENDS_FOOTER_LEADERBOARD);
		_leaderboardLabel.text = text3;
		string text4 = Strings.Get(StringID.FRIENDS_FOOTER_TOPRUN);
		_toprunLabel.text = text4;
		bool isRestricted = AgeRestriction.isRestricted;
		bool active = (byte)((isRestricted ? 1u : 0u) ^ 1u) != 0;
		_collectButton.SetActive(active);
	}
}
