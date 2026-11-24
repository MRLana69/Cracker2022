using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;

namespace Kiloo.Common.Backend;

public static class HTTPExtensions
{
	public static Error GetServiceError(IRequest request, IJsonSerializer jsonSerializer)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Error error = default;
		error.category = null;
		object obj = error + 16;
		obj = request;
		object obj2 = error + 20;
		obj2 = jsonSerializer;
		return error;
	}
}
