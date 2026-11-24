using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[assembly: AssemblyVersion("0.0.0.0")]
namespace NaughtyAttributes;

[Token(Token = "0x2000002")]
public class DrawConditionAttribute : NaughtyAttribute
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x3536", Offset = "0x3536", VA = "0x3536")]
	public DrawConditionAttribute()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1981", Offset = "0x1981")]
public class HideIfAttribute : DrawConditionAttribute
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private string conditionName;

	[Token(Token = "0x17000001")]
	public string ConditionName
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3318", Offset = "0x3318", VA = "0x3318")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x281C", Offset = "0x281C", VA = "0x281C")]
	public HideIfAttribute(string conditionName)
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1982", Offset = "0x1982")]
public class ShowIfAttribute : DrawConditionAttribute
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private string conditionName;

	[Token(Token = "0x17000002")]
	public string ConditionName
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x3319", Offset = "0x3319", VA = "0x3319")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x281D", Offset = "0x281D", VA = "0x281D")]
	public ShowIfAttribute(string conditionName)
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1983", Offset = "0x1983")]
public class ButtonAttribute : DrawerAttribute
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private string text;

	[Token(Token = "0x17000003")]
	public string Text
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x331A", Offset = "0x331A", VA = "0x331A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x281E", Offset = "0x281E", VA = "0x281E")]
	public ButtonAttribute([Optional] string text)
	{
	}
}
[Token(Token = "0x2000006")]
public abstract class DrawerAttribute : NaughtyAttribute
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x3537", Offset = "0x3537", VA = "0x3537")]
	protected DrawerAttribute()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1984", Offset = "0x1984")]
public class DropdownAttribute : DrawerAttribute
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private string valuesFieldName;

	[Token(Token = "0x17000004")]
	public string ValuesFieldName
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x331B", Offset = "0x331B", VA = "0x331B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x281F", Offset = "0x281F", VA = "0x281F")]
	public DropdownAttribute(string valuesFieldName)
	{
	}
}
[Token(Token = "0x2000008")]
public interface IDropdownList : IEnumerable<KeyValuePair<string, object>>, IEnumerable
{
}
[Token(Token = "0x2000009")]
public class DropdownList<T> : IDropdownList, IEnumerable<KeyValuePair<string, object>>, IEnumerable
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<KeyValuePair<string, object>> values;

	[Token(Token = "0x600000B")]
	public DropdownList()
	{
	}

	[Token(Token = "0x600000C")]
	public void Add(string displayName, T value)
	{
	}

	[Token(Token = "0x600000D")]
	public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	public static explicit operator DropdownList<object>(DropdownList<T> target)
	{
		return null;
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1985", Offset = "0x1985")]
public class MinMaxSliderAttribute : DrawerAttribute
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private float minValue;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private float maxValue;

	[Token(Token = "0x17000005")]
	public float MinValue
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1D6", Offset = "0x1D6", VA = "0x1D6")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000006")]
	public float MaxValue
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1D7", Offset = "0x1D7", VA = "0x1D7")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x23", Offset = "0x23", VA = "0x23")]
	public MinMaxSliderAttribute(float minValue, float maxValue)
	{
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1986", Offset = "0x1986")]
public class ReadOnlyAttribute : DrawerAttribute
{
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x3538", Offset = "0x3538", VA = "0x3538")]
	public ReadOnlyAttribute()
	{
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1987", Offset = "0x1987")]
public class ReorderableListAttribute : DrawerAttribute
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x3539", Offset = "0x3539", VA = "0x3539")]
	public ReorderableListAttribute()
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1988", Offset = "0x1988")]
public class ResizableTextAreaAttribute : DrawerAttribute
{
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x353A", Offset = "0x353A", VA = "0x353A")]
	public ResizableTextAreaAttribute()
	{
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1989", Offset = "0x1989")]
public class ShowAssetPreviewAttribute : DrawerAttribute
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private int width;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private int height;

	[Token(Token = "0x17000007")]
	public int Width
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x331C", Offset = "0x331C", VA = "0x331C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000008")]
	public int Height
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x331D", Offset = "0x331D", VA = "0x331D")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x14D9", Offset = "0x14D9", VA = "0x14D9")]
	public ShowAssetPreviewAttribute(int width = 64, int height = 64)
	{
	}
}
[Token(Token = "0x200000F")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x198A", Offset = "0x198A")]
public class ShowNativePropertyAttribute : DrawerAttribute
{
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x353B", Offset = "0x353B", VA = "0x353B")]
	public ShowNativePropertyAttribute()
	{
	}
}
[Token(Token = "0x2000010")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x198B", Offset = "0x198B")]
public class ShowNonSerializedFieldAttribute : DrawerAttribute
{
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x353C", Offset = "0x353C", VA = "0x353C")]
	public ShowNonSerializedFieldAttribute()
	{
	}
}
[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x198C", Offset = "0x198C")]
public class SliderAttribute : DrawerAttribute
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private float minValue;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private float maxValue;

	[Token(Token = "0x17000009")]
	public float MinValue
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1D8", Offset = "0x1D8", VA = "0x1D8")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700000A")]
	public float MaxValue
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1D9", Offset = "0x1D9", VA = "0x1D9")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x24", Offset = "0x24", VA = "0x24")]
	public SliderAttribute(float minValue, float maxValue)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x14DA", Offset = "0x14DA", VA = "0x14DA")]
	public SliderAttribute(int minValue, int maxValue)
	{
	}
}
[Token(Token = "0x2000012")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x198D", Offset = "0x198D")]
public class BoxGroupAttribute : GroupAttribute
{
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2820", Offset = "0x2820", VA = "0x2820")]
	public BoxGroupAttribute(string name = "")
	{
	}
}
[Token(Token = "0x2000013")]
public abstract class GroupAttribute : NaughtyAttribute
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private string name;

	[Token(Token = "0x1700000B")]
	public string Name
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x331E", Offset = "0x331E", VA = "0x331E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2821", Offset = "0x2821", VA = "0x2821")]
	public GroupAttribute(string name)
	{
	}
}
[Token(Token = "0x2000014")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x198E", Offset = "0x198E")]
public class BlankSpaceAttribute : MetaAttribute
{
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x353D", Offset = "0x353D", VA = "0x353D")]
	public BlankSpaceAttribute()
	{
	}
}
[Token(Token = "0x2000015")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x198F", Offset = "0x198F")]
public class InfoBoxAttribute : MetaAttribute
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private string text;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private InfoBoxType type;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private string visibleIf;

	[Token(Token = "0x1700000C")]
	public string Text
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x331F", Offset = "0x331F", VA = "0x331F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000D")]
	public InfoBoxType Type
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3320", Offset = "0x3320", VA = "0x3320")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700000E")]
	public string VisibleIf
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x3321", Offset = "0x3321", VA = "0x3321")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x518", Offset = "0x518", VA = "0x518")]
	public InfoBoxAttribute(string text, [Optional][DefaultParameterValue(0)] InfoBoxType type, [Optional] string visibleIf)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x14DB", Offset = "0x14DB", VA = "0x14DB")]
	public InfoBoxAttribute(string text, string visibleIf)
	{
	}
}
[Token(Token = "0x2000016")]
public enum InfoBoxType
{
	[Token(Token = "0x4000011")]
	Normal,
	[Token(Token = "0x4000012")]
	Warning,
	[Token(Token = "0x4000013")]
	Error
}
[Token(Token = "0x2000017")]
public abstract class MetaAttribute : NaughtyAttribute
{
	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private int order;

