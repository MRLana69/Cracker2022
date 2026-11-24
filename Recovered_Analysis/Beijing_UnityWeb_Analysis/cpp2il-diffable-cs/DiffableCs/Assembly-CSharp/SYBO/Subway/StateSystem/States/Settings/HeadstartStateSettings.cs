namespace SYBO.Subway.StateSystem.States.Settings;

public class HeadstartStateSettings
{
	private float _turboHeadstart1FlyHeight; //Field offset: 0xC
	private float _turboHeadstart2FlyHeight; //Field offset: 0x10
	private PickupType[] _pickupTypes; //Field offset: 0x14
	private float _megaHeadstartFOVIncrease; //Field offset: 0x18
	private float _fovTransitionTime; //Field offset: 0x1C

	public float FovTransitionTime
	{
		 get { } //Length: 6
	}

	public float MegaHeadstartFOVIncrease
	{
		 get { } //Length: 6
	}

	public PickupType[] PickupTypes
	{
		 get { } //Length: 6
	}

	public float TurboHeadstart1FlyHeight
	{
		 get { } //Length: 6
	}

	public float TurboHeadstart2FlyHeight
	{
		 get { } //Length: 6
	}

	public HeadstartStateSettings() { }

	public float get_FovTransitionTime() { }

	public float get_MegaHeadstartFOVIncrease() { }

	public PickupType[] get_PickupTypes() { }

	public float get_TurboHeadstart1FlyHeight() { }

	public float get_TurboHeadstart2FlyHeight() { }

}

