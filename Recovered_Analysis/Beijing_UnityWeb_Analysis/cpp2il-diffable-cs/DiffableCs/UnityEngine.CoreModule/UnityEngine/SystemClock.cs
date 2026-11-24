namespace UnityEngine;

internal class SystemClock
{
	private static readonly DateTime s_Epoch; //Field offset: 0x0

	public static DateTime now
	{
		 get { } //Length: 5
	}

	private static SystemClock() { }

	public static DateTime get_now() { }

}

