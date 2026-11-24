using Cpp2ILInjected;
using UnityEngine;

public class PreloadSetting : MonoBehaviour
{
	private int _preloadAmount;

	public int PreloadAmount
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (PreloadSetting)+10]");
			return 0;
		}
	}

	public PreloadSetting()
	{
		CancelInvoke();
	}
}
