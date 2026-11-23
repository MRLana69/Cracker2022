using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Characters.States;
using SYBO.Subway.Placeholders.Lifecycles;
using UnityEngine;

namespace SYBO.Subway.Coins;

public class CoinManager : SingletonMonobehavior<CoinManager>
{
	private GameObject _coinPrefab;

	private HashSet<Coin> _activeCoins;

	private HashSet<Coin> _toRemove;

	private GameStats _gameStats;

	private Character _character;

	private EventHandler m_OnCoinCollected;

	public event EventHandler OnCoinCollected
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 32;
			Delegate obj2 = this.m_OnCoinCollected;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 32;
			Delegate obj2 = this.m_OnCoinCollected;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	protected void Start()
	{
		Transform childTransform = transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.DynamicManagers);
		Character instance = Character.Instance;
		_character = instance;
		GameStats instance2 = GameStats.Instance;
		_gameStats = instance2;
	}

	public bool IsSpawned(Coin coin)
	{
		return _activeCoins.Contains(coin);
	}

	public void NotifyCoinActivated(Coin coin)
	{
		//IL_0021: Expected Obj, but got I
		if (!_activeCoins.Contains(coin))
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.HashSet`1<SYBO.Subway.Coins.Coin>>)+3C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S3_v5+4] (should have been resolved before IL gen)");
		}
	}

	public void NotifyCoinDeactivated(Coin coin)
	{
		//IL_002b: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.HashSet`1<SYBO.Subway.Coins.Coin>>)+3C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		Transform transform = coin.transform;
		Transform parent = transform.parent;
		PoolManager.Despawn(parent);
	}

	public void NotifyCoinDestroyed(Coin coin)
	{
		bool flag = _activeCoins.Remove(coin);
	}

	public unsafe Coin SpawnCoin(Vector3 position, Transform parentTransform = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0028: Expected I, but got Obj
		//IL_00df: Expected native int or pointer, but got VT
		//IL_00f1: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		Transform prefab = _coinPrefab.transform;
		Transform transform = PoolManager.Spawn(prefab);
		PlaceholderLifecycle component = transform.GetComponent<PlaceholderLifecycle>();
		nint num = (nint)component;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S1_v8 (Il2CppClass<SYBO.Subway.Placeholders.Lifecycles.PlaceholderLifecycle>)+DC] (should have been resolved before IL gen)");
		if (!component._placeholder.HasSpawnedInstances)
		{
			component.Spawn();
		}
		GameStats gameStats = _gameStats;
		int coinsSpawned = gameStats._coinsSpawned + 1;
		gameStats._coinsSpawned = coinsSpawned;
		int coinsSpawnedRun = gameStats._coinsSpawnedRun + 1;
		gameStats._coinsSpawnedRun = coinsSpawnedRun;
		Coin componentInChildren = transform.GetComponentInChildren<Coin>();
		((Vector3*)(nint)vector)->z = position.z;
		((Vector3*)(nint)vector)->x = position.x;
		transform.position = vector;
		if (parentTransform != null)
		{
			transform.parent = parentTransform;
		}
		componentInChildren.Initialize();
		componentInChildren.Activate();
		return componentInChildren;
	}

	private void RewardCoin()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		int count = 4;
		if (!DoubleCoins.HasDoubleCoinsModifier)
		{
			count = 2;
		}
		int num = 2;
		if (!DoubleCoins.HasDoubleCoinsModifier)
		{
			num = 1;
		}
		if (!instance._hasDoubleCoinsUpgrade)
		{
			count = num;
		}
		_gameStats.CoinsCollectedIncrement(count);
		if (_character.IsAboveGroundOfCharacterRoute)
		{
			_gameStats.CoinsInAirIncrement();
		}
		JetpackState instance2 = JetpackState.Instance;
		if (~(instance2.isActive ? 1u : 0u) == 0)
		{
			_gameStats.CoinsWithJetpackIncrement();
		}
		PogoStickState instance3 = PogoStickState.Instance;
		if (~(instance3.isActive ? 1u : 0u) == 0)
		{
			_gameStats.CoinsWithPogoStickIncrement();
		}
		Character character = _character;
		if (character.__trackIndex != 0)
		{
			if (character.__trackIndex != 1)
			{
				if (character.__trackIndex == 2)
				{
					_gameStats.CoinsCollectedOnRightTrackIncrement();
				}
			}
			else
			{
				_gameStats.CoinsCollectedOnCenterTrackIncrement();
			}
		}
		else
		{
			_gameStats.CoinsCollectedOnLeftTrackIncrement();
		}
		GameStats gameStats = _gameStats;
		int coinsCollectedRaw = gameStats._coinsCollectedRaw + 1;
		gameStats._coinsCollectedRaw = coinsCollectedRaw;
		int coinsCollectedRawRun = gameStats._coinsCollectedRawRun + 1;
		gameStats._coinsCollectedRawRun = coinsCollectedRawRun;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Obj, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		float time = Time.time;
		DeviceInfo instance = DeviceInfo.Instance;
		Character instance2 = Character.Instance;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A9");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		bool flag = instance.performanceLevel == DeviceInfo.PerformanceLevel.Low;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		object obj17 = default;
		object obj18 = default;
		object obj19 = default;
		object obj20 = default;
		object obj21 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_01df;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @217");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj7 != obj8;
			object obj9 = obj10;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_01df;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0498;
			}
			goto IL_04c1;
			IL_0498:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			break;
			IL_04c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
			IL_01df:
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3ACB");
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A9");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj15 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			while (true)
			{
				_ = 0;
				object obj16 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj17 == null)
					{
						break;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag3 = obj18 == obj19;
				bool flag4 = !flag3;
				obj9 = obj20;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj9 = obj21;
				}
				goto IL_044c;
			}
			break;
			IL_044c:
			_ = 0;
			object obj22 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0498;
			}
			goto IL_04c1;
		}
		object obj23 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3ACB");
		throw new IndexOutOfRangeException();
	}

	public void PickupCoin(Coin coin)
	{
		RewardCoin();
		RaiseOnCoinCollected();
	}

	private void RaiseOnCoinCollected()
	{
		EventHandler onCoinCollected = this.m_OnCoinCollected;
		if (this.m_OnCoinCollected != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v12.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ResetCoins()
	{
		List<Coin> list = default;
		list._002Ector((IEnumerable<Coin>)_activeCoins);
		int num = 0;
		while (num < list._size)
		{
			Coin coin = list.get_Item(num);
			coin.Deactivate();
			int num2 = num + 1;
			num = num2;
		}
	}

	public CoinManager()
	{
		HashSet<Coin> hashSet = default;
		hashSet._002Ector();
		_activeCoins = hashSet;
		HashSet<Coin> hashSet2 = default;
		hashSet2._002Ector();
		_toRemove = hashSet2;
		base._002Ector();
	}
}
