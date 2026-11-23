using UnityEngine;
using UnityEngine.UI;

public class ButtonStyle : MonoBehaviour
{
	public Sprite active;

	public Sprite unactive;

	public Button button;

	public void SetUp(bool _active)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		Image image = button.image;
		object obj = 12;
		if (!_active)
		{
			obj = 16;
		}
		object sprite = (object)this + obj;
		image.sprite = (Sprite)sprite;
	}
}
