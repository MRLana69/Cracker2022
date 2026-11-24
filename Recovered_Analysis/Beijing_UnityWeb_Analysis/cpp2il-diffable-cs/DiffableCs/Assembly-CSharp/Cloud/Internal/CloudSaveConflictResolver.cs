namespace Cloud.Internal;

public class CloudSaveConflictResolver
{
	public enum Recommendation
	{
		None = 0,
		Mine = 1,
		Theirs = 2,
	}

	private ICloudConflict _conflict; //Field offset: 0x8
	private UserData _localData; //Field offset: 0xC
	private UserData _cloudData; //Field offset: 0x10
	private float <recommendationEvaluation>k__BackingField; //Field offset: 0x14

	public DateTime lastModifiedMine
	{
		 get { } //Length: 931
	}

	public DateTime lastModifiedTheirs
	{
		 get { } //Length: 142
	}

	public Recommendation recommendation
	{
		 get { } //Length: 288
	}

	public float recommendationEvaluation
	{
		 get { } //Length: 330
		private set { } //Length: 8
	}

	public CloudConflictResolution resolution
	{
		 get { } //Length: 37
	}

	public string sourceMine
	{
		 get { } //Length: 54
	}

	public string sourceTheirs
	{
		 get { } //Length: 72
	}

	public CloudSaveConflictResolver(ICloudConflict conflict) { }

	private void AttemptAutoResolution() { }

	private void DetermineRecommendation() { }

	private static float Evaluate(float localValue, float cloudValue, float factor) { }

	public DateTime get_lastModifiedMine() { }

	public DateTime get_lastModifiedTheirs() { }

	public Recommendation get_recommendation() { }

	public float get_recommendationEvaluation() { }

	public CloudConflictResolution get_resolution() { }

	public string get_sourceMine() { }

	public string get_sourceTheirs() { }

	public List<CloudSaveComparisonRow> GetComparisonRows() { }

	private static void Log(string logMessage) { }

	public void RefreshLocalUserData() { }

	public void ResolveToMine() { }

	public void ResolveToTheirs() { }

	private void set_recommendationEvaluation(float value) { }

}

