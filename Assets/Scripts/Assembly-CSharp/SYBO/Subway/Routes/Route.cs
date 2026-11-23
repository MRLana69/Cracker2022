using System;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.Routes;

public abstract class Route : MonoBehaviour
{
	public class CharacterEntryStartedEventArgs(Route fromRoute, Route toRoute) : EventArgs
	{
		public readonly Route FromRoute = fromRoute;

		public readonly Route ToRoute = toRoute;
	}

	public class CharacterEntrySkippedEventArgs(bool hasCharacterStartedEntryTransition) : EventArgs
	{
		public readonly bool HasCharacterStartedEntryTransition = hasCharacterStartedEntryTransition;
	}

	public class CharacterEnteredEventArgs(Route fromRoute) : EventArgs
	{
		public readonly Route FromRoute = fromRoute;
	}

	public class CharacterExitedEventArgs(Route toRoute) : EventArgs
	{
		public readonly Route ToRoute = toRoute;
	}

	protected RouteManager _routeManager;

	protected Transform _transform;

	private Character _character;

	private bool _characterEnteredAndLanded;

	private float _characterEnterTimeStamp;

	private float _characterExitedTimeStamp;

	private bool CharacterSkippedEntry__BackingField;

	private bool CharacterEntered__BackingField;

	private bool HasCharacterStartedEntryTransition__BackingField;

	private EventHandler<CharacterEntryStartedEventArgs> m_OnCharacterEntryStarted;

	private EventHandler<CharacterEntrySkippedEventArgs> m_OnCharacterEntrySkipped;

	private EventHandler<CharacterEnteredEventArgs> m_OnCharacterEntered;

	private EventHandler m_OnCharacterEnteredLanded;

	private EventHandler<CharacterExitedEventArgs> m_OnCharacterExited;

	private EventHandler m_OnDestructing;

	public abstract RouteBuilder Builder { get; }

	public abstract RouteType Type { get; }

	public Transform OriginTransform => _transform;

	public bool CharacterSkippedEntry
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

	public bool CharacterEntered
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

	public bool HasCharacterStartedEntryTransition
	{
		get
		{
			return HasCharacterStartedEntryTransition__BackingField;
		}
		private set
		{
			HasCharacterStartedEntryTransition__BackingField = value;
		}
	}

	public bool IsCharacterInThisRoute
	{
		get
		{
			if (_routeManager != null)
			{
				RouteManager routeManager = _routeManager;
				return routeManager._characterRoute == this;
			}
			return false;
		}
	}

	public float TimeCharacterInRoute => _characterExitedTimeStamp - _characterEnterTimeStamp;

	public float TimeCharacterEnterTimeStamp => _characterEnterTimeStamp;

	public event EventHandler<CharacterEntryStartedEventArgs> OnCharacterEntryStarted
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 40;
			Delegate obj2 = this.m_OnCharacterEntryStarted;
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
			object obj = this + 40;
			Delegate obj2 = this.m_OnCharacterEntryStarted;
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

	public event EventHandler<CharacterEntrySkippedEventArgs> OnCharacterEntrySkipped
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 44;
			Delegate obj2 = this.m_OnCharacterEntrySkipped;
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
			object obj = this + 44;
			Delegate obj2 = this.m_OnCharacterEntrySkipped;
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

	public event EventHandler<CharacterEnteredEventArgs> OnCharacterEntered
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_OnCharacterEntered;
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
			object obj = this + 48;
			Delegate obj2 = this.m_OnCharacterEntered;
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

	public event EventHandler OnCharacterEnteredLanded
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 52;
			Delegate obj2 = this.m_OnCharacterEnteredLanded;
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
			object obj = this + 52;
			Delegate obj2 = this.m_OnCharacterEnteredLanded;
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

	public event EventHandler<CharacterExitedEventArgs> OnCharacterExited
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 56;
			Delegate obj2 = this.m_OnCharacterExited;
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
			object obj = this + 56;
			Delegate obj2 = this.m_OnCharacterExited;
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

	public event EventHandler OnDestructing
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 60;
			Delegate obj2 = this.m_OnDestructing;
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
			object obj = this + 60;
			Delegate obj2 = this.m_OnDestructing;
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

