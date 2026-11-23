using System;
using Cpp2ILInjected;
using UnityEngine;

public class RenderQueueModifier : MonoBehaviour
{
	public enum RenderType
	{
		FRONT,
		BACK
	}

	public RenderType m_type;

	private Renderer[] _renderers;

	private int _lastQueue;

	private int _renderQueue;

	private void Start()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		Renderer[] renderers = default;
		_renderers = renderers;
	}

	private void LateUpdate()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected I4, but got Unknown
		//IL_0022: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		object obj = -2;
		if (m_type == RenderType.FRONT)
		{
			obj = 2;
		}
		int num = _renderQueue + obj;
		if (num != _lastQueue)
		{
			_lastQueue = num;
			Renderer[] renderers = _renderers;
			object obj2 = 0;
			while ((nint)obj2 < renderers.Length)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)renderers + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v14+10]");
				Material material = ((Renderer)0).material;
				material.renderQueue = _lastQueue;
				object obj5 = obj2 + 1;
				obj2 = obj5;
			}
		}
	}
}
