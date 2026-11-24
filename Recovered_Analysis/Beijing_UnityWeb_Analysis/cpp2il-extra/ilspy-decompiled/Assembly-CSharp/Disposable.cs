using System;
using Cpp2ILInjected;
using UnityEngine;

public class Disposable<T> where T : UnityEngine.Object
{
	public T ReferencedObject
	{
		get
		{
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected Obj, but got Unknown
			//IL_0108: Expected Obj, but got I4
			//IL_0111: Expected Obj, but got I4
			//IL_0028: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 4;
			obj = 0;
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			if (obj == null)
			{
				obj = field;
				if ((object)field == null)
				{
					object obj3 = 0;
					goto IL_003c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			goto IL_003c;
			IL_003c:
			throw new ArrayTypeMismatchException();
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
	}

	public Disposable(T obj)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj2 = this + 8;
		obj2 = obj;
	}
}
