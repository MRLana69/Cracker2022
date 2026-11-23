using System;
using Cpp2ILInjected;
using SYBO.Common.Visuals;
using SYBO.Subway.Level;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class FlyingBirdCharacterTrigger : CharacterCollisionTrigger
{
	private Renderer _renderer;

	private MeshMorpher _meshMorpher;

	private Animation _animation;

	private bool _setDirection = true;

	private unsafe void Awake()
	{
		EventHandler eventHandler = default;
		eventHandler._002Ector(this, (nint)__ldftn(FlyingBirdCharacterTrigger.FlyingBirdCharacterTrigger_OnCharacterEnter));
		OnCharacterEnter += eventHandler;
	}

	private unsafe void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008c: Expected I, but got Obj
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected VT, but got Unknown
		//IL_0106: Expected I, but got Obj
		//IL_0138: Expected F4, but got I
		//IL_0133: Expected native int or pointer, but got VT
		//IL_0153: Expected F4, but got I
		//IL_014e: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj + -64);
		_setDirection = true;
		_renderer.enabled = false;
		MeshMorpher meshMorpher = _meshMorpher;
		meshMorpher._animate = false;
		meshMorpher.Reset();
		_animation.Stop();
		_animation.Rewind();
		Transform transform = _animation.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v22 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Vector3 localPosition = (Vector3)(quaternion + 16);
		transform.localPosition = localPosition;
		Transform transform2 = _animation.transform;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v37 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v38 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+28]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+20]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		transform2.localRotation = quaternion;
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0045: Expected I, but got Obj
		//IL_0077: Expected F4, but got I
		//IL_0072: Expected native int or pointer, but got VT
		//IL_0092: Expected F4, but got I
		//IL_008d: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		if (~(_setDirection ? 1u : 0u) == 0)
		{
			Transform transform = base.transform;
			nint num = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v15 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v16 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+18]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+10]");
			((Quaternion*)(nint)quaternion)->x = 0f;
			transform.rotation = quaternion;
			_setDirection = false;
		}
	}

	private void FlyingBirdCharacterTrigger_OnCharacterEnter(object sender, EventArgs e)
	{
		_renderer.enabled = true;
		MeshMorpher meshMorpher = _meshMorpher;
		meshMorpher._animate = true;
		bool flag = _animation.Play();
	}
}
