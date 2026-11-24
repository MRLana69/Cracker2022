using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Common.Visuals;
using UnityEngine;

namespace SYBO.Common;

public class ScriptBehaviour : MonoBehaviour
{
	public ScriptBehaviour()
	{
		//IL_0016: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.ScriptBehaviour)+10]");
		IEnumerator enumerator = ((Animation)0).GetEnumerator();
		((MeshCombiner)this).Combine((GameObject)(object)"Play", (IList<ObjectModelInfo>)null);
	}
}
