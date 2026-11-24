//Type is in global namespace

public class InGameCaptureWrapper : MonoBehaviour
{
	private int _width; //Field offset: 0xC
	private int _height; //Field offset: 0x10

	public int Height
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int Width
	{
		 get { } //Length: 66
		 set { } //Length: 195
	}

	public InGameCaptureWrapper() { }

	public int get_Height() { }

	public int get_Width() { }

	public void set_Height(int value) { }

	public void set_Width(int value) { }

}

