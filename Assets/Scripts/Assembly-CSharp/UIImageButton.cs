using Cpp2ILInjected;
using UnityEngine;

public class UIImageButton : MonoBehaviour
{
	public UISprite target;

	public string normalSprite;

	public string hoverSprite;

	public string pressedSprite;

	public string disabledSprite;

	public bool pixelSnap = true;

	public bool isEnabled
	{
		get
		{
			GameObject gameObject = base.gameObject;
			Collider component = gameObject.GetComponent<Collider>();
			if ((bool)component)
			{
				return component.enabled;
			}
			return false;
		}
		set
		{
			GameObject gameObject = base.gameObject;
			Collider component = gameObject.GetComponent<Collider>();
			if ((bool)component)
			{
				bool flag = component.enabled;
				if (flag != value)
				{
					component.enabled = value;
					UpdateImage();
				}
			}
		}
	}

	private void OnEnable()
	{
		if (target == null)
		{
			UISprite componentInChildren = GetComponentInChildren<UISprite>();
			target = componentInChildren;
		}
		UpdateImage();
	}

	private void OnValidate()
	{
		//IL_0053: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		if (!(target != null))
		{
			return;
		}
		string text = normalSprite;
		object obj;
		if (normalSprite != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_0178;
			}
		}
		obj = 1;
		goto IL_0178;
		IL_0195:
		object obj2;
		if (obj2 != null)
		{
			UISprite uISprite = target;
			hoverSprite = uISprite.mSpriteName;
		}
		string text2 = pressedSprite;
		object obj3;
		if (pressedSprite != null)
		{
			obj3 = 0;
			if (text2._stringLength != 0)
			{
				goto IL_01b2;
			}
		}
		obj3 = 1;
		goto IL_01b2;
		IL_01cf:
		object obj4;
		if (obj4 != null)
		{
			UISprite uISprite2 = target;
			disabledSprite = uISprite2.mSpriteName;
		}
		return;
		IL_01b2:
		if (obj3 != null)
		{
			UISprite uISprite3 = target;
			pressedSprite = uISprite3.mSpriteName;
		}
		string text3 = disabledSprite;
		if (disabledSprite != null)
		{
			obj4 = 0;
			if (text3._stringLength != 0)
			{
				goto IL_01cf;
			}
		}
		obj4 = 1;
		goto IL_01cf;
		IL_0178:
		if (obj != null)
		{
			UISprite uISprite4 = target;
			normalSprite = uISprite4.mSpriteName;
		}
		string text4 = hoverSprite;
		if (hoverSprite != null)
		{
			obj2 = 0;
			if (text4._stringLength != 0)
			{
				goto IL_0195;
			}
		}
		obj2 = 1;
		goto IL_0195;
	}

	private void UpdateImage()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		if (!(target != null))
		{
			return;
		}
		object sprite;
		if (isEnabled)
		{
			GameObject go = gameObject;
			sprite = this + 20;
			object obj = this + 16;
			if (!UICamera.IsHighlighted(go))
			{
				sprite = obj;
			}
		}
		else
		{
			sprite = this + 28;
		}
		SetSprite((string)sprite);
	}

	private void OnHover(bool isOver)
	{
		//IL_003c: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		if (isEnabled && target != null)
		{
			object obj = 20;
			if (!isOver)
			{
				obj = 16;
			}
			object sprite = (object)this + obj;
			SetSprite((string)sprite);
		}
	}

	private void OnPress(bool pressed)
	{
		if (pressed)
		{
			SetSprite(pressedSprite);
		}
		else
		{
			UpdateImage();
		}
	}

	private void SetSprite(string sprite)
	{
		//IL_007c: Expected I, but got Obj
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		UISprite uISprite = target;
		if (!(uISprite.mAtlas != null))
		{
			return;
		}
		UISprite uISprite2 = target;
		UISpriteData sprite2 = uISprite2.mAtlas.GetSprite(sprite);
		if (sprite2 != null)
		{
			target.spriteName = sprite;
			if (~(pixelSnap ? 1u : 0u) == 0)
			{
				UISprite uISprite3 = target;
				nint num = (nint)uISprite3;
				object obj = uISprite3 + 296;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S1_v7 (Il2CppClass<UISprite>)+1E4] (should have been resolved before IL gen)");
			}
		}
	}
}
