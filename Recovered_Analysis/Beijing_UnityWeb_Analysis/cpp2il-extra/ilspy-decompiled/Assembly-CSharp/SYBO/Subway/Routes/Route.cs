using System;
using Cpp2ILInjected;
using SYBO.Common.Data;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Level;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.Routes;

public abstract class Route : MonoBehaviour
{
	public class CharacterEntryStartedEventArgs : EventArgs
	{
		public readonly Route FromRoute;

		public readonly Route ToRoute;

		public CharacterEntryStartedEventArgs(Route fromRoute, Route toRoute)
		{
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj2 = default;
			object obj = obj2 + 4;
			obj = fromRoute;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
	}

	public class CharacterEntrySkippedEventArgs(bool hasCharacterStartedEntryTransition) : EventArgs
	{
		public readonly bool HasCharacterStartedEntryTransition = hasCharacterStartedEntryTransition;
	}

	public class CharacterEnteredEventArgs : EventArgs
	{
		public readonly Route FromRoute;

		public CharacterEnteredEventArgs(Route fromRoute)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Route fromRoute2 = (Route)(fromRoute & 1);
			FromRoute = fromRoute2;
		}
	}

	public class CharacterExitedEventArgs : EventArgs
	{
		public readonly Route ToRoute;

		public CharacterExitedEventArgs(Route toRoute)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 8;
			obj2 = toRoute;
		}
	}

	private EventHandler<CharacterEntryStartedEventArgs> m_OnCharacterEntryStarted;

	private EventHandler<CharacterEntrySkippedEventArgs> m_OnCharacterEntrySkipped;

	private EventHandler<CharacterEnteredEventArgs> m_OnCharacterEntered;

	private EventHandler m_OnCharacterEnteredLanded;

	private EventHandler<CharacterExitedEventArgs> m_OnCharacterExited;

	private EventHandler m_OnDestructing;

	protected RouteManager _routeManager;

	protected Transform _transform;

	private Character _character;

	private bool _characterEnteredAndLanded;

	private float _characterEnterTimeStamp;

	private float _characterExitedTimeStamp;

	private bool CharacterSkippedEntry__BackingField;

	private bool CharacterEntered__BackingField;

	private bool HasCharacterStartedEntryTransition__BackingField;

	public abstract RouteBuilder Builder { get; }

	public abstract RouteType Type { get; }

	public Vector3 OriginGamePosition
	{
		get
		{
			//IL_0034: Expected Obj, but got I
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+20]");
			Delegate obj = (Delegate)0;
			Vector3 vector = default;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)(object)this);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = vector + 32;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 == obj)
				{
					break;
				}
				obj = (Delegate)obj3;
			}
			return vector;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 60;
			Route route = (Route)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public unsafe bool CharacterSkippedEntry
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Route)+4C]");
			return false;
		}
		private set
		{
			//IL_000d: Expected Obj, but got I4
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected Obj, but got Unknown
			object obj = ((bool*)(value ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
			_ = 0;
			object obj2 = this + 60;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
	}

	public bool CharacterEntered
	{
		get
		{
			return CharacterSkippedEntry__BackingField;
		}
		private set
		{
			CharacterSkippedEntry__BackingField = value;
		}
	}

	public bool HasCharacterStartedEntryTransition
	{
		get
		{
			return CharacterEntered__BackingField;
		}
		private set
		{
			CharacterEntered__BackingField = value;
		}
	}

	public bool IsCharacterInThisRoute => HasCharacterStartedEntryTransition__BackingField;

	public float TimeCharacterInRoute
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0010: Expected F4, but got Obj
			object obj = this - -64;
			return (float)obj;
		}
	}

	public float TimeCharacterEnterTimeStamp => _characterExitedTimeStamp - _characterEnterTimeStamp;

	public event EventHandler<CharacterEntryStartedEventArgs> OnCharacterEntryStarted
	{
		add
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 68;
			Route route = (Route)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCharacterEntryStarted;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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

	public event EventHandler<CharacterEntrySkippedEventArgs> OnCharacterEntrySkipped
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCharacterEntryStarted;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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
			Delegate obj = this.m_OnCharacterEntrySkipped;
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

	public event EventHandler<CharacterEnteredEventArgs> OnCharacterEntered
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCharacterEntrySkipped;
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
			Delegate obj = this.m_OnCharacterEntered;
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

	public event EventHandler OnCharacterEnteredLanded
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCharacterEntered;
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
			Delegate obj = this.m_OnCharacterEnteredLanded;
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

	public event EventHandler<CharacterExitedEventArgs> OnCharacterExited
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCharacterEnteredLanded;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCharacterExited;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
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

	public event EventHandler OnDestructing
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCharacterExited;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
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
			Delegate obj = this.m_OnDestructing;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
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

	public virtual void Initialize(RouteManager routeManager, Vector3 originGamePosition, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, RouteType previousRouteType, SyboRandom randomGenerator)
	{
		//IL_005f: Expected Obj, but got F4
		//IL_0071: Expected I, but got F4
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00ec: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		Route route = (Route)originGamePosition.x;
		((UnityEngine.Object)route).m_CachedPtr = (IntPtr)originGamePosition.z;
		((DefaultRouteBuilder)(object)this).Initialize(routeManager, route, sectionSpawnMode, chunkBuildMode, previousRouteType, randomGenerator);
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v12 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 76;
		bool isInstantiated = Game.IsInstantiated;
		obj2 = isInstantiated;
	}

	protected virtual void OnDestroy()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	protected unsafe void OnEnable()
	{
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		if (this.m_OnDestructing != null)
		{
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v25 (Il2CppClass<System.EventArgs>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v30 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_character).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Character.OnHangtimeDelegate onHangtimeDelegate = default;
			((Delegate)onHangtimeDelegate).method_ptr = method_ptr;
			((Delegate)onHangtimeDelegate).method = (nint)__ldftn(Route.Character_OnLanding);
			object obj3 = onHangtimeDelegate + 16;
			obj3 = this;
			_character.OnHangtime += onHangtimeDelegate;
		}
	}

	protected void OnValidate()
	{
	}

	public unsafe static Vector3 GetPosition(float x, float z)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b6: Expected native int or pointer, but got VT
		//IL_00c4: Expected native int or pointer, but got VT
		//IL_00d2: Expected VT, but got Obj
		//IL_00db: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002b: Expected native int or pointer, but got VT
		//IL_0038: Expected native int or pointer, but got VT
		//IL_0045: Expected native int or pointer, but got VT
		//IL_0057: Expected Obj, but got F4
		//IL_0069: Expected I, but got F4
		//IL_007b: Expected Obj, but got VT
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		Vector3 vector = default;
		Collider collider = (Collider)(vector + 12);
		((Vector3*)(nint)vector)->x = 0f;
		((Vector3*)(nint)vector)->z = 0f;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		object obj = 0;
		while ((nint)obj <= 2)
		{
			object obj2 = obj - 1;
			float x2 = (float)obj2 * 20f;
			((Vector3*)(nint)vector)->x = x2;
			((Vector3*)(nint)vector)->y = z;
			((Vector3*)(nint)vector)->z = x;
			collider = (Collider)vector.x;
			((UnityEngine.Object)collider).m_CachedPtr = (IntPtr)vector.z;
			bool flag = ((Character)val).EnteredColliderFromBelow(collider, false);
			object obj3 = obj + 1;
			obj = obj3;
		}
		return vector;
	}

	public static int GetTrackX(int trackIndex)
	{
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I
		//IL_00b1: Expected I, but got Obj
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trackIndex @ L0 (System.Int32)+24]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trackIndex @ L0 (System.Int32)+24]");
			object obj2 = 0;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v11+4C]");
			return ((UnityEngine.Object)0 != (UnityEngine.Object)trackIndex) ? 1 : 0;
		}
		return 0;
	}

	public void UpdateRoute(float characterGamePositionZ, SyboRandom random)
	{
		//IL_000a: Expected Obj, but got F4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		this.m_OnCharacterEntrySkipped = (EventHandler<CharacterEntrySkippedEventArgs>)characterGamePositionZ;
		object obj = this + 20;
		obj = random;
		((ScoreMultiplier)(object)this).Reset();
	}

	public virtual void CharacterStartEntryTransition(Route fromRoute, Route toRoute)
	{
		//IL_0016: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Route)+88]");
		object obj = (nint)0 + (nint)16;
		object obj2 = (object)fromRoute << 2;
		object obj3 = obj + obj2;
		((GameObject)obj3).tag = (string)(object)toRoute;
	}

	public virtual void NotifyCharacterEntrySkipped()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public void NotifyCharacterEntered(Character character, Route previousRoute)
	{
		//IL_0020: Expected VT, but got Obj
		HasCharacterStartedEntryTransition__BackingField = true;
		if (this.m_OnCharacterEntryStarted != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			RouteChunk.ChunkBlockConstraint chunkBlockConstraint = default;
			chunkBlockConstraint._002Ector((EnvironmentKind)(object)character, (EnvironmentBaseKind)previousRoute);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	public virtual void CharacterEnteredLanded()
	{
		//IL_0030: Expected Obj, but got I4
		CharacterSkippedEntry__BackingField = true;
		if (this.m_OnCharacterEntrySkipped != null)
		{
			bool flag = HasCharacterStartedEntryTransition__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CharacterEnteredEventArgs e = default;
			e._002Ector((Route)flag);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	public virtual void NotifyCharacterExited(Route nextRoute)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(nextRoute & 1) != 0;
		HasCharacterStartedEntryTransition__BackingField = flag;
	}

	public unsafe virtual void CharacterStartExitTransition(Route nextRoute)
	{
		//IL_015e: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01ac: Expected F4, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01d3: Expected Obj, but got I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0140: Expected I4, but got Obj
		//IL_00f4: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_character).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Character.OnHangtimeDelegate onHangtimeDelegate = default;
			((Delegate)onHangtimeDelegate).method_ptr = method_ptr;
			((Delegate)onHangtimeDelegate).method = (nint)__ldftn(Route.Character_OnLanding);
			object obj2 = onHangtimeDelegate + 16;
			obj2 = this;
			_character.OnHangtime += onHangtimeDelegate;
		}
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v10 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v23 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v11 (System.Boolean)+5C]");
		_characterExitedTimeStamp = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		_ = 1;
		object obj5 = default;
		object obj4 = obj5 - -64;
		obj4 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RouteChunk._003CDestruct_003Ed__41 obj6 = default;
		obj6._002Ector((int)nextRoute);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public Vector3 GetRelativePosition(Vector3 gamePosition)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_011b: Expected Obj, but got VT
		//IL_0130: Expected Obj, but got I
		//IL_006f: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		Vector3 vector = default;
		object obj = vector + 44;
		obj = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v20 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v6 (System.Boolean)+5C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<Character> action = default;
		object obj3 = action + 16;
		obj3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+2C]");
		((Character)0).OnLanding -= action;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterExitedEventArgs e = default;
		e._002Ector((Route)gamePosition);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		return vector;
	}

	public override string ToString()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		return (string)(this * 20);
	}

	protected virtual void RaiseOnCharacterEntered(CharacterEnteredEventArgs args)
	{
	}

	protected virtual void RaiseOnCharacterExited(CharacterExitedEventArgs args)
	{
		if (this.m_OnCharacterEntered != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	private void Character_OnLanding(Character character)
	{
		if (this.m_OnCharacterExited != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}
}
