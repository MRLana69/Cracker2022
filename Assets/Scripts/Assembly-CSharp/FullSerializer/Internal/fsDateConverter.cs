using System;
using System.Globalization;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsDateConverter : fsConverter
{
	private const string DefaultDateTimeFormatString = "o";

	private const string DateTimeOffsetFormatString = "o";

	private string DateTimeFormatString
	{
		get
		{
			fsSerializer serializer = Serializer;
			fsConfig config = serializer.Config;
			string result = config.CustomDateTimeFormatString;
			if (config.CustomDateTimeFormatString == null)
			{
				result = "o";
			}
			return result;
		}
	}

	public override bool CanProcess(Type type)
	{
		//IL_0084: Expected VT, but got Obj
		//IL_0014: Expected VT, but got Obj
		//IL_0051: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(DateTime));
		bool flag = (object)typeFromHandle == type;
		bool result = true;
		if (!flag)
		{
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(DateTimeOffset));
			bool flag2 = (object)typeFromHandle2 == type;
			result = true;
			if (!flag2)
			{
				Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(TimeSpan));
				bool flag3 = (object)typeFromHandle3 == type;
				result = flag3;
			}
		}
		return result;
	}

	public unsafe override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0237: Expected I8, but got I4
		//IL_0232: Expected native int or pointer, but got VT
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected VT, but got Unknown
		//IL_0123: Expected Ref, but got VT
		//IL_01d1: Expected I4, but got VT
		//IL_01cc: Expected native int or pointer, but got VT
		//IL_0217: Expected VT, but got Obj
		object obj = default;
		TimeSpan timeSpan = (TimeSpan)(obj - 32);
		_ = 0;
		_ = 0;
		_ = 0;
		((TimeSpan*)(nint)timeSpan)->_ticks = 0L;
		bool flag = instance == null;
		object obj2 = null;
		if (!flag)
		{
			bool flag2 = (object)instance.GetType() == typeof(DateTime);
			obj2 = instance;
			if (!flag2)
			{
				obj2 = null;
			}
		}
		if (obj2 != null)
		{
			throw new NullReferenceException();
		}
		bool flag3 = instance == null;
		object obj3 = null;
		if (!flag3)
		{
			bool flag4 = (object)instance.GetType() == typeof(DateTimeOffset);
			obj3 = instance;
			if (!flag4)
			{
				obj3 = null;
			}
		}
		if (obj3 != null)
		{
			NullReferenceException ex = new NullReferenceException();
			_ = ((Exception)ex)._className;
			DateTimeOffset dateTimeOffset = (DateTimeOffset)(timeSpan + 8);
			string text = ((DateTimeOffset*)dateTimeOffset)->ToString("o");
			object obj4 = default;
			ref fsData reference = ref *(fsData*)obj4;
			fsResult fsResult2 = default;
			((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
			return fsResult2;
		}
		bool flag5 = instance == null;
		object obj5 = null;
		if (!flag5)
		{
			bool flag6 = (object)instance.GetType() == typeof(TimeSpan);
			obj5 = instance;
			if (!flag6)
			{
				obj5 = null;
			}
		}
		if (obj5 != null)
		{
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		InvalidOperationException ex2 = default;
		ex2._002Ector("FullSerializer Internal Error -- Unexpected serialization type");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (fsResult)ex2;
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected Obj, but got Unknown
		//IL_00b3: Expected VT, but got Obj
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0673: Expected VT, but got Obj
		//IL_009a: Expected native int or pointer, but got VT
		//IL_07a9: Expected VT, but got Obj
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Ref, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected Ref, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_065a: Expected native int or pointer, but got VT
		//IL_0173: Expected I4, but got VT
		//IL_016e: Expected native int or pointer, but got VT
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected Ref, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_0790: Expected native int or pointer, but got VT
		//IL_0740: Expected I4, but got VT
		//IL_073b: Expected native int or pointer, but got VT
		//IL_09fd: Expected VT, but got Obj
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Expected Obj, but got Unknown
		//IL_08b3: Expected native int or pointer, but got VT
		//IL_0863: Expected I4, but got VT
		//IL_085e: Expected native int or pointer, but got VT
		//IL_09aa: Expected I4, but got VT
		//IL_09a5: Expected native int or pointer, but got VT
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0607: Expected VT, but got I
		//IL_061f: Expected Obj, but got I
		//IL_05a3: Expected VT, but got I
		//IL_0425: Expected Obj, but got I
		//IL_0450: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_0532: Expected Obj, but got I
		//IL_0547: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 32;
		_ = 0;
		fsResult fsResult4 = default;
		fsResult fsResult5 = default;
		InvalidOperationException ex2;
		if (!data.IsString)
		{
			fsDataType type = data.Type;
			Enum obj4 = (Enum)(obj + 8);
			_ = -1;
			obj4 = (Enum)(object)typeof(fsDataType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
			_ = 0;
			string text = obj4.ToString();
			string warning = "Date deserialization requires a string, not " + text;
			fsResult fsResult2 = fsResult.Fail(warning);
			fsResult fsResult3 = fsResult4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		else
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(DateTime));
			if ((object)typeFromHandle == storageType)
			{
				string asString = data.AsString;
				ref object reference;
				if (!DateTime.TryParse(asString, null, DateTimeStyles.RoundtripKind, out *(DateTime*)(obj - -64)))
				{
					if (~(fsGlobalConfig.AllowInternalExceptions ? 1u : 0u) == 0)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								fsResult fsResult6 = default;
								if ((nint)0 != 1)
								{
									_ = 0;
									object obj5 = obj + 8;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										object obj6 = default;
										reference = ref *(object*)obj6;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											fsResult5 = fsResult.Success;
											goto IL_099d;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									fsResult5 = fsResult6;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									fsResult5 = fsResult6;
								}
								goto IL_031d;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_031d;
					}
					goto IL_0974;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
				_ = 0;
				object obj7 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj8 = default;
				reference = ref *(object*)obj8;
				((fsResult*)(nint)fsResult4)->_success = (byte)(int)fsResult.Success != 0;
			}
			else
			{
				Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(DateTimeOffset));
				if ((object)typeFromHandle2 == storageType)
				{
					string asString2 = data.AsString;
					if (DateTimeOffset.TryParse(asString2, null, DateTimeStyles.RoundtripKind, out *(DateTimeOffset*)(obj + 48)))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
						_ = 0;
						object obj9 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						object obj10 = default;
						ref object reference = ref *(object*)obj10;
						((fsResult*)(nint)fsResult4)->_success = (byte)(int)fsResult.Success != 0;
					}
					else
					{
						string asString3 = data.AsString;
						string warning2 = "Unable to parse " + asString3 + " into a DateTimeOffset";
						fsResult fsResult7 = fsResult.Fail(warning2);
						fsResult fsResult8 = fsResult4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						((fsResult*)(nint)fsResult8)->_success = false;
					}
				}
				else
				{
					Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(TimeSpan));
					if ((object)typeFromHandle3 != storageType)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						InvalidOperationException ex = default;
						ex._002Ector("FullSerializer Internal Error -- Unexpected deserialization type");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
						ex2 = ex;
						goto IL_09d7;
					}
					string asString4 = data.AsString;
					if (TimeSpan.TryParse(asString4, out *(TimeSpan*)(obj + 40)))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
						_ = 0;
						object obj11 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						object obj12 = default;
						ref object reference = ref *(object*)obj12;
						((fsResult*)(nint)fsResult4)->_success = (byte)(int)fsResult.Success != 0;
					}
					else
					{
						string asString5 = data.AsString;
						string warning3 = "Unable to parse " + asString5 + " into a TimeSpan";
						fsResult fsResult9 = fsResult.Fail(warning3);
						fsResult fsResult10 = fsResult4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						((fsResult*)(nint)fsResult10)->_success = false;
					}
				}
			}
		}
		goto IL_096f;
		IL_09d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		fsResult4 = (fsResult)ex2;
		goto IL_099d;
		IL_062d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0974;
		IL_0974:
		string asString6 = data.AsString;
		string warning4 = "Unable to parse " + asString6 + " into a DateTime";
		fsResult fsResult11 = fsResult.Fail(warning4);
		fsResult fsResult12 = fsResult4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		((fsResult*)(nint)fsResult12)->_success = false;
		goto IL_096f;
		IL_031d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj13 = default;
		object obj14 = default;
		bool flag = obj13 == obj14;
		bool flag2 = !flag;
		object obj16 = default;
		object obj15 = obj16;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj18 = default;
				object obj17 = obj18;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj19 = default;
					if (obj19 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj20 = (nint)0 << 2;
						object obj21 = obj3 + obj20;
						obj21 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj22 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj23 = (nint)0 << 2;
						object obj24 = obj23 + obj3;
						object obj25 = obj24 - 4;
						object obj26 = obj25;
						string asString7 = data.AsString;
						bool flag3 = obj25 == null;
						string text2 = null;
						string text3 = " into a DateTime; got exception ";
						string text4 = "Unable to parse ";
						if (!flag3)
						{
							object obj27 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v657 @ S1_v120+D4] (should have been resolved before IL gen)");
							string text5 = default;
							text2 = text5;
							text3 = " into a DateTime; got exception ";
							text4 = "Unable to parse ";
						}
						string warning5 = text4 + asString7 + text3 + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						fsResult fsResult13 = fsResult.Fail(warning5);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj28 = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						fsResult5 = (fsResult)0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj29 = obj18;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag4 = (nint)0 != 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						fsResult4 = (fsResult)0;
						if (!flag4)
						{
							goto IL_05b1;
						}
					}
					goto IL_099d;
				}
			}
			goto IL_05b1;
		}
		goto IL_062d;
		IL_099d:
		((fsResult*)(nint)fsResult4)->_success = (byte)(int)fsResult5 != 0;
		goto IL_096f;
		IL_096f:
		return fsResult4;
		IL_05b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag5 = (nint)0 == 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		fsResult4 = (fsResult)0;
		object obj30 = default;
		obj15 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		ex2 = (InvalidOperationException)0;
		if (!flag5)
		{
			goto IL_062d;
		}
		goto IL_09d7;
	}
}
