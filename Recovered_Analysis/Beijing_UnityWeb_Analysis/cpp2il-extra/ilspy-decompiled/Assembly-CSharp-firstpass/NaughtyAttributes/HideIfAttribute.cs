using Cpp2ILInjected;

namespace NaughtyAttributes;

public class HideIfAttribute : DrawConditionAttribute
{
	private string conditionName;

	public string ConditionName
	{
		get
		{
			//IL_0009: Expected Obj, but got I4
			object obj = 0;
			return (string)(object)this;
		}
	}

	public HideIfAttribute(string conditionName)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		_ = conditionName.m_stringLength;
		object obj = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11733");
	}
}
