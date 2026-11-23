using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using SYBO.Common.Exceptions;
using SYBO.Common.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.Routes;

public class RouteSection : MonoBehaviour
{
	[Serializable]
	public class RepeatConfiguration
	{
		private int _sectionsBetweenRepeats = 1;

		private int _remainingSectionsBetweenRepeats;

		private int _distanceBetweenRepeats;

		private int _lastSpawnZPosition;

		private List<RouteSection> _doNotSpawnAfter;

		public int RemainingSectionsBetweenRepeat => _remainingSectionsBetweenRepeats;

		public void Reset()
		{
			_lastSpawnZPosition = 0;
			_remainingSectionsBetweenRepeats = 0;
		}

		public bool CanSpawnAtPositionZ(int posZ, int routeSpecificDistanceBetweenRepeats)
		{
			//IL_0074: Expected Obj, but got I4
			if (_lastSpawnZPosition == 0)
			{
				return true;
			}
			int num = _distanceBetweenRepeats;
			if (_distanceBetweenRepeats <= routeSpecificDistanceBetweenRepeats)
			{
				num = routeSpecificDistanceBetweenRepeats;
			}
			object obj = num + _lastSpawnZPosition;
			return posZ >= (nint)obj;
		}

		public bool CanSpawnAfter(RouteSection previousSection)
		{
			bool flag = _doNotSpawnAfter.Contains(previousSection);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}

		public void NotifySectionSpawn(int posZ, int maxLength)
		{
			_remainingSectionsBetweenRepeats = _sectionsBetweenRepeats;
			int lastSpawnZPosition = posZ + maxLength;
			_lastSpawnZPosition = lastSpawnZPosition;
		}

		public void UpdateRepeatConfiguration()
		{
			if (_remainingSectionsBetweenRepeats >= 1)
			{
				int remainingSectionsBetweenRepeats = _remainingSectionsBetweenRepeats - 1;
				_remainingSectionsBetweenRepeats = remainingSectionsBetweenRepeats;
			}
		}

