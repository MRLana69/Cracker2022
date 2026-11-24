//Type is in global namespace

public class AvatarEyeAnimation : MonoBehaviour
{
	private sealed class <>c__DisplayClass48_0
	{
		public AvatarEyeAnimation <>4__this; //Field offset: 0x8
		public Vector3 fromPosition; //Field offset: 0xC
		public Vector3 focusPoint; //Field offset: 0x18

		public <>c__DisplayClass48_0() { }

		internal void <ShiftFocusPoint>b__0(float t) { }

	}

	private float blinkTime; //Field offset: 0xC
	private float blinkWaitTimeMax; //Field offset: 0x10
	private float blinkWaitTimeMin; //Field offset: 0x14
	private float shiftEyeHorizontalLimit; //Field offset: 0x18
	private float shiftEyeVerticalLimit; //Field offset: 0x1C
	private float shiftEyeHorizontalMultiplier; //Field offset: 0x20
	private float shiftEyeVerticalMultiplier; //Field offset: 0x24
	private Transform headboneTransform; //Field offset: 0x28
	private GameObject testTargetPoint; //Field offset: 0x2C
	private Vector2 maxLookOffset; //Field offset: 0x30
	private GameObject targetPosition; //Field offset: 0x38
	private Vector3 popupMenuFocusPointOffset; //Field offset: 0x3C
	private Vector3 characterMenuFocusPointOffset; //Field offset: 0x48
	private Vector3 boardMenuFocusPointOffset; //Field offset: 0x54
	private Vector3 duelsScreenFocusPointOffset; //Field offset: 0x60
	private float timeToMoveFocus; //Field offset: 0x6C
	private float timeBetweenFocusShiftMax; //Field offset: 0x70
	private float timeBetweenFocusShiftMin; //Field offset: 0x74
	private bool animate; //Field offset: 0x78
	private SkinnedMeshRenderer _headMesh; //Field offset: 0x7C
	private Transform _eyeFocusOrigin; //Field offset: 0x80
	private Transform _eyeFocusTarget; //Field offset: 0x84
	private Transform _eyeSwitch; //Field offset: 0x88
	private Transform _blendshapeController; //Field offset: 0x8C
	private GameObject _duelsScreensPrefab; //Field offset: 0x90
	private float blinkWaitEndTime; //Field offset: 0x94
	private float blinkEndTime; //Field offset: 0x98
	private float currentHorizontalLimit; //Field offset: 0x9C
	private float currentVerticalLimit; //Field offset: 0xA0
	private Vector3 toprunFocusPointOffset; //Field offset: 0xA4
	private Vector3 originalPosition; //Field offset: 0xB0
	private Vector3 originalRotation; //Field offset: 0xBC
	private Vector3 newTargetPosition; //Field offset: 0xC8
	private Vector3 lookToCamera; //Field offset: 0xD4
	private Vector2 offsetVector; //Field offset: 0xE0
	private float endTimeToShift; //Field offset: 0xE8
	private bool useFocuPoint; //Field offset: 0xEC
	private bool shiftToFocusBlink; //Field offset: 0xED
	private int _eyeMaterialID; //Field offset: 0xF0

	private bool IsEyeControlledByAnimation
	{
		 get { } //Length: 66
	}

	public AvatarEyeAnimation() { }

	public void AnimateEyes(ModelScreen modelScreen) { }

	private void AnimateEyes() { }

	public void DuelsScreenAnimateEyes(GameObject root, Vector3 offset) { }

	private void ForceBlink() { }

	private bool get_IsEyeControlledByAnimation() { }

	private Vector3 GetFocusPoint() { }

	public void Initialize(GameObject eyeFocus, Transform headJoint, Transform eyeSwitch, Transform eyeFocusOrigin, Transform eyeFocusTarget, Transform blendshapeController, SkinnedMeshRenderer headMesh, int eyeMaterialID) { }

	private void ResetEyes() { }

	private void ShiftFocusPoint(Vector3 focusPoint) { }

	public void StopAnimatingEyes() { }

	private void Update() { }

	private void UpdateAnimatedEyes() { }

	private void UpdateEyeBlinking() { }

	private void UpdateGetNewFocusPoint() { }

}

