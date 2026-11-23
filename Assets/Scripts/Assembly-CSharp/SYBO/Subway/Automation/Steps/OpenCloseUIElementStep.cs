using Cpp2ILInjected;
using SYBO.Common.Automation.Steps;

namespace SYBO.Subway.Automation.Steps;

public class OpenCloseUIElementStep : AutomationStep
{
	public enum UIElementType
	{
		Popup,
		Screen
	}

	private enum StepState
	{
		None,
		WaitingBeforeOpen,
		Open,
		Closed
	}

	private UIElementType _type;

	private string _name;

	private const float DelayBefore = 0.2f;

	private const float OpenTime = 0.2f;

	private const float DelayAfter = 0.2f;

	private float _currentDuration;

	private StepState _currentState;

	private bool _skipFrame;

	public OpenCloseUIElementStep(UIElementType uiElementType, string name)
	{
		_name = string.Empty;
		_name = name;
		_type = uiElementType;
	}

	public override void Initialize()
	{
		_currentState = StepState.WaitingBeforeOpen;
	}

	public override void Cleanup()
	{
		_currentDuration = 0f;
		_skipFrame = false;
		base.IsDone__BackingField = false;
	}

	public override void Update(float unscaledDeltaTime)
	{
		//IL_008a: Expected Obj, but got I4
		Game instance = Game.Instance;
		Variable<bool> isInGame = instance.IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 != 0)
		{
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.GoToMainMenuFromGame(null);
			UIScreenController instance3 = UIScreenController.Instance;
			instance3.ClosePopup();
		}
		if (~(_skipFrame ? 1u : 0u) == 0)
		{
			_skipFrame = false;
			return;
		}
		float num = (_currentDuration += unscaledDeltaTime);
		object obj = _currentState - 1;
		if (_currentState != StepState.WaitingBeforeOpen)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2 && !(num < 0.6f))
				{
					UIScreenController instance4 = UIScreenController.Instance;
					instance4.ClosePopup();
					base.IsDone__BackingField = true;
				}
			}
			else
			{
				if (num < 0.4f)
				{
					return;
				}
				if (_type != UIElementType.Popup)
				{
					if (_type == UIElementType.Screen)
					{
						UIScreenController instance5 = UIScreenController.Instance;
						instance5.BackToPrevious();
					}
				}
				else
				{
					UIScreenController instance6 = UIScreenController.Instance;
					instance6.ClosePopup();
				}
				_currentState = StepState.Closed;
			}
		}
		else
		{
			if (num < 0.2f)
			{
				return;
			}
			if (_type != UIElementType.Popup)
			{
				if (_type == UIElementType.Screen)
				{
					UIScreenController instance7 = UIScreenController.Instance;
					instance7.PushScreen(_name);
				}
			}
			else
			{
				UIScreenController instance8 = UIScreenController.Instance;
				instance8.PushPopup(_name);
			}
			_skipFrame = true;
			_currentState = StepState.Open;
		}
	}
}
