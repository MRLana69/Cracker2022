using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Common.Visuals;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class OnActivationMeshCombineLauncher : MonoBehaviour
{
	private TrackObject _trackObject;

	private MeshCombiner _meshCombiner;

	private void Awake()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		object obj = this + 16;
		obj = "";
		_ = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Renderer> list = default;
		list._002Ector();
		object obj2 = this + 28;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Material> list2 = default;
		list2._002Ector();
		object obj3 = this + 32;
		obj3 = list2;
		CancelInvoke();
	}

	private unsafe void TrackObject_OnActivate()
	{
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01ba: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected I, but got Unknown
		//IL_0243: Expected I, but got Obj
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0147: Expected I, but got Obj
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		object obj = this + 12;
		TrackObject component = GetComponent<TrackObject>();
		obj = component;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_trackObject).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(OnActivationMeshCombineLauncher.TrackObject_OnActivate);
			object obj3 = action + 16;
			obj3 = this;
			_trackObject.OnActivate -= action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Action action2 = default;
			((Delegate)action2).method_ptr = method_ptr2;
			((Delegate)action2).method = (nint)__ldftn(OnActivationMeshCombineLauncher.TrackObject_OnDeactivate);
			object obj4 = action2 + 16;
			obj4 = this;
			_trackObject.OnDeactivate -= action2;
		}
		nint num3 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v17 (Il2CppClass<System.Type>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v27 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(MeshCombiner);
		nint num5 = (nint)(typeFromHandle + 4);
		((IntPtr*)num5)->m_value = (void*)(nint)typeFromHandle;
		object obj6 = this + 16;
		Type type = Type.internal_from_handle((IntPtr)num5);
		Component component2 = GameObjectUtil.AddComponentIfMissing((GameObject)(object)this, type);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj7 = default;
		obj6 = obj7;
	}

	private void TrackObject_OnDeactivate()
	{
		_meshCombiner.Combine();
	}

	private void OnDestroy()
	{
		_meshCombiner.SortCombineableMeshes();
	}

	public unsafe OnActivationMeshCombineLauncher()
	{
		//IL_00f3: Expected I, but got Obj
		//IL_0109: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_trackObject).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(OnActivationMeshCombineLauncher.TrackObject_OnActivate);
			object obj2 = action + 16;
			obj2 = this;
			_trackObject.OnDeactivate += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			bool flag = default;
			object obj3 = (flag ? 1 : 0) + 16;
			obj3 = this;
			_trackObject.PropagateActivationStateToChildren = flag;
		}
	}
}
