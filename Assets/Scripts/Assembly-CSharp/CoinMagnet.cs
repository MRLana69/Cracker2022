using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Characters;
using SYBO.Subway.Coins;
using UnityEngine;

public class CoinMagnet : CharacterModifier
{
	private sealed class _003CBegin_003Ed__19(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CoinMagnet _003C_003E4__this;

		private MeshRenderer _003CcoinMesh_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00ed: Expected VT, but got Obj
			//IL_00fb: Expected Obj, but got VT
			//IL_02cd: Expected I, but got Obj
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Expected VT, but got Unknown
			//IL_045f: Expected F4, but got I
			//IL_045a: Expected native int or pointer, but got VT
			//IL_0481: Expected F4, but got I
			//IL_047c: Expected native int or pointer, but got VT
			//IL_037c: Expected VT, but got Obj
			//IL_038a: Expected Obj, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 80);
			CoinMagnet coinMagnet = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_04e1;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				if (coinMagnet.character == null)
				{
					coinMagnet.Initialize();
				}
				CharacterRendering characterRendering = coinMagnet.characterRendering;
				MeshRenderer meshCoinMagnet = characterRendering._characterModel.MeshCoinMagnet;
				_003CcoinMesh_003E5__2 = meshCoinMagnet;
				_003CcoinMesh_003E5__2.enabled = true;
				GameStats instance = GameStats.Instance;
				instance.PickedUpPowerupsIncrement();
				((CharacterModifier)coinMagnet)._paused = false;
				_00210 val = (_00210)Singleton<>.Instance;
				((AudioStateLoop)val).ChangeLoop(AudioState.Magnet);
				Character character = coinMagnet.character;
				if (~(character._isStumbling ? 1u : 0u) == 0)
				{
					character.StopStumble();
				}
				CharacterRendering characterRendering2 = coinMagnet.characterRendering;
				SafeAnimation characterSafeAnimation = characterRendering2._characterSafeAnimation;
				AnimationState animationState = characterSafeAnimation._animation.get_Item("hold_magnet");
				animationState.enabled = true;
				CharacterRendering characterRendering3 = coinMagnet.characterRendering;
				SafeAnimation characterSafeAnimation2 = characterRendering3._characterSafeAnimation;
				bool flag = characterSafeAnimation2._animation.Play("hold_magnet");
				GameStats instance2 = GameStats.Instance;
				ActivePowerup powerup = instance2.TriggerPowerup(PowerupType.coinmagnet);
				coinMagnet._powerup = powerup;
				Collider component = coinMagnet.coinMagnetCollider.GetComponent<Collider>();
				component.enabled = true;
				coinMagnet.isActive = true;
				coinMagnet.enabled = true;
				coinMagnet.stop = StopSignal.DONT_STOP;
			}
			ActivePowerup powerup2 = coinMagnet._powerup;
			bool result = default;
			if (!(powerup2.timeLeft > 0f) || coinMagnet.stop != StopSignal.DONT_STOP)
			{
				Collider component2 = coinMagnet.coinMagnetCollider.GetComponent<Collider>();
				component2.enabled = false;
				coinMagnet.isActive = false;
				coinMagnet.enabled = false;
				_003CcoinMesh_003E5__2.enabled = false;
				nint num = (nint)typeof(CharacterPickupParticles);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v30 (Il2CppClass<CharacterPickupParticles>)+5C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v31 (Il2CppStaticFields<CharacterPickupParticles>)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				_ = CharacterPickupParticles.coinEfxOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Vector3 localPosition = vector + 16;
				coinMagnet.coinEFX.localPosition = localPosition;
				CharacterRendering characterRendering4 = coinMagnet.characterRendering;
				SafeAnimation characterSafeAnimation3 = characterRendering4._characterSafeAnimation;
				AnimationState animationState2 = characterSafeAnimation3._animation.get_Item("hold_magnet");
				animationState2.enabled = false;
				_00210 val2 = (_00210)Singleton<>.Instance;
				((AudioStateLoop)val2).ChangeLoop(AudioState.MagnetStop);
				ActivePowerup powerup3 = coinMagnet._powerup;
				bool flag2 = !(powerup3.timeLeft > 0f);
				bool flag3 = !flag2;
				result = false;
				if (!flag3)
				{
					Sound sound = So.Instance.playSound(coinMagnet.powerDownSound);
					result = false;
				}
			}
			else
			{
				CharacterRendering characterRendering5 = coinMagnet.characterRendering;
				MeshRenderer meshCoinMagnet2 = characterRendering5._characterModel.MeshCoinMagnet;
				Transform transform = meshCoinMagnet2.transform;
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				((Vector3*)(nint)vector)->x = 0f;
				coinMagnet.coinEFX.position = vector;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				result = true;
			}
			goto IL_04e1;
			IL_04e1:
			return result;
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

