using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using SYBO.Common;
using SYBO.Components.Json;
using SYBO.Components.Utilities;
using SYBO.Subway.Info;
using UnityEngine;

namespace SYBO.Components.Analytics.Integration;

public class AggregatedDataTracking : SingletonMonoBehaviour<AggregatedDataTracking>
{
	[Serializable]
	public class DataContainer
	{
		public int KeysReceived;

		public int CoinsReceived;

		public int LastDayPlayed;

		public int UniqueDaysPlayed;

		public int SessionCount;

		public int MissingKeysCount;

		public int MissingCoinsCount;

		private List<UnsampledPurchaseData> _unsampledPurchases;

		private DataCompleteness _dataCompleteness;

		public List<UnsampledPurchaseData> UnsampledPurchases
		{
			get
			{
				//IL_0007: Expected Obj, but got I4
				return (List<UnsampledPurchaseData>)CoinsReceived;
			}
		}

		public DataCompleteness DataCompleteness
		{
			get
			{
				//IL_0067: Expected I4, but got Obj
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_0029: Expected Obj, but got Unknown
				if (_unsampledPurchases == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
					object obj = this + 36;
					object obj2 = default;
					obj = obj2;
				}
				return (DataCompleteness)_unsampledPurchases;
			}
		}

		public DataContainer(DataCompleteness dataCompleteness, int initialKeysAmount = 0)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Exception>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Exception);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.Exception>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Exception)this).SetErrorCode((int)dataCompleteness);
		}

		public void AddUnsampledPurchase(string itemTitleId)
		{
			//IL_000a: Expected I4, but got Obj
			KeysReceived = (int)itemTitleId;
		}

		public static string Serialize(DataContainer dataContainer)
		{
			//IL_000a: Expected Obj, but got I4
			return (string)dataContainer._dataCompleteness;
		}

		public static DataContainer Deserialize(string dataString)
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			_0021_00210 val = (_0021_00210)JsonApi.ReflectionDeserializeDom<T>((object)dataString, (JsonContext)null);
			Encoding uTF = Encoding.UTF32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			nint num = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v6 (Il2CppClass<System.Convert>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v11 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string s = default;
			return (DataContainer)(object)Convert.FromBase64String(s);
		}
	}

	[Serializable]
	public class UnsampledPurchaseData
	{
		public string ItemTitleId;

		public int Count;
	}

	public enum DataCompleteness
	{
		Undefined,
		Full,
		Partial,
		None
	}

	private const int MaxDaysInYear = 366;

	private bool _initialized;

	private bool _stoppedTracking;

	private DataContainer _dataContainer;

	private int _currentKeysAmount;

	private int _currentCoinsAmount;

	private SessionTracker _sessionTracker;

	public void Initialize(bool hadUserInPlayerInfo, int sessionTimeoutSeconds)
	{
		//IL_0127: Expected Obj, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_015a: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		bool flag2 = default;
		bool flag = ((!flag2) ? true : flag2);
		_dataContainer = (DataContainer)flag;
		object obj = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.Integration.AggregatedDataTracking)+C]");
		object obj3 = (nint)0 + (nint)16;
		obj3 = 1337;
		_stoppedTracking = true;
		while ((_stoppedTracking ? 1 : 0) <= 623)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.Integration.AggregatedDataTracking)+C]");
			object obj4 = (nint)0 + (nint)16;
			object obj5 = (_stoppedTracking ? 1u : 0u) << 2;
			object obj6 = obj4 + obj5;
			object obj7 = (_stoppedTracking ? 1u : 0u) << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.Integration.AggregatedDataTracking)+C]");
			object obj8 = 0 + obj7;
			object obj9 = obj8 + 12;
			object obj10 = obj9 * 69069;
			obj6 = obj10;
			bool stoppedTracking = (byte)((_stoppedTracking ? 1u : 0u) + 1u) != 0;
			_stoppedTracking = stoppedTracking;
		}
		((UnsyncedMTRandomGen)(object)this)._002Ector();
		int num = sessionTimeoutSeconds;
		while (num >= 624)
		{
			((UnsyncedMTRandomGen)(object)this)._002Ector();
			int num2 = num - 624;
			num = num2;
		}
		_stoppedTracking = (byte)num != 0;
		_currentKeysAmount = sessionTimeoutSeconds;
	}

	public void StopAggregatedDataTracking()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AggregatedDataTracking aggregatedDataTracking = default;
		aggregatedDataTracking.Initialize(hadUserInPlayerInfo: true, 0);
		object obj = this + 8;
		obj = aggregatedDataTracking;
	}

	private void OnApplicationFocus(bool focusStatus)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 8;
		obj = focusStatus;
	}

	private void Load(bool hadUserInPlayerInfo)
	{
		if (hadUserInPlayerInfo)
		{
			Collider collider = ((CollisionNotifier)(object)_sessionTracker).Collider;
			if ((object)collider != null)
			{
				UIScreenController_OnAwake();
			}
		}
		else
		{
			((CollisionNotifier)(object)_sessionTracker).Awake();
		}
	}

	private unsafe void Save()
	{
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_0173: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(AggregatedDataTracking.UIScreenController_OnPopupShown);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnLastPopupClosed += action;
		SyboAnalyticsSave.kilooAnalyticsHasLoggedSyboUserId = (byte)(int)string.Empty != 0;
		string obj3 = tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj3);
		_stoppedTracking = true;
	}

	private void PlayerInfo_OnKeysChanged()
	{
		//IL_0018: Expected I4, but got Obj
		DataContainer dataContainer = DataContainer.Deserialize((string)(object)_dataContainer);
		SyboAnalyticsSave.kilooAnalyticsHasLoggedSyboUserId = (byte)(int)dataContainer != 0;
	}

	private void PlayerInfo_OnCoinsChanged()
	{
		//IL_004b: Expected Obj, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected I4, but got Unknown
		int coins = InventorySave.coins;
		if (coins > _currentKeysAmount)
		{
			DataContainer dataContainer = _dataContainer;
			object obj = coins - _currentKeysAmount;
			int keysReceived = obj + dataContainer.KeysReceived;
			dataContainer.KeysReceived = keysReceived;
			PlayerInfo_OnKeysChanged();
		}
		_currentKeysAmount = coins;
	}

	private void CheckForNewUniqueDay()
	{
		//IL_004b: Expected Obj, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected I4, but got Unknown
		int unrewardedCoins = InventorySave.unrewardedCoins;
		if (unrewardedCoins > _currentCoinsAmount)
		{
			DataContainer dataContainer = _dataContainer;
			object obj = unrewardedCoins - _currentCoinsAmount;
			int coinsReceived = obj + dataContainer.CoinsReceived;
			dataContainer.CoinsReceived = coinsReceived;
			PlayerInfo_OnKeysChanged();
		}
		_currentCoinsAmount = unrewardedCoins;
	}

	private int ConvertDateTimeToDay(DateTime dateTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0;
	}

	private unsafe void IncrementSession()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got VT
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected I4, but got Unknown
		//IL_010c: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v26 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime utcNow = DateTime.UtcNow;
		object obj2 = utcNow;
		Characters.CharacterId characterId = (Characters.CharacterId)(obj2 + 8);
		((Characters.CharacterId*)(int)characterId)->value__ = (int)obj2;
		int itemBalance = AnalyticsHelper.GetItemBalance(InAppItemModel.ItemType.Undefined, characterId);
		DataContainer dataContainer = _dataContainer;
		if (itemBalance > dataContainer.LastDayPlayed)
		{
			DataContainer dataContainer2 = _dataContainer;
			int uniqueDaysPlayed = dataContainer2.UniqueDaysPlayed + 1;
			dataContainer2.UniqueDaysPlayed = uniqueDaysPlayed;
			DataContainer dataContainer3 = _dataContainer;
			dataContainer3.LastDayPlayed = itemBalance;
			PlayerInfo_OnKeysChanged();
		}
	}

	private void UIScreenController_OnAwake()
	{
		DataContainer dataContainer = _dataContainer;
		int sessionCount = dataContainer.SessionCount + 1;
		dataContainer.SessionCount = sessionCount;
		PlayerInfo_OnKeysChanged();
	}

	private void UIScreenController_OnPopupShown(string screenName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I4
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		bool flag;
		if (SyboAnalyticsSave.kilooAnalyticsHasLoggedSyboUserId)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			if (screenName != null)
			{
				object obj4 = 2;
			}
			else
			{
				object obj4 = 1;
			}
			if (screenName != null)
			{
				object obj5 = 0;
			}
			else
			{
				object obj5 = 5;
			}
			object obj6 = this + 20;
			object obj7 = default;
			obj6 = obj7;
			PlayerInfo_OnKeysChanged();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj8 = default;
		object obj9 = default;
		if (obj8 == obj9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj11 = default;
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj13 = default;
			object obj12 = obj13;
		}
		else
		{
			object obj14 = default;
			object obj12 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private unsafe void PurchaseHandler_OnIngameCurrencyPurchaseCompleted(object sender, PurchaseHandler.SyboInGameCurrencyPurchaseEventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return;
		}
		_initialized = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CollisionNotifier collisionNotifier = default;
		collisionNotifier.TriggerEnter += (Action<Collider>)(object)e;
		object obj = this + 32;
		obj = collisionNotifier;
		((CollisionNotifier)(object)_sessionTracker).Awake();
		UIScreenController_OnPopupShown((string)sender);
		int coins = InventorySave.coins;
		_currentKeysAmount = coins;
		int unrewardedCoins = InventorySave.unrewardedCoins;
		_currentCoinsAmount = unrewardedCoins;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(AggregatedDataTracking.PlayerInfo_OnKeysChanged);
		object obj2 = action + 16;
		obj2 = this;
		InventorySave.keysChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(AggregatedDataTracking.PlayerInfo_OnCoinsChanged);
		object obj3 = action2 + 16;
		obj3 = this;
		InventorySave.coinsChanged -= action2;
		IncrementSession();
		UIScreenController_OnAwake();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(AggregatedDataTracking.UIScreenController_OnAwake);
		object obj4 = action3 + 16;
		obj4 = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v43 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v48 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnAwake -= action3;
	}

	public unsafe AggregatedDataTracking()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_013e: Expected I, but got Obj
		//IL_0154: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_017f: Expected I, but got Obj
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		if (~(_stoppedTracking ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			Action<string> action = default;
			object obj = action + 16;
			obj = this;
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v35 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v42 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIScreenController.OnPopupShown -= action;
			SlideinPowerupHelper instance = SlideinPowerupHelper.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			_ = 0;
			EventHandler<PurchaseHandler.SyboInGameCurrencyPurchaseEventArgs> eventHandler = default;
			object obj3 = eventHandler + 16;
			obj3 = this;
			((PurchaseHandler)(object)instance).OnIngameCurrencyPurchaseCompleted -= eventHandler;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(AggregatedDataTracking.UIScreenController_OnAwake);
		object obj4 = action2 + 16;
		obj4 = this;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v21 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationPaused += action2;
	}
}
