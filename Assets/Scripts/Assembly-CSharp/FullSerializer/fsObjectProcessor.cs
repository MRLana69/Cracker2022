using System;
using Cpp2ILInjected;

namespace FullSerializer;

public abstract class fsObjectProcessor
{
	public virtual bool CanProcess(Type type)
	{
		//IL_0037: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte)(int)ex != 0;
	}

	public virtual void OnBeforeSerialize(Type storageType, object instance)
	{
	}

	public virtual void OnAfterSerialize(Type storageType, object instance, ref fsData data)
	{
	}

	public virtual void OnBeforeDeserialize(Type storageType, ref fsData data)
	{
	}

	public virtual void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
	{
	}

	public virtual void OnAfterDeserialize(Type storageType, object instance)
	{
	}
}
