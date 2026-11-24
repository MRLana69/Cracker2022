using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Components;

public class DeselectMeComponent : MonoBehaviour
{
	private Transform _redirectTarget;

	private DeselectMeMode _deselectMeMode;

	public Transform RedirectTarget => _redirectTarget;

	public DeselectMeMode DeselectMeMode
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (DeselectMeMode)_redirectTarget;
		}
		set
		{
			//IL_000e: Expected Obj, but got I4
			object obj = value + 32;
			DeselectMeComponent deselectMeComponent = (DeselectMeComponent)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}
}
