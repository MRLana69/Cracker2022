using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace UI;

public class FacebookPromotionReconnect : MonoBehaviour
{
	private GameObject _loginButton;

	private UILabel _warningLabel;

	private Transform _dinoLogoPosition;

	private GameObject _dinoLogoPrefab;

	private GameObject _dino;

	public void Init(Action clickedAction)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00d2: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		object obj = clickedAction & 1;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FacebookPromotionReconnect)+34]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FacebookPromotionReconnect)+44]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FacebookPromotionReconnect)+34]");
				((UIButtonOverlayOff)0).GoToNotAvailableState();
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FacebookPromotionReconnect)+34]");
				((UIButtonOverlayOff)0).GoToSelectedState();
			}
		}
	}

	private void CreateDinoLogo()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<GameObject> list = default;
		list._002Ector();
		object obj = this + 52;
		obj = list;
		CancelInvoke();
	}

	public unsafe FacebookPromotionReconnect()
	{
		//IL_014a: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected VT, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected VT, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0061: Expected VT, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_01ae: Expected I, but got Obj
		//IL_01c4: Expected Obj, but got I
		//IL_01ee: Expected F4, but got Obj
		//IL_01e9: Expected native int or pointer, but got VT
		//IL_0200: Expected F4, but got I
		//IL_01fb: Expected native int or pointer, but got VT
		//IL_020d: Expected F4, but got Obj
		//IL_0208: Expected native int or pointer, but got VT
		//IL_021f: Expected F4, but got I
		//IL_021a: Expected native int or pointer, but got VT
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_00b0: Expected I, but got Obj
		//IL_00fd: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = default;
		Quaternion quaternion = (Quaternion)(transform + 40);
		Vector3 vector = (Vector3)(transform + 28);
		Transform transform2 = (Transform)(transform + 16);
		if (!(_dino != null))
		{
			return;
		}
		transform2.position = (Vector3)_dinoLogoPosition;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v17 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v41 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform.Rotate(0f, 0f, 0f);
		GameObject parent = base.gameObject;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)transform2;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		((Quaternion*)(nint)quaternion)->x = (float)transform;
		((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		object obj4 = this + 28;
		GameObject gameObject = UnityEngine.Object.Instantiate(_dinoLogoPrefab, vector, quaternion, (Transform)(object)parent);
		obj4 = gameObject;
	}
}
