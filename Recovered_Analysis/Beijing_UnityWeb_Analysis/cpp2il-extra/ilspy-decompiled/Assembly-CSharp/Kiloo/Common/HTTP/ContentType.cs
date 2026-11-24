using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.LocalizationManager;
using UnityEngine;

namespace Kiloo.Common.HTTP;

public class ContentType
{
	public readonly string type;

	public readonly string subType;

	private readonly IDictionary<string, string> _parameters;

	public IEnumerable<KeyValuePair<string, string>> parameters
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			return (IEnumerable<KeyValuePair<string, string>>)(object)(subType + 16);
		}
	}

	public ContentType(string type, string subType, IDictionary<string, string> parameters)
	{
		GUILayout.BeginVertical((GUIContent)(object)type, subType, (GUILayoutOption[])(object)parameters);
	}

	public string GetParameter(string name)
	{
		//IL_001d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		Locale locale = default;
		return (string)((Locale)(object)this != locale);
	}
}
