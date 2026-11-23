using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway;
using SYBO.Subway.Characters;
using SYBO.Subway.Info;
using UnityEngine;

public class UIModelController : MonoBehaviour
{
	public enum ModelScreen
	{
		Character,
		GameOver,
		TutorialPopup,
		Popup,
		Boards,
		CelebrationCharacterUnlock,
		CelebrationBoardUnlock,
		CelebrationHighScore,
		DuelResultPopup,
		CelebrationTopRun,
		LimitedCharacterPopup,
		LimitedBoardPopup
	}

	private sealed class _003CAnimateRunningCharacterForBragCelebration_003Ed__68(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject model;

		public UIModelController _003C_003E4__this;

		private CharacterAnimationControl _003C_charAnimCtrl_003E5__2;

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
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected VT, but got Unknown
			//IL_0221: Expected Obj, but got VT
			//IL_03b6: Expected Obj, but got I
			//IL_03f9: Expected Obj, but got I
			//IL_0439: Expected F4, but got I
			//IL_0434: Expected native int or pointer, but got VT
			//IL_0458: Expected F4, but got I
			//IL_0453: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			UIModelController uIModelController = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (_003Cfactor2_003E5__3 < 1f)
					{
						goto IL_00f5;
					}
				}
				goto IL_02ab;
			}
			_003C_003E1__state = -1;
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S4_v14 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			CharacterAnimationControl characterAnimationControl = default;
			_003C_charAnimCtrl_003E5__2 = characterAnimationControl;
			Transform transform = model.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UIModelController)+78]");
			_ = 0;
			_ = uIModelController.CHAR_FROM_POS;
			Vector3 localPosition = vector + 16;
			transform.localPosition = localPosition;
			_003Cfactor2_003E5__3 = 0f;
			goto IL_00f5;
			IL_00f5:
			float deltaTime = Time.deltaTime;
			float num3 = deltaTime / 3.5f;
			float num4 = _003Cfactor2_003E5__3 + num3;
			float num5 = Math.Min(num4, 1f);
			bool flag = num4 < 0f;
			float num6 = 0f;
			if (!flag)
			{
				num6 = num5;
			}
			_003Cfactor2_003E5__3 = num6;
			float bragCelebrationAnimationCurveValue = uIModelController.celebrationBackgroundHelper.GetBragCelebrationAnimationCurveValue(num6);
			float num7 = 1f - _003Cfactor2_003E5__3;
			float num8 = Math.Min(num7, 1f);
			bool flag2 = num7 < 0f;
			float num9 = 0f;
			if (!flag2)
			{
				num9 = num8;
			}
			float num10 = num9 * 3f;
			float particleAnimationSpeed = num10 + 0.5f;
			uIModelController.celebrationBackgroundHelper.SetParticleAnimationSpeed(particleAnimationSpeed);
			if (_003C_charAnimCtrl_003E5__2 != null)
			{
				_003C_charAnimCtrl_003E5__2.Play();
				bool flag3 = num7 < 0.45f;
				float speed = 0.45f;
				if (!flag3)
				{
					speed = num8;
				}
				_003C_charAnimCtrl_003E5__2.Speed(speed);
			}
			if (model != null)
			{
				Transform transform2 = model.transform;
				object obj2 = uIModelController.CHAR_TO_POS - uIModelController.CHAR_FROM_POS;
				float num11 = Math.Min(bragCelebrationAnimationCurveValue, 1f);
				bool flag4 = bragCelebrationAnimationCurveValue < 0f;
				float num12 = 0f;
				if (!flag4)
				{
					num12 = num11;
				}
				float num13 = (float)obj2 * num12;
				float num14 = (float)uIModelController.CHAR_FROM_POS + num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UIModelController)+68]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UIModelController)+74]");
				object obj3 = num15 - 0;
				float num16 = (float)obj3 * num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UIModelController)+74]");
				float num17 = 0f + num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UIModelController)+6C]");
				nint num18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UIModelController)+78]");
				object obj4 = num18 - 0;
				float num19 = (float)obj4 * num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UIModelController)+78]");
				float num20 = 0f + num19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				((Vector3*)(nint)vector)->x = 0f;
				transform2.localPosition = vector;
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_02ab;
			IL_02ab:
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

	private sealed class _003CAnimateUnlockBackground_003Ed__69(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIModelController _003C_003E4__this;

		public GameObject go;

		private Vector3 _003CcharWithBoardPosition_003E5__2;

		private Vector3 _003Crotation1CharWithBoard_003E5__3;

		private Vector3 _003Crotation2CharWithBoard_003E5__4;

		private Vector3 _003Crotation3CharWithBoard_003E5__5;

		private Vector3 _003Coffset1PosBoard_003E5__6;

		private Vector3 _003Coffset2PosBoard_003E5__7;

		private Vector3 _003Coffset3PosBoard_003E5__8;

		private Vector3 _003CcharPosition_003E5__9;

		private Vector3 _003Crotation1character_003E5__10;

		private Vector3 _003Crotation2character_003E5__11;

		private Vector3 _003Crotation3character_003E5__12;

		private Vector3 _003Coffset1PosCharacter_003E5__13;

		private Vector3 _003Coffset2PosCharacter_003E5__14;

		private Vector3 _003Coffset3PosCharacter_003E5__15;

		private Vector3 _003Coffset1BgRotationCharScreen_003E5__16;

		private Vector3 _003Coffset2BgRotationCharScreen_003E5__17;

		private Vector3 _003Coffset3BgRotationCharScreen_003E5__18;

		private int _003Cindex_003E5__19;

		private Vector3 _003CcurrentBackgroundRotationOffset2_003E5__20;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0046: Expected VT, but got I8
			//IL_0055: Expected VT, but got I8
			//IL_0060: Expected VT, but got I4
			//IL_006f: Expected VT, but got I8
			//IL_007e: Expected VT, but got I8
			//IL_0089: Expected VT, but got I4
			//IL_0094: Expected VT, but got I4
			//IL_00a3: Expected VT, but got I8
			//IL_00b2: Expected VT, but got I8
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected Obj, but got Unknown
			//IL_013d: Expected Obj, but got I4
			//IL_016c: Expected VT, but got I4
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Expected Obj, but got Unknown
			//IL_01a2: Expected VT, but got I4
			//IL_01f9: Expected F4, but got I
			//IL_01f4: Expected native int or pointer, but got VT
			//IL_0208: Expected F4, but got VT
			//IL_0203: Expected native int or pointer, but got VT
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected VT, but got Unknown
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Expected VT, but got Unknown
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Expected VT, but got Unknown
			//IL_0291: Expected Obj, but got I4
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected Obj, but got Unknown
			//IL_0573: Unknown result type (might be due to invalid IL or missing references)
			//IL_0578: Expected VT, but got Unknown
			//IL_0581: Unknown result type (might be due to invalid IL or missing references)
			//IL_0586: Expected VT, but got Unknown
			//IL_058f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0594: Expected VT, but got Unknown
			//IL_059d: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a2: Expected VT, but got Unknown
			//IL_0343: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Expected Obj, but got Unknown
			//IL_0420: Unknown result type (might be due to invalid IL or missing references)
			//IL_0425: Expected Obj, but got Unknown
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ed: Expected Obj, but got Unknown
			//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ca: Expected Obj, but got Unknown
			//IL_048d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0492: Expected Obj, but got Unknown
			object obj = default;
			Vector3 vector = (Vector3)(obj - 176);
			UIModelController uIModelController = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					int num = _003Cindex_003E5__19 / 3;
					object obj2 = num * 3;
					object obj3 = _003Cindex_003E5__19 - obj2;
					if (_003Cindex_003E5__19 == (nint)obj2)
					{
						goto IL_02e0;
					}
					if ((nint)obj3 == 1)
					{
						if (~(uIModelController._isCelebrationCharacterScreen ? 1u : 0u) == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+8C]");
							_ = 0;
							_ = _003Crotation2character_003E5__11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+B0]");
							_ = 0;
							_ = _003Coffset2PosCharacter_003E5__14;
							_003CcurrentBackgroundRotationOffset2_003E5__20 = _003Coffset2BgRotationCharScreen_003E5__17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+D4]");
							_ = 0;
							object obj4 = this + 108;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+38]");
							_ = 0;
							_ = _003Crotation2CharWithBoard_003E5__4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+5C]");
							_ = 0;
							_ = _003Coffset2PosBoard_003E5__7;
							object obj4 = this + 24;
						}
					}
					else if (~(uIModelController._isCelebrationCharacterScreen ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+98]");
						_ = 0;
						_ = _003Crotation3character_003E5__12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+BC]");
						_ = 0;
						_ = _003Coffset3PosCharacter_003E5__15;
						_003CcurrentBackgroundRotationOffset2_003E5__20 = _003Coffset3BgRotationCharScreen_003E5__18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+E0]");
						_ = 0;
						object obj4 = this + 108;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+44]");
						_ = 0;
						_ = _003Crotation3CharWithBoard_003E5__5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+68]");
						_ = 0;
						_ = _003Coffset3PosBoard_003E5__8;
						object obj4 = this + 24;
					}
					goto IL_04fe;
				}
			}
			else
			{
				_003Coffset3BgRotationCharScreen_003E5__18 = (Vector3)(-4472074428870819840L);
				_003Coffset1BgRotationCharScreen_003E5__16 = (Vector3)4728779609847103488L;
				_003Coffset2PosCharacter_003E5__14 = (Vector3)0;
				_003Crotation3character_003E5__12 = (Vector3)4859383997932765184L;
				_003Crotation1character_003E5__10 = (Vector3)4828421750494593024L;
				_003Coffset3PosBoard_003E5__8 = (Vector3)0;
				_003Coffset1PosBoard_003E5__6 = (Vector3)0;
				_003Crotation2CharWithBoard_003E5__4 = (Vector3)4831236501397241856L;
				_003CcharWithBoardPosition_003E5__2 = (Vector3)(-4392135533339344896L);
				_003C_003E1__state = -1;
				_ = 0;
				_ = 4759178906223771648L;
				_ = -4375247037990436864L;
				_ = 4656722017977368576L;
				_ = -4380876537524649984L;
				_ = -4530621225134718976L;
				_ = 1127481344;
				_ = 0;
				_ = 3276931072L;
				_ = -4472074426711015424L;
				_ = -4383691287291756544L;
				_ = 3253731328L;
				object obj5 = this - -64;
				obj5 = 1129447424;
				_ = 4656722015793709056L;
				_ = 4719772410613399552L;
				_ = 4744542207434817536L;
				_ = 0;
				_003CcurrentBackgroundRotationOffset2_003E5__20 = (Vector3)0;
				_ = 0;
				if (uIModelController._currentActivatedScreenModel != ModelScreen.CelebrationHighScore)
				{
					goto IL_02e0;
				}
				_003CcurrentBackgroundRotationOffset2_003E5__20 = (Vector3)0;
				_ = 1135542272;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+44]");
				_ = 0;
				_ = _003Crotation3CharWithBoard_003E5__5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+20]");
				_ = 0;
				_ = _003CcharWithBoardPosition_003E5__2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+68]");
				_ = 0;
				_ = _003Coffset3PosBoard_003E5__8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+F0]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)_003CcurrentBackgroundRotationOffset2_003E5__20;
				Vector3 charRotation = vector + 48;
				Vector3 charPosition = vector + 32;
				Vector3 charPositionOffset = vector + 16;
				uIModelController.UpdateCelebrationRotation(go, charRotation, charPosition, charPositionOffset, vector, uIModelController.celebrationShouldAnimateStripes, uIModelController._isCelebrationBackgroundRotating);
			}
			goto IL_04f8;
			IL_02e0:
			if (~(uIModelController._isCelebrationCharacterScreen ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+80]");
				_ = 0;
				_ = _003Crotation1character_003E5__10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+A4]");
				_ = 0;
				_ = _003Coffset1PosCharacter_003E5__13;
				_003CcurrentBackgroundRotationOffset2_003E5__20 = _003Coffset1BgRotationCharScreen_003E5__16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+C8]");
				_ = 0;
				object obj4 = this + 108;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+2C]");
				_ = 0;
				_ = _003Crotation1CharWithBoard_003E5__3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+50]");
				_ = 0;
				_ = _003Coffset1PosBoard_003E5__6;
				object obj4 = this + 24;
			}
			goto IL_04fe;
			IL_04fe:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S1_v5+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S1_v5+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController+<AnimateUnlockBackground>d__69)+F0]");
			_ = 0;
			_ = _003CcurrentBackgroundRotationOffset2_003E5__20;
			Vector3 charRotation2 = vector + 112;
			Vector3 charPosition2 = vector + 96;
			Vector3 charPositionOffset2 = vector + 80;
			Vector3 backgroundRotationOffset = vector - -64;
			uIModelController.UpdateCelebrationRotation(go, charRotation2, charPosition2, charPositionOffset2, backgroundRotationOffset, uIModelController.celebrationShouldAnimateStripes, uIModelController._isCelebrationBackgroundRotating);
			int num2 = _003Cindex_003E5__19 + 1;
			_003Cindex_003E5__19 = num2;
			_ = 2.5f;
			object obj6 = default;
			_003C_003E2__current = obj6;
			_003C_003E1__state = 1;
			goto IL_04f8;
			IL_04f8:
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

	public GameObject CharacterAnchor;

	public GameObject GameOverAnchor;

	public GameObject CelebrationPopupAnchor;

	public GameObject TutorialPopupAnchor;

	public GameObject HuntPrizeAnchor;

	public GameObject PauseScreenAnchor;

	public Transform[] birthdayCharacterAnchors;

	public GameObject ModelPrefab;

	public CelebrationBackgroundHelper celebrationBackgroundHelper;

	private const string RUNNING_ANIMATION_NAME = "run";

	private CharacterModel _cachedActiveModel;

	private const string CELEBRATION_STRIPE_COROUTINE_NAME = "AnimateUnlockBackground";

	private const string BRAG_CELEBRATION_ANIMATION_COROUTINE = "AnimateRunningCharacterForBragCelebration";

	private bool celebrationShouldAnimateStripes = true;

	private bool _isCelebrationCharacterScreen;

	private bool _isCelebrationBackgroundRotating;

	private Vector3 _discoBgRotation = (Vector3)4842495500438208512L;

	private Vector3 _tunnerBgRotationNormal;

	private ModelScreen _currentActivatedScreenModel;

	private bool isShownInMysteryBox;

	private Hoverboards.BoardType currentMysteryBoxBoardType;

	private int _currentlyShownThemeIndex;

	private Characters.CharacterType _currentlyShownModel;

	private Vector3 CHAR_TO_POS = (Vector3)(-4361173285909561344L);

	private Vector3 CHAR_FROM_POS;

	private const float RUNNING_SPEED_LOW = 0.45f;

	private const float DURATION = 3.5f;

	private const float PARTICLE_ANIMATION_SPEED_FACTOR_LOW = 0.5f;

	private const float PARTICLE_ANIMATION_SPEED_FACTOR_HIGH = 3.5f;

	private static UIModelController _instance;

	private GameObject limitedCharacterPopupAnchor__BackingField;

	private GameObject limitedBoardPopupAnchor__BackingField;

	private static Action m_OnChangedCurrentlyShownCharacter;

	private static Action m_OnChangedCurrentlyShownHoverboard;

	public GameObject limitedCharacterPopupAnchor
	{
		get
		{
			return limitedCharacterPopupAnchor__BackingField;
		}
		set
		{
			limitedCharacterPopupAnchor__BackingField = value;
		}
	}

	public GameObject limitedBoardPopupAnchor
	{
		get
		{
			return limitedBoardPopupAnchor__BackingField;
		}
		set
		{
			limitedBoardPopupAnchor__BackingField = value;
		}
	}

	public int currentlyShownThemeIndex => _currentlyShownThemeIndex;

	public Characters.CharacterType currentlyShownModel => _currentlyShownModel;

	public static UIModelController Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)_instance == null;
			bool flag2 = !flag;
			UIModelController result = _instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(UIModelController));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				UIModelController uIModelController = default;
				_instance = uIModelController;
				result = uIModelController;
			}
			return result;
		}
	}

	public static event Action OnChangedCurrentlyShownCharacter
	{
		add
		{
			Delegate obj = UIModelController.m_OnChangedCurrentlyShownCharacter;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == UIModelController.m_OnChangedCurrentlyShownCharacter;
				Action onChangedCurrentlyShownCharacter = action;
				if (!flag)
				{
					onChangedCurrentlyShownCharacter = UIModelController.m_OnChangedCurrentlyShownCharacter;
				}
				UIModelController.m_OnChangedCurrentlyShownCharacter = onChangedCurrentlyShownCharacter;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = UIModelController.m_OnChangedCurrentlyShownCharacter;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = UIModelController.m_OnChangedCurrentlyShownCharacter;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == UIModelController.m_OnChangedCurrentlyShownCharacter;
				Action onChangedCurrentlyShownCharacter = action;
				if (!flag)
				{
					onChangedCurrentlyShownCharacter = UIModelController.m_OnChangedCurrentlyShownCharacter;
				}
				UIModelController.m_OnChangedCurrentlyShownCharacter = onChangedCurrentlyShownCharacter;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = UIModelController.m_OnChangedCurrentlyShownCharacter;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action OnChangedCurrentlyShownHoverboard
	{
		add
		{
			Delegate obj = UIModelController.m_OnChangedCurrentlyShownHoverboard;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == UIModelController.m_OnChangedCurrentlyShownHoverboard;
				Action onChangedCurrentlyShownHoverboard = action;
				if (!flag)
				{
					onChangedCurrentlyShownHoverboard = UIModelController.m_OnChangedCurrentlyShownHoverboard;
				}
				UIModelController.m_OnChangedCurrentlyShownHoverboard = onChangedCurrentlyShownHoverboard;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = UIModelController.m_OnChangedCurrentlyShownHoverboard;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = UIModelController.m_OnChangedCurrentlyShownHoverboard;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == UIModelController.m_OnChangedCurrentlyShownHoverboard;
				Action onChangedCurrentlyShownHoverboard = action;
				if (!flag)
				{
					onChangedCurrentlyShownHoverboard = UIModelController.m_OnChangedCurrentlyShownHoverboard;
				}
				UIModelController.m_OnChangedCurrentlyShownHoverboard = onChangedCurrentlyShownHoverboard;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = UIModelController.m_OnChangedCurrentlyShownHoverboard;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public void ActivateGameOverModel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_0058: Expected VT, but got I4
		object obj = default;
		int num = obj - 32;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		PlayerInfo instance2 = PlayerInfo.Instance;
		int currentThemeIndex = instance2.currentThemeIndex;
		object obj2 = num + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+10]");
		_ = 0;
		Characters.CharacterType? friendsCharacterName = (Characters.CharacterType?)(object)(num + 8);
		GameObject gameObject = _ActivateModel((Characters.CharacterType)instance._currentCharacter, currentThemeIndex, ModelScreen.GameOver, friendsCharacterName, num);
	}

	public GameObject ShowCharacterInCelebration(Characters.CharacterType charType, int themeIndex, ModelScreen screen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_002d: Expected Obj, but got I4
		//IL_0052: Expected VT, but got I4
		object obj = default;
		int num = obj - 32;
		_ = 0;
		isShownInMysteryBox = true;
		object obj2 = num + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+10]");
		_ = 0;
		Characters.CharacterType? friendsCharacterName = (Characters.CharacterType?)(object)(num + 8);
		return _ActivateModel(charType, themeIndex, screen, friendsCharacterName, num);
	}

	public void DeactivateCelebrationPopupModels()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		StopCoroutine("AnimateUnlockBackground");
		StopCoroutine("AnimateRunningCharacterForBragCelebration");
		isShownInMysteryBox = false;
		Transform transform = TutorialPopupAnchor.transform;
		IEnumerator enumerator = transform.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		UIModelController uIModelController = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					break;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
							}
						}
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
			bool flag = obj6 == obj7;
			bool flag2 = !flag;
			object obj8 = obj9;
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
				obj8 = obj10;
			}
			_ = 0;
			object obj11 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			uIModelController = (UIModelController)0;
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
		object obj12 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
		uIModelController.celebrationBackgroundHelper.Hide();
	}

	public GameObject ActivateCelebrationBoardWithStripes(Hoverboards.BoardType boardType, ModelScreen screen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_00e1: Expected Obj, but got I4
		//IL_0113: Expected VT, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_007c: Expected VT, but got I4
		object obj = default;
		int num = obj - 48;
		_ = 0;
		currentMysteryBoxBoardType = boardType;
		isShownInMysteryBox = true;
		if (screen == ModelScreen.CelebrationHighScore)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			PlayerInfo instance2 = PlayerInfo.Instance;
			int currentThemeIndex = instance2.currentThemeIndex;
			object obj2 = num + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+28]");
			_ = 0;
			Characters.CharacterType? friendsCharacterName = (Characters.CharacterType?)(object)(num + 8);
			return _ActivateModel((Characters.CharacterType)instance._currentCharacter, currentThemeIndex, ModelScreen.CelebrationHighScore, friendsCharacterName, num);
		}
		UIModelController instance3 = Instance;
		PlayerInfo instance4 = PlayerInfo.Instance;
		int currentThemeIndex2 = instance4.currentThemeIndex;
		object obj3 = num + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+28]");
		_ = 0;
		Characters.CharacterType? friendsCharacterName2 = (Characters.CharacterType?)(object)(num + 16);
		return _ActivateModel(instance3._currentlyShownModel, currentThemeIndex2, screen, friendsCharacterName2, num);
	}

	public unsafe void SetDiscoLightBackground()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected VT, but got Unknown
		//IL_00b9: Expected F4, but got I
		//IL_00b4: Expected native int or pointer, but got VT
		//IL_00db: Expected F4, but got I
		//IL_00d6: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 80);
		float num = (float)_discoBgRotation * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController)+3C]");
		float num2 = 0f * ((float)Math.PI / 180f);
		object obj2 = this - -64;
		float num3 = (float)obj2 * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion + 16);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		celebrationBackgroundHelper.Show(quaternion, shouldAnimateStripes: false, shouldRotateBackground: true);
	}

	public unsafe void ActivateCelebrationTunnel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected VT, but got Unknown
		//IL_00b6: Expected F4, but got I
		//IL_00b1: Expected native int or pointer, but got VT
		//IL_00d8: Expected F4, but got I
		//IL_00d3: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 80);
		float num = (float)_tunnerBgRotationNormal * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController)+48]");
		float num2 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController)+4C]");
		float num3 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion + 16);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		celebrationBackgroundHelper.Show(quaternion, shouldAnimateStripes: false, shouldRotateBackground: false);
	}

	public void DeactivateCelebrationTunnel()
	{
		celebrationBackgroundHelper.Hide();
	}

	public void SelectThemeForCurrentModel(int themeVersion)
	{
		_currentlyShownThemeIndex = themeVersion;
		SelectCurrentModelForPlay();
	}

	public void SelectCurrentModelForPlay()
	{
		SelectCharacterForPlay(_currentlyShownModel, _currentlyShownThemeIndex);
	}

	public void SelectCharacterForPlay(Characters.CharacterType characterType, int themeIndex)
	{
		//IL_0198: Expected Obj, but got I4
		PlayerInfo instance = PlayerInfo.Instance;
		if (characterType != (Characters.CharacterType)instance._currentCharacter)
		{
			instance._dirty = true;
			instance._currentCharacter = (int)characterType;
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		instance2.currentThemeIndex = themeIndex;
		bool flag = ((UIModelController)characterType).ShouldCreateABrandNewModel();
		Game instance3 = Game.Instance;
		if (flag)
		{
			instance3.RecreateCharacterModel();
		}
		else if (instance3 != null)
		{
			PlayerInfo instance4 = PlayerInfo.Instance;
			Characters.Model model = Characters.characterData.get_Item((Characters.CharacterType)instance4._currentCharacter);
			Game instance5 = Game.Instance;
			Character character = instance5._character;
			PlayerInfo instance6 = PlayerInfo.Instance;
			int currentThemeIndex = instance6.currentThemeIndex;
			character._characterModel.ChangeCharacterModel(model.modelName, currentThemeIndex, useSpecialAsset: false, deleteSpecialAsset: true);
		}
		Action onChangedCurrentlyShownCharacter = UIModelController.m_OnChangedCurrentlyShownCharacter;
		if (UIModelController.m_OnChangedCurrentlyShownCharacter != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v76.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public GameObject ShowMenuModel(Characters.CharacterType charType, int themeVersion, ModelScreen screen = ModelScreen.Character)
	{
		GameObject result;
		if (_currentlyShownModel == charType && _currentlyShownThemeIndex == themeVersion)
		{
			bool flag = _cachedActiveModel == null;
			bool flag2 = !flag;
			result = null;
			if (flag2)
			{
				goto IL_0088;
			}
		}
		_currentlyShownThemeIndex = themeVersion;
		_currentlyShownModel = charType;
		result = _SwitchModel(charType, themeVersion, screen);
		goto IL_0088;
		IL_0088:
		return result;
	}

	public GameObject ActivateHoverboardModel(ModelScreen screen = ModelScreen.Boards)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_009a: Expected Obj, but got I4
		//IL_00bf: Expected VT, but got I4
		object obj = default;
		int num = obj - 32;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		_currentlyShownModel = (Characters.CharacterType)instance._currentCharacter;
		PlayerInfo instance2 = PlayerInfo.Instance;
		int currentThemeIndex = instance2.currentThemeIndex;
		_currentlyShownThemeIndex = currentThemeIndex;
		Action onChangedCurrentlyShownHoverboard = UIModelController.m_OnChangedCurrentlyShownHoverboard;
		if (UIModelController.m_OnChangedCurrentlyShownHoverboard != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		object obj2 = num + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+10]");
		_ = 0;
		Characters.CharacterType? friendsCharacterName = (Characters.CharacterType?)(object)(num + 8);
		return _ActivateModel(_currentlyShownModel, _currentlyShownThemeIndex, screen, friendsCharacterName, num);
	}

	public void ShowHoverboardMenuModel(Hoverboards.BoardType currentlyShownBoard, bool willUpdateAnimation, bool willAllowSignatureAnimation, Hoverboard.BoardAbility boardAbility)
	{
		GameObject hoverboardGameObject = _cachedActiveModel.GetHoverboardGameObject();
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		CharacterModel cachedActiveModel = _cachedActiveModel;
		instance.ChangeHoverboard(currentlyShownBoard, hoverboardGameObject, cachedActiveModel._characterAnimation, willUpdateAnimation, willAllowSignatureAnimation, boardAbility);
		Action onChangedCurrentlyShownHoverboard = UIModelController.m_OnChangedCurrentlyShownHoverboard;
		if (UIModelController.m_OnChangedCurrentlyShownHoverboard != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void SelectCurrentlyShownBoard(Hoverboards.BoardType boardType)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		if (boardType != instance._currentHoverboard)
		{
			instance._dirty = true;
			instance._currentHoverboard = boardType;
		}
		Action onChangedCurrentlyShownHoverboard = UIModelController.m_OnChangedCurrentlyShownHoverboard;
		if (UIModelController.m_OnChangedCurrentlyShownHoverboard != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public CharacterModel GetActiveCharacterModel()
	{
		return _cachedActiveModel;
	}

	private unsafe GameObject _ActivateModel(Characters.CharacterType characterName, int modelVersion, ModelScreen screen, Characters.CharacterType? friendsCharacterName = null, int friendsModelVersion = -1)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected VT, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected VT, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected VT, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected VT, but got Unknown
		//IL_0318: Expected F4, but got I
		//IL_0313: Expected native int or pointer, but got VT
		//IL_033a: Expected F4, but got I
		//IL_0335: Expected native int or pointer, but got VT
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected VT, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected VT, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected VT, but got Unknown
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected VT, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected VT, but got Unknown
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected VT, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected VT, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected VT, but got Unknown
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Expected VT, but got Unknown
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected Obj, but got Unknown
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Expected VT, but got Unknown
		//IL_130a: Unknown result type (might be due to invalid IL or missing references)
		//IL_130f: Expected VT, but got Unknown
		//IL_135e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1363: Expected VT, but got Unknown
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Expected Obj, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Expected VT, but got Unknown
		//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd0: Expected VT, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected VT, but got Unknown
		//IL_11aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_11af: Expected Obj, but got Unknown
		//IL_11f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f6: Expected VT, but got Unknown
		//IL_1245: Unknown result type (might be due to invalid IL or missing references)
		//IL_124a: Expected VT, but got Unknown
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Expected VT, but got Unknown
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e31: Expected VT, but got Unknown
		//IL_0fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd2: Expected VT, but got Unknown
		//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8a: Expected VT, but got Unknown
		//IL_0ed9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ede: Expected VT, but got Unknown
		//IL_1048: Unknown result type (might be due to invalid IL or missing references)
		//IL_104d: Expected VT, but got Unknown
		//IL_10a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a6: Expected VT, but got Unknown
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fa: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 880);
		if (_cachedActiveModel != null && !isShownInMysteryBox)
		{
			ClearModels();
		}
		else
		{
			isShownInMysteryBox = false;
		}
		Characters.Model model = Characters.characterData.get_Item(characterName);
		_currentActivatedScreenModel = screen;
		GameObject result;
		switch (screen)
		{
		default:
		{
			bool flag = screen == ModelScreen.TutorialPopup;
			result = null;
			if (flag)
			{
				break;
			}
			bool flag2 = screen == ModelScreen.Popup;
			result = null;
			if (flag2)
			{
				break;
			}
			if (screen != ModelScreen.Boards)
			{
				if (screen != ModelScreen.CelebrationCharacterUnlock)
				{
					if (screen == ModelScreen.CelebrationBoardUnlock || screen == ModelScreen.CelebrationHighScore)
					{
						GameObject gameObject3 = UnityEngine.Object.Instantiate(ModelPrefab);
						Transform transform9 = gameObject3.transform;
						Transform parent3 = TutorialPopupAnchor.transform;
						transform9.parent = parent3;
						Transform transform10 = gameObject3.transform;
						_ = 0;
						_ = 0;
						_ = -4411275831744135168L;
						_ = -4411275831744135168L;
						Vector3 localPosition3 = (Vector3)(quaternion + 464);
						transform10.localPosition = localPosition3;
						Transform transform11 = gameObject3.transform;
						_ = 1114112000;
						_ = 1114112000;
						_ = 4785074605195264000L;
						_ = 4785074605195264000L;
						Vector3 localScale3 = (Vector3)(quaternion + 448);
						transform11.localScale = localScale3;
						Transform transform12 = gameObject3.transform;
						_ = 0.17453292f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+358]");
						_ = 0;
						_ = 3.6651914f;
						_ = (float)Math.PI / 6f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+350]");
						_ = 0;
						Vector3 euler3 = (Vector3)(quaternion + 432);
						Quaternion quaternion4 = Quaternion.Internal_FromEulerRad(euler3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
						_ = 0;
						Quaternion localRotation2 = (Quaternion)(quaternion + 416);
						transform12.localRotation = localRotation2;
						CharacterModel component3 = gameObject3.GetComponent<CharacterModel>();
						component3.ChangeCharacterModel(model.modelName, modelVersion, useSpecialAsset: false, deleteSpecialAsset: false);
						component3.HideAllPowerups();
						if (screen == ModelScreen.CelebrationBoardUnlock)
						{
							GameObject hoverboardGameObject = component3.GetHoverboardGameObject();
							HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
							instance.ChangeHoverboard(currentMysteryBoxBoardType, hoverboardGameObject, component3._characterAnimation, willUpdateAnimation: true, willAllowSignatureAnimation: false, Hoverboard.BoardAbility.None);
						}
						Transform t3 = gameObject3.transform;
						int layer3 = TutorialPopupAnchor.layer;
						Utility.SetLayerRecursively(t3, layer3);
						_isCelebrationBackgroundRotating = false;
						celebrationShouldAnimateStripes = true;
						Coroutine coroutine = StartCoroutine("AnimateUnlockBackground", gameObject3);
						bool flag3 = screen != ModelScreen.CelebrationHighScore;
						result = gameObject3;
						if (!flag3)
						{
							Coroutine coroutine2 = StartCoroutine("AnimateRunningCharacterForBragCelebration", gameObject3);
							result = gameObject3;
						}
						break;
					}
					bool flag4 = screen == ModelScreen.DuelResultPopup;
					result = null;
					if (flag4)
					{
						break;
					}
					if (screen != ModelScreen.CelebrationTopRun)
					{
						switch (screen)
						{
						default:
							result = null;
							break;
						case ModelScreen.LimitedCharacterPopup:
						{
							GameObject gameObject5 = UnityEngine.Object.Instantiate(ModelPrefab);
							Transform transform17 = gameObject5.transform;
							Transform parent5 = limitedCharacterPopupAnchor__BackingField.transform;
							transform17.parent = parent5;
							Transform transform18 = gameObject5.transform;
							_ = 0;
							_ = 0;
							_ = -4440549232587309056L;
							_ = -4440549232587309056L;
							Vector3 localPosition5 = (Vector3)(quaternion + 240);
							transform18.localPosition = localPosition5;
							Transform t5 = gameObject5.transform;
							int layer5 = CharacterAnchor.layer;
							Utility.SetLayerRecursively(t5, layer5);
							Transform transform19 = gameObject5.transform;
							_ = 1101529088;
							_ = 1101529088;
							_ = 4731031409654235136L;
							_ = 4731031409654235136L;
							Vector3 localScale5 = (Vector3)(quaternion + 224);
							transform19.localScale = localScale5;
							Transform transform20 = gameObject5.transform;
							_ = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+358]");
							_ = 0;
							_ = (float)Math.PI;
							_ = (float)Math.PI * -2f / 45f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+350]");
							_ = 0;
							Vector3 euler5 = (Vector3)(quaternion + 208);
							Quaternion quaternion6 = Quaternion.Internal_FromEulerRad(euler5);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
							_ = 0;
							Quaternion localRotation4 = (Quaternion)(quaternion + 192);
							transform20.localRotation = localRotation4;
							CharacterModel component5 = gameObject5.GetComponent<CharacterModel>();
							component5.ChangeCharacterModel(model.modelName, modelVersion, useSpecialAsset: true, deleteSpecialAsset: true);
							component5.HideAllPowerups();
							component5.StartIdleAnimations(ModelScreen.LimitedCharacterPopup);
							_cachedActiveModel = component5;
							result = gameObject5;
							break;
						}
						case ModelScreen.LimitedBoardPopup:
						{
							GameObject gameObject4 = UnityEngine.Object.Instantiate(ModelPrefab);
							Transform transform13 = gameObject4.transform;
							Transform parent4 = limitedBoardPopupAnchor__BackingField.transform;
							transform13.parent = parent4;
							Transform transform14 = gameObject4.transform;
							_ = 1120403456;
							_ = 1120403456;
							_ = -4440549229333577728L;
							_ = -4440549229333577728L;
							Vector3 localPosition4 = (Vector3)(quaternion + 176);
							transform14.localPosition = localPosition4;
							Transform t4 = gameObject4.transform;
							int layer4 = CharacterAnchor.layer;
							Utility.SetLayerRecursively(t4, layer4);
							Transform transform15 = gameObject4.transform;
							_ = 1101529088;
							_ = 1101529088;
							_ = 4731031409654235136L;
							_ = 4731031409654235136L;
							Vector3 localScale4 = (Vector3)(quaternion + 160);
							transform15.localScale = localScale4;
							Transform transform16 = gameObject4.transform;
							_ = 6.2482786f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+358]");
							_ = 0;
							_ = (float)Math.PI * 103f / 120f;
							_ = (float)Math.PI / 15f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+350]");
							_ = 0;
							Vector3 euler4 = (Vector3)(quaternion + 144);
							Quaternion quaternion5 = Quaternion.Internal_FromEulerRad(euler4);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
							_ = 0;
							Quaternion localRotation3 = (Quaternion)(quaternion + 128);
							transform16.localRotation = localRotation3;
							CharacterModel component4 = gameObject4.GetComponent<CharacterModel>();
							component4.ChangeCharacterModel(model.modelName, modelVersion, useSpecialAsset: false, deleteSpecialAsset: true);
							component4.HideAllPowerups();
							component4.StartEyeAnimations(ModelScreen.LimitedBoardPopup);
							_cachedActiveModel = component4;
							result = gameObject4;
							break;
						}
						}
						break;
					}
				}
				GameObject gameObject6 = UnityEngine.Object.Instantiate(ModelPrefab);
				Transform transform21 = gameObject6.transform;
				Transform parent6 = TutorialPopupAnchor.transform;
				transform21.parent = parent6;
				Transform transform22 = gameObject6.transform;
				_ = -1018691584;
				_ = -1018691584;
				_ = -4405646332209266688L;
				_ = -4405646332209266688L;
				Vector3 localPosition6 = (Vector3)(quaternion + 400);
				transform22.localPosition = localPosition6;
				Transform t6 = gameObject6.transform;
				int layer6 = TutorialPopupAnchor.layer;
				Utility.SetLayerRecursively(t6, layer6);
				Transform transform23 = gameObject6.transform;
				if (characterName == Characters.CharacterType.halloweenCharacter01)
				{
					_ = 1101004800;
					object obj2 = quaternion + 672;
					float num = 20f;
				}
				else
				{
					_ = 1114112000;
					object obj2 = quaternion + 656;
					float num = 58f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ S0_v176+8]");
				_ = 0;
				Vector3 localScale6 = (Vector3)(quaternion + 384);
				transform23.localScale = localScale6;
				Transform transform24 = gameObject6.transform;
				_ = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+358]");
				_ = 0;
				_ = (float)Math.PI;
				_ = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+350]");
				_ = 0;
				Vector3 euler6 = (Vector3)(quaternion + 368);
				Quaternion quaternion7 = Quaternion.Internal_FromEulerRad(euler6);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
				_ = 0;
				Quaternion localRotation5 = (Quaternion)(quaternion + 352);
				transform24.localRotation = localRotation5;
				CharacterModel component6 = gameObject6.GetComponent<CharacterModel>();
				bool useSpecialAsset = screen != ModelScreen.CelebrationTopRun;
				component6.ChangeCharacterModel(model.modelName, modelVersion, useSpecialAsset, deleteSpecialAsset: true);
				component6.HideAllPowerups();
				component6.StartEyeAnimations(ModelScreen.CelebrationTopRun);
				switch (screen)
				{
				case ModelScreen.CelebrationTopRun:
					if (component6._topRunIdleAnimation != null)
					{
						component6._topRunIdleAnimation.TR_ActivateIdle();
					}
					else
					{
						component6.StartIdleAnimations(ModelScreen.CelebrationTopRun);
					}
					break;
				case ModelScreen.CelebrationCharacterUnlock:
				{
					component6.StartIdleAnimations(ModelScreen.CelebrationCharacterUnlock);
					float num2 = (float)_discoBgRotation * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIModelController)+3C]");
					float num3 = 0f * ((float)Math.PI / 180f);
					object obj3 = this - -64;
					float num4 = (float)obj3 * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+358]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+350]");
					_ = 0;
					Vector3 euler7 = (Vector3)(quaternion + 336);
					Quaternion quaternion8 = Quaternion.Internal_FromEulerRad(euler7);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
					_ = 0;
					Quaternion rotation = (Quaternion)(quaternion + 320);
					celebrationBackgroundHelper.Show(rotation, shouldAnimateStripes: false, shouldRotateBackground: true);
					_isCelebrationBackgroundRotating = true;
					celebrationShouldAnimateStripes = false;
					break;
				}
				}
				_isCelebrationCharacterScreen = true;
				result = gameObject6;
			}
			else
			{
				GameObject gameObject7 = UnityEngine.Object.Instantiate(ModelPrefab);
				Transform transform25 = gameObject7.transform;
				Transform parent7 = CharacterAnchor.transform;
				transform25.parent = parent7;
				Transform transform26 = gameObject7.transform;
				_ = 1120403456;
				_ = 1120403456;
				_ = 3253731328L;
				_ = 3253731328L;
				Vector3 localPosition7 = (Vector3)(quaternion + 304);
				transform26.localPosition = localPosition7;
				Transform t7 = gameObject7.transform;
				int layer7 = CharacterAnchor.layer;
				Utility.SetLayerRecursively(t7, layer7);
				Transform transform27 = gameObject7.transform;
				_ = 1101529088;
				_ = 1101529088;
				_ = 4731031409654235136L;
				_ = 4731031409654235136L;
				Vector3 localScale7 = (Vector3)(quaternion + 288);
				transform27.localScale = localScale7;
				Transform transform28 = gameObject7.transform;
				_ = 6.2482786f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+358]");
				_ = 0;
				_ = (float)Math.PI * 103f / 120f;
				_ = 0.34906584f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+350]");
				_ = 0;
				Vector3 euler8 = (Vector3)(quaternion + 272);
				Quaternion quaternion9 = Quaternion.Internal_FromEulerRad(euler8);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
				_ = 0;
				Quaternion localRotation6 = (Quaternion)(quaternion + 256);
				transform28.localRotation = localRotation6;
				CharacterModel component7 = gameObject7.GetComponent<CharacterModel>();
				component7.ChangeCharacterModel(model.modelName, modelVersion, useSpecialAsset: false, deleteSpecialAsset: true);
				component7.HideAllPowerups();
				component7.StartEyeAnimations(ModelScreen.Boards);
				_cachedActiveModel = component7;
				result = gameObject7;
			}
			break;
		}
		case ModelScreen.Character:
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(ModelPrefab);
			Transform transform5 = gameObject2.transform;
			Transform parent2 = CharacterAnchor.transform;
			transform5.parent = parent2;
			Transform transform6 = gameObject2.transform;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Vector3 localPosition2 = (Vector3)(quaternion + 48);
			transform6.localPosition = localPosition2;
			Transform t2 = gameObject2.transform;
			int layer2 = CharacterAnchor.layer;
			Utility.SetLayerRecursively(t2, layer2);
			Transform transform7 = gameObject2.transform;
			_ = 1101529088;
			_ = 1101529088;
			_ = 4731031409654235136L;
			_ = 4731031409654235136L;
			Vector3 localScale2 = (Vector3)(quaternion + 32);
			transform7.localScale = localScale2;
			Transform transform8 = gameObject2.transform;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+358]");
			_ = 0;
			_ = (float)Math.PI;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+350]");
			_ = 0;
			Vector3 euler2 = (Vector3)(quaternion + 16);
			Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(euler2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
			((Quaternion*)(nint)quaternion)->x = 0f;
			transform8.localRotation = quaternion;
			CharacterModel component2 = gameObject2.GetComponent<CharacterModel>();
			component2.ChangeCharacterModel(model.modelName, modelVersion, useSpecialAsset: true, deleteSpecialAsset: true);
			component2.HideAllPowerups();
			component2.StartIdleAnimations(ModelScreen.Character);
			_cachedActiveModel = component2;
			result = gameObject2;
			break;
		}
		case ModelScreen.GameOver:
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(ModelPrefab);
			Transform transform = gameObject.transform;
			Transform parent = GameOverAnchor.transform;
			transform.parent = parent;
			Transform transform2 = gameObject.transform;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Vector3 localPosition = (Vector3)(quaternion + 112);
			transform2.localPosition = localPosition;
			Transform t = gameObject.transform;
			int layer = GameOverAnchor.layer;
			Utility.SetLayerRecursively(t, layer);
			Transform transform3 = gameObject.transform;
			_ = 1099956224;
			_ = 1099956224;
			_ = 4724276010211606528L;
			_ = 4724276010211606528L;
			Vector3 localScale = (Vector3)(quaternion + 96);
			transform3.localScale = localScale;
			Transform transform4 = gameObject.transform;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+358]");
			_ = 0;
			_ = (float)Math.PI;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+350]");
			_ = 0;
			Vector3 euler = (Vector3)(quaternion + 80);
			Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+368]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+360]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(quaternion - -64);
			transform4.localRotation = localRotation;
			CharacterModel component = gameObject.GetComponent<CharacterModel>();
			component.ChangeCharacterModel(model.modelName, modelVersion, useSpecialAsset: true, deleteSpecialAsset: false);
			component.HideAllPowerups();
			component.StartIdleAnimations(ModelScreen.GameOver);
			_cachedActiveModel = component;
			result = gameObject;
			break;
		}
		}
		return result;
	}

	private unsafe CharacterModel InstantiateCharacterModelForPopup(Characters.CharacterType characterName, int modelVersion, ModelScreen screen, Vector3 position, Vector3 rotation, Vector3 scale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected VT, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected VT, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected VT, but got Unknown
		//IL_01bc: Expected F4, but got I
		//IL_01b7: Expected native int or pointer, but got VT
		//IL_01de: Expected F4, but got I
		//IL_01d9: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 112);
		Characters.Model model = Characters.characterData.get_Item(characterName);
		GameObject gameObject = UnityEngine.Object.Instantiate(ModelPrefab);
		Transform transform = gameObject.transform;
		Transform parent = TutorialPopupAnchor.transform;
		transform.parent = parent;
		Transform t = gameObject.transform;
		int layer = TutorialPopupAnchor.layer;
		Utility.SetLayerRecursively(t, layer);
		Transform transform2 = gameObject.transform;
		_ = position.z;
		_ = position.x;
		Vector3 localPosition = (Vector3)(quaternion + 48);
		transform2.localPosition = localPosition;
		Transform transform3 = gameObject.transform;
		_ = scale.z;
		_ = scale.x;
		Vector3 localScale = (Vector3)(quaternion + 32);
		transform3.localScale = localScale;
		Transform transform4 = gameObject.transform;
		float num = rotation.x * ((float)Math.PI / 180f);
		float num2 = rotation.y * ((float)Math.PI / 180f);
		float num3 = rotation.z * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion + 16);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		transform4.localRotation = quaternion;
		CharacterModel component = gameObject.GetComponent<CharacterModel>();
		component.ChangeCharacterModel(model.modelName, modelVersion, useSpecialAsset: true, deleteSpecialAsset: true);
		component.HideAllPowerups();
		component.StartIdleAnimations(screen);
		return component;
	}

	private IEnumerator AnimateRunningCharacterForBragCelebration(GameObject model)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateUnlockBackground(GameObject go)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void UpdateCelebrationRotation(GameObject go, Vector3 charRotation, Vector3 charPosition, Vector3 charPositionOffset, Vector3 backgroundRotationOffset, bool shouldAnimateStripes, bool rotateBackground)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected VT, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected VT, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected VT, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected VT, but got Unknown
		//IL_028b: Expected F4, but got I
		//IL_0286: Expected native int or pointer, but got VT
		//IL_02aa: Expected F4, but got I
		//IL_02a5: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 160);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (go != null)
		{
			float num = charRotation.x + backgroundRotationOffset.x;
			float num2 = num * ((float)Math.PI / 180f);
			float num3 = charRotation.y + backgroundRotationOffset.y;
			float num4 = num3 * ((float)Math.PI / 180f);
			float num5 = charRotation.z + backgroundRotationOffset.z;
			float num6 = num5 * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Vector3 euler = vector - -64;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			float num7 = charRotation.z * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			float num8 = charRotation.y * ((float)Math.PI / 180f);
			float num9 = charRotation.x * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Vector3 euler2 = vector + 48;
			Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Transform transform = go.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(vector + 32);
			transform.localRotation = localRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Quaternion rotation = (Quaternion)(vector + 16);
			celebrationBackgroundHelper.Show(rotation, shouldAnimateStripes, rotateBackground);
			float num10 = charPosition.x + charPositionOffset.x;
			float num11 = charPosition.y + charPositionOffset.y;
			float num12 = charPosition.z + charPositionOffset.z;
			Transform transform2 = go.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			((Vector3*)(nint)vector)->x = 0f;
			transform2.localPosition = vector;
		}
	}

	private bool ShouldCreateABrandNewModel()
	{
		//IL_00e6: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			string operatingSystem = SystemInfo.GetOperatingSystem();
			bool flag = operatingSystem.Contains("iPhone OS 7");
			bool flag2 = !flag;
			bool flag3 = !flag2;
			bool flag4 = true;
			if (!flag3)
			{
				string operatingSystem2 = SystemInfo.GetOperatingSystem();
				bool flag5 = operatingSystem2.Contains("iOS 7");
				flag4 = flag5;
			}
			string graphicsDeviceName = SystemInfo.GetGraphicsDeviceName();
			bool flag6 = graphicsDeviceName.Contains("Apple A7");
			object obj = flag6 & flag4;
			return obj != null;
		}
		return false;
	}

	private void ClearScreenAnchor(ModelScreen screen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		if (_cachedActiveModel != null)
		{
			_cachedActiveModel = null;
		}
		if (screen != ModelScreen.Character)
		{
			ClearScreenAnchor(ModelScreen.Character);
		}
		GameObject screenAnchor = GetScreenAnchor(screen);
		if (!screenAnchor)
		{
			return;
		}
		Transform transform = screenAnchor.transform;
		IEnumerator enumerator = transform.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					goto IL_02cd;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
							}
						}
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
			bool flag = obj6 != obj7;
			object obj8 = obj9;
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
				goto IL_02cd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj8 = obj10;
			break;
			IL_02cd:
			object obj11 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			return;
		}
		_ = 0;
		object obj12 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	private GameObject GetScreenAnchor(ModelScreen screen)
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		switch (screen)
		{
		case ModelScreen.Character:
		case ModelScreen.Boards:
			return (GameObject)(this + 12);
		case ModelScreen.GameOver:
			return (GameObject)(this + 16);
		case ModelScreen.TutorialPopup:
			return (GameObject)(this + 24);
		case ModelScreen.LimitedCharacterPopup:
			return (GameObject)(this + 124);
		case ModelScreen.LimitedBoardPopup:
			return (GameObject)(this + 128);
		case ModelScreen.CelebrationCharacterUnlock:
		case ModelScreen.CelebrationBoardUnlock:
		case ModelScreen.CelebrationHighScore:
		case ModelScreen.CelebrationTopRun:
			return (GameObject)(this + 24);
		default:
			return (GameObject)(this + 12);
		}
	}

	private GameObject _SwitchModel(Characters.CharacterType characterName, int themeVersion, ModelScreen screen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00fd: Expected I, but got Obj
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected VT, but got Unknown
		//IL_0125: Expected I4, but got Obj
		object obj = default;
		UIModelController uIModelController = (UIModelController)(obj - 32);
		uIModelController.TutorialPopupAnchor = null;
		if (uIModelController.ShouldCreateABrandNewModel())
		{
			ClearScreenAnchor(screen);
		}
		if (_cachedActiveModel != null)
		{
			Characters.Model model = Characters.characterData.get_Item(characterName);
			_cachedActiveModel.ChangeCharacterModel(model.modelName, themeVersion, useSpecialAsset: true, deleteSpecialAsset: true);
			_cachedActiveModel.HideAllPowerups();
			_cachedActiveModel.StartIdleAnimations(screen);
			return _cachedActiveModel.gameObject;
		}
		object obj2 = uIModelController + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		uIModelController.GameOverAnchor = uIModelController.TutorialPopupAnchor;
		((UnityEngine.Object)uIModelController).m_CachedPtr = (IntPtr)uIModelController.TutorialPopupAnchor;
		Characters.CharacterType? friendsCharacterName = (Characters.CharacterType?)(object)(uIModelController + 8);
		return _ActivateModel(characterName, themeVersion, screen, friendsCharacterName, (int)uIModelController);
	}

	public void ClearModels()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_127d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1282: Expected Obj, but got Unknown
		//IL_1290: Unknown result type (might be due to invalid IL or missing references)
		//IL_1295: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected Obj, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got Unknown
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected Obj, but got Unknown
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Expected Obj, but got Unknown
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected Obj, but got Unknown
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected Obj, but got Unknown
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Expected Obj, but got Unknown
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected Obj, but got Unknown
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Expected Obj, but got Unknown
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected Obj, but got Unknown
		//IL_0e99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9e: Expected Obj, but got Unknown
		//IL_0eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb1: Expected Obj, but got Unknown
		//IL_0e29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2e: Expected Obj, but got Unknown
		//IL_0efe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f03: Expected Obj, but got Unknown
		//IL_1151: Unknown result type (might be due to invalid IL or missing references)
		//IL_1156: Expected Obj, but got Unknown
		//IL_1196: Unknown result type (might be due to invalid IL or missing references)
		//IL_119b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (_cachedActiveModel != null)
		{
			_cachedActiveModel = null;
		}
		Transform transform = CharacterAnchor.transform;
		IEnumerator enumerator = transform.GetEnumerator();
		object obj3 = obj + 60;
		object obj4 = obj + 76;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		object obj15 = default;
		object obj16 = default;
		object obj17 = default;
		object obj18 = default;
		object obj19 = default;
		object obj26 = default;
		object obj27 = default;
		object obj28 = default;
		object obj29 = default;
		object obj30 = default;
		object obj34 = default;
		object obj35 = default;
		object obj36 = default;
		object obj37 = default;
		object obj38 = default;
		object obj43 = default;
		object obj44 = default;
		object obj45 = default;
		object obj46 = default;
		object obj47 = default;
		object obj51 = default;
		object obj52 = default;
		object obj53 = default;
		object obj54 = default;
		object obj55 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					goto IL_0227;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
							}
						}
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
			bool flag = obj6 != obj7;
			object obj8 = obj9;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0227;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj10;
			}
			_ = 0;
			object obj11 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				break;
			}
			goto IL_11d0;
			IL_0227:
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			Transform transform2 = GameOverAnchor.transform;
			IEnumerator enumerator2 = transform2.GetEnumerator();
			object obj13 = obj + 56;
			object obj14 = obj + 72;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj15 == null)
					{
						goto IL_051a;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
									}
								}
							}
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
				bool flag2 = obj16 != obj17;
				obj8 = obj18;
				if (flag2)
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
					goto IL_051a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj19;
				break;
				IL_051a:
				object obj20 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
				Transform transform3 = TutorialPopupAnchor.transform;
				IEnumerator enumerator3 = transform3.GetEnumerator();
				object obj21 = obj + 52;
				object obj22 = obj + 68;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				goto IL_134b;
			}
			_ = 0;
			object obj23 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				break;
			}
			goto IL_11d0;
			IL_0e3d:
			if (!limitedBoardPopupAnchor__BackingField)
			{
				return;
			}
			Transform transform4 = limitedBoardPopupAnchor__BackingField.transform;
			IEnumerator enumerator4 = transform4.GetEnumerator();
			object obj24 = obj + 32;
			object obj25 = obj + 36;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj26 == null)
					{
						goto IL_1148;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
									}
								}
							}
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
				bool flag3 = obj27 != obj28;
				obj8 = obj29;
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
					goto IL_1148;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj30;
				break;
				IL_1148:
				object obj31 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
				return;
			}
			_ = 0;
			object obj32 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				break;
			}
			goto IL_11d0;
			IL_0bca:
			_ = 0;
			object obj33 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				break;
			}
			goto IL_11d0;
			IL_134b:
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj34 == null)
					{
						goto IL_080d;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
									}
								}
							}
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
				bool flag4 = obj35 != obj36;
				obj8 = obj37;
				if (flag4)
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
					goto IL_080d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj38;
				break;
				IL_080d:
				object obj39 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
				Transform transform5 = CelebrationPopupAnchor.transform;
				IEnumerator enumerator5 = transform5.GetEnumerator();
				object obj40 = obj + 48;
				object obj41 = obj - -64;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				goto IL_1386;
			}
			_ = 0;
			object obj42 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				break;
			}
			goto IL_11d0;
			IL_1386:
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj43 == null)
					{
						break;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
									}
								}
							}
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
				bool flag5 = obj44 != obj45;
				obj8 = obj46;
				if (!flag5)
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
					obj8 = obj47;
				}
				goto IL_0bca;
			}
			object obj48 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			if (!limitedCharacterPopupAnchor__BackingField)
			{
				goto IL_0e3d;
			}
			Transform transform6 = limitedCharacterPopupAnchor__BackingField.transform;
			IEnumerator enumerator6 = transform6.GetEnumerator();
			object obj49 = obj + 40;
			object obj50 = obj + 44;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj51 == null)
					{
						goto IL_0e20;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
									}
								}
							}
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
				bool flag6 = obj52 != obj53;
				obj8 = obj54;
				if (flag6)
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
					goto IL_0e20;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj55;
				break;
				IL_0e20:
				object obj56 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
				goto IL_0e3d;
			}
			_ = 0;
			object obj57 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				break;
			}
			goto IL_11d0;
			IL_11d0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	private void ClearCharacterAnchor()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_02e3: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		if (_cachedActiveModel != null)
		{
			_cachedActiveModel = null;
		}
		Transform transform = CharacterAnchor.transform;
		IEnumerator enumerator = transform.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj5 == null;
				obj6 = obj;
				if (flag)
				{
					break;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
							}
						}
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
			bool flag2 = obj7 == obj8;
			bool flag3 = !flag2;
			object obj9 = obj10;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj6 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj6 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj13 = obj6 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
	}

	public void ClearTutorialPopup()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_02d7: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Transform transform = TutorialPopupAnchor.transform;
		IEnumerator enumerator = transform.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj5 == null;
				obj6 = obj;
				if (flag)
				{
					break;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
							}
						}
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
			bool flag2 = obj7 == obj8;
			bool flag3 = !flag2;
			object obj9 = obj10;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj6 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj6 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj13 = obj6 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
	}

	public UIModelController()
	{
		//IL_000f: Expected VT, but got I8
		//IL_001e: Expected VT, but got I8
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I4
		_ = 4916664158964547584L;
		_ = 4881620524360794112L;
		_ = 4842495499330125824L;
		object obj = this - -64;
		obj = 0;
		base._002Ector();
	}
}
