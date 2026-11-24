using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Extensions;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.Utility;
using Kiloo.Plugins.Facebook;
using SYBO.Common;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Coins;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Placeholders;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.Routes.Builders.Worker;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using SYBO.Subway.Utilities;
using UnityEngine;

namespace SYBO.Subway.Routes;

public class RouteManager : SingletonMonoBehaviour<RouteManager>
{
	public enum ValueResetEvent
	{
		AppStart,
		GameStart,
		RunRevive
	}

	public class CharacterChunks
	{
		public string PreviousChunkReportedName;

		public RouteChunk Current;

		public RouteChunk Next;

		public void Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		public bool Contains(RouteChunk chunk)
		{
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Expected Obj, but got Unknown
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected Obj, but got Unknown
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Expected Obj, but got Unknown
			//IL_0029: Expected Obj, but got I
			//IL_0037: Expected I, but got Obj
			//IL_004d: Expected Obj, but got I
			//IL_0078: Expected I, but got Obj
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected Obj, but got Unknown
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected Obj, but got Unknown
			//IL_0136: Expected I, but got Obj
			//IL_014c: Expected Obj, but got I
			//IL_0177: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 36;
			object obj3 = obj2 + 24;
			object obj4 = obj2 + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj5 = default;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
				string previousChunkReportedName = PreviousChunkReportedName;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19+8]");
				object obj6 = 0;
				nint num = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v25 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num2 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v58 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int stringLength = previousChunkReportedName.m_stringLength;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v23+8]");
				bool flag;
				if ((nint)stringLength == 0)
				{
					char firstChar = previousChunkReportedName.m_firstChar;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v23+C]");
					flag = (nint)(int)firstChar == 0;
				}
				else
				{
					flag = false;
				}
				if (flag)
				{
					object obj8 = this + 12;
					obj4 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v18+8]");
					_ = 0;
					object obj10 = default;
					object obj9 = obj10 + 12;
					obj2 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v23+8]");
					_ = 0;
					nint num3 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v40 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num4 = (nint)typeof(EnvironmentBaseKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v50 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj3 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					_ = 0;
					obj = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8656");
					bool result = default;
					return result;
				}
				return false;
			}
			return false;
		}

		public CharacterChunks()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			//IL_002d: Expected Obj, but got I4
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			//IL_0041: Expected Obj, but got I4
			object obj = this + 8;
			obj = string.Empty;
			object obj2 = this + 16;
			obj2 = 0;
			object obj3 = this + 12;
			obj3 = 0;
		}
	}

	[Serializable]
	public class AlternateRouteConfig
	{
		public AlternateRoute Route;

		public bool Enabled;

		public int Weight;

		public AlternateRouteConfig()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = string.Empty;
		}
	}

	private class WeightedAlternateRouteConfig : WeightedObject<AlternateRouteConfig>
	{
		public unsafe WeightedAlternateRouteConfig(AlternateRouteConfig routeConfig, int weight)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0020: Expected Obj, but got I4
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = routeConfig;
			object obj2 = ((int*)weight)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [weight @ L2 (System.Int32)+8]");
			_ = 0;
			object obj3 = this + 12;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
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

		public bool ExistsTransitionRoute
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (byte)(int)TransitionRoute != 0;
			}
		}

		public RouteTransitionEventArgs(Route currentRoute, RouteType transitionRouteType, Route transitionRoute)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0026: Expected Obj, but got I4
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = currentRoute;
			object obj2 = this + 12;
			obj2 = transitionRouteType;
			object obj3 = this + 16;
			obj3 = transitionRoute;
		}

		public override string ToString()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (string)((ComputeShader)(object)TransitionRoute).FindKernel((string)null);
		}
	}

	public class CharacterRouteChangedEventArgs : EventArgs
	{
		private Route _fromRoute = (Route)1;

		private Route _toRoute;

		public Route FromRoute => (Route)(object)string.Format((IFormatProvider)(object)"[RouteTransitionSkippedEventArgs (Current={0}, TransutionType={1}, TransutionRoute={2})]", (string)(object)_fromRoute, _toRoute, _toRoute);

		public bool HasFromRoute
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (byte)(int)_fromRoute != 0;
			}
		}

		public Route ToRoute
		{
			get
			{
				//IL_0060: Expected I, but got Obj
				//IL_0076: Expected Obj, but got I
				//IL_00a3: Expected Obj, but got I4
				//IL_0013: Expected I, but got Obj
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (Route)((ComputeShader)(object)_fromRoute).FindKernel((string)null);
			}
		}

		public CharacterRouteChangedEventArgs(Route fromRoute, Route toRoute)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = fromRoute;
			_fromRoute = toRoute;
		}

		public override string ToString()
		{
			return (string)(object)_toRoute;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PickupSpawnPoint> _003C_003E9__90_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			RouteChunk._003C_003Ec obj = default;
			RouteChunk._003C_003Ec._003C_003E9 = obj;
		}

		internal int _003CPickupManager_OnPickupSpawnPointRegistered_003Eb__90_0(PickupSpawnPoint x, PickupSpawnPoint y)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected VT, but got Obj
			//IL_0047: Expected VT, but got Obj
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected Obj, but got Unknown
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected Obj, but got Unknown
			//IL_009c: Expected VT, but got I
			//IL_00ad: Expected I4, but got Obj
			Transform transform2 = default;
			Transform transform = (Transform)(transform2 + 12);
			GameObject gameObject = x.gameObject;
			transform.position = (Vector3)gameObject;
			GameObject gameObject2 = y.gameObject;
			transform2.position = (Vector3)gameObject2;
			Component component = (Component)(transform2 + 24);
			component = transform;
			((UnityEngine.Object)component).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
			Type type = (Type)(transform2 + 36);
			type = (Type)(object)transform2;
			type._impl = (RuntimeTypeHandle)(nint)((UnityEngine.Object)transform2).m_CachedPtr;
			return (int)SYBO.Common.Utilities.GameObjectUtil.GetComponentsInChildrenBFS(component, type);
		}
	}

	private const string RoutePoolName = "Routes";

	public const int RouteBuilderHeight = 90;

	public const int FirstRouteStartPosZ = 0;

	public static string PrefabPath;

	private EventHandler<RouteCreatedEventArgs> m_OnRouteCreated;

	private EventHandler<CharacterRouteChangedEventArgs> m_OnCharacterRouteChanged;

	private EventHandler<RouteTransitionEventArgs> m_OnRouteTransitionStarted;

	private Route _defaultRoute;

	private int _alternateRouteFirstOfferTime;

	private int _alternateRouteRepeatedOfferDelay;

	private int _alternateRouteRepeatedOfferDelayIncrement;

	private bool _limitAlternateOfferToHeadstart;

	private ValueResetEvent _alternateRouteOfferDelayResetEvent;

	private List<AlternateRouteConfig> _alternateRouteConfigs;

	private Route _benchmarkRoute;

	private static bool UseBenchmarkRoute__BackingField;

	private RouteManagerConfigurationSO _routeManagerConfiguration;

	private Game _game;

	private Character _character;

	private Route _mainRoute;

	private Route _characterRoute;

	private CharacterChunks _characterChunksNear;

	private RouteCollection _routeCollection;

	private Vector3 _originGamePosition;

	private WeightRandomizedOrderedContainter<WeightedAlternateRouteConfig, AlternateRouteConfig> _alternateRouteConfigsEnabled;

	private float _timeInDefaultRoute;

	private float _alternateRouteRepeatedOfferDelayIncremented;

	private float _alternateRouteOfferDefaultRouteTimeNext;

	private bool _isWaitingForRouteChoice;

	private float _requiredOfferGamePositionZBeforeRouteOffer;

	private List<PickupSpawnPoint> _spawnPoints;

	public Route DefaultRoute
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteManager)+8]");
			return (Route)0;
		}
	}

	public static bool UseBenchmarkRoute
	{
		private get
		{
			//IL_017c: Expected I, but got Obj
			//IL_0192: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01bf: Expected I4, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_012f: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (GameStateMachine._instance == null)
			{
				nint num3 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v30 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(GameStateMachine);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v35 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameStateMachine._002Ecctor();
			}
			nint num5 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v23 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)GameStateMachine._instance != 0;
		}
		set
		{
			//IL_004e: Expected Obj, but got I
			//IL_001a: Expected Obj, but got I
			//IL_002b: Expected VT, but got Obj
			//IL_002b: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Boolean)+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+C]");
			int num = 0;
			while (true)
			{
				int num2 = num - 1;
				if (num2 >= 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Boolean)+8]");
					Route route = ((List<Route>)0).get_Item(num2);
					((RouteCollection)value).DrawBounds((Bounds)route);
					num = num2;
					continue;
				}
				break;
			}
		}
	}

	private bool IsPaused
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_defaultRoute != 0;
		}
	}

	public ICollection<Route> Routes
	{
		get
		{
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected Obj, but got Unknown
			//IL_0105: Expected I, but got Obj
			//IL_011b: Expected Obj, but got I
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected Obj, but got Unknown
			//IL_0083: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected Obj, but got Unknown
			//IL_00e7: Expected Obj, but got I4
			//IL_005b: Expected Obj, but got I4
			object obj = this - -64;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)obj != null)
			{
				return (ICollection<Route>)1;
			}
			object obj3 = this - -64;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v14+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v15+8]");
			if ((nint)0 != 0)
			{
				return null;
			}
			object obj6 = this - -64;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v19+C4]");
			bool flag = (nint)0 != 0;
			return (ICollection<Route>)flag;
		}
	}

	public Route MainRoute
	{
		get
		{
			RouteCollection routeCollection = _routeCollection;
			return (Route)(object)routeCollection._routes;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Expected Obj, but got Unknown
			//IL_0237: Expected Obj, but got I4
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Expected Obj, but got Unknown
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Expected Obj, but got Unknown
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Expected Obj, but got Unknown
			//IL_02df: Expected Obj, but got I4
			//IL_0176: Expected Obj, but got I
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected Obj, but got Unknown
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			((WeightRandomizedOrderedContainter<, >)(object)_alternateRouteConfigsEnabled)._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			bool flag = (object)value == null;
			object obj5 = default;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v74+C]");
				if ((nint)0 == 0)
				{
					continue;
				}
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
					if (obj6 == null)
					{
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			object obj7 = obj4 + 4;
			object obj8 = obj7 + 1;
			obj7 = obj8;
			object obj9 = obj8 << 2;
			object obj10 = obj4 + obj9;
			obj10 = 111;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj4 + obj11;
				if ((nint)obj12 == 111)
				{
					object obj13 = obj4 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					return;
				}
			}
			object obj15 = default;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
	}

	public Route CharacterRoute => _mainRoute;

	public CharacterChunks CharacterChunksNear => (CharacterChunks)(object)_characterRoute;

	public bool IsCharacterInAnyRoute
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_characterChunksNear != 0;
		}
	}

	public float TimeInDefaultRoute
	{
		get
		{
			//IL_0017: Expected F4, but got I
			Vector3 gamePositionEnd = ((RouteChunk)(object)this).GamePositionEnd;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			return 0f;
		}
	}

	private float AlternateRouteOfferDefaultRouteTimeNext
	{
		get
		{
			return _timeInDefaultRoute;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Expected Obj, but got Unknown
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Expected Obj, but got Unknown
			//IL_02ec: Expected Obj, but got I4
			//IL_005c: Expected I, but got Obj
			//IL_0072: Expected Obj, but got I
			//IL_01d0: Expected Obj, but got I
			//IL_009d: Expected I, but got Obj
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Expected Obj, but got Unknown
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			GameObject gameObject = base.gameObject;
			object current = ((Transform.Enumerator)(object)gameObject).Current;
			object obj3 = default;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj3 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v81 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v94 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27");
				}
			}
			object obj6 = obj2 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj2 + obj8;
			obj9 = 75;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj10 = default;
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj2 + obj11;
				if ((nint)obj12 == 75)
				{
					object obj13 = obj2 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					return;
				}
			}
			object obj15 = default;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
	}

	public unsafe event EventHandler<RouteCreatedEventArgs> OnRouteCreated
	{
		add
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected Obj, but got Unknown
			//IL_0034: Expected Obj, but got I
			//IL_0049: Expected Obj, but got I
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected I4, but got Unknown
			//IL_0064: Expected I4, but got Obj
			Color green = Color.green;
			object obj = default;
			Uri uri = (Uri)(obj + 16);
			uri = (Uri)(object)value;
			Uri uri2 = uri;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Routes.RouteManager+RouteCreatedEventArgs>)+8]");
			uri2.m_String = (string)0;
			Uri uri3 = uri;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.EventHandler`1<SYBO.Subway.Routes.RouteManager+RouteCreatedEventArgs>)+10]");
			uri3.m_Syntax = (UriParser)0;
			bool flag = (byte)(obj + 40) != 0;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			((PurchaseValidationServer)null)._002Ector(uri, (IJsonSerializer)null, flag, 0.25f);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRouteCreated;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
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

	public event EventHandler<CharacterRouteChangedEventArgs> OnCharacterRouteChanged
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRouteCreated;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCharacterRouteChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
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

	public event EventHandler<RouteTransitionEventArgs> OnRouteTransitionStarted
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCharacterRouteChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRouteTransitionStarted;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
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

	protected override void SubclassInitialize()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected I4, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(RouteManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Routes.RouteManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RouteManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Subway.Routes.RouteManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (byte)(this & 1) != 0;
		UseBenchmarkRoute__BackingField = flag;
	}

	private void FilterAlternateRouteConfigs(IList<RouteType> allowedRouteTypes = null)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnRouteTransitionStarted;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)allowedRouteTypes);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 24;
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

	public unsafe void Reset()
	{
		//IL_031a: Expected I, but got Obj
		//IL_0330: Expected Obj, but got I
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_039c: Expected Obj, but got I4
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I
		//IL_008c: Expected F4, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_01ed: Expected I, but got Obj
		//IL_0203: Expected Obj, but got I
		//IL_0367: Expected Obj, but got I
		//IL_010c: Expected VT, but got Obj
		//IL_027e: Expected Obj, but got I
		//IL_028c: Expected I, but got Obj
		//IL_02a2: Expected Obj, but got I
		//IL_022e: Expected I, but got Obj
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got VT
		//IL_0152: Expected VT, but got Obj
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got VT
		//IL_02cd: Expected I, but got Obj
		//IL_019d: Expected VT, but got Obj
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got VT
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v67 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this - -64;
		bool isInstantiated = Game.IsInstantiated;
		obj2 = isInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(RouteManager.Game_OnGameRevived);
		object obj3 = action + 16;
		obj3 = this;
		Game.OnGameRevived -= action;
		object obj4 = this + 68;
		object obj5 = this - -64;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v16+88]");
		obj4 = 0;
		_alternateRouteOfferDefaultRouteTimeNext = _alternateRouteFirstOfferTime;
		float alternateRouteRepeatedOfferDelayIncremented = (float)_alternateRouteRepeatedOfferDelay - (float)_alternateRouteRepeatedOfferDelayIncrement;
		_alternateRouteRepeatedOfferDelayIncremented = alternateRouteRepeatedOfferDelayIncremented;
		MainRoute = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RouteCollection routeCollection = default;
		routeCollection.Add(null);
		object obj7 = this + 84;
		obj7 = routeCollection;
		if (SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			Action<PickupSpawnPoint> action2 = default;
			object obj8 = action2 + 16;
			obj8 = this;
			((PickupManager)val).OnPickupSpawnPointRegistered -= action2;
			_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			_ = 0;
			Action<PickupSpawnPoint> action3 = default;
			object obj9 = action3 + 16;
			obj9 = this;
			((PickupManager)val2).OnPickupSpawnPointDeregistered -= action3;
			_00210 val3 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			EventHandler<PickupManager.PickupEventArgs> eventHandler = default;
			object obj10 = eventHandler + 16;
			obj10 = this;
			((PickupManager)val3).OnPickupSpawned -= eventHandler;
		}
		nint num6 = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v34 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num7 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v54 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameStateMachine instance = GameStateMachine.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v39 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		((Theme)0).PrepoolPrefabs();
		GameStateMachine instance2 = GameStateMachine.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v42 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		((Theme)0).PrepoolPrefabs();
		nint num8 = (nint)typeof(RouteManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v45 (Il2CppClass<SYBO.Subway.Routes.RouteManager>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num9 = (nint)typeof(RouteManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v50 (Il2CppClass<SYBO.Subway.Routes.RouteManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @810D");
	}

	private unsafe void Update()
	{
		//IL_00b3: Expected I4, but got Obj
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00db: Expected Obj, but got I4
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected VT, but got Unknown
		//IL_014e: Expected F4, but got Obj
		//IL_0149: Expected native int or pointer, but got VT
		//IL_0163: Expected F4, but got I
		//IL_015e: Expected native int or pointer, but got VT
		//IL_0182: Expected F4, but got Obj
		//IL_017d: Expected native int or pointer, but got VT
		//IL_0197: Expected F4, but got I
		//IL_0192: Expected native int or pointer, but got VT
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01af: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_0253: Expected F4, but got Obj
		//IL_024e: Expected native int or pointer, but got VT
		//IL_0268: Expected F4, but got I
		//IL_0263: Expected native int or pointer, but got VT
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_028c: Expected Obj, but got VT
		//IL_02af: Expected I4, but got Obj
		//IL_007a: Expected F4, but got I4
		UseBenchmarkRoute = (byte)(int)_routeCollection != 0;
		object obj = this + 76;
		obj = 0;
		object obj2 = this + 72;
		obj2 = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v52 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 12;
		Vector3 back = Vector3.back;
		Vector3 vector = (Vector3)(obj5 + 24);
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = vector / 0f;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		object obj6 = this + 88;
		obj6 = vector.x;
		_ = vector.z;
		_timeInDefaultRoute = 0f;
		_isWaitingForRouteChoice = false;
		float requiredOfferGamePositionZBeforeRouteOffer = ((~(_limitAlternateOfferToHeadstart ? 1u : 0u) != 0) ? 0f : 6500f);
		_requiredOfferGamePositionZBeforeRouteOffer = requiredOfferGamePositionZBeforeRouteOffer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		if (_alternateRouteOfferDelayResetEvent == ValueResetEvent.GameStart)
		{
			_alternateRouteOfferDefaultRouteTimeNext = _alternateRouteFirstOfferTime;
			float alternateRouteRepeatedOfferDelayIncremented = (float)_alternateRouteRepeatedOfferDelay - (float)_alternateRouteRepeatedOfferDelayIncrement;
			_alternateRouteRepeatedOfferDelayIncremented = alternateRouteRepeatedOfferDelayIncremented;
		}
		object obj7 = this + 88;
		obj4 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v36+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		object obj8 = this + 72;
		Route route = CreateRouteAndConnect(RouteType.Default, SectionSpawnMode.All, ChunkBuildMode.Normal, (Route)vector);
		obj8 = route;
		_characterChunksNear._002Ector();
		CreateRouteTransition((RouteType)_mainRoute);
		SetNextAlternateRouteOfferTimeFromGamePosition(0f);
	}

	public bool IsModifierAllowedInCurrentRoute(CharacterModifier characterModifier)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02e6: Expected Obj, but got I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0303: Expected Obj, but got I4
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 56;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 32;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = obj;
		_ = -1;
		object obj6 = obj2 + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+8]");
		_ = 0;
		object obj7 = default;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
				_ = 0;
				obj6 = characterModifier;
				_ = ((UnityEngine.Object)characterModifier).m_CachedPtr;
				_ = characterModifier._paused;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj8 != null)
				{
					object obj9 = obj5 + 4;
					object obj10 = obj9 + 1;
					obj9 = obj10;
					object obj11 = obj10 << 2;
					object obj12 = obj5 + obj11;
					obj12 = 75;
					break;
				}
				continue;
			}
			object obj13 = obj5 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj5 + obj15;
			obj16 = 75;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj5 + obj17;
			if ((nint)obj18 == 75)
			{
				object obj19 = obj5 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_03c7;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03c7;
		IL_03c7:
		bool result = default;
		return result;
	}

	public unsafe float GetRoutePositionOffsetY(RouteHeight routeHeight)
	{
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01bb: Expected Obj, but got I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0212: Expected Obj, but got I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected VT, but got Unknown
		//IL_0265: Expected F4, but got Obj
		//IL_0260: Expected native int or pointer, but got VT
		//IL_027a: Expected F4, but got I
		//IL_0275: Expected native int or pointer, but got VT
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_002c: Expected F4, but got I4
		//IL_0027: Expected native int or pointer, but got VT
		//IL_0041: Expected F4, but got I
		//IL_003c: Expected native int or pointer, but got VT
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00d7: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected VT, but got Unknown
		//IL_02b9: Expected F4, but got Obj
		//IL_02b4: Expected native int or pointer, but got VT
		//IL_02ce: Expected F4, but got I
		//IL_02c9: Expected native int or pointer, but got VT
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected VT, but got Unknown
		//IL_02e9: Expected F4, but got Obj
		//IL_02e4: Expected native int or pointer, but got VT
		//IL_02fe: Expected F4, but got I
		//IL_02f9: Expected native int or pointer, but got VT
		//IL_030b: Expected F4, but got Obj
		//IL_0306: Expected native int or pointer, but got VT
		//IL_0320: Expected F4, but got I
		//IL_031b: Expected native int or pointer, but got VT
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0365: Expected F4, but got Obj
		//IL_0360: Expected native int or pointer, but got VT
		//IL_037a: Expected F4, but got I
		//IL_0375: Expected native int or pointer, but got VT
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_03aa: Expected Obj, but got F4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_0411: Expected I, but got Obj
		//IL_0427: Expected Obj, but got I
		//IL_0451: Expected F4, but got Obj
		//IL_044c: Expected native int or pointer, but got VT
		//IL_0466: Expected F4, but got I
		//IL_0461: Expected native int or pointer, but got VT
		//IL_0473: Expected F4, but got Obj
		//IL_046e: Expected native int or pointer, but got VT
		//IL_0488: Expected F4, but got I
		//IL_0483: Expected native int or pointer, but got VT
		//IL_0118: Expected I, but got Obj
		//IL_0165: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 168;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 156;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 144;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 132;
		obj5 = 0;
		_ = 0;
		Camera current = Camera.current;
		object obj6 = obj2 + 120;
		Vector2 mouseScrollDelta = Input.mouseScrollDelta;
		obj = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+8]");
		_ = 0;
		Vector3 vector = (Vector3)(obj2 + 204);
		((Vector3*)(nint)vector)->x = (float)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteManager)+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj7 = obj2 + 108;
		Vector3 vector2 = current.WorldToViewportPoint(vector);
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = ((RouteHeight*)(int)routeHeight)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [routeHeight @ L1 (SYBO.Subway.Routes.RouteHeight)+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj8 = obj2 + 96;
		Vector3 vector3 = current.WorldToViewportPoint(vector);
		object obj9 = obj2 + 84;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj10 = obj2 + 72;
		obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v36+8]");
		_ = 0;
		object obj11 = obj2 + 60;
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num = (nint)typeof(Math3D);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v47 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num2 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v99 (Il2CppClass<SYBO.Common.Math3D>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector4 = (Vector3)(obj2 + 180);
		((Vector3*)(nint)vector4)->x = (float)obj9;
		Vector3 vector5 = vector4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v38+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		Vector3 vector6 = (Vector3)(obj2 + 192);
		((Vector3*)(nint)vector6)->x = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v41+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v44+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj13 = obj2 + 48;
		Vector3 vector7 = Math3D.ProjectPointOnPlane(vector4, vector6, vector);
		obj4 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v60+8]");
		_ = 0;
		((Vector3*)(nint)vector4)->x = (float)obj13;
		Vector3 vector8 = vector4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v60+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		object obj14 = obj2 + 36;
		obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		obj4 = vector4.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v68+4]");
		_ = 0;
		_ = 0f;
		object obj15 = obj2 + 24;
		obj15 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj16 = obj2 + 12;
		obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v82 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v95 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector6)->x = (float)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v76+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v79+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector6, vector);
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		float result = default;
		return result;
	}

	private void UpdateRoutes(float characterGamePositionZ)
	{
		_alternateRouteOfferDefaultRouteTimeNext = characterGamePositionZ;
	}

	private void UpdateCharacterRoute()
	{
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01f3: Expected F4, but got I
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_026f: Expected VT, but got Obj
		//IL_026f: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0110: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		ICollection<Route> routes = Routes;
		if (routes != null)
		{
			return;
		}
		Game_OnGameRevived();
		int num = default;
		int num5 = default;
		while (true)
		{
			RouteCollection routeCollection = _routeCollection;
			List<Route> routes2 = routeCollection._routes;
			if (num >= routes2._size)
			{
				break;
			}
			RouteCollection routeCollection2 = _routeCollection;
			Route route = routeCollection2._routes.get_Item(num);
			if (~(route.CharacterEntered__BackingField ? 1u : 0u) != 0 && ~(route.CharacterSkippedEntry__BackingField ? 1u : 0u) != 0)
			{
				nint num2 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v37 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num3 = (nint)typeof(GamePositionRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v46 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isRestricted = AgeRestriction.isRestricted;
				GameObject gameObject = route.gameObject;
				Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
				object obj4 = _character + 236;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S2_v12+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				if (num4 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				}
			}
			num = num5 + 1;
		}
		object obj5 = _character + 236;
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v14+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		SetNextAlternateRouteOfferTimeFromGamePosition(0f);
	}

	private void UpdateCharacterNearChunks(CharacterChunks charChunks, Vector3 characterGamePosition, Route charRoute)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got VT
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		object obj = this + 116;
		obj = charChunks;
		object obj2 = this + 120;
		obj2 = characterGamePosition;
		object obj3 = this + 124;
		obj3 = charRoute;
	}

	private void ChangeCharacterRoute(Route route)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 72;
		obj = route;
	}

	private unsafe void ProcessCharacterRouteEnter(Route route, Route previousRoute)
	{
		//IL_001a: Expected Obj, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected I4, but got Unknown
		//IL_0047: Expected I4, but got Obj
		((Uri)(object)route).m_String = (string)(nint)((UnityEngine.Object)route).m_CachedPtr;
		((Uri)(object)route).m_Syntax = (UriParser)(object)route.OnCharacterEntrySkipped;
		bool flag = (byte)(route + 24) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)previousRoute != 0;
		_ = ((UnityEngine.Object)previousRoute).m_CachedPtr;
		((PurchaseValidationServer)null)._002Ector((Uri)(object)route, (IJsonSerializer)null, flag, 0.25f);
	}

	private void ProcessCharacterRouteExited(Route route, Route nextRoute)
	{
		//IL_00f2: Expected I, but got Obj
		//IL_0108: Expected Obj, but got I
		//IL_015f: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00d5: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			_isWaitingForRouteChoice = false;
			float alternateRouteRepeatedOfferDelayIncremented = _alternateRouteRepeatedOfferDelayIncremented + (float)_alternateRouteRepeatedOfferDelayIncrement;
			_alternateRouteRepeatedOfferDelayIncremented = alternateRouteRepeatedOfferDelayIncremented;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			RouteBuilder routeBuilder = default;
			if (routeBuilder.IsDoneLayingSections)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				RouteBuilder routeBuilder2 = default;
				int spawnedLeadingEdgeWorldPositionZ = routeBuilder2.SpawnedLeadingEdgeWorldPositionZ;
				((ConstrainingRouteBuilder)(object)this).UpdateBuilder((float)spawnedLeadingEdgeWorldPositionZ);
			}
		}
		Vector3 relativePosition = ((Route)(object)_character).GetRelativePosition((Vector3)nextRoute);
	}

	public Route GetRoutePrefab(RouteType routeType)
	{
		//IL_0083: Expected VT, but got Obj
		//IL_0091: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I4
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			return (Route)((CharacterModifier)routeType).Current;
		}
		return (Route)1;
	}

	private Route FindAlternateRoute(Predicate<Route> predicate)
	{
		//IL_01ad: Expected I, but got Obj
		//IL_01c3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0215: Expected I, but got Obj
		//IL_022b: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_013a: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(RouteManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Routes.RouteManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RouteManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v54 (Il2CppClass<SYBO.Subway.Routes.RouteManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @811E");
		object obj2 = default;
		if (obj2 != null)
		{
			return _benchmarkRoute;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		object obj3 = default;
		UnityEngine.Object obj4;
		if (obj3 == null)
		{
			obj4 = _defaultRoute;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			bool flag = (nint)0 != 1;
			bool flag2 = !flag;
			obj4 = _defaultRoute;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = 0;
				_ = 0;
				RouteType routeType = default;
				object obj5 = routeType + 16;
				object obj6 = default;
				obj5 = obj6;
				bool flag3 = CanCreateRoute(routeType);
				obj4 = (UnityEngine.Object)flag3;
			}
		}
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (obj4 != null)
		{
			return null;
		}
		return (Route)obj4;
	}

	public T GetRoutePrefab<T>() where T : Route
	{
		//IL_013c: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0193: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00be: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6+C]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S2_v5 (should have been resolved before IL gen)");
		object obj7 = 0;
		object obj8 = default;
		string value = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S4_v3+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S4_v4+10]");
			object obj11 = 0;
			object obj12 = obj11 & 0x1FFF;
			object obj13 = obj12 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S5_v5 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			StringBuilder stringBuilder2 = stringBuilder.AppendLine(value);
			object obj14 = obj8 - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
			{
				CharacterController charactercontroller = Game.Charactercontroller;
				StringBuilder stringBuilder3 = stringBuilder.Append((int)charactercontroller);
			}
			object obj15 = obj7 + 1;
			obj7 = obj15;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string item = default;
		list.Add(item);
		return (T)(object)list;
	}

	private Route CreateRoute(Route routePrefab, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, Vector3 originGamePosition, RouteType previousRouteType)
	{
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_01e3: Expected I, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I4
		//IL_0224: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		object obj3 = originGamePosition | previousRouteType;
		Route route = ((previousRouteType == RouteType.None) ? ((Route)1) : ((Route)3));
		bool flag = obj3 == null;
		bool flag2 = !flag;
		Route result = route;
		if (!flag2)
		{
			if (_alternateRouteFirstOfferTime <= (nint)routePrefab)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			object obj4 = sectionSpawnMode - routePrefab;
			object obj5 = obj4 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [chunkBuildMode @ L3 (SYBO.Subway.Routes.Builders.ChunkBuildMode)+C]");
			object obj6;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [chunkBuildMode @ L3 (SYBO.Subway.Routes.Builders.ChunkBuildMode)+18]");
				obj6 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [chunkBuildMode @ L3 (SYBO.Subway.Routes.Builders.ChunkBuildMode)+14]");
				obj6 = 0;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				if (obj5 == obj6)
				{
					return (Route)3;
				}
				return (Route)2;
			}
			nint num = (nint)typeof(DebugQueuedEnvironments);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v27 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(DebugQueuedEnvironments);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v60 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, string> selected = DebugQueuedEnvironments.GetSelected();
			if (selected == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			result = (Route)3;
		}
		return result;
	}

	public unsafe Route CreateRoute(RouteType routeType, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, Vector3 originGamePosition)
	{
		//IL_024f: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got F4
		//IL_0169: Expected VT, but got I4
		//IL_0169: Expected VT, but got I4
		//IL_0169: Expected VT, but got Obj
		//IL_017a: Expected F4, but got I4
		//IL_0175: Expected native int or pointer, but got VT
		//IL_023a: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		//IL_0148: Expected VT, but got I4
		//IL_0148: Expected VT, but got I
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_01ae: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I
		float num = (float)routeType * 90f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sectionSpawnMode @ L2 (SYBO.Subway.Routes.Builders.SectionSpawnMode)+C]");
		if ((nint)0 == 0)
		{
			ChunkBuildMode chunkBuildMode2 = default;
			object obj = chunkBuildMode2 - 1;
			if (chunkBuildMode2 != ChunkBuildMode.Normal && (nint)obj != 1 && (nint)obj == 2)
			{
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sectionSpawnMode @ L2 (SYBO.Subway.Routes.Builders.SectionSpawnMode)+8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v6+8]");
		object obj3 = -2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v6+8]");
		bool flag;
		if ((nint)0 == 2 || ((nint)obj3 != 1 && (nint)obj3 == 2))
		{
			flag = true;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v6+8]");
			flag = (nint)0 == 16;
		}
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sectionSpawnMode @ L2 (SYBO.Subway.Routes.Builders.SectionSpawnMode)+8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v16+8]");
			((RouteCollection)(object)this).DrawBounds((Bounds)0, (Color)2, num);
		}
		int num2 = Physics2D.Raycast((Vector2)this, (Vector2)sectionSpawnMode, (ContactFilter2D)2, (RaycastHit2D[])originGamePosition.x, num);
		((Vector3*)(nint)originGamePosition)->x = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sectionSpawnMode @ L2 (SYBO.Subway.Routes.Builders.SectionSpawnMode)+C]");
		object obj6;
		if ((nint)0 != 0)
		{
			object obj5 = 2 - 1;
			if (2 == 1 || ((nint)obj5 != 1 && (nint)obj5 == 2))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sectionSpawnMode @ L2 (SYBO.Subway.Routes.Builders.SectionSpawnMode)+18]");
				obj6 = 0;
				goto IL_02a3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sectionSpawnMode @ L2 (SYBO.Subway.Routes.Builders.SectionSpawnMode)+14]");
		obj6 = 0;
		goto IL_02a3;
		IL_02a3:
		return (Route)(object)(obj6 + routeType);
	}

	public unsafe Route CreateRouteAndConnect(RouteType routeType, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, Route routeConnectTo)
	{
		//IL_000a: Expected Obj, but got I4
		//IL_001b: Expected I4, but got Obj
		//IL_0040: Expected I4, but got Obj
		Route route = FindAlternateRoute((Predicate<Route>)routeType);
		int num = default;
		((int*)num)->m_value = (int)routeConnectTo;
		_ = ((UnityEngine.Object)routeConnectTo).m_CachedPtr;
		return (Route)(object)Connection.Open((string)(object)this, (int)route, (byte)sectionSpawnMode != 0, (int)chunkBuildMode, num);
	}

	private void CreateRouteTransition(RouteType transitionRouteType)
	{
		//IL_0241: Expected I, but got Obj
		//IL_0257: Expected Obj, but got I
		//IL_0319: Expected Obj, but got I4
		//IL_0282: Expected I, but got Obj
		//IL_0298: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c2: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_0167: Expected I, but got Obj
		//IL_017d: Expected Obj, but got I
		//IL_0103: Expected I, but got Obj
		//IL_021d: Expected I4, but got Obj
		//IL_021d: Expected I4, but got Obj
		//IL_01a8: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RouteType routeType = default;
		if (!((UnityEngine.Object)routeType != null))
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		if (((ComputeShader)(object)_characterRoute).FindKernel((string)(object)_mainRoute) == 0)
		{
			return;
		}
		object obj3 = this + 76;
		obj3 = _mainRoute;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_characterRoute).FindKernel((string)null) != 0)
		{
			((RouteManager)null).RaiseOnCharacterRouteChanged((object)_characterRoute, (CharacterRouteChangedEventArgs)(object)_characterRoute);
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_characterRoute).FindKernel((string)null) != 0)
		{
			ProcessCharacterRouteExited(_characterRoute, _characterRoute);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RouteSection.RepeatConfiguration repeatConfiguration = default;
		repeatConfiguration.NotifySectionSpawn((int)_characterRoute, (int)_characterRoute);
		Route_OnDestructing(null, (EventArgs)(object)repeatConfiguration);
	}

	public bool CanCreateRoute(RouteType routeType)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = routeType;
		WeightRandomizedOrderedContainter<WeightedAlternateRouteConfig, AlternateRouteConfig> alternateRouteConfigsEnabled = _alternateRouteConfigsEnabled;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = obj2;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v8 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v9+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v10+2C]");
		object obj7 = 0;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S3_v4 (should have been resolved before IL gen)");
		object obj10 = default;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v12+C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v18+8]");
			return false;
		}
		return false;
	}

	public unsafe bool CanCreateRoute<T>()
	{
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0219: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I
		//IL_0251: Expected I, but got Obj
		//IL_0267: Expected Obj, but got I
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected I, but got Unknown
		//IL_02a7: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02fd: Expected Obj, but got I
		//IL_005c: Expected I4, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_0372: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I
		//IL_03ac: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
		nint num = default;
		object obj3 = num + 24;
		object obj4 = obj3;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11 (Il2CppClass<System.Type>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v39 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = obj4;
		nint num4 = (nint)(obj2 + 8);
		((IntPtr*)num4)->m_value = (void*)(nint)obj2;
		Type type = Type.internal_from_handle((IntPtr)num4);
		object obj6 = default;
		if (obj6 == type)
		{
			bool flag = (byte)(int)_defaultRoute != 0;
		}
		else
		{
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v20+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				object obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v75+74]");
				if ((nint)0 == 0)
				{
					object obj10 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v27+5C]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v28+4]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v28+4]");
			RouteType routeType = RouteType.None;
			if (!flag3)
			{
				object obj13 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v37+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					object obj15 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v65+74]");
					if ((nint)0 == 0)
					{
						object obj16 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj17 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v44+5C]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj19 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v31+C]");
				object obj20 = 0;
				RouteType routeType2 = default;
				object obj21 = routeType2 + 16;
				obj21 = obj18;
				object obj22 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v59+5C]");
				object obj23 = (nint)0 + (nint)4;
				obj23 = routeType2;
				routeType = routeType2;
			}
			bool flag = CanCreateRoute(routeType);
		}
		object obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		bool result = default;
		return result;
	}

	public void StartRouteTransition(Route targetRoute)
	{
		//IL_0065: Expected Obj, but got I4
		//IL_0049: Expected I4, but got Obj
		//IL_0049: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		MovingTrainPlaceholder movingTrainPlaceholder = default;
		Transform transform = movingTrainPlaceholder.InitializeSpawnedInstance((Transform)(object)targetRoute, text);
		if ((object)transform != null)
		{
			string text2 = ((RouteSection)(object)text).ToString();
			if (text2 != null)
			{
				bool flag = ((FacebookSession)(object)this)._GraphRequest((string)(object)targetRoute, (IDictionary<string, object>)2, (string)1, (int)_mainRoute);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			}
		}
	}

	private float ComputeDefaultRouteTimeUntilPosition(float gamePositionZ)
	{
		//IL_0016: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteManager)+94]");
		return UIExtensions.CenterChildrenHorizontally((Transform[])(object)this, gamePositionZ, (Transform)0);
	}

	private void SetNextAlternateRouteOfferTimeFromGamePosition(float gamePositionZ)
	{
		//IL_0026: Expected F4, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0084: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		RouteBuilder routeBuilder = default;
		int spawnedLeadingEdgeWorldPositionZ = routeBuilder.SpawnedLeadingEdgeWorldPositionZ;
		IConstrainingRouteBuilder constrainingBuilderAt = ((RouteBuilder)(object)this).GetConstrainingBuilderAt((float)spawnedLeadingEdgeWorldPositionZ);
		if (constrainingBuilderAt != null)
		{
			StartRouteTransition((Route)constrainingBuilderAt);
		}
		object obj = this - -64;
		object obj2 = obj;
		RouteCollection routeCollection = _routeCollection;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v8+CC]");
		((CoinCurve)(object)routeCollection).DrawCurve(gamePositionZ, (Color)0);
	}

	public RouteType EvaluateAlternateRouteOffer(float offerGamePositionZ)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		RouteType routeType = default;
		object obj = routeType + 16;
		obj = this;
		return routeType;
	}

	private void RaiseOnCharacterRouteChanged(object sender, CharacterRouteChangedEventArgs args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	private void Route_OnDestructing(object sender, EventArgs args)
	{
		if (this.m_OnCharacterRouteChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	private unsafe void Game_OnGameRevived()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected VT, but got Unknown
		//IL_0158: Expected VT, but got Obj
		//IL_0153: Expected native int or pointer, but got VT
		//IL_0186: Expected I, but got Obj
		//IL_019c: Expected Obj, but got I
		//IL_006e: Expected VT, but got Obj
		//IL_0069: Expected native int or pointer, but got VT
		//IL_0091: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_005c: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		object obj3 = _character + 236;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v8+8]");
		_ = 0;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Bounds bounds = (Bounds)(obj2 + 24);
		((Bounds*)(nint)bounds)->m_Center = (Vector3)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Route routeContainingBounds = _routeCollection.GetRouteContainingBounds(bounds);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)routeContainingBounds).FindKernel((string)(object)_characterRoute) != 0)
		{
			CreateRouteTransition((RouteType)routeContainingBounds);
		}
		((Bounds*)(nint)bounds)->m_Center = (Vector3)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		((RouteBuilder)(object)this).RouteChunk_OnEnvironmentSegmentSpawned((EnvironmentKind)(object)_characterChunksNear, (int)bounds, _characterRoute);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj5 = default;
		if (obj5 != null)
		{
			float unscaledTime = Time.unscaledTime;
			float timeInDefaultRoute = _timeInDefaultRoute + unscaledTime;
			_timeInDefaultRoute = timeInDefaultRoute;
		}
	}

	private void AlternateRouteBuilder_OnCompletedLayingSections(object sender, EventArgs args)
	{
		//IL_00c4: Expected Obj, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		Route route = default;
		((UnityEngine.Object)route).m_CachedPtr = cachedPtr;
		route.OnCharacterEntered = (EventHandler<Route.CharacterEnteredEventArgs>)0;
		object obj = route + 16;
		obj = this;
		Vector3 originGamePosition = route.OriginGamePosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		EventHandler<Route.CharacterEnteredEventArgs> eventHandler = default;
		object obj2 = eventHandler + 16;
		obj2 = this;
		Route route2 = default;
		route2.OnCharacterEntered += eventHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		SyboRandom syboRandom = default;
		syboRandom._randomGen = (IRandomGen)num2;
		_ = 0;
		object obj3 = syboRandom + 16;
		obj3 = this;
		RouteBuilder routeBuilder = default;
		routeBuilder.RandomGenerator = syboRandom;
	}

	private void AlternateRoute_CharacterEntrySkipped(object sender, Route.CharacterEntrySkippedEventArgs args)
	{
		//IL_001c: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		if (~(_isWaitingForRouteChoice ? 1u : 0u) != 0)
		{
			RouteBuilder routeBuilder = default;
			int spawnedLeadingEdgeWorldPositionZ = routeBuilder.SpawnedLeadingEdgeWorldPositionZ;
			((ConstrainingRouteBuilder)(object)this).UpdateBuilder((float)spawnedLeadingEdgeWorldPositionZ);
		}
	}

	private void PickupManager_OnPickupSpawnPointRegistered(PickupSpawnPoint spawnPoint)
	{
		//IL_0035: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
		if (this.m_OnRouteTransitionStarted != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			RouteBuilderWorker.WorkWrapper workWrapper = default;
			Stack<IEnumerator> workStack = default;
			workWrapper._002Ector((RouteChunk)(object)_characterRoute, workStack, (RouteBuilderWorker.WorkType)spawnPoint);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	private void PickupManager_OnPickupSpawnPointDeregistered(PickupSpawnPoint spawnPoint)
	{
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0104: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01f1: Expected I, but got Obj
		//IL_0207: Expected Obj, but got I
		//IL_00b7: Expected I, but got Obj
		//IL_0145: Expected I, but got Obj
		if (spawnPoint.__spawnPointMode == SpawnPointMode.WillForcePickupType || spawnPoint._spawnPointDifficulty != SpawnPointDifficulty.Easy)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		_spawnPoints.Add(spawnPoint);
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v9 (Il2CppClass<SYBO.Subway.Routes.RouteManager+<>c>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v46 (Il2CppClass<SYBO.Subway.Routes.RouteManager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v20 (Il2CppClass<SYBO.Subway.Routes.RouteManager+<>c>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v40 (Il2CppClass<SYBO.Subway.Routes.RouteManager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj5 = default;
		object obj4 = obj5 + 16;
		obj4 = _003C_003Ec._003C_003E9;
		nint num6 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v37 (Il2CppClass<SYBO.Subway.Routes.RouteManager+<>c>)+5C]");
		object obj6 = (nint)0 + (nint)4;
		obj6 = obj5;
		throw new NullReferenceException();
	}

	private void PickupManager_OnPickupSpawned(object sender, PickupManager.PickupEventArgs args)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_004f: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		_isWaitingForRouteChoice = false;
		object obj2 = default;
		object obj = obj2 + 60;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((ConstrainingRouteBuilder)(object)this).UpdateBuilder(0f);
	}

	public RouteManager()
	{
		//IL_0036: Expected F4, but got I4
		if (_alternateRouteOfferDelayResetEvent == ValueResetEvent.RunRevive)
		{
			_alternateRouteRepeatedOfferDelayIncremented = _alternateRouteRepeatedOfferDelay;
		}
	}

	static RouteManager()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0055: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		object obj3 = default;
		obj = obj3;
		obj2 = obj;
		object obj4 = obj2 + 8;
		obj4 = obj2;
		RouteConstraint.None = (RouteConstraint)obj4;
	}
}
