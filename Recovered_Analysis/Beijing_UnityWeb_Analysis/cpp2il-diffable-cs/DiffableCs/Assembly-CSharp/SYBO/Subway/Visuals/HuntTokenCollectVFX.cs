namespace SYBO.Subway.Visuals;

public abstract class HuntTokenCollectVFX : MonoBehaviour
{
	protected ParticleSystem _particleSystem; //Field offset: 0xC

	protected HuntTokenCollectVFX() { }

	private void Awake() { }

	public abstract IEnumerator PlayEffect() { }

	public virtual void Setup() { }

	private void Update() { }

}

