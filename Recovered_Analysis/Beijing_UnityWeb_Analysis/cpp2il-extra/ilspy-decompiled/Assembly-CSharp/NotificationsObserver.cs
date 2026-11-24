using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using Info;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using UnityEngine;

public class NotificationsObserver : MonoBehaviour
{
	public delegate void NotificationHandler(Notification notification);

	private static readonly IJsonSerializer _jsonConverter;

	private NotificationHandler m_onNotificationReceived;

	private Action<Notification> m_onNotificationPressed;

	private const string TITLE_DICT_KEY = "title";

	private const string MESSAGE_DICT_KEY = "message";

	private const string TYPE_DICT_KEY = "type";

	private const string SOUNDNAME_DICT_KEY = "soundName";

	private const string USERINFO_DICT_KEY = "userInfo";

	private static NotificationsObserver _instance;

	public static NotificationsObserver instance
	{
		get
		{
			//IL_001d: Expected Obj, but got I4
			bool flag = LoadLevelCtrl.StartupFinished__BackingField;
			return (NotificationsObserver)flag;
		}
	}

	public event NotificationHandler onNotificationReceived
	{
		add
		{
			//IL_0006: Expected I4, but got Obj
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected I4, but got Unknown
			//IL_0021: Expected I4, but got Obj
			int mysteryBoxesOpened = PlayerSave.GetMysteryBoxesOpened((MysteryBox.Type)this);
			int value2 = value + mysteryBoxesOpened;
			PlayerSave.MigrateMysteryBoxOpened((MysteryBox.Type)this, value2);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onNotificationReceived;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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
	}

	public event Action<Notification> onNotificationPressed
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onNotificationReceived;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onNotificationPressed;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
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
	}

	private void Awake()
	{
	}

