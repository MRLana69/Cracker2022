using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Ionic.Crc;
using Kiloo.Common.Extensions;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI;

public class FriendsLoginFBButton : MonoBehaviour
{
	private GameObject _connectingContent;

	private GameObject _normalContentLeaderboard;

	private GameObject _overlay;

	private UILabel _leaderboardLabel1;

	private Collider _leaderboardCollider;

	private UISprite _connectingFill;

	private UILabel _connectingLabel;

	private Layout _connectingLayout;

	private Layout _loginLayout;

	private Action _clickedAction;

	private Action _activateReconnect;

	private bool _leaderboardScreen;

	private bool _noFriends;

	private bool _isGameOverScreen;

	public void Init(Action clickedAction, bool leaderboardScreen = false, bool noFriends = false, bool isGameOverScreen = false, Action activateReconnect = null)
	{
		//IL_008d: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00c3: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		_leaderboardLabel1 = (UILabel)2;
		_activateReconnect = (Action)16384;
		object obj = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		nint num = (nint)typeof(Stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v10 (Il2CppClass<System.IO.Stream>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Stream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v29 (Il2CppClass<System.IO.Stream>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_leaderboardCollider = null;
		object obj4 = this + 60;
		obj4 = clickedAction;
		Layout loginLayout = (Layout)(activateReconnect & 1);
		_loginLayout = loginLayout;
		_connectingLabel = (UILabel)leaderboardScreen;
		_connectingFill = (UISprite)isGameOverScreen;
		_connectingLayout = (Layout)noFriends;
		if ((isGameOverScreen ? 1 : 0) == 1952)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CRC32 cRC = default;
			cRC.Reset();
			object obj5 = this + 68;
			obj5 = cRC;
		}
	}

	public void ConnectClicked()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got F4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got F4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01ad: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 40;
		obj = 0;
		_ = 0;
		obj = 1f;
		_ = 1f;
		_ = 1f;
		_ = 1f;
		object obj3 = obj2 - -64;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		object obj4 = this + 12;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+8]");
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = 0;
		_ = 0;
		obj5 = 11f / 255f;
		_ = 43f / 255f;
		_ = 83f / 255f;
		_ = 1f;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
		_ = 0;
		object obj6 = this + 28;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+8]");
		_ = 0;
		object obj7 = obj2 + 12;
		obj7 = 0;
		obj7 = 0;
		obj7 = 11;
		_ = 43;
		_ = 83;
		_ = -52;
		object obj8 = obj2 + 56;
		obj8 = obj7;
		obj3 = obj8;
		object obj9 = obj2 + 4;
		obj9 = 0;
		obj9 = 0;
		obj9 = -72;
		_ = -41;
		_ = -19;
		_ = 127;
		object obj10 = obj2 + 32;
		obj10 = obj9;
		obj3 = obj10;
		obj2 = 0;
		obj2 = 0;
		obj2 = 120;
		_ = -86;
		_ = -50;
		_ = 127;
		object obj11 = obj2 + 8;
		obj11 = obj2;
		obj3 = obj11;
		CancelInvoke();
	}

	private unsafe void SetToLogInState(bool isLeaderboardScreen, bool noFriends, bool isGameOverScreen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected VT, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I
		//IL_006a: Expected F4, but got Obj
		//IL_0065: Expected native int or pointer, but got VT
		//IL_02e3: Expected F4, but got Obj
		//IL_02de: Expected native int or pointer, but got VT
		//IL_02f8: Expected F4, but got I
		//IL_02f3: Expected native int or pointer, but got VT
		//IL_0305: Expected I4, but got VT
		//IL_002b: Expected Obj, but got I
		//IL_0040: Expected F4, but got Obj
		//IL_003b: Expected native int or pointer, but got VT
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_0325: Expected Obj, but got I
		//IL_0338: Expected I4, but got Obj
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_0365: Expected F4, but got Obj
		//IL_0360: Expected native int or pointer, but got VT
		//IL_037a: Expected F4, but got I
		//IL_0375: Expected native int or pointer, but got VT
		//IL_0389: Expected I4, but got VT
		//IL_011a: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_00cd: Expected I, but got Obj
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0165: Expected F4, but got Obj
		//IL_0160: Expected native int or pointer, but got VT
		//IL_017a: Expected F4, but got I
		//IL_0175: Expected native int or pointer, but got VT
		//IL_0189: Expected I4, but got VT
		//IL_0189: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I
		//IL_01c5: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got I
		//IL_0206: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 40;
		obj = noFriends;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 48);
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 36;
		object obj5 = obj2 + 32;
		_ = 1;
		object obj6 = this - -64;
		if (isGameOverScreen)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendsLoginFBButton)+58]");
			obj3 = 0;
			obj5 = obj3;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendsLoginFBButton)+54]");
			obj3 = 0;
			obj4 = obj3;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		}
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)obj6).rawPivot = (UIWidget.Pivot)matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		((UILabel)(object)_loginLayout).fontSize = fontSize;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v11 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S2_v47 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isLeaderboardScreen @ L1 (System.Boolean)+8]");
		string text = Strings.GetDefault((string)0);
		((UILabel)(object)_activateReconnect).fontSize = (int)text;
		object obj8 = this + 28;
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S2_v18+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)(object)_activateReconnect).rawPivot = (UIWidget.Pivot)matrix4x;
		object obj9 = (isLeaderboardScreen ? 1 : 0) + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize2 = default;
		((UILabel)_leaderboardScreen).fontSize = fontSize2;
		object obj10 = this + 28;
		obj2 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S2_v31+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)_leaderboardScreen).rawPivot = (UIWidget.Pivot)matrix4x;
		string text2 = ((Component)(object)_clickedAction).tag;
		((GameObject)(object)text2).tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendsLoginFBButton)+6C]");
		object obj11 = 0;
		nint num3 = (nint)typeof(LeaderboardDummyData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v41 (Il2CppClass<LeaderboardDummyData>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(LeaderboardDummyData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v51 (Il2CppClass<LeaderboardDummyData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<LeaderboardDummyData.LeaderboardDummy> dummyData = LeaderboardDummyData.dummyData;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S7_v2 (Il2CppMethodInfo)+C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S7_v3+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S7_v4+8C]");
		object obj15 = 0;
		object obj16 = obj15 & 0x7FF;
		object obj17 = obj16 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v207 @ S8_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v38+C]");
		int index = default;
		Challenger challenger = ((List<Challenger>)0).get_Item(index);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		int num6 = Shader.PropertyToID("Unlit/Transparent Colored (AlphaClip)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		((FriendHelperHighScore)this).HideMedal();
		((FriendHelperHighScore)this).InitializeMedal();
		_ = 1;
	}

	private void SetToConnectingState()
	{
		TransformExtensions.Reset((Transform)(object)_clickedAction);
		FBStateChangedHandler();
	}

	private void FBStateChangedHandler()
	{
		//IL_002d: Expected Obj, but got I4
		_overlay.tag = null;
		_normalContentLeaderboard.tag = null;
		_connectingContent.tag = (string)1;
		((RewardForVideoButton)(object)_connectingLayout).Init((VideoButtonPayload)null);
		_leaderboardCollider.isTrigger = false;
	}

	private void OnEnable()
	{
		//IL_00e2: Expected I, but got Obj
		//IL_00f8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00cf: Expected Obj, but got I4
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v20 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+60]");
		if ((nint)0 == 1)
		{
			if (_activateReconnect != null)
			{
				TransformExtensions.Reset((Transform)(object)_activateReconnect);
				return;
			}
			bool leaderboardScreen = _leaderboardScreen;
			bool noFriends = _noFriends;
			bool isGameOverScreen = _isGameOverScreen;
			((GameOverLeaderboardHandler)this).SetOnlineContentListForLeaderboard(leaderboardScreen, (Friend[])noFriends, isGameOverScreen);
		}
	}

	private unsafe void OnDisable()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FriendsLoginFBButton.FBStateChangedHandler);
		object obj2 = action + 16;
		obj2 = this;
		((SocialManager)facebookDialogsSupported).RemoveFacebookStateChangedHandler(action);
	}

	public FriendsLoginFBButton()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		SocialManager.FacebookState facebookState = default;
		object obj2 = facebookState + 16;
		obj2 = this;
		((SocialManager)facebookDialogsSupported).facebookState = facebookState;
	}
}
