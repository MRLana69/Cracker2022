using Cpp2ILInjected;
using SYBO.Subway.Info;
using UI.Popups;
using UI.RenderTexture;
using UnityEngine;

namespace UI;

public class DinoLogoCharacterHelper : MonoBehaviour
{
	private FacebookDinoLogoRenderTextureSetup _dinoLogoRenderTextureSetup;

	private void OnDisable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = this + 100;
		obj3 = string.Empty;
		object obj4 = this + 104;
		obj4 = string.Empty;
		obj = 0;
		obj = -1;
		obj2 = obj;
		object obj5 = obj2 + 4;
		obj5 = obj2;
		CancelInvoke();
	}

	private void OnEnable()
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		this._002Ector();
		string obj = tag;
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Object.DestroyImmediate((Object)(object)obj);
	}

	private void ActivateDinoLogoAnimation()
	{
		DeactivateDinoLogoAnimation();
	}

	private void DeactivateDinoLogoAnimation()
	{
		((CharacterPromotionPopup)(object)_dinoLogoRenderTextureSetup).OnCharacterPurchaseSuccess(Characters.CharacterId.slick, 1);
	}

	public DinoLogoCharacterHelper()
	{
		((RenderTextureSetupBase)_dinoLogoRenderTextureSetup).OnReleaseRenderTexture();
	}
}
