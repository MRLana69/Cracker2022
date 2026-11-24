using System;
using System.Collections;
using Cpp2ILInjected;
using InApp;
using Info;
using SYBO.Common.Data;
using SYBO.Common.Events;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Pickups;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using SYBO.Subway.StateSystem.States;
using UnityEngine;

namespace SYBO.Subway.Coins;

public class Coin : MonoBehaviour
{
	private class CoinMagnetMovement
	{
		private Action m_OnComplete;

		private Game _game;

		private Character _character;

		private Transform _coinTransform;

		private bool _usedForSuperSneakers;

		private bool _active;

		private Vector3 _startPosition;

		private Vector3 _endPositionOffset;

		private float _startTime;

		private float _duration;

		public event Action OnComplete
		{
			add
			{
				this.m_OnComplete = value;
			}
			remove
			{
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Expected Obj, but got Unknown
				Delegate obj = this.m_OnComplete;
				object obj4 = default;
				while (true)
				{
					Delegate obj2 = obj.CombineImpl((Delegate)value);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
					object obj3 = this + 8;
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

		public CoinMagnetMovement(Transform coinTransform, Vector3 endPositionOffset, bool usedForSuperSneakers)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			//IL_00b9: Expected Obj, but got VT
			//IL_00c3: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 8;
			obj2 = coinTransform;
			object obj3 = this + 12;
			obj3 = endPositionOffset;
			_character = (Character)usedForSuperSneakers;
		}

		public void Activate(float pullSpeed)
		{
			//IL_010a: Expected I, but got Obj
			//IL_0120: Expected Obj, but got I
			//IL_0182: Expected Obj, but got I4
			//IL_00f6: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0152: Expected F4, but got Obj
			//IL_0152: Expected F4, but got Obj
			//IL_016b: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
			IEnumerator enumerator = ((DeathState)useBenchmarkRoute).DelayGameOverScreen();
			Action onComplete = this.m_OnComplete;
			IntPtr method = ((Delegate)onComplete).method;
			if (enumerator != null)
			{
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v25 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float orthographicSize = Mathf.LerpUnclamped((float)_game, (float)_character, pullSpeed);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v6 (System.IntPtr)+6C]");
				((Camera)0).orthographicSize = orthographicSize;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v6 (System.IntPtr)+6C]");
				((Camera)0).orthographicSize = 68f;
			}
		}

