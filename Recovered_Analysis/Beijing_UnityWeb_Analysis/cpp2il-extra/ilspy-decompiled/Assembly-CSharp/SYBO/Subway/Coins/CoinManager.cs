using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Info;
using UnityEngine;

namespace SYBO.Subway.Coins;

public class CoinManager : SingletonMonoBehaviour<CoinManager>
{
	private GameObject _coinPrefab;

	private EventHandler m_OnCoinCollected;

	private HashSet<Coin> _activeCoins;

	private List<Coin> _coinsCopy;

	private GameStats _gameStats;

	private Character _character;

	public event EventHandler OnCoinCollected
	{
		add
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected Obj, but got Unknown
			//IL_001f: Expected Obj, but got I4
			_ = 0;
			object obj = this - -64;
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCoinCollected;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
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
	}

	protected void Start()
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		_coinsCopy = (List<Coin>)(-1);
		_gameStats = (GameStats)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public bool IsSpawned(Coin coin)
	{
		//IL_0041: Expected I4, but got Obj
		//IL_0053: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I
		GameObject gameObject = base.gameObject;
		((UnityEngine.Object)coin).m_CachedPtr = ((UnityEngine.Object)coin).m_CachedPtr;
		bool flag = _character.EnteredColliderFromBelow((Collider)(object)coin, (byte)(int)gameObject != 0);
		object obj = (flag ? 1 : 0) + 44;
		obj = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinManager)+30]");
		((List<Coin>)0).Add((Coin)flag);
		return flag;
	}

	public void NotifyCoinActivated(Coin coin)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnCoinCollected;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)coin);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 20;
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

	public void NotifyCoinDeactivated(Coin coin)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		if (!_activeCoins.Contains(coin))
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v5 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v6+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v7+38]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	public void NotifyCoinDestroyed(Coin coin)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		bool flag = _activeCoins.Remove(coin);
		GameObject gameObject = coin.gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v11 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.AddPool((PrefabPool)(object)parentInternal);
	}

	public Coin SpawnCoin(Vector3 position, Transform parentTransform = null)
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got I4
		//IL_0197: Expected I4, but got Obj
		//IL_0197: Expected Obj, but got VT
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01d9: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got VT
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got VT
		//IL_004b: Expected I, but got Obj
		//IL_0061: Expected Obj, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_022d: Expected I, but got Obj
		//IL_0243: Expected Obj, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I4
		//IL_008c: Expected I, but got Obj
		//IL_00d9: Expected I, but got Obj
		//IL_016d: Expected Obj, but got VT
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 40;
		obj = 0;
		_ = 0;
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)position, (byte)(int)parentTransform != 0);
		Transform transform = (Transform)(obj2 + 28);
		transform.localScale = position;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinManager)+C]");
		((Transform)position).parentInternal = (Transform)0;
		Transform transform2 = (Transform)(obj2 + 56);
		transform2 = (Transform)obj;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		((Transform)position).parent = transform2;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v22 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v56 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 16;
		Vector3 one = Vector3.one;
		transform2 = (Transform)obj4;
		Transform transform4 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v27+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform2.eulerAngles;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v32 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v52 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		transform2 = (Transform)obj2;
		Transform transform5 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform2.localScale;
		object obj6 = _activeCoins + 12;
		object obj7 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			object obj8 = _activeCoins + 16;
			object obj9 = obj7 << 2;
			object obj10 = obj8 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
			object obj11 = obj7 + 1;
			obj7 = obj11;
		}
		return (Coin)position;
	}

	private void RewardCoin()
	{
		//IL_006f: Expected VT, but got I4
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		GameObject childTransform = gameObject;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)childTransform, HierarchyPathType.DynamicManagers, (Vector3)0);
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v8 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v16 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 36;
		CharacterRendering instance = CharacterRendering.Instance;
		obj2 = instance;
		object obj3 = this + 32;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		obj3 = privacyPolicyUrl;
	}

	private void Update()
	{
		//IL_03a0: Expected I, but got Obj
		//IL_03b6: Expected Obj, but got I
		//IL_050d: Expected I, but got Obj
		//IL_0523: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_010e: Expected I, but got Obj
		//IL_0079: Expected I, but got Obj
		//IL_0195: Expected I, but got Obj
		//IL_01ab: Expected Obj, but got I
		//IL_0233: Expected I, but got Obj
		//IL_0249: Expected Obj, but got I
		//IL_01d6: Expected I, but got Obj
		//IL_0274: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v102 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<SYBO.Subway.Info.Characters.CharacterId, bool> hasCharacterBeenSeen = UserSave.hasCharacterBeenSeen;
		nint num3 = (nint)typeof(DoubleCoins);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<DoubleCoins>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 != null;
		if (hasCharacterBeenSeen != null)
		{
			if (flag)
			{
				nint num4 = (nint)typeof(DoubleCoins);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v96 (Il2CppClass<DoubleCoins>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (DoubleCoins.HasDoubleCoinsModifier)
			{
				_gameStats.CoinsCollectedRun = 4;
			}
			else
			{
				_gameStats.CoinsCollectedRun = 2;
			}
		}
		else
		{
			if (flag)
			{
				nint num5 = (nint)typeof(DoubleCoins);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v81 (Il2CppClass<DoubleCoins>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (DoubleCoins.HasDoubleCoinsModifier)
			{
				_gameStats.CoinsCollectedRun = 2;
			}
			else
			{
				_gameStats.CoinsCollectedRun = 1;
			}
		}
		if (_character.IsJumpingHigher)
		{
			_gameStats.CoinsCollectedOnLeftTrackIncrement();
		}
		nint num6 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v67 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		if (((Game)null).IsInPogostickMode)
		{
			_gameStats.CoinsWithPogoStickIncrement();
		}
		nint num8 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num9 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v61 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated2 = Game.IsInstantiated;
		if (((Game)null).HasSuperSneakers)
		{
			_gameStats.CoinsInAirIncrement();
		}
		Character character = _character;
		if (character.__trackIndex != 0)
		{
			Character character2 = _character;
			if (character2.__trackIndex == 1)
			{
				_gameStats.CoinsCollectedOnRightTrackIncrement();
			}
			else
			{
				Character character3 = _character;
				if (character3.__trackIndex == 2)
				{
					_gameStats.CoinMagnetCountIncrement();
				}
			}
		}
		else
		{
			_gameStats.CoinsCollectedOnCenterTrackIncrement();
		}
		GameStats gameStats = _gameStats;
		int coinsCollectedRaw = gameStats._coinsCollectedRaw + 1;
		gameStats._coinsCollectedRaw = coinsCollectedRaw;
		int coinsCollectedRawRun = gameStats._coinsCollectedRawRun + 1;
		gameStats._coinsCollectedRawRun = coinsCollectedRawRun;
	}

	public void PickupCoin(Coin coin)
	{
		bool flag = _activeCoins.Remove(coin);
	}

	private void RaiseOnCoinCollected()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_0308: Expected Obj, but got I4
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0341: Expected I, but got Obj
		//IL_0357: Expected Obj, but got I
		//IL_038b: Expected I, but got Obj
		//IL_03a1: Expected Obj, but got I
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 40;
		obj4 = obj;
		_ = -1;
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (Il2CppClass<DeviceInfo>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v103 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		nint num3 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v12 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v73 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25 (System.Int32)+8]");
		bool flag = (nint)0 == 0;
		object obj7 = obj2 + 28;
		CharacterRendering instance = CharacterRendering.Instance;
		object obj8 = instance + 248;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v19+8]");
		_ = 0;
		object obj9 = obj2 + 16;
		CharacterRendering instance2 = CharacterRendering.Instance;
		object obj10 = instance2 + 236;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v26+8]");
		_ = 0;
		throw new IndexOutOfRangeException();
	}

	public void ResetCoins()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (this.m_OnCoinCollected == null)
		{
			return;
		}
		nint num = (nint)typeof(EventArgs);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<System.EventArgs>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9 (Il2CppClass<System.EventArgs>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
	}

	public CoinManager()
	{
		//IL_005e: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list).Add((T)_activeCoins);
		int num = 0;
		while (num < list._size)
		{
			Coin coin = ((List<Coin>)(object)list).get_Item(num);
			coin.Activate();
			int num2 = num + 1;
			num = num2;
		}
	}
}
