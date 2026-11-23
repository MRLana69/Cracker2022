using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public struct fsOption<T>
{
	private bool _hasValue;

	private T _value;

	public static fsOption<T> Empty;

	public unsafe bool HasValue => (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != 0;

	public unsafe bool IsEmpty => System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) == null;

	public unsafe T Value
	{
		get
		{
			//IL_007d: Expected VT, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				InvalidOperationException ex = default;
				ex._002Ector("fsOption is empty");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14 (System.InvalidOperationException)+4]");
			return (T)0;
		}
	}

	public fsOption(T value)
	{
		//IL_000e: Expected VT, but got I4
		fsOption<T> fsOption2 = (fsOption<T>)1;
	}
}
public static class fsOption
{
	public static fsOption<T> Just<T>(T value)
	{
		//IL_0009: Expected VT, but got I4
		//IL_0017: Expected VT, but got I4
		fsOption<T> fsOption2 = (fsOption<T>)0;
		return (fsOption<T>)1;
	}
}
