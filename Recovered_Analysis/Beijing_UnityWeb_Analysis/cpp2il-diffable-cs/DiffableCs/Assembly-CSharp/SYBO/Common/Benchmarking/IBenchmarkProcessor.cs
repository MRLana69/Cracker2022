namespace SYBO.Common.Benchmarking;

public interface IBenchmarkProcessor
{

	public char SeparatorCharacter
	{
		 get { } //Length: 0
	}

	public char get_SeparatorCharacter() { }

	public void Process(IBenchmark benchmark) { }

}

