using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Missions;
using TMPro;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI;

public class AwardCellHelper : MonoBehaviour
{
	private enum AwardCellState
	{
		NotSet,
		SocialNetworksLocked,
		PreviewInProgress,
		InProgress,
		Collectible,
		PreviewFinished,
		Finished
	}

	private sealed class _003CAnimateChangingOfTierSprite_003Ed__76(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Image effectSprite;

		public AwardTierHelper tierIconToChange;

		public AwardCellHelper _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected VT, but got Unknown
			//IL_011c: Expected Obj, but got VT
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected Obj, but got Unknown
			//IL_014e: Expected Obj, but got VT
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected Obj, but got Unknown
			//IL_01a3: Expected Obj, but got VT
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected Obj, but got Unknown
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected Obj, but got Unknown
			//IL_0219: Expected F4, but got I
			//IL_0219: Expected F4, but got I
			//IL_0219: Expected Obj, but got I
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Expected Obj, but got Unknown
			//IL_0242: Expected I, but got Obj
			//IL_026c: Expected native int or pointer, but got VT
			//IL_029e: Expected native int or pointer, but got VT
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02be: Expected VT, but got Unknown
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Expected Obj, but got Unknown
			//IL_0385: Expected I, but got Obj
			//IL_03b8: Expected Obj, but got VT
			//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c6: Expected Obj, but got Unknown
			//IL_03f7: Expected Obj, but got VT
			//IL_0423: Unknown result type (might be due to invalid IL or missing references)
			//IL_0428: Expected Obj, but got Unknown
			//IL_044c: Expected Obj, but got VT
			//IL_0455: Unknown result type (might be due to invalid IL or missing references)
			//IL_045a: Expected Obj, but got Unknown
			//IL_0492: Unknown result type (might be due to invalid IL or missing references)
			//IL_0497: Expected VT, but got Unknown
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a5: Expected VT, but got Unknown
			object obj = default;
			Color color = (Color)(obj - 208);
			AwardCellHelper awardCellHelper = _003C_003E4__this;
			int num;
			bool result = default;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						bool flag = _003C_003E1__state == 3;
						num = -1;
						if (!flag)
						{
							goto IL_0532;
						}
					}
					else
					{
						_003C_003E1__state = -1;
						object obj2 = color + 160;
						Image image = effectSprite;
						nint num2 = (nint)image;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S2_v27 (Il2CppClass<UnityEngine.UI.Image>)+16C] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
						_ = 0;
						object obj3 = EFFECT_INITIAL_COLOR >> 16;
						object obj4 = obj3 & 0xFF;
						float num3 = (float)obj4 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
						_ = 0;
						object obj5 = EFFECT_INITIAL_COLOR >> 24;
						float num4 = (float)obj5 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+68]");
						_ = 0;
						object obj6 = EFFECT_INITIAL_COLOR & 0xFF;
						float num5 = (float)obj6 / 255f;
						object obj7 = EFFECT_INITIAL_COLOR >> 8;
						object obj8 = obj7 & 0xFF;
						float num6 = (float)obj8 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+60]");
						_ = 0;
						Color color2 = color + 80;
						Color color3 = color - -64;
						IEnumerator routine = awardCellHelper.AnimateEffectColor(image, color2, color3, 0.8f);
						Coroutine coroutine = awardCellHelper.StartCoroutine(routine);
						_003C_003E2__current = coroutine;
						result = true;
						num = 3;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					tierIconToChange.TierComplete(complete: true);
					_ = 0.5f;
					object obj9 = default;
					_003C_003E2__current = obj9;
					result = true;
					num = 2;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				Transform transform = effectSprite.transform;
				Transform transform2 = tierIconToChange.transform;
				Vector3 localPosition = transform2.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
				_ = 0;
				Vector3 localPosition2 = (Vector3)(color + 48);
				transform.localPosition = localPosition2;
				object obj10 = EFFECT_INITIAL_COLOR >> 16;
				object obj11 = obj10 & 0xFF;
				float num7 = (float)obj11 / 255f;
				object obj12 = EFFECT_INITIAL_COLOR >> 24;
				float num8 = (float)obj12 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
				_ = 0;
				object obj13 = EFFECT_INITIAL_COLOR & 0xFF;
				float num9 = (float)obj13 / 255f;
				object obj14 = EFFECT_INITIAL_COLOR >> 8;
				object obj15 = obj14 & 0xFF;
				float num10 = (float)obj15 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B0]");
				_ = 0;
				object obj16 = color + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UI.AwardCellHelper)+C]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UI.AwardCellHelper)+94]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UI.AwardCellHelper)+98]");
				AudioSource audioSource = NGUITools.PlaySound((AudioClip)num11, num12, 0f);
				object obj17 = color + 160;
				Image image2 = effectSprite;
				nint num13 = (nint)image2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v300 @ S2_v21 (Il2CppClass<UnityEngine.UI.Image>)+16C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
				_ = 0;
				_ = 4575657222473777152L;
				((Color*)(nint)color)->b = 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
				_ = 0;
				_ = 4575657222473777152L;
				((Color*)(nint)color)->r = 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
				_ = 0;
				Color color4 = color + 16;
				IEnumerator routine2 = awardCellHelper.AnimateEffectColor(image2, color4, color, 3f);
				Coroutine coroutine2 = awardCellHelper.StartCoroutine(routine2);
				_003C_003E2__current = coroutine2;
				result = true;
				num = 1;
			}
			_003C_003E1__state = num;
			goto IL_0532;
			IL_0532:
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CAnimateEffectColor_003Ed__77(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AwardCellHelper _003C_003E4__this;

		public float speedFactor;

		public Image spriteToAnimate;

		public Color color1;

		public Color color2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00fd: Expected Obj, but got VT
			//IL_018a: Expected Obj, but got I
			//IL_01cd: Expected Obj, but got I
			//IL_0210: Expected Obj, but got I
			//IL_0267: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 32;
			AwardCellHelper awardCellHelper = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (awardCellHelper._animationLerpFactor < 1f)
					{
						goto IL_00b1;
					}
				}
				goto IL_0147;
			}
			_003C_003E1__state = -1;
			awardCellHelper._animationLerpFactor = 0f;
			goto IL_00b1;
			IL_00b1:
			float deltaTime = Time.deltaTime;
			float num = deltaTime * speedFactor;
			float num2 = (awardCellHelper._animationLerpFactor += num);
			object obj3 = color2 - color1;
			float num3 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num4 = 0f;
			if (!flag)
			{
				num4 = num3;
			}
			float num5 = (float)obj3 * num4;
			float num6 = (float)color1 + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.AwardCellHelper+<AnimateEffectColor>d__77)+30]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.AwardCellHelper+<AnimateEffectColor>d__77)+20]");
			object obj4 = num7 - 0;
			float num8 = (float)obj4 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.AwardCellHelper+<AnimateEffectColor>d__77)+20]");
			float num9 = 0f + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.AwardCellHelper+<AnimateEffectColor>d__77)+38]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.AwardCellHelper+<AnimateEffectColor>d__77)+28]");
			object obj5 = num10 - 0;
			float num11 = (float)obj5 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.AwardCellHelper+<AnimateEffectColor>d__77)+28]");
			float num12 = 0f + num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.AwardCellHelper+<AnimateEffectColor>d__77)+34]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.AwardCellHelper+<AnimateEffectColor>d__77)+24]");
			object obj6 = num13 - 0;
			float num14 = (float)obj6 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.AwardCellHelper+<AnimateEffectColor>d__77)+24]");
			float num15 = 0f + num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_0147;
			IL_0147:
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private const string AWARD_IN_PROGRESS_DESCRIPTION_HEX_COLOR = "[2486BB]";

	private const string AWARD_IN_PROGRESS_VALUE_HEX_COLOR = "[004A7D]";

	private const string AWARD_COMPLETE_DESCRIPTION_HEX_COLOR = "[549133]";

	private const string AWARD_COMPLETE_VALUE_HEX_COLOR = "[015A01]";

	private const string END_COLOR_SYMBOL = "[-]";

	private static readonly Color32 COMPLETED_TITLE_TEXT_COLOR = (Color32)(-16688639);

	private static readonly Color32 ACTIVE_TITLE_TEXT_COLOR = (Color32)(-8566272);

	private static readonly Color32 ACTIVE_TITLE_TEXT_SHADOW_COLOR = (Color32)(-1119515);

	private static readonly Color32 COMPLETED_TITLE_TEXT_SHADOW_COLOR = (Color32)(-1771288);

	private static readonly Color32 COLLECTIBLE_SEGMENT_BACKGROUND_COLOR = (Color32)(-1259155826);

	private static readonly Color32 PROGRESS_SEGMENT_BACKGROUND_COLOR = (Color32)(-1261650262);

	private static readonly Color32 COMPLETE_SEGMENT_BACKGROUND_COLOR = (Color32)(-1266686062);

	private static readonly Color32 REWARD_BIG_BACKGROUND_FINISHED_COLOR = (Color32)(-10847142);

	private static readonly Color32 REWARD_BIG_BACKGROUND_IN_PROGRESS_COLOR = (Color32)(-8358813);

	private static readonly Color32 REWARD_BIG_BACKGROUND_COLLECTIBLE_COLOR = (Color32)(-7965605);

	private static readonly Color32 EFFECT_INITIAL_COLOR = (Color32)16777215;

	private AudioClip _awardTierUnlockSound;

	private AwardCollectibleHelper _mainGoalElementsHelper;

	private GameObject _expandedParent;

	private TMP_Text _missionTitle;

	private TMP_Text _missionTextDescription;

	private GameObject _missionIconsDescriptionParent;

	private GameObject _collectButtonParent;

	private TMP_Text _collectButtonLabel;

	private Image _progressIconsBG;

	private GameObject _progressBarParent;

	private Slider _progressBarSlider;

	private GameObject _progressBarFG;

	private GameObject _tieredParent;

	private AwardTierHelper _notTieredParent;

	private Image _rewardBigBG;

	private TMP_Text _previewCompleteLabel;

	private AwardTierHelper[] _tierIconHelpers;

	private Image _noTierEffectSprite;

	private AwardCollectibleHelper[] _goalIcons;

	private Image _mysteryBoxIcon;

	private TMP_Text _inMysteryBoxLabel;

	private Image _notTieredIcon;

	private TMP_Text _progressAmount;

	private GameObject _rewardContentParent;

	private TMP_Text _rewardAmount;

	private GameObject _stickerParent;

	private TMP_Text _stickerLabel;

	private Image _stickerIconSprite;

	private Image _stickerSprite;

	private CenterLabelAndSpriteUnit centerer;

	private Animation wiggleAnimation;

	private Button CollectAwardButton;

	private string[] _mainTierGoalSpriteNames;

	private string[] _mysteryBoxIconNames;

	private const string COMPLETED_ITEM_BACKGROUND_SPRITE_NAME = "icon_award_bg_completed_small";

	private const string COLLECTIBLE_ITEM_BACKGROUND_SPRITE_NAME = "icon_award_collect_bg_small";

	private const string IN_PROGRESS_ITEM_BACKGROUND_SPRITE_NAME = "icon_award_bg_small";

	private const string COMPLETED_GOAL_ICON_BACKGROUND_SPRITE_NAME = "icon_award_bg_completed";

	private const string COLLECTIBLE_GOAL_ICON_BACKGROUND_SPRITE_NAME = "icon_award_collect_bg";

	private const string IN_PROGRESS_GOAL_ICON_BACKGROUND_SPRITE_NAME = "icon_award_bg";

	private float soundVolume;

	private float soundPitch;

	private AwardCellState _currentCellState;

	private AwardsScreen _awardsScreen;

	private bool _hasManyTiers;

	private Award _currentAward;

	private bool _enablePreview;

	private float _animationLerpFactor;

	private bool _isConnectedToFacebook;

	private unsafe void Start()
	{
		Button collectAwardButton = CollectAwardButton;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(AwardCellHelper._003CStart_003Eb__49_0));
		collectAwardButton.m_OnClick.AddListener(unityAction);
	}

	private void OnDisable()
	{
		if (_currentAward != null)
		{
			_currentAward.isNew = false;
		}
	}

	public void InitCell(Award award, AwardsScreen awardsScreen)
	{
		//IL_008e: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I4
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got I4
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected I4, but got Unknown
		//IL_01d3: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I4
		if (award != null)
		{
			_currentAward = award;
			_enablePreview = award.isInPreview__BackingField;
			SocialManager instance = SocialManager.instance;
			bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
			_isConnectedToFacebook = facebookIsLoggedIn;
			AwardCellState cellState = GetCellState();
			_currentCellState = cellState;
			AwardStaticData awardStaticData = award._awardStaticData;
			Dictionary<AwardTierType, AwardTier> dictionary = awardStaticData.missionTiers__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v46 (System.Collections.Generic.Dictionary`2<Missions.AwardTierType, Missions.AwardTier>)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v46 (System.Collections.Generic.Dictionary`2<Missions.AwardTierType, Missions.AwardTier>)+18]");
			object obj = num - 0;
			_awardsScreen = awardsScreen;
			bool hasManyTiers = (nint)obj > 1;
			_hasManyTiers = hasManyTiers;
		}
		SetupCellStructure();
		SetupCellContent();
		if (~(_enablePreview ? 1u : 0u) == 0)
		{
			if (~(_hasManyTiers ? 1u : 0u) == 0)
			{
				Award currentAward = _currentAward;
				AwardTier awardActiveTier = currentAward._awardActiveTier;
				object obj3;
				if (awardActiveTier.tierType__BackingField == AwardTierType.Gold)
				{
					Award currentAward2 = _currentAward;
					object obj2 = currentAward2._currentActiveAwardState - 1;
					bool flag = (nint)obj2 < 2;
					obj3 = 1;
					if (!flag)
					{
						obj3 = 2;
					}
				}
				else
				{
					obj3 = 0;
				}
				object obj4 = obj3 + 1;
				if ((nint)award.tierAnimationPlayed != (nint)obj4)
				{
					Award currentAward3 = _currentAward;
					AwardTier awardActiveTier2 = currentAward3._awardActiveTier;
					object obj6;
					if (awardActiveTier2.tierType__BackingField == AwardTierType.Gold)
					{
						Award currentAward4 = _currentAward;
						object obj5 = currentAward4._currentActiveAwardState - 1;
						bool flag2 = (nint)obj5 < 2;
						obj6 = 1;
						if (!flag2)
						{
							obj6 = 2;
						}
					}
					else
					{
						obj6 = 0;
					}
					AwardTierType tierAnimationPlayed = (AwardTierType)(obj6 + 1);
					award.tierAnimationPlayed = tierAnimationPlayed;
				}
			}
			else
			{
				IEnumerator routine = AnimateChangingOfTierSprite(_noTierEffectSprite, _notTieredParent);
				Coroutine coroutine = StartCoroutine(routine);
			}
		}
		if (_currentCellState == AwardCellState.Collectible)
		{
			wiggleAnimation.wrapMode = WrapMode.Loop;
			bool flag3 = wiggleAnimation.Play();
		}
		else
		{
			wiggleAnimation.Stop();
		}
		if (_currentCellState == AwardCellState.SocialNetworksLocked)
		{
			GameObject gameObject = base.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private int GetNbToAnimate()
	{
		//IL_0061: Expected Obj, but got I4
		Award currentAward = _currentAward;
		AwardTier awardActiveTier = currentAward._awardActiveTier;
		if (awardActiveTier.tierType__BackingField == AwardTierType.Gold)
		{
			Award currentAward2 = _currentAward;
			object obj = currentAward2._currentActiveAwardState - 1;
			bool flag = (nint)obj < 2;
			int result = 1;
			if (!flag)
			{
				result = 2;
			}
			return result;
		}
		return 0;
	}

	private AwardCellState GetCellState()
	{
		//IL_001d: Expected Obj, but got I4
		Award currentAward = _currentAward;
		object obj = currentAward._currentActiveAwardState - 1;
		if (currentAward._currentActiveAwardState != AwardState.InProgress)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					return AwardCellState.NotSet;
				}
				AwardCellState result = AwardCellState.PreviewFinished;
				if (!_enablePreview)
				{
					result = AwardCellState.Finished;
				}
				return result;
			}
			return AwardCellState.Collectible;
		}
		AwardCellState result2 = AwardCellState.PreviewInProgress;
		if (!_enablePreview)
		{
			result2 = AwardCellState.InProgress;
		}
		return result2;
	}

	private void SetupCellStructure()
	{
		//IL_00f1: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I4
		bool active = _currentCellState != AwardCellState.Finished;
		_expandedParent.SetActive(active);
		GameObject gameObject = _missionTextDescription.gameObject;
		Award currentAward = _currentAward;
		AwardStaticData awardStaticData = currentAward._awardStaticData;
		gameObject.SetActive(awardStaticData.hasDescription__BackingField);
		Award currentAward2 = _currentAward;
		AwardStaticData awardStaticData2 = currentAward2._awardStaticData;
		bool active2 = (byte)(~(awardStaticData2.hasDescription__BackingField ? 1u : 0u)) != 0;
		_missionIconsDescriptionParent.SetActive(active2);
		if (_expandedParent.activeSelf)
		{
			bool active3 = _currentCellState == AwardCellState.Collectible;
			_collectButtonParent.SetActive(active3);
			object obj = _currentCellState & (AwardCellState)(-2);
			bool active4 = (nint)obj == 2;
			_progressBarParent.SetActive(active4);
			GameObject gameObject2 = _previewCompleteLabel.gameObject;
			bool active5 = _currentCellState == AwardCellState.PreviewFinished;
			gameObject2.SetActive(active5);
			GameObject gameObject3 = _notTieredParent.gameObject;
			bool active6 = (byte)(~(_hasManyTiers ? 1u : 0u)) != 0;
			gameObject3.SetActive(active6);
			_tieredParent.SetActive(_hasManyTiers);
			bool active7 = _currentAward.isNew || _currentCellState == AwardCellState.Collectible;
			_stickerParent.SetActive(active7);
			GameObject gameObject4 = _stickerLabel.gameObject;
			bool active8 = _currentAward.isNew && _currentCellState != AwardCellState.Collectible;
			gameObject4.SetActive(active8);
			GameObject gameObject5 = _stickerIconSprite.gameObject;
			bool active9 = _currentCellState == AwardCellState.Collectible;
			gameObject5.SetActive(active9);
			object obj2 = _currentCellState & (AwardCellState)(-5);
			bool active10 = (nint)obj2 != 1;
			_rewardContentParent.SetActive(active10);
		}
	}

	private unsafe void SetupCellContent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_094e: Expected Obj, but got I4
		//IL_0037: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got I4
		//IL_0121: Expected I, but got Obj
		//IL_09cd: Expected I4, but got Obj
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_0a84: Expected Obj, but got I4
		//IL_0aa9: Expected Obj, but got I
		//IL_0425: Expected Obj, but got I
		//IL_0555: Expected Obj, but got I4
		//IL_0a32: Expected Obj, but got I
		//IL_0a32: Expected Obj, but got I
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Expected Obj, but got Unknown
		//IL_0490: Expected I, but got Obj
		//IL_05cd: Expected I, but got Obj
		//IL_059f: Expected I, but got Obj
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Expected I4, but got Unknown
		//IL_0af7: Expected I, but got Obj
		//IL_0819: Expected Obj, but got I4
		//IL_0778: Expected I, but got Obj
		//IL_06f4: Expected I, but got Obj
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_06be: Expected I, but got Obj
		//IL_0866: Expected Obj, but got I
		//IL_0744: Expected I, but got Obj
		//IL_0898: Expected Obj, but got I
		//IL_08bb: Expected Obj, but got I
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Award currentAward = _currentAward;
		AwardTier awardActiveTier = currentAward._awardActiveTier;
		AwardGoal[] array = ((currentAward._awardActiveTier == null) ? null : awardActiveTier.listGoals__BackingField);
		int progressAsPercentage = _currentAward.GetProgressAsPercentage();
		Award currentAward2 = _currentAward;
		AwardTier awardActiveTier2 = currentAward2._awardActiveTier;
		object obj3 = awardActiveTier2.tierType__BackingField - 1;
		TMP_Text missionTitle = _missionTitle;
		Award currentAward3 = _currentAward;
		AwardStaticData awardStaticData = currentAward3._awardStaticData;
		string text = Strings.Get(awardStaticData.title__BackingField);
		nint num = (nint)missionTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S2_v3 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		string backgroundToUse = FindBackgroundToUse(mainGoalIcon: true);
		object obj4 = obj3 << 2;
		object obj5 = (object)_mainTierGoalSpriteNames + obj4;
		object obj6 = _currentCellState - 5;
		bool flag = (nint)obj6 < 2;
		bool flag2 = _currentCellState == AwardCellState.Collectible;
		bool useGlitter = flag | flag2;
		AwardCollectibleHelper mainGoalElementsHelper = _mainGoalElementsHelper;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S2_v8+10]");
		mainGoalElementsHelper.SetupAwardCollectible(backgroundToUse, (string)0, useGlitter, flag);
		if (_currentCellState == AwardCellState.PreviewFinished)
		{
			TMP_Text previewCompleteLabel = _previewCompleteLabel;
			string text2 = Strings.Get(StringID.AWARD_PREVIEW_COMPLETED_TEXT);
			nint num2 = (nint)previewCompleteLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v141 @ S2_v89 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		Award currentAward4 = _currentAward;
		AwardStaticData awardStaticData2 = currentAward4._awardStaticData;
		if (~(awardStaticData2.hasDescription__BackingField ? 1u : 0u) != 0)
		{
			object obj7 = 0;
			bool isItemCollected = default;
			while (array.Length > (nint)obj7)
			{
				object obj8 = obj7 << 2;
				object obj9 = (object)array + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v209+10]");
				object obj10 = 0;
				object obj11 = obj7 << 2;
				object obj12 = (object)_goalIcons + obj11;
				string backgroundToUse2 = FindBackgroundToUse(mainGoalIcon: false);
				if (_currentCellState != AwardCellState.Collectible)
				{
					Award currentAward5 = _currentAward;
					nint num3 = (nint)currentAward5;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ S6_v5 (Il2CppClass<Missions.Award>)+DC] (should have been resolved before IL gen)");
				}
				else
				{
					isItemCollected = true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v215+10]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v210+10]");
				((AwardCollectibleHelper)num4).SetupAwardCollectible(backgroundToUse2, (string)0, useGlitter: false, isItemCollected);
				object obj13 = obj7 + 1;
				obj7 = obj13;
			}
			Award currentAward6 = _currentAward;
			AwardStaticData awardStaticData3 = currentAward6._awardStaticData;
			bool flag3 = awardStaticData3.id__BackingField == AwardId.COLLECT_OLD_TROPHY_ITEMS_MB;
			AwardId awardId = awardStaticData3.id__BackingField;
			if (!flag3)
			{
				if (awardStaticData3.id__BackingField != AwardId.COLLECT_OLD_TROPHY_ITEMS_SMB)
				{
					goto IL_0528;
				}
				awardId = AwardId.COLLECT_OLD_TROPHY_ITEMS_SMB;
			}
			object obj14 = (int)awardId << 2;
			object obj15 = (object)_mysteryBoxIconNames + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S2_v66+10]");
			string path = "UI/" + (string)0;
			Sprite sprite = Resources.Load<Sprite>(path);
			_mysteryBoxIcon.sprite = sprite;
			goto IL_0528;
		}
		TMP_Text missionTextDescription = _missionTextDescription;
		bool flag4 = (byte)(~(awardStaticData2.hasAnotherDescriptionForOneItemGoal__BackingField ? 1u : 0u)) != 0;
		AwardStaticData awardStaticData4 = awardStaticData2;
		object obj16;
		if (!flag4)
		{
			Award currentAward7 = _currentAward;
			AwardGoal awardGoal = array[0];
			bool flag5 = awardGoal.goal__BackingField != 1;
			awardStaticData4 = currentAward7._awardStaticData;
			if (!flag5)
			{
				obj16 = currentAward7._awardStaticData + 44;
				goto IL_09c4;
			}
		}
		obj16 = awardStaticData4 + 20;
		goto IL_09c4;
		IL_09c4:
		string text3 = Strings.Get((StringID)obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
		IL_0528:
		TMP_Text inMysteryBoxLabel = _inMysteryBoxLabel;
		string format = Strings.Get(StringID.AWARD_IN_MYSTERYBOX_TEXT);
		object obj17 = _currentCellState - 5;
		if ((nint)obj17 >= 2)
		{
			string text4 = string.Format(format, "[2486BB]", "[-]");
			nint num5 = (nint)inMysteryBoxLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v346 @ S2_v80 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		else
		{
			string text5 = string.Format(format, "[549133]", "[-]");
			nint num6 = (nint)inMysteryBoxLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v353 @ S2_v75 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		if (!_expandedParent.activeSelf)
		{
			return;
		}
		TMP_Text rewardAmount = _rewardAmount;
		Award currentAward8 = _currentAward;
		AwardTier awardActiveTier3 = currentAward8._awardActiveTier;
		if (currentAward8._awardActiveTier != null)
		{
			int num7 = awardActiveTier3.reward__BackingField;
		}
		else
		{
			int num7 = 0;
		}
		int num8 = obj + 12;
		string text6 = ((int*)num8)->ToString();
		nint num9 = (nint)rewardAmount;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v501 @ S2_v16 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		if (_progressBarParent.activeSelf)
		{
			_progressBarSlider.minValue = 0f;
			_progressBarSlider.maxValue = 1f;
			float num10 = (float)progressAsPercentage / 100f;
			if (num10 > 0f)
			{
				_progressBarFG.SetActive(value: true);
				Slider progressBarSlider = _progressBarSlider;
				nint num11 = (nint)progressBarSlider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v592 @ S2_v49 (Il2CppClass<UnityEngine.UI.Slider>)+234] (should have been resolved before IL gen)");
			}
			else
			{
				_progressBarFG.SetActive(value: false);
			}
			Slider progressBarSlider2 = _progressBarSlider;
			nint num12 = (nint)progressBarSlider2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v609 @ S2_v39 (Il2CppClass<UnityEngine.UI.Slider>)+234] (should have been resolved before IL gen)");
			TMP_Text progressAmount = _progressAmount;
			object obj18 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			string text7 = $"{arg}%";
			nint num13 = (nint)progressAmount;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v651 @ S2_v44 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		if (_collectButtonParent.activeSelf)
		{
			TMP_Text collectButtonLabel = _collectButtonLabel;
			string text8 = Strings.Get(StringID.AWARDS_COLLECT_BUTTON_TEXT);
			nint num14 = (nint)collectButtonLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v627 @ S2_v33 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		if (centerer != null)
		{
			GameObject gameObject = centerer.gameObject;
			if (gameObject.activeInHierarchy)
			{
				GameObject gameObject2 = centerer.gameObject;
				if (gameObject2.activeSelf)
				{
					centerer.CenterUnit();
				}
			}
		}
		object obj19 = 0;
		while (true)
		{
			AwardTierHelper[] tierIconHelpers = _tierIconHelpers;
			if ((nint)obj19 < tierIconHelpers.Length)
			{
				object obj20 = obj19 << 2;
				object obj21 = (object)tierIconHelpers + obj20;
				int tierNumberToEnable = GetTierNumberToEnable();
				bool complete = tierNumberToEnable > (nint)obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ S0_v73+10]");
				((AwardTierHelper)0).TierComplete(complete);
				object obj22 = obj19 << 2;
				object obj23 = (object)_tierIconHelpers + obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ S0_v77+10]");
				object obj24 = 0;
				bool active = obj19 == obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ S0_v78+14]");
				((GameObject)0).SetActive(active);
				object obj25 = obj19 + 1;
				obj19 = obj25;
				continue;
			}
			break;
		}
	}

	private string FindBackgroundToUse(bool mainGoalIcon)
	{
		//IL_00b1: Expected Obj, but got I4
		object result;
		if (_currentCellState != AwardCellState.Collectible)
		{
			result = "icon_award_bg_completed";
			if (!mainGoalIcon)
			{
				result = "icon_award_bg_completed_small";
			}
			object obj = _currentCellState - 5;
			if ((nint)obj > 1)
			{
				result = "icon_award_bg";
				if (!mainGoalIcon)
				{
					result = "icon_award_bg_small";
				}
			}
		}
		else
		{
			result = "icon_award_collect_bg";
			if (!mainGoalIcon)
			{
				result = "icon_award_collect_bg_small";
			}
		}
		return (string)result;
	}

	private int GetTierNumberToEnable()
	{
		bool flag = _currentAward.HasCompletedTier(AwardTierType.Gold);
		Award currentAward = _currentAward;
		if (flag && currentAward._currentActiveAwardState == AwardState.Finished)
		{
			AwardTier awardActiveTier = currentAward._awardActiveTier;
			return (int)awardActiveTier.tierType__BackingField;
		}
		AwardTier awardActiveTier2 = currentAward._awardActiveTier;
		return (int)(awardActiveTier2.tierType__BackingField - 1);
	}

	private void CollectRewardClicked()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 32);
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Award currentAward = _currentAward;
		AwardStaticData awardStaticData = currentAward._awardStaticData;
		_ = awardStaticData.id__BackingField;
		_ = -1;
		obj = (Enum)(object)typeof(AwardId);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+1C]");
		_ = 0;
		string text = obj.ToString();
		throw new ArrayTypeMismatchException();
	}

	private IEnumerator AnimateChangingOfTierSprite(Image effectSprite, AwardTierHelper tierIconToChange)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateEffectColor(Image spriteToAnimate, Color color1, Color color2, float speedFactor = 1f)
	{
		_ = 0;
		_ = color1.b;
		_ = color1.r;
		_ = color2.r;
		_ = color2.b;
		IEnumerator result = default;
		return result;
	}

	public AwardCellHelper()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		AwardTierHelper[] tierIconHelpers = default;
		_tierIconHelpers = tierIconHelpers;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		AwardCollectibleHelper[] goalIcons = default;
		_goalIcons = goalIcons;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	static AwardCellHelper()
	{
		//IL_000f: Expected VT, but got I4
		//IL_0019: Expected VT, but got I4
		//IL_0023: Expected VT, but got I4
		//IL_002d: Expected VT, but got I4
		//IL_0037: Expected VT, but got I4
		//IL_0041: Expected VT, but got I4
		//IL_004b: Expected VT, but got I4
		//IL_0055: Expected VT, but got I4
		//IL_005f: Expected VT, but got I4
		//IL_0069: Expected VT, but got I4
		//IL_0073: Expected VT, but got I4
	}

	private void _003CStart_003Eb__49_0()
	{
		CollectRewardClicked();
	}
}
