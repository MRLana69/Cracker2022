using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Plugins.GameCenter;

public class GameCenter : MonoBehaviour
{
	public struct Player
	{
		public string playerID;

		public string alias;

		public string displayName;

		public bool isFriend;
	}

	public struct LocalPlayer
	{
		public string playerID;

		public string alias;

		public string displayName;

		public bool underage;

		public bool authenticated;
	}

	public struct Score
	{
		public string playerID;

		public int rank;

		public long value;

		public string formattedValue;

		public DateTime date;

		public ulong context;
	}

	public class Leaderboard
	{
		public string category;

		public int rangeBegin;

		public int rangeCount;

		public LeaderboardPlayerScope playerScope;

		public LeaderboardTimeScope timeScope;

		public Score localPlayerScore;

		public Score[] scores;

		public string groupIdentifier;

		public uint maxRange;

		public string title;
	}

	public class Achievement
	{
		public string identifier;

		public float percentComplete;

		public DateTime lastReportedDate;

		public bool complete => !(percentComplete < 100f);
	}

	public class AchievementDescription
	{
		public string identifier;

		public string title;

		public string unachievedDescription;

		public string achievedDescription;

		public int maximumPoints;

		public bool replayable;

		public bool hidden;

		public string groupIdentifier;
	}

	public enum PhotoSize
	{
		Small,
		Normal
	}

	public enum ShowViewState
	{
		Default = -1,
		LeaderBoards,
		Achievements,
		Challenges
	}

	public enum LeaderboardTimeScope
	{
		Today,
		Week,
		AllTime
	}

	public enum LeaderboardPlayerScope
	{
		Global,
		FriendsOnly
	}

	public delegate void AuthenticateHandler(bool hasLoginView, string error);

	public delegate void LoadFriendsCompletionHandler(string[] friends, string error);

	public delegate void LoadPlayersCompletionHandler(Player[] players, string error);

	public delegate void LoadPhotoCompletionHandler(string playerID, Texture2D photo, string error);

	private delegate void InternalLoadPhotoCompletionHandler(int imgWidth, int imgHeight, string error);

	public delegate void ViewDismissedHandler(ShowViewState viewState, string leaderboardCategory, LeaderboardTimeScope leaderboardTimeScope);

	public delegate void RequestCompleteHandler(string error);

	public delegate void LoadLeaderboardCompletionHandler(Leaderboard leaderboard, string error);

	public delegate void LoadAchievementsCompletionHandler(Achievement[] achievements, string error);

	public delegate void LoadAchievementDescriptionsCompletionHandler(AchievementDescription[] achievements, string error);

	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public int textureWidth;

		public int textureHeight;

		public LoadPhotoCompletionHandler completionHandler;

		public string playerID;

		public int context;

