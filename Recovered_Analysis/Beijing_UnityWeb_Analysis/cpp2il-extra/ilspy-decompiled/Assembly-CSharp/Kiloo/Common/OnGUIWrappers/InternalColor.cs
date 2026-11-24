using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.OnGUIWrappers;

public class InternalColor : IDisposable
{
	protected Color previousColor
	{
		get
		{
			//IL_0006: Expected VT, but got Obj
			GUILayout.BeginArea((Rect)this);
			Color result = default;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected VT, but got I
			object obj = value + 8;
			InternalColor internalColor = (InternalColor)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			field = (Color)0;
		}
	}

	protected InternalColor()
	{
		GUILayout.EndArea();
	}

	public virtual void Dispose()
	{
	}
}
