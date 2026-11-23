using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using Missions;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Managers;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Info;
using SYBO.Subway.Themes;
using TopRun;
using UI.Popups;
using UI.Screens;
using UnityEngine;

public class UIScreenController : MonoBehaviour
{
	public enum SlideInType
	{
		TopRunTimer,
		Mission,
		MissionSet,
		Letters,
		LettersCompleteMysteryBox,
		LettersCompleteCoins,
		Unlock,
		ErrorMessage,
		WeeklyHunt,
		OfferWall,
		VideoForKeys,
		Brag,
		BundlesPack,
		Awards,
		Facebook,
		CharacterEventWord,
		CharacterEventWordReward
	}

	public class SlideIn
	{
		private SlideInType _type;

		private string _payload;

		private string _extraInfo;

		private AwardTierType _awardTierType;

		private UISlideInFacebook.FacebookSlideInState _facebookState;

		private Action _onDidShowCallback;

		private int _payloadInt;

		private MysteryBox.Type _mysteryBoxType;

		public SlideInType type => _type;

		public string payload => _payload;

		public string extraInfo => _extraInfo;

		public AwardTierType awardTierType => _awardTierType;

		public UISlideInFacebook.FacebookSlideInState facebookState => _facebookState;

		public Action onDidShowCallback => _onDidShowCallback;

		public int payloadInt => _payloadInt;

		public MysteryBox.Type mysteryBoxType => _mysteryBoxType;

		public SlideIn(SlideInType type)
		{
			_payload = string.Empty;
			_extraInfo = string.Empty;
			_type = type;
		}

		public SlideIn(SlideInType type, string payload)
		{
			_payload = string.Empty;
			_extraInfo = string.Empty;
			_payload = payload;
			_type = type;
		}

		public SlideIn(SlideInType type, string payload, AwardTierType awardTierType)
		{
			_payload = string.Empty;
			_extraInfo = string.Empty;
			_payload = payload;
			_awardTierType = awardTierType;
			_type = type;
		}

		public SlideIn(SlideInType type, int payload, string extraInfo)
		{
			_payload = string.Empty;
			_extraInfo = string.Empty;
			_extraInfo = extraInfo;
			_type = type;
			_payloadInt = payload;
		}

		public SlideIn(SlideInType type, UISlideInFacebook.FacebookSlideInState state, Action onDidShowCallback = null)
		{
			_payload = string.Empty;
			_extraInfo = string.Empty;
			_onDidShowCallback = onDidShowCallback;
			_type = type;
			_facebookState = state;
		}

		public SlideIn(SlideInType type, int PayLoadInt)
		{
			_payload = string.Empty;
			_extraInfo = string.Empty;
			_payloadInt = PayLoadInt;
			_type = type;
		}

		public SlideIn(SlideInType type, MysteryBox.Type mysteryBoxType)
		{
			_payload = string.Empty;
			_extraInfo = string.Empty;
			_mysteryBoxType = mysteryBoxType;
			_type = type;
		}
	}

