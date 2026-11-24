using Cpp2ILInjected;

namespace NaughtyAttributes;

public class MaxValueAttribute : ValidatorAttribute
{
	private float maxValue;

	public float MaxValue
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NaughtyAttributes.MaxValueAttribute)+C]");
			return 0f;
		}
	}

	public MaxValueAttribute(float maxValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got I4
		//IL_007e: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		_ = 0;
		_ = 0;
		obj2 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11766");
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		MaxValueAttribute maxValueAttribute = (MaxValueAttribute)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		this.maxValue = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+10]");
		_ = 0;
	}

	public MaxValueAttribute(int maxValue)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 12;
		obj = maxValue;
	}
}
