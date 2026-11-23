using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway;
using TMPro;
using TopRun;
using UnityEngine;

public class FriendGhostHandler : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Challenger> _003C_003E9__27_0;

		public static Comparison<Challenger> _003C_003E9__28_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal int _003CGetCombinedAndSortedChallengers_003Eb__27_0(Challenger x, Challenger y)
		{
			return y.Score - x.Score;
		}

		internal int _003CGetSortedFriends_003Eb__28_0(Challenger x, Challenger y)
		{
			return y.Score - x.Score;
		}
	}

	private IManager _tournamentManager;

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

	private int _currentChallengerIndex = -1;

	private int _localHighestScore;

	private int _localTopRunScore;

	private int _numberOfCharactersInScore;

	private Color localPlayerColor = (Color)4565484386274770944L;

	private Color friendColor = (Color)4575657222473777152L;

	private Color topRunHighscoreTitleColor = (Color)4575657222473777152L;

	private Color normalHighScoreTitleColor = (Color)4565484386274770944L;

	private unsafe void Init()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FriendGhostHandler.NewGame));
		Game.OnGameStarted += action;
	}

	private unsafe void OnDestroy()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FriendGhostHandler.NewGame));
		Game.OnGameStarted -= action;
	}

	private void Awake()
	{
		Init();
		NewGame();
	}

	public void NewGame()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		_gameRunning = true;
		_localHighestScore = instance._highScore;
		_currentThreshold = 0;
		_passedLocalHighScore = false;
		_localUserHighscoreInserted = false;
		GameStats instance2 = GameStats.Instance;
		instance2.ResetGame();
		helper.GameOver();
		_tournamentManager = TopRunRoot.manager__BackingField;
		if (_tournamentManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int localTopRunScore = default;
			_localTopRunScore = localTopRunScore;
		}
		PlayerInfo instance3 = PlayerInfo.Instance;
		if (~(instance3._isTutorialCompleted ? 1u : 0u) == 0)
		{
			GameStats instance4 = GameStats.Instance;
			int nextChallengerWithHigherScoreIndex = getNextChallengerWithHigherScoreIndex(challengersDescending, instance4._score);
			_currentChallengerIndex = nextChallengerWithHigherScoreIndex;
			helper.NewGame();
			SetNewChallenger();
			FriendGhostHelper friendGhostHelper = helper;
			if (~(friendGhostHelper.noFriendsLeftToGhost ? 1u : 0u) != 0)
			{
				friendGhostHelper.currentAnimationState = FriendGhostHelper.AnimatingState.AnimatingIn;
			}
		}
	}

	private Challenger[] GetFriends()
	{
		//IL_016b: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Globals.LogInState loginState = Globals.GetLoginState();
		RuntimePlatform platform = Application.platform;
		bool flag2 = default;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			bool flag = loginState == Globals.LogInState.Both;
			flag2 = true;
			if (!flag)
			{
				bool flag3 = loginState == Globals.LogInState.GameCenter;
				flag2 = flag3;
			}
		}
		bool flag4 = !flag2;
		object obj = loginState & (Globals.LogInState)(-3);
		bool flag5 = (nint)obj != 1;
		object obj2 = flag4 & flag5;
		bool flag6 = obj2 == null;
		bool flag7 = !flag6;
		Friend[] array2 = default;
		Friend[] array = array2;
		if (!flag7)
		{
			SocialManager instance = SocialManager.instance;
			Friend[] array3 = instance.FriendsSortedByScore();
			array = array3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = 0;
		if (array.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)array + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v34+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v35+20]");
			if ((nint)0 != 0)
			{
				object obj7 = obj3 << 2;
				object obj8 = (object)array + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v27+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v28+20]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v29+14]");
				_ = 0;
			}
			_ = 1;
			object obj11 = obj3 << 2;
			object obj12 = (object)array + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v18+10]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v19+C]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		Challenger[] result = default;
		return result;
	}

	private Challenger[] GetTopRunPlayers()
	{
		//IL_01fa: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		_tournamentManager = TopRunRoot.manager__BackingField;
		List<IPlayer> list = default;
		list._002Ector();
		if (_tournamentManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			bool flag = obj == null;
			object obj2 = 0;
			if (!flag)
			{
				object obj3 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
					nint num = 0;
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S4_v13 (Il2CppRgctx<System.Collections.Generic.List`1<TopRun.IPlayer>>)+3C]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v193 @ S4_v14+4] (should have been resolved before IL gen)");
					object obj5 = obj2 + 1;
					obj2 = obj5;
				}
			}
		}
		IPlayer[] array = list.ToArray();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj6 = 0;
		if (array.Length > (nint)obj6)
		{
			object obj7 = obj6 << 2;
			object obj8 = (object)array + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj9 = default;
			if (obj9 != null)
			{
				object obj10 = obj6 << 2;
				object obj11 = (object)array + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v34+14]");
				_ = 0;
			}
			object obj12 = obj6 << 2;
			object obj13 = (object)array + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj14 = obj6 << 2;
			object obj15 = (object)array + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		if (_tournamentManager != null)
		{
			throw new ArgumentException();
		}
		Challenger[] result = default;
		return result;
	}

	private Challenger[] GetCombinedAndSortedChallengers(Challenger[] friends, Challenger[] topRuns)
	{
		//IL_0064: Expected Obj, but got I4
		object obj = friends.Length + topRuns.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		Array.Copy(friends, 0, array, 0, friends.Length);
		Array.Copy(topRuns, 0, array, friends.Length, topRuns.Length);
		bool flag = _003C_003Ec._003C_003E9__27_0 == null;
		bool flag2 = !flag;
		Comparison<Challenger> comparison = _003C_003Ec._003C_003E9__27_0;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		Array.Sort((Challenger[])array, comparison);
		return (Challenger[])array;
	}

	private Challenger[] GetSortedFriends()
	{
		Challenger[] friends = ((FriendGhostHandler)null).GetFriends();
		bool flag = _003C_003Ec._003C_003E9__28_0 == null;
		bool flag2 = !flag;
		Comparison<Challenger> comparison = _003C_003Ec._003C_003E9__28_0;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		Array.Sort(friends, comparison);
		return friends;
	}

	private int getNextChallengerWithHigherScoreIndex(Challenger[] sortedChallengerList, int thisPlayerScore)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I
		bool flag = sortedChallengerList == null;
		int result = -1;
		if (!flag)
		{
			bool flag2 = sortedChallengerList.Length == 0;
			int num = sortedChallengerList.Length;
			result = -1;
			if (!flag2)
			{
				bool flag4;
				do
				{
					int num2 = num - 1;
					bool flag3 = num2 <= -1;
					result = -1;
					if (flag3)
					{
						break;
					}
					int num3 = num2 << 2;
					object obj = sortedChallengerList + num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+10]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17+8]");
					flag4 = (nint)0 <= (nint)thisPlayerScore;
					num = num2;
					result = num2;
				}
				while (flag4);
			}
		}
		return result;
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04a5: Expected Obj, but got I4
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_00ea: Expected I, but got Obj
		//IL_04e6: Expected I, but got Obj
		//IL_044a: Expected I, but got Obj
		//IL_01d4: Expected Obj, but got I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected I4, but got Unknown
		//IL_02b7: Expected Obj, but got I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected I4, but got Unknown
		//IL_0213: Expected I, but got Obj
		//IL_02f6: Expected I, but got Obj
		//IL_03dd: Expected Obj, but got I4
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected I4, but got Unknown
		//IL_041c: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		FriendGhostHelper friendGhostHelper = helper;
		bool flag = friendGhostHelper.currentAnimationState <= FriendGhostHelper.AnimatingState.AnimatingOut;
		object obj3 = 1 << (int)friendGhostHelper.currentAnimationState;
		object obj4 = obj3 & 0x15;
		if (obj4 == null)
		{
			flag = false;
		}
		if (flag || ~(_gameRunning ? 1u : 0u) != 0 || friendGhostHelper.noFriendsLeftToGhost)
		{
			return;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		if (~(instance._isTutorialCompleted ? 1u : 0u) != 0)
		{
			return;
		}
		GameStats instance2 = GameStats.Instance;
		if (instance2._score > _currentThreshold && friendGhostHelper.currentAnimationState == FriendGhostHelper.AnimatingState.OnScreen)
		{
			FriendGhostHelper friendGhostHelper2 = helper;
			TMP_Text points = friendGhostHelper2.points;
			nint num = (nint)points;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v105 @ S2_v34 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			FriendGhostHelper friendGhostHelper3 = helper;
			if (~(friendGhostHelper3._gameRunning ? 1u : 0u) == 0)
			{
				friendGhostHelper3.currentAnimationState = FriendGhostHelper.AnimatingState.AnimatingOut;
			}
		}
		else
		{
			if (~(_insertedAnyUser ? 1u : 0u) != 0)
			{
				return;
			}
			GameStats instance3 = GameStats.Instance;
			if (~(_localUserHighscoreInserted ? 1u : 0u) == 0 && !_passedLocalHighScore)
			{
				if (instance3._score <= _localHighestScore)
				{
					FriendGhostHelper friendGhostHelper4 = helper;
					TMP_Text points2 = friendGhostHelper4.points;
					object obj5 = _localHighestScore - instance3._score;
					int num2 = obj + 12;
					string text = ((int*)num2)->ToString();
					string text2 = string.Empty + text;
					nint num3 = (nint)points2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v240 @ S2_v31 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				}
				else
				{
					_passedLocalHighScore = true;
				}
			}
			else if (~(_localUserTopRunInserted ? 1u : 0u) == 0 && !_passedLocalTopRunScore)
			{
				if (instance3._score <= _localTopRunScore)
				{
					FriendGhostHelper friendGhostHelper5 = helper;
					TMP_Text points3 = friendGhostHelper5.points;
					object obj6 = _localTopRunScore - instance3._score;
					int num4 = obj + 12;
					string text3 = ((int*)num4)->ToString();
					string text4 = string.Empty + text3;
					nint num5 = (nint)points3;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v246 @ S2_v24 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				}
				else
				{
					_passedLocalTopRunScore = true;
				}
			}
			else if (challengersDescending != null && _currentChallengerIndex != -1)
			{
				Challenger challenger = currentChallenger;
				if (currentChallenger != null && challenger.Score > instance3._score)
				{
					FriendGhostHelper friendGhostHelper6 = helper;
					TMP_Text points4 = friendGhostHelper6.points;
					Challenger challenger2 = currentChallenger;
					object obj7 = challenger2.Score - instance3._score;
					int num6 = obj + 12;
					string text5 = ((int*)num6)->ToString();
					string text6 = string.Empty + text5;
					nint num7 = (nint)points4;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v269 @ S2_v17 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				}
			}
			FriendGhostHelper friendGhostHelper7 = helper;
			TMP_Text points5 = friendGhostHelper7.points;
			nint num8 = (nint)points5;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v207 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
			int numberOfCharactersInScore = _numberOfCharactersInScore;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v15+8]");
			if ((nint)numberOfCharactersInScore != 0)
			{
				FriendGhostHelper friendGhostHelper8 = helper;
				TMP_Text points6 = friendGhostHelper8.points;
				nint num9 = (nint)points6;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v20+8]");
				_numberOfCharactersInScore = 0;
			}
		}
	}

	private int CalculateGapToFriendsScore(int scoreTo, int currentScore)
	{
		return scoreTo - currentScore;
	}

	private void PassThreshold()
	{
		FriendGhostHelper friendGhostHelper = helper;
		if (~(friendGhostHelper._gameRunning ? 1u : 0u) == 0)
		{
			friendGhostHelper.currentAnimationState = FriendGhostHelper.AnimatingState.AnimatingOut;
		}
	}

	public void FinishedAnimatingOut()
	{
		if (~(_gameRunning ? 1u : 0u) == 0)
		{
			SetNewChallenger();
		}
	}

	public void SetNewChallenger()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0141: Expected Obj, but got I
		if (~(_gameRunning ? 1u : 0u) != 0)
		{
			return;
		}
		_insertedAnyUser = false;
		if (challengersDescending != null || _currentChallengerIndex != -1)
		{
			GameStats instance = GameStats.Instance;
			int num = (_currentChallengerIndex = getNextChallengerWithHigherScoreIndex(challengersDescending, instance._score));
			if (num == -1)
			{
				GameStats instance2 = GameStats.Instance;
				if (_localHighestScore > instance2._score && InsertLocalUserHighScore())
				{
					goto IL_021c;
				}
			}
			else
			{
				int num2 = num << 2;
				object obj = challengersDescending + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v17+10]");
				currentChallenger = (Challenger)0;
				Challenger challenger = currentChallenger;
				if (challenger.Score > _localTopRunScore)
				{
					if (InsertChallenger())
					{
						goto IL_021c;
					}
				}
				else if (challenger.Score > _localHighestScore)
				{
					if (InsertLocalUserHighScore() || InsertChallenger())
					{
						goto IL_021c;
					}
				}
				else if (InsertChallenger())
				{
					goto IL_021c;
				}
			}
		}
		goto IL_02bd;
		IL_02bd:
		if (!_localUserHighscoreInserted && InsertLocalUserHighScore())
		{
			_insertedAnyUser = true;
		}
		else if (~(_insertedAnyUser ? 1u : 0u) != 0)
		{
			return;
		}
		FriendGhostHelper friendGhostHelper = helper;
		if (~(friendGhostHelper.noFriendsLeftToGhost ? 1u : 0u) != 0)
		{
			friendGhostHelper.currentAnimationState = FriendGhostHelper.AnimatingState.AnimatingIn;
		}
		return;
		IL_021c:
		_insertedAnyUser = true;
		goto IL_02bd;
	}

	private unsafe bool InsertLocalUserHighScore()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected I4, but got Unknown
		//IL_0095: Expected I, but got Obj
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got VT
		//IL_010a: Expected I, but got Obj
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		GameStats instance = GameStats.Instance;
		if (_localHighestScore > instance._score && !_localUserHighscoreInserted)
		{
			FriendGhostHelper friendGhostHelper = helper;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHandler)+48]");
			_ = 0;
			_ = localPlayerColor;
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			FriendGhostHelper friendGhostHelper2 = helper;
			TMP_Text points = friendGhostHelper2.points;
			int num = this + 52;
			string text = ((int*)num)->ToString();
			nint num2 = (nint)points;
			object obj4 = points + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			FriendGhostHelper friendGhostHelper3 = helper;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHandler)+78]");
			_ = 0;
			obj = normalHighScoreTitleColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			FriendGhostHelper friendGhostHelper4 = helper;
			TMP_Text scoreType = friendGhostHelper4.scoreType;
			string text2 = Strings.Get(StringID.INGAME_UI_HIGHSCORE);
			nint num3 = (nint)scoreType;
			object obj5 = scoreType + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S2_v13 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			FriendGhostHelper friendGhostHelper5 = helper;
			friendGhostHelper5.competitorIcon.enabled = false;
			_localUserHighscoreInserted = true;
			_currentThreshold = _localHighestScore;
		}
		return true;
	}

	private unsafe bool InsertChallenger()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected I4, but got Unknown
		//IL_0111: Expected Obj, but got I
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0182: Expected I, but got Obj
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected I4, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_024b: Expected I, but got Obj
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0373: Expected Obj, but got VT
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_03ae: Expected I, but got Obj
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected Obj, but got Unknown
		//IL_0318: Expected I, but got Obj
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		if (_currentChallengerIndex >= 0)
		{
			Challenger[] array = challengersDescending;
			if (_currentChallengerIndex < array.Length)
			{
				int num = _currentChallengerIndex << 2;
				object obj3 = array + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v17+10]");
				object obj4 = 0;
				GameStats instance = GameStats.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v18+8]");
				if ((nint)0 > (nint)instance._score)
				{
					int num2 = obj4 + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v18+14]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v18+14]");
						if ((nint)0 == 1)
						{
							FriendGhostHelper friendGhostHelper = helper;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHandler)+78]");
							_ = 0;
							_ = normalHighScoreTitleColor;
							object obj5 = obj + 48;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
							FriendGhostHelper friendGhostHelper2 = helper;
							TMP_Text scoreType = friendGhostHelper2.scoreType;
							string text = Strings.Get(StringID.INGAME_UI_HIGHSCORE);
							nint num3 = (nint)scoreType;
							object obj6 = scoreType + 528;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ S2_v26 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
							FriendGhostHelper friendGhostHelper3 = helper;
							friendGhostHelper3.competitorIcon.enabled = false;
							MissionsManager instance2 = MissionsManager.Instance;
							instance2.PlayerDidThis(MissionTarget.BeatFriends);
						}
						else
						{
							FriendGhostHelper friendGhostHelper4 = helper;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHandler)+78]");
							_ = 0;
							_ = normalHighScoreTitleColor;
							object obj7 = obj + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
							FriendGhostHelper friendGhostHelper5 = helper;
							TMP_Text scoreType2 = friendGhostHelper5.scoreType;
							string text2 = Strings.Get(StringID.INGAME_UI_HIGHSCORE);
							nint num4 = (nint)scoreType2;
							object obj8 = scoreType2 + 528;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v181 @ S2_v35 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
							FriendGhostHelper friendGhostHelper6 = helper;
							friendGhostHelper6.competitorIcon.enabled = false;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v18+C]");
						bool flag = (UnityEngine.Object)0 != null;
						FriendGhostHelper friendGhostHelper7 = helper;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHandler)+68]");
						_ = 0;
						_ = topRunHighscoreTitleColor;
						object obj9 = obj + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
						FriendGhostHelper friendGhostHelper8 = helper;
						TMP_Text scoreType3 = friendGhostHelper8.scoreType;
						string text3 = Strings.Get(StringID.INGAME_UI_TOPRUN);
						nint num5 = (nint)scoreType3;
						object obj10 = scoreType3 + 528;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ S2_v15 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
						FriendGhostHelper friendGhostHelper9 = helper;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v18+10]");
						object obj11 = (nint)0 ^ (nint)(-1);
						bool flag2 = (byte)((flag & obj11) ? 1 : 0) != 0;
						friendGhostHelper9.competitorIcon.enabled = flag2;
					}
					FriendGhostHelper friendGhostHelper10 = helper;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHandler)+58]");
					_ = 0;
					obj = friendColor;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
					FriendGhostHelper friendGhostHelper11 = helper;
					TMP_Text points = friendGhostHelper11.points;
					string text4 = ((int*)num2)->ToString();
					nint num6 = (nint)points;
					object obj12 = points + 528;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v247 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
					_currentThreshold = ((int*)num2)->m_value;
				}
			}
		}
		return true;
	}

	public FriendGhostHandler()
	{
		//IL_000f: Expected VT, but got I8
		//IL_001e: Expected VT, but got I8
		//IL_002d: Expected VT, but got I8
		//IL_003c: Expected VT, but got I8
		_ = 4575657221408423936L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657221408423936L;
		base._002Ector();
	}

	private bool _003CGetTopRunPlayers_003Eb__26_0(Challenger element)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		return element.Score > (nint)obj;
	}
}
