public class ProviderSettings
{
	private string _id;

	private int _weight;

	private int _priority;

	public string id => _id;

	public int weight => _weight;

	public int priority => _priority;

	public ProviderSettings(string id, int priority, int weight)
	{
		_id = id;
		_priority = priority;
		_weight = weight;
	}
}
