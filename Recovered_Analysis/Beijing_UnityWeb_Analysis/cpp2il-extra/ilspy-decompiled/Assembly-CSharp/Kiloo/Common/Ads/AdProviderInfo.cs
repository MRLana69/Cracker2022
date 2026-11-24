using Cpp2ILInjected;

namespace Kiloo.Common.Ads;

public class AdProviderInfo
{
	private int priority__BackingField;

	public float weight
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdProviderInfo)+14]");
			return 0f;
		}
		set
		{
		}
	}

	public int priority
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdProviderInfo)+1C]");
			return 0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 28;
			obj = value;
		}
	}

	public string providerID
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)priority__BackingField;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			priority__BackingField = (int)value;
		}
	}
}
