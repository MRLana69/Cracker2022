using System;
using System.IO;
using Cpp2ILInjected;
using Kiloo;
using SYBO.Subway;
using TopRun;
using TopRun.UI;
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
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected Obj, but got Unknown
			if (TopRunEventsHandler._instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				TopRunEventsHandler topRunEventsHandler = default;
				TopRunEventsHandler._instance = topRunEventsHandler;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
				TopRunNotificationSlideInManager topRunNotificationSlideInManager = instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				NullReferenceException ex = new NullReferenceException();
				object obj2 = default;
				object obj = obj2 + 16;
				obj = topRunNotificationSlideInManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			}
			return (TopRunNotificationSlideInManager)(object)TopRunEventsHandler._instance;
		}
	}

	public static void Init()
	{
	}

	private void Update()
	{
	}

	private void InitiateWarningTimes()
	{
		//IL_02ff: Expected I, but got Obj
		//IL_0315: Expected Obj, but got I
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_0340: Expected I, but got Obj
		//IL_043d: Expected I, but got Obj
		//IL_0453: Expected Obj, but got I
		//IL_038d: Expected I, but got Obj
		//IL_03a3: Expected Obj, but got I
		//IL_047a: Expected Obj, but got I4
		//IL_00bb: Expected I, but got Obj
		//IL_0599: Expected Obj, but got I4
		//IL_0108: Expected I, but got Obj
		//IL_03ce: Expected I, but got Obj
		//IL_0155: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_04b9: Expected Obj, but got I
		//IL_0196: Expected I, but got Obj
		//IL_01e3: Expected I, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_0224: Expected I, but got Obj
		//IL_0271: Expected I, but got Obj
		//IL_0287: Expected Obj, but got I
		//IL_0539: Expected Obj, but got I4
		//IL_02b2: Expected I, but got Obj
		if (~(_doUseTimer ? 1u : 0u) != 0)
		{
			return;
		}
		float aspectRatio = Utils.GetAspectRatio();
		float num = timeLeftForCurrentWarning - aspectRatio;
		timeLeftForCurrentWarning = num;
		if (!(timeLeftForCurrentWarning < 0f))
		{
			return;
		}
		if (~(_isCurrentWarningTimerGameOnly ? 1u : 0u) == 0)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v40 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v83 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)isInstantiated).FindKernel(null) != 0)
			{
				nint num6 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v49 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v79 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated2 = Game.IsInstantiated;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v54 (System.Boolean)+60]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v55+8]");
				if ((nint)0 != 0)
				{
					nint num8 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v58 (Il2CppClass<UIScreenController>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num9 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v75 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UIScreenController uIScreenController = UIScreenController.Instance;
					if ((object)uIScreenController != null)
					{
						nint num10 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v65 (Il2CppClass<UIScreenController>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num11 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v71 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UIScreenController.ShouldShowOnlineScreen();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						string text = default;
						text.m_stringLength = 0;
						_ = timeToShowOnLabel;
						((UIScreenController)flag)._QueueMessage(text);
					}
				}
			}
		}
		else
		{
			nint num12 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num13 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v35 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIScreenController uIScreenController2 = UIScreenController.Instance;
			if ((object)uIScreenController2 != null)
			{
				nint num14 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v25 (Il2CppClass<UIScreenController>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num15 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v31 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = UIScreenController.ShouldShowOnlineScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text2 = default;
				text2.m_stringLength = 0;
				_ = timeToShowOnLabel;
				((UIScreenController)flag2)._QueueMessage(text2);
			}
		}
		_doUseTimer = false;
		OnEnable();
	}

	private void CalculateNextWarningTime()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_015e: Expected Obj, but got VT
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_006d: Expected I, but got Obj
		//IL_00df: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 16;
		object obj5 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj6 = default;
		if (obj6 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v29 (Il2CppClass<System.DateTime>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v47 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj4 = _originalTourEndDate;
		object obj8 = default;
		obj5 = obj8;
		obj3 = obj4;
		obj = obj5;
		object obj9 = obj3 & 0x3FFFFFFFFFFFFFFFL;
		object obj10 = obj & 0x3FFFFFFFFFFFFFFFL;
		if (obj9 != obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
			object obj11 = default;
			obj2 = obj11;
			obj = obj2;
			_originalTourEndDate = (DateTime)obj;
			OnEnable();
		}
	}

	private unsafe void OnEnable()
	{
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected VT, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_02fc: Expected Obj, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0313: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got VT
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_036d: Expected I8, but got Obj
		//IL_0368: Expected native int or pointer, but got VT
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_00e3: Expected I, but got Obj
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01c3: Expected Obj, but got I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0203: Expected I, but got Obj
		//IL_0219: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got VT
		//IL_03e5: Expected I8, but got Obj
		//IL_03e0: Expected native int or pointer, but got VT
		//IL_03fa: Expected Ref, but got VT
		//IL_0406: Expected Obj, but got I8
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_0459: Expected I4, but got Obj
		//IL_0244: Expected I, but got Obj
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 72);
		DateTime dateTime = (DateTime)(obj - -64);
		object obj2 = obj + 56;
		object obj3 = obj + 40;
		object obj4 = obj + 24;
		object obj5 = obj + 16;
		object obj6 = obj + 8;
		object obj7 = obj + 48;
		obj7 = 0;
		object obj8 = obj + 32;
		obj8 = 0;
		_doUseTimer = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj9 = default;
		if (obj9 == null)
		{
			return;
		}
		object obj10 = default;
		object obj15 = default;
		object obj16 = default;
		object obj18 = default;
		object obj21 = default;
		DateTime today2;
		while (true)
		{
			int[] warningTimesInMinutes = _warningTimesInMinutes;
			if ((nint)obj10 >= warningTimesInMinutes.Length)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
			DateTime today = CDateTime.Today;
			obj7 = today;
			object obj11 = _warningTimesInMinutes + 16;
			object obj12 = obj10 << 2;
			object obj13 = obj11 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC9F");
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v44 (Il2CppClass<System.DateTime>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v93 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = obj15;
			obj3 = obj16;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj2;
			formatProvider = (IFormatProvider)obj3;
			long num3 = (long)(dateTime.dateData & 0x3FFFFFFFFFFFFFFFL);
			object obj17 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
			if (num3 <= (long)obj17)
			{
				obj10 = obj18 + 1;
				continue;
			}
			object obj19 = _areWarningTimesGameOnly + 16;
			object obj20 = obj19 + obj10;
			bool isCurrentWarningTimerGameOnly = obj20 != null;
			_isCurrentWarningTimerGameOnly = isCurrentWarningTimerGameOnly;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
			obj7 = obj21;
			object obj22 = _warningTimesInMinutes + 16;
			object obj23 = obj10 << 2;
			object obj24 = obj22 + obj23;
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3CD");
			obj5 = obj4;
			formatProvider = (IFormatProvider)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD8");
			today2 = CDateTime.Today;
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v74 (Il2CppClass<System.DateTime>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num5 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v87 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			break;
		}
		object obj26 = default;
		obj6 = obj26;
		obj = today2;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj6;
		formatProvider = (IFormatProvider)obj;
		long num6 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj8 = num6;
		double num7 = (double)obj8 * 1E-07;
		timeUntilSlideInInSeconds = (float)num7;
		object obj27 = _warningTimesInMinutes + 16;
		object obj28 = obj10 << 2;
		object obj29 = obj27 + obj28;
		timeToShowOnLabel = (int)obj29;
		timeLeftForCurrentWarning = timeUntilSlideInInSeconds;
		_doUseTimer = true;
	}

	private void OnDisable()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		TopRunNotificationSlideInManager topRunNotificationSlideInManager = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		EventHandler<TournamentChangedEventArgs> eventHandler = default;
		object obj = eventHandler + 16;
		obj = this;
		((TopRunEventsHandler)(object)topRunNotificationSlideInManager).OnTopRunChangedEvent -= eventHandler;
	}

	private void TournamentChanged(object sender, EventArgs eventArg)
	{
		//IL_0040: Expected Obj, but got I
		bool flag = eventArg == null;
		bool flag2 = !flag;
		TopRunNormalStateHelper e = (TopRunNormalStateHelper)(object)eventArg;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			TopRunNormalStateHelper topRunNormalStateHelper = default;
			topRunNormalStateHelper.InitNormalState();
			_ = 1;
			e = topRunNormalStateHelper;
		}
		if (((UnityEngine.Object)this).m_CachedPtr != (IntPtr)0)
		{
			((EventHandler<TournamentChangedEventArgs>)(nint)((UnityEngine.Object)this).m_CachedPtr)(this, (TournamentChangedEventArgs)(object)e);
		}
	}

	private void OnApplicationQuit()
	{
		//IL_0035: Expected Obj, but got I4
		TopRunNotificationSlideInManager topRunNotificationSlideInManager = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		((AwardCollectibleHelper)(object)topRunNotificationSlideInManager).AddSocialLockCanOverlay(flag);
	}

	public TopRunNotificationSlideInManager()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(TopRunNotificationSlideInManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<TopRunNotificationSlideInManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TopRunNotificationSlideInManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<TopRunNotificationSlideInManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_applicationIsQuitting = true;
		_instance = null;
	}

	static TopRunNotificationSlideInManager()
	{
		//IL_023c: Expected I, but got Obj
		//IL_0252: Expected Obj, but got I
		//IL_0310: Expected I, but got Obj
		//IL_0326: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0153: Expected I4, but got Obj
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_02b7: Expected I, but got Obj
		//IL_02cd: Expected Obj, but got I
		//IL_01a2: Expected I, but got Obj
		//IL_01ef: Expected I, but got Obj
		nint num = (nint)typeof(TopRunNotificationSlideInManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<TopRunNotificationSlideInManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TopRunNotificationSlideInManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v63 (Il2CppClass<TopRunNotificationSlideInManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(_instance != null))
		{
			return;
		}
		nint num5 = (nint)typeof(TopRunNotificationSlideInManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<TopRunNotificationSlideInManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(TopRunNotificationSlideInManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v57 (Il2CppClass<TopRunNotificationSlideInManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_applicationIsQuitting ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Stream stream = default;
		UnityEngine.ManagedStreamHelpers.ValidateLoadFromStream(stream);
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)stream, (byte)(int)"TopRunNotificationManager" != 0);
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v53 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)stream).Exec();
		TopRunNotificationSlideInManager topRunNotificationSlideInManager = ((GameObject)(object)stream).AddComponent<TopRunNotificationSlideInManager>();
		nint num9 = (nint)typeof(TopRunNotificationSlideInManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v37 (Il2CppClass<TopRunNotificationSlideInManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(TopRunNotificationSlideInManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v47 (Il2CppClass<TopRunNotificationSlideInManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_instance = topRunNotificationSlideInManager;
		_instance.OnEnable();
	}
}
