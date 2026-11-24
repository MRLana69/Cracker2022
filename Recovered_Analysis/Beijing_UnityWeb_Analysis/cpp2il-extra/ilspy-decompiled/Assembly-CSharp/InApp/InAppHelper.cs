using System;
using System.Text;
using Cpp2ILInjected;
using Info;
using UnityEngine;

namespace InApp;

public class InAppHelper : MonoBehaviour
{
	private AudioClip purchaseSuccessSound;

	private void Start()
	{
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_01dd: Expected I4, but got Obj
		//IL_01ef: Expected I, but got Obj
		//IL_0205: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0278: Expected I4, but got Obj
		//IL_02c3: Expected I4, but got Obj
		//IL_02ea: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v38 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)this);
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v27 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string type = Strings.GetDefault(board.name);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "com.kiloo.subwayboard." + text2;
		object format = ((IConvertible)"iOS Id for ").ToType((Type)(object)type, (IFormatProvider)(object)": {0}");
		object[] args = (object[])(object)((~(board.overrideDynamicIapIdiOS ? 1u : 0u) != 0) ? text : board.dynamicIapId);
		string text3 = string.Format((string)format, args);
		StringBuilder stringBuilder2 = stringBuilder.Append((char)(int)text3);
		object format2 = ((IConvertible)"Android Id for ").ToType((Type)(object)type, (IFormatProvider)(object)": {0}");
		string text4 = ((~(board.overrideDynamicIapIdAndroid ? 1u : 0u) != 0) ? text : board.dynamicIapId);
		string args2 = text4.ToLowerInvariant();
		string text5 = string.Format((string)format2, (object[])(object)args2);
		StringBuilder stringBuilder3 = stringBuilder.Append((char)(int)text5);
		object format3 = ((IConvertible)"Kindle Id for ").ToType((Type)(object)type, (IFormatProvider)(object)": {0}");
		object[] args3 = (object[])(object)((~(board.overrideDynamicIapIdKindle ? 1u : 0u) != 0) ? text : board.dynamicIapId);
		string text6 = string.Format((string)format3, args3);
		StringBuilder stringBuilder4 = stringBuilder.Append((char)(int)text6);
	}
}
