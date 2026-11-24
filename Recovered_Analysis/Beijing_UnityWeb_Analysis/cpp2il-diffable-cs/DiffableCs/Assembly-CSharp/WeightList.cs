//Type is in global namespace

public class WeightList
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<WeightEntry> <>9__8_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <SyncList>b__8_0(WeightEntry obj) { }

	}

	public class WeightEntry
	{
		public Transform Transform; //Field offset: 0x8
		public Vector2 Weight; //Field offset: 0xC

		public WeightEntry(Transform transform, Vector2 weight) { }

		public WeightEntry(Transform transform) { }

	}

	private List<WeightEntry> _entries; //Field offset: 0x8

	public List<WeightEntry> Entries
	{
		 get { } //Length: 6
	}

	public WeightList() { }

	private void AddWeightEntry(Transform transform) { }

	public List<Vector2> CalculateProportionalWeights() { }

	public List<WeightEntry> get_Entries() { }

	public void SyncList(Transform layout) { }

	private bool WeightEntryExists(Transform transform) { }

	public Vector2 WeightForTransform(Transform transform) { }

}

