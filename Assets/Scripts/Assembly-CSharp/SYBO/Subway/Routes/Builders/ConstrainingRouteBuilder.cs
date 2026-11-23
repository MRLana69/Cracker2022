using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Routes.Builders;

[Serializable]
public abstract class ConstrainingRouteBuilder : RouteBuilder, IConstrainingRouteBuilder
{
	public const int MinConstraintLength = 180;

	private List<RouteBuilder> _constrainedRouteBuilders;

	private EventHandler m_OnReachedLengthVisibleFromEntry;

	public bool HasReachedLengthVisibleFromEntry
	{
		get
		{
			//IL_0005: Expected I, but got Obj
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			nint num = (nint)this;
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SYBO.Subway.Routes.Builders.ConstrainingRouteBuilder>)+DC] (should have been resolved before IL gen)");
			object obj2 = default;
			return (nint)obj2 <= _length;
		}
	}

	public int ConstraintStartZ
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002d: Expected F8, but got I
			//IL_003e: Expected F8, but got I
			//IL_0081: Expected F8, but got I4
			//IL_008b: Expected I4, but got F8
			object obj2 = default;
			object obj = obj2 - 16;
			Vector3 position = _originTransfrom.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num2 = Math.Abs(0.0);
			if (!(num2 < 2147483648.0))
			{
				num = -2147483648.0;
			}
			return (int)num;
		}
	}

	public int ConstraintEndZ
	{
		get
		{
			if (base.SectionCountUsed__BackingField == 0)
			{
				int constraintStartZ = ConstraintStartZ;
				return constraintStartZ + 180;
			}
			if (~(_stopped ? 1u : 0u) == 0)
			{
				return BuiltLeadingEdgeWorldZ;
			}
			return SpawnedLeadingEdgeWorldZ;
		}
	}

	public ICollection<RouteBuilder> ConstrainedBuilders => _constrainedRouteBuilders;

	public abstract ICollection<RouteType> ConstrainedRouteTypes { get; }

	public event EventHandler OnReachedLengthVisibleFromEntry
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 244;
			Delegate obj2 = this.m_OnReachedLengthVisibleFromEntry;
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
			object obj = this + 244;
			Delegate obj2 = this.m_OnReachedLengthVisibleFromEntry;
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

	public abstract RouteConstraint GetConstraint(RouteType routeType);

	public override void UpdateBuilder(float characterWorldZ)
	{
		//IL_006f: Expected I, but got Obj
		//IL_000a: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<SYBO.Subway.Routes.Builders.ConstrainingRouteBuilder>)+DC] (should have been resolved before IL gen)");
		object obj = default;
		bool flag = (nint)obj <= _length;
		base.UpdateBuilder(characterWorldZ);
		if (flag)
		{
			return;
		}
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S1_v10 (Il2CppClass<SYBO.Subway.Routes.Builders.ConstrainingRouteBuilder>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		if ((nint)obj2 <= _length)
		{
			EventHandler onReachedLengthVisibleFromEntry = this.m_OnReachedLengthVisibleFromEntry;
			if (this.m_OnReachedLengthVisibleFromEntry != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public void CollectConstrained()
	{
		((List<T>)(object)_constrainedRouteBuilders).Clear();
		AddFromListIfConstrained(base._buildersAbove);
		AddFromListIfConstrained(base._buildersBelow);
		AddIfConstrained(base._builderForward);
	}

	private void AddFromListIfConstrained(ICollection<RouteBuilder> builders)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = default;
		object obj5 = default;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj4 == null)
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
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
			bool flag = obj5 == obj6;
			bool flag2 = !flag;
			object obj7 = obj8;
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
				obj7 = obj9;
			}
			_ = 0;
			object obj10 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
		object obj11 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
	}

	private void AddIfConstrained(RouteBuilder builder)
	{
		//IL_000a: Expected I, but got Obj
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0034: Expected I, but got Obj
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		if (builder != null)
		{
			nint num = (nint)this;
			object obj = this + 232;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v4 (Il2CppClass<SYBO.Subway.Routes.Builders.ConstrainingRouteBuilder>)+1A4] (should have been resolved before IL gen)");
			Route route = builder._route;
			nint num2 = (nint)route;
			object obj2 = route + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S1_v8 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj3 = default;
			if (obj3 != null)
			{
				_constrainedRouteBuilders.Add(builder);
			}
		}
	}

	public override void ConnectBuilder(RouteBuilder builderToConnect)
	{
		base.ConnectBuilder(builderToConnect);
		CollectConstrained();
	}

	public override void DisconnectBuilder(RouteBuilder builderToDisconnect)
	{
		base.DisconnectBuilder(builderToDisconnect);
		CollectConstrained();
	}

	public bool IsConstrainingStartAt(int rangeStartZ)
	{
		int constraintStartZ = ConstraintStartZ;
		if (constraintStartZ <= rangeStartZ)
		{
			int constraintEndZ = ConstraintEndZ;
			return constraintEndZ > rangeStartZ;
		}
		return false;
	}

	public bool IsConstrainingEndAt(int rangeEndZ)
	{
		int constraintStartZ = ConstraintStartZ;
		if (constraintStartZ < rangeEndZ)
		{
			int constraintEndZ = ConstraintEndZ;
			return constraintEndZ >= rangeEndZ;
		}
		return false;
	}

	public bool IsConstrainingRange(int startZ, int endZ)
	{
		if (IsConstrainingStartAt(startZ))
		{
			return true;
		}
		return IsConstrainingEndAt(endZ);
	}

	private unsafe void OnDrawGizmos()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0047: Expected I, but got Obj
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected VT, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_013b: Expected F4, but got I
		//IL_0136: Expected native int or pointer, but got VT
		//IL_0158: Expected native int or pointer, but got VT
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		int constraintEndZ = ConstraintEndZ;
		int constraintStartZ = ConstraintStartZ;
		object obj2 = constraintEndZ - constraintStartZ;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		object obj3 = Vector3.forwardVector * obj2;
		object obj4 = _originPosition + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v18 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
		object obj5 = 0 * obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.ConstrainingRouteBuilder)+90]");
		object obj6 = 0 + obj5;
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 1065353216;
		_ = 1065353216;
		Color color = (Color)(vector + 32);
		Gizmos.color = color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v18 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		object obj7 = 0 * obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.ConstrainingRouteBuilder)+94]");
		object obj8 = 0 + obj7;
		float num3 = (float)obj2 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = 4812096202960273408L;
		((Vector3*)(nint)vector)->x = 61f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 center = vector + 16;
		Gizmos.DrawWireCube(center, vector);
	}

	protected ConstrainingRouteBuilder()
	{
		List<RouteBuilder> list = default;
		list._002Ector();
		_constrainedRouteBuilders = list;
		base._002Ector();
	}
}
