namespace Kiloo.Common.Backend.Cloud;

public static class CloudUserDataExtensions
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair<string, string>, string> <>9__0_0; //Field offset: 0x4
		public static Func<KeyValuePair<string, string>, string> <>9__0_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ToDictionary>b__0_0(KeyValuePair<string, string> pair) { }

		internal string <ToDictionary>b__0_1(KeyValuePair<string, string> pair) { }

	}


	public static Dictionary<string, string> ToDictionary(ICloudUserData userData) { }

	public static ICloudUserData ToUserData(IDictionary<string, string> dict) { }

}

