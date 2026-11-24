namespace UnityEngine;

public sealed class QualitySettings : Object
{

	public static ColorSpace activeColorSpace
	{
		 get { } //Length: 47
	}

	public static string[] names
	{
		 get { } //Length: 47
	}

	public static int pixelLightCount
	{
		 get { } //Length: 47
		 set { } //Length: 51
	}

	public static ColorSpace get_activeColorSpace() { }

	public static string[] get_names() { }

	public static int get_pixelLightCount() { }

	public static int GetQualityLevel() { }

	public static void set_pixelLightCount(int value) { }

	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

}

