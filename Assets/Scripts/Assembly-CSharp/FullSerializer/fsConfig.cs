using System;
using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;

namespace FullSerializer;

public class fsConfig
{
	public Type[] SerializeAttributes;

	public Type[] IgnoreSerializeAttributes;

	public Type[] IgnoreSerializeTypeAttributes;

	public fsMemberSerialization DefaultMemberSerialization;

	public Func<string, MemberInfo, string> GetJsonNameFromMemberName;

	public bool EnablePropertySerialization;

	public bool SerializeNonAutoProperties;

	public bool SerializeNonPublicSetProperties;

	public string CustomDateTimeFormatString;

	public bool Serialize64BitIntegerAsString;

	public bool SerializeEnumsAsInteger;

	public fsConfig()
	{
		//IL_018b: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SerializeField));
		throw new ArrayTypeMismatchException();
	}
}
