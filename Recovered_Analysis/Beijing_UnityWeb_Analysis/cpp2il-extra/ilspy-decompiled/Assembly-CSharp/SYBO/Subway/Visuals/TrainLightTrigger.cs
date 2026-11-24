using System;
using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace SYBO.Subway.Visuals;

public class TrainLightTrigger : CharacterPassTrigger
{
	private MaterialAnimationController _materialAnimationController;

	private Animation _animation;

	private void Awake()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}

	private unsafe void OnEnable()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got VT
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		object obj = this + 24;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj = componentInChildren;
		object obj2 = this + 28;
		Animation component = GetComponent<Animation>();
		obj2 = component;
		MaterialAnimationController materialAnimationController = _materialAnimationController;
		materialAnimationController._colorMultiplier = 1f;
		_animation.tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventHandler eventHandler = default;
		((Delegate)eventHandler).method_ptr = method_ptr;
		((Delegate)eventHandler).method = (nint)__ldftn(TrainLightTrigger.TrainLightTrigger_Triggered);
		object obj3 = eventHandler + 16;
		obj3 = this;
		Triggered -= eventHandler;
	}

	private void TrainLightTrigger_Triggered(object sender, EventArgs e)
	{
		((Renderer)(object)base._collider).shadowCastingMode = ShadowCastingMode.On;
		EventHandler triggered = base.Triggered;
		((Delegate)triggered).extra_arg = (IntPtr)1;
		IEnumerator enumerator = ((Animation)(object)_materialAnimationController).GetEnumerator();
	}

	public TrainLightTrigger()
	{
		MaterialAnimationController materialAnimationController = _materialAnimationController;
		materialAnimationController._colorMultiplier = 1f;
		Animation.INTERNAL_CALL_Stop(_animation);
		Animation.INTERNAL_CALL_Rewind(_animation);
		_animation.tag = null;
	}
}
