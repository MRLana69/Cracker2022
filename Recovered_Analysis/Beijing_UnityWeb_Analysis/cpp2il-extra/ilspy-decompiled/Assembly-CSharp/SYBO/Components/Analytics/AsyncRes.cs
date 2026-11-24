using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;

namespace SYBO.Components.Analytics;

public class AsyncRes
{
	public bool IsReady;

	public bool ExceptionOccured;

	public int ChunkLength;

	public string UncompressedMD5Hash;

	public object Result;

	public AsyncRes()
	{
		//IL_0029: Expected VT, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AsyncRes)+38]");
		if ((nint)0 == 0)
		{
			_ = 1;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Queue<> queue = default;
			((Queue<T>)(object)queue).Enqueue((T)16);
			object obj = this + 36;
			obj = queue;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ContextCallback contextCallback = default;
			contextCallback(null);
			object obj2 = this + 44;
			obj2 = contextCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj4 = default;
			object obj3 = obj4 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Thread thread = default;
			thread.Start(obj4);
			object obj5 = this + 56;
			obj5 = thread;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.AsyncRes)+38]");
			Thread.SleepInternal(0);
		}
	}
}
