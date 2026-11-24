namespace SYBO.Subway.Automation.Steps;

public class OpenCloseUIElementStep : AutomationStep
{
	private enum StepState
	{
		None = 0,
		WaitingBeforeOpen = 1,
		Open = 2,
		Closed = 3,
	}

	public enum UIElementType
	{
		Popup = 0,
		Screen = 1,
	}

	private const float DelayBefore = 0.2; //Field offset: 0x0
	private const float OpenTime = 0.2; //Field offset: 0x0
	private const float DelayAfter = 0.2; //Field offset: 0x0
	private UIElementType _type; //Field offset: 0xC
	private string _name; //Field offset: 0x10
	private float _currentDuration; //Field offset: 0x14
	private StepState _currentState; //Field offset: 0x18
	private bool _skipFrame; //Field offset: 0x1C

	public OpenCloseUIElementStep(UIElementType uiElementType, string name) { }

	public override void Cleanup() { }

	public override void Initialize() { }

	public override void Update(float unscaledDeltaTime) { }

}

