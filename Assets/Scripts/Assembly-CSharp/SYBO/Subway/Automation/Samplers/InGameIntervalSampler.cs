using Cpp2ILInjected;
using SYBO.Common.Automation.Samplers;

namespace SYBO.Subway.Automation.Samplers;

public class InGameIntervalSampler : IntervalSampler
{
	public InGameIntervalSampler(float sampleInterval)
	{
		base._sampleInterval = sampleInterval;
	}

	public override bool Update(float unscaledDeltaTime)
	{
		if (Game.IsInstantiated)
		{
			Game instance = Game.Instance;
			Variable<bool> isInGame = instance.IsInGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (Variable`1<System.Boolean>)+8]");
			if ((nint)0 != 0)
			{
				return base.Update(unscaledDeltaTime);
			}
		}
		_timeSinceLastSample = 0f;
		return false;
	}
}
