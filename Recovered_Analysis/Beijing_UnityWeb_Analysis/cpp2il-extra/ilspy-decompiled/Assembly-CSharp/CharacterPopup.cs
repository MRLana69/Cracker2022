using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UI.Screens;
using UnityEngine;

public class CharacterPopup : UIScreen
{
	private sealed class _003CAnimateCharacterModelCoroutine_003Ed__9(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterPopup _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Expected Obj, but got Unknown
				//IL_006c: Expected Obj, but got I4
				//IL_0080: Expected Obj, but got I4
				CharacterPopup characterPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						characterPopup._characterModel.StopIdleAnimations();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				obj = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private CharacterModel _characterModel;

	private CharacterModel _secondaryCharacterModel;

	protected UIModelController uimodelController;

	private bool _characterHidden;

	public override void Init()
	{
		CancelInvoke();
	}

	protected void SetCharacter(Characters.CharacterId character, Vector2? offsetFromAnchor = null, Vector3? rotationOffset = null, float scale = 19f, bool posing = false, AnimationClip pose = null, bool useSpecialAsset = true)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public override void Hide()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0027: Expected Obj, but got I4
		ShowIfInactive();
		object obj = this + 48;
		bool isInstanced = UIScreenController.IsInstanced;
		obj = isInstanced;
	}

	public void HideCharacter()
	{
		base.LoseFocus();
		ShowCharacter();
	}

	public void ShowCharacter()
	{
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		uimodelController.ClearScreenAnchor(UIModelController.ModelScreen.TutorialPopup);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_characterModel).FindKernel((string)null) != 0)
		{
			string text = _characterModel.tag;
			((GameObject)(object)text).tag = null;
		}
		_characterHidden = true;
	}

	private IEnumerator AnimateCharacterModelCoroutine()
	{
		//IL_0007: Expected Obj, but got I4
		return (IEnumerator)base._footerInited;
	}

	protected virtual void OnDisable()
	{
		//IL_0023: Expected I, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_00cb: Expected I4, but got Obj
		//IL_00d9: Expected Obj, but got I4
		//IL_0064: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I4
		if (~(_characterHidden ? 1u : 0u) != 0)
		{
			return;
		}
		uimodelController.DeactivateModelScreen(UIModelController.ModelScreen.TutorialPopup);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_characterModel).FindKernel((string)null) != 0)
		{
			string text = _characterModel.tag;
			((GameObject)(object)text).tag = (string)1;
		}
		bool flag = CharacterStickerManager.HasCharacterFreeTheme((Characters.CharacterId)this);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)flag);
		_characterHidden = false;
	}

	public CharacterPopup()
	{
		//IL_01e7: Expected I, but got Obj
		//IL_01fd: Expected Obj, but got I
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0231: Expected I, but got Obj
		//IL_0247: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I4
		//IL_00bf: Expected I, but got Obj
		//IL_010c: Expected I, but got Obj
		//IL_0159: Expected I, but got Obj
		//IL_016f: Expected Obj, but got I
		//IL_019a: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_characterModel).FindKernel((string)null) != 0)
		{
			string text = _characterModel.tag;
			((GameObject)(object)text).tag = null;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v10 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v31 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)flag != null)
		{
			return;
		}
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v20 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
	}
}
