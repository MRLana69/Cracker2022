using Cpp2ILInjected;
using UnityEngine;

namespace UI.Helpers;

public class WelcomePackStickerHelper : MonoBehaviour
{
	private const int PROCENT_OFF = 70;

	private UISprite _stickerBackground;

	private UILabel _stickerLabel;

	private void OnEnable()
	{
		CancelInvoke();
	}

	private void SetupSticker()
	{
		this._002Ector();
	}

	public unsafe WelcomePackStickerHelper()
	{
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got VT
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected VT, but got Unknown
		//IL_01e6: Expected F4, but got Obj
		//IL_01e1: Expected native int or pointer, but got VT
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_020e: Expected F4, but got Obj
		//IL_0209: Expected native int or pointer, but got VT
		//IL_0223: Expected F4, but got I
		//IL_021e: Expected native int or pointer, but got VT
		//IL_0232: Expected I4, but got VT
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0249: Expected Obj, but got VT
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_026c: Expected F4, but got Obj
		//IL_0267: Expected native int or pointer, but got VT
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_0083: Expected I4, but got VT
		//IL_0091: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_017e: Expected F4, but got I4
		//IL_0179: Expected native int or pointer, but got VT
		//IL_0120: Expected I4, but got Obj
		//IL_00d2: Expected I, but got Obj
		nint num = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v41 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 40;
		obj2 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_BG;
		object obj4 = obj3 + 44;
		obj4 = obj2;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 48);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		object obj5 = obj3 + 24;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v15+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_stickerBackground.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj6 = obj3 + 16;
		obj6 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_TEXT;
		object obj7 = obj3 + 20;
		obj7 = obj6;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_stickerLabel.rawPivot = (UIWidget.Pivot)matrix4x;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v29 (Il2CppClass<Strings>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v37 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("DISCOUNT_BUTTON_COOL_OFF");
		((Matrix4x4*)(nint)matrix4x)->m00 = 70f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = string.Format(format, args);
		_stickerLabel.fontSize = (int)text;
	}
}
