namespace System;

internal sealed class LocalDataStoreHolder
{
	private LocalDataStore m_Store; //Field offset: 0x8

	public LocalDataStore Store
	{
		 get { } //Length: 349
	}

	public LocalDataStoreHolder(LocalDataStore store) { }

	protected override void Finalize() { }

	public LocalDataStore get_Store() { }

}

