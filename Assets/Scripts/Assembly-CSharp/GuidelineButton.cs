using System;
using Cpp2ILInjected;
using Info;
using UnityEngine;

public class GuidelineButton : MonoBehaviour
{
	public enum GuidelineButtonType
	{
		_notSet,
		hoverboard,
		facebookOrCollect,
		mission1,
		playerMenuIntroduction,
		shopMenuIntroduction
	}

	private enum AnimationState
	{
		NONE,
		SCALING,
		BLINKING,
		WAITING
	}

	private GameObject _breadcrumb;

	private bool _showIcon;

	public bool __forceIcon;

	public GuidelineButtonType guidelineButtonType;

	private bool _hasInited;

	private Vector3 _startScale;

	private Vector3 _maxScale;

	private float SCALE_DURATION;

	private const float SCALE_MAX_SIZE = 2.5f;

	private const float WAIT_DURATION = 2f;

	private const float BLINK_DURATION = 1f;

	private AnimationState animationState;

	private float currentAnimationTime;

	private bool wiggleNow
	{
		get
		{
			return _showIcon;
		}
		set
		{
			//IL_027a: Expected Obj, but got I4
			_showIcon = value;
			object obj = guidelineButtonType - 1;
			if (guidelineButtonType != GuidelineButtonType.hoverboard)
			{
				if ((nint)obj != 1)
				{
					if ((nint)obj == 2)
					{
						PlayerInfo instance = PlayerInfo.Instance;
						if (!instance._shouldShowMission1Popup)
						{
							instance._dirty = true;
							instance._shouldShowMission1Popup = true;
						}
						bool flag = (byte)((value ? 1u : 0u) ^ 1u) != 0;
						PlayerInfo instance2 = PlayerInfo.Instance;
						if (flag != instance2._hasShownMission1Popup)
						{
							instance2._dirty = true;
							instance2._hasShownMission1Popup = flag;
						}
					}
				}
				else
				{
					float value2 = UnityEngine.Random.value;
					PlayerInfo instance3 = PlayerInfo.Instance;
					if (value2 > 0.5f)
					{
						if (!instance3._shouldShowFacebookPopup)
						{
							instance3._dirty = true;
							instance3._shouldShowFacebookPopup = true;
						}
						PlayerInfo instance4 = PlayerInfo.Instance;
						if (~(instance4._hasShownFacebookPopup ? 1u : 0u) == 0)
						{
							instance4._dirty = true;
							instance4._hasShownFacebookPopup = false;
						}
					}
					else
					{
						if (value != instance3._shouldShowCollectPopup)
						{
							instance3._dirty = true;
							instance3._shouldShowCollectPopup = value;
						}
						bool flag2 = (byte)((value ? 1u : 0u) ^ 1u) != 0;
						PlayerInfo instance5 = PlayerInfo.Instance;
						if (flag2 != instance5._hasShownCollectPopup)
						{
							instance5._dirty = true;
							instance5._hasShownCollectPopup = flag2;
						}
					}
				}
			}
			else
			{
				PlayerInfo instance6 = PlayerInfo.Instance;
				if (value != instance6._shouldShowHoverboardPopup)
				{
					instance6._dirty = true;
					instance6._shouldShowHoverboardPopup = value;
				}
				bool flag3 = (byte)((value ? 1u : 0u) ^ 1u) != 0;
				PlayerInfo instance7 = PlayerInfo.Instance;
				if (flag3 != instance7._hasShownHoverboardPopup)
				{
					instance7._dirty = true;
					instance7._hasShownHoverboardPopup = flag3;
				}
			}
			OnEnable();
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
		//IL_005b: Expected VT, but got F4
		//IL_00a9: Expected Obj, but got I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00d9: Expected F4, but got Obj
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			float num = (float)_startScale * 2.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (GuidelineButton)+20]");
			float num2 = 0f * 2.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (GuidelineButton)+24]");
			float num3 = 0f * 2.5f;
			_maxScale = (Vector3)num;
			UIScreenController instance = UIScreenController.Instance;
			Keyframe[] keys = instance.guidelineAnimation.keys;
			UIScreenController instance2 = UIScreenController.Instance;
			int length = instance2.guidelineAnimation.length;
			object obj = length * 28;
			object obj2 = (object)keys + obj;
			object obj3 = obj2 - 12;
			_hasInited = true;
			SCALE_DURATION = (float)obj3;
		}
		bool flag = ShouldInfoIconShow();
		if (flag)
		{
			EnableInfoIcon();
		}
		if (_breadcrumb != null)
		{
			bool active = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			_breadcrumb.SetActive(active);
		}
	}

	private void OnClick()
	{
		//IL_049a: Expected Obj, but got I4
		if (~(_showIcon ? 1u : 0u) == 0)
		{
			animationState = AnimationState.NONE;
			_showIcon = false;
			bool flag = this.guidelineButtonType != GuidelineButtonType.facebookOrCollect;
			GuidelineButtonType guidelineButtonType = this.guidelineButtonType;
			if (!flag)
			{
				PlayerInfo instance = PlayerInfo.Instance;
				if (~(instance._shouldShowCollectPopup ? 1u : 0u) == 0)
				{
					PlayerInfo instance2 = PlayerInfo.Instance;
					instance2._dirty = true;
					instance2._dummyFriendShouldShow = true;
					UIScreenController instance3 = UIScreenController.Instance;
					instance3.PushScreen("FriendsUI");
					UIScreenController instance4 = UIScreenController.Instance;
					instance4.QueuePopup("TutorialCollectFromFriendsPopup");
					PlayerInfo instance5 = PlayerInfo.Instance;
					if (!instance5._hasShownCollectPopup)
					{
						instance5._dirty = true;
						instance5._hasShownCollectPopup = true;
					}
					PlayerInfo instance6 = PlayerInfo.Instance;
					if (~(instance6._shouldShowCollectPopup ? 1u : 0u) == 0)
					{
						instance6._dirty = true;
						instance6._shouldShowCollectPopup = false;
					}
					return;
				}
				bool flag2 = this.guidelineButtonType != GuidelineButtonType.facebookOrCollect;
				guidelineButtonType = this.guidelineButtonType;
				if (!flag2)
				{
					PlayerInfo instance7 = PlayerInfo.Instance;
					if (~(instance7._shouldShowFacebookPopup ? 1u : 0u) == 0 && !AgeRestriction.isRestricted)
					{
						UIScreenController instance8 = UIScreenController.Instance;
						instance8.PushScreen("FriendsUI");
						UIScreenController instance9 = UIScreenController.Instance;
						instance9.QueuePopup("TutorialFacebookPopup");
						PlayerInfo instance10 = PlayerInfo.Instance;
						if (!instance10._hasShownFacebookPopup)
						{
							instance10._dirty = true;
							instance10._hasShownFacebookPopup = true;
						}
						PlayerInfo instance11 = PlayerInfo.Instance;
						if (~(instance11._shouldShowFacebookPopup ? 1u : 0u) == 0)
						{
							instance11._dirty = true;
							instance11._shouldShowFacebookPopup = false;
						}
						return;
					}
					bool flag3 = this.guidelineButtonType != GuidelineButtonType.facebookOrCollect;
					guidelineButtonType = this.guidelineButtonType;
					if (!flag3)
					{
						PlayerInfo instance12 = PlayerInfo.Instance;
						if (instance12._lastShownTopRunIntroPopupVersionNumber != 2)
						{
							UIScreenController instance13 = UIScreenController.Instance;
							instance13.PushScreen("TopRunUI");
							UIScreenController instance14 = UIScreenController.Instance;
							instance14.QueuePopup("TopRunPopup");
							PlayerInfo instance15 = PlayerInfo.Instance;
							if (instance15._lastShownTopRunIntroPopupVersionNumber != 2)
							{
								instance15._dirty = true;
								instance15._lastShownTopRunIntroPopupVersionNumber = 2;
							}
							return;
						}
						guidelineButtonType = this.guidelineButtonType;
					}
				}
			}
			switch (guidelineButtonType)
			{
			case GuidelineButtonType.hoverboard:
			{
				UIScreenController instance19 = UIScreenController.Instance;
				instance19.QueuePopup("TutorialHoverboardsPopup");
				PlayerInfo instance20 = PlayerInfo.Instance;
				if (!instance20._hasShownHoverboardPopup)
				{
					instance20._dirty = true;
					instance20._hasShownHoverboardPopup = true;
				}
				PlayerInfo instance21 = PlayerInfo.Instance;
				if (~(instance21._shouldShowHoverboardPopup ? 1u : 0u) == 0)
				{
					instance21._dirty = true;
					instance21._shouldShowHoverboardPopup = false;
				}
				break;
			}
			case GuidelineButtonType.mission1:
			{
				UIScreenController instance16 = UIScreenController.Instance;
				instance16.QueuePopup("TutorialMissionPopup");
				PlayerInfo instance17 = PlayerInfo.Instance;
				if (!instance17._hasShownMission1Popup)
				{
					instance17._dirty = true;
					instance17._hasShownMission1Popup = true;
				}
				PlayerInfo instance18 = PlayerInfo.Instance;
				if (~(instance18._shouldShowMission1Popup ? 1u : 0u) == 0)
				{
					instance18._dirty = true;
					instance18._shouldShowMission1Popup = false;
				}
				break;
			}
			case GuidelineButtonType._notSet:
			{
				GameObject gameObject = base.gameObject;
				break;
			}
			}
			return;
		}
		object obj = this.guidelineButtonType - 1;
		if (this.guidelineButtonType != GuidelineButtonType.hoverboard)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj == 4)
						{
							UIScreenController instance22 = UIScreenController.Instance;
							instance22.PushScreen(UIScreens.shopMenu_lastScreen);
						}
					}
					else
					{
						UIScreenController instance23 = UIScreenController.Instance;
						instance23.PushScreen(UIScreens.meMenu_lastScreen);
					}
				}
				else
				{
					UIScreenController instance24 = UIScreenController.Instance;
					instance24.QueuePopup("Mission_popup");
				}
			}
			else
			{
				UIScreenController instance25 = UIScreenController.Instance;
				instance25.PushScreen(UIScreens.friendsMenu_lastScreen);
			}
		}
		else
		{
			UIScreenController instance26 = UIScreenController.Instance;
			instance26.QueuePopup("HoverboardPopup");
		}
	}

	public bool ShouldInfoIconShow()
	{
		GuidelineButtonType guidelineButtonType = this.guidelineButtonType;
		if (this.guidelineButtonType == GuidelineButtonType.hoverboard)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			if (~(instance._shouldShowHoverboardPopup ? 1u : 0u) == 0)
			{
				PlayerInfo instance2 = PlayerInfo.Instance;
				if (~(instance2._hasShownHoverboardPopup ? 1u : 0u) != 0)
				{
					goto IL_0332;
				}
			}
			guidelineButtonType = this.guidelineButtonType;
		}
		if (guidelineButtonType == GuidelineButtonType.facebookOrCollect)
		{
			PlayerInfo instance3 = PlayerInfo.Instance;
			if (instance3._lastShownTopRunIntroPopupVersionNumber != 2)
			{
				PlayerInfo instance4 = PlayerInfo.Instance;
				if (~(instance4._isFreshInstall ? 1u : 0u) != 0)
				{
					goto IL_0332;
				}
			}
		}
		bool flag = this.guidelineButtonType != GuidelineButtonType.facebookOrCollect;
		GuidelineButtonType guidelineButtonType2 = this.guidelineButtonType;
		if (!flag)
		{
			PlayerInfo instance5 = PlayerInfo.Instance;
			if (~(instance5._shouldShowFacebookPopup ? 1u : 0u) == 0)
			{
				PlayerInfo instance6 = PlayerInfo.Instance;
				if (!instance6._hasShownFacebookPopup && !AgeRestriction.isRestricted)
				{
					PlayerInfo instance7 = PlayerInfo.Instance;
					return (byte)(~(instance7._shouldShowHoverboardPopup ? 1u : 0u)) != 0;
				}
			}
			bool flag2 = this.guidelineButtonType != GuidelineButtonType.facebookOrCollect;
			guidelineButtonType2 = this.guidelineButtonType;
			if (!flag2)
			{
				PlayerInfo instance8 = PlayerInfo.Instance;
				if (~(instance8._shouldShowCollectPopup ? 1u : 0u) == 0)
				{
					PlayerInfo instance9 = PlayerInfo.Instance;
					if (!instance9._hasShownCollectPopup && !AgeRestriction.isRestricted)
					{
						PlayerInfo instance10 = PlayerInfo.Instance;
						if (!instance10._shouldShowHoverboardPopup)
						{
							PlayerInfo instance11 = PlayerInfo.Instance;
							return (byte)(~(instance11._shouldShowFacebookPopup ? 1u : 0u)) != 0;
						}
						goto IL_03ac;
					}
				}
				guidelineButtonType2 = this.guidelineButtonType;
			}
		}
		if (guidelineButtonType2 == GuidelineButtonType.mission1)
		{
			PlayerInfo instance12 = PlayerInfo.Instance;
			if (~(instance12._shouldShowMission1Popup ? 1u : 0u) == 0)
			{
				PlayerInfo instance13 = PlayerInfo.Instance;
				if (!instance13._hasShownMission1Popup)
				{
					PlayerInfo instance14 = PlayerInfo.Instance;
					if (!instance14._shouldShowHoverboardPopup)
					{
						PlayerInfo instance15 = PlayerInfo.Instance;
						if (!instance15._shouldShowFacebookPopup)
						{
							PlayerInfo instance16 = PlayerInfo.Instance;
							return (byte)(~(instance16._shouldShowCollectPopup ? 1u : 0u)) != 0;
						}
					}
					goto IL_03ac;
				}
			}
		}
		if (this.guidelineButtonType == GuidelineButtonType._notSet)
		{
			GameObject gameObject = base.gameObject;
		}
		goto IL_03ac;
		IL_0332:
		return true;
		IL_03ac:
		return false;
	}

	private void EnableInfoIcon()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		_showIcon = true;
		if (animationState != AnimationState.NONE)
		{
			return;
		}
		_ = -1;
		obj = (Enum)(object)typeof(GuidelineButtonType);
		object obj3 = this + 20;
		string text = obj.ToString();
		string key = text + "hasScaled";
		if (!PlayerPrefs.HasKey(key))
		{
			animationState = AnimationState.SCALING;
			_ = -1;
			obj = (Enum)(object)typeof(GuidelineButtonType);
			string text2 = obj.ToString();
			string key2 = text2 + "hasScaled";
			PlayerPrefs.SetInt(key2, 1);
			return;
		}
		_ = -1;
		obj = (Enum)(object)typeof(GuidelineButtonType);
		string text3 = obj.ToString();
		string key3 = text3 + "hasScaled";
		int num = PlayerPrefs.GetInt(key3);
		if (num == 1 && (nint)obj3 == 2)
		{
			animationState = AnimationState.SCALING;
			_ = -1;
			obj = (Enum)(object)typeof(GuidelineButtonType);
			string text4 = obj.ToString();
			string key4 = text4 + "hasScaled";
			PlayerPrefs.SetInt(key4, 2);
		}
		else
		{
			animationState = AnimationState.BLINKING;
		}
	}

	private void Update()
	{
		if (this.animationState == AnimationState.NONE)
		{
			return;
		}
		AnimationState animationState;
		if (this.animationState != AnimationState.SCALING)
		{
			animationState = this.animationState;
		}
		else
		{
			if (!(currentAnimationTime < SCALE_DURATION))
			{
				goto IL_0156;
			}
			UIScreenController instance = UIScreenController.Instance;
			float num = instance.guidelineAnimation.Evaluate(currentAnimationTime);
			float num2 = Math.Min(num, 1f);
			if (!(num < 0f))
			{
				goto IL_00b3;
			}
			float deltaTime = Time.deltaTime;
			float num3 = currentAnimationTime + deltaTime;
			currentAnimationTime = num3;
			animationState = this.animationState;
		}
		AnimationState animationState2;
		if (animationState != AnimationState.BLINKING)
		{
			animationState2 = animationState;
			goto IL_01e9;
		}
		goto IL_00b3;
		IL_01e9:
		float num4;
		if (animationState2 == AnimationState.WAITING)
		{
			bool flag = currentAnimationTime < 2f;
			num4 = currentAnimationTime;
			if (!flag)
			{
				this.animationState = AnimationState.BLINKING;
				return;
			}
			goto IL_0209;
		}
		return;
		IL_00b3:
		if (!(currentAnimationTime < 1f))
		{
			goto IL_0156;
		}
		float deltaTime2 = Time.deltaTime;
		float num5 = currentAnimationTime + deltaTime2;
		currentAnimationTime = num5;
		animationState2 = this.animationState;
		goto IL_01e9;
		IL_0156:
		this.animationState = AnimationState.WAITING;
		num4 = 0f;
		goto IL_0209;
		IL_0209:
		float deltaTime3 = Time.deltaTime;
		float num6 = num4 + deltaTime3;
		currentAnimationTime = num6;
	}
}
