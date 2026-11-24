namespace System;

internal class TermInfoReader
{
	private short boolSize; //Field offset: 0x8
	private short numSize; //Field offset: 0xA
	private short strOffsets; //Field offset: 0xC
	private byte[] buffer; //Field offset: 0x10
	private int booleansOffset; //Field offset: 0x14

	public TermInfoReader(string term, string filename) { }

	public TermInfoReader(string term, byte[] buffer) { }

	public int Get(TermInfoNumbers number) { }

	public string Get(TermInfoStrings tstr) { }

	private short GetInt16(byte[] buffer, int offset) { }

	private string GetString(byte[] buffer, int offset) { }

	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	private byte[] GetStringBytes(byte[] buffer, int offset) { }

	private void ReadHeader(byte[] buffer, ref int position) { }

	private void ReadNames(byte[] buffer, ref int position) { }

}

