using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using UnityEngine;

public class UIPowerupHandler : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ActivePowerup, bool> _003C_003E9__5_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal bool _003CSetPowerupSlots_003Eb__5_0(ActivePowerup powerup)
		{
			return powerup.type == PowerupType.mysteryPowerup;
		}
	}

	private int _screenOffset = 26;

	private List<UIPowerupHelper> _powerupSlots;

	private void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Obj, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_03a3: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<ActivePowerup> list = default;
		list._002Ector();
		ActivePowerup activePowerup = default;
		activePowerup.type = PowerupType.supersneakers;
		list.Add(activePowerup);
		ActivePowerup activePowerup2 = default;
		activePowerup2.type = PowerupType.plusMultiplier;
		list.Add(activePowerup2);
		ActivePowerup activePowerup3 = default;
		activePowerup3.type = PowerupType.doubleJump;
		list.Add(activePowerup3);
		ActivePowerup activePowerup4 = default;
		activePowerup4.type = PowerupType.jetpack;
		list.Add(activePowerup4);
		ActivePowerup activePowerup5 = default;
		activePowerup5.type = PowerupType.hoverboard;
		list.Add(activePowerup5);
		ActivePowerup activePowerup6 = default;
		activePowerup6.type = PowerupType.doubleMultiplier;
		list.Add(activePowerup6);
		ActivePowerup activePowerup7 = default;
		activePowerup7.type = PowerupType.coinmagnet;
		list.Add(activePowerup7);
		ActivePowerup activePowerup8 = default;
		activePowerup8.type = PowerupType.doubleCoinsMysteryPowerup;
		list.Add(activePowerup8);
		ActivePowerup activePowerup9 = default;
		activePowerup9.type = PowerupType.headstart;
		list.Add(activePowerup9);
		SetPowerupSlots(list);
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B049");
	}

	private void Update()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0037: Expected I4, but got Obj
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		GameStats instance = GameStats.Instance;
		List<ActivePowerup> listOfActivePowerups = instance._listOfActivePowerups;
		SetPowerupSlots(instance._listOfActivePowerups);
		int num = listOfActivePowerups._size;
		UIPowerupHandler uIPowerupHandler = null;
		while (true)
		{
			int num2 = num - 1;
			if (num2 <= -1)
			{
				break;
			}
			UIPowerupHandler uIPowerupHandler2 = (UIPowerupHandler)(uIPowerupHandler + 1);
			num = num2;
			uIPowerupHandler = uIPowerupHandler2;
		}
		while (true)
		{
			List<UIPowerupHelper> powerupSlots = _powerupSlots;
			if ((nint)uIPowerupHandler < powerupSlots._size)
			{
				UIPowerupHelper slot = _powerupSlots.get_Item((int)uIPowerupHandler);
				uIPowerupHandler.DisablePowerupSlot(slot);
				UIPowerupHandler uIPowerupHandler3 = (UIPowerupHandler)(uIPowerupHandler + 1);
				uIPowerupHandler = uIPowerupHandler3;
				continue;
			}
			break;
		}
	}

	private void DisablePowerupSlot(UIPowerupHelper slot)
	{
		GameObject gameObject = slot.gameObject;
		if (gameObject.activeInHierarchy)
		{
			slot.HidePowerupSlot();
			GameObject gameObject2 = slot.gameObject;
			gameObject2.SetActive(value: false);
		}
	}

	private void SetPowerupSlots(List<ActivePowerup> powerups)
	{
		int num = powerups._size - 1;
		int num2 = num;
		Func<ActivePowerup, bool> func = default;
		_003C_003Ec obj2 = default;
		int index = default;
		int num3 = default;
		while (num2 > -1)
		{
			ActivePowerup activePowerup = powerups.get_Item(num2);
			_003C_003Ec obj;
			Func<ActivePowerup, bool> func2;
			if (activePowerup.type == PowerupType.hoverboard)
			{
				bool flag = _003C_003Ec._003C_003E9__5_0 == null;
				bool flag2 = !flag;
				func = _003C_003Ec._003C_003E9__5_0;
				if (!flag2)
				{
					throw new ArgumentException();
				}
				bool flag3 = Enumerable.Any(powerups, func);
				obj = obj2;
				func2 = func;
				if (flag3)
				{
					goto IL_00e7;
				}
			}
			UIPowerupHelper uIPowerupHelper = _powerupSlots.get_Item(index);
			ActivePowerup powerupSlot = powerups.get_Item(num2);
			uIPowerupHelper.SetPowerupSlot(powerupSlot);
			obj = obj2;
			func2 = func;
			goto IL_00e7;
			IL_00e7:
			UIPowerupHelper uIPowerupHelper2 = _powerupSlots.get_Item(index);
			GameObject gameObject = uIPowerupHelper2.gameObject;
			if (!gameObject.activeInHierarchy)
			{
				UIPowerupHelper uIPowerupHelper3 = _powerupSlots.get_Item(index);
				GameObject gameObject2 = uIPowerupHelper3.gameObject;
				gameObject2.SetActive(value: true);
			}
			index = num3 + 1;
			int num4 = num2 - 1;
			num2 = num4;
			obj2 = obj;
			func = func2;
		}
	}

	public int getNumberOfSpaces(int i)
	{
		//IL_0081: Expected F8, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected I4, but got Unknown
		//IL_0061: Expected F8, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected I4, but got Unknown
		float num = (float)i * 0.5f;
		if ((i & 1) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Ceiling not resolved\"");
			double num2 = Math.Abs((double)num);
			double num3 = ((!(num2 < 2147483648.0)) ? (-2147483648.0) : ((double)num));
			double num4 = num3 + 1.0;
			int num5 = _screenOffset / 4;
			return (int)(num4 * num5);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Ceiling not resolved\"");
		double num6 = Math.Abs((double)num);
		double num7 = ((!(num6 < 2147483648.0)) ? (-2147483648.0) : ((double)num));
		int num8 = _screenOffset / 4;
		return (int)(num7 * num8);
	}

	public UIPowerupHandler()
	{
		List<UIPowerupHelper> list = default;
		list._002Ector();
		_powerupSlots = list;
		base._002Ector();
	}
}
