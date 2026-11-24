using Kiloo.Analytics;

namespace Kiloo.Common.Utility;

public static class GUIUtil
{
	public static float ScaleGUI()
	{
		float userSampleValue = Manager.userSampleValue;
		return userSampleValue * 100f;
	}
}
