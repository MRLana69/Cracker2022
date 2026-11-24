using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class RenderQueueModifier : MonoBehaviour
{
	public enum RenderType
	{
		FRONT,
		BACK
	}

	public UIWidget m_target;

	public RenderType m_type;

	private Renderer[] _renderers;

	private int _lastQueue;

	private void Start()
	{
		CancelInvoke();
	}

	private void LateUpdate()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		object obj = this + 20;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+18]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		obj = obj6;
	}

	public RenderQueueModifier()
	{
		//IL_01d9: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_0137: Expected Obj, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected I4, but got Unknown
		//IL_0129: Expected Obj, but got I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_015f: Expected Obj, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (m_target != null)
		{
			return;
		}
		UIWidget target = m_target;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (target.drawCall != null)
		{
			return;
		}
		UIWidget target2 = m_target;
		UIDrawCall drawCall = target2.drawCall;
		object obj3 = ((m_type == RenderType.FRONT) ? ((object)2) : ((object)(-2)));
		int num5 = obj3 + drawCall.mRenderQueue;
		if (_lastQueue != num5)
		{
			_lastQueue = num5;
			object obj4 = _renderers + 12;
			object obj5 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				object obj6 = _renderers + 16;
				object obj7 = obj5 << 2;
				object obj8 = obj6 + obj7;
				Material sharedMaterial = ((Renderer)obj8).sharedMaterial;
				sharedMaterial.EnableKeyword((string)_lastQueue);
				object obj9 = obj5 + 1;
				obj5 = obj9;
			}
		}
	}
}
