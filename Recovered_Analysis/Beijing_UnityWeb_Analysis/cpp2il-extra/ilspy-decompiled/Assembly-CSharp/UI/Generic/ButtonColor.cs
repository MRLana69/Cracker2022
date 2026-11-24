using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

namespace UI.Generic;

public class ButtonColor : MonoBehaviour
{
	private UIWidget _widget;

	private Color _normalColor;

	private Color _pressedColor;

	private void OnPress(bool pressed)
	{
		//IL_009e: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		nint num = (nint)typeof(CoinScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CoinScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(CoinScreen.openedFromWelcomePackGetNowClick ? 1u : 0u) == 0)
		{
			object obj2 = this + 60;
			obj2 = "BoardScreen";
		}
		else
		{
			object obj3 = this + 60;
			bool isShowingPopup = ((UIScreenController)pressed).isShowingPopup;
			obj3 = isShowingPopup;
		}
	}

	private void TakeNormalColorFromWidget()
	{
		CancelInvoke();
	}

	private void MakePressedFromNormalColor()
	{
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		if (((ComputeShader)(object)_widget).FindKernel((string)null) != 0)
		{
			object obj4 = _widget + 80;
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v14+8]");
			_ = 0;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = this + 16;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9+8]");
			_ = 0;
		}
	}

	public ButtonColor()
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0214: Expected Obj, but got I4
		//IL_0222: Expected Obj, but got F4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		object obj = this + 16;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v40 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = (float)obj - 30f / 255f;
		if (num3 < 0f)
		{
			num3 = 0f;
		}
		else if (num3 > 1f)
		{
			num3 = 1f;
		}
		object obj3 = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v15+4]");
		float num4 = 0f - 30f / 255f;
		if (num4 < 0f)
		{
			num4 = 0f;
		}
		else if (num4 > 1f)
		{
			num4 = 1f;
		}
		object obj4 = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v21+8]");
		float num5 = 0f - 30f / 255f;
		if (num5 < 0f)
		{
			num5 = 0f;
		}
		else if (num5 > 1f)
		{
			num5 = 1f;
		}
		object obj5 = this + 16;
		object obj6 = 0;
		_ = 0;
		obj6 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v27+C]");
		_ = 0;
		object obj7 = obj6 + 16;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj8 = this + 32;
		obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v36+8]");
		_ = 0;
	}
}
