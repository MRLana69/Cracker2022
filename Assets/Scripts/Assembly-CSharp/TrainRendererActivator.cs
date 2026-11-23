using System;
using Cpp2ILInjected;
using UnityEngine;

public class TrainRendererActivator : MonoBehaviour
{
	private Renderer[] renderers;

	public unsafe void Awake()
	{
		TrackObject component = GetComponent<TrackObject>();
		bool flag = (object)component == null;
		bool flag2 = !flag;
		TrackObject trackObject = component;
		if (!flag2)
		{
			GameObject gameObject = base.gameObject;
			TrackObject trackObject2 = gameObject.AddComponent<TrackObject>();
			trackObject = trackObject2;
		}
		Action action = default;
		action._002Ector(this, (nint)__ldftn(TrainRendererActivator.OnActivate));
		trackObject.OnActivate += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(TrainRendererActivator.OnDeactivate));
		trackObject.OnDeactivate += action2;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		Renderer[] array = default;
		renderers = array;
		OnDeactivate();
	}

	public void OnActivate()
	{
		//IL_009e: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I
		Renderer[] array = renderers;
		object obj = 0;
		while (array.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v13+10]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v13+10]");
				((Renderer)0).enabled = true;
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
	}

	public void OnDeactivate()
	{
		//IL_009e: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I
		Renderer[] array = renderers;
		object obj = 0;
		while (array.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v13+10]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v13+10]");
				((Renderer)0).enabled = false;
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
	}
}
