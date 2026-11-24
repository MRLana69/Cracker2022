using System;
using Cpp2ILInjected;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI.DoubleCoinsVideo;

public abstract class DoubleCoinsVideo : MonoBehaviour
{
	public static Action<CelebrationReward> onDoubleCoinsReceived;

	protected DoubleCoinsVideoPayload _payload;

	protected int _amount;

	private const string DOUBLE_COINS_VIDEO_PAYOUT_CAP_KEY = "DoubleCoinsVideoPayoutCap";

	private const int DEFAULT_CAP = 3000;

	public static int payoutCap
	{
		get
		{
			//IL_002d: Invalid comparison between I4 and F4
			int sleepTimeout = Screen.sleepTimeout;
			int height = Screen.height;
			int num = sleepTimeout / height;
			return ((float)num > 1.5f) ? 1 : 0;
		}
	}

	public abstract void Setup(DoubleCoinsVideoPayload payload);

	public unsafe virtual void SetCoinVisualValue(int coinValue)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00c0: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected VT, but got Unknown
		//IL_0103: Expected Obj, but got I
		//IL_0110: Expected F4, but got Obj
		//IL_010b: Expected native int or pointer, but got VT
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got F4
		//IL_015d: Expected F4, but got Obj
		//IL_0158: Expected native int or pointer, but got VT
		//IL_0177: Expected F4, but got Obj
		//IL_0172: Expected native int or pointer, but got VT
		//IL_0189: Expected F4, but got I4
		//IL_0184: Expected native int or pointer, but got VT
		//IL_019e: Expected I4, but got VT
		//IL_019e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got F4
		//IL_01b9: Expected F4, but got Obj
		//IL_01b4: Expected native int or pointer, but got VT
		//IL_01c6: Expected Obj, but got VT
		//IL_01d3: Expected F4, but got Obj
		//IL_01ce: Expected native int or pointer, but got VT
		//IL_01e5: Expected F4, but got I4
		//IL_01e0: Expected native int or pointer, but got VT
		//IL_01fa: Expected F4, but got Obj
		//IL_0054: Expected I, but got Obj
		object obj = default;
		string text = (string)(obj + 8);
		object obj2 = obj + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DoubleCoinsVideo.DoubleCoinsVideo)+18]");
		string text2 = ((Component)0).tag;
		string text3 = (string)(coinValue ^ 1);
		((GameObject)(object)text2).tag = text3;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DoubleCoinsVideo.DoubleCoinsVideo)+28]");
		object obj3 = (nint)0 + (nint)40;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		bool flag = coinValue == 0;
		float num = matrix4x.m00;
		if (!flag)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v27 (Il2CppClass<GlobalColors>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num3 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v39 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = matrix4x.m00;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
			Globals.LogError(text, (UnityEngine.Object)matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)text;
			((Matrix4x4*)(nint)matrix4x)->m20 = text.m_stringLength;
			Color color = (Color32)matrix4x;
			num = (float)obj;
		}
		object obj5 = obj + 24;
		obj5 = num;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)text;
		((Matrix4x4*)(nint)matrix4x)->m20 = text.m_stringLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DoubleCoinsVideo.DoubleCoinsVideo)+14]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
	}

	public abstract int GetHeight();

	protected void WatchVideo()
	{
		CancelInvoke();
	}

	protected DoubleCoinsVideo()
	{
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		OfferWallManager instance = OfferWallManager.instance;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v10 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		string text = default;
		text.m_stringLength = (int)num3;
		_ = 0;
		object obj2 = text + 16;
		obj2 = this;
		((AdSystemManager)(object)instance).FinishedWatchingVideo((string)(object)AdLocations.GAMEOVER_DOUBLE_COINS_VIDEOS, text);
	}

	private void _003CWatchVideo_003Eb__6_0()
	{
		CancelInvoke();
	}
}
