namespace Kiloo.Common.HTTP;

public interface IResponse
{
	int status { get; }

	string message { get; }

	byte[] bytes { get; }

	Headers headers { get; }

	ResponseCategory category { get; }
}
