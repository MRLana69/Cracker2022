namespace Kiloo.Common.Utility;

public class ObfuscatedMemory
{
	private static readonly byte[] Key; //Field offset: 0x0
	private readonly IDictionary<string, byte[]> _dictionary; //Field offset: 0x8

	private static ObfuscatedMemory() { }

	public ObfuscatedMemory() { }

	public bool GetBoolean(string key) { }

	public byte[] GetBuffer(string key) { }

	public byte GetByte(string key) { }

	public char GetChar(string key) { }

	public DateTime GetDateTime(string key) { }

	public double GetDouble(string key) { }

	public short GetInt16(string key) { }

	public int GetInt32(string key) { }

	public long GetInt64(string key) { }

	public float GetSingle(string key) { }

	public string GetString(string key) { }

	public ushort GetUInt16(string key) { }

	public uint GetUInt32(string key) { }

	public ulong GetUInt64(string key) { }

	public void SetBoolean(string key, bool value) { }

	public void SetBuffer(string key, byte[] value) { }

	public void SetByte(string key, byte value) { }

	public void SetChar(string key, char value) { }

	public void SetDateTime(string key, DateTime value) { }

	public void SetDouble(string key, double value) { }

	public void SetInt16(string key, short value) { }

	public void SetInt32(string key, int value) { }

	public void SetInt64(string key, long value) { }

	public void SetSingle(string key, float value) { }

	public void SetString(string key, string value) { }

	public void SetUInt16(string key, ushort value) { }

	public void SetUInt32(string key, uint value) { }

	public void SetUInt64(string key, ulong value) { }

	public bool TryGetBoolean(string key, out bool result) { }

	public bool TryGetByte(string key, out byte result) { }

	public bool TryGetChar(string key, out char result) { }

	public bool TryGetDateTime(string key, out DateTime result) { }

	public bool TryGetDouble(string key, out double result) { }

	public bool TryGetInt16(string key, out short result) { }

	public bool TryGetInt32(string key, out int result) { }

	public bool TryGetInt64(string key, out long result) { }

	public bool TryGetSingle(string key, out float result) { }

	public bool TryGetString(string key, out string result) { }

	public bool TryGetUInt16(string key, out ushort result) { }

	public bool TryGetUInt32(string key, out uint result) { }

	public bool TryGetUInt64(string key, out ulong result) { }

}

