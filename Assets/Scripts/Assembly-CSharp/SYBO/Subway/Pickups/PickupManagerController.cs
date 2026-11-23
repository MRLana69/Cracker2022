using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Common.Exceptions;
using SYBO.Subway.Characters;
using SYBO.Subway.Pickups.Picker.Pickers;
using SYBO.Subway.Pickups.Pickers;
using UnityEngine;

namespace SYBO.Subway.Pickups;

public class PickupManagerController
{
	private sealed class _003CRewardDailyLetterCoroutine_003Ed__16(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					DailyLetterPickupManager instance = DailyLetterPickupManager.Instance;
					instance.UpdateLetter();
				}
				return false;
			}
			_003C_003E1__state = -1;
			GameStats instance2 = GameStats.Instance;
			instance2.AddScoreForPickup(PowerupType.letters);
			PlayerInfo instance3 = PlayerInfo.Instance;
			DailyLetterPickupManager instance4 = DailyLetterPickupManager.Instance;
			instance3.PickedupLetter(instance4.letter);
			GameStats instance5 = GameStats.Instance;
			instance5.DailyLetterPickupsCollectedIncrement();
			_ = 2f;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
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

	private PickupManager _pickupManager;

	private List<Action> _refreshEventSpecificPickupsFunctions;

	public PickupManagerController(PickupManager pickupManager)
	{
		List<Action> list = default;
		list._002Ector();
		_refreshEventSpecificPickupsFunctions = list;
		_pickupManager = pickupManager;
		throw new ArgumentException();
	}

	public void Destroy()
	{
		if (_pickupManager != null)
		{
			throw new ArgumentException();
		}
	}

	public void Update()
	{
		RefreshEventSpecificPickups();
	}

	private unsafe void SetupEventSpecificPickups()
	{
		List<Action> list = default;
		list._002Ector();
		_refreshEventSpecificPickupsFunctions = list;
		PickupData pickupDataForPickupType = _pickupManager.GetPickupDataForPickupType(PickupType.LetterHuntDaily);
		PickupData pickupDataForPickupType2 = _pickupManager.GetPickupDataForPickupType(PickupType.LetterHuntCharacter);
		PickupData pickupDataForPickupType3 = _pickupManager.GetPickupDataForPickupType(PickupType.MysteryPowerup);
		PickupData pickupDataForPickupType4 = _pickupManager.GetPickupDataForPickupType(PickupType.SuperMysteryBox);
		PickupData pickupDataForPickupType5 = _pickupManager.GetPickupDataForPickupType(PickupType.TokenHunt);
		if (pickupDataForPickupType != null && pickupDataForPickupType._pickupEnabledState == PickupEnabledState.SetProgrammatically)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(PickupManagerController.RefreshEventSpecificPickups_LetterHuntDaily));
			_refreshEventSpecificPickupsFunctions.Add(action);
		}
		if (pickupDataForPickupType2 != null && pickupDataForPickupType2._pickupEnabledState == PickupEnabledState.SetProgrammatically)
		{
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(PickupManagerController.RefreshEventSpecificPickups_LetterHuntCharacter));
			_refreshEventSpecificPickupsFunctions.Add(action2);
		}
		if (pickupDataForPickupType3 != null && pickupDataForPickupType3._pickupEnabledState == PickupEnabledState.SetProgrammatically)
		{
			Action action3 = default;
			action3._002Ector(this, (nint)__ldftn(PickupManagerController.RefreshEventSpecificPickups_MysteryPowerup));
			_refreshEventSpecificPickupsFunctions.Add(action3);
		}
		if (pickupDataForPickupType4 != null && pickupDataForPickupType4._pickupEnabledState == PickupEnabledState.SetProgrammatically)
		{
			Action action4 = default;
			action4._002Ector(this, (nint)__ldftn(PickupManagerController.RefreshEventSpecificPickups_SuperMysteryBox));
			_refreshEventSpecificPickupsFunctions.Add(action4);
		}
		if (pickupDataForPickupType5 != null && pickupDataForPickupType5._pickupEnabledState == PickupEnabledState.SetProgrammatically)
		{
			Action action5 = default;
			action5._002Ector(this, (nint)__ldftn(PickupManagerController.RefreshEventSpecificPickups_TokenHunt));
			_refreshEventSpecificPickupsFunctions.Add(action5);
		}
	}

	private void AddAnyEventSpecificPickers()
	{
		PickupData pickupDataForPickupType = _pickupManager.GetPickupDataForPickupType(PickupType.LetterHuntDaily);
		PickupData pickupDataForPickupType2 = _pickupManager.GetPickupDataForPickupType(PickupType.TokenHunt);
		PickupData pickupDataForPickupType3 = _pickupManager.GetPickupDataForPickupType(PickupType.SuperMysteryBox);
		PickupData pickupDataForPickupType4 = _pickupManager.GetPickupDataForPickupType(PickupType.MysteryPowerup);
		PickupData pickupDataForPickupType5 = _pickupManager.GetPickupDataForPickupType(PickupType.LetterHuntCharacter);
		PickerData pickerDataForPickerType = _pickupManager.GetPickerDataForPickerType(PickerType.LetterHuntDaily);
		PickerData pickerDataForPickerType2 = _pickupManager.GetPickerDataForPickerType(PickerType.TokenHunt);
		PickerData pickerDataForPickerType3 = _pickupManager.GetPickerDataForPickerType(PickerType.SuperMysteryBox);
		PickerData pickerDataForPickerType4 = _pickupManager.GetPickerDataForPickerType(PickerType.MysteryPowerUp);
		PickerData pickerDataForPickerType5 = _pickupManager.GetPickerDataForPickerType(PickerType.LetterHuntCharacter);
		if (pickupDataForPickupType != null && pickupDataForPickupType._pickupEnabledState == PickupEnabledState.Enabled)
		{
			PickupManager pickupManager = _pickupManager;
			if (!pickupManager._pickerCollection.HasPickerOfType<LetterHuntDailyPicker>() && pickerDataForPickerType._pickerEnabledState != PickerEnabledState.NotEnabled)
			{
				PickupManager pickupManager2 = _pickupManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B5F");
				IPicker iPicker = default;
				pickupManager2._pickerCollection.Add(iPicker);
			}
		}
		if (pickupDataForPickupType2 != null && pickupDataForPickupType2._pickupEnabledState == PickupEnabledState.Enabled)
		{
			PickupManager pickupManager3 = _pickupManager;
			if (!pickupManager3._pickerCollection.HasPickerOfType<TokenHuntPicker>() && pickerDataForPickerType2._pickerEnabledState != PickerEnabledState.NotEnabled)
			{
				PickupManager pickupManager4 = _pickupManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B5F");
				IPicker iPicker2 = default;
				pickupManager4._pickerCollection.Add(iPicker2);
			}
		}
		if (pickupDataForPickupType3 != null && pickupDataForPickupType3._pickupEnabledState == PickupEnabledState.Enabled)
		{
			PickupManager pickupManager5 = _pickupManager;
			if (!pickupManager5._pickerCollection.HasPickerOfType<SuperMysteryBoxPicker>() && pickerDataForPickerType3._pickerEnabledState != PickerEnabledState.NotEnabled)
			{
				PickupManager pickupManager6 = _pickupManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B5F");
				IPicker iPicker3 = default;
				pickupManager6._pickerCollection.Add(iPicker3);
			}
		}
		if (pickupDataForPickupType4 != null && pickupDataForPickupType4._pickupEnabledState == PickupEnabledState.Enabled)
		{
			PickupManager pickupManager7 = _pickupManager;
			if (!pickupManager7._pickerCollection.HasPickerOfType<MysteryPowerupPicker>() && pickerDataForPickerType4._pickerEnabledState != PickerEnabledState.NotEnabled)
			{
				PickupManager pickupManager8 = _pickupManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B5F");
				IPicker iPicker4 = default;
				pickupManager8._pickerCollection.Add(iPicker4);
			}
		}
		if (pickupDataForPickupType5 != null && pickupDataForPickupType5._pickupEnabledState == PickupEnabledState.Enabled)
		{
			PickupManager pickupManager9 = _pickupManager;
			if (!pickupManager9._pickerCollection.HasPickerOfType<LetterHuntCharacterPicker>() && pickerDataForPickerType5._pickerEnabledState != PickerEnabledState.NotEnabled)
			{
				PickupManager pickupManager10 = _pickupManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B5F");
				IPicker iPicker5 = default;
				pickupManager10._pickerCollection.Add(iPicker5);
			}
		}
	}

	private void RefreshEventSpecificPickups()
	{
		AddAnyEventSpecificPickers();
		int num = 0;
		while (true)
		{
			List<Action> refreshEventSpecificPickupsFunctions = _refreshEventSpecificPickupsFunctions;
			if (num < refreshEventSpecificPickupsFunctions._size)
			{
				Action action = _refreshEventSpecificPickupsFunctions.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}

	private void RefreshEventSpecificPickups_SuperMysteryBox()
	{
		PickupData pickupDataForPickupType = _pickupManager.GetPickupDataForPickupType(PickupType.SuperMysteryBox);
		if (pickupDataForPickupType != null)
		{
			SSEventsManagerController instance = SSEventsManagerController.instance;
			IEventManager activeEventManager = instance.GetActiveEventManager(SSEventType.SuperMysteryBox);
			PickupEnabledState pickupEnabledState = ((activeEventManager == null) ? ((PickupEnabledState)((Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___SUPER_MYSTERY_BOX ? 1 : 0) ^ 1)) : PickupEnabledState.Enabled);
			pickupDataForPickupType._pickupEnabledState = pickupEnabledState;
		}
	}

	private void RefreshEventSpecificPickups_TokenHunt()
	{
		PickupData pickupDataForPickupType = _pickupManager.GetPickupDataForPickupType(PickupType.TokenHunt);
		if (pickupDataForPickupType != null)
		{
			PickupEnabledState pickupEnabledState = ((!WeeklyHuntManager.IsAnyPeriodActive()) ? ((PickupEnabledState)((Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___LETTER_HUNT_CHARACTER ? 1 : 0) ^ 1)) : PickupEnabledState.Enabled);
			pickupDataForPickupType._pickupEnabledState = pickupEnabledState;
		}
	}

	private void RefreshEventSpecificPickups_MysteryPowerup()
	{
		PickupData pickupDataForPickupType = _pickupManager.GetPickupDataForPickupType(PickupType.MysteryPowerup);
		if (pickupDataForPickupType != null)
		{
			SSEventsManagerController instance = SSEventsManagerController.instance;
			IEventManager activeEventManager = instance.GetActiveEventManager(SSEventType.MysteryPowerup);
			PickupEnabledState pickupEnabledState = ((activeEventManager == null) ? ((PickupEnabledState)((Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___MYSTERY_POWER_UP ? 1 : 0) ^ 1)) : PickupEnabledState.Enabled);
			pickupDataForPickupType._pickupEnabledState = pickupEnabledState;
		}
	}

	private void RefreshEventSpecificPickups_LetterHuntDaily()
	{
		PickupData pickupDataForPickupType = _pickupManager.GetPickupDataForPickupType(PickupType.LetterHuntDaily);
		PickupEnabledState pickupEnabledState;
		if (pickupDataForPickupType != null)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			if (instance.IsActiveDailyLetterEvent())
			{
				PlayerInfo instance2 = PlayerInfo.Instance;
				bool flag = instance2.HasDailyWordTimeLeft();
				pickupEnabledState = PickupEnabledState.Enabled;
				if (flag)
				{
					goto IL_00aa;
				}
			}
		}
		pickupEnabledState = PickupEnabledState.NotEnabled;
		goto IL_00aa;
		IL_00aa:
		pickupDataForPickupType._pickupEnabledState = pickupEnabledState;
	}

	private bool IsCharacterNameEventActive()
	{
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager(SSEventType.CharacterName);
		return activeEventManager != null;
	}

	private bool IsCharacterLetterPickupSpawnable()
	{
		bool result = true;
		if (!Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___LETTER_HUNT_CHARACTER)
		{
			bool flag = ((PickupManagerController)null).IsCharacterNameEventActive();
			bool flag2 = !flag;
			result = false;
			if (!flag2)
			{
				SSEventsManagerController instance = SSEventsManagerController.instance;
				CharacterNameEventManager typeOfActiveEventManager = instance.GetTypeOfActiveEventManager<CharacterNameEventManager>();
				bool flag3 = typeOfActiveEventManager == null;
				result = false;
				if (!flag3)
				{
					result = typeOfActiveEventManager.ShouldSpawnLetters();
				}
			}
		}
		return result;
	}

	private void RefreshEventSpecificPickups_LetterHuntCharacter()
	{
		PickupData pickupDataForPickupType = _pickupManager.GetPickupDataForPickupType(PickupType.LetterHuntCharacter);
		PickupEnabledState pickupEnabledState = PickupEnabledState.Enabled;
		if (!Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___LETTER_HUNT_CHARACTER)
		{
			if (pickupDataForPickupType == null)
			{
				return;
			}
			if (((PickupManagerController)(object)pickupDataForPickupType).IsCharacterNameEventActive())
			{
				bool flag = ((PickupManagerController)(object)pickupDataForPickupType).IsCharacterLetterPickupSpawnable();
				pickupEnabledState = PickupEnabledState.Enabled;
				if (flag)
				{
					goto IL_00a6;
				}
			}
			pickupEnabledState = PickupEnabledState.NotEnabled;
		}
		goto IL_00a6;
		IL_00a6:
		pickupDataForPickupType._pickupEnabledState = pickupEnabledState;
	}

	private void PickupManager_OnPickupCollected(object sender, PickupManager.PickupEventArgs args)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I
		//IL_04de: Expected Obj, but got I
		//IL_04ef: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_06b9: Expected Obj, but got I
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		Game instance = Game.Instance;
		if (instance._isInStumbleDeathSequence)
		{
			return;
		}
		Game instance2 = Game.Instance;
		if (instance2.isDead)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
		if ((nint)0 <= (nint)64)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
			if ((nint)0 <= (nint)8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
				object obj4 = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
				if ((nint)0 == 1)
				{
					PlayerInfo instance3 = PlayerInfo.Instance;
					instance3.AddSaveMeTokenToUnlock();
					GameStats instance4 = GameStats.Instance;
					instance4.KeyPickupsCollectedIncrement();
					GameStats instance5 = GameStats.Instance;
					instance5.AddScoreForPickup(PowerupType.saveMeToken);
					PlayerInfo instance6 = PlayerInfo.Instance;
					Statistics stats = instance6._stats;
					int[] values = stats._values;
					int value = values[27] + 1;
					stats.set_Item(Stat.KeysCollected, value);
					return;
				}
				if ((nint)obj4 == 1)
				{
					Game instance7 = Game.Instance;
					Game instance8 = Game.Instance;
					CharacterModifierCollection modifiers = instance8._modifiers;
					instance7._modifiers.Add(modifiers.coinMagnet);
					GameStats instance9 = GameStats.Instance;
					instance9.CoinMagnetPickupsCollectedIncrement();
					return;
				}
				if ((nint)obj4 != 2)
				{
					if ((nint)obj4 == 3)
					{
						Game instance10 = Game.Instance;
						Game instance11 = Game.Instance;
						CharacterModifierCollection modifiers2 = instance11._modifiers;
						instance10._modifiers.Add(modifiers2.superSneakers);
						GameStats instance12 = GameStats.Instance;
						instance12.SuperSneakerPickupsCollectedIncrement();
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
					if ((nint)0 == 8)
					{
						Game instance13 = Game.Instance;
						instance13.PickupJetpack();
						return;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
				if ((nint)0 == 16)
				{
					GameStats instance14 = GameStats.Instance;
					instance14.MysteryBoxPickupsCollectedInrement();
					RewardManager.AddRewardToUnlock(CelebrationRewardOrigin.MysteryBox);
					GameStats instance15 = GameStats.Instance;
					instance15.AddScoreForPickup(PowerupType.mysterybox);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
				if ((nint)0 == 32)
				{
					Game instance16 = Game.Instance;
					Game instance17 = Game.Instance;
					CharacterModifierCollection modifiers3 = instance17._modifiers;
					instance16._modifiers.Add(modifiers3.doubleScoreMultiplier);
					GameStats instance18 = GameStats.Instance;
					instance18.DoubleMultiplierPickupsCollectedIncrement();
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
				if ((nint)0 == 64)
				{
					CharacterModifier randomModifier = MysteryPowerup.GetRandomModifier();
					randomModifier.TriggeredByMysteryPowerup__BackingField = true;
					Game instance19 = Game.Instance;
					instance19._modifiers.Add(randomModifier);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
					object obj5 = default;
					if (obj5 != null)
					{
						Character instance20 = Character.Instance;
						instance20.MysteryPowerupParticleSystem.Play();
					}
					return;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
			if ((nint)0 <= (nint)256)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
				if ((nint)0 == 128)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v57+48]");
					CharacterLetterPickup component = ((GameObject)0).GetComponent<CharacterLetterPickup>();
					if (component != null)
					{
						component.Reward();
					}
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
				if ((nint)0 == 256)
				{
					RewardManager.AddRewardToUnlock(CelebrationRewardOrigin.SuperMysteryBox);
					GameStats instance21 = GameStats.Instance;
					int superMysteryBoxPickupsCollected = instance21._superMysteryBoxPickupsCollected + 1;
					instance21._superMysteryBoxPickupsCollected = superMysteryBoxPickupsCollected;
					int superMysteryBoxPickupsCollectedRun = instance21._superMysteryBoxPickupsCollectedRun + 1;
					instance21._superMysteryBoxPickupsCollectedRun = superMysteryBoxPickupsCollectedRun;
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
				if ((nint)0 == 512)
				{
					GameStats instance22 = GameStats.Instance;
					int huntTokensCollected = instance22._huntTokensCollected + 1;
					instance22._huntTokensCollected = huntTokensCollected;
					int huntTokensCollectedRun = instance22._huntTokensCollectedRun + 1;
					instance22._huntTokensCollectedRun = huntTokensCollectedRun;
					WeeklyHuntManager.ItemPickedUp();
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
				if ((nint)0 == 1024)
				{
					IEnumerator coroutine = RewardDailyLetterCoroutine();
					Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v21+8]");
				if ((nint)0 == 2048)
				{
					Game instance23 = Game.Instance;
					instance23.PickupPogostick();
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v8+8]");
		_ = 0;
		_ = -1;
		obj = (Enum)(object)typeof(PickupType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string missingSwitchValue = obj.ToString();
		SwitchDefaultException.Throw(missingSwitchValue);
	}

	public static IEnumerator RewardDailyLetterCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void PickupManager_OnPickerRemoved(PickerRemoveRequestEventArgs pickerRemoveEvent)
	{
		//IL_00c7: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(XTestPicker));
		object obj = default;
		string text4 = default;
		if (typeFromHandle != obj)
		{
			bool flag = obj == null;
			string text = null;
			string text2 = "Type not yet expected. Add a case for ";
			if (!flag)
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S1_v13+D4] (should have been resolved before IL gen)");
				string text3 = default;
				text = text3;
				text2 = "Type not yet expected. Add a case for ";
			}
			text4 = text2 + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			UnityException ex = default;
			ex._002Ector(text4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		PickupManager pickupManager = ((PickupManagerController)(object)text4)._pickupManager;
		bool flag2 = pickupManager._pickerCollection.HasPickerOfType<DefaultPicker>();
	}
}
