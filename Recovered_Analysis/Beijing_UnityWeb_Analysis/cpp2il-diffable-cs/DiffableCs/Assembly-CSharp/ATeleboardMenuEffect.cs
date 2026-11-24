//Type is in global namespace

public abstract class ATeleboardMenuEffect : MonoBehaviour
{
	protected Transform _rootTransform; //Field offset: 0xC
	protected bool _boardOnly; //Field offset: 0x10

	protected ATeleboardMenuEffect() { }

	public abstract void EndTeleboardEffect(float duration, CharacterModel characterModel) { }

	public virtual void Initialize(Transform root, bool boardOnly = false) { }

	public abstract void StartTeleboardEffect(float duration, CharacterModel characterModel) { }

}

