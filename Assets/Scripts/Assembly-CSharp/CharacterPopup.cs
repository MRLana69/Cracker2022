using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UI.Screens;
using UnityEngine;

public class CharacterPopup : UIScreen
{
	private sealed class _003CAnimateCharacterModelCoroutine_003Ed__8(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterPopup _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0052: Expected I4, but got I8
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					CharacterPopup characterPopup = _003C_003E4__this;
					characterPopup.characterModel.StartIdlePopupAnimations();
				}
				return false;
			}
			_003C_003E1__state = -1;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private CharacterModel characterModel;

	private CharacterModel secondaryCharacterModel;

	protected UIModelController uimodelController;

	private bool _characterHidden;

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<CharacterPopup>)+104] (should have been resolved before IL gen)");
		UIModelController instance = UIModelController.Instance;
		uimodelController = instance;
	}

	protected unsafe void SetCharacter(Characters.CharacterType character, Vector2? offsetFromAnchor = null, Vector3? rotationOffset = null, float scale = 19f, bool posing = false, AnimationClip pose = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_0035: Invalid comparison between VT and I4
		//IL_0048: Expected Obj, but got I8
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected VT, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected VT, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01bb: Expected F4, but got I
		//IL_01cb: Expected F4, but got I
		//IL_03b8: Expected F4, but got I
		//IL_03b3: Expected native int or pointer, but got VT
		//IL_03d7: Expected F4, but got I
		//IL_03d2: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		uimodelController.ClearTutorialPopup();
		object obj2 = this + 52;
		if (this.characterModel == null)
		{
			bool flag = (Vector2)offsetFromAnchor == (Vector2)(object)0;
			object obj3 = 4735535009288159232L;
			if (!flag)
			{
				object obj4 = vector - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4A5B");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				obj3 = 0;
			}
			UIModelController uIModelController = uimodelController;
			GameObject gameObject = NGUITools.AddChild(uIModelController.TutorialPopupAnchor, uIModelController.ModelPrefab);
			CharacterModel component = gameObject.GetComponent<CharacterModel>();
			this.characterModel = component;
			Transform t = this.characterModel.transform;
			UIModelController uIModelController2 = uimodelController;
			int layer = uIModelController2.TutorialPopupAnchor.layer;
			Utility.SetLayerRecursively(t, layer);
			Transform transform = this.characterModel.transform;
			_ = 1112014848;
			_ = 1112014848;
			Vector3 localPosition = vector + 32;
			transform.localPosition = localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			Vector3 localScale = vector + 16;
			transform.localScale = localScale;
			if (!posing)
			{
				float num = 200f;
				float num2 = 50f;
			}
			else
			{
				object obj5 = vector - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1510");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				float num2 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				float num = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector)->x = 0f;
			transform.localEulerAngles = vector;
			((CharacterModel)obj2).IsVisibleShadow = false;
		}
		Characters.Model model = Characters.characterData.get_Item(character);
		UIScreenController instance = UIScreenController.Instance;
		string currentPopupName = instance.GetCurrentPopupName();
		bool flag2 = currentPopupName == "WelcomePopup";
		bool useSpecialAsset = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
		((CharacterModel)obj2).ChangeCharacterModel(model.modelName, 0, useSpecialAsset, false);
		((CharacterModel)obj2).HideAllPowerups();
		CharacterModel characterModel = (CharacterModel)obj2;
		if (posing)
		{
			string newName = pose.name;
			characterModel._characterAnimation.AddClip(pose, newName);
			string animation = pose.name;
			bool flag3 = characterModel._characterAnimation.Play(animation);
		}
		else
		{
			((CharacterModel)obj2).StartIdlePopupAnimations();
		}
		UIModelController uIModelController3 = uimodelController;
		CharacterScaler component2 = uIModelController3.TutorialPopupAnchor.GetComponent<CharacterScaler>();
		if (component2 != null)
		{
			component2.lookAtCamera = true;
		}
	}

	public void HideCharacter()
	{
		UIModelController uIModelController = uimodelController;
		uIModelController.TutorialPopupAnchor.SetActive(value: false);
		_characterHidden = true;
	}

	public void ShowCharacter()
	{
		if (~(_characterHidden ? 1u : 0u) == 0)
		{
			UIModelController uIModelController = uimodelController;
			uIModelController.TutorialPopupAnchor.SetActive(value: true);
			IEnumerator routine = AnimateCharacterModelCoroutine();
			Coroutine coroutine = StartCoroutine(routine);
			_characterHidden = false;
		}
	}

	private IEnumerator AnimateCharacterModelCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	protected virtual void OnDisable()
	{
		UIScreenController instance = UIScreenController.Instance;
		if (instance != null)
		{
			UIScreenController instance2 = UIScreenController.Instance;
			if (!instance2.stoppingFromEditor)
			{
				uimodelController.ClearTutorialPopup();
			}
		}
	}
}
