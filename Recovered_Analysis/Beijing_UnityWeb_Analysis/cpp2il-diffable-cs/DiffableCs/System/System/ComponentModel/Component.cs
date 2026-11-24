namespace System.ComponentModel;

public class Component : MarshalByRefObject, IComponent, IDisposable
{
	private static readonly object EventDisposed; //Field offset: 0x0
	private ISite site; //Field offset: 0xC
	private EventHandlerList events; //Field offset: 0x10

	protected virtual bool CanRaiseEvents
	{
		 get { } //Length: 12
	}

	internal bool CanRaiseEventsInternal
	{
		 get { } //Length: 3
	}

	protected bool DesignMode
	{
		 get { } //Length: 6
	}

	public virtual ISite Site
	{
		 get { } //Length: 9
	}

	private static Component() { }

	public Component() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	protected virtual bool get_CanRaiseEvents() { }

	internal bool get_CanRaiseEventsInternal() { }

	protected bool get_DesignMode() { }

	public virtual ISite get_Site() { }

	protected virtual object GetService(Type service) { }

	public override string ToString() { }

}

