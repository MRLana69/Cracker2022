using System;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

public class CharacterModelPreviewFactory : MonoBehaviour
{
	[Serializable]
	public class ModelSetupObject
	{
		public AnimationClip ScrollbarPose;

		public AnimationClip ScrollbarHeadPose;

		public AnimationClip EventScreenPose;

		public AnimationClip NameEventScreenIdle;

		public GameObject model;

		public bool UseCustomEventScreenIdle;
	}

	private GameObject characterModelPreviewPrefab;

	private CharacterAssetFactory characterAssetFactory;

	private AnimationClip facebookIdle;

	private AnimationClip defaultEventScreenPose;

	private AnimationClip defaultEnventScreenIdle;

	private Shader eventScreenShader;

	private Shader eventScreenOutfitShader;

	private float _nameEventScreenCharacterFadeFactor = 0.6f;

	private float _nameEventScreenShadowFadeFactor;

	private SkinnedMeshRenderer headMesh;

	private static CharacterModelPreviewFactory instance;

	public static CharacterModelPreviewFactory Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			CharacterModelPreviewFactory result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(CharacterModelPreviewFactory));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				CharacterModelPreviewFactory characterModelPreviewFactory = default;
				instance = characterModelPreviewFactory;
				result = characterModelPreviewFactory;
			}
			return result;
		}
	}

	public void GetCharacterModelPreview(string name, int version, Action<GameObject> onSuccess)
	{
		throw new ArgumentException();
	}

	public void GetEventScreenModel(string name, int version, Action<GameObject> onSuccess)
	{
		throw new ArgumentException();
	}

	public void GetFacebookScreenModel(string name, Action<GameObject> onSuccess)
	{
		throw new ArgumentException();
	}

	public void GetCharacterEventScreenModel(string name, int version, Action<CharacterScreenController> onSuccess)
	{
		throw new ArgumentException();
	}

	public void GetCharacterComebackScreenModel(Characters.CharacterType charType, int themeIndex, Action<CharacterScreenController> onSuccess)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		_ = -1;
		obj = (Enum)(object)typeof(Characters.CharacterType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text = obj.ToString();
		throw new ArgumentException();
	}

	public void BuildCharacter(string name, int version, bool useSpecialAsset, bool useAnimatedEyes, bool forceLOD0, Action<ModelSetupObject> onSucess)
	{
		throw new ArgumentException();
	}

	private void OnDestroy()
	{
		instance = null;
	}
}
