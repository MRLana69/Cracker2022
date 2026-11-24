namespace UnityEngine;

public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
{
	private RuntimeInitializeLoadType m_LoadType; //Field offset: 0x8

	private RuntimeInitializeLoadType loadType
	{
		 set { } //Length: 8
	}

	public RuntimeInitializeOnLoadMethodAttribute() { }

	public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType) { }

	private void set_loadType(RuntimeInitializeLoadType value) { }

}

