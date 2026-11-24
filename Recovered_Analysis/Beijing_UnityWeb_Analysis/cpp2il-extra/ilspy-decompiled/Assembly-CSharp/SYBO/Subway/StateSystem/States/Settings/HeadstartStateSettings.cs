using Cpp2ILInjected;
using SYBO.Subway.Pickups;

namespace SYBO.Subway.StateSystem.States.Settings;

public class HeadstartStateSettings : ScriptableSingleton<HeadstartStateSettings>
{
	private float _turboHeadstart1FlyHeight = 60f;

	private float _turboHeadstart2FlyHeight = 95f;

	private PickupType[] _pickupTypes = (PickupType[])1.5f;

	private float _megaHeadstartFOVIncrease = 50f;

	private float _fovTransitionTime = 0.05f;

	public float TurboHeadstart1FlyHeight
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.Settings.HeadstartStateSettings)+24]");
			return 0f;
		}
	}

	public float TurboHeadstart2FlyHeight => _turboHeadstart1FlyHeight;

	public PickupType[] PickupTypes
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.Settings.HeadstartStateSettings)+28]");
			return (PickupType[])0;
		}
	}

	public float MegaHeadstartFOVIncrease => _turboHeadstart2FlyHeight;

	public float FovTransitionTime => _megaHeadstartFOVIncrease;

	public HeadstartStateSettings()
	{
		//IL_0026: Expected Obj, but got F4
		_ = 0.05f;
		_ = 15f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724B");
	}
}
