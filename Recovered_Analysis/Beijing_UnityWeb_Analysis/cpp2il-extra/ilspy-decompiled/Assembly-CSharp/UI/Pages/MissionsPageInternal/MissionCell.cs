using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Ads;
using Kiloo.Common.Extensions;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.Timer;
using Kiloo.Common.Utility;
using Missions;
using SYBO.Subway;
using UI.Breadcrumbs;
using UI.FreeStuff;
using UI.Generic;
using UI.Helpers;
using UI.Pages.DailyChallengePageInternal;
using UnityEngine;

namespace UI.Pages.MissionsPageInternal;

public class MissionCell : MonoBehaviour, IBuyButton
{
	public enum PayloadSource
	{
		PauseMenu,
		ChallengesScreen
	}

	public class MissionCellPayload
	{
		public int cellHeight;

		public int missionIndex;

		public int headerHeight;

		public MissionInfo missionInfo;

		public Action<int> onMissionCellAnimationComplete;

		public PayloadSource source;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<MissionInfo, bool> _003C_003E9__62_0;

		public static Func<MissionInfo, bool> _003C_003E9__72_0;

		public static Action<UISprite> _003C_003E9__75_0;

		public static Action<UISprite> _003C_003E9__75_1;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			MissionsPage._003C_003Ec obj = default;
			MissionsPage._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			//IL_0040: Expected Obj, but got I
			//IL_0051: Expected Obj, but got I
			//IL_0074: Expected Obj, but got I
			//IL_0085: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPageInternal.MissionCell+<>c)+8]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPageInternal.MissionCell+<>c)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v6+34]");
				string tag = ((Component)0).tag;
				((GameObject)(object)tag).tag = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPageInternal.MissionCell+<>c)+C]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+38]");
				string tag2 = ((Component)0).tag;
				((GameObject)(object)tag2).tag = null;
			}
		}

		internal bool _003CAnimateSkip_003Eb__62_0(MissionInfo m)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [m @ L1 (MissionInfo)+5C]");
			bool flag = (nint)0 != 0;
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}

		internal bool _003CAnimateBackgroundProgress_003Eb__72_0(MissionInfo m)
		{
			//IL_000d: Expected Obj, but got VT
			object obj = m.mission;
			_ = m.template;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [m @ L1 (MissionInfo)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [m @ L1 (MissionInfo)+18]");
			_ = 0;
			_ = m.progress;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+24]");
			return (nint)0 != 0;
		}

		internal void _003CAnimateBottomPanelCoroutine_003Eb__75_0(UISprite s)
		{
		}

		internal void _003CAnimateBottomPanelCoroutine_003Eb__75_1(UISprite s)
		{
			//IL_001b: Expected Obj, but got I4
			string tag = s.tag;
			((GameObject)(object)tag).tag = (string)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		}
	}

	private sealed class _003CAnimateBackgroundProgress_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int finalProgress;

		public MissionCell _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004a: Expected Obj, but got I
				//IL_010f: Expected I, but got Obj
				//IL_0125: Expected Obj, but got I
				//IL_023b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0240: Expected Obj, but got Unknown
				//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c5: Expected Obj, but got Unknown
				//IL_00e1: Expected Obj, but got I4
				//IL_0342: Expected Obj, but got I4
				//IL_0150: Expected I, but got Obj
				//IL_019d: Expected I, but got Obj
				//IL_01b3: Expected Obj, but got I
				//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f3: Expected Obj, but got Unknown
				//IL_030a: Expected I, but got Obj
				//IL_0320: Expected Obj, but got I
				//IL_01de: Expected I, but got Obj
				MissionCell missionCell = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						object obj = missionCell - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Pages.MissionsPageInternal.MissionCell)+60]");
				object obj2 = (nint)0 + (nint)20;
				int num = finalProgress;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v6+4]");
				if ((nint)num < (nint)0)
				{
					GameObject routine = ((FirstPurchaseBonusQuickShopHelper)(object)missionCell).CreateEmptyWidget(finalProgress);
					Coroutine coroutine = missionCell.StartCoroutine_Auto((IEnumerator)(object)routine);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = -1f;
					_ = 1f;
					object obj3 = this + 12;
					object obj4 = default;
					obj3 = obj4;
					_003C_003E1__state = 1;
					return 1;
				}
				StayInOneLaneMission instance = StayInOneLaneMission.instance;
				int currentMissionSet = ((MissionsManager)(object)instance).currentMissionSet;
				nint num2 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v18 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num3 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v57 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = _003C_003Ec._003C_003E9__72_0 == null;
				bool flag2 = !flag;
				Func<MissionInfo, bool> predicate = _003C_003Ec._003C_003E9__72_0;
				if (!flag2)
				{
					nint num4 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v31 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num5 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v51 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num6 = 0;
					_ = 0;
					Func<MissionInfo, bool> func = default;
					object obj7 = func + 16;
					obj7 = _003C_003Ec._003C_003E9;
					nint num7 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v48 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+5C]");
					object obj8 = (nint)0 + (nint)8;
					obj8 = func;
					predicate = func;
				}
				int num8 = Enumerable.Count((IEnumerable<MissionInfo>)currentMissionSet, predicate);
				IEnumerator routine2 = missionCell.AnimateProgressBarCoroutine(num8);
				Coroutine coroutine2 = missionCell.StartCoroutine_Auto(routine2);
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CAnimateBackgroundProgress_003Ed__72(int _003C_003E1__state)
		{
			//IL_0009: Expected Obj, but got I4
			//IL_002e: Expected Obj, but got I4
			string tag = ((Component)_003C_003E1__state).tag;
			bool flag = this._003C_003E1__state != 0;
			((GameObject)(object)tag).tag = (string)flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		}

		void IDisposable.Dispose()
		{
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

	private sealed class _003CCompleteAnimationInternal_003Ed__73(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public MissionCell _003C_003E4__this;

		public int completedMissionsCount;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0069: Expected Obj, but got I
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b9: Expected Obj, but got Unknown
				//IL_00d5: Expected Obj, but got I4
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Expected Obj, but got Unknown
				//IL_0145: Expected Obj, but got I4
				//IL_0165: Expected Obj, but got I
				//IL_01a0: Expected Obj, but got I
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Expected Obj, but got Unknown
				//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c4: Expected Obj, but got Unknown
				MissionCell missionCell = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Pages.MissionsPageInternal.MissionCell)+60]");
							object obj = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v38+3C]");
							if ((nint)0 != 0)
							{
								nint num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S2_v10 (Il2CppMethodInfo)+18]");
								object obj2 = 0;
								object obj3 = obj2;
								object obj4 = obj3 & 0x3FFF;
								object obj5 = obj4 + 97173;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v69 @ S3_v8 (should have been resolved before IL gen)");
							}
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					FinalDayHelper.DailyWordPayload data = ((FinalDayHelper)(object)missionCell).GetData();
					Coroutine coroutine = missionCell.StartCoroutine_Auto((IEnumerator)data);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = -1f;
					_ = 0.8f;
					object obj6 = this + 12;
					object obj7 = default;
					obj6 = obj7;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Pages.MissionsPageInternal.MissionCell)+60]");
				object obj8 = (nint)0 + (nint)20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v4+4]");
				GameObject routine = ((FirstPurchaseBonusQuickShopHelper)(object)missionCell).CreateEmptyWidget(0);
				Coroutine coroutine2 = missionCell.StartCoroutine_Auto((IEnumerator)(object)routine);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = -1f;
				_ = 1f;
				object obj9 = this + 12;
				object obj10 = default;
				obj9 = obj10;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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

	private sealed class _003CAnimateProgressBarCoroutine_003Ed__74(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public MissionCell _003C_003E4__this;

		public int finalProgress;

		private float _003CcurrentDuration_003E5__2;

		private float _003CstartProgress_003E5__3;

		private int _003Cgoal_003E5__4;

		private float _003CfirstInterval_003E5__5;

		private float _003CsecondInterval_003E5__6;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_042c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0431: Expected VT, but got Unknown
				//IL_043a: Unknown result type (might be due to invalid IL or missing references)
				//IL_043f: Expected Obj, but got Unknown
				//IL_0448: Unknown result type (might be due to invalid IL or missing references)
				//IL_044d: Expected Obj, but got Unknown
				//IL_0456: Expected Obj, but got I4
				//IL_045f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0464: Expected Obj, but got Unknown
				//IL_046d: Expected Obj, but got I4
				//IL_006d: Expected F4, but got I4
				//IL_015b: Expected I, but got Obj
				//IL_0171: Expected Obj, but got I
				//IL_04c9: Expected F4, but got I4
				//IL_04e2: Expected Obj, but got I4
				//IL_011f: Expected Obj, but got I4
				//IL_019c: Expected I, but got Obj
				//IL_021a: Unknown result type (might be due to invalid IL or missing references)
				//IL_021f: Expected Obj, but got Unknown
				//IL_024e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0253: Expected Obj, but got Unknown
				//IL_025c: Expected Obj, but got I4
				//IL_0270: Expected Obj, but got I4
				//IL_04ff: Expected I, but got Obj
				//IL_0515: Expected Obj, but got I
				//IL_0548: Expected F4, but got Obj
				//IL_0543: Expected native int or pointer, but got VT
				//IL_055d: Expected F4, but got I
				//IL_0558: Expected native int or pointer, but got VT
				//IL_03ca: Expected F4, but got Obj
				//IL_03c5: Expected native int or pointer, but got VT
				//IL_03df: Expected F4, but got I
				//IL_03da: Expected native int or pointer, but got VT
				//IL_03ec: Expected Obj, but got VT
				//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f7: Expected Obj, but got Unknown
				//IL_0400: Expected Obj, but got I4
				//IL_0414: Expected Obj, but got I4
				//IL_037e: Expected I, but got Obj
				object obj = default;
				Vector3 vector = (Vector3)(obj + 40);
				object obj2 = obj + 12;
				object obj3 = obj + 36;
				obj3 = 0;
				object obj4 = obj + 24;
				obj4 = 0;
				_ = 0;
				MissionCell missionCell = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							goto IL_0275;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					_003CcurrentDuration_003E5__2 = 0f;
					_003CstartProgress_003E5__3 = missionCell._currentProgress;
					_003Cgoal_003E5__4 = finalProgress;
					_003CfirstInterval_003E5__5 = 0.5f;
					_003CsecondInterval_003E5__6 = 0.5f;
				}
				if (!(_003CcurrentDuration_003E5__2 < _003CfirstInterval_003E5__5))
				{
					_003CcurrentDuration_003E5__2 = 0f;
					string tag = missionCell._progressFlashSprite.tag;
					((GameObject)(object)tag).tag = (string)1;
					goto IL_0275;
				}
				float fixedDeltaTime = Time.fixedDeltaTime;
				float num = _003CcurrentDuration_003E5__2 + fixedDeltaTime;
				_003CcurrentDuration_003E5__2 = num;
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v16 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S2_v32 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float t = _003CcurrentDuration_003E5__2 / _003CfirstInterval_003E5__5;
				float num4 = Mathf.LerpUnclamped(_003CstartProgress_003E5__3, _003Cgoal_003E5__4, t);
				int num5 = NumberExtensions.CeilToInt(num4);
				obj3 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
				int fontSize = default;
				missionCell._missionProgress.fontSize = fontSize;
				int currentProgress = NumberExtensions.CeilToInt(num4);
				missionCell._currentProgress = currentProgress;
				object obj6 = missionCell._payload + 20;
				float num6 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S2_v29+4]");
				float alpha = num6 / 0f;
				missionCell._progressSlider.alpha = alpha;
				object obj7 = this + 12;
				obj7 = 0;
				_003C_003E1__state = 1;
				return 1;
				IL_0275:
				if (_003CcurrentDuration_003E5__2 < _003CsecondInterval_003E5__6)
				{
					float fixedDeltaTime2 = Time.fixedDeltaTime;
					float num7 = _003CcurrentDuration_003E5__2 + fixedDeltaTime2;
					_003CcurrentDuration_003E5__2 = num7;
					float num8 = _003CcurrentDuration_003E5__2 / _003CsecondInterval_003E5__6;
					float num9 = 1f - num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					float num10 = Easings.ElasticEaseInOut(num8);
					bool flag = num8 > 372f / 1023f;
					bool flag2 = !flag;
					float angle = num10;
					if (!flag2)
					{
						float num11 = num10 - 1f;
						float num12 = num11 / 5f;
						float num13 = num12 + 1f;
						angle = num13;
					}
					nint num14 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v35 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num15 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v52 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 forward = Vector3.forward;
					((Vector3*)(nint)vector)->x = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Quaternion quaternion = Quaternion.AngleAxis(angle, vector);
					obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					GameObject gameObject = missionCell._missionProgress.gameObject;
					((Vector3*)(nint)vector)->x = (float)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
					((Vector3*)(nint)vector)->z = 0f;
					((Transform)(object)gameObject).parent = (Transform)vector;
					object obj9 = this + 12;
					obj9 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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

	private sealed class _003CAnimateBottomPanelCoroutine_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MissionCell _003C_003E4__this;

		private float _003CcurrentDuration_003E5__2;

		private float _003CfirstInterval_003E5__3;

		private float _003CsecondInterval_003E5__4;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0801: Unknown result type (might be due to invalid IL or missing references)
				//IL_0806: Expected I4, but got Unknown
				//IL_080f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0814: Expected Obj, but got Unknown
				//IL_081d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0822: Expected Obj, but got Unknown
				//IL_082b: Expected Obj, but got I4
				//IL_083a: Unknown result type (might be due to invalid IL or missing references)
				//IL_083f: Expected Obj, but got Unknown
				//IL_0848: Expected Obj, but got I4
				//IL_00c0: Expected Obj, but got I4
				//IL_00d3: Expected I, but got Obj
				//IL_00e9: Expected Obj, but got I
				//IL_088e: Expected Obj, but got I4
				//IL_08b0: Expected I4, but got Obj
				//IL_08dd: Expected I, but got Obj
				//IL_08f3: Expected Obj, but got I
				//IL_0114: Expected I, but got Obj
				//IL_0458: Expected I, but got Obj
				//IL_046e: Expected Obj, but got I
				//IL_0161: Expected I, but got Obj
				//IL_0a14: Expected I4, but got Obj
				//IL_0a2e: Expected Obj, but got I4
				//IL_0a2e: Expected Obj, but got I4
				//IL_02e4: Expected I, but got Obj
				//IL_02fa: Expected Obj, but got I
				//IL_0778: Expected I, but got Obj
				//IL_078e: Expected Obj, but got I
				//IL_01ae: Expected I, but got Obj
				//IL_01c4: Expected Obj, but got I
				//IL_04e6: Expected Obj, but got I4
				//IL_04f4: Expected I, but got Obj
				//IL_050a: Expected Obj, but got I
				//IL_0499: Expected I, but got Obj
				//IL_09b4: Expected I4, but got Obj
				//IL_09ce: Expected VT, but got I4
				//IL_0b26: Expected I4, but got Obj
				//IL_0b40: Expected Obj, but got I4
				//IL_095a: Unknown result type (might be due to invalid IL or missing references)
				//IL_095f: Expected Obj, but got Unknown
				//IL_0976: Expected I, but got Obj
				//IL_098c: Expected Obj, but got I
				//IL_0582: Expected I, but got Obj
				//IL_0598: Expected Obj, but got I
				//IL_037e: Expected I4, but got Obj
				//IL_0398: Expected Obj, but got I4
				//IL_0398: Expected Obj, but got I4
				//IL_0325: Expected I, but got Obj
				//IL_07b9: Expected I, but got Obj
				//IL_0684: Expected I, but got Obj
				//IL_069a: Expected Obj, but got I
				//IL_01ef: Expected I, but got Obj
				//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a76: Expected Obj, but got Unknown
				//IL_0a8d: Expected I, but got Obj
				//IL_0aa3: Expected Obj, but got I
				//IL_0535: Expected I, but got Obj
				//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e6: Expected Obj, but got Unknown
				//IL_0ac6: Expected I4, but got Obj
				//IL_0ae0: Expected VT, but got I4
				//IL_05c3: Expected I, but got Obj
				//IL_0711: Expected I4, but got Obj
				//IL_072b: Expected Obj, but got I4
				//IL_0731: Unknown result type (might be due to invalid IL or missing references)
				//IL_0736: Expected Obj, but got Unknown
				//IL_073f: Expected Obj, but got I4
				//IL_0753: Expected Obj, but got I4
				//IL_06c5: Expected I, but got Obj
				object obj = default;
				UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 56);
				object obj2 = obj + 16;
				object obj3 = obj + 44;
				obj3 = 0;
				_ = 0;
				object obj4 = obj + 32;
				obj4 = 0;
				_ = 0;
				MissionCell missionCell = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							if (_003CcurrentDuration_003E5__2 < _003CsecondInterval_003E5__4)
							{
								float fixedDeltaTime = Time.fixedDeltaTime;
								float num = _003CcurrentDuration_003E5__2 + fixedDeltaTime;
								_003CcurrentDuration_003E5__2 = num;
								float p = _003CcurrentDuration_003E5__2 / _003CsecondInterval_003E5__4;
								float angle = Easings.ElasticEaseInOut(p);
								nint num2 = (nint)typeof(Vector3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v37 (Il2CppClass<UnityEngine.Vector3>)+BA]");
								object obj5 = (nint)0 & (nint)0x200;
								if (obj5 != null)
								{
									nint num3 = (nint)typeof(Vector3);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v54 (Il2CppClass<UnityEngine.Vector3>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Vector3 forward = Vector3.forward;
								((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
								_ = 0;
								Quaternion quaternion = Quaternion.AngleAxis(angle, (Vector3)pivot);
								obj4 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
								_ = 0;
								GameObject gameObject = missionCell._checkmarkSprite.gameObject;
								((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+8]");
								_ = 0;
								((Transform)(object)gameObject).parent = (Transform)pivot;
								object obj6 = this + 12;
								obj6 = 0;
								_003C_003E1__state = 2;
								return 1;
							}
							GameObject gameObject2 = missionCell._checkmarkSprite.gameObject;
							nint num4 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S1_v18 (Il2CppClass<UnityEngine.Vector3>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num5 = (nint)typeof(Vector3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v26 (Il2CppClass<UnityEngine.Vector3>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Vector3 forward2 = Vector3.forward;
							((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
							_ = 0;
							((Transform)(object)gameObject2).parent = (Transform)pivot;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					if (_003CcurrentDuration_003E5__2 < _003CfirstInterval_003E5__3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						float fixedDeltaTime2 = Time.fixedDeltaTime;
						float num6 = _003CcurrentDuration_003E5__2 + fixedDeltaTime2;
						_003CcurrentDuration_003E5__2 = num6;
						float num7 = _003CcurrentDuration_003E5__2 / _003CsecondInterval_003E5__4;
						float angle2 = Easings.ElasticEaseInOut(num7);
						nint num8 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v81 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num9 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v102 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3 forward3 = Vector3.forward;
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
						_ = 0;
						Quaternion quaternion2 = Quaternion.AngleAxis(angle2, (Vector3)pivot);
						obj3 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						_ = 0;
						string tag = missionCell._completedLabel.tag;
						int layer = ((GameObject)(object)tag).layer;
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						_ = 0;
						((Transform)layer).parent = (Transform)pivot;
						float num10 = num7 * num7;
						float num11 = num10 * num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num12 = 0;
						_ = 0;
						object obj10 = default;
						object obj9 = obj10 + 16;
						object obj11 = default;
						obj9 = obj11;
						throw new NullReferenceException();
					}
					string tag2 = missionCell._completedLabel.tag;
					int layer2 = ((GameObject)(object)tag2).layer;
					nint num13 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v60 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num14 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S1_v115 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 forward4 = Vector3.forward;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					((Transform)layer2).parent = (Transform)pivot;
					_003CcurrentDuration_003E5__2 = 0f;
					string tag3 = missionCell._checkmarkSprite.tag;
					((GameObject)(object)tag3).tag = (string)1;
					nint num15 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S1_v72 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num16 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S1_v109 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num17 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S1_v83 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num18 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S1_v103 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num19 = 0;
					_ = 0;
					object obj16 = default;
					object obj15 = obj16 + 16;
					obj15 = _003C_003Ec._003C_003E9;
					nint num20 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ S1_v100 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+5C]");
					object obj17 = (nint)0 + (nint)16;
					obj17 = obj16;
					throw new NullReferenceException();
				}
				_003C_003E1__state = -1;
				_003CcurrentDuration_003E5__2 = 0f;
				string tag4 = missionCell._inProgressDisplay.tag;
				((GameObject)(object)tag4).tag = null;
				string tag5 = missionCell._checkmarkSprite.tag;
				((GameObject)(object)tag5).tag = null;
				string tag6 = missionCell._completedLabel.tag;
				((GameObject)(object)tag6).tag = (string)1;
				nint num21 = (nint)typeof(ColorData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S1_v166 (Il2CppClass<UI.ColorData>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num22 = (nint)typeof(ColorData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S1_v221 (Il2CppClass<UI.ColorData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
				object obj19 = (flag ? 1 : 0) + 204;
				obj2 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S2_v64+8]");
				_ = 0;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				missionCell._backgroundSprite.rawPivot = pivot;
				nint num23 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S1_v176 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num24 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S1_v215 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (_003C_003Ec._003C_003E9__75_0 == null)
				{
					nint num25 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S1_v189 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num26 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S1_v209 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num27 = 0;
					_ = 0;
					object obj23 = default;
					object obj22 = obj23 + 16;
					obj22 = _003C_003Ec._003C_003E9;
					nint num28 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S1_v206 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+5C]");
					object obj24 = (nint)0 + (nint)12;
					obj24 = obj23;
				}
				throw new NullReferenceException();
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CAnimateBottomPanelCoroutine_003Ed__75(int _003C_003E1__state)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		}

		void IDisposable.Dispose()
		{
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

	private UISprite _headerSprite;

	private UILabel _missionText;

	private UILabel _missionSkipText;

	private UILabel _skipCost;

	private UILabel _videoLabel;

	private UILabel _missionProgress;

	private UISlider _progressSlider;

	private GameObject _progressComplete;

	private UISprite _progressFlashSprite;

	private UILabel _completedLabel;

	private UISprite _checkmarkSprite;

	private List<UISprite> _completedGlows;

	private UIButton _skipWithKeysButton;

	private UIButton _skipWithVideoButton;

	private UISprite _backgroundSprite;

	private UIWidget _inProgressDisplay;

	private UIWidget _completedDisplay;

	private GameObject _animatedTVIconPrefab;

	private UIWidget _animatedTVIconContainer;

	private bool hasSkippedMission__BackingField;

	private bool isVideoPlaying__BackingField;

	private MissionCellPayload _payload;

	private int _currentProgress;

	private bool _hasHookedUpEvents;

	private bool _isNewlyCreated;

	private const int MIN_BG_HEIGHT = 80;

	private const int MIN_BG_HEIGHT_FOR_CHALLENGES_SCREEN = 109;

	private const int BG_TRIGGER_HEIGHT = 88;

	private const int MIN_HEADER_HEIGHT = 45;

	public const int MAX_HEADER_HEIGHT = 50;

	public unsafe bool hasSkippedMission
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_progressComplete != 0;
		}
		private set
		{
			//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b1: Expected VT, but got Unknown
			//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bf: Expected Obj, but got Unknown
			//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cd: Expected Obj, but got Unknown
			//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04db: Expected Obj, but got Unknown
			//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e9: Expected Obj, but got Unknown
			//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f7: Expected Obj, but got Unknown
			//IL_0500: Unknown result type (might be due to invalid IL or missing references)
			//IL_0505: Expected Obj, but got Unknown
			//IL_050e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0513: Expected Obj, but got Unknown
			//IL_051c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0521: Expected Obj, but got Unknown
			//IL_052a: Unknown result type (might be due to invalid IL or missing references)
			//IL_052f: Expected Obj, but got Unknown
			//IL_0538: Unknown result type (might be due to invalid IL or missing references)
			//IL_053d: Expected Obj, but got Unknown
			//IL_0546: Unknown result type (might be due to invalid IL or missing references)
			//IL_054b: Expected Obj, but got Unknown
			//IL_0554: Unknown result type (might be due to invalid IL or missing references)
			//IL_0559: Expected Obj, but got Unknown
			//IL_0562: Unknown result type (might be due to invalid IL or missing references)
			//IL_0567: Expected Obj, but got Unknown
			//IL_0570: Unknown result type (might be due to invalid IL or missing references)
			//IL_0575: Expected Obj, but got Unknown
			//IL_057e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0583: Expected Obj, but got Unknown
			//IL_058c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0591: Expected Obj, but got Unknown
			//IL_059a: Unknown result type (might be due to invalid IL or missing references)
			//IL_059f: Expected Obj, but got Unknown
			//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ad: Expected Obj, but got Unknown
			//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bb: Expected Obj, but got Unknown
			//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c9: Expected Obj, but got Unknown
			//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d7: Expected Obj, but got Unknown
			//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e5: Expected Obj, but got Unknown
			//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f3: Expected Obj, but got Unknown
			//IL_060f: Expected Obj, but got I4
			//IL_024d: Expected F4, but got Obj
			//IL_0248: Expected native int or pointer, but got VT
			//IL_0262: Expected F4, but got I
			//IL_025d: Expected native int or pointer, but got VT
			//IL_0271: Expected I4, but got VT
			//IL_027f: Expected I, but got Obj
			//IL_0295: Expected Obj, but got I
			//IL_0059: Expected I, but got Obj
			//IL_006f: Expected Obj, but got I
			//IL_06d4: Expected Obj, but got VT
			//IL_06e9: Expected F4, but got Obj
			//IL_06e4: Expected native int or pointer, but got VT
			//IL_0703: Expected F4, but got Obj
			//IL_06fe: Expected native int or pointer, but got VT
			//IL_0718: Expected F4, but got I
			//IL_0713: Expected native int or pointer, but got VT
			//IL_072b: Expected Obj, but got VT
			//IL_0740: Expected F4, but got Obj
			//IL_073b: Expected native int or pointer, but got VT
			//IL_063a: Expected Obj, but got VT
			//IL_064f: Expected F4, but got Obj
			//IL_064a: Expected native int or pointer, but got VT
			//IL_0669: Expected F4, but got Obj
			//IL_0664: Expected native int or pointer, but got VT
			//IL_067e: Expected F4, but got I
			//IL_0679: Expected native int or pointer, but got VT
			//IL_068d: Expected I4, but got VT
			//IL_0696: Expected Obj, but got VT
			//IL_06ab: Expected F4, but got Obj
			//IL_06a6: Expected native int or pointer, but got VT
			//IL_030c: Expected F4, but got Obj
			//IL_0307: Expected native int or pointer, but got VT
			//IL_0321: Expected F4, but got I
			//IL_031c: Expected native int or pointer, but got VT
			//IL_0334: Expected Obj, but got VT
			//IL_0349: Expected F4, but got Obj
			//IL_0344: Expected native int or pointer, but got VT
			//IL_02c0: Expected I, but got Obj
			//IL_00e6: Expected F4, but got Obj
			//IL_00e1: Expected native int or pointer, but got VT
			//IL_00fb: Expected F4, but got I
			//IL_00f6: Expected native int or pointer, but got VT
			//IL_010a: Expected I4, but got VT
			//IL_0113: Expected Obj, but got VT
			//IL_0128: Expected F4, but got Obj
			//IL_0123: Expected native int or pointer, but got VT
			//IL_009a: Expected I, but got Obj
			//IL_0368: Expected F4, but got Obj
			//IL_0363: Expected native int or pointer, but got VT
			//IL_037d: Expected F4, but got I
			//IL_0378: Expected native int or pointer, but got VT
			//IL_038c: Expected I4, but got VT
			//IL_0395: Expected Obj, but got VT
			//IL_03aa: Expected F4, but got Obj
			//IL_03a5: Expected native int or pointer, but got VT
			//IL_0147: Expected F4, but got Obj
			//IL_0142: Expected native int or pointer, but got VT
			//IL_015c: Expected F4, but got I
			//IL_0157: Expected native int or pointer, but got VT
			//IL_0165: Expected Obj, but got VT
			//IL_0172: Expected Obj, but got VT
			//IL_0187: Expected F4, but got Obj
			//IL_0182: Expected native int or pointer, but got VT
			//IL_03c9: Expected F4, but got Obj
			//IL_03c4: Expected native int or pointer, but got VT
			//IL_03de: Expected F4, but got I
			//IL_03d9: Expected native int or pointer, but got VT
			//IL_03e7: Expected Obj, but got VT
			//IL_03f4: Expected Obj, but got VT
			//IL_0409: Expected F4, but got Obj
			//IL_0404: Expected native int or pointer, but got VT
			//IL_01a6: Expected F4, but got Obj
			//IL_01a1: Expected native int or pointer, but got VT
			//IL_01bb: Expected F4, but got I
			//IL_01b6: Expected native int or pointer, but got VT
			//IL_01ca: Expected I4, but got VT
			//IL_01d3: Expected Obj, but got VT
			//IL_01e8: Expected F4, but got Obj
			//IL_01e3: Expected native int or pointer, but got VT
			//IL_0428: Expected F4, but got Obj
			//IL_0423: Expected native int or pointer, but got VT
			//IL_043d: Expected F4, but got I
			//IL_0438: Expected native int or pointer, but got VT
			//IL_044c: Expected I4, but got VT
			//IL_0455: Expected Obj, but got VT
			//IL_046a: Expected F4, but got Obj
			//IL_0465: Expected native int or pointer, but got VT
			//IL_0207: Expected F4, but got Obj
			//IL_0202: Expected native int or pointer, but got VT
			//IL_021c: Expected F4, but got I
			//IL_0217: Expected native int or pointer, but got VT
			//IL_0489: Expected F4, but got Obj
			//IL_0484: Expected native int or pointer, but got VT
			//IL_049e: Expected F4, but got I
			//IL_0499: Expected native int or pointer, but got VT
			//IL_06c6: Expected Obj, but got VT
			object obj = default;
			Matrix4x4 matrix4x = (Matrix4x4)(obj + 248);
			object obj2 = obj + 192;
			object obj3 = obj + 176;
			object obj4 = obj + 244;
			object obj5 = obj + 152;
			object obj6 = obj + 136;
			object obj7 = obj + 240;
			object obj8 = obj + 120;
			object obj9 = obj + 104;
			object obj10 = obj + 236;
			object obj11 = obj + 88;
			object obj12 = obj + 72;
			object obj13 = obj + 232;
			object obj14 = obj + 56;
			object obj15 = obj + 40;
			object obj16 = obj + 228;
			object obj17 = obj + 224;
			object obj18 = obj + 220;
			object obj19 = obj + 216;
			object obj20 = obj + 212;
			object obj21 = obj + 24;
			object obj22 = obj + 208;
			object obj23 = obj + 16;
			object obj24 = obj + 168;
			string text = _headerSprite.tag;
			((GameObject)(object)text).tag = (string)value;
			bool isTrigger = (byte)((value ? 1u : 0u) ^ 1u) != 0;
			((Collider)(object)_skipCost).isTrigger = isTrigger;
			GameObject[] hideWhenPopupsActive = _hideWhenPopupsActive;
			GameObject gameObject = hideWhenPopupsActive[1];
			if (value)
			{
				_ = _missionProgress;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A665");
				nint num = (nint)typeof(GlobalColorsGenerated);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v103 (Il2CppClass<GlobalColorsGenerated>)+BA]");
				object obj25 = (nint)0 & (nint)0x200;
				if (obj25 != null)
				{
					nint num2 = (nint)typeof(GlobalColorsGenerated);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v148 (Il2CppClass<GlobalColorsGenerated>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_BG_GRADIENT_TOP;
				obj4 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
				Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				((UIWidget)(object)_hideWhenPopupsActive).rawPivot = (UIWidget.Pivot)matrix4x;
				obj5 = GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_TITLE_TEXT;
				obj7 = obj5;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
				Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_missionText.rawPivot = (UIWidget.Pivot)matrix4x;
				obj8 = GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_TITLE_TEXT_SHADOW;
				obj10 = obj8;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
				Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				Vector2 effectDistance = ((UILabel)matrix4x).effectDistance;
				obj11 = GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_STATUS_TEXT;
				obj13 = obj11;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
				Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_missionSkipText.rawPivot = (UIWidget.Pivot)matrix4x;
				obj14 = GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_STATUS_TEXT_SHADOW;
				obj16 = obj14;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj16;
				Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			}
			else
			{
				_ = _videoLabel;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A665");
				Color black = Color.black;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				((UIWidget)(object)_hideWhenPopupsActive).rawPivot = (UIWidget.Pivot)matrix4x;
				nint num3 = (nint)typeof(GlobalColorsGenerated);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v41 (Il2CppClass<GlobalColorsGenerated>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num4 = (nint)typeof(GlobalColorsGenerated);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v93 (Il2CppClass<GlobalColorsGenerated>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = GlobalColorsGenerated.WEEKLYHUNT_REWARD_BG_GRADIENT_TOP;
				obj17 = obj3;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj17;
				Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A667");
				obj6 = GlobalColorsGenerated.WEEKLYHUNT_REWARD_BG_GRADIENT_BOTTOM;
				obj18 = obj6;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj18;
				Matrix4x4 matrix4x8 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A668");
				obj9 = GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_TITLE_TEXT;
				obj19 = obj9;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
				Matrix4x4 matrix4x9 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_missionText.rawPivot = (UIWidget.Pivot)matrix4x;
				obj12 = GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_TITLE_TEXT_SHADOW;
				obj20 = obj12;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj20;
				Matrix4x4 matrix4x10 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				Vector2 effectDistance2 = ((UILabel)matrix4x).effectDistance;
				obj15 = GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_STATUS_TEXT;
				obj22 = obj15;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj22;
				Matrix4x4 matrix4x11 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_missionSkipText.rawPivot = (UIWidget.Pivot)matrix4x;
				obj23 = GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_STATUS_TEXT_SHADOW;
				obj24 = obj23;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj24;
				Matrix4x4 matrix4x12 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			}
			Vector2 effectDistance3 = ((UILabel)matrix4x).effectDistance;
		}
	}

	public bool isVideoPlaying
	{
		get
		{
			return hasSkippedMission__BackingField;
		}
		private set
		{
			hasSkippedMission__BackingField = value;
		}
	}

	public void Init(MissionCellPayload payload)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(payload & 1) != 0;
		isVideoPlaying__BackingField = flag;
	}

	private void HookEvents()
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		_videoLabel = (UILabel)3;
		_missionProgress = (UILabel)(-14);
		CancelInvoke();
	}

	private unsafe void UnhookEvents()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00e2: Expected I, but got Obj
		//IL_00f8: Expected Obj, but got I
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02af: Expected Obj, but got I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0123: Expected I, but got Obj
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		if (~(_hasHookedUpEvents ? 1u : 0u) == 0)
		{
			return;
		}
		_hasHookedUpEvents = true;
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(MissionCell.OnMissionProgress);
		object obj2 = obj + 16;
		obj2 = this;
		object obj3 = instance + 44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v11 (Missions.StayInOneLaneMission)+2C]");
		Delegate obj4 = ((Delegate)0).CombineImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj5 = default;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj6 = action + 16;
		obj6 = this;
		AdSystemManager.onFailedToShowVideo -= action;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v32 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v62 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(MissionCell.OnVideoOverlayClosed);
		object obj8 = action2 + 16;
		obj8 = this;
		((UIScreenController)flag).OnOverlayManuallyClosed -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj9 = action3 + 16;
		obj9 = this;
		UIScreenController.OnPopupShown -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr3;
		((Delegate)action4).method = (nint)__ldftn(MissionCell.OnLastPopupClosed);
		object obj10 = action4 + 16;
		obj10 = this;
		UIScreenController.OnLastPopupClosed -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action5 = default;
		((Delegate)action5).method_ptr = method_ptr4;
		((Delegate)action5).method = (nint)__ldftn(MissionCell.ShowSkipButton);
		object obj11 = action5 + 16;
		obj11 = this;
		UIScreenController.OnApplicationResumed -= action5;
	}

	private unsafe void OnDisable()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00e2: Expected I, but got Obj
		//IL_00f8: Expected Obj, but got I
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_0123: Expected I, but got Obj
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		if (~(_hasHookedUpEvents ? 1u : 0u) != 0)
		{
			return;
		}
		_hasHookedUpEvents = false;
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(MissionCell.OnMissionProgress);
		object obj2 = obj + 16;
		obj2 = this;
		object obj3 = instance + 44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Missions.StayInOneLaneMission)+2C]");
		Delegate obj4 = ((Delegate)0).RemoveImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj5 = default;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj6 = action + 16;
		obj6 = this;
		AdSystemManager.onDismissedVideo += action;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v31 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v61 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		string text = default;
		text.m_stringLength = (int)num4;
		_ = 0;
		object obj8 = text + 16;
		obj8 = this;
		((UIScreenController)flag).ShowVideoAdsOverlay(text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(MissionCell.OnPopupShown);
		object obj9 = action2 + 16;
		obj9 = this;
		UIScreenController.OnLastPopupClosed += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj10 = action3 + 16;
		obj10 = this;
		UIScreenController.OnPopupClosed += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		Action<string> action4 = default;
		object obj11 = action4 + 16;
		obj11 = this;
		UIScreenController.OnPopupShown += action4;
	}

	private void OnLastPopupClosed()
	{
		_isNewlyCreated = false;
	}

	private void OnPopupShown(string popupName)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_002c: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		hasSkippedMission__BackingField = false;
		object obj = this + 96;
		obj = popupName;
		Color color = ((UIWidget)popupName.m_stringLength).color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [popupName @ L1 (System.String)+10]");
		UIWidget uIWidget;
		if ((nint)0 > (nint)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [popupName @ L1 (System.String)+10]");
			uIWidget = (UIWidget)0;
		}
		else
		{
			UISprite backgroundSprite = _backgroundSprite;
			uIWidget = ((((UIWidget)backgroundSprite).mHeight >= 89) ? ((UIWidget)50) : ((UIWidget)45));
		}
		Color color2 = uIWidget.color;
		string text = _backgroundSprite.tag;
		MissionCellPayload payload = _payload;
		bool flag = payload.cellHeight > 80;
		((GameObject)(object)text).tag = (string)flag;
		UnhookEvents();
		CreateTVIcon();
		OnDestroy();
		RefreshState();
		_isNewlyCreated = true;
	}

	private void AlignCompletedText()
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

	private void CreateTVIcon()
	{
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_013f: Expected I, but got Obj
		//IL_0155: Expected Obj, but got I
		//IL_018f: Expected I4, but got Obj
		//IL_0060: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got VT
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 12;
		obj = this;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v31 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("MISSION_PAGE_COMPLETED");
		_completedLabel.fontSize = (int)text;
		string text2 = _completedLabel.tag;
		((GameObject)(object)text2).tag = (string)1;
		string text3 = _checkmarkSprite.tag;
		((GameObject)(object)text3).tag = (string)1;
		_0021_00210 componentInChildren = (_0021_00210)((Component)_completedDisplay).GetComponentInChildren<T>();
		((RewardForVideoButton)componentInChildren).Init(null);
		object obj4 = _payload + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v21+24]");
		bool flag = (nint)0 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		string text4 = default;
		text4.m_stringLength = (int)num3;
		_ = 0;
		object obj5 = text4 + 16;
		obj5 = obj2;
		Timer.Log(text4);
	}

	private void OnDestroy()
	{
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_00bb: Expected I4, but got Obj
		//IL_00c8: Expected Obj, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00ed: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		string go = _animatedTVIconContainer.tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v2 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v7 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)_animatedTVIconPrefab != 0);
		FitSpriteToWidget component = ((GameObject)num3).GetComponent<FitSpriteToWidget>();
		object obj2 = component + 16;
		obj2 = _animatedTVIconContainer;
		FitSpriteToWidget component2 = ((GameObject)num3).GetComponent<FitSpriteToWidget>();
		component2.FitStretch();
	}

	private bool IsBottomBoxActive()
	{
		return isVideoPlaying__BackingField;
	}

	private bool CanShowBottomPanel()
	{
		//IL_001c: Expected I4, but got Obj
		string text = _backgroundSprite.tag;
		return (byte)(int)((GameObject)(object)text).tag != 0;
	}

	private void UpdateText()
	{
		OnDisable();
	}

	private static string AddNumberColor(int number)
	{
		//IL_0010: Expected Obj, but got I
		//IL_002c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [number @ L0 (System.Int32)+60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+8]");
		bool flag = (nint)0 > (nint)80;
		return (string)flag;
	}

	private unsafe int CalculateHeaderHeight()
	{
		//IL_00cd: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected VT, but got Unknown
		//IL_0147: Expected I4, but got Obj
		//IL_0142: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v32 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj2 = (flag ? 1 : 0) + 268;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6+8]");
		_ = 0;
		Color32 color = (Color32)(obj3 + 16);
		((Color32*)(nint)color)->rgba = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		string text = MiscExtensions.ToHex(color);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private void UpdateProgress()
	{
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I4
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got I4
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected Obj, but got Unknown
		//IL_03f6: Expected Obj, but got I
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_0486: Expected I, but got Obj
		//IL_049c: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_04e1: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 232;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj2 + 224;
		obj3 = 0;
		object obj4 = obj2 + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8292");
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+20]");
		_ = 0;
		object obj5 = obj2 + 144;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+20]");
		_ = 0;
		object obj6 = obj2 + 136;
		obj6 = obj5;
		object obj7 = obj2 + 96;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		object obj8 = obj2 + 88;
		obj8 = obj7;
		object obj9 = obj2 + 48;
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v40+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v53+20]");
		MissionCell missionCell = (MissionCell)(num - 0);
		object obj10 = obj2 + 8;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		obj2 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		string key;
		if ((nint)0 > (nint)1)
		{
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
			_ = 0;
			object obj11 = obj4 + 8;
			obj5 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v135+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v135+10]");
			_ = 0;
			key = (string)obj5;
		}
		else
		{
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
			_ = 0;
			object obj12 = obj4 + 8;
			obj5 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v118+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v118+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v24+4]");
			key = (string)0;
		}
		nint num2 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v78 (Il2CppClass<Strings>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v103 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(key);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v30+4]");
		int num4 = ((MissionCell)0).CalculateHeaderHeight();
		throw new ArrayTypeMismatchException();
	}

	private int GetSkipCost()
	{
		UISprite backgroundSprite = _backgroundSprite;
		if (((UIWidget)backgroundSprite).mHeight < 89)
		{
			return 45;
		}
		return 50;
	}

	public void OnBuyClicked()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		object obj = _payload + 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		_missionProgress.fontSize = fontSize;
		object obj2 = _payload + 20;
		object obj3 = _payload + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v7+20]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v7+4]");
		float alpha = num / 0f;
		_progressSlider.alpha = alpha;
		object obj4 = _payload + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v12+20]");
		_currentProgress = 0;
	}

	public void OnSkipWithVideoClicked()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_004b: Expected I4, but got Obj
		//IL_004b: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		object obj = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		hasSkippedMission__BackingField = true;
		SlideinPowerupHelper instance = SlideinPowerupHelper.Instance;
		MissionCellPayload payload = _payload;
		((SlideinPowerupButton)(object)instance).InitSlideinButton((SlideinPowerupHelper)payload.missionIndex, (int)this);
		((Breadcrumb)2)._002Ector();
	}

	private void OnShowVideoFailure(string locationID)
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

	private void OnVideoOverlayClosed()
	{
		//IL_00e2: Expected I, but got Obj
		//IL_00f8: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12+8]");
		bool flag = (nint)0 != 0;
		int numberOfOwnedBoards = ((OwnBoardsAward)flag).GetNumberOfOwnedBoards();
		AdTrackingSystemLogger.LogFillRequest((AdLocationInfo)numberOfOwnedBoards);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		hasSkippedMission__BackingField = true;
		OfferWallManager instance = OfferWallManager.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		string text = default;
		text.m_stringLength = (int)num3;
		_ = 0;
		object obj3 = text + 16;
		obj3 = this;
		((AdSystemManager)(object)instance).FinishedWatchingVideo((string)numberOfOwnedBoards, text);
		isVideoPlaying__BackingField = true;
		((Breadcrumb)2)._002Ector();
	}

	private void OnFinishedWatchingVideo()
	{
		if (~(isVideoPlaying__BackingField ? 1u : 0u) == 0)
		{
			OnPurchaseSuccessful();
		}
	}

	private void OnMissionProgress(int missionIndex, float completionFactor)
	{
		//IL_1110: Expected I, but got Obj
		//IL_1126: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_1171: Expected I, but got Obj
		//IL_1187: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_163f: Expected I, but got Obj
		//IL_1655: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_19a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a5: Expected Obj, but got Unknown
		//IL_19ae: Expected Obj, but got I4
		//IL_19b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bd: Expected Obj, but got Unknown
		//IL_19c6: Expected Obj, but got I4
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_10c3: Expected I, but got Obj
		//IL_048f: Expected I, but got Obj
		//IL_04a5: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_05ab: Expected I, but got Obj
		//IL_05c1: Expected Obj, but got I
		//IL_04d0: Expected I, but got Obj
		//IL_12e3: Expected Obj, but got I4
		//IL_1304: Expected I4, but got Obj
		//IL_051d: Expected I, but got Obj
		//IL_0533: Expected Obj, but got I
		//IL_02e5: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I
		//IL_020a: Expected I, but got Obj
		//IL_1438: Expected I, but got Obj
		//IL_144e: Expected Obj, but got I
		//IL_05ec: Expected I, but got Obj
		//IL_1236: Expected I4, but got Obj
		//IL_1236: Expected I4, but got Obj
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_18ca: Expected I, but got Obj
		//IL_18e0: Expected Obj, but got I
		//IL_0639: Expected I, but got Obj
		//IL_064f: Expected Obj, but got I
		//IL_055e: Expected I, but got Obj
		//IL_0401: Expected I, but got Obj
		//IL_0417: Expected Obj, but got I
		//IL_0326: Expected I, but got Obj
		//IL_091e: Expected I, but got Obj
		//IL_1296: Expected I4, but got Obj
		//IL_0373: Expected I, but got Obj
		//IL_0389: Expected Obj, but got I
		//IL_0298: Expected I, but got Obj
		//IL_194c: Expected I, but got Obj
		//IL_1962: Expected Obj, but got I
		//IL_096b: Expected I, but got Obj
		//IL_067a: Expected I, but got Obj
		//IL_0442: Expected I, but got Obj
		//IL_09b8: Expected I, but got Obj
		//IL_09ce: Expected Obj, but got I
		//IL_06c7: Expected I, but got Obj
		//IL_06dd: Expected Obj, but got I
		//IL_03b4: Expected I, but got Obj
		//IL_0ca3: Expected I, but got Obj
		//IL_136d: Expected I, but got Obj
		//IL_1383: Expected Obj, but got I
		//IL_0cf0: Expected I, but got Obj
		//IL_0d06: Expected Obj, but got I
		//IL_190b: Expected I, but got Obj
		//IL_1921: Expected Obj, but got I
		//IL_09f9: Expected I, but got Obj
		//IL_13c5: Expected I, but got Obj
		//IL_13db: Expected Obj, but got I
		//IL_0708: Expected I, but got Obj
		//IL_16bd: Expected I, but got Obj
		//IL_16d3: Expected Obj, but got I
		//IL_0a2c: Expected I, but got Obj
		//IL_0a42: Expected Obj, but got I
		//IL_0755: Expected I, but got Obj
		//IL_0d31: Expected I, but got Obj
		//IL_0b14: Expected I, but got Obj
		//IL_0d64: Expected I, but got Obj
		//IL_0b47: Expected I, but got Obj
		//IL_0b5d: Expected Obj, but got I
		//IL_0a6d: Expected I, but got Obj
		//IL_08aa: Expected I, but got Obj
		//IL_08c0: Expected Obj, but got I
		//IL_0803: Expected I, but got Obj
		//IL_0d97: Expected I, but got Obj
		//IL_0dad: Expected Obj, but got I
		//IL_0aa0: Expected I, but got Obj
		//IL_0ab6: Expected Obj, but got I
		//IL_14b3: Expected Obj, but got I4
		//IL_14d4: Expected I4, but got Obj
		//IL_0836: Expected I, but got Obj
		//IL_084c: Expected Obj, but got I
		//IL_07ac: Expected I, but got Obj
		//IL_0c2f: Expected I, but got Obj
		//IL_0c45: Expected Obj, but got I
		//IL_0b88: Expected I, but got Obj
		//IL_1542: Unknown result type (might be due to invalid IL or missing references)
		//IL_1547: Expected Obj, but got Unknown
		//IL_1571: Expected Obj, but got I
		//IL_1586: Invalid comparison between Obj and F4
		//IL_08eb: Expected I, but got Obj
		//IL_0e7f: Expected I, but got Obj
		//IL_0e95: Expected Obj, but got I
		//IL_0dd8: Expected I, but got Obj
		//IL_162c: Expected I4, but got Obj
		//IL_162c: Expected I4, but got Obj
		//IL_0bbb: Expected I, but got Obj
		//IL_0bd1: Expected Obj, but got I
		//IL_0ae1: Expected I, but got Obj
		//IL_0877: Expected I, but got Obj
		//IL_1797: Expected I4, but got Obj
		//IL_0e0b: Expected I, but got Obj
		//IL_0e21: Expected Obj, but got I
		//IL_0c70: Expected I, but got Obj
		//IL_104f: Expected I, but got Obj
		//IL_1065: Expected Obj, but got I
		//IL_0ec0: Expected I, but got Obj
		//IL_0bfc: Expected I, but got Obj
		//IL_0ef3: Expected I, but got Obj
		//IL_0f09: Expected Obj, but got I
		//IL_0e4c: Expected I, but got Obj
		//IL_1090: Expected I, but got Obj
		//IL_0fdb: Expected I, but got Obj
		//IL_0ff1: Expected Obj, but got I
		//IL_0f34: Expected I, but got Obj
		//IL_183c: Expected I4, but got Obj
		//IL_0f67: Expected I, but got Obj
		//IL_0f7d: Expected Obj, but got I
		//IL_101c: Expected I, but got Obj
		//IL_0fa8: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v564 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouch == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v558 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		currentTouch.pressStarted = false;
		UICamera.MouseOrTouch currentTouch2 = UICamera.currentTouch;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v554 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)currentTouch2.pressed).FindKernel((string)null) != 0)
		{
			nint num7 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v64 (Il2CppClass<UICamera>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v548 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch3 = UICamera.currentTouch;
			if (~(currentTouch3.dragStarted ? 1u : 0u) == 0)
			{
				nint num9 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v471 (Il2CppClass<UICamera>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v542 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UICamera.onDragOut != null)
				{
					nint num11 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v529 (Il2CppClass<UICamera>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num12 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v536 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch4 = UICamera.currentTouch;
					UICamera.MouseOrTouch currentTouch5 = UICamera.currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				}
				nint num13 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v480 (Il2CppClass<UICamera>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num14 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v522 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch6 = UICamera.currentTouch;
				UICamera.MouseOrTouch currentTouch7 = UICamera.currentTouch;
				((UICamera)(object)currentTouch6.last).ProcessTouch((byte)(int)"OnDragOut" != 0, (byte)(int)currentTouch7.dragged != 0);
				if (UICamera.onDragEnd != null)
				{
					nint num15 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v509 (Il2CppClass<UICamera>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num16 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S0_v516 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch8 = UICamera.currentTouch;
					UICamera.onDragEnd.EndInvoke((IAsyncResult)(object)currentTouch8.dragged);
				}
				nint num17 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S0_v494 (Il2CppClass<UICamera>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num18 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v502 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch9 = UICamera.currentTouch;
				((UICamera)(object)currentTouch9.dragged).ProcessTouch((byte)(int)"OnDragEnd" != 0, false);
			}
			nint num19 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v74 (Il2CppClass<UICamera>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num20 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v464 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UICamera.onPress != null)
			{
				nint num21 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v451 (Il2CppClass<UICamera>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num22 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S0_v458 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch10 = UICamera.currentTouch;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
			nint num23 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v83 (Il2CppClass<UICamera>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num24 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v444 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch11 = UICamera.currentTouch;
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			bool released = default;
			((UICamera)(object)currentTouch11.pressed).ProcessTouch((byte)(int)"OnPress" != 0, released);
			if (missionIndex != 0)
			{
				nint num25 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ S0_v365 (Il2CppClass<UICamera>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num26 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ S0_v438 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch12 = UICamera.currentTouch;
				if (((UIFont)null).References((UIFont)(object)currentTouch12.pressed))
				{
					nint num27 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S0_v372 (Il2CppClass<UICamera>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num28 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S0_v432 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch13 = UICamera.currentTouch;
					nint num29 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S2_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num30 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ S2_v55 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = UICamera.mHover != currentTouch13.current;
					nint num31 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ S1_v103 (Il2CppClass<UICamera>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					bool flag2 = obj17 == null;
					if (!flag)
					{
						if (!flag2)
						{
							nint num32 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S0_v427 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UICamera.MouseOrTouch currentTouch14 = UICamera.currentTouch;
						UICamera.controllerNavigationObject = currentTouch14.current;
					}
					else
					{
						if (!flag2)
						{
							nint num33 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S0_v415 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (UICamera.onHover != null)
						{
							nint num34 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ S0_v403 (Il2CppClass<UICamera>)+BA]");
							object obj18 = (nint)0 & (nint)0x200;
							if (obj18 != null)
							{
								nint num35 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ S0_v410 (Il2CppClass<UICamera>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							UICamera.MouseOrTouch currentTouch15 = UICamera.currentTouch;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
						}
						nint num36 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ S0_v389 (Il2CppClass<UICamera>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num37 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ S0_v397 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UICamera.MouseOrTouch currentTouch16 = UICamera.currentTouch;
						obj13 = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						bool released2 = default;
						((UICamera)(object)currentTouch16.current).ProcessTouch((byte)(int)"OnHover" != 0, released2);
					}
				}
			}
			nint num38 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v94 (Il2CppClass<UICamera>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num39 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S0_v358 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch17 = UICamera.currentTouch;
			UICamera.MouseOrTouch currentTouch18 = UICamera.currentTouch;
			nint num40 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S0_v108 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num41 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S0_v354 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (currentTouch17.dragged != currentTouch18.current)
			{
				goto IL_193e;
			}
			nint num42 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ S0_v254 (Il2CppClass<UICamera>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num43 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ S0_v351 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			KeyCode currentKey = UICamera.currentKey;
			if (currentKey != (KeyCode)2)
			{
				nint num44 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S0_v319 (Il2CppClass<UICamera>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				if (obj23 != null)
				{
					nint num45 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ S0_v346 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch19 = UICamera.currentTouch;
				if (currentTouch19.clickNotification != UICamera.ClickNotification.None)
				{
					nint num46 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S0_v329 (Il2CppClass<UICamera>)+BA]");
					object obj24 = (nint)0 & (nint)0x200;
					if (obj24 != null)
					{
						nint num47 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ S0_v341 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj25 = UICamera.currentTouch + 36;
					object obj26 = obj25 * obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ S0_v336+4]");
					nint num48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ S0_v336+4]");
					object obj27 = num48 * 0;
					object obj28 = obj26 + obj27;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)completionFactor))
					{
						goto IL_193e;
					}
				}
			}
			nint num49 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ S0_v263 (Il2CppClass<UICamera>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num50 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ S0_v313 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch20 = UICamera.currentTouch;
			if (~(currentTouch20.dragStarted ? 1u : 0u) == 0)
			{
				nint num51 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ S0_v273 (Il2CppClass<UICamera>)+BA]");
				object obj30 = (nint)0 & (nint)0x200;
				if (obj30 != null)
				{
					nint num52 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ S0_v308 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UICamera.onDrop != null)
				{
					nint num53 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ S0_v296 (Il2CppClass<UICamera>)+BA]");
					object obj31 = (nint)0 & (nint)0x200;
					if (obj31 != null)
					{
						nint num54 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ S0_v303 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch21 = UICamera.currentTouch;
					UICamera.MouseOrTouch currentTouch22 = UICamera.currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				}
				nint num55 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ S0_v282 (Il2CppClass<UICamera>)+BA]");
				object obj32 = (nint)0 & (nint)0x200;
				if (obj32 != null)
				{
					nint num56 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ S0_v290 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch23 = UICamera.currentTouch;
				UICamera.MouseOrTouch currentTouch24 = UICamera.currentTouch;
				((UICamera)(object)currentTouch23.current).ProcessTouch((byte)(int)"OnDrop" != 0, (byte)(int)currentTouch24.dragged != 0);
			}
		}
		goto IL_1631;
		IL_1631:
		nint num57 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v40 (Il2CppClass<UICamera>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num58 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v57 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.MouseOrTouch currentTouch25 = UICamera.currentTouch;
		currentTouch25.dragStarted = false;
		object obj34 = UICamera.currentTouch + 56;
		obj34 = 0;
		object obj35 = UICamera.currentTouch + 60;
		obj35 = 0;
		return;
		IL_193e:
		nint num59 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ S0_v117 (Il2CppClass<UICamera>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num60 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ S0_v247 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.MouseOrTouch currentTouch26 = UICamera.currentTouch;
		if (currentTouch26.clickNotification != UICamera.ClickNotification.None)
		{
			nint num61 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S0_v126 (Il2CppClass<UICamera>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num62 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ S0_v242 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch27 = UICamera.currentTouch;
			UICamera.MouseOrTouch currentTouch28 = UICamera.currentTouch;
			nint num63 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ S2_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj38 = (nint)0 & (nint)0x200;
			if (obj38 != null)
			{
				nint num64 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ S2_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (currentTouch27.pressed != currentTouch28.current)
			{
				nint num65 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ S0_v137 (Il2CppClass<UICamera>)+BA]");
				object obj39 = (nint)0 & (nint)0x200;
				if (obj39 != null)
				{
					nint num66 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ S0_v239 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BMFont bmFont = ((UIFont)null).bmFont;
				float unscaledDeltaTime = Time.unscaledDeltaTime;
				if (UICamera.onClick != null)
				{
					nint num67 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ S0_v227 (Il2CppClass<UICamera>)+BA]");
					object obj40 = (nint)0 & (nint)0x200;
					if (obj40 != null)
					{
						nint num68 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ S0_v234 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch29 = UICamera.currentTouch;
					UICamera.onClick.EndInvoke((IAsyncResult)(object)currentTouch29.pressed);
				}
				nint num69 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ S0_v151 (Il2CppClass<UICamera>)+BA]");
				object obj41 = (nint)0 & (nint)0x200;
				if (obj41 != null)
				{
					nint num70 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ S0_v221 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch30 = UICamera.currentTouch;
				((UICamera)(object)currentTouch30.pressed).ProcessTouch((byte)(int)"OnClick" != 0, false);
				UICamera.MouseOrTouch currentTouch31 = UICamera.currentTouch;
				float num71 = currentTouch31.clickTime + 0.35f;
				if (num71 > unscaledDeltaTime)
				{
					nint num72 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ S0_v181 (Il2CppClass<UICamera>)+BA]");
					object obj42 = (nint)0 & (nint)0x200;
					if (obj42 != null)
					{
						nint num73 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ S0_v216 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (UICamera.onDoubleClick != null)
					{
						nint num74 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ S0_v204 (Il2CppClass<UICamera>)+BA]");
						object obj43 = (nint)0 & (nint)0x200;
						if (obj43 != null)
						{
							nint num75 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ S0_v211 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UICamera.MouseOrTouch currentTouch32 = UICamera.currentTouch;
						UICamera.onDoubleClick.EndInvoke((IAsyncResult)(object)currentTouch32.pressed);
					}
					nint num76 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ S0_v190 (Il2CppClass<UICamera>)+BA]");
					object obj44 = (nint)0 & (nint)0x200;
					if (obj44 != null)
					{
						nint num77 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ S0_v198 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch33 = UICamera.currentTouch;
					((UICamera)(object)currentTouch33.pressed).ProcessTouch((byte)(int)"OnDoubleClick" != 0, false);
				}
				nint num78 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ S0_v168 (Il2CppClass<UICamera>)+BA]");
				object obj45 = (nint)0 & (nint)0x200;
				if (obj45 != null)
				{
					nint num79 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ S0_v175 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch34 = UICamera.currentTouch;
				currentTouch34.clickTime = unscaledDeltaTime;
			}
		}
		goto IL_1631;
	}

	public void OnPurchaseSuccessful()
	{
		//IL_0024: Expected VT, but got I4
		if (~(isVideoPlaying__BackingField ? 1u : 0u) == 0)
		{
			RefreshIfNotNewlyCreated((MissionInfo)1);
			StayInOneLaneMission instance = StayInOneLaneMission.instance;
			MissionCellPayload payload = _payload;
			((MissionsManager)(object)instance).OverWriteAchievementsProgress((MissionTarget)payload.missionIndex, 1);
			OnPurchaseFailure();
			isVideoPlaying__BackingField = false;
		}
	}

	public void AnimateSkip()
	{
		//IL_000b: Expected VT, but got I4
		RefreshIfNotNewlyCreated((MissionInfo)0);
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		MissionCellPayload payload = _payload;
		((MissionsManager)(object)instance).OverWriteAchievementsProgress((MissionTarget)payload.missionIndex, 0);
		OnPurchaseFailure();
	}

	private void TrackSuccessfulSkipFlurry(bool skippedWithVideo = false)
	{
		if (~(isVideoPlaying__BackingField ? 1u : 0u) == 0)
		{
			OnPurchaseSuccessful();
		}
	}

	public void OnPurchaseFailure()
	{
		//IL_0105: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		int currentMissionSet = ((MissionsManager)(object)instance).currentMissionSet;
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v47 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__62_0 == null;
		bool flag2 = !flag;
		Func<MissionInfo, bool> predicate = _003C_003Ec._003C_003E9__62_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v21 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v41 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<MissionInfo, bool> func = default;
			object obj3 = func + 16;
			obj3 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v38 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionCell+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = func;
			predicate = func;
		}
		int finalProgress = Enumerable.Count((IEnumerable<MissionInfo>)currentMissionSet, predicate);
		IEnumerator routine = AnimateProgressBarCoroutine(finalProgress);
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	public void RefreshIfNotNewlyCreated(MissionInfo info)
	{
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected Obj, but got Unknown
		//IL_050e: Expected Obj, but got I4
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_0536: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_054d: Expected Obj, but got I4
		//IL_0563: Expected Obj, but got I
		//IL_0573: Expected Obj, but got I
		//IL_0583: Expected Obj, but got I
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected Obj, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected Obj, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		object obj3 = obj2 + 12;
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		obj3 = currentSkipForVideoMissionIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		object obj4 = obj2 + 4;
		MissionCellPayload payload = _payload;
		obj4 = payload.missionIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text3 = default;
		string text = text2 + "-" + text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S3_v4+60]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v69 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S3_v8 (Il2CppMethodInfo)+C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S3_v9+60]");
		object obj11 = 0;
		object obj12 = obj11;
		object obj13 = obj12 & 0x1FFF;
		object obj14 = obj13 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88 @ S4_v8 (should have been resolved before IL gen)");
		MissionCellPayload payload2 = _payload;
		bool flag = payload2.cellHeight > 109;
		bool flag2 = payload2.cellHeight > 80;
		object obj15 = obj2 + 16;
		object obj16 = _payload - -64;
		bool flag3 = (((nint)obj16 != 1) ? flag2 : flag);
		obj15 = flag3;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S4_v10 (Il2CppMethodInfo)+C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S4_v11+60]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S4_v12+48]");
		object obj19 = 0;
		object obj20 = obj19 & 0x7FF;
		object obj21 = obj20 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v134 @ S5_v8 (should have been resolved before IL gen)");
		object obj22 = _payload - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public void Refresh()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		hasSkippedMission__BackingField = false;
		object obj = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public void Refresh(MissionInfo info)
	{
		//IL_0031: Expected Obj, but got VT
		if (~(_isNewlyCreated ? 1u : 0u) != 0)
		{
			object obj = info.mission;
			_ = info.template;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [info @ L1 (MissionInfo)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [info @ L1 (MissionInfo)+18]");
			_ = 0;
			_ = info.progress;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8284");
			RefreshState();
		}
		_isNewlyCreated = false;
	}

	private void RefreshState()
	{
		hasSkippedMission__BackingField = false;
		ShowSkipButton();
		UpdateProgress();
		OnBuyClicked();
		this._002Ector();
		LogAttemptToShowButtonFlow();
	}

	private unsafe void ShowSkipButton()
	{
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected I4, but got Unknown
		//IL_027c: Expected Obj, but got I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02c9: Expected I, but got Obj
		//IL_02df: Expected Obj, but got I
		//IL_03d0: Expected Obj, but got I4
		//IL_03dd: Expected I4, but got Obj
		//IL_035e: Expected Obj, but got I4
		//IL_0378: Expected I4, but got Obj
		//IL_00a8: Expected I, but got Obj
		//IL_032a: Expected Obj, but got I4
		//IL_0337: Expected I4, but got Obj
		//IL_0037: Expected I, but got Obj
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I4
		//IL_0480: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 16);
		obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = _payload + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v8+24]");
		bool flag = (nint)0 != 0;
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v12 (Il2CppClass<UI.ColorData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag2 = obj3 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14+8]");
		if ((nint)0 != 0)
		{
			if (!flag2)
			{
				nint num2 = (nint)typeof(ColorData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v81 (Il2CppClass<UI.ColorData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj4 = (flag3 ? 1 : 0) + 204;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
			object obj5 = obj4;
		}
		else
		{
			if (!flag2)
			{
				nint num3 = (nint)typeof(ColorData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v73 (Il2CppClass<UI.ColorData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag4 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj6 = (flag4 ? 1 : 0) + 364;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
			object obj5 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ L3_v2+8]");
		_ = 0;
		obj = ((UIWidget.Pivot*)(int)pivot)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UIWidget+Pivot)+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_backgroundSprite.rawPivot = pivot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14+8]");
		string text;
		if ((nint)0 != 0)
		{
			bool flag5 = CanShowBottomPanel();
			text = (string)((flag5 ? 1 : 0) ^ 1);
		}
		else
		{
			text = null;
		}
		_progressComplete.tag = text;
		string text2 = _missionProgress.tag;
		object obj7 = _payload + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v31+24]");
		string text3;
		if ((nint)0 != 0)
		{
			bool flag6 = CanShowBottomPanel();
			text3 = (string)flag6;
		}
		else
		{
			text3 = (string)1;
		}
		((GameObject)(object)text2).tag = text3;
		string text4 = _completedLabel.tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14+8]");
		bool flag7 = (nint)0 != 0;
		((GameObject)(object)text4).tag = (string)flag7;
		string text5 = _checkmarkSprite.tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14+8]");
		bool flag8 = (nint)0 != 0;
		((GameObject)(object)text5).tag = (string)flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		object obj9 = default;
		object obj8 = obj9 + 16;
		object obj10 = default;
		obj8 = obj10;
		throw new NullReferenceException();
	}

	private void LogAttemptToShowButtonFlow()
	{
		//IL_003c: Expected I4, but got Obj
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		if (~(hasSkippedMission__BackingField ? 1u : 0u) != 0)
		{
			StayInOneLaneMission instance = StayInOneLaneMission.instance;
			bool flag = ((MissionsManager)(object)instance).IsMissionTargetActive((MissionTarget)_payload);
			object obj = this - -64;
			string text = ((Component)obj).tag;
			if (flag)
			{
				((GameObject)(object)text).tag = null;
				string text2 = _skipWithVideoButton.tag;
				((GameObject)(object)text2).tag = (string)1;
			}
			else
			{
				((GameObject)(object)text).tag = (string)1;
				string text3 = _skipWithVideoButton.tag;
				((GameObject)(object)text3).tag = null;
			}
			((MissionCell)null).ResetAnimations();
		}
	}

	private void ResetAnimations()
	{
		//IL_00be: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		object obj = instance._currentProgress + -1;
		if ((nint)obj >= 2)
		{
			return;
		}
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v12 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v23 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17 (System.Boolean)+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
		bool flag = (nint)0 != 0;
		int numberOfOwnedBoards = ((OwnBoardsAward)flag).GetNumberOfOwnedBoards();
		((WaterFallReach)numberOfOwnedBoards)._002Ector();
		AdTrackingSystemLogger.LogVideoAdButtonClick((AdLocationInfo)numberOfOwnedBoards);
	}

	private IEnumerator AnimateBackgroundProgress(int finalProgress)
	{
		//IL_005b: Expected Obj, but got I4
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		GameObject parent = ((Component)finalProgress).gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v9 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TimerHelper timerHelper = UnityEngine.Object.Instantiate((TimerHelper)(object)_skipCost, (Transform)(object)parent);
		return (IEnumerator)(object)timerHelper.tag;
	}

	private IEnumerator CompleteAnimationInternal(int completedMissionsCount)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		return enumerator;
	}

	private IEnumerator AnimateProgressBarCoroutine(int finalProgress)
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

	private IEnumerator AnimateBottomPanelCoroutine()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(MissionsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Missions.MissionsData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Missions.MissionsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = MissionsData.skipData + 16;
		MissionCellPayload payload = _payload;
		int num3 = payload.missionIndex << 2;
		object obj3 = obj2 + num3;
		return (IEnumerator)((MissionsManager)obj3).videoButtonState;
	}

	public MissionCell()
	{
		//IL_013d: Expected I, but got Obj
		//IL_0153: Expected Obj, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I4
		OnBuyClicked();
		GameObject gameObject = _checkmarkSprite.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v32 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 24;
		Vector3 forward = Vector3.forward;
		Transform transform = (Transform)(obj3 + 36);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject).parent = transform;
		string text = _completedLabel.tag;
		int layer = ((GameObject)(object)text).layer;
		object obj4 = obj3 + 12;
		Vector3 forward2 = Vector3.forward;
		transform = (Transform)obj4;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v19+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		((Transform)layer).parent = transform;
		GameObject gameObject2 = _missionProgress.gameObject;
		Vector3 forward3 = Vector3.forward;
		transform = (Transform)obj3;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject2).parent = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		string text2 = _progressFlashSprite.tag;
		((GameObject)(object)text2).tag = null;
	}
}
