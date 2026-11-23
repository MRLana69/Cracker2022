using UnityEngine;

public class InGameCaptureWrapper : MonoBehaviour
{
	private int _width;

	private int _height;

	public int Width
	{
		get
		{
			return _width;
		}
		set
		{
			_width = value;
		}
	}

	public int Height
	{
		get
		{
			return _height;
		}
		set
		{
			_height = value;
		}
	}
}
