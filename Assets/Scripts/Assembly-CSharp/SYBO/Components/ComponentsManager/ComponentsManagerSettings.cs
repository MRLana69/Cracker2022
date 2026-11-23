using System;
using Cpp2ILInjected;

namespace SYBO.Components.ComponentsManager;

public class ComponentsManagerSettings
{
	public string[] _componentZipPath;

	public string[] _gitlabDownloadURIFormat;

	public string[] _gitlabDownloadComponentTreeURIFormat;

	public ComponentsManagerSettings()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