		internal unsafe void _003CLoadPhoto_003Eb__0(int imgWidth, int imgHeight, string error)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0041: Expected Obj, but got I4
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected VT, but got Unknown
			//IL_007e: Expected Ref, but got VT
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected VT, but got Unknown
			//IL_0099: Expected Ref, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			if (imgWidth != 0 && imgHeight != 0)
			{
				object obj3 = textureWidth * textureHeight;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				object value = default;
				GCHandle gCHandle = GCHandle.Alloc(value, GCHandleType.Pinned);
				GCHandle gCHandle2 = (GCHandle)(obj + 8);
				IntPtr intPtr = ((GCHandle*)gCHandle2)->AddrOfPinnedObject();
				GCHandle gCHandle3 = (GCHandle)(obj + 8);
				((GCHandle*)gCHandle3)->Free();
			}
			LoadPhotoCompletionHandler loadPhotoCompletionHandler = completionHandler;
			if (completionHandler != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public LoadLeaderboardCompletionHandler completionHandler;

		public string category;

		public LeaderboardPlayerScope playerScope;

		public LeaderboardTimeScope timeScope;

		public int rangeBegin;

		public int rangeCount;

		internal void _003CLoadLeaderboard_003Eb__0(Leaderboard leaderboard, string error)
		{
			if (completionHandler != null)
			{
				bool flag = leaderboard == null;
				LoadLeaderboardCompletionHandler loadLeaderboardCompletionHandler = completionHandler;
				if (!flag)
				{
					leaderboard.category = category;
					leaderboard.playerScope = playerScope;
					leaderboard.timeScope = timeScope;
					leaderboard.rangeBegin = rangeBegin;
					leaderboard.rangeCount = rangeCount;
					loadLeaderboardCompletionHandler = completionHandler;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public LoadLeaderboardCompletionHandler completionHandler;

		public string category;

		public LeaderboardTimeScope timeScope;

		internal void _003CLoadLeaderboardForIDs_003Eb__0(Leaderboard leaderboard, string error)
		{
			if (completionHandler != null)
			{
				bool flag = leaderboard == null;
				LoadLeaderboardCompletionHandler loadLeaderboardCompletionHandler = completionHandler;
				if (!flag)
				{
					leaderboard.category = category;
					leaderboard.timeScope = timeScope;
					loadLeaderboardCompletionHandler = completionHandler;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private const char SEPARATION_CHAR = '|';

	private const string ESCAPED_SEPARATION_CHAR = "&#124;";

	private bool _hasLoginView;

	private bool _initialAuthenticationComplete;

	private ViewDismissedHandler _viewDismissedHandler;

	private static GameCenter _instance;

	private static AuthenticateHandler m_authenticationEvent;

	public static bool hasLoginView
	{
		get
		{
			if (_instance != null)
			{
				GameCenter instance = _instance;
				return instance._hasLoginView;
			}
			return false;
		}
	}

	public static bool initialAuthenticationComplete
	{
		get
		{
			if (_instance != null)
			{
				GameCenter instance = _instance;
				return instance._initialAuthenticationComplete;
			}
			return false;
		}
	}

	public static event AuthenticateHandler authenticationEvent
	{
		add
		{
			Delegate obj = GameCenter.m_authenticationEvent;
			AuthenticateHandler authenticateHandler2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == GameCenter.m_authenticationEvent;
				AuthenticateHandler authenticateHandler = authenticateHandler2;
				if (!flag)
				{
					authenticateHandler = GameCenter.m_authenticationEvent;
				}
				GameCenter.m_authenticationEvent = authenticateHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = GameCenter.m_authenticationEvent;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = GameCenter.m_authenticationEvent;
			AuthenticateHandler authenticateHandler2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == GameCenter.m_authenticationEvent;
				AuthenticateHandler authenticateHandler = authenticateHandler2;
				if (!flag)
				{
					authenticateHandler = GameCenter.m_authenticationEvent;
				}
				GameCenter.m_authenticationEvent = authenticateHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = GameCenter.m_authenticationEvent;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private static void _GameCenterInit(string gameObject)
	{
	}

	private static void _GameCenterShowLoginView()
	{
	}

	private static void _GameCenterGetLocalPlayer(ref LocalPlayer localPlayer)
	{
	}

	private static void _GameCenterLoadFriends(int handlerContext)
	{
	}

	private static void _GameCenterLoadPlayers(string playerIDs, int handlerContext)
	{
	}

	private static void _GameCenterLoadPhoto(string playerID, int size, int handlerContext)
	{
	}

	private static bool _GameCenterArePhotosSupported()
	{
		return false;
	}

	private static bool _GameCenterGetPhotoPixels(int context, int width, int height, IntPtr pixels)
	{
		return false;
	}

	private static void _GameCenterShowView(int viewState, string leaderboardCategory, int leaderboardTimeScope)
	{
	}

	private static void _GameCenterReportScore(string category, long scoreValue, ulong scoreContext, int handlerContext)
	{
	}

	private static void _GameCenterLoadLeaderboard(string category, int playerScope, int timeScope, int rangeBegin, int rangeCount, int handlerContext)
	{
	}

	private static void _GameCenterLoadLeaderboardForIDs(string category, string playerIDs, int timeScope, int handlerContext)
	{
	}

	private static void _GameCenterReportAchievement(string achievementID, float percentComplete, int showsCompletionBanner, int handlerContext)
	{
	}

	private static void _GameCenterReportAchievements(string interleavedAchievements, int showsCompletionBanner, int handlerContext)
	{
	}

	private static void _GameCenterLoadAchievements(int handlerContext)
	{
	}

	private static void _GameCenterLoadAchievementDescriptions(int handlerContext)
	{
	}

	private static void _GameCenterResetAchievements(int handlerContext)
	{
	}

	public static bool IsSupported()
	{
		RuntimePlatform platform = Application.platform;
		return platform == RuntimePlatform.IPhonePlayer;
	}

	public static void Init()
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A23C");
				GameCenter instance = default;
				_instance = instance;
			}
			string text = _instance.name;
		}
	}

	public static void ShowLoginView()
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				GameCenter instance = _instance;
				if (~(instance._hasLoginView ? 1u : 0u) == 0)
				{
					GameCenter instance2 = _instance;
					instance2._hasLoginView = false;
				}
			}
			else
			{
				LogError("GameCenter.ShowLoginView was called before Init");
			}
		}
		else
		{
			LogError("Could not show login view (not on iOS)");
		}
	}

	public unsafe static LocalPlayer GetLocalPlayer()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_0096: Expected native int or pointer, but got VT
		//IL_00a3: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		obj3 = 0;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				_ = 0;
			}
		}
		LocalPlayer localPlayer = default;
		System.Runtime.CompilerServices.Unsafe.Write(&((LocalPlayer*)(nint)localPlayer)->playerID, obj);
		System.Runtime.CompilerServices.Unsafe.Write(&((LocalPlayer*)(nint)localPlayer)->displayName, obj3);
		return localPlayer;
	}

