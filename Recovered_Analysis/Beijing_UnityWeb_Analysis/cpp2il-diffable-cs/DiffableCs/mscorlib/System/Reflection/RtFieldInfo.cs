namespace System.Reflection;

internal abstract class RtFieldInfo : RuntimeFieldInfo
{

	protected RtFieldInfo() { }

	internal void CheckConsistency(object target) { }

	public override void SetValueDirect(TypedReference obj, object value) { }

	internal object UnsafeGetValue(object obj) { }

	internal void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

