//Type is in global namespace

public class GliderAnimation : MonoBehaviour
{
	private Animation _animation; //Field offset: 0xC
	private AnimationClip _clipClose; //Field offset: 0x10
	private AnimationClip _clipOpen; //Field offset: 0x14
	private AnimationState _stateClose; //Field offset: 0x18
	private AnimationState _stateOpen; //Field offset: 0x1C
	private Character _character; //Field offset: 0x20
	private HoverboardModelPreviewFactory _factory; //Field offset: 0x24
	private bool _open; //Field offset: 0x28

	public GliderAnimation() { }

	public void AddEvents() { }

	public void AddEvents(HoverboardModelPreviewFactory factory) { }

	private void Awake() { }

	private void HandleOnClose() { }

	private void HandleOnCloseMenu() { }

	private void HandleOnHangtime() { }

	private void HandleOnLanding(Character character) { }

	private void HandleOnOpenMenu() { }

	private void HandleOnSwitchToHoverboard(HoverboardBundle hoverbooardBundle, BoardAbility[] abilities) { }

	private void OnDestroy() { }

	public void RemoveEventHandling() { }

}

