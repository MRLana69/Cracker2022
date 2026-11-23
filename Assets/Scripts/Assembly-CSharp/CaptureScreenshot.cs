using Cpp2ILInjected;
using UnityEngine;

public class CaptureScreenshot : AScreenCapture
{
	public CaptureScreenshot(string captureFolder, string fileName, int width, int height, Camera camera)
		: base(captureFolder, width, height, camera)
	{
		//IL_002f: Expected I, but got Obj
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		SaveScreenshot(fileName);
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v4 (Il2CppClass<CaptureScreenshot>)+DC] (should have been resolved before IL gen)");
	}
}
