//Type is in global namespace

public abstract class AScreenCapture
{
	private string _captureFolder; //Field offset: 0x8
	private int _width; //Field offset: 0xC
	private int _height; //Field offset: 0x10
	private Camera[] _camera; //Field offset: 0x14
	private RenderTexture _renderTexture; //Field offset: 0x18
	private Texture2D _screenshotTexture; //Field offset: 0x1C

	public AScreenCapture(string captureFolder, int width, int height, Camera[] camera, int antiAliasing = 8) { }

	public AScreenCapture(string captureFolder, int width, int height, Camera camera, int antiAliasing = 8) { }

	public virtual void Cleanup() { }

	protected void SaveScreenshot(string name) { }

	private void Screenshot(Camera camera) { }

}

