namespace SYBO.Subway.Cameras;

public class CharacterCamera : MonoBehaviour
{
	private sealed class <>c__DisplayClass81_0
	{
		public CharacterCamera <>4__this; //Field offset: 0x8
		public float amplitude; //Field offset: 0xC

		public <>c__DisplayClass81_0() { }

		internal void <Shake>b__0(float t) { }

	}

	private sealed class <>c__DisplayClass84_0
	{
		public CharacterCamera <>4__this; //Field offset: 0x8
		public float startFOV; //Field offset: 0xC
		public float multiplier; //Field offset: 0x10

		public <>c__DisplayClass84_0() { }

		internal void <FOVGip>b__0(float t) { }

	}

	private sealed class <FOVTarget_Coroutine>d__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 60
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <FOVTarget_Coroutine>d__86(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum CameraState
	{
		Menu = 0,
		DefaultRunning = 1,
		Custom = 2,
	}

	public const float DefaultCharacterLookAtAngle = 21.5; //Field offset: 0x0
	private const float FRONTSCREEN_FOV_HIGH_ASPECT_RATIO = 80; //Field offset: 0x0
	private const float HIGH_ASPECT_RATIO = 2.2; //Field offset: 0x0
	private const float LOW_ASPECT_RATIO = 1.5; //Field offset: 0x0
	public const float DefaultFieldOfView = 68; //Field offset: 0x0
	private const float MenuFieldOfView = 71; //Field offset: 0x0
	private const float FRONTSCREEN_FOV_LOW_ASPECT_RATIO = 71; //Field offset: 0x0
	private const float _HIGH_SPEED_2_FOV_SMOOTH_DURATION = 1; //Field offset: 0x0
	private const float _SMOOTH_DAMP_THRESHHOLD = 0.5; //Field offset: 0x0
	public const float DefaultAspectRatio = 0.5625; //Field offset: 0x0
	private static CharacterCamera instance; //Field offset: 0x0
	private const float _HIGH_SPEED_1_FOV_SMOOTH_DURATION = 1; //Field offset: 0x0
	private const float _HIGH_SPEED_2_FOV = 10; //Field offset: 0x0
	private const float _HIGH_SPEED_1_FOV = 5; //Field offset: 0x0
	private float tunnelDelta; //Field offset: 0xC
	private MainCamera _mainCamera; //Field offset: 0x10
	private Vector3 _position; //Field offset: 0x14
	private Vector3 _target; //Field offset: 0x20
	public float _speed; //Field offset: 0x2C
	private float _previousCameraEndYPosition; //Field offset: 0x30
	private float _previousCameraEndXRotation; //Field offset: 0x34
	private CameraData _currentCameraData; //Field offset: 0x38
	private CameraData _defaultCameraData; //Field offset: 0x3C
	private CameraSpeedType _cameraSpeedType; //Field offset: 0x40
	private float _customhighSpeedFOV; //Field offset: 0x44
	private CameraState _currentCameraState; //Field offset: 0x48
	private float _lastZ; //Field offset: 0x4C
	private Vector3 _shake; //Field offset: 0x50
	private Vector3 _diff; //Field offset: 0x5C
	private bool _fovGipping; //Field offset: 0x68
	private Camera _camera; //Field offset: 0x6C
	private SmoothDampVector3B _cameraTarget; //Field offset: 0x70
	private Vector3 _lastCameraTransformPosition; //Field offset: 0x74
	private Vector3 _lastCameraTarget; //Field offset: 0x80
	private SmoothDampVector3B _cameraPosition; //Field offset: 0x8C
	private Character _character; //Field offset: 0x90
	private SmoothDampFloat _fieldOfViewSmoothDampFloat; //Field offset: 0x94
	private bool _hasSuperSneakers; //Field offset: 0x98
	private float _cameraModifierColliderStartGamePositionZ; //Field offset: 0x9C
	private Curve offsetDeltaCurve; //Field offset: 0xA0
	private float _cameraModifierColliderEndGamePositionZ; //Field offset: 0xA4
	private float _cameraModifierY; //Field offset: 0xA8
	private float _cameraModifierX; //Field offset: 0xAC
	private Vector3 _previousCameraEndPosition; //Field offset: 0xB0
	private Vector3 _previousTargetEndPosition; //Field offset: 0xBC
	private float _tweenTimeTransform; //Field offset: 0xC8
	private bool _initialized; //Field offset: 0xCC
	private float _lastDeltaYFactor; //Field offset: 0xD0

	public Camera Camera
	{
		 get { } //Length: 9
	}

	public CameraData CameraData
	{
		 get { } //Length: 6
		private set { } //Length: 123
	}

	public Vector3 CameraPositionValue
	{
		 get { } //Length: 762
	}

	public CameraSpeedType CameraSpeedType
	{
		 get { } //Length: 6
		private set { } //Length: 513
	}

	public static CharacterCamera Instance
	{
		 get { } //Length: 298
	}

	public MainCamera MainCamera
	{
		 get { } //Length: 6
	}

	public Vector3 Position
	{
		 get { } //Length: 26
		 set { } //Length: 26
	}

	public float Speed
	{
		 get { } //Length: 6
	}

	public Vector3 Target
	{
		 get { } //Length: 61
		 set { } //Length: 26
	}

	private static CharacterCamera() { }

	public CharacterCamera() { }

	protected void Awake() { }

	private void Character_OnStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble) { }

	public void CharacterModifierCollection_OnChanged(object sender, CharacterModifierCollectionChangedEventArgs characterModifierCollectionChangedEventArgs) { }

	private void DebugLogCameraDetails() { }

	public void EnterCameraModifierCollider(float colliderLength) { }

	public void ExitCameraModifierCollider() { }

	public void FOVGip(float time, float multiplier) { }

	private IEnumerator FOVTarget_Coroutine() { }

	public Camera get_Camera() { }

	public CameraData get_CameraData() { }

	public Vector3 get_CameraPositionValue() { }

	public CameraSpeedType get_CameraSpeedType() { }

	public static CharacterCamera get_Instance() { }

	public MainCamera get_MainCamera() { }

	public Vector3 get_Position() { }

	public float get_Speed() { }

	public Vector3 get_Target() { }

	public CameraData GetDefaultCameraData() { }

	public CameraData GetDefaultCameraDataForMenu() { }

	private float GetFOVForAspectRatio(float aspectRatio) { }

	private CharacterCamera Initialize() { }

	protected void LateUpdate() { }

	protected void OnDrawGizmos() { }

	public void ResetShake() { }

	public void RevertFOV() { }

	private void set_CameraData(CameraData value) { }

	private void set_CameraSpeedType(CameraSpeedType value) { }

	public void set_Position(Vector3 value) { }

	public void set_Target(Vector3 value) { }

	public void SetCameraDataForcefully(CameraData cameraData) { }

	public void SetCameraDataForcefully(CameraData cameraData, Vector3 cameraLocalPosition, Quaternion cameraLocalRotation) { }

	public void SetCameraState(CameraState state) { }

	public void SetFOV(float addedFOV) { }

	public void Shake() { }

	public void Shake(float intensity) { }

	protected void Start() { }

}

