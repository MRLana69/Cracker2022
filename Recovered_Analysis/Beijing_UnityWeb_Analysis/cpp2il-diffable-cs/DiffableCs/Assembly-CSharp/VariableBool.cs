//Type is in global namespace

public class VariableBool
{
	public delegate OnChangeDelegate
	{

		public OnChangeDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(bool value, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(bool value) { }

	}

	private bool value; //Field offset: 0x8
	public OnChangeDelegate OnChange; //Field offset: 0xC
	private HashSet<object> objects; //Field offset: 0x10

	public bool Value
	{
		 get { } //Length: 9
	}

	public VariableBool() { }

	public void Add(object o) { }

	public void Clear() { }

	public void FireOnChange() { }

	public bool get_Value() { }

	private void NotifyOnChange() { }

	public void Remove(object o) { }

	private void UpdateValue() { }

}

