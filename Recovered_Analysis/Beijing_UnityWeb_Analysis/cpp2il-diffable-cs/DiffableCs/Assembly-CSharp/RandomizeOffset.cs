//Type is in global namespace

public class RandomizeOffset : MonoBehaviour
{
	public class RandomOffsetsData
	{
		public bool left; //Field offset: 0x8
		public bool mid; //Field offset: 0x9
		public bool right; //Field offset: 0xA

		public RandomOffsetsData() { }

	}

	public static readonly string RandomOffsetsFieldName; //Field offset: 0x0
	private RandomOffsetsData randomOffsets; //Field offset: 0xC
	private List<float> _offsets; //Field offset: 0x10

	public RandomOffsetsData RandomOffsets
	{
		 get { } //Length: 89
	}

	private static RandomizeOffset() { }

	public RandomizeOffset() { }

	public void ChooseRandomOffset() { }

	public RandomOffsetsData get_RandomOffsets() { }

	private void OnEnable() { }

	public void SetRandomOffsetsData(RandomOffsetsData newRandomOffsetsData) { }

}

