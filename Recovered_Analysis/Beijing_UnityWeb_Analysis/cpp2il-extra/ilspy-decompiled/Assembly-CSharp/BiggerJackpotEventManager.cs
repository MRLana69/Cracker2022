using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Kiloo;
using UnityEngine;
using WordHunt;

public class BiggerJackpotEventManager : IEventManager
{
	private SSEventType _eventType;

	private long _eventID;

	public static BiggerJackpotEventManager Create(SSEventType eventType, long eventID)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected I8, but got Unknown
		//IL_0142: Expected I8, but got I4
		object obj = eventType + 4;
		object obj2 = obj;
		if (obj == null)
		{
			return null;
		}
		nint num = default;
		object obj3 = num - 1;
		long num3 = default;
		object obj8;
		if (num != 1)
		{
			if ((nint)obj3 != 1)
			{
				if ((nint)obj3 == 2)
				{
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v9+1C]");
					object obj5 = (nint)0 & (nint)0x7F;
					object obj6 = obj5 + 43615;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v66 @ S1_v12 (should have been resolved before IL gen)");
					object obj7 = default;
					long num2 = obj7 - num3;
					num3 = num2;
					obj8 = obj;
				}
				else
				{
					num3 = -1L;
					obj8 = obj;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [eventType @ L0 (SSEventType)+10]");
				long num4 = 0 + num3;
				num3 = num4;
				obj8 = obj;
			}
		}
		else
		{
			obj8 = obj;
		}
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S2_v3+1C]");
		object obj10 = (nint)0 & (nint)0x7F;
		object obj11 = obj10 + 43615;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20 @ S2_v6 (should have been resolved before IL gen)");
		object obj12 = default;
		if (num3 > (long)obj12)
		{
			return null;
		}
		return (BiggerJackpotEventManager)1;
	}

	private void Initialize(SSEventType eventType, long eventID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public SSEventType GetEventType()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BiggerJackpotEventManager)+64]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+8]");
		return SSEventType.None;
	}

	public long GetEventID()
	{
		//IL_03fe: Expected I, but got Obj
		//IL_0414: Expected Obj, but got I
		//IL_067a: Expected I, but got Obj
		//IL_0690: Expected Obj, but got I
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected Obj, but got Unknown
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected Obj, but got Unknown
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected Obj, but got Unknown
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected Obj, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected Obj, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Obj, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected Obj, but got Unknown
		//IL_073b: Expected I8, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_044f: Expected I8, but got VT
		//IL_00ee: Expected I, but got Obj
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0465: Expected Obj, but got VT
		//IL_046e: Expected Obj, but got VT
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_02d6: Expected I, but got Obj
		//IL_02ec: Expected Obj, but got I
		//IL_0185: Expected I, but got Obj
		//IL_059e: Expected I, but got Obj
		//IL_05b4: Expected Obj, but got I
		//IL_01db: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I
		//IL_05e9: Expected I, but got Obj
		//IL_05ff: Expected Obj, but got I
		//IL_0317: Expected I, but got Obj
		//IL_04e3: Expected I, but got Obj
		//IL_04f9: Expected Obj, but got I
		//IL_0624: Expected Obj, but got VT
		//IL_064e: Expected Obj, but got I8
		//IL_0364: Expected I, but got Obj
		//IL_051e: Expected Obj, but got VT
		//IL_0526: Expected Obj, but got VT
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_0574: Expected I8, but got VT
		//IL_021c: Expected I, but got Obj
		//IL_03b1: Expected I, but got Obj
		//IL_0269: Expected I, but got Obj
		//IL_02b9: Expected I8, but got VT
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v140 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v134 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		Dictionary<string, string> dictionary = (Dictionary<string, string>)(obj3 - -64);
		object obj4 = obj3 + 48;
		object obj5 = obj3 + 56;
		object obj6 = obj3 + 40;
		object obj7 = obj3 + 32;
		object obj8 = obj3 + 24;
		object obj9 = obj3 + 16;
		object obj10 = obj3 + 8;
		bool flag = (byte)(~(Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT ? 1u : 0u)) != 0;
		bool flag2 = !flag;
		long result = (long)DateTime.MinValue;
		if (!flag2)
		{
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v45 (Il2CppClass<Globals>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num6 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v128 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = (byte)(~(Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_GRACE_PERIOD ? 1u : 0u)) != 0;
			bool flag4 = !flag3;
			result = (long)DateTime.MinValue;
			if (!flag4)
			{
				DateTime lastLoggedDailyData = AnalyticsSave.lastLoggedDailyData;
				nint num7 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v56 (Il2CppClass<System.DateTime>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num8 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v122 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj5 = lastLoggedDailyData;
				obj6 = DateTime.MinValue;
				obj4 = obj5;
				dictionary = (Dictionary<string, string>)obj6;
				object obj13 = obj4 & 0x3FFFFFFFFFFFFFFFL;
				object obj14 = dictionary & 0x3FFFFFFFFFFFFFFFL;
				if (obj13 != obj14)
				{
					DateTime today = CDateTime.Today;
					nint num9 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v93 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num10 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v118 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					DateTime lastTimeAVideoForKeysWasSeen = UserSave.lastTimeAVideoForKeysWasSeen;
					nint num11 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v100 (Il2CppClass<System.DateTime>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num12 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v114 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj7 = today;
					obj8 = lastTimeAVideoForKeysWasSeen;
					obj4 = obj7;
					dictionary = (Dictionary<string, string>)obj8;
					object obj17 = obj4 & 0x3FFFFFFFFFFFFFFFL;
					object obj18 = dictionary & 0x3FFFFFFFFFFFFFFFL;
					bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
					result = (long)DateTime.MinValue;
					if (!flag5)
					{
						DateTime lastLoggedDailyData2 = AnalyticsSave.lastLoggedDailyData;
						result = (long)lastLoggedDailyData2;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					nint num13 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S1_v28 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj19 = (nint)0 & (nint)0x200;
					if (obj19 != null)
					{
						nint num14 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v56 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					DateTime lastTimeAVideoForKeysWasSeen2 = UserSave.lastTimeAVideoForKeysWasSeen;
					nint num15 = (nint)typeof(TimeSpan);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v35 (Il2CppClass<System.TimeSpan>)+BA]");
					object obj20 = (nint)0 & (nint)0x200;
					if (obj20 != null)
					{
						nint num16 = (nint)typeof(TimeSpan);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S1_v52 (Il2CppClass<System.TimeSpan>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
					nint num17 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v75 (Il2CppClass<System.DateTime>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num18 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v86 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj9 = lastTimeAVideoForKeysWasSeen2;
					object obj22 = default;
					obj10 = obj22;
					obj4 = obj9;
					dictionary = (Dictionary<string, string>)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
					long num19 = default;
					obj3 = num19;
					dictionary = (Dictionary<string, string>)obj3;
					AdsSave.lastShowedProviders = dictionary;
					result = num19;
				}
			}
		}
		return result;
	}

	public bool IsEventActive()
	{
		return (byte)_eventType != 0;
	}

	public T GetEventValue<T>(out bool found)
	{
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_014a: Expected Obj, but got I4
		//IL_0155: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected VT, but got Unknown
		//IL_0030: Expected VT, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_01a0: Expected VT, but got Obj
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<BiggerJackpotEventManager>)+B6]");
		if ((nint)0 >= (nint)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			System.RuntimeType[] array = default;
			System.RuntimeType.SanityCheckGenericArguments(array, (System.RuntimeType[])(object)"Only single dimension arrays are supported.");
			((Array)array).InternalArray__IndexOf<WordHuntManager.WordHuntReward>((WordHuntManager.WordHuntReward)0);
		}
		int rank = ((Array)this).Rank;
		nint num2 = default;
		object obj3 = num2 + 24;
		object obj4 = 0;
		object obj7 = default;
		while (true)
		{
			if ((nint)obj4 < rank)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @906A");
				obj2 = found;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [found @ L1 (System.Boolean&)+8]");
				_ = 0;
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				NullReferenceException ex = new NullReferenceException();
				obj = ex;
				_ = ((Exception)ex)._className;
				if (obj7 != null)
				{
					break;
				}
				object obj8 = obj4 + 1;
				obj4 = obj8;
				continue;
			}
			object value = ((Array)this).GetValue((int[])null);
			return (T)(value - 1);
		}
		object value2 = ((Array)this).GetValue((int[])null);
		return (T)(value2 + obj4);
	}

	public unsafe void GetPopupTitle(out string firstLine, out string secondLine)
	{
		//IL_000e: Expected Obj, but got I
		object obj = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref secondLine) & (nint)1;
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref secondLine) == null)
		{
			_ = 0f;
		}
	}

	public unsafe void GetPopupDescription(out string firstTitle, out string secondTitle)
	{
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00f5: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_USE_EVENT_TESTER = Globals.DEBUG_USE_EVENT_TESTER;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		ref string reference;
		ref string reference2;
		if (dEBUG_USE_EVENT_TESTER)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v35 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("EVENTS_POPUP_TUESDAY_EVENT_TITLE_LINE_1");
			reference = ref *(string*)text;
			string text2 = Strings.GetDefault("EVENTS_POPUP_TUESDAY_EVENT_TITLE_LINE_2");
			reference2 = ref *(string*)text2;
			return;
		}
		if (!flag)
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v26 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("EVENTS_POPUP_TUESDAY_EVENT_TITLE_LINE_1");
		bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_title_first", out *(string*)text3);
		reference = ref *(flag2 ? ((string*)1) : ((string*)null));
		string text4 = Strings.GetDefault("EVENTS_POPUP_TUESDAY_EVENT_TITLE_LINE_2");
		bool flag3 = Strings.TryGetLocalizedOnlineSettings("event_popup_title_second", out *(string*)text4);
		reference2 = ref *(flag3 ? ((string*)1) : ((string*)null));
	}

	public unsafe void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine)
	{
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_0756: Expected Obj, but got I4
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected Obj, but got Unknown
		//IL_0773: Expected Obj, but got I4
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected Obj, but got Unknown
		//IL_0790: Expected Obj, but got I4
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Expected Obj, but got Unknown
		//IL_07ad: Expected Obj, but got I4
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected Obj, but got Unknown
		//IL_07ca: Expected Obj, but got I4
		//IL_07de: Expected I, but got Obj
		//IL_07f4: Expected Obj, but got I
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Expected VT, but got Unknown
		//IL_0c08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Expected VT, but got Unknown
		//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Expected Obj, but got Unknown
		//IL_0c24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c29: Expected Obj, but got Unknown
		//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Expected Obj, but got Unknown
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Expected Obj, but got Unknown
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Expected Obj, but got Unknown
		//IL_0c65: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_0834: Expected I, but got Obj
		//IL_084a: Expected Obj, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_0271: Expected I, but got Obj
		//IL_0287: Expected Obj, but got I
		//IL_0c93: Expected F4, but got Obj
		//IL_0c8e: Expected native int or pointer, but got VT
		//IL_0ca5: Expected F4, but got I
		//IL_0ca0: Expected native int or pointer, but got VT
		//IL_0cb2: Expected F4, but got Obj
		//IL_0cad: Expected native int or pointer, but got VT
		//IL_0cc4: Expected F4, but got I
		//IL_0cbf: Expected native int or pointer, but got VT
		//IL_0ce2: Expected F4, but got Obj
		//IL_0cdd: Expected native int or pointer, but got VT
		//IL_0cf4: Expected F4, but got I
		//IL_0cef: Expected native int or pointer, but got VT
		//IL_0d13: Expected Obj, but got F4
		//IL_08db: Expected F4, but got Obj
		//IL_08d6: Expected native int or pointer, but got VT
		//IL_08ed: Expected F4, but got I
		//IL_08e8: Expected native int or pointer, but got VT
		//IL_08fa: Expected F4, but got Obj
		//IL_08f5: Expected native int or pointer, but got VT
		//IL_090c: Expected F4, but got I
		//IL_0907: Expected native int or pointer, but got VT
		//IL_092a: Expected F4, but got Obj
		//IL_0925: Expected native int or pointer, but got VT
		//IL_093c: Expected F4, but got I
		//IL_0937: Expected native int or pointer, but got VT
		//IL_095b: Expected Obj, but got F4
		//IL_0877: Expected Obj, but got I
		//IL_0888: Expected Obj, but got I
		//IL_0899: Expected VT, but got Ref
		//IL_08a6: Expected F4, but got Obj
		//IL_08a1: Expected native int or pointer, but got VT
		//IL_08b8: Expected F4, but got I
		//IL_08b3: Expected native int or pointer, but got VT
		//IL_08c9: Expected Ref, but got VT
		//IL_01ce: Expected I, but got Obj
		//IL_02b2: Expected I, but got Obj
		//IL_04ac: Expected F4, but got Obj
		//IL_04a7: Expected native int or pointer, but got VT
		//IL_04c1: Expected F4, but got I
		//IL_04bc: Expected native int or pointer, but got VT
		//IL_04d2: Expected Ref, but got VT
		//IL_0507: Expected I, but got Obj
		//IL_051d: Expected Obj, but got I
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0a94: Expected F4, but got Obj
		//IL_0a8f: Expected native int or pointer, but got VT
		//IL_0aa9: Expected F4, but got I
		//IL_0aa4: Expected native int or pointer, but got VT
		//IL_0ab6: Expected F4, but got Obj
		//IL_0ab1: Expected native int or pointer, but got VT
		//IL_0acb: Expected F4, but got I
		//IL_0ac6: Expected native int or pointer, but got VT
		//IL_0afa: Expected Obj, but got Ref
		//IL_0b0c: Expected Obj, but got Ref
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Expected Obj, but got Unknown
		//IL_09b8: Expected I, but got Obj
		//IL_09ce: Expected Obj, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_0548: Expected I, but got Obj
		//IL_0d44: Expected F4, but got Obj
		//IL_0d3f: Expected native int or pointer, but got VT
		//IL_0d56: Expected F4, but got I
		//IL_0d51: Expected native int or pointer, but got VT
		//IL_0d63: Expected F4, but got Obj
		//IL_0d5e: Expected native int or pointer, but got VT
		//IL_0d75: Expected F4, but got I
		//IL_0d70: Expected native int or pointer, but got VT
		//IL_0d93: Expected F4, but got Obj
		//IL_0d8e: Expected native int or pointer, but got VT
		//IL_0da5: Expected F4, but got I
		//IL_0da0: Expected native int or pointer, but got VT
		//IL_0dc4: Expected Obj, but got F4
		//IL_0b36: Expected F4, but got Obj
		//IL_0b31: Expected native int or pointer, but got VT
		//IL_0b4b: Expected F4, but got I
		//IL_0b46: Expected native int or pointer, but got VT
		//IL_0b5d: Expected Obj, but got Ref
		//IL_0b5d: Expected Obj, but got VT
		//IL_036a: Expected I, but got Obj
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected Obj, but got Unknown
		//IL_040d: Expected I, but got Obj
		//IL_0423: Expected Obj, but got I
		//IL_05d9: Expected I, but got Obj
		//IL_05ef: Expected Obj, but got I
		//IL_09f8: Expected F4, but got Obj
		//IL_09f3: Expected native int or pointer, but got VT
		//IL_0a0a: Expected F4, but got I
		//IL_0a05: Expected native int or pointer, but got VT
		//IL_0a17: Expected F4, but got Obj
		//IL_0a12: Expected native int or pointer, but got VT
		//IL_0a29: Expected F4, but got I
		//IL_0a24: Expected native int or pointer, but got VT
		//IL_0a47: Expected F4, but got Obj
		//IL_0a42: Expected native int or pointer, but got VT
		//IL_0a59: Expected F4, but got I
		//IL_0a54: Expected native int or pointer, but got VT
		//IL_0a78: Expected Obj, but got F4
		//IL_044e: Expected I, but got Obj
		//IL_061a: Expected I, but got Obj
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected Obj, but got Unknown
		//IL_0bbc: Expected Obj, but got F4
		//IL_0bec: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 + 120;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 108;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 96;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 84;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 72;
		obj6 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v236 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 144);
		Vector3 vector2 = (Vector3)(obj2 + 132);
		Transform transform = (Transform)(obj2 + 60);
		Transform transform2 = (Transform)(obj2 + 48);
		Transform transform3 = (Transform)(obj2 + 36);
		object obj8 = obj2 + 24;
		object obj9 = obj2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BiggerJackpotEventManager)+24]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BiggerJackpotEventManager)+24]");
			((UIDragCamera)0).OnPress((byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref firstLine) != 0);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BiggerJackpotEventManager)+30]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj12 = default;
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref secondLine) != null)
		{
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref secondLine) == (void*)1)
			{
				goto IL_020d;
			}
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref secondLine) != (void*)2)
			{
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref secondLine) == (void*)3)
				{
					goto IL_020d;
				}
				object obj11 = obj12 + 40;
				transform = (Transform)obj11;
				Transform transform4 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v207+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				object obj13 = obj12 + 16;
				transform2 = (Transform)obj13;
				Transform transform5 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S1_v212+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v179 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num4 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S0_v193 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)transform;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)transform2;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				Vector3 vector3 = vector2 - vector;
				((Vector3*)(nint)vector)->x = (float)transform3;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
				Vector3 vector4 = vector / 0.5f;
				obj = vector2.x;
				_ = vector2.z;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BiggerJackpotEventManager)+C]");
				if ((nint)0 != 0)
				{
					object obj15 = obj12 + 40;
					transform = (Transform)obj15;
					object obj16 = obj15;
				}
				else
				{
					object obj17 = obj12 + 16;
					transform = (Transform)obj17;
					object obj16 = obj17;
				}
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ L11_v5+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				object obj18 = obj12 + 52;
				transform2 = (Transform)obj18;
				Transform transform7 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S1_v173+8]");
				((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
				nint num5 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v152 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num6 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v168 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)transform;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)transform2;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				Vector3 vector5 = vector2 - vector;
				((Vector3*)(nint)vector)->x = (float)transform3;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
				Vector3 vector6 = vector / 0.5f;
				obj6 = vector2.x;
				_ = vector2.z;
				obj = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
				_ = 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BiggerJackpotEventManager)+C]");
			if ((nint)0 != 0)
			{
				object obj20 = obj12 + 16;
				transform = (Transform)obj20;
				Transform transform8 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v133+8]");
				((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
				object obj21 = obj12 + 28;
				transform2 = (Transform)obj21;
				object obj22 = obj21;
			}
			else
			{
				object obj23 = obj12 + 28;
				transform = (Transform)obj23;
				Transform transform9 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v125+8]");
				((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
				object obj24 = obj12 + 40;
				transform2 = (Transform)obj24;
				object obj22 = obj24;
			}
			Transform transform10 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ L6_v5+8]");
			((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v96 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v112 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)transform;
			((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)transform2;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			Vector3 vector7 = vector2 - vector;
			((Vector3*)(nint)vector)->x = (float)transform3;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
			Vector3 vector8 = vector / 0.5f;
			obj5 = vector2.x;
			_ = vector2.z;
			obj = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
			_ = 0;
		}
		goto IL_0867;
		IL_020d:
		object obj26 = obj12 + 40;
		transform = (Transform)obj26;
		Transform transform11 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v141+8]");
		((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
		object obj27 = obj12 + 16;
		transform2 = (Transform)obj27;
		Transform transform12 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v146+8]");
		((UnityEngine.Object)transform12).m_CachedPtr = (IntPtr)0;
		nint num9 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v127 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num10 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v141 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)transform;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)transform2;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		Vector3 vector9 = vector2 - vector;
		((Vector3*)(nint)vector)->x = (float)transform3;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
		Vector3 vector10 = vector / 0.5f;
		obj = vector2.x;
		_ = vector2.z;
		goto IL_0867;
		IL_0867:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BiggerJackpotEventManager)+30]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S0_v33+68]");
		Camera anchorCamera = ((UIRect)0).anchorCamera;
		transform.position = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref firstLine);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		transform2.Internal_LookAt_Injected(ref *(Vector3*)anchorCamera, ref *(Vector3*)vector);
		obj3 = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		transform3.Internal_LookAt_Injected(ref *(Vector3*)anchorCamera, ref *(Vector3*)vector);
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj9 = transform3;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		nint num11 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S0_v50 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num12 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S0_v87 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj8;
		Vector3 vector11 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v34+8]");
		((Vector3*)(nint)vector11)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v36+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		UIWidget component = ((Component)System.Runtime.CompilerServices.Unsafe.AsPointer(ref firstLine)).GetComponent<UIWidget>();
		object obj31 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref secondLine, 1));
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref secondLine) != (void*)1 && ((nint)obj31 == 1 || (nint)obj31 != 2))
		{
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ S0_v70 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ S0_v83 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BiggerJackpotEventManager)+C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BiggerJackpotEventManager)+C]");
					if ((nint)0 == 1)
					{
						float num15 = ((System.Runtime.CompilerServices.Unsafe.AsPointer(ref secondLine) != (void*)2) ? 0.5f : (-0.5f));
						float num16 = num15 * (float)component.mWidth;
						float num17 = (float)obj4 + num16;
						obj4 = num17;
					}
				}
				else
				{
					object obj33 = obj4 + 4;
					float num18 = ((System.Runtime.CompilerServices.Unsafe.AsPointer(ref secondLine) != (void*)2) ? 0.5f : (-0.5f));
					float num19 = num18 * (float)component.mHeight;
					float num20 = (float)obj33 + num19;
					obj33 = num20;
				}
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector)->z = 0f;
		KeyValuePair<bool, string> keyValuePair = ((FPSLog)vector).SendRequest((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref thirdLine), 8f);
	}

	public void SaveProgress()
	{
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		_ = 1;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v24 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 8;
		Vector2 one = Vector2.one;
		object obj4 = obj3 + 16;
		obj4 = obj2;
		Vector2 one2 = Vector2.one;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
