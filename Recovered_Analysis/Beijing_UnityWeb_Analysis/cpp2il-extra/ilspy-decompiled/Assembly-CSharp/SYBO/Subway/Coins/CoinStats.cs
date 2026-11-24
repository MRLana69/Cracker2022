using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using SYBO.Subway.Managers;
using SYBO.Subway.Routes;
using UnityEngine;
using UnityEngine.Rendering;

namespace SYBO.Subway.Coins;

public class CoinStats
{
	public static CoinStats New;

	public static CoinStats Old;

	private int CreatedCoins__BackingField;

	private int DestroyedCoins__BackingField;

	private int ActivatedCoins__BackingField;

	private int DeactivatedCoins__BackingField;

	private int ActivatedSpawnPoints__BackingField;

	private int DeactivatedSpawnPoints__BackingField;

	private int DynamicCoinSpawns__BackingField;

	private int DynamicCoinDespawns__BackingField;

	public unsafe int CreatedCoins
	{
		get
		{
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected VT, but got Unknown
			//IL_00a0: Expected I4, but got Obj
			//IL_0064: Expected F4, but got Obj
			//IL_005f: Expected native int or pointer, but got VT
			//IL_0076: Expected F4, but got I
			//IL_0071: Expected native int or pointer, but got VT
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected Obj, but got Unknown
			Character character = default;
			Vector3 vector = (Vector3)(character + 12);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<Vector3> list = default;
			list._002Ector();
			RouteManager.RouteCreatedEventArgs e = default;
			RouteManager.RouteCreatedEventArgs e2 = default;
			while (true)
			{
				float unscaledCoinSpacing = ((CoinCurve)this).UnscaledCoinSpacing;
				bool flag = ((CoinCurve)this).IsSkippingCoin(unscaledCoinSpacing);
				if ((nint)e >= (flag ? 1 : 0))
				{
					break;
				}
				character.RouteManager_OnRouteCreated((object)this, e);
				((Vector3*)(nint)vector)->x = (float)character;
				((Vector3*)(nint)vector)->z = (nint)((Object)character).m_CachedPtr;
				list.Add(vector);
				e = (RouteManager.RouteCreatedEventArgs)(e2 + 1);
			}
			return (int)list;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0020: Expected Obj, but got I4
			((Renderer)DestroyedCoins__BackingField).shadowCastingMode = ShadowCastingMode.Off;
			((PickupDefault)ActivatedCoins__BackingField).IsActive = false;
			DeactivatedSpawnPoints__BackingField = 0;
			int num = value & 1;
		}
	}

	public int DestroyedCoins
	{
		get
		{
			return CreatedCoins__BackingField;
		}
		private set
		{
			CreatedCoins__BackingField = value;
		}
	}

	public int ActivatedCoins
	{
		get
		{
			return DestroyedCoins__BackingField;
		}
		private set
		{
			DestroyedCoins__BackingField = value;
		}
	}

	public int DeactivatedCoins
	{
		get
		{
			return ActivatedCoins__BackingField;
		}
		private set
		{
			ActivatedCoins__BackingField = value;
		}
	}

	public int ActivatedSpawnPoints
	{
		get
		{
			return DeactivatedCoins__BackingField;
		}
		private set
		{
			DeactivatedCoins__BackingField = value;
		}
	}

	public int DeactivatedSpawnPoints
	{
		get
		{
			return ActivatedSpawnPoints__BackingField;
		}
		private set
		{
			ActivatedSpawnPoints__BackingField = value;
		}
	}

	public int DynamicCoinSpawns
	{
		get
		{
			return DeactivatedSpawnPoints__BackingField;
		}
		private set
		{
			DeactivatedSpawnPoints__BackingField = value;
		}
	}

	public int DynamicCoinDespawns
	{
		get
		{
			return DynamicCoinSpawns__BackingField;
		}
		private set
		{
			DynamicCoinSpawns__BackingField = value;
		}
	}

	public void NotifyCoinCreated()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void NotifyCoinDestroyed()
	{
		int num = CreatedCoins__BackingField + 1;
		CreatedCoins__BackingField = num;
	}

	public void NotifyCoinActivated()
	{
		int num = DestroyedCoins__BackingField + 1;
		DestroyedCoins__BackingField = num;
	}

	public void NotifyCoinDeactivated()
	{
		int num = ActivatedCoins__BackingField + 1;
		ActivatedCoins__BackingField = num;
	}

	public void NotifySpawnPointActivated(int coins)
	{
		DynamicCoinDespawns__BackingField = coins;
	}

	public void NotifySpawnPointDeactivated(int coins)
	{
		int num = coins + ActivatedSpawnPoints__BackingField;
		ActivatedSpawnPoints__BackingField = num;
	}

	public void NotifyDynamicCoinSpawned()
	{
		int num = DeactivatedCoins__BackingField + 1;
		DeactivatedCoins__BackingField = num;
	}

	public void NotifyDynamicCoinsDespawned(int coins)
	{
		int num = coins + DeactivatedSpawnPoints__BackingField;
		DeactivatedSpawnPoints__BackingField = num;
	}

	public CoinStats()
	{
		int num = DynamicCoinSpawns__BackingField + 1;
		DynamicCoinSpawns__BackingField = num;
	}

	static CoinStats()
	{
		Character instance = Character.Instance;
		((DemoVideoModeManager)(object)instance)._002Ector();
	}
}
