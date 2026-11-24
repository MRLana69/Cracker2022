using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class TrainRendererActivator : MonoBehaviour
{
	private Renderer[] renderers;

	public void Awake()
	{
		CancelInvoke();
	}

	public unsafe void OnActivate()
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0091: Expected Obj, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
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
		((Delegate)action).method = (nint)__ldftn(TrainRendererActivator.OnActivate);
		object obj = action + 16;
		obj = this;
		trackObject.OnActivate -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(TrainRendererActivator.OnDeactivate);
		object obj2 = action2 + 16;
		obj2 = this;
		trackObject.OnDeactivate -= action2;
		object obj3 = this + 12;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S3_v2 (Il2CppMethodInfo)+18]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v80 @ S4_v4 (should have been resolved before IL gen)");
		object obj8 = default;
		obj3 = obj8;
		this._002Ector();
	}

	public void OnDeactivate()
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		object obj = renderers + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = renderers + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj5).FindKernel((string)null) != 0)
			{
				((Renderer)obj5).shadowCastingMode = ShadowCastingMode.On;
			}
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
	}

	public TrainRendererActivator()
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		object obj = renderers + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = renderers + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj5).FindKernel((string)null) != 0)
			{
				((Renderer)obj5).shadowCastingMode = ShadowCastingMode.Off;
			}
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
	}
}
