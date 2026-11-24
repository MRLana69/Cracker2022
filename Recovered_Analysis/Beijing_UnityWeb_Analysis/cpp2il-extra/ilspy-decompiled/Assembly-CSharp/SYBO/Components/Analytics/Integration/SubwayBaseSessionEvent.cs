using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace SYBO.Components.Analytics.Integration;

public abstract class SubwayBaseSessionEvent : BaseSessionEvent, ISubwayBaseEvent
{
	public unsafe SubwayBaseSessionEvent()
	{
		//IL_0015: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		//IL_0030: Expected I4, but got Obj
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj = 0;
		CallingConvention callingConvention = (CallingConvention)(obj + 4);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		object obj2 = this + 8;
		obj2 = unmanagedFunctionPointerAttribute;
		_ = 1;
		_sessionID = 10;
		_sessionDelta = 1;
		_sessionEventID = 1;
		object obj3 = this + 36;
		obj3 = "subwaysurf";
		object obj4 = this + 40;
		obj4 = "4.0";
		_ = 60f;
		_ = 1800;
		_ = 512;
		_ = 2048;
	}

	public SubwayBaseSessionEvent(DateTime eventTime, int sessionDelta)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}
}
