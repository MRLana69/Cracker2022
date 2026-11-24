using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Subway;
using SYBO.Subway.Info;
using TopRun;
using UnityEngine;

public class FriendGhostHandler : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Challenger> _003C_003E9__31_0;

		public static Comparison<Challenger> _003C_003E9__32_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			BundlePurchaseButton._003C_003Ec obj = default;
			BundlePurchaseButton._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal int _003CGetCombinedAndSortedChallengers_003Eb__31_0(Challenger x, Challenger y)
		{
			//IL_0017: Expected I4, but got Obj
			return (object)y.ProfilePicture - (object)x.ProfilePicture;
		}

		internal int _003CGetSortedFriends_003Eb__32_0(Challenger x, Challenger y)
		{
			return y.Score - x.Score;
		}
	}

	private IManager _tournamentManager;

	public CharacterAvatars dummies;

	public FriendGhostHelper helper;

	public Texture dummyImage;

	private Challenger[] challengersDescending;

	private Challenger currentChallenger;

	private List<IPlayer> topRunPlayers;

	private bool _localUserHighscoreInserted;

	private bool _localUserTopRunInserted;

	private bool _insertedAnyUser;

	private bool _passedLocalHighScore;

	private bool _passedLocalTopRunScore;

	private bool _gameRunning;

	private int _currentThreshold;

	private int _currentChallengerIndex;

	private int _localHighestScore;

	private int _localTopRunScore;

	private int _numberOfCharactersInScore;

	private Color localPlayerColor;

	private Color friendColor;

	private Color topRunHighscoreTitleColor;

	private Color normalHighScoreTitleColor;

	private void Init()
	{
		CancelInvoke();
	}

	private unsafe void OnDestroy()
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00ec: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FriendGhostHandler.NewGame);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v36 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<bool> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		nint num4 = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27 (Il2CppClass<Info.Settings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v32 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Settings.onTopRunChallengerSettingChanged -= action2;
	}

	private unsafe void Awake()
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<bool, bool, bool, bool> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v36 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnRunStarted += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(FriendGhostHandler.RefreshListOnSettingsChanged);
		object obj3 = action2 + 16;
		obj3 = this;
		nint num4 = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27 (Il2CppClass<Info.Settings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v32 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Settings.onSfxSettingChanged += action2;
	}

	public void NewGame()
	{
		OnDestroy();
		Update();
	}

	private int GetDummyPlayerScore()
	{
		//IL_0007: Expected I4, but got Obj
		return (int)currentChallenger;
	}

	private bool IsTopRunTournamentRunning()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_0374: Expected Obj, but got I4
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_03a4: Expected I, but got Obj
		//IL_03ba: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I
		//IL_04d3: Expected I, but got Obj
		//IL_04e9: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_041f: Expected Obj, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_031e: Expected I, but got Obj
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(LeaderboardDummyData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<LeaderboardDummyData>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(LeaderboardDummyData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v125 (Il2CppClass<LeaderboardDummyData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		bool flag = true;
		object obj6 = default;
		object obj7 = default;
		bool result = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v111+C]");
				if (0 > (nint)obj7)
				{
					bool flag2 = (byte)((flag ? 1u : 0u) + 1u) != 0;
					flag = flag2;
					continue;
				}
				object obj8 = obj4 + 4;
				object obj9 = obj8 + 1;
				obj8 = obj9;
				object obj10 = obj9 << 2;
				object obj11 = obj4 + obj10;
				obj11 = 82;
				result = flag;
				break;
			}
			object obj12 = obj4 + 4;
			object obj13 = obj12 + 1;
			obj12 = obj13;
			object obj14 = obj13 << 2;
			object obj15 = obj4 + obj14;
			obj15 = 69;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj4 + obj16;
			if ((nint)obj17 == 82)
			{
				object obj18 = obj4 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_04c0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj4 + obj20;
			if ((nint)obj21 == 69)
			{
				object obj22 = obj4 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_04c5;
			}
		}
		object obj24 = default;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_04c5;
		IL_04c0:
		return result;
		IL_04c5:
		nint num3 = (nint)typeof(LeaderboardDummyData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v47 (Il2CppClass<LeaderboardDummyData>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num4 = (nint)typeof(LeaderboardDummyData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v58 (Il2CppClass<LeaderboardDummyData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<LeaderboardDummyData.LeaderboardDummy> dummyData = LeaderboardDummyData.dummyData;
		bool flag3 = (byte)(dummyData._size + 1) != 0;
		result = flag3;
		goto IL_04c0;
	}

	private void RefreshListOnSettingsChanged(bool settingValue)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		object obj = this + 20;
		obj = settingValue;
		((Collider)(object)dummies).isTrigger = true;
		((GameObject)(object)_tournamentManager).tag = (string)1;
	}

	private Challenger[] GetFriends()
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_0083: Expected Obj, but got I4
		object obj = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj2 = default;
		obj = obj2;
		if (_tournamentManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj3 = default;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj4 = default;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj5 = default;
					if (obj5 == null)
					{
						return (Challenger[])1;
					}
				}
			}
		}
		return null;
	}

	private Challenger[] GetTopRunPlayers()
	{
		//IL_01e3: Expected I, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_03a1: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_00c3: Expected I, but got Obj
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_01b1: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v63 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<Characters.CharacterId> availableCharacterTokens = MysteryBox.GetAvailableCharacterTokens();
		object obj2 = availableCharacterTokens | 2;
		bool flag = (nint)obj2 == 3;
		string dataPath = Application.dataPath;
		bool flag2 = (nint)dataPath != 8;
		bool flag3 = false;
		if (!flag2)
		{
			object obj3 = availableCharacterTokens | 1;
			flag3 = (nint)obj3 == 3;
		}
		object obj4 = flag3 | flag;
		bool flag4 = obj4 == null;
		Friend[] array2 = default;
		Friend[] array = array2;
		if (!flag4)
		{
			nint num3 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v49 (Il2CppClass<SocialManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v56 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
			Friend[] array3 = ((SocialManager)facebookDialogsSupported).FriendsSortedByCash();
			array = array3;
		}
		object obj6 = array + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj7 = 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj8 = array + 16;
			object obj9 = obj7 << 2;
			object obj10 = obj8 + obj9;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v35+20]");
			if ((nint)0 != 0)
			{
				object obj13 = default;
				object obj12 = obj13 + 12;
				object obj14 = array + 16;
				object obj15 = obj7 << 2;
				object obj16 = obj14 + obj15;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v38+20]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v39+14]");
				obj12 = 0;
			}
			_ = 1;
			object obj19 = array + 16;
			object obj20 = obj7 << 2;
			object obj21 = obj19 + obj20;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v26+C]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		Challenger[] result = default;
		return result;
	}

	private Challenger[] GetCombinedAndSortedChallengers(Challenger[] friends, Challenger[] topRuns)
	{
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)friends))
		{
			((Component)(object)friends).tag = (string)(object)topRuns;
			return (Challenger[])1;
		}
		return null;
	}

	private Challenger[] GetSortedFriends()
	{
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02bf: Expected Obj, but got I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_025a: Expected Obj, but got I4
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		object obj = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<IPlayer> list = default;
		list._002Ector();
		if (_tournamentManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj3 = default;
			if (obj3 != null)
			{
				object obj4 = 0;
				object obj5 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S3_v23 (Il2CppMethodInfo)+C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S3_v24+60]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S3_v25+38]");
					object obj8 = 0;
					object obj9 = obj8 & 0x1FFF;
					object obj10 = obj9 + 113696;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v79 @ S4_v18 (should have been resolved before IL gen)");
					object obj11 = obj4 + 1;
					obj4 = obj11;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA9");
		object obj13 = default;
		object obj12 = obj13 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj14 = 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj15 = obj13 + 16;
			object obj16 = obj14 << 2;
			object obj17 = obj15 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj18 = default;
			if (obj18 != null)
			{
				object obj20 = default;
				object obj19 = obj20 + 12;
				object obj21 = obj13 + 16;
				object obj22 = obj14 << 2;
				object obj23 = obj21 + obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v41+14]");
				obj19 = 0;
			}
			object obj24 = obj13 + 16;
			object obj25 = obj14 << 2;
			object obj26 = obj24 + obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj28 = default;
			object obj27 = obj28 & 1;
			object obj29 = obj13 + 16;
			object obj30 = obj14 << 2;
			object obj31 = obj29 + obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		bool flag = _tournamentManager == null;
		_0021_00210[] array = default;
		_0021_00210[] result = array;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num2 = 0;
			_ = 0;
			Predicate<_0021_00210> predicate = default;
			object obj32 = predicate + 16;
			obj32 = this;
			int num3 = Array.FindIndex<T>((T[])(object)array, (Predicate<T>)(object)predicate);
			result = (_0021_00210[])num3;
		}
		return (Challenger[])(object)result;
	}

	private int getNextChallengerWithHigherScoreIndex(Challenger[] sortedChallengerList, int thisPlayerScore)
	{
		//IL_012f: Expected Obj, but got I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_016f: Expected I4, but got Obj
		//IL_0189: Expected I4, but got Obj
		//IL_0189: Expected I4, but got Obj
		//IL_0189: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_023a: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_01fd: Expected I, but got Obj
		//IL_0213: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		object obj = thisPlayerScore + 12;
		object obj2 = sortedChallengerList + 12;
		object obj3 = obj + obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Array array = default;
		Array.ConstrainedCopy(sortedChallengerList, 0, array, 0, (int)obj2);
		Array.ConstrainedCopy((Array)thisPlayerScore, 0, array, (int)obj2, (int)obj);
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v8 (Il2CppClass<FriendGhostHandler+<>c>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v46 (Il2CppClass<FriendGhostHandler+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__31_0 == null;
		bool flag2 = !flag;
		Comparison<Challenger> comparison = _003C_003Ec._003C_003E9__31_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v20 (Il2CppClass<FriendGhostHandler+<>c>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v40 (Il2CppClass<FriendGhostHandler+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Comparison<Challenger> comparison2 = default;
			object obj6 = comparison2 + 16;
			obj6 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v37 (Il2CppClass<FriendGhostHandler+<>c>)+5C]");
			object obj7 = (nint)0 + (nint)4;
			obj7 = comparison2;
			comparison = comparison2;
		}
		Array.Sort((Challenger[])array, comparison);
		return (int)array;
	}

	private void Update()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_00b7: Expected VT, but got Obj
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_0185: Expected I4, but got Obj
		int bragScoreThreshold = PlayerSave.bragScoreThreshold;
		_localHighestScore = bragScoreThreshold;
		_gameRunning = true;
		_localUserHighscoreInserted = false;
		_localUserTopRunInserted = false;
		_passedLocalHighScore = false;
		_passedLocalTopRunScore = false;
		_currentThreshold = 0;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		((GameStats)(object)privacyPolicyUrl).ResetRun();
		helper.Reset();
		object obj = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj2 = default;
		obj = obj2;
		if (_tournamentManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			int localTopRunScore = default;
			_localTopRunScore = localTopRunScore;
		}
		if (OnboardingSave.numberOfRunsSinceLastGuideline == 0)
		{
			return;
		}
		object obj3 = this + 28;
		CharacterAvatars characterAvatars = dummies;
		Challenger[] array = characterAvatars.characterAvatars.ToArray();
		obj3 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list).Add((T)challengersDescending);
		bool flag = ((FriendGhostHandler)null).IsTopRunTournamentRunning();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		int bragScoreThreshold2 = PlayerSave.bragScoreThreshold;
		Challenger challenger = default;
		challenger.Score = bragScoreThreshold2;
		object obj4 = challenger + 12;
		Texture texture = dummyImage;
		if ((object)dummyImage != null)
		{
			if ((object)texture.GetType() != typeof(Texture2D))
			{
				texture = null;
			}
		}
		else
		{
			texture = null;
		}
		obj4 = texture;
		int index = (flag ? 1 : 0) - 1;
		((List<Challenger>)(object)list).Insert(index, challenger);
		object obj5 = this + 28;
		Challenger[] array2 = ((List<Challenger>)(object)list).ToArray();
		obj5 = array2;
		string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
		Challenger[] array3 = challengersDescending;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S3_v6 (System.String)+74]");
		int currentChallengerIndex = ((FriendGhostHandler)null).CalculateGapToFriendsScore((int)array3, 0);
		_currentChallengerIndex = currentChallengerIndex;
		helper.AnimateIn();
		ScaleHelperBackground();
		FriendGhostHelper friendGhostHelper = helper;
		if (~(friendGhostHelper.noFriendsLeftToGhost ? 1u : 0u) != 0)
		{
			friendGhostHelper.currentAnimationState = FriendGhostHelper.AnimatingState.AnimatingIn;
		}
	}

	private int CalculateGapToFriendsScore(int scoreTo, int currentScore)
	{
		//IL_00a4: Expected Obj, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		if (scoreTo != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [scoreTo @ L1 (System.Int32)+C]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [scoreTo @ L1 (System.Int32)+C]");
			int num = 0;
			if (!flag)
			{
				int num2;
				bool flag2;
				do
				{
					num2 = num - 1;
					if (num2 < 0)
					{
						return -1;
					}
					object obj = scoreTo + 16;
					int num3 = num2 << 2;
					object obj2 = obj + num3;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16+8]");
					flag2 = (nint)0 <= (nint)currentScore;
					num = num2;
				}
				while (flag2);
				return num2;
			}
			return -1;
		}
		return -1;
	}

	private void PassThreshold()
	{
		//IL_0149: Expected Obj, but got I4
		//IL_0183: Expected I4, but got Obj
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_04b7: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I
		//IL_029f: Expected I4, but got Obj
		//IL_037e: Expected I4, but got Obj
		//IL_0440: Expected Obj, but got I
		//IL_0476: Expected I4, but got Obj
		FriendGhostHelper friendGhostHelper = helper;
		if (friendGhostHelper.currentAnimationState == FriendGhostHelper.AnimatingState._notset || (friendGhostHelper.currentAnimationState != FriendGhostHelper.AnimatingState.OnScreen && (friendGhostHelper.currentAnimationState == FriendGhostHelper.AnimatingState.OffScreen || (friendGhostHelper.currentAnimationState != FriendGhostHelper.AnimatingState.AnimatingIn && friendGhostHelper.currentAnimationState == FriendGhostHelper.AnimatingState.AnimatingOut))) || ~(_gameRunning ? 1u : 0u) != 0)
		{
			return;
		}
		FriendGhostHelper friendGhostHelper2 = helper;
		if (~(friendGhostHelper2.noFriendsLeftToGhost ? 1u : 0u) == 0 || OnboardingSave.numberOfRunsSinceLastGuideline == 0)
		{
			return;
		}
		bool flag = friendGhostHelper.currentAnimationState == FriendGhostHelper.AnimatingState.OnScreen;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v6 (System.String)+74]");
		bool flag2 = (nint)0 > (nint)_currentThreshold;
		object obj = flag & flag2;
		if (obj != null)
		{
			FriendGhostHelper friendGhostHelper3 = helper;
			friendGhostHelper3.points.fontSize = (int)"0";
			FriendGhostHelper friendGhostHelper4 = helper;
			if (~(friendGhostHelper4._gameRunning ? 1u : 0u) == 0)
			{
				friendGhostHelper4.currentAnimationState = FriendGhostHelper.AnimatingState.AnimatingOut;
			}
		}
		else
		{
			if (~(_insertedAnyUser ? 1u : 0u) != 0)
			{
				return;
			}
			string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
			if (~(_localUserHighscoreInserted ? 1u : 0u) == 0 && !_passedLocalHighScore)
			{
				int localHighestScore = _localHighestScore;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v27 (System.String)+74]");
				if ((nint)localHighestScore < (nint)0)
				{
					_passedLocalHighScore = true;
				}
				else
				{
					FriendGhostHelper friendGhostHelper5 = helper;
					int localHighestScore2 = _localHighestScore;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v27 (System.String)+74]");
					object obj2 = (nint)localHighestScore2 - (nint)0;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					object[] array = default;
					string text = string.Concat(array);
					friendGhostHelper5.points.fontSize = (int)text;
				}
			}
			else if (~(_localUserTopRunInserted ? 1u : 0u) == 0 && ~(_passedLocalTopRunScore ? 1u : 0u) != 0)
			{
				int localTopRunScore = _localTopRunScore;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v27 (System.String)+74]");
				if ((nint)localTopRunScore < (nint)0)
				{
					_passedLocalTopRunScore = true;
				}
				else
				{
					FriendGhostHelper friendGhostHelper6 = helper;
					int localTopRunScore2 = _localTopRunScore;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v27 (System.String)+74]");
					object obj4 = (nint)localTopRunScore2 - (nint)0;
					object obj3 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					object[] array2 = default;
					string text2 = string.Concat(array2);
					friendGhostHelper6.points.fontSize = (int)text2;
				}
			}
			else if (challengersDescending != null && _currentChallengerIndex != -1 && currentChallenger != null)
			{
				Challenger challenger = currentChallenger;
				int score = challenger.Score;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v27 (System.String)+74]");
				if ((nint)score > (nint)0)
				{
					FriendGhostHelper friendGhostHelper7 = helper;
					Challenger challenger2 = currentChallenger;
					int score2 = challenger2.Score;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v27 (System.String)+74]");
					object obj5 = (nint)score2 - (nint)0;
					object obj3 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					object[] array3 = default;
					string text3 = string.Concat(array3);
					friendGhostHelper7.points.fontSize = (int)text3;
				}
			}
			object obj6 = this - -64;
			FriendGhostHelper friendGhostHelper8 = helper;
			UILabel points = friendGhostHelper8.points;
			string mText = points.mText;
			if ((nint)obj6 != mText.m_stringLength)
			{
				object obj7 = this - -64;
				FriendGhostHelper friendGhostHelper9 = helper;
				UILabel points2 = friendGhostHelper9.points;
				string mText2 = points2.mText;
				obj7 = mText2.m_stringLength;
				this._002Ector();
			}
		}
	}

	public void FinishedAnimatingOut()
	{
		FriendGhostHelper friendGhostHelper = helper;
		if (~(friendGhostHelper._gameRunning ? 1u : 0u) == 0)
		{
			friendGhostHelper.currentAnimationState = FriendGhostHelper.AnimatingState.AnimatingOut;
		}
	}

	public void SetNewChallenger()
	{
		if (~(_gameRunning ? 1u : 0u) == 0)
		{
			ScaleHelperBackground();
		}
	}

	private bool InsertLocalUserHighScore()
	{
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_01d7: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_019a: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		Challenger[] array = ((FriendGhostHandler)null).GetTopRunPlayers();
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<FriendGhostHandler+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v46 (Il2CppClass<FriendGhostHandler+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__32_0 == null;
		bool flag2 = !flag;
		Comparison<Challenger> comparison = _003C_003Ec._003C_003E9__32_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v20 (Il2CppClass<FriendGhostHandler+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v40 (Il2CppClass<FriendGhostHandler+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Comparison<Challenger> comparison2 = default;
			object obj3 = comparison2 + 16;
			obj3 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v37 (Il2CppClass<FriendGhostHandler+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)8;
			obj4 = comparison2;
			comparison = comparison2;
		}
		Array.Sort(array, comparison);
		return (byte)(int)array != 0;
	}

	private unsafe bool InsertLocalUserTopRun()
	{
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected I4, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I
		//IL_04e3: Expected I, but got Obj
		//IL_04f9: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I
		//IL_0141: Expected I, but got Obj
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02d1: Expected I4, but got Obj
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_018e: Expected I, but got Obj
		//IL_01a4: Expected Obj, but got I
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_035d: Expected I4, but got Obj
		//IL_0399: Expected I, but got Obj
		//IL_03af: Expected Obj, but got I
		//IL_01cf: Expected I, but got Obj
		//IL_0573: Expected I4, but got Obj
		//IL_0286: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I
		//IL_03da: Expected I, but got Obj
		//IL_0268: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 32);
		object obj2 = obj + 16;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		int localHighestScore = _localHighestScore;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v6 (System.String)+74]");
		if ((nint)localHighestScore > (nint)0)
		{
			if (~(_localUserHighscoreInserted ? 1u : 0u) == 0)
			{
				return false;
			}
			nint num = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v21 (Il2CppClass<SocialManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v69 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v26 (System.Boolean)+38]");
			ComputeShader computeShader;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v26 (System.Boolean)+38]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v67+14]");
				computeShader = (ComputeShader)0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v26 (System.Boolean)+3C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v26 (System.Boolean)+3C]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v64+14]");
					computeShader = (ComputeShader)0;
				}
				else
				{
					computeShader = null;
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = computeShader.FindKernel(null);
			FriendGhostHelper friendGhostHelper = helper;
			if (num5 != 0)
			{
				nint num6 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v51 (Il2CppClass<SocialManager>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num7 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v56 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S2_v36 (System.Boolean)+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S2_v36 (System.Boolean)+38]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S2_v46+14]");
					object obj9 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S2_v36 (System.Boolean)+3C]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S2_v36 (System.Boolean)+3C]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S2_v43+14]");
						object obj9 = 0;
					}
					else
					{
						object obj9 = 0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
			FriendGhostHelper friendGhostHelper2 = helper;
			object obj11 = this + 68;
			obj2 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S2_v7+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			friendGhostHelper2.points.rawPivot = pivot;
			FriendGhostHelper friendGhostHelper3 = helper;
			object obj12 = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			int fontSize = default;
			friendGhostHelper3.points.fontSize = fontSize;
			FriendGhostHelper friendGhostHelper4 = helper;
			object obj13 = this + 116;
			obj = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S2_v20+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			friendGhostHelper4.scoreType.rawPivot = pivot;
			FriendGhostHelper friendGhostHelper5 = helper;
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v36 (Il2CppClass<Strings>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num9 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v47 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("INGAME_UI_HIGHSCORE");
			friendGhostHelper5.scoreType.fontSize = (int)text;
			FriendGhostHelper friendGhostHelper6 = helper;
			friendGhostHelper6.competitorIcon.tag = null;
			_localUserHighscoreInserted = true;
			_currentThreshold = _localHighestScore;
			return true;
		}
		return false;
	}

	private unsafe bool InsertChallenger()
	{
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected I4, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_00b5: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0518: Expected I, but got Obj
		//IL_052e: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_017b: Expected I, but got Obj
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_030b: Expected I4, but got Obj
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_01c8: Expected I, but got Obj
		//IL_01de: Expected Obj, but got I
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0397: Expected I4, but got Obj
		//IL_03d3: Expected I, but got Obj
		//IL_03e9: Expected Obj, but got I
		//IL_0209: Expected I, but got Obj
		//IL_05a8: Expected I4, but got Obj
		//IL_02c0: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I
		//IL_0414: Expected I, but got Obj
		//IL_02a2: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got I
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 32);
		object obj2 = obj + 16;
		Challenger[] friends = GetFriends();
		if (friends != null)
		{
			string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
			int localTopRunScore = _localTopRunScore;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v9 (System.String)+74]");
			if ((nint)localTopRunScore > (nint)0)
			{
				if (~(_localUserTopRunInserted ? 1u : 0u) == 0)
				{
					return false;
				}
				nint num = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v25 (Il2CppClass<SocialManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v73 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v30 (System.Boolean)+38]");
				ComputeShader computeShader;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v30 (System.Boolean)+38]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v71+14]");
					computeShader = (ComputeShader)0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v30 (System.Boolean)+3C]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v30 (System.Boolean)+3C]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v68+14]");
						computeShader = (ComputeShader)0;
					}
					else
					{
						computeShader = null;
					}
				}
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v56 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num5 = computeShader.FindKernel(null);
				FriendGhostHelper friendGhostHelper = helper;
				if (num5 != 0)
				{
					nint num6 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v55 (Il2CppClass<SocialManager>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num7 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v60 (Il2CppClass<SocialManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v37 (System.Boolean)+38]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v37 (System.Boolean)+38]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S2_v47+14]");
						object obj9 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v37 (System.Boolean)+3C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v37 (System.Boolean)+3C]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S2_v44+14]");
							object obj9 = 0;
						}
						else
						{
							object obj9 = 0;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				}
				FriendGhostHelper friendGhostHelper2 = helper;
				object obj11 = this + 68;
				obj2 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S2_v8+8]");
				_ = 0;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				friendGhostHelper2.points.rawPivot = pivot;
				FriendGhostHelper friendGhostHelper3 = helper;
				object obj12 = this + 60;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
				int fontSize = default;
				friendGhostHelper3.points.fontSize = fontSize;
				FriendGhostHelper friendGhostHelper4 = helper;
				object obj13 = this + 100;
				obj = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S2_v21+8]");
				_ = 0;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				friendGhostHelper4.scoreType.rawPivot = pivot;
				FriendGhostHelper friendGhostHelper5 = helper;
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v38 (Il2CppClass<Strings>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num9 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v49 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = Strings.GetDefault("INGAME_UI_HIGHSCORE");
				friendGhostHelper5.scoreType.fontSize = (int)text;
				FriendGhostHelper friendGhostHelper6 = helper;
				friendGhostHelper6.competitorIcon.tag = null;
				_localUserTopRunInserted = true;
				_currentThreshold = _localTopRunScore;
				return true;
			}
			return false;
		}
		return false;
	}

	private void ScaleHelperBackground()
	{
		//IL_0125: Expected I4, but got Obj
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		if (~(_gameRunning ? 1u : 0u) != 0)
		{
			return;
		}
		_insertedAnyUser = false;
		if (challengersDescending == null && _currentChallengerIndex == -1)
		{
			if (~(_localUserTopRunInserted ? 1u : 0u) != 0)
			{
				if (InsertChallenger())
				{
					_insertedAnyUser = true;
				}
			}
			else if (~(_localUserHighscoreInserted ? 1u : 0u) != 0 && InsertLocalUserTopRun())
			{
				_insertedAnyUser = true;
			}
		}
		else
		{
			string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
			Challenger[] array = challengersDescending;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v4 (System.String)+74]");
			int currentChallengerIndex = ((FriendGhostHandler)null).CalculateGapToFriendsScore((int)array, 0);
			_currentChallengerIndex = currentChallengerIndex;
			if (_currentChallengerIndex == -1)
			{
				string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
				int localHighestScore = _localHighestScore;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v37 (System.String)+74]");
				if ((nint)localHighestScore > (nint)0)
				{
					if (InsertChallenger())
					{
						_insertedAnyUser = true;
					}
					else if (InsertLocalUserTopRun())
					{
						_insertedAnyUser = true;
					}
				}
			}
			else
			{
				object obj = this + 32;
				object obj2 = challengersDescending + 16;
				int num = _currentChallengerIndex << 2;
				object obj3 = obj2 + num;
				obj = obj3;
				Challenger challenger = currentChallenger;
				if (_localTopRunScore < challenger.Score)
				{
					if (InsertChallenger())
					{
						_insertedAnyUser = true;
					}
					else if (((FriendHelperCrew)this).PayoutAndReturnReward() != 0)
					{
						_insertedAnyUser = true;
					}
				}
				else
				{
					Challenger challenger2 = currentChallenger;
					if (_localHighestScore >= challenger2.Score)
					{
						if (((FriendHelperCrew)this).PayoutAndReturnReward() != 0)
						{
							_insertedAnyUser = true;
						}
					}
					else if (InsertLocalUserTopRun())
					{
						_insertedAnyUser = true;
					}
					else if (((FriendHelperCrew)this).PayoutAndReturnReward() != 0)
					{
						_insertedAnyUser = true;
					}
				}
			}
		}
		bool insertedAnyUser = _insertedAnyUser;
		FriendGhostHelper friendGhostHelper = helper;
		if (insertedAnyUser)
		{
			if (~(friendGhostHelper.noFriendsLeftToGhost ? 1u : 0u) != 0)
			{
				friendGhostHelper.currentAnimationState = FriendGhostHelper.AnimatingState.AnimatingIn;
			}
		}
		else
		{
			helper.GameOver();
		}
	}

	public FriendGhostHandler()
	{
		//IL_00b9: Expected VT, but got Obj
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_0124: Expected F4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0064: Expected I4, but got Obj
		FriendGhostHelper friendGhostHelper = helper;
		GameObject gameObject = friendGhostHelper.points.gameObject;
		Transform transform = default;
		transform.localPosition = (Vector3)gameObject;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v34 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FriendGhostHelper friendGhostHelper2 = helper;
		FriendGhostHelper friendGhostHelper3 = helper;
		UILabel points = friendGhostHelper3.points;
		float num3 = Math.Abs((float)transform);
		float num4 = 3f * num3;
		float width = (float)((UIWidget)points).mWidth + num4;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		FriendGhostHelper friendGhostHelper4 = helper;
		if ((nint)gUILayoutOption > friendGhostHelper2.defaultBackgroundWidth)
		{
			friendGhostHelper4.background.height = (int)gUILayoutOption;
			return;
		}
		FriendGhostHelper friendGhostHelper5 = helper;
		friendGhostHelper4.background.height = friendGhostHelper5.defaultBackgroundWidth;
	}

	private bool _003CGetTopRunPlayers_003Eb__30_0(Challenger element)
	{
		return (nint)((UnityEngine.Object)this).m_CachedPtr >= (nint)element;
	}
}
