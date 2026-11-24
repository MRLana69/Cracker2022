using System;
using System.Globalization;
using Cpp2ILInjected;
using UnityEngine.UI;

namespace Kiloo.GameCenter;

public class GameCenterRequest
{
	private bool didTimeout__BackingField;

	private bool isDone__BackingField;

	private string error__BackingField;

	public float timeout
	{
		get
		{
			//IL_0011: Expected F4, but got I4
			//IL_0011: Expected F4, but got Obj
			return ScrollRect.RubberDelta((float)error__BackingField, (float)(didTimeout__BackingField ? 1 : 0));
		}
		set
		{
		}
	}

	public unsafe bool didTimeout
	{
		get
		{
			//IL_00e4: Expected Obj, but got I4
			//IL_0130: Expected I4, but got Obj
			//IL_0036: Expected Obj, but got I4
			//IL_0044: Expected I, but got Obj
			//IL_005a: Expected Obj, but got I
			//IL_0125: Expected I4, but got Obj
			//IL_0085: Expected I, but got Obj
			object obj = 0;
			if (this != null)
			{
				if (((string)this).EndsWith("&#124;"))
				{
					obj = 124;
					nint num = (nint)typeof(CultureInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v19 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(CultureInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v27 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CultureInfo currentCulture = CultureInfo.CurrentCulture;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B6");
					int count = default;
					string text = ((string)this).Remove((int)"&#124;", count);
					GameCenterRequest gameCenterRequest = (GameCenterRequest)(object)text;
				}
			}
			else
			{
				GameCenterRequest gameCenterRequest = null;
			}
			return (byte)(int)this != 0;
		}
		internal set
		{
			//IL_019c: Expected Obj, but got I4
			//IL_01a5: Expected Obj, but got I4
			//IL_01b2: Expected Obj, but got I4
			//IL_00d4: Expected Obj, but got I4
			//IL_0103: Expected I, but got Obj
			//IL_0119: Expected Obj, but got I
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected Obj, but got Unknown
			//IL_00c2: Expected Obj, but got I4
			//IL_0144: Expected I, but got Obj
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected Obj, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			//IL_00a9: Expected Obj, but got I4
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected Obj, but got Unknown
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num = default;
			object obj = num + 16;
			obj = 124;
			string text = ((string)value).Substring(num);
			if (text.m_firstChar == '\u0003')
			{
				if (error__BackingField != null)
				{
					object obj2 = text + 16;
					TypeCode typeCode = ((int*)obj2)->GetTypeCode();
					object obj3 = text + 20;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v36+8]");
					if ((nint)0 > (nint)0)
					{
						object obj5 = text + 20;
						object obj6 = obj5;
					}
					else
					{
						object obj6 = 0;
					}
					object obj7 = text + 24;
					TypeCode typeCode2 = ((int*)obj7)->GetTypeCode();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A32E");
				}
				object obj8 = this + 16;
				obj8 = 0;
				return;
			}
			object obj9 = text.m_firstChar;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string msg = "OnGameCenterViewDismissed: Unexpected number of parameters :" + text2;
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num3 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v18 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameCenterPlugin.LogWarning(msg);
		}
	}

	public bool isDone
	{
		get
		{
			return didTimeout__BackingField;
		}
		internal set
		{
			didTimeout__BackingField = value;
		}
	}

	public string error
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = isDone__BackingField;
			return (string)flag;
		}
		internal set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			isDone__BackingField = flag;
		}
	}

	public GameCenterRequest()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
