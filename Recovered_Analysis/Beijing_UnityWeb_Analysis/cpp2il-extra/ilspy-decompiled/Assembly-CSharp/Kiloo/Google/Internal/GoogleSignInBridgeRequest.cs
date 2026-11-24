using Cpp2ILInjected;

namespace Kiloo.Google.Internal;

public class GoogleSignInBridgeRequest<T>
{
	public bool done;

	public bool canceled;

	public T result;

	public GoogleSignInBridgeRequest()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected I, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		nint num = (nint)(obj2 + 16);
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		bool flag = done;
		bool flag2;
		if (~(done ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (System.Boolean)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj5 = default;
			object obj4 = obj5;
			object obj7 = default;
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj8 = default;
			if (obj6 == obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj10 = default;
				object obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj12 = default;
				object obj11 = obj12;
			}
			else
			{
				object obj11 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}
}