	public unsafe virtual void Initialize(RouteManager routeManager, Vector3 originPosition, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, RouteType previousRouteType, SyboRandom randomGenerator)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		//IL_005b: Expected I, but got Obj
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		_routeManager = routeManager;
		Transform component = GetComponent<Transform>();
		_transform = component;
		Transform parent = _routeManager.transform;
		_transform.parent = parent;
		((Vector3*)(nint)vector)->z = originPosition.z;
		((Vector3*)(nint)vector)->x = originPosition.x;
		_transform.position = vector;
		_transform.SetAsLastSibling();
		nint num = (nint)this;
		object obj2 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S1_v16 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		object obj4 = default;
		object obj3 = obj4 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S7_v3+BC] (should have been resolved before IL gen)");
		CharacterEntered__BackingField = false;
	}

	protected virtual void OnDestroy()
	{
		EventHandler onDestructing = this.m_OnDestructing;
		if (this.m_OnDestructing != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v12.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		if (_character != null)
		{
			throw new ArgumentException();
		}
	}

	protected void OnEnable()
	{
	}

	protected void OnValidate()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3;
		object obj4 = obj3 + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S2_v5+104] (should have been resolved before IL gen)");
	}

	public unsafe static Vector3 GetPosition(float x, float z)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0074: Expected I, but got Obj
		//IL_00f8: Expected native int or pointer, but got VT
		//IL_0105: Expected native int or pointer, but got VT
		//IL_0121: Expected native int or pointer, but got VT
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float num3 = (float)Vector3.forwardVector * z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
		float num4 = 0f * z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		float num5 = 0f * z;
		nint num6 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v22 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num7 = 0;
		float num8 = x - 20f;
		float num9 = (float)Vector3.rightVector * num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v23 (Il2CppStaticFields<UnityEngine.Vector3>)+40]");
		float num10 = 0f * num8;
		float y = num4 + num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v23 (Il2CppStaticFields<UnityEngine.Vector3>)+44]");
		float num11 = 0f * num8;
		float z2 = num5 + num11;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = z2;
		((Vector3*)(nint)vector)->y = y;
		float x2 = num3 + num9;
		((Vector3*)(nint)vector)->x = x2;
		return vector;
	}

	public static int GetTrackX(int trackIndex)
	{
		return trackIndex * 20;
	}

	public void UpdateRoute(float characterWorldZ, SyboRandom random)
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3;
		object obj4 = obj3 + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S2_v5+11C] (should have been resolved before IL gen)");
	}

	public virtual void CharacterStartEntryTransition(Route fromRoute, Route toRoute)
	{
		HasCharacterStartedEntryTransition__BackingField = true;
		EventHandler<CharacterEntryStartedEventArgs> onCharacterEntryStarted = this.m_OnCharacterEntryStarted;
		if (this.m_OnCharacterEntryStarted != null)
		{
			CharacterEntryStartedEventArgs e = default;
			e._002Ector(fromRoute, toRoute);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S0_v7 (System.EventHandler`1<SYBO.Subway.Routes.Route+CharacterEntryStartedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	public virtual void NotifyCharacterEntrySkipped()
	{
		CharacterSkippedEntry__BackingField = true;
		EventHandler<CharacterEntrySkippedEventArgs> onCharacterEntrySkipped = this.m_OnCharacterEntrySkipped;
		if (this.m_OnCharacterEntrySkipped != null)
		{
			CharacterEntrySkippedEventArgs e = default;
			e._002Ector(HasCharacterStartedEntryTransition__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S0_v7 (System.EventHandler`1<SYBO.Subway.Routes.Route+CharacterEntrySkippedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	public void NotifyCharacterEntered(Character character, Route previousRoute)
	{
		_character = character;
		Game instance = Game.Instance;
		_characterEnterTimeStamp = instance._elapsedGameDuration;
		throw new ArgumentException();
	}

	public virtual void CharacterEnteredLanded()
	{
	}

	public virtual void NotifyCharacterExited(Route nextRoute)
	{
		//IL_0046: Expected I, but got Obj
		//IL_0073: Expected I, but got Obj
		if (_character != null)
		{
			throw new ArgumentException();
		}
		Game instance = Game.Instance;
		_characterExitedTimeStamp = instance._elapsedGameDuration;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S1_v8 (Il2CppClass<SYBO.Subway.Routes.Route>)+DC] (should have been resolved before IL gen)");
		_ = 2;
		_ = 1;
		CharacterExitedEventArgs e = default;
		e._002Ector(nextRoute);
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ S2_v7 (Il2CppClass<SYBO.Subway.Routes.Route>)+12C] (should have been resolved before IL gen)");
	}

	public virtual void CharacterStartExitTransition(Route nextRoute)
	{
	}

	public unsafe Vector3 GetRelativePosition(Vector3 worldPosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected native int or pointer, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		//IL_005a: Expected F4, but got I
		//IL_0055: Expected native int or pointer, but got VT
		//IL_006f: Expected F4, but got I
		//IL_006a: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		((Vector3*)(nint)vector)->z = worldPosition.z;
		((Vector3*)(nint)vector)->x = worldPosition.x;
		Vector3 vector2 = _transform.InverseTransformPoint(vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		Vector3 vector3 = default;
		((Vector3*)(nint)vector3)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector3)->x = 0f;
		return vector3;
	}

	public override string ToString()
	{
		return name;
	}

	protected virtual void RaiseOnCharacterEntered(CharacterEnteredEventArgs args)
	{
		EventHandler<CharacterEnteredEventArgs> onCharacterEntered = this.m_OnCharacterEntered;
		if (this.m_OnCharacterEntered != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.EventHandler`1<SYBO.Subway.Routes.Route+CharacterEnteredEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	protected virtual void RaiseOnCharacterExited(CharacterExitedEventArgs args)
	{
		EventHandler<CharacterExitedEventArgs> onCharacterExited = this.m_OnCharacterExited;
		if (this.m_OnCharacterExited != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.EventHandler`1<SYBO.Subway.Routes.Route+CharacterExitedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	private void Character_OnLanding(Character character)
	{
		//IL_000a: Expected I, but got Obj
		if (~(_characterEnteredAndLanded ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v9 (Il2CppClass<SYBO.Subway.Routes.Route>)+10C] (should have been resolved before IL gen)");
		}
		_characterEnteredAndLanded = true;
		throw new ArgumentException();
	}
}
