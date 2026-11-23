using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Networking;

namespace Proyecto26.Common;

public static class Extensions
{
	public static ResponseHelper CreateWebResponse(UnityWebRequest request)
	{
		ResponseHelper responseHelper = default;
		responseHelper.Request__BackingField = request;
		return responseHelper;
	}

	public static bool IsValidRequest(UnityWebRequest request, RequestHelper options)
	{
		bool isDone = request.isDone;
		bool flag = !isDone;
		bool result = false;
		if (!flag)
		{
			bool isNetworkError = request.isNetworkError;
			result = false;
			if (!isNetworkError)
			{
				bool isHttpError = request.isHttpError;
				bool flag2 = !isHttpError;
				result = true;
				if (!flag2)
				{
					result = options._ignoreHttpException;
				}
			}
		}
		return result;
	}

	public static string EscapeURL(string queryParam)
	{
		return UnityWebRequest.EscapeURL(queryParam);
	}

	public static string BuildUrl(string uri, Dictionary<string, string> queryParams)
	{
		Dictionary<string, string> defaultRequestParams = RestClient.DefaultRequestParams;
		if (Enumerable.Any(defaultRequestParams) || Enumerable.Any(queryParams))
		{
			Dictionary<string, string>.KeyCollection keys = queryParams.Keys;
			string text = default;
			bool flag = text.Contains("?");
			object obj = "&";
			if (!flag)
			{
				obj = "?";
			}
			throw new ArgumentException();
		}
		string result = default;
		return result;
	}
}
