namespace System.Runtime.Remoting;

public interface IRemotingTypeInfo
{

	public string TypeName
	{
		 get { } //Length: 0
	}

	public bool CanCastTo(Type fromType, object o) { }

	public string get_TypeName() { }

}

