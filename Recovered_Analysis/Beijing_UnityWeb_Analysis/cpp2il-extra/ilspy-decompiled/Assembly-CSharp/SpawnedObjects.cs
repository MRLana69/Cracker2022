using System;
using Cpp2ILInjected;
using Kiloo;
using SYBO.Common.Utilities;
using UnityEngine;
using UnityEngine.Networking;

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
		//IL_00e5: Expected I4, but got Obj
		//IL_00f3: Expected I, but got Obj
		//IL_0109: Expected Obj, but got I
		//IL_014f: Expected VT, but got I4
		//IL_014f: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00c7: Expected VT, but got I4
		//IL_00c7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"_RealTimeTracker";
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)gameObject).Exec();
		int layer = gameObject.layer;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)layer, HierarchyPathType.Dynamic, (Vector3)0);
		int layer2 = gameObject.layer;
		((HierarchyUtility)layer2)._002Ector();
		RealTimeTracker mInst = gameObject.AddComponent<RealTimeTracker>();
		RealTimeTracker.mInst = mInst;
		RealTimeTracker mInst2 = RealTimeTracker.mInst;
		float maxDelay = NetworkServer.maxDelay;
		mInst2.mRealTime = maxDelay;
		int layer3 = gameObject.layer;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)layer3, HierarchyPathType.DynamicManagers, (Vector3)0);
	}

	public static void countUP(string powerUp)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got F4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		obj = 10f;
		_ = 10f;
		_ = 10f;
		object obj3 = obj2 + 24;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj4 = powerUp + 12;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v33 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = powerUp + 24;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public static void startPowerUpCount()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SpawnedObjects);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SpawnedObjects>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SpawnedObjects);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v51 (Il2CppClass<SpawnedObjects>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
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

	public unsafe static void endPowerUpCount()
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got VT
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected VT, but got Unknown
		//IL_015a: Expected I8, but got Obj
		//IL_0155: Expected native int or pointer, but got VT
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_017d: Expected Ref, but got VT
		//IL_0189: Expected Obj, but got I8
		//IL_01ab: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC8A");
		DateTime today = CDateTime.Today;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v47 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 8;
		obj5 = today;
		obj2 = obj;
		DateTime dateTime = (DateTime)(obj2 + 32);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 40);
		formatProvider = (IFormatProvider)obj2;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj3 = num3;
		double num4 = (double)obj3 * 1E-07;
		nint num5 = (nint)typeof(SpawnedObjects);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v34 (Il2CppClass<SpawnedObjects>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(SpawnedObjects);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v41 (Il2CppClass<SpawnedObjects>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		startTime = num4;
	}

	public unsafe static void printInConsole()
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I4
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got VT
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected VT, but got Unknown
		//IL_0176: Expected I8, but got Obj
		//IL_0171: Expected native int or pointer, but got VT
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0199: Expected Ref, but got VT
		//IL_01a5: Expected Obj, but got I8
		//IL_01c7: Expected I, but got Obj
		//IL_01dd: Expected Obj, but got I
		//IL_01fa: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_0226: Expected Obj, but got F8
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC8A");
		DateTime today = CDateTime.Today;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v48 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 8;
		obj5 = today;
		obj2 = obj;
		DateTime dateTime = (DateTime)(obj2 + 32);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 40);
		formatProvider = (IFormatProvider)obj2;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj3 = num3;
		double num4 = (double)obj3 * 1E-07;
		nint num5 = (nint)typeof(SpawnedObjects);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v34 (Il2CppClass<SpawnedObjects>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		bool flag = obj6 == null;
		nint num6 = (nint)typeof(SpawnedObjects);
		if (!flag)
		{
			nint num7 = (nint)typeof(SpawnedObjects);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v42 (Il2CppClass<SpawnedObjects>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num6 = (nint)typeof(SpawnedObjects);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num6 = (nint)typeof(SpawnedObjects);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ L0_v6 (Il2CppClass<SpawnedObjects>)+5C]");
		object obj7 = -(-64);
		obj7 = num4;
	}

	public SpawnedObjects()
	{
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		//IL_01d6: Expected I, but got Obj
		//IL_01ec: Expected Obj, but got I
		//IL_0142: Expected I, but got Obj
		//IL_02ab: Expected I, but got Obj
		//IL_02c1: Expected Obj, but got I
		//IL_0217: Expected I, but got Obj
		//IL_0380: Expected I, but got Obj
		//IL_0396: Expected Obj, but got I
		//IL_02ec: Expected I, but got Obj
		//IL_0455: Expected I, but got Obj
		//IL_046b: Expected Obj, but got I
		//IL_03c1: Expected I, but got Obj
		//IL_052a: Expected I, but got Obj
		//IL_0540: Expected Obj, but got I
		//IL_0496: Expected I, but got Obj
		//IL_05ff: Expected I, but got Obj
		//IL_0615: Expected Obj, but got I
		//IL_056b: Expected I, but got Obj
		//IL_0b6f: Expected I, but got Obj
		//IL_0b85: Expected Obj, but got I
		//IL_06d4: Expected I, but got Obj
		//IL_06ea: Expected Obj, but got I
		//IL_0640: Expected I, but got Obj
		//IL_0bb0: Expected I, but got Obj
		//IL_07a9: Expected I, but got Obj
		//IL_07bf: Expected Obj, but got I
		//IL_0715: Expected I, but got Obj
		//IL_093a: Expected I, but got Obj
		//IL_0950: Expected Obj, but got I
		//IL_087e: Expected I, but got Obj
		//IL_0894: Expected Obj, but got I
		//IL_07ea: Expected I, but got Obj
		//IL_08bf: Expected I, but got Obj
		//IL_0a08: Expected I, but got Obj
		//IL_09a2: Expected I, but got Obj
		string str = ((string)this).ToLowerInvariant();
		string a = string.Copy(str);
		if (string.Equals(a, "dailyletter"))
		{
			nint num = (nint)typeof(SpawnedObjects);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v252 (Il2CppClass<SpawnedObjects>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SpawnedObjects);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v259 (Il2CppClass<SpawnedObjects>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = dailyLetterCounter + 1;
			dailyLetterCounter = num3;
		}
		else
		{
			string str2 = ((string)this).ToLowerInvariant();
			string a2 = string.Copy(str2);
			if (string.Equals(a2, "doublescoremultiplier"))
			{
				nint num4 = (nint)typeof(SpawnedObjects);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v238 (Il2CppClass<SpawnedObjects>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(SpawnedObjects);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v245 (Il2CppClass<SpawnedObjects>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num6 = doubleScoreMultiplierCounter + 1;
				doubleScoreMultiplierCounter = num6;
			}
			else
			{
				string str3 = ((string)this).ToLowerInvariant();
				string text = string.Copy(str3);
				if (text.EndsWith("jetpack"))
				{
					nint num7 = (nint)typeof(SpawnedObjects);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v224 (Il2CppClass<SpawnedObjects>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num8 = (nint)typeof(SpawnedObjects);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v231 (Il2CppClass<SpawnedObjects>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num9 = jetpackPickupCounter + 1;
					jetpackPickupCounter = num9;
				}
				else
				{
					string str4 = ((string)this).ToLowerInvariant();
					string a3 = string.Copy(str4);
					if (string.Equals(a3, "jumpbooster"))
					{
						nint num10 = (nint)typeof(SpawnedObjects);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v210 (Il2CppClass<SpawnedObjects>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num11 = (nint)typeof(SpawnedObjects);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v217 (Il2CppClass<SpawnedObjects>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num12 = jumpBoosterCounter + 1;
						jumpBoosterCounter = num12;
					}
					else
					{
						string str5 = ((string)this).ToLowerInvariant();
						string a4 = string.Copy(str5);
						if (string.Equals(a4, "magnetbooster"))
						{
							nint num13 = (nint)typeof(SpawnedObjects);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v196 (Il2CppClass<SpawnedObjects>)+BA]");
							object obj5 = (nint)0 & (nint)0x200;
							if (obj5 != null)
							{
								nint num14 = (nint)typeof(SpawnedObjects);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v203 (Il2CppClass<SpawnedObjects>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int num15 = magnetBoosterCounter + 1;
							magnetBoosterCounter = num15;
						}
						else
						{
							string str6 = ((string)this).ToLowerInvariant();
							string a5 = string.Copy(str6);
							if (string.Equals(a5, "mysterybox"))
							{
								nint num16 = (nint)typeof(SpawnedObjects);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v182 (Il2CppClass<SpawnedObjects>)+BA]");
								object obj6 = (nint)0 & (nint)0x200;
								if (obj6 != null)
								{
									nint num17 = (nint)typeof(SpawnedObjects);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v189 (Il2CppClass<SpawnedObjects>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								int num18 = mysteryBoxCounter + 1;
								mysteryBoxCounter = num18;
							}
							else
							{
								string str7 = ((string)this).ToLowerInvariant();
								string a6 = string.Copy(str7);
								if (string.Equals(a6, "savemetoken"))
								{
									nint num19 = (nint)typeof(SpawnedObjects);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S0_v168 (Il2CppClass<SpawnedObjects>)+BA]");
									object obj7 = (nint)0 & (nint)0x200;
									if (obj7 != null)
									{
										nint num20 = (nint)typeof(SpawnedObjects);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S0_v175 (Il2CppClass<SpawnedObjects>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									int num21 = saveMeTokenCounter + 1;
									saveMeTokenCounter = num21;
								}
								else
								{
									string str8 = ((string)this).ToLowerInvariant();
									string text2 = string.Copy(str8);
									if (text2.EndsWith("hunttoken"))
									{
										nint num22 = (nint)typeof(SpawnedObjects);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S0_v154 (Il2CppClass<SpawnedObjects>)+BA]");
										object obj8 = (nint)0 & (nint)0x200;
										if (obj8 != null)
										{
											nint num23 = (nint)typeof(SpawnedObjects);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v161 (Il2CppClass<SpawnedObjects>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										int num24 = huntTokenCounter + 1;
										huntTokenCounter = num24;
									}
									else
									{
										string str9 = ((string)this).ToLowerInvariant();
										string a7 = string.Copy(str9);
										if (string.Equals(a7, "coin"))
										{
											nint num25 = (nint)typeof(SpawnedObjects);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v140 (Il2CppClass<SpawnedObjects>)+BA]");
											object obj9 = (nint)0 & (nint)0x200;
											if (obj9 != null)
											{
												nint num26 = (nint)typeof(SpawnedObjects);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v147 (Il2CppClass<SpawnedObjects>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											int num27 = coinCounter + 1;
											coinCounter = num27;
										}
										else
										{
											string str10 = ((string)this).ToLowerInvariant();
											string a8 = string.Copy(str10);
											if (string.Equals(a8, "meter"))
											{
												nint num28 = (nint)typeof(SpawnedObjects);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v126 (Il2CppClass<SpawnedObjects>)+BA]");
												object obj10 = (nint)0 & (nint)0x200;
												if (obj10 != null)
												{
													nint num29 = (nint)typeof(SpawnedObjects);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S0_v133 (Il2CppClass<SpawnedObjects>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												int num30 = metersCounter + 1;
												metersCounter = num30;
											}
											else
											{
												string str11 = ((string)this).ToLowerInvariant();
												string a9 = string.Copy(str11);
												if (string.Equals(a9, "pogo"))
												{
													nint num31 = (nint)typeof(SpawnedObjects);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v112 (Il2CppClass<SpawnedObjects>)+BA]");
													object obj11 = (nint)0 & (nint)0x200;
													if (obj11 != null)
													{
														nint num32 = (nint)typeof(SpawnedObjects);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v119 (Il2CppClass<SpawnedObjects>)+74]");
														if ((nint)0 == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														}
													}
													int num33 = pogoCounter + 1;
													pogoCounter = num33;
												}
												else
												{
													string str12 = ((string)this).ToLowerInvariant();
													string text3 = string.Copy(str12);
													bool flag = text3.EndsWith("supermysterybox");
													nint num34 = (nint)typeof(SpawnedObjects);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S1_v74 (Il2CppClass<SpawnedObjects>)+BA]");
													object obj12 = (nint)0 & (nint)0x200;
													bool flag2 = obj12 != null;
													if (flag)
													{
														if (flag2)
														{
															nint num35 = (nint)typeof(SpawnedObjects);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ S0_v105 (Il2CppClass<SpawnedObjects>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														int num36 = superMysteryBoxCounter + 1;
														superMysteryBoxCounter = num36;
													}
													else
													{
														if (flag2)
														{
															nint num37 = (nint)typeof(SpawnedObjects);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S0_v94 (Il2CppClass<SpawnedObjects>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														int num38 = others + 1;
														others = num38;
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
		string str13 = ((string)this).ToLowerInvariant();
		string a10 = string.Copy(str13);
		if (string.Equals(a10, "dailyletter"))
		{
			return;
		}
		string str14 = ((string)this).ToLowerInvariant();
		string a11 = string.Copy(str14);
		if (string.Equals(a11, "coin"))
		{
			return;
		}
		string str15 = ((string)this).ToLowerInvariant();
		string a12 = string.Copy(str15);
		if (string.Equals(a12, "hunttoken"))
		{
			return;
		}
		string str16 = ((string)this).ToLowerInvariant();
		string a13 = string.Copy(str16);
		if (string.Equals(a13, "meter"))
		{
			return;
		}
		nint num39 = (nint)typeof(SpawnedObjects);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v32 (Il2CppClass<SpawnedObjects>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num40 = (nint)typeof(SpawnedObjects);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v39 (Il2CppClass<SpawnedObjects>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num41 = total + 1;
		total = num41;
	}

	static SpawnedObjects()
	{
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_012e: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(SpawnedObjects);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SpawnedObjects>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(SpawnedObjects);
		if (!flag)
		{
			nint num3 = (nint)typeof(SpawnedObjects);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<SpawnedObjects>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(SpawnedObjects);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(SpawnedObjects);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L0_v2 (Il2CppClass<SpawnedObjects>)+5C]");
		object obj2 = -(-64);
		nint num4 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v2 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v6 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		double num6 = (double)obj2 - startTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		startPowerUpCount();
	}
}
