using System;
using Cpp2ILInjected;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Info;
using SYBO.Subway.Promotion;
using UI.Generic;
using UI.Generic.Layout;
using UI.ModelCamera;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class CharacterPromotionPopup : UIScreen
{
	private GameObject _topAnchor;

	private UILabel _popupCharacterTitle;

	private UILabel _popupCharacterSubTitle;

	private UITexture _popupStickerTexture;

	private TimerHelper _timerPrefab;

	private Transform _timerContainer;

	private Layout _timerLayout;

	private TimerHelper _timer;

	private CharacterSelectButton _characterSelectButtonPrefab;

	private Transform _characterSelectButtonParent;

	private CharacterSelectButton _characterSelectButton;

	private UISprite backgroundSprite;

	private UISprite flashSprite;

	private CharacterPromotion characterPromotion;

	private const int CharacterSelectButtonWidth = 135;

	private const int CharacterSelectButtonHeight = 50;

	public override void Init()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got F4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		object obj = 0;
		_ = 0;
		obj = -2f;
		_ = -65f;
		_ = 920f;
		object obj2 = obj + 12;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj3 = this + 40;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
		_ = 0;
		((UpgradeScreen)this).Start();
	}

	private unsafe void OnCharacterPurchaseSuccess(Characters.CharacterId characterId, int themeId)
	{
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0228: Expected I, but got Obj
		//IL_023e: Expected Obj, but got I
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Ref, but got Unknown
		//IL_033c: Expected Obj, but got VT
		//IL_012b: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_00de: Expected I, but got Obj
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_03b5: Expected F4, but got Obj
		//IL_03b5: Expected VT, but got Obj
		//IL_03e3: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I
		//IL_01da: Expected I4, but got Obj
		//IL_01da: Expected I4, but got Obj
		//IL_016c: Expected I, but got Obj
		object obj = this + 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E19");
		object obj2 = default;
		obj = obj2;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 48;
		GameObject gameObject = UnityEngine.Object.Instantiate(_topAnchor);
		obj4 = gameObject;
		int layer = ((GameObject)(object)_popupCharacterSubTitle).layer;
		object obj6 = default;
		object obj5 = obj6 + 52;
		object obj7 = this + 12;
		obj5 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S2_v5+8]");
		_ = 0;
		Transform transform = (Transform)(obj6 - -64);
		transform = (Transform)obj5;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v12+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		int layer2 = ((GameObject)(object)_popupCharacterSubTitle).layer;
		object obj8 = obj6 + 40;
		object obj9 = this + 24;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S2_v17+8]");
		_ = 0;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v23 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v58 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform = (Transform)obj8;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v20+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		ref Quaternion reference = ref *(Quaternion*)(obj6 + 24);
		Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)transform);
		transform = (Transform)reference;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v30 (UnityEngine.Quaternion&)+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		int layer3 = ((GameObject)(object)_popupCharacterSubTitle).layer;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v36 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v54 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj12 = obj6 + 12;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj12;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v41+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 vector = (Vector3)transform / (float)base.parentScreen__BackingField;
		transform = (Transform)obj6;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		((Transform)layer3).parent = transform;
		((Component)(nint)((UnityEngine.Object)this).m_CachedPtr).tag = (string)1;
		GameObject gameObject2 = ((UIModelController)(object)_popupStickerTexture).ShowCharacterInCelebration((Characters.CharacterId)_popupCharacterSubTitle, (int)_popupCharacterTitle, (UIModelController.ModelScreen)characterId, (byte)themeId != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public unsafe override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_04fd: Expected I, but got Obj
		//IL_0513: Expected Obj, but got I
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected Obj, but got Unknown
		//IL_054d: Expected Obj, but got I4
		//IL_0567: Expected I, but got Obj
		//IL_057d: Expected Obj, but got I
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected I4, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_016d: Expected I4, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0366: Expected Obj, but got I4
		//IL_0422: Expected Obj, but got I
		//IL_0207: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_0248: Expected I, but got Obj
		//IL_02cf: Expected Obj, but got I4
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_02b7: Expected Obj, but got I4
		//IL_02fd: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 16;
		obj3 = obj;
		_ = -1;
		ShowIfInactive();
		nint num = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v146 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 92;
		bool flag = UIScreen.IsScreenHeightOutOfProportion();
		CharacterPromotion characterPromotion = ((PromotionManager)flag).TryGetCurrentPromotion<CharacterPromotion>();
		obj5 = characterPromotion;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v97 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 24);
		if (this.characterPromotion != null)
		{
			nint num5 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v136 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v142 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogException((Exception)(object)"Current Promotion is not a character promotion.");
			return;
		}
		object obj8 = this.characterPromotion + 44;
		obj2 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v9+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		backgroundSprite.rawPivot = pivot;
		GameObject gameObject = backgroundSprite.gameObject;
		object current = ((Transform.Enumerator)(object)gameObject).Current;
		object obj9 = default;
		object obj11 = default;
		object obj14 = default;
		object obj15 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v107 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v128 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj12;
				if (obj11 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj12 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj12 = 0;
				}
				object obj13 = obj12 & 1;
				if (obj13 == null)
				{
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				if (obj14 == obj15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				break;
			}
			object obj16 = obj3 + 4;
			object obj17 = obj16 + 1;
			obj16 = obj17;
			object obj18 = obj17 << 2;
			object obj19 = obj3 + obj18;
			obj19 = 182;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
			object obj21 = (nint)0 << 2;
			object obj22 = obj3 + obj21;
			if ((nint)obj22 == 182)
			{
				object obj23 = obj3 + 4;
				if ((nint)obj23 > -1)
				{
					object obj24 = obj23 + -1;
					obj23 = obj24;
				}
				goto IL_062a;
			}
		}
		object obj25 = default;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_062a;
		IL_062a:
		InitializeTimer();
		SetupTop();
		OnCloseClicked();
	}

	public unsafe override void GainFocus()
	{
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01b3: Expected I, but got Obj
		//IL_01c9: Expected Obj, but got I
		//IL_01fd: Expected I, but got Obj
		//IL_0213: Expected Obj, but got I
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		//IL_00cc: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_015b: Expected I4, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I4
		base.Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<Characters.CharacterId, int> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v41 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreenManager.characterUnlocked -= action;
		nint num4 = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v37 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreen.IsScreenHeightOutOfProportion();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(PromotionManager.OnPromotionPurchaseFailed);
		object obj4 = action2 + 16;
		obj4 = flag;
		CharacterScreenManager.characterUnlockedFailure -= action2;
		bool isInstanced = UIScreenController.IsInstanced;
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S2_v2 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIModelController.ModelScreen screen;
		if (characterPromotion != null)
		{
			screen = UIModelController.ModelScreen.Character;
		}
		else
		{
			AnimationClip[] characterAnimations = characterPromotion.CharacterAnimations;
			screen = (UIModelController.ModelScreen)characterAnimations;
		}
		((UIModelController)isInstanced).SetupModelScreen(screen, (ModelScreenSetup)null, (ModelScreenData)15);
	}

	public override void LoseFocus()
	{
		//IL_00bc: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_0077: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		bool isInstanced = UIScreenController.IsInstanced;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIModelController.ModelScreen screen;
		if (characterPromotion != null)
		{
			screen = UIModelController.ModelScreen.Character;
		}
		else
		{
			AnimationClip[] characterAnimations = characterPromotion.CharacterAnimations;
			screen = (UIModelController.ModelScreen)characterAnimations;
		}
		((UIModelController)isInstanced).SetupModelScreen(screen, (ModelScreenSetup)null, (ModelScreenData)15);
		_characterSelectButton.SetSticker(CharacterSelectButton.StickerType.Gift);
	}

	public override void Hide()
	{
		//IL_0017: Expected Obj, but got I4
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.CharacterPromotionPopup);
	}

	private unsafe void InitializeSelectButton()
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_010f: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I
		//IL_0159: Expected I, but got Obj
		//IL_016f: Expected Obj, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CharacterPromotionPopup.OnCharacterPurchaseSuccess);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v41 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreenManager.characterUnlockedFailure += action;
		nint num3 = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v37 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreen.IsScreenHeightOutOfProportion();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(PromotionManager.OnPromotionPurchaseFailed);
		object obj4 = action2 + 16;
		obj4 = flag;
		CharacterScreenManager.onCharacterSelected += action2;
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.CharacterPromotionPopup);
	}

	private void InitializeTimer()
	{
		//IL_00f2: Expected I, but got Obj
		//IL_0108: Expected Obj, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_01c0: Expected I, but got Obj
		//IL_01d6: Expected Obj, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 80;
		CharacterSelectButton characterSelectButton = UnityEngine.Object.Instantiate(_characterSelectButtonPrefab, _characterSelectButtonParent);
		obj2 = characterSelectButton;
		GameObject gameObject = _characterSelectButton.gameObject;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v25 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj4 = default;
		Transform transform = (Transform)(obj4 + 12);
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		_characterSelectButton.SetSticker(CharacterSelectButton.StickerType.Gift);
		UIWidget component = _characterSelectButton.GetComponent<UIWidget>();
		component.height = 135;
		UIWidget component2 = _characterSelectButton.GetComponent<UIWidget>();
		Color color = ((UIWidget)50).color;
	}

	private unsafe void SetupTop()
	{
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0233: Expected I, but got Obj
		//IL_0249: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got VT
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected VT, but got Unknown
		//IL_0139: Expected F4, but got Obj
		//IL_0134: Expected native int or pointer, but got VT
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got VT
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_018e: Expected F4, but got Obj
		//IL_0189: Expected native int or pointer, but got VT
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected I4, but got Unknown
		//IL_01b6: Expected I4, but got Obj
		//IL_01d0: Expected F4, but got Obj
		//IL_01cb: Expected native int or pointer, but got VT
		//IL_01e5: Expected F4, but got I
		//IL_01e0: Expected native int or pointer, but got VT
		//IL_01f8: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 68;
		TimerHelper timerHelper = UnityEngine.Object.Instantiate(_timerPrefab, _timerContainer);
		obj2 = timerHelper;
		nint num3 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v8 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v33 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 44;
		obj4 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_TEXT;
		object obj6 = obj5 + 40;
		obj6 = obj4;
		Matrix4x4 matrix4x = (Matrix4x4)(obj5 - -64);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		object obj7 = obj5 + 24;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		object obj8 = obj5 + 20;
		obj8 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_BG;
		object obj9 = obj5 + 16;
		obj9 = obj8;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		bool flag = (byte)(obj5 + 48) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj7 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v19+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_timer.AnimateClock(flag, (byte)(int)matrix4x != 0);
		_timer.SetTimerText((string)1);
	}

	public void OnCloseClicked()
	{
		//IL_0272: Expected I, but got Obj
		//IL_0288: Expected Obj, but got I
		//IL_02c1: Expected I4, but got Obj
		//IL_006e: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00c0: Expected Obj, but got VT
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got VT
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_00fc: Expected Obj, but got I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_018e: Expected Obj, but got VT
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got VT
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01ca: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v63 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string key = default;
		string text = Strings.GetDefault(key);
		_popupCharacterTitle.fontSize = (int)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string key2 = default;
		string text2 = Strings.GetDefault(key2);
		_popupCharacterSubTitle.fontSize = (int)text2;
		CharacterPromotion characterPromotion = this.characterPromotion;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		GameObject gameObject = _popupStickerTexture.gameObject;
		object obj3 = default;
		object obj2 = obj3 + 72;
		CharacterPromotion characterPromotion2 = this.characterPromotion;
		obj2 = characterPromotion2._stickerPosition;
		object obj4 = obj3 - -64;
		CharacterPromotion characterPromotion3 = this.characterPromotion;
		obj4 = characterPromotion3._stickerPosition;
		object obj5 = obj3 + 48;
		obj5 = 0;
		_ = 0;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v17+4]");
		_ = 0;
		_ = 0f;
		Transform transform = (Transform)(obj3 + 8);
		transform = (Transform)obj5;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v21+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject2 = _popupStickerTexture.gameObject;
		object obj6 = obj3 + 40;
		CharacterPromotion characterPromotion4 = this.characterPromotion;
		obj6 = characterPromotion4._stickerScale;
		object obj7 = obj3 + 32;
		CharacterPromotion characterPromotion5 = this.characterPromotion;
		obj7 = characterPromotion5._stickerScale;
		object obj8 = obj3 + 20;
		obj8 = 0;
		_ = 0;
		obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v36+4]");
		_ = 0;
		_ = 0f;
		transform = (Transform)obj8;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v40+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject2).parent = transform;
		long elapsedMilliseconds = ((FramerateTracker)(object)this.characterPromotion).ElapsedMilliseconds;
		obj3 = elapsedMilliseconds;
		transform = (Transform)obj3;
		throw new ArrayTypeMismatchException();
	}

	public CharacterPromotionPopup()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)screenName);
	}
}
