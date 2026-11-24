using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UnityEngine;

namespace UI;

public class iPhoneXFooterScaler : MonoBehaviour
{
	private Transform[] footerItems;

	private bool _hasOffsetButtons;

	private void Start()
	{
		CancelInvoke();
	}

	public iPhoneXFooterScaler()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00e1: Expected I, but got Obj
		//IL_00f7: Expected Obj, but got I
		//IL_01c5: Expected F4, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_0122: Expected I, but got Obj
		if (~(_hasOffsetButtons ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v30 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			object obj2 = footerItems + 12;
			object obj3 = default;
			object obj8 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				object obj4 = footerItems + 16;
				object obj5 = obj3 << 2;
				object obj6 = obj4 + obj5;
				nint num3 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v14 (Il2CppClass<IPhoneXSupport>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(IPhoneXSupport);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v22 (Il2CppClass<IPhoneXSupport>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				TransformExtensions.OffsetLocalPosZ((Transform)obj6, IPhoneXSupport.OFFSET_BOTTOM);
				obj3 = obj8 + 1;
			}
		}
		_hasOffsetButtons = true;
	}
}
