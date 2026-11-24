//Type is in global namespace

public class ColorTeleboardMenuEffect : BatTeleboardMenuEffect
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MeshRenderer, Material> <>9__5_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal Material <AddChildrenMaterials>b__5_0(MeshRenderer r) { }

	}

	private int colorNumber; //Field offset: 0x34
	private List<Material> materials; //Field offset: 0x38

	public ColorTeleboardMenuEffect() { }

	private void AddChildrenMaterials(Transform rootTransform, ref List<Material> materials) { }

	private List<Material> CollectMaterials(CharacterModel characterModel) { }

	private void OnDisable() { }

	public override void StartTeleboardEffect(float duration, CharacterModel characterModel) { }

}

