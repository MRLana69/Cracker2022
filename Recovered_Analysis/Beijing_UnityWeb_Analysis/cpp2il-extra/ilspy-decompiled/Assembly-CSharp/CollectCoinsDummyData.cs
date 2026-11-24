using Cpp2ILInjected;

public static class CollectCoinsDummyData
{
	public static CollectCoinsDummy[] GetDefaultDummyList()
	{
		bool flag = Achievements._instance == null;
		bool flag2 = !flag;
		CollectCoinsDummy result = (CollectCoinsDummy)(object)Achievements._instance;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CollectCoinsDummy collectCoinsDummy = default;
			collectCoinsDummy.AssignRandomDummyFriendName();
			Achievements._instance = (Achievements)(object)collectCoinsDummy;
			result = collectCoinsDummy;
		}
		return (CollectCoinsDummy[])(object)result;
	}
}
