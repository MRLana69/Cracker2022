using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Common.Utilities;
using SYBO.Subway.Coins;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Routes.Log;
using UnityEngine;

namespace SYBO.Subway.Routes.Builders;

[Serializable]
public abstract class ConstrainingRouteBuilder : RouteBuilder, IConstrainingRouteBuilder
{
	public const int MinConstraintLength = 180;

	private EventHandler m_OnReachedLengthVisibleFromEntry;

	private List<RouteBuilder> _constrainedRouteBuilders;

	public bool HasReachedLengthVisibleFromEntry => (byte)_routeHeight != 0;

	public int ConstraintStartZ
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj = default;
			return ((nint)obj <= _length) ? 1 : 0;
		}
	}

	public int ConstraintEndZ
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0074: Invalid comparison between I and F4
			//IL_00b5: Invalid comparison between I and F4
			object obj = this + 168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			int result = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if (num != 0)
			{
				result = int.MinValue;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				if (!(0f < 2.1474836E+09f))
				{
					result = int.MinValue;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					if (!(0f > -2.1474836E+09f))
					{
						result = int.MinValue;
					}
				}
			}
			return result;
		}
	}

	public ICollection<RouteBuilder> ConstrainedBuilders
	{
		get
		{
			//IL_0083: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I4
			//IL_004a: Expected Obj, but got I4
			if (base.SectionCountUsed__BackingField != 0)
			{
				if (~(_stopped ? 1u : 0u) == 0)
				{
					int distanceVisibleFromEntry = base.DistanceVisibleFromEntry;
					return (ICollection<RouteBuilder>)distanceVisibleFromEntry;
				}
				int spawnedLeadingEdgeWorldPositionZ = SpawnedLeadingEdgeWorldPositionZ;
				return (ICollection<RouteBuilder>)spawnedLeadingEdgeWorldPositionZ;
			}
			int constraintEndZ = ConstraintEndZ;
			return (ICollection<RouteBuilder>)(constraintEndZ + 180);
		}
	}

	public abstract ICollection<RouteType> ConstrainedRouteTypes { get; }

	public event EventHandler OnReachedLengthVisibleFromEntry
	{
		add
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnReachedLengthVisibleFromEntry;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 232;
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

	public abstract RouteConstraint GetConstraint(RouteType routeType);

	public override void UpdateBuilder(float characterWorldZ)
	{
		//IL_003a: Expected Obj, but got F4
		float num = ((CoinCurve)(object)this).JumpLength(characterWorldZ);
		float num2 = (float)base._builderForward + num;
		float num3 = num2 + (float)base._buildersOnSides;
		base._buildLimitingSpawnPoint = (PickupSpawnPoint)num3;
	}

	public void CollectConstrained()
	{
		//IL_000b: Expected I4, but got Obj
		RoutesLogManagerBridge.ForcedZBuildValue__BackingField = (int)this;
	}

	private void AddFromListIfConstrained(ICollection<RouteBuilder> builders)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnReachedLengthVisibleFromEntry;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)builders);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 232;
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

	private void AddIfConstrained(RouteBuilder builder)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 43;
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			if ((nint)obj10 == 43)
			{
				object obj11 = obj2 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				return;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public override void ConnectBuilder(RouteBuilder builderToConnect)
	{
		if (builderToConnect != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj = default;
			if (obj != null)
			{
				_constrainedRouteBuilders.Add(builderToConnect);
			}
		}
	}

	public override void DisconnectBuilder(RouteBuilder builderToDisconnect)
	{
		base.DisconnectBuilder(builderToDisconnect);
		OnDrawGizmos();
	}

	public bool IsConstrainingStartAt(int rangeStartZ)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_0056: Expected I4, but got Obj
		//IL_0074: Expected I4, but got Obj
		object obj = rangeStartZ;
		switch (rangeStartZ)
		{
		case 0:
			return (byte)(int)_endSectionPrefabs != 0;
		case 1:
			return (byte)base._minDistanceBetweenSectionRepeats != 0;
		case 2:
			return (byte)(int)_fallbackSection != 0;
		default:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
	}

	public bool IsConstrainingEndAt(int rangeEndZ)
	{
		int constraintEndZ = ConstraintEndZ;
		if (constraintEndZ > rangeEndZ)
		{
			return false;
		}
		ICollection<RouteBuilder> constrainedBuilders = ConstrainedBuilders;
		return (nint)constrainedBuilders > rangeEndZ;
	}

	public bool IsConstrainingRange(int startZ, int endZ)
	{
		//IL_025d: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I4
		//IL_026f: Expected I, but got Obj
		//IL_0285: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02df: Expected I, but got Obj
		//IL_02f5: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_023a: Expected I4, but got Obj
		//IL_01dc: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.ConstrainingRouteBuilder)+58]");
		bool flag = IsConstrainingStartAt(0);
		RouteChunk routeChunk = ((WeightRandomizedPrefabContainter<WeightedRouteChunk, RouteChunk>)flag).PickSemiRandomlyOrderedPrefab((SyboRandom)endZ);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v67 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = routeChunk != null;
		bool flag3 = !flag2;
		RouteChunk routeChunk2 = routeChunk;
		if (!flag3)
		{
			RouteChunk lastChunk = ((RouteBuilder)startZ).LastChunk;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.ConstrainingRouteBuilder)+58]");
		if ((nint)0 == 1)
		{
			List<RouteBuilder> buildersAbove = (List<RouteBuilder>)(base._buildersAbove + 1);
			base._buildersAbove = buildersAbove;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)routeChunk2).FindKernel((string)null) != 0)
		{
			((RouteSection)(object)this)._002Ector();
		}
		((List<RouteChunk>)(object)base._buildersOnSides).Add(routeChunk2);
		return (byte)(int)routeChunk2 != 0;
	}

	private void OnDrawGizmos()
	{
		throw new IndexOutOfRangeException();
	}

	protected unsafe ConstrainingRouteBuilder()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_018b: Expected Obj, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01a8: Expected Obj, but got I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_020d: Expected I, but got Obj
		//IL_0223: Expected Obj, but got I
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected VT, but got Unknown
		//IL_0272: Expected F4, but got Obj
		//IL_026d: Expected native int or pointer, but got VT
		//IL_0287: Expected F4, but got I
		//IL_0282: Expected native int or pointer, but got VT
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected VT, but got Unknown
		//IL_02c1: Expected F4, but got Obj
		//IL_02bc: Expected native int or pointer, but got VT
		//IL_02d6: Expected F4, but got I
		//IL_02d1: Expected native int or pointer, but got VT
		//IL_02e3: Expected F4, but got Obj
		//IL_02de: Expected native int or pointer, but got VT
		//IL_02f8: Expected F4, but got I
		//IL_02f3: Expected native int or pointer, but got VT
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0332: Expected F4, but got Obj
		//IL_032d: Expected native int or pointer, but got VT
		//IL_0347: Expected F4, but got I
		//IL_0342: Expected native int or pointer, but got VT
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_0366: Expected I4, but got VT
		//IL_0366: Expected Obj, but got I4
		//IL_036f: Expected Obj, but got F4
		//IL_0102: Expected F4, but got Obj
		//IL_00fd: Expected native int or pointer, but got VT
		//IL_0117: Expected F4, but got I
		//IL_0112: Expected native int or pointer, but got VT
		//IL_0120: Expected Ref, but got VT
		//IL_012d: Expected F4, but got Obj
		//IL_0128: Expected native int or pointer, but got VT
		//IL_013f: Expected F4, but got I4
		//IL_013a: Expected native int or pointer, but got VT
		//IL_014c: Expected F4, but got Obj
		//IL_0147: Expected native int or pointer, but got VT
		//IL_0161: Expected F4, but got I
		//IL_015c: Expected native int or pointer, but got VT
		//IL_00b6: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 88;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 76;
		obj3 = 0;
		_ = 0;
		ICollection<RouteBuilder> constrainedBuilders = ConstrainedBuilders;
		int constraintEndZ = ConstraintEndZ;
		float num = (float)constrainedBuilders - (float)constraintEndZ;
		object obj4 = obj2 - -64;
		object obj5 = this + 168;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v14+8]");
		_ = 0;
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v69 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 52;
		Vector3 back = Vector3.back;
		Vector3 vector = (Vector3)(obj2 + 112);
		((Vector3*)(nint)vector)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v26+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj8 = obj2 + 40;
		Vector3 vector2 = vector / num;
		Vector3 vector3 = (Vector3)(obj2 + 100);
		((Vector3*)(nint)vector3)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v18+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v31+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj9 = obj2 + 28;
		Vector3 vector4 = vector3 - vector;
		obj = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v38+8]");
		_ = 0;
		nint num4 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v42 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num5 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v65 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		BackgroundCulling backgroundCulling = (BackgroundCulling)(obj2 + 16);
		backgroundCulling.Initialize((Material)isRestricted, (int)vector);
		obj3 = 61f;
		_ = 100f;
		float num6 = num * 0.5f;
		Color green = Color.green;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Gizmos.set_color_Injected(ref *(Color*)vector);
		((Vector3*)(nint)vector3)->x = (float)backgroundCulling;
		((Vector3*)(nint)vector3)->z = (float)backgroundCulling.EnvironmentType;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Gizmos.DrawRay(vector3, vector);
	}
}
