using System;
using System.IO;
using Cpp2ILInjected;
using UnityEngine;

public class CaptureScreenshot : AScreenCapture
{
	public CaptureScreenshot(string captureFolder, string fileName, int width, int height, Camera camera)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_0110: Expected I4, but got Obj
		object obj = this + 8;
		obj = "";
		object obj2 = this + 8;
		obj2 = captureFolder;
		DirectoryInfo directoryInfo = Directory.CreateDirectoriesInternal(base._captureFolder);
		base._width = (int)fileName;
		base._height = width;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public CaptureScreenshot(string captureFolder, string fileName, int width, int height, Camera[] camera)
		: this(captureFolder, (string)width, height, (int)camera, (Camera)8)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_001b: Expected I4, but got Obj
		//IL_001b: Expected Obj, but got I4
		Screenshot((Camera)(object)fileName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}
}
