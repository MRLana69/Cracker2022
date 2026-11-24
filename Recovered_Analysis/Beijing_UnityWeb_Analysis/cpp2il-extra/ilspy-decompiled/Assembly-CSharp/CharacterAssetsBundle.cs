using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class CharacterAssetsBundle : MonoBehaviour
{
	[Serializable]
	private class OutfitBreathAnimation
	{
		private string OutfitIdentifier;

		public int OutfitIndex;

		public AnimationClip Breath;
	}

	public Mesh MainMesh;

	public Mesh HeadMesh;

	public int EyeMaterialID;

	public bool AnimatedEyesHaveDoubleMaterial;

	public AvatarEyeAnimation _avatarEyeAnimation;

	public AnimationClip Breath;

	public AnimationClip ScrollbarPose;

	public AnimationClip ScrollbarHeadPose;

	public AnimationClip EventScreenPose;

	public AnimationClip NameEventScreenIdle;

	public bool UseCustomEventScreenIdle;

	private List<OutfitBreathAnimation> _outfitBreathAnimations;

	public AnimationClip GetOutfitBreatheOrNull(int outfitIndex)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AnimationClip animationClip = default;
		((UnityEngine.Object)animationClip).m_CachedPtr = (IntPtr)0;
		object obj = animationClip + 16;
		obj = this;
		object obj2 = animationClip + 20;
		obj2 = outfitIndex;
		return animationClip;
	}

	public CharacterAssetsBundle()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		object obj = this + 16;
		obj = "Assets/Bundles/CharacterAssets/";
		object obj2 = this + 20;
		obj2 = "Assets/Bundles/CharacterCustomizationAssets/";
		AnimatedEyesHaveDoubleMaterial = true;
		object obj3 = this + 28;
		obj3 = "Assets/Bundles/CharacterIdles/";
		object obj4 = this + 32;
		obj4 = "_idles";
		object obj5 = this + 36;
		obj5 = "Assets/Bundles/CharacterTextures/";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		list.Add("_outfit1_tex");
		list.Add("_outfit2_tex");
		list.Add("_tex");
		object obj6 = this + 40;
		obj6 = list;
		object obj7 = this + 44;
		obj7 = "_low";
		CancelInvoke();
	}
}
