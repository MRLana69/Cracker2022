using Cpp2ILInjected;
using Kiloo.Common.HTTP.Internal;
using UnityEngine;

namespace Kiloo.Common.HTTP;

public static class ResponseExtensions
{
	public static bool IsJSON(IResponse response)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Headers headers = default;
		string text = headers.get_Item("Content-Type");
		if (text.Contains("json"))
		{
			return true;
		}
		return text.Contains("javascript");
	}

	public static bool IsTexture(IResponse response)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Headers headers = default;
		string text = headers.get_Item("Content-Type");
		if (text.Equals("image/jpeg"))
		{
			return true;
		}
		return text.Equals("image/png");
	}

	public static Texture2D AsTexture(IResponse response)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		byte[] array = default;
		Texture2D result;
		if (array != null && array.Length != 0)
		{
			Texture2D texture2D = default;
			texture2D._002Ector(4, 4);
			bool flag = ImageConversion.LoadImage(texture2D, array);
			result = texture2D;
			if (flag)
			{
				goto IL_0094;
			}
		}
		result = null;
		goto IL_0094;
		IL_0094:
		return result;
	}

	public static string AsString(IResponse response)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		byte[] bytes = default;
		Headers headers = default;
		return Util.ContentAsString(bytes, headers);
	}
}
