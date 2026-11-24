namespace System.Runtime.Remoting.Contexts;

public interface IContextAttribute
{

	public void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	public bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }

}

