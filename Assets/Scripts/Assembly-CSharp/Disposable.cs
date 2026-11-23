using System;
using Cpp2ILInjected;
using UnityEngine;

public class Disposable<T> where T : UnityEngine.Object
{
	public T ReferencedObject
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public Disposable(T obj)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S3_v4 (Il2CppClass<Il2CppRgctx<Disposable`1>>)+4] (should have been resolved before IL gen)");
	}
}
