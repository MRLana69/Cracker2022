//Type is in global namespace

public class PropertyReference
{
	private static int s_Hash; //Field offset: 0x0
	private Component mTarget; //Field offset: 0x8
	private string mName; //Field offset: 0xC
	private FieldInfo mField; //Field offset: 0x10
	private PropertyInfo mProperty; //Field offset: 0x14

	public bool isEnabled
	{
		 get { } //Length: 112
	}

	public bool isValid
	{
		 get { } //Length: 6
	}

	public string name
	{
		 get { } //Length: 6
		 set { } //Length: 31
	}

	public Component target
	{
		 get { } //Length: 2214
		 set { } //Length: 486
	}

	private static PropertyReference() { }

	public PropertyReference() { }

	public PropertyReference(Component target, string fieldName) { }

	private bool Cache() { }

	public void Clear() { }

	public static bool Convert(object value, Type to) { }

	public static bool Convert(Type from, Type to) { }

	private bool Convert(ref object value) { }

	public static bool Convert(ref object value, Type from, Type to) { }

	public override bool Equals(object obj) { }

	public object Get() { }

	public bool get_isEnabled() { }

	public bool get_isValid() { }

	public string get_name() { }

	public Component get_target() { }

	public override int GetHashCode() { }

	public Type GetPropertyType() { }

	public void Reset() { }

	public bool Set(object value) { }

	public void Set(Component target, string methodName) { }

	public void set_name(string value) { }

	public void set_target(Component value) { }

	public static string ToString(Component comp, string property) { }

	public override string ToString() { }

}

