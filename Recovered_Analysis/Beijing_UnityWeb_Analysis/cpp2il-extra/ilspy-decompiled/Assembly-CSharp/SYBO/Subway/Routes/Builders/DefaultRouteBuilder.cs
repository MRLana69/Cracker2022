using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Routes.Builders;

[Serializable]
public class DefaultRouteBuilder : RouteBuilder
{
	public static readonly int ChunkLengthForcingEnvironmentSwitch;

	private RouteSection _tutorialSection;

	private EnvironmentKindRepeatConfig[] _environmentRepeatSettings;

	private SemiRandomlyOrderedList<EnvironmentKindRepeatConfig> _randomizedEnvironmentRepeatConfigs;

	private RouteSection _jetpackEndSection;

	private EnvironmentKindRepeatConfig _currentEnvironmentRepeatConfig;

	private int _desiredEnvironmentChangeDistance;

	public RouteSection TutorialSection => (RouteSection)(object)_environmentRepeatSettings;

	public RouteSection JetpackEndSection => _tutorialSection;

	public unsafe override void Initialize(RouteManager routeManager, Route route, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, RouteType previousRouteType, SyboRandom randomGenerator)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0012: Expected I4, but got Obj
		object obj = this + 36;
		obj = routeManager;
		object obj2 = this + 40;
		Transform component = ((Component)(object)this).GetComponent<Transform>();
		obj2 = component;
		GameObject gameObject = ((Component)(object)_midSectionPrefabs).gameObject;
		((Transform)(object)base._midSectionGroupPrefabs).parentInternal = (Transform)(object)gameObject;
		bool flag = default;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)route != 0;
		_ = ((UnityEngine.Object)route).m_CachedPtr;
		((Route)(object)this).CharacterSkippedEntry = flag;
		((Transform.Enumerator)(object)base._midSectionGroupPrefabs).Reset();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8948");
		_ = 0;
		_ = 0;
	}

	public override void Destruct()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<RouteBuilder> list = default;
		list._002Ector();
		object obj = this + 236;
		obj = list;
		InitializeSectionGroups();
	}

	public override bool WillChangeEnvironment(int addedDistance)
	{
		int constraintEndZ = ((ConstrainingRouteBuilder)this).ConstraintEndZ;
		if (constraintEndZ < addedDistance)
		{
			ICollection<RouteBuilder> constrainedBuilders = ((ConstrainingRouteBuilder)this).ConstrainedBuilders;
			return (nint)constrainedBuilders >= addedDistance;
		}
		return false;
	}

	protected override EnvironmentKind EvalNextChunkDesiredEnvironment(RouteChunk spawnedChunk)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_0027: Expected Obj, but got I4
		object obj = spawnedChunk + base.DistanceBuilt__BackingField;
		bool flag = (nint)obj >= _desiredEnvironmentChangeDistance;
		return (EnvironmentKind)flag;
	}

	public override void ConnectBuilder(RouteBuilder builderToConnect)
	{
		RemoveChunk((RouteChunk)(object)builderToConnect);
		((ConstrainingRouteBuilder)this).OnDrawGizmos();
	}

	public unsafe override void DisconnectBuilder(RouteBuilder builderToDisconnect)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		base.DisconnectBuilder(builderToDisconnect);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		ConstrainingRouteBuilder constrainingRouteBuilder = default;
		if (constrainingRouteBuilder != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			EventHandler eventHandler = default;
			((Delegate)eventHandler).method_ptr = method_ptr;
			((Delegate)eventHandler).method = (nint)__ldftn(DefaultRouteBuilder.ConstrainingRouteBuilder_OnReachedLengthVisibleFromEntry);
			object obj = eventHandler + 16;
			obj = this;
			constrainingRouteBuilder.OnReachedLengthVisibleFromEntry -= eventHandler;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			EventHandler eventHandler2 = default;
			((Delegate)eventHandler2).method_ptr = method_ptr2;
			((Delegate)eventHandler2).method = (nint)__ldftn(DefaultRouteBuilder.ConstrainingRouteBuilder_OnCompletedLayingSections);
			object obj2 = eventHandler2 + 16;
			obj2 = this;
			constrainingRouteBuilder.OnCompletedLayingSections -= eventHandler2;
		}
	}

	public override void Validate(Route route)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		RemoveChunk((RouteChunk)(object)route);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		ConstrainingRouteBuilder constrainingRouteBuilder = default;
		if (constrainingRouteBuilder != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			ICollection<RouteBuilder> collection = default;
			object obj = collection + 16;
			obj = this;
			constrainingRouteBuilder.AddFromListIfConstrained(collection);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num2 = 0;
			SyboRandom syboRandom = default;
			syboRandom._randomGen = (IRandomGen)num2;
			_ = 0;
			object obj2 = syboRandom + 16;
			obj2 = this;
			((RouteBuilder)constrainingRouteBuilder).RandomGenerator = syboRandom;
		}
	}

	public void EnqueueJetpackEndSection(int gamePositionZ)
	{
		//IL_000a: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		base.ConnectBuilder((RouteBuilder)gamePositionZ);
		object obj = _environmentRepeatSettings + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _environmentRepeatSettings + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			((EnvironmentKindRepeatConfig)obj5)._002Ector();
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
	}

	protected unsafe override bool CanSpawnSection(RouteSection section)
	{
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected Obj, but got Unknown
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Expected Obj, but got Unknown
		//IL_002f: Expected I, but got Obj
		//IL_0045: Expected Obj, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_0070: Expected I, but got Obj
		//IL_03e1: Expected Obj, but got I4
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected Obj, but got Unknown
		//IL_0b85: Expected I, but got Obj
		//IL_0b9b: Expected Obj, but got I
		//IL_032a: Expected I, but got Obj
		//IL_0340: Expected Obj, but got I
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_03f4: Expected I, but got Obj
		//IL_036b: Expected I, but got Obj
		//IL_09f5: Expected Obj, but got I4
		//IL_0994: Expected Obj, but got I4
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_0499: Expected Obj, but got I4
		//IL_0944: Expected I4, but got Obj
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_0234: Expected Obj, but got I4
		//IL_0249: Expected I4, but got Obj
		//IL_0a20: Expected I, but got Obj
		//IL_0a36: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Expected Obj, but got Unknown
		//IL_0bfc: Expected Obj, but got I
		//IL_0c12: Expected Obj, but got I
		//IL_0c4f: Expected Obj, but got I4
		//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5d: Expected Obj, but got Unknown
		//IL_0c6d: Expected Obj, but got I
		//IL_04ac: Expected I, but got Obj
		//IL_050f: Expected Obj, but got I4
		//IL_04f4: Expected Obj, but got I4
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected Obj, but got Unknown
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Expected Obj, but got Unknown
		//IL_0639: Expected Obj, but got I
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected Obj, but got Unknown
		//IL_07dd: Expected I, but got Obj
		//IL_07f3: Expected Obj, but got I
		//IL_06a6: Expected Obj, but got I
		//IL_06b6: Expected Obj, but got I
		//IL_05a9: Expected I, but got Obj
		//IL_05bf: Expected Obj, but got I
		//IL_0555: Expected I4, but got Obj
		//IL_0774: Expected I4, but got Obj
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_0ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected Obj, but got Unknown
		//IL_0af1: Expected Obj, but got I4
		//IL_0b06: Expected I4, but got Obj
		//IL_058a: Expected I4, but got Obj
		//IL_058a: Expected Obj, but got I
		//IL_081e: Expected I, but got Obj
		//IL_05ea: Expected I, but got Obj
		//IL_078f: Expected I4, but got Obj
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = section;
		object obj3 = obj2 + 12;
		obj3 = this;
		GamePositionRoot gamePositionRoot;
		if (_currentEnvironmentRepeatConfig != null)
		{
			EnvironmentKindRepeatConfig currentEnvironmentRepeatConfig = _currentEnvironmentRepeatConfig;
			gamePositionRoot = (GamePositionRoot)(object)currentEnvironmentRepeatConfig.EnvironmentKind;
		}
		else
		{
			nint num = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v142 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v148 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			gamePositionRoot = GamePositionRoot.Instance;
		}
		object obj6 = default;
		object obj5 = obj6 + 4;
		int distanceVisibleFromEntry = base.DistanceVisibleFromEntry;
		RouteSection startSectionPrefab = GetStartSectionPrefab((RouteType)distanceVisibleFromEntry);
		bool result;
		if ((object)startSectionPrefab != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj7 = default;
			obj6 = obj7;
			obj5 = obj6;
			object obj9 = default;
			object obj8 = obj9 + 8;
			obj8 = obj5;
			_randomizedEnvironmentRepeatConfigs.Reset(base.RandomGenerator__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			Func<EnvironmentKindRepeatConfig, bool> func = default;
			object obj10 = func + 16;
			obj10 = obj9;
			EnvironmentKindRepeatConfig nextMatching = _randomizedEnvironmentRepeatConfigs.GetNextMatching(base.RandomGenerator__BackingField, func);
			if (nextMatching == null)
			{
				object obj11 = obj9 + 8;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S2_v97+C]");
				bool flag = ((Theme)(object)base.RandomGenerator__BackingField).TryGetDevicePerformanceRelativeMaterial((Material)null, out *(Material*)(-1));
				object obj13 = obj9 + 8;
				object obj14 = obj13 + 16;
				object obj15 = (flag ? 1u : 0u) << 2;
				object obj16 = obj14 + obj15;
				result = (byte)(int)obj16 != 0;
			}
			else
			{
				bool flag2 = nextMatching != _currentEnvironmentRepeatConfig;
				bool flag3 = !flag2;
				GamePositionRoot gamePositionRoot2 = gamePositionRoot;
				if (!flag3)
				{
					EnvironmentKindRepeatConfig currentEnvironmentRepeatConfig2 = _currentEnvironmentRepeatConfig;
					int desiredEnvironmentChangeDistance = currentEnvironmentRepeatConfig2.RepeatDistance + base.DistanceBuilt__BackingField;
					_desiredEnvironmentChangeDistance = desiredEnvironmentChangeDistance;
					object obj17 = this + 248;
					obj17 = nextMatching;
					gamePositionRoot2 = (GamePositionRoot)(object)nextMatching.EnvironmentKind;
				}
				result = (byte)(int)gamePositionRoot2 != 0;
			}
		}
		else
		{
			SemiRandomlyOrderedList<EnvironmentKindRepeatConfig> randomizedEnvironmentRepeatConfigs = _randomizedEnvironmentRepeatConfigs;
			List<EnvironmentKindRepeatConfig> allEntries = randomizedEnvironmentRepeatConfigs._allEntries;
			object obj20;
			if (_currentEnvironmentRepeatConfig != null)
			{
				EnvironmentKindRepeatConfig currentEnvironmentRepeatConfig3 = _currentEnvironmentRepeatConfig;
				EnvironmentKind environmentKind = currentEnvironmentRepeatConfig3.EnvironmentKind;
				nint num4 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v127 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num5 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v143 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GamePositionRoot instance = GamePositionRoot.Instance;
				EnvironmentType type = environmentKind._type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v132 (SYBO.Subway.Level.GamePositionRoot)+8]");
				bool flag4;
				if ((nint)type == (nint)0)
				{
					EnvironmentDensity density = environmentKind._density;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v132 (SYBO.Subway.Level.GamePositionRoot)+C]");
					flag4 = (nint)density == (nint)0;
				}
				else
				{
					flag4 = false;
				}
				object obj19 = (flag4 ? 1 : 0) ^ 1;
				obj20 = obj19 & 1;
			}
			else
			{
				obj20 = 0;
			}
			SemiRandomlyOrderedList<EnvironmentKindRepeatConfig> randomizedEnvironmentRepeatConfigs2 = _randomizedEnvironmentRepeatConfigs;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num6 = 0;
			_ = 0;
			Func<_0021_00210, bool> func2 = default;
			object obj21 = func2 + 16;
			obj21 = obj2;
			bool flag5 = Enumerable.All<TSource>((IEnumerable<TSource>)randomizedEnvironmentRepeatConfigs2._allEntries, (Func<TSource, bool>)(object)func2);
			nint num7 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v27 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num8 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S1_v118 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GamePositionRoot instance2 = GamePositionRoot.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (SYBO.Subway.Level.GamePositionRoot)+8]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v32 (SYBO.Subway.Level.GamePositionRoot)+8]");
			bool flag6;
			if (num9 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (SYBO.Subway.Level.GamePositionRoot)+C]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v32 (SYBO.Subway.Level.GamePositionRoot)+C]");
				flag6 = num10 == 0;
			}
			else
			{
				flag6 = false;
			}
			object obj23 = (flag6 ? 1 : 0) ^ 1;
			object obj24;
			if (obj23 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
				EnvironmentKind randomAllowedEnvironmentKind = ((RouteChunk)0).GetRandomAllowedEnvironmentKind((SyboRandom)(object)gamePositionRoot);
				obj24 = randomAllowedEnvironmentKind & 1;
			}
			else
			{
				obj24 = 0;
			}
			nint num11 = (nint)typeof(DefaultRouteBuilder);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S1_v40 (Il2CppClass<SYBO.Subway.Routes.Builders.DefaultRouteBuilder>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num12 = (nint)typeof(DefaultRouteBuilder);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S1_v103 (Il2CppClass<SYBO.Subway.Routes.Builders.DefaultRouteBuilder>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag7 = allEntries._size > 0;
			bool flag8 = _desiredEnvironmentChangeDistance > base.DistanceBuilt__BackingField;
			object obj26 = obj24 ^ 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S2_v25+20]");
			object obj28 = (nint)0 * (nint)90;
			bool flag9 = ChunkLengthForcingEnvironmentSwitch > (nint)obj28;
			bool flag10 = !flag9;
			object obj29 = obj26;
			if (!flag10)
			{
				obj29 = 0;
			}
			object obj30 = flag7 & flag5;
			object obj31 = obj20 ^ 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj33 = default;
			bool flag11 = (nint)obj33 > 0;
			object obj34 = ((!flag8) ? ((object)1) : obj31);
			object obj35 = obj29 | obj34;
			bool flag12 = obj35 == null;
			object obj36 = obj30 ^ 1;
			object obj37 = flag12 | obj36;
			if (obj37 != null)
			{
				object obj38 = obj24 & obj20;
				if (obj38 != null)
				{
					EnvironmentKindRepeatConfig currentEnvironmentRepeatConfig4 = _currentEnvironmentRepeatConfig;
					result = (byte)(int)currentEnvironmentRepeatConfig4.EnvironmentKind != 0;
				}
				else if (flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
					int currentEnvironmentEndBlock = ((RouteChunk)0).GetCurrentEnvironmentEndBlock((int)base.RandomGenerator__BackingField);
					result = (byte)currentEnvironmentEndBlock != 0;
				}
				else
				{
					nint num13 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S0_v85 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
					object obj39 = (nint)0 & (nint)0x200;
					if (obj39 != null)
					{
						nint num14 = (nint)typeof(EnvironmentKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v96 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj40 = EnvironmentKind.AllUnconstrained + 16;
					EnvironmentKind[] allUnconstrained = EnvironmentKind.AllUnconstrained;
					ref Material performanceRelative = ref *(Material*)(allUnconstrained.Length - 1);
					bool flag13 = ((Theme)(object)base.RandomGenerator__BackingField).TryGetDevicePerformanceRelativeMaterial((Material)null, out performanceRelative);
					object obj41 = (flag13 ? 1u : 0u) << 2;
					object obj42 = obj40 + obj41;
					result = (byte)(int)obj42 != 0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj44 = default;
				EnvironmentKindRepeatConfig environmentKindRepeatConfig;
				if (obj44 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj46 = default;
					object obj45 = obj46 + 12;
					obj45 = obj2;
					_randomizedEnvironmentRepeatConfigs.Reset(base.RandomGenerator__BackingField);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S0_v64+C]");
					object obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S3_v28+8]");
					object obj48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj49 = default;
					bool flag14 = (nint)obj49 == 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num15 = 0;
					_ = 0;
					Func<EnvironmentKindRepeatConfig, bool> func3 = default;
					object obj50 = func3 + 16;
					obj50 = obj46;
					environmentKindRepeatConfig = _randomizedEnvironmentRepeatConfigs.GetNextMatching(base.RandomGenerator__BackingField, func3);
				}
				else
				{
					environmentKindRepeatConfig = _randomizedEnvironmentRepeatConfigs.GetNext(base.RandomGenerator__BackingField);
				}
				if (environmentKindRepeatConfig == null)
				{
					nint num16 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S0_v46 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
					object obj51 = (nint)0 & (nint)0x200;
					if (obj51 != null)
					{
						nint num17 = (nint)typeof(EnvironmentKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S0_v52 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					GamePositionRoot instance3 = GamePositionRoot.Instance;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					throw new ArrayTypeMismatchException();
				}
				bool flag15 = environmentKindRepeatConfig == _currentEnvironmentRepeatConfig;
				result = (byte)(int)gamePositionRoot != 0;
				if (!flag15)
				{
					result = (byte)(int)environmentKindRepeatConfig.EnvironmentKind != 0;
					EnvironmentKindRepeatConfig currentEnvironmentRepeatConfig5 = _currentEnvironmentRepeatConfig;
					int desiredEnvironmentChangeDistance2 = currentEnvironmentRepeatConfig5.RepeatDistance + base.DistanceBuilt__BackingField;
					_desiredEnvironmentChangeDistance = desiredEnvironmentChangeDistance2;
					object obj52 = this + 248;
					obj52 = environmentKindRepeatConfig;
				}
			}
		}
		return result;
	}

	protected override RouteSection GetTransitionSectionPrefab(List<TransitionSectionInfo> transitionSections, RouteType transitionRouteType)
	{
		//IL_000a: Expected I4, but got Obj
		//IL_004b: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I4
		if (((ConstrainingRouteBuilder)this).IsConstrainingEndAt((int)transitionSections))
		{
			return (RouteSection)1;
		}
		bool flag = WillChangeEnvironment((int)transitionRouteType);
		return (RouteSection)flag;
	}

	private void ConstrainingRouteBuilder_OnReachedLengthVisibleFromEntry(object sender, EventArgs args)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got F4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = "";
		OnAddedSection = (Action<Route, RouteSection, float>)sender;
		object obj2 = this + 16;
		obj2 = args;
		float deltaTime = Time.deltaTime;
		base.OnCompletedLayingSections = (EventHandler)deltaTime;
		object obj4 = default;
		object obj3 = obj4 + 4;
		obj3 = OnAddedSection;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj4 = base.OnCompletedLayingSections;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object obj5 = this + 20;
		string format = default;
		object arg = default;
		string text = string.Format((IFormatProvider)(object)"[RoutesLogData (RoutesLogType={0},TimeStamp={1})]", format, arg);
		obj5 = text;
	}

	private void ConstrainingRouteBuilder_OnCompletedLayingSections(object sender, EventArgs args)
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_0022: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		ICollection<RouteBuilder> collection = default;
		object obj = collection + 16;
		obj = this;
		ConstrainingRouteBuilder constrainingRouteBuilder = default;
		constrainingRouteBuilder.AddFromListIfConstrained(collection);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		SyboRandom syboRandom = default;
		syboRandom._randomGen = (IRandomGen)num2;
		_ = 0;
		object obj2 = syboRandom + 16;
		obj2 = this;
		((RouteBuilder)constrainingRouteBuilder).RandomGenerator = syboRandom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		PickupType pickupType = default;
		((PickupSpawnPoint)(object)this).SetSpawnPointForced(pickupType, (SpawnPointDifficulty)0, true, true, false);
	}

	public DefaultRouteBuilder()
	{
		CollectConstrainingBuilders();
	}

	static DefaultRouteBuilder()
	{
		RouteScoreChangeExplosion.PREFAB_RESOURCE_PATH = "Prefabs/Routes/RouteScoreChangeExplosion";
	}
}
