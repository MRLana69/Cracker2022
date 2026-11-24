using System;
using System.Diagnostics;
using Cpp2ILInjected;
using SYBO.Components.Crypt;
using UnityEngine;

namespace Info.VideoRewardCooldowns;

public class Cooldown
{
	private string id__BackingField;

	private int totalCharges__BackingField;

	private int usedCharges__BackingField;

	public string id
	{
		get
		{
			//IL_00a5: Expected I, but got Obj
			//IL_00bb: Expected Obj, but got I
			//IL_0101: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I4
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault((string)totalCharges__BackingField);
			if (text == null || text.m_stringLength == 0)
			{
				return id__BackingField;
			}
			return (string)totalCharges__BackingField;
		}
		set
		{
			//IL_001b: Expected Obj, but got I
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected Obj, but got Unknown
			if (SellConsumable.completed != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v2 (Il2CppMethodInfo)+18]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = obj2 & 0x1FFF;
				object obj4 = obj3 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S4_v5 (should have been resolved before IL gen)");
			}
		}
	}

	public int totalCharges
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)id__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
		}
	}

	public int usedCharges
	{
		get
		{
			return totalCharges__BackingField;
		}
		set
		{
			totalCharges__BackingField = value;
		}
	}

	public int seconds
	{
		get
		{
			return usedCharges__BackingField;
		}
		set
		{
			usedCharges__BackingField = value;
		}
	}

	public DateTime startTime
	{
		get
		{
			//IL_000f: Expected VT, but got I8
			return (DateTime)((Stopwatch)(object)id__BackingField).ElapsedTicks;
		}
		set
		{
			//IL_0027: Expected I8, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			((EncryptedCTRStream)(object)ex).SetLength(0L);
		}
	}

	public Cooldown()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}
}
