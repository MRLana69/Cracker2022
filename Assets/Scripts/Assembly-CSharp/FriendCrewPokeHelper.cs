using UnityEngine;

public class FriendCrewPokeHelper : MonoBehaviour
{
	private UISprite pokeIcon;

	private BoxCollider pokeCollider;

	private Friend _friend;

	public void ActivatePoke(Friend friend)
	{
		_friend = friend;
		pokeCollider.enabled = true;
		pokeIcon.enabled = true;
	}

	public void DeactivatePoke()
	{
		pokeCollider.enabled = false;
		pokeIcon.enabled = false;
	}

	private void OnClick()
	{
		DeactivatePoke();
		PlayerInfo instance = PlayerInfo.Instance;
		Statistics stats = instance._stats;
		int[] values = stats._values;
		int value = values[26] + 1;
		stats.set_Item(Stat.PokeFriend, value);
		SocialManager instance2 = SocialManager.instance;
		instance2.Poke(_friend, SocialManager.PokeType.Poke);
	}
}
