//Type is in global namespace

public class HoverboardModelPreviewFactory : MonoBehaviour
{
	private sealed class <JumpDelayedEvent>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float delay; //Field offset: 0x10
		public HoverboardModelPreviewFactory <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 156
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <JumpDelayedEvent>d__50(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <SpeederEvents>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public HoverboardModelPreviewFactory <>4__this; //Field offset: 0x10
		public float waitTime; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 169
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SpeederEvents>d__51(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <TeleboardEndTimer>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float duration; //Field offset: 0x10
		public HoverboardModelPreviewFactory <>4__this; //Field offset: 0x14
		private float <time>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 285
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <TeleboardEndTimer>d__57(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <TeleportFXStartScale>d__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float duration; //Field offset: 0x10
		public HoverboardModelPreviewFactory <>4__this; //Field offset: 0x14
		private float <time>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 719
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <TeleportFXStartScale>d__55(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class HoverboardModelSetup
	{
		public string name; //Field offset: 0x8
		public Vector3 eulerAngles; //Field offset: 0xC
		public float menuYPosition; //Field offset: 0x18
		public AnimationClip clipHangtime; //Field offset: 0x1C
		public AnimationClip clipRun; //Field offset: 0x20

		public HoverboardModelSetup() { }

	}

	private static HoverboardModelPreviewFactory instance; //Field offset: 0x0
	private HoverboardModelSetup[] hoverboards; //Field offset: 0xC
	private AnimationClip jumperSignature; //Field offset: 0x10
	private AnimationClip speederSignature; //Field offset: 0x14
	private AnimationClip doublejumperSignature; //Field offset: 0x18
	private AnimationClip lowriderSignature; //Field offset: 0x1C
	private AnimationClip lowriderRunIdle; //Field offset: 0x20
	private AnimationClip teleporterSignature; //Field offset: 0x24
	private AnimationClip gliderSignature; //Field offset: 0x28
	private AnimationClip vanitySignature; //Field offset: 0x2C
	public Action OnOpenGlider; //Field offset: 0x30
	public Action OnCloseGlider; //Field offset: 0x34
	public Action OnSpeederStart; //Field offset: 0x38
	public Action OnSpeederEnd; //Field offset: 0x3C
	public Action OnJump; //Field offset: 0x40
	private Dictionary<string, HoverboardModelSetup> name2board; //Field offset: 0x44
	private string currentIdleClip; //Field offset: 0x48
	private GameObject teleboardWarpPrefab; //Field offset: 0x4C
	private Material teleboardFXMaterial; //Field offset: 0x50
	private GameObject teleboardWarp; //Field offset: 0x54
	private ATeleboardMenuEffect _teleboardMenuEffect; //Field offset: 0x58
	private AnimationState teleboardAnimation; //Field offset: 0x5C
	private Vector3 teleboardWarpPosition; //Field offset: 0x60
	private GliderAnimation gliderAnimation; //Field offset: 0x6C
	private readonly int id_Teleboard; //Field offset: 0x70
	private readonly int id_Glider; //Field offset: 0x74
	private Animator animator; //Field offset: 0x78
	private Vector3 intialScale; //Field offset: 0x7C
	private Transform root; //Field offset: 0x88
	private Material cachedModelMaterial; //Field offset: 0x8C
	private Material cachedCustomizationMaterial; //Field offset: 0x90
	private Material[] cachedHeadMaterials; //Field offset: 0x94
	private Renderer cachedHoverboardBaseModelRenderer; //Field offset: 0x98
	private Material cachedHoverboardMaterial; //Field offset: 0x9C
	private Material cachedSupersneakersMaterial; //Field offset: 0xA0
	private Material cachedDoubleJumperMaterial; //Field offset: 0xA4
	private Material[] cachedCustomHoverboardModelMaterials; //Field offset: 0xA8
	private HoverboardBundle hoverboardBundle; //Field offset: 0xAC
	private CharacterModel characterModel; //Field offset: 0xB0
	private bool cachedCustomizationState; //Field offset: 0xB4
	private bool teleportFxActive; //Field offset: 0xB5

	public static HoverboardModelPreviewFactory Instance
	{
		 get { } //Length: 217
	}

	private static HoverboardModelPreviewFactory() { }

	public HoverboardModelPreviewFactory() { }

	private void <TeleboardEnd>b__56_0(float t) { }

	private void <TeleboardEnd>b__56_1(float t) { }

	private void AddCustomModelsAndFX(CustomSet[] customSets, int customSetIndex, Transform hoverboardRoot) { }

	public void Awake() { }

	private void CachMaterials() { }

	public void ChangeHoverboard(BoardId boardId, GameObject hoverboardGO, Animation characterAnimation, bool willUpdateAnimation, bool willAllowSignatureAnimation, BoardAbility boardAbility) { }

	private void CloseGlider() { }

	private CharacterModel FindCharacterModel(GameObject characterAnimation) { }

	public static HoverboardModelPreviewFactory get_Instance() { }

	public Quaternion GetHoverboardDefaultRotation(string name) { }

	public GameObject GetHoverboardModelPreview(string name, BoardId boardId) { }

	private void HandleOnNavigateToScreen(string obj) { }

	private void HandleOnPopupShown(string popupName) { }

	private IEnumerator JumpDelayedEvent(float delay) { }

	private void OnDestroy() { }

	private void OpenGlider() { }

	public void PlaySignatureMove(CustomSet set, Animation characterAnimation, bool useLowrider) { }

	public void ResetAnimator() { }

	public void ResetTeleportFX() { }

	private void SetEnabledWithinCurrentCustomHoverboardModels(bool isEnabled) { }

	private IEnumerator SpeederEvents(float waitTime) { }

	private void TeleboardEnd(float duration) { }

	private IEnumerator TeleboardEndTimer(float duration) { }

	private void TeleboardStart(float duration) { }

	private IEnumerator TeleportFXStartScale(float duration) { }

	private void UIScreenController_OnApplicationResumed() { }

}

