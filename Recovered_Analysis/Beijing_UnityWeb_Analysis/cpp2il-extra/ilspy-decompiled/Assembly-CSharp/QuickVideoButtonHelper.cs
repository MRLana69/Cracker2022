using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Info.VideoRewardCooldowns;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using UI.Screens.RewardManagement;
using UI.SlideIns;
using UI.VideoAdPrizes;
using UnityEngine;
using WeeklyHunt;

public class QuickVideoButtonHelper : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__15_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			DebugSettingsPopup._003C_003Ec obj = default;
			DebugSettingsPopup._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CStartVideoWithDelay_003Eb__15_0()
		{
		}
	}

	private sealed class _003CStartVideoWithDelay_003Ed__15(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public QuickVideoButtonHelper _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0065: Expected Obj, but got I4
				//IL_008c: Expected I, but got Obj
				//IL_00a2: Expected Obj, but got I
				//IL_022d: Expected I, but got Obj
				//IL_0243: Expected Obj, but got I
				//IL_00cd: Expected I, but got Obj
				//IL_011a: Expected I, but got Obj
				//IL_0167: Expected I, but got Obj
				//IL_017d: Expected Obj, but got I
				//IL_0289: Unknown result type (might be due to invalid IL or missing references)
				//IL_028e: Expected Obj, but got Unknown
				//IL_02a5: Expected I, but got Obj
				//IL_02bb: Expected Obj, but got I
				//IL_01a8: Expected I, but got Obj
				QuickVideoButtonHelper quickVideoButtonHelper = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						OfferWallManager instance = OfferWallManager.instance;
						nint num = (nint)typeof(AdLocations);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v11 (Il2CppClass<AdLocations>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(AdLocations);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v19 (Il2CppClass<AdLocations>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						nint num3 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v4 (Il2CppClass<QuickVideoButtonHelper+<>c>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num4 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S2_v38 (Il2CppClass<QuickVideoButtonHelper+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = _003C_003Ec._003C_003E9__15_0 == null;
						bool flag2 = !flag;
						string adLocationID = (string)(object)_003C_003Ec._003C_003E9__15_0;
						if (!flag2)
						{
							nint num5 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S2_v15 (Il2CppClass<QuickVideoButtonHelper+<>c>)+BA]");
							object obj3 = (nint)0 & (nint)0x200;
							if (obj3 != null)
							{
								nint num6 = (nint)typeof(_003C_003Ec);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S2_v32 (Il2CppClass<QuickVideoButtonHelper+<>c>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num7 = 0;
							string text = default;
							text.m_stringLength = (int)num7;
							_ = 0;
							object obj4 = text + 16;
							obj4 = _003C_003Ec._003C_003E9;
							nint num8 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S2_v29 (Il2CppClass<QuickVideoButtonHelper+<>c>)+5C]");
							object obj5 = (nint)0 + (nint)4;
							obj5 = text;
							adLocationID = text;
						}
						((AdSystemManager)(object)instance).FinishedWatchingVideo((string)(object)AdLocations.HOME_VIDEOS, adLocationID);
						TransformExtensions.Reset((Transform)(object)quickVideoButtonHelper.m_onVideoStarted);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj6 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj7 = default;
				obj6 = obj7;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0017: Expected Obj, but got I4
			SlideInData instance = SlideInData.instance;
			((UISlideIn)(object)instance).onDidShowCallback += (Action)2;
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private GameObject[] _hideWhenPopupsActive;

	private UISprite _defaultIconSprite;

	private UIPanel _defaultMaskPanel;

	private Transform _defaultRotateGlint;

	private List<QuickVideoButtonPrizeIconSetup> _prizeIconSetups;

	private VideoAdPrize _curentVideoAdPrize;

	private Action m_onVideoStarted;

	private const string EVENT_QUICKVIDEO_BUTTON_SHOWN = "Quick Video Ads Button Shown";

	private const string EVENT_ARG_QUICKVIDEO_VALUE_FORMAT = "step{0}|sinceDailyKeys{1}|{2}";

	private const string EVENT_ARG_QUICKVIDEO_SINCE_DAILY_KEYS = "SinceDailyKeys";

	public unsafe event Action onVideoStarted
	{
		add
		{
			//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3a: Expected Obj, but got Unknown
			//IL_0a43: Expected Obj, but got I4
			//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a51: Expected VT, but got Unknown
			//IL_0a5a: Expected VT, but got I4
			//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a80: Expected Obj, but got Unknown
			//IL_0ab4: Expected I, but got Obj
			//IL_0aca: Expected Obj, but got I
			//IL_199e: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a3: Expected VT, but got Unknown
			//IL_19b0: Expected I4, but got Obj
			//IL_19ab: Expected native int or pointer, but got VT
			//IL_19c0: Expected native int or pointer, but got VT
			//IL_19d5: Expected native int or pointer, but got VT
			//IL_19ea: Expected native int or pointer, but got VT
			//IL_1a12: Expected I, but got Obj
			//IL_1a28: Expected Obj, but got I
			//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af5: Expected Obj, but got Unknown
			//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b03: Expected Obj, but got Unknown
			//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b11: Expected Obj, but got Unknown
			//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b1f: Expected Obj, but got Unknown
			//IL_0b35: Expected Obj, but got I
			//IL_0b45: Expected Obj, but got I
			//IL_0b55: Expected Obj, but got I
			//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b63: Expected Obj, but got Unknown
			//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b71: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected Obj, but got Unknown
			//IL_0060: Expected I, but got Obj
			//IL_0325: Expected I, but got Obj
			//IL_033b: Expected Obj, but got I
			//IL_0358: Expected I, but got Obj
			//IL_00bd: Expected I, but got Obj
			//IL_00d3: Expected Obj, but got I
			//IL_0d48: Expected Obj, but got I
			//IL_0d6b: Expected I, but got Obj
			//IL_0d81: Expected Obj, but got I
			//IL_0da4: Expected I, but got Obj
			//IL_0dba: Expected Obj, but got I
			//IL_0dd8: Expected Obj, but got I4
			//IL_0e27: Expected I4, but got Obj
			//IL_0e22: Expected native int or pointer, but got VT
			//IL_0e37: Expected native int or pointer, but got VT
			//IL_0e53: Expected I4, but got Obj
			//IL_0e4e: Expected native int or pointer, but got VT
			//IL_0e63: Expected native int or pointer, but got VT
			//IL_0e78: Expected native int or pointer, but got VT
			//IL_0e8d: Expected native int or pointer, but got VT
			//IL_0ea7: Expected native int or pointer, but got VT
			//IL_0374: Expected I, but got Obj
			//IL_03a4: Expected I, but got Obj
			//IL_03dd: Expected I, but got Obj
			//IL_03f3: Expected Obj, but got I
			//IL_0410: Expected I, but got Obj
			//IL_00fe: Expected I, but got Obj
			//IL_0ec7: Expected Obj, but got I
			//IL_0eea: Expected I, but got Obj
			//IL_0f00: Expected Obj, but got I
			//IL_0f23: Expected I, but got Obj
			//IL_0f39: Expected Obj, but got I
			//IL_0f57: Expected Obj, but got I4
			//IL_0fa6: Expected I4, but got Obj
			//IL_0fa1: Expected native int or pointer, but got VT
			//IL_0fb6: Expected native int or pointer, but got VT
			//IL_0fd2: Expected I4, but got Obj
			//IL_0fcd: Expected native int or pointer, but got VT
			//IL_0fe2: Expected native int or pointer, but got VT
			//IL_0ff7: Expected native int or pointer, but got VT
			//IL_100c: Expected native int or pointer, but got VT
			//IL_1026: Expected native int or pointer, but got VT
			//IL_090a: Expected I, but got Obj
			//IL_0920: Expected Obj, but got I
			//IL_03ca: Expected I, but got Obj
			//IL_042c: Expected I, but got Obj
			//IL_045c: Expected I, but got Obj
			//IL_0495: Expected I, but got Obj
			//IL_04ab: Expected Obj, but got I
			//IL_04c8: Expected I, but got Obj
			//IL_1932: Expected I4, but got VT
			//IL_192d: Expected native int or pointer, but got VT
			//IL_1942: Expected native int or pointer, but got VT
			//IL_1957: Expected native int or pointer, but got VT
			//IL_196c: Expected native int or pointer, but got VT
			//IL_1990: Expected I4, but got Obj
			//IL_1049: Expected Obj, but got VT
			//IL_1064: Expected I, but got Obj
			//IL_107a: Expected Obj, but got I
			//IL_109d: Expected I, but got Obj
			//IL_10b3: Expected Obj, but got I
			//IL_10d1: Expected Obj, but got I4
			//IL_1120: Expected I4, but got Obj
			//IL_111b: Expected native int or pointer, but got VT
			//IL_1130: Expected native int or pointer, but got VT
			//IL_114c: Expected I4, but got Obj
			//IL_1147: Expected native int or pointer, but got VT
			//IL_115c: Expected native int or pointer, but got VT
			//IL_1171: Expected native int or pointer, but got VT
			//IL_1186: Expected native int or pointer, but got VT
			//IL_11a0: Expected native int or pointer, but got VT
			//IL_09df: Expected Obj, but got VT
			//IL_0a03: Expected Obj, but got I
			//IL_0a15: Expected Obj, but got I
			//IL_0a27: Expected Obj, but got I
			//IL_094b: Expected I, but got Obj
			//IL_0482: Expected I, but got Obj
			//IL_04e4: Expected I, but got Obj
			//IL_0514: Expected I, but got Obj
			//IL_054d: Expected I, but got Obj
			//IL_0563: Expected Obj, but got I
			//IL_0580: Expected I, but got Obj
			//IL_11c0: Expected Obj, but got I
			//IL_11e3: Expected I, but got Obj
			//IL_11f9: Expected Obj, but got I
			//IL_121c: Expected I, but got Obj
			//IL_1232: Expected Obj, but got I
			//IL_1250: Expected Obj, but got I4
			//IL_129f: Expected I4, but got Obj
			//IL_129a: Expected native int or pointer, but got VT
			//IL_12af: Expected native int or pointer, but got VT
			//IL_12cb: Expected I4, but got Obj
			//IL_12c6: Expected native int or pointer, but got VT
			//IL_12db: Expected native int or pointer, but got VT
			//IL_12f0: Expected native int or pointer, but got VT
			//IL_1305: Expected native int or pointer, but got VT
			//IL_131f: Expected native int or pointer, but got VT
			//IL_053a: Expected I, but got Obj
			//IL_059c: Expected I, but got Obj
			//IL_05cc: Expected I, but got Obj
			//IL_0605: Expected I, but got Obj
			//IL_061b: Expected Obj, but got I
			//IL_0638: Expected I, but got Obj
			//IL_133f: Expected Obj, but got I
			//IL_1362: Expected I, but got Obj
			//IL_1378: Expected Obj, but got I
			//IL_139b: Expected I, but got Obj
			//IL_13b1: Expected Obj, but got I
			//IL_13cf: Expected Obj, but got I4
			//IL_141e: Expected I4, but got Obj
			//IL_1419: Expected native int or pointer, but got VT
			//IL_142e: Expected native int or pointer, but got VT
			//IL_144a: Expected I4, but got Obj
			//IL_1445: Expected native int or pointer, but got VT
			//IL_145a: Expected native int or pointer, but got VT
			//IL_146f: Expected native int or pointer, but got VT
			//IL_1484: Expected native int or pointer, but got VT
			//IL_149e: Expected native int or pointer, but got VT
			//IL_05f2: Expected I, but got Obj
			//IL_0654: Expected I, but got Obj
			//IL_0684: Expected I, but got Obj
			//IL_06bd: Expected I, but got Obj
			//IL_06d3: Expected Obj, but got I
			//IL_06f0: Expected I, but got Obj
			//IL_14be: Expected Obj, but got I
			//IL_14e1: Expected I, but got Obj
			//IL_14f7: Expected Obj, but got I
			//IL_151a: Expected I, but got Obj
			//IL_1530: Expected Obj, but got I
			//IL_154e: Expected Obj, but got I4
			//IL_159d: Expected I4, but got Obj
			//IL_1598: Expected native int or pointer, but got VT
			//IL_15ad: Expected native int or pointer, but got VT
			//IL_15c9: Expected I4, but got Obj
			//IL_15c4: Expected native int or pointer, but got VT
			//IL_15d9: Expected native int or pointer, but got VT
			//IL_15ee: Expected native int or pointer, but got VT
			//IL_1603: Expected native int or pointer, but got VT
			//IL_161d: Expected native int or pointer, but got VT
			//IL_06aa: Expected I, but got Obj
			//IL_070c: Expected I, but got Obj
			//IL_073c: Expected I, but got Obj
			//IL_0775: Expected I, but got Obj
			//IL_078b: Expected Obj, but got I
			//IL_07a8: Expected I, but got Obj
			//IL_163d: Expected Obj, but got I
			//IL_1660: Expected I, but got Obj
			//IL_1676: Expected Obj, but got I
			//IL_1699: Expected I, but got Obj
			//IL_16af: Expected Obj, but got I
			//IL_16cd: Expected Obj, but got I4
			//IL_171c: Expected I4, but got Obj
			//IL_1717: Expected native int or pointer, but got VT
			//IL_172c: Expected native int or pointer, but got VT
			//IL_1748: Expected I4, but got Obj
			//IL_1743: Expected native int or pointer, but got VT
			//IL_1758: Expected native int or pointer, but got VT
			//IL_176d: Expected native int or pointer, but got VT
			//IL_1782: Expected native int or pointer, but got VT
			//IL_179c: Expected native int or pointer, but got VT
			//IL_0762: Expected I, but got Obj
			//IL_07c4: Expected I, but got Obj
			//IL_07f4: Expected I, but got Obj
			//IL_082d: Expected I, but got Obj
			//IL_0843: Expected Obj, but got I
			//IL_0860: Expected I, but got Obj
			//IL_17bc: Expected Obj, but got I
			//IL_17df: Expected I, but got Obj
			//IL_17f5: Expected Obj, but got I
			//IL_1818: Expected I, but got Obj
			//IL_182e: Expected Obj, but got I
			//IL_184c: Expected Obj, but got I4
			//IL_189b: Expected I4, but got Obj
			//IL_1896: Expected native int or pointer, but got VT
			//IL_18ab: Expected native int or pointer, but got VT
			//IL_18c7: Expected I4, but got Obj
			//IL_18c2: Expected native int or pointer, but got VT
			//IL_18d7: Expected native int or pointer, but got VT
			//IL_18ec: Expected native int or pointer, but got VT
			//IL_1901: Expected native int or pointer, but got VT
			//IL_191b: Expected native int or pointer, but got VT
			//IL_081a: Expected I, but got Obj
			//IL_087c: Expected I, but got Obj
			//IL_08ac: Expected I, but got Obj
			//IL_026d: Expected I, but got Obj
			//IL_0283: Expected Obj, but got I
			//IL_02a0: Expected I, but got Obj
			//IL_0bc9: Expected Obj, but got I
			//IL_0bec: Expected I, but got Obj
			//IL_0c02: Expected Obj, but got I
			//IL_0c25: Expected I, but got Obj
			//IL_0c3b: Expected Obj, but got I
			//IL_0c59: Expected Obj, but got I4
			//IL_0ca8: Expected I4, but got Obj
			//IL_0ca3: Expected native int or pointer, but got VT
			//IL_0cb8: Expected native int or pointer, but got VT
			//IL_0cd4: Expected I4, but got Obj
			//IL_0ccf: Expected native int or pointer, but got VT
			//IL_0ce4: Expected native int or pointer, but got VT
			//IL_0cf9: Expected native int or pointer, but got VT
			//IL_0d0e: Expected native int or pointer, but got VT
			//IL_0d28: Expected native int or pointer, but got VT
			//IL_08d2: Expected I, but got Obj
			//IL_02bc: Expected I, but got Obj
			//IL_02ec: Expected I, but got Obj
			//IL_0312: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 112;
			obj = 0;
			PrizePositionData.TransformValues? transformValues = (PrizePositionData.TransformValues?)(object)(obj2 + 72);
			transformValues = (PrizePositionData.TransformValues?)(object)0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			object obj3 = obj2 + 128;
			obj3 = value;
			_ = ((Delegate)value).method_ptr;
			_ = ((Delegate)value).m_target;
			_ = ((Delegate)value).delegate_trampoline;
			nint num = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v22 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v439 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WeeklyHuntData.PrizeData prizeData = (WeeklyHuntData.PrizeData)(obj2 + 160);
			((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+8]");
			((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+10]");
			((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+18]");
			((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
			string text = WeeklyHuntManager.Get(prizeData);
			obj = text;
			nint num3 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v33 (Il2CppClass<PrizePositionData>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			bool flag = obj5 == null;
			string text2 = text;
			if (!flag)
			{
				nint num4 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v431 (Il2CppClass<PrizePositionData>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				text2 = text;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					text2 = (string)obj;
				}
			}
			object obj6 = obj2 + 116;
			object obj7 = obj2 + 60;
			object obj8 = obj2 + 48;
			object obj9 = obj2 + 36;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S2_v3 (Il2CppMethodInfo)+C]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S2_v4+60]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S2_v5+44]");
			object obj12 = 0;
			object obj13 = obj12 & 0x1FFF;
			object obj14 = obj13 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v134 @ S3_v4 (should have been resolved before IL gen)");
			object obj15 = default;
			if ((nint)obj15 > -1)
			{
				nint num6 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v420 (Il2CppClass<PrizePositionData>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num7 = (nint)typeof(PrizePositionData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v425 (Il2CppClass<PrizePositionData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10A5E");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			object obj17 = text2 - 1;
			if ((nint)text2 != 1)
			{
				if ((nint)obj17 != 1)
				{
					if ((nint)obj17 != 2)
					{
						if ((nint)obj17 != 3)
						{
							if ((nint)obj17 != 4)
							{
								if ((nint)obj17 != 5)
								{
									if ((nint)obj17 != 6)
									{
										if ((nint)obj17 != 7)
										{
											if ((nint)obj17 == 8)
											{
												nint num8 = (nint)typeof(PrizePositionData);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ S0_v383 (Il2CppClass<PrizePositionData>)+BA]");
												object obj18 = (nint)0 & (nint)0x200;
												bool flag4 = obj18 == null;
												nint num9 = (nint)typeof(PrizePositionData);
												if (!flag4)
												{
													nint num10 = (nint)typeof(PrizePositionData);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1114 @ S0_v413 (Il2CppClass<PrizePositionData>)+74]");
													bool flag5 = (nint)0 == 0;
													bool flag6 = !flag5;
													num9 = (nint)typeof(PrizePositionData);
													if (!flag6)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														num9 = (nint)typeof(PrizePositionData);
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ L1_v69 (Il2CppClass<PrizePositionData>)+5C]");
												object obj19 = (nint)0 + (nint)432;
												obj7 = obj19;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ S1_v467+8]");
												_ = 0;
												nint num11 = (nint)typeof(PrizePositionData);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ S1_v472 (Il2CppClass<PrizePositionData>)+5C]");
												object obj20 = (nint)0 + (nint)444;
												obj8 = obj20;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ S1_v474+8]");
												_ = 0;
												nint num12 = (nint)typeof(PrizePositionData);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ S1_v479 (Il2CppClass<PrizePositionData>)+5C]");
												object obj21 = (nint)0 + (nint)456;
												obj9 = obj21;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ S1_v481+8]");
												_ = 0;
												obj2 = 0;
												_ = 0;
												_ = 0;
												_ = 0;
												_ = 0;
												obj6 = obj7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v40+8]");
												_ = 0;
												obj3 = obj8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v42+8]");
												_ = 0;
												((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj9;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v44+8]");
												((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CEF");
												((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
												((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
												((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
												((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
												_ = 0;
												*(PrizePositionData.TransformValues?*)(nint)transformValues = (PrizePositionData.TransformValues)prizeData;
											}
										}
										else
										{
											nint num13 = (nint)typeof(PrizePositionData);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ S0_v346 (Il2CppClass<PrizePositionData>)+BA]");
											object obj22 = (nint)0 & (nint)0x200;
											bool flag7 = obj22 == null;
											nint num14 = (nint)typeof(PrizePositionData);
											if (!flag7)
											{
												nint num15 = (nint)typeof(PrizePositionData);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ S0_v376 (Il2CppClass<PrizePositionData>)+74]");
												bool flag8 = (nint)0 == 0;
												bool flag9 = !flag8;
												num14 = (nint)typeof(PrizePositionData);
												if (!flag9)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													num14 = (nint)typeof(PrizePositionData);
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ L1_v62 (Il2CppClass<PrizePositionData>)+5C]");
											object obj23 = (nint)0 + (nint)468;
											obj7 = obj23;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ S1_v417+8]");
											_ = 0;
											nint num16 = (nint)typeof(PrizePositionData);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ S1_v422 (Il2CppClass<PrizePositionData>)+5C]");
											object obj24 = (nint)0 + (nint)492;
											obj8 = obj24;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ S1_v424+8]");
											_ = 0;
											nint num17 = (nint)typeof(PrizePositionData);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ S1_v429 (Il2CppClass<PrizePositionData>)+5C]");
											object obj25 = (nint)0 + (nint)480;
											obj9 = obj25;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ S1_v431+8]");
											_ = 0;
											obj2 = 0;
											_ = 0;
											_ = 0;
											_ = 0;
											_ = 0;
											obj6 = obj7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v40+8]");
											_ = 0;
											obj3 = obj8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v42+8]");
											_ = 0;
											((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj9;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v44+8]");
											((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CEF");
											((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
											((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
											((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
											((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
											_ = 0;
											*(PrizePositionData.TransformValues?*)(nint)transformValues = (PrizePositionData.TransformValues)prizeData;
										}
									}
									else
									{
										nint num18 = (nint)typeof(PrizePositionData);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ S0_v309 (Il2CppClass<PrizePositionData>)+BA]");
										object obj26 = (nint)0 & (nint)0x200;
										bool flag10 = obj26 == null;
										nint num19 = (nint)typeof(PrizePositionData);
										if (!flag10)
										{
											nint num20 = (nint)typeof(PrizePositionData);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ S0_v339 (Il2CppClass<PrizePositionData>)+74]");
											bool flag11 = (nint)0 == 0;
											bool flag12 = !flag11;
											num19 = (nint)typeof(PrizePositionData);
											if (!flag12)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												num19 = (nint)typeof(PrizePositionData);
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ L1_v55 (Il2CppClass<PrizePositionData>)+5C]");
										object obj27 = (nint)0 + (nint)396;
										obj7 = obj27;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ S1_v367+8]");
										_ = 0;
										nint num21 = (nint)typeof(PrizePositionData);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ S1_v372 (Il2CppClass<PrizePositionData>)+5C]");
										object obj28 = (nint)0 + (nint)420;
										obj8 = obj28;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ S1_v374+8]");
										_ = 0;
										nint num22 = (nint)typeof(PrizePositionData);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ S1_v379 (Il2CppClass<PrizePositionData>)+5C]");
										object obj29 = (nint)0 + (nint)408;
										obj9 = obj29;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ S1_v381+8]");
										_ = 0;
										obj2 = 0;
										_ = 0;
										_ = 0;
										_ = 0;
										_ = 0;
										obj6 = obj7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v40+8]");
										_ = 0;
										obj3 = obj8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v42+8]");
										_ = 0;
										((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v44+8]");
										((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CEF");
										((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
										((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
										((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
										((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
										_ = 0;
										*(PrizePositionData.TransformValues?*)(nint)transformValues = (PrizePositionData.TransformValues)prizeData;
									}
								}
								else
								{
									nint num23 = (nint)typeof(PrizePositionData);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ S0_v272 (Il2CppClass<PrizePositionData>)+BA]");
									object obj30 = (nint)0 & (nint)0x200;
									bool flag13 = obj30 == null;
									nint num24 = (nint)typeof(PrizePositionData);
									if (!flag13)
									{
										nint num25 = (nint)typeof(PrizePositionData);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ S0_v302 (Il2CppClass<PrizePositionData>)+74]");
										bool flag14 = (nint)0 == 0;
										bool flag15 = !flag14;
										num24 = (nint)typeof(PrizePositionData);
										if (!flag15)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											num24 = (nint)typeof(PrizePositionData);
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ L1_v48 (Il2CppClass<PrizePositionData>)+5C]");
									object obj31 = (nint)0 + (nint)360;
									obj7 = obj31;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ S1_v317+8]");
									_ = 0;
									nint num26 = (nint)typeof(PrizePositionData);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ S1_v322 (Il2CppClass<PrizePositionData>)+5C]");
									object obj32 = (nint)0 + (nint)384;
									obj8 = obj32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S1_v324+8]");
									_ = 0;
									nint num27 = (nint)typeof(PrizePositionData);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ S1_v329 (Il2CppClass<PrizePositionData>)+5C]");
									object obj33 = (nint)0 + (nint)372;
									obj9 = obj33;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ S1_v331+8]");
									_ = 0;
									obj2 = 0;
									_ = 0;
									_ = 0;
									_ = 0;
									_ = 0;
									obj6 = obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v40+8]");
									_ = 0;
									obj3 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v42+8]");
									_ = 0;
									((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v44+8]");
									((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CEF");
									((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
									((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
									((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
									((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
									_ = 0;
									*(PrizePositionData.TransformValues?*)(nint)transformValues = (PrizePositionData.TransformValues)prizeData;
								}
							}
							else
							{
								nint num28 = (nint)typeof(PrizePositionData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v235 (Il2CppClass<PrizePositionData>)+BA]");
								object obj34 = (nint)0 & (nint)0x200;
								bool flag16 = obj34 == null;
								nint num29 = (nint)typeof(PrizePositionData);
								if (!flag16)
								{
									nint num30 = (nint)typeof(PrizePositionData);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ S0_v265 (Il2CppClass<PrizePositionData>)+74]");
									bool flag17 = (nint)0 == 0;
									bool flag18 = !flag17;
									num29 = (nint)typeof(PrizePositionData);
									if (!flag18)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										num29 = (nint)typeof(PrizePositionData);
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ L1_v41 (Il2CppClass<PrizePositionData>)+5C]");
								object obj35 = (nint)0 + (nint)108;
								obj7 = obj35;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ S1_v267+8]");
								_ = 0;
								nint num31 = (nint)typeof(PrizePositionData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S1_v272 (Il2CppClass<PrizePositionData>)+5C]");
								object obj36 = (nint)0 + (nint)132;
								obj8 = obj36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ S1_v274+8]");
								_ = 0;
								nint num32 = (nint)typeof(PrizePositionData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ S1_v279 (Il2CppClass<PrizePositionData>)+5C]");
								object obj37 = (nint)0 + (nint)120;
								obj9 = obj37;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ S1_v281+8]");
								_ = 0;
								obj2 = 0;
								_ = 0;
								_ = 0;
								_ = 0;
								_ = 0;
								obj6 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v40+8]");
								_ = 0;
								obj3 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v42+8]");
								_ = 0;
								((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v44+8]");
								((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CEF");
								((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
								((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
								((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
								((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
								_ = 0;
								*(PrizePositionData.TransformValues?*)(nint)transformValues = (PrizePositionData.TransformValues)prizeData;
							}
						}
						else
						{
							nint num33 = (nint)typeof(PrizePositionData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v198 (Il2CppClass<PrizePositionData>)+BA]");
							object obj38 = (nint)0 & (nint)0x200;
							bool flag19 = obj38 == null;
							nint num34 = (nint)typeof(PrizePositionData);
							if (!flag19)
							{
								nint num35 = (nint)typeof(PrizePositionData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ S0_v228 (Il2CppClass<PrizePositionData>)+74]");
								bool flag20 = (nint)0 == 0;
								bool flag21 = !flag20;
								num34 = (nint)typeof(PrizePositionData);
								if (!flag21)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									num34 = (nint)typeof(PrizePositionData);
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ L1_v34 (Il2CppClass<PrizePositionData>)+5C]");
							object obj39 = (nint)0 + (nint)72;
							obj7 = obj39;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S1_v217+8]");
							_ = 0;
							nint num36 = (nint)typeof(PrizePositionData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S1_v222 (Il2CppClass<PrizePositionData>)+5C]");
							object obj40 = (nint)0 + (nint)96;
							obj8 = obj40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ S1_v224+8]");
							_ = 0;
							nint num37 = (nint)typeof(PrizePositionData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ S1_v229 (Il2CppClass<PrizePositionData>)+5C]");
							object obj41 = (nint)0 + (nint)84;
							obj9 = obj41;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S1_v231+8]");
							_ = 0;
							obj2 = 0;
							_ = 0;
							_ = 0;
							_ = 0;
							_ = 0;
							obj6 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v40+8]");
							_ = 0;
							obj3 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v42+8]");
							_ = 0;
							((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v44+8]");
							((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CEF");
							((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
							((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
							((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
							_ = 0;
							*(PrizePositionData.TransformValues?*)(nint)transformValues = (PrizePositionData.TransformValues)prizeData;
						}
					}
					else
					{
						nint num38 = (nint)typeof(PrizePositionData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v161 (Il2CppClass<PrizePositionData>)+BA]");
						object obj42 = (nint)0 & (nint)0x200;
						bool flag22 = obj42 == null;
						nint num39 = (nint)typeof(PrizePositionData);
						if (!flag22)
						{
							nint num40 = (nint)typeof(PrizePositionData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S0_v191 (Il2CppClass<PrizePositionData>)+74]");
							bool flag23 = (nint)0 == 0;
							bool flag24 = !flag23;
							num39 = (nint)typeof(PrizePositionData);
							if (!flag24)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num39 = (nint)typeof(PrizePositionData);
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ L1_v27 (Il2CppClass<PrizePositionData>)+5C]");
						nint num41 = 0;
						obj7 = PrizePositionData.HOVERBOARD_POSITION_OFFSET;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S1_v167 (Il2CppStaticFields<PrizePositionData>)+8]");
						_ = 0;
						nint num42 = (nint)typeof(PrizePositionData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S1_v172 (Il2CppClass<PrizePositionData>)+5C]");
						object obj43 = (nint)0 + (nint)24;
						obj8 = obj43;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S1_v174+8]");
						_ = 0;
						nint num43 = (nint)typeof(PrizePositionData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S1_v179 (Il2CppClass<PrizePositionData>)+5C]");
						object obj44 = (nint)0 + (nint)12;
						obj9 = obj44;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S1_v181+8]");
						_ = 0;
						obj2 = 0;
						_ = 0;
						_ = 0;
						_ = 0;
						_ = 0;
						obj6 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v40+8]");
						_ = 0;
						obj3 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v42+8]");
						_ = 0;
						((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v44+8]");
						((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CEF");
						((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
						((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
						((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
						_ = 0;
						*(PrizePositionData.TransformValues?*)(nint)transformValues = (PrizePositionData.TransformValues)prizeData;
					}
				}
				else
				{
					nint num44 = (nint)typeof(PrizePositionData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v124 (Il2CppClass<PrizePositionData>)+BA]");
					object obj45 = (nint)0 & (nint)0x200;
					bool flag25 = obj45 == null;
					nint num45 = (nint)typeof(PrizePositionData);
					if (!flag25)
					{
						nint num46 = (nint)typeof(PrizePositionData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v154 (Il2CppClass<PrizePositionData>)+74]");
						bool flag26 = (nint)0 == 0;
						bool flag27 = !flag26;
						num45 = (nint)typeof(PrizePositionData);
						if (!flag27)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num45 = (nint)typeof(PrizePositionData);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ L1_v20 (Il2CppClass<PrizePositionData>)+5C]");
					object obj46 = (nint)0 + (nint)180;
					obj7 = obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S1_v118+8]");
					_ = 0;
					nint num47 = (nint)typeof(PrizePositionData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S1_v123 (Il2CppClass<PrizePositionData>)+5C]");
					object obj47 = (nint)0 + (nint)204;
					obj8 = obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S1_v125+8]");
					_ = 0;
					nint num48 = (nint)typeof(PrizePositionData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S1_v130 (Il2CppClass<PrizePositionData>)+5C]");
					object obj48 = (nint)0 + (nint)192;
					obj9 = obj48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S1_v132+8]");
					_ = 0;
					obj2 = 0;
					_ = 0;
					_ = 0;
					_ = 0;
					_ = 0;
					obj6 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v40+8]");
					_ = 0;
					obj3 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v42+8]");
					_ = 0;
					((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v44+8]");
					((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CEF");
					((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
					((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
					((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
					_ = 0;
					*(PrizePositionData.TransformValues?*)(nint)transformValues = (PrizePositionData.TransformValues)prizeData;
				}
			}
			else
			{
				nint num49 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v87 (Il2CppClass<PrizePositionData>)+BA]");
				object obj49 = (nint)0 & (nint)0x200;
				bool flag28 = obj49 == null;
				nint num50 = (nint)typeof(PrizePositionData);
				if (!flag28)
				{
					nint num51 = (nint)typeof(PrizePositionData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v117 (Il2CppClass<PrizePositionData>)+74]");
					bool flag29 = (nint)0 == 0;
					bool flag30 = !flag29;
					num50 = (nint)typeof(PrizePositionData);
					if (!flag30)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num50 = (nint)typeof(PrizePositionData);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ L1_v13 (Il2CppClass<PrizePositionData>)+5C]");
				object obj50 = (nint)0 + (nint)36;
				obj7 = obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S1_v68+8]");
				_ = 0;
				nint num52 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v73 (Il2CppClass<PrizePositionData>)+5C]");
				object obj51 = (nint)0 + (nint)60;
				obj8 = obj51;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v75+8]");
				_ = 0;
				nint num53 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v80 (Il2CppClass<PrizePositionData>)+5C]");
				object obj52 = (nint)0 + (nint)48;
				obj9 = obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v82+8]");
				_ = 0;
				obj2 = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				obj6 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v40+8]");
				_ = 0;
				obj3 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v42+8]");
				_ = 0;
				((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v44+8]");
				((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CEF");
				((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
				((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
				((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
				_ = 0;
				*(PrizePositionData.TransformValues?*)(nint)transformValues = (PrizePositionData.TransformValues)prizeData;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.Nullable`1<PrizePositionData+TransformValues>)+24]");
			if ((nint)0 != 0)
			{
				nint num54 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ S0_v73 (Il2CppClass<PrizePositionData>)+BA]");
				object obj53 = (nint)0 & (nint)0x200;
				if (obj53 != null)
				{
					nint num55 = (nint)typeof(PrizePositionData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ S0_v80 (Il2CppClass<PrizePositionData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((WeeklyHuntData.PrizeData*)(nint)prizeData)->amount = (int)transformValues;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.Nullable`1<PrizePositionData+TransformValues>)+8]");
				((WeeklyHuntData.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.Nullable`1<PrizePositionData+TransformValues>)+10]");
				((WeeklyHuntData.PrizeData*)(nint)prizeData)->characterId = Characters.CharacterId.slick;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.Nullable`1<PrizePositionData+TransformValues>)+18]");
				((WeeklyHuntData.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.Nullable`1<PrizePositionData+TransformValues>)+20]");
				_ = 0;
				PrizePositionData._cachedPositionData.Add((WeeklyHuntData.WeeklyHuntPrize)obj, (PrizePositionData.TransformValues?)prizeData);
				QuickVideoButtonHelper quickVideoButtonHelper = (QuickVideoButtonHelper)transformValues;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.Nullable`1<PrizePositionData+TransformValues>)+8]");
				((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.Nullable`1<PrizePositionData+TransformValues>)+10]");
				_defaultIconSprite = (UISprite)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.Nullable`1<PrizePositionData+TransformValues>)+18]");
				_defaultRotateGlint = (Transform)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.Nullable`1<PrizePositionData+TransformValues>)+20]");
				_curentVideoAdPrize = (VideoAdPrize)0;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onVideoStarted;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 36;
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

	private unsafe void OnEnable()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0112: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0159: Expected I, but got Obj
		//IL_016f: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected VT, but got Unknown
		//IL_0206: Expected VT, but got Obj
		//IL_0201: Expected native int or pointer, but got VT
		//IL_0226: Expected Obj, but got I4
		//IL_0253: Expected VT, but got Obj
		//IL_024e: Expected native int or pointer, but got VT
		//IL_0282: Expected VT, but got I
		//IL_027d: Expected native int or pointer, but got VT
		//IL_0294: Expected native int or pointer, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<PrizePositionData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(PrizePositionData);
		if (!flag)
		{
			nint num3 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v51 (Il2CppClass<PrizePositionData>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(PrizePositionData);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(PrizePositionData);
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ L1_v2 (Il2CppClass<PrizePositionData>)+5C]");
		object obj4 = (nint)0 + (nint)216;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v7+8]");
		_ = 0;
		object obj5 = obj3 + 48;
		nint num4 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v13 (Il2CppClass<PrizePositionData>)+5C]");
		object obj6 = (nint)0 + (nint)240;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v15+8]");
		_ = 0;
		object obj7 = obj3 + 36;
		nint num5 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v21 (Il2CppClass<PrizePositionData>)+5C]");
		object obj8 = (nint)0 + (nint)228;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v23+8]");
		_ = 0;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj9 = obj3 + 72;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14+8]");
		_ = 0;
		object obj10 = obj3 + 84;
		obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v17+8]");
		_ = 0;
		PrizePositionData.TransformValues transformValues = (PrizePositionData.TransformValues)(obj3 + 96);
		((PrizePositionData.TransformValues*)(nint)transformValues)->PositionOffset = (Vector3)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v20+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CEF");
		QuickVideoButtonHelper quickVideoButtonHelper = (QuickVideoButtonHelper)0;
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		_defaultIconSprite = null;
		_defaultRotateGlint = null;
		_curentVideoAdPrize = null;
		((PrizePositionData.TransformValues*)(nint)transformValues)->PositionOffset = (Vector3)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
		((PrizePositionData.TransformValues*)(nint)transformValues)->ScaleOffset = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
		_ = 0;
		*(PrizePositionData.TransformValues?*)(nint)this = transformValues;
	}

	private unsafe void OnDisable()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(QuickVideoButtonHelper.OnLastPopupClosed);
		object obj3 = action2 + 16;
		obj3 = this;
		UIScreenController.OnLastPopupClosed -= action2;
	}

	private unsafe void OnLastPopupClosed()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(QuickVideoButtonHelper.OnPopupShown);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnLastPopupClosed += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		UIScreenController.OnPopupClosed += action2;
	}

	private void OnPopupShown(string popupName)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_onVideoStarted;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)popupName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 36;
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

	private void OnClick()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0057: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		object obj = _hideWhenPopupsActive + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _hideWhenPopupsActive + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			((GameObject)obj5).tag = (string)1;
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
	}

	private void OnVideoFinished(bool withReward)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		object obj = _hideWhenPopupsActive + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _hideWhenPopupsActive + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			((GameObject)obj5).tag = null;
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
	}

	private IEnumerator StartVideoWithDelay()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	public void SetPrize(VideoAdPrize prize)
	{
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I4
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.RefreshOnlineSettingsAndInappsIfNeeded();
		if (prize != null)
		{
			SlideInData instance = SlideInData.instance;
			((UISlideIn)(object)instance).onDidShowCallback += (Action)2;
			SlideInData instance2 = SlideInData.instance;
			bool videoIsPlaying = ((VideoAdPrizeManager)(object)instance2).HasVideoAdPrizeIndexChanged();
			((SaveMePopup)this).VideoIsPlaying = videoIsPlaying;
		}
	}

	private void SetDefaultPrizeIconProperties()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		bool isInitialized = AdSystemManager.isInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		object obj3 = (isInitialized ? 1 : 0) + 20;
		obj3 = obj2;
		bool isInitialized2 = AdSystemManager.isInitialized;
		((PokiUnitySDK)isInitialized2).checkInit();
	}

	private void LogShownButtonToFlurry()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Expected Obj, but got Unknown
		//IL_08d4: Expected Obj, but got I4
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_00e0: Expected I, but got Obj
		//IL_0191: Expected I, but got Obj
		//IL_01a7: Expected Obj, but got I
		//IL_01d2: Expected I, but got Obj
		//IL_0813: Expected Obj, but got I
		//IL_0283: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected Obj, but got Unknown
		//IL_02c4: Expected I, but got Obj
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected Obj, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected Obj, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected Obj, but got Unknown
		//IL_078b: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj7 = default;
		object obj9 = default;
		object obj11 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v82 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v157 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v96 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v141 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S0_v110 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S0_v125 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
		}
		object obj12 = 40;
		object obj13 = obj12 - 9;
		if ((nint)obj12 != 9 && (nint)obj13 != 1)
		{
			if ((nint)obj13 != 2 && (nint)obj13 != 3)
			{
				if ((nint)obj13 == 4)
				{
					goto IL_0790;
				}
				if ((nint)obj13 != 5 && (nint)obj13 != 6 && (nint)obj13 != 7 && (nint)obj13 != 8 && (nint)obj13 != 9)
				{
					if ((nint)obj13 == 10 || (nint)obj13 == 11)
					{
						goto IL_0790;
					}
					if ((nint)obj13 != 12 && (nint)obj13 != 13)
					{
						if ((nint)obj13 == 14)
						{
							goto IL_0790;
						}
						if ((nint)obj13 != 15 && (nint)obj13 != 16 && (nint)obj13 != 17 && (nint)obj13 != 18 && (nint)obj13 != 19)
						{
							if ((nint)obj13 == 20 || (nint)obj13 == 21)
							{
								goto IL_0790;
							}
							if ((nint)obj13 != 22 && (nint)obj13 != 23)
							{
								if ((nint)obj13 == 24)
								{
									goto IL_0790;
								}
								if ((nint)obj13 != 25 && (nint)obj13 != 26 && (nint)obj13 != 27 && (nint)obj13 != 28)
								{
									if ((nint)obj13 == 29 || (nint)obj13 == 30)
									{
										goto IL_0790;
									}
									if ((nint)obj13 == 31)
									{
										object obj14 = obj4 + 4;
										object obj15 = obj14 + 1;
										obj14 = obj15;
										object obj16 = obj15 << 2;
										object obj17 = obj4 + obj16;
										obj17 = 125;
									}
								}
							}
						}
					}
				}
			}
			goto IL_0983;
		}
		goto IL_0790;
		IL_0983:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj18 = (nint)0 << 2;
			object obj19 = obj4 + obj18;
			if ((nint)obj19 == 125)
			{
				object obj20 = obj4 + 4;
				if ((nint)obj20 > -1)
				{
					object obj21 = obj20 + -1;
					obj20 = obj21;
				}
				return;
			}
		}
		object obj22 = default;
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		return;
		IL_0790:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj23 = default;
		object obj24 = default;
		if (obj23 == obj24)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0983;
	}

	public QuickVideoButtonHelper()
	{
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected Obj, but got Unknown
		//IL_037b: Expected Obj, but got I4
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_0392: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		object obj3 = obj2 + 12;
		obj3 = 0;
		VideoAdPrize curentVideoAdPrize = _curentVideoAdPrize;
		if (curentVideoAdPrize.prizeType__BackingField == VideoAdPrizeType.DailyVideoPrize)
		{
			AdsSave.cooldowns = null;
		}
		SlideInData instance = SlideInData.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S3_v3+60]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (UI.SlideIns.SlideInData)+1C]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (UI.SlideIns.SlideInData)+1C]");
		if ((nint)0 != 0)
		{
			int currentVideoAdPrizeSeed = AdsSave.currentVideoAdPrizeSeed;
		}
		else
		{
			int currentVideoAdPrizeSeed = AdsSave.currentRandomVideoAdPrizeIndex;
		}
		Cooldowns cooldowns = AdsSave.cooldowns;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}
}
