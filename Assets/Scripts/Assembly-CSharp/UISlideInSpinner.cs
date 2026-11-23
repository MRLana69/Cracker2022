using Cpp2ILInjected;
using UnityEngine;

public class UISlideInSpinner : UISlideIn
{
	private UILabel messageLabel;

	private UISprite spinner;

	private Transform _cachedSpinnerTransform;

	private Vector3 _singleStepRotation = (Vector3)0;

	private float _singleStepThreshold;

	private int _currentStep;

	private float _currentDuration;

	private int numberofSteps = 8;

	private void SetupSlidein(string message)
	{
		//IL_0031: Expected I, but got Obj
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		messageLabel.text = message;
		nint num = (nint)this;
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S2_v4 (Il2CppClass<UISlideInSpinner>)+E4] (should have been resolved before IL gen)");
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0041: Expected Obj, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected I4, but got Unknown
		//IL_005f: Expected Obj, but got I4
		//IL_006c: Expected I4, but got Obj
		//IL_008b: Expected F4, but got I
		//IL_0086: Expected native int or pointer, but got VT
		//IL_009a: Expected F4, but got VT
		//IL_0095: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		if (_cachedSpinnerTransform == null)
		{
			Transform cachedTransform = spinner.cachedTransform;
			_cachedSpinnerTransform = cachedTransform;
		}
		float deltaTime = Time.deltaTime;
		float num = (_currentDuration += deltaTime);
		if (_singleStepThreshold < num)
		{
			object obj2 = _currentStep + 1;
			int num2 = obj2 / numberofSteps;
			object obj3 = num2 * numberofSteps;
			int currentStep = obj2 - obj3;
			_currentStep = currentStep;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlideInSpinner)+4C]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)_singleStepRotation;
			_cachedSpinnerTransform.Rotate(vector);
			float currentDuration = _currentDuration - _singleStepThreshold;
			_currentDuration = currentDuration;
		}
	}

	public UISlideInSpinner()
	{
		//IL_0016: Expected VT, but got I4
		_ = 4453159315661127680L;
		base._002Ector();
	}
}
