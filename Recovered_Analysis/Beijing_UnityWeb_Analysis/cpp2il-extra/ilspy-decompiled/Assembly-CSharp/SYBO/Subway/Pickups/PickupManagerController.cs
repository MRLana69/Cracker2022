using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Components.Utilities.Validators;
using SYBO.Subway.Coins;
using SYBO.Subway.Info;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups.Pickers;
using SYBO.Subway.Routes.Log;
using UnityEngine;
using WeeklyHunt;
using WordHunt;

namespace SYBO.Subway.Pickups;

public class PickupManagerController
{
	private sealed class _003CRewardDailyLetterCoroutine_003Ed__16(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0067: Expected I, but got Obj
				//IL_007d: Expected Obj, but got I
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Expected Obj, but got Unknown
				//IL_011e: Expected Obj, but got I4
				//IL_00a8: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						AndroidIncomingCallBridge androidIncomingCallBridge = AndroidIncomingCallBridge.CreatePlugin();
						((DailyLetterPickupManager)(object)androidIncomingCallBridge)._002Ector();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
				((GameStats)(object)privacyPolicyUrl).AddScoreForPickup(true);
				AndroidIncomingCallBridge androidIncomingCallBridge2 = AndroidIncomingCallBridge.CreatePlugin();
				nint num = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(WordHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v16 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((WordHuntManager)(object)androidIncomingCallBridge2.onPhoneStateChanged).LoadFromOfflineData();
				string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
				((GameStats)(object)privacyPolicyUrl2).CharacterLetterPickupsCollectedIncrement();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 2f;
				object obj2 = this + 12;
				object obj3 = default;
				obj2 = obj3;
				_003C_003E1__state = 1;
				return 1;
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

	private PickupManager _pickupManager;

	private List<Action> _refreshEventSpecificPickupsFunctions;

	public PickupManagerController(PickupManager pickupManager)
	{
		//IL_0150: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		SpawnPointMode spawnPointMode = default;
		object obj = spawnPointMode + 16;
		obj = this;
		((PickupSpawnPoint)(object)pickupManager).SpawnPointMode = spawnPointMode;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<PickupSpawnPoint, PickerData> action = default;
		object obj2 = action + 16;
		obj2 = this;
		((PickupSpawnPoint)(object)pickupManager).OnPickupSpawned += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<PickupSpawnPoint> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		((PickupSpawnPoint)(object)pickupManager).OnPickupCollected += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<PickupSpawnPoint> action3 = default;
		object obj4 = action3 + 16;
		obj4 = this;
		((PickupSpawnPoint)(object)pickupManager).OnDeregistered += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<PickupSpawnPoint> action4 = default;
		object obj5 = action4 + 16;
		obj5 = this;
		((PickupSpawnPoint)(object)pickupManager).OnPickupDespawned += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupManagerController)+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupManagerController)+20]");
			((Action<PickupSpawnPoint>)0)((PickupSpawnPoint)(object)pickupManager);
		}
	}

	public void Destroy()
	{
		//IL_002c: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_009d: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		_ = 360f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 72;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S3_v8+60]");
		object obj9 = 0;
		object obj10 = obj9;
		object obj11 = obj10 & 0x1FFF;
		object obj12 = obj11 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54 @ S4_v8 (should have been resolved before IL gen)");
		object obj13 = this + 76;
		object obj14 = default;
		obj13 = obj14;
		((Validator<>)this)._002Ector();
	}

	public void Update()
	{
		//IL_00df: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_pickupManager).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			bool flag = default;
			object obj2 = (flag ? 1 : 0) + 16;
			obj2 = this;
			_pickupManager.UpdatePickerCollection(flag);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			_ = 0;
			Action<PickupSpawnPoint> action = default;
			object obj3 = action + 16;
			obj3 = this;
			_pickupManager.OnPickupSpawnPointRegistered += action;
		}
	}

	private void SetupEventSpecificPickups()
	{
		RefreshEventSpecificPickups_SuperMysteryBox();
	}

	private unsafe void AddAnyEventSpecificPickers()
	{
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Action> list = default;
		list._002Ector();
		object obj = this + 12;
		obj = list;
		bool flag = _pickupManager.HasPickupDataForPickupType(PickupType.LetterHuntDaily);
		bool flag2 = _pickupManager.HasPickupDataForPickupType(PickupType.LetterHuntCharacter);
		bool flag3 = _pickupManager.HasPickupDataForPickupType(PickupType.MysteryPowerup);
		bool flag4 = _pickupManager.HasPickupDataForPickupType(PickupType.SuperMysteryBox);
		bool flag5 = _pickupManager.HasPickupDataForPickupType(PickupType.TokenHunt);
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (System.Boolean)+10]");
			if ((nint)0 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Action action = default;
				((Delegate)action).method_ptr = method_ptr;
				((Delegate)action).method = (nint)__ldftn(PickupManagerController.RefreshEventSpecificPickups_LetterHuntDaily);
				object obj2 = action + 16;
				obj2 = this;
				_refreshEventSpecificPickupsFunctions.Add(action);
			}
		}
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (System.Boolean)+10]");
			if ((nint)0 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr2 = 0;
				Action action2 = default;
				((Delegate)action2).method_ptr = method_ptr2;
				((Delegate)action2).method = (nint)__ldftn(PickupManagerController.RefreshEventSpecificPickups_LetterHuntCharacter);
				object obj3 = action2 + 16;
				obj3 = this;
				_refreshEventSpecificPickupsFunctions.Add(action2);
			}
		}
		if (flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (System.Boolean)+10]");
			if ((nint)0 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr3 = 0;
				Action action3 = default;
				((Delegate)action3).method_ptr = method_ptr3;
				((Delegate)action3).method = (nint)__ldftn(PickupManagerController.RefreshEventSpecificPickups_MysteryPowerup);
				object obj4 = action3 + 16;
				obj4 = this;
				_refreshEventSpecificPickupsFunctions.Add(action3);
			}
		}
		if (flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v21 (System.Boolean)+10]");
			if ((nint)0 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr4 = 0;
				Action action4 = default;
				((Delegate)action4).method_ptr = method_ptr4;
				((Delegate)action4).method = (nint)__ldftn(PickupManagerController.RefreshEventSpecificPickups_SuperMysteryBox);
				object obj5 = action4 + 16;
				obj5 = this;
				_refreshEventSpecificPickupsFunctions.Add(action4);
			}
		}
		if (flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v24 (System.Boolean)+10]");
			if ((nint)0 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr5 = 0;
				Action action5 = default;
				((Delegate)action5).method_ptr = method_ptr5;
				((Delegate)action5).method = (nint)__ldftn(PickupManagerController.RefreshEventSpecificPickups_TokenHunt);
				object obj6 = action5 + 16;
				obj6 = this;
				_refreshEventSpecificPickupsFunctions.Add(action5);
			}
		}
	}

	private void RefreshEventSpecificPickups()
	{
		//IL_0042: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected Obj, but got Unknown
		bool flag = _pickupManager.HasPickupDataForPickupType(PickupType.LetterHuntDaily);
		bool flag2 = _pickupManager.HasPickupDataForPickupType(PickupType.TokenHunt);
		bool flag3 = _pickupManager.HasPickupDataForPickupType(PickupType.SuperMysteryBox);
		bool flag4 = _pickupManager.HasPickupDataForPickupType(PickupType.MysteryPowerup);
		bool flag5 = _pickupManager.HasPickupDataForPickupType(PickupType.LetterHuntCharacter);
		bool flag6 = _pickupManager.IsSpawned((Transform)2);
		bool flag7 = _pickupManager.IsSpawned((Transform)4);
		bool flag8 = _pickupManager.IsSpawned((Transform)8);
		bool flag9 = _pickupManager.IsSpawned((Transform)16);
		bool flag10 = _pickupManager.IsSpawned((Transform)32);
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7 (System.Boolean)+10]");
			if ((nint)0 == 0)
			{
				object obj = _pickupManager - -64;
				SaveGame save = ((DataManager<>)obj).save;
				if (save == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22 (System.Boolean)+C]");
					if ((nint)0 != 1)
					{
						object obj2 = _pickupManager - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95C5");
						IPicker iPicker = default;
						((PickerCollection)obj2).Remove(iPicker);
					}
				}
			}
		}
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10 (System.Boolean)+10]");
			if ((nint)0 == 0)
			{
				object obj3 = _pickupManager - -64;
				SaveGame save2 = ((DataManager<>)obj3).save;
				if (save2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v25 (System.Boolean)+C]");
					if ((nint)0 != 1)
					{
						object obj4 = _pickupManager - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95C5");
						IPicker iPicker2 = default;
						((PickerCollection)obj4).Remove(iPicker2);
					}
				}
			}
		}
		if (flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (System.Boolean)+10]");
			if ((nint)0 == 0)
			{
				object obj5 = _pickupManager - -64;
				SaveGame save3 = ((DataManager<>)obj5).save;
				if (save3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v28 (System.Boolean)+C]");
					if ((nint)0 != 1)
					{
						object obj6 = _pickupManager - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95C5");
						IPicker iPicker3 = default;
						((PickerCollection)obj6).Remove(iPicker3);
					}
				}
			}
		}
		if (flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (System.Boolean)+10]");
			if ((nint)0 == 0)
			{
				object obj7 = _pickupManager - -64;
				SaveGame save4 = ((DataManager<>)obj7).save;
				if (save4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v31 (System.Boolean)+C]");
					if ((nint)0 != 1)
					{
						object obj8 = _pickupManager - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95C5");
						IPicker iPicker4 = default;
						((PickerCollection)obj8).Remove(iPicker4);
					}
				}
			}
		}
		if (!flag5)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19 (System.Boolean)+10]");
		if ((nint)0 != 0)
		{
			return;
		}
		object obj9 = _pickupManager - -64;
		SaveGame save5 = ((DataManager<>)obj9).save;
		if (save5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v34 (System.Boolean)+C]");
			if ((nint)0 != 1)
			{
				object obj10 = _pickupManager - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95C5");
				IPicker iPicker5 = default;
				((PickerCollection)obj10).Remove(iPicker5);
			}
		}
	}

	private void RefreshEventSpecificPickups_SuperMysteryBox()
	{
		RefreshEventSpecificPickups();
		int num = default;
		int num2 = default;
		while (true)
		{
			List<Action> refreshEventSpecificPickupsFunctions = _refreshEventSpecificPickupsFunctions;
			if (num < refreshEventSpecificPickupsFunctions._size)
			{
				Action action = _refreshEventSpecificPickupsFunctions.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
				num = num2 + 1;
				continue;
			}
			break;
		}
	}

	private void RefreshEventSpecificPickups_TokenHunt()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		if (!_pickupManager.HasPickupDataForPickupType(PickupType.SuperMysteryBox))
		{
			return;
		}
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v36 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		if (!((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(SYBO.Subway.Info.Characters.CharacterId.fresh))
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v21 (Il2CppClass<Globals>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v30 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___SUPER_MYSTERY_BOX ? 1u : 0u) != 0)
			{
				_ = 1;
				return;
			}
		}
		_ = 0;
	}

	private void RefreshEventSpecificPickups_MysteryPowerup()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		if (!_pickupManager.HasPickupDataForPickupType(PickupType.TokenHunt))
		{
			return;
		}
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v35 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!WeeklyHuntManager.IsHuntStillActive())
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v20 (Il2CppClass<Globals>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___LETTER_HUNT_CHARACTER ? 1u : 0u) != 0)
			{
				_ = 1;
				return;
			}
		}
		_ = 0;
	}

	private void RefreshEventSpecificPickups_LetterHuntDaily()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		if (!_pickupManager.HasPickupDataForPickupType(PickupType.MysteryPowerup))
		{
			return;
		}
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v36 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		if (!((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(SYBO.Subway.Info.Characters.CharacterId.frank))
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v21 (Il2CppClass<Globals>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v30 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___MYSTERY_POWER_UP ? 1u : 0u) != 0)
			{
				_ = 1;
				return;
			}
		}
		_ = 0;
	}

	private unsafe bool IsCharacterNameEventActive()
	{
		//IL_00b0: Expected Obj, but got I
		//IL_00c2: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_011a: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0181: Expected Obj, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected I4, but got Unknown
		//IL_019c: Expected I4, but got Obj
		//IL_01bb: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupManagerController)+2C]");
		int layer = ((GameObject)0).layer;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v36 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		Vector3 one = Vector3.one;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v32 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		BackgroundLayer backgroundLayer = (BackgroundLayer)(obj3 + 28);
		backgroundLayer = (BackgroundLayer)obj2;
		BackgroundLayer backgroundLayer2 = backgroundLayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v17+8]");
		backgroundLayer2.Name = (string)0;
		int num5 = obj3 + 40;
		((int*)num5)->m_value = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return (byte)((EnvironmentBackground)null).UpdateMovingSingleObjects((List<BackgroundObject>)layer, backgroundLayer, num5) != 0;
	}

	private bool IsCharacterLetterPickupSpawnable()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		return ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(SYBO.Subway.Info.Characters.CharacterId.lucy);
	}

	private void RefreshEventSpecificPickups_LetterHuntCharacter()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0170: Expected I, but got Obj
		//IL_01bd: Expected I, but got Obj
		//IL_01d3: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_01fe: Expected I, but got Obj
		if (_pickupManager.HasPickupDataForPickupType(PickupType.LetterHuntDaily))
		{
			nint num = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v13 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v65 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!WordHuntManager.HasTimeLeft())
			{
				nint num3 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v51 (Il2CppClass<Globals>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v59 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(Globals.DEBUG_USE_ENABLE_PLAYER_INFO___IS_ACTIVE_DAILY_LETTER_EVENT ? 1u : 0u) != 0)
				{
					goto IL_0248;
				}
			}
			nint num5 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v22 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v46 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PrizeIconPrefabData instance = PrizeIconPrefabData.instance;
			if ((object)instance == null)
			{
				nint num7 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v32 (Il2CppClass<Globals>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v40 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(Globals.DEBUG_USE_ENABLE_PLAYER_INFO___HAS_DAILY_WORD_TIME_LEFT ? 1u : 0u) != 0)
				{
					goto IL_0248;
				}
			}
			_ = 0;
			return;
		}
		goto IL_0248;
		IL_0248:
		_ = 1;
	}

	private void PickupManager_OnPickupCollected(object sender, PickupManager.PickupEventArgs args)
	{
		//IL_0273: Expected Obj, but got I
		//IL_0283: Expected Obj, but got I
		//IL_0294: Invalid comparison between I and F4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0105: Invalid comparison between I and F4
		//IL_02d6: Expected VT, but got Obj
		//IL_02d6: Expected Obj, but got I4
		//IL_0242: Expected VT, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_025d: Expected Obj, but got I
		//IL_0132: Expected I, but got Obj
		//IL_0148: Expected Obj, but got I
		//IL_0327: Expected VT, but got Obj
		//IL_0327: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_0173: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sender @ L1 (System.Object)+3C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sender @ L1 (System.Object)+3C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12+20]");
		if (0f > 0f)
		{
			nint num = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v14 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v20 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isRestricted = AgeRestriction.isRestricted;
			GameObject gameObject = ((Component)sender).gameObject;
			Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S4_v15 (Il2CppMethodInfo)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S4_v16+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S4_v17+48]");
			object obj6 = 0;
			object obj7 = obj6 & 0x1F;
			object obj8 = obj7 + 22619;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v42 @ S5_v12 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sender @ L1 (System.Object)+24]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (SYBO.Subway.Pickups.PickupManager+PickupEventArgs)+18]");
			if (0f > 0f)
			{
				nint num4 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S2_v7 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num5 = (nint)typeof(GamePositionRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S2_v14 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isRestricted2 = AgeRestriction.isRestricted;
				GameObject gameObject2 = ((Component)sender).gameObject;
				Vector3 gamePosition2 = ((GamePositionRoot)isRestricted2).GetGamePosition((Vector3)gameObject2);
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S4_v8 (Il2CppMethodInfo)+C]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S4_v9+60]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S4_v10+48]");
				object obj12 = 0;
				object obj13 = obj12 & 0x1F;
				object obj14 = obj13 + 22619;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90 @ S5_v8 (should have been resolved before IL gen)");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupManagerController)+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sender @ L1 (System.Object)+3C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sender @ L1 (System.Object)+24]");
			Coin.CoinMagnetMovement coinMagnetMovement = default;
			coinMagnetMovement._002Ector((Transform)sender, (Vector3)num7, usedForSuperSneakers: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupManagerController)+10]");
			((EventHandler<PickupManager.PickupEventArgs>)0)(this, (PickupManager.PickupEventArgs)(object)coinMagnetMovement);
		}
	}

	public static IEnumerator RewardDailyLetterCoroutine()
	{
		//IL_000b: Expected Obj, but got I4
		return (IEnumerator)RoutesLogManagerBridge.ForcedZBuildValue__BackingField;
	}

	private void PickupManager_OnPickerRemoved(PickerRemoveRequestEventArgs pickerRemoveEvent)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Action> list = default;
		list._002Ector();
		object obj = this + 12;
		obj = list;
		object obj2 = this + 8;
		obj2 = pickerRemoveEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<PickerRemovedEventArgs> action = default;
		object obj3 = action + 16;
		obj3 = this;
		_pickupManager.OnPickerRemoved -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		EventHandler<PickupManager.PickupEventArgs> eventHandler = default;
		object obj4 = eventHandler + 16;
		obj4 = this;
		_pickupManager.OnPickupCollected -= eventHandler;
		AddAnyEventSpecificPickers();
		RefreshEventSpecificPickups_SuperMysteryBox();
	}
}
