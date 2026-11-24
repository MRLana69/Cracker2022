using System;
using Cpp2ILInjected;

namespace SYBO.Components.Utilities.Data;

[Serializable]
public abstract class NumericToggle
{
	public const string DefaultMessage = "(Default)";

	public const int UnsetInt = -1;

	private bool _isEnabled;

	private bool _isEnabledOriginal;

	private string _inspectorMessage;

	private string _inspectorMessageOriginal;

	private bool _showInspectorMessage;

	public bool IsEnabled
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.Data.NumericToggle)+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.Data.NumericToggle)+1C]");
			return num == 0;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public bool IsEnabledOriginal
	{
		get
		{
			return _isEnabled;
		}
		set
		{
			_isEnabled = value;
		}
	}

	public string InspectorMessage
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool isEnabledOriginal = _isEnabledOriginal;
			return (string)isEnabledOriginal;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool isEnabledOriginal = (byte)(value & 1) != 0;
			_isEnabledOriginal = isEnabledOriginal;
		}
	}

	public string InspectorMessageOriginal
	{
		get
		{
			return _inspectorMessage;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = value;
		}
	}

	public bool ShowInspectorMessage
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_inspectorMessageOriginal != 0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 16;
			obj = value;
		}
	}

	protected abstract bool IsOriginalValue();

	public virtual void OnChanged()
	{
		((NumericIntToggle)this).SoftReset();
	}

	protected NumericToggle()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		bool showInspectorMessage = (byte)(obj & 1) != 0;
		_showInspectorMessage = showInspectorMessage;
	}
}
