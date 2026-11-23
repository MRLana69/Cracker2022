using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Subway;
using SYBO.Subway.Characters;
using SYBO.Subway.Coins;
using SYBO.Subway.Pickups;
using UnityEngine;

public class LongMagnet : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public PickupSpawnPoint pickupSpawnPoint;

		public Vector3 position;

		public LongMagnet _003C_003E4__this;

		internal unsafe void _003CPullPickupSpawnPoint_003Eb__0(float t)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected Obj, but got Unknown
			//IL_015b: Expected Obj, but got I
			//IL_019e: Expected Obj, but got I
			//IL_01de: Expected F4, but got I
			//IL_01d9: Expected native int or pointer, but got VT
			//IL_01fd: Expected F4, but got I
			//IL_01f8: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			PickupSpawnPoint pickupSpawnPoint = this.pickupSpawnPoint;
			if (pickupSpawnPoint._spawnedPickupVisuals != null)
			{
				PickupSpawnPoint pickupSpawnPoint2 = this.pickupSpawnPoint;
				Transform transform = pickupSpawnPoint2._spawnedPickupVisuals.transform;
				LongMagnet longMagnet = _003C_003E4__this;
				CharacterRendering characterRendering = longMagnet.characterRendering;
				CharacterModel characterModel = characterRendering._characterModel;
				Transform transform2 = characterModel._meshSuperSneaker.transform;
				Vector3 vector2 = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				object obj2 = 0 - position;
				float num = t * t;
				float num2 = Math.Min(num, 1f);
				bool flag = num < 0f;
				float num3 = 0f;
				if (!flag)
				{
					num3 = num2;
				}
				float num4 = (float)obj2 * num3;
				float num5 = (float)position + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LongMagnet+<>c__DisplayClass13_0)+10]");
				object obj3 = num6 - 0;
				float num7 = (float)obj3 * num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LongMagnet+<>c__DisplayClass13_0)+10]");
				float num8 = 0f + num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LongMagnet+<>c__DisplayClass13_0)+14]");
				object obj4 = num9 - 0;
				float num10 = (float)obj4 * num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LongMagnet+<>c__DisplayClass13_0)+14]");
				float num11 = 0f + num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				transform.position = vector;
			}
		}
	}

	private sealed class _003CPullPickupSpawnPoint_003Ed__13(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PickupSpawnPoint pickupSpawnPoint;

		public LongMagnet _003C_003E4__this;

		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00ef: Expected VT, but got Obj
			//IL_010a: Expected Obj, but got I
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected Obj, but got Unknown
			//IL_014f: Expected Obj, but got I
			//IL_016c: Expected Obj, but got I
			//IL_02bd: Expected Obj, but got I
			//IL_02cd: Expected Obj, but got I
			//IL_02ea: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 32;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					_003C_003Ec__DisplayClass13_0 obj3 = _003C_003E8__1;
					PickupSpawnPoint pickupSpawnPoint = obj3.pickupSpawnPoint;
					if (pickupSpawnPoint.__spawnPointState == SpawnPointState.Spawned)
					{
						Character instance = Character.Instance;
						pickupSpawnPoint.TriggerCollisionWithCharacter(instance.CharacterPickupParticleSystem);
					}
				}
				return true;
			}
			LongMagnet longMagnet = _003C_003E4__this;
			_003C_003E1__state = -1;
			_003C_003Ec__DisplayClass13_0 obj4 = default;
			_003C_003E8__1 = obj4;
			_003C_003Ec__DisplayClass13_0 obj5 = _003C_003E8__1;
			obj5.pickupSpawnPoint = this.pickupSpawnPoint;
			_003C_003Ec__DisplayClass13_0 obj6 = _003C_003E8__1;
			obj6._003C_003E4__this = _003C_003E4__this;
			_003C_003Ec__DisplayClass13_0 obj7 = _003C_003E8__1;
			PickupSpawnPoint pickupSpawnPoint2 = obj7.pickupSpawnPoint;
			Transform transform = pickupSpawnPoint2._spawnedPickupVisuals.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			obj7.position = (Vector3)obj;
			_003C_003Ec__DisplayClass13_0 obj8 = _003C_003E8__1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (LongMagnet)+10]");
			Transform transform2 = ((Component)0).transform;
			Vector3 position2 = transform2.position;
			object obj9 = obj8.position - obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v27 (LongMagnet+<>c__DisplayClass13_0)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj10 = num - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v27 (LongMagnet+<>c__DisplayClass13_0)+14]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj11 = num2 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (LongMagnet)+C]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v49+44]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v49+30]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v35+8]");
			object obj14 = num3 / 0;
			throw new ArgumentException();
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

	private Game game;

	private CharacterController characterController;

	private CharacterRendering characterRendering;

	private Character character;

	private CollisionNotifier coinMagnetCollider;

	public float pullSpeed = 200f;

	private VariableBool longMagnetSuction;

	public bool ShouldBeActive
	{
		get
		{
			Hoverboard instance = Hoverboard.Instance;
			bool result;
			if (~(instance.isActive ? 1u : 0u) == 0)
			{
				PlayerInfo instance2 = PlayerInfo.Instance;
				bool flag = instance2._currentHoverboard == Hoverboards.BoardType.gliderboard;
				result = true;
				if (flag)
				{
					goto IL_0088;
				}
			}
			SuperSneakers instance3 = SuperSneakers.Instance;
			result = instance3.isActive;
			goto IL_0088;
			IL_0088:
			return result;
		}
	}

	public VariableBool LongMagnetSuction => longMagnetSuction;

	public void Start()
	{
		Character instance = Character.Instance;
		this.character = instance;
		CharacterRendering instance2 = CharacterRendering.Instance;
		characterRendering = instance2;
		Character character = this.character;
		coinMagnetCollider = character.CoinMagnetLongCollider;
		Character character2 = this.character;
		characterController = character2._characterController;
		Game instance3 = Game.Instance;
		this.game = instance3;
		Game game = this.game;
		Variable<bool> isInGame = game.IsInGame;
		throw new ArgumentException();
	}

	public void CoinHit(Collider collider)
	{
		if (game.IsInJetpackMode)
		{
			return;
		}
		Coin component = collider.GetComponent<Coin>();
		if (component != null)
		{
			component.MoveToSuperSneakers(pullSpeed);
			return;
		}
		PickupSpawnPoint component2 = collider.GetComponent<PickupSpawnPoint>();
		if (component2 != null && component2.__spawnPointState == SpawnPointState.Spawned)
		{
			IEnumerator routine = PullPickupSpawnPoint(component2);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator PullPickupSpawnPoint(PickupSpawnPoint pickupSpawnPoint)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void Activate()
	{
		longMagnetSuction.Add(this);
	}

	public void Deactivate()
	{
		longMagnetSuction.Remove(this);
	}

	public LongMagnet()
	{
		VariableBool variableBool = default;
		variableBool._002Ector();
		longMagnetSuction = variableBool;
		base._002Ector();
	}

	private void _003CStart_003Eb__11_0(bool value)
	{
		if (value)
		{
			longMagnetSuction.Clear();
		}
	}

	private void _003CStart_003Eb__11_1(bool value)
	{
		if (value)
		{
			throw new ArgumentException();
		}
		Collider component = coinMagnetCollider.GetComponent<Collider>();
		component.enabled = false;
		throw new ArgumentException();
	}
}
