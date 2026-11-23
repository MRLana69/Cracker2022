using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Subway.Level;

namespace SYBO.Subway.Routes.Builders;

[Serializable]
public class DefaultRouteBuilder : RouteBuilder
{
	public static readonly int ChunkLengthForcingEnvironmentSwitch = 540;

	private RouteSection _tutorialSection;

	private EnvironmentKindRepeatConfig[] _environmentRepeatSettings;

	private SemiRandomlyOrderedList<EnvironmentKindRepeatConfig> _randomizedEnvironmentRepeatConfigs;

	private RouteSection _jetpackEndSection;

	private EnvironmentKindRepeatConfig _currentEnvironmentRepeatConfig;

	private int _desiredEnvironmentChangeDistance;

	public RouteSection TutorialSection => _tutorialSection;

	public RouteSection JetpackEndSection => _jetpackEndSection;

	public override void Initialize(RouteManager routeManager, Route route, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, RouteType previousRouteType, SyboRandom randomGenerator)
	{
		//IL_004c: Expected I, but got Obj
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		base.Initialize(routeManager, route, sectionSpawnMode, chunkBuildMode, previousRouteType, randomGenerator);
		((SemiRandomlyOrderedList<>)(object)_randomizedEnvironmentRepeatConfigs).Build((IEnumerable<T>)(object)_environmentRepeatSettings, base.RandomGenerator__BackingField);
		EnvironmentKindRepeatConfig next = _randomizedEnvironmentRepeatConfigs.GetNext(base.RandomGenerator__BackingField);
		_currentEnvironmentRepeatConfig = next;
		EnvironmentKindRepeatConfig currentEnvironmentRepeatConfig = _currentEnvironmentRepeatConfig;
		if (_currentEnvironmentRepeatConfig != null)
		{
			_desiredEnvironmentChangeDistance = currentEnvironmentRepeatConfig.RepeatDistance;
			nint num = (nint)this;
			object obj = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S2_v8 (Il2CppClass<SYBO.Subway.Routes.Builders.DefaultRouteBuilder>)+F4] (should have been resolved before IL gen)");
		}
	}

	public override void Destruct()
	{
		base.Destruct();
	}

	public override bool WillChangeEnvironment(int addedDistance)
	{
		//IL_000f: Expected Obj, but got I4
		object obj = addedDistance + base.DistanceBuilt__BackingField;
		return _desiredEnvironmentChangeDistance <= (nint)obj;
	}

	protected override EnvironmentKind EvalNextChunkDesiredEnvironment(RouteChunk spawnedChunk)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_020f: Expected Obj, but got I4
		//IL_007f: Expected I, but got Obj
		//IL_06b2: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		EnvironmentKindRepeatConfig currentEnvironmentRepeatConfig = _currentEnvironmentRepeatConfig;
		if (_currentEnvironmentRepeatConfig != null)
		{
			EnvironmentKind environmentKind = currentEnvironmentRepeatConfig.EnvironmentKind;
		}
		else
		{
			EnvironmentKind environmentKind = EnvironmentKind.None;
		}
		int builtLeadingEdgeWorldZ = BuiltLeadingEdgeWorldZ;
		IConstrainingRouteBuilder builderConstrainingStartAt = GetBuilderConstrainingStartAt(builtLeadingEdgeWorldZ);
		if (builderConstrainingStartAt != null)
		{
			Route route = _route;
			nint num = (nint)route;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S1_v77 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			_randomizedEnvironmentRepeatConfigs.Reset(base.RandomGenerator__BackingField);
			throw new ArgumentException();
		}
		SemiRandomlyOrderedList<EnvironmentKindRepeatConfig> randomizedEnvironmentRepeatConfigs = _randomizedEnvironmentRepeatConfigs;
		List<EnvironmentKindRepeatConfig> allEntries = randomizedEnvironmentRepeatConfigs._allEntries;
		EnvironmentKindRepeatConfig currentEnvironmentRepeatConfig2 = _currentEnvironmentRepeatConfig;
		bool flag = _currentEnvironmentRepeatConfig == null;
		object obj3 = 0;
		if (!flag)
		{
			EnvironmentKind environmentKind2 = currentEnvironmentRepeatConfig2.EnvironmentKind;
			EnvironmentKind none = EnvironmentKind.None;
			bool flag2 = environmentKind2._type == none._type && environmentKind2._density == none._density;
			object obj4 = (flag2 ? 1 : 0) ^ 1;
			obj3 = obj4;
		}
		SemiRandomlyOrderedList<EnvironmentKindRepeatConfig> randomizedEnvironmentRepeatConfigs2 = _randomizedEnvironmentRepeatConfigs;
		throw new ArgumentException();
	}

	public unsafe override void ConnectBuilder(RouteBuilder builderToConnect)
	{
		base.ConnectBuilder(builderToConnect);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		ConstrainingRouteBuilder constrainingRouteBuilder = default;
		if (constrainingRouteBuilder != null)
		{
			EventHandler eventHandler = default;
			eventHandler._002Ector(this, (nint)__ldftn(DefaultRouteBuilder.ConstrainingRouteBuilder_OnReachedLengthVisibleFromEntry));
			constrainingRouteBuilder.OnReachedLengthVisibleFromEntry += eventHandler;
			EventHandler eventHandler2 = default;
			eventHandler2._002Ector(this, (nint)__ldftn(DefaultRouteBuilder.ConstrainingRouteBuilder_OnCompletedLayingSections));
			constrainingRouteBuilder.OnCompletedLayingSections += eventHandler2;
		}
	}

	public unsafe override void DisconnectBuilder(RouteBuilder builderToDisconnect)
	{
		base.DisconnectBuilder(builderToDisconnect);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		ConstrainingRouteBuilder constrainingRouteBuilder = default;
		if (constrainingRouteBuilder != null)
		{
			EventHandler eventHandler = default;
			eventHandler._002Ector(this, (nint)__ldftn(DefaultRouteBuilder.ConstrainingRouteBuilder_OnReachedLengthVisibleFromEntry));
			constrainingRouteBuilder.OnReachedLengthVisibleFromEntry -= eventHandler;
			EventHandler eventHandler2 = default;
			eventHandler2._002Ector(this, (nint)__ldftn(DefaultRouteBuilder.ConstrainingRouteBuilder_OnCompletedLayingSections));
			constrainingRouteBuilder.OnCompletedLayingSections -= eventHandler2;
		}
	}

	public override void Validate(Route route)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		base.Validate(route);
		EnvironmentKindRepeatConfig[] environmentRepeatSettings = _environmentRepeatSettings;
		object obj = 0;
		while (environmentRepeatSettings.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)environmentRepeatSettings + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v10+10]");
			((EnvironmentKindRepeatConfig)0).Validate();
			object obj4 = obj + 1;
			obj = obj4;
		}
	}

	public void EnqueueJetpackEndSection(int posZ)
	{
		EnqueueBuildDirective(posZ, SectionSpawnMode.All, ChunkBuildMode.Normal, isApplicablePositionStict: true, _jetpackEndSection);
	}

	protected override bool CanSpawnSection(RouteSection section)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0211: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_025a: Expected Obj, but got I
		//IL_026c: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
		bool result = default;
		if (base.CanSpawnSection((RouteSection)0))
		{
			int spawnedLeadingEdgeWorldZ = SpawnedLeadingEdgeWorldZ;
			bool flag = IsStartPositionConstrained(spawnedLeadingEdgeWorldZ);
			bool flag2 = !flag;
			result = true;
			if (!flag2)
			{
				IConstrainingRouteBuilder builderConstrainingStartAt = GetBuilderConstrainingStartAt(spawnedLeadingEdgeWorldZ);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v24+40]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v24+44]");
				if (num != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					string name = _route.name;
					throw new ArrayTypeMismatchException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj5 = default;
				object obj4 = obj5 - spawnedLeadingEdgeWorldZ;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
				object obj6 = 0;
				Route route = _route;
				nint num2 = (nint)route;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ S1_v18 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				throw new ArgumentException();
			}
		}
		return result;
	}

	protected override RouteSection GetTransitionSectionPrefab(List<TransitionSectionInfo> transitionSections, RouteType transitionRouteType)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		if (!instance._isTutorialCompleted && _tutorialSection != null)
		{
			return _tutorialSection;
		}
		return ((RouteBuilder)(object)transitionSections).GetTransitionSectionPrefab(transitionSections, transitionRouteType);
	}

	private unsafe void ConstrainingRouteBuilder_OnReachedLengthVisibleFromEntry(object sender, EventArgs args)
	{
		//IL_0041: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		EventHandler eventHandler = default;
		eventHandler._002Ector(this, (nint)__ldftn(DefaultRouteBuilder.ConstrainingRouteBuilder_OnReachedLengthVisibleFromEntry));
		ConstrainingRouteBuilder constrainingRouteBuilder = default;
		constrainingRouteBuilder.OnReachedLengthVisibleFromEntry -= eventHandler;
		EventHandler eventHandler2 = default;
		eventHandler2._002Ector(this, (nint)__ldftn(DefaultRouteBuilder.ConstrainingRouteBuilder_OnCompletedLayingSections));
		constrainingRouteBuilder.OnCompletedLayingSections -= eventHandler2;
		nint num = (nint)constrainingRouteBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S2_v8 (Il2CppClass<SYBO.Subway.Routes.Builders.ConstrainingRouteBuilder>)+E4] (should have been resolved before IL gen)");
		int positionZ = default;
		EnqueueBuildDirective(positionZ, SectionSpawnMode.None, ChunkBuildMode.Normal);
	}

	private unsafe void ConstrainingRouteBuilder_OnCompletedLayingSections(object sender, EventArgs args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		EventHandler eventHandler = default;
		eventHandler._002Ector(this, (nint)__ldftn(DefaultRouteBuilder.ConstrainingRouteBuilder_OnReachedLengthVisibleFromEntry));
		ConstrainingRouteBuilder constrainingRouteBuilder = default;
		constrainingRouteBuilder.OnReachedLengthVisibleFromEntry -= eventHandler;
		EventHandler eventHandler2 = default;
		eventHandler2._002Ector(this, (nint)__ldftn(DefaultRouteBuilder.ConstrainingRouteBuilder_OnCompletedLayingSections));
		constrainingRouteBuilder.OnCompletedLayingSections -= eventHandler2;
		int spawnedLeadingEdgeWorldZ = constrainingRouteBuilder.SpawnedLeadingEdgeWorldZ;
		EnqueueBuildDirective(spawnedLeadingEdgeWorldZ, SectionSpawnMode.None, ChunkBuildMode.Normal);
	}

	public DefaultRouteBuilder()
	{
		SemiRandomlyOrderedList<EnvironmentKindRepeatConfig> semiRandomlyOrderedList = default;
		semiRandomlyOrderedList._002Ector();
		_randomizedEnvironmentRepeatConfigs = semiRandomlyOrderedList;
		base._002Ector();
	}
}
