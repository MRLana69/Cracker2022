using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cloud;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using Kiloo.Common.Backend.Authentication;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.Utility;
using SYBO.Components.Utilities;
using SYBO.Subway.StateSystem.States;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;

public class MysteryBoxDoubleUpButton : MonoBehaviour
{
	private sealed class _003CAnimateButton_003Ed__22(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public MysteryBoxDoubleUpButton _003C_003E4__this;

		private float _003CbounceDuration_003E5__2;

		private float _003Cp_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_031f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0324: Expected VT, but got Unknown
				//IL_032d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0332: Expected Obj, but got Unknown
				//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Expected Obj, but got Unknown
				//IL_0156: Expected Obj, but got I4
				//IL_016a: Expected VT, but got Obj
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_0117: Expected Obj, but got Unknown
				//IL_0133: Expected Obj, but got I4
				//IL_0180: Expected F4, but got I
				//IL_0211: Expected I, but got Obj
				//IL_0227: Expected Obj, but got I
				//IL_0396: Expected F4, but got Obj
				//IL_0391: Expected native int or pointer, but got VT
				//IL_03ab: Expected F4, but got I
				//IL_03a6: Expected native int or pointer, but got VT
				//IL_029e: Expected F4, but got Obj
				//IL_0299: Expected native int or pointer, but got VT
				//IL_02b3: Expected F4, but got I
				//IL_02ae: Expected native int or pointer, but got VT
				//IL_02c0: Expected Obj, but got VT
				//IL_02c0: Expected Obj, but got I4
				//IL_0252: Expected I, but got Obj
				//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f4: Expected Obj, but got Unknown
				//IL_02fd: Expected Obj, but got I4
				//IL_0311: Expected Obj, but got I4
				object obj = default;
				Vector3 vector = (Vector3)(obj + 24);
				object obj2 = obj + 12;
				MysteryBoxDoubleUpButton mysteryBoxDoubleUpButton = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						mysteryBoxDoubleUpButton._stickerGameObject.tag = (string)1;
						_003Cp_003E5__3 = 0f;
						_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v57 (T)+10]");
						Time.captureDeltaTime = 0f;
					}
					if (!(_003Cp_003E5__3 < _003CbounceDuration_003E5__2))
					{
						IEnumerator enumerator = mysteryBoxDoubleUpButton._stickerAnimation.GetEnumerator();
						return null;
					}
					int layer = mysteryBoxDoubleUpButton._stickerGameObject.layer;
					nint num = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v25 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num2 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v46 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 forward = Vector3.forward;
					float p = _003Cp_003E5__3 / _003CbounceDuration_003E5__2;
					float num3 = Easings.ElasticEaseInOut(p);
					((Vector3*)(nint)vector)->x = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Vector3 vector2 = vector / num3;
					((Vector3*)(nint)vector)->x = (float)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Vector3*)(nint)vector)->z = 0f;
					((Transform)layer).parent = (Transform)vector;
					float unscaledTime = Time.unscaledTime;
					float num4 = _003Cp_003E5__3 + unscaledTime;
					_003Cp_003E5__3 = num4;
					object obj4 = this + 12;
					obj4 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				_003CbounceDuration_003E5__2 = 1f;
				_003C_003E4__this.DisableButton();
				if (mysteryBoxDoubleUpButton._animateAlphaCoroutine != null)
				{
					FileUtil.LogError((string)(object)mysteryBoxDoubleUpButton._animateAlphaCoroutine);
				}
				object obj5 = _003C_003E4__this + 44;
				UIWidget component = mysteryBoxDoubleUpButton._doubleButton.GetComponent<UIWidget>();
				IEnumerator list = ((JetpackState)null).SpawnCoinCurve((AnimationCurve)(object)component, 0.2f, 0f, 1f);
				Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
				obj5 = coroutine;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0.2f;
				object obj6 = this + 12;
				object obj7 = default;
				obj6 = obj7;
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

	private sealed class _003CAnimateAlpha_003Ed__28(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWidget widget;

		public float from;

		public float duration;

		public float to;

		private float _003Cfactor_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00d5: Expected I, but got Obj
				//IL_00eb: Expected Obj, but got I
				//IL_0116: Expected I, but got Obj
				//IL_0237: Unknown result type (might be due to invalid IL or missing references)
				//IL_023c: Expected Obj, but got Unknown
				//IL_0245: Expected Obj, but got I4
				//IL_0259: Expected Obj, but got I4
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					_003Cfactor_003E5__2 = 0f;
				}
				if (_003Cfactor_003E5__2 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num = unscaledTime / duration;
					float num2 = _003Cfactor_003E5__2 + num;
					_003Cfactor_003E5__2 = num2;
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v27 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num5;
					if (_003Cfactor_003E5__2 < 0f)
					{
						num5 = 0f;
					}
					else
					{
						num5 = ((!(_003Cfactor_003E5__2 > 1f)) ? _003Cfactor_003E5__2 : 1f);
					}
					_003Cfactor_003E5__2 = num5;
					float num6 = Mathf.LerpUnclamped(from, to, _003Cfactor_003E5__2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
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

	private GameObject _doubleButton;

	private UILabel _buttonLabel;

	private GameObject _stickerGameObject;

	private Animation _stickerAnimation;

	private const string ONLINESETTINGS_MYSTERY_BOX_DOUBLE_REWARD_CHANCE_KEY = "mystery_box_double_reward_chance";

	private const int DEFAULT_MYSTERY_BOX_DOUBLE_REWARD_CHANCE = 100;

	private const string ONLINESETTINGS_MYSTERY_BOX_DOUBLE_REWARD_ALLOW_KEYS_KEY = "mystery_box_double_reward_allow_keys";

	private const bool DEFAULT_MYSTERY_BOX_DOUBLE_REWARD_ALLOW_KEYS = false;

	private CelebrationReward _rewardToDouble;

	private bool _wasRewardDoubled;

	private bool _isButtonEnabled;

	private Dictionary<CelebrationRewardType, Action> _doubleRewardCallbacks;

	private Coroutine _animateButtonCoroutine;

	private Coroutine _animateAlphaCoroutine;

	private bool _hasSetDefaultButtonColorOnce;

	private int chance
	{
		get
		{
			//IL_00a4: Expected I, but got Obj
			//IL_00ba: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (MysteryBoxDoubleUpButton)+158]");
			int num3 = (int)(-6);
			if (num3 < 0)
			{
				num3 = 0;
			}
			else if (num3 > 28)
			{
				num3 = 28;
			}
			return num3;
		}
	}

	private bool ChanceRoll()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		return (byte)((OnlineSettings)(object)saveDataPath).GetValue("mystery_box_double_reward_chance", 100u) != 0;
	}

	private bool IsVideoAvailable()
	{
		bool flag = ((MysteryBoxDoubleUpButton)null).ChanceRoll();
		int num = UnityEngine.Random.RandomRangeInt(0, 100);
		return (flag ? 1 : 0) > num;
	}

	private bool IsDoublable(CelebrationReward reward)
	{
		//IL_00a5: Expected Obj, but got I4
		//IL_0027: Expected I4, but got Obj
		//IL_0078: Expected I4, but got Obj
		OfferWallManager instance = OfferWallManager.instance;
		bool flag = ((AdSystemManager)(object)instance).GetAvailabilityForLocation((string)(object)reward);
		if ((string)flag != "none")
		{
			flag = (byte)(int)"none" != 0;
		}
		else
		{
			bool flag2;
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ S0_v9 (System.Boolean)+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (flag2)
			{
				flag = (byte)(int)"none" != 0;
			}
		}
		return flag;
	}

	private unsafe bool IsValidOrigin(CelebrationReward reward)
	{
		//IL_029d: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_0152: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got I4
		//IL_02e7: Expected I4, but got Obj
		//IL_0193: Expected I, but got Obj
		//IL_01fc: Expected I, but got Obj
		//IL_0212: Expected Obj, but got I
		//IL_023d: Expected I, but got Obj
		object obj = reward.rewardType - 1;
		if (reward.rewardType != CelebrationRewardType.coins)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4)
						{
							if ((nint)obj == 5)
							{
								nint num = (nint)typeof(OnlineSettings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v22 (Il2CppClass<Info.OnlineSettings>)+BA]");
								object obj2 = (nint)0 & (nint)0x200;
								if (obj2 != null)
								{
									nint num2 = (nint)typeof(OnlineSettings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v29 (Il2CppClass<Info.OnlineSettings>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								string saveDataPath = OnlineSettings.GetSaveDataPath();
								return ((OnlineSettings)(object)saveDataPath).TryGetValue("mystery_box_double_reward_allow_keys", out *(string*)null);
							}
							return false;
						}
						return false;
					}
					return false;
				}
				nint num3 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v7 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v12 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				ICloudServer cloudServer = CloudSave.CreateServer((string)reward.characterId, (IKilooAuth)reward, (IBsonSerializer)1);
				return (byte)(int)cloudServer != 0;
			}
			object obj4 = reward.upgradeType - 1;
			if (reward.upgradeType == UpgradeType.hoverboard || ((nint)obj4 != 1 && (nint)obj4 == 2))
			{
				return true;
			}
			return reward.upgradeType == UpgradeType.scorebooster;
		}
		return true;
	}

	public bool TryEnable(CelebrationReward rewardToDouble, Dictionary<CelebrationRewardType, Action> doubleRewardCallbacks)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_013f: Expected Obj, but got I4
		//IL_00bd: Expected I4, but got Obj
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0123: Expected I4, but got Obj
		//IL_00af: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		object obj3 = 1;
		object obj5;
		while (true)
		{
			if ((nint)obj3 <= 10)
			{
				object obj4 = (object)doubleRewardCallbacks * obj3;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<CelebrationReward, UIntPtr>(ref rewardToDouble))
				{
					obj5 = obj3;
					break;
				}
				if ((nint)obj3 == 10)
				{
					object obj6 = doubleRewardCallbacks * 10;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<CelebrationReward, UIntPtr>(ref rewardToDouble))
					{
						obj5 = 10;
						break;
					}
				}
				object obj7 = obj3 + 1;
				obj3 = obj7;
				continue;
			}
			return (byte)(int)"" != 0;
		}
		object obj8 = (object)doubleRewardCallbacks * obj5;
		object obj9 = obj8 - (object)doubleRewardCallbacks;
		obj = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text3 = default;
		string text = text2 + " - " + text3;
		return (byte)(int)text != 0;
	}

	private unsafe void LogAttemptToShowButton(bool isValidOrigin, bool isDoublable, bool chanceRoll)
	{
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected VT, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0265: Expected Obj, but got I4
		//IL_0035: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_028b: Expected Obj, but got VT
		//IL_02a0: Expected F4, but got Obj
		//IL_029b: Expected native int or pointer, but got VT
		//IL_02ba: Expected F4, but got Obj
		//IL_02b5: Expected native int or pointer, but got VT
		//IL_02cf: Expected F4, but got I
		//IL_02ca: Expected native int or pointer, but got VT
		//IL_02dc: Expected I4, but got VT
		//IL_02dc: Expected Obj, but got I4
		//IL_02e5: Expected Obj, but got VT
		//IL_02fa: Expected F4, but got Obj
		//IL_02f5: Expected native int or pointer, but got VT
		//IL_00c2: Expected F4, but got Obj
		//IL_00bd: Expected native int or pointer, but got VT
		//IL_00d7: Expected F4, but got I
		//IL_00d2: Expected native int or pointer, but got VT
		//IL_00e4: Expected I4, but got VT
		//IL_00e4: Expected Obj, but got I4
		//IL_0076: Expected I, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_0315: Expected Obj, but got VT
		//IL_032a: Expected F4, but got Obj
		//IL_0325: Expected native int or pointer, but got VT
		//IL_0344: Expected F4, but got Obj
		//IL_033f: Expected native int or pointer, but got VT
		//IL_0359: Expected F4, but got I
		//IL_0354: Expected native int or pointer, but got VT
		//IL_0366: Expected I4, but got VT
		//IL_0366: Expected Obj, but got I4
		//IL_036f: Expected Obj, but got VT
		//IL_0384: Expected F4, but got Obj
		//IL_037f: Expected native int or pointer, but got VT
		//IL_0184: Expected F4, but got Obj
		//IL_017f: Expected native int or pointer, but got VT
		//IL_0199: Expected F4, but got I
		//IL_0194: Expected native int or pointer, but got VT
		//IL_01a6: Expected I4, but got VT
		//IL_01a6: Expected Obj, but got I4
		//IL_0138: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj - -64);
		object obj2 = obj + 40;
		object obj3 = obj + 24;
		object obj4 = obj + 56;
		object obj5 = obj + 16;
		object obj6 = obj + 52;
		object obj7 = obj + 48;
		object obj8 = obj + 44;
		object obj9 = (isValidOrigin ? 1 : 0) - 1;
		if (!isValidOrigin)
		{
			if ((nint)obj9 == 1)
			{
				nint num = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v60 (Il2CppClass<GlobalColors>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num2 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v78 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = GlobalColors.ACTIVE_SCOREBOOSTER_GEAR_BACKGROUND_COLOR;
				obj7 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
				Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				((UIWidget)isDoublable).rawPivot = (UIWidget.Pivot)matrix4x;
				obj5 = GlobalColors.ACTIVE_SCOREBOOSTER_GEAR_COUNT_COLOR;
				obj8 = obj5;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
				Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				((UIWidget)chanceRoll).rawPivot = (UIWidget.Pivot)matrix4x;
			}
		}
		else
		{
			nint num3 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v35 (Il2CppClass<GlobalColors>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num4 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v53 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.ACTIVE_HEADSTART_GEAR_BACKGROUND_COLOR;
			obj4 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)isDoublable).rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = GlobalColors.ACTIVE_HEADSTART_GEAR_COUNT_COLOR;
			obj6 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)chanceRoll).rawPivot = (UIWidget.Pivot)matrix4x;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [chanceRoll @ L3 (System.Boolean)+144]");
		if ((nint)0 != 0)
		{
			_ = 0;
			_ = 1;
			_ = 1;
		}
	}

	private IEnumerator AnimateButton()
	{
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		OfferWallManager instance = OfferWallManager.instance;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v11 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((AdSystemManager)(object)instance).IsCaching((string)(object)AdLocations.DOUBLE_UP_VIDEOS);
		((WaterFallReach)(object)AdLocations.DOUBLE_UP_VIDEOS).OnFailedToCacheVideo((string)flag);
		return (IEnumerator)flag;
	}

	private unsafe void ResetAnimationState()
	{
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got F4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected I4, but got Unknown
		//IL_017a: Expected I4, but got Obj
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_019f: Expected Obj, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01c3: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got F4
		//IL_01f1: Expected I4, but got Obj
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0216: Expected Obj, but got I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_023a: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got F4
		//IL_0268: Expected I4, but got Obj
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_028d: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got F4
		//IL_02d1: Expected I4, but got Obj
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I
		//IL_0038: Expected I4, but got Obj
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I
		//IL_00e9: Expected I4, but got Obj
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		obj = 0;
		_ = 0;
		obj = 191f / 255f;
		_ = 233f / 255f;
		_ = 253f / 255f;
		_ = 1f;
		CallingConvention callingConvention = (CallingConvention)(obj2 + 72);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj3 = this + 108;
		obj3 = ((CallingConvention*)(int)callingConvention)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (System.Runtime.InteropServices.CallingConvention)+8]");
		_ = 0;
		object obj4 = obj2 + 32;
		obj4 = 0;
		_ = 0;
		obj4 = 0f;
		_ = 156f / 255f;
		_ = 1f;
		_ = 1f;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v22+8]");
		_ = 0;
		object obj5 = this + 124;
		obj5 = ((CallingConvention*)(int)callingConvention)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (System.Runtime.InteropServices.CallingConvention)+8]");
		_ = 0;
		object obj6 = obj2 + 16;
		obj6 = 0;
		_ = 0;
		obj6 = 1f;
		_ = 1f;
		_ = 1f;
		_ = 1f;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v34+8]");
		_ = 0;
		object obj7 = this + 140;
		obj7 = ((CallingConvention*)(int)callingConvention)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (System.Runtime.InteropServices.CallingConvention)+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 1f;
		_ = 219f / 255f;
		_ = 0f;
		_ = 1f;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj8 = this + 156;
		obj8 = ((CallingConvention*)(int)callingConvention)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (System.Runtime.InteropServices.CallingConvention)+8]");
		_ = 0;
		object obj9 = this + 212;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj10 = default;
		obj9 = obj10;
		object obj11 = this + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj12 = default;
		obj11 = obj12;
		object obj13 = this + 220;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj15 = obj2 + 68;
		obj15 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj15;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		object obj16 = this + 240;
		obj16 = unmanagedFunctionPointerAttribute;
		object obj17 = this + 252;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj18 = default;
		obj17 = obj18;
		object obj19 = this + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj20 = default;
		obj19 = obj20;
		object obj21 = this + 260;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj22 = default;
		obj21 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj23 = obj2 - -64;
		obj23 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj23;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute2 = default;
		unmanagedFunctionPointerAttribute2._002Ector(callingConvention);
		object obj24 = this + 280;
		obj24 = unmanagedFunctionPointerAttribute2;
		_ = 2;
		_ = 2;
		_ = -1;
		((UpgradeScreen)this).Start();
	}

	public void DisableButton()
	{
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I4
		//IL_00c5: Expected I4, but got Obj
		//IL_00c5: Expected Obj, but got I4
		//IL_0063: Expected I, but got Obj
		_stickerGameObject.tag = null;
		UIWidget component = _doubleButton.GetComponent<UIWidget>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		int layer = _stickerGameObject.layer;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v22 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 forward = Vector3.forward;
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		((Transform)layer).parent = transform;
		Animation.INTERNAL_CALL_Stop(_stickerAnimation);
		bool isPlaying = _stickerAnimation.isPlaying;
		((Animator)isPlaying).SetFloat((int)_stickerGameObject, 0f);
	}

	public void OnClick()
	{
		if (~(_isButtonEnabled ? 1u : 0u) == 0 && _rewardToDouble != null && ~(_wasRewardDoubled ? 1u : 0u) != 0)
		{
			((OfferWallPopup)this).OnApplicationPause(false);
		}
		_wasRewardDoubled = false;
		_isButtonEnabled = false;
		_doubleButton.tag = null;
	}

	private void OnDoubleReward()
	{
		//IL_00b9: Expected I, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_015d: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		_wasRewardDoubled = true;
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v18 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnClick();
		OfferWallManager instance = OfferWallManager.instance;
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v6 (Il2CppClass<AdLocations>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v14 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		string text = default;
		text.m_stringLength = (int)num5;
		_ = 0;
		object obj3 = text + 16;
		obj3 = this;
		((AdSystemManager)(object)instance).FinishedWatchingVideo((string)(object)AdLocations.DOUBLE_UP_VIDEOS, text);
		AdTrackingSystemLogger.LogFillRequest(AdLocations.DOUBLE_UP_VIDEOS);
	}

	private void OnEnable()
	{
		//IL_00bc: Expected Obj, but got I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		object obj = 0;
		if (_rewardToDouble != null && ((MysteryBoxDoubleUpButton)null).IsValidOrigin(_rewardToDouble))
		{
			CelebrationReward rewardToDouble = _rewardToDouble;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
			object obj3 = default;
			object obj2 = obj3 ^ 1;
			bool flag = obj == null;
			object obj4 = flag | obj2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
			((OfferWallPopup)this).OnApplicationPause(true);
		}
		object obj5 = this + 28;
		obj5 = 0;
	}

	private IEnumerator AnimateAlpha(UIWidget widget, float duration, float from, float to)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public void FlurryLogDoubleUpResultAs(bool doubledUp)
	{
		if (!doubledUp)
		{
			((IngameScreen)this).OnEnable();
		}
	}

	public string GroupCoinsForFlurryLogging(int originalCoinAmount)
	{
		//IL_0016: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [originalCoinAmount @ L1 (System.Int32)+8]");
		object obj = -1;
		if ((nint)obj > 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [originalCoinAmount @ L1 (System.Int32)+8]");
			object obj2 = -4;
			if ((nint)obj2 > 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [originalCoinAmount @ L1 (System.Int32)+8]");
				object obj3 = -12;
				bool flag = (nint)obj3 < 2;
				return (string)flag;
			}
		}
		return (string)1;
	}

	private void SetDefaultButtonColorOnce()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_001a: Expected Obj, but got I4
		OnClick();
		object obj = this + 28;
		obj = 0;
	}

	private unsafe void Log(string msg, UnityEngine.Object context = null)
	{
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected VT, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d3: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_003c: Expected I, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_020b: Expected Obj, but got VT
		//IL_0220: Expected F4, but got Obj
		//IL_021b: Expected native int or pointer, but got VT
		//IL_023a: Expected F4, but got Obj
		//IL_0235: Expected native int or pointer, but got VT
		//IL_024f: Expected F4, but got I
		//IL_024a: Expected native int or pointer, but got VT
		//IL_025c: Expected I4, but got VT
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_0117: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_007d: Expected I, but got Obj
		//IL_029f: Expected Obj, but got VT
		//IL_02b4: Expected F4, but got Obj
		//IL_02af: Expected native int or pointer, but got VT
		//IL_02ce: Expected F4, but got Obj
		//IL_02c9: Expected native int or pointer, but got VT
		//IL_02e3: Expected F4, but got I
		//IL_02de: Expected native int or pointer, but got VT
		//IL_02f0: Expected I4, but got VT
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_0158: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 32);
		object obj2 = obj + 16;
		object obj3 = obj + 24;
		object obj4 = obj + 20;
		object obj5 = msg + 12;
		object obj6 = default;
		object obj11 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			object obj7 = msg + 16;
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			nint num = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v42 (Il2CppClass<GlobalColors>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num2 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v54 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.INACTIVE_GEAR_BACKGROUND_COLOR;
			obj3 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)obj9).rawPivot = (UIWidget.Pivot)matrix4x;
			obj6 = obj11 + 1;
		}
		object obj12 = context + 12;
		object obj13 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
		{
			object obj14 = context + 16;
			object obj15 = obj13 << 2;
			object obj16 = obj14 + obj15;
			UIWidget uIWidget = (UIWidget)obj16;
			nint num3 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v33 (Il2CppClass<GlobalColors>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num4 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v53 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.INACTIVE_GEAR_COUNT_COLOR;
			obj4 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)obj16).rawPivot = (UIWidget.Pivot)matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v31 (UIWidget)+144]");
			if ((nint)0 != 1)
			{
				_ = 1;
				((UIRect)uIWidget).mChanged = true;
				_ = 1;
			}
			object obj18 = obj13 + 1;
			obj13 = obj18;
		}
	}

	public unsafe MysteryBoxDoubleUpButton()
	{
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected I4, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I4
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_0063: Expected I, but got Obj
		//IL_00af: Expected VT, but got Obj
		//IL_0106: Expected Obj, but got I4
		//IL_0141: Expected I4, but got Obj
		object obj = default;
		bool flag = (byte)(obj + 96) != 0;
		UIButtonColor uIButtonColor = (UIButtonColor)(obj - -64);
		object obj2 = obj + 48;
		object obj3 = obj + 32;
		object obj4 = obj + 16;
		object obj5 = obj + 80;
		obj5 = 0;
		_ = 0;
		if (~(_hasSetDefaultButtonColorOnce ? 1u : 0u) == 0)
		{
			return;
		}
		UIButtonColor component = _doubleButton.GetComponent<UIButtonColor>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v62 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			uIButtonColor.defaultColor = (Color)component;
			obj5 = uIButtonColor;
			_ = ((UnityEngine.Object)uIButtonColor).m_CachedPtr;
			obj2 = uIButtonColor;
			_ = ((UnityEngine.Object)uIButtonColor).m_CachedPtr;
			obj3 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			_ = 0;
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			_ = 0;
			obj = 0;
			_ = 0;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			_ = 0;
			_ = 1f;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			component.isEnabled = flag;
		}
		_hasSetDefaultButtonColorOnce = true;
	}
}
