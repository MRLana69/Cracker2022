namespace UnityEngine.Bindings;

internal class NativeTypeAttribute : Attribute
{
	private string <Header>k__BackingField; //Field offset: 0x8
	private string <IntermediateScriptingStructName>k__BackingField; //Field offset: 0xC
	private CodegenOptions <CodegenOptions>k__BackingField; //Field offset: 0x10

	public CodegenOptions CodegenOptions
	{
		 set { } //Length: 11
	}

	public string Header
	{
		 set { } //Length: 174
	}

	public string IntermediateScriptingStructName
	{
		 set { } //Length: 11
	}

	public NativeTypeAttribute() { }

	public NativeTypeAttribute(CodegenOptions codegenOptions) { }

	public NativeTypeAttribute(string header) { }

	public NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName) { }

	public void set_CodegenOptions(CodegenOptions value) { }

	public void set_Header(string value) { }

	public void set_IntermediateScriptingStructName(string value) { }

}

