using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;

namespace Kiloo.Analytics;

internal class Event
{
	public readonly string name;

	public readonly Dictionary<string, object> parameters;

	public Event(string name, Dictionary<string, object> parameters = null)
	{
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_0303: Expected I4, but got Obj
		//IL_015d: Expected I, but got Obj
		//IL_02da: Expected Obj, but got I4
		if (this != null)
		{
			if ((nint)this != 1)
			{
				if ((nint)this != 2)
				{
					if ((nint)this != 3)
					{
						if ((nint)this != 4)
						{
							if ((nint)this != 5)
							{
								if ((nint)this != 6)
								{
									if ((nint)this != 7)
									{
										if ((nint)this != 8)
										{
											if ((nint)this != 9)
											{
												if ((nint)this == 10)
												{
													bool isPaused = ApplicationState.isPaused;
													name((Event)isPaused);
												}
											}
											else
											{
												Event aBTestDailyReportValue = Tracker.GetABTestDailyReportValue((string)(object)parameters);
												name(aBTestDailyReportValue);
											}
										}
										else
										{
											Event consentPrivacyLinkClickedEvent = Tracker.GetConsentPrivacyLinkClickedEvent();
											name(consentPrivacyLinkClickedEvent);
										}
									}
									else
									{
										NullReferenceException obj = new NullReferenceException();
										name((Event)(object)obj);
									}
								}
								else
								{
									Event consentGivenEvent = Tracker.GetConsentGivenEvent();
									name(consentGivenEvent);
								}
							}
							else
							{
								Event consentWithdrawnEvent = Tracker.GetConsentWithdrawnEvent((string)(object)parameters);
								name(consentWithdrawnEvent);
							}
						}
						else
						{
							Event playerBirthday = Tracker.GetPlayerBirthday();
							name(playerBirthday);
						}
					}
					else
					{
						Event singleValidPurchase = Tracker.GetSingleValidPurchase();
						name(singleValidPurchase);
					}
				}
				else
				{
					Event syboUserId = Tracker.GetSyboUserId();
					name(syboUserId);
				}
			}
			else
			{
				Event dailyData = Tracker.GetDailyData();
				name(dailyData);
			}
			return;
		}
		nint num = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RunTracker.OnRunEnded((byte)(int)name != 0);
	}
}