	private void OnApplicationPause(bool pause)
	{
		//IL_0066: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_onNotificationPressed;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)pause);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 16;
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

	private unsafe bool DidAppStartFromNotificationAndroid(out Notification notification)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03e7: Expected Obj, but got I4
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0447: Expected Obj, but got I
		//IL_0457: Expected Obj, but got I
		//IL_0467: Expected Obj, but got I
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected Obj, but got Unknown
		//IL_0062: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_04c0: Expected I4, but got Obj
		//IL_00f0: Expected I, but got Obj
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got I4
		//IL_029f: Expected Obj, but got I
		//IL_033b: Expected Obj, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01ca: Expected Obj, but got I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if ((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref notification) > (nint)(-1))
		{
			nint num = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v16 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v119 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S2_v5 (Il2CppMethodInfo)+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S2_v6+60]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S2_v7+44]");
			object obj8 = 0;
			object obj9 = obj8 & 0x1FFF;
			object obj10 = obj9 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S3_v5 (should have been resolved before IL gen)");
			object obj11 = default;
			if ((nint)obj11 > -1)
			{
				nint num4 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v26 (Il2CppClass<HoverboardThemes>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num5 = (nint)typeof(HoverboardThemes);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v113 (Il2CppClass<HoverboardThemes>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item((Boards.BoardId)this);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				object obj13 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj13 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v97+20]");
						if (null == System.Runtime.CompilerServices.Unsafe.AsPointer(ref notification))
						{
							object obj14 = obj4 + 4;
							object obj15 = obj14 + 1;
							obj14 = obj15;
							object obj16 = obj15 << 2;
							object obj17 = obj4 + obj16;
							obj17 = 93;
							break;
						}
						continue;
					}
					object obj18 = obj4 + 4;
					object obj19 = obj18 + 1;
					obj18 = obj19;
					object obj20 = obj19 << 2;
					object obj21 = obj4 + obj20;
					obj21 = 89;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+4]");
					object obj22 = (nint)0 << 2;
					object obj23 = obj4 + obj22;
					if ((nint)obj23 == 93)
					{
						object obj24 = obj4 + 4;
						if ((nint)obj24 > -1)
						{
							object obj25 = obj24 + -1;
							obj24 = obj25;
						}
						goto IL_0584;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+4]");
					object obj26 = (nint)0 << 2;
					object obj27 = obj4 + obj26;
					if ((nint)obj27 == 89)
					{
						object obj28 = obj4 + 4;
						if ((nint)obj28 > -1)
						{
							object obj29 = obj28 + -1;
							obj28 = obj29;
						}
						goto IL_0584;
					}
				}
				object obj30 = default;
				if (obj30 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
			}
		}
		goto IL_0584;
		IL_0584:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v97+28]");
		return false;
	}

	private unsafe bool DidAppStartFromNotificationIOS(out Notification notification)
	{
		ref Notification reference = ref *(Notification*)null;
		return false;
	}

	private void Start()
	{
		//IL_01f1: Expected I, but got Obj
		//IL_0207: Expected Obj, but got I
		//IL_02b5: Expected I, but got Obj
		//IL_02cb: Expected Obj, but got I
		//IL_0305: Expected I, but got Obj
		//IL_031b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0266: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I
		//IL_00b8: Expected I, but got Obj
		//IL_0156: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_01a3: Expected I, but got Obj
		//IL_00d4: Expected I, but got Obj
		//IL_0104: Expected I, but got Obj
		//IL_012a: Expected I, but got Obj
		nint num = (nint)typeof(NotificationsObserver);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NotificationsObserver>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NotificationsObserver);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<NotificationsObserver>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _instance != null;
		nint num5 = (nint)typeof(NotificationsObserver);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v10 (Il2CppClass<NotificationsObserver>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag2 = obj3 != null;
		if (flag)
		{
			bool flag3 = !flag2;
			nint num6 = (nint)typeof(NotificationsObserver);
			if (!flag3)
			{
				nint num7 = (nint)typeof(NotificationsObserver);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v30 (Il2CppClass<NotificationsObserver>)+74]");
				bool flag4 = (nint)0 == 0;
				bool flag5 = !flag4;
				num6 = (nint)typeof(NotificationsObserver);
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num6 = (nint)typeof(NotificationsObserver);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ L1_v6 (Il2CppClass<NotificationsObserver>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = this;
			return;
		}
		if (flag2)
		{
			nint num8 = (nint)typeof(NotificationsObserver);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v21 (Il2CppClass<NotificationsObserver>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
		string obj5 = tag;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj5);
	}

	private void onAndroidNotificationReceived()
	{
	}

	private void alertListeners(string title, string message, string type, Dictionary<string, object> userInfo, string soundName = "")
	{
		//IL_035e: Expected I, but got Obj
		//IL_0374: Expected Obj, but got I
		//IL_042b: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_039a: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_03c5: Expected I4, but got Obj
		//IL_019c: Expected Obj, but got I4
		//IL_012f: Expected I, but got Obj
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_029a: Expected I, but got Obj
		//IL_02b0: Expected Obj, but got I
		//IL_03f8: Expected Obj, but got I4
		//IL_02db: Expected I, but got Obj
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v63 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 <= -1)
		{
			return;
		}
		nint num4 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v17 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v59 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!CharacterManager.IsCollectionComplete((Characters.CharacterId)title))
		{
			return;
		}
		nint num6 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v24 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v53 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)title);
		if (~(model.hasOnlineSettings ? 1u : 0u) == 0)
		{
			object obj10 = type + 1;
			string text = (string)obj10;
			return;
		}
		object obj11 = model.unlockType - 1;
		if (model.unlockType != PurchaseData.UnlockType.Tokens)
		{
			if ((nint)obj11 != 1 && (nint)obj11 != 2 && (nint)obj11 != 3 && (nint)obj11 != 4 && (nint)obj11 != 5 && (nint)obj11 == 6)
			{
				nint num8 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v39 (Il2CppClass<SocialManager>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num9 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v48 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
				if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
				{
					object obj13 = soundName + 1;
					string text2 = (string)obj13;
				}
			}
			else
			{
				object obj14 = message + 1;
				string text3 = (string)obj14;
			}
		}
		else
		{
			object obj15 = userInfo + 1;
			Dictionary<string, object> dictionary = (Dictionary<string, object>)obj15;
		}
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_00c3: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		object obj = 0;
		if ((object)context != null)
		{
			return;
		}
		obj = 0;
		string dataPath = Application.dataPath;
		object obj2 = dataPath - 8;
		if ((nint)dataPath != 8)
		{
			if ((nint)obj2 != 1 && (nint)obj2 != 2 && (nint)obj2 == 3)
			{
				obj = 0;
			}
		}
		else
		{
			obj = 0;
		}
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public NotificationsObserver()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0381: Expected I, but got Obj
		//IL_0397: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_03fc: Expected Obj, but got I4
		//IL_02bb: Expected Obj, but got I
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v160 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError("Notification received");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A44");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj4 = default;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj4 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj5 == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			if (obj6 == null || obj6 == typeof(string))
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			if (obj7 != null)
			{
				if (obj7 != typeof(string))
				{
					obj7 = 0;
				}
			}
			else
			{
				obj7 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			if (obj8 != null)
			{
				if (obj8 != typeof(string))
				{
					obj8 = 0;
				}
			}
			else
			{
				obj8 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E");
		}
		object obj9 = obj2 + 4;
		object obj10 = obj9 + 1;
		obj9 = obj10;
		object obj11 = obj10 << 2;
		object obj12 = obj2 + obj11;
		obj12 = 140;
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj2 + obj14;
			if ((nint)obj15 == 140)
			{
				object obj16 = obj2 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				return;
			}
		}
		object obj18 = default;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	static NotificationsObserver()
	{
		RandomizeOffset.RandomOffsetsFieldName = "randomOffsets";
	}
}
