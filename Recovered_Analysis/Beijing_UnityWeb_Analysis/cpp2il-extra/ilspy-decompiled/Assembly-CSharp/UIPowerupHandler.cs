using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Extensions;
using SYBO.Subway;
using SYBO.Subway.Info;
using UI.ModelCamera;
using UnityEngine;

public class UIPowerupHandler : MonoBehaviour
{
	public GameObject PowerupPrefab;

	private int _screenOffset;

	private int _bottomOffset;

	private List<UIPowerupHelper> _powerupSlots;

	private bool _isPowerupButtonsShowing;

	private const int MAX_SHOWABLE_PROGRESS_BARS = 8;

	private int previousSlotAmountLastFrame;

	private void Start()
	{
		_screenOffset = 2;
		CancelInvoke();
	}

	private unsafe void OnDestroy()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		SetPowerupSlotPosition(8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(UIPowerupHandler.HandleSlideInPowerUpShow);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SlideinPowerupHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<SlideinPowerupHelper>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v25 (Il2CppClass<SlideinPowerupHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SlideinPowerupHelper.OnButtonsShow -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(UIPowerupHandler.HandleSlideInPowerUpHide);
		object obj3 = action2 + 16;
		obj3 = this;
		SlideinPowerupHelper.OnButtonsHide -= action2;
	}

	private unsafe void HandleSlideInPowerUpShow()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(UIPowerupHandler.HandleSlideInPowerUpShow);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SlideinPowerupHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SlideinPowerupHelper>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v24 (Il2CppClass<SlideinPowerupHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SlideinPowerupHelper.OnButtonsHide += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		SlideinPowerupHelper slideinPowerupHelper = default;
		((UnityEngine.Object)slideinPowerupHelper).m_CachedPtr = cachedPtr;
		slideinPowerupHelper.powerup1AmountLabel = (UILabel)0;
		object obj3 = slideinPowerupHelper + 16;
		obj3 = this;
		slideinPowerupHelper.Start();
	}

	private void HandleSlideInPowerUpHide()
	{
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		object obj2 = (isInstantiated ? 1 : 0) - -64;
		if (obj2 != null)
		{
			return;
		}
		_isPowerupButtonsShowing = true;
		this._002Ector();
		ActivePowerup activePowerup = null;
		while (true)
		{
			List<UIPowerupHelper> powerupSlots = _powerupSlots;
			if ((nint)activePowerup < powerupSlots._size)
			{
				((UIPowerupHelper)this).SetPowerupSlot(activePowerup);
				ActivePowerup activePowerup2 = (ActivePowerup)(activePowerup + 1);
				activePowerup = activePowerup2;
				continue;
			}
			break;
		}
	}

	private void Update()
	{
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		object obj2 = (isInstantiated ? 1 : 0) - -64;
		if (obj2 != null)
		{
			return;
		}
		_isPowerupButtonsShowing = false;
		this._002Ector();
		ActivePowerup activePowerup = null;
		while (true)
		{
			List<UIPowerupHelper> powerupSlots = _powerupSlots;
			if ((nint)activePowerup < powerupSlots._size)
			{
				((UIPowerupHelper)this).SetPowerupSlot(activePowerup);
				ActivePowerup activePowerup2 = (ActivePowerup)(activePowerup + 1);
				activePowerup = activePowerup2;
				continue;
			}
			break;
		}
	}

	private void DisablePowerupSlot(UIPowerupHelper slot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0394: Expected Obj, but got I
		//IL_03a4: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_003b: Expected I4, but got Obj
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I4
		//IL_0028: Expected I4, but got Obj
		//IL_0028: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_0211: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got I
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0185: Expected I, but got Obj
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
		object obj5 = 0;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
		object obj8 = default;
		if ((nint)obj8 > -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHandler)+58]");
			bool flag = ((Dictionary<UIModelController.ModelScreen, ModelScreenData>)0).Remove((UIModelController.ModelScreen)slot);
		}
		int numberOfSpaces = getNumberOfSpaces((int)slot);
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v114 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)numberOfSpaces))
		{
			return;
		}
		int layer = ((GameObject)numberOfSpaces).layer;
		object current = ((Transform.Enumerator)layer).Current;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v98 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v107 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj12 = obj2 + 4;
		object obj13 = obj12 + 1;
		obj12 = obj13;
		object obj14 = obj13 << 2;
		object obj15 = obj2 + obj14;
		obj15 = 105;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj2 + obj17;
			if ((nint)obj18 == 105)
			{
				object obj19 = obj2 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				return;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void SetPowerupSlotContent(ActivePowerup powerup, int i)
	{
		//IL_0268: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02b9: Expected I, but got Obj
		//IL_02cf: Expected Obj, but got I
		//IL_02f6: Expected Obj, but got I4
		//IL_00f8: Expected I, but got Obj
		//IL_0292: Expected Obj, but got I4
		//IL_0145: Expected I, but got Obj
		//IL_0087: Expected I, but got Obj
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_0340: Expected I, but got Obj
		//IL_0356: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I
		//IL_01d3: Expected I, but got Obj
		//IL_0220: Expected I, but got Obj
		PlayerSave.currentBoardId = (Boards.BoardId)powerup;
		PlayerSave.currentCharacterId = (Characters.CharacterId)i;
		IngameScreen ingameScreen = ((UIPowerupHelper)null).ingameScreen;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		if ((object)ingameScreen != null)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v58 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			((Game)isInstantiated).StartNewGame();
		}
		else
		{
			if (!flag)
			{
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v49 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated2 = Game.IsInstantiated;
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)isInstantiated2).FindKernel(null) != 0)
			{
				nint num6 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(Characters);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v43 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
				Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)currentBoardId);
				nint num8 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v31 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num9 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v39 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated3 = Game.IsInstantiated;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v36 (System.Boolean)+88]");
				object obj5 = 0;
				Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v37+BC]");
				((CharacterModel)0).SetCharacterModel(model.modelName, (int)currentCharacterId, useSpecialAsset: false, deleteSpecialAsset: true);
			}
		}
		TransformExtensions.Reset((Transform)(object)UIModelController.OnChangedCurrentlyShownCharacter);
	}

	private void InstantiatePowerupSlots(int amount)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		string text = ((Component)amount).tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 != null)
		{
			((UIPowerupHelper)amount)._002Ector();
			string text3 = ((Component)amount).tag;
			((GameObject)(object)text3).tag = null;
		}
	}

	private void SetPowerupSlotPosition(int i)
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_014c: Expected I4, but got Obj
		//IL_0159: Expected Obj, but got I4
		//IL_005e: Expected I, but got Obj
		//IL_0189: Expected I4, but got Obj
		//IL_0193: Expected Obj, but got I4
		int num = 0;
		while (num < i)
		{
			string go = tag;
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v3 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v17 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num4 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)PowerupPrefab != 0);
			_0021_00210 componentInChildren = (_0021_00210)((GameObject)num4).GetComponentInChildren<T>();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			UIPowerupHelper uIPowerupHelper = _powerupSlots.get_Item(num);
			UIAnchor component = uIPowerupHelper.GetComponent<UIAnchor>();
			if ((num & 1) != 0)
			{
				component.side = UIAnchor.Side.BottomRight;
			}
			else
			{
				component.side = UIAnchor.Side.BottomLeft;
			}
			UIPowerupHelper uIPowerupHelper2 = _powerupSlots.get_Item(num);
			((UIPowerupHandler)null).InstantiatePowerupSlots((int)uIPowerupHelper2);
			((UIPowerupHelper)this).SetPowerupSlot((ActivePowerup)num);
			int num5 = num + 1;
			num = num5;
		}
	}

	private void ReanchorPowerupSlots()
	{
		//IL_00f6: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I4
		//IL_00bd: Expected I4, but got Obj
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.String)+94]");
		List<ActivePowerup> list = (List<ActivePowerup>)0;
		int num = list._size;
		if (list._size >= 8)
		{
			num = 8;
		}
		int num2 = 0;
		int num3 = default;
		int num5 = default;
		while (num3 < num)
		{
			ActivePowerup sender = list.get_Item(num3);
			((UIScreenController)this).PushScreen((GameObject)(object)sender, (string)num3);
			int num4 = num2 + 1;
			num3 = num5 + 1;
			num2 = num4;
		}
		if (previousSlotAmountLastFrame == num2)
		{
			return;
		}
		previousSlotAmountLastFrame = num2;
		while (true)
		{
			List<UIPowerupHelper> powerupSlots = _powerupSlots;
			if (num2 < powerupSlots._size)
			{
				UIPowerupHelper uIPowerupHelper = _powerupSlots.get_Item(num2);
				((UIPowerupHandler)null).InstantiatePowerupSlots((int)uIPowerupHelper);
				int num6 = num2 + 1;
				num2 = num6;
				continue;
			}
			break;
		}
	}

	public float getSliderHights(int i, int slotPosition)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	public int getNumberOfSpaces(int i)
	{
		//IL_01df: Expected I4, but got Obj
		//IL_01fd: Expected I4, but got Obj
		//IL_0272: Expected I4, but got Obj
		//IL_0221: Expected I4, but got Obj
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_0263: Expected I4, but got Obj
		switch (i)
		{
		case 0:
		case 4:
		case 13:
			return (int)PowerupPrefab;
		case 1:
			return _screenOffset;
		case 2:
			return (int)_powerupSlots;
		case 15:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHandler)+30]");
			return 0;
		case 5:
		case 6:
		case 7:
		case 9:
			return (int)_powerupSlots;
		case 10:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHandler)+38]");
			return 0;
		case 11:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPowerupHandler)+3C]");
			return 0;
		case 12:
		{
			object obj = this - -64;
			return (int)obj;
		}
		default:
			return (int)PowerupPrefab;
		}
	}

	public UIPowerupHandler()
	{
		int num = 0;
		while (true)
		{
			List<UIPowerupHelper> powerupSlots = _powerupSlots;
			if (num < powerupSlots._size)
			{
				UIPowerupHelper uIPowerupHelper = _powerupSlots.get_Item(num);
				UIAnchor component = uIPowerupHelper.GetComponent<UIAnchor>();
				if ((num & 1) != 0)
				{
					component.side = UIAnchor.Side.BottomRight;
				}
				else
				{
					component.side = UIAnchor.Side.BottomLeft;
				}
				if (~(_isPowerupButtonsShowing ? 1u : 0u) == 0)
				{
					UIPowerupHelper uIPowerupHelper2 = _powerupSlots.get_Item(num);
					UIAnchor component2 = uIPowerupHelper2.GetComponent<UIAnchor>();
					component2.side = UIAnchor.Side.BottomRight;
				}
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}
}
