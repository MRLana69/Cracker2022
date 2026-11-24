namespace UI.Generic;

public class ButtonText : MonoBehaviour
{
	private UILabel _label; //Field offset: 0xC
	private Collider _collider; //Field offset: 0x10
	private Color _activeColor; //Field offset: 0x14
	private Color _activeEffectColor; //Field offset: 0x24
	private Color _inactiveColor; //Field offset: 0x34
	private Color _inactiveEffectColor; //Field offset: 0x44

	public ButtonText() { }

	public void Refresh() { }

	private void TakeActiveColorFromWidget() { }

}

