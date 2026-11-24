using System;
using Cpp2ILInjected;
using UI.VideoAdPrizes;
using UnityEngine;

namespace UI;

public class UICameraScreenClipping : MonoBehaviour
{
	private const float SCREEN_WIDTH = 306f;

	private const float POPUP_WIDTH = 265f;

	private Rect previousRect;

	private bool _setClippingOnStart;

	private void Start()
	{
		CancelInvoke();
	}

	public void CalculateClipping(bool popupSizedClip)
	{
		//IL_00d1: Expected Obj, but got I4
		//IL_0033: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I
		//IL_00ee: Expected I4, but got Obj
		//IL_00ee: Expected I4, but got Obj
		//IL_0074: Expected I, but got Obj
		bool flag = !popupSizedClip;
		bool flag2 = !flag;
		RootScaler rootScaler = (RootScaler)popupSizedClip;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			RootScaler rootScaler2 = default;
			rootScaler2.Awake();
			rootScaler = rootScaler2;
		}
		nint num = (nint)typeof(CameraSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v9 (Il2CppClass<UI.CameraSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CameraSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v16 (Il2CppClass<UI.CameraSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((VideoAdPrize)(object)CameraSettings._renderTextureCameraSettings)._002Ector((VideoAdPrizeType)this, (int)rootScaler);
	}

	public void ResetClipping()
	{
		if (~(_setClippingOnStart ? 1u : 0u) == 0)
		{
			WelcomePackManager.Log((string)(object)this, (UnityEngine.Object)null);
		}
	}

	public UICameraScreenClipping()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		string text = tag;
		Camera component = ((GameObject)(object)text).GetComponent<Camera>();
		object obj = this + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v2+8]");
		_ = 0;
		Camera camera = (Camera)(obj2 + 16);
		camera = (Camera)obj2;
		Camera camera2 = camera;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)camera2).m_CachedPtr = (IntPtr)0;
		Rect pixelRect = camera.pixelRect;
		object obj3 = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
	}
}
