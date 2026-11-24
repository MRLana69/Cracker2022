namespace System.IO;

internal abstract class SearchResultHandler`1
{

	protected SearchResultHandler`1() { }

	internal abstract TSource CreateObject(SearchResult result) { }

	internal abstract bool IsResultIncluded(SearchResult result) { }

}

