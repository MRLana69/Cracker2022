using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.Helpers;

public class MostPopularStickerHelper : MonoBehaviour
{
	private const int EXTRA_DEPTH_ON_TOP_OF_PANEL_PLACED_ON = 50;

	private UILabel _title;

	private UIWidget _widget;

	private HorizontalLayout _layout;

	private UIPanel _contentPanel;

	private UIPanel _maskPanel;

	public int height
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
	}

	private void OnEnable()
	{
		CancelInvoke();
	}

	public unsafe void SetDepthFrom(int depth)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I4
		//IL_0071: Invalid comparison between Obj and F4
		//IL_00aa: Invalid comparison between Obj and F4
		//IL_0063: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_00f9: Invalid comparison between I and F4
		//IL_00d5: Expected Obj, but got I4
		//IL_013a: Invalid comparison between I and F4
		//IL_00e3: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		obj = ((int*)depth)->m_value;
		UIWidget uIWidget = (UIWidget)obj;
		obj2 = ((int*)depth)->m_value;
		if (obj != obj)
		{
			uIWidget = (UIWidget)int.MinValue;
		}
		else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2.1474836E+09f))
		{
			uIWidget = (UIWidget)int.MinValue;
		}
		else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)(-2.1474836E+09f)))
		{
			uIWidget = (UIWidget)int.MinValue;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		Transform relativeParent;
		if (num != 0)
		{
			relativeParent = (Transform)int.MinValue;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if (!(0f < 2.1474836E+09f))
			{
				relativeParent = (Transform)int.MinValue;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if (!(0f > -2.1474836E+09f))
				{
					relativeParent = (Transform)int.MinValue;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					relativeParent = (Transform)0;
				}
			}
		}
		Bounds bounds = uIWidget.CalculateBounds(relativeParent);
	}

	public MostPopularStickerHelper()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00b1: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("MOST_POPULAR_STICKER_TITLE");
		_title.fontSize = (int)text;
		((RewardForVideoButton)(object)_layout).Init((VideoButtonPayload)null);
	}
}
