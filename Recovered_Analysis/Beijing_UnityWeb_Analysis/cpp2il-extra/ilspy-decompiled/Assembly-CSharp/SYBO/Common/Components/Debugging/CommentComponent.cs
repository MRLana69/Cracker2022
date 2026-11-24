using System;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;

namespace SYBO.Common.Components.Debugging;

public class CommentComponent : MonoBehaviour
{
	public string Comment;

	private bool _isCommentEditableInInspector = true;

	public bool IsCommentEditableInInspector
	{
		get
		{
			//IL_0176: Expected I, but got Obj
			//IL_018c: Expected Obj, but got I
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0202: Expected Obj, but got Unknown
			//IL_020e: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Expected Obj, but got Unknown
			//IL_01bf: Expected Obj, but got I4
			//IL_01dc: Expected Obj, but got I
			//IL_00f2: Expected VT, but got I4
			//IL_00f2: Expected Obj, but got I4
			//IL_00f2: Expected Obj, but got I4
			//IL_0103: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			Transform transform = (Transform)(obj2 + 12);
			if (((ComputeShader)_isCommentEditableInInspector).FindKernel(null) != 0)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj4 = this + 36;
				GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)_isCommentEditableInInspector);
				obj4 = gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Components.Debugging.CommentComponent)+24]");
				int layer = ((GameObject)0).layer;
				int layer2 = ((GameObject)(object)Comment).layer;
				HierarchyUtility.Reparent((Transform)layer, (Transform)layer2, (Vector3)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Components.Debugging.CommentComponent)+24]");
				int layer3 = ((GameObject)0).layer;
				object obj5 = this + 20;
				obj2 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S2_v10+8]");
				_ = 0;
				transform = (Transform)obj2;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles = transform.eulerAngles;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Components.Debugging.CommentComponent)+24]");
			return false;
		}
		set
		{
			//IL_0054: Expected Obj, but got I4
			if (_isCommentEditableInInspector == value)
			{
				string text = tag;
				bool flag = Comment != null;
				((GameObject)(object)text).tag = (string)flag;
			}
		}
	}

	protected void Reset()
	{
		CancelInvoke();
	}
}
