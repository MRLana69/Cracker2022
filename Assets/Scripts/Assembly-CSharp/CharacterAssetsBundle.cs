using UnityEngine;

public class CharacterAssetsBundle : MonoBehaviour
{
	public Mesh MainMesh;

	public Mesh HeadMesh;

	public int EyeMaterialID = 1;

	public bool AnimatedEyesHaveDoubleMaterial = true;

	public AvatarEyeAnimation _avatarEyeAnimation;

	public AnimationClip Breath;

	public AnimationClip ScrollbarPose;

	public AnimationClip ScrollbarHeadPose;

	public AnimationClip EventScreenPose;

	public AnimationClip NameEventScreenIdle;

	public AnimationClip RunIdle;

	public bool UseCustomEventScreenIdle = true;
}
