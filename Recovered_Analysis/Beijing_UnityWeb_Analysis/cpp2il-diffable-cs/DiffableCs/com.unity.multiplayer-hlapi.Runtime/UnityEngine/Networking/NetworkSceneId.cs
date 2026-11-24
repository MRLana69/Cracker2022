namespace UnityEngine.Networking;

public struct NetworkSceneId : IEquatable<NetworkSceneId>
{
	private uint m_Value; //Field offset: 0x0

	public uint Value
	{
		 get { } //Length: 12
	}

	public NetworkSceneId(uint value) { }

	public override bool Equals(object obj) { }

	public bool Equals(NetworkSceneId other) { }

	public uint get_Value() { }

	public override int GetHashCode() { }

	public bool IsEmpty() { }

	public static bool op_Equality(NetworkSceneId c1, NetworkSceneId c2) { }

	public static bool op_Inequality(NetworkSceneId c1, NetworkSceneId c2) { }

	public override string ToString() { }

}

