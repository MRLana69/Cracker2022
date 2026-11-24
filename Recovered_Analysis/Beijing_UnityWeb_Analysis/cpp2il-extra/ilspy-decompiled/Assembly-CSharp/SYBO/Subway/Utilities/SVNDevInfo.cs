using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Utilities;

public class SVNDevInfo : ScriptableObject
{
	public const string SVN_DEV_INFO_OBJECT_NAME = "SVNDevInfo";

	public const string SVN_DEV_INFO_OBJECT_PATH = "Resources/SVNDevInfo.asset";

	public SVNDevInfo()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
