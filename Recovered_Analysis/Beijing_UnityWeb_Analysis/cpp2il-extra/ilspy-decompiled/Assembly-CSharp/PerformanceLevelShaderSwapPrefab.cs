using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

public class PerformanceLevelShaderSwapPrefab : MonoBehaviour, IPrefabBehaviour
{
	private Renderer _renderer;

	private Shader _swapShader;

	private DeviceInfo.PerformanceLevel _minPerformanceLevelForSwap;

	public void Initialize()
	{
		//IL_000b: Expected Obj, but got I4
		_renderer = (Renderer)1;
		CancelInvoke();
	}

	public PerformanceLevelShaderSwapPrefab()
	{
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_renderer).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v10 (Il2CppClass<DeviceInfo>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num4 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v45 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v15 (System.Int32)+8]");
		if ((nint)0 <= (nint)_minPerformanceLevelForSwap)
		{
			Shader shader = Shader.Find((string)(object)_renderer);
			object obj2 = shader + 12;
			object obj3 = 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				object contents = (object)(shader + 16) + (object)(obj3 << 2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Material material = default;
				material._002Ector((string)contents);
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
		}
	}
}