	private bool isActive;

	public float pullSpeed = 150f;

	private Character character;

	private CollisionNotifier coinMagnetCollider;

	private CharacterRendering characterRendering;

	private Transform coinEFX;

	private Game game;

	public AudioClipInfo powerDownSound;

	private static CoinMagnet instance;

	public bool IsActive => isActive;

	public static CoinMagnet Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			CoinMagnet result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(CoinMagnet));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				CoinMagnet coinMagnet = default;
				instance = coinMagnet;
				result = coinMagnet;
			}
			return result;
		}
	}

	public void Awake()
	{
		instance = this;
	}

	public void Initialize()
	{
		Character character = Character.Instance;
		this.character = character;
		Character character2 = this.character;
		CharacterPickupParticles characterPickupParticleSystem = character2.CharacterPickupParticleSystem;
		Transform transform = characterPickupParticleSystem.CoinEFX.transform;
		coinEFX = transform;
		CharacterRendering characterRendering = CharacterRendering.Instance;
		this.characterRendering = characterRendering;
		Character character3 = this.character;
		coinMagnetCollider = character3.CoinMagnetCollider;
		throw new ArgumentException();
	}

	private void SetUpHoldAnimation()
	{
		CharacterRendering characterRendering = this.characterRendering;
		SafeAnimation characterSafeAnimation = characterRendering._characterSafeAnimation;
		AnimationState animationState = characterSafeAnimation._animation.get_Item("hold_magnet");
		CharacterRendering characterRendering2 = this.characterRendering;
		CharacterModel characterModel = characterRendering2._characterModel;
		animationState.AddMixingTransform(characterModel._shoulderTransform);
		CharacterRendering characterRendering3 = this.characterRendering;
		SafeAnimation characterSafeAnimation2 = characterRendering3._characterSafeAnimation;
		AnimationState animationState2 = characterSafeAnimation2._animation.get_Item("hold_magnet");
		animationState2.layer = 3;
		CharacterRendering characterRendering4 = this.characterRendering;
		SafeAnimation characterSafeAnimation3 = characterRendering4._characterSafeAnimation;
		AnimationState animationState3 = characterSafeAnimation3._animation.get_Item("hold_magnet");
		animationState3.weight = 0.9f;
		CharacterRendering characterRendering5 = this.characterRendering;
		SafeAnimation characterSafeAnimation4 = characterRendering5._characterSafeAnimation;
		AnimationState animationState4 = characterSafeAnimation4._animation.get_Item("hold_magnet");
		animationState4.enabled = false;
	}

	private void OnDestroy()
	{
		if (coinMagnetCollider != null)
		{
			throw new ArgumentException();
		}
	}

	private void Game_OnCharacterModelRecreated()
	{
		SetUpHoldAnimation();
	}

	public override void Reset()
	{
		base._paused = false;
	}

	public override IEnumerator Begin()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void Update()
	{
	}

	public void CoinHit(Collider collider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a9: Invalid comparison between I and F4
		//IL_00ce: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 - 16;
		Coin component = collider.GetComponent<Coin>();
		if (!(component != null))
		{
			return;
		}
		Transform transform = character.transform;
		Vector3 position = transform.position;
		Transform transform2 = component.transform;
		Vector3 position2 = transform2.position;
		if (component != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			bool flag = !(0f < 70f);
			bool flag2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			bool flag3 = !(0f < 70f);
			if (flag2 != flag3)
			{
				component.MoveToMagnet(pullSpeed);
			}
		}
	}
}
