using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Exceptions;
using SYBO.Common.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Pickups;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Routes;

public class RouteManager : SingletonMonobehavior<RouteManager>
{
	public enum ValueResetEvent
	{
		AppStart,
		GameStart,
		RunRevive
	}

	public class CharacterChunks
	{
		public RouteChunk Previous;

		public RouteChunk Current;

		public RouteChunk Next;

		public void Reset()
		{
			Next = null;
			Current = null;
			Previous = null;
		}

		public bool Contains(RouteChunk chunk)
		{
			bool flag = Previous != chunk;
			bool result = true;
			if (flag)
			{
				bool flag2 = Current != chunk;
				result = true;
				if (flag2)
				{
					bool flag3 = Next == chunk;
					result = flag3;
				}
			}
			return result;
		}
	}

	[Serializable]
	public class AlternateRouteConfig
	{
		public AlternateRoute Route;

		public bool Enabled = true;

		public int Weight = 1;
	}

	private class WeightedAlternateRouteConfig : WeightedObject<AlternateRouteConfig>
	{
		public WeightedAlternateRouteConfig(AlternateRouteConfig routeConfig, int weight)
		{
			_ = 1;
		}
	}

	public class RouteCreatedEventArgs(Route route) : EventArgs
	{
		public readonly Route Route = route;
	}

	public class RouteTransitionEventArgs : EventArgs
	{
		public readonly Route CurrentRoute;

		public readonly Route TransitionRoute;

		public readonly RouteType TransitionRouteType;

		public bool ExistsTransitionRoute => TransitionRoute != null;

		public RouteTransitionEventArgs(Route currentRoute, RouteType transitionRouteType, Route transitionRoute)
		{
			CurrentRoute = currentRoute;
			TransitionRoute = transitionRoute;
			TransitionRouteType = transitionRouteType;
		}

		public override string ToString()
		{
			return $"[RouteTransitionSkippedEventArgs (Current={CurrentRoute}, TransutionType={TransitionRoute}, TransutionRoute={TransitionRoute})]";
		}
	}

	public class CharacterRouteChangedEventArgs : EventArgs
	{
		private Route _fromRoute;

		private Route _toRoute;

		public Route FromRoute => _fromRoute;

		public bool HasFromRoute => _fromRoute != null;

		public Route ToRoute => _toRoute;

		public CharacterRouteChangedEventArgs(Route fromRoute, Route toRoute)
		{
			_fromRoute = fromRoute;
			_toRoute = toRoute;
		}

		public override string ToString()
		{
			return $"[CharacterRouteTypeChangedEventArgs (FromRouteType={_fromRoute}, ToRouteType={_toRoute})]";
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PickupSpawnPoint> _003C_003E9__97_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal unsafe int _003CPickupManager_OnPickupSpawnPointRegistered_003Eb__97_0(PickupSpawnPoint x, PickupSpawnPoint y)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0027: Expected native int or pointer, but got F4
			//IL_0066: Expected F4, but got I
			//IL_0061: Expected native int or pointer, but got F4
			//IL_009f: Expected F4, but got I
			//IL_009f: Expected Ref, but got F4
			object obj2 = default;
			object obj = obj2 - 32;
			float num = (float)obj + 24f;
			((float*)(nint)num)->m_value = 0f;
			_ = 0;
			Transform transform = x.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((float*)(nint)num)->m_value = 0f;
			Transform transform2 = y.transform;
			Vector3 position2 = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			return ((float*)num)->CompareTo(0f);
		}
	}

	private const string RoutePoolName = "Routes";

	public const int RouteBuilderHeight = 90;

	public const int FirstRouteStartPosZ = 0;

	public static string PrefabPath = "Assets/Resources/Prefabs/Managers/RouteManager.prefab";

	private Route _defaultRoute;

	private int _alternateRouteFirstOfferTime;

	private int _alternateRouteRepeatedOfferDelay;

	private int _alternateRouteRepeatedOfferDelayIncrement;

	private bool _limitAlternateOfferToHeadstart;

	private ValueResetEvent _alternateRouteOfferDelayResetEvent = ValueResetEvent.GameStart;

	private List<AlternateRouteConfig> _alternateRouteConfigs;

	private Route _benchmarkRoute;

	private RouteManagerConfigurationSO _routeManagerConfiguration;

	private Game _game;

	private Character _character;

	private Route _mainRoute;

	private Route _characterRoute;

	private CharacterChunks _characterChunksNear;

