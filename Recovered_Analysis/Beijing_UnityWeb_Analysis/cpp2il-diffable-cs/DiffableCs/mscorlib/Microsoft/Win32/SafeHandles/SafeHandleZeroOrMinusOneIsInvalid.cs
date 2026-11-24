namespace Microsoft.Win32.SafeHandles;

public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
{

	public override bool IsInvalid
	{
		 get { } //Length: 36
	}

	protected SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle) { }

	public override bool get_IsInvalid() { }

}

