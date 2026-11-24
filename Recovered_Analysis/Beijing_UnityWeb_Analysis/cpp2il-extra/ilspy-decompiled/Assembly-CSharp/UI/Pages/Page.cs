using System;
using Cpp2ILInjected;
using Data.Save;
using UI.Footer;
using UnityEngine;

namespace UI.Pages;

public abstract class Page : MonoBehaviour
{
	protected UIWidget topContainer;

	public abstract void Init(UIWidget pageGuideWidget);

	public abstract void Show();

	public abstract void Hide();

	public abstract FooterButton.FooterPayload GetButtonPayload();

	protected void TopAlign(UIWidget pageGuideWidget)
	{
		//IL_021b: Expected I, but got Obj
		//IL_0231: Expected Obj, but got I
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_005a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v56 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("MISSION_SET");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj3 = default;
		object obj2 = obj3 + 4;
		int missionsVersion = PlayerSave.missionsVersion;
		obj2 = missionsVersion;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	protected Page()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		_ = 1f;
		_ = 0.1f;
		object obj = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		object obj3 = this + 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}
}
