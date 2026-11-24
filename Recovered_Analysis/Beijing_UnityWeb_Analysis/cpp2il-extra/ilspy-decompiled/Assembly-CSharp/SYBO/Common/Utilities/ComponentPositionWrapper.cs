using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Utilities;

public struct ComponentPositionWrapper<T> where T : Component
{
	public T Component;

	public Vector3 Position;

	public unsafe ComponentPositionWrapper(T component)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0114: Invalid comparison between VT and I4
		//IL_004b: Expected VT, but got I4
		//IL_004b: Expected VT, but got Ref
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected VT, but got Unknown
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Vector3 vector2 = default;
		Vector3 vector = vector2;
		while (vector >= (object)2)
		{
			int num2 = Math3D.PointOnWhichSideOfLineSegment((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (Vector3)0, vector);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			object obj5 = vector - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			object obj8 = vector - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
			Vector3 vector3 = vector - 1;
			vector = vector3;
		}
	}
}
