using System;
using Cpp2ILInjected;
using SYBO.Common.Exceptions;

namespace SYBO.Subway.Level;

[Serializable]
public class EnvironmentKind
{
	public const string FieldPatternType = "_type";

	private EnvironmentType _type;

	private EnvironmentDensity _density;

	public static readonly EnvironmentKind Empty;

	public static readonly EnvironmentKind FillersLow;

	public static readonly EnvironmentKind FillersMedium;

	public static readonly EnvironmentKind FillersHigh;

	public static readonly EnvironmentKind Gates;

	public static readonly EnvironmentKind Tube;

	public static readonly EnvironmentKind Pillars;

	public static readonly EnvironmentKind Station;

	public static readonly EnvironmentKind Epic;

	public static readonly EnvironmentKind[] All;

	public static readonly EnvironmentKind[] AllUnconstrained;

	public static readonly EnvironmentKind[] AllWithSplitPieces;

	public EnvironmentType Type => _type;

	public EnvironmentDensity Density => _density;

	public bool IsRepeatable
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = _type - 1;
			return (nint)obj < 2;
		}
	}

	public static EnvironmentKind None
	{
		get
		{
			EnvironmentKind environmentKind = default;
			environmentKind._density = EnvironmentDensity.Default;
			environmentKind._type = EnvironmentType.None;
			return environmentKind;
		}
	}

	public EnvironmentKind(EnvironmentType type, EnvironmentDensity density)
	{
		_density = density;
		_type = type;
	}

	public static bool operator ==(EnvironmentKind c1, EnvironmentKind c2)
	{
		if (c1._type == c2._type)
		{
			return c1._density == c2._density;
		}
		return false;
	}

	public static bool operator !=(EnvironmentKind c1, EnvironmentKind c2)
	{
		bool flag = c1._type == c2._type && c1._density == c2._density;
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public override bool Equals(object other)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			EnvironmentType type = _type;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
			if ((nint)type == (nint)0)
			{
				EnvironmentDensity density = _density;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+C]");
				return (nint)density == (nint)0;
			}
			return false;
		}
		return false;
	}

	public bool Equals(EnvironmentKind other)
	{
		if (_type == other._type)
		{
			return _density == other._density;
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
		object obj = _type + 493;
		object obj2 = obj * 29;
		return (int)(_density + obj2);
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 32);
		Enum obj3 = (Enum)(obj + 16);
		_ = -1;
		obj3 = (Enum)(object)typeof(EnvironmentType);
		_ = _type;
		string text = obj3.ToString();
		_ = -1;
		obj = (Enum)(object)typeof(EnvironmentDensity);
		_ = _density;
		string text2 = obj.ToString();
		return text + " " + text2;
	}

	public EnvironmentKind GetValidated()
	{
		EnvironmentKind environmentKind = default;
		if (!IsValidDensity(this))
		{
			EnvironmentDensity defaultDensity = GetDefaultDensity(_type);
			environmentKind._density = defaultDensity;
			environmentKind._type = _type;
		}
		return environmentKind;
	}

	public static bool IsValidDensity(EnvironmentKind envKind)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0101: Expected I, but got Obj
		//IL_003e: Expected Obj, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_015d: Expected I4, but got Obj
		object obj = envKind._type - 1;
		bool result;
		if ((nint)obj <= 31)
		{
			object obj2 = 1 << (int)obj;
			object obj3 = obj2 & -2147450742;
			if (obj3 != null)
			{
				goto IL_00e0;
			}
			if (obj == null)
			{
				bool flag = envKind._density == EnvironmentDensity.Low;
				result = true;
				if (!flag)
				{
					bool flag2 = envKind._density == EnvironmentDensity.Medium;
					bool flag3 = envKind._density == EnvironmentDensity.High;
					return flag2 | flag3;
				}
				goto IL_015d;
			}
		}
		if (envKind._type == EnvironmentType.None)
		{
			goto IL_00e0;
		}
		nint num = (nint)envKind;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S2_v3 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+D4] (should have been resolved before IL gen)");
		string text = default;
		string missingSwitchValue = "Missing switch case for " + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		SwitchDefaultException ex = default;
		ex._002Ector(missingSwitchValue);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte)(int)ex != 0;
		IL_015d:
		return result;
		IL_00e0:
		result = envKind._density == EnvironmentDensity.Default;
		goto IL_015d;
	}

	public static EnvironmentDensity GetDefaultDensity(EnvironmentType envType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		EnvironmentType environmentType = default;
		object obj3 = environmentType - 1;
		if ((nint)obj3 > 31)
		{
			goto IL_00af;
		}
		object obj4 = 1 << (int)obj3;
		object obj5 = obj4 & 0x8A;
		if (obj5 == null)
		{
			object obj6 = obj4 & -2147450880;
			if (obj6 == null && obj3 != null)
			{
				goto IL_00af;
			}
		}
		goto IL_0155;
		IL_0155:
		return EnvironmentDensity.Default;
		IL_00af:
		if (environmentType != EnvironmentType.None)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			_ = -1;
			object obj7 = default;
			obj = (Enum)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
			string missingSwitchValue = "Missing switch case for " + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			SwitchDefaultException ex = default;
			ex._002Ector(missingSwitchValue);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		goto IL_0155;
	}

	static EnvironmentKind()
	{
		EnvironmentKind environmentKind = default;
		environmentKind._density = EnvironmentDensity.Default;
		environmentKind._type = EnvironmentType.Empty;
		Empty = environmentKind;
		EnvironmentKind environmentKind2 = default;
		environmentKind2._density = EnvironmentDensity.Low;
		environmentKind2._type = EnvironmentType.Fillers;
		FillersLow = environmentKind2;
		EnvironmentKind environmentKind3 = default;
		environmentKind3._density = EnvironmentDensity.Medium;
		environmentKind3._type = EnvironmentType.Fillers;
		FillersMedium = environmentKind3;
		EnvironmentKind environmentKind4 = default;
		environmentKind4._density = EnvironmentDensity.High;
		environmentKind4._type = EnvironmentType.Fillers;
		FillersHigh = environmentKind4;
		EnvironmentKind environmentKind5 = default;
		environmentKind5._density = EnvironmentDensity.Default;
		environmentKind5._type = EnvironmentType.Gates;
		Gates = environmentKind5;
		EnvironmentKind environmentKind6 = default;
		environmentKind6._density = EnvironmentDensity.Default;
		environmentKind6._type = EnvironmentType.Tube;
		Tube = environmentKind6;
		EnvironmentKind environmentKind7 = default;
		environmentKind7._density = EnvironmentDensity.Default;
		environmentKind7._type = EnvironmentType.Pillars;
		Pillars = environmentKind7;
		EnvironmentKind environmentKind8 = default;
		environmentKind8._density = EnvironmentDensity.Default;
		environmentKind8._type = EnvironmentType.Station;
		Station = environmentKind8;
		EnvironmentKind environmentKind9 = default;
		environmentKind9._density = EnvironmentDensity.Default;
		environmentKind9._type = EnvironmentType.Epic;
		Epic = environmentKind9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