	private RouteCollection _routeCollection;

	private Vector3 _originPosition;

	private WeightRandomizedOrderedContainter<WeightedAlternateRouteConfig, AlternateRouteConfig> _alternateRouteConfigsEnabled;

	private float _timeInDefaultRoute;

	private float _alternateRouteRepeatedOfferDelayIncremented;

	private float _alternateRouteOfferDefaultRouteTimeNext;

	private bool _isWaitingForRouteChoice;

	private float _requriedOfferPositionZBeforeRouteOffer;

	private List<PickupSpawnPoint> _spawnPoints;

	private static bool UseBenchmarkRoute__BackingField;

	private EventHandler<RouteCreatedEventArgs> m_OnRouteCreated;

	private EventHandler<CharacterRouteChangedEventArgs> m_OnCharacterRouteChanged;

	private EventHandler<RouteTransitionEventArgs> m_OnRouteTransitionStarted;

	public Route DefaultRoute => _defaultRoute;

	public static bool UseBenchmarkRoute
	{
		private get
		{
			return UseBenchmarkRoute__BackingField;
		}
		set
		{
			UseBenchmarkRoute__BackingField = value;
		}
	}

	private bool IsPaused
	{
		get
		{
			bool flag = _game != null;
			bool result = true;
			if (flag)
			{
				Game game = _game;
				Variable<bool> isInGame = game.IsInGame;
				result = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v7 (Variable`1<System.Boolean>)+8]");
				if ((nint)0 == 0)
				{
					Game game2 = _game;
					result = game2._isPaused;
				}
			}
			return result;
		}
	}

	public ICollection<Route> Routes
	{
		get
		{
			RouteCollection routeCollection = _routeCollection;
			return routeCollection._routes;
		}
	}

	public Route MainRoute
	{
		get
		{
			return _mainRoute;
		}
		private set
		{
			_mainRoute = value;
		}
	}

	public Route CharacterRoute => _characterRoute;

	public CharacterChunks CharacterChunksNear => _characterChunksNear;

	public bool IsCharacterInAnyRoute => _characterRoute != null;

	public float TimeInDefaultRoute => _timeInDefaultRoute;

	private float AlternateRouteOfferDefaultRouteTimeNext
	{
		get
		{
			return _alternateRouteOfferDefaultRouteTimeNext;
		}
		set
		{
			_alternateRouteOfferDefaultRouteTimeNext = value;
		}
	}

	public event EventHandler<RouteCreatedEventArgs> OnRouteCreated
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 112;
			Delegate obj2 = this.m_OnRouteCreated;
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
			object obj = this + 112;
			Delegate obj2 = this.m_OnRouteCreated;
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

	public event EventHandler<CharacterRouteChangedEventArgs> OnCharacterRouteChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 116;
			Delegate obj2 = this.m_OnCharacterRouteChanged;
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
			object obj = this + 116;
			Delegate obj2 = this.m_OnCharacterRouteChanged;
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

	public event EventHandler<RouteTransitionEventArgs> OnRouteTransitionStarted
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 120;
			Delegate obj2 = this.m_OnRouteTransitionStarted;
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
			object obj = this + 120;
			Delegate obj2 = this.m_OnRouteTransitionStarted;
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

	protected unsafe override void Initialize()
	{
		//IL_0048: Expected F4, but got I4
		//IL_00b5: Expected VT, but got Obj
		Game instance = Game.Instance;
		_game = instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(RouteManager.Game_OnGameRevived));
		Game.OnGameRevived += action;
		Game game = _game;
		_character = game._character;
		_alternateRouteOfferDefaultRouteTimeNext = _alternateRouteFirstOfferTime;
		float alternateRouteRepeatedOfferDelayIncremented = (float)_alternateRouteRepeatedOfferDelay - (float)_alternateRouteRepeatedOfferDelayIncrement;
		_alternateRouteRepeatedOfferDelayIncremented = alternateRouteRepeatedOfferDelayIncremented;
		FilterAlternateRouteConfigs();
		RouteCollection routeCollection = default;
		routeCollection._002Ector(this);
		_routeCollection = routeCollection;
		if (SingletonMonobehavior<>.IsInstantiated)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			throw new ArgumentException();
		}
		ThemeManager instance2 = ThemeManager.Instance;
		instance2._theme.InitializeEnvironmentTransitions();
		ThemeManager instance3 = ThemeManager.Instance;
		instance3._theme.InitializeEnvironmentTransitions();
		UseBenchmarkRoute__BackingField = false;
	}

	private void FilterAlternateRouteConfigs(IList<RouteType> allowedRouteTypes = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		((WeightRandomizedOrderedContainter<, >)(object)_alternateRouteConfigsEnabled).Clear();
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
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
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
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v66+C]");
					if ((nint)0 == 0)
					{
						continue;
					}
					if (allowedRouteTypes == null)
					{
						goto IL_0155;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj8 == null)
							{
								continue;
							}
							goto IL_0155;
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
			goto IL_0245;
			IL_0155:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0245;
			IL_0245:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj9 == obj10;
			bool flag2 = !flag;
			object obj11 = obj12;
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
				obj11 = obj13;
			}
			_ = 0;
			object obj14 = obj + 16;
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
		object obj15 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A421");
	}

	public unsafe void Reset()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_007c: Expected I, but got Obj
		//IL_00f7: Expected VT, but got F4
		//IL_0125: Expected F4, but got I
		//IL_0120: Expected native int or pointer, but got VT
		//IL_0134: Expected F4, but got VT
		//IL_012f: Expected native int or pointer, but got VT
		//IL_002d: Expected F4, but got I4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		_routeCollection.RemoveAll();
		_characterRoute = null;
		_mainRoute = null;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float num3 = (float)Vector3.forwardVector * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
		float num4 = 0f * 0f;
		_isWaitingForRouteChoice = false;
		_timeInDefaultRoute = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		float num5 = 0f * 0f;
		_originPosition = (Vector3)num3;
		float requriedOfferPositionZBeforeRouteOffer = 6500f;
		if (!_limitAlternateOfferToHeadstart)
		{
			requriedOfferPositionZBeforeRouteOffer = 0f;
		}
		_requriedOfferPositionZBeforeRouteOffer = requriedOfferPositionZBeforeRouteOffer;
		((List<T>)(object)_spawnPoints).Clear();
		if (_alternateRouteOfferDelayResetEvent == ValueResetEvent.GameStart)
		{
			_alternateRouteOfferDefaultRouteTimeNext = _alternateRouteFirstOfferTime;
			float alternateRouteRepeatedOfferDelayIncremented = (float)_alternateRouteRepeatedOfferDelay - (float)_alternateRouteRepeatedOfferDelayIncrement;
			_alternateRouteRepeatedOfferDelayIncremented = alternateRouteRepeatedOfferDelayIncremented;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteManager)+50]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)_originPosition;
		Route mainRoute = CreateRoute(RouteType.Default, SectionSpawnMode.All, ChunkBuildMode.Normal, vector);
		_mainRoute = mainRoute;
		CharacterChunks characterChunksNear = _characterChunksNear;
		characterChunksNear.Next = null;
		characterChunksNear.Current = null;
		characterChunksNear.Previous = null;
		ChangeCharacterRoute(_mainRoute);
		UpdateRoutes(0f);
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0164: Expected F4, but got I
		//IL_0126: Expected I, but got Obj
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (IsPaused)
		{
			return;
		}
		UpdateCharacterRoute();
		int num = default;
		int num4 = default;
		while (true)
		{
			RouteCollection routeCollection = _routeCollection;
			List<Route> routes = routeCollection._routes;
			if (num >= routes._size)
			{
				break;
			}
			RouteCollection routeCollection2 = _routeCollection;
			Route route = routeCollection2._routes.get_Item(num);
			if (!route.CharacterEntered__BackingField && !route.CharacterSkippedEntry__BackingField)
			{
				Transform transform = route.transform;
				Vector3 position = transform.position;
				Transform transform2 = _character.transform;
				Vector3 position2 = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				if (num2 < 0)
				{
					nint num3 = (nint)route;
					object obj3 = route + 72;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S1_v27 (Il2CppClass<SYBO.Subway.Routes.Route>)+104] (should have been resolved before IL gen)");
				}
			}
			num = num4 + 1;
		}
		Vector3 currentTransformPosition = _character.CurrentTransformPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		UpdateRoutes(0f);
	}

	public bool IsModifierAllowedInCurrentRoute(CharacterModifier characterModifier)
	{
		//IL_0068: Expected VT, but got Obj
		//IL_0034: Expected I, but got Obj
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I4, but got Unknown
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UnityEngine.Object obj = default;
		if (obj != null)
		{
			nint num = (nint)characterModifier;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S1_v7 (Il2CppClass<CharacterModifier>)+E4] (should have been resolved before IL gen)");
			object obj2 = default;
			return (byte)(obj2 ^ 1) != 0;
		}
		return true;
	}

	public float GetRoutePositionOffsetY(RouteHeight routeHeight)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_007b: Expected F4, but got Obj
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		object obj3 = routeHeight - 1;
		if ((nint)obj3 >= 3)
		{
			_ = -1;
			obj = (Enum)(object)typeof(RouteHeight);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string missingSwitchValue = obj.ToString();
			SwitchDefaultException.Throw(missingSwitchValue);
			return 0f;
		}
		object obj4 = obj3 << 2;
		object obj5 = obj4 + 2293072;
		return (float)obj5;
	}

	private void UpdateRoutes(float characterPositionZ)
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0045: Expected F4, but got I4
		Route mainRoute = _mainRoute;
		nint num = (nint)mainRoute;
		object obj = mainRoute + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S3_v2 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		RouteBuilder routeBuilder = default;
		int spawnedLeadingEdgeWorldZ = routeBuilder.SpawnedLeadingEdgeWorldZ;
		RouteType routeType = EvaluateAlternateRouteOffer(characterPositionZ, spawnedLeadingEdgeWorldZ);
		if (routeType != RouteType.None)
		{
			CreateRouteTransition(routeType);
		}
		Game game = _game;
		_routeCollection.Update(characterPositionZ, game._randomGenerator);
	}

	private unsafe void UpdateCharacterRoute()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected VT, but got Unknown
		//IL_0063: Expected F4, but got I
		//IL_005e: Expected native int or pointer, but got VT
		//IL_0078: Expected F4, but got I
		//IL_0073: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		Vector3 currentTransformPosition = _character.CurrentTransformPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		_ = 0;
		Vector3 point = vector + 16;
		Route routeContainingPoint = _routeCollection.GetRouteContainingPoint(point);
		if (routeContainingPoint != _characterRoute)
		{
			ChangeCharacterRoute(routeContainingPoint);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		((Vector3*)(nint)vector)->x = 0f;
		UpdateCharacterNearChunks(_characterChunksNear, vector, routeContainingPoint);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj2 = default;
		if (obj2 != null)
		{
			float deltaTime = Time.deltaTime;
			float timeInDefaultRoute = _timeInDefaultRoute + deltaTime;
			_timeInDefaultRoute = timeInDefaultRoute;
		}
	}

	private unsafe void UpdateCharacterNearChunks(CharacterChunks charChunks, Vector3 charPosition, Route charRoute)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0040: Expected native int or pointer, but got VT
		//IL_0052: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		if (!(charRoute != null))
		{
			return;
		}
		nint num = (nint)charRoute;
		object obj2 = charRoute + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S1_v7 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		((Vector3*)(nint)vector)->z = charPosition.z;
		((Vector3*)(nint)vector)->x = charPosition.x;
		RouteBuilder routeBuilder = default;
		RouteChunk chunkContainingPoint = routeBuilder.GetChunkContainingPoint(vector);
		if (chunkContainingPoint != null)
		{
			if (charChunks.Current != chunkContainingPoint)
			{
				CharacterChunks characterChunksNear = _characterChunksNear;
				charChunks.Previous = characterChunksNear.Current;
				charChunks.Current = chunkContainingPoint;
				charChunks.Next = chunkContainingPoint.Next;
			}
			RouteChunk current = charChunks.Current;
			if (charChunks.Next != current.Next)
			{
				RouteChunk current2 = charChunks.Current;
				charChunks.Next = current2.Next;
			}
		}
	}

	private void ChangeCharacterRoute(Route route)
	{
		//IL_0051: Expected I, but got Obj
		Route route2 = default;
		if (route2 == null)
		{
		}
		if (_characterRoute != _mainRoute)
		{
			Route characterRoute = _characterRoute;
			_characterRoute = _mainRoute;
			if (_characterRoute != null)
			{
				nint num = (nint)characterRoute;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S2_v12 (Il2CppClass<UnityEngine.Object>)+114] (should have been resolved before IL gen)");
			}
			if (_characterRoute != null)
			{
				ProcessCharacterRouteEnter(_characterRoute, _characterRoute);
			}
			CharacterRouteChangedEventArgs e = default;
			e._002Ector(_characterRoute, _characterRoute);
			EventHandler<CharacterRouteChangedEventArgs> onCharacterRouteChanged = this.m_OnCharacterRouteChanged;
			if (this.m_OnCharacterRouteChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S0_v38 (System.EventHandler`1<SYBO.Subway.Routes.RouteManager+CharacterRouteChangedEventArgs>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	private void ProcessCharacterRouteEnter(Route route, Route previousRoute)
	{
		//IL_004e: Expected I, but got Obj
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0094: Expected I, but got Obj
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00c3: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UnityEngine.Object obj = default;
		if (obj != null)
		{
			_isWaitingForRouteChoice = false;
			float alternateRouteRepeatedOfferDelayIncremented = _alternateRouteRepeatedOfferDelayIncremented + (float)_alternateRouteRepeatedOfferDelayIncrement;
			_alternateRouteRepeatedOfferDelayIncremented = alternateRouteRepeatedOfferDelayIncremented;
			nint num = (nint)obj;
			object obj2 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
			RouteBuilder routeBuilder = default;
			if (routeBuilder.IsDone)
			{
				nint num2 = (nint)obj;
				object obj3 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S2_v10 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
				RouteBuilder routeBuilder2 = default;
				int spawnedLeadingEdgeWorldZ = routeBuilder2.SpawnedLeadingEdgeWorldZ;
				SetNextAlternateRouteOfferTimeFromPosition(spawnedLeadingEdgeWorldZ);
			}
		}
		route.NotifyCharacterEntered(_character, previousRoute);
	}

	private void ProcessCharacterRouteExited(Route route, Route nextRoute)
	{
		//IL_0008: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)route;
		object obj = route + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<SYBO.Subway.Routes.Route>)+114] (should have been resolved before IL gen)");
	}

	public Route GetRoutePrefab(RouteType routeType)
	{
		//IL_0017: Expected I, but got Obj
		if (~(UseBenchmarkRoute__BackingField ? 1u : 0u) != 0)
		{
			Route defaultRoute = _defaultRoute;
			nint num = (nint)defaultRoute;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S1_v5 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
			object obj = default;
			UnityEngine.Object obj2;
			if (obj == null)
			{
				obj2 = _defaultRoute;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
				bool flag = (nint)0 == 1;
				obj2 = defaultRoute;
				if (!flag)
				{
					throw new ArgumentException();
				}
			}
			bool flag2 = obj2 != null;
			Route result = null;
			if (flag2)
			{
				result = (Route)obj2;
			}
			return result;
		}
		return _benchmarkRoute;
	}

	private Route FindAlternateRoute(Predicate<Route> predicate)
	{
		WeightRandomizedOrderedContainter<WeightedAlternateRouteConfig, AlternateRouteConfig> alternateRouteConfigsEnabled = _alternateRouteConfigsEnabled;
		throw new ArgumentException();
	}

	public T GetRoutePrefab<T>() where T : Route
	{
		//IL_013a: Expected VT, but got I
		//IL_0064: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		object obj = default;
		if (typeFromHandle == obj)
		{
			Route defaultRoute = _defaultRoute;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v23+5C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v24+4]");
			bool flag = (nint)0 == 0;
			bool flag2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v24+4]");
			Predicate<Route> predicate = (Predicate<Route>)0;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				throw new ArgumentException();
			}
			Route defaultRoute = FindAlternateRoute(predicate);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		T result = default;
		return result;
	}

