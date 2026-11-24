using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Placeholders;

public class SynchronizedThemeAsset : MonoBehaviour
{
	private List<Component> _themedComponents;

	public bool _canSynchronize;

	public List<Component> ThemedComponents
	{
		get
		{
			//IL_0098: Expected I, but got Obj
			//IL_00ae: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_007b: Expected Obj, but got I4
			nint num = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_themedComponents).FindKernel((string)null) != 0)
			{
				int siblingIndex = ((Transform)(object)_themedComponents).GetSiblingIndex();
				bool flag = siblingIndex != 0;
				return (List<Component>)flag;
			}
			return null;
		}
	}

	public bool CanSynchronize
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_themedComponents != 0;
		}
		set
		{
			//IL_0015: Expected Obj, but got I
			((Placeholder)this).OnValidate();
			List<Component> themedComponents = ThemedComponents;
			if (themedComponents == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+14]");
				List<Transform> list = (List<Transform>)0;
				int num = 0;
				while (num < list._size)
				{
					Transform transform = list.get_Item(num);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					int num2 = num + 1;
					num = num2;
				}
			}
		}
	}

	public SynchronizedThemeAsset()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<TrackObject> list = default;
		list._002Ector();
		object obj = this + 20;
		obj = list;
		CancelInvoke();
	}
}
