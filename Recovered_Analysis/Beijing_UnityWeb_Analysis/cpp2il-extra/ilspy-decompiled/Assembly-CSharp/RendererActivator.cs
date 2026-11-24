using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class RendererActivator : MonoBehaviour
{
	public void Awake()
	{
		//IL_001e: Expected Obj, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)3);
		object obj = this + 16;
		obj = list;
		CancelInvoke();
	}

	public unsafe void OnActivate()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		TrackObject component = GetComponent<TrackObject>();
		bool flag = (object)component == null;
		bool flag2 = !flag;
		TrackObject trackObject = component;
		if (!flag2)
		{
			string text = tag;
			TrackObject trackObject2 = ((GameObject)(object)text).AddComponent<TrackObject>();
			trackObject = trackObject2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(RendererActivator.OnActivate);
		object obj = action + 16;
		obj = this;
		trackObject.OnActivate -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(RendererActivator.OnDeactivate);
		object obj2 = action2 + 16;
		obj2 = this;
		trackObject.OnDeactivate -= action2;
		Renderer component2 = GetComponent<Renderer>();
		component2.shadowCastingMode = ShadowCastingMode.Off;
	}

	public void OnDeactivate()
	{
		Renderer component = GetComponent<Renderer>();
		component.shadowCastingMode = ShadowCastingMode.On;
	}

	public RendererActivator()
	{
		Renderer component = GetComponent<Renderer>();
		component.shadowCastingMode = ShadowCastingMode.Off;
	}
}
