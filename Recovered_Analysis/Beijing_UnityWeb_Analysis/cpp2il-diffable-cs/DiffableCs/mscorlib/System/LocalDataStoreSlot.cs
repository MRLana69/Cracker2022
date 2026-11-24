namespace System;

public sealed class LocalDataStoreSlot
{
	private LocalDataStoreMgr m_mgr; //Field offset: 0x8
	private int m_slot; //Field offset: 0xC
	private long m_cookie; //Field offset: 0x10

	internal long Cookie
	{
		 get { } //Length: 6
	}

	internal LocalDataStoreMgr Manager
	{
		 get { } //Length: 6
	}

	internal int Slot
	{
		 get { } //Length: 6
	}

	internal LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie) { }

	protected override void Finalize() { }

	internal long get_Cookie() { }

	internal LocalDataStoreMgr get_Manager() { }

	internal int get_Slot() { }

}

