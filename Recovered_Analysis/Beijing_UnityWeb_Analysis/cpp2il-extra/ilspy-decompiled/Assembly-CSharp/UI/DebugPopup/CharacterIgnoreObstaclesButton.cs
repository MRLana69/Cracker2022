using System;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UI.DoubleCoinsVideo;
using UI.Generic.Layout;
using UI.Screens.PauseScreenInternal;
using UnityEngine;
using UnityEngine.Networking;

namespace UI.DebugPopup;

public class CharacterIgnoreObstaclesButton : MonoBehaviour
{
	private UILabel _titleLabel;

	private int _characterLayer;

	private int _hitLayer;

	private void OnEnable()
	{
	}

	public void Click()
	{
		//IL_0051: Expected VT, but got I4
		//IL_0051: Expected VT, but got I4
		bool characterLayer = ((MonoBehaviour)(object)"Character").IsInvoking();
		_characterLayer = (characterLayer ? 1 : 0);
		bool hitLayer = ((MonoBehaviour)(object)"Hit").IsInvoking();
		_hitLayer = (hitLayer ? 1 : 0);
		bool flag = Physics.Raycast((Vector3)_hitLayer, (Vector3)_characterLayer);
		((CharacterInvincibleButton)this).SetupButton(flag);
	}

	private void SetupButton(bool enabled)
	{
		//IL_018f: Expected Obj, but got I4
		//IL_019d: Expected I, but got Obj
		//IL_01b3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		object obj = 0;
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<HouseKeeper>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v45 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.RefreshOnlineSettingsAndInappsIfNeeded();
		if (enabled)
		{
			UILabel titleLabel = _titleLabel;
			TransformExtensions.Reset((Transform)(object)titleLabel.leftAnchor);
			if (UI.DoubleCoinsVideo.DoubleCoinsVideo.onDoubleCoinsReceived != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
				dailyChallengeRewardHelper.Refresh();
				((UnityEngine.Object)dailyChallengeRewardHelper).m_CachedPtr = (IntPtr)16;
				dailyChallengeRewardHelper._rewardLayout = (Layout)13;
				obj = 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
		}
	}

	public CharacterIgnoreObstaclesButton()
	{
		//IL_0011: Expected VT, but got I4
		//IL_0011: Expected VT, but got I4
		//IL_0023: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		string text = (string)((Physics.Raycast((Vector3)_hitLayer, (Vector3)_characterLayer) ? 1 : 0) ^ 1);
		((UnityWebRequest)_hitLayer)._002Ector((string)_characterLayer, text);
		((CharacterInvincibleButton)this).SetupButton((byte)(int)text != 0);
	}
}
