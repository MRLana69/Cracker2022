using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class CharacterScreenController : MonoBehaviour
{
	private float _shadowFadeFactor;

	private float _characterFadeFactor;

	private AnimationClip _idleClip;

	public float _freeze;

	public bool _freezing;

	public bool _defreezing;

	private bool _wasFreezing;

	private bool _wasDefreezing;

	private Animation _animation;

	public AnimationState _idleState;

	private Renderer[] _renderers;

	private List<Material> _materials;

	private Material _shadowMaterial;

	private AvatarEyeAnimation _avatarEyeAnimation;

	private Color _overlayColor;

	public float Freeze
	{
		set
		{
			//IL_0015: Expected Obj, but got I
			//IL_002a: Expected Obj, but got I
			//IL_0067: Expected Obj, but got F4
			//IL_0077: Expected Obj, but got F4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterScreenController)+44]");
			((AnimationState)0).speed = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterScreenController)+48]");
			((AnimationState)0).speed = value;
			if (value == 1f)
			{
				((Renderer)_shadowFadeFactor).shadowCastingMode = ShadowCastingMode.Off;
				((Renderer)_characterFadeFactor).shadowCastingMode = ShadowCastingMode.Off;
			}
		}
	}

	public void Initialize(AnimationClip idleClip, Shader characterShader, Shader outfitShader, float characterFadeFactor, float shadowFadeFactor)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private void SetFreeze(float freeze)
	{
		((playThruster)this)._003CPlayEffects_003Eb__22_0(freeze);
	}

	private void OnDestroy()
	{
		CancelInvoke();
	}

	public CharacterScreenController()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Object.DestroyImmediate(_shadowMaterial);
	}
}
