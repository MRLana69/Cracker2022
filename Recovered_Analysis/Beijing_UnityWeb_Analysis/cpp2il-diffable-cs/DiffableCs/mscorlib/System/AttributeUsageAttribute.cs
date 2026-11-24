namespace System;

public sealed class AttributeUsageAttribute : Attribute
{
	internal static AttributeUsageAttribute Default; //Field offset: 0x0
	internal AttributeTargets m_attributeTarget; //Field offset: 0x8
	internal bool m_allowMultiple; //Field offset: 0xC
	internal bool m_inherited; //Field offset: 0xD

	public bool AllowMultiple
	{
		 get { } //Length: 166
		 set { } //Length: 24
	}

	public bool Inherited
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	private static AttributeUsageAttribute() { }

	public AttributeUsageAttribute(AttributeTargets validOn) { }

	public bool get_AllowMultiple() { }

	public bool get_Inherited() { }

	public void set_AllowMultiple(bool value) { }

	public void set_Inherited(bool value) { }

}

