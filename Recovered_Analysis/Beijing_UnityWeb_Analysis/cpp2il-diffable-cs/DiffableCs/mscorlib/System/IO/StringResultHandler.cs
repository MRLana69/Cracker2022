namespace System.IO;

internal class StringResultHandler
{
	private bool _includeFiles; //Field offset: 0x8
	private bool _includeDirs; //Field offset: 0x9

	internal StringResultHandler(bool includeFiles, bool includeDirs) { }

	internal override string CreateObject(SearchResult result) { }

	internal override bool IsResultIncluded(SearchResult result) { }

}

