using System;
using Cpp2ILInjected;
using Kiloo;
using SYBO.Subway;
using UnityEngine;

public class TopRunNotificationSlideInManager : MonoBehaviour
{
	private int[] _warningTimesInMinutes;

	private bool[] _areWarningTimesGameOnly;

	private bool _isCurrentWarningTimerGameOnly;

	private const string GAME_OBJECT_NAME = "TopRunNotificationManager";

	private static TopRunNotificationSlideInManager _instance;

	private float timeUntilSlideInInSeconds;

	private int timeToShowOnLabel;

	private float timeLeftForCurrentWarning;

	private bool _doUseTimer;

	private DateTime _originalTourEndDate;

	private static bool _applicationIsQuitting;

	public static TopRunNotificationSlideInManager instance
	{
		get
		{
			Init();
			return _instance;
		}
	}

	public static void Init()
	{
		if (_instance == null && !_applicationIsQuitting)
		{
			GameObject gameObject = default;
			gameObject._002Ector();
			gameObject.name = "TopRunNotificationManager";
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			TopRunNotificationSlideInManager topRunNotificationSlideInManager = gameObject.AddComponent<TopRunNotificationSlideInManager>();
			_instance = topRunNotificationSlideInManager;
			_instance.CalculateNextWarningTime();
		}
	}

	private void Update()
	{
		if (~(_doUseTimer ? 1u : 0u) != 0)
		{
			return;
		}
		float deltaTime = RealTimeTracker.deltaTime;
		if (!((timeLeftForCurrentWarning -= deltaTime) < 0f))
		{
			return;
		}
		if (~(_isCurrentWarningTimerGameOnly ? 1u : 0u) == 0)
		{
			Game game = Game.Instance;
			if (game != null)
			{
				Game game2 = Game.Instance;
				Variable<bool> isInGame = game2.IsInGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v46 (Variable`1<System.Boolean>)+8]");
				if ((nint)0 != 0 && UIScreenController.IsInstanced)
				{
					UIScreenController uIScreenController = UIScreenController.Instance;
					UIScreenController.SlideIn slideIn = default;
					slideIn._002Ector(UIScreenController.SlideInType.TopRunTimer, timeToShowOnLabel);
					uIScreenController.QueueSlideIn(slideIn);
				}
			}
		}
		else if (UIScreenController.IsInstanced)
		{
			UIScreenController uIScreenController2 = UIScreenController.Instance;
			UIScreenController.SlideIn slideIn2 = default;
			slideIn2._002Ector(UIScreenController.SlideInType.TopRunTimer, timeToShowOnLabel);
			uIScreenController2.QueueSlideIn(slideIn2);
		}
		_doUseTimer = false;
		CalculateNextWarningTime();
	}

	private void InitiateWarningTimes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
			DateTime dateTime = default;
			if (_originalTourEndDate != dateTime)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
				DateTime originalTourEndDate = default;
				_originalTourEndDate = originalTourEndDate;
				CalculateNextWarningTime();
			}
		}
	}

	private unsafe void CalculateNextWarningTime()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected VT, but got Unknown
		//IL_00aa: Expected F8, but got I
		//IL_00aa: Expected Ref, but got VT
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected VT, but got Unknown
		//IL_018a: Expected native int or pointer, but got VT
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected VT, but got Unknown
		//IL_01b7: Expected VT, but got I
		//IL_01b7: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		_doUseTimer = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = default;
		if (obj3 == null)
		{
			return;
		}
		object obj4 = default;
		DateTime dateTime3 = default;
		object obj7 = default;
		while (true)
		{
			int[] warningTimesInMinutes = _warningTimesInMinutes;
			if ((nint)obj4 < warningTimesInMinutes.Length)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
				DateTime utcNow = CDateTime.UtcNow;
				object obj5 = obj4 << 2;
				object obj6 = (object)_warningTimesInMinutes + obj5;
				DateTime dateTime = (DateTime)(obj + 24);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v30+10]");
				DateTime dateTime2 = ((DateTime*)dateTime)->AddMinutes(0.0);
				if (!(dateTime3 > dateTime2))
				{
					obj4 = obj7 + 1;
					continue;
				}
				object obj8 = obj4 + (object)_areWarningTimesGameOnly;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v27+10]");
				_isCurrentWarningTimerGameOnly = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
				object obj9 = obj4 << 2;
				object obj10 = (object)_warningTimesInMinutes + obj9;
				_ = 0;
				TimeSpan timeSpan = (TimeSpan)(obj + 8);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v43+10]");
				*(TimeSpan*)(nint)timeSpan = new TimeSpan(0, 0, 0, 0);
				DateTime dateTime4 = (DateTime)(obj + 24);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				DateTime dateTime5 = ((DateTime*)dateTime4)->Subtract((TimeSpan)0);
				DateTime utcNow2 = CDateTime.UtcNow;
				TimeSpan timeSpan2 = dateTime5 - utcNow2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				double num = 0.0 * 1E-07;
				timeUntilSlideInInSeconds = (float)num;
				object obj11 = obj4 << 2;
				object obj12 = (object)_warningTimesInMinutes + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v47+10]");
				timeToShowOnLabel = 0;
				_doUseTimer = true;
				timeLeftForCurrentWarning = timeUntilSlideInInSeconds;
				break;
			}
			break;
		}
	}

	private void OnEnable()
	{
		TopRunEventsHandler topRunEventsHandler = TopRunEventsHandler.instance;
		throw new ArgumentException();
	}

	private void OnDisable()
	{
		TopRunEventsHandler topRunEventsHandler = TopRunEventsHandler.instance;
		throw new ArgumentException();
	}

	private void TournamentChanged(object sender, EventArgs eventArg)
	{
		InitiateWarningTimes();
	}

	private void OnApplicationQuit()
	{
		_applicationIsQuitting = true;
		_instance = null;
	}

	public TopRunNotificationSlideInManager()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int[] array = default;
		array[0] = 10;
		array[1] = 1;
		_warningTimesInMinutes = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		bool[] array2 = default;
		array2[1] = true;
		_areWarningTimesGameOnly = array2;
		timeLeftForCurrentWarning = 10000000f;
		_originalTourEndDate = DateTime.MinValue;
		base._002Ector();
	}
}
