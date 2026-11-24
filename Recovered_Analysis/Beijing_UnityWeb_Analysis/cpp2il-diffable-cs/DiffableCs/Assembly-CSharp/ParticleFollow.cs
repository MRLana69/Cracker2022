//Type is in global namespace

public class ParticleFollow : MonoBehaviour
{
	public Transform Target; //Field offset: 0xC
	public float TweenTime; //Field offset: 0x10
	public float SineOffset; //Field offset: 0x14
	public float SineSpeed; //Field offset: 0x18
	public float RotationTweenTime; //Field offset: 0x1C
	private float tweenVelocity; //Field offset: 0x20
	private Vector3 baseRotation; //Field offset: 0x24
	private float tweenRotVelocity; //Field offset: 0x30

	public ParticleFollow() { }

	private void Awake() { }

	private void LateUpdate() { }

	private void OnDisable() { }

	private void OnEnable() { }

}

