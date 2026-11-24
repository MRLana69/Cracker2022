namespace SYBO.Components.Utilities.Scriptables;

public static class ScriptablesAccessor
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Object, FieldInfo, bool> <>9__2_1; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateFields>b__2_1(Object feature, FieldInfo field) { }

	}

	private sealed class <>c__DisplayClass2_0
	{
		public Type type; //Field offset: 0x8

		public <>c__DisplayClass2_0() { }

		internal bool <UpdateFields>b__0(FieldInfo x) { }

	}

	private sealed class <>c__DisplayClass4_0
	{
		public Func<Object, FieldInfo, bool> comparator; //Field offset: 0x8

		public <>c__DisplayClass4_0() { }

	}

	private sealed class <>c__DisplayClass4_1
	{
		public FieldInfo field; //Field offset: 0x8
		public <>c__DisplayClass4_0 CS$<>8__locals1; //Field offset: 0xC

		public <>c__DisplayClass4_1() { }

		internal bool <PopulateFieldsOfType>b__0(Object x) { }

	}

	public static ScriptablesAccessorEvent OnUpdatedFields; //Field offset: 0x0
	public const BindingFlags PublicStaticFields = 26; //Field offset: 0x0

	private static ScriptablesAccessor() { }

	public static bool CanUpdateFields(Type partialClass) { }

	private static void PopulateFieldOfType(Type type, FieldInfo field, Object asset) { }

	private static void PopulateFieldsOfType(Type type, FieldInfo[] fields, Func<Object, FieldInfo, bool> comparator) { }

	public static void UpdateFields(Type partialClass) { }

}

