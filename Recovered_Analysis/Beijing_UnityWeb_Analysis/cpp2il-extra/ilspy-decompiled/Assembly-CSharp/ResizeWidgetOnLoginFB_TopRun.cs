using Cpp2ILInjected;
using UnityEngine;

public class ResizeWidgetOnLoginFB_TopRun : MonoBehaviour
{
	public UIWidget emptyWidget;

	public unsafe void SetEmptyWidgetSize(int width, int height)
	{
		//IL_0022: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		int depth = ((RenderTexture)height).depth;
		((RenderTexture)((int*)width)->m_value).isPowerOfTwo = (byte)depth != 0;
		float maxColorComponent = ((Color*)height)->maxColorComponent;
		PlayerPrefs.SetFloat((string)((int*)width)->m_value, maxColorComponent);
		FilterMode filterMode = ((Texture)height).filterMode;
		((Texture)((int*)width)->m_value).filterMode = filterMode;
		int anisoLevel = ((Texture)height).anisoLevel;
		((Texture)((int*)width)->m_value).anisoLevel = anisoLevel;
		TextureFormat format = ((Texture2D)height).format;
		Vector2 texelSize = ((Texture)format).texelSize;
		int volumeDepth = ((RenderTexture)height).volumeDepth;
		((RenderTexture)((int*)width)->m_value).volumeDepth = volumeDepth;
		int antiAliasing = ((RenderTexture)height).antiAliasing;
		((RenderTexture)((int*)width)->m_value).antiAliasing = antiAliasing;
	}

	public ResizeWidgetOnLoginFB_TopRun()
	{
		CancelInvoke();
	}
}
