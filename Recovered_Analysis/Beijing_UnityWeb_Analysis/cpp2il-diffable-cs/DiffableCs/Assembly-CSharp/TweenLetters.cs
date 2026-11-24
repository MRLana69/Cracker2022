//Type is in global namespace

public class TweenLetters : UITweener
{
	public enum AnimationLetterOrder
	{
		Forward = 0,
		Reverse = 1,
		Random = 2,
	}

	public class AnimationProperties
	{
		public AnimationLetterOrder animationOrder; //Field offset: 0x8
		public float overlap; //Field offset: 0xC
		public bool randomDurations; //Field offset: 0x10
		public Vector2 randomness; //Field offset: 0x14
		public Vector2 offsetRange; //Field offset: 0x1C
		public Vector3 pos; //Field offset: 0x24
		public Vector3 rot; //Field offset: 0x30
		public Vector3 scale; //Field offset: 0x3C
		public float alpha; //Field offset: 0x48

		public AnimationProperties() { }

	}

	private class LetterProperties
	{
		public float start; //Field offset: 0x8
		public float duration; //Field offset: 0xC
		public Vector2 offset; //Field offset: 0x10

		public LetterProperties() { }

	}

	public AnimationProperties hoverOver; //Field offset: 0x58
	public AnimationProperties hoverOut; //Field offset: 0x5C
	private UILabel mLabel; //Field offset: 0x60
	private int mVertexCount; //Field offset: 0x64
	private int[] mLetterOrder; //Field offset: 0x68
	private LetterProperties[] mLetter; //Field offset: 0x6C
	private AnimationProperties mCurrent; //Field offset: 0x70

	public TweenLetters() { }

	private void Awake() { }

	private static Vector3 GetCenter(List<Vector3> verts, int firstVert, int length) { }

	private void GetLetterDuration(int letterCount) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPostFill(UIWidget widget, int bufferOffset, List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	protected override void OnUpdate(float factor, bool isFinished) { }

	public override void Play(bool forward) { }

	private float ScaleRange(float value, float baseMax, float limitMax) { }

	private void SetLetterOrder(int letterCount) { }

}

