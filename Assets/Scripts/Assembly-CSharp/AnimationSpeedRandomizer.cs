using UnityEngine;

public class AnimationSpeedRandomizer : MonoBehaviour
{
	private Animation _animation;

	private float _minAnimationSpeed = 1f;

	private float _maxAnimationSpeed;

	private void OnEnable()
	{
		if (_animation != null)
		{
			AnimationClip clip = _animation.clip;
			string text = clip.name;
			AnimationState animationState = _animation.get_Item(text);
			float speed = Random.Range(_minAnimationSpeed, _maxAnimationSpeed);
			animationState.speed = speed;
		}
	}
}
