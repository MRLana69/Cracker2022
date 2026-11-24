namespace System;

public sealed class ConsoleCancelEventArgs : EventArgs
{
	private ConsoleSpecialKey _type; //Field offset: 0x8
	private bool _cancel; //Field offset: 0xC

	public bool Cancel
	{
		 get { } //Length: 168
	}

	internal ConsoleCancelEventArgs(ConsoleSpecialKey type) { }

	internal ConsoleCancelEventArgs() { }

	public bool get_Cancel() { }

}

