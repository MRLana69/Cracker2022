namespace UI.Generic;

public class FitSpriteToWidget : MonoBehaviour
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

	public enum FittingMode
	{
		Constrain = 0,
		Fill = 1,
		FitWidth = 2,
		FitHeight = 3,
		Stretch = 4,
		PixelPerfect = 5,
		MaxSize = 6,
	}

	private UISprite _spriteToFit; //Field offset: 0xC
	private UIWidget _widgetContainer; //Field offset: 0x10
	public FittingMode fittingMode; //Field offset: 0x14
	private Execute _execute; //Field offset: 0x18

	public UIWidget widgetContainer
	{
		 set { } //Length: 136
	}

	public FitSpriteToWidget() { }

	private void FitConstrain() { }

	private void FitFill() { }

	private void FitHeight() { }

	private void FitMaxSize(int spriteWidth, int spriteHeight) { }

	public void FitNow() { }

	private void FitPixelPerfect(int spriteWidth, int spriteHeight) { }

	private void FitStretch() { }

	private void FitWidth() { }

	private void FixedUpdate() { }

	private void LateUpdate() { }

	private void OnEnable() { }

	public void set_widgetContainer(UIWidget value) { }

	private void Start() { }

	private void Update() { }

}

