using UnityEngine;

public class OffsetAnimation : MonoBehaviour
{
	private Animator animator;

	private void Start()
	{
		if (animator == null)
		{
			GameObject gameObject = base.gameObject;
			Animator component = gameObject.GetComponent<Animator>();
			animator = component;
			float value = Random.Range(0f, 1f);
			animator.SetFloat("offset", value);
		}
	}
}
