using System;
using Cpp2ILInjected;
using Kiloo;

public class SpawnedObjects
{
	private static int dailyLetterCounter;

	private static int doubleScoreMultiplierCounter;

	private static int jetpackPickupCounter;

	private static int jumpBoosterCounter;

	private static int magnetBoosterCounter;

	private static int mysteryBoxCounter;

	private static int saveMeTokenCounter;

	private static int huntTokenCounter;

	private static int coinCounter;

	private static int pogoCounter;

	private static int superMysteryBoxCounter;

	private static int others;

	public static int metersCounter;

	private static int total;

	private static double startTime;

	private static double endTime;

	private static void resetCounter()
	{
		dailyLetterCounter = 0;
		doubleScoreMultiplierCounter = 0;
		jetpackPickupCounter = 0;
		jumpBoosterCounter = 0;
		magnetBoosterCounter = 0;
		mysteryBoxCounter = 0;
		saveMeTokenCounter = 0;
		huntTokenCounter = 0;
		coinCounter = 0;
		others = 0;
		metersCounter = 0;
		total = 0;
		pogoCounter = 0;
		superMysteryBoxCounter = 0;
	}

	public static void countUP(string powerUp)
	{
		string text = powerUp.ToLower();
		string text2 = text.Trim();
		if (text2.Equals("dailyletter"))
		{
			int num = dailyLetterCounter + 1;
			dailyLetterCounter = num;
		}
		else
		{
			string text3 = powerUp.ToLower();
			string text4 = text3.Trim();
			if (text4.Equals("doublescoremultiplier"))
			{
				int num2 = doubleScoreMultiplierCounter + 1;
				doubleScoreMultiplierCounter = num2;
			}
			else
			{
				string text5 = powerUp.ToLower();
				string text6 = text5.Trim();
				if (text6.Contains("jetpack"))
				{
					int num3 = jetpackPickupCounter + 1;
					jetpackPickupCounter = num3;
				}
				else
				{
					string text7 = powerUp.ToLower();
					string text8 = text7.Trim();
					if (text8.Equals("jumpbooster"))
					{
						int num4 = jumpBoosterCounter + 1;
						jumpBoosterCounter = num4;
					}
					else
					{
						string text9 = powerUp.ToLower();
						string text10 = text9.Trim();
						if (text10.Equals("magnetbooster"))
						{
							int num5 = magnetBoosterCounter + 1;
							magnetBoosterCounter = num5;
						}
						else
						{
							string text11 = powerUp.ToLower();
							string text12 = text11.Trim();
							if (text12.Equals("mysterybox"))
							{
								int num6 = mysteryBoxCounter + 1;
								mysteryBoxCounter = num6;
							}
							else
							{
								string text13 = powerUp.ToLower();
								string text14 = text13.Trim();
								if (text14.Equals("savemetoken"))
								{
									int num7 = saveMeTokenCounter + 1;
									saveMeTokenCounter = num7;
								}
								else
								{
									string text15 = powerUp.ToLower();
									string text16 = text15.Trim();
									if (text16.Contains("hunttoken"))
									{
										int num8 = huntTokenCounter + 1;
										huntTokenCounter = num8;
									}
									else
									{
										string text17 = powerUp.ToLower();
										string text18 = text17.Trim();
										if (text18.Equals("coin"))
										{
											int num9 = coinCounter + 1;
											coinCounter = num9;
										}
										else
										{
											string text19 = powerUp.ToLower();
											string text20 = text19.Trim();
											if (text20.Equals("meter"))
											{
												int num10 = metersCounter + 1;
												metersCounter = num10;
											}
											else
											{
												string text21 = powerUp.ToLower();
												string text22 = text21.Trim();
												if (text22.Equals("pogo"))
												{
													int num11 = pogoCounter + 1;
													pogoCounter = num11;
												}
												else
												{
													string text23 = powerUp.ToLower();
													string text24 = text23.Trim();
													if (text24.Contains("supermysterybox"))
													{
														int num12 = superMysteryBoxCounter + 1;
														superMysteryBoxCounter = num12;
													}
													else
													{
														int num13 = others + 1;
														others = num13;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		string text25 = powerUp.ToLower();
		string text26 = text25.Trim();
		if (text26.Equals("dailyletter"))
		{
			return;
		}
		string text27 = powerUp.ToLower();
		string text28 = text27.Trim();
		if (text28.Equals("coin"))
		{
			return;
		}
		string text29 = powerUp.ToLower();
		string text30 = text29.Trim();
		if (!text30.Equals("hunttoken"))
		{
			string text31 = powerUp.ToLower();
			string text32 = text31.Trim();
			if (!text32.Equals("meter"))
			{
				int num14 = total + 1;
				total = num14;
			}
		}
	}

	public unsafe static void startPowerUpCount()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected VT, but got Unknown
		//IL_009b: Expected native int or pointer, but got VT
		//IL_0028: Expected VT, but got I
		//IL_0034: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		obj = 0;
		DateTime dateTime = (DateTime)(obj + 8);
		*(DateTime*)(nint)dateTime = new DateTime(1970, 1, 1, 8, 0, 0, DateTimeKind.Utc);
		DateTime utcNow = CDateTime.UtcNow;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		TimeSpan timeSpan = utcNow - (DateTime)0;
		obj = timeSpan;
		double num = (double)obj * 1E-07;
		startTime = num;
	}

	public unsafe static void endPowerUpCount()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected VT, but got Unknown
		//IL_009b: Expected native int or pointer, but got VT
		//IL_0028: Expected VT, but got I
		//IL_0034: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		obj = 0;
		DateTime dateTime = (DateTime)(obj + 8);
		*(DateTime*)(nint)dateTime = new DateTime(1970, 1, 1, 8, 0, 0, DateTimeKind.Utc);
		DateTime utcNow = CDateTime.UtcNow;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		TimeSpan timeSpan = utcNow - (DateTime)0;
		obj = timeSpan;
		double num = (double)obj * 1E-07;
		endTime = num;
	}

	public static void printInConsole()
	{
		double num = endTime - startTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		resetCounter();
	}
}
