using System.IO;
using Cpp2ILInjected;
using UnityEngine;

public abstract class AScreenCapture
{
	private string _captureFolder;

	private int _width;

	private int _height;

	private Camera _camera;

	private RenderTexture _renderTexture;

	private Texture2D _screenshotTexture;

	public AScreenCapture(string captureFolder, int width, int height, Camera camera, int antiAliasing = 8)
	{
		//IL_0030: Expected I, but got Obj
		//IL_004c: Expected I, but got Obj
		_captureFolder = string.Empty;
		_captureFolder = captureFolder;
		DirectoryInfo directoryInfo = Directory.CreateDirectory(_captureFolder);
		_camera = camera;
		_height = height;
		_width = width;
		RenderTexture renderTexture = default;
		renderTexture._002Ector(_width, _height, 32);
		_renderTexture = renderTexture;
		_renderTexture.antiAliasing = antiAliasing;
		nint num = (nint)_renderTexture;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ S1_v15 (Il2CppClass<UnityEngine.RenderTexture>)+DC] (should have been resolved before IL gen)");
		nint num2 = (nint)_renderTexture;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S1_v18 (Il2CppClass<UnityEngine.RenderTexture>)+EC] (should have been resolved before IL gen)");
		Texture2D texture2D = default;
		int width2 = default;
		int height2 = default;
		texture2D._002Ector(width2, height2, TextureFormat.ARGB32, mipChain: false);
		_screenshotTexture = texture2D;
	}

	public virtual void Cleanup()
	{
		Object.Destroy(_renderTexture);
	}

	protected void SaveScreenshot(string name)
	{
		Screenshot();
		byte[] bytes = ImageConversion.EncodeToPNG(_screenshotTexture);
		string path = name + ".png";
		string path2 = Path.Combine(_captureFolder, path);
		File.WriteAllBytes(path2, bytes);
	}

	private unsafe void Screenshot()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005d: Expected I, but got Obj
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0087: Expected I, but got Obj
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00d6: Expected F4, but got I
		//IL_00d1: Expected native int or pointer, but got VT
		//IL_00eb: Expected F4, but got I
		//IL_00e6: Expected native int or pointer, but got VT
		object obj = default;
		Rect rect = (Rect)(obj - 32);
		_camera.targetTexture = _renderTexture;
		_camera.Render();
		_camera.targetTexture = null;
		RenderTexture.active = _renderTexture;
		RenderTexture renderTexture = _renderTexture;
		nint num = (nint)renderTexture;
		object obj2 = renderTexture + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S1_v8 (Il2CppClass<UnityEngine.RenderTexture>)+DC] (should have been resolved before IL gen)");
		RenderTexture renderTexture2 = _renderTexture;
		nint num2 = (nint)renderTexture2;
		object obj3 = renderTexture2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S1_v12 (Il2CppClass<UnityEngine.RenderTexture>)+EC] (should have been resolved before IL gen)");
		_ = 0;
		_ = 0;
		_ = 0f;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
		((Rect*)(nint)rect)->m_Width = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
		((Rect*)(nint)rect)->m_XMin = 0f;
		_screenshotTexture.ReadPixels(rect, 0, 0);
		_screenshotTexture.Apply();
		RenderTexture.active = null;
	}
}
