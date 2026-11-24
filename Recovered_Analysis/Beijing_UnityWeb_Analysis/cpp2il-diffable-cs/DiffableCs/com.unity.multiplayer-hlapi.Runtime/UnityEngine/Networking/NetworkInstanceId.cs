namespace UnityEngine.Networking;

public struct NetworkInstanceId : IEquatable<NetworkInstanceId>
{
	public static NetworkInstanceId Invalid; //Field offset: 0x0
	internal static NetworkInstanceId Zero; //Field offset: 0x4
	private readonly uint m_Value; //Field offset: 0x0

	public uint Value
	{
		 get { } //Length: 12
	}

	private static NetworkInstanceId() { }

	public NetworkInstanceId(uint value) { }

	public override bool Equals(object obj) { }

	public bool Equals(NetworkInstanceId other) { }

	public uint get_Value() { }

	public override int GetHashCode() { }

	public bool IsEmpty() { }

	public static bool op_Equality(NetworkInstanceId c1, NetworkInstanceId c2) { }

	public static bool op_Inequality(NetworkInstanceId c1, NetworkInstanceId c2) { }

	public override string ToString() { }

}

