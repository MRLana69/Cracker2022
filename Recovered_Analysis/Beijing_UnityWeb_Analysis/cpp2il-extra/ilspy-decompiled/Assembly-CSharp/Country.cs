using Cpp2ILInjected;
using UnityEngine;

public class Country
{
	public readonly string displayNameID;

	public readonly string flag;

	public readonly string countryCode;

	public Country(string displayNameID, string flag, string countryCode)
	{
		//IL_0011: Invalid comparison between I and F4
		//IL_00e5: Expected F4, but got I
		//IL_00e5: Expected I4, but got Obj
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Country)+18]");
		if (0f < 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Country)+1C]");
			if ((nint)0 == 0)
			{
				float time = Time.time;
				float time2 = Time.time;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Country)+14]");
				object obj = 0 - this.countryCode;
				float num = time2 * (float)obj;
				float deltaTime = num + (float)this.countryCode;
				((Animator)(object)displayNameID).Update(deltaTime);
			}
		}
		string text = this.flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Country)+18]");
		((Animator)(object)displayNameID).Play((int)text, 0, 0f);
		_ = 0f;
	}
}
