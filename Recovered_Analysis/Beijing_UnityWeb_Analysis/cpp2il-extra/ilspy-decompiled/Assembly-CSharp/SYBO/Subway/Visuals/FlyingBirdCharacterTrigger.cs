using System;
using Cpp2ILInjected;
using SYBO.Common.Visuals;
using SYBO.Subway.Level;
using UnityEngine;
using UnityEngine.Rendering;

namespace SYBO.Subway.Visuals;

public class FlyingBirdCharacterTrigger : CharacterCollisionTrigger
{
	private Renderer _renderer;

	private MeshMorpher _meshMorpher;

	private Animation _animation;

	private bool _setDirection;

	private void Awake()
	{
		CancelInvoke();
	}

	private unsafe void OnEnable()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventHandler eventHandler = default;
		((Delegate)eventHandler).method_ptr = method_ptr;
		((Delegate)eventHandler).method = (nint)__ldftn(FlyingBirdCharacterTrigger.FlyingBirdCharacterTrigger_OnCharacterEnter);
		object obj = eventHandler + 16;
		obj = this;
		OnCharacterEnter -= eventHandler;
	}

	private void Update()
	{
		//IL_0032: Expected I, but got Obj
		//IL_0048: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_00c0: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_0073: Expected I, but got Obj
		//IL_0101: Expected I, but got Obj
		_setDirection = true;
		_renderer.shadowCastingMode = ShadowCastingMode.Off;
		MeshMorpher meshMorpher = _meshMorpher;
		meshMorpher._animate = false;
		_meshMorpher.Awake();
		Animation.INTERNAL_CALL_Stop(_animation);
		Animation.INTERNAL_CALL_Rewind(_animation);
		GameObject gameObject = _animation.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v11 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v35 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj3 + 32);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v16+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject2 = _animation.gameObject;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v23 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v31 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj3;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
	}

	private void FlyingBirdCharacterTrigger_OnCharacterEnter(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = sender;
		_renderer = (Renderer)(object)e;
		_ = 1;
		_meshMorpher = null;
	}

	public FlyingBirdCharacterTrigger()
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 16);
		if (~(_setDirection ? 1u : 0u) != 0)
		{
			return;
		}
		GameObject gameObject = base.gameObject;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v7 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v16 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Quaternion localRotation = transform.localRotation;
		_setDirection = false;
	}
}
