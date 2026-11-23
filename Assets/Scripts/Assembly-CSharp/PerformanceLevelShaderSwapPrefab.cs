using System;
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
		//IL_007a: Expected Obj, but got I
		if (!(_renderer != null))
		{
			return;
		}
		DeviceInfo instance = DeviceInfo.Instance;
		if (instance.performanceLevel <= _minPerformanceLevelForSwap)
		{
			Material[] sharedMaterials = _renderer.sharedMaterials;
			object obj = default;
			if (sharedMaterials.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)sharedMaterials + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v29+10]");
				Material material = default;
				material._002Ector((Material)0);
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
		}
	}
}
