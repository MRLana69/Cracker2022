using Cpp2ILInjected;

namespace SYBO.Subway.StateSystem.States.Settings;

public class JetpackStateSettings : ScriptableSingleton<JetpackStateSettings>
{
	private float _speedup = 105f;

	private float _coinOffset = 120f;

	public float Speedup
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.Settings.JetpackStateSettings)+1C]");
			return 0f;
		}
	}

	public float CoinOffset => _speedup;

	public JetpackStateSettings()
	{
		_ = 18f;
		_ = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724B");
	}
}