		public void Update()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		public unsafe void Reset()
		{
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected VT, but got Unknown
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected VT, but got Unknown
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Expected Obj, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Expected Obj, but got Unknown
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Expected Obj, but got Unknown
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Expected Obj, but got Unknown
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Expected Obj, but got Unknown
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Expected Obj, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected Obj, but got Unknown
			//IL_00c7: Expected VT, but got Obj
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected Obj, but got Unknown
			//IL_00fa: Expected I, but got Obj
			//IL_0110: Expected Obj, but got I
			//IL_0279: Expected F4, but got Obj
			//IL_0274: Expected native int or pointer, but got VT
			//IL_028b: Expected F4, but got I
			//IL_0286: Expected native int or pointer, but got VT
			//IL_0298: Expected F4, but got Obj
			//IL_0293: Expected native int or pointer, but got VT
			//IL_02ad: Expected F4, but got I
			//IL_02a8: Expected native int or pointer, but got VT
			//IL_02f5: Expected F4, but got Obj
			//IL_02f0: Expected native int or pointer, but got VT
			//IL_030a: Expected F4, but got I
			//IL_0305: Expected native int or pointer, but got VT
			//IL_0317: Expected F4, but got Obj
			//IL_0312: Expected native int or pointer, but got VT
			//IL_032c: Expected F4, but got I
			//IL_0327: Expected native int or pointer, but got VT
			//IL_036e: Expected F4, but got Obj
			//IL_0369: Expected native int or pointer, but got VT
			//IL_0383: Expected F4, but got I
			//IL_037e: Expected native int or pointer, but got VT
			//IL_038c: Expected Obj, but got VT
			//IL_013b: Expected I, but got Obj
			object obj = default;
			Vector3 vector = (Vector3)(obj + 96);
			Vector3 vector2 = (Vector3)(obj + 84);
			object obj2 = obj + 72;
			Transform transform = (Transform)(obj + 60);
			object obj3 = obj + 48;
			object obj4 = obj + 12;
			object obj5 = obj + 36;
			object obj6 = obj + 24;
			if (~(_active ? 1u : 0u) != 0)
			{
				return;
			}
			float timeSinceLevelLoad = Time.timeSinceLevelLoad;
			float num = timeSinceLevelLoad - _startTime;
			Character character = _character;
			CharacterRendering characterRendering = character._characterRendering;
			CharacterModel characterModel = characterRendering._characterModel;
			Component component;
			if (~(_usedForSuperSneakers ? 1u : 0u) == 0)
			{
				component = characterModel._meshSuperSneaker;
			}
			else
			{
				MeshRenderer meshJetpack = characterRendering._characterModel.MeshJetpack;
				component = meshJetpack;
			}
			GameObject gameObject = component.gameObject;
			object obj7 = this + 28;
			obj2 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S2_v3+8]");
			_ = 0;
			transform.position = (Vector3)gameObject;
			object obj8 = this + 40;
			obj3 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S2_v9+8]");
			_ = 0;
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v24 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v49 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)transform;
			((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector3 = vector2 - vector;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			_ = 0;
			((Vector3*)(nint)vector2)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
			((Vector3*)(nint)vector)->z = 0f;
			float num4 = num / _duration;
			float t = num4 * num4;
			Vector3 vector4 = Vector3.LerpUnclamped(vector2, vector, t);
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 localPosition = ((Transform)vector).localPosition;
			if (!(num4 < 1f))
			{
				if (this.m_OnComplete != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
				}
				_active = false;
			}
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
		CancelInvoke();
	}

	public void UpdateCoin(float time, float characterZ, float characterGamePositionZ, bool lowPerformanceLevel)
	{
		//IL_000a: Expected Obj, but got F4
		//IL_0014: Expected Obj, but got F4
		//IL_001e: Expected Obj, but got F4
		//IL_0028: Expected Obj, but got I4
		_pickupRotate = (PickupRotate)time;
		_trackObject = (TrackObject)characterZ;
		_pickupDefault = (PickupDefault)characterGamePositionZ;
		((GatedValue)(object)this).RaiseOnValueChanged((ValueChangedEventArgs)lowPerformanceLevel);
	}

	public void OnDestroy()
	{
		TrackObject_OnActivate();
	}

	public void ToggleRenderer(bool enabled)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I4
		object obj = this + 32;
		obj = enabled;
		if ((object)_trackObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
		object obj2 = this + 28;
		obj2 = _active;
	}

	public void SetCurve(CoinCurve curve)
	{
		//IL_000f: Expected I4, but got Obj
		((CoinStats)(object)_coinRenderer).CreatedCoins = (int)curve;
	}

	public void Deactivate(bool trackObjectDeactivated = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 44;
		obj = trackObjectDeactivated;
	}

	public void Activate(bool trackObjectActivated = false)
	{
		//IL_004d: Expected VT, but got Obj
		//IL_0057: Expected Obj, but got VT
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_013f: Expected Obj, but got I4
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
		//IL_018e: Expected I, but got Obj
		if (~(_active ? 1u : 0u) != 0)
		{
			return;
		}
		_active = false;
		if (!trackObjectActivated)
		{
			_trackObject._002Ector();
		}
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		((CoinManager)val).NotifyCoinDestroyed(this);
		CoinMagnetMovement coinMagnetMovement = _coinMagnetMovement;
		coinMagnetMovement._active = false;
		CoinMagnetMovement superSneakerMagnetMovement = _superSneakerMagnetMovement;
		superSneakerMagnetMovement._active = false;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_curve).FindKernel((string)null) != 0)
		{
			((CoinManager)(object)_curve).OnCoinCollected += (EventHandler)(object)this;
		}
		object obj2 = this + 44;
		obj2 = 0;
		nint num3 = (nint)typeof(CoinStats);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v26 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(CoinStats);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v33 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinStats coinStats = CoinStats.New;
		int num5 = coinStats.DeactivatedCoins__BackingField + 1;
		coinStats.DeactivatedCoins__BackingField = num5;
	}

	public void MoveToMagnet(float pullSpeed)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		object obj = this + 28;
		float num = pullSpeed * (float)_trackObject;
		object obj2 = (object)_coinRenderer * (object)_pickupDefault;
		float num2 = num + (float)obj2;
		object obj3 = this + 28;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v7+8]");
		_ = 0;
		Transform transform = (Transform)(obj4 + 12);
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 right = transform.right;
	}

	public void MoveToSuperSneakers(float pullSpeed)
	{
		_collider.isTrigger = false;
		_coinMagnetMovement(pullSpeed);
	}

	public void Initialize()
	{
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_014c: Expected VT, but got Obj
		//IL_0156: Expected Obj, but got VT
		//IL_0054: Expected I, but got Obj
		if (SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
		{
			nint num = (nint)typeof(SingletonMonoBehaviour);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v24 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SingletonMonoBehaviour);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v31 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((CoinManager)val).PickupCoin(this);
		}
		nint num3 = (nint)typeof(CoinStats);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v10 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CoinStats);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v17 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinStats coinStats = CoinStats.New;
		int num5 = coinStats.DestroyedCoins__BackingField + 1;
		coinStats.DestroyedCoins__BackingField = num5;
	}

	private unsafe void TrackObject_OnActivate()
	{
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected VT, but got Unknown
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Expected Obj, but got Unknown
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected Obj, but got Unknown
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected Obj, but got Unknown
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_0699: Expected I, but got Obj
		//IL_06af: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_06da: Expected I, but got Obj
		//IL_06f0: Expected Obj, but got I
		//IL_00ce: Expected I, but got Obj
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got VT
		//IL_071b: Expected I, but got Obj
		//IL_0731: Expected Obj, but got I
		//IL_013d: Expected I, but got Obj
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got VT
		//IL_075c: Expected I, but got Obj
		//IL_0772: Expected Obj, but got I
		//IL_01ac: Expected I, but got Obj
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c9: Expected Obj, but got Unknown
		//IL_021b: Expected I, but got Obj
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02ce: Expected I, but got Obj
		//IL_02e4: Expected Obj, but got I
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected Obj, but got Unknown
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected Obj, but got Unknown
		//IL_035c: Expected I, but got Obj
		//IL_0372: Expected Obj, but got I
		//IL_030f: Expected I, but got Obj
		//IL_084a: Expected F4, but got Obj
		//IL_0845: Expected native int or pointer, but got VT
		//IL_085f: Expected F4, but got I
		//IL_085a: Expected native int or pointer, but got VT
		//IL_03e9: Expected F4, but got Obj
		//IL_03e4: Expected native int or pointer, but got VT
		//IL_03fe: Expected F4, but got I
		//IL_03f9: Expected native int or pointer, but got VT
		//IL_0414: Expected I4, but got VT
		//IL_0414: Expected I4, but got Obj
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected Obj, but got Unknown
		//IL_039d: Expected I, but got Obj
		//IL_044c: Expected F4, but got Obj
		//IL_0447: Expected native int or pointer, but got VT
		//IL_0461: Expected F4, but got I
		//IL_045c: Expected native int or pointer, but got VT
		//IL_048f: Expected F4, but got Obj
		//IL_048a: Expected native int or pointer, but got VT
		//IL_04a4: Expected F4, but got I
		//IL_049f: Expected native int or pointer, but got VT
		//IL_04ba: Expected I4, but got VT
		//IL_04ba: Expected I4, but got Obj
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got Unknown
		//IL_0586: Expected I, but got Obj
		//IL_059c: Expected Obj, but got I
		//IL_05c7: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 48);
		object obj2 = obj + 36;
		object obj3 = obj + 24;
		object obj4 = obj + 12;
		if (~(_isInitialized ? 1u : 0u) == 0)
		{
			return;
		}
		_isInitialized = true;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v143 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_pickupRotate != null)
		{
			object obj6 = this + 12;
			PickupRotate component = GetComponent<PickupRotate>();
			obj6 = component;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v136 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_pickupDefault != null)
		{
			object obj8 = this + 20;
			_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
			obj8 = componentInChildren;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v129 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_coinRenderer != null)
		{
			object obj10 = this + 24;
			_0021_00210 componentInChildren2 = (_0021_00210)((Component)this).GetComponentInChildren<T>();
			obj10 = componentInChildren2;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v122 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_collider != null)
		{
			object obj12 = this + 28;
			Collider component2 = GetComponent<Collider>();
			obj12 = component2;
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v115 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_trackObject != null)
		{
			object obj14 = this + 16;
			TrackObject component3 = GetComponent<TrackObject>();
			obj14 = component3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(Coin.TrackObject_OnActivate);
		object obj15 = action + 16;
		obj15 = this;
		_trackObject.OnActivate -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(Coin.TrackObject_OnDeactivate);
		object obj16 = action2 + 16;
		obj16 = this;
		_trackObject.OnDeactivate -= action2;
		nint num11 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v47 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num12 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v110 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj18 = this + 36;
		CharacterRendering instance = CharacterRendering.Instance;
		obj18 = instance;
		object obj19 = this + 40;
		GameObject gameObject = base.gameObject;
		obj19 = gameObject;
		GameObject gameObject2 = base.gameObject;
		nint num13 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v58 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num14 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v106 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 left = Vector3.left;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = vector / 6f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector)->z = 0f;
		InAppItemModel.BundleItem bundleItem = default;
		bundleItem._002Ector((InAppItemModel.ItemType)gameObject2, (Boards.BoardId)vector, HoverboardThemes.ThemeIdentifier.none);
		object obj21 = this + 48;
		obj21 = bundleItem;
		GameObject gameObject3 = base.gameObject;
		Vector3 left2 = Vector3.left;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector3 = vector / 6f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		InAppItemModel.BundleItem bundleItem2 = default;
		bundleItem2._002Ector((InAppItemModel.ItemType)gameObject3, (Boards.BoardId)vector, HoverboardThemes.ThemeIdentifier.heroboardTheme01);
		object obj22 = this + 52;
		obj22 = bundleItem2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(Coin.MagnetMovement_OnComplete);
		object obj23 = action3 + 16;
		obj23 = this;
		_coinMagnetMovement.OnComplete -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr4;
		((Delegate)action4).method = (nint)__ldftn(Coin.SuperSneakersMagnetMovement_OnComplete);
		object obj24 = action4 + 16;
		obj24 = this;
		_superSneakerMagnetMovement.OnComplete -= action4;
		nint num15 = (nint)typeof(CoinStats);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S0_v93 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num16 = (nint)typeof(CoinStats);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v100 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinStats coinStats = CoinStats.New;
		int num17 = coinStats.CreatedCoins__BackingField + 1;
		coinStats.CreatedCoins__BackingField = num17;
	}

	private void TrackObject_OnDeactivate()
	{
		//IL_000b: Expected Obj, but got I4
		Pickup((CharacterPickupParticles)1);
	}

	public void Pickup(CharacterPickupParticles pickupParticles)
	{
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I4
		//IL_00f4: Expected VT, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0103: Expected Obj, but got VT
		//IL_0111: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_0152: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		if (~(_active ? 1u : 0u) == 0)
		{
			return;
		}
		_active = true;
		if ((object)pickupParticles == null)
		{
			_trackObject.Deactivate();
		}
		GameObject gameObject = base.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v24 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		_collider.isTrigger = true;
		SetCurve((CoinCurve)1);
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		((CoinManager)val).NotifyCoinDeactivated(this);
		nint num3 = (nint)typeof(CoinStats);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v28 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(CoinStats);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v35 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinStats coinStats = CoinStats.New;
		int num5 = coinStats.ActivatedCoins__BackingField + 1;
		coinStats.ActivatedCoins__BackingField = num5;
	}

	private void MagnetMovement_OnComplete()
	{
		Activate(trackObjectActivated: true);
	}

	private void SuperSneakersMagnetMovement_OnComplete()
	{
		//IL_0019: Expected I4, but got Obj
		Character character = _character;
		((CoinCurve)this).ToggleRenderers((byte)(int)character.CharacterPickupParticleSystem != 0);
		_collider.isTrigger = true;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		((GameStats)(object)privacyPolicyUrl).ScoreBoosterTierIncrement();
	}

	public Coin()
	{
		//IL_0019: Expected I4, but got Obj
		Character character = _character;
		((CoinCurve)this).ToggleRenderers((byte)(int)character.CharacterPickupParticleSystem != 0);
		_collider.isTrigger = true;
	}
}
