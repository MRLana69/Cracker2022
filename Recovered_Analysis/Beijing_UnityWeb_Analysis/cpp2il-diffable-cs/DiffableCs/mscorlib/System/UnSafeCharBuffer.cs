namespace System;

internal struct UnSafeCharBuffer
{
	private char* m_buffer; //Field offset: 0x0
	private int m_totalSize; //Field offset: 0x4
	private int m_length; //Field offset: 0x8

	public UnSafeCharBuffer(char* buffer, int bufferSize) { }

	public void AppendString(string stringToAppend) { }

}

