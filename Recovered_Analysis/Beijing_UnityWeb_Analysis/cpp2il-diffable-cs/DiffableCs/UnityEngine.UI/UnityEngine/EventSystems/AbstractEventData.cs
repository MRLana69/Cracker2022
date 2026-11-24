namespace UnityEngine.EventSystems;

public abstract class AbstractEventData
{
	protected bool m_Used; //Field offset: 0x8

	public virtual bool used
	{
		 get { } //Length: 6
	}

	protected AbstractEventData() { }

	public virtual bool get_used() { }

	public virtual void Reset() { }

	public virtual void Use() { }

}

