using System;
using System.Globalization;
using Cpp2ILInjected;

namespace Kiloo.Common.Utility;

public class BsonFileSaver : IFileSaver
{
	private readonly IBsonSerializer _bsonSerializer;

	public BsonFileSaver(IBsonSerializer bsonSerializer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005d: Expected Obj, but got I
		//IL_0048: Expected Obj, but got I
		object obj = bsonSerializer & 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.BsonFileSaver)+21]");
		object obj2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.BsonFileSaver)+14]");
			obj2 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.BsonFileSaver)+18]");
			obj2 = 0;
		}
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public void Save(string file, object obj)
	{
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_010b: Expected I, but got Obj
		object obj3 = default;
		object obj2 = obj3 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj4 = default;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
			object obj5 = 0;
			object obj6 = obj5;
		}
		else
		{
			object obj7;
			object obj6 = default;
			if (obj6 == null)
			{
				obj7 = null;
			}
			else
			{
				obj7 = (((object)obj6.GetType() != typeof(DateTime)) ? null : obj6);
			}
			if (obj7 != null)
			{
				nint num = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v22 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num2 = (nint)typeof(TimeUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v30 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				throw new NullReferenceException();
			}
			if (((ActionQueue)obj6).Count == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj9 = default;
				obj6 = obj9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
	}

	public unsafe T Load<T>(string file)
	{
		//IL_060e: Expected Obj, but got I
		//IL_061c: Expected Obj, but got I
		//IL_062a: Expected Obj, but got I
		//IL_0638: Expected Obj, but got I
		//IL_0646: Expected Obj, but got I
		//IL_0654: Expected Obj, but got I
		//IL_0662: Expected Obj, but got I
		//IL_0670: Expected Obj, but got I
		//IL_0068: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_06b1: Expected Obj, but got I
		//IL_06be: Expected I, but got Obj
		//IL_06e6: Expected I, but got Obj
		//IL_0730: Expected I, but got Obj
		//IL_0746: Expected Obj, but got I
		//IL_00a9: Expected I, but got Obj
		//IL_09b0: Expected Obj, but got I
		//IL_09bd: Expected I, but got Obj
		//IL_09e5: Expected I, but got Obj
		//IL_0792: Expected I, but got Obj
		//IL_07a8: Expected Obj, but got I
		//IL_015c: Expected I, but got Obj
		//IL_08f3: Expected Obj, but got I
		//IL_0900: Expected I, but got Obj
		//IL_0928: Expected I, but got Obj
		//IL_046d: Expected I, but got Obj
		//IL_084a: Expected Obj, but got I
		//IL_0857: Expected I, but got Obj
		//IL_089a: Expected I, but got Obj
		//IL_08b0: Expected Obj, but got I
		//IL_031c: Expected I, but got Obj
		//IL_020e: Expected I, but got Obj
		//IL_0224: Expected Obj, but got I
		//IL_0a6b: Expected I4, but got Obj
		//IL_0a6b: Expected I4, but got Obj
		//IL_0369: Expected I, but got Obj
		//IL_037f: Expected Obj, but got I
		//IL_056c: Expected I, but got Obj
		//IL_0582: Expected Obj, but got I
		//IL_03f7: Expected I, but got Obj
		//IL_07e9: Expected I, but got Obj
		//IL_07ff: Expected Obj, but got I
		//IL_024f: Expected I, but got Obj
		//IL_03aa: Expected I, but got Obj
		//IL_0a3c: Expected I, but got VT
		//IL_05ad: Expected I, but got Obj
		//IL_029c: Expected I, but got Obj
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
			}
			else
			{
				object obj12 = obj8;
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v37 (Il2CppClass<System.Type>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num4 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v186 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v34+4]");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
						goto IL_069c;
					}
				}
				object obj16 = obj8;
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v51 (Il2CppClass<System.Type>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num6 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v175 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v48+4]");
				obj3 = 0;
				((IntPtr*)num)->m_value = (void*)(nint)obj3;
				Type type3 = Type.internal_from_handle((IntPtr)num);
				obj4 = typeof(DateTime);
				((IntPtr*)num)->m_value = (void*)(nint)obj4;
				Type type4 = Type.internal_from_handle((IntPtr)num);
				string text = default;
				if ((object)type3 == type4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
					object obj18 = default;
					if (obj18 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
						string s;
						if (text != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
							string text2 = default;
							s = text2;
						}
						else
						{
							nint num7 = (nint)typeof(CultureInfo);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v163 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
							object obj19 = (nint)0 & (nint)0x200;
							if (obj19 != null)
							{
								nint num8 = (nint)typeof(CultureInfo);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v169 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							CultureInfo currentCulture = CultureInfo.CurrentCulture;
							text = (string)(object)currentCulture;
							string text3 = default;
							s = text3;
						}
						nint num9 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v149 (Il2CppClass<System.DateTime>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						if (obj20 != null)
						{
							nint num10 = (nint)typeof(DateTime);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v158 (Il2CppClass<System.DateTime>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						DateTime dateTime = System.DateTimeParse.Parse(s, (DateTimeFormatInfo)(object)text, (DateTimeStyles)87);
						((IntPtr*)num)->m_value = (void*)(nint)dateTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						object obj21 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
						goto IL_069c;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				object obj22 = default;
				bool flag = obj22 == null;
				object obj23 = obj8;
				nint num11 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S1_v41 (Il2CppClass<System.Type>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				bool flag2 = obj24 == null;
				if (!flag)
				{
					if (!flag2)
					{
						nint num12 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v138 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v38+4]");
					obj5 = 0;
					((IntPtr*)num)->m_value = (void*)(nint)obj5;
					Type type5 = Type.internal_from_handle((IntPtr)num);
					if (text == null)
					{
						nint num13 = (nint)typeof(CultureInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v128 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
						object obj25 = (nint)0 & (nint)0x200;
						if (obj25 != null)
						{
							nint num14 = (nint)typeof(CultureInfo);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S0_v134 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CultureInfo currentCulture2 = CultureInfo.CurrentCulture;
						text = (string)(object)currentCulture2;
					}
					nint num15 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v116 (Il2CppClass<System.Convert>)+BA]");
					object obj26 = (nint)0 & (nint)0x200;
					if (obj26 != null)
					{
						nint num16 = (nint)typeof(Convert);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S0_v123 (Il2CppClass<System.Convert>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					byte[] array = Convert.FromBase64CharArray((char[])(object)this, (int)type5, (int)text);
					object obj27 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
				}
				else
				{
					if (!flag2)
					{
						nint num17 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v101 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v38+4]");
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
						JsonObject.ConvertValue<object>(ex);
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
					object obj28 = default;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj29 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
					}
					else
					{
						if (text == null)
						{
							nint num18 = (nint)typeof(CultureInfo);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S0_v84 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
							object obj30 = (nint)0 & (nint)0x200;
							if (obj30 != null)
							{
								nint num19 = (nint)typeof(CultureInfo);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v90 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							CultureInfo currentCulture3 = CultureInfo.CurrentCulture;
							text = (string)(object)currentCulture3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
						object obj31 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
					}
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		}
		goto IL_069c;
		IL_069c:
		T result = default;
		return result;
	}

	public bool TryLoad<T>(string file, out T obj)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj2 = default;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		}
		else
		{
			object obj3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44 @ S3_v5 (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	private static void LogError(string msg)
	{
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
