using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Common;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using UnityEngine;
using UnityEngine.Rendering;

public class CoinMagnet : CharacterModifier
{
	private sealed class _003CBegin_003Ed__16(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CoinMagnet _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_03aa: Expected Obj, but got Unknown
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_0083: Expected I, but got Obj
				//IL_0130: Expected VT, but got Obj
				//IL_013e: Expected Obj, but got I4
				//IL_013e: Expected Obj, but got VT
				//IL_01ac: Expected I4, but got Obj
				//IL_01be: Expected Obj, but got I4
				//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0202: Expected Obj, but got Unknown
				//IL_021f: Expected Obj, but got I4
				//IL_022b: Expected Obj, but got I4
				//IL_0343: Expected VT, but got Obj
				//IL_026c: Expected Obj, but got I4
				//IL_0375: Unknown result type (might be due to invalid IL or missing references)
				//IL_037a: Expected Obj, but got Unknown
				//IL_0383: Expected Obj, but got I4
				//IL_0397: Expected Obj, but got I4
				Transform transform2 = default;
				Transform transform = (Transform)(transform2 + 12);
				CoinMagnet coinMagnet = _003C_003E4__this;
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
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (coinMagnet.character != null)
					{
						coinMagnet.SetUpHoldAnimation();
					}
					CharacterRendering characterRendering = coinMagnet.characterRendering;
					MeshRenderer meshJetpack = characterRendering._characterModel.MeshJetpack;
					meshJetpack.shadowCastingMode = ShadowCastingMode.On;
					string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
					((GameStats)(object)privacyPolicyUrl).KeyPickupsCollectedIncrement();
					((CharacterModifier)coinMagnet)._paused = false;
					_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
					((AudioStateLoop)val).PlayLoop((AudioSource)4);
					Character character = coinMagnet.character;
					if (~(character._isStumbling ? 1u : 0u) == 0)
					{
						coinMagnet.character.HitByTrainSequence();
					}
					CharacterRendering characterRendering2 = coinMagnet.characterRendering;
					SafeAnimation characterSafeAnimation = characterRendering2._characterSafeAnimation;
					bool flag = characterSafeAnimation._animation.Play((PlayMode)"hold_magnet");
					((AnimationState)flag).wrapMode = WrapMode.Once;
					CharacterRendering characterRendering3 = coinMagnet.characterRendering;
					SafeAnimation characterSafeAnimation2 = characterRendering3._characterSafeAnimation;
					AnimationState animationState = characterSafeAnimation2._animation.CrossFadeQueued("hold_magnet");
					object obj2 = coinMagnet + 20;
					string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
					bool flag2 = Globals.TryAddAnimationEvent((Animation)(object)privacyPolicyUrl2, (string)8, null);
					obj2 = flag2;
					Collider component = coinMagnet.coinMagnetCollider.GetComponent<Collider>();
					component.isTrigger = true;
					coinMagnet.isActive = true;
					coinMagnet.tag = (string)1;
					coinMagnet.stop = StopSignal.DONT_STOP;
				}
				ActivePowerup powerup = coinMagnet._powerup;
				if (powerup.timeLeft > 0f && coinMagnet.stop == StopSignal.DONT_STOP)
				{
					CharacterRendering characterRendering4 = coinMagnet.characterRendering;
					MeshRenderer meshJetpack2 = characterRendering4._characterModel.MeshJetpack;
					GameObject gameObject = meshJetpack2.gameObject;
					transform2.position = (Vector3)gameObject;
					transform = transform2;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					Vector3 localPosition = transform.localPosition;
					object obj3 = this + 12;
					obj3 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				coinMagnet.Update();
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

	private bool isActive;

	public float pullSpeed;

	private Character character;

	private CollisionNotifier coinMagnetCollider;

	private CharacterRendering characterRendering;

	private Transform coinEFX;

	private Game game;

	public AudioClipInfo powerDownSound;

	private static CoinMagnet instance;

	public bool IsActive
	{
		get
		{
			//IL_0007: Expected I4, but got F4
			return (byte)(int)pullSpeed != 0;
		}
	}

	public unsafe static CoinMagnet Instance
	{
		get
		{
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected I, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_01d6: Expected I, but got Obj
			//IL_01f1: Expected I, but got Obj
			//IL_0207: Expected Obj, but got I
			//IL_0249: Expected I, but got Obj
			//IL_025f: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			nint num = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(HoverboardModelPreviewFactory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 4);
			bool flag = (object)HoverboardModelPreviewFactory.instance == null;
			bool flag2 = !flag;
			CoinMagnet result = (CoinMagnet)(object)HoverboardModelPreviewFactory.instance;
			if (!flag2)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<System.Type>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v49 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(HoverboardModelPreviewFactory);
				((IntPtr*)num3)->m_value = (void*)(nint)obj2;
				Type type = Type.internal_from_handle((IntPtr)num3);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((UnityEngine.Object)(object)type).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				nint num8 = (nint)typeof(HoverboardModelPreviewFactory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num9 = (nint)typeof(HoverboardModelPreviewFactory);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v43 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CoinMagnet coinMagnet = default;
				HoverboardModelPreviewFactory.instance = (HoverboardModelPreviewFactory)(object)coinMagnet;
				result = coinMagnet;
			}
			return result;
		}
	}

	public void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01f4: Expected Obj, but got I4
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
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
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 66)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				goto IL_0273;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		goto IL_0273;
		IL_0273:
		throw new IndexOutOfRangeException();
	}

	public void Initialize()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CoinMagnet);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CoinMagnet>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CoinMagnet);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<CoinMagnet>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		instance = this;
	}

	private unsafe void SetUpHoldAnimation()
	{
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02b9: Expected Obj, but got I4
		//IL_02c7: Expected I, but got Obj
		//IL_02dd: Expected Obj, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_020e: Expected Obj, but got I4
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_00f4: Expected I, but got Obj
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v43 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 40;
		CharacterRendering characterRendering = CharacterRendering.Instance;
		obj2 = characterRendering;
		object obj3 = this + 52;
		Character character = this.character;
		CharacterPickupParticles characterPickupParticleSystem = character.CharacterPickupParticleSystem;
		int layer = characterPickupParticleSystem.CoinEFX.layer;
		obj3 = layer;
		nint num3 = (nint)typeof(CharacterRendering);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v15 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v39 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 48;
		CharacterCamera characterCamera = CharacterCamera.Instance;
		obj5 = characterCamera;
		object obj6 = this + 44;
		Character character2 = this.character;
		obj6 = character2.CoinMagnetCollider;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<Collider> action = default;
		object obj7 = action + 16;
		obj7 = this;
		coinMagnetCollider.TriggerEnter -= action;
		OnDestroy();
		nint num6 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v27 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num7 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v35 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = this + 56;
		bool isInstantiated = Game.IsInstantiated;
		obj9 = isInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(CoinMagnet.Game_OnCharacterModelRecreated);
		object obj10 = action2 + 16;
		obj10 = this;
		game.OnCharacterModelRecreated -= action2;
	}

	private void OnDestroy()
	{
		//IL_00c0: Expected I4, but got Obj
		//IL_00ed: Expected I4, but got Obj
		//IL_00ed: Expected Obj, but got I4
		//IL_0117: Expected I4, but got Obj
		//IL_0013: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_003d: Expected I4, but got Obj
		//IL_0054: Expected Obj, but got I4
		//IL_007e: Expected I4, but got Obj
		//IL_0095: Expected Obj, but got I4
		CharacterRendering characterRendering = this.characterRendering;
		SafeAnimation characterSafeAnimation = characterRendering._characterSafeAnimation;
		bool flag = characterSafeAnimation._animation.Play((PlayMode)"hold_magnet");
		CharacterRendering characterRendering2 = this.characterRendering;
		CharacterModel characterModel = characterRendering2._characterModel;
		((AnimationState)flag).blendMode = (AnimationBlendMode)characterModel._shoulderTransform;
		CharacterRendering characterRendering3 = this.characterRendering;
		SafeAnimation characterSafeAnimation2 = characterRendering3._characterSafeAnimation;
		bool flag2 = characterSafeAnimation2._animation.Play((PlayMode)"hold_magnet");
		((AnimationState)flag2).AddMixingTransform((Transform)3);
		CharacterRendering characterRendering4 = this.characterRendering;
		SafeAnimation characterSafeAnimation3 = characterRendering4._characterSafeAnimation;
		bool flag3 = characterSafeAnimation3._animation.Play((PlayMode)"hold_magnet");
		((AnimationState)flag3).time = 0.9f;
		CharacterRendering characterRendering5 = this.characterRendering;
		SafeAnimation characterSafeAnimation4 = characterRendering5._characterSafeAnimation;
		bool flag4 = characterSafeAnimation4._animation.Play((PlayMode)"hold_magnet");
		((AnimationState)flag4).wrapMode = WrapMode.Default;
	}

	private void Game_OnCharacterModelRecreated()
	{
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)coinMagnetCollider).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			Action<Collider> action = default;
			object obj2 = action + 16;
			obj2 = this;
			coinMagnetCollider.TriggerExit += action;
		}
	}

	public override void Reset()
	{
		OnDestroy();
	}

	public override IEnumerator Begin()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = isActive;
		return (IEnumerator)flag;
	}

	private void StopCoinMagnet()
	{
		base.ExpireSoon();
		Update();
	}

	public void Update()
	{
		//IL_0042: Expected I, but got Obj
		//IL_0058: Expected Obj, but got I
		//IL_0075: Expected I, but got Obj
		//IL_021e: Expected Obj, but got VT
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_028d: Expected I4, but got Obj
		//IL_029f: Expected Obj, but got I4
		//IL_00f5: Expected VT, but got Obj
		//IL_0103: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got VT
		//IL_0091: Expected I, but got Obj
		//IL_00c1: Expected I, but got Obj
		//IL_00e7: Expected I, but got Obj
		//IL_0150: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I
		//IL_0191: Expected I, but got Obj
		Collider component = coinMagnetCollider.GetComponent<Collider>();
		component.isTrigger = false;
		isActive = false;
		tag = null;
		CharacterRendering characterRendering = this.characterRendering;
		MeshRenderer meshJetpack = characterRendering._characterModel.MeshJetpack;
		meshJetpack.shadowCastingMode = ShadowCastingMode.Off;
		nint num = (nint)typeof(CharacterPickupParticles);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11 (Il2CppClass<CharacterPickupParticles>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(CharacterPickupParticles);
		if (!flag)
		{
			nint num3 = (nint)typeof(CharacterPickupParticles);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v30 (Il2CppClass<CharacterPickupParticles>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(CharacterPickupParticles);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(CharacterPickupParticles);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ L1_v2 (Il2CppClass<CharacterPickupParticles>)+5C]");
		nint num4 = 0;
		object obj2 = CharacterPickupParticles.coinEfxOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S2_v6 (Il2CppStaticFields<CharacterPickupParticles>)+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		CharacterRendering characterRendering2 = this.characterRendering;
		SafeAnimation characterSafeAnimation = characterRendering2._characterSafeAnimation;
		bool flag4 = characterSafeAnimation._animation.Play((PlayMode)"hold_magnet");
		((AnimationState)flag4).wrapMode = WrapMode.Default;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		((AudioStateLoop)val).PlayLoop((AudioSource)5);
		ActivePowerup powerup = _powerup;
		if (powerup.timeLeft > 0f)
		{
			return;
		}
		nint num5 = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v34 (Il2CppClass<So>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v42 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)powerDownSound, false);
	}

	public void CoinHit(Collider collider)
	{
		if (((UnityEngine.Object)this).m_CachedPtr != (IntPtr)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	static CoinMagnet()
	{
		CharacterModifierCollection.TIME_LEFT_FOR_EXPIRE_SOON = 1f;
	}
}
