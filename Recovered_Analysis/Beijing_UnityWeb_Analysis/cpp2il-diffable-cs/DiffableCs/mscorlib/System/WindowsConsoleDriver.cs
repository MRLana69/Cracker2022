namespace System;

internal class WindowsConsoleDriver : IConsoleDriver
{
	private nint inputHandle; //Field offset: 0x8
	private nint outputHandle; //Field offset: 0xC
	private short defaultAttribute; //Field offset: 0x10

	public WindowsConsoleDriver() { }

	private static bool GetConsoleScreenBufferInfo(nint handle, out ConsoleScreenBufferInfo info) { }

	private static nint GetStdHandle(Handles handle) { }

	private static bool IsModifierKey(short virtualKeyCode) { }

	private static bool ReadConsoleInput(nint handle, out InputRecord record, int length, out int nread) { }

	public ConsoleKeyInfo ReadKey(bool intercept) { }

}

