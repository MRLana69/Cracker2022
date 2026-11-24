namespace UnityEngine;

public sealed class AndroidJavaException : Exception
{
	private string mJavaStackTrace; //Field offset: 0x44

	public override string StackTrace
	{
		 get { } //Length: 242
	}

	internal AndroidJavaException(string message, string javaStackTrace) { }

	public override string get_StackTrace() { }

}

