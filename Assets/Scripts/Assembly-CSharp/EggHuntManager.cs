using System;
using Cpp2ILInjected;

public static class EggHuntManager
{
	private static readonly Hoverboards.BoardType HOVERBOARDTYPE = Hoverboards.BoardType.chick;

	private static Action m_EggCountUpdated;

	public static event Action EggCountUpdated
	{
		add
		{
			Delegate obj = EggHuntManager.m_EggCountUpdated;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == EggHuntManager.m_EggCountUpdated;
				Action eggCountUpdated = action;
				if (!flag)
				{
					eggCountUpdated = EggHuntManager.m_EggCountUpdated;
				}
				EggHuntManager.m_EggCountUpdated = eggCountUpdated;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = EggHuntManager.m_EggCountUpdated;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = EggHuntManager.m_EggCountUpdated;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == EggHuntManager.m_EggCountUpdated;
				Action eggCountUpdated = action;
				if (!flag)
				{
					eggCountUpdated = EggHuntManager.m_EggCountUpdated;
				}
				EggHuntManager.m_EggCountUpdated = eggCountUpdated;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = EggHuntManager.m_EggCountUpdated;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static bool ShouldSpawnEggs()
	{
		return true;
	}

	public unsafe static void EggPickedUp()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		int num = instance._amountOfSeasonalEggs + 1;
		if (instance._amountOfSeasonalEggs != num)
		{
			instance._dirty = true;
			instance._amountOfSeasonalEggs = num;
		}
		if (CanUnlockEgg())
		{
			Hoverboards.Board board = Hoverboards.boardData.get_Item(HOVERBOARDTYPE);
			instance.UnlockHoverboard(HOVERBOARDTYPE);
			string text = Strings.Get(board.name);
			char c = text.get_Chars(0);
			char c2 = char.ToUpper(c);
			char c3 = (char)(obj + 14);
			string text2 = ((char*)(ushort)c3)->ToString();
			string text3 = Strings.Get(board.name);
			string text4 = text3.Substring(1);
			string text5 = text2 + text4;
		}
		if (EggHuntManager.m_EggCountUpdated != null)
		{
			Action eggCountUpdated = EggHuntManager.m_EggCountUpdated;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v113.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public static bool TryToUnlockEggBoard()
	{
		bool flag = CanUnlockEgg();
		if (flag)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			instance.UnlockHoverboard(HOVERBOARDTYPE);
		}
		return flag;
	}

	private static bool CanUnlockEgg()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		int maximumNumberOfEggs = GetMaximumNumberOfEggs();
		if (maximumNumberOfEggs <= instance._amountOfSeasonalEggs)
		{
			bool flag = instance.IsHoverboardUnlocked(HOVERBOARDTYPE);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		return false;
	}

	public static bool HasEggHuntExpired()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = instance.isBoardActive(HOVERBOARDTYPE);
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public static int GetMaximumNumberOfEggs()
	{
		Hoverboards.Board board = Hoverboards.boardData.get_Item(HOVERBOARDTYPE);
		return board.price;
	}

	public static int GetCurrentNumberOfEggs()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return instance._amountOfSeasonalEggs;
	}
}
