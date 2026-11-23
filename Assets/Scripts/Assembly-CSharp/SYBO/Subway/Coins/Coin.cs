using System;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Subway.Characters;
using SYBO.Subway.Pickups;
using UnityEngine;

namespace SYBO.Subway.Coins;

public class Coin : MonoBehaviour
{
	private class CoinMagnetMovement
	{
		private Game _game;

		private Character _character;

		private Transform _coinTransform;

		private bool _usedForSuperSneakers;

		private bool _active;

		private Vector3 _startPosition;

		private Vector3 _endPositionOffset;

		private float _startTime;

		private float _duration;

		private Action m_OnComplete;

		public event Action OnComplete
		{
			add
			{
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Expected Obj, but got Unknown
				object obj = this + 56;
				Delegate obj2 = this.m_OnComplete;
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
				object obj = this + 56;
				Delegate obj2 = this.m_OnComplete;
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

		public CoinMagnetMovement(Transform coinTransform, Vector3 endPositionOffset, bool usedForSuperSneakers)
		{
			//IL_003d: Expected VT, but got F4
			_coinTransform = coinTransform;
			_ = endPositionOffset.z;
			_endPositionOffset = (Vector3)endPositionOffset.x;
			Game instance = Game.Instance;
			_game = instance;
			Character instance2 = Character.Instance;
			_character = instance2;
			_usedForSuperSneakers = usedForSuperSneakers;
		}

		public void Activate(float pullSpeed)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0046: Expected VT, but got Obj
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected Obj, but got Unknown
			//IL_00ab: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 32;
			Vector3 position = _coinTransform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			_startPosition = (Vector3)obj;
			float time = Time.time;
			_startTime = time;
			Transform transform = _character.transform;
			Vector3 position2 = transform.position;
			object obj3 = _startPosition - obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.Coin+CoinMagnetMovement)+1C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj4 = num - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.Coin+CoinMagnetMovement)+20]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj5 = num2 - 0;
			Game game = _game;
			Game.SpeedInfo speed = game.speed;
			float num3 = game.__currentSpeed / speed.min;
			float num4 = pullSpeed * num3;
			_active = true;
			object obj6 = obj3 * obj3;
			object obj7 = obj4 * obj4;
			object obj8 = obj6 + obj7;
			object obj9 = obj5 * obj5;
			object obj10 = obj8 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			float duration = (float)obj10 / num4;
			_duration = duration;
		}

		public unsafe void Update()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected Obj, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected Obj, but got Unknown
			//IL_01d5: Expected Obj, but got I
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Expected Obj, but got Unknown
			//IL_022d: Expected Obj, but got I
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Expected Obj, but got Unknown
			//IL_0282: Expected F4, but got I
			//IL_027d: Expected native int or pointer, but got VT
			//IL_02a1: Expected F4, but got I
			//IL_029c: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			if (~(_active ? 1u : 0u) != 0)
			{
				return;
			}
			float time = Time.time;
			float num = time - _startTime;
			float num2 = num / _duration;
			Character character = _character;
			CharacterRendering characterRendering = character._characterRendering;
			CharacterModel characterModel = characterRendering._characterModel;
			Component component;
			if (~(_usedForSuperSneakers ? 1u : 0u) != 0)
			{
				MeshRenderer meshCoinMagnet = characterModel.MeshCoinMagnet;
				component = meshCoinMagnet;
			}
			else
			{
				component = characterModel._meshSuperSneaker;
			}
			Transform transform = component.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			object obj2 = 0 + _endPositionOffset;
			object obj3 = obj2 - _startPosition;
			float num3 = num2 * num2;
			float num4 = Math.Min(num3, 1f);
			bool flag = num3 < 0f;
			float num5 = 0f;
			if (!flag)
			{
				num5 = num4;
			}
			float num6 = (float)obj3 * num5;
			float num7 = (float)_startPosition + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.Coin+CoinMagnetMovement)+28]");
			object obj4 = num8 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.Coin+CoinMagnetMovement)+1C]");
			object obj5 = obj4 - 0;
			float num9 = (float)obj5 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.Coin+CoinMagnetMovement)+1C]");
			float num10 = 0f + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.Coin+CoinMagnetMovement)+2C]");
			object obj6 = num11 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.Coin+CoinMagnetMovement)+20]");
			object obj7 = obj6 - 0;
			float num12 = (float)obj7 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.Coin+CoinMagnetMovement)+20]");
			float num13 = 0f + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			_coinTransform.position = vector;
			if (!(num2 < 1f))
			{
				Action onComplete = this.m_OnComplete;
				if (this.m_OnComplete != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v160.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				_active = false;
			}
		}

		public void Reset()
		{
			_active = false;
		}
	}

	public const float QA_X_OFFSET = 5f;

	private const float DEACTIVATION_Z_DISTANCE = 10f;

	private PickupRotate _pickupRotate;

	private TrackObject _trackObject;

	private PickupDefault _pickupDefault;

	private CoinRenderer _coinRenderer;

	private Collider _collider;

	private bool _active;

	private Character _character;

	private Transform _transform;

	private CoinCurve _curve;

	private CoinMagnetMovement _coinMagnetMovement;

	private CoinMagnetMovement _superSneakerMagnetMovement;

	private bool _isInitialized;

	protected void Awake()
	{
		Initialize();
	}

	public void UpdateCoin(float time, float characterZ, bool lowPerformanceLevel)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0058: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 - 16;
		_coinMagnetMovement.Update();
		_superSneakerMagnetMovement.Update();
		Vector3 position = _transform.position;
		float num = characterZ - 10f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		if (!(0f > num))
		{
			Deactivate();
		}
		_coinRenderer.UpdateCoinRenderer(time, characterZ, lowPerformanceLevel);
	}

	public void OnDestroy()
	{
		//IL_000e: Expected VT, but got Obj
		//IL_0018: Expected Obj, but got VT
		if (SingletonMonobehavior<>.IsInstantiated)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			((CoinManager)val).NotifyCoinDestroyed(this);
		}
		CoinStats coinStats = CoinStats.New;
		int num = coinStats.DestroyedCoins__BackingField + 1;
		coinStats.DestroyedCoins__BackingField = num;
	}

	public void ToggleRenderer(bool enabled)
	{
		_coinRenderer.ToggleRenderers(enabled);
	}

	public void SetCurve(CoinCurve curve)
	{
		_curve = curve;
	}

	public void Deactivate(bool trackObjectDeactivated = false)
	{
		//IL_004d: Expected VT, but got Obj
		//IL_0057: Expected Obj, but got VT
		if (~(_active ? 1u : 0u) == 0)
		{
			_active = false;
			if (!trackObjectDeactivated)
			{
				_trackObject.Deactivate();
			}
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			((CoinManager)val).NotifyCoinDeactivated(this);
			CoinMagnetMovement coinMagnetMovement = _coinMagnetMovement;
			coinMagnetMovement._active = false;
			CoinMagnetMovement superSneakerMagnetMovement = _superSneakerMagnetMovement;
			superSneakerMagnetMovement._active = false;
			if (_curve != null)
			{
				_curve.DeactivateCoin(this);
			}
			_curve = null;
			CoinStats coinStats = CoinStats.New;
			int num = coinStats.DeactivatedCoins__BackingField + 1;
			coinStats.DeactivatedCoins__BackingField = num;
		}
	}

	public unsafe void Activate(bool trackObjectActivated = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00d9: Expected I, but got Obj
		//IL_010b: Expected F4, but got I
		//IL_0106: Expected native int or pointer, but got VT
		//IL_0126: Expected F4, but got I
		//IL_0121: Expected native int or pointer, but got VT
		//IL_006a: Expected VT, but got Obj
		//IL_0074: Expected Obj, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		if (~(_active ? 1u : 0u) != 0)
		{
			_active = true;
			if (!trackObjectActivated)
			{
				_trackObject.Activate();
			}
			Transform transform = base.transform;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v25 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			transform.localPosition = vector;
			_collider.enabled = true;
			ToggleRenderer(enabled: true);
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			((CoinManager)val).NotifyCoinActivated(this);
			CoinStats coinStats = CoinStats.New;
			int num3 = coinStats.ActivatedCoins__BackingField + 1;
			coinStats.ActivatedCoins__BackingField = num3;
		}
	}

	public void MoveToMagnet(float pullSpeed)
	{
		_collider.enabled = false;
		_coinMagnetMovement.Activate(pullSpeed);
	}

	public void MoveToSuperSneakers(float pullSpeed)
	{
		_collider.enabled = false;
		_superSneakerMagnetMovement.Activate(pullSpeed);
	}

	public new int GetHashCode()
	{
		return GetInstanceID();
	}

	public unsafe void Initialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02a7: Expected I, but got Obj
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected VT, but got Unknown
		//IL_036c: Expected I, but got Obj
		//IL_03d7: Expected F4, but got I
		//IL_03d2: Expected native int or pointer, but got VT
		//IL_03f6: Expected F4, but got I
		//IL_03f1: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		if (~(_isInitialized ? 1u : 0u) != 0)
		{
			_isInitialized = true;
			if (_pickupRotate == null)
			{
				PickupRotate component = GetComponent<PickupRotate>();
				_pickupRotate = component;
			}
			if (_pickupDefault == null)
			{
				PickupDefault component2 = GetComponent<PickupDefault>();
				_pickupDefault = component2;
			}
			if (_coinRenderer == null)
			{
				CoinRenderer component3 = GetComponent<CoinRenderer>();
				_coinRenderer = component3;
			}
			if (_collider == null)
			{
				Collider component4 = GetComponent<Collider>();
				_collider = component4;
			}
			if (_trackObject == null)
			{
				TrackObject component5 = GetComponent<TrackObject>();
				_trackObject = component5;
			}
			Action action = default;
			action._002Ector(this, (nint)__ldftn(Coin.TrackObject_OnActivate));
			_trackObject.OnActivate += action;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(Coin.TrackObject_OnDeactivate));
			_trackObject.OnDeactivate += action2;
			Character instance = Character.Instance;
			_character = instance;
			Transform transform = base.transform;
			_transform = transform;
			Transform coinTransform = base.transform;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v70 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			float num3 = (float)Vector3.downVector * 6f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v71 (Il2CppStaticFields<UnityEngine.Vector3>)+28]");
			float num4 = 0f * 6f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v71 (Il2CppStaticFields<UnityEngine.Vector3>)+2C]");
			float num5 = 0f * 6f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Vector3 endPositionOffset = vector + 16;
			CoinMagnetMovement coinMagnetMovement = default;
			coinMagnetMovement._002Ector(coinTransform, endPositionOffset, usedForSuperSneakers: false);
			_coinMagnetMovement = coinMagnetMovement;
			Transform coinTransform2 = base.transform;
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v96 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num7 = 0;
			float num8 = (float)Vector3.downVector * 6f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v97 (Il2CppStaticFields<UnityEngine.Vector3>)+28]");
			float num9 = 0f * 6f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v97 (Il2CppStaticFields<UnityEngine.Vector3>)+2C]");
			float num10 = 0f * 6f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			CoinMagnetMovement coinMagnetMovement2 = default;
			coinMagnetMovement2._002Ector(coinTransform2, vector, usedForSuperSneakers: true);
			_superSneakerMagnetMovement = coinMagnetMovement2;
			Action action3 = default;
			action3._002Ector(this, (nint)__ldftn(Coin.MagnetMovement_OnComplete));
			_coinMagnetMovement.OnComplete += action3;
			Action action4 = default;
			action4._002Ector(this, (nint)__ldftn(Coin.SuperSneakersMagnetMovement_OnComplete));
			_superSneakerMagnetMovement.OnComplete += action4;
			CoinStats coinStats = CoinStats.New;
			int num11 = coinStats.CreatedCoins__BackingField + 1;
			coinStats.CreatedCoins__BackingField = num11;
		}
	}

	private void TrackObject_OnActivate()
	{
		Activate(trackObjectActivated: true);
	}

	private void TrackObject_OnDeactivate()
	{
		Deactivate(trackObjectDeactivated: true);
	}

	public void Pickup(CharacterPickupParticles pickupParticles)
	{
		//IL_000e: Expected VT, but got Obj
		//IL_0018: Expected Obj, but got VT
		if (~(_active ? 1u : 0u) == 0)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			((CoinManager)val).PickupCoin(this);
		}
		Transform trans = transform;
		pickupParticles.PickedUpCoin(trans);
		Deactivate();
	}

	private void MagnetMovement_OnComplete()
	{
		Character character = _character;
		Pickup(character.CharacterPickupParticleSystem);
		_collider.enabled = true;
		GameStats instance = GameStats.Instance;
		instance.CoinMagnetCountIncrement();
	}

	private void SuperSneakersMagnetMovement_OnComplete()
	{
		Character character = _character;
		Pickup(character.CharacterPickupParticleSystem);
		_collider.enabled = true;
	}
}
