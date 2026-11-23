using UnityEngine;

namespace Debugging;

public class CharacterIgnoreObstaclesButton : MonoBehaviour
{
	private UILabel _titleLabel;

	private int _characterLayer;

	private int _hitLayer;

	private void OnEnable()
	{
		int characterLayer = LayerMask.NameToLayer("Character");
		_characterLayer = characterLayer;
		bool ignoreLayerCollision = Physics.GetIgnoreLayerCollision(_hitLayer = LayerMask.NameToLayer("Hit"), _characterLayer);
		SetupButton(ignoreLayerCollision);
	}

	public void Click()
	{
		bool ignoreLayerCollision = Physics.GetIgnoreLayerCollision(_hitLayer, _characterLayer);
		bool ignore = (byte)((ignoreLayerCollision ? 1u : 0u) ^ 1u) != 0;
		Physics.IgnoreLayerCollision(_hitLayer, _characterLayer, ignore);
		SetupButton(ignore);
	}

	private void SetupButton(bool enabled)
	{
		object text = "Ignore Obstacles: ON";
		if (!enabled)
		{
			text = "Ignore Obstacles: OFF";
		}
		_titleLabel.text = (string)text;
	}
}
