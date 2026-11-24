using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Components.Utilities;
using SYBO.Subway.Info;
using UI.Screens.RewardManagement;
using UnityEngine;
using WeeklyHunt;

namespace Debugging;

public class FPSCounter : MonoBehaviour
{
	public UILabel OptionalMinFPSLabel;

	public float UpdateInterval;

	private UILabel _label;

	private float accum;

	private int frames;

	private float timeleft;

	private float maxFrame;

	private bool _visible;

	private static FPSCounter _instance;

	private GameObject _prefabInstanceRoot;

	public unsafe bool Visible
	{
		get
		{
			//IL_0673: Expected I, but got Obj
			//IL_0689: Expected Obj, but got I
			//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ac: Expected VT, but got Unknown
			//IL_07b9: Expected I4, but got Obj
			//IL_07b4: Expected native int or pointer, but got VT
			//IL_07c9: Expected native int or pointer, but got VT
			//IL_07de: Expected native int or pointer, but got VT
			//IL_07f3: Expected native int or pointer, but got VT
			//IL_080e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0813: Expected Obj, but got Unknown
			//IL_01db: Expected I, but got Obj
			//IL_01f1: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_06dc: Expected I4, but got Obj
			//IL_021c: Expected I, but got Obj
			//IL_0269: Expected I, but got Obj
			//IL_027f: Expected Obj, but got I
			//IL_06f7: Expected I4, but got Obj
			//IL_02aa: Expected I, but got Obj
			//IL_02f7: Expected I, but got Obj
			//IL_030d: Expected Obj, but got I
			//IL_0712: Expected I4, but got Obj
			//IL_0338: Expected I, but got Obj
			//IL_0385: Expected I, but got Obj
			//IL_039b: Expected Obj, but got I
			//IL_072d: Expected I4, but got Obj
			//IL_03c6: Expected I, but got Obj
			//IL_0413: Expected I, but got Obj
			//IL_0429: Expected Obj, but got I
			//IL_0748: Expected I4, but got Obj
			//IL_0454: Expected I, but got Obj
			//IL_04a1: Expected I, but got Obj
			//IL_04b7: Expected Obj, but got I
			//IL_0763: Expected I4, but got Obj
			//IL_04e2: Expected I, but got Obj
			//IL_052f: Expected I, but got Obj
			//IL_0545: Expected Obj, but got I
			//IL_077e: Expected I4, but got Obj
			//IL_0570: Expected I, but got Obj
			//IL_05bd: Expected I, but got Obj
			//IL_05d3: Expected Obj, but got I
			//IL_0799: Expected I4, but got Obj
			//IL_05fe: Expected I, but got Obj
			//IL_014d: Expected I, but got Obj
			//IL_0163: Expected Obj, but got I
			//IL_06bc: Expected I4, but got Obj
			//IL_018e: Expected I, but got Obj
			//IL_0646: Expected I4, but got Obj
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			_ = UpdateInterval;
			_ = accum;
			nint num = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v138 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WeeklyHuntData.PrizeData prizeData = (WeeklyHuntData.PrizeData)(this + 28);
			((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
			((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
			string text = WeeklyHuntManager.Get(prizeData);
			object obj2 = text - 1;
			if ((nint)text != 1)
			{
				if ((nint)obj2 != 1)
				{
					if ((nint)obj2 != 2)
					{
						if ((nint)obj2 != 3)
						{
							if ((nint)obj2 != 4)
							{
								if ((nint)obj2 != 5)
								{
									if ((nint)obj2 != 6)
									{
										if ((nint)obj2 != 7)
										{
											if ((nint)obj2 == 8)
											{
												nint num3 = (nint)typeof(Strings);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v123 (Il2CppClass<Strings>)+BA]");
												object obj3 = (nint)0 & (nint)0x200;
												if (obj3 != null)
												{
													nint num4 = (nint)typeof(Strings);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v130 (Il2CppClass<Strings>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												string text2 = Strings.GetDefault("WEEKLYHUNT_PRIZE_CHERRY_SHORT");
												return (byte)(int)text2 != 0;
											}
											return (byte)(int)string.Empty != 0;
										}
										nint num5 = (nint)typeof(Strings);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v111 (Il2CppClass<Strings>)+BA]");
										object obj4 = (nint)0 & (nint)0x200;
										if (obj4 != null)
										{
											nint num6 = (nint)typeof(Strings);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v118 (Il2CppClass<Strings>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										string text3 = Strings.GetDefault("HOVERBOARDS_LONDONBOARD03");
										return (byte)(int)text3 != 0;
									}
									nint num7 = (nint)typeof(Strings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v99 (Il2CppClass<Strings>)+BA]");
									object obj5 = (nint)0 & (nint)0x200;
									if (obj5 != null)
									{
										nint num8 = (nint)typeof(Strings);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v106 (Il2CppClass<Strings>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									string text4 = Strings.GetDefault("WEEKLYHUNT_PRIZE_RIO_SHORT");
									return (byte)(int)text4 != 0;
								}
								nint num9 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v87 (Il2CppClass<Strings>)+BA]");
								object obj6 = (nint)0 & (nint)0x200;
								if (obj6 != null)
								{
									nint num10 = (nint)typeof(Strings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v94 (Il2CppClass<Strings>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								string text5 = Strings.GetDefault("HOVERBOARDS_LONDONBOARD01");
								return (byte)(int)text5 != 0;
							}
							nint num11 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v75 (Il2CppClass<Strings>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num12 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v82 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string text6 = Strings.GetDefault("WEEKLYHUNT_PRIZE_HEADSTART_TITLE_SHORT");
							return (byte)(int)text6 != 0;
						}
						nint num13 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v63 (Il2CppClass<Strings>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num14 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v70 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text7 = Strings.GetDefault("WEEKLYHUNT_PRIZE_SCOREBOOSTER_TITLE_SHORT");
						return (byte)(int)text7 != 0;
					}
					nint num15 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v51 (Il2CppClass<Strings>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num16 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v58 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text8 = Strings.GetDefault("WEEKLYHUNT_PRIZE_HOVERBOARD_TITLE_SHORT");
					return (byte)(int)text8 != 0;
				}
				nint num17 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v39 (Il2CppClass<Strings>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num18 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v46 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text9 = Strings.GetDefault("WEEKLYHUNT_PRIZE_SUPERMYSTERYBOX_TITLE_SHORT");
				return (byte)(int)text9 != 0;
			}
			nint num19 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v27 (Il2CppClass<Strings>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num20 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v34 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text10 = Strings.GetDefault("WEEKLYHUNT_PRIZE_KEYS_TITLE_SHORT");
			return (byte)(int)text10 != 0;
		}
	}

	public static FPSCounter Instance
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (FPSCounter)WeeklyHuntData.GetActivePeriod();
		}
	}

	private void Awake()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = string.Empty;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<int> list = default;
		list._002Ector();
		list.Add(0);
		list.Add(0);
		list.Add(0);
		list.Add(0);
		object obj2 = this + 12;
		obj2 = list;
	}

	private void Update()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		_instance = this;
		object obj = this + 20;
		UILabel component = GetComponent<UILabel>();
		obj = component;
		timeleft = UpdateInterval;
	}

	public static FPSCounter Create(GameObject anchor)
	{
		//IL_001f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [anchor @ L0 (UnityEngine.GameObject)+28]");
		bool flag = (nint)0 != 0;
		return (FPSCounter)flag;
	}

	public void ToggleVisible(bool visible)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00e7: Expected F4, but got I
		//IL_00f9: Expected F4, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FPSCounter instance = Instance;
		WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance).get_Item(visible ? 1 : 0);
		object obj2 = weeklyHuntPeriodData + 40;
		FPSCounter fPSCounter = (FPSCounter)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6+8]");
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6+10]");
		UpdateInterval = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6+18]");
		accum = 0f;
	}

	public unsafe FPSCounter()
	{
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected I4, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected Obj, but got Unknown
		//IL_039b: Expected Obj, but got I4
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03b8: Expected Obj, but got I4
		//IL_0032: Expected VT, but got Obj
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_00ea: Expected I, but got Obj
		//IL_0444: Expected Obj, but got I4
		//IL_0459: Expected Obj, but got F4
		//IL_0484: Expected I4, but got Obj
		//IL_01e2: Expected I4, but got Obj
		//IL_022e: Expected I, but got Obj
		//IL_0244: Expected Obj, but got I
		//IL_026f: Expected I, but got Obj
		//IL_04c3: Expected Obj, but got I4
		//IL_04d8: Expected Obj, but got F4
		//IL_0503: Expected I4, but got Obj
		//IL_034a: Expected I4, but got Obj
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 40);
		object obj2 = obj + 24;
		obj2 = 0;
		_ = 0;
		object obj3 = obj + 8;
		obj3 = 0;
		_ = 0;
		if (~(_visible ? 1u : 0u) != 0)
		{
			return;
		}
		float unscaledTime = Time.unscaledTime;
		float num = timeleft - unscaledTime;
		timeleft = num;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float unscaledTime2 = Time.unscaledTime;
		float num2 = realtimeSinceStartup / unscaledTime2;
		float num3 = accum + num2;
		accum = num3;
		int num4 = frames + 1;
		frames = num4;
		float unscaledTime3 = Time.unscaledTime;
		nint num5 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v74 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num7 = ((!(maxFrame > unscaledTime3)) ? unscaledTime3 : maxFrame);
		maxFrame = num7;
		if (timeleft > 0f)
		{
			return;
		}
		float num8 = accum / (float)frames;
		if (!(num8 < 30f))
		{
			Color blue = Color.blue;
		}
		else if (num8 > 10f)
		{
			Color green = Color.green;
		}
		else
		{
			Color magenta = Color.magenta;
		}
		obj2 = ((UIWidget.Pivot*)(int)pivot)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UIWidget+Pivot)+8]");
		_ = 0;
		obj = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = $"{args:F1} FPS";
		_label.fontSize = (int)text;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		_ = 0;
		_label.rawPivot = pivot;
		timeleft = UpdateInterval;
		accum = 0f;
		frames = 0;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v76 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)OptionalMinFPSLabel).FindKernel((string)null) != 0)
		{
			float num11 = 1f / maxFrame;
			if (!(num11 < 30f))
			{
				Color blue2 = Color.blue;
			}
			else if (num11 > 10f)
			{
				Color green2 = Color.green;
			}
			else
			{
				Color magenta2 = Color.magenta;
			}
			obj3 = ((UIWidget.Pivot*)(int)pivot)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UIWidget+Pivot)+8]");
			_ = 0;
			obj = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args2 = default;
			string text2 = $"{args2:F1} MIN";
			OptionalMinFPSLabel.fontSize = (int)text2;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
			_ = 0;
			OptionalMinFPSLabel.rawPivot = pivot;
			maxFrame = 0f;
		}
	}
}
