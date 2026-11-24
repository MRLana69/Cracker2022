namespace Kiloo.Common.HTTP;

public enum RequestDumpOption
{
	Status = 1,
	RequestHeaders = 2,
	RequestBody = 4,
	ResponseHeaders = 8,
	ResponseBody = 16,
	AllRequest = 6,
	AllResponse = 24,
	All = 31
}
