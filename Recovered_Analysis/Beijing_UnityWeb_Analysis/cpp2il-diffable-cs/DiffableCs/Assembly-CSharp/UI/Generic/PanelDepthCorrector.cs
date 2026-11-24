namespace UI.Generic;

public class PanelDepthCorrector : MonoBehaviour
{
	private enum Execute
	{
		Off = 0,
		OnEnable = 1,
		OnStart = 2,
		OnUpdate = 3,
		OnFixedUpdate = 4,
		OnLateUpdate = 5,
	}

	private UIPanel _targetPanel; //Field offset: 0xC
	private Execute _execute; //Field offset: 0x10

	public PanelDepthCorrector() { }

	private void <CorrectNow>b__8_0() { }

	public void CorrectNow() { }

	private void FixedUpdate() { }

	private void LateUpdate() { }

	private void OnEnable() { }

	private void Start() { }

	private void Update() { }

}

