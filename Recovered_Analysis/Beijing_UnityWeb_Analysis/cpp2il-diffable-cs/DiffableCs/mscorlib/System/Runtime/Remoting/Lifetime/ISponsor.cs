namespace System.Runtime.Remoting.Lifetime;

public interface ISponsor
{

	public TimeSpan Renewal(ILease lease) { }

}

