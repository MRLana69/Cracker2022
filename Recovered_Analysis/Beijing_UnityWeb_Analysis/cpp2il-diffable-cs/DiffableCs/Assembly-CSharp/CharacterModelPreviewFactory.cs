//Type is in global namespace

public class CharacterModelPreviewFactory : MonoBehaviour
{
	private sealed class <>c__DisplayClass11_0
	{
		public string name; //Field offset: 0x8
		public Action<GameObject> onSuccess; //Field offset: 0xC

		public <>c__DisplayClass11_0() { }

		internal void <GetCharacterModelPreview>b__0(ModelSetupObject go) { }

	}

	private sealed class <>c__DisplayClass12_0
	{
		public CharacterModelPreviewFactory <>4__this; //Field offset: 0x8
		public Action<GameObject> onSuccess; //Field offset: 0xC

		public <>c__DisplayClass12_0() { }

		internal void <GetEventScreenModel>b__0(ModelSetupObject MSO) { }

	}

	private sealed class <>c__DisplayClass13_0
	{
		public CharacterModelPreviewFactory <>4__this; //Field offset: 0x8
		public Action<GameObject> onSuccess; //Field offset: 0xC

		public <>c__DisplayClass13_0() { }

		internal void <GetFacebookScreenModel>b__0(ModelSetupObject go) { }

	}

	private sealed class <>c__DisplayClass14_0
	{
		public CharacterModelPreviewFactory <>4__this; //Field offset: 0x8
		public Action<CharacterScreenController> onSuccess; //Field offset: 0xC

		public <>c__DisplayClass14_0() { }

		internal void <GetCharacterEventScreenModel>b__0(ModelSetupObject mso) { }

	}

	private sealed class <>c__DisplayClass15_0
	{
		public CharacterModelPreviewFactory <>4__this; //Field offset: 0x8
		public Action<CharacterScreenController> onSuccess; //Field offset: 0xC

		public <>c__DisplayClass15_0() { }

		internal void <GetCharacterComebackScreenModel>b__0(ModelSetupObject modelSetupObject) { }

	}

	private sealed class <>c__DisplayClass16_0
	{
		public CharacterModelPreviewFactory <>4__this; //Field offset: 0x8
		public string name; //Field offset: 0xC
		public int version; //Field offset: 0x10
		public bool useSpecialAsset; //Field offset: 0x14
		public bool forceLOD0; //Field offset: 0x15
		public bool asynchronous; //Field offset: 0x16
		public bool useAnimatedEyes; //Field offset: 0x17
		public Action<ModelSetupObject> onSucess; //Field offset: 0x18

		public <>c__DisplayClass16_0() { }

		internal void <BuildCharacter>b__0(CharacterAssetsBundle modelBundle) { }

	}

	private sealed class <>c__DisplayClass16_1
	{
		public CharacterAssetsBundle modelBundle; //Field offset: 0x8
		public <>c__DisplayClass16_0 CS$<>8__locals1; //Field offset: 0xC

		public <>c__DisplayClass16_1() { }

	}

	private sealed class <>c__DisplayClass16_2
	{
		public GameObject go; //Field offset: 0x8
		public CharacterRig rig; //Field offset: 0xC
		public <>c__DisplayClass16_1 CS$<>8__locals2; //Field offset: 0x10

		public <>c__DisplayClass16_2() { }

		internal void <BuildCharacter>b__1() { }

	}

	public class ModelSetupObject
	{
		public AnimationClip ScrollbarPose; //Field offset: 0x8
		public AnimationClip ScrollbarHeadPose; //Field offset: 0xC
		public AnimationClip EventScreenPose; //Field offset: 0x10
		public AnimationClip NameEventScreenIdle; //Field offset: 0x14
		public GameObject model; //Field offset: 0x18
		public bool UseCustomEventScreenIdle; //Field offset: 0x1C

		public ModelSetupObject() { }

	}

	private static CharacterModelPreviewFactory instance; //Field offset: 0x0
	private GameObject characterModelPreviewPrefab; //Field offset: 0xC
	private CharacterAssetFactory characterAssetFactory; //Field offset: 0x10
	private AnimationClip facebookIdle; //Field offset: 0x14
	private AnimationClip defaultEventScreenPose; //Field offset: 0x18
	private AnimationClip defaultEnventScreenIdle; //Field offset: 0x1C
	private Shader eventScreenShader; //Field offset: 0x20
	private Shader eventScreenOutfitShader; //Field offset: 0x24
	private float _nameEventScreenCharacterFadeFactor; //Field offset: 0x28
	private float _nameEventScreenShadowFadeFactor; //Field offset: 0x2C
	private SkinnedMeshRenderer headMesh; //Field offset: 0x30

	public static CharacterModelPreviewFactory Instance
	{
		 get { } //Length: 141
	}

	private static CharacterModelPreviewFactory() { }

	public CharacterModelPreviewFactory() { }

	public void BuildCharacter(string name, int version, bool useSpecialAsset, bool useAnimatedEyes, bool forceLOD0, Action<ModelSetupObject> onSucess, bool asynchronous = false) { }

	public static CharacterModelPreviewFactory get_Instance() { }

	public void GetCharacterComebackScreenModel(CharacterId charId, int themeIndex, Action<CharacterScreenController> onSuccess) { }

	public void GetCharacterEventScreenModel(string name, int version, Action<CharacterScreenController> onSuccess) { }

	public void GetCharacterModelPreview(string name, int version, Action<GameObject> onSuccess, bool asynchronous) { }

	public void GetEventScreenModel(string name, int version, Action<GameObject> onSuccess) { }

	public void GetFacebookScreenModel(string name, Action<GameObject> onSuccess) { }

	private void OnDestroy() { }

}

