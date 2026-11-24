using System;
using System.Globalization;
using System.Net.Sockets;
using System.Text;
using Cpp2ILInjected;
using SYBO.Components.Analytics.Integration;
using SYBO.Components.Logging;
using SYBO.Components.Logging.Ftp;

namespace SYBO.Components.Analytics;

public class AnalyticsLogCategory : LogCategory
{
	public AnalyticsLogCategory(int categoryId)
	{
		//IL_00d5: Expected I4, but got Obj
		//IL_00d5: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I
		if (CategoryId != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		Encoding latin = Encoding.Latin1;
		string value = string.ConcatArray((string[])categoryId, (int)"\r\n");
		bool flag = string.IsNullOrEmpty(value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsLogCategory)+38]");
		byte[] array = default;
		int num = ((Socket)0).Receive(array, array.Length, SocketFlags.None);
		((FtpClient)(object)this).cleanup();
	}

	public override string[] GetCallstackPrefixes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected Obj, but got Unknown
		//IL_07f8: Expected Obj, but got I4
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected Obj, but got Unknown
		//IL_081f: Expected I4, but got Obj
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009d: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected I4, but got Unknown
		//IL_0102: Expected Obj, but got I
		//IL_0029: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_004e: Expected I4, but got Obj
		//IL_09d4: Expected Obj, but got I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_0150: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I
		//IL_085b: Expected I4, but got Obj
		//IL_0867: Expected Obj, but got I4
		//IL_0191: Expected I, but got Obj
		//IL_08c3: Expected I4, but got Obj
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_0223: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 24;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		this._002Ector((int)"PASV");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsLogCategory)+2C]");
		if ((nint)0 != 227)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsLogCategory)+20]");
			string text = ((string)0).Trim((char[])4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AggregatedDataTracking.DataContainer dataContainer = default;
			dataContainer._002Ector((AggregatedDataTracking.DataCompleteness)text, -1);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		object obj5 = obj2 + 12;
		object obj6 = obj2 + 8;
		object obj7 = obj2 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsLogCategory)+20]");
		int num = ((string)0).IndexOfAny((char[])40);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsLogCategory)+20]");
		int num2 = ((string)0).IndexOfAny((char[])41);
		int startIndex = num + 1;
		object obj8 = num2 - num;
		int length = obj8 - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsLogCategory)+20]");
		string text2 = ((string)0).InternalSubString(startIndex, length);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		string[] array = (string[])(object)"";
		object obj9 = 0;
		int num3 = default;
		int totalLength = default;
		object obj15 = default;
		object obj18 = default;
		int num6 = default;
		while (true)
		{
			bool flag = num3 >= text2.m_stringLength;
			bool flag2 = (nint)obj9 > 6;
			object obj10 = flag | flag2;
			string text6;
			if (obj10 == null)
			{
				string text3 = text2.InternalSubString(num3, 1);
				nint num4 = (nint)typeof(char);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v192 (Il2CppClass<System.Char>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num5 = (nint)typeof(char);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v263 (Il2CppClass<System.Char>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = char.IsDigit((char)(int)text3);
				obj3 = flag3;
				if (char.CheckLetter(flag3 ? UnicodeCategory.LowercaseLetter : UnicodeCategory.UppercaseLetter))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
					string text4 = string.ConcatArray(array, totalLength);
					bool flag4 = (nint)obj3 == 44;
					string text5 = text4;
					if (!flag4)
					{
						object obj12 = num3 + 1;
						bool flag5 = (nint)obj12 == text2.m_stringLength;
						text5 = text4;
						if (!flag5)
						{
							text6 = text4;
							goto IL_08c8;
						}
					}
				}
				else
				{
					if ((nint)obj3 != 44)
					{
						break;
					}
					string text5 = (string)(object)array;
				}
				object obj13 = obj9 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj14 = obj15 + 16;
				object obj16 = obj9 << 2;
				object obj17 = obj14 + obj16;
				obj17 = obj18;
				text6 = "";
				obj9 = obj13;
				goto IL_08c8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj19 = obj15 + 16;
			obj5 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
			IL_08c8:
			num3 = num6 + 1;
			array = (string[])(object)text6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AnalyticsLogCategory)+20]");
		string text7 = string.ConcatArray((string[])(object)"Malformed PASV result: ", 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AggregatedDataTracking.DataContainer dataContainer2 = default;
		dataContainer2._002Ector((AggregatedDataTracking.DataCompleteness)text7, -1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return null;
	}
}
