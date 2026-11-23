using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class CharacterScreenController : MonoBehaviour
{
	private float _shadowFadeFactor = 0.7f;

	private float _characterFadeFactor;

	private AnimationClip _idleClip;

	public float _freeze = 1f;

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
			SetFreeze(value);
		}
	}

	public unsafe void Initialize(AnimationClip idleClip, Shader characterShader, Shader outfitShader, float characterFadeFactor, float shadowFadeFactor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0108: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_01ed: Expected Obj, but got I
		//IL_0328: Expected Obj, but got I
		//IL_033d: Expected F4, but got I
		//IL_0338: Expected native int or pointer, but got VT
		//IL_034c: Expected F4, but got VT
		//IL_0347: Expected native int or pointer, but got VT
		//IL_0366: Expected Obj, but got I
		//IL_037d: Expected Obj, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 16);
		_shadowFadeFactor = shadowFadeFactor;
		_characterFadeFactor = characterFadeFactor;
		GameObject gameObject = base.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		AvatarEyeAnimation avatarEyeAnimation = default;
		_avatarEyeAnimation = avatarEyeAnimation;
		_idleClip = idleClip;
		GameObject gameObject2 = base.gameObject;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ S4_v7 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		Animation animation = default;
		_animation = animation;
		string newName = _idleClip.name;
		_animation.AddClip(_idleClip, newName);
		string text = _idleClip.name;
		AnimationState idleState = _animation.get_Item(text);
		_idleState = idleState;
		_idleState.enabled = true;
		_idleState.speed = 1f;
		_idleState.weight = 1f;
		_idleState.layer = 0;
		_idleState.blendMode = AnimationBlendMode.Blend;
		_idleState.wrapMode = WrapMode.Loop;
		GameObject gameObject3 = base.gameObject;
		nint num5 = 0;
		nint num6 = 0;
		IntPtr intPtr3 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S4_v11 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		Renderer[] renderers = default;
		_renderers = renderers;
		object obj2 = 0;
		while (true)
		{
			Renderer[] renderers2 = _renderers;
			if (renderers2.Length <= (nint)obj2)
			{
				break;
			}
			object obj3 = obj2 << 2;
			object obj4 = (object)renderers2 + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v38+10]");
			GameObject gameObject4 = ((Component)0).gameObject;
			string text2 = gameObject4.name;
			if (text2 == "shadowPlane_blob")
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v38+10]");
				Material material = ((Renderer)0).material;
				_shadowMaterial = material;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v38+10]");
				Material[] materials = ((Renderer)0).materials;
				object obj5 = 0;
				while ((nint)obj5 < materials.Length)
				{
					object obj6 = obj5 << 2;
					object obj7 = (object)materials + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v53+10]");
					Shader shader = ((Material)0).shader;
					string text3 = shader.name;
					bool flag = text3 != "Custom/Distorted/Character seperated alpha";
					Shader shader2 = outfitShader;
					if (flag)
					{
						shader2 = characterShader;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v53+10]");
					((Material)0).shader = shader2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterScreenController)+40]");
					((Color*)(nint)color)->b = 0f;
					((Color*)(nint)color)->r = (float)_overlayColor;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v53+10]");
					((Material)0).SetColor("_Color", color);
					List<Material> materials2 = _materials;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v53+10]");
					materials2.Add((Material)0);
					object obj8 = obj5 + 1;
					obj5 = obj8;
				}
			}
			object obj9 = obj2 + 1;
			obj2 = obj9;
		}
		SetFreeze(1f);
	}

	private void SetFreeze(float freeze)
	{
		float num = default;
		if (!(freeze < 0f))
		{
			bool flag = freeze > 1f;
			bool flag2 = !flag;
			num = freeze;
			if (!flag2)
			{
				num = 1f;
			}
		}
		_freeze = num;
		bool flag3 = (_defreezing = num < _freeze);
		bool flag4 = (_freezing = num > _freeze);
		bool flag5;
		if (num == 1f)
		{
			flag5 = true;
			if (!_wasFreezing)
			{
				_idleState.enabled = true;
				_animation.Sample();
				bool wasFreezing = _wasFreezing;
				flag5 = wasFreezing;
			}
		}
		else if (flag3 && !_wasDefreezing)
		{
			_idleState.enabled = true;
			_idleState.wrapMode = WrapMode.Loop;
			_idleState.normalizedTime = 0f;
			_wasFreezing = false;
			bool flag6 = _avatarEyeAnimation != null;
			bool flag7 = !flag6;
			flag5 = true;
			if (!flag7)
			{
				_avatarEyeAnimation.AnimateEyes(UIModelController.ModelScreen.LimitedCharacterPopup);
				flag5 = true;
			}
		}
		else
		{
			bool flag8 = !flag4;
			flag5 = true;
			if (!flag8)
			{
				flag5 = true;
				if (!_wasFreezing)
				{
					_idleState.wrapMode = WrapMode.ClampForever;
					float normalizedTime = _idleState.normalizedTime;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @440");
					float normalizedTime2 = default;
					_idleState.normalizedTime = normalizedTime2;
					_wasFreezing = true;
					bool flag9 = _avatarEyeAnimation != null;
					bool flag10 = !flag9;
					flag5 = true;
					if (!flag10)
					{
						_avatarEyeAnimation.StopAnimatingEyes();
						flag5 = true;
					}
				}
			}
		}
		_idleState.enabled = flag5;
		_wasFreezing = _freezing;
		int num2 = 0;
		while (true)
		{
			List<Material> materials = _materials;
			if (num2 >= materials._size)
			{
				break;
			}
			Material material = _materials.get_Item(num2);
			float value = _freeze * _characterFadeFactor;
			material.SetFloat("_ShiftColor", value);
			int num3 = num2 + 1;
			num2 = num3;
		}
		if (_shadowMaterial != null)
		{
			float value2 = _freeze * _shadowFadeFactor;
			_shadowMaterial.SetFloat("_Fade", value2);
		}
	}

	private void OnDestroy()
	{
		UnityEngine.Object.Destroy(_shadowMaterial);
	}

	public CharacterScreenController()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I8
		//IL_0056: Expected VT, but got I8
		List<Material> list = default;
		list._002Ector();
		_materials = list;
		object obj = this - -64;
		obj = 4575657222473777152L;
		_overlayColor = (Color)4575657222473777152L;
		base._002Ector();
	}
}
