using UI.Screens;
using UnityEngine;

public class UIPopupIn : MonoBehaviour
{
	public enum TYPE
	{
		IN,
		IN_INGAME,
		IN_FRONT,
		OUT,
		OUT_FRONT,
		OUT_INGAME,
		OUT_IMPORTANT
	}

	private Animator pupUIAnim;

	private TYPE cureentType;

	public void PlayAnim(TYPE type)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			object obj = this + 12;
			if (pupUIAnim == null)
			{
				Animator component = GetComponent<Animator>();
				pupUIAnim = component;
			}
			cureentType = type;
			if (type <= TYPE.OUT_IMPORTANT)
			{
				object obj2 = (int)type << 2;
				object obj3 = obj2 + 2288608;
				object trigger = obj3;
				((Animator)obj).SetTrigger((string)trigger);
			}
		}
	}

	public void InComplete()
	{
		UIScreen componentInParent = GetComponentInParent<UIScreen>();
		if (componentInParent.InComplete != null)
		{
			componentInParent.InComplete.Invoke();
		}
	}

	public void OutCompelete()
	{
		UIScreen componentInParent = GetComponentInParent<UIScreen>();
		if (componentInParent.OutConplete != null)
		{
			componentInParent.OutConplete.Invoke();
		}
	}
}
