using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Extensions;
using Kiloo.Common.Utility;
using Missions;
using UI.Breadcrumbs;
using UI.DoubleCoinsVideo;
using UI.Footer;
using UI.Generic;
using UI.Generic.Layout;
using UI.Pages.MissionsPageInternal;
using UI.Popups.CloudSaveConfirmationPopupInternal;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI.Pages;

public class MissionsPage : Page
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<MissionInfo, bool> _003C_003E9__22_0;

		public static Func<MissionCell, bool> _003C_003E9__24_0;

		public static Action<MissionCell> _003C_003E9__32_0;

		public static Action<MissionCell> _003C_003E9__33_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CloudSaveConfirmationPopupPayload._003C_003Ec obj = default;
			CloudSaveConfirmationPopupPayload._003C_003Ec._003C_003E9 = obj;
		}

		public unsafe _003C_003Ec()
		{
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Expected Obj, but got Unknown
			//IL_0276: Expected Obj, but got I4
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Expected Obj, but got Unknown
			//IL_02aa: Expected Obj, but got I
			//IL_02c7: Expected Obj, but got I
			//IL_02d5: Expected I, but got Obj
			//IL_02eb: Expected Obj, but got I
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Expected I4, but got Unknown
			//IL_0323: Expected I4, but got Obj
			//IL_0371: Expected Obj, but got I
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_037f: Expected Obj, but got Unknown
			//IL_0395: Expected Obj, but got I
			//IL_03af: Expected VT, but got I4
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected Obj, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_0098: Expected I, but got Obj
			//IL_00ae: Expected Obj, but got I
			//IL_00d1: Expected I, but got Obj
			//IL_00e7: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Expected VT, but got Unknown
			//IL_03cf: Expected F4, but got Obj
			//IL_03ca: Expected native int or pointer, but got VT
			//IL_03e4: Expected F4, but got I
			//IL_03df: Expected native int or pointer, but got VT
			//IL_03f1: Expected I4, but got Obj
			//IL_0407: Unknown result type (might be due to invalid IL or missing references)
			//IL_040c: Expected Obj, but got Unknown
			//IL_0419: Expected VT, but got I4
			//IL_042a: Expected I4, but got Obj
			//IL_044d: Expected Obj, but got I
			//IL_045a: Expected Obj, but got I4
			//IL_0470: Unknown result type (might be due to invalid IL or missing references)
			//IL_0475: Expected Obj, but got Unknown
			//IL_048b: Expected Obj, but got I
			//IL_04a5: Expected VT, but got I4
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Expected Obj, but got Unknown
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected Obj, but got Unknown
			//IL_0197: Expected I, but got Obj
			//IL_01ad: Expected Obj, but got I
			//IL_01cf: Expected F4, but got Obj
			//IL_01ca: Expected native int or pointer, but got VT
			//IL_01e4: Expected F4, but got I
			//IL_01df: Expected native int or pointer, but got VT
			//IL_01f1: Expected I4, but got Obj
			//IL_020b: Expected VT, but got I4
			//IL_0112: Expected I, but got Obj
			//IL_0221: Expected I4, but got Obj
			//IL_0244: Expected Obj, but got I
			//IL_0251: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 152;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @826D");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage+<>c)+30]");
			object obj4 = -(-64);
			int layer = ((GameObject)obj4).layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage+<>c)+30]");
			object obj5 = 0;
			nint num = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v22 (Il2CppClass<PrizePositionData>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v42 (Il2CppClass<PrizePositionData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CelebrationRewardOrigin celebrationRewardOrigin = (CelebrationRewardOrigin)(obj2 + 184);
			((CelebrationRewardOrigin*)(int)celebrationRewardOrigin)->value__ = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+24]");
			RewardManager.AddRewardToUnlock(celebrationRewardOrigin, (ObtainableItemSource)layer, (string)0);
			Transform transform = (Transform)(obj2 + 96);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage+<>c)+30]");
			object obj7 = -(-64);
			int layer2 = ((GameObject)obj7).layer;
			transform.rotation = (Quaternion)layer2;
			obj = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj8 = obj2 + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
			object obj9 = obj2 + 68;
			nint num3 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v16 (Il2CppClass<PrizePositionData>)+5C]");
			object obj10 = (nint)0 + (nint)508;
			obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S2_v18+8]");
			_ = 0;
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v33 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num5 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v72 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = (Vector3)(obj2 + 168);
			((Vector3*)(nint)vector)->x = (float)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v28+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((CelebrationRewardOrigin*)(int)celebrationRewardOrigin)->value__ = (int)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v30+8]");
			_ = 0;
			object obj12 = obj2 + 56;
			Vector3 vector2 = vector - (Vector3)celebrationRewardOrigin;
			((CelebrationRewardOrigin*)(int)celebrationRewardOrigin)->value__ = (int)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v43+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage+<>c)+30]");
			object obj13 = (nint)0 + (nint)68;
			obj13 = ((CelebrationRewardOrigin*)(int)celebrationRewardOrigin)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v27 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+8]");
			_ = 0;
			Transform transform2 = (Transform)(obj2 + 40);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage+<>c)+30]");
			object obj14 = -(-64);
			int layer3 = ((GameObject)obj14).layer;
			transform2.rotation = (Quaternion)layer3;
			obj = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			object obj15 = obj2 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
			object obj16 = obj2 + 12;
			nint num6 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S2_v52 (Il2CppClass<PrizePositionData>)+5C]");
			object obj17 = (nint)0 + (nint)520;
			obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S2_v54+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v56+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((CelebrationRewardOrigin*)(int)celebrationRewardOrigin)->value__ = (int)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v58+8]");
			_ = 0;
			Vector3 vector3 = vector - (Vector3)celebrationRewardOrigin;
			((CelebrationRewardOrigin*)(int)celebrationRewardOrigin)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage+<>c)+30]");
			object obj18 = (nint)0 + (nint)80;
			obj18 = ((CelebrationRewardOrigin*)(int)celebrationRewardOrigin)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v27 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+8]");
			_ = 0;
		}

		internal bool _003CShow_003Eb__22_0(MissionInfo m)
		{
			//IL_0030: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
			bool result = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
			object obj = (nint)0 + (nint)(-1);
			if ((nint)obj >= 3)
			{
				result = false;
			}
			return result;
		}

		internal bool _003CDisplayCelebrationPopupIfNeeded_003Eb__24_0(MissionCell x)
		{
			_ = ((UnityEngine.Object)x).m_CachedPtr;
			_ = x._headerSprite;
			_ = x._missionSkipText;
			_ = x._videoLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+24]");
			return (nint)0 != 0;
		}

		internal void _003CResetCellPositions_003Eb__32_0(MissionCell c)
		{
		}

		internal void _003CDestroyOtherMissionCells_003Eb__33_0(MissionCell cell)
		{
			Transform component = cell.GetComponent<Transform>();
			TransformExtensions.SetLocalPosY(component, 0f);
		}
	}

	private sealed class _003CDelayedQueueCelebrationPopup_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0048: Expected Obj, but got I4
				//IL_005c: Expected Obj, but got I4
				//IL_007a: Expected I, but got Obj
				//IL_0090: Expected Obj, but got I
				//IL_013a: Expected Obj, but got I4
				//IL_00bb: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v22 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UIScreenController.ShouldShowOnlineScreen();
						((UIScreenController)flag).ClosePopup();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj2 = this + 12;
				obj2 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CDelayedQueueCelebrationPopup_003Ed__25(int _003C_003E1__state)
		{
			//IL_00fc: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_0146: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_005b: Expected Obj, but got I4
			//IL_006d: Expected I, but got Obj
			//IL_0083: Expected Obj, but got I
			//IL_00ae: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_003C_003E1__state))
			{
				return;
			}
			string tag = ((Component)_003C_003E1__state).tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag);
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

	private sealed class _003CMissionCompleteAnimation_003Ed__29(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public int completedMissionsCount;

		public MissionsPage _003C_003E4__this;

		private int _003CcurrentMissionsSet_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e7: Expected Obj, but got Unknown
				//IL_0503: Expected Obj, but got I4
				//IL_0141: Unknown result type (might be due to invalid IL or missing references)
				//IL_0146: Expected Obj, but got Unknown
				//IL_0162: Expected Obj, but got I4
				//IL_019b: Expected Obj, but got I4
				//IL_044d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0452: Expected Obj, but got Unknown
				//IL_046e: Expected Obj, but got I4
				//IL_0224: Unknown result type (might be due to invalid IL or missing references)
				//IL_0229: Expected Obj, but got Unknown
				//IL_0245: Expected Obj, but got I4
				//IL_02fb: Expected Obj, but got I4
				//IL_0367: Expected I, but got Obj
				//IL_037d: Expected Obj, but got I
				//IL_051f: Expected Obj, but got I4
				//IL_03a8: Expected I, but got Obj
				MissionsPage missionsPage = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state != 3)
							{
								if (_003C_003E1__state == 4)
								{
									_003C_003E1__state = -1;
									missionsPage.CreateNewMissionCells();
									missionsPage.TopAlign(null);
									missionsPage._missionSetProgress.BounceNextProgressDot();
									StayInOneLaneMission instance = StayInOneLaneMission.instance;
									int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
									StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
									int missionSetCount = ((MissionsManager)(object)instance2).missionSetCount;
									if (currentSkipForVideoMissionIndex >= missionSetCount)
									{
										missionsPage._missionSetProgress.TestBounce((UISprite)1);
									}
									missionsPage._missionCompleteAnimationInProgress = false;
									int missionsVersion = PlayerSave.missionsVersion;
									StayInOneLaneMission instance3 = StayInOneLaneMission.instance;
									int missionSetCount2 = ((MissionsManager)(object)instance3).missionSetCount;
									if (missionsVersion > missionSetCount2)
									{
										nint num = (nint)typeof(UIScreenController);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v99 (Il2CppClass<UIScreenController>)+BA]");
										object obj = (nint)0 & (nint)0x200;
										if (obj != null)
										{
											nint num2 = (nint)typeof(UIScreenController);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v105 (Il2CppClass<UIScreenController>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										bool flag = UIScreenController.ShouldShowOnlineScreen();
										((UIScreenController)flag).ClosePopup();
									}
									return null;
								}
								return null;
							}
							_003C_003E1__state = -1;
						}
						else
						{
							_003C_003E1__state = -1;
							StayInOneLaneMission instance4 = StayInOneLaneMission.instance;
							int missionSetCount3 = ((MissionsManager)(object)instance4).missionSetCount;
							object obj2 = missionSetCount3 + 1;
							if (_003CcurrentMissionsSet_003E5__2 < (nint)obj2)
							{
								missionsPage._top.ResetAnimations();
								PageTop top = missionsPage._top;
								float num3 = top._iconScaleEffectDelay + top._iconScaleEffectDuration;
								float num4 = num3 + top._blinkEffectDuration;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								_ = -1f;
								object obj3 = this + 12;
								object obj4 = default;
								obj3 = obj4;
								_003C_003E1__state = 3;
								return 1;
							}
						}
						missionsPage._002Ector();
						float num5 = missionsPage._cellAnimationDelay * 2f;
						float num6 = num5 + missionsPage._cellAnimationDuration;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = -1f;
						object obj5 = this + 12;
						object obj6 = default;
						obj5 = obj6;
						_003C_003E1__state = 4;
						return 1;
					}
					_003C_003E1__state = -1;
					missionsPage._missionSetProgress.TestBounce1();
					MissionSetProgress missionSetProgress = missionsPage._missionSetProgress;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = -1f;
					_ = missionSetProgress._bounceEffectDuration;
					object obj7 = this + 12;
					object obj8 = default;
					obj7 = obj8;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				if (completedMissionsCount != 0)
				{
					missionsPage._missionSetProgress.ChangeToMysteryBoxReward();
					return null;
				}
				missionsPage._missionCompleteAnimationInProgress = true;
				StayInOneLaneMission instance5 = StayInOneLaneMission.instance;
				int currentSkipForVideoMissionIndex2 = PlayerSave.currentSkipForVideoMissionIndex;
				_003CcurrentMissionsSet_003E5__2 = currentSkipForVideoMissionIndex2;
				missionsPage._missionSetProgress.ChangeToMysteryBoxReward();
				MissionSetProgress missionSetProgress2 = missionsPage._missionSetProgress;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = -1f;
				_ = missionSetProgress2._bounceEffectDuration;
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

	private sealed class _003CAnimateCell_003Ed__36(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public MissionsPage _003C_003E4__this;

		public Transform cellTransform;

		public float startX;

		public float endX;

		public Action onComplete;

		private float _003CcurrentDuration_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0204: Expected I, but got Obj
				//IL_021a: Expected Obj, but got I
				//IL_027f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0284: Expected Obj, but got Unknown
				//IL_028d: Expected Obj, but got I4
				//IL_02a1: Expected Obj, but got I4
				//IL_0189: Expected I, but got Obj
				MissionsPage missionsPage = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					_003CcurrentDuration_003E5__2 = 0f;
				}
				if (!(_003CcurrentDuration_003E5__2 < missionsPage._cellAnimationDuration))
				{
					TransformExtensions.SetLocalPosY(cellTransform, endX);
					TransformExtensions.Reset((Transform)(object)onComplete);
					return null;
				}
				float fixedDeltaTime = Time.fixedDeltaTime;
				float num = _003CcurrentDuration_003E5__2 + fixedDeltaTime;
				_003CcurrentDuration_003E5__2 = num;
				float num2 = _003CcurrentDuration_003E5__2 / missionsPage._cellAnimationDuration;
				float num3 = Easings.BounceEaseInOut(num2);
				bool flag = num2 > 372f / 1023f;
				bool flag2 = !flag;
				float num4 = num3;
				if (!flag2)
				{
					float num5 = num3 - 1f;
					float num6 = num5 * 0.125f;
					float num7 = num6 + 1f;
					num4 = num7;
				}
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v19 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num9 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v28 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num10 = endX - startX;
				float num11 = num10 * num4;
				float posY = startX + num11;
				TransformExtensions.SetLocalPosY(cellTransform, posY);
				object obj2 = this + 12;
				obj2 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0029: Expected Obj, but got F4
			//IL_005b: Expected F4, but got Obj
			//IL_005b: Expected Obj, but got I4
			//IL_0014: Expected Obj, but got I4
			MissionCell missionCell = ((List<MissionCell>)startX).get_Item(2);
			GameObject gameObject = missionCell.gameObject;
			IEnumerator routine = ((FrontScreen)_003C_003E1__state).AnimateButtonVertical(gameObject, (float)cellTransform, endX, onComplete);
			Coroutine coroutine = ((MonoBehaviour)_003C_003E1__state).StartCoroutine_Auto(routine);
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

	public const int PAGE_INDEX = 1;

	private PageTop _topPrefab;

	private PageTop _top;

	private GameObject _missionCellPrefab;

	private Layout[] _missionCellLayouts;

	private float _cellAnimationDuration;

	private float _cellAnimationDelay;

	private int _currentSet;

	private MissionSetProgress _missionSetProgressPrefab;

	private MissionSetProgress _missionSetProgress;

	private int _cellHeight;

	private MissionInfo[][] _missionInfos;

	private List<MissionCell>[] _missionCells;

	private const int MAX_MULTIPLIER = 30;

	private const int MISSION_COUNT_IN_SET = 3;

	private int _currentMissionSetCompletedSum;

	private bool _missionCompleteAnimationInProgress;

	private PageTop.EventsPageTopPayload _topPayload;

	private unsafe int GetCurrentSetIndex()
	{
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0434: Expected Obj, but got I4
		//IL_0454: Expected I, but got Obj
		//IL_046a: Expected Obj, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected VT, but got Unknown
		//IL_00ae: Expected I4, but got Obj
		//IL_00a9: Expected native int or pointer, but got VT
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected VT, but got Unknown
		//IL_00f2: Expected VT, but got I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0115: Expected I4, but got Obj
		//IL_0110: Expected native int or pointer, but got VT
		//IL_011d: Expected native int or pointer, but got VT
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0138: Expected Obj, but got VT
		//IL_0145: Expected I4, but got Obj
		//IL_0140: Expected native int or pointer, but got VT
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I4
		//IL_018d: Expected I4, but got Obj
		//IL_0188: Expected native int or pointer, but got VT
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected VT, but got Unknown
		//IL_01d1: Expected VT, but got I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01f4: Expected I4, but got Obj
		//IL_01ef: Expected native int or pointer, but got VT
		//IL_01fc: Expected native int or pointer, but got VT
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got VT
		//IL_0224: Expected I4, but got Obj
		//IL_021f: Expected native int or pointer, but got VT
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_024a: Expected Obj, but got I4
		//IL_026c: Expected I4, but got Obj
		//IL_0267: Expected native int or pointer, but got VT
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_02a2: Expected VT, but got I4
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02c5: Expected I4, but got Obj
		//IL_02c0: Expected native int or pointer, but got VT
		//IL_02cd: Expected native int or pointer, but got VT
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02e8: Expected Obj, but got VT
		//IL_02f5: Expected I4, but got Obj
		//IL_02f0: Expected native int or pointer, but got VT
		//IL_0302: Expected Obj, but got I4
		//IL_030f: Expected I4, but got Obj
		//IL_030a: Expected native int or pointer, but got VT
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_0351: Expected Obj, but got I4
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_039d: Expected I, but got Obj
		//IL_03b3: Expected Obj, but got I
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04d0: Expected I4, but got Obj
		//IL_03de: Expected I, but got Obj
		Color32? color = default;
		object obj = (Nullable)color + 120;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UI.ColorData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v108 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DoubleCoinsVideoBanner._003CActivateStars_003Ed__14 obj3 = default;
		((IDisposable)obj3).Dispose();
		_ = 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj4 = (Nullable)color + 104;
		object obj5 = (flag ? 1 : 0) + 940;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v14+8]");
		_ = 0;
		Color32 color2 = (Color32)((Nullable)color + 160);
		((Color32*)(nint)color2)->rgba = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26+8]");
		_ = 0;
		object obj6 = (Nullable)color + 96;
		Color color3 = color2;
		Color32? color4 = (Color32?)(object)((Nullable)color + 24);
		color4 = (Color32?)(object)0;
		object obj7 = (Nullable)color + 156;
		obj7 = obj6;
		((Color32*)(nint)color2)->rgba = (int)obj7;
		*(Color32?*)(nint)color4 = color2;
		object obj8 = (Nullable)color + 40;
		obj8 = color4;
		((Color32*)(nint)color2)->rgba = (int)obj8;
		_ = color2.rgba;
		object obj9 = (Nullable)color + 80;
		object obj10 = (flag ? 1 : 0) + 972;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v42+8]");
		_ = 0;
		((Color32*)(nint)color2)->rgba = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v46+8]");
		_ = 0;
		object obj11 = (Nullable)color + 72;
		Color color5 = color2;
		Color32? color6 = (Color32?)(object)((Nullable)color + 8);
		color6 = (Color32?)(object)0;
		object obj12 = (Nullable)color + 152;
		obj12 = obj11;
		((Color32*)(nint)color2)->rgba = (int)obj12;
		*(Color32?*)(nint)color6 = color2;
		object obj13 = (Nullable)color + 32;
		obj13 = color6;
		((Color32*)(nint)color2)->rgba = (int)obj13;
		_ = color2.rgba;
		object obj14 = (Nullable)color + 56;
		object obj15 = (flag ? 1 : 0) + 956;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v69+8]");
		_ = 0;
		((Color32*)(nint)color2)->rgba = (int)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v65+8]");
		_ = 0;
		object obj16 = (Nullable)color + 48;
		Color color7 = color2;
		color = (Color32?)(object)0;
		object obj17 = (Nullable)color + 76;
		obj17 = obj16;
		((Color32*)(nint)color2)->rgba = (int)obj17;
		*(Color32?*)(nint)color = color2;
		object obj18 = (Nullable)color + 16;
		obj18 = color;
		((Color32*)(nint)color2)->rgba = (int)obj18;
		obj = color2.rgba;
		((Color32*)(nint)color2)->rgba = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		object obj19 = obj3 + 16;
		obj19 = color2.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29 (UnityEngine.Color32)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29 (UnityEngine.Color32)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29 (UnityEngine.Color32)+18]");
		_ = 0;
		object obj20 = obj3 + 12;
		obj20 = "icon_daily_challenge";
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v94 (Il2CppClass<Strings>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v104 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj22 = obj3 + 52;
		string text = Strings.GetDefault("DAILY_CHALLENGE_WORD_HUNT");
		obj22 = text;
		object obj23 = obj3 + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj24 = default;
		obj23 = obj24;
		return (int)obj3;
	}

	private int GetOtherSetIndex()
	{
		//IL_001e: Expected Obj, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
		int num = _currentSet / 2;
		object obj = num * 2;
		return _currentSet - obj;
	}

	public override FooterButton.FooterPayload GetButtonPayload()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		object obj = _currentSet + 1;
		object obj2 = obj / 2;
		object obj3 = obj2 * 2;
		return (FooterButton.FooterPayload)(obj - obj3);
	}

	public unsafe override void Init(UIWidget pageGuideWidget)
	{
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_043d: Expected Obj, but got I4
		//IL_0451: Expected I, but got Obj
		//IL_0467: Expected Obj, but got I
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected VT, but got Unknown
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected VT, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected Ref, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_0710: Invalid comparison between I and F4
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_073f: Expected F4, but got Obj
		//IL_073a: Expected native int or pointer, but got VT
		//IL_0754: Expected F4, but got I
		//IL_074f: Expected native int or pointer, but got VT
		//IL_0762: Expected I, but got Obj
		//IL_0778: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0138: Expected I, but got Obj
		//IL_014e: Expected Obj, but got I
		//IL_060c: Expected native int or pointer, but got VT
		//IL_061e: Expected native int or pointer, but got VT
		//IL_0630: Expected Ref, but got VT
		//IL_0642: Expected F4, but got VT
		//IL_063d: Expected native int or pointer, but got VT
		//IL_0657: Expected F4, but got I
		//IL_0652: Expected native int or pointer, but got VT
		//IL_0660: Expected Obj, but got VT
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_0206: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I
		//IL_0521: Expected F4, but got VT
		//IL_051c: Expected native int or pointer, but got VT
		//IL_0536: Expected F4, but got I
		//IL_0531: Expected native int or pointer, but got VT
		//IL_0543: Expected F4, but got Obj
		//IL_053e: Expected native int or pointer, but got VT
		//IL_0558: Expected F4, but got I
		//IL_0553: Expected native int or pointer, but got VT
		//IL_02fd: Expected I, but got Obj
		//IL_0313: Expected Obj, but got I
		//IL_0294: Expected I, but got Obj
		//IL_0599: Expected F4, but got VT
		//IL_0594: Expected native int or pointer, but got VT
		//IL_05ae: Expected F4, but got I
		//IL_05a9: Expected native int or pointer, but got VT
		//IL_05bb: Expected F4, but got Obj
		//IL_05b6: Expected native int or pointer, but got VT
		//IL_05d0: Expected F4, but got I
		//IL_05cb: Expected native int or pointer, but got VT
		//IL_0179: Expected I, but got Obj
		//IL_0683: Invalid comparison between I and F4
		//IL_0247: Expected I, but got Obj
		//IL_033e: Expected I, but got Obj
		//IL_0393: Expected Obj, but got I
		//IL_03a6: Expected I, but got Obj
		//IL_03bc: Expected Obj, but got I
		//IL_03e7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 40;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<PrizePositionData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v129 (Il2CppClass<PrizePositionData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 - -64);
		Vector3 vector2 = (Vector3)(obj2 + 52);
		ref Quaternion reference = ref *(Quaternion*)(obj2 + 24);
		object obj4 = obj2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage)+5C]");
		if (0f > PrizePositionData.rewardRotationDuration)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		nint num3 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v25 (Il2CppClass<PrizePositionData>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v123 (Il2CppClass<PrizePositionData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage)+5C]");
		float p = 0f / PrizePositionData.rewardRotationDuration;
		float t = Easings.CircularEaseIn(p);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage)+60]");
		if ((nint)0 >= (nint)1)
		{
			object obj6 = this + 68;
			reference = ref *(Quaternion*)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v100+8]");
			_ = 0;
			object obj7 = this + 80;
			obj4 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v105+8]");
			_ = 0;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v90 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v101 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)reference;
			Vector3 vector3 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16 (UnityEngine.Quaternion&)+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v18+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector4 = Vector3.LerpUnclamped(vector2, vector, t);
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage)+60]");
		if ((nint)0 <= (nint)(-1))
		{
			object obj9 = this + 80;
			reference = ref *(Quaternion*)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v76+8]");
			_ = 0;
			object obj10 = this + 68;
			obj4 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v81+8]");
			_ = 0;
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v70 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v81 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)reference;
			Vector3 vector5 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16 (UnityEngine.Quaternion&)+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v18+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector6 = Vector3.LerpUnclamped(vector2, vector, t);
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
		((Vector3*)(nint)vector2)->x = (float)obj;
		Vector3 vector7 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		nint num9 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v32 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num10 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v61 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = vector2.x;
		((Vector3*)(nint)vector)->z = vector2.z;
		Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)vector);
		((Vector3*)(nint)vector)->x = (float)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16 (UnityEngine.Quaternion&)+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion localRotation = ((Transform)vector).localRotation;
		float fixedDeltaTime = Time.fixedDeltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage)+5C]");
		float num11 = 0f + fixedDeltaTime;
		nint num12 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S1_v56 (Il2CppClass<PrizePositionData>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num13 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S1_v69 (Il2CppClass<PrizePositionData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage)+5C]");
		if (0f < PrizePositionData.rewardRotationDuration)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage)+60]");
		object obj14 = (nint)0 * (nint)(-1);
		nint num14 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v50 (Il2CppClass<PrizePositionData>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num15 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v55 (Il2CppClass<PrizePositionData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPage)+5C]");
		float num16 = 0f - PrizePositionData.rewardRotationDuration;
	}

	public override void Show()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 56;
		object obj2 = default;
		obj = obj2;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public override void Hide()
	{
		//IL_0229: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_02ee: Expected Obj, but got I4
		//IL_00cf: Expected I, but got Obj
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_02a3: Expected I, but got Obj
		//IL_02b9: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I4
		//IL_015d: Expected I, but got Obj
		_missionCompleteAnimationInProgress = false;
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		CreateNewMissionCells();
		ResetCellPositions();
		DestroyOtherMissionCells();
		AnimateNewMissionSet();
		TopAlign(null);
		object obj = _missionInfos + 16;
		int num = _currentSet / 2;
		object obj2 = num * 2;
		object obj3 = _currentSet - obj2;
		object obj4 = obj3 << 2;
		object source = obj + obj4;
		nint num2 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S2_v9 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S2_v50 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__22_0 == null;
		bool flag2 = !flag;
		Func<MissionInfo, bool> predicate = _003C_003Ec._003C_003E9__22_0;
		if (!flag2)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v24 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num5 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S2_v44 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S2_v41 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+5C]");
			object obj8 = (nint)0 + (nint)4;
			obj8 = func;
			predicate = func;
		}
		int num8 = Enumerable.Count((IEnumerable<MissionInfo>)source, predicate);
		_missionSetProgress.BounceNextProgressDot((Action)num8);
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
		int missionSetCount = ((MissionsManager)(object)instance2).missionSetCount;
		if (currentSkipForVideoMissionIndex >= missionSetCount)
		{
			_missionSetProgress.TestBounce((UISprite)null);
		}
		((Breadcrumb)2)._002Ector();
	}

	private void DisplayCelebrationPopupIfNeeded()
	{
		string text = tag;
		((GameObject)(object)text).tag = null;
		RefreshMissionInfos();
		_missionCompleteAnimationInProgress = false;
	}

	private unsafe IEnumerator DelayedQueueCelebrationPopup()
	{
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0434: Expected Obj, but got I4
		//IL_0454: Expected I, but got Obj
		//IL_046a: Expected Obj, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected VT, but got Unknown
		//IL_00ae: Expected I4, but got Obj
		//IL_00a9: Expected native int or pointer, but got VT
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected VT, but got Unknown
		//IL_00f2: Expected VT, but got I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0115: Expected I4, but got Obj
		//IL_0110: Expected native int or pointer, but got VT
		//IL_011d: Expected native int or pointer, but got VT
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0138: Expected Obj, but got VT
		//IL_0145: Expected I4, but got Obj
		//IL_0140: Expected native int or pointer, but got VT
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I4
		//IL_018d: Expected I4, but got Obj
		//IL_0188: Expected native int or pointer, but got VT
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected VT, but got Unknown
		//IL_01d1: Expected VT, but got I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01f4: Expected I4, but got Obj
		//IL_01ef: Expected native int or pointer, but got VT
		//IL_01fc: Expected native int or pointer, but got VT
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got VT
		//IL_0224: Expected I4, but got Obj
		//IL_021f: Expected native int or pointer, but got VT
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_024a: Expected Obj, but got I4
		//IL_026c: Expected I4, but got Obj
		//IL_0267: Expected native int or pointer, but got VT
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_02a2: Expected VT, but got I4
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02c5: Expected I4, but got Obj
		//IL_02c0: Expected native int or pointer, but got VT
		//IL_02cd: Expected native int or pointer, but got VT
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02e8: Expected Obj, but got VT
		//IL_02f5: Expected I4, but got Obj
		//IL_02f0: Expected native int or pointer, but got VT
		//IL_0302: Expected Obj, but got I4
		//IL_030f: Expected I4, but got Obj
		//IL_030a: Expected native int or pointer, but got VT
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_0351: Expected Obj, but got I4
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_039d: Expected I, but got Obj
		//IL_03b3: Expected Obj, but got I
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_04cc: Expected Obj, but got I4
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected Obj, but got Unknown
		//IL_03de: Expected I, but got Obj
		Color32? color = default;
		object obj = (Nullable)color + 120;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UI.ColorData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v112 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DoubleCoinsVideoBanner._003CActivateStars_003Ed__14 obj3 = default;
		((IDisposable)obj3).Dispose();
		_ = 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj4 = (Nullable)color + 104;
		object obj5 = (flag ? 1 : 0) + 940;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v14+8]");
		_ = 0;
		Color32 color2 = (Color32)((Nullable)color + 160);
		((Color32*)(nint)color2)->rgba = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26+8]");
		_ = 0;
		object obj6 = (Nullable)color + 96;
		Color color3 = color2;
		Color32? color4 = (Color32?)(object)((Nullable)color + 24);
		color4 = (Color32?)(object)0;
		object obj7 = (Nullable)color + 156;
		obj7 = obj6;
		((Color32*)(nint)color2)->rgba = (int)obj7;
		*(Color32?*)(nint)color4 = color2;
		object obj8 = (Nullable)color + 40;
		obj8 = color4;
		((Color32*)(nint)color2)->rgba = (int)obj8;
		_ = color2.rgba;
		object obj9 = (Nullable)color + 80;
		object obj10 = (flag ? 1 : 0) + 972;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v42+8]");
		_ = 0;
		((Color32*)(nint)color2)->rgba = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v46+8]");
		_ = 0;
		object obj11 = (Nullable)color + 72;
		Color color5 = color2;
		Color32? color6 = (Color32?)(object)((Nullable)color + 8);
		color6 = (Color32?)(object)0;
		object obj12 = (Nullable)color + 152;
		obj12 = obj11;
		((Color32*)(nint)color2)->rgba = (int)obj12;
		*(Color32?*)(nint)color6 = color2;
		object obj13 = (Nullable)color + 32;
		obj13 = color6;
		((Color32*)(nint)color2)->rgba = (int)obj13;
		_ = color2.rgba;
		object obj14 = (Nullable)color + 56;
		object obj15 = (flag ? 1 : 0) + 956;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v69+8]");
		_ = 0;
		((Color32*)(nint)color2)->rgba = (int)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v65+8]");
		_ = 0;
		object obj16 = (Nullable)color + 48;
		Color color7 = color2;
		color = (Color32?)(object)0;
		object obj17 = (Nullable)color + 76;
		obj17 = obj16;
		((Color32*)(nint)color2)->rgba = (int)obj17;
		*(Color32?*)(nint)color = color2;
		object obj18 = (Nullable)color + 16;
		obj18 = color;
		((Color32*)(nint)color2)->rgba = (int)obj18;
		obj = color2.rgba;
		((Color32*)(nint)color2)->rgba = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		object obj19 = obj3 + 16;
		obj19 = color2.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29 (UnityEngine.Color32)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29 (UnityEngine.Color32)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29 (UnityEngine.Color32)+18]");
		_ = 0;
		object obj20 = obj3 + 12;
		obj20 = "icon_missions";
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v94 (Il2CppClass<Strings>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v108 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj22 = obj3 + 52;
		string text = Strings.GetDefault("MISSIONS_TITLE");
		obj22 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj24 = default;
		object obj23 = obj24 + 16;
		obj23 = 2;
		object obj25 = obj3 + 56;
		obj25 = obj24;
		return obj3;
	}

	private void RefreshMissionInfos()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00b6: Expected I, but got Obj
		//IL_00cc: Expected Obj, but got I
		//IL_00f7: Expected I, but got Obj
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0273: Expected I, but got Obj
		//IL_0289: Expected Obj, but got I
		//IL_0185: Expected I, but got Obj
		int missionsVersion = PlayerSave.missionsVersion;
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		int missionSetCount = ((MissionsManager)(object)instance).missionSetCount;
		if (missionsVersion <= missionSetCount)
		{
			return;
		}
		if (~(_missionCompleteAnimationInProgress ? 1u : 0u) != 0)
		{
			object obj = _missionCells + 16;
			int num = _currentSet / 2;
			object obj2 = num * 2;
			object obj3 = _currentSet - obj2;
			object obj4 = obj3 << 2;
			object source = obj + obj4;
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v15 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num3 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v52 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = _003C_003Ec._003C_003E9__24_0 == null;
			bool flag2 = !flag;
			Func<MissionCell, bool> predicate = _003C_003Ec._003C_003E9__24_0;
			if (!flag2)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v26 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num5 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v46 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num6 = 0;
				_ = 0;
				Func<MissionCell, bool> func = default;
				object obj7 = func + 16;
				obj7 = _003C_003Ec._003C_003E9;
				nint num7 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v43 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+5C]");
				object obj8 = (nint)0 + (nint)8;
				obj8 = func;
				predicate = func;
			}
			if (Enumerable.Count((IEnumerable<MissionCell>)source, predicate) != 0)
			{
				return;
			}
		}
		IEnumerator list = ((PageTop)null).FadeOutBlinkImage();
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private void CreateNewMissionCells()
	{
		//IL_001e: Expected Obj, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		int num = _currentSet / 2;
		object obj = num * 2;
		object obj2 = _currentSet - obj;
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		int currentMissionSet = ((MissionsManager)(object)instance).currentMissionSet;
		throw new ArrayTypeMismatchException();
	}

	private void OnMissionCellAnimationComplete(int completedMissionsCount)
	{
		//IL_04f5: Expected I, but got Obj
		//IL_050b: Expected Obj, but got I
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		//IL_056b: Expected I, but got Obj
		//IL_0581: Expected Obj, but got I
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected Obj, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected Obj, but got Unknown
		//IL_05fb: Expected I, but got Obj
		//IL_0611: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected Obj, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_013b: Expected I, but got Obj
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01d4: Expected Obj, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0242: Expected Obj, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02b0: Expected Obj, but got I4
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		//IL_0310: Expected Obj, but got I4
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_0379: Expected I, but got Obj
		//IL_038f: Expected Obj, but got I
		//IL_03ba: Expected I, but got Obj
		//IL_06cd: Expected Obj, but got I4
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected Obj, but got Unknown
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected Obj, but got Unknown
		//IL_043c: Expected Obj, but got I
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		//IL_0487: Expected Obj, but got VT
		//IL_0490: Expected Obj, but got I4
		//IL_049f: Expected Obj, but got I4
		//IL_04c6: Expected I4, but got Obj
		GameObject parent = topContainer.gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v127 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 20;
		PageTop pageTop = UnityEngine.Object.Instantiate(_topPrefab, (Transform)(object)parent);
		obj2 = pageTop;
		GameObject gameObject = _top.gameObject;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v10 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v125 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 68;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj5 + 80);
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v15+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		nint num5 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v24 (Il2CppClass<UI.ColorData>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v123 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PageTop.TopIconPayload topIconPayload = default;
		topIconPayload._002Ector();
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v34 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v119 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = topIconPayload + 8;
		string text = Strings.GetDefault("MISSIONS_TITLE");
		obj8 = text;
		string format = Strings.GetDefault("MISSION_SET");
		object obj9 = obj5 - -64;
		int missionsVersion = PlayerSave.missionsVersion;
		obj9 = missionsVersion;
		object obj10 = topIconPayload + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text2 = string.Format(format, args);
		obj10 = text2;
		object obj11 = obj5 + 48;
		object obj12 = (flag ? 1 : 0) + 140;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v36+8]");
		_ = 0;
		transform = (Transform)obj11;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v48+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		object obj13 = topIconPayload + 20;
		obj13 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj14 = obj5 + 32;
		object obj15 = (flag ? 1 : 0) + 76;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v51+8]");
		_ = 0;
		transform = (Transform)obj14;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v56+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		object obj16 = topIconPayload + 36;
		obj16 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj17 = obj5 + 16;
		object obj18 = (flag ? 1 : 0) + 204;
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S1_v66+8]");
		_ = 0;
		transform = (Transform)obj17;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v64+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		object obj19 = topIconPayload + 52;
		obj19 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj20 = (flag ? 1 : 0) + 460;
		obj5 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v80+8]");
		_ = 0;
		transform = (Transform)obj5;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		object obj21 = topIconPayload + 68;
		obj21 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		int missionsVersion2 = PlayerSave.missionsVersion;
		nint num9 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v81 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num10 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v115 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num11 = ((missionsVersion2 >= 30) ? 30 : missionsVersion2);
		transform = (Transform)num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object obj23 = topIconPayload + 16;
		string text4 = default;
		string text3 = "x" + text4;
		obj23 = text3;
		_ = 1;
		object obj24 = this + 72;
		obj24 = topIconPayload;
		_top.MakeIcon((PageTop.TopIconPayload)(object)_topPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		UIWidget uIWidget = default;
		((UnityEngine.Object)uIWidget).m_CachedPtr = cachedPtr;
		uIWidget.bottomAnchor = (UIRect.AnchorPoint)0;
		object obj25 = uIWidget + 16;
		obj25 = this;
		object obj26 = this + 48;
		GameObject gameObject2 = ((WeeklyHuntPage)(object)_top)._003CInit_003Eb__32_2(uIWidget);
		_0021_00210 componentInChildren = (_0021_00210)gameObject2.GetComponentInChildren<T>();
		obj26 = componentInChildren;
		((UIRect)completedMissionsCount).ParentHasChanged();
		((PageTop)(object)this).Setup((PageTop.EventsPageTopPayload)completedMissionsCount);
		UIWidget component = GetComponent<UIWidget>();
		GameObject gameObject3 = _003CInit_003Eb__21_0(component);
		_cellHeight = (int)gameObject3;
		CreateNewMissionCells();
		RefreshCurrentCells();
	}

	private unsafe IEnumerator MissionCompleteAnimation(int completedMissionsCount)
	{
		//IL_013b: Expected Obj, but got I4
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_018f: Expected Obj, but got F4
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got VT
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected I4, but got Unknown
		//IL_0200: Expected I4, but got Obj
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_024e: Expected Obj, but got I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected I4, but got Unknown
		//IL_027e: Expected I4, but got Obj
		//IL_0298: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		GameObject parent = ((Component)completedMissionsCount).gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TimerHelper timerHelper = UnityEngine.Object.Instantiate((TimerHelper)_cellAnimationDuration, (Transform)(object)parent);
		nint num3 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v12 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v42 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TimeSpan wordHuntTimeLeft = EventsSave.wordHuntTimeLeft;
		object obj3 = wordHuntTimeLeft;
		HorizontalAlignment horizontalAlignment = (HorizontalAlignment)(obj3 + 8);
		((HorizontalAlignment*)(int)horizontalAlignment)->value__ = (int)obj3;
		timerHelper.SetAlignment(horizontalAlignment);
		object obj4 = obj3 + 40;
		Color black = Color.black;
		nint num5 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v23 (Il2CppClass<UI.ColorData>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v38 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj3 + 24;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj7 = (flag ? 1 : 0) + 204;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v18+8]");
		_ = 0;
		bool flag2 = (byte)(obj3 + 56) != 0;
		((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj4 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v21+8]");
		_ = 0;
		((HorizontalAlignment*)(int)horizontalAlignment)->value__ = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v28+8]");
		_ = 0;
		timerHelper.AnimateClock(flag2, (byte)horizontalAlignment != 0);
		return (IEnumerator)(object)timerHelper.tag;
	}

	private int CalculateCellHeight(UIWidget pageGuideWidget)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 20;
		obj = this;
		return num;
	}

	private void RefreshCurrentCells()
	{
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 40;
		object obj3 = _missionInfos + 16;
		int num = _currentSet / 2;
		object obj4 = num * 2;
		object obj5 = _currentSet - obj4;
		object obj6 = obj5 << 2;
		object obj7 = obj3 + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<MissionCell> list = default;
		list._002Ector();
		throw new ArrayTypeMismatchException();
	}

	private unsafe void ResetCellPositions()
	{
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected VT, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00e2: Expected VT, but got Obj
		//IL_00dd: Expected native int or pointer, but got VT
		//IL_00f7: Expected VT, but got I
		//IL_00f2: Expected native int or pointer, but got VT
		//IL_0121: Expected native int or pointer, but got VT
		object obj = default;
		MissionInfo missionInfo = (MissionInfo)(obj + 40);
		int num = default;
		int num4 = default;
		while (num <= 2)
		{
			object obj2 = _missionCells + 16;
			int num2 = _currentSet / 2;
			object obj3 = num2 * 2;
			object obj4 = _currentSet - obj3;
			object obj5 = obj4 << 2;
			object obj6 = obj2 + obj5;
			MissionCell missionCell = ((List<MissionCell>)obj6).get_Item(num);
			object obj7 = _missionInfos + 16;
			int num3 = _currentSet / 2;
			object obj8 = num3 * 2;
			object obj9 = _currentSet - obj8;
			object obj10 = obj9 << 2;
			object obj11 = obj7 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8283");
			((MissionInfo*)(nint)missionInfo)->mission = (Mission)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			System.Runtime.CompilerServices.Unsafe.Write(&((MissionInfo*)(nint)missionInfo)->template, (MissionTemplate)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
			((MissionInfo*)(nint)missionInfo)->progress = 0;
			missionCell.Refresh(missionInfo);
			num = num4 + 1;
		}
	}

	private void DestroyOtherMissionCells()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_015e: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v8 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v45 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v19 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v39 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = _003C_003Ec._003C_003E9;
		nint num6 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v36 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+5C]");
		object obj5 = (nint)0 + (nint)12;
		obj5 = obj4;
		throw new NullReferenceException();
	}

	private void RefreshPageTitles(bool useEffect = false)
	{
		//IL_0043: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I4
		string text = tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 != null)
		{
			int num = CalculateCellHeight((UIWidget)useEffect);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)num);
		}
	}

	private void AnimateNewMissionSet()
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0142: Expected Obj, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00e2: Expected I, but got Obj
		object obj = _missionCells + 16;
		object obj2 = _currentSet + 1;
		object obj3 = obj2 / 2;
		object obj4 = obj3 * 2;
		object obj5 = obj2 - obj4;
		object obj6 = obj5 << 2;
		object obj7 = obj + obj6;
		if (obj7 == null)
		{
			return;
		}
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v13 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v50 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v24 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v44 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj11 = default;
		object obj10 = obj11 + 16;
		obj10 = _003C_003Ec._003C_003E9;
		nint num6 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v41 (Il2CppClass<UI.Pages.MissionsPage+<>c>)+5C]");
		object obj12 = (nint)0 + (nint)16;
		obj12 = obj11;
		throw new NullReferenceException();
	}

	private unsafe IEnumerator AnimateCell(Transform cellTransform, float startX, float endX, Action onComplete = null)
	{
		//IL_0017: Expected VT, but got Obj
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected VT, but got Unknown
		//IL_0037: Expected F4, but got Obj
		//IL_0032: Expected native int or pointer, but got VT
		//IL_0049: Expected F4, but got I
		//IL_0044: Expected native int or pointer, but got VT
		//IL_007c: Expected I4, but got Obj
		//IL_007c: Expected Obj, but got I
		GameObject gameObject = base.gameObject;
		Transform transform = default;
		transform.position = (Vector3)gameObject;
		Vector3 vector = (Vector3)(transform + 12);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		IntPtr cachedPtr = ((UnityEngine.Object)cellTransform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cellTransform @ L1 (UnityEngine.Transform)+1C]");
		return ((Sound)(object)this).playAudioClip((AudioClip)(nint)cachedPtr, AudioRolloffMode.Logarithmic, startX, startX, endX, endX, vector, (byte)(int)onComplete != 0);
	}

	private float GetTotalMissionCellAnimationTime()
	{
		//IL_0007: Expected F4, but got Obj
		return (float)_missionSetProgressPrefab;
	}

	public MissionsPage()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_040c: Expected Obj, but got I4
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected Obj, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04b9: Expected Obj, but got I4
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Obj, but got Unknown
		//IL_058a: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I
		//IL_0219: Expected F4, but got I
		//IL_0219: Expected F4, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj6 = default;
		object obj5 = obj6 + 8;
		obj5 = this;
		_ = -350f;
		_ = 0f;
		_ = 350f;
		int currentSet = _currentSet + 1;
		_currentSet = currentSet;
		RefreshCurrentCells();
		object obj7 = obj6 + 12;
		object obj8 = _missionCells + 16;
		int num = _currentSet / 2;
		object obj9 = num * 2;
		object obj10 = _currentSet - obj9;
		object obj11 = obj10 << 2;
		object obj12 = obj8 + obj11;
		obj7 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj13 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj13 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
		}
		object obj14 = obj4 + 4;
		object obj15 = obj14 + 1;
		obj14 = obj15;
		object obj16 = obj15 << 2;
		object obj17 = obj4 + obj16;
		obj17 = 147;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj18 = (nint)0 << 2;
			object obj19 = obj4 + obj18;
			if ((nint)obj19 == 147)
			{
				object obj20 = obj4 + 4;
				if ((nint)obj20 > -1)
				{
					object obj21 = obj20 + -1;
					obj20 = obj21;
				}
				goto IL_0533;
			}
		}
		object obj22 = default;
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0533;
		IL_0533:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		object obj24 = default;
		object obj23 = obj24 + 16;
		obj23 = this;
		object obj25 = obj6 + 32;
		obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+C]");
		MissionCell missionCell = ((List<MissionCell>)0).get_Item(0);
		GameObject button = missionCell.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+10]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+14]");
		IEnumerator routine = ((FrontScreen)(object)this).AnimateButtonVertical(button, (float)num3, 0f, (Action)null);
		Coroutine coroutine = StartCoroutine_Auto(routine);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		object obj27 = default;
		object obj26 = obj27 + 16;
		obj26 = obj6;
		throw new ArrayTypeMismatchException();
	}

	private GameObject _003CInit_003Eb__21_0(UIWidget w)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I4
		object obj = _missionCellLayouts + 16;
		int num = _currentSet / 2;
		object obj2 = num * 2;
		object obj3 = _currentSet - obj2;
		object obj4 = obj3 << 2;
		object obj5 = obj + obj4;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5+24]");
		object obj7 = (nint)0 << 1;
		UIWidget uIWidget = topContainer;
		object obj8 = obj7 + uIWidget.mHeight;
		object obj9 = w.mHeight - obj8;
		float f = (float)obj9 / 3f;
		return (GameObject)NumberExtensions.FloorToInt(f);
	}
}