	[Token(Token = "0x1700000F")]
	public int Order
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x3322", Offset = "0x3322", VA = "0x3322")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2822", Offset = "0x2822", VA = "0x2822")]
		set
		{
		}
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x353E", Offset = "0x353E", VA = "0x353E")]
	protected MetaAttribute()
	{
	}
}
[Token(Token = "0x2000018")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1990", Offset = "0x1990")]
public class OnValueChangedAttribute : MetaAttribute
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private string callbackName;

	[Token(Token = "0x17000010")]
	public string CallbackName
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x3323", Offset = "0x3323", VA = "0x3323")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2823", Offset = "0x2823", VA = "0x2823")]
	public OnValueChangedAttribute(string callbackName)
	{
	}
}
[Token(Token = "0x2000019")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1991", Offset = "0x1991")]
public class SectionAttribute : MetaAttribute
{
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private string sectionLabel;

	[Token(Token = "0x17000011")]
	public string SectionLabel
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3324", Offset = "0x3324", VA = "0x3324")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2824", Offset = "0x2824", VA = "0x2824")]
	public SectionAttribute(string sectionLabel)
	{
	}
}
[Token(Token = "0x200001A")]
public class NaughtyAttribute : Attribute
{
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x353F", Offset = "0x353F", VA = "0x353F")]
	public NaughtyAttribute()
	{
	}
}
[Token(Token = "0x200001B")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1992", Offset = "0x1992")]
public class MaxValueAttribute : ValidatorAttribute
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private float maxValue;

	[Token(Token = "0x17000012")]
	public float MaxValue
	{
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1DA", Offset = "0x1DA", VA = "0x1DA")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x18E", Offset = "0x18E", VA = "0x18E")]
	public MaxValueAttribute(float maxValue)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2825", Offset = "0x2825", VA = "0x2825")]
	public MaxValueAttribute(int maxValue)
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1993", Offset = "0x1993")]
public class MinValueAttribute : ValidatorAttribute
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private float minValue;

	[Token(Token = "0x17000013")]
	public float MinValue
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1DB", Offset = "0x1DB", VA = "0x1DB")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x18F", Offset = "0x18F", VA = "0x18F")]
	public MinValueAttribute(float minValue)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2826", Offset = "0x2826", VA = "0x2826")]
	public MinValueAttribute(int minValue)
	{
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1994", Offset = "0x1994")]
public class RequiredAttribute : ValidatorAttribute
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private string message;

	[Token(Token = "0x17000014")]
	public string Message
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x3325", Offset = "0x3325", VA = "0x3325")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2827", Offset = "0x2827", VA = "0x2827")]
	public RequiredAttribute([Optional] string message)
	{
	}
}
[Token(Token = "0x200001E")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1995", Offset = "0x1995")]
public class ValidateInputAttribute : ValidatorAttribute
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private string callbackName;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private string message;

	[Token(Token = "0x17000015")]
	public string CallbackName
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x3326", Offset = "0x3326", VA = "0x3326")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000016")]
	public string Message
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x3327", Offset = "0x3327", VA = "0x3327")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x14DC", Offset = "0x14DC", VA = "0x14DC")]
	public ValidateInputAttribute(string callbackName, [Optional] string message)
	{
	}
}
[Token(Token = "0x200001F")]
public abstract class ValidatorAttribute : NaughtyAttribute
{
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x3540", Offset = "0x3540", VA = "0x3540")]
	protected ValidatorAttribute()
	{
	}
}
