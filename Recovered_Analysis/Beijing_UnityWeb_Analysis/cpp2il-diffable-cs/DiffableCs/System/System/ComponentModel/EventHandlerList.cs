namespace System.ComponentModel;

public sealed class EventHandlerList
{
	private sealed class ListEntry
	{
		internal ListEntry next; //Field offset: 0x8
		internal object key; //Field offset: 0xC
		internal Delegate handler; //Field offset: 0x10

	}

	private ListEntry head; //Field offset: 0x8
	private Component parent; //Field offset: 0xC

	public Delegate Item
	{
		 get { } //Length: 99
	}

	private ListEntry Find(object key) { }

	public Delegate get_Item(object key) { }

}

