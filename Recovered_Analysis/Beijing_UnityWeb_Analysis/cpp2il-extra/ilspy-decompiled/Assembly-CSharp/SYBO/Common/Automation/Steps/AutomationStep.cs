using Cpp2ILInjected;

namespace SYBO.Common.Automation.Steps;

public abstract class AutomationStep : IAutomationStep
{
	public bool IsDone
	{
		get
		{
			//IL_0025: Expected Obj, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected Obj, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected Obj, but got Unknown
			bool flag = field;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Boolean)+C]");
			if ((nint)0 != 0)
			{
				bool flag2 = field;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v3 (System.Boolean)+C]");
				object obj = (nint)0 << 2;
				object obj2 = field + obj;
				object obj3 = obj2 + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				bool result = default;
				return result;
			}
			return true;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
		}
	} = false;

	public virtual void Initialize()
	{
		_ = 0f;
	}

	public virtual void Cleanup()
	{
	}

	public abstract void Update(float unscaledDeltaTime);
}
