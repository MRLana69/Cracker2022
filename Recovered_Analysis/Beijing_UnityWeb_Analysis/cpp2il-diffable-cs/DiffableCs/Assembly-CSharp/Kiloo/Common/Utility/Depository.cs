namespace Kiloo.Common.Utility;

public static class Depository
{
	private struct Deposit
	{
		public object context; //Field offset: 0x0
		public object deposit; //Field offset: 0x4

	}

	private static int _nextTicket; //Field offset: 0x0
	private static readonly Dictionary<int, Deposit> _sharedStore; //Field offset: 0x4

	private static Depository() { }

	public static int CheckIn(object deposit, object context) { }

	public static object CheckOut(int ticket) { }

	public static int GetNextTicket() { }

	public static void RemoveAll() { }

	public static IDictionary<int, object> RemoveByContext(object context) { }

}

