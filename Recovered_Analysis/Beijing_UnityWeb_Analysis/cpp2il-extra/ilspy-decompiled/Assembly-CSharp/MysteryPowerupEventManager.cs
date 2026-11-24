using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using InApp;
using Info;
using Kiloo.Common;
using SYBO.Subway.Info;

public class MysteryPowerupEventManager : IEventManager
{
	private SSEventType _eventType;

	private long _eventID;

	public static MysteryPowerupEventManager Create(SSEventType eventType, long eventID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MysteryPowerupEventManager mysteryPowerupEventManager = default;
		mysteryPowerupEventManager._eventType = SSEventType.ExpiredLimitedCharacter;
		mysteryPowerupEventManager._eventType = eventType;
		mysteryPowerupEventManager._eventID = eventID;
		return mysteryPowerupEventManager;
	}

	private void Initialize(SSEventType eventType, long eventID)
	{
		_eventType = eventType;
		_eventID = eventID;
	}

	public unsafe SSEventType GetEventType()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		ref bool reference = ref *(bool*)null;
		Characters.CharacterId eventValue = ((ExpiredLimitedCharacterEventManager)this).GetEventValue<Characters.CharacterId>(out reference);
		if (reference)
		{
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v16 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v23 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = CharacterManager.IsCollectionComplete(eventValue);
			return (SSEventType)((flag ? 1 : 0) ^ 1);
		}
		return SSEventType.None;
	}

	public long GetEventID()
	{
		return _eventID;
	}

	public bool IsEventActive()
	{
		return (byte)_eventType != 0;
	}

	public unsafe T GetEventValue<T>(out bool found)
	{
		//IL_0632: Expected Obj, but got I
		//IL_0640: Expected Obj, but got I
		//IL_064e: Expected Obj, but got I
		//IL_065c: Expected Obj, but got I
		//IL_066a: Expected Obj, but got I
		//IL_0678: Expected Obj, but got I
		//IL_0686: Expected Obj, but got I
		//IL_0694: Expected Obj, but got I
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_06d5: Expected Obj, but got I
		//IL_06e2: Expected I, but got Obj
		//IL_070a: Expected I, but got Obj
		//IL_0754: Expected I, but got Obj
		//IL_076a: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_09d0: Expected Obj, but got I
		//IL_09dd: Expected I, but got Obj
		//IL_0a05: Expected I, but got Obj
		//IL_07b6: Expected I, but got Obj
		//IL_07cc: Expected Obj, but got I
		//IL_0164: Expected I, but got Obj
		//IL_0917: Expected Obj, but got I
		//IL_0924: Expected I, but got Obj
		//IL_094c: Expected I, but got Obj
		//IL_0481: Expected I, but got Obj
		//IL_086e: Expected Obj, but got I
		//IL_087b: Expected I, but got Obj
		//IL_08be: Expected I, but got Obj
		//IL_08d4: Expected Obj, but got I
		//IL_0328: Expected I, but got Obj
		//IL_0216: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_0a8b: Expected I4, but got Obj
		//IL_0375: Expected I, but got Obj
		//IL_038b: Expected Obj, but got I
		//IL_0584: Expected I, but got Obj
		//IL_059a: Expected Obj, but got I
		//IL_0403: Expected I, but got Obj
		//IL_080d: Expected I, but got Obj
		//IL_0823: Expected Obj, but got I
		//IL_0257: Expected I, but got Obj
		//IL_03b6: Expected I, but got Obj
		//IL_0a4b: Expected Obj, but got Ref
		//IL_0a5c: Expected I, but got VT
		//IL_05c5: Expected I, but got Obj
		//IL_02a4: Expected I, but got Obj
		nint num = default;
		object obj = num + 32;
		object obj2 = num + 28;
		object obj3 = num + 24;
		object obj4 = num + 20;
		object obj5 = num + 16;
		object obj6 = num + 12;
		object obj7 = num + 8;
		nint num2 = default;
		object obj8 = num2 + 24;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		if (this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj10 = default;
			if (obj10 != null)
			{
				object obj11 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				throw new NullReferenceException();
			}
			object obj12 = obj8;
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v38 (Il2CppClass<System.Type>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v192 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+4]");
			obj = 0;
			((IntPtr*)num)->m_value = (void*)(nint)obj;
			Type type = Type.internal_from_handle((IntPtr)num);
			obj2 = typeof(JsonObject);
			((IntPtr*)num)->m_value = (void*)(nint)obj2;
			Type type2 = Type.internal_from_handle((IntPtr)num);
			if ((object)type == type2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				object obj14 = default;
				if (obj14 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					JsonObject jsonObject = default;
					jsonObject.Remove((string)(object)this);
					object obj15 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					throw new NullReferenceException();
				}
			}
			object obj16 = obj8;
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v52 (Il2CppClass<System.Type>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num6 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v180 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v49+4]");
			obj3 = 0;
			((IntPtr*)num)->m_value = (void*)(nint)obj3;
			Type type3 = Type.internal_from_handle((IntPtr)num);
			obj4 = typeof(DateTime);
			((IntPtr*)num)->m_value = (void*)(nint)obj4;
			Type type4 = Type.internal_from_handle((IntPtr)num);
			ref bool reference = default;
			if ((object)type3 == type4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				object obj18 = default;
				if (obj18 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
					string s;
					if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
						string text = default;
						s = text;
					}
					else
					{
						nint num7 = (nint)typeof(CultureInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v168 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num8 = (nint)typeof(CultureInfo);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v174 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CultureInfo currentCulture = CultureInfo.CurrentCulture;
						reference = ref *(bool*)currentCulture;
						string text2 = default;
						s = text2;
					}
					nint num9 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v153 (Il2CppClass<System.DateTime>)+BA]");
					object obj20 = (nint)0 & (nint)0x200;
					if (obj20 != null)
					{
						nint num10 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v163 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					DateTime dateTime = System.DateTimeParse.Parse(s, (DateTimeFormatInfo)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), (DateTimeStyles)87);
					((IntPtr*)num)->m_value = (void*)(nint)dateTime;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					object obj21 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					throw new NullReferenceException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj22 = default;
			bool flag = obj22 == null;
			object obj23 = obj8;
			nint num11 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S1_v41 (Il2CppClass<System.Type>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			bool flag2 = obj24 == null;
			if (!flag)
			{
				if (!flag2)
				{
					nint num12 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v142 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S1_v38+4]");
				obj5 = 0;
				((IntPtr*)num)->m_value = (void*)(nint)obj5;
				Type type5 = Type.internal_from_handle((IntPtr)num);
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) == null)
				{
					nint num13 = (nint)typeof(CultureInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v132 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num14 = (nint)typeof(CultureInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v138 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CultureInfo currentCulture2 = CultureInfo.CurrentCulture;
					reference = ref *(bool*)currentCulture2;
				}
				nint num15 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v119 (Il2CppClass<System.Convert>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num16 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S0_v127 (Il2CppClass<System.Convert>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				byte[] array = Convert.FromBase64CharArray((char[])(object)this, (int)type5, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
				object obj27 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				throw new NullReferenceException();
			}
			if (!flag2)
			{
				nint num17 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v104 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S1_v38+4]");
			obj6 = 0;
			((IntPtr*)num)->m_value = (void*)(nint)obj6;
			Type type6 = Type.internal_from_handle((IntPtr)num);
			obj7 = typeof(string);
			((IntPtr*)num)->m_value = (void*)(nint)obj7;
			Type type7 = Type.internal_from_handle((IntPtr)num);
			if ((object)type6 != type7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InvalidOperationException ex = default;
				ex._002Ector();
				JsonObject.ConvertValue<int>(ex);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj28 = default;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj29 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				throw new NullReferenceException();
			}
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) == null)
			{
				nint num18 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S0_v86 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
				object obj30 = (nint)0 & (nint)0x200;
				if (obj30 != null)
				{
					nint num19 = (nint)typeof(CultureInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v92 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CultureInfo currentCulture3 = CultureInfo.CurrentCulture;
				reference = ref *(bool*)currentCulture3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
			object obj31 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			throw new NullReferenceException();
		}
		throw new NullReferenceException();
	}

	public unsafe void GetPopupTitle(out string firstLine, out string secondLine)
	{
		//IL_015b: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02d7: Expected I, but got Obj
		//IL_02ed: Expected Obj, but got I
		//IL_01fe: Expected I, but got Obj
		//IL_0214: Expected Obj, but got I
		//IL_019c: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_023f: Expected I, but got Obj
		ref bool reference = ref *(bool*)null;
		Characters.CharacterId eventValue = ((ExpiredLimitedCharacterEventManager)this).GetEventValue<Characters.CharacterId>(out reference);
		ref string reference2;
		ref string reference3;
		if (reference)
		{
			nint num = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v54 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v80 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Characters.Model model = Characters.characterData.get_Item(eventValue);
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v64 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v76 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_TITLE_COMEBACK");
			string args = Strings.GetDefault(model.name);
			string text = string.Format(format, (object[])(object)args);
			string format2 = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_SECOND_TITLE_LIMITED_CHAR");
			string args2 = Strings.GetDefault(model.name);
			string text2 = string.Format(format2, (object[])(object)args2);
			reference2 = ref *(string*)text2;
			reference3 = ref *(string*)text;
		}
		else
		{
			SDebug.LogFormat("ExpiredLimitedCharacterEventManager - GetPopupDescription: The Character type does not exist.", null);
			reference2 = ref *(string*)string.Empty;
			reference3 = ref *(string*)string.Empty;
		}
		nint num5 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v23 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v45 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref string reference4;
		ref string reference5;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			reference4 = ref reference3;
			reference5 = ref reference2;
			return;
		}
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v33 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v39 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Strings.TryGetLocalizedOnlineSettings("event_popup_description_first", out reference3);
		reference4 = ref *(flag ? ((string*)1) : ((string*)null));
		bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_second", out reference2);
		reference5 = ref *(flag2 ? ((string*)1) : ((string*)null));
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
			string text = Strings.GetDefault("EVENTS_POPUP_MONDAY_EVENT_TITLE_LINE_1");
			reference = ref *(string*)text;
			string text2 = Strings.GetDefault("EVENTS_POPUP_MONDAY_EVENT_TITLE_LINE_2");
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
		string text3 = Strings.GetDefault("EVENTS_POPUP_MONDAY_EVENT_TITLE_LINE_1");
		bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_title_first", out *(string*)text3);
		reference = ref *(flag2 ? ((string*)1) : ((string*)null));
		string text4 = Strings.GetDefault("EVENTS_POPUP_MONDAY_EVENT_TITLE_LINE_2");
		bool flag3 = Strings.TryGetLocalizedOnlineSettings("event_popup_title_second", out *(string*)text4);
		reference2 = ref *(flag3 ? ((string*)1) : ((string*)null));
	}

	public unsafe void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine)
	{
		//IL_042a: Expected I, but got Obj
		//IL_0440: Expected Obj, but got I
		//IL_004c: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_03ba: Expected I, but got Obj
		//IL_03d0: Expected Obj, but got I
		//IL_0186: Expected I, but got Obj
		//IL_008d: Expected I, but got Obj
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_00da: Expected I, but got Obj
		//IL_0214: Expected I, but got Obj
		//IL_02be: Expected Obj, but got I4
		//IL_02c7: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I4
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		bool flag = default;
		ref bool reference = ref *(bool*)((flag ? 1 : 0) + 4);
		reference = ref *(bool*)null;
		((bool*)(flag ? 1 : 0))->m_value = false;
		string text = string.Empty;
		string text4;
		string text5;
		string text6;
		if (((ExpiredLimitedCharacterEventManager)this).ShouldEventBeAvailable())
		{
			reference = ref *(bool*)null;
			Characters.CharacterId eventValue = ((ExpiredLimitedCharacterEventManager)this).GetEventValue<Characters.CharacterId>(out reference);
			if (reference)
			{
				nint num = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v87 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Characters);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v115 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Characters.Model model = Characters.characterData.get_Item(eventValue);
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v97 (Il2CppClass<Strings>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v111 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = Strings.GetDefault("EVENT_RIBBON_TEXT_WILD");
				string text3 = Strings.GetDefault("EVENT_RIBBON_TEXT_WEDNESDAY");
				string format = Strings.GetDefault("EVENT_RIBBON_TEXT_COMEBACK");
				string args = Strings.GetDefault(model.name);
				text = string.Format(format, (object[])(object)args);
				text4 = text2;
				text5 = text3;
			}
			else
			{
				SDebug.LogFormat("ExpiredLimitedCharacterEventManager - GetRibbonDescription: The Character type in the ExpiredLimitedCharacter Event does not exist.", null);
				text4 = string.Empty;
				text5 = string.Empty;
			}
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v38 (Il2CppClass<Globals>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v77 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			text6 = text;
			if (!Globals.DEBUG_USE_EVENT_TESTER)
			{
				nint num7 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v46 (Il2CppClass<Info.OnlineSettings>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v73 (Il2CppClass<Info.OnlineSettings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string saveDataPath = OnlineSettings.GetSaveDataPath();
				bool flag2 = ((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"event_ribbon_text", flag);
				bool flag3 = !flag2;
				text6 = text;
				if (!flag3)
				{
					bool value = ((bool*)(flag ? 1 : 0))->m_value;
					bool flag4;
					if (~(((bool*)(flag ? 1 : 0))->m_value ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v55 (System.Boolean)+8]");
						flag4 = (nint)0 == 0;
					}
					else
					{
						flag4 = true;
					}
					bool flag5 = !flag4;
					bool flag6 = !flag5;
					text6 = text;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						int num9 = default;
						object obj5 = num9 + 16;
						obj5 = 59;
						string text7 = ((string)((bool*)(flag ? 1 : 0))->m_value).Substring(num9);
						object obj6 = text7 + 16;
						object obj7 = text7 + 20;
						object obj8 = text7 + 24;
						text4 = (string)obj6;
						text5 = (string)obj7;
						text6 = (string)obj8;
					}
				}
			}
		}
		else
		{
			text4 = string.Empty;
			text5 = string.Empty;
			text6 = string.Empty;
		}
		ref string reference2 = ref *(string*)text4;
		ref string reference3 = ref *(string*)text5;
		ref string reference4 = ref *(string*)text6;
	}

	public void SaveProgress()
	{
		_eventType = SSEventType.ExpiredLimitedCharacter;
	}
}
