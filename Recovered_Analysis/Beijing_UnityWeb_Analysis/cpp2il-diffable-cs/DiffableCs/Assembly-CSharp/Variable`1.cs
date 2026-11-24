//Type is in global namespace

public class Variable`1
{
	public delegate OnChangeDelegate
	{

		public OnChangeDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(T value, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(T value) { }

	}

	private T value; //Field offset: 0x0
	public OnChangeDelegate<T> OnChange; //Field offset: 0x0

	public T Value
	{
		 get { } //Length: 12
		 set { } //Length: 197
	}

	public Variable`1(T initialValue) { }

	public void FireOnChange() { }

	public T get_Value() { }

	private void NotifyOnChange() { }

	public void set_Value(T value) { }

}