	private unsafe Route CreateRoute(Route routePrefab, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, Vector3 originPosition, RouteType previousRouteType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0143: Expected Obj, but got F4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0159: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		Route route = UnityEngine.Object.Instantiate(routePrefab);
		Game game = _game;
		_ = originPosition.z;
		obj = originPosition.x;
		object obj3 = obj - 16;
		nint num = (nint)route;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S0_v19 (Il2CppClass<SYBO.Subway.Routes.Route>)+EC] (should have been resolved before IL gen)");
		EventHandler eventHandler = default;
		eventHandler._002Ector(this, (nint)__ldftn(RouteManager.Route_OnDestructing));
		route.OnDestructing += eventHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UnityEngine.Object obj4 = default;
		if (obj4 != null)
		{
			throw new ArgumentException();
		}
		_routeCollection.Add(route);
		EventHandler<RouteCreatedEventArgs> onRouteCreated = this.m_OnRouteCreated;
		if (this.m_OnRouteCreated != null)
		{
			RouteCreatedEventArgs e = default;
			e._002Ector(route);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ S0_v39 (System.EventHandler`1<SYBO.Subway.Routes.RouteManager+RouteCreatedEventArgs>)+C] (should have been resolved before IL gen)");
		}
		return route;
	}

	public unsafe Route CreateRoute(RouteType routeType, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, Vector3 originPosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0029: Expected native int or pointer, but got VT
		//IL_003b: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		Route routePrefab = GetRoutePrefab(routeType);
		((Vector3*)(nint)vector)->z = originPosition.z;
		((Vector3*)(nint)vector)->x = originPosition.x;
		return CreateRoute(routePrefab, sectionSpawnMode, chunkBuildMode, vector, RouteType.None);
	}

	public Route CreateRouteAndConnect(RouteType routeType, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, Route routeConnectTo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0094: Expected I, but got Obj
		//IL_00ac: Expected I, but got Obj
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected I4, but got Unknown
		//IL_00e7: Expected I, but got Obj
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0120: Expected I, but got Obj
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0171: Expected I4, but got F4
		//IL_018b: Expected Obj, but got I4
		//IL_01a5: Expected VT, but got Obj
		//IL_0029: Expected I, but got Obj
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0049: Expected I, but got Obj
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		object obj = default;
		RouteManager routeManager = (RouteManager)(obj - 32);
		Route routePrefab = GetRoutePrefab(routeType);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		nint num3 = (nint)routeConnectTo;
		object obj2 = routeConnectTo + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S2_v3 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		RouteBuilder routeBuilder = default;
		int spawnedLeadingEdgeWorldZ = routeBuilder.SpawnedLeadingEdgeWorldZ;
		int alternateRouteFirstOfferTime = (int)(Vector3.forwardVector * spawnedLeadingEdgeWorldZ);
		nint num4 = (nint)routePrefab;
		object obj3 = routePrefab + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S2_v8 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		RouteManager routeManager2 = routeManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v8+10]");
		float routePositionOffsetY = routeManager2.GetRoutePositionOffsetY(RouteHeight.None);
		nint num5 = (nint)routeConnectTo;
		object obj4 = routeConnectTo + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S1_v11 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		int alternateRouteRepeatedOfferDelayIncrement = (int)((nint)0 * (nint)spawnedLeadingEdgeWorldZ);
		routeManager._alternateRouteRepeatedOfferDelayIncrement = alternateRouteRepeatedOfferDelayIncrement;
		_ = routeManager._alternateRouteRepeatedOfferDelayIncrement;
		routeManager._alternateRouteRepeatedOfferDelay = (int)routePositionOffsetY;
		routeManager._alternateRouteFirstOfferTime = alternateRouteFirstOfferTime;
		routeManager = (RouteManager)routeManager._alternateRouteFirstOfferTime;
		RouteType previousRouteType = default;
		Route route = CreateRoute(routePrefab, sectionSpawnMode, chunkBuildMode, (Vector3)routeManager, previousRouteType);
		nint num6 = (nint)routeConnectTo;
		object obj5 = routeConnectTo + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ S1_v24 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		nint num7 = (nint)route;
		object obj6 = route + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ S2_v21 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		object obj8 = default;
		object obj7 = obj8;
		object obj9 = obj8 + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v121 @ S2_v25+10C] (should have been resolved before IL gen)");
		return route;
	}

	private unsafe void CreateRouteTransition(RouteType transitionRouteType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008b: Expected I, but got Obj
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Ref, but got Unknown
		//IL_0024: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Route mainRoute = _mainRoute;
		nint num = (nint)mainRoute;
		object obj3 = mainRoute + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v5 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		RouteBuilder routeBuilder = default;
		if (routeBuilder.AddTransitionSectionTo(transitionRouteType, out *(RouteSection*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			IRouteTransitionTrigger transitionTrigger = ((RouteSection)0).GetTransitionTrigger();
			if (transitionTrigger != null)
			{
				Route route = CreateRouteAndConnect(transitionRouteType, SectionSpawnMode.OnlyEntry, ChunkBuildMode.Normal, _mainRoute);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			}
		}
	}

	public bool CanCreateRoute(RouteType routeType)
	{
		//IL_005b: Expected I, but got Obj
		Route defaultRoute = _defaultRoute;
		nint num = (nint)defaultRoute;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v4 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
		object obj = default;
		if (obj != null)
		{
			throw new ArgumentException();
		}
		return true;
	}

	public bool CanCreateRoute<T>()
	{
		//IL_0120: Expected VT, but got I
		//IL_0063: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		object obj = default;
		if (typeFromHandle == obj)
		{
			return true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v22+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v23+4]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v23+4]");
		Predicate<Route> predicate = (Predicate<Route>)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			throw new ArgumentException();
		}
		Route route = FindAlternateRoute(predicate);
		return route != null;
	}

	public void StartRouteTransition(Route targetRoute)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_000d: Expected I, but got Obj
		object obj = targetRoute - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v19 @ S3_v3+BC] (should have been resolved before IL gen)");
		if (this.m_OnRouteTransitionStarted != null)
		{
			nint num = (nint)targetRoute;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S1_v6 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
			RouteTransitionEventArgs e = default;
			RouteType transitionRouteType = default;
			e._002Ector(_characterRoute, transitionRouteType, targetRoute);
			EventHandler<RouteTransitionEventArgs> onRouteTransitionStarted = this.m_OnRouteTransitionStarted;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S0_v17 (System.EventHandler`1<SYBO.Subway.Routes.RouteManager+RouteTransitionEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	private float ComputeDefaultRouteTimeUntilPosition(float positionZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0057: Expected I, but got Obj
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_00c6: Expected I, but got Obj
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		float offsetGameStartTime = _game.OffsetGameStartTime;
		Vector3 currentTransformPosition = _character.CurrentTransformPosition;
		float num = positionZ;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num2 = num - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UnityEngine.Object obj3 = default;
		bool flag = obj3 != null;
		bool flag2 = !flag;
		float num3 = num2;
		float t = offsetGameStartTime;
		if (!flag2)
		{
			nint num4 = (nint)obj3;
			object obj4 = obj3 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v33+9C]");
			bool flag3;
			if ((nint)0 != 0)
			{
				flag3 = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v33+84]");
				flag3 = (nint)0 == 3;
			}
			bool flag4 = !flag3;
			num3 = num2;
			t = offsetGameStartTime;
			if (!flag4)
			{
				nint num5 = (nint)obj3;
				object obj5 = obj3 + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v118 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
				RouteBuilder routeBuilder = default;
				int spawnedLeadingEdgeWorldZ = routeBuilder.SpawnedLeadingEdgeWorldZ;
				Vector3 currentTransformPosition2 = _character.CurrentTransformPosition;
				float num6 = spawnedLeadingEdgeWorldZ;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				float val = num6 - 0f;
				float num7 = Math.Max(0f, val);
				Game game = _game;
				float num8 = num7 / game.__currentSpeed;
				float num9 = offsetGameStartTime + num8;
				float num10 = num2 - num7;
				num3 = num10;
				t = num9;
			}
		}
		bool flag5 = num3 < 0f;
		bool flag6 = !flag5;
		bool flag7 = !flag6;
		float result = 0f;
		if (!flag7)
		{
			float speedAtTime = _game.GetSpeedAtTime(t);
			float num11 = num3 / speedAtTime;
			result = num11;
		}
		return result;
	}

