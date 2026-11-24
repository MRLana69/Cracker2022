using System;
using Cpp2ILInjected;

public class LocalNotificationsManager
{
	public const int TIME_OF_NOTIFICATION = 17;

	public const int TIME_OF_NOTIFICATION_DAILY_VIDEO = 19;

	public const string ONLINE_SETTING = "enable_local_notifications";

	public static DateTime GetNextNotificationTimeForVideos()
	{
		//IL_0046: Expected Obj, but got I
		//IL_0053: Expected VT, but got I
		//IL_0036: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [3BC134]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [3BC134]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v5+18]");
			return (DateTime)0;
		}
		return (DateTime)0;
	}

	public LocalNotificationsManager()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
