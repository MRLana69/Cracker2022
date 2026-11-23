using UnityEngine;

public abstract class ATeleboardMenuEffect : MonoBehaviour
{
	protected Transform _rootTransform;

	public virtual void Initialize(Transform root)
	{
		_rootTransform = root;
	}

	public abstract void StartTeleboardEffect(float duration, CharacterModel characterModel);

	public abstract void EndTeleboardEffect(float duration, CharacterModel characterModel);
}