	public static void GetLocalPlayer(ref LocalPlayer player)
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [player @ L0 (LocalPlayer&)+8]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [player @ L0 (LocalPlayer&)+4]");
				_ = 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		}
	}

	public static void LoadFriends(LoadFriendsCompletionHandler completionHandler)
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				int num = PluginUtil.CheckInHandler(completionHandler, _instance);
			}
			else
			{
				LogError("GameCenter.LoadFriends was called before Init");
			}
		}
		else if (completionHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: completionHandler.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public unsafe static void LoadPlayers(string[] playerIDs, LoadPlayersCompletionHandler completionHandler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				int num = PluginUtil.CheckInHandler(completionHandler, _instance);
				_ = 124;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				char c = (char)(obj + 14);
				string separator = ((char*)(ushort)c)->ToString(invariantCulture);
				string text = string.Join(separator, playerIDs);
			}
			else
			{
				LogError("GameCenter.LoadPlayers was called before Init");
			}
		}
		else if (completionHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: completionHandler.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public static bool ArePhotosSupported()
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer && _instance == null)
		{
			LogError("GameCenter.ArePhotosSupported was called before Init");
		}
		return false;
	}

	public unsafe static void LoadPhoto(string playerID, PhotoSize size, int textureWidth, int textureHeight, LoadPhotoCompletionHandler completionHandler)
	{
		//IL_0088: Expected Obj, but got I
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				_ = 0;
				InternalLoadPhotoCompletionHandler internalLoadPhotoCompletionHandler = default;
				object obj = default;
				internalLoadPhotoCompletionHandler._002Ector(obj, (nint)__ldftn(_003C_003Ec__DisplayClass58_0._003CLoadPhoto_003Eb__0));
				int num = PluginUtil.CheckInHandler(internalLoadPhotoCompletionHandler, _instance);
			}
			else
			{
				LogError("GameCenter.LoadPhoto was called before Init");
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S0_v15+C] (should have been resolved before IL gen)");
		}
	}

	public static void ShowView(ShowViewState viewState, string leaderboardCategory = null, LeaderboardTimeScope leaderboardTimeScope = LeaderboardTimeScope.AllTime, ViewDismissedHandler viewDismissedHandler = null)
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				GameCenter instance = _instance;
				instance._viewDismissedHandler = viewDismissedHandler;
			}
			else
			{
				LogError("GameCenter.ShowView was called before Init");
			}
		}
	}

	public static void ReportScore(string category, long scoreValue, ulong scoreContext, RequestCompleteHandler completionHandler)
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				int num = PluginUtil.CheckInHandler(completionHandler, _instance);
			}
			else
			{
				LogError("GameCenter.ReportScore was called before Init");
			}
		}
		else if (completionHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [completionHandler @ L3 (System.Int64)+C] (should have been resolved before IL gen)");
		}
	}

	public unsafe static void LoadLeaderboard(string category, LeaderboardPlayerScope playerScope, LeaderboardTimeScope timeScope, int rangeBegin, int rangeCount, LoadLeaderboardCompletionHandler completionHandler)
	{
		//IL_007d: Expected Obj, but got I
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				LoadLeaderboardCompletionHandler loadLeaderboardCompletionHandler = default;
				object obj = default;
				loadLeaderboardCompletionHandler._002Ector(obj, (nint)__ldftn(_003C_003Ec__DisplayClass61_0._003CLoadLeaderboard_003Eb__0));
				int num = PluginUtil.CheckInHandler(loadLeaderboardCompletionHandler, _instance);
			}
			else
			{
				LogError("GameCenter.LoadLeaderboard was called before Init");
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S0_v17+C] (should have been resolved before IL gen)");
		}
	}

	public unsafe static void LoadLeaderboardForIDs(string category, string[] playerIDs, LeaderboardTimeScope timeScope, LoadLeaderboardCompletionHandler completionHandler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				LoadLeaderboardCompletionHandler loadLeaderboardCompletionHandler = default;
				object obj3 = default;
				loadLeaderboardCompletionHandler._002Ector(obj3, (nint)__ldftn(_003C_003Ec__DisplayClass62_0._003CLoadLeaderboardForIDs_003Eb__0));
				int num = PluginUtil.CheckInHandler(loadLeaderboardCompletionHandler, _instance);
				_ = 124;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				char c = (char)(obj + 14);
				string separator = ((char*)(ushort)c)->ToString(invariantCulture);
				string text = string.Join(separator, playerIDs);
			}
			else
			{
				LogError("GameCenter.LoadLeaderboardForIDs was called before Init");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (System.Object)+8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (System.Object)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S0_v19+C] (should have been resolved before IL gen)");
			}
		}
	}

	public static void ReportAchievement(string identifier, float percentComplete, bool showsCompletionBanner, RequestCompleteHandler completionHandler)
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				int num = PluginUtil.CheckInHandler(completionHandler, _instance);
			}
			else
			{
				LogError("GameCenter.ReportAchievement was called before Init");
			}
		}
		else if (completionHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [completionHandler @ L3 (System.Single)+C] (should have been resolved before IL gen)");
		}
	}

	public static void ReportAchievement(Achievement achievement, bool showsCompletionBanner, RequestCompleteHandler completionHandler)
	{
		ReportAchievement(achievement.identifier, achievement.percentComplete, showsCompletionBanner, completionHandler);
	}

	public static void ReportAchievements(Achievement[] achievements, bool showsCompletionBanner, RequestCompleteHandler completionHandler)
	{
		//IL_0060: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_0142: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_0112: Expected F4, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				int num = PluginUtil.CheckInHandler(completionHandler, _instance);
				StringBuilder stringBuilder = default;
				stringBuilder._002Ector();
				object obj = 0;
				object obj2 = 0;
				while (achievements.Length > (nint)obj2)
				{
					object obj3 = obj2 << 2;
					object obj4 = (object)achievements + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v42+10]");
					object obj5 = 0;
					if (obj != null)
					{
						StringBuilder stringBuilder2 = stringBuilder.Append('|');
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v43+8]");
					StringBuilder stringBuilder3 = stringBuilder.Append((string)0);
					StringBuilder stringBuilder4 = stringBuilder3.Append('|');
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v43+C]");
					StringBuilder stringBuilder5 = stringBuilder4.Append(0f);
					object obj6 = obj2 + 1;
					obj = 1;
					obj2 = obj6;
				}
				nint num2 = (nint)stringBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v122 @ S1_v13 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			}
			else
			{
				LogError("GameCenter.ReportAchievements was called before Init");
			}
		}
		else if (completionHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: completionHandler.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public static void LoadAchievements(LoadAchievementsCompletionHandler completionHandler)
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				int num = PluginUtil.CheckInHandler(completionHandler, _instance);
			}
			else
			{
				LogError("GameCenter.LoadAchievements was called before Init");
			}
		}
		else if (completionHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: completionHandler.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public static void LoadAchievementDescriptions(LoadAchievementDescriptionsCompletionHandler completionHandler)
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				int num = PluginUtil.CheckInHandler(completionHandler, _instance);
			}
			else
			{
				LogError("GameCenter.LoadAchievementDescriptions was called before Init");
			}
		}
		else if (completionHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: completionHandler.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public static void ResetAchievements(RequestCompleteHandler completionHandler)
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			if (_instance != null)
			{
				int num = PluginUtil.CheckInHandler(completionHandler, _instance);
			}
			else
			{
				LogError("GameCenter.ResetAchievements was called before Init");
			}
		}
		else if (completionHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: completionHandler.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private unsafe void OnGameCenterAuthenticationEvent(string param)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_initialAuthenticationComplete = true;
		AuthenticateHandler authenticateHandler = GameCenter.m_authenticationEvent;
		if (GameCenter.m_authenticationEvent != null)
		{
			string[] array = param.Split('|');
			if (array.Length != 2)
			{
				_ = array.Length;
				int num = obj + 12;
				string text = ((int*)num)->ToString();
				string msg = "GameCenter.OnGameCenterAuthenticationEvent: Unexpected number of parameters :" + text;
				LogError(msg);
			}
			bool flag = array[0] == "true";
			_hasLoginView = flag;
			string text2 = array[1];
			if (text2._stringLength >= 1)
			{
				string text3 = UnescapeResultString(array[1]);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v23.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private unsafe void OnGameCenterLoadFriendsComplete(string param)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I4, but got Unknown
		//IL_014c: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		string[] array = param.Split('|');
		if (array.Length <= 1)
		{
			_ = array.Length;
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			string msg = "GameCenter.OnGameCenterLoadFriendsComplete: Unexpected number of parameters :" + text;
			LogError(msg);
			return;
		}
		int ticket = int.Parse(array[0]);
		Delegate obj3 = PluginUtil.CheckOutHandler(ticket);
		bool flag = (object)obj3 == null;
		Delegate obj4 = null;
		if (!flag)
		{
			bool flag2 = (object)obj3.GetType() == typeof(LoadFriendsCompletionHandler);
			obj4 = obj3;
			if (!flag2)
			{
				obj4 = null;
			}
		}
		if ((object)obj4 != null)
		{
			string text2 = array[1];
			if (text2._stringLength >= 1)
			{
				string text3 = UnescapeResultString(array[1]);
			}
			if (array.Length >= 3)
			{
				object obj5 = array.Length - 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				object obj6 = 2;
				if ((nint)obj6 < array.Length)
				{
					object obj7 = obj6 << 2;
					object obj8 = (object)array + obj7;
					throw new ArrayTypeMismatchException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v112.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		else
		{
			LogError("GameCenter.OnGameCenterLoadFriendsComplete: Handler not registered");
		}
	}

	private unsafe void OnGameCenterLoadPlayersComplete(string param)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0421: Expected Obj, but got I4
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected I4, but got Unknown
		//IL_0023: Expected Obj, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got I4
		//IL_04c3: Expected Obj, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I4
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0238: Expected Obj, but got I
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_031a: Expected Obj, but got I
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_035c: Expected Obj, but got I
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		string[] array = param.Split('|');
		object obj3 = array.Length;
		if (array.Length >= 2)
		{
			object obj4 = array.Length - 2;
			object obj5 = obj4 & 3;
			if (obj5 == null)
			{
				int ticket = int.Parse(array[0]);
				Delegate obj6 = PluginUtil.CheckOutHandler(ticket);
				bool flag = (object)obj6 == null;
				Delegate obj7 = null;
				if (!flag)
				{
					bool flag2 = (object)obj6.GetType() == typeof(LoadPlayersCompletionHandler);
					obj7 = obj6;
					if (!flag2)
					{
						obj7 = null;
					}
				}
				if ((object)obj7 != null)
				{
					string text = array[1];
					if (text._stringLength >= 1)
					{
						string text2 = UnescapeResultString(array[1]);
					}
					bool flag3 = (nint)obj3 < 3;
					object obj8 = 0;
					if (!flag3)
					{
						object obj9 = obj3 - 2;
						object obj10 = obj9 / 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						object obj11 = 2;
						object obj12 = 0;
						object obj13 = default;
						while (true)
						{
							bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
							obj8 = obj13;
							if (flag4)
							{
								break;
							}
							object obj14 = obj12 << 4;
							object obj15 = obj13 + obj14;
							object obj16 = obj15 + 16;
							object obj17 = obj11 << 2;
							object obj18 = (object)array + obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v39+10]");
							obj16 = 0;
							object obj19 = obj12 << 4;
							object obj20 = obj13 + obj19;
							object obj21 = obj20 + 16;
							object obj22 = obj11 + 1;
							object obj23 = obj22 << 2;
							object obj24 = (object)array + obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v45+10]");
							string text3 = UnescapeResultString((string)0);
							object obj25 = obj12 << 4;
							object obj26 = obj13 + obj25;
							object obj27 = obj26 + 16;
							object obj28 = obj11 + 2;
							object obj29 = obj28 << 2;
							object obj30 = (object)array + obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S1_v52+10]");
							string text4 = UnescapeResultString((string)0);
							object obj31 = obj12 << 4;
							object obj32 = obj13 + obj31;
							object obj33 = obj32 + 16;
							object obj34 = obj11 + 3;
							object obj35 = obj34 << 2;
							object obj36 = (object)array + obj35;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v59+10]");
							bool flag5 = (string)0 == "true";
							object obj37 = obj12 << 4;
							object obj38 = obj13 + obj37;
							object obj39 = obj38 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v63+8]");
							object obj40 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v64+8]");
							if ((nint)0 == 0)
							{
								object obj41 = obj12 << 4;
								object obj42 = obj13 + obj41;
								object obj43 = obj42 + 16;
								object obj44 = obj12 << 4;
								object obj45 = obj13 + obj44;
								object obj46 = obj45 + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S1_v73+4]");
								_ = 0;
							}
							object obj47 = obj11 + 4;
							object obj48 = obj12 + 1;
							obj11 = obj47;
							obj12 = obj48;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				else
				{
					LogError("GameCenter.OnGameCenterLoadPlayersComplete: Handler not registered");
				}
				return;
			}
			obj3 = array.Length;
		}
		int num = obj + 12;
		string text5 = ((int*)num)->ToString();
		string msg = "GameCenter.OnGameCenterLoadPlayersComplete: Unexpected number of parameters :" + text5;
		LogError(msg);
	}

	private unsafe void OnGameCenterLoadPhotoComplete(string param)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I4, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		string[] array = param.Split('|');
		if (array.Length != 4)
		{
			_ = array.Length;
			int num = obj + 8;
			string text = ((int*)num)->ToString();
			string msg = "GameCenter.OnGameCenterLoadPhotoComplete: Unexpected number of parameters :" + text;
			LogError(msg);
			return;
		}
		int ticket = int.Parse(array[0]);
		Delegate obj3 = PluginUtil.CheckOutHandler(ticket);
		bool flag = (object)obj3 == null;
		Delegate obj4 = null;
		if (!flag)
		{
			bool flag2 = (object)obj3.GetType() == typeof(InternalLoadPhotoCompletionHandler);
			obj4 = obj3;
			if (!flag2)
			{
				obj4 = null;
			}
		}
		if ((object)obj4 != null)
		{
			string text2 = array[1];
			if (text2._stringLength >= 1)
			{
				string text3 = UnescapeResultString(array[1]);
			}
			int num2 = int.Parse(array[2]);
			int num3 = int.Parse(array[3]);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v113.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		else
		{
			int num4 = obj + 12;
			string text4 = ((int*)num4)->ToString();
			string msg2 = "GameCenter.OnGameCenterLoadPhotoComplete: Handler not registered: " + text4;
			LogError(msg2);
		}
	}

	private unsafe void OnGameCenterRequestComplete(string param)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I4, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		string[] array = param.Split('|');
		if (array.Length != 2)
		{
			_ = array.Length;
			int num = obj + 8;
			string text = ((int*)num)->ToString();
			string msg = "GameCenter.OnGameCenterRequestComplete: Unexpected number of parameters :" + text;
			LogError(msg);
			return;
		}
		int ticket = int.Parse(array[0]);
		Delegate obj3 = PluginUtil.CheckOutHandler(ticket);
		bool flag = (object)obj3 == null;
		Delegate obj4 = null;
		if (!flag)
		{
			bool flag2 = (object)obj3.GetType() == typeof(RequestCompleteHandler);
			obj4 = obj3;
			if (!flag2)
			{
				obj4 = null;
			}
		}
		if ((object)obj4 != null)
		{
			string text2 = array[1];
			if (text2._stringLength >= 1)
			{
				string text3 = UnescapeResultString(array[1]);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		else
		{
			int num2 = obj + 12;
			string text4 = ((int*)num2)->ToString();
			string msg2 = "GameCenter.OnGameCenterRequestComplete: Handler not registered: " + text4;
			LogError(msg2);
		}
	}

	private unsafe void OnGameCenterLoadLeaderboardComplete(string param)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I4
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected I4, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_06cf: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected VT, but got Unknown
		//IL_0262: Expected native int or pointer, but got VT
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected VT, but got Unknown
		//IL_02b0: Expected F8, but got I4
		//IL_02b0: Expected Ref, but got VT
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_0309: Expected Obj, but got I4
		//IL_0312: Expected Obj, but got I4
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_03af: Expected Obj, but got I
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_040d: Expected Obj, but got I
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected Obj, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_0470: Expected Obj, but got I
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected VT, but got Unknown
		//IL_04b9: Expected native int or pointer, but got VT
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_050a: Expected Obj, but got I
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected VT, but got Unknown
		//IL_0549: Expected F8, but got I4
		//IL_0549: Expected Ref, but got VT
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Obj, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_05a7: Expected Obj, but got I
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected Obj, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		string[] array = param.Split('|');
		if (array.Length != 2)
		{
			if (array.Length >= 11)
			{
				object obj3 = array.Length - 5;
				object obj4 = obj3 / 6;
				object obj5 = obj4 * 6;
				if (obj3 == obj5)
				{
					goto IL_00ab;
				}
				object obj6 = array.Length;
			}
			else
			{
				object obj6 = array.Length;
			}
			int num = obj + 28;
			string text = ((int*)num)->ToString();
			string msg = "GameCenter.OnGameCenterLoadLeaderboardComplete: Unexpected number of parameters :" + text;
			LogError(msg);
			return;
		}
		goto IL_00ab;
		IL_00ab:
		int ticket = int.Parse(array[0]);
		Delegate obj7 = PluginUtil.CheckOutHandler(ticket);
		bool flag = (object)obj7 == null;
		Delegate obj8 = null;
		if (!flag)
		{
			bool flag2 = (object)obj7.GetType() == typeof(LoadLeaderboardCompletionHandler);
			obj8 = obj7;
			if (!flag2)
			{
				obj8 = null;
			}
		}
		if ((object)obj8 != null)
		{
			string text2 = array[1];
			if (text2._stringLength >= 1)
			{
				string text3 = UnescapeResultString(array[1]);
			}
			bool flag3 = array.Length >= 3;
			bool flag4 = !flag3;
			object obj9 = 0;
			if (!flag4)
			{
				_ = array[2];
				string text4 = array[3];
				if (text4._stringLength != 0)
				{
					string text5 = array[3];
				}
				else
				{
					string text5 = null;
				}
				uint num2 = uint.Parse(array[4]);
				_ = array[5];
				int num3 = int.Parse(array[6]);
				long num4 = long.Parse(array[7]);
				object obj10 = array.Length - 5;
				string text6 = UnescapeResultString(array[8]);
				_ = 0;
				DateTime dateTime = (DateTime)(obj + 8);
				*(DateTime*)(nint)dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				int num5 = int.Parse(array[9]);
				DateTime dateTime2 = (DateTime)(obj + 16);
				DateTime dateTime3 = ((DateTime*)dateTime2)->AddSeconds(num5);
				ulong num6 = ulong.Parse(array[10]);
				object obj11 = obj10 / 6;
				object obj12 = obj11 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				object obj13 = 11;
				object obj14 = 0;
				object obj17 = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
				{
					object obj15 = obj14 * 40;
					object obj16 = obj17 + obj15;
					object obj18 = obj13 << 2;
					object obj19 = (object)array + obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S1_v62+10]");
					_ = 0;
					object obj20 = obj14 * 40;
					object obj21 = obj17 + obj20;
					object obj22 = obj13 + 1;
					object obj23 = obj22 << 2;
					object obj24 = (object)array + obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S1_v67+10]");
					int num7 = int.Parse((string)0);
					object obj25 = obj14 * 40;
					object obj26 = obj17 + obj25;
					object obj27 = obj13 + 2;
					object obj28 = obj27 << 2;
					object obj29 = (object)array + obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S1_v73+10]");
					long num8 = long.Parse((string)0);
					object obj30 = obj14 * 40;
					object obj31 = obj17 + obj30;
					object obj32 = obj13 + 3;
					object obj33 = obj32 << 2;
					object obj34 = (object)array + obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S1_v79+10]");
					string text7 = UnescapeResultString((string)0);
					_ = 0;
					DateTime dateTime4 = (DateTime)(obj + 8);
					*(DateTime*)(nint)dateTime4 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					object obj35 = obj13 + 4;
					object obj36 = obj35 << 2;
					object obj37 = (object)array + obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S0_v83+10]");
					int num9 = int.Parse((string)0);
					object obj38 = obj14 * 40;
					object obj39 = obj17 + obj38;
					DateTime dateTime5 = (DateTime)(obj + 16);
					DateTime dateTime6 = ((DateTime*)dateTime5)->AddSeconds(num9);
					object obj40 = obj14 * 40;
					object obj41 = obj17 + obj40;
					object obj42 = obj13 + 5;
					object obj43 = obj42 << 2;
					object obj44 = (object)array + obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S1_v99+10]");
					ulong num10 = ulong.Parse((string)0);
					object obj45 = obj13 + 6;
					object obj46 = obj14 + 1;
					obj13 = obj45;
					obj14 = obj46;
				}
				object obj47 = default;
				obj9 = obj47;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v97.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		else
		{
			LogError("GameCenter.OnGameCenterLoadLeaderboardComplete: Handler not registered");
		}
	}

	private unsafe void OnGameCenterLoadAchievementsComplete(string param)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_033f: Expected Obj, but got I4
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected I4, but got Unknown
		//IL_0023: Expected Obj, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected VT, but got Unknown
		//IL_0235: Expected native int or pointer, but got VT
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got I
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected VT, but got Unknown
		//IL_02a5: Expected F8, but got I4
		//IL_02a5: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		string[] array = param.Split('|');
		object obj3 = array.Length;
		if (array.Length >= 2)
		{
			object obj4 = array.Length - 2;
			object obj5 = obj4 / 3;
			object obj6 = obj5 * 3;
			if (obj4 == obj6)
			{
				int ticket = int.Parse(array[0]);
				Delegate obj7 = PluginUtil.CheckOutHandler(ticket);
				bool flag = (object)obj7 == null;
				Delegate obj8 = null;
				if (!flag)
				{
					bool flag2 = (object)obj7.GetType() == typeof(LoadAchievementsCompletionHandler);
					obj8 = obj7;
					if (!flag2)
					{
						obj8 = null;
					}
				}
				if ((object)obj8 != null)
				{
					string text = array[1];
					if (text._stringLength >= 1)
					{
						string text2 = UnescapeResultString(array[1]);
					}
					if ((nint)obj3 >= 3)
					{
						object obj9 = obj3 - 2;
						object obj10 = obj9 / 3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						object obj11 = 2;
						object obj12 = default;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
						{
							object obj13 = obj11 << 2;
							object obj14 = (object)array + obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S1_v38+10]");
							_ = 0;
							object obj15 = obj11 + 1;
							object obj16 = obj15 << 2;
							object obj17 = (object)array + obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v41+10]");
							float num = float.Parse((string)0);
							_ = 0;
							DateTime dateTime = (DateTime)(obj + 8);
							*(DateTime*)(nint)dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_ = 0;
							object obj18 = obj11 + 2;
							object obj19 = obj18 << 2;
							object obj20 = (object)array + obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v58+10]");
							int num2 = int.Parse((string)0);
							DateTime dateTime2 = (DateTime)(obj + 16);
							DateTime dateTime3 = ((DateTime*)dateTime2)->AddSeconds(num2);
							throw new ArrayTypeMismatchException();
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				else
				{
					LogError("GameCenter.OnGameCenterLoadAchievementsComplete: Handler not registered");
				}
				return;
			}
			obj3 = array.Length;
		}
		int num3 = obj + 28;
		string text3 = ((int*)num3)->ToString();
		string msg = "GameCenter.OnGameCenterLoadAchievementsComplete: Unexpected number of parameters :" + text3;
		LogError(msg);
	}

	private unsafe void OnGameCenterLoadAchievementDescriptionsComplete(string param)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0426: Expected Obj, but got I4
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected I4, but got Unknown
		//IL_0023: Expected Obj, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0222: Expected Obj, but got I
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0265: Expected Obj, but got I
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_02ad: Expected Obj, but got I
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02f5: Expected Obj, but got I
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0342: Expected Obj, but got I
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_0384: Expected Obj, but got I
		//IL_03f0: Expected Obj, but got I4
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03e2: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		string[] array = param.Split('|');
		object obj3 = array.Length;
		if (array.Length >= 2)
		{
			object obj4 = array.Length - 2;
			object obj5 = obj4 & 7;
			if (obj5 == null)
			{
				int ticket = int.Parse(array[0]);
				Delegate obj6 = PluginUtil.CheckOutHandler(ticket);
				bool flag = (object)obj6 == null;
				Delegate obj7 = null;
				if (!flag)
				{
					bool flag2 = (object)obj6.GetType() == typeof(LoadAchievementDescriptionsCompletionHandler);
					obj7 = obj6;
					if (!flag2)
					{
						obj7 = null;
					}
				}
				if ((object)obj7 != null)
				{
					string text = array[1];
					if (text._stringLength >= 1)
					{
						string text2 = UnescapeResultString(array[1]);
					}
					if ((nint)obj3 >= 3)
					{
						object obj8 = obj3 - 2;
						object obj9 = obj8 / 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						object obj10 = 2;
						object obj11 = default;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
						{
							object obj12 = obj10 << 2;
							object obj13 = (object)array + obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v36+10]");
							_ = 0;
							object obj14 = obj10 + 1;
							object obj15 = obj14 << 2;
							object obj16 = (object)array + obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v39+10]");
							string text3 = UnescapeResultString((string)0);
							object obj17 = obj10 + 2;
							object obj18 = obj17 << 2;
							object obj19 = (object)array + obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v43+10]");
							string text4 = UnescapeResultString((string)0);
							object obj20 = obj10 + 3;
							object obj21 = obj20 << 2;
							object obj22 = (object)array + obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v47+10]");
							string text5 = UnescapeResultString((string)0);
							object obj23 = obj10 + 4;
							object obj24 = obj23 << 2;
							object obj25 = (object)array + obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v51+10]");
							int num = int.Parse((string)0);
							object obj26 = obj10 + 5;
							object obj27 = obj26 << 2;
							object obj28 = (object)array + obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S1_v55+10]");
							bool flag3 = (string)0 == "true";
							object obj29 = obj10 + 6;
							object obj30 = obj29 << 2;
							object obj31 = (object)array + obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v59+10]");
							bool flag4 = (string)0 == "true";
							object obj32 = obj10 + 7;
							object obj33 = obj32 << 2;
							object obj34 = (object)array + obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v63+10]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S1_v64+8]");
							if ((nint)0 != 0)
							{
								object obj36 = obj10 + 7;
								object obj37 = obj36 << 2;
								object obj38 = (object)array + obj37;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v75+10]");
								object obj39 = 0;
							}
							else
							{
								object obj39 = 0;
							}
							throw new ArrayTypeMismatchException();
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v83.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				else
				{
					LogError("GameCenter.OnGameCenterLoadAchievementDescriptionsComplete: Handler not registered");
				}
				return;
			}
			obj3 = array.Length;
		}
		int num2 = obj + 12;
		string text6 = ((int*)num2)->ToString();
		string msg = "GameCenter.OnGameCenterLoadAchievementDescriptionsComplete: Unexpected number of parameters :" + text6;
		LogError(msg);
	}

	private unsafe void OnGameCenterViewDismissed(string param)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0147: Expected Obj, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		string[] array = param.Split('|');
		if (array.Length != 3)
		{
			_ = array.Length;
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			string msg = "GameCenter.OnGameCenterViewDismissed: Unexpected number of parameters :" + text;
			LogError(msg);
			return;
		}
		object obj3 = this + 16;
		if (_viewDismissedHandler != null)
		{
			int num2 = int.Parse(array[0]);
			string text2 = array[1];
			bool flag = text2._stringLength >= 1;
			bool flag2 = !flag;
			string text3 = null;
			if (!flag2)
			{
				text3 = array[1];
			}
			int num3 = int.Parse(array[2]);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S0_v33+C] (should have been resolved before IL gen)");
		}
		obj3 = 0;
	}

	private unsafe static string UnescapeResultString(string s)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		bool flag = s == null;
		string result = null;
		if (!flag)
		{
			if (!s.Contains("&#124;"))
			{
				result = s;
			}
			else
			{
				_ = 124;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				char c = (char)(obj + 14);
				string newValue = ((char*)(ushort)c)->ToString(invariantCulture);
				string text = s.Replace("&#124;", newValue);
				result = text;
			}
		}
		return result;
	}

	private static void LogError(string msg)
	{
		string text = "[GameCenter] " + msg;
	}

	private static void LogWarning(string msg)
	{
	}

	private static void Log(string msg)
	{
	}
}