		public void Validate(RouteSection mySection)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			//IL_0429: Expected Obj, but got Unknown
			//IL_0456: Unknown result type (might be due to invalid IL or missing references)
			//IL_045b: Expected Obj, but got Unknown
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a5: Expected Obj, but got Unknown
			//IL_0481: Unknown result type (might be due to invalid IL or missing references)
			//IL_0486: Expected Obj, but got Unknown
			//IL_036a: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 48;
			_ = 0;
			_ = 0;
			int sectionsBetweenRepeats = _sectionsBetweenRepeats;
			if (_sectionsBetweenRepeats <= 0)
			{
				sectionsBetweenRepeats = 0;
			}
			_sectionsBetweenRepeats = sectionsBetweenRepeats;
			int distanceBetweenRepeats = _distanceBetweenRepeats;
			if (_distanceBetweenRepeats <= 0)
			{
				distanceBetweenRepeats = 0;
			}
			_distanceBetweenRepeats = distanceBetweenRepeats;
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
			object obj7 = default;
			object obj8 = default;
			object obj9 = default;
			object obj11 = default;
			object obj12 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						break;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj7 == null)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													continue;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
										goto IL_02a0;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							goto IL_02a0;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_02a0;
				IL_02a0:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj8 == obj9;
				bool flag2 = !flag;
				object obj10 = obj11;
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
					obj10 = obj12;
				}
				_ = 0;
				object obj13 = obj + 16;
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
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A402");
		}

		public RepeatConfiguration()
		{
			List<RouteSection> list = default;
			list._002Ector();
			_doNotSpawnAfter = list;
		}
	}

	private int _zMinimum;

	private bool _zMaximumActive;

	private int _zMaximum;

	private int _minSpawnOrder;

	private RepeatConfiguration _repeatConfiguration;

	private bool _middleChunkCountLimited = true;

	private int _middleChunkCountMin = 1;

	private int _middleChunkCountMax;

	protected WeightRandomizedRouteChunkContainter _startChunks;

	protected WeightRandomizedRouteChunkContainter _midChunks;

	protected WeightRandomizedRouteChunkContainter _endChunks;

	private List<EnvironmentKind> _limitedAllowedEnvironmentKinds;

	private List<EnvironmentKind> _forcedEnvironmentKinds;

	private int _lengthMin;

	private int _lengthMax;

	private int _lengthMinPrev;

	private int _lengthMaxPrev;

	private int _middleChunkCountMinPrev;

	private int _middleChunkCountMaxPrev;

	private RouteBuildProgress _progressState;

	private WeightRandomizedRouteChunkContainter _filteredChunks;

	private int _midChunksCountUsed;

	private int _midChunksCountTarget;

	private RouteBuilder _builder;

	private List<RouteChunk> _pickedChunks;

	private ReadOnlyCollection<RouteChunk> _pickedChunksReadOnly;

	protected List<RouteChunk> _spawnedChunks;

	public List<EnvironmentKind> ForcedEnvironmentKinds => _forcedEnvironmentKinds;

	public bool IsDone => _progressState == RouteBuildProgress.Done;

	public int ZMinimum => _zMinimum;

	public int ZMaximum => _zMaximum;

	public bool ZMaximumActive => _zMaximumActive;

	public int MinSpawnOrder => _minSpawnOrder;

	public int LengthMin => _lengthMin;

	public int LengthMax => _lengthMax;

	public ReadOnlyCollection<RouteChunk> PickedChunks
	{
		get
		{
			if (_pickedChunksReadOnly != null)
			{
				return _pickedChunksReadOnly;
			}
			ReadOnlyCollection<RouteChunk> pickedChunksReadOnly = _pickedChunks.AsReadOnly();
			_pickedChunksReadOnly = pickedChunksReadOnly;
			return _pickedChunksReadOnly;
		}
	}

	public List<RouteChunk> SpawnedChunks => _spawnedChunks;

	public WeightRandomizedRouteChunkContainter StartChunks => _startChunks;

	public WeightRandomizedRouteChunkContainter MidChunks => _midChunks;

	public WeightRandomizedRouteChunkContainter EndChunks => _endChunks;

	public int SpawnedChunkCount
	{
		get
		{
			List<RouteChunk> spawnedChunks = _spawnedChunks;
			return spawnedChunks._size;
		}
	}

	public void Reset(RouteBuilder builder)
	{
		_builder = builder;
		WeightRandomizedRouteChunkContainter startChunks = _startChunks;
		throw new ArgumentException();
	}

	public bool SupportsEnvironment(EnvironmentKind envKind)
	{
		List<EnvironmentKind> limitedAllowedEnvironmentKinds = _limitedAllowedEnvironmentKinds;
		if (limitedAllowedEnvironmentKinds._size == 0)
		{
			return true;
		}
		return _limitedAllowedEnvironmentKinds.Contains(envKind);
	}

	public RepeatConfiguration GetRepeatConfiguration()
	{
		return _repeatConfiguration;
	}

	public RouteChunk GetRandomMidChunk(SyboRandom random)
	{
		RouteChunk routeChunk = _midChunks.PickSemiRandomlyOrderedPrefab(random);
		_pickedChunks.Add(routeChunk);
		return routeChunk;
	}

	public RouteChunk GetNextChunk(RouteBuilder builder, SyboRandom random)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		WeightRandomizedRouteChunkContainter progressStateChunks = GetProgressStateChunks(_progressState);
		RouteChunk routeChunk = progressStateChunks.PickSemiRandomlyOrderedPrefab(random);
		bool flag = routeChunk == null;
		bool flag2 = !flag;
		RouteChunk routeChunk2 = routeChunk;
		if (!flag2)
		{
			RouteChunk fallbackRouteChunk = builder.FallbackRouteChunk;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		if (_progressState == RouteBuildProgress.Mid)
		{
			int midChunksCountUsed = _midChunksCountUsed + 1;
			_midChunksCountUsed = midChunksCountUsed;
		}
		if (routeChunk2 != null)
		{
			IncrementProgressState();
		}
		_pickedChunks.Add(routeChunk2);
		return routeChunk2;
	}

	public void AddSpawnedChunk(RouteChunk chunk)
	{
		_spawnedChunks.Add(chunk);
	}

	public void RemoveSpawnedChunk(RouteChunk chunk)
	{
		bool flag = _spawnedChunks.Remove(chunk);
	}

	public RouteChunk GetSpawnedChunk(int index)
	{
		List<RouteChunk> spawnedChunks = _spawnedChunks;
		if (index < spawnedChunks._size)
		{
			return _spawnedChunks.get_Item(index);
		}
		return null;
	}

	public bool HasChunk(RouteChunk chunk)
	{
		bool flag = _startChunks.Contains(chunk);
		bool result = true;
		if (!flag)
		{
			bool flag2 = _midChunks.Contains(chunk);
			result = true;
			if (!flag2)
			{
				bool flag3 = _endChunks.Contains(chunk);
				result = flag3;
			}
		}
		return result;
	}

	public IRouteTransitionTrigger GetTransitionTrigger()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
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
		IRouteTransitionTrigger routeTransitionTrigger = null;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		IRouteTransitionTrigger result;
		IRouteTransitionTrigger routeTransitionTrigger2 = default;
		IRouteTransitionTrigger routeTransitionTrigger3 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_0319;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (routeTransitionTrigger == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v77+40]");
						routeTransitionTrigger = (IRouteTransitionTrigger)0;
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj8 == null)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											continue;
										}
									}
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
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj9 != obj10;
			result = routeTransitionTrigger2;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0319;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			result = routeTransitionTrigger3;
			break;
			IL_0319:
			object obj11 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3872");
			if (routeTransitionTrigger == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				string text = name;
				throw new ArrayTypeMismatchException();
			}
			return routeTransitionTrigger;
		}
		_ = 0;
		object obj12 = obj + 16;
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
		return result;
	}

	public new string ToString()
	{
		return name;
	}

	private bool CanSpawnChunk(RouteChunk chunk)
	{
		bool result;
		if (~(chunk._isRepeatableInSections ? 1u : 0u) != 0)
		{
			bool flag = _pickedChunks.Contains(chunk);
			result = false;
			if (flag)
			{
				goto IL_0047;
			}
		}
		result = _builder.CanSpawnChunk(chunk);
		goto IL_0047;
		IL_0047:
		return result;
	}

	private void IncrementProgressState()
	{
		//IL_0031: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		object obj2 = default;
		object obj4 = default;
		while (_progressState != RouteBuildProgress.Done)
		{
			WeightRandomizedRouteChunkContainter progressStateChunks = GetProgressStateChunks(_progressState);
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S2_v6 (Il2CppRgctx<SYBO.Subway.Routes.WeightRandomizedPrefabContainter`2<SYBO.Subway.Routes.WeightedRouteChunk, SYBO.Subway.Routes.RouteChunk>>)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S2_v7+4] (should have been resolved before IL gen)");
			if (obj2 != null && _progressState == RouteBuildProgress.Mid && (~(_middleChunkCountLimited ? 1u : 0u) != 0 || _midChunksCountUsed < _midChunksCountTarget))
			{
				break;
			}
			RouteBuildProgress routeBuildProgress = ++_progressState;
			if (routeBuildProgress != RouteBuildProgress.Done)
			{
				WeightRandomizedRouteChunkContainter progressStateChunks2 = GetProgressStateChunks(routeBuildProgress);
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S2_v13 (Il2CppRgctx<SYBO.Subway.Routes.WeightRandomizedPrefabContainter`2<SYBO.Subway.Routes.WeightedRouteChunk, SYBO.Subway.Routes.RouteChunk>>)+C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ S2_v14+4] (should have been resolved before IL gen)");
				if (obj4 != null)
				{
					break;
				}
				continue;
			}
			break;
		}
	}

	private WeightRandomizedRouteChunkContainter GetProgressStateChunks(RouteBuildProgress progressState)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		string text = default;
		switch (progressState)
		{
		case RouteBuildProgress.Mid:
			return (WeightRandomizedRouteChunkContainter)(this + 48);
		case RouteBuildProgress.End:
			return (WeightRandomizedRouteChunkContainter)(this + 52);
		default:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			_ = -1;
			object obj3 = default;
			obj = (Enum)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			text = obj.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			SwitchDefaultException ex = default;
			ex._002Ector(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			break;
		}
		case RouteBuildProgress.Start:
			break;
		}
		return (WeightRandomizedRouteChunkContainter)(object)(text + 44);
	}

	public RouteSection()
	{
		//IL_00c3: Expected I4, but got I8
		WeightRandomizedRouteChunkContainter weightRandomizedRouteChunkContainter = default;
		weightRandomizedRouteChunkContainter._002Ector();
		_startChunks = weightRandomizedRouteChunkContainter;
		WeightRandomizedRouteChunkContainter weightRandomizedRouteChunkContainter2 = default;
		weightRandomizedRouteChunkContainter2._002Ector();
		_midChunks = weightRandomizedRouteChunkContainter2;
		WeightRandomizedRouteChunkContainter weightRandomizedRouteChunkContainter3 = default;
		weightRandomizedRouteChunkContainter3._002Ector();
		_endChunks = weightRandomizedRouteChunkContainter3;
		List<EnvironmentKind> list = default;
		list._002Ector();
		_limitedAllowedEnvironmentKinds = list;
		List<EnvironmentKind> list2 = default;
		list2._002Ector();
		_forcedEnvironmentKinds = list2;
		WeightRandomizedRouteChunkContainter weightRandomizedRouteChunkContainter4 = default;
		weightRandomizedRouteChunkContainter4._002Ector();
		_filteredChunks = weightRandomizedRouteChunkContainter4;
		List<RouteChunk> list3 = default;
		list3._002Ector();
		_pickedChunks = list3;
		List<RouteChunk> list4 = default;
		list4._002Ector();
		_spawnedChunks = list4;
		base._002Ector();
	}
}
