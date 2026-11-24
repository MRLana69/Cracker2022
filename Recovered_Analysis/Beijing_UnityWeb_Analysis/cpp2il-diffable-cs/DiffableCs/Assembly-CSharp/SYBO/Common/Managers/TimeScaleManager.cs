namespace SYBO.Common.Managers;

public class TimeScaleManager
{
	private const float TimeScaleDefault = 1; //Field offset: 0x0
	private float _timeScaleInMenuDefault; //Field offset: 0x10
	private float _timeScaleInGameDefault; //Field offset: 0x14

	public float TimeScale
	{
		 get { } //Length: 7
		 set { } //Length: 179
	}

	public float TimeScaleInGameDefault
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float TimeScaleInMenuDefault
	{
		 get { } //Length: 7
		 set { } //Length: 9
	}

	public TimeScaleManager() { }

	public float get_TimeScale() { }

	public float get_TimeScaleInGameDefault() { }

	public float get_TimeScaleInMenuDefault() { }

	private void InputManager_OnInputEvent(object sender, InputEventArgs inputEventArgs) { }

	protected override void OnDestroy() { }

	public void set_TimeScale(float value) { }

	public void set_TimeScaleInGameDefault(float value) { }

	public void set_TimeScaleInMenuDefault(float value) { }

	protected override void SubclassInitialize() { }

}

