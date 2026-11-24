using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Backend.PurchaseValidation;
using SYBO.Components.Logging;
using TopRun;
using UI.Popups.AgeRestrictionPopupInternal;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI;

public class FriendHelperHighScore : MonoBehaviour
{
	private readonly Color _localPlayerColor;

	private readonly Color _friendColor;

	private UILabel _friendRank;

	private UISprite _unrankedBulletPoint;

	private UILabel _friendName;

	private UILabel _friendScore;

	private UITexture _friendPicture;

	private UISprite _friendBackground;

	private UISprite _medal;

	private UISprite _shadow;

	private UISprite _flag;

	private const int SCORE_SPACING = 10;

	private Color32 _cellBackgroundColorLocalUser;

	private Color32 _cellBackgroundColorClear;

	private Color32 _cellBackgroundColorDark;

	private Texture2D _dummyImage;

	private bool _isLocalUser;

	private bool _isDummy;

	private Friend _friend;

	private bool _initialized;

	private CharacterAvatars _avatars;

	public void InitLocalUser(int ranking, bool backgroundActive = false, bool isPlayerRanked = true)
	{
		//IL_0012: Expected Obj, but got I4
		//IL_0012: Expected Obj, but got I4
		((DoubleCoinUpgradeHelper)this)._DefaultSetup((string)ranking, backgroundActive, (IPurchaseValidationResult)isPlayerRanked);
		((DoubleCoinUpgradeHelper)this).DisableDiscount();
	}

