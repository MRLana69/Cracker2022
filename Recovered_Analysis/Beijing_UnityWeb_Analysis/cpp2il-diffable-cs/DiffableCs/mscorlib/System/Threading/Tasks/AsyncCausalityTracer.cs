namespace System.Threading.Tasks;

internal static class AsyncCausalityTracer
{

	internal static bool LoggingOn
	{
		 get { } //Length: 9
	}

	internal static bool get_LoggingOn() { }

	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	internal static void TraceOperationRelation(CausalityTraceLevel traceLevel, int taskId, CausalityRelation relation) { }

	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

}

