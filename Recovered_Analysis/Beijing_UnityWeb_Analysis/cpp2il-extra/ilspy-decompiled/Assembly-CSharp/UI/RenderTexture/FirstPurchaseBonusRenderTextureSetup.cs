using System;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.RenderTexture;

[Serializable]
public class FirstPurchaseBonusRenderTextureSetup : RenderTextureSetupBase
{
	private AnimationClip _firstPurchaseBonusIdleAnimation;

	private CharacterModel _characterModel;

	protected override void OnSetup()
	{
	}

	public FirstPurchaseBonusRenderTextureSetup()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		object obj = this + 60;
		CharacterModel component = _objectInstance.GetComponent<CharacterModel>();
		obj = component;
		_characterModel.HideBlobShadow();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
