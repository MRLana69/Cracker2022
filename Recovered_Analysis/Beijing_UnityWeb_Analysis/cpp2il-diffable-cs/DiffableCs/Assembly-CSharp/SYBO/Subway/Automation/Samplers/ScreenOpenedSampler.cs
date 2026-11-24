namespace SYBO.Subway.Automation.Samplers;

public class ScreenOpenedSampler : IMetricSampler
{
	private bool _shouldSample; //Field offset: 0x8

	public ScreenOpenedSampler() { }

	public void Cleanup() { }

	public void Initialize() { }

	private void UIScreenController_OnNavigateToScreen(string screenId) { }

	private void UIScreenController_OnPopupShown(string popupId) { }

	public bool Update(float unscaledDeltaTime) { }

}

