using System;
using Cpp2ILInjected;
using SYBO.Components.Utilities;

namespace SYBO.Subway.Pickups.Pickers;

public class PickerRemoveRequestEventArgs
{
	public IPicker IPicker
	{
		get
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected Obj, but got Unknown
			//IL_003c: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 + 4;
			obj = field;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Pickers.PickerRemoveRequestEventArgs)+10]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			object arg = default;
			return (IPicker)(object)string.Format((IFormatProvider)(object)"[PickerData: PickerType={0}, PickupType={1}]", format, arg);
		}
		private set
		{
			//IL_000e: Expected VT, but got Obj
			if (SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
			{
				_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			}
		}
	}

	public PickerRemoveRequestEventArgs(IPicker iPicker)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = iPicker;
	}
}
