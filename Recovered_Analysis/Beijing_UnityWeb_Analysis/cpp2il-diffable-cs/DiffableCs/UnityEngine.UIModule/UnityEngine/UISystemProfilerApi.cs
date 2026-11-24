namespace UnityEngine;

public static class UISystemProfilerApi
{
	public enum SampleType
	{
		Layout = 0,
		Render = 1,
	}


	public static void AddMarker(string name, Object obj) { }

	public static void BeginSample(SampleType type) { }

	public static void EndSample(SampleType type) { }

}