	private void SetNextAlternateRouteOfferTimeFromPosition(float positionZ)
	{
		float num = ComputeDefaultRouteTimeUntilPosition(positionZ);
		float num2 = _timeInDefaultRoute + num;
		float alternateRouteOfferDefaultRouteTimeNext = num2 + _alternateRouteRepeatedOfferDelayIncremented;
		_alternateRouteOfferDefaultRouteTimeNext = alternateRouteOfferDefaultRouteTimeNext;
	}

	public RouteType EvaluateAlternateRouteOffer(float characterPositionZ, float offerPositionZ)
	{
		//IL_002b: Expected Obj, but got I
		WeightRandomizedOrderedContainter<WeightedAlternateRouteConfig, AlternateRouteConfig> alternateRouteConfigsEnabled = _alternateRouteConfigsEnabled;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v3 (Il2CppRgctx<SYBO.Common.Utilities.WeightRandomizedOrderedContainter`2<SYBO.Subway.Routes.RouteManager+WeightedAlternateRouteConfig, SYBO.Subway.Routes.RouteManager+AlternateRouteConfig>>)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v4+4] (should have been resolved before IL gen)");
		return RouteType.None;
	}

	private void RaiseOnCharacterRouteChanged(object sender, CharacterRouteChangedEventArgs args)
	{
		EventHandler<CharacterRouteChangedEventArgs> onCharacterRouteChanged = this.m_OnCharacterRouteChanged;
		if (this.m_OnCharacterRouteChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.EventHandler`1<SYBO.Subway.Routes.RouteManager+CharacterRouteChangedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	private unsafe void Route_OnDestructing(object sender, EventArgs args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		EventHandler eventHandler = default;
		eventHandler._002Ector(this, (nint)__ldftn(RouteManager.Route_OnDestructing));
		Route route = default;
		route.OnDestructing -= eventHandler;
		throw new ArgumentException();
	}

	private void Game_OnGameRevived()
	{
		//IL_0036: Expected F4, but got I4
		if (_alternateRouteOfferDelayResetEvent == ValueResetEvent.RunRevive)
		{
			_alternateRouteRepeatedOfferDelayIncremented = _alternateRouteRepeatedOfferDelay;
		}
	}

	private void AlternateRouteBuilder_OnCompletedLayingSections(object sender, EventArgs args)
	{
		//IL_001c: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		if (~(_isWaitingForRouteChoice ? 1u : 0u) != 0)
		{
			RouteBuilder routeBuilder = default;
			int spawnedLeadingEdgeWorldZ = routeBuilder.SpawnedLeadingEdgeWorldZ;
			SetNextAlternateRouteOfferTimeFromPosition(spawnedLeadingEdgeWorldZ);
		}
	}

	private void AlternateRoute_CharacterEntrySkipped(object sender, Route.CharacterEntrySkippedEventArgs args)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003a: Expected Obj, but got I
		//IL_0050: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_isWaitingForRouteChoice = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5+10]");
		Vector3 position = ((Transform)0).position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		SetNextAlternateRouteOfferTimeFromPosition(0f);
	}

	private void PickupManager_OnPickupSpawnPointRegistered(PickupSpawnPoint spawnPoint)
	{
		if (spawnPoint.__spawnPointMode == SpawnPointMode.WillForcePickupType || spawnPoint._spawnPointDifficulty != SpawnPointDifficulty.Easy)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj = default;
		if (obj != null)
		{
			_spawnPoints.Add(spawnPoint);
			bool flag = _003C_003Ec._003C_003E9__97_0 == null;
			bool flag2 = !flag;
			Comparison<PickupSpawnPoint> comparison = _003C_003Ec._003C_003E9__97_0;
			if (!flag2)
			{
				throw new ArgumentException();
			}
			_spawnPoints.Sort(comparison);
		}
	}

	private void PickupManager_OnPickupSpawnPointDeregistered(PickupSpawnPoint spawnPoint)
	{
		if (_spawnPoints.Contains(spawnPoint))
		{
			bool flag = _spawnPoints.Remove(spawnPoint);
		}
	}

	private void PickupManager_OnPickupSpawned(object sender, PickupManager.PickupEventArgs args)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_002a: Expected Obj, but got I
		//IL_00df: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		List<PickupSpawnPoint> spawnPoints = _spawnPoints;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
		if (spawnPoints.Contains((PickupSpawnPoint)0))
		{
			List<PickupSpawnPoint> spawnPoints2 = _spawnPoints;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
			bool flag = spawnPoints2.Remove((PickupSpawnPoint)0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
		Component component = (Component)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v12 (UnityEngine.Component)+28]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v13+8]");
		if ((nint)0 != 8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v13+8]");
			if ((nint)0 == 2048)
			{
				Transform transform = component.transform;
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				float num = ComputeDefaultRouteTimeUntilPosition(0f);
				float num2 = _timeInDefaultRoute + num;
				if (num2 > _alternateRouteOfferDefaultRouteTimeNext)
				{
					_alternateRouteOfferDefaultRouteTimeNext = num2;
				}
			}
		}
		else
		{
			Transform transform2 = component.transform;
			Vector3 position2 = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			float requriedOfferPositionZBeforeRouteOffer = 0f + 3240f;
			_requriedOfferPositionZBeforeRouteOffer = requriedOfferPositionZBeforeRouteOffer;
		}
	}

	public RouteManager()
	{
		CharacterChunks characterChunksNear = default;
		_characterChunksNear = characterChunksNear;
		WeightRandomizedOrderedContainter<, > weightRandomizedOrderedContainter = default;
		weightRandomizedOrderedContainter._002Ector();
		_alternateRouteConfigsEnabled = (WeightRandomizedOrderedContainter<WeightedAlternateRouteConfig, AlternateRouteConfig>)(object)weightRandomizedOrderedContainter;
		List<PickupSpawnPoint> list = default;
		list._002Ector();
		_spawnPoints = list;
		base._002Ector();
	}
}