	public unsafe void InitFriend(Friend friend, int ranking, bool backgroundActive = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected Obj, but got Unknown
		//IL_05a1: Expected Obj, but got I4
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_05cf: Expected Obj, but got VT
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected Obj, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected VT, but got Unknown
		//IL_0600: Expected F4, but got Obj
		//IL_05fb: Expected native int or pointer, but got VT
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_0628: Expected F4, but got Obj
		//IL_0623: Expected native int or pointer, but got VT
		//IL_063d: Expected F4, but got I
		//IL_0638: Expected native int or pointer, but got VT
		//IL_064a: Expected I4, but got VT
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0065: Expected F4, but got Obj
		//IL_0060: Expected native int or pointer, but got VT
		//IL_007a: Expected F4, but got I
		//IL_0075: Expected native int or pointer, but got VT
		//IL_0089: Expected I4, but got VT
		//IL_009c: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_066b: Expected Obj, but got I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0157: Expected F4, but got Obj
		//IL_0152: Expected native int or pointer, but got VT
		//IL_016c: Expected F4, but got I
		//IL_0167: Expected native int or pointer, but got VT
		//IL_017b: Expected I4, but got VT
		//IL_00dd: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01ea: Expected F4, but got Obj
		//IL_01e5: Expected native int or pointer, but got VT
		//IL_01ff: Expected F4, but got I
		//IL_01fa: Expected native int or pointer, but got VT
		//IL_020e: Expected I4, but got VT
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_023b: Expected F4, but got Obj
		//IL_0236: Expected native int or pointer, but got VT
		//IL_0250: Expected F4, but got I
		//IL_024b: Expected native int or pointer, but got VT
		//IL_025f: Expected I4, but got VT
		//IL_0281: Expected Obj, but got I4
		//IL_02af: Expected Obj, but got I4
		//IL_02f2: Expected Obj, but got I
		//IL_0302: Expected Obj, but got I
		//IL_0691: Expected I, but got Obj
		//IL_06a7: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I
		//IL_034c: Expected Obj, but got I
		//IL_0369: Expected I, but got Obj
		//IL_03b6: Expected I, but got Obj
		//IL_03cc: Expected Obj, but got I
		//IL_04fe: Expected I, but got Obj
		//IL_0514: Expected Obj, but got I
		//IL_03f7: Expected I, but got Obj
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected Obj, but got Unknown
		//IL_0756: Expected Obj, but got I4
		//IL_04ae: Expected Obj, but got I4
		//IL_0446: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I
		//IL_053f: Expected I, but got Obj
		//IL_0490: Expected Obj, but got I
		//IL_04a0: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 92;
		obj = friend;
		object obj3 = obj2 + 84;
		obj3 = 0;
		_isLocalUser = true;
		object obj4 = this - -64;
		object obj5 = obj2 + 80;
		obj5 = _cellBackgroundColorLocalUser;
		object obj6 = obj2 + 88;
		obj6 = obj5;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 96);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		object obj7 = obj2 - -64;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v16+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)obj4).rawPivot = (UIWidget.Pivot)matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		_friendRank.fontSize = fontSize;
		object obj8 = obj2 + 48;
		object obj9 = this + 12;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v21+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v23+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_friendRank.rawPivot = (UIWidget.Pivot)matrix4x;
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v29 (Il2CppClass<SocialManager>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v90 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		bool hasFacebookProfile = ((SocialManager)facebookDialogsSupported).HasFacebookProfile;
		_friendName.fontSize = (hasFacebookProfile ? 1 : 0);
		object obj11 = obj2 + 32;
		object obj12 = this + 12;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S2_v35+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v37+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_friendName.rawPivot = (UIWidget.Pivot)matrix4x;
		int bragScoreThreshold = PlayerSave.bragScoreThreshold;
		obj3 = bragScoreThreshold;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize2 = default;
		_friendScore.fontSize = fontSize2;
		object obj13 = obj2 + 16;
		object obj14 = this + 12;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S2_v50+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v46+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_friendScore.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj15 = this + 12;
		obj2 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S2_v60+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_unrankedBulletPoint.rawPivot = (UIWidget.Pivot)matrix4x;
		string text = _unrankedBulletPoint.tag;
		string text2 = (string)((backgroundActive ? 1 : 0) ^ 1);
		((GameObject)(object)text).tag = text2;
		string text3 = _friendRank.tag;
		((GameObject)(object)text3).tag = (string)backgroundActive;
		bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v37 (System.Boolean)+38]");
		ComputeShader computeShader;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v37 (System.Boolean)+38]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v76+14]");
			computeShader = (ComputeShader)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v37 (System.Boolean)+3C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v37 (System.Boolean)+3C]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v73+14]");
				computeShader = (ComputeShader)0;
			}
			else
			{
				computeShader = null;
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v86 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (computeShader.FindKernel(null) != 0)
		{
			nint num5 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v60 (Il2CppClass<SocialManager>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num6 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v65 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported3 = SocialManager.facebookDialogsSupported;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S2_v88 (System.Boolean)+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S2_v88 (System.Boolean)+38]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S2_v98+14]");
				object obj21 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S2_v88 (System.Boolean)+3C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S2_v88 (System.Boolean)+3C]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S2_v95+14]");
					object obj21 = 0;
				}
				else
				{
					object obj21 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		int num7 = Shader.PropertyToID("Unlit/Transparent Colored (AlphaClip)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		HideMedal();
		InitializeMedal();
		nint num8 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v46 (Il2CppClass<SocialManager>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num9 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v54 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported4 = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FriendHelperHighScore.OnLocalUserUpdated);
		object obj24 = action + 16;
		obj24 = this;
		((SocialManager)facebookDialogsSupported4).RemoveLocalUserUpdatedHandler(action);
		_initialized = true;
	}

	public unsafe void InitDummy(LeaderboardDummyData.LeaderboardDummy dummy, int ranking, bool backgroundActive)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected VT, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got VT
		//IL_005e: Expected F4, but got Obj
		//IL_0059: Expected native int or pointer, but got VT
		//IL_0430: Expected F4, but got Obj
		//IL_042b: Expected native int or pointer, but got VT
		//IL_0445: Expected F4, but got I
		//IL_0440: Expected native int or pointer, but got VT
		//IL_0452: Expected I4, but got VT
		//IL_0025: Expected Obj, but got VT
		//IL_003a: Expected F4, but got Obj
		//IL_0035: Expected native int or pointer, but got VT
		//IL_0095: Expected I4, but got Obj
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c2: Expected F4, but got Obj
		//IL_00bd: Expected native int or pointer, but got VT
		//IL_00d7: Expected F4, but got I
		//IL_00d2: Expected native int or pointer, but got VT
		//IL_00e6: Expected I4, but got VT
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0144: Expected F4, but got Obj
		//IL_013f: Expected native int or pointer, but got VT
		//IL_0159: Expected F4, but got I
		//IL_0154: Expected native int or pointer, but got VT
		//IL_0168: Expected I4, but got VT
		//IL_046f: Expected I, but got Obj
		//IL_0485: Expected Obj, but got I
		//IL_022a: Expected I, but got Obj
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_0306: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got I
		//IL_02ae: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 40;
		obj = ranking;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 48);
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 36;
		object obj5 = obj2 + 32;
		object obj6 = this + 100;
		obj6 = dummy;
		object obj7 = this - -64;
		if (backgroundActive)
		{
			obj3 = _cellBackgroundColorDark;
			obj5 = obj3;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		}
		else
		{
			obj3 = _cellBackgroundColorClear;
			obj4 = obj3;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		}
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)obj7).rawPivot = (UIWidget.Pivot)matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		_friendRank.fontSize = fontSize;
		Texture2D image = _friend.image;
		_friendName.fontSize = (int)image;
		object obj8 = this + 28;
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S2_v13+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_friendName.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj9 = dummy + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize2 = default;
		_friendScore.fontSize = fontSize2;
		object obj10 = this + 28;
		obj2 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S2_v26+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_friendScore.rawPivot = (UIWidget.Pivot)matrix4x;
		string text = _unrankedBulletPoint.tag;
		((GameObject)(object)text).tag = null;
		Friend friend = _friend;
		ComputeShader computeShader;
		if (friend.fbProfile != null)
		{
			FacebookProfile fbProfile = friend.fbProfile;
			computeShader = (ComputeShader)(object)fbProfile.image;
		}
		else if (friend.gcProfile != null)
		{
			GameCenterProfile gcProfile = friend.gcProfile;
			computeShader = (ComputeShader)(object)gcProfile.image;
		}
		else
		{
			computeShader = null;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v61 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (computeShader.FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dummy @ L1 (LeaderboardDummyData+LeaderboardDummy)+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dummy @ L1 (LeaderboardDummyData+LeaderboardDummy)+20]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S2_v61+14]");
				object obj13 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dummy @ L1 (LeaderboardDummyData+LeaderboardDummy)+1C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dummy @ L1 (LeaderboardDummyData+LeaderboardDummy)+1C]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S2_v58+14]");
					object obj13 = 0;
				}
				else
				{
					object obj13 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		int num3 = Shader.PropertyToID("Unlit/Transparent Colored (AlphaClip)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		HideMedal();
		InitializeMedal();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FriendHelperHighScore.OnFriendUpdatedHandler);
		object obj15 = action + 16;
		obj15 = this;
		_friend.updated -= action;
		_initialized = true;
	}

	private void ResizeNameIfNeeded()
	{
		CancelInvoke();
	}

	private void InitializeMedal()
	{
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_022c: Expected VT, but got Obj
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_0012: Expected VT, but got Obj
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_028c: Invalid comparison between F4 and Obj
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_02c6: Expected I, but got Obj
		//IL_02dc: Expected Obj, but got I
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected I4, but got Unknown
		//IL_014b: Expected I, but got Obj
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 12);
		GameObject gameObject = _friendScore.gameObject;
		transform.localPosition = (Vector3)gameObject;
		UILabel friendScore = _friendScore;
		object obj = transform - ((UIWidget)friendScore).mWidth;
		GameObject gameObject2 = _friendName.gameObject;
		transform2.localPosition = (Vector3)gameObject2;
		float num = (float)obj - 10f;
		UILabel friendName = _friendName;
		object obj2 = transform2 + ((UIWidget)friendName).mWidth;
		bool flag = _medal.isActiveAndEnabled;
		bool flag2 = !flag;
		object obj3 = obj2;
		if (!flag2)
		{
			UISprite medal = _medal;
			object obj4 = obj2 + ((UIWidget)medal).mWidth;
			obj3 = obj4;
		}
		if (_flag.isActiveAndEnabled)
		{
			UISprite flag3 = _flag;
			object obj5 = obj3 + ((UIWidget)flag3).mWidth;
			obj3 = obj5;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			return;
		}
		float width = (float)obj3 - num;
		UILabel friendName2 = _friendName;
		if (friendName2.mOverflow != UILabel.Overflow.ClampContent)
		{
			friendName2.mOverflow = UILabel.Overflow.ClampContent;
			((UIRect)friendName2).mChanged = true;
			friendName2.mShouldBeProcessed = true;
		}
		UILabel friendName3 = _friendName;
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S2_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S2_v17 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		int height = ((UIWidget)friendName3).mWidth - gUILayoutOption;
		_friendName.height = height;
		bool isValid = _friendName.isValid;
		_friendName.fontSize = (isValid ? 1 : 0);
		UILabel friendName4 = _friendName;
		if (friendName4.mOverflow != UILabel.Overflow.ResizeFreely)
		{
			friendName4.mOverflow = UILabel.Overflow.ResizeFreely;
			((UIRect)friendName4).mChanged = true;
			friendName4.mShouldBeProcessed = true;
		}
	}

	private void HideMedal()
	{
		//IL_03fe: Expected I, but got Obj
		//IL_0414: Expected Obj, but got I
		//IL_02d2: Expected I, but got Obj
		//IL_021c: Expected I, but got Obj
		//IL_0232: Expected Obj, but got I
		//IL_025d: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		bool flag = default;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj = default;
			if (obj == null)
			{
				OnDestroy();
				return;
			}
			if (~(_isLocalUser ? 1u : 0u) != 0)
			{
				if (_friend == null)
				{
					OnDestroy();
					return;
				}
				Friend friend = _friend;
				if (friend.fbProfile == null)
				{
					OnDestroy();
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
				Friend friend2 = _friend;
				FacebookProfile fbProfile = friend2.fbProfile;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				int num = default;
				if (num != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj2 = default;
					if ((nint)obj2 <= 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj3 = default;
						if ((nint)obj3 != -1)
						{
							((GameOverLeaderboardHandler)this).AddDummy(num, flag);
							return;
						}
					}
				}
				OnDestroy();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj4 = default;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj5 = default;
				if (obj5 != null)
				{
					nint num2 = (nint)typeof(TopRunRewardHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v46 (Il2CppClass<TopRunRewardHelper>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num3 = (nint)typeof(TopRunRewardHelper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v56 (Il2CppClass<TopRunRewardHelper>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CelebrationReward pendingReward = TopRunRewardHelper.GetPendingReward();
					if (pendingReward == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
						RefreshType refreshType = default;
						((FrontHighscoreLabel)this).OnAppHasRefreshed(refreshType);
						return;
					}
				}
			}
			nint num4 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v24 (Il2CppClass<TopRunRewardHelper>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num5 = (nint)typeof(TopRunRewardHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v39 (Il2CppClass<TopRunRewardHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CelebrationReward pendingReward2 = TopRunRewardHelper.GetPendingReward();
			if (pendingReward2 != null)
			{
				OnDestroy();
				return;
			}
			int num6 = default;
			if (num6 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj8 = default;
				if ((nint)obj8 <= 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj9 = default;
					if ((nint)obj9 != -1)
					{
						((GameOverLeaderboardHandler)this).AddDummy(num6, flag);
						return;
					}
				}
			}
		}
		OnDestroy();
	}

	private void SetMedalForRank(IRank rankData, IManager manager)
	{
		//IL_014b: Expected Obj, but got I
		//IL_0016: Expected Obj, but got I
		//IL_0028: Expected I, but got Obj
		//IL_003e: Expected Obj, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got VT
		//IL_0069: Expected I, but got Obj
		if ((string)(object)rankData != "TopRunUI")
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendHelperHighScore)+18]");
			_0021_00210 componentInChildren = (_0021_00210)((GameObject)0).GetComponentInChildren<T>();
			nint num = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v22 (Il2CppClass<SocialManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v30 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
			bool flag = ((SocialManager)facebookDialogsSupported).HasFacebookAccessToken();
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			bool gamecenterIsLoggedOut = ((SocialManager)facebookDialogsSupported2).gamecenterIsLoggedOut;
			((LogCategory)componentInChildren).LogFormat(null, 0, (string)gamecenterIsLoggedOut, 1, null, null);
		}
		else if ((string)(object)rankData != "LeaderboardUI" || (string)(object)rankData != "FriendsUI")
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendHelperHighScore)+18]");
			FriendsLoginFBButton component = ((GameObject)0).GetComponent<FriendsLoginFBButton>();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			string text = default;
			text.m_stringLength = (int)num3;
			_ = 0;
			object obj2 = text + 16;
			obj2 = this;
			((ListContentElementAdapter)(object)component)._002Ector((List<ListContentElement>)manager, (GameObject)1, (ScrollView)1, (CenterOnChild)null, text);
		}
	}

	private void SetTemporaryMedal(int rank)
	{
		//IL_0066: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = (Delegate)(object)_friendRank;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)rank);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 44;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	private void OnDestroy()
	{
		_flag.tag = null;
		_shadow.tag = null;
		_medal.tag = null;
	}

	public void Refresh()
	{
		//IL_0093: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got I4
		//IL_00d4: Expected I, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		if (~(_initialized ? 1u : 0u) != 0)
		{
			return;
		}
		if (~(_isLocalUser ? 1u : 0u) != 0)
		{
			if (!_isDummy)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				string text = default;
				text.m_stringLength = (int)num;
				_ = 0;
				object obj = text + 16;
				obj = this;
				RemoteNotificationControl.Enable((RemoteNotificationControl.RemoteNotificationsEnabledHandler)(object)_friend, text);
			}
			return;
		}
		nint num2 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v12 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		GameCenterProfile gameCenterProfile = default;
		gameCenterProfile.id = (string)num4;
		gameCenterProfile.image = (Texture2D)0;
		object obj3 = gameCenterProfile + 16;
		obj3 = this;
		((SocialManager)facebookDialogsSupported).OnGameCenterPhotoDownloaded(gameCenterProfile);
	}

	private void OnFriendUpdatedHandler()
	{
		OnLocalUserUpdated();
	}

	private void OnLocalUserUpdated()
	{
		//IL_018d: Expected I, but got Obj
		//IL_01a3: Expected Obj, but got I
		//IL_007d: Expected I, but got Obj
		Friend friend = _friend;
		ComputeShader computeShader;
		if (friend.fbProfile != null)
		{
			FacebookProfile fbProfile = friend.fbProfile;
			computeShader = (ComputeShader)(object)fbProfile.image;
		}
		else if (friend.gcProfile != null)
		{
			GameCenterProfile gcProfile = friend.gcProfile;
			computeShader = (ComputeShader)(object)gcProfile.image;
		}
		else
		{
			computeShader = null;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (computeShader.FindKernel(null) != 0)
		{
			Friend friend2 = _friend;
			if (friend2.fbProfile != null)
			{
				FacebookProfile fbProfile2 = friend2.fbProfile;
				Texture2D image = fbProfile2.image;
			}
			else if (friend2.gcProfile != null)
			{
				GameCenterProfile gcProfile2 = friend2.gcProfile;
				Texture2D image = gcProfile2.image;
			}
			else
			{
				Texture2D image = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	public FriendHelperHighScore()
	{
		//IL_0232: Expected I, but got Obj
		//IL_0248: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0273: Expected I, but got Obj
		//IL_0289: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00d9: Expected I, but got Obj
		//IL_0126: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I
		//IL_0167: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v37 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+38]");
		ComputeShader computeShader;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+38]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v35+14]");
			computeShader = (ComputeShader)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+3C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+3C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v32+14]");
				computeShader = (ComputeShader)0;
			}
			else
			{
				computeShader = null;
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (computeShader.FindKernel(null) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v19 (Il2CppClass<SocialManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v24 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v5 (System.Boolean)+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v5 (System.Boolean)+38]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S2_v15+14]");
			object obj7 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v5 (System.Boolean)+3C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v5 (System.Boolean)+3C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S2_v12+14]");
				object obj7 = 0;
			}
			else
			{
				object obj7 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}
}
