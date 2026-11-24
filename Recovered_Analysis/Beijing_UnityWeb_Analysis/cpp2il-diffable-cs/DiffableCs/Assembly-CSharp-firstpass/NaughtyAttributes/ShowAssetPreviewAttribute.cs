namespace NaughtyAttributes;

public class ShowAssetPreviewAttribute : DrawerAttribute
{
	private int width; //Field offset: 0x8
	private int height; //Field offset: 0xC

	public int Height
	{
		 get { } //Length: 6
	}

	public int Width
	{
		 get { } //Length: 6
	}

	public ShowAssetPreviewAttribute(int width = 64, int height = 64) { }

	public int get_Height() { }

	public int get_Width() { }

}

