using UnityEngine.Bindings;

namespace NaughtyAttributes;

public class InfoBoxAttribute : MetaAttribute
{
	private string text;

	private InfoBoxType type;

	private string visibleIf;

	public string Text
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)base.order;
		}
	}

	public InfoBoxType Type
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (InfoBoxType)text;
		}
	}

	public string VisibleIf
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)type;
		}
	}

	public InfoBoxAttribute(string text, InfoBoxType type = InfoBoxType.Normal, string visibleIf = null)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_000e: Expected I4, but got Obj
		//IL_0018: Expected I4, but got Obj
		((UnityEngine.Bindings.NativeTypeAttribute)(object)this)._002Ector((UnityEngine.Bindings.CodegenOptions)text, (string)type);
		this.type = (InfoBoxType)visibleIf;
	}

	public InfoBoxAttribute(string text, string visibleIf)
	{
		//IL_000a: Expected I4, but got Obj
		base.order = (int)text;
		this.text = visibleIf;
	}
}
