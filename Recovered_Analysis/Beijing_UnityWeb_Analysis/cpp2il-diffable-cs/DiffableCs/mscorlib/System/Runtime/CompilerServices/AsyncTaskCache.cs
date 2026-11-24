namespace System.Runtime.CompilerServices;

internal static class AsyncTaskCache
{
	internal static readonly Task<bool> TrueTask; //Field offset: 0x0
	internal static readonly Task<bool> FalseTask; //Field offset: 0x4
	internal static readonly Task<int>[] Int32Tasks; //Field offset: 0x8

	private static AsyncTaskCache() { }

	internal static Task<TResult> CreateCacheableTask(TResult result) { }

	private static Task<int>[] CreateInt32Tasks() { }

}

