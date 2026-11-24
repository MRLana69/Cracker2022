using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Utility;
using Missions;
using UnityEngine;

public class FriendHelperCrew : MonoBehaviour
{
	private static Action<int> m_OnFriendCoinsReceived;

	private GameObject _collectButton;

	private UILabel _collectButtonLabel;

	private GameObject _progress;

	private UILabel _friendName;

	private UITexture _friendPicture;

	private UISprite _friendBackground;

	private FriendCrewPokeHelper _pokeHelper;

	private Texture2D _dummyImage;

	private Texture2D _dummyFriendImage;

	private UISprite _coinpouchSprite;

	private Friend _friend;

	private CollectCoinsDummy _dummyFriend;

	private const int RUNS_TO_COLLECT = 25;

	private const int REWARD_MIN = 250;

	private const int REWARD_MAX = 350;

	private readonly Color32 CELL_BACKGROUND_COLOR_CLEAR;

	private readonly Color32 CELL_BACKGROUND_COLOR_DARK;

	private readonly Vector3 COLLECT_POSITION;

	private bool _isDummyFriend;

	private bool _hasAddedFriendUpdateHandler;

	public static event Action<int> OnFriendCoinsReceived
	{
		add
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Expected Obj, but got I4
			//IL_0026: Expected Obj, but got F4
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected Obj, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected Obj, but got Unknown
			//IL_008f: Expected Obj, but got I4
			//IL_009e: Expected Obj, but got F4
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected Obj, but got Unknown
			//IL_00eb: Expected Obj, but got I4
			//IL_00fa: Expected Obj, but got F4
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 24;
			obj = 0;
			_ = 0;
			obj = 80f;
			_ = -78f;
			_ = 0f;
			object obj3 = obj2 + 36;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			object obj4 = value + 40;
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11+8]");
			_ = 0;
			object obj5 = obj2 + 12;
			obj5 = 0;
			_ = 0;
			obj5 = 0f;
			_ = -78f;
			_ = 0f;
			obj3 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17+8]");
			_ = 0;
			object obj6 = value + 52;
			obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11+8]");
			_ = 0;
			obj2 = 0;
			_ = 0;
			obj2 = 0f;
			_ = -215f;
			_ = 0f;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj7 = value - -64;
			obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11+8]");
			_ = 0;
			_ = 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
		remove
		{
			Delegate onFriendCoinsReceived = FriendHelperCrew.m_OnFriendCoinsReceived;
			Action<int> onFriendCoinsReceived2 = default;
			while (true)
			{
				Delegate obj = onFriendCoinsReceived.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)FriendHelperCrew.m_OnFriendCoinsReceived == onFriendCoinsReceived)
				{
					FriendHelperCrew.m_OnFriendCoinsReceived = onFriendCoinsReceived2;
				}
				if ((object)FriendHelperCrew.m_OnFriendCoinsReceived != onFriendCoinsReceived)
				{
					onFriendCoinsReceived = FriendHelperCrew.m_OnFriendCoinsReceived;
					continue;
				}
				break;
			}
		}
	}

	public void InitDummyFriend(CollectCoinsDummy dummyFriend, bool backgroundActive = false)
	{
		//IL_0011: Expected Obj, but got I
		//IL_001c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHelperCrew)+70]");
		CoroutineUtil.StopCoroutine((Coroutine)0);
		((CoinEarnerVideoAds)this).SetStateGameObjectActive((GameObject)2);
	}

	public unsafe void InitFriend(Friend friend, bool backgroundActive = false)
	{
		//IL_04ca: Expected I, but got Obj
		//IL_04e0: Expected Obj, but got I
		//IL_066a: Expected Obj, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected VT, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_010d: Expected Obj, but got VT
		//IL_0122: Expected F4, but got Obj
		//IL_011d: Expected native int or pointer, but got VT
		//IL_0062: Expected I4, but got Obj
		//IL_0517: Expected F4, but got Obj
		//IL_0512: Expected native int or pointer, but got VT
		//IL_052c: Expected F4, but got I
		//IL_0527: Expected native int or pointer, but got VT
		//IL_053b: Expected I4, but got VT
		//IL_0549: Expected I, but got Obj
		//IL_055f: Expected Obj, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00fe: Expected F4, but got Obj
		//IL_00f9: Expected native int or pointer, but got VT
		//IL_058a: Expected Obj, but got I4
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_0135: Expected I, but got Obj
		//IL_05c4: Expected Obj, but got I4
		//IL_05d7: Expected I4, but got Obj
		//IL_01d1: Expected I, but got Obj
		//IL_0395: Expected Obj, but got I4
		//IL_03a8: Expected I, but got Obj
		//IL_03be: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I4
		//IL_0644: Expected I4, but got Obj
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_03e9: Expected I, but got Obj
		//IL_05f4: Expected I, but got Obj
		//IL_060a: Expected Obj, but got I
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_0489: Expected F4, but got Obj
		//IL_0484: Expected native int or pointer, but got VT
		//IL_049e: Expected F4, but got I
		//IL_0499: Expected native int or pointer, but got VT
		//IL_04a7: Expected Obj, but got VT
		//IL_06b2: Expected F4, but got I4
		//IL_06ad: Expected native int or pointer, but got VT
		//IL_06c5: Expected Obj, but got I4
		//IL_0348: Expected I4, but got Obj
		//IL_02e2: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v78 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (!((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			_coinpouchSprite.fillCenter = (byte)(int)"ic_lock" != 0;
		}
		object obj2 = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 40);
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 32;
		object obj5 = obj2 + 28;
		_isDummyFriend = true;
		object obj6 = this + 56;
		obj6 = friend;
		if (backgroundActive)
		{
			object obj7 = this - -64;
			obj3 = obj7;
			obj5 = obj3;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		}
		else
		{
			obj3 = CELL_BACKGROUND_COLOR_CLEAR;
			obj4 = obj3;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		}
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_friendBackground.rawPivot = (UIWidget.Pivot)matrix4x;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v20 (Il2CppClass<Strings>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v86 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, string> dictionary = Strings.DeserializeObject((string)friend.userid);
		if (dictionary == null)
		{
			((CollectCoinsDummy)(object)friend)._002Ector();
		}
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S2_v11 (Il2CppClass<Strings>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S2_v52 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault((string)friend.userid);
		_friendName.fontSize = (int)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		int num7 = Shader.PropertyToID("Unlit/Transparent Colored (AlphaClip)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		if (friend.score != 0)
		{
			_progress.tag = (string)1;
			_collectButton.tag = null;
			FriendProgressHelper component = _progress.GetComponent<FriendProgressHelper>();
			if (friend.meters >= 26)
			{
				int meters = friend.meters - 25;
				friend.meters = meters;
			}
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v67 (Il2CppClass<Strings>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num9 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v78 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string provider = Strings.GetDefault("TOPRUN_COLLECT_PROGRESS");
			((Matrix4x4*)(nint)matrix4x)->m00 = friend.meters;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj3 = 25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			object arg = default;
			string text2 = string.Format((IFormatProvider)(object)provider, format, arg);
			component.label.fontSize = (int)text2;
			float alpha = (float)friend.meters / 25f;
			component.slider.alpha = alpha;
		}
		else
		{
			_progress.tag = null;
			_collectButton.tag = (string)1;
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v38 (Il2CppClass<Strings>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num11 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v56 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text3 = Strings.GetDefault("TOPRUN_COLLECT_BUTTON_TITLE");
			_collectButtonLabel.fontSize = (int)text3;
			UIButtonMessage component2 = _collectButton.GetComponent<UIButtonMessage>();
			object obj12 = component2 + 12;
			string text4 = tag;
			obj12 = text4;
			int layer = _collectButton.layer;
			object obj13 = this + 68;
			obj3 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S2_v30+8]");
			_ = 0;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			Vector3 eulerAngles = ((Transform)matrix4x).eulerAngles;
		}
		_pokeHelper.OnClick();
	}

	public void CollectReward()
	{
		Delegate onFriendCoinsReceived = FriendHelperCrew.m_OnFriendCoinsReceived;
		Action<int> onFriendCoinsReceived2 = default;
		while (true)
		{
			Delegate obj = onFriendCoinsReceived.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			if ((object)FriendHelperCrew.m_OnFriendCoinsReceived == onFriendCoinsReceived)
			{
				FriendHelperCrew.m_OnFriendCoinsReceived = onFriendCoinsReceived2;
			}
			if ((object)FriendHelperCrew.m_OnFriendCoinsReceived != onFriendCoinsReceived)
			{
				onFriendCoinsReceived = FriendHelperCrew.m_OnFriendCoinsReceived;
				continue;
			}
			break;
		}
	}

	private unsafe int PayoutAndReturnReward()
	{
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected I4, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_03ef: Expected I, but got Obj
		//IL_0405: Expected Obj, but got I
		//IL_06da: Expected Obj, but got I
		//IL_049a: Expected Obj, but got I4
		//IL_0430: Expected I, but got Obj
		//IL_0227: Expected I, but got Obj
		//IL_023d: Expected Obj, but got I
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected Obj, but got Unknown
		//IL_073c: Expected I4, but got Obj
		//IL_075e: Expected Obj, but got I
		//IL_0776: Expected I, but got Obj
		//IL_078c: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I4
		//IL_0659: Expected Obj, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0155: Expected I4, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_07cc: Expected I4, but got Obj
		//IL_07cc: Expected Obj, but got I
		//IL_07fe: Expected Obj, but got I4
		//IL_0832: Expected Obj, but got I4
		//IL_0832: Expected Obj, but got I
		//IL_0268: Expected I, but got Obj
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05e9: Expected I4, but got Obj
		//IL_060b: Expected Obj, but got I
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected Obj, but got Unknown
		//IL_0642: Expected Obj, but got I
		//IL_04ad: Expected I, but got Obj
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02fc: Expected I4, but got Obj
		//IL_031e: Expected Obj, but got I
		//IL_0336: Expected I, but got Obj
		//IL_034c: Expected Obj, but got I
		//IL_0591: Expected I4, but got Obj
		//IL_0591: Expected Obj, but got I
		//IL_05ad: Expected Obj, but got I
		//IL_04fe: Expected Obj, but got I
		//IL_06a7: Expected I4, but got Obj
		//IL_06a7: Expected Obj, but got I
		//IL_06c3: Expected Obj, but got I
		//IL_01d5: Expected I, but got Obj
		//IL_03d7: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I4
		//IL_0377: Expected I, but got Obj
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 16);
		if ((nint)_friend > -1)
		{
			UITexture friendPicture = _friendPicture;
			Friend friend = _friend;
			UIRect.AnchorPoint leftAnchor = friendPicture.leftAnchor;
			if (System.Runtime.CompilerServices.Unsafe.As<Friend, UIntPtr>(ref friend) < System.Runtime.CompilerServices.Unsafe.As<UIRect.AnchorPoint, UIntPtr>(ref leftAnchor))
			{
				object obj2 = _friendPicture + 16;
				object obj3 = (object)_friend << 2;
				object obj4 = obj2 + obj3;
				object obj5 = obj4;
				string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v23+8]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v15 (System.String)+74]");
				if (num > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v23+14]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v23+14]");
						if ((nint)0 != 1)
						{
							GameObject progress = _progress;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
							GameObject progress2 = _progress;
							object obj6 = this + 116;
							obj = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S2_v70+8]");
							_ = 0;
							((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v78 (UnityEngine.GameObject)+18]");
							((UIWidget)0).rawPivot = pivot;
							GameObject progress3 = _progress;
							nint num2 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v110 (Il2CppClass<Strings>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num3 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v118 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string text = Strings.GetDefault("INGAME_UI_HIGHSCORE");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v81 (UnityEngine.GameObject)+18]");
							((UILabel)0).fontSize = (int)text;
							GameObject progress4 = _progress;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v84 (UnityEngine.GameObject)+20]");
							((Component)0).tag = null;
						}
						else
						{
							nint num4 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj8 = (nint)0 & (nint)0x200;
							if (obj8 != null)
							{
								nint num5 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v97 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v23+C]");
							int num6 = ((ComputeShader)0).FindKernel(null);
							GameObject progress5 = _progress;
							if (num6 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
							}
							GameObject progress6 = _progress;
							object obj9 = this + 116;
							obj = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S2_v49+8]");
							_ = 0;
							((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v64 (UnityEngine.GameObject)+18]");
							((UIWidget)0).rawPivot = pivot;
							GameObject progress7 = _progress;
							nint num7 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S1_v82 (Il2CppClass<Strings>)+BA]");
							object obj10 = (nint)0 & (nint)0x200;
							if (obj10 != null)
							{
								nint num8 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v91 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string text2 = Strings.GetDefault("INGAME_UI_HIGHSCORE");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v67 (UnityEngine.GameObject)+18]");
							((UILabel)0).fontSize = (int)text2;
							GameObject progress8 = _progress;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S0_v70 (UnityEngine.GameObject)+20]");
							((Component)0).tag = null;
							StayInOneLaneMission instance = StayInOneLaneMission.instance;
							((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)18, (PersistentAwardProgress)1, (Action<Award>)(-1));
						}
					}
					else
					{
						nint num9 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num10 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v61 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v23+C]");
						int num11 = ((ComputeShader)0).FindKernel(null);
						GameObject progress9 = _progress;
						object obj12;
						if (num11 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
							obj12 = 1;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
							obj12 = 0;
						}
						GameObject progress10 = _progress;
						object obj13 = this + 100;
						obj = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S2_v23+8]");
						_ = 0;
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v44 (UnityEngine.GameObject)+18]");
						((UIWidget)0).rawPivot = pivot;
						GameObject progress11 = _progress;
						nint num12 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S1_v45 (Il2CppClass<Strings>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num13 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v55 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text3 = Strings.GetDefault("INGAME_UI_HIGHSCORE");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v47 (UnityEngine.GameObject)+18]");
						((UILabel)0).fontSize = (int)text3;
						GameObject progress12 = _progress;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v23+10]");
						bool flag = (nint)0 != 0;
						object obj15 = (flag ? 1 : 0) ^ 1;
						object obj16 = obj12 & obj15;
						bool flag2 = obj16 != null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v50 (UnityEngine.GameObject)+20]");
						((Component)0).tag = (string)flag2;
					}
					GameObject progress13 = _progress;
					object obj17 = this + 84;
					obj = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S2_v7+8]");
					_ = 0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v32 (UnityEngine.GameObject)+14]");
					((UIWidget)0).rawPivot = pivot;
					GameObject progress14 = _progress;
					object obj18 = obj5 + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S0_v35 (UnityEngine.GameObject)+14]");
					int fontSize = default;
					((UILabel)0).fontSize = fontSize;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v23+8]");
					_coinpouchSprite = (UISprite)0;
					return 1;
				}
				return 0;
			}
			return 0;
		}
		return 0;
	}

	public void Refresh()
	{
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected Obj, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected Obj, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected Obj, but got Unknown
		//IL_064a: Expected Obj, but got I4
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected Obj, but got Unknown
		//IL_0661: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I4
		//IL_02e6: Expected I, but got Obj
		//IL_02fc: Expected Obj, but got I
		//IL_0741: Expected Obj, but got I4
		//IL_005a: Expected I, but got Obj
		//IL_0070: Expected Obj, but got I
		//IL_0327: Expected I, but got Obj
		//IL_069b: Expected Obj, but got I4
		//IL_06ae: Expected Obj, but got I4
		//IL_0394: Expected I, but got Obj
		//IL_03aa: Expected Obj, but got I
		//IL_0101: Expected I4, but got Obj
		//IL_009b: Expected I, but got Obj
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_07c0: Expected Obj, but got I4
		//IL_07db: Expected Obj, but got I4
		//IL_03d5: Expected I, but got Obj
		//IL_06d3: Expected I4, but got Obj
		//IL_044a: Expected I4, but got Obj
		//IL_01d2: Expected Obj, but got I4
		//IL_01f8: Expected I, but got Obj
		//IL_020e: Expected Obj, but got I
		//IL_0168: Expected I, but got Obj
		//IL_0823: Expected Obj, but got I4
		//IL_0853: Expected I, but got Obj
		//IL_0869: Expected Obj, but got I
		//IL_089c: Expected I4, but got Obj
		//IL_0239: Expected I, but got Obj
		//IL_052e: Expected Obj, but got I4
		//IL_053c: Expected I, but got Obj
		//IL_0552: Expected Obj, but got I
		//IL_04c4: Expected I, but got Obj
		//IL_08be: Expected I, but got Obj
		//IL_08d4: Expected Obj, but got I
		//IL_057d: Expected I, but got Obj
		//IL_05ca: Expected I, but got Obj
		GameOverOfflineHelper gameOverOfflineHelper = default;
		string text = (string)(gameOverOfflineHelper + 28);
		object obj = gameOverOfflineHelper + 16;
		object obj2 = gameOverOfflineHelper + 12;
		object obj3 = gameOverOfflineHelper + 24;
		obj3 = 0;
		object obj4 = gameOverOfflineHelper + 20;
		obj4 = 0;
		OnboardingSave.hasShownCollectPopup = true;
		if (~(_isDummyFriend ? 1u : 0u) == 0)
		{
			IEnumerator enumerator = ((BoardAnimation)null).BoardFloating();
			obj3 = enumerator;
			_progress.tag = (string)1;
			_collectButton.tag = null;
			FriendProgressHelper component = _progress.GetComponent<FriendProgressHelper>();
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v63 (Il2CppClass<Strings>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v81 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string provider = Strings.GetDefault("TOPRUN_COLLECT_PROGRESS");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = 25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			object arg = default;
			string text2 = string.Format((IFormatProvider)(object)provider, format, arg);
			component.label.fontSize = (int)text2;
			component.slider.alpha = 0f;
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v96 (Il2CppClass<UIScreenController>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v114 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			gameOverOfflineHelper.HandleColliders((byte)(int)component != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			text = (string)(object)gameOverOfflineHelper;
			text.m_stringLength = (int)(nint)((UnityEngine.Object)gameOverOfflineHelper).m_CachedPtr;
			int missionIndex = default;
			((UIScreenController)flag).OnMissionCompleted(text, missionIndex);
			CollectCoinsDummy dummyFriend = _dummyFriend;
			dummyFriend.hasBeenCollected = true;
			nint num5 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v105 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v110 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveManager.Load();
			return;
		}
		if (_friend == null)
		{
			SDebug.LogFormat("FriendHelperCrew.CollectReward called for non-dummy friend, but _friend is not set", (object[])(object)this);
			return;
		}
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)28, (PersistentAwardProgress)1, (Action<Award>)(-1));
		nint num7 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v29 (Il2CppClass<SocialManager>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v78 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Friend friend = _friend;
		Friend.Status status = friend.status;
		status.gamesCashedIn = friend.games;
		IEnumerator enumerator2 = ((BoardAnimation)null).BoardFloating();
		obj4 = enumerator2;
		_progress.tag = (string)1;
		_collectButton.tag = null;
		FriendProgressHelper component2 = _progress.GetComponent<FriendProgressHelper>();
		nint num9 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v23 (Il2CppClass<Strings>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v51 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string provider2 = Strings.GetDefault("TOPRUN_COLLECT_PROGRESS");
		Friend friend2 = _friend;
		Friend.Status status2 = friend2.status;
		if (friend2.games < status2.gamesCashedIn)
		{
			Friend.Status status3 = friend2.status;
			status3.gamesCashedIn = friend2.games;
		}
		Friend.Status status4 = friend2.status;
		object obj10 = friend2.games - status4.gamesCashedIn;
		obj = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 25;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format2 = default;
		object arg2 = default;
		string text3 = string.Format((IFormatProvider)(object)provider2, format2, arg2);
		component2.label.fontSize = (int)text3;
		Friend friend3 = _friend;
		Friend.Status status5 = friend3.status;
		if (friend3.games < status5.gamesCashedIn)
		{
			Friend.Status status6 = friend3.status;
			status6.gamesCashedIn = friend3.games;
		}
		Friend.Status status7 = friend3.status;
		object obj11 = friend3.games - status7.gamesCashedIn;
		float alpha = (float)obj11 / 25f;
		component2.slider.alpha = alpha;
		nint num11 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v50 (Il2CppClass<UIScreenController>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num12 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v74 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		gameOverOfflineHelper.HandleColliders((byte)(int)component2 != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		text = (string)(object)gameOverOfflineHelper;
		text.m_stringLength = (int)(nint)((UnityEngine.Object)gameOverOfflineHelper).m_CachedPtr;
		int missionIndex2 = default;
		((UIScreenController)flag2).OnMissionCompleted(text, missionIndex2);
		nint num13 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v57 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num14 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S0_v70 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
		nint num15 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S0_v63 (Il2CppClass<Flurry>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num16 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v66 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void OnFriendUpdatedHandler()
	{
		OnDestroy();
	}

	private void OnDestroy()
	{
		//IL_02c0: Expected I, but got Obj
		//IL_02d6: Expected Obj, but got I
		//IL_00a9: Expected I, but got Obj
		//IL_01df: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_0220: Expected I, but got Obj
		//IL_027d: Expected I4, but got Obj
		if (_friend != null)
		{
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
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
			Texture2D image2 = _friend.image;
			if ((object)image2 == null || ((UnityEngine.Object)image2).m_CachedPtr == (IntPtr)0)
			{
				return;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_friendName).FindKernel((string)null) != 0)
			{
				Texture2D image3 = _friend.image;
				_friendName.fontSize = (int)image3;
			}
		}
		else
		{
			SDebug.LogFormat("FriendHelperCrew.OnFriendUpdatedHandler called but _friend is not set", (object[])(object)this);
		}
	}

	public FriendHelperCrew()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		if (~(_hasAddedFriendUpdateHandler ? 1u : 0u) == 0)
		{
			if (_friend != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				string text = default;
				text.m_stringLength = (int)num;
				_ = 0;
				object obj = text + 16;
				obj = this;
				RemoteNotificationControl.Enable((RemoteNotificationControl.RemoteNotificationsEnabledHandler)(object)_friend, text);
				_hasAddedFriendUpdateHandler = false;
			}
			else
			{
				SDebug.LogFormat("FriendHelperCrew.OnDestroy called but _friend is not set and we have a handler to remove", (object[])(object)this);
			}
		}
	}
}
