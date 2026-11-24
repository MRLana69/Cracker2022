namespace Data.Save;

public abstract class DataManager`1
{
	private static T _instance; //Field offset: 0x0
	private SaveGame <save>k__BackingField; //Field offset: 0x0

	protected static CloudData cloud
	{
		 get { } //Length: 109
	}

	protected static T instance
	{
		 get { } //Length: 424
	}

	protected static LocalData local
	{
		 get { } //Length: 116
	}

	protected static LocalDebugData localDebug
	{
		 get { } //Length: 109
	}

	protected SaveGame save
	{
		 get { } //Length: 209
		private set { } //Length: 8
	}

	protected DataManager`1() { }

	protected static CloudData get_cloud() { }

	protected static T get_instance() { }

	protected static LocalData get_local() { }

	protected static LocalDebugData get_localDebug() { }

	protected SaveGame get_save() { }

	private void OnSaveGameChanged() { }

	private void set_save(SaveGame value) { }

	public void SetSaveGame(SaveGame save) { }

}