	private sealed class _003CShowMainMenuCoroutine_003Ed__161(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIScreenController _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
			{
				if (_003C_003E1__state != 2)
				{
					goto IL_00e1;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				if (realtimeSinceStartup < LoadLevelCtrl.continueTime)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
			}
			if (!PoolManager._balancing)
			{
				ThemeManager instance = ThemeManager.Instance;
				instance.OnValidate();
				UIScreen uIScreen = _003C_003E4__this._ActivateScreen("FrontUI");
				goto IL_00e1;
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 2;
			return true;
			IL_00e1:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CDealyHideMainCamera_003Ed__179(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIScreenController _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					UIScreenController uIScreenController = _003C_003E4__this;
					uIScreenController.mainCamera.enabled = false;
				}
				return false;
			}
			_003C_003E1__state = -1;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CAnimateCollectText_003Ed__215(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UILabel collectText;

		public UIScreenController _003C_003E4__this;

		private Vector3 _003CtoLocalPosition_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00dd: Expected VT, but got I
			//IL_0166: Expected F4, but got I
			//IL_0161: Expected native int or pointer, but got VT
			//IL_0175: Expected F4, but got VT
			//IL_0170: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 32);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state == 3)
						{
							_003C_003E1__state = -1;
							GameObject gameObject = collectText.gameObject;
							UnityEngine.Object.Destroy(gameObject);
						}
						bool result = default;
						return result;
					}
					_003C_003E1__state = -1;
					IEnumerator routine = _003C_003E4__this.AnimateAlpha(collectText, 0.2f, 0f);
					Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
					_ = 0.25f;
					object obj2 = default;
					_003C_003E2__current = obj2;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E1__state = -1;
				Transform cachedTransform = collectText.cachedTransform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScreenController+<AnimateCollectText>d__215)+20]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)_003CtoLocalPosition_003E5__2;
				IEnumerator routine2 = _003C_003E4__this.MoveTransform(cachedTransform, 1f, vector);
				Coroutine coroutine2 = _003C_003E4__this.StartCoroutine(routine2);
				_ = 0.8f;
				object obj3 = default;
				_003C_003E2__current = obj3;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			Transform transform = collectText.transform;
			Vector3 localPosition = transform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
			float num = 0f + 50f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			_003CtoLocalPosition_003E5__2 = (Vector3)0;
			IEnumerator routine3 = _003C_003E4__this.AnimateAlpha(collectText, 0.1f, 1f);
			Coroutine coroutine3 = _003C_003E4__this.StartCoroutine(routine3);
			_003C_003E2__current = coroutine3;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CAnimateAlpha_003Ed__216(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UILabel label;

		public float duration;

		public float toAlpha;

		private float _003CfromAlpha_003E5__2;

		private float _003Cfactor2_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected Obj, but got Unknown
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Expected Obj, but got Unknown
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					bool flag = _003Cfactor2_003E5__3 < 1f;
					num = _003Cfactor2_003E5__3;
					if (flag)
					{
						goto IL_00d5;
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			UILabel uILabel = label;
			nint num2 = (nint)uILabel;
			object obj = uILabel + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S1_v12 (Il2CppClass<UILabel>)+F4] (should have been resolved before IL gen)");
			_003Cfactor2_003E5__3 = 0f;
			float num3 = default;
			_003CfromAlpha_003E5__2 = num3;
			num = 0f;
			goto IL_00d5;
			IL_00d5:
			float deltaTime = Time.deltaTime;
			float num4 = deltaTime / duration;
			float num5 = num + num4;
			float num6 = Math.Min(num5, 1f);
			bool flag2 = num5 < 0f;
			float num7 = 0f;
			if (!flag2)
			{
				num7 = num6;
			}
			_003Cfactor2_003E5__3 = num7;
			UILabel uILabel2 = label;
			float num8 = toAlpha - _003CfromAlpha_003E5__2;
			float num9 = Math.Max(num7, 0f);
			float num10 = num8 * num9;
			float num11 = _003CfromAlpha_003E5__2 + num10;
			object obj2 = uILabel2 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S2_v11+BC] (should have been resolved before IL gen)");
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CMoveTransform_003Ed__217(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform trans;

		public float duration;

		public Vector3 toPos;

		private Vector3 _003CfromPos_003E5__2;

		private float _003Cfactor2_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00a4: Expected VT, but got I
			//IL_017f: Expected Obj, but got VT
			//IL_01ce: Expected Obj, but got I
			//IL_0211: Expected Obj, but got I
			//IL_0251: Expected F4, but got I
			//IL_024c: Expected native int or pointer, but got VT
			//IL_0270: Expected F4, but got I
			//IL_026b: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj + -64);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (_003Cfactor2_003E5__3 < 1f)
					{
						goto IL_00e9;
					}
				}
				goto IL_015e;
			}
			_003C_003E1__state = -1;
			Vector3 localPosition = trans.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_003CfromPos_003E5__2 = (Vector3)0;
			_003Cfactor2_003E5__3 = 0f;
			goto IL_00e9;
			IL_00e9:
			float deltaTime = Time.deltaTime;
			float num = deltaTime / duration;
			float num2 = _003Cfactor2_003E5__3 + num;
			float num3 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num4 = 0f;
			if (!flag)
			{
				num4 = num3;
			}
			_003Cfactor2_003E5__3 = num4;
			object obj2 = toPos - _003CfromPos_003E5__2;
			float num5 = Math.Max(num4, 0f);
			float num6 = (float)obj2 * num5;
			float num7 = (float)_003CfromPos_003E5__2 + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScreenController+<MoveTransform>d__217)+1C]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScreenController+<MoveTransform>d__217)+28]");
			object obj3 = num8 - 0;
			float num9 = (float)obj3 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScreenController+<MoveTransform>d__217)+28]");
			float num10 = 0f + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScreenController+<MoveTransform>d__217)+20]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScreenController+<MoveTransform>d__217)+2C]");
			object obj4 = num11 - 0;
			float num12 = (float)obj4 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScreenController+<MoveTransform>d__217)+2C]");
			float num13 = 0f + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			trans.localPosition = vector;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_015e;
			IL_015e:
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<SlideIn> _003C_003E9__218_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal bool _003CNumberOfMissionSetSlideIns_003Eb__218_0(SlideIn item)
		{
			return item._type == SlideInType.MissionSet;
		}
	}

	private sealed class _003CHideInAppPurchaceOverlayDelayedCoroutine_003Ed__237(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIScreenController _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					_003C_003E4__this.HideInAppPurchaseOverlay();
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = 2f;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CHideAdsOverlayWithDelay_003Ed__242(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public UIScreenController _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					UIScreenController uIScreenController = _003C_003E4__this;
					uIScreenController.adsOverlay.SetActive(value: false);
				}
				return false;
			}
			_003C_003E1__state = -1;
			IEnumerator enumerator = CoroutineUtil.WaitForRealSeconds(delay);
			_003C_003E2__current = enumerator;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CHideTransitionAdsOverlayWithDelay_003Ed__245(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public UIScreenController _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					UIScreenController uIScreenController = _003C_003E4__this;
					uIScreenController.transitionAdsOverlay.SetActive(value: false);
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = delay;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CDelayInputOnOverlay_003Ed__249(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIScreenController _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					_ = 1;
				}
				return false;
			}
			_003C_003E1__state = -1;
			IEnumerator routine = CoroutineUtil.WaitForRealSeconds(2f);
			Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
			_003C_003E2__current = coroutine;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private AgeRestrictionPopup AgeRestrictionPopup;

	private FrontScreen FrontScreen;

	private SettingsPopup SettingsPopup;

	private CountryPopup CountryPopup;

	private ShopScreen ShopScreen;

	private MeScreen MeScreen;

	private DailyChallengeScreen DailyChallengeScreen;

	private HoverboardPopup HoverboardPopup;

	private MissionPopup MissionPopup;

	private ItemHuntPopup ItemHuntPopup;

	private LeaderboardPopup LeaderboardPopup;

	private GameOverScreen GameOverScreen;

	private SaveMePopup SaveMePopup;

	private PauseScreen PauseScreen;

	private HomeConfirmationPopup HomeConfirmationPopup;

	private IngameScreen IngameScreen;

	private ConsumablesPopup ConsumablesPopup;

	private NotEnoughCurencyPopup NotEnoughCurencyPopup;

	private CelebrationPopup CelebrationPopup;

	private PrizeMBPopup PrizeMBPopup_Keys;

	public SCREEN CurrenScreen = SCREEN.FrontUI;

	public SCREEN OldScreen;

	public List<SCREEN> ListScreen;

	public SCREEN_GAME screen_game;

	private const string SCREEN_RESOURCE_PATH = "Prefabs/Screens/";

	private const string POPUP_RESOURCE_PATH = "Prefabs/Popups/";

	private static UIScreenController _instance;

	public AnimationCurve guidelineAnimation;

	public GameObject backgroundAnchor;

	public GameObject screenAnchor;

	public GameObject popupAnchor;

	public GameObject superPopupAnchor;

	public UICamera nguiCamera;

	public Camera Camera3D;

	public Camera CameraOverlay2dClipping;

	public Camera CameraOverlay2d;

	public Camera CameraCelebration;

	public Camera Camera2DNormal;

	public Camera Camera3DOverlay;

	public Camera Camera3DClip;

	public UIRoot root;

	public GameObject MenuElements3D;

	public bool LoadMenuOnStart;

	public Font FloatingTextFont;

	private Camera mainCamera;

	public Action<string> OnChangedScreen;

	private Font lilitaRegularFont;

	private Font titanRegularFont;

	private bool _isApplicationFocused;

	private static readonly List<string> PAYOUT_DISALLOWED_SCREENS;

	private static bool _facebookPayoutPopupQueued;

	private static bool _gameCenterPayoutPopupQueued;

	private Dictionary<string, UIScreen> _cachedScreens;

	private List<string> _screenStack;

	private List<string> _popupQueue;

	private List<string> _delayedPopups;

	private bool _popupActive;

	private List<string> _screenNamesWithoutBackground;

	public string text;

	public int size;

	public FontStyle style;

	private bool _isApplicationResuming;

	private bool _isApplicationPaused;

	public bool justPaidOutTopRun;

	public bool stoppingFromEditor;

	public bool doSaveAndDelayRemainingPopups;

	public bool ignoreLastPopupClosed;

	private UISlideInMissionHelper missionSlideIn;

	private UISlideInMissionSetHelper missionSetSlideIn;

	private UISlideInLettersHelper lettersSlideIn;

	private UISlideInUnlock unlockSlideIn;

	private UISlideInErrorMessage errorSlideIn;

	private UISlideInOfferPayoutHelper offerWallSlideIn;

	private UISlideInItemHunt _weeklyHuntSlideIn;

	private UISlideInBrag bragSlideIn;

	private UISlideInVideoPayoutHelper watchForKeysSlideIn;

	private UISlideInBundlesPack bundlesPackSlideIn;

	private UISlideInAwards awardsSlideIn;

	private UISlideInFacebook facebookSlideIn;

	private UISlideInTopRunTimer topRunTimerSlideIn;

	private UISlideInCharacterEventHelper characterEventSlideIn;

	private UISlideInCharacterEventRewardHelper characterEventRewardSlideIn;

	public UISlideInMissionSetHelper coinReward;

	private List<SlideIn> _slideInQueue;

	private List<SlideIn> _noOfMissionSetSlideIns;

	private bool slideInActive;

	private bool slideHasPreloaded;

	private AudioClipInfo slideInSound;

	private AudioClipInfo slideInFanfare;

	private List<SlideInType> _uniqueSlideInTypes;

	public UIMessageHelper messageHelper;

	private Queue<string> _messageQueue;

	private bool messageShowing;

	public GameObject inAppPurchaseOverlay;

	public GameObject adsOverlay;

	private GameObject _nativeInterstitialAdViewPrefab;

	private NativeInterstitialHelper _nativeInterstitialAdView;

	private GameObject transitionAdsOverlay;

	public GameObject videoAdsOverlay;

	private bool _allowInputOnVideoAdsOverlay;

	private GameObject generalDebugLabel;

	private GameObject _memoryBenchmarkOverlay;

	private UIProgressBar _memoryBenchmarkProgress;

	public static Vector3 POPUP_DEFAULT_POSITION;

	public static Vector3 SCREEN_DEFAULT_POSITION;

	public static Vector3 CELEBRATION_POPUP_POSITION;

	public static Vector2 SAVEME_POPUP_POSITION;

	private static Action<string> m_OnNavigateToScreen;

	private static Action<string> m_OnWillNavigateToScreen;

	private static Action m_OnAwake;

	private static Action m_OnApplicationResumed;

	private Action<string> m_OnPopupShown;

	private Action m_OnLastPopupClosed;

	private Action<string> m_OnPopupClosed;

	public ShopScreen.Screen _Screen;

	public bool pauseGame
	{
		get
		{
			PauseScreen pauseScreen = PauseScreen;
			return pauseScreen._isActive;
		}
	}

	public static bool IsInstanced
	{
		get
		{
			//IL_002d: Expected VT, but got Obj
			if (_instance == null)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(UIScreenController));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				UIScreenController instance = default;
				_instance = instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			}
			return _instance != null;
		}
	}

	public LeaderboardPopup _LeaderboardPopup => LeaderboardPopup;

	public static UIScreenController Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)_instance == null;
			bool flag2 = !flag;
			UIScreenController result = _instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(UIScreenController));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				UIScreenController uIScreenController = default;
				_instance = uIScreenController;
				result = uIScreenController;
			}
			return result;
		}
	}

	public bool IsApplicationFocused => _isApplicationFocused;

	public bool IsApplicationPaused => _isApplicationPaused;

	public bool isShowingPopup
	{
		get
		{
			List<string> popupQueue = _popupQueue;
			if (_popupQueue != null)
			{
				return popupQueue._size > 0;
			}
			return false;
		}
	}

	public NativeInterstitialHelper NativeInterstitialAdView
	{
		get
		{
			if (_nativeInterstitialAdView == null)
			{
				InstantiateNativeAdView();
			}
			return _nativeInterstitialAdView;
		}
	}

	public static event Action<string> OnNavigateToScreen
	{
		add
		{
			Delegate obj = UIScreenController.m_OnNavigateToScreen;
			Action<string> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == UIScreenController.m_OnNavigateToScreen;
				Action<string> onNavigateToScreen = action;
				if (!flag)
				{
					onNavigateToScreen = UIScreenController.m_OnNavigateToScreen;
				}
				UIScreenController.m_OnNavigateToScreen = onNavigateToScreen;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = UIScreenController.m_OnNavigateToScreen;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = UIScreenController.m_OnNavigateToScreen;
			Action<string> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == UIScreenController.m_OnNavigateToScreen;
				Action<string> onNavigateToScreen = action;
				if (!flag)
				{
					onNavigateToScreen = UIScreenController.m_OnNavigateToScreen;
				}
				UIScreenController.m_OnNavigateToScreen = onNavigateToScreen;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = UIScreenController.m_OnNavigateToScreen;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<string> OnWillNavigateToScreen
	{
		add
		{
			Delegate obj = UIScreenController.m_OnWillNavigateToScreen;
			Action<string> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == UIScreenController.m_OnWillNavigateToScreen;
				Action<string> onWillNavigateToScreen = action;
				if (!flag)
				{
					onWillNavigateToScreen = UIScreenController.m_OnWillNavigateToScreen;
				}
				UIScreenController.m_OnWillNavigateToScreen = onWillNavigateToScreen;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = UIScreenController.m_OnWillNavigateToScreen;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = UIScreenController.m_OnWillNavigateToScreen;
			Action<string> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == UIScreenController.m_OnWillNavigateToScreen;
				Action<string> onWillNavigateToScreen = action;
				if (!flag)
				{
					onWillNavigateToScreen = UIScreenController.m_OnWillNavigateToScreen;
				}
				UIScreenController.m_OnWillNavigateToScreen = onWillNavigateToScreen;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = UIScreenController.m_OnWillNavigateToScreen;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action OnAwake
	{
		add
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			Delegate obj = UIScreenController.m_OnAwake;
			Delegate obj5 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				nint num = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v7 (Il2CppClass<UIScreenController>)+5C]");
				object obj3 = -(-64);
				bool flag = obj == obj3;
				Delegate obj4 = obj5;
				if (!flag)
				{
					obj4 = (Delegate)obj3;
				}
				obj3 = obj4;
				Delegate obj6 = obj;
				if (!flag)
				{
					obj6 = (Delegate)obj3;
				}
				flag2 = (object)obj != obj6;
				obj = obj6;
			}
			while (flag2);
		}
		remove
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			Delegate obj = UIScreenController.m_OnAwake;
			Delegate obj5 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				nint num = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v7 (Il2CppClass<UIScreenController>)+5C]");
				object obj3 = -(-64);
				bool flag = obj == obj3;
				Delegate obj4 = obj5;
				if (!flag)
				{
					obj4 = (Delegate)obj3;
				}
				obj3 = obj4;
				Delegate obj6 = obj;
				if (!flag)
				{
					obj6 = (Delegate)obj3;
				}
				flag2 = (object)obj != obj6;
				obj = obj6;
			}
			while (flag2);
		}
	}

	public static event Action OnApplicationResumed
	{
		add
		{
			Delegate obj = UIScreenController.m_OnApplicationResumed;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == UIScreenController.m_OnApplicationResumed;
				Action onApplicationResumed = action;
				if (!flag)
				{
					onApplicationResumed = UIScreenController.m_OnApplicationResumed;
				}
				UIScreenController.m_OnApplicationResumed = onApplicationResumed;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = UIScreenController.m_OnApplicationResumed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = UIScreenController.m_OnApplicationResumed;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == UIScreenController.m_OnApplicationResumed;
				Action onApplicationResumed = action;
				if (!flag)
				{
					onApplicationResumed = UIScreenController.m_OnApplicationResumed;
				}
				UIScreenController.m_OnApplicationResumed = onApplicationResumed;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = UIScreenController.m_OnApplicationResumed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public event Action<string> OnPopupShown
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 380;
			Delegate obj2 = this.m_OnPopupShown;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 380;
			Delegate obj2 = this.m_OnPopupShown;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action OnLastPopupClosed
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 384;
			Delegate obj2 = this.m_OnLastPopupClosed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 384;
			Delegate obj2 = this.m_OnLastPopupClosed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<string> OnPopupClosed
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 388;
			Delegate obj2 = this.m_OnPopupClosed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 388;
			Delegate obj2 = this.m_OnPopupClosed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	private unsafe void Awake()
	{
		MissionsManager instance = MissionsManager.Instance;
		MissionsManager.MissionCompleteHandler missionCompleteHandler = default;
		missionCompleteHandler._002Ector(this, (nint)__ldftn(UIScreenController.OnMissionCompleted));
		Delegate obj = Delegate.Combine(instance.onMissionComplete, missionCompleteHandler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		MissionsManager.MissionCompleteHandler onMissionComplete = default;
		instance.onMissionComplete = onMissionComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		MissionsManager instance2 = MissionsManager.Instance;
		MissionsManager.MissionSetCompleteHandler missionSetCompleteHandler = default;
		missionSetCompleteHandler._002Ector(this, (nint)__ldftn(UIScreenController.OnMissionSetCompleted));
		Delegate obj2 = Delegate.Combine(instance2.onMissionSetComplete, missionSetCompleteHandler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		MissionsManager.MissionSetCompleteHandler onMissionSetComplete = default;
		instance2.onMissionSetComplete = onMissionSetComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		PlayerInfo instance3 = PlayerInfo.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(UIScreenController.OnLetterPickedUp));
		Delegate obj3 = Delegate.Combine(instance3.OnPickedUpLetter, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onPickedUpLetter = default;
		instance3.OnPickedUpLetter = onPickedUpLetter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		PlayerInfo instance4 = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	private void OnApplicationQuit()
	{
	}

	private unsafe void OnDestroy()
	{
		if (~(stoppingFromEditor ? 1u : 0u) != 0)
		{
			MissionsManager instance = MissionsManager.Instance;
			MissionsManager.MissionCompleteHandler missionCompleteHandler = default;
			missionCompleteHandler._002Ector(this, (nint)__ldftn(UIScreenController.OnMissionCompleted));
			Delegate obj = Delegate.Remove(instance.onMissionComplete, missionCompleteHandler);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			MissionsManager.MissionCompleteHandler onMissionComplete = default;
			instance.onMissionComplete = onMissionComplete;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			MissionsManager instance2 = MissionsManager.Instance;
			MissionsManager.MissionSetCompleteHandler missionSetCompleteHandler = default;
			missionSetCompleteHandler._002Ector(this, (nint)__ldftn(UIScreenController.OnMissionSetCompleted));
			Delegate obj2 = Delegate.Remove(instance2.onMissionSetComplete, missionSetCompleteHandler);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			MissionsManager.MissionSetCompleteHandler onMissionSetComplete = default;
			instance2.onMissionSetComplete = onMissionSetComplete;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			PlayerInfo instance3 = PlayerInfo.Instance;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(UIScreenController.OnLetterPickedUp));
			Delegate obj3 = Delegate.Remove(instance3.OnPickedUpLetter, action);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			Action onPickedUpLetter = default;
			instance3.OnPickedUpLetter = onPickedUpLetter;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			PlayerInfo instance4 = PlayerInfo.Instance;
			throw new ArgumentException();
		}
	}

	private void Start()
	{
		HideInAppPurchaseOverlay();
		if (~(LoadMenuOnStart ? 1u : 0u) == 0)
		{
			ShowMainMenu();
		}
		PlayerInfo instance = PlayerInfo.Instance;
		instance.BragCompleted();
		MissionsManager instance2 = MissionsManager.Instance;
		MissionInfo[] missionInfo = instance2.GetMissionInfo();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (MissionInfo[])+34]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (MissionInfo[])+5C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (MissionInfo[])+84]");
				if ((nint)0 != 0)
				{
					PlayerInfo instance3 = PlayerInfo.Instance;
					bool flag = instance3._missionCompletedSum == 0;
					bool flag2 = !flag;
					int num = instance3._missionCompletedSum;
					if (!flag2)
					{
						num = (instance3._missionCompletedSum = instance3._currentMissionSet + 1);
					}
					int missionCompletedSum = num + 1;
					instance3._missionCompletedSum = missionCompletedSum;
					MissionsManager instance4 = MissionsManager.Instance;
					PlayerInfo playerinfo = instance4.playerinfo;
					int currentMissionSet = playerinfo._currentMissionSet + 1;
					instance4.currentMissionSet = currentMissionSet;
				}
			}
		}
		PreloadAllSlideIn();
		UpdateNguiTouchThresholds();
		EnableGeneralDebugLabelIfNeeded();
	}

	private void _SetApplicationPause(bool isApplicationPaused)
	{
		//IL_00e8: Expected VT, but got Obj
		//IL_00f6: Expected Obj, but got VT
		bool isApplicationResuming;
		if (isApplicationPaused)
		{
			_isApplicationPaused = true;
			PlayerInfo instance = PlayerInfo.Instance;
			instance.SaveIfDirty();
			UpdateApp.AllowAgainThisSession();
			LogFlurry();
			isApplicationResuming = (byte)((_isApplicationPaused ? 1u : 0u) ^ 1u) != 0;
		}
		else
		{
			_isApplicationPaused = false;
			isApplicationResuming = true;
		}
		_isApplicationResuming = isApplicationResuming;
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.MetroPlayerARM || !isApplicationPaused)
		{
			return;
		}
		string text = Peek(_screenStack);
		if (text == "IngameUI")
		{
			Game instance2 = Game.Instance;
			if (!instance2.isDead)
			{
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				((TimeScaleManager)val).TimeScale = 0f;
			}
		}
	}

	private void _SetApplicationFocus(bool _isApplicationFocus)
	{
		//IL_00a5: Expected Obj, but got I4
		//IL_0103: Expected VT, but got Obj
		//IL_0111: Expected Obj, but got VT
		_isApplicationFocused = _isApplicationFocus;
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor)
		{
			return;
		}
		bool isApplicationPaused = (byte)((_isApplicationFocus ? 1u : 0u) ^ 1u) != 0;
		_SetApplicationPause(isApplicationPaused);
		RuntimePlatform platform2 = Application.platform;
		if (platform2 != RuntimePlatform.Android || DeviceUtility.isKindleDevice || _isApplicationFocus)
		{
			return;
		}
		string text = ((UIScreenController)_isApplicationFocus).Peek(_screenStack);
		if (text == "IngameUI")
		{
			Game instance = Game.Instance;
			if (!instance.isDead)
			{
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				((TimeScaleManager)val).TimeScale = 0f;
			}
		}
	}

	public void DebugSetApplicationPause(bool isApplicationPaused)
	{
		_SetApplicationPause(isApplicationPaused);
	}

	public void DebugSetApplicationFocus(bool isApplicationFocused)
	{
		_SetApplicationFocus(isApplicationFocused);
	}

	private void LateUpdate()
	{
		if (~(_isApplicationResuming ? 1u : 0u) != 0)
		{
			return;
		}
		_isApplicationResuming = false;
		if (CurrenScreen == SCREEN.InGame)
		{
			Game instance = Game.Instance;
			if (instance != null)
			{
				Game instance2 = Game.Instance;
				if (instance2.isDead)
				{
					goto IL_00ec;
				}
			}
			if (~(_popupActive ? 1u : 0u) == 0)
			{
				string text = Peek(_popupQueue);
				if (!(text != "ConsumablesPopup"))
				{
					goto IL_00ec;
				}
			}
			PushScreen(null, "PauseUI");
		}
		goto IL_00ec;
		IL_00ec:
		if (UIScreenController.m_OnApplicationResumed != null)
		{
			Action onApplicationResumed = UIScreenController.m_OnApplicationResumed;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v80.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void OnApplicationPause(bool isApplicationPaused)
	{
		_SetApplicationPause(isApplicationPaused);
	}

	private void OnApplicationFocus(bool isFocused)
	{
		_SetApplicationFocus(isFocused);
	}

	private void UpdateNguiTouchThresholds()
	{
		float dpi = Screen.dpi;
		bool flag = dpi > 0f;
		bool flag2 = !flag;
		float touchDragThreshold = 30f;
		if (!flag2)
		{
			float dpi2 = Screen.dpi;
			float num = dpi2 * 0.1f;
			touchDragThreshold = num;
		}
		float dpi3 = Screen.dpi;
		bool flag3 = dpi3 > 0f;
		bool flag4 = !flag3;
		float touchClickThreshold = 30f;
		if (!flag4)
		{
			float dpi4 = Screen.dpi;
			float num2 = dpi4 * 0.1f;
			touchClickThreshold = num2;
		}
		UICamera uICamera = nguiCamera;
		uICamera.touchClickThreshold = touchClickThreshold;
		uICamera.touchDragThreshold = touchDragThreshold;
	}

	private void LogFlurry()
	{
		//IL_0076: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I4
		string currentPopupName = GetCurrentPopupName();
		string topScreenName = GetTopScreenName();
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.Android)
		{
			RuntimePlatform platform2 = Application.platform;
			if (platform2 != RuntimePlatform.IPhonePlayer)
			{
				goto IL_0051;
			}
		}
		if (currentPopupName != null)
		{
			goto IL_0051;
		}
		goto IL_006d;
		IL_0124:
		object obj;
		if (currentPopupName != null)
		{
			obj = 0;
			if (currentPopupName._stringLength != 0)
			{
				goto IL_021f;
			}
		}
		obj = 1;
		goto IL_021f;
		IL_0203:
		object obj2;
		if (obj2 != null)
		{
			goto IL_0124;
		}
		object obj3;
		if (topScreenName != null)
		{
			obj3 = 0;
			if (topScreenName._stringLength != 0)
			{
				goto IL_0211;
			}
		}
		obj3 = 1;
		goto IL_0211;
		IL_0051:
		object obj4 = 0;
		if (currentPopupName._stringLength == 0)
		{
			goto IL_006d;
		}
		goto IL_01db;
		IL_006d:
		obj4 = 1;
		goto IL_01db;
		IL_01db:
		if (obj4 != null)
		{
			return;
		}
		if (currentPopupName != null)
		{
			obj2 = 0;
			if (currentPopupName._stringLength != 0)
			{
				goto IL_0203;
			}
		}
		obj2 = 1;
		goto IL_0203;
		IL_023c:
		object obj5;
		if (obj5 != null)
		{
		}
		return;
		IL_0211:
		if (obj3 == null)
		{
			string text = topScreenName + "_" + currentPopupName;
			return;
		}
		goto IL_0124;
		IL_021f:
		if (obj == null)
		{
			return;
		}
		if (topScreenName != null)
		{
			obj5 = 0;
			if (topScreenName._stringLength != 0)
			{
				goto IL_023c;
			}
		}
		obj5 = 1;
		goto IL_023c;
	}

	public void FacebookLogIn(bool loggedIn)
	{
		if (loggedIn)
		{
			MissionsManager instance = MissionsManager.Instance;
			instance.PlayerDidThis(MissionTarget.FacebookLoggedIn);
		}
	}

	public void ShowMainMenu()
	{
		IEnumerator routine = ShowMainMenuCoroutine();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator ShowMainMenuCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void GameOverTriggered()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		instance.RunCompleted();
		MissionsManager instance2 = MissionsManager.Instance;
		instance2.inRun = false;
		UIScreen uIScreen = _ActivateScreen("GameoverUI");
	}

	public void QueueMessage(string message)
	{
		_QueueMessage(message);
	}

	public void GoToMainMenuFromGame(GameObject sender)
	{
		Game instance = Game.Instance;
		if (instance != null)
		{
			MissionsManager instance2 = MissionsManager.Instance;
			instance2.inRun = false;
			Game instance3 = Game.Instance;
			instance3.StartTopMenu();
			Game instance4 = Game.Instance;
			instance4.TriggerPause(pauseGame: false);
		}
		PayWeeklyHuntIfNeeded();
		UIScreen uIScreen = _ActivateScreen("FrontUI");
	}

	private void PayWeeklyHuntIfNeeded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_021c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		List<CelebrationReward> weeklyHuntRewardsToUnlock = RewardManager.GetWeeklyHuntRewardsToUnlock();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2386");
	}

	public void PayoutCelebrationReward(CelebrationReward reward)
	{
		//IL_01fb: Expected Obj, but got I4
		//IL_0102: Expected I, but got Obj
		object obj = reward.rewardType - 1;
		if (reward.rewardType != CelebrationRewardType.coins)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4 && (nint)obj != 5 && (nint)obj != 6 && (nint)obj == 7)
						{
							TopRunRewardHelper.TrackRewardStats(reward);
							TopRunEventsHandler instance = TopRunEventsHandler.instance;
							TournamentChangedEventArgs e = default;
							e._002Ector();
							nint num = (nint)instance;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ S3_v4 (Il2CppClass<TopRunEventsHandler>)+DC] (should have been resolved before IL gen)");
						}
					}
					else
					{
						PlayerInfo instance2 = PlayerInfo.Instance;
						int amountOfKeys = instance2.amountOfKeys;
						int amountOfKeys2 = amountOfKeys + reward.amount;
						instance2.amountOfKeys = amountOfKeys2;
					}
				}
			}
			else
			{
				PlayerInfo instance3 = PlayerInfo.Instance;
				instance3.IncreaseUpgradeAmount(reward.powerupType, reward.amount);
			}
		}
		else
		{
			PlayerInfo instance4 = PlayerInfo.Instance;
			int amountOfCoins = instance4.amountOfCoins;
			int amountOfCoins2 = amountOfCoins + reward.amount;
			instance4.amountOfCoins = amountOfCoins2;
		}
		RewardManager.RewardPayedOut(reward);
		PlayerInfo instance5 = PlayerInfo.Instance;
		instance5.SaveIfDirty();
	}

	public string GetTopScreenName()
	{
		List<string> screenStack = _screenStack;
		bool flag = _screenStack == null;
		string result = null;
		if (!flag)
		{
			bool flag2 = screenStack._size < 1;
			result = null;
			if (!flag2)
			{
				string text = ((UIScreenController)null).Peek(_screenStack);
				result = text;
			}
		}
		return result;
	}

	public UIScreen GetScreenFromCache(string screenName)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		object obj;
		if (screenName != null)
		{
			obj = 0;
			if (screenName._stringLength != 0)
			{
				goto IL_00d0;
			}
		}
		obj = 1;
		goto IL_00d0;
		IL_00d0:
		UIScreen result = null;
		if (obj == null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UI.Screens.UIScreen>>)+54]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj4 = default;
			object obj3 = obj4 ^ -1;
			object obj5 = obj3 >> 31;
			bool flag = obj5 == null;
			result = null;
			if (!flag)
			{
				UIScreen uIScreen = _cachedScreens.get_Item(screenName);
				result = uIScreen;
			}
		}
		return result;
	}

	public void PushScreen(string screenName)
	{
		PushScreen(null, screenName);
	}

	public void PushScreen(GameObject sender)
	{
		PushScreen(sender, string.Empty);
	}

	private void PushScreen(GameObject sender, string screenOverride)
	{
		//IL_025f: Expected Obj, but got I4
		//IL_0243: Expected Obj, but got I4
		string text = default;
		if (text == string.Empty)
		{
			UIButtonChangeScreen component = sender.GetComponent<UIButtonChangeScreen>();
			bool flag = component != null;
			bool flag2 = !flag;
			text = string.Empty;
			if (!flag2)
			{
				text = component.ScreenNameToOpen;
			}
		}
		if (sender != null)
		{
			BackBtnBehaviour component2 = sender.GetComponent<BackBtnBehaviour>();
			if (component2 != null)
			{
				text = component2.ScreenNameToOpen;
			}
		}
		if (text.Equals("FrontUI"))
		{
			GoToMainMenuFromGame((GameObject)(object)text);
		}
		if (text == "PauseUI")
		{
			Game instance = Game.Instance;
			if (!(instance != null))
			{
				return;
			}
			Game instance2 = Game.Instance;
			if (instance2.isDead)
			{
				return;
			}
		}
		string text2 = ((UIScreenController)(object)text).Peek(_screenStack);
		if (text2 == "PauseUI" && text == "IngameUI")
		{
			UIScreen uIScreen = _cachedScreens.get_Item("PauseUI");
			PauseScreen component3 = uIScreen.GetComponent<PauseScreen>();
			if (component3.IsWaiting())
			{
				return;
			}
		}
		if (!(text == "FrontUI"))
		{
			goto IL_0475;
		}
		string topScreenName = GetTopScreenName();
		object obj;
		if (topScreenName != null)
		{
			obj = 0;
			if (topScreenName._stringLength != 0)
			{
				goto IL_0488;
			}
		}
		obj = 1;
		goto IL_0488;
		IL_0475:
		UIScreen uIScreen2 = _ActivateScreen(text);
		return;
		IL_0488:
		if (obj == null)
		{
			switch (topScreenName)
			{
			case "FriendsUI":
				UIScreens.friendsMenu_lastScreen = topScreenName;
				break;
			case "LeaderboardUI":
				UIScreens.friendsMenu_lastScreen = topScreenName;
				break;
			case "TopRunUI":
				UIScreens.friendsMenu_lastScreen = "TopRunUI";
				break;
			default:
				if (!(topScreenName != "CharacterScreen") || !(topScreenName != "BoardScreen") || topScreenName == "AwardsScreen")
				{
					UIScreens.meMenu_lastScreen = topScreenName;
				}
				else if (!(topScreenName != "UpgradesUI_shop") || !(topScreenName != "EarnCoinsScreen") || topScreenName == "CoinsUI_shop")
				{
					UIScreens.shopMenu_lastScreen = topScreenName;
				}
				break;
			}
		}
		goto IL_0475;
	}

	public void BackToPrevious()
	{
		_BackToPreviousScreen();
	}

	private UIScreen _ActivateScreen(string screenName)
	{
		//IL_01a0: Expected I, but got Obj
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01ca: Expected I, but got Obj
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01f4: Expected I, but got Obj
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_022e: Expected I, but got Obj
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0258: Expected I, but got Obj
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_0306: Expected I, but got Obj
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_008d: Expected I, but got Obj
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00b7: Expected I, but got Obj
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		if (!(screenName == "FrontUI"))
		{
			if (!(screenName == "GameoverUI"))
			{
				if (screenName != "PauseUI")
				{
					if (screenName == "IngameUI")
					{
						PauseScreen.HidePupUp();
						IngameScreen ingameScreen = IngameScreen;
						nint num = (nint)ingameScreen;
						object obj = ingameScreen + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v213 @ S1_v59 (Il2CppClass<IngameScreen>)+DC] (should have been resolved before IL gen)");
						IngameScreen ingameScreen2 = IngameScreen;
						nint num2 = (nint)ingameScreen2;
						object obj2 = ingameScreen2 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ S1_v63 (Il2CppClass<IngameScreen>)+E4] (should have been resolved before IL gen)");
						if (IngameScreen != null)
						{
							IngameScreen.Reset();
						}
					}
				}
				else
				{
					PauseScreen pauseScreen = PauseScreen;
					nint num3 = (nint)pauseScreen;
					object obj3 = pauseScreen + 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ S1_v52 (Il2CppClass<PauseScreen>)+E4] (should have been resolved before IL gen)");
				}
			}
			else
			{
				GameOverScreen.SetupBeforeMysteryBox();
				GameOverScreen gameOverScreen = GameOverScreen;
				nint num4 = (nint)gameOverScreen;
				object obj4 = gameOverScreen + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v141 @ S1_v32 (Il2CppClass<GameOverScreen>)+DC] (should have been resolved before IL gen)");
				GameOverScreen gameOverScreen2 = GameOverScreen;
				nint num5 = (nint)gameOverScreen2;
				object obj5 = gameOverScreen2 + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ S1_v36 (Il2CppClass<GameOverScreen>)+E4] (should have been resolved before IL gen)");
				GameOverScreen.SetupAfterMysteryBox();
				Action<string> onChangedScreen = OnChangedScreen;
				if (OnChangedScreen != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v179 @ S0_v41 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
				}
				Action<string> onNavigateToScreen = UIScreenController.m_OnNavigateToScreen;
				if (UIScreenController.m_OnNavigateToScreen != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ S0_v48 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
				}
				ScreenDidChange(screenName);
				ActivateAnchors(active: true);
				int rewardsToUnlockCount = RewardManager.rewardsToUnlockCount;
				if (rewardsToUnlockCount >= 1)
				{
					_QueuePopup("CelebrationPopup");
				}
			}
		}
		else
		{
			List<string> screenStack = _screenStack;
			if (screenStack._size != 0)
			{
				string text = Peek(_screenStack);
				if (text == "IngameUI")
				{
					string text2 = Pop(_screenStack);
				}
			}
			IngameScreen ingameScreen3 = IngameScreen;
			nint num6 = (nint)ingameScreen3;
			object obj6 = ingameScreen3 + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S1_v11 (Il2CppClass<IngameScreen>)+EC] (should have been resolved before IL gen)");
			FrontScreen frontScreen = FrontScreen;
			nint num7 = (nint)frontScreen;
			object obj7 = frontScreen + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ S1_v15 (Il2CppClass<FrontScreen>)+DC] (should have been resolved before IL gen)");
			FrontScreen frontScreen2 = FrontScreen;
			nint num8 = (nint)frontScreen2;
			object obj8 = frontScreen2 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ S1_v19 (Il2CppClass<FrontScreen>)+E4] (should have been resolved before IL gen)");
		}
		bool flag = _screenNamesWithoutBackground.Contains(screenName);
		bool state = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		_SetBackground(state);
		return null;
	}

	private void _SwitchScreen(string screenName)
	{
		//IL_0031: Expected I, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		string key = Pop(_screenStack);
		UIScreen uIScreen = _cachedScreens.get_Item(key);
		nint num = (nint)uIScreen;
		object obj = uIScreen + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S1_v6 (Il2CppClass<UI.Screens.UIScreen>)+EC] (should have been resolved before IL gen)");
		UIScreen uIScreen2 = _ActivateScreen(screenName);
	}

	public void SwitchScreen(GameObject sender)
	{
		UIButtonChangeScreen component = sender.GetComponent<UIButtonChangeScreen>();
		_SwitchScreen(component.ScreenNameToOpen);
	}

	private void _BackToPreviousScreen()
	{
		//IL_0035: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		List<string> screenStack = _screenStack;
		if (screenStack._size >= 2)
		{
			string key = Pop(_screenStack);
			UIScreen uIScreen = _cachedScreens.get_Item(key);
			nint num = (nint)uIScreen;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S1_v7 (Il2CppClass<UI.Screens.UIScreen>)+EC] (should have been resolved before IL gen)");
			string text = Peek(_screenStack);
			UIScreen uIScreen2 = _cachedScreens.get_Item(text);
			nint num2 = (nint)uIScreen2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ S1_v13 (Il2CppClass<UI.Screens.UIScreen>)+E4] (should have been resolved before IL gen)");
			bool flag = _screenNamesWithoutBackground.Contains(text);
			bool state = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			_SetBackground(state);
			ScreenDidChange(text);
		}
	}

	private void ScreenDidChange(string newScreenName)
	{
		if (newScreenName != "IngameUI")
		{
			messageHelper.DisableShowLabel();
		}
		TryQueuePayoutPopups();
		if (newScreenName == "FrontUI" || newScreenName == "GameoverUI")
		{
			HouseKeeper.RefreshOnlineSettingsAndInappsIfNeeded();
		}
		PlayerInfo instance = PlayerInfo.Instance;
		if (newScreenName == "FrontUI" && ~(FrontScreen.buttonsHaveTweened ? 1u : 0u) == 0 && ~(instance._shouldShowMission2Popup ? 1u : 0u) == 0 && !instance._hasShownMission2Popup)
		{
			if (~(instance._shouldShowMission2Popup ? 1u : 0u) == 0)
			{
				instance._dirty = true;
				instance._shouldShowMission2Popup = false;
			}
			if (!instance._hasShownMission2Popup)
			{
				instance._dirty = true;
				instance._hasShownMission2Popup = true;
			}
			_QueuePopup("TutorialEndGameMissionsPopup");
		}
		instance.SaveIfDirty();
		SocialManager instance2 = SocialManager.instance;
		instance2.SaveIfDirty();
	}

	private void _SetBackground(bool state)
	{
		//IL_0202: Expected Obj, but got I
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_01bf: Expected I, but got Obj
		//IL_025d: Expected I, but got Obj
		//IL_0054: Expected VT, but got Obj
		//IL_011b: Expected Obj, but got I
		//IL_0146: Expected I, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UI.Screens.UIScreen>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (state)
		{
			if (obj4 == null)
			{
				string path = "Prefabs/Screens/" + "NotebookPanel2";
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(GameObject));
				UnityEngine.Object obj5 = Resources.Load(path, typeFromHandle);
				bool flag = (object)obj5 == null;
				UnityEngine.Object prefab = null;
				if (!flag)
				{
					bool flag2 = (object)obj5.GetType() == typeof(GameObject);
					prefab = obj5;
					if (!flag2)
					{
						prefab = null;
					}
				}
				GameObject gameObject = NGUITools.AddChild(backgroundAnchor, (GameObject)prefab);
				string text = gameObject.name;
				string text2 = text.Replace("(Clone)", string.Empty);
				gameObject.name = text2;
				UIScreen component = gameObject.GetComponent<UIScreen>();
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UI.Screens.UIScreen>>)+5C]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v230 @ S5_v5+4] (should have been resolved before IL gen)");
				UIScreen uIScreen = _cachedScreens.get_Item("NotebookPanel2");
				nint num5 = (nint)uIScreen;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ S1_v40 (Il2CppClass<UI.Screens.UIScreen>)+DC] (should have been resolved before IL gen)");
			}
			UIScreen uIScreen2 = _cachedScreens.get_Item("NotebookPanel2");
			nint num6 = (nint)uIScreen2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ S1_v19 (Il2CppClass<UI.Screens.UIScreen>)+E4] (should have been resolved before IL gen)");
			if (mainCamera == null)
			{
				Camera main = Camera.main;
				mainCamera = main;
			}
			IEnumerator coroutine = DealyHideMainCamera();
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
		}
		else
		{
			if (obj4 != null)
			{
				UIScreen uIScreen3 = _cachedScreens.get_Item("NotebookPanel2");
				nint num7 = (nint)uIScreen3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S1_v14 (Il2CppClass<UI.Screens.UIScreen>)+EC] (should have been resolved before IL gen)");
			}
			if (mainCamera == null)
			{
				Camera main2 = Camera.main;
				mainCamera = main2;
			}
			mainCamera.enabled = true;
		}
	}

	private IEnumerator DealyHideMainCamera()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private UIScreen _LoadScreenToCache(string screenName, bool isPopup = false)
	{
		//IL_00c6: Expected VT, but got Obj
		//IL_002b: Expected VT, but got Obj
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I
		//IL_01ac: Expected I, but got Obj
		object parent;
		UnityEngine.Object prefab;
		if (!isPopup)
		{
			string path = "Prefabs/Screens/" + screenName;
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(GameObject));
			UnityEngine.Object obj = Resources.Load(path, typeFromHandle);
			bool flag = (object)obj == null;
			UnityEngine.Object obj2 = null;
			if (!flag)
			{
				bool flag2 = (object)obj.GetType() == typeof(GameObject);
				obj2 = obj;
				if (!flag2)
				{
					obj2 = null;
				}
			}
			parent = this + 116;
			prefab = obj2;
		}
		else
		{
			string path2 = "Prefabs/Popups/" + screenName;
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(GameObject));
			UnityEngine.Object obj3 = Resources.Load(path2, typeFromHandle2);
			bool flag3 = (object)obj3 == null;
			UnityEngine.Object obj4 = null;
			if (!flag3)
			{
				bool flag4 = (object)obj3.GetType() == typeof(GameObject);
				obj4 = obj3;
				if (!flag4)
				{
					obj4 = null;
				}
			}
			parent = this + 120;
			prefab = obj4;
		}
		GameObject gameObject = NGUITools.AddChild((GameObject)parent, (GameObject)prefab);
		string text = gameObject.name;
		string text2 = text.Replace("(Clone)", string.Empty);
		gameObject.name = text2;
		UIScreen component = gameObject.GetComponent<UIScreen>();
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UI.Screens.UIScreen>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ S5_v4+4] (should have been resolved before IL gen)");
		component.screenName = screenName;
		nint num3 = (nint)component;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ S1_v12 (Il2CppClass<UI.Screens.UIScreen>)+DC] (should have been resolved before IL gen)");
		return component;
	}

	public static bool ShouldShowOnlineScreen()
	{
		bool result = true;
		if (!Globals.DEBUG_USE_DEBUG_LOGIN_STATE)
		{
			SocialManager instance = SocialManager.instance;
			bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
			result = true;
			if (!facebookIsLoggedIn)
			{
				SocialManager instance2 = SocialManager.instance;
				bool flag = instance2._fbState == SocialManager.FacebookState.LoggingIn;
				result = true;
				if (!flag)
				{
					SocialManagerIOS instance3 = SocialManagerIOS.instance;
					bool flag2 = instance3._gcState != SocialManagerIOS.GCState.LoggedOut;
					result = flag2;
				}
			}
		}
		return result;
	}

	private string Peek(List<string> list)
	{
		if (list._size >= 1)
		{
			int index = list._size - 1;
			return list.get_Item(index);
		}
		return string.Empty;
	}

	private string Pop(List<string> list)
	{
		bool flag = list._size >= 1;
		bool flag2 = !flag;
		string result = string.Empty;
		if (!flag2)
		{
			int index = list._size - 1;
			string text = list.get_Item(index);
			int index2 = list._size - 1;
			list.RemoveAt(index2);
			result = text;
		}
		return result;
	}

	private string QueuePeek(List<string> list)
	{
		bool flag = list == null;
		string result = string.Empty;
		if (!flag)
		{
			bool flag2 = list._size < 1;
			result = string.Empty;
			if (!flag2)
			{
				string text = list.get_Item(0);
				result = text;
			}
		}
		return result;
	}

	private string Dequeue(List<string> list)
	{
		bool flag = list._size >= 1;
		bool flag2 = !flag;
		string result = string.Empty;
		if (!flag2)
		{
			string text = list.get_Item(0);
			list.RemoveAt(0);
			result = text;
		}
		return result;
	}

	public void ShowUnlockAnimationForCharacter(Characters.CharacterType ctype, int themeIndex = 0)
	{
		//IL_0041: Expected I4, but got I8
		CelebrationReward celebrationReward = default;
		celebrationReward._002Ector();
		celebrationReward.characterOutfitIndex = themeIndex;
		celebrationReward.characterType = ctype;
		celebrationReward.CelebrationRewardOrigin = CelebrationRewardOrigin.CharacterUnlock;
		RewardManager.AddRewardToUnlock(celebrationReward);
		QueueMysteryBox();
	}

	public void ShowUnlockAnimationForHoverboard(Hoverboards.BoardType boardType, Hoverboard.BoardAbility boardPower = Hoverboard.BoardAbility.None)
	{
		//IL_0041: Expected I4, but got I8
		CelebrationReward celebrationReward = default;
		celebrationReward._002Ector();
		celebrationReward.boardPower = boardPower;
		celebrationReward.boardType = boardType;
		celebrationReward.CelebrationRewardOrigin = CelebrationRewardOrigin.BoardUnlock;
		RewardManager.AddRewardToUnlock(celebrationReward);
		QueueMysteryBox();
	}

	public string GetCurrentPopupName()
	{
		return QueuePeek(_popupQueue);
	}

	public bool IsPopupQueueEmpty()
	{
		List<string> popupQueue = _popupQueue;
		return popupQueue._size < 1;
	}

	public bool IsPopupAlreadyQueued(string popupName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		bool flag2 = default;
		bool result;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		bool flag5 = default;
		bool flag7 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				bool flag = !flag2;
				result = flag2;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj6 != null)
						{
							result = flag2;
							break;
						}
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj7 == obj8;
			bool flag4 = !flag3;
			result = flag5;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag6 = (nint)0 != 1;
				result = false;
				if (flag6)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = flag7;
			}
			_ = 0;
			object obj9 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
		}
		object obj10 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
		return result;
	}

	public void PushPopup(string name)
	{
		_PushPopup(name);
	}

	public void PushPopup(GameObject sender)
	{
		UIButtonChangeScreen component = sender.GetComponent<UIButtonChangeScreen>();
		_PushPopup(component.ScreenNameToOpen);
	}

	private void _PushPopup(string name)
	{
		//IL_064b: Expected Obj, but got I4
		//IL_0414: Expected I, but got Obj
		//IL_0430: Expected I, but got Obj
		//IL_09f3: Expected Obj, but got I4
		//IL_062f: Expected Obj, but got I4
		//IL_098e: Expected I, but got Obj
		//IL_09aa: Expected I, but got Obj
		//IL_04e7: Expected I, but got Obj
		//IL_0503: Expected I, but got Obj
		//IL_0a43: Expected Obj, but got I
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected Obj, but got Unknown
		//IL_0483: Expected I, but got Obj
		//IL_049f: Expected I, but got Obj
		//IL_066c: Expected Obj, but got I
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected Obj, but got Unknown
		//IL_06aa: Expected Obj, but got I4
		//IL_054b: Expected I, but got Obj
		//IL_0567: Expected I, but got Obj
		//IL_05af: Expected I, but got Obj
		//IL_05cb: Expected I, but got Obj
		//IL_03b0: Expected I, but got Obj
		//IL_03cc: Expected I, but got Obj
		//IL_031a: Expected I, but got Obj
		//IL_00aa: Expected I, but got Obj
		//IL_00c6: Expected I, but got Obj
		//IL_06f3: Expected Obj, but got I4
		//IL_025c: Expected I, but got Obj
		//IL_0278: Expected I, but got Obj
		//IL_0173: Expected I, but got Obj
		//IL_018f: Expected I, but got Obj
		//IL_07ec: Expected Obj, but got I
		//IL_07f5: Expected Obj, but got I4
		//IL_0728: Expected Obj, but got I
		//IL_0738: Expected Obj, but got I
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a94: Expected Obj, but got Unknown
		//IL_0825: Expected Obj, but got I
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Expected Obj, but got Unknown
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Expected Obj, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected Obj, but got Unknown
		//IL_08e2: Expected Obj, but got I4
		//IL_0942: Expected Obj, but got I
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected I4, but got Unknown
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752");
		UIScreenController uIScreenController = default;
		if ((nint)uIScreenController <= -2006668647)
		{
			if ((nint)uIScreenController <= 1699271083)
			{
				if ((nint)uIScreenController != 1113936781)
				{
					if ((nint)uIScreenController == 1699271083 && name == "NotEnoughCurencyPopup")
					{
						NotEnoughCurencyPopup notEnoughCurencyPopup = NotEnoughCurencyPopup;
						nint num = (nint)notEnoughCurencyPopup;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v219 @ S1_v153 (Il2CppClass<NotEnoughCurencyPopup>)+DC] (should have been resolved before IL gen)");
						NotEnoughCurencyPopup notEnoughCurencyPopup2 = NotEnoughCurencyPopup;
						nint num2 = (nint)notEnoughCurencyPopup2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ S1_v156 (Il2CppClass<NotEnoughCurencyPopup>)+E4] (should have been resolved before IL gen)");
						return;
					}
				}
				else if (name == "ShopScreen")
				{
					if (screen_game == SCREEN_GAME.GAME)
					{
						GameOverScreen.GameActive(value: false);
					}
					ShopScreen shopScreen = ShopScreen;
					shopScreen.CureentScreen = _Screen;
					nint num3 = (nint)shopScreen;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v255 @ S1_v143 (Il2CppClass<UI.Screens.ShopScreen>)+DC] (should have been resolved before IL gen)");
					ShopScreen shopScreen2 = ShopScreen;
					nint num4 = (nint)shopScreen2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v265 @ S1_v146 (Il2CppClass<UI.Screens.ShopScreen>)+E4] (should have been resolved before IL gen)");
					return;
				}
			}
			else if ((nint)uIScreenController != -2006668647)
			{
				if ((nint)uIScreenController != 1745664438)
				{
					if ((nint)uIScreenController == 1826641713 && name == "CountryPopup")
					{
						CloseActivePopups("SettingsPopup");
						CountryPopup countryPopup = CountryPopup;
						nint num5 = (nint)countryPopup;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v450 @ S1_v130 (Il2CppClass<CountryPopup>)+DC] (should have been resolved before IL gen)");
						CountryPopup countryPopup2 = CountryPopup;
						nint num6 = (nint)countryPopup2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v458 @ S1_v133 (Il2CppClass<CountryPopup>)+E4] (should have been resolved before IL gen)");
						return;
					}
				}
				else if (name == "LeaderboardPopup")
				{
					LeaderboardPopup leaderboardPopup = LeaderboardPopup;
					nint num7 = (nint)leaderboardPopup;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v275 @ S1_v119 (Il2CppClass<UI.Screens.LeaderboardPopup>)+DC] (should have been resolved before IL gen)");
					LeaderboardPopup leaderboardPopup2 = LeaderboardPopup;
					nint num8 = (nint)leaderboardPopup2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v285 @ S1_v122 (Il2CppClass<UI.Screens.LeaderboardPopup>)+E4] (should have been resolved before IL gen)");
					return;
				}
			}
			else if (name == "MissionPopup")
			{
				MissionPopup missionPopup = MissionPopup;
				nint num9 = (nint)missionPopup;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ S1_v110 (Il2CppClass<MissionPopup>)+DC] (should have been resolved before IL gen)");
				MissionPopup missionPopup2 = MissionPopup;
				nint num10 = (nint)missionPopup2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ S1_v113 (Il2CppClass<MissionPopup>)+E4] (should have been resolved before IL gen)");
				return;
			}
		}
		else if ((nint)uIScreenController <= -1600195253)
		{
			if ((nint)uIScreenController != -1817846022)
			{
				if ((nint)uIScreenController != -1766908518)
				{
					if ((nint)uIScreenController == -1600195253 && name == "HoverboardPopup")
					{
						HoverboardPopup hoverboardPopup = HoverboardPopup;
						nint num11 = (nint)hoverboardPopup;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v390 @ S1_v100 (Il2CppClass<HoverboardPopup>)+DC] (should have been resolved before IL gen)");
						HoverboardPopup hoverboardPopup2 = HoverboardPopup;
						nint num12 = (nint)hoverboardPopup2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v398 @ S1_v103 (Il2CppClass<HoverboardPopup>)+E4] (should have been resolved before IL gen)");
						return;
					}
				}
				else if (name == "ItemmHuntPopup")
				{
					ItemHuntPopup itemHuntPopup = ItemHuntPopup;
					nint num13 = (nint)itemHuntPopup;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v355 @ S1_v91 (Il2CppClass<ItemHuntPopup>)+DC] (should have been resolved before IL gen)");
					ItemHuntPopup itemHuntPopup2 = ItemHuntPopup;
					nint num14 = (nint)itemHuntPopup2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v363 @ S1_v94 (Il2CppClass<ItemHuntPopup>)+E4] (should have been resolved before IL gen)");
					return;
				}
			}
			else if (!(name != "SettingsPopup"))
			{
				SettingsPopup settingsPopup = SettingsPopup;
				nint num15 = (nint)settingsPopup;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ S1_v82 (Il2CppClass<UI.Screens.SettingsPopup>)+DC] (should have been resolved before IL gen)");
				SettingsPopup settingsPopup2 = SettingsPopup;
				nint num16 = (nint)settingsPopup2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v182 @ S1_v85 (Il2CppClass<UI.Screens.SettingsPopup>)+E4] (should have been resolved before IL gen)");
				return;
			}
		}
		else if ((nint)uIScreenController != -1323490229)
		{
			if ((nint)uIScreenController != -102990841)
			{
				if ((nint)uIScreenController == -68414861 && name == "PrizeMBPopup_Keys")
				{
					PrizeMBPopup prizeMBPopup_Keys = PrizeMBPopup_Keys;
					nint num17 = (nint)prizeMBPopup_Keys;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v403 @ S1_v76 (Il2CppClass<PrizeMBPopup>)+E4] (should have been resolved before IL gen)");
					return;
				}
			}
			else if (name == "DailyChallengePopup")
			{
				DailyChallengeScreen dailyChallengeScreen = DailyChallengeScreen;
				nint num18 = (nint)dailyChallengeScreen;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v369 @ S1_v67 (Il2CppClass<DailyChallengeScreen>)+DC] (should have been resolved before IL gen)");
				DailyChallengeScreen dailyChallengeScreen2 = DailyChallengeScreen;
				nint num19 = (nint)dailyChallengeScreen2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v377 @ S1_v70 (Il2CppClass<DailyChallengeScreen>)+E4] (should have been resolved before IL gen)");
				return;
			}
		}
		else if (name == "MeScreen")
		{
			MeScreen meScreen = MeScreen;
			nint num20 = (nint)meScreen;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v195 @ S1_v57 (Il2CppClass<UI.Screens.MeScreen>)+DC] (should have been resolved before IL gen)");
			MeScreen meScreen2 = MeScreen;
			nint num21 = (nint)meScreen2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v205 @ S1_v60 (Il2CppClass<UI.Screens.MeScreen>)+E4] (should have been resolved before IL gen)");
			ActivateAnchors(active: true);
			return;
		}
		string text = uIScreenController.QueuePeek(_popupQueue);
		object obj;
		if (text != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_09ea;
			}
		}
		obj = 1;
		goto IL_09ea;
		IL_09ea:
		object obj2 = -1;
		UIScreenController uIScreenController2 = uIScreenController;
		if (obj == null)
		{
			nint num22 = 0;
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S3_v19 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UI.Screens.UIScreen>>)+54]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v418 @ S3_v20+4] (should have been resolved before IL gen)");
			object obj5 = default;
			object obj4 = obj5 ^ -1;
			object obj6 = obj4 >> 31;
			bool flag = obj6 == null;
			obj2 = -1;
			uIScreenController2 = uIScreenController;
			if (!flag)
			{
				UIScreen uIScreen = _cachedScreens.get_Item(text);
				UIPanel[] componentsInChildren = uIScreen.GetComponentsInChildren<UIPanel>(includeInactive: true);
				obj2 = -1;
				uIScreenController2 = null;
				while ((nint)uIScreenController2 < componentsInChildren.Length)
				{
					object obj7 = (object)uIScreenController2 << 2;
					object obj8 = (object)componentsInChildren + obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ S0_v82+10]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S0_v83+E0]");
					object obj10 = 0;
					object obj11 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S0_v83+E0]");
					if ((nint)obj11 >= 0)
					{
						obj10 = obj2;
					}
					UIScreenController uIScreenController3 = (UIScreenController)(uIScreenController2 + 1);
					obj2 = obj10;
					uIScreenController2 = uIScreenController3;
				}
			}
		}
		_popupQueue.Insert(0, name);
		_ActivateNextPopup(text);
		nint num24 = 0;
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S3_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UI.Screens.UIScreen>>)+54]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v489 @ S3_v7+4] (should have been resolved before IL gen)");
		object obj14 = default;
		object obj13 = obj14 ^ -1;
		object obj15 = obj13 >> 31;
		if (obj15 == null)
		{
			return;
		}
		UIScreen uIScreen2 = _cachedScreens.get_Item(name);
		nint num26 = 0;
		nint num27 = 0;
		IntPtr intPtr = num27;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v546 @ S3_v12 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		object obj16 = default;
		if (obj16 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S0_v27+C]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S0_v27+10]");
		UnityEngine.Object obj17 = (UnityEngine.Object)0;
		object obj18 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S0_v27+C]");
			if (0 <= (nint)obj18)
			{
				break;
			}
			object obj19 = obj18 << 2;
			object obj20 = obj16 + obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S0_v61+10]");
			UnityEngine.Object obj21 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ S0_v63 (UnityEngine.Object)+E0]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ L1_v3 (UnityEngine.Object)+E0]");
			if (num28 >= 0)
			{
				obj21 = obj17;
			}
			object obj22 = obj18 + 1;
			obj17 = obj21;
			obj18 = obj22;
		}
		bool flag2 = obj17 != null;
		if ((nint)obj2 < 0 || !flag2)
		{
			return;
		}
		object obj23 = obj2 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ L1_v3 (UnityEngine.Object)+E0]");
		object obj24 = obj23 - 0;
		bool flag3 = (nint)obj24 < 0;
		object obj25 = 0;
		if (flag3)
		{
			return;
		}
		while (true)
		{
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S0_v27+C]");
			if ((nint)obj26 < 0)
			{
				object obj27 = obj25 << 2;
				object obj28 = obj16 + obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ S0_v56+10]");
				UIPanel uIPanel = (UIPanel)0;
				int depth = obj24 + uIPanel.mDepth;
				uIPanel.depth = depth;
				object obj29 = obj25 + 1;
				obj25 = obj29;
				continue;
			}
			break;
		}
	}

	private void _QueuePopup(string name)
	{
		//IL_014a: Expected I, but got Obj
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0174: Expected I, but got Obj
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01c1: Expected I, but got Obj
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01eb: Expected I, but got Obj
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0216: Expected I, but got Obj
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_0240: Expected I, but got Obj
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_026b: Expected I, but got Obj
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0295: Expected I, but got Obj
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_03cc: Expected I, but got Obj
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03f6: Expected I, but got Obj
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		if (!(name == "AgeRestrictionPopup"))
		{
			if (name != "SaveMePopup")
			{
				if (name != "HomeConfirmationPopup")
				{
					if (name != "ConsumablesPopup")
					{
						if (name == "CelebrationPopup")
						{
							object obj = CurrenScreen - 4;
							if (CurrenScreen != SCREEN.Shop)
							{
								if ((nint)obj != 1 && (nint)obj != 2 && (nint)obj != 3 && (nint)obj == 4)
								{
									MeScreen.HidePupUp();
								}
							}
							else
							{
								ShopScreen.HidePupUp();
							}
							ActivateAnchors(active: false);
							if (screen_game == SCREEN_GAME.GAME)
							{
								int rewardsToUnlockCount = RewardManager.rewardsToUnlockCount;
								if (rewardsToUnlockCount >= 1)
								{
									RewardManager.canShowMultipleQueuedCelebrations = true;
								}
							}
							CelebrationPopup celebrationPopup = CelebrationPopup;
							nint num = (nint)celebrationPopup;
							object obj2 = celebrationPopup + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ S1_v61 (Il2CppClass<CelebrationPopup>)+DC] (should have been resolved before IL gen)");
							CelebrationPopup celebrationPopup2 = CelebrationPopup;
							nint num2 = (nint)celebrationPopup2;
							object obj3 = celebrationPopup2 + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ S1_v65 (Il2CppClass<CelebrationPopup>)+E4] (should have been resolved before IL gen)");
						}
						else
						{
							messageHelper.DisableShowLabel();
							_popupQueue.Add(name);
							if (~(_popupActive ? 1u : 0u) != 0)
							{
								_ActivateNextPopup(string.Empty);
							}
						}
					}
					else
					{
						ConsumablesPopup consumablesPopup = ConsumablesPopup;
						nint num3 = (nint)consumablesPopup;
						object obj4 = consumablesPopup + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ S1_v39 (Il2CppClass<ConsumablesPopup>)+DC] (should have been resolved before IL gen)");
						ConsumablesPopup consumablesPopup2 = ConsumablesPopup;
						nint num4 = (nint)consumablesPopup2;
						object obj5 = consumablesPopup2 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v169 @ S1_v43 (Il2CppClass<ConsumablesPopup>)+E4] (should have been resolved before IL gen)");
					}
				}
				else
				{
					HomeConfirmationPopup homeConfirmationPopup = HomeConfirmationPopup;
					nint num5 = (nint)homeConfirmationPopup;
					object obj6 = homeConfirmationPopup + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v135 @ S1_v29 (Il2CppClass<UI.Popups.HomeConfirmationPopup>)+DC] (should have been resolved before IL gen)");
					HomeConfirmationPopup homeConfirmationPopup2 = HomeConfirmationPopup;
					nint num6 = (nint)homeConfirmationPopup2;
					object obj7 = homeConfirmationPopup2 + 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ S1_v33 (Il2CppClass<UI.Popups.HomeConfirmationPopup>)+E4] (should have been resolved before IL gen)");
				}
			}
			else
			{
				SaveMePopup saveMePopup = SaveMePopup;
				nint num7 = (nint)saveMePopup;
				object obj8 = saveMePopup + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ S1_v19 (Il2CppClass<SaveMePopup>)+DC] (should have been resolved before IL gen)");
				SaveMePopup saveMePopup2 = SaveMePopup;
				nint num8 = (nint)saveMePopup2;
				object obj9 = saveMePopup2 + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v120 @ S1_v23 (Il2CppClass<SaveMePopup>)+E4] (should have been resolved before IL gen)");
			}
		}
		else
		{
			AgeRestrictionPopup ageRestrictionPopup = AgeRestrictionPopup;
			nint num9 = (nint)ageRestrictionPopup;
			object obj10 = ageRestrictionPopup + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S1_v5 (Il2CppClass<UI.Popups.AgeRestrictionPopup>)+DC] (should have been resolved before IL gen)");
			AgeRestrictionPopup ageRestrictionPopup2 = AgeRestrictionPopup;
			nint num10 = (nint)ageRestrictionPopup2;
			object obj11 = ageRestrictionPopup2 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S1_v9 (Il2CppClass<UI.Popups.AgeRestrictionPopup>)+E4] (should have been resolved before IL gen)");
			AgeRestrictionPopup ageRestrictionPopup3 = AgeRestrictionPopup;
			object obj12 = ageRestrictionPopup3 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S1_v14+BC] (should have been resolved before IL gen)");
		}
	}

	private void _ActivateNextPopup(string oldPopupName = "")
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected I, but got Unknown
		//IL_009e: Expected Obj, but got I
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected Obj, but got Unknown
		//IL_034a: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I4
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected Obj, but got Unknown
		//IL_07ec: Expected Obj, but got I
		//IL_0500: Expected Obj, but got I
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		//IL_04cb: Expected Obj, but got I4
		//IL_04af: Expected Obj, but got I4
		//IL_09f9: Expected I, but got Obj
		//IL_0678: Expected I, but got Obj
		object obj = default;
		UIScreenController uIScreenController = (UIScreenController)(obj - 48);
		uIScreenController.HoverboardPopup = null;
		uIScreenController.MeScreen = null;
		List<string> popupQueue = _popupQueue;
		UIScreenController uIScreenController2 = default;
		string text2;
		if (popupQueue._size >= 1)
		{
			string text = uIScreenController.QueuePeek(_popupQueue);
			object obj2 = uIScreenController + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			uIScreenController.HoverboardPopup = (HoverboardPopup)(object)uIScreenController.CountryPopup;
			uIScreenController.MeScreen = (MeScreen)(object)uIScreenController.FrontScreen;
			nint cachedPtr = (nint)(uIScreenController + 32);
			((UnityEngine.Object)uIScreenController).m_CachedPtr = cachedPtr;
			uIScreenController.FrontScreen = null;
			uIScreenController.SettingsPopup = (SettingsPopup)(nint)((UnityEngine.Object)uIScreenController).m_CachedPtr;
			object obj4 = default;
			object obj5 = default;
			object obj6 = default;
			object obj7 = default;
			object obj8 = default;
			object obj10 = default;
			object frontScreen = default;
			object obj11 = default;
			object obj16 = default;
			while (true)
			{
				_ = 0;
				object obj3 = uIScreenController + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj4 == null)
					{
						goto IL_0435;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj5 == null)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v204+21]");
								if ((nint)0 == 0)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj6 != null)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj7 != obj8;
				object obj9 = obj10;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					uIScreenController.FrontScreen = (FrontScreen)frontScreen;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_0435;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj9 = obj11;
				}
				_ = 0;
				object obj12 = uIScreenController + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				uIScreenController2 = (UIScreenController)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					text2 = text;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
				IL_0937:
				object obj13;
				string topScreenName;
				if (obj13 == null)
				{
					EnableBackButton(topScreenName, enable: false);
				}
				goto IL_04e4;
				IL_04e4:
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S3_v12 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UI.Screens.UIScreen>>)+54]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v347 @ S3_v13+4] (should have been resolved before IL gen)");
				object obj15 = obj16 ^ -1;
				object obj17 = obj15 >> 31;
				if (obj17 == null)
				{
					UIScreen uIScreen = _LoadScreenToCache(text, isPopup: true);
				}
				if (text == "CelebrationPopup")
				{
					List<string> screenStack = _screenStack;
					if (screenStack._size >= 1)
					{
						List<string> screenStack2 = _screenStack;
						int index = screenStack2._size - 1;
						string text3 = screenStack2.get_Item(index);
						if (text3 == "GameoverUI")
						{
							RewardManager.canShowMultipleQueuedCelebrations = true;
						}
						List<string> screenStack3 = _screenStack;
						int index2 = screenStack3._size - 1;
						string text4 = screenStack3.get_Item(index2);
						if (text4 != "GameoverUI")
						{
							List<string> screenStack4 = _screenStack;
							int index3 = screenStack4._size - 1;
							string key = screenStack4.get_Item(index3);
							UIScreen uIScreen2 = _cachedScreens.get_Item(key);
							nint num3 = (nint)uIScreen2;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v594 @ S1_v89 (Il2CppClass<UI.Screens.UIScreen>)+EC] (should have been resolved before IL gen)");
						}
					}
				}
				UIScreen uIScreen3 = _cachedScreens.get_Item(text);
				if (uIScreen3 != null && !uIScreen3._isActive)
				{
					if (oldPopupName != string.Empty)
					{
						uIScreen3.parentScreen__BackingField = oldPopupName;
					}
					nint num4 = (nint)uIScreen3;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v582 @ S1_v66 (Il2CppClass<UI.Screens.UIScreen>)+E4] (should have been resolved before IL gen)");
				}
				_popupActive = true;
				if (DeviceUtility.hasPhysicalBackButton && text != "CelebrationPopup" && text != "AgeRestrictionPopup")
				{
					AddBackButtonBehavior(text);
				}
				Action<string> onChangedScreen = OnChangedScreen;
				bool flag2 = OnChangedScreen == null;
				text2 = text;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v563 @ S0_v95 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
					text2 = text;
				}
				break;
				IL_0435:
				object obj18 = uIScreenController + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
				ActivateAnchors(active: false);
				if (!DeviceUtility.hasPhysicalBackButton)
				{
					goto IL_04e4;
				}
				topScreenName = GetTopScreenName();
				if (topScreenName != null)
				{
					obj13 = 0;
					if (topScreenName._stringLength != 0)
					{
						goto IL_0937;
					}
				}
				obj13 = 1;
				goto IL_0937;
			}
			goto IL_0908;
		}
		ActivateAnchors(active: true);
		if (!DeviceUtility.hasPhysicalBackButton)
		{
			goto IL_0363;
		}
		string topScreenName2 = GetTopScreenName();
		object obj19;
		if (topScreenName2 != null)
		{
			obj19 = 0;
			if (topScreenName2._stringLength != 0)
			{
				goto IL_08fa;
			}
		}
		obj19 = 1;
		goto IL_08fa;
		IL_08fa:
		if (obj19 == null)
		{
			EnableBackButton(topScreenName2, enable: true);
		}
		goto IL_0363;
		IL_0363:
		text2 = string.Empty;
		goto IL_0908;
		IL_0908:
		Action<string> onPopupShown = uIScreenController2.m_OnPopupShown;
		if (uIScreenController2.m_OnPopupShown != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v188 @ S0_v20 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void EnableBackButton(string screenName, bool enable)
	{
		UIScreen uIScreen = _cachedScreens.get_Item(screenName);
		if (uIScreen != null)
		{
			GameObject gameObject = uIScreen.gameObject;
			BackBtnBehaviour component = gameObject.GetComponent<BackBtnBehaviour>();
			if (component != null)
			{
				component.enabled = enable;
			}
		}
	}

	public void ActivateAnchors(bool active)
	{
		UIModelController instance = UIModelController.Instance;
		NGUITools.SetActive(instance.CharacterAnchor, active);
		UIModelController instance2 = UIModelController.Instance;
		NGUITools.SetActive(instance2.GameOverAnchor, active);
		UIModelController instance3 = UIModelController.Instance;
		NGUITools.SetActive(instance3.CelebrationPopupAnchor, active);
		UIModelController instance4 = UIModelController.Instance;
		NGUITools.SetActive(instance4.PauseScreenAnchor, active);
		bool pause = (byte)((active ? 1u : 0u) ^ 1u) != 0;
		Transform trans = MenuElements3D.transform;
		_PauseAnimations(pause, trans);
	}

	public static void QueueFacebookPayoutPopup()
	{
		_facebookPayoutPopupQueued = true;
		if (IsInstanced)
		{
			UIScreenController instance = Instance;
			instance.TryQueuePayoutPopups();
		}
	}

	public static void QueueGameCenterPayoutPopup()
	{
		_gameCenterPayoutPopupQueued = true;
		if (IsInstanced)
		{
			UIScreenController instance = Instance;
			instance.TryQueuePayoutPopups();
		}
	}

	private void TryQueuePayoutPopups()
	{
		if (~(_facebookPayoutPopupQueued ? 1u : 0u) != 0 && ~(_gameCenterPayoutPopupQueued ? 1u : 0u) != 0)
		{
			return;
		}
		List<string> screenStack = _screenStack;
		if (_screenStack == null || screenStack._size < 1)
		{
			return;
		}
		string item = Peek(_screenStack);
		if (PAYOUT_DISALLOWED_SCREENS.Contains(item))
		{
			return;
		}
		if (~(_facebookPayoutPopupQueued ? 1u : 0u) == 0)
		{
			if (!IsPopupAlreadyQueued("FacebookRewardsPopup"))
			{
				QueuePopup("FacebookRewardsPopup");
			}
			_facebookPayoutPopupQueued = false;
		}
		if (~(_gameCenterPayoutPopupQueued ? 1u : 0u) != 0)
		{
			return;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		if (~(instance._isTutorialCompleted ? 1u : 0u) == 0)
		{
			if (!IsPopupAlreadyQueued("GameCenterPayoutPopup"))
			{
				QueuePopup("GameCenterPayoutPopup");
			}
			_gameCenterPayoutPopupQueued = false;
		}
	}

	public void QueuePopupRightAfterCurrentActivePopup(string popupName)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		string text = QueuePeek(_popupQueue);
		object obj;
		if (text != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_007c;
			}
		}
		obj = 1;
		goto IL_007c;
		IL_007c:
		if (obj == null)
		{
			_popupQueue.Insert(1, popupName);
		}
		else
		{
			_QueuePopup(popupName);
		}
	}

	public void QueuePopup(string popupName)
	{
		_QueuePopup(popupName);
	}

	public void QueuePopup(GameObject sender)
	{
		UIButtonChangeScreen component = sender.GetComponent<UIButtonChangeScreen>();
		_QueuePopup(component.ScreenNameToOpen);
	}

	public void QueueMysteryBox()
	{
		List<string> popupQueue = _popupQueue;
		if (popupQueue._size >= 1)
		{
			string text = QueuePeek(_popupQueue);
			if (!(text != "CelebrationPopup"))
			{
				return;
			}
		}
		_QueuePopup("CelebrationPopup");
	}

	public void HideScreen(SCREEN screen)
	{
	}

	public void CloseActivePopups(string popupToStopAt)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected Obj, but got Unknown
		//IL_0d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d74: Expected Obj, but got Unknown
		//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10db: Expected Obj, but got Unknown
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got Unknown
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected Obj, but got Unknown
		//IL_108d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1092: Expected Obj, but got Unknown
		//IL_08ce: Expected I, but got Obj
		//IL_08e8: Expected Obj, but got I4
		//IL_0f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6b: Expected Obj, but got Unknown
		//IL_060a: Expected Obj, but got I4
		//IL_0177: Expected I, but got Obj
		//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Expected Obj, but got Unknown
		//IL_0fe9: Expected Obj, but got I
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Expected Obj, but got Unknown
		//IL_00e3: Expected I, but got Obj
		//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc6: Expected Obj, but got Unknown
		//IL_0dfd: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752");
		object obj3 = default;
		if ((nint)obj3 <= -2006668647)
		{
			if ((nint)obj3 <= 1343889753)
			{
				if ((nint)obj3 <= 444927868)
				{
					if ((nint)obj3 != 118448015)
					{
						if ((nint)obj3 == 444927868 && popupToStopAt == "AgeRestrictionPopup")
						{
							AgeRestrictionPopup ageRestrictionPopup = AgeRestrictionPopup;
							nint num = (nint)ageRestrictionPopup;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v307 @ S1_v216 (Il2CppClass<UI.Popups.AgeRestrictionPopup>)+F4] (should have been resolved before IL gen)");
							AgeRestrictionPopup.HidePupUp();
							return;
						}
					}
					else if (popupToStopAt == "CelebrationPopup")
					{
						CelebrationPopup celebrationPopup = CelebrationPopup;
						nint num2 = (nint)celebrationPopup;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v235 @ S1_v202 (Il2CppClass<CelebrationPopup>)+EC] (should have been resolved before IL gen)");
						object obj4 = OldScreen - 4;
						if (OldScreen != SCREEN.Shop)
						{
							if ((nint)obj4 != 1 && (nint)obj4 != 2 && (nint)obj4 != 3)
							{
								if ((nint)obj4 == 4)
								{
									_PushPopup("MeScreen");
									ActivateAnchors(active: true);
								}
								else if (OldScreen == SCREEN.Gameover)
								{
									ActivateAnchors(active: true);
								}
							}
						}
						else
						{
							_PushPopup("ShopScreen");
						}
						return;
					}
				}
				else if ((nint)obj3 != 1113936781)
				{
					if ((nint)obj3 == 1343889753 && popupToStopAt == "GameOverScreen")
					{
						GameOverScreen gameOverScreen = GameOverScreen;
						nint num3 = (nint)gameOverScreen;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v331 @ S1_v196 (Il2CppClass<GameOverScreen>)+EC] (should have been resolved before IL gen)");
						return;
					}
				}
				else if (popupToStopAt == "ShopScreen")
				{
					if (screen_game != SCREEN_GAME.MENU)
					{
						if (screen_game == SCREEN_GAME.GAME)
						{
							object obj5 = CurrenScreen - 21;
							if (CurrenScreen != SCREEN.Gameover)
							{
								if ((nint)obj5 != 1)
								{
									if ((nint)obj5 != 2)
									{
										if (CurrenScreen == SCREEN.Shop)
										{
											GameOverScreen.GameActive(value: true);
											ActivateAnchors(active: true);
										}
									}
									else
									{
										GameOverScreen.GameActive(value: false);
										ActivateAnchors(active: true);
									}
								}
							}
							else
							{
								ActivateAnchors(active: true);
							}
						}
					}
					else
					{
						UIScreen uIScreen = _ActivateScreen("FrontUI");
					}
					ShopScreen.HidePupUp();
					return;
				}
			}
			else if ((nint)obj3 <= 1699271083)
			{
				if ((nint)obj3 != 1469991027)
				{
					if ((nint)obj3 == 1699271083 && popupToStopAt == "NotEnoughCurencyPopup")
					{
						NotEnoughCurencyPopup.HidePupUp();
						return;
					}
				}
				else if (popupToStopAt == "PauseUI")
				{
					PauseScreen.HidePupUp();
					return;
				}
			}
			else if ((nint)obj3 != -2006668647)
			{
				if ((nint)obj3 != 1745664438)
				{
					if ((nint)obj3 == 1826641713 && popupToStopAt == "CountryPopup")
					{
						CountryPopup.HidePupUp();
						return;
					}
				}
				else if (popupToStopAt == "LeaderboardPopup")
				{
					LeaderboardPopup.HidePupUp();
					return;
				}
			}
			else if (popupToStopAt == "MissionPopup")
			{
				MissionPopup.HidePupUp();
				return;
			}
		}
		else if ((nint)obj3 <= -1323490229)
		{
			if ((nint)obj3 <= -1817846022)
			{
				if ((nint)obj3 != -1840938310)
				{
					if ((nint)obj3 == -1817846022 && popupToStopAt == "SettingsPopup")
					{
						SettingsPopup.HidePupUp();
						return;
					}
				}
				else if (!(popupToStopAt != "FrontUI"))
				{
					goto IL_106e;
				}
			}
			else if ((nint)obj3 != -1766908518)
			{
				if ((nint)obj3 != -1600195253)
				{
					if ((nint)obj3 == -1323490229 && popupToStopAt == "MeScreen")
					{
						MeScreen.HidePupUp();
						if (screen_game == SCREEN_GAME.MENU)
						{
							UIScreen uIScreen2 = _ActivateScreen("FrontUI");
						}
						return;
					}
				}
				else if (popupToStopAt == "HoverboardPopup")
				{
					HoverboardPopup.HidePupUp();
					return;
				}
			}
			else if (popupToStopAt == "ItemmHuntPopup")
			{
				ItemHuntPopup.HidePupUp();
				return;
			}
		}
		else if ((nint)obj3 <= -182885045)
		{
			if ((nint)obj3 != -287092856)
			{
				if ((nint)obj3 == -182885045 && popupToStopAt == "ConsumablesPopup")
				{
					ConsumablesPopup.HidePupUp();
					return;
				}
			}
			else if (popupToStopAt == "SaveMePopup")
			{
				SaveMePopup.HidePupUp();
				return;
			}
		}
		else if ((nint)obj3 != -102990841)
		{
			if ((nint)obj3 != -68414861)
			{
				if ((nint)obj3 == -25949153 && popupToStopAt == "HomeConfirmationPopup")
				{
					HomeConfirmationPopup.HidePupUp();
					return;
				}
			}
			else if (popupToStopAt == "PrizeMBPopup_Keys")
			{
				PrizeMBPopup_Keys.HidePupUp();
				CelebrationPopup.OnPopClosed("PrizeMBPopup_Keys");
				return;
			}
		}
		else if (popupToStopAt == "DailyChallengePopup")
		{
			DailyChallengeScreen.HidePupUp();
			return;
		}
		List<string> list = default;
		list._002Ector();
		if (!_popupQueue.Contains(popupToStopAt))
		{
			goto IL_0d34;
		}
		object obj6 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj7 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		object obj14 = default;
		object obj15 = default;
		while (true)
		{
			_ = 0;
			object obj8 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj9 == null)
				{
					goto IL_0d17;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ S0_v161+21]");
						if ((nint)0 == 0)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj10 == null)
								{
									continue;
								}
								goto IL_0d17;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj11 != obj12;
			object obj13 = obj14;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0d17;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj13 = obj15;
			break;
			IL_0d17:
			object obj16 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
			goto IL_0d34;
		}
		_ = 0;
		object obj17 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag2 = (nint)0 == 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		UIScreenController uIScreenController = (UIScreenController)0;
		if (flag2)
		{
			goto IL_0ff7;
		}
		goto IL_1021;
		IL_0d34:
		object obj18 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj19 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj21 = default;
		object obj22 = default;
		object obj23 = default;
		object obj24 = default;
		object obj25 = default;
		while (true)
		{
			_ = 0;
			object obj20 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj21 == null)
				{
					goto IL_0f5d;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj22 != obj23;
			object obj13 = obj24;
			if (flag3)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0f5d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj13 = obj25;
			break;
			IL_0f5d:
			object obj26 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
			return;
		}
		_ = 0;
		object obj27 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag4 = (nint)0 != 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		uIScreenController = (UIScreenController)0;
		if (!flag4)
		{
			goto IL_0ff7;
		}
		goto IL_1021;
		IL_106e:
		FrontScreen.HidePupUp();
		return;
		IL_1021:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_0ff7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_106e;
	}

	public void ClosePopup(GameObject go = null)
	{
		_RemovePopup(string.Empty);
	}

	public void DebugCloseAllPopups()
	{
		List<string> popupQueue = _popupQueue;
		int num = popupQueue._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 > -1)
			{
				string screenName = _popupQueue.get_Item(num2);
				_RemovePopup(screenName);
				num = num2;
				continue;
			}
			break;
		}
	}

	private void _PauseAnimations(bool pause, Transform trans)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_028b: Expected Obj, but got I
		//IL_016d: Expected I, but got Obj
		object obj = default;
		UIScreenController uIScreenController = (UIScreenController)(obj - 32);
		uIScreenController.CountryPopup = null;
		IEnumerator enumerator = trans.GetEnumerator();
		uIScreenController.ShopScreen = (ShopScreen)enumerator;
		object obj2 = uIScreenController + 24;
		object obj3 = uIScreenController + 28;
		uIScreenController = (UIScreenController)obj3;
		((UnityEngine.Object)uIScreenController).m_CachedPtr = (IntPtr)0;
		uIScreenController.AgeRestrictionPopup = (AgeRestrictionPopup)(object)uIScreenController;
		object obj4 = default;
		object obj5 = default;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		UIScreenController uIScreenController2 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj4 == null)
				{
					goto IL_01ad;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_0116;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0116;
			IL_0116:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj5 != obj6;
			object obj7 = obj8;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				((UnityEngine.Object)uIScreenController).m_CachedPtr = (IntPtr)obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_01ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj7 = obj10;
			}
			_ = 0;
			object obj11 = uIScreenController + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			uIScreenController2 = (UIScreenController)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
			IL_01ad:
			object obj12 = uIScreenController + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			CharacterModel component = trans.GetComponent<CharacterModel>();
			if (component != null)
			{
				if (!pause)
				{
					break;
				}
				CharacterModel component2 = trans.GetComponent<CharacterModel>();
				component2.StopIdleAnimations();
			}
			return;
		}
		string text = uIScreenController.Peek(uIScreenController2._screenStack);
		if (text == "BoardScreen")
		{
			HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
			instance.ResetTeleportFX();
		}
		else
		{
			CharacterModel component3 = trans.GetComponent<CharacterModel>();
			component3.StartIdleAnimations(UIModelController.ModelScreen.Character);
		}
	}

	public void SaveAndDelayPopups()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		doSaveAndDelayRemainingPopups = false;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		UIScreenController uIScreenController = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 == obj8;
			bool flag2 = !flag;
			object obj9 = obj10;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			uIScreenController = (UIScreenController)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
		((List<T>)(object)uIScreenController._popupQueue).Clear();
	}

	public void RequeueDelayedPopups()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		UIScreenController uIScreenController = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 == obj8;
			bool flag2 = !flag;
			object obj9 = obj10;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			uIScreenController = (UIScreenController)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
		((List<T>)(object)uIScreenController._delayedPopups).Clear();
	}

	private void _RemovePopup(string screenName = "")
	{
		//IL_010f: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0378: Expected I, but got Obj
		List<string> popupQueue = _popupQueue;
		if (popupQueue._size < 1)
		{
			return;
		}
		string text = default;
		string text2 = default;
		if (text == string.Empty)
		{
			text2 = Dequeue(_popupQueue);
		}
		else
		{
			bool flag = _popupQueue.Remove(text);
		}
		if (text2 == "FacebookRewardsPopup")
		{
			UIScreen uIScreen = _cachedScreens.get_Item(text2);
			GameObject gameObject = uIScreen.gameObject;
			FacebookRewardsPopup component = gameObject.GetComponent<FacebookRewardsPopup>();
			if (component != null)
			{
				component.OnBackBtnClicked();
			}
		}
		UIScreen uIScreen2 = _cachedScreens.get_Item(text2);
		nint num = (nint)uIScreen2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ S1_v14 (Il2CppClass<UI.Screens.UIScreen>)+EC] (should have been resolved before IL gen)");
		uIScreen2.parentScreen__BackingField = string.Empty;
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UI.Screens.UIScreen>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ S3_v5+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			List<string> popupQueue2 = _popupQueue;
			if (popupQueue2._size == 0)
			{
				BoardScreenManager instance = BoardScreenManager.Instance;
				instance.willResetBoardAnimation__BackingField = true;
			}
		}
		Action<string> onPopupClosed = this.m_OnPopupClosed;
		if (this.m_OnPopupClosed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v173 @ S0_v34 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
		_popupActive = false;
		List<string> popupQueue3 = _popupQueue;
		if (popupQueue3._size == 0)
		{
			Action<string> onChangedScreen = OnChangedScreen;
			if (OnChangedScreen != null)
			{
				string topScreenName = GetTopScreenName();
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v204 @ S0_v97 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
			}
		}
		if (~(doSaveAndDelayRemainingPopups ? 1u : 0u) == 0)
		{
			SaveAndDelayPopups();
		}
		_ActivateNextPopup(string.Empty);
		if (text2 == "CelebrationPopup")
		{
			string topScreenName2 = GetTopScreenName();
			if (topScreenName2 == "CharacterScreen")
			{
				UIScreen uIScreen3 = _cachedScreens.get_Item("CharacterScreen");
				CharacterScreen component2 = uIScreen3.GetComponent<CharacterScreen>();
				component2.SetupAfterMysteryBox();
			}
			List<string> screenStack = _screenStack;
			if (screenStack._size >= 1)
			{
				string topScreenName3 = GetTopScreenName();
				if (topScreenName3 != "GameoverUI")
				{
					List<string> screenStack2 = _screenStack;
					int index = screenStack2._size - 1;
					string key = screenStack2.get_Item(index);
					UIScreen uIScreen4 = _cachedScreens.get_Item(key);
					nint num4 = (nint)uIScreen4;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ S1_v60 (Il2CppClass<UI.Screens.UIScreen>)+E4] (should have been resolved before IL gen)");
				}
			}
			string topScreenName4 = GetTopScreenName();
			if (topScreenName4 == "GameoverUI")
			{
				UIScreen uIScreen5 = _cachedScreens.get_Item("GameoverUI");
				GameOverScreen component3 = uIScreen5.GetComponent<GameOverScreen>();
				component3.SetupAfterMysteryBox();
			}
		}
		List<string> popupQueue4 = _popupQueue;
		if (popupQueue4._size != 0)
		{
			return;
		}
		Action onLastPopupClosed = this.m_OnLastPopupClosed;
		if (this.m_OnLastPopupClosed != null)
		{
			if (~(ignoreLastPopupClosed ? 1u : 0u) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v270.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			else
			{
				ignoreLastPopupClosed = false;
			}
		}
	}

	public unsafe void SpawnCollectText(Vector3 startPosition, string text)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected VT, but got Unknown
		//IL_0221: Expected I, but got Obj
		//IL_023a: Expected native int or pointer, but got VT
		//IL_0252: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 80);
		UILabel uILabel = NGUITools.AddWidget<UILabel>(superPopupAnchor);
		GameObject gameObject = uILabel.gameObject;
		Transform t = gameObject.transform;
		int layer = superPopupAnchor.layer;
		Utility.SetLayerRecursively(t, layer);
		uILabel.text = text;
		Transform transform = uILabel.transform;
		Transform cachedTransform = uILabel.cachedTransform;
		Vector3 position = cachedTransform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+38]");
		_ = 0;
		_ = startPosition.x;
		_ = startPosition.x;
		Vector3 position2 = (Vector3)(color + 16);
		transform.position = position2;
		uILabel.trueTypeFont = FloatingTextFont;
		uILabel.fontSize = 20;
		if (~(uILabel.mEncoding ? 1u : 0u) == 0)
		{
			uILabel.mEncoding = false;
			((UIRect)uILabel).mChanged = true;
			uILabel.mShouldBeProcessed = true;
		}
		if (uILabel.mMaxLineCount != 1)
		{
			uILabel.mMaxLineCount = 1;
			((UIRect)uILabel).mChanged = true;
			uILabel.mShouldBeProcessed = true;
		}
		uILabel.keepCrispWhenShrunk = UILabel.Crispness.Always;
		if (uILabel.mOverflow != UILabel.Overflow.ResizeFreely)
		{
			uILabel.mOverflow = UILabel.Overflow.ResizeFreely;
			((UIRect)uILabel).mChanged = true;
			uILabel.mShouldBeProcessed = true;
		}
		nint num = (nint)uILabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v121 @ S1_v33 (Il2CppClass<UILabel>)+1E4] (should have been resolved before IL gen)");
		_ = 1047589105;
		((Color*)(nint)color)->b = 60f / 255f;
		_ = 4559550231825021691L;
		((Color*)(nint)color)->r = 250f / 255f;
		uILabel.color = color;
		GameObject gameObject2 = uILabel.gameObject;
		UIPanel uIPanel = gameObject2.AddComponent<UIPanel>();
		uIPanel.depth = 11;
		IEnumerator routine = AnimateCollectText(uILabel);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator AnimateCollectText(UILabel collectText)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateAlpha(UILabel label, float duration, float toAlpha)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator MoveTransform(Transform trans, float duration, Vector3 toPos)
	{
		_ = 0;
		_ = toPos.x;
		_ = toPos.z;
		IEnumerator result = default;
		return result;
	}

	public int NumberOfMissionSetSlideIns()
	{
		bool flag = _003C_003Ec._003C_003E9__218_0 == null;
		bool flag2 = !flag;
		Predicate<SlideIn> match = _003C_003Ec._003C_003E9__218_0;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		List<SlideIn> noOfMissionSetSlideIns = _slideInQueue.FindAll(match);
		_noOfMissionSetSlideIns = noOfMissionSetSlideIns;
		List<SlideIn> noOfMissionSetSlideIns2 = _noOfMissionSetSlideIns;
		return noOfMissionSetSlideIns2._size;
	}

	private void PreloadAllSlideIn()
	{
		if (~(slideHasPreloaded ? 1u : 0u) != 0)
		{
			slideHasPreloaded = true;
			IEnumerator routine = missionSlideIn.PreloadSlideIn();
			Coroutine coroutine = StartCoroutine(routine);
			IEnumerator routine2 = missionSetSlideIn.PreloadSlideIn();
			Coroutine coroutine2 = StartCoroutine(routine2);
			IEnumerator routine3 = lettersSlideIn.PreloadSlideIn();
			Coroutine coroutine3 = StartCoroutine(routine3);
			IEnumerator routine4 = unlockSlideIn.PreloadSlideIn();
			Coroutine coroutine4 = StartCoroutine(routine4);
			IEnumerator routine5 = errorSlideIn.PreloadSlideIn();
			Coroutine coroutine5 = StartCoroutine(routine5);
			IEnumerator routine6 = _weeklyHuntSlideIn.PreloadSlideIn();
			Coroutine coroutine6 = StartCoroutine(routine6);
			IEnumerator routine7 = bragSlideIn.PreloadSlideIn();
			Coroutine coroutine7 = StartCoroutine(routine7);
			IEnumerator routine8 = watchForKeysSlideIn.PreloadSlideIn();
			Coroutine coroutine8 = StartCoroutine(routine8);
			IEnumerator routine9 = bundlesPackSlideIn.PreloadSlideIn();
			Coroutine coroutine9 = StartCoroutine(routine9);
			IEnumerator routine10 = offerWallSlideIn.PreloadSlideIn();
			Coroutine coroutine10 = StartCoroutine(routine10);
			IEnumerator routine11 = awardsSlideIn.PreloadSlideIn();
			Coroutine coroutine11 = StartCoroutine(routine11);
			IEnumerator routine12 = facebookSlideIn.PreloadSlideIn();
			Coroutine coroutine12 = StartCoroutine(routine12);
			IEnumerator routine13 = topRunTimerSlideIn.PreloadSlideIn();
			Coroutine coroutine13 = StartCoroutine(routine13);
			IEnumerator routine14 = characterEventSlideIn.PreloadSlideIn();
			Coroutine coroutine14 = StartCoroutine(routine14);
			IEnumerator routine15 = characterEventRewardSlideIn.PreloadSlideIn();
			Coroutine coroutine15 = StartCoroutine(routine15);
		}
	}

	private void OnMissionCompleted(string message)
	{
		SlideIn slideIn = default;
		slideIn._002Ector(SlideInType.Mission, message);
		QueueSlideIn(slideIn);
	}

	private void OnMissionSetCompleted()
	{
		MissionsManager instance = MissionsManager.Instance;
		instance.PlayerDidThis(MissionTarget.ReachMissionSet);
		SlideIn slideIn = default;
		slideIn._002Ector(SlideInType.MissionSet);
		QueueSlideIn(slideIn);
	}

	private void OnLetterPickedUp()
	{
		SlideIn slideIn = default;
		slideIn._002Ector(SlideInType.Letters);
		QueueSlideIn(slideIn);
	}

	private void OnTokenPickUp(Characters.CharacterType type)
	{
		//IL_001c: Expected Obj, but got I4
		Characters.Model model = Characters.characterData.get_Item(type);
		PlayerInfo instance = PlayerInfo.Instance;
		object obj = (int)type << 2;
		object obj2 = (object)instance._collectedCharacterTokens + obj;
		int price = model.Price;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v6+10]");
		if ((nint)price <= (nint)0)
		{
			Characters.Model model2 = Characters.characterData.get_Item(type);
			string text = Strings.Get(model2.name);
			string text2 = text.ToLower();
			PlayerInfo instance2 = PlayerInfo.Instance;
			Statistics stats = instance2._stats;
			int[] values = stats._values;
			int value = values[11] + 1;
			stats.set_Item(Stat.OwnCharacters, value);
			Characters.Model model3 = Characters.characterData.get_Item(type);
			if (model3.unlockType == PurchaseData.UnlockType.Tokens)
			{
				RewardManager.canShowMultipleQueuedCelebrations = true;
				ShowUnlockAnimationForCharacter(type);
			}
		}
	}

	private void OnWillNavigateToScreenHandler(string screen)
	{
		bool flag = screen == "IngameUI";
		bool menuCamerasEnabled = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		SetMenuCamerasEnabled(menuCamerasEnabled);
	}

	private void SetMenuCamerasEnabled(bool state)
	{
		Camera3D.enabled = state;
		Camera3DClip.enabled = state;
		Camera3DOverlay.enabled = state;
		CameraOverlay2dClipping.enabled = state;
	}

	public void QueueErrorMessageSlidein(string message)
	{
		SlideIn slideIn = default;
		slideIn._002Ector(SlideInType.ErrorMessage, message);
		QueueSlideIn(slideIn);
	}

	public void QueueSlideIn(SlideIn slideIn)
	{
		if (!UniqueAllreadyInQueue(slideIn._type))
		{
			_slideInQueue.Add(slideIn);
			if (!slideInActive)
			{
				_ShowSlideIn();
			}
		}
	}

	private bool UniqueAllreadyInQueue(SlideInType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		bool result = default;
		if (_uniqueSlideInTypes.Contains(type))
		{
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj4 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			bool flag2 = default;
			object obj7 = default;
			object obj8 = default;
			bool flag4 = default;
			bool flag6 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					bool flag = !flag2;
					result = flag2;
					if (flag)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj6 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v72+8]");
						if ((nint)type == (nint)0)
						{
							result = flag2;
							break;
						}
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag3 = obj7 != obj8;
				bool result2 = flag4;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 == 1;
					result = false;
					if (!flag5)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result2 = flag6;
				}
				_ = 0;
				object obj9 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return result2;
			}
			object obj10 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B012");
		}
		return result;
	}

	public void ReadyForNextSlide()
	{
		slideInActive = false;
		_ShowSlideIn();
	}

	private void _ShowSlideIn()
	{
		//IL_061e: Expected Obj, but got I4
		//IL_0636: Expected Obj, but got I4
		//IL_064d: Expected Obj, but got I4
		List<SlideIn> slideInQueue = _slideInQueue;
		if (slideInQueue._size < 1)
		{
			return;
		}
		SlideIn slideIn = _slideInQueue.get_Item(0);
		_slideInQueue.RemoveAt(0);
		if (slideIn._type != SlideInType.TopRunTimer)
		{
			if (slideIn._type != SlideInType.Mission)
			{
				if (slideIn._type != SlideInType.MissionSet)
				{
					if (slideIn._type != SlideInType.Letters)
					{
						if (slideIn._type != SlideInType.LettersCompleteMysteryBox)
						{
							if (slideIn._type != SlideInType.LettersCompleteCoins)
							{
								if (slideIn._type != SlideInType.Unlock)
								{
									if (slideIn._type != SlideInType.ErrorMessage)
									{
										if (slideIn._type != SlideInType.WeeklyHunt)
										{
											if (slideIn._type != SlideInType.OfferWall)
											{
												if (slideIn._type != SlideInType.VideoForKeys)
												{
													if (slideIn._type != SlideInType.Brag)
													{
														if (slideIn._type != SlideInType.BundlesPack)
														{
															if (slideIn._type != SlideInType.Awards)
															{
																if (slideIn._type != SlideInType.Facebook)
																{
																	if (slideIn._type != SlideInType.CharacterEventWord)
																	{
																		if (slideIn._type == SlideInType.CharacterEventWordReward)
																		{
																			Sound sound = So.Instance.playSound(slideInSound);
																			characterEventRewardSlideIn.SetupCharacterEventReward(slideIn._payload);
																		}
																	}
																	else
																	{
																		Sound sound2 = So.Instance.playSound(slideInSound);
																		characterEventSlideIn.SetupCharacterEventLetters(slideIn._payloadInt, slideIn._extraInfo);
																	}
																}
																else
																{
																	object obj = slideIn._facebookState - 1;
																	bool flag = (nint)obj < 2;
																	object obj2 = 320;
																	if (!flag)
																	{
																		obj2 = 316;
																	}
																	object audioClip = (object)this + obj2;
																	Sound sound3 = So.Instance.playSound((AudioClipInfo)audioClip);
																	facebookSlideIn.SetupSlideFacebook(slideIn._facebookState, slideIn._onDidShowCallback);
																}
															}
															else
															{
																Sound sound4 = So.Instance.playSound(slideInFanfare);
																awardsSlideIn.SetupSlideInAward(slideIn._payload, slideIn._awardTierType);
															}
														}
														else
														{
															Sound sound5 = So.Instance.playSound(slideInFanfare);
															bundlesPackSlideIn.SetupSlideInOffer(slideIn._payload);
														}
													}
													else
													{
														Sound sound6 = So.Instance.playSound(slideInFanfare);
														bragSlideIn.SetupSlideInBrag();
													}
												}
												else
												{
													Sound sound7 = So.Instance.playSound(slideInFanfare);
													watchForKeysSlideIn.SetupSlideInVideoPayout();
												}
											}
											else
											{
												Sound sound8 = So.Instance.playSound(slideInFanfare);
												offerWallSlideIn.SetupSlideInOffer(slideIn._payload);
											}
										}
										else
										{
											Sound sound9 = So.Instance.playSound(slideInFanfare);
											_weeklyHuntSlideIn.SetupSlideInOffer(string.Empty);
										}
									}
									else
									{
										Sound sound10 = So.Instance.playSound(slideInSound);
										errorSlideIn.SetupErrorMessage(slideIn._payload);
									}
								}
								else
								{
									Sound sound11 = So.Instance.playSound(slideInFanfare);
									unlockSlideIn.SetupSlideInUnlock(slideIn._payload);
								}
							}
							else
							{
								Sound sound12 = So.Instance.playSound(slideInFanfare);
								missionSetSlideIn.SetupCoin();
							}
						}
						else
						{
							Sound sound13 = So.Instance.playSound(slideInFanfare);
							missionSetSlideIn.SetupMysteryBox(slideIn._mysteryBoxType);
						}
					}
					else
					{
						Sound sound14 = So.Instance.playSound(slideInSound);
						lettersSlideIn.SetupLetters();
					}
				}
				else
				{
					Sound sound15 = So.Instance.playSound(slideInFanfare);
					PlayerInfo instance = PlayerInfo.Instance;
					int num = instance._currentMissionSet + 1;
					if (num >= 30)
					{
						num = 30;
					}
					if (num <= 1)
					{
						num = 1;
					}
					missionSetSlideIn.SetupSlideInMissionSet(num);
				}
			}
			else
			{
				Sound sound16 = So.Instance.playSound(slideInFanfare);
				missionSlideIn.SetupSlideInMission(slideIn._payload);
			}
		}
		else
		{
			Sound sound17 = So.Instance.playSound(slideInSound);
			topRunTimerSlideIn.SetupSlideTopRunTimer(slideIn._payloadInt);
		}
		slideInActive = true;
	}

	public void ReadyForNextMessage()
	{
		messageShowing = false;
		_ShowNextMessage();
	}

	private void _QueueMessage(string message)
	{
		_messageQueue.Enqueue(message);
		if (~(messageShowing ? 1u : 0u) != 0)
		{
			_ShowNextMessage();
		}
		if (~(slideInActive ? 1u : 0u) != 0)
		{
			_ShowSlideIn();
		}
	}

	private void _ShowNextMessage()
	{
		Queue<string> messageQueue = _messageQueue;
		if (messageQueue._size >= 1)
		{
			string message = _messageQueue.Dequeue();
			messageHelper.ShowMessage(message);
			messageShowing = true;
		}
	}

	public void ShowInAppPurchaseOverlay(string text)
	{
		if (inAppPurchaseOverlay != null)
		{
			InAppPurchaseOverlay component = inAppPurchaseOverlay.GetComponent<InAppPurchaseOverlay>();
			if (component != null && component.titleLabel != null)
			{
				component.titleLabel.text = text;
			}
			inAppPurchaseOverlay.SetActive(value: true);
			Game instance = Game.Instance;
			Variable<bool> isInGame = instance.IsInGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v28 (Variable`1<System.Boolean>)+8]");
			if ((nint)0 == 0)
			{
				Camera3D.enabled = false;
			}
		}
	}

	public void HideInAppPurchaseOverlay()
	{
		inAppPurchaseOverlay.SetActive(value: false);
		Game instance = Game.Instance;
		Variable<bool> isInGame = instance.IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 == 0)
		{
			Camera3D.enabled = true;
		}
	}

	public void DelayedHideInAppPurchaseOverlay()
	{
		if (inAppPurchaseOverlay.activeSelf)
		{
			IEnumerator coroutine = HideInAppPurchaceOverlayDelayedCoroutine();
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
		}
	}

	private IEnumerator HideInAppPurchaceOverlayDelayedCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public bool IsInAppPurchaseOverlayVisible()
	{
		return inAppPurchaseOverlay.activeInHierarchy;
	}

	private unsafe void InstantiateNativeAdView()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00bf: Expected I, but got Obj
		//IL_00e4: Expected F4, but got I
		//IL_00df: Expected native int or pointer, but got VT
		//IL_00f2: Expected F4, but got VT
		//IL_00ed: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		if (_nativeInterstitialAdView == null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(_nativeInterstitialAdViewPrefab);
			NativeInterstitialHelper component = gameObject.GetComponent<NativeInterstitialHelper>();
			_nativeInterstitialAdView = component;
			Transform transform = _nativeInterstitialAdView.transform;
			Transform parent = CameraOverlay2d.transform;
			transform.parent = parent;
			Transform transform2 = _nativeInterstitialAdView.transform;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v16 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			transform2.localScale = vector;
		}
	}

	public void ShowAdsOverlay()
	{
		adsOverlay.SetActive(value: true);
	}

	public void HideAdsOverlay()
	{
		IEnumerator routine = HideAdsOverlayWithDelay(0.3f);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator HideAdsOverlayWithDelay(float delay)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public bool IsAdsOverlayVisible()
	{
		return adsOverlay.activeInHierarchy;
	}

	public void ShowTransitionAdsOverlay()
	{
		transitionAdsOverlay.SetActive(value: true);
		IEnumerator routine = HideTransitionAdsOverlayWithDelay(0.5f);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator HideTransitionAdsOverlayWithDelay(float delay)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void ShowDiskSpaceErrorOverlay()
	{
		videoAdsOverlay.SetActive(value: true);
		_allowInputOnVideoAdsOverlay = false;
	}

	public void ShowVideoAdsOverlay()
	{
		videoAdsOverlay.SetActive(value: true);
		_allowInputOnVideoAdsOverlay = false;
		IEnumerator coroutine = DelayInputOnOverlay();
		Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
	}

	public void HideVideoAdsOverlay()
	{
		if (~(_allowInputOnVideoAdsOverlay ? 1u : 0u) == 0 || ~(Globals.DEBUG_SKIP_VIDEO_ADS ? 1u : 0u) == 0)
		{
			HouseKeeper.TryRestoreSoundOptionAfterLostFocusIfNeeded();
			videoAdsOverlay.SetActive(value: false);
		}
	}

	private IEnumerator DelayInputOnOverlay()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public bool IsVideoAdsOverlayVisible()
	{
		return videoAdsOverlay.activeInHierarchy;
	}

	private void EnableGeneralDebugLabelIfNeeded()
	{
		generalDebugLabel.SetActive(Globals.DEBUG);
	}

	public void ShowMemoryBenchmarkOverlay()
	{
		_memoryBenchmarkOverlay.SetActive(value: true);
	}

	public void HideMemoryBenchmarkOverlay()
	{
		_memoryBenchmarkOverlay.SetActive(value: false);
	}

	public void UpdateMemoryBenchmarkPercent(float percent)
	{
		_memoryBenchmarkProgress.value = percent;
	}

	private void AddBackButtonBehavior(string screenName)
	{
		UIScreen uIScreen = _cachedScreens.get_Item(screenName);
		GameObject gameObject = uIScreen.gameObject;
		BackBtnBehaviour component = gameObject.GetComponent<BackBtnBehaviour>();
		if (!(component == null))
		{
			return;
		}
		UIScreen uIScreen2 = _cachedScreens.get_Item(screenName);
		GameObject gameObject2 = uIScreen2.gameObject;
		BackBtnBehaviour backBtnBehaviour = gameObject2.AddComponent<BackBtnBehaviour>();
		if (screenName == "FrontUI")
		{
			UIScreen uIScreen3 = _cachedScreens.get_Item(screenName);
			GameObject gameObject3 = uIScreen3.gameObject;
			BackBtnBehaviour component2 = gameObject3.GetComponent<BackBtnBehaviour>();
			component2.screenChangeType = BackBtnBehaviour.ScreenChangeType.ExitGame;
			return;
		}
		if (screenName != "FriendsUI" && screenName != "FriendsUI" && screenName != "AwardsScreen" && screenName != "LeaderboardUI" && screenName != "LeaderboardUI" && screenName != "CharacterScreen" && screenName != "UpgradesUI_shop" && screenName != "CoinsUI_shop" && screenName != "GameoverUI" && screenName != "BoardScreen" && screenName != "EarnCoinsScreen")
		{
			switch (screenName)
			{
			case "TopRunUI":
				break;
			case "PauseUI":
			{
				UIScreen uIScreen7 = _cachedScreens.get_Item(screenName);
				GameObject gameObject7 = uIScreen7.gameObject;
				BackBtnBehaviour component6 = gameObject7.GetComponent<BackBtnBehaviour>();
				component6.screenChangeType = BackBtnBehaviour.ScreenChangeType.PushScreen;
				UIScreen uIScreen8 = _cachedScreens.get_Item(screenName);
				GameObject gameObject8 = uIScreen8.gameObject;
				BackBtnBehaviour component7 = gameObject8.GetComponent<BackBtnBehaviour>();
				component7.ScreenNameToOpen = "IngameUI";
				return;
			}
			case "IngameUI":
			{
				UIScreen uIScreen5 = _cachedScreens.get_Item(screenName);
				GameObject gameObject5 = uIScreen5.gameObject;
				BackBtnBehaviour component4 = gameObject5.GetComponent<BackBtnBehaviour>();
				component4.screenChangeType = BackBtnBehaviour.ScreenChangeType.PushScreen;
				UIScreen uIScreen6 = _cachedScreens.get_Item(screenName);
				GameObject gameObject6 = uIScreen6.gameObject;
				BackBtnBehaviour component5 = gameObject6.GetComponent<BackBtnBehaviour>();
				component5.ScreenNameToOpen = "PauseUI";
				return;
			}
			case "SaveMePopup":
			{
				UIScreen uIScreen9 = _cachedScreens.get_Item(screenName);
				GameObject gameObject9 = uIScreen9.gameObject;
				BackBtnBehaviour component8 = gameObject9.GetComponent<BackBtnBehaviour>();
				component8.screenChangeType = BackBtnBehaviour.ScreenChangeType.SaveMePopup;
				return;
			}
			default:
			{
				bool flag = screenName == "NotEnoughCurencyPopup";
				UIScreen uIScreen4 = _cachedScreens.get_Item(screenName);
				GameObject gameObject4 = uIScreen4.gameObject;
				BackBtnBehaviour component3 = gameObject4.GetComponent<BackBtnBehaviour>();
				if (flag)
				{
					component3.screenChangeType = BackBtnBehaviour.ScreenChangeType.NotEnoughCurrency;
				}
				else
				{
					component3.screenChangeType = BackBtnBehaviour.ScreenChangeType.ClosePopup;
				}
				return;
			}
			}
		}
		UIScreen uIScreen10 = _cachedScreens.get_Item(screenName);
		GameObject gameObject10 = uIScreen10.gameObject;
		BackBtnBehaviour component9 = gameObject10.GetComponent<BackBtnBehaviour>();
		component9.screenChangeType = BackBtnBehaviour.ScreenChangeType.PushScreen;
		UIScreen uIScreen11 = _cachedScreens.get_Item(screenName);
		GameObject gameObject11 = uIScreen11.gameObject;
		BackBtnBehaviour component10 = gameObject11.GetComponent<BackBtnBehaviour>();
		component10.ScreenNameToOpen = "FrontUI";
	}

	public unsafe void SetViewportRectXForCamera(Camera camera, float x)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0054: Expected F4, but got I
		//IL_004f: Expected native int or pointer, but got VT
		//IL_0069: Expected F4, but got I
		//IL_0064: Expected native int or pointer, but got VT
		object obj = default;
		Rect rect = (Rect)(obj - 48);
		_ = 0;
		_ = 0;
		if (camera != null)
		{
			Rect rect2 = camera.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
			((Rect*)(nint)rect)->m_XMin = 0f;
			camera.rect = rect;
		}
	}

	public unsafe void SetViewportRectYForCamera(Camera camera, float y)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0054: Expected F4, but got I
		//IL_004f: Expected native int or pointer, but got VT
		//IL_0069: Expected F4, but got I
		//IL_0064: Expected native int or pointer, but got VT
		object obj = default;
		Rect rect = (Rect)(obj - 48);
		_ = 0;
		_ = 0;
		if (camera != null)
		{
			Rect rect2 = camera.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
			((Rect*)(nint)rect)->m_XMin = 0f;
			camera.rect = rect;
		}
	}

	public unsafe void SetViewportRectWidthForCamera(Camera camera, float width)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0054: Expected F4, but got I
		//IL_004f: Expected native int or pointer, but got VT
		//IL_0069: Expected F4, but got I
		//IL_0064: Expected native int or pointer, but got VT
		object obj = default;
		Rect rect = (Rect)(obj - 48);
		_ = 0;
		_ = 0;
		if (camera != null)
		{
			Rect rect2 = camera.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
			((Rect*)(nint)rect)->m_XMin = 0f;
			camera.rect = rect;
		}
	}

	public unsafe void SetViewportRectHeightForCamera(Camera camera, float height)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0054: Expected F4, but got I
		//IL_004f: Expected native int or pointer, but got VT
		//IL_0069: Expected F4, but got I
		//IL_0064: Expected native int or pointer, but got VT
		object obj = default;
		Rect rect = (Rect)(obj - 48);
		_ = 0;
		_ = 0;
		if (camera != null)
		{
			Rect rect2 = camera.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
			((Rect*)(nint)rect)->m_XMin = 0f;
			camera.rect = rect;
		}
	}

	public void RecalculateViewportRectForClipCamera(Camera camera, bool popupSizedClip)
	{
		if (camera != null)
		{
			UICameraScreenClipping component = camera.GetComponent<UICameraScreenClipping>();
			if (component != null)
			{
				component.CalculateClipping(popupSizedClip);
			}
		}
	}

	public void SetCameraToOrtographic(Camera camera, bool isOrtographic)
	{
		if (camera != null)
		{
			camera.orthographic = isOrtographic;
		}
	}

	public void CalculateCameraFieldOfView(Camera camera, float designedScreenWidth, float distanceToUI)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected I4, but got Unknown
		if (camera != null && !camera.orthographic)
		{
			float num = designedScreenWidth * 0.5f;
			float num2 = num / distanceToUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @54D");
			int pixelWidth = camera.pixelWidth;
			int pixelHeight = camera.pixelHeight;
			object obj = default;
			float num3 = (float)obj * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E3");
			int num4 = pixelWidth / pixelHeight;
			object obj2 = default;
			int num5 = obj2 / num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @54D");
			object obj4 = default;
			object obj3 = obj4 + obj4;
			float fieldOfView = (float)obj3 * 57.29578f;
			camera.fieldOfView = fieldOfView;
		}
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public void PushFacebookRewardPopup()
	{
		PushPopup("FacebookPayoutPopup");
	}

	static UIScreenController()
	{
		//IL_0030: Expected I, but got Obj
		//IL_0054: Expected VT, but got I8
		//IL_0062: Expected I, but got Obj
		//IL_0086: Expected VT, but got I8
		//IL_0094: Expected I, but got Obj
		//IL_00b8: Expected VT, but got I8
		//IL_00c6: Expected VT, but got I8
		UIScreenController.m_OnNavigateToScreen = null;
		UIScreenController.m_OnWillNavigateToScreen = null;
		List<string> list = default;
		list._002Ector();
		list.Add("IngameUI");
		PAYOUT_DISALLOWED_SCREENS = list;
		_facebookPayoutPopupQueued = false;
		_gameCenterPayoutPopupQueued = false;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v34 (Il2CppClass<UIScreenController>)+5C]");
		nint num2 = 0;
		_ = 0;
		POPUP_DEFAULT_POSITION = (Vector3)(-4483333425783373824L);
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v38 (Il2CppClass<UIScreenController>)+5C]");
		nint num4 = 0;
		_ = 0;
		SCREEN_DEFAULT_POSITION = (Vector3)(-4436045631840845824L);
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v42 (Il2CppClass<UIScreenController>)+5C]");
		nint num6 = 0;
		_ = -1082130432;
		CELEBRATION_POPUP_POSITION = (Vector3)4719772410585284608L;
		SAVEME_POPUP_POSITION = (Vector2)4638707617292615680L;
	}

	public UIScreenController()
	{
		//IL_017a: Expected I4, but got I8
		List<SCREEN> list = default;
		list._002Ector();
		ListScreen = list;
		_isApplicationFocused = true;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UI.Screens.UIScreen>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, UIScreen> cachedScreens = default;
		_cachedScreens = cachedScreens;
		List<string> list2 = default;
		list2._002Ector();
		_screenStack = list2;
		List<string> list3 = default;
		list3._002Ector();
		_popupQueue = list3;
		List<string> list4 = default;
		list4._002Ector();
		_delayedPopups = list4;
		List<string> list5 = default;
		list5._002Ector();
		list5.Add("FrontUI");
		list5.Add("IngameUI");
		_screenNamesWithoutBackground = list5;
		text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		size = 16;
		List<SlideIn> list6 = default;
		list6._002Ector(15);
		_slideInQueue = list6;
		List<SlideIn> list7 = default;
		list7._002Ector();
		_noOfMissionSetSlideIns = list7;
		List<SlideInType> list8 = default;
		list8._002Ector();
		list8.Add(SlideInType.Facebook);
		_uniqueSlideInTypes = list8;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ S2_v13 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Queue`1<System.String>>>)+4] (should have been resolved before IL gen)");
		Queue<string> queue = default;
		string[] array = default;
		queue._array = array;
		_messageQueue = queue;
		_allowInputOnVideoAdsOverlay = true;
		base._002Ector();
	}
}
