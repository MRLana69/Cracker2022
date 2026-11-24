using Cpp2ILInjected;

namespace NaughtyAttributes;

public class MinMaxSliderAttribute : DrawerAttribute
{
	private float minValue;

	private float maxValue;

	public float MinValue
	{
		get
		{
			//IL_0032: Expected Obj, but got I
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [3BF480]");
			bool flag = (nint)0 == 0;
			bool flag2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [3BF480]");
			object obj = 0;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A5");
				object obj2 = default;
				obj = obj2;
			}
			object obj3 = obj & 0xFF;
			object obj4 = obj3 + 401;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v19 @ S1_v4 (should have been resolved before IL gen)");
			float result = default;
			return result;
		}
	}

	public float MaxValue => minValue;

	public MinMaxSliderAttribute(float minValue, float maxValue)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11768");
	}
}
