using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;

public class Notification
{
	private string type__BackingField;

	private string message__BackingField;

	public string type
	{
		get
		{
			//IL_0006: Expected I4, but got Obj
			//IL_000a: Expected Obj, but got I4
			return (string)PlayerSave.GetMysteryBoxesOpened((MysteryBox.Type)this);
		}
		set
		{
		}
	}

	public string message
	{
		get
		{
			return type__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
	}

	public Dictionary<string, object> userInfo
	{
		get
		{
			return (Dictionary<string, object>)(object)message__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = value;
		}
	}

	public Notification()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
