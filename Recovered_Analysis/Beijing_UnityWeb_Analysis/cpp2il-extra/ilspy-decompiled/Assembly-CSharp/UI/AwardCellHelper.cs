using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Ionic.Crc;
using Missions;
using SYBO.Subway.Info;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;
using WeeklyHunt;

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

	private sealed class _003CAnimateChangingOfTierSprite_003Ed__91(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UISprite effectSprite;

		public AwardTierHelper tierIconToChange;

		public AwardCellHelper _003C_003E4__this;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0346: Unknown result type (might be due to invalid IL or missing references)
				//IL_034b: Expected Obj, but got Unknown
				//IL_0354: Unknown result type (might be due to invalid IL or missing references)
				//IL_0359: Expected I4, but got Unknown
				//IL_0362: Unknown result type (might be due to invalid IL or missing references)
				//IL_0367: Expected Obj, but got Unknown
				//IL_0370: Unknown result type (might be due to invalid IL or missing references)
				//IL_0375: Expected Obj, but got Unknown
				//IL_037e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0383: Expected Obj, but got Unknown
				//IL_038c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0391: Expected Obj, but got Unknown
				//IL_039a: Unknown result type (might be due to invalid IL or missing references)
				//IL_039f: Expected Obj, but got Unknown
				//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ad: Expected Obj, but got Unknown
				//IL_00a2: Expected VT, but got Obj
				//IL_00dc: Expected I, but got Obj
				//IL_00f2: Expected Obj, but got I
				//IL_01f6: Expected Obj, but got I4
				//IL_03df: Expected Obj, but got VT
				//IL_03f8: Expected VT, but got Obj
				//IL_0428: Expected I4, but got Obj
				//IL_0436: Expected I, but got Obj
				//IL_044c: Expected Obj, but got I
				//IL_0211: Unknown result type (might be due to invalid IL or missing references)
				//IL_0216: Expected Obj, but got Unknown
				//IL_0232: Expected Obj, but got I4
				//IL_0492: Expected F4, but got I
				//IL_0492: Expected F4, but got I
				//IL_0492: Expected Obj, but got I
				//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a6: Expected Obj, but got Unknown
				//IL_04d1: Expected I4, but got Obj
				//IL_0501: Unknown result type (might be due to invalid IL or missing references)
				//IL_0506: Expected Obj, but got Unknown
				//IL_0522: Expected I4, but got Obj
				//IL_011d: Expected I, but got Obj
				//IL_024d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0252: Expected Obj, but got Unknown
				//IL_027d: Expected I, but got Obj
				//IL_0293: Expected Obj, but got I
				//IL_01b6: Expected Obj, but got I4
				//IL_01d6: Expected Obj, but got I4
				//IL_016a: Expected I, but got Obj
				//IL_0539: Expected Obj, but got VT
				//IL_0552: Expected VT, but got Obj
				//IL_0563: Expected I4, but got Obj
				//IL_0590: Unknown result type (might be due to invalid IL or missing references)
				//IL_0595: Expected Obj, but got Unknown
				//IL_05b1: Expected I4, but got Obj
				//IL_05c2: Expected Obj, but got I4
				//IL_0319: Expected Obj, but got I4
				//IL_02be: Expected I, but got Obj
				object obj = default;
				Transform transform = (Transform)(obj + 96);
				EnvironmentSequence environmentSequence = (EnvironmentSequence)(obj + 80);
				Transform transform2 = (Transform)(obj + 56);
				object obj2 = obj + 48;
				object obj3 = obj + 32;
				object obj4 = obj + 72;
				object obj5 = obj + 16;
				object obj6 = obj + 52;
				AwardCellHelper awardCellHelper = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
						object obj7 = effectSprite + 80;
						transform2 = (Transform)obj7;
						Transform transform3 = transform2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v67+8]");
						((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
						nint num = (nint)typeof(AwardCellHelper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v67 (Il2CppClass<UI.AwardCellHelper>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num2 = (nint)typeof(AwardCellHelper);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v83 (Il2CppClass<UI.AwardCellHelper>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj2 = EFFECT_INITIAL_COLOR;
						obj6 = obj2;
						transform = (Transform)obj6;
						Matrix4x4 matrix4x = Matrix4x4.Inverse((Matrix4x4)transform);
						((EnvironmentSequence*)(int)environmentSequence)->value__ = (int)transform2;
						_ = ((UnityEngine.Object)transform2).m_CachedPtr;
						transform = (Transform)obj3;
						Transform transform4 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
						((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
						object obj9 = this + 12;
						int num3 = ((RouteChunk)(object)awardCellHelper).CreateEnvironmentModel((EnvironmentInfo)(object)effectSprite, environmentSequence, (int)transform, 0.8f);
						Coroutine coroutine = awardCellHelper.StartCoroutine_Auto((IEnumerator)num3);
						obj9 = coroutine;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
					((BoardAnimation)(object)tierIconToChange).Init((Transform)1);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 0.5f;
					object obj10 = this + 12;
					object obj11 = default;
					obj10 = obj11;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				GameObject gameObject = effectSprite.gameObject;
				GameObject gameObject2 = tierIconToChange.gameObject;
				transform2.localPosition = (Vector3)gameObject2;
				transform = transform2;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
				Vector3 eulerAngles = transform.eulerAngles;
				nint num4 = (nint)typeof(AwardCellHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v20 (Il2CppClass<UI.AwardCellHelper>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num5 = (nint)typeof(AwardCellHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S1_v52 (Il2CppClass<UI.AwardCellHelper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = EFFECT_INITIAL_COLOR;
				obj4 = obj2;
				transform = (Transform)obj4;
				Matrix4x4 matrix4x2 = Matrix4x4.Inverse((Matrix4x4)transform);
				transform = (Transform)obj3;
				Transform transform5 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				effectSprite.rawPivot = (UIWidget.Pivot)transform;
				nint num6 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S3_v6 (Il2CppClass<NGUITools>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num7 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S3_v13 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (UI.AwardCellHelper)+C]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (UI.AwardCellHelper)+BC]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (UI.AwardCellHelper)+C0]");
				TweenFill tweenFill = TweenFill.Begin((GameObject)num8, num9, 0f);
				object obj14 = effectSprite + 80;
				obj5 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S1_v35+8]");
				_ = 0;
				Color black = Color.black;
				((EnvironmentSequence*)(int)environmentSequence)->value__ = (int)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
				_ = 0;
				transform = (Transform)obj;
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				object obj15 = this + 12;
				int num10 = ((RouteChunk)(object)awardCellHelper).CreateEnvironmentModel((EnvironmentInfo)(object)effectSprite, environmentSequence, (int)transform, 3f);
				Coroutine coroutine2 = awardCellHelper.StartCoroutine_Auto((IEnumerator)num10);
				obj15 = coroutine2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CAnimateEffectColor_003Ed__92(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AwardCellHelper _003C_003E4__this;

		public float speedFactor;

		public UISprite spriteToAnimate;

		public Color color1;

		public Color color2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected I4, but got Unknown
				//IL_0017: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Expected I4, but got Unknown
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Expected Obj, but got Unknown
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				//IL_012b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Expected Obj, but got Unknown
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Expected Obj, but got Unknown
				//IL_0172: Expected I4, but got Obj
				//IL_018c: Expected I4, but got Obj
				//IL_01b3: Expected Ref, but got VT
				//IL_01ca: Expected I4, but got F4
				//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ee: Expected Obj, but got Unknown
				//IL_01f7: Expected Obj, but got I4
				//IL_020b: Expected Obj, but got I4
				Matrix4x4 matrix4x = default;
				int num = matrix4x - -64;
				int num2 = matrix4x + 48;
				object obj = matrix4x + 32;
				object obj2 = matrix4x + 16;
				AwardCellHelper awardCellHelper = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					awardCellHelper._animationLerpFactor = 0f;
				}
				if (awardCellHelper._animationLerpFactor < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num3 = unscaledTime * speedFactor;
					float animationLerpFactor = awardCellHelper._animationLerpFactor + num3;
					awardCellHelper._animationLerpFactor = animationLerpFactor;
					object obj3 = this + 28;
					obj = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S2_v6+8]");
					_ = 0;
					object obj4 = this + 44;
					obj2 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v11+8]");
					_ = 0;
					((int*)num2)->m_value = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
					_ = 0;
					((int*)num)->m_value = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+8]");
					_ = 0;
					((Matrix4x4*)matrix4x)->set_Item(num2, num, awardCellHelper._animationLerpFactor);
					((int*)num)->m_value = (int)matrix4x.m00;
					_ = matrix4x.m20;
					spriteToAnimate.rawPivot = (UIWidget.Pivot)num;
					object obj5 = this + 12;
					obj5 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const string AWARD_IN_PROGRESS_DESCRIPTION_HEX_COLOR = "[2486BB]";

	private const string AWARD_IN_PROGRESS_VALUE_HEX_COLOR = "[004A7D]";

	private const string AWARD_COMPLETE_DESCRIPTION_HEX_COLOR = "[549133]";

	private const string AWARD_COMPLETE_VALUE_HEX_COLOR = "[015A01]";

	private const string END_COLOR_SYMBOL = "[-]";

	private static readonly Color32 COMPLETED_TITLE_TEXT_COLOR;

	private static readonly Color32 ACTIVE_TITLE_TEXT_COLOR;

	private static readonly Color32 ACTIVE_TITLE_TEXT_SHADOW_COLOR;

	private static readonly Color32 COMPLETED_TITLE_TEXT_SHADOW_COLOR;

	private static readonly Color32 COLLECTIBLE_SEGMENT_BACKGROUND_COLOR;

	private static readonly Color32 PROGRESS_SEGMENT_BACKGROUND_COLOR;

	private static readonly Color32 COMPLETE_SEGMENT_BACKGROUND_COLOR;

	private static readonly Color32 REWARD_BIG_BACKGROUND_FINISHED_COLOR;

	private static readonly Color32 REWARD_BIG_BACKGROUND_IN_PROGRESS_COLOR;

	private static readonly Color32 REWARD_BIG_BACKGROUND_COLLECTIBLE_COLOR;

	private static readonly Color32 EFFECT_INITIAL_COLOR;

	private static readonly Color32 MYSTERYBOX_BACKGROUND_PROGRESS_COLOR;

	private static readonly Color32 MYSTERYBOX_BACKGROUND_FINISHED_COLOR;

	private AudioClip _awardTierUnlockSound;

	private AwardCollectibleHelper _mainGoalElementsHelper;

	private GameObject _expandedParent;

	private UILabel _missionTitle;

	private UILabel _missionTextDescription;

	private GameObject _missionIconsDescriptionParent;

	private UISprite _cellBackground;

	private GameObject _collectButtonParent;

	private UILabel _collectButtonLabel;

	private UISprite _progressIconsBG;

	private GameObject _progressBarParent;

	private UISlider _progressBarSlider;

	private GameObject _progressBarFG;

	private GameObject _tieredParent;

	private AwardTierHelper _notTieredParent;

	private UISprite _rewardBigBG;

	private UILabel _previewCompleteLabel;

	private GameObject _loginFBButton;

	private GameObject _loginButtonContents;

	private GameObject _connectingButtonContents;

	private Layout _connectingContentsLayout;

	private Layout _loginContentLayout;

	private UISprite _loginFBButtonFill;

	private UILabel _loginFBLabel;

	private UILabel _connectingLabel;

	private AwardTierHelper[] _tierIconHelpers;

	private UISprite _tierEffectSprite;

	private UISprite _noTierEffectSprite;

	private AwardCollectibleHelper[] _goalIcons;

	private UISprite _mysteryBoxIcon;

	private UISprite _mysteryBoxArrowBackground;

	private UILabel _progressAmount;

	private GameObject _rewardContentParent;

	private UILabel _rewardAmount;

	private HorizontalLayout _rewardContentLayout;

	private GameObject _stickerParent;

	private UISprite _stickerIconSprite;

	private UISprite _stickerIconNew;

	private UISprite _stickerSprite;

	private Animation wiggleAnimation;

	private BoxCollider _loginCollider;

	private UISprite _socialLock;

	private string[] _mainTierGoalSpriteNames;

	private string[] _mysteryBoxIconNames;

	private const string COMPLETED_ITEM_BACKGROUND_SPRITE_NAME = "icon_award_bg_completed_small";

	private const string COLLECTIBLE_ITEM_BACKGROUND_SPRITE_NAME = "icon_award_collect_bg_small";

	private const string IN_PROGRESS_ITEM_BACKGROUND_SPRITE_NAME = "icon_award_bg_small";

	private const string DIAMOND_TIER_ITEM_BACKGROUND_SPRITE_NAME = "icon_diamond_award_bg";

	private const string COLLECTIBLE_DIAMOND_TIER_ITEM_BACKGROUND_SPRITE_NAME = "icon_diamond_award_collect_bg";

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

	private void OnDisable()
	{
	}

	public void InitCell(Award award, AwardsScreen awardsScreen)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CrcCalculatorStream);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Ionic.Crc.CrcCalculatorStream>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CrcCalculatorStream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Ionic.Crc.CrcCalculatorStream>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8AA2");
	}

	private unsafe int GetNbToAnimate()
	{
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected I, but got Unknown
		//IL_01c6: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0210: Expected I, but got Obj
		//IL_0226: Expected Obj, but got I
		//IL_013a: Expected I4, but got Obj
		//IL_0154: Expected Obj, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0190: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_00ab: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v49 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(GameObject);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type systemTypeInstance = Type.internal_from_handle((IntPtr)num3);
		UnityEngine.Object[] array = Resources.LoadAll("Prefabs/Special/FreeMemoryStatus", systemTypeInstance);
		if (array != null)
		{
			if ((object)array.GetType() != typeof(GameObject))
			{
				array = null;
			}
		}
		else
		{
			array = null;
		}
		nint num4 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v28 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v38 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num6 = NGUITools.CalculateNextDepth((GameObject)(object)this, (byte)(int)array != 0);
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S2_v4 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v101 @ S3_v4 (should have been resolved before IL gen)");
		int num8 = default;
		object obj7 = num8 + 24;
		obj7 = num6;
		return num8;
	}

	private AwardCellState GetCellState()
	{
		//IL_0038: Expected Obj, but got I4
		Award currentAward = _currentAward;
		AwardTier awardActiveTier = currentAward._awardActiveTier;
		AwardCellState awardCellState = (AwardCellState)(awardActiveTier.tierType__BackingField - 2);
		object obj = awardCellState - 1;
		if (awardCellState != AwardCellState.SocialNetworksLocked)
		{
			if ((nint)obj == 1)
			{
				Award currentAward2 = _currentAward;
				PersistentAwardProgress savedProgress = currentAward2.savedProgress;
				if (savedProgress.currentActiveAwardState != AwardState.Collectible)
				{
					Award currentAward3 = _currentAward;
					PersistentAwardProgress savedProgress2 = currentAward3.savedProgress;
					if (savedProgress2.currentActiveAwardState == AwardState.InProgress)
					{
						return AwardCellState.PreviewInProgress;
					}
					return AwardCellState.InProgress;
				}
				return AwardCellState.PreviewInProgress;
			}
			return AwardCellState.NotSet;
		}
		return awardCellState;
	}

	private void SetupCellStructure()
	{
		if (_currentAward != null)
		{
			_currentAward.isInPreview = false;
		}
	}

	private void SetupCellContent()
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_0378: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I4
		//IL_01f8: Expected Obj, but got I4
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0236: Expected Obj, but got I4
		//IL_028e: Expected Obj, but got I4
		//IL_0270: Expected Obj, but got I4
		//IL_03e9: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I4
		//IL_032b: Expected Obj, but got I4
		//IL_041d: Expected Obj, but got I4
		bool flag = _currentCellState != AwardCellState.Finished;
		_expandedParent.tag = (string)flag;
		string text = _missionTextDescription.tag;
		Award currentAward = _currentAward;
		AwardStaticData awardData = currentAward._awardData;
		bool flag2 = awardData.hasDescription__BackingField;
		((GameObject)(object)text).tag = (string)flag2;
		Award currentAward2 = _currentAward;
		AwardStaticData awardData2 = currentAward2._awardData;
		bool flag3 = awardData2.hasDescription__BackingField;
		string text2 = (string)((flag3 ? 1 : 0) ^ 1);
		_missionIconsDescriptionParent.tag = text2;
		string text3 = _socialLock.tag;
		bool flag4 = _currentCellState == AwardCellState.SocialNetworksLocked;
		((GameObject)(object)text3).tag = (string)flag4;
		if (_expandedParent.activeInHierarchy)
		{
			string text4 = _tierEffectSprite.tag;
			bool enablePreview = _enablePreview;
			((GameObject)(object)text4).tag = (string)enablePreview;
			bool flag5 = _currentCellState == AwardCellState.Collectible;
			_collectButtonParent.tag = (string)flag5;
			string text5;
			if (_currentCellState == AwardCellState.InProgress)
			{
				text5 = (string)1;
			}
			else
			{
				bool flag6 = _currentCellState == AwardCellState.PreviewInProgress;
				text5 = (string)flag6;
			}
			_progressBarParent.tag = text5;
			string text6 = _previewCompleteLabel.tag;
			bool flag7 = _currentCellState == AwardCellState.PreviewFinished;
			((GameObject)(object)text6).tag = (string)flag7;
			string text7 = _notTieredParent.tag;
			bool hasManyTiers = _hasManyTiers;
			string text8 = (string)((hasManyTiers ? 1 : 0) ^ 1);
			((GameObject)(object)text7).tag = text8;
			object obj = this - -64;
			bool hasManyTiers2 = _hasManyTiers;
			((GameObject)obj).tag = (string)hasManyTiers2;
			string text9;
			if (_currentAward.activeTierType != AwardTierType.None)
			{
				text9 = (string)1;
			}
			else
			{
				bool flag8 = _currentCellState == AwardCellState.Collectible;
				text9 = (string)flag8;
			}
			_stickerParent.tag = text9;
			string text10 = _stickerIconNew.tag;
			string text11;
			if (_currentAward.activeTierType != AwardTierType.None)
			{
				bool flag9 = _currentCellState != AwardCellState.Collectible;
				text11 = (string)flag9;
			}
			else
			{
				text11 = null;
			}
			((GameObject)(object)text10).tag = text11;
			string text12 = _stickerIconSprite.tag;
			bool flag10 = _currentCellState == AwardCellState.Collectible;
			((GameObject)(object)text12).tag = (string)flag10;
			string text13;
			if (_currentCellState == AwardCellState.PreviewFinished)
			{
				text13 = null;
			}
			else
			{
				bool flag11 = _currentCellState != AwardCellState.SocialNetworksLocked;
				text13 = (string)flag11;
			}
			_rewardContentParent.tag = text13;
			bool flag12 = _currentCellState == AwardCellState.SocialNetworksLocked;
			_loginFBButton.tag = (string)flag12;
			if (_currentCellState == AwardCellState.SocialNetworksLocked)
			{
				SetFBLoginButtonToConnectingState();
			}
		}
	}

	private unsafe void SetupCellColors()
	{
		//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea3: Expected Obj, but got Unknown
		//IL_0eac: Expected Obj, but got I4
		//IL_0f11: Expected Obj, but got I4
		//IL_0f36: Expected I, but got Obj
		//IL_0f4c: Expected Obj, but got I
		//IL_0f8a: Expected I4, but got Obj
		//IL_003c: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_12e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e9: Expected Obj, but got Unknown
		//IL_1347: Expected Obj, but got I4
		//IL_1347: Expected Obj, but got I4
		//IL_1347: Expected I4, but got Obj
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected VT, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected Obj, but got Unknown
		//IL_01cc: Expected I, but got Obj
		//IL_01e2: Expected Obj, but got I
		//IL_1097: Expected I4, but got Obj
		//IL_020d: Expected I, but got Obj
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected Obj, but got Unknown
		//IL_08bf: Expected I4, but got Obj
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected Obj, but got Unknown
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected Obj, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_08d2: Expected I, but got Obj
		//IL_08e8: Expected Obj, but got I
		//IL_07e2: Expected Obj, but got I4
		//IL_07e2: Expected Obj, but got I
		//IL_07e2: Expected I4, but got Obj
		//IL_1399: Expected I, but got Obj
		//IL_13af: Expected Obj, but got I
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected Obj, but got Unknown
		//IL_07b1: Expected Obj, but got I4
		//IL_07b1: Expected Obj, but got I4
		//IL_07b1: Expected Obj, but got I
		//IL_07b1: Expected I4, but got Obj
		//IL_1188: Expected Obj, but got VT
		//IL_119d: Expected F4, but got Obj
		//IL_1198: Expected native int or pointer, but got VT
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_0896: Expected I4, but got Obj
		//IL_0575: Expected I, but got Obj
		//IL_13e6: Expected F4, but got Obj
		//IL_13e1: Expected native int or pointer, but got VT
		//IL_13fb: Expected F4, but got I
		//IL_13f6: Expected native int or pointer, but got VT
		//IL_140a: Expected I4, but got VT
		//IL_09c4: Expected I, but got Obj
		//IL_1165: Expected Obj, but got VT
		//IL_117a: Expected F4, but got Obj
		//IL_1175: Expected native int or pointer, but got VT
		//IL_03b5: Expected I, but got Obj
		//IL_03cb: Expected Obj, but got I
		//IL_0953: Expected I, but got Obj
		//IL_03f6: Expected I, but got Obj
		//IL_11aa: Expected Obj, but got I4
		//IL_0d17: Expected I, but got Obj
		//IL_0d2d: Expected Obj, but got I
		//IL_0bbf: Expected I, but got Obj
		//IL_0bd5: Expected Obj, but got I
		//IL_0c75: Expected I, but got Obj
		//IL_0c8b: Expected Obj, but got I
		//IL_122f: Expected I4, but got Obj
		//IL_0af5: Expected I, but got Obj
		//IL_0b0b: Expected Obj, but got I
		//IL_0abd: Expected Obj, but got I4
		//IL_129a: Expected Obj, but got I4
		//IL_0d58: Expected I, but got Obj
		//IL_1251: Expected I4, but got Obj
		//IL_0c00: Expected I, but got Obj
		//IL_11f2: Expected F4, but got Obj
		//IL_11ed: Expected native int or pointer, but got VT
		//IL_0d04: Expected I4, but got Obj
		//IL_0cb6: Expected I, but got Obj
		//IL_0b84: Expected I4, but got Obj
		//IL_0b36: Expected I, but got Obj
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0e: Expected Obj, but got Unknown
		//IL_0e75: Expected Obj, but got I4
		//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e88: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 28;
		obj = 0;
		Award currentAward = _currentAward;
		AwardGoal[] array;
		if (currentAward._awardActiveTier != null)
		{
			AwardTier awardActiveTier = currentAward._awardActiveTier;
			array = awardActiveTier.listGoals__BackingField;
		}
		else
		{
			array = null;
		}
		PersistentAwardProgress persistentProgress = _currentAward.GetPersistentProgress();
		Award currentAward2 = _currentAward;
		AwardTier awardActiveTier2 = currentAward2._awardActiveTier;
		object obj3 = awardActiveTier2.tierType__BackingField - 1;
		Award currentAward3 = _currentAward;
		AwardStaticData awardData = currentAward3._awardData;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S2_v2 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S2_v166 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(awardData.title__BackingField);
		_missionTitle.fontSize = (int)text;
		bool flag;
		Action onClickDelegate;
		if (_currentCellState == AwardCellState.Finished)
		{
			flag = true;
			onClickDelegate = (Action)1;
		}
		else if (_currentCellState == AwardCellState.PreviewFinished)
		{
			flag = true;
			onClickDelegate = (Action)1;
		}
		else
		{
			bool flag2;
			if (_currentCellState == AwardCellState.Collectible)
			{
				flag2 = true;
			}
			else
			{
				Award currentAward4 = _currentAward;
				AwardTier awardActiveTier3 = currentAward4._awardActiveTier;
				flag2 = awardActiveTier3.tierType__BackingField == AwardTierType.Diamond;
			}
			flag = flag2;
			onClickDelegate = null;
		}
		bool active = _currentCellState == AwardCellState.SocialNetworksLocked;
		_mainGoalElementsHelper.ActivateCanGlow(active);
		Award currentAward5 = _currentAward;
		AwardTier awardActiveTier4 = currentAward5._awardActiveTier;
		bool flag3 = awardActiveTier4.tierType__BackingField == AwardTierType.Diamond && _currentCellState != AwardCellState.Finished && _currentCellState != AwardCellState.PreviewFinished;
		string text2 = ((CelebrationPopupLabelTemplate)this)._GetTrophyLabel(Trophies.Trophy.goldbar);
		object obj5 = _mainTierGoalSpriteNames + 16;
		object obj6 = obj3 << 2;
		object earnerTitle = obj5 + obj6;
		bool flag4 = flag;
		bool flag5 = flag3;
		((FacebookGiftButton)(object)_mainGoalElementsHelper).Init((int)text2, (string)earnerTitle, (string)flag4, onClickDelegate, (UIScrollView)flag5);
		Award currentAward6 = _currentAward;
		AwardTier awardActiveTier5 = currentAward6._awardActiveTier;
		bool flag6 = awardActiveTier5.tierType__BackingField == AwardTierType.Diamond && _currentCellState == AwardCellState.Collectible;
		bool socialLock = flag6;
		_mainGoalElementsHelper.ChangeCanColorForSocialLock(socialLock);
		if (_currentCellState == AwardCellState.PreviewFinished)
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v223 (Il2CppClass<Strings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S1_v230 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text3 = Strings.GetDefault("AWARD_PREVIEW_COMPLETED_TEXT");
			_previewCompleteLabel.fontSize = (int)text3;
		}
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 32);
		object obj8 = obj2 + 16;
		object obj9 = obj2 + 24;
		object obj10 = obj2 + 20;
		Award currentAward7 = _currentAward;
		AwardStaticData awardData2 = currentAward7._awardData;
		string key;
		if (~(awardData2.hasDescription__BackingField ? 1u : 0u) == 0)
		{
			Award currentAward8 = _currentAward;
			AwardStaticData awardData3 = currentAward8._awardData;
			if (~(awardData3.hasAnotherDescriptionForOneItemGoal__BackingField ? 1u : 0u) == 0)
			{
				object obj11 = array + 16;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v173+8]");
				if ((nint)0 == 1)
				{
					Award currentAward9 = _currentAward;
					AwardStaticData awardData4 = currentAward9._awardData;
					key = awardData4.descriptionForOneItemGoal__BackingField;
					goto IL_109c;
				}
			}
			Award currentAward10 = _currentAward;
			AwardStaticData awardData5 = currentAward10._awardData;
			key = awardData5.description__BackingField;
			goto IL_109c;
		}
		object obj13 = array + 12;
		object obj14 = default;
		Action onClickDelegate2 = default;
		object obj22 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
		{
			object obj15 = array + 16;
			object obj16 = obj14 << 2;
			object obj17 = obj15 + obj16;
			object obj18 = obj17;
			bool flag7 = _currentCellState == AwardCellState.Collectible;
			object obj19 = _goalIcons + 16;
			object obj20 = obj14 << 2;
			object obj21 = obj19 + obj20;
			string text4 = ((CelebrationPopupLabelTemplate)this)._GetTrophyLabel(Trophies.Trophy.diamond);
			if (flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v140+10]");
				((FacebookGiftButton)obj21).Init((int)text4, (string)0, (string)null, (Action)1, (UIScrollView)flag5);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v140+10]");
				((FacebookGiftButton)obj21).Init((int)text4, (string)0, (string)null, onClickDelegate2, (UIScrollView)flag5);
			}
			obj14 = obj22 + 1;
		}
		Award currentAward11 = _currentAward;
		AwardStaticData awardData6 = currentAward11._awardData;
		if (awardData6.id__BackingField != AwardId.COLLECT_OLD_TROPHY_ITEMS_MB)
		{
			Award currentAward12 = _currentAward;
			AwardStaticData awardData7 = currentAward12._awardData;
			if (awardData7.id__BackingField == AwardId.COLLECT_OLD_TROPHY_ITEMS_SMB)
			{
				object obj23 = _mysteryBoxIconNames + 20;
				_mysteryBoxIcon.fillCenter = (byte)(int)obj23 != 0;
			}
		}
		else
		{
			object obj24 = _mysteryBoxIconNames + 16;
			_mysteryBoxIcon.fillCenter = (byte)(int)obj24 != 0;
		}
		nint num5 = (nint)typeof(AwardCellHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S1_v128 (Il2CppClass<UI.AwardCellHelper>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		bool flag8 = obj25 == null;
		if (_currentCellState == AwardCellState.PreviewFinished)
		{
			if (!flag8)
			{
				nint num6 = (nint)typeof(AwardCellHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S1_v158 (Il2CppClass<UI.AwardCellHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj8 = MYSTERYBOX_BACKGROUND_FINISHED_COLOR;
			obj9 = obj8;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		}
		else
		{
			if (!flag8)
			{
				nint num7 = (nint)typeof(AwardCellHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S1_v146 (Il2CppClass<UI.AwardCellHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj8 = MYSTERYBOX_BACKGROUND_PROGRESS_COLOR;
			obj10 = obj8;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		}
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_mysteryBoxArrowBackground.rawPivot = (UIWidget.Pivot)matrix4x;
		if (!_expandedParent.activeInHierarchy)
		{
			return;
		}
		Award currentAward13 = _currentAward;
		int num8;
		if (currentAward13._awardActiveTier != null)
		{
			AwardTier awardActiveTier6 = currentAward13._awardActiveTier;
			num8 = awardActiveTier6.reward__BackingField;
		}
		else
		{
			num8 = 0;
		}
		obj = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		_rewardAmount.fontSize = fontSize;
		if (_progressBarParent.activeInHierarchy)
		{
			float num9 = (float)persistentProgress / 100f;
			if (num9 > 0f)
			{
				_progressBarFG.tag = (string)1;
				_progressBarSlider.alpha = num9;
			}
			else
			{
				_progressBarFG.tag = null;
			}
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ S1_v107 (Il2CppClass<Strings>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num11 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ S1_v115 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format = Strings.GetDefault("AWARD_PROGRESS_AMOUNT_FORMAT");
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)persistentProgress;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string text5 = string.Format(format, args);
			_progressAmount.fontSize = (int)text5;
		}
		if (_collectButtonParent.activeInHierarchy)
		{
			nint num12 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ S1_v92 (Il2CppClass<Strings>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num13 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ S1_v99 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text6 = Strings.GetDefault("AWARDS_COLLECT_BUTTON_TEXT");
			_collectButtonLabel.fontSize = (int)text6;
		}
		if (_loginFBButton.activeInHierarchy)
		{
			nint num14 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ S1_v77 (Il2CppClass<Strings>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num15 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ S1_v87 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text7 = Strings.GetDefault("AWARD_SOCIAL_NETWORK_LOCKED_TEXT");
			_loginFBLabel.fontSize = (int)text7;
			string text8 = Strings.GetDefault("SOCIAL_BUTTON_FEEDBACK_CONNECTING");
			_connectingLabel.fontSize = (int)text8;
		}
		nint num16 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_rewardContentLayout).FindKernel((string)null) != 0)
		{
			string text9 = _rewardContentLayout.tag;
			string text10 = ((GameObject)(object)text9).tag;
			if (text10 != null)
			{
				((RewardForVideoButton)(object)_rewardContentLayout).Init((VideoButtonPayload)null);
			}
		}
		object obj30 = 0;
		while (true)
		{
			AwardTierHelper[] tierIconHelpers = _tierIconHelpers;
			if ((nint)obj30 < tierIconHelpers.Length)
			{
				bool flag9 = ((BoardSelectButton)this).CurrentlyShownBoardMatchesTrySpecialPowerBoard();
				bool flag10 = (nint)obj30 == (flag9 ? 1 : 0);
				object obj31 = _tierIconHelpers + 16;
				object obj32 = obj30 << 2;
				object obj33 = obj31 + obj32;
				if (flag10)
				{
					((AwardTierHelper)obj33)._002Ector();
				}
				else
				{
					bool flag11 = ((BoardSelectButton)this).CurrentlyShownBoardMatchesTrySpecialPowerBoard();
					bool flag12 = (nint)obj30 < (flag11 ? 1 : 0);
					((BoardAnimation)obj33).Init((Transform)flag12);
				}
				object obj34 = obj30 + 1;
				obj30 = obj34;
				continue;
			}
			break;
		}
		return;
		IL_109c:
		if (_currentCellState != AwardCellState.PreviewFinished && _currentCellState != AwardCellState.Finished)
		{
			nint num18 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S1_v208 (Il2CppClass<Strings>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num19 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S1_v215 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text11 = Strings.GetDefault(key);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		nint num20 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S1_v195 (Il2CppClass<Strings>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num21 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S1_v202 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text12 = Strings.GetDefault(key);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private unsafe string FindBackgroundToUse(bool mainGoalIcon)
	{
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_01f9: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_023b: Expected I, but got Obj
		//IL_0251: Expected Obj, but got I
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected VT, but got Unknown
		//IL_0328: Expected I4, but got Obj
		//IL_0323: Expected native int or pointer, but got VT
		//IL_0338: Expected native int or pointer, but got VT
		//IL_034d: Expected native int or pointer, but got VT
		//IL_0362: Expected native int or pointer, but got VT
		//IL_0385: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_017e: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_02a7: Expected I, but got Obj
		//IL_02bd: Expected Obj, but got I
		//IL_039b: Expected Obj, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I
		//IL_00c2: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 28;
		obj = 0;
		obj2 = ((bool*)(mainGoalIcon ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mainGoalIcon @ L1 (System.Boolean)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mainGoalIcon @ L1 (System.Boolean)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mainGoalIcon @ L1 (System.Boolean)+18]");
		_ = 0;
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v71 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntData.PrizeData prizeData = (WeeklyHuntData.PrizeData)(obj2 + 32);
		((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
		((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
		string text = WeeklyHuntManager.Get(prizeData);
		obj = text;
		object obj4 = 0;
		while (true)
		{
			AudioClip awardTierUnlockSound = _awardTierUnlockSound;
			object obj5 = obj4;
			AudioClip.PCMReaderCallback pCMReaderCallback = awardTierUnlockSound.m_PCMReaderCallback;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<AudioClip.PCMReaderCallback, UIntPtr>(ref pCMReaderCallback))
			{
				object obj6 = _awardTierUnlockSound + 16;
				object obj7 = obj4 << 3;
				object obj8 = obj6 + obj7;
				if (obj8 == text)
				{
					break;
				}
				object obj9 = obj4 + 1;
				obj4 = obj9;
				continue;
			}
			object obj10 = (mainGoalIcon ? 1 : 0) + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		object obj11 = _awardTierUnlockSound + 16;
		object obj12 = obj4 << 3;
		object obj13 = obj11 + obj12;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v65 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v48+4]");
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v48+4]");
		return (string)0;
	}

	private int GetTierNumberToEnable()
	{
		//IL_0071: Expected Obj, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01f8: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I4
		Award currentAward = _currentAward;
		AwardStaticData awardData = currentAward._awardData;
		object obj;
		if (~(awardData.useFacebook__BackingField ? 1u : 0u) != 0)
		{
			obj = 14;
		}
		else
		{
			obj = ((~(_isConnectedToFacebook ? 1u : 0u) != 0) ? ((object)0) : ((object)14));
		}
		object obj2 = obj & 0xF;
		bool flag = obj2 == null;
		Award currentAward2 = _currentAward;
		PersistentAwardProgress savedProgress = currentAward2.savedProgress;
		object obj3 = savedProgress.currentActiveAwardState - 1;
		int num;
		if (savedProgress.currentActiveAwardState != AwardState.InProgress)
		{
			num = (((nint)obj3 == 1) ? 4 : (((nint)obj3 == 2) ? ((~(_enablePreview ? 1u : 0u) != 0) ? 6 : 5) : 0));
		}
		else
		{
			num = ((~(_enablePreview ? 1u : 0u) != 0) ? 3 : 2);
		}
		int num2 = num & 6;
		bool flag2 = num2 == 2;
		object obj4 = flag & flag2;
		if (obj4 != null)
		{
			return 1;
		}
		return num;
	}

	public unsafe void CollectRewardClicked()
	{
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected Obj, but got Unknown
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected Obj, but got Unknown
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Expected Obj, but got Unknown
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected Obj, but got Unknown
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected Obj, but got Unknown
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected Obj, but got Unknown
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Expected Obj, but got Unknown
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected Obj, but got Unknown
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected Obj, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected Obj, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected Obj, but got Unknown
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected Obj, but got Unknown
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Expected Obj, but got Unknown
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected Obj, but got Unknown
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected Obj, but got Unknown
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected Obj, but got Unknown
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected Obj, but got Unknown
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected Obj, but got Unknown
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected Obj, but got Unknown
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Expected I4, but got Unknown
		//IL_0954: Expected I4, but got Obj
		//IL_0980: Expected Obj, but got I4
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_09a8: Expected Obj, but got VT
		//IL_09bd: Expected I4, but got Obj
		//IL_09c6: Expected VT, but got I4
		//IL_09d7: Expected I4, but got Obj
		//IL_09fc: Expected Obj, but got VT
		//IL_0a11: Expected I4, but got Obj
		//IL_0a1a: Expected VT, but got I4
		//IL_0136: Expected I4, but got Obj
		//IL_015b: Expected Obj, but got VT
		//IL_0170: Expected I4, but got Obj
		//IL_0179: Expected VT, but got I4
		//IL_00ea: Expected I, but got Obj
		//IL_01bc: Expected I, but got Obj
		//IL_01d2: Expected Obj, but got I
		//IL_018f: Expected I4, but got Obj
		//IL_01a5: Expected Obj, but got I4
		//IL_0a2c: Expected Obj, but got VT
		//IL_0a41: Expected I4, but got Obj
		//IL_0a4a: Expected VT, but got I4
		//IL_0a5b: Expected I4, but got Obj
		//IL_0a80: Expected Obj, but got VT
		//IL_0a95: Expected I4, but got Obj
		//IL_0a9e: Expected VT, but got I4
		//IL_0249: Expected I4, but got Obj
		//IL_026e: Expected Obj, but got VT
		//IL_0283: Expected I4, but got Obj
		//IL_028c: Expected VT, but got I4
		//IL_01fd: Expected I, but got Obj
		//IL_02a2: Expected I4, but got Obj
		//IL_02b8: Expected Obj, but got I4
		//IL_0c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c16: Expected Obj, but got Unknown
		//IL_0c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c24: Expected Obj, but got Unknown
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Expected Obj, but got Unknown
		//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c40: Expected Obj, but got Unknown
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Expected Obj, but got Unknown
		//IL_0c57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Expected Obj, but got Unknown
		//IL_051f: Expected I, but got Obj
		//IL_0535: Expected Obj, but got I
		//IL_06f5: Expected I, but got Obj
		//IL_070b: Expected Obj, but got I
		//IL_05d9: Expected I, but got Obj
		//IL_05ef: Expected Obj, but got I
		//IL_0bb8: Expected Obj, but got VT
		//IL_0bcd: Expected I4, but got Obj
		//IL_0bd6: Expected VT, but got I4
		//IL_0be7: Expected I4, but got Obj
		//IL_0667: Expected I, but got Obj
		//IL_067d: Expected Obj, but got I
		//IL_0c8f: Expected Obj, but got VT
		//IL_0ca4: Expected I4, but got Obj
		//IL_0cad: Expected VT, but got I4
		//IL_0cbe: Expected I4, but got Obj
		//IL_0560: Expected I, but got Obj
		//IL_02cf: Expected I, but got Obj
		//IL_02e5: Expected Obj, but got I
		//IL_0e1f: Expected Obj, but got VT
		//IL_0e34: Expected I4, but got Obj
		//IL_0e3d: Expected VT, but got I4
		//IL_0e4e: Expected I4, but got Obj
		//IL_0e73: Expected Obj, but got VT
		//IL_0e88: Expected I4, but got Obj
		//IL_0ce8: Expected Obj, but got VT
		//IL_0cfd: Expected I4, but got Obj
		//IL_0d06: Expected VT, but got I4
		//IL_0d17: Expected I4, but got Obj
		//IL_0d3c: Expected Obj, but got VT
		//IL_0d51: Expected I4, but got Obj
		//IL_061a: Expected I, but got Obj
		//IL_0ab0: Expected Obj, but got VT
		//IL_0ac5: Expected I4, but got Obj
		//IL_0ace: Expected VT, but got I4
		//IL_0adf: Expected I4, but got Obj
		//IL_0b04: Expected Obj, but got VT
		//IL_0b19: Expected I4, but got Obj
		//IL_0b22: Expected VT, but got I4
		//IL_0d69: Expected VT, but got I4
		//IL_0d7a: Expected I4, but got Obj
		//IL_07e7: Expected I, but got Obj
		//IL_0d9e: Expected Obj, but got VT
		//IL_0db3: Expected I4, but got Obj
		//IL_0dbc: Expected VT, but got I4
		//IL_0dcd: Expected I4, but got Obj
		//IL_0df2: Expected Obj, but got VT
		//IL_0e07: Expected I4, but got Obj
		//IL_06a8: Expected I, but got Obj
		//IL_035c: Expected I4, but got Obj
		//IL_0381: Expected Obj, but got VT
		//IL_0396: Expected I4, but got Obj
		//IL_039f: Expected VT, but got I4
		//IL_0310: Expected I, but got Obj
		//IL_03e2: Expected I, but got Obj
		//IL_03f8: Expected Obj, but got I
		//IL_0776: Expected I, but got Obj
		//IL_03b5: Expected I4, but got Obj
		//IL_03cb: Expected Obj, but got I4
		//IL_0b34: Expected Obj, but got VT
		//IL_0b49: Expected I4, but got Obj
		//IL_0b52: Expected VT, but got I4
		//IL_0b63: Expected I4, but got Obj
		//IL_0b88: Expected Obj, but got VT
		//IL_0b9d: Expected I4, but got Obj
		//IL_0ba6: Expected VT, but got I4
		//IL_046f: Expected I4, but got Obj
		//IL_0494: Expected Obj, but got VT
		//IL_04a9: Expected I4, but got Obj
		//IL_04b2: Expected VT, but got I4
		//IL_0423: Expected I, but got Obj
		//IL_04c8: Expected I4, but got Obj
		//IL_04de: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 156;
		object obj4 = obj2 + 40;
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 152;
		object obj7 = obj2 + 16;
		object obj8 = obj2 + 148;
		object obj9 = obj2 + 144;
		object obj10 = obj2 + 140;
		object obj11 = obj2 + 136;
		object obj12 = obj2 + 132;
		object obj13 = obj2 + 128;
		object obj14 = obj2 + 124;
		object obj15 = obj2 + 120;
		object obj16 = obj2 + 116;
		object obj17 = obj2 + 112;
		object obj18 = obj2 + 108;
		object obj19 = obj2 + 104;
		object obj20 = obj2 - -64;
		Color black = Color.black;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 160);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v22+8]");
		_ = 0;
		_missionTextDescription.rawPivot = pivot;
		object obj21 = _currentCellState - 1;
		if (_currentCellState == AwardCellState.SocialNetworksLocked)
		{
			goto IL_009b;
		}
		if ((nint)obj21 != 1)
		{
			if ((nint)obj21 == 2)
			{
				goto IL_009b;
			}
			if ((nint)obj21 != 3)
			{
				if ((nint)obj21 != 4)
				{
					if ((nint)obj21 == 5)
					{
						nint num = (nint)typeof(AwardCellHelper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v249 (Il2CppClass<UI.AwardCellHelper>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						if (obj22 != null)
						{
							nint num2 = (nint)typeof(AwardCellHelper);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S1_v274 (Il2CppClass<UI.AwardCellHelper>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj20 = COMPLETE_SEGMENT_BACKGROUND_COLOR;
						obj12 = obj20;
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj12;
						Matrix4x4 matrix4x = Matrix4x4.Inverse((Matrix4x4)pivot);
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						_ = 0;
						_cellBackground.rawPivot = pivot;
						obj4 = COMPLETED_TITLE_TEXT_COLOR;
						obj13 = obj4;
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj13;
						Matrix4x4 matrix4x2 = Matrix4x4.Inverse((Matrix4x4)pivot);
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
						_ = 0;
						_missionTitle.rawPivot = pivot;
						obj7 = COMPLETED_TITLE_TEXT_SHADOW_COLOR;
						obj14 = obj7;
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj14;
						Matrix4x4 matrix4x3 = Matrix4x4.Inverse((Matrix4x4)pivot);
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						_ = 0;
						Vector2 effectDistance = ((UILabel)pivot).effectDistance;
					}
				}
				else
				{
					nint num3 = (nint)typeof(AwardCellHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v217 (Il2CppClass<UI.AwardCellHelper>)+BA]");
					object obj23 = (nint)0 & (nint)0x200;
					if (obj23 != null)
					{
						nint num4 = (nint)typeof(AwardCellHelper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S1_v242 (Il2CppClass<UI.AwardCellHelper>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj20 = COMPLETE_SEGMENT_BACKGROUND_COLOR;
					obj15 = obj20;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj15;
					Matrix4x4 matrix4x4 = Matrix4x4.Inverse((Matrix4x4)pivot);
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					_cellBackground.rawPivot = pivot;
					obj4 = COMPLETED_TITLE_TEXT_COLOR;
					obj16 = obj4;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj16;
					Matrix4x4 matrix4x5 = Matrix4x4.Inverse((Matrix4x4)pivot);
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					_ = 0;
					_missionTitle.rawPivot = pivot;
					obj7 = COMPLETED_TITLE_TEXT_SHADOW_COLOR;
					obj17 = obj7;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj17;
					Matrix4x4 matrix4x6 = Matrix4x4.Inverse((Matrix4x4)pivot);
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Vector2 effectDistance2 = ((UILabel)pivot).effectDistance;
				}
				goto IL_04e7;
			}
		}
		nint num5 = (nint)typeof(AwardCellHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v185 (Il2CppClass<UI.AwardCellHelper>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num6 = (nint)typeof(AwardCellHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v210 (Il2CppClass<UI.AwardCellHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj20 = COLLECTIBLE_SEGMENT_BACKGROUND_COLOR;
		obj3 = obj20;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Matrix4x4 matrix4x7 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		_cellBackground.rawPivot = pivot;
		obj4 = ACTIVE_TITLE_TEXT_COLOR;
		obj6 = obj4;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
		Matrix4x4 matrix4x8 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		_missionTitle.rawPivot = pivot;
		obj7 = ACTIVE_TITLE_TEXT_SHADOW_COLOR;
		obj8 = obj7;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
		Matrix4x4 matrix4x9 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector2 effectDistance3 = ((UILabel)pivot).effectDistance;
		goto IL_04e7;
		IL_009b:
		nint num7 = (nint)typeof(AwardCellHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v153 (Il2CppClass<UI.AwardCellHelper>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num8 = (nint)typeof(AwardCellHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v178 (Il2CppClass<UI.AwardCellHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj20 = PROGRESS_SEGMENT_BACKGROUND_COLOR;
		obj9 = obj20;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
		Matrix4x4 matrix4x10 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		_cellBackground.rawPivot = pivot;
		obj4 = ACTIVE_TITLE_TEXT_COLOR;
		obj10 = obj4;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj10;
		Matrix4x4 matrix4x11 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		_missionTitle.rawPivot = pivot;
		obj7 = ACTIVE_TITLE_TEXT_SHADOW_COLOR;
		obj11 = obj7;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj11;
		Matrix4x4 matrix4x12 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector2 effectDistance4 = ((UILabel)pivot).effectDistance;
		goto IL_04e7;
		IL_04e7:
		if (_currentCellState == AwardCellState.Collectible)
		{
			nint num9 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S1_v135 (Il2CppClass<GlobalColors>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num10 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S1_v146 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj20 = GlobalColors.AWARDS_COLLECTIBLE_STICKER_COLOR;
			obj18 = obj20;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj18;
			Matrix4x4 matrix4x13 = Matrix4x4.Inverse((Matrix4x4)pivot);
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			_stickerSprite.rawPivot = pivot;
		}
		else if (_currentAward.activeTierType != AwardTierType.None)
		{
			nint num11 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ S1_v117 (Il2CppClass<GlobalColors>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num12 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ S1_v128 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj20 = GlobalColors.AWARDS_NEW_STICKER_COLOR;
			obj19 = obj20;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj19;
			Matrix4x4 matrix4x14 = Matrix4x4.Inverse((Matrix4x4)pivot);
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			_stickerSprite.rawPivot = pivot;
		}
		object obj28 = obj2 + 100;
		object obj29 = obj2 + 96;
		object obj30 = obj2 + 92;
		object obj31 = obj2 + 88;
		object obj32 = obj2 + 84;
		object obj33 = obj2 + 80;
		UIWidget progressIconsBG;
		if (_currentCellState == AwardCellState.PreviewFinished)
		{
			nint num13 = (nint)typeof(AwardCellHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ S1_v90 (Il2CppClass<UI.AwardCellHelper>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num14 = (nint)typeof(AwardCellHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ S1_v109 (Il2CppClass<UI.AwardCellHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj20 = REWARD_BIG_BACKGROUND_FINISHED_COLOR;
			obj28 = obj20;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj28;
			Matrix4x4 matrix4x15 = Matrix4x4.Inverse((Matrix4x4)pivot);
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			_rewardBigBG.rawPivot = pivot;
			obj4 = REWARD_BIG_BACKGROUND_FINISHED_COLOR;
			obj29 = obj4;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj29;
			progressIconsBG = _progressIconsBG;
		}
		else
		{
			nint num15 = (nint)typeof(AwardCellHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ S0_v78 (Il2CppClass<UI.AwardCellHelper>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			bool flag = obj35 == null;
			if (_currentCellState == AwardCellState.Collectible)
			{
				if (!flag)
				{
					nint num16 = (nint)typeof(AwardCellHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ S0_v121 (Il2CppClass<UI.AwardCellHelper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj20 = REWARD_BIG_BACKGROUND_COLLECTIBLE_COLOR;
				obj30 = obj20;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj30;
				Matrix4x4 matrix4x16 = Matrix4x4.Inverse((Matrix4x4)pivot);
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				_rewardBigBG.rawPivot = pivot;
				obj4 = REWARD_BIG_BACKGROUND_COLLECTIBLE_COLOR;
				obj31 = obj4;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj31;
				progressIconsBG = _progressIconsBG;
			}
			else
			{
				if (!flag)
				{
					nint num17 = (nint)typeof(AwardCellHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ S0_v100 (Il2CppClass<UI.AwardCellHelper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj20 = REWARD_BIG_BACKGROUND_IN_PROGRESS_COLOR;
				obj32 = obj20;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj32;
				Matrix4x4 matrix4x17 = Matrix4x4.Inverse((Matrix4x4)pivot);
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				_rewardBigBG.rawPivot = pivot;
				obj4 = REWARD_BIG_BACKGROUND_IN_PROGRESS_COLOR;
				obj33 = obj4;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj33;
				progressIconsBG = _progressIconsBG;
			}
		}
		Matrix4x4 matrix4x18 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		progressIconsBG.rawPivot = pivot;
	}

	public void FacebookLoginClicked()
	{
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_0477: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 12;
		Award currentAward = _currentAward;
		AwardStaticData awardData = currentAward._awardData;
		obj = awardData.id__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private IEnumerator AnimateChangingOfTierSprite(UISprite effectSprite, AwardTierHelper tierIconToChange)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		if ((nint)effectSprite.leftAnchor <= 9)
		{
			return null;
		}
		object obj = effectSprite + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = effectSprite + 16;
		throw new ArrayTypeMismatchException();
	}

	private IEnumerator AnimateEffectColor(UISprite spriteToAnimate, Color color1, Color color2, float speedFactor = 1f)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got F4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = spriteToAnimate;
		object obj3 = default;
		object obj2 = obj3 + 4;
		obj2 = color1.r;
		object obj4 = obj3 + 8;
		obj4 = obj2;
		obj3 = color2.r;
		obj4 = obj3;
		return enumerator;
	}

	private void SetFBLoginButtonToNormalState()
	{
		_awardsScreen.OnFailSlideInFinish();
		this._002Ector();
	}

	private unsafe void SetFBLoginButtonToConnectingState()
	{
		//IL_006f: Expected Obj, but got I4
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d3: Expected Obj, but got VT
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected VT, but got Unknown
		//IL_0104: Expected F4, but got Obj
		//IL_00ff: Expected native int or pointer, but got VT
		//IL_011e: Expected F4, but got Obj
		//IL_0119: Expected native int or pointer, but got VT
		//IL_0133: Expected F4, but got I
		//IL_012e: Expected native int or pointer, but got VT
		//IL_0142: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		_loginButtonContents.tag = (string)1;
		_connectingButtonContents.tag = null;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v6 (Il2CppClass<GlobalColors>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v22 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 20;
		obj2 = GlobalColors.PRIMARY_ACTION_COLOR;
		object obj4 = obj3 + 16;
		obj4 = obj2;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 24);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_loginFBButtonFill.rawPivot = (UIWidget.Pivot)matrix4x;
		_loginCollider.isTrigger = true;
		((RewardForVideoButton)(object)_loginContentLayout).Init((VideoButtonPayload)null);
	}

	public unsafe AwardCellHelper()
	{
		//IL_007b: Expected Obj, but got I4
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d3: Expected Obj, but got VT
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected VT, but got Unknown
		//IL_0104: Expected F4, but got Obj
		//IL_00ff: Expected native int or pointer, but got VT
		//IL_011e: Expected F4, but got Obj
		//IL_0119: Expected native int or pointer, but got VT
		//IL_0133: Expected F4, but got I
		//IL_012e: Expected native int or pointer, but got VT
		//IL_0142: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		_loginButtonContents.tag = null;
		_connectingButtonContents.tag = (string)1;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v6 (Il2CppClass<GlobalColors>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v22 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 20;
		obj2 = GlobalColors.SOCIAL_GREY;
		object obj4 = obj3 + 16;
		obj4 = obj2;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 24);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_loginFBButtonFill.rawPivot = (UIWidget.Pivot)matrix4x;
		_loginCollider.isTrigger = false;
		((RewardForVideoButton)(object)_connectingContentsLayout).Init((VideoButtonPayload)null);
	}

	unsafe static AwardCellHelper()
	{
		//IL_00b2: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got F4
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected VT, but got Unknown
		//IL_01f4: Expected F4, but got Obj
		//IL_01ef: Expected native int or pointer, but got VT
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_021d: Expected I, but got Obj
		//IL_022a: Expected F4, but got Obj
		//IL_0225: Expected native int or pointer, but got VT
		//IL_023f: Expected F4, but got I
		//IL_023a: Expected native int or pointer, but got VT
		//IL_0255: Expected Obj, but got I
		//IL_0262: Expected Obj, but got F4
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0283: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got F4
		//IL_02ac: Expected I, but got Obj
		//IL_02b9: Expected F4, but got Obj
		//IL_02b4: Expected native int or pointer, but got VT
		//IL_02ce: Expected F4, but got I
		//IL_02c9: Expected native int or pointer, but got VT
		//IL_02e4: Expected Obj, but got I
		//IL_02f1: Expected Obj, but got F4
		//IL_0309: Expected I, but got Obj
		//IL_031f: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0126: Expected F4, but got Obj
		//IL_0121: Expected native int or pointer, but got VT
		//IL_013b: Expected F4, but got I
		//IL_0136: Expected native int or pointer, but got VT
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0169: Expected I, but got Obj
		//IL_0176: Expected F4, but got Obj
		//IL_0171: Expected native int or pointer, but got VT
		//IL_018b: Expected F4, but got I
		//IL_0186: Expected native int or pointer, but got VT
		//IL_01a1: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		WeeklyHuntManager._hasInited = false;
		object obj = 0;
		obj = -3f;
		_ = 9.2f;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v15 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v65 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = obj + 8;
		obj3 = obj;
		Vector4 vector = (Vector4)(obj - -64);
		((Vector4*)(nint)vector)->x = (float)obj3;
		object obj4 = obj + 52;
		Vector3 vector2 = vector;
		nint num3 = (nint)typeof(WeeklyHuntManager);
		((Vector4*)(nint)vector)->x = (float)obj4;
		Vector4 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v24+8]");
		((Vector4*)(nint)vector3)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v26 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+5C]");
		object obj5 = (nint)0 + (nint)8;
		obj5 = vector.x;
		_ = vector.z;
		object obj6 = obj + 40;
		obj6 = 0;
		_ = 0;
		obj6 = 0f;
		_ = 28f;
		_ = -8f;
		nint num4 = (nint)typeof(WeeklyHuntManager);
		((Vector4*)(nint)vector)->x = (float)obj6;
		Vector4 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v31+8]");
		((Vector4*)(nint)vector4)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v37 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+5C]");
		object obj7 = (nint)0 + (nint)20;
		obj7 = vector.x;
		_ = vector.z;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v42 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v61 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = obj + 28;
		Vector3 forward = Vector3.forward;
		((Vector4*)(nint)vector)->x = (float)obj9;
		Vector4 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v47+8]");
		((Vector4*)(nint)vector5)->z = 0f;
		object obj10 = obj + 16;
		Vector3 vector6 = (Vector3)vector / 0.8f;
		nint num7 = (nint)typeof(WeeklyHuntManager);
		((Vector4*)(nint)vector)->x = (float)obj10;
		Vector4 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v51+8]");
		((Vector4*)(nint)vector7)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v53 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+5C]");
		object obj11 = (nint)0 + (nint)32;
		obj11 = vector.x;
		_ = vector.z;
		WeeklyHuntManager.canCollectAllTokensInOneRun = false;
	}
}
