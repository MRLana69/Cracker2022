using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace SYBO.Components.Utilities.Examples;

public class PreloadExample : MonoBehaviour
{
	public Text text;

	private void Start()
	{
		CancelInvoke();
	}

	private void Progress(float progress)
	{
	}

	public void StartBalancing()
	{
		this._002Ector();
	}

	public PreloadExample()
	{
		//IL_006f: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_009b: Expected I, but got Obj
		//IL_00b1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		PooledInstanceData pooledInstanceData = default;
		pooledInstanceData.node__BackingField = (LinkedListNode<PooledInstanceData>)num;
		pooledInstanceData.transform__BackingField = (Transform)0;
		object obj = pooledInstanceData + 16;
		obj = this;
		nint num2 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v20 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.RegisterInstance(pooledInstanceData);
	}
}
