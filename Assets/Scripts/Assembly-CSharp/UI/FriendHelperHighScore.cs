using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TopRun;
using UnityEngine;

namespace UI;

public class FriendHelperHighScore : MonoBehaviour
{
	private readonly Color _localPlayerColor = (Color)4575657222473777152L;

	private readonly Color _friendColor = (Color)4480145589382721713L;

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

	private Color32 _cellBackgroundColorLocalUser = (Color32)9218261200999230219L;

	private Color32 _cellBackgroundColorClear;

	private Color32 _cellBackgroundColorDark = (Color32)2144250488;

	private Texture2D _dummyImage;

	private bool _isLocalUser;

	private bool _isDummy;

	private Friend _friend;

	private bool _initialized;

	public unsafe void InitLocalUser(int ranking, bool backgroundActive = false, bool isPlayerRanked = true)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_032d: Expected Obj, but got VT
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_0360: Expected Obj, but got VT
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected Obj, but got Unknown
		//IL_03b7: Expected Obj, but got VT
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected VT, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected I4, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0036: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected VT, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected VT, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected I4, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected VT, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected VT, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_048b: Expected I, but got Obj
		//IL_04b5: Expected I, but got Obj
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 112;
		_ = 0;
		_isLocalUser = true;
		object obj3 = _cellBackgroundColorLocalUser >> 16;
		object obj4 = obj3 & 0xFF;
		float num = (float)obj4 / 255f;
		object obj5 = _cellBackgroundColorLocalUser >> 24;
		float num2 = (float)obj5 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		_ = 0;
		object obj6 = _cellBackgroundColorLocalUser & 0xFF;
		float num3 = (float)obj6 / 255f;
		object obj7 = _cellBackgroundColorLocalUser >> 8;
		object obj8 = obj7 & 0xFF;
		float num4 = (float)obj8 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Color color = (Color)(obj + 72);
		_friendBackground.color = color;
		int num5 = obj + 108;
		string text = ((int*)num5)->ToString();
		_friendRank.text = text;
		object obj9 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendHelperHighScore)+14]");
		obj9 = 0;
		_ = _localPlayerColor;
		Color color2 = (Color)(obj + 56);
		_friendRank.color = color2;
		SocialManager instance = SocialManager.instance;
		string localUserName = instance.localUserName;
		_friendName.text = localUserName;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendHelperHighScore)+14]");
		_ = 0;
		_ = _localPlayerColor;
		Color color3 = (Color)(obj + 40);
		_friendName.color = color3;
		PlayerInfo instance2 = PlayerInfo.Instance;
		_ = instance2._highScore;
		int num6 = obj + 104;
		string text2 = ((int*)num6)->ToString();
		_friendScore.text = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendHelperHighScore)+14]");
		_ = 0;
		_ = _localPlayerColor;
		Color color4 = (Color)(obj + 24);
		_friendScore.color = color4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendHelperHighScore)+14]");
		_ = 0;
		_ = _localPlayerColor;
		Color color5 = (Color)(obj + 8);
		_unrankedBulletPoint.color = color5;
		GameObject gameObject = _unrankedBulletPoint.gameObject;
		bool active = (byte)((isPlayerRanked ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
		GameObject gameObject2 = _friendRank.gameObject;
		gameObject2.SetActive(isPlayerRanked);
		SocialManager instance3 = SocialManager.instance;
		object obj10;
		UnityEngine.Object obj11;
		if (instance3._fbProfile != null)
		{
			obj10 = instance3._fbProfile + 20;
		}
		else
		{
			bool flag = instance3._gcProfile == null;
			obj11 = null;
			if (flag)
			{
				goto IL_0440;
			}
			obj10 = instance3._gcProfile + 20;
		}
		obj11 = (UnityEngine.Object)obj10;
		goto IL_0440;
		IL_0440:
		bool flag2 = obj11 != null;
		UITexture friendPicture = _friendPicture;
		if (flag2)
		{
			SocialManager instance4 = SocialManager.instance;
			object obj12;
			Texture2D texture2D;
			if (instance4._fbProfile != null)
			{
				obj12 = instance4._fbProfile + 20;
			}
			else
			{
				bool flag3 = instance4._gcProfile == null;
				texture2D = null;
				if (flag3)
				{
					goto IL_0483;
				}
				obj12 = instance4._gcProfile + 20;
			}
			texture2D = (Texture2D)obj12;
		}
		else
		{
			Texture2D texture2D = _dummyImage;
		}
		goto IL_0483;
		IL_0483:
		nint num7 = (nint)friendPicture;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ S2_v35 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		UITexture friendPicture2 = _friendPicture;
		Shader shader = Shader.Find("Unlit/Transparent Colored (AlphaClip)");
		nint num8 = (nint)friendPicture2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v251 @ S2_v39 (Il2CppClass<UITexture>)+1A4] (should have been resolved before IL gen)");
		InitializeMedal();
		ResizeNameIfNeeded();
		SocialManager instance5 = SocialManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FriendHelperHighScore.OnLocalUserUpdated));
		instance5.AddLocalUserUpdatedHandler(action);
		_initialized = true;
	}

	public unsafe void InitFriend(Friend friend, int ranking, bool backgroundActive = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got VT
		//IL_0311: Expected Obj, but got VT
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_0342: Expected Obj, but got VT
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected VT, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected I4, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected VT, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected I4, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected VT, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_041b: Expected I, but got Obj
		//IL_0445: Expected I, but got Obj
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 96;
		_friend = friend;
		Color32 color;
		if (!backgroundActive)
		{
			object obj3 = _cellBackgroundColorClear & 0xFF;
			float num = (float)obj3 / 255f;
			object obj4 = obj + 72;
			color = _cellBackgroundColorClear;
		}
		else
		{
			object obj5 = _cellBackgroundColorDark & 0xFF;
			float num2 = (float)obj5 / 255f;
			object obj4 = obj + 56;
			color = _cellBackgroundColorDark;
		}
		object obj6 = color >> 24;
		float num3 = (float)obj6 / 255f;
		object obj7 = color >> 16;
		object obj8 = obj7 & 0xFF;
		float num4 = (float)obj8 / 255f;
		object obj9 = color >> 8;
		object obj10 = obj9 & 0xFF;
		float num5 = (float)obj10 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v13+8]");
		_ = 0;
		Color color2 = (Color)(obj + 40);
		_friendBackground.color = color2;
		int num6 = obj + 92;
		string text = ((int*)num6)->ToString();
		_friendRank.text = text;
		string text2 = _friend.name;
		_friendName.text = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendHelperHighScore)+24]");
		_ = 0;
		_ = _friendColor;
		Color color3 = (Color)(obj + 24);
		_friendName.color = color3;
		int num7 = friend + 12;
		string text3 = ((int*)num7)->ToString();
		_friendScore.text = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendHelperHighScore)+24]");
		_ = 0;
		_ = _friendColor;
		Color color4 = (Color)(obj + 8);
		_friendScore.color = color4;
		GameObject gameObject = _unrankedBulletPoint.gameObject;
		gameObject.SetActive(value: false);
		Friend friend2 = _friend;
		object obj11;
		UnityEngine.Object obj12;
		if (friend2.fbProfile != null)
		{
			obj11 = friend2.fbProfile + 20;
		}
		else
		{
			bool flag = friend2.gcProfile == null;
			obj12 = null;
			if (flag)
			{
				goto IL_03d0;
			}
			obj11 = friend2.gcProfile + 20;
		}
		obj12 = (UnityEngine.Object)obj11;
		goto IL_03d0;
		IL_0413:
		UITexture friendPicture;
		nint num8 = (nint)friendPicture;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ S2_v28 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		UITexture friendPicture2 = _friendPicture;
		Shader shader = Shader.Find("Unlit/Transparent Colored (AlphaClip)");
		nint num9 = (nint)friendPicture2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ S2_v32 (Il2CppClass<UITexture>)+1A4] (should have been resolved before IL gen)");
		InitializeMedal();
		ResizeNameIfNeeded();
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FriendHelperHighScore.OnFriendUpdatedHandler));
		_friend.AddUpdatedHandler(action);
		_initialized = true;
		return;
		IL_03d0:
		bool flag2 = obj12 != null;
		friendPicture = _friendPicture;
		if (flag2)
		{
			object obj13;
			Texture2D texture2D;
			if (friend.fbProfile != null)
			{
				obj13 = friend.fbProfile + 20;
			}
			else
			{
				bool flag3 = friend.gcProfile == null;
				texture2D = null;
				if (flag3)
				{
					goto IL_0413;
				}
				obj13 = friend.gcProfile + 20;
			}
			texture2D = (Texture2D)obj13;
		}
		else
		{
			Texture2D texture2D = _dummyImage;
		}
		goto IL_0413;
	}

	public unsafe void InitDummy(LeaderboardDummyData.LeaderboardDummy dummy, int ranking, bool backgroundActive)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_0229: Expected Obj, but got VT
		//IL_024c: Expected Obj, but got VT
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_027d: Expected Obj, but got VT
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected VT, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected I4, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected VT, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected I4, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected VT, but got Unknown
		//IL_017a: Expected I, but got Obj
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01b7: Expected I, but got Obj
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 96;
		_isDummy = true;
		Color32 color;
		if (!backgroundActive)
		{
			object obj3 = _cellBackgroundColorClear & 0xFF;
			float num = (float)obj3 / 255f;
			object obj4 = obj + 72;
			color = _cellBackgroundColorClear;
		}
		else
		{
			object obj5 = _cellBackgroundColorDark & 0xFF;
			float num2 = (float)obj5 / 255f;
			object obj4 = obj + 56;
			color = _cellBackgroundColorDark;
		}
		object obj6 = color >> 24;
		float num3 = (float)obj6 / 255f;
		object obj7 = color >> 16;
		object obj8 = obj7 & 0xFF;
		float num4 = (float)obj8 / 255f;
		object obj9 = color >> 8;
		object obj10 = obj9 & 0xFF;
		float num5 = (float)obj10 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v13+8]");
		_ = 0;
		Color color2 = (Color)(obj + 40);
		_friendBackground.color = color2;
		int num6 = obj + 92;
		string text = ((int*)num6)->ToString();
		_friendRank.text = text;
		_friendName.text = dummy.name;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendHelperHighScore)+24]");
		_ = 0;
		_ = _friendColor;
		Color color3 = (Color)(obj + 24);
		_friendName.color = color3;
		int num7 = dummy + 12;
		string text2 = ((int*)num7)->ToString();
		_friendScore.text = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FriendHelperHighScore)+24]");
		_ = 0;
		_ = _friendColor;
		Color color4 = (Color)(obj + 8);
		_friendScore.color = color4;
		GameObject gameObject = _unrankedBulletPoint.gameObject;
		gameObject.SetActive(value: false);
		UITexture friendPicture = _friendPicture;
		nint num8 = (nint)friendPicture;
		object obj11 = friendPicture + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ S2_v25 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		UITexture friendPicture2 = _friendPicture;
		Shader shader = Shader.Find("Unlit/Transparent Colored (AlphaClip)");
		nint num9 = (nint)friendPicture2;
		object obj12 = friendPicture2 + 232;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ S2_v30 (Il2CppClass<UITexture>)+1A4] (should have been resolved before IL gen)");
		InitializeMedal();
		ResizeNameIfNeeded();
		_initialized = true;
	}

	private void ResizeNameIfNeeded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_025b: Invalid comparison between Obj and F4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_01ad: Expected F8, but got I4
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Transform transform = _friendScore.transform;
		Vector3 localPosition = transform.localPosition;
		UILabel friendScore = _friendScore;
		object obj3 = obj - ((UIWidget)friendScore).mWidth;
		Transform transform2 = _friendName.transform;
		Vector3 localPosition2 = transform2.localPosition;
		UILabel friendName = _friendName;
		object obj4 = obj + ((UIWidget)friendName).mWidth;
		bool flag = _medal.enabled;
		bool flag2 = !flag;
		object obj5 = obj4;
		if (!flag2)
		{
			UISprite medal = _medal;
			object obj6 = obj4 + ((UIWidget)medal).mWidth;
			obj5 = obj6;
		}
		float num = (float)obj3 - 10f;
		if (_flag.enabled)
		{
			UISprite flag3 = _flag;
			object obj7 = obj5 + ((UIWidget)flag3).mWidth;
			obj5 = obj7;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num))
		{
			UILabel friendName2 = _friendName;
			if (friendName2.mOverflow != UILabel.Overflow.ClampContent)
			{
				friendName2.mOverflow = UILabel.Overflow.ClampContent;
				((UIRect)friendName2).mChanged = true;
				friendName2.mShouldBeProcessed = true;
			}
			UILabel friendName3 = _friendName;
			float num2 = (float)obj5 - num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num4 = default;
			double num3 = Math.Abs(num4);
			if (!(num3 < 2147483648.0))
			{
				num4 = -2147483648.0;
			}
			int width = (int)(((UIWidget)friendName3).mWidth - num4);
			friendName3.width = width;
			string processedText = _friendName.processedText;
			_friendName.text = processedText;
			UILabel friendName4 = _friendName;
			if (friendName4.mOverflow != UILabel.Overflow.ResizeFreely)
			{
				friendName4.mOverflow = UILabel.Overflow.ResizeFreely;
				((UIRect)friendName4).mChanged = true;
				friendName4.mShouldBeProcessed = true;
			}
		}
	}

	private void InitializeMedal()
	{
		IRank rankData;
		if (TopRunRoot.manager__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			if (obj != null)
			{
				if (~(_isLocalUser ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj2 = default;
					if (obj2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						object obj3 = default;
						if (obj3 != null && !TopRunRewardHelper.ShouldShowResults())
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
							int temporaryMedal = default;
							SetTemporaryMedal(temporaryMedal);
							return;
						}
					}
					IRank rank = default;
					if (!TopRunRewardHelper.ShouldShowResults() && rank != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						object obj4 = default;
						if ((nint)obj4 <= 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							object obj5 = default;
							if ((nint)obj5 != -1)
							{
								rankData = rank;
								goto IL_020d;
							}
						}
					}
				}
				else
				{
					Friend friend = _friend;
					if (_friend != null && friend.fbProfile != null)
					{
						Friend friend2 = _friend;
						FacebookProfile fbProfile = friend2.fbProfile;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
						IRank rank2 = default;
						if (rank2 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							object obj6 = default;
							if ((nint)obj6 <= 3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
								object obj7 = default;
								if ((nint)obj7 != -1)
								{
									rankData = rank2;
									goto IL_020d;
								}
							}
						}
					}
				}
			}
			HideMedal();
		}
		else
		{
			HideMedal();
		}
		return;
		IL_020d:
		SetMedalForRank(rankData, TopRunRoot.manager__BackingField);
	}

	private void HideMedal()
	{
		_flag.enabled = false;
		_shadow.enabled = false;
		_medal.enabled = false;
	}

	private void SetMedalForRank(IRank rankData, IManager manager)
	{
		//IL_005e: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string id = default;
		Country countryForID = CountryData.GetCountryForID(id);
		bool flag = countryForID == null;
		string text = null;
		if (!flag)
		{
			text = countryForID.flag__BackingField;
		}
		object obj;
		if (text != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_02d8;
			}
		}
		obj = 1;
		goto IL_02d8;
		IL_02d8:
		object obj2 = default;
		if (obj == null && (nint)obj2 >= 0 && (nint)obj2 <= 3)
		{
			_flag.spriteName = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text2 = default;
			string a = text2.ToLower();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text3 = default;
			string b = text3.ToLower();
			bool flag2 = string.Equals(a, b);
			bool flag3 = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			_flag.enabled = flag3;
			_shadow.enabled = flag3;
		}
		object obj3;
		bool flag4;
		if (obj2 != null)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 != 2)
				{
					if ((nint)obj2 == 3)
					{
						_medal.spriteName = "icon_bronze_medal";
						obj3 = this + 68;
						flag4 = true;
					}
					else
					{
						_medal.enabled = false;
						_flag.enabled = false;
						obj3 = this + 72;
						flag4 = false;
					}
				}
				else
				{
					_medal.spriteName = "icon_silver_medal";
					obj3 = this + 68;
					flag4 = true;
				}
			}
			else
			{
				_medal.spriteName = "icon_gold_medal";
				obj3 = this + 68;
				flag4 = true;
			}
		}
		else
		{
			_medal.spriteName = "icon_diamond_medal";
			obj3 = this + 68;
			flag4 = true;
		}
		((Behaviour)obj3).enabled = flag4;
	}

	private void SetTemporaryMedal(int rank)
	{
		_medal.enabled = true;
		_flag.enabled = false;
		_shadow.enabled = false;
		switch (rank)
		{
		case 0:
			_medal.spriteName = "icon_diamond_medal";
			break;
		case 1:
			_medal.spriteName = "icon_gold_medal";
			break;
		case 2:
			_medal.spriteName = "icon_silver_medal";
			break;
		case 3:
			_medal.spriteName = "icon_bronze_medal";
			break;
		default:
			_medal.enabled = false;
			break;
		}
	}

	private unsafe void OnDestroy()
	{
		if (~(_initialized ? 1u : 0u) == 0)
		{
			if (~(_isLocalUser ? 1u : 0u) == 0)
			{
				SocialManager instance = SocialManager.instance;
				Action action = default;
				action._002Ector(this, (nint)__ldftn(FriendHelperHighScore.OnLocalUserUpdated));
				instance.RemoveLocalUserUpdatedHandler(action);
			}
			else if (!_isDummy)
			{
				Action action2 = default;
				action2._002Ector(this, (nint)__ldftn(FriendHelperHighScore.OnFriendUpdatedHandler));
				_friend.RemoveUpdatedHandler(action2);
			}
		}
	}

	public void Refresh()
	{
		OnFriendUpdatedHandler();
	}

	private void OnFriendUpdatedHandler()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I4
		//IL_0163: Expected I, but got Obj
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		Friend friend = _friend;
		object obj;
		UnityEngine.Object obj2;
		if (friend.fbProfile != null)
		{
			obj = friend.fbProfile + 20;
		}
		else
		{
			bool flag = friend.gcProfile == null;
			obj2 = null;
			if (flag)
			{
				goto IL_0126;
			}
			obj = friend.gcProfile + 20;
		}
		obj2 = (UnityEngine.Object)obj;
		goto IL_0126;
		IL_0126:
		if (!(obj2 != null))
		{
			return;
		}
		UITexture friendPicture = _friendPicture;
		Friend friend2 = _friend;
		object obj3;
		object obj4;
		if (friend2.fbProfile != null)
		{
			obj3 = friend2.fbProfile + 20;
		}
		else
		{
			bool flag2 = friend2.gcProfile == null;
			obj4 = 0;
			if (flag2)
			{
				goto IL_015b;
			}
			obj3 = friend2.gcProfile + 20;
		}
		obj4 = obj3;
		goto IL_015b;
		IL_015b:
		nint num = (nint)friendPicture;
		object obj5 = friendPicture + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S2_v5 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
	}

	private void OnLocalUserUpdated()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_0161: Expected I, but got Obj
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		SocialManager instance = SocialManager.instance;
		object obj;
		UnityEngine.Object obj2;
		if (instance._fbProfile != null)
		{
			obj = instance._fbProfile + 20;
		}
		else
		{
			bool flag = instance._gcProfile == null;
			obj2 = null;
			if (flag)
			{
				goto IL_0124;
			}
			obj = instance._gcProfile + 20;
		}
		obj2 = (UnityEngine.Object)obj;
		goto IL_0124;
		IL_0124:
		if (!(obj2 != null))
		{
			return;
		}
		UITexture friendPicture = _friendPicture;
		SocialManager instance2 = SocialManager.instance;
		object obj3;
		object obj4;
		if (instance2._fbProfile != null)
		{
			obj3 = instance2._fbProfile + 20;
		}
		else
		{
			bool flag2 = instance2._gcProfile == null;
			obj4 = 0;
			if (flag2)
			{
				goto IL_0159;
			}
			obj3 = instance2._gcProfile + 20;
		}
		obj4 = obj3;
		goto IL_0159;
		IL_0159:
		nint num = (nint)friendPicture;
		object obj5 = friendPicture + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S2_v5 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
	}

	public FriendHelperHighScore()
	{
		//IL_000b: Expected VT, but got I4
		//IL_001a: Expected VT, but got I8
		//IL_0029: Expected VT, but got I8
		//IL_0038: Expected VT, but got I8
		_ = 4575657222459532967L;
		_ = 4575657222473777152L;
		base._002Ector();
	}
}
