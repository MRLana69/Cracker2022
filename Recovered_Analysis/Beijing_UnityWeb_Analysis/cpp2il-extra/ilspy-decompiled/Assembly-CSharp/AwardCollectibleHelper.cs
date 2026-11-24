using System;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class AwardCollectibleHelper : MonoBehaviour
{
	private UISprite _itemIconSprite;

	private GameObject _completeIcon;

	private GameObject _glitterOverlay;

	private UISprite _background;

	private GameObject _socialLockOverlay;

	private GameObject _glowElement;

	private const string GLOW_LOOP_ANIMATION = "MainCanGlow";

	private const string GLOW_SHORT_ANIMATION = "MainCanGlowShort";

	private static readonly Color32 SOCIAL_LOCK_CAN_COLOR;

	public void SetupAwardCollectible(string backgroundToUse, string itemIconName, bool useGlitter, bool isItemCollected = false, bool animateStars = false)
	{
		//IL_001b: Expected Obj, but got I4
		((AScreenCapture)(object)this)._002Ector(backgroundToUse, useGlitter ? 1 : 0, isItemCollected ? 1 : 0, (Camera)animateStars, 8);
		((AScreenCapture)(object)this).Screenshot((Camera)(object)itemIconName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public void AddSocialLockCanOverlay(bool socialLock)
	{
		//IL_002a: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = (Delegate)(nint)((UnityEngine.Object)this).m_CachedPtr;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)socialLock);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 8;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public void ActivateCanGlow(bool active)
	{
		//IL_000f: Expected Obj, but got I4
		_socialLockOverlay.tag = (string)active;
	}

	public void ChangeCanColorForSocialLock(bool socialLock)
	{
		//IL_003b: Expected Obj, but got I4
		_glowElement.tag = (string)socialLock;
		if (socialLock)
		{
			Animation component = _glowElement.GetComponent<Animation>();
			AnimationState animationState = component.CrossFadeQueued("MainCanGlow");
		}
	}

	public AwardCollectibleHelper()
	{
		((UpgradeScreen)this).Start();
	}

	static AwardCollectibleHelper()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0067: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		obj = 0;
		obj = -1;
		_ = -1;
		_ = -1;
		_ = 0;
		obj2 = obj;
		object obj3 = obj2 + 8;
		obj3 = obj2;
		TopRunPlayerCell.EFFECT_INITIAL_COLOR = (Color32)obj3;
	}
}
