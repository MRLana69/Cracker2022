using Cpp2ILInjected;

namespace Kiloo;

public class RandomTimeDelay : BaseTimeDelay
{
	private float _maxTimeDelay;

	private float _minTimeDelay;

	public override float delay
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.RandomTimeDelay)+14]");
			return 0f;
		}
	}

	public RandomTimeDelay()
	{
		CancelInvoke();
	}
}
