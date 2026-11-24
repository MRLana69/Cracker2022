using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Routes.Builders;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SYBO.Subway.Routes;

public class RouteSection : MonoBehaviour
{
	[Serializable]
	public class RepeatConfiguration
	{
		private int _sectionsBetweenRepeats;

		private int _remainingSectionsBetweenRepeats;

		private int _distanceBetweenRepeats;

		private int _lastSpawnZPosition;

		private List<RouteSection> _doNotSpawnAfter;

		public int RemainingSectionsBetweenRepeat
		{
			get
			{
				//IL_001b: Expected Obj, but got I4
				//IL_001b: Expected Obj, but got I4
				//IL_001f: Expected I4, but got Obj
				return (int)string.Format((IFormatProvider)(object)"[CharacterRouteTypeChangedEventArgs (FromRouteType={0}, ToRouteType={1})]", (string)_sectionsBetweenRepeats, _remainingSectionsBetweenRepeats);
			}
		}

		public void Reset()
		{
		}

		public bool CanSpawnAtPositionZ(int posZ, int routeSpecificDistanceBetweenRepeats)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Expected Obj, but got I4
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			//IL_0034: Expected Obj, but got I4
			//IL_0045: Expected VT, but got Obj
			//IL_0065: Expected Obj, but got I4
			//IL_0076: Expected VT, but got Obj
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			Transform transform = default;
			object obj = transform + 24;
			obj = 0;
			_ = 0;
			Transform transform2 = (Transform)(transform + 12);
			GameObject gameObject = ((Component)posZ).gameObject;
			transform2.position = (Vector3)gameObject;
			obj = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			GameObject gameObject2 = ((Component)routeSpecificDistanceBetweenRepeats).gameObject;
			transform.position = (Vector3)gameObject2;
			object obj2 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D9CC");
			bool result = default;
			return result;
		}

		public bool CanSpawnAfter(RouteSection previousSection)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj = default;
			return (nint)obj == _sectionsBetweenRepeats;
		}

		public void NotifySectionSpawn(int posZ, int maxLength)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00a6: Expected Obj, but got I4
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			//IL_00b9: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 8;
			obj2 = posZ;
			object obj3 = this + 12;
			obj3 = maxLength;
		}

		public void UpdateRepeatConfiguration()
		{
			_remainingSectionsBetweenRepeats = 0;
			_lastSpawnZPosition = 0;
		}

		public void Validate(RouteSection mySection)
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
			obj2 = mySection;
		}

		public RepeatConfiguration()
		{
			if (_remainingSectionsBetweenRepeats > 0)
			{
				int remainingSectionsBetweenRepeats = _remainingSectionsBetweenRepeats - 1;
				_remainingSectionsBetweenRepeats = remainingSectionsBetweenRepeats;
			}
		}
	}

	private int _zMinimum;

	private bool _zMaximumActive;

	private int _zMaximum;

	private int _minSpawnOrder;

	private RepeatConfiguration _repeatConfiguration;

	private bool _middleChunkCountLimited;

	private int _middleChunkCountMin;

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

	public List<EnvironmentKind> ForcedEnvironmentKinds
	{
		get
		{
			//IL_0112: Expected I, but got Obj
			//IL_0128: Expected Obj, but got I
			//IL_017e: Expected I4, but got Obj
			//IL_0190: Expected I, but got Obj
			//IL_01a6: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00ff: Expected Obj, but got VT
			nint num = (nint)typeof(RouteScoreChangeExplosion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Routes.RouteScoreChangeExplosion>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(RouteScoreChangeExplosion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v43 (Il2CppClass<SYBO.Subway.Routes.RouteScoreChangeExplosion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string nameInternal = Scene.GetNameInternal((int)RouteScoreChangeExplosion.PREFAB_RESOURCE_PATH);
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType((Type)(object)nameInternal);
			GameObject gameObject;
			if (array == null)
			{
				gameObject = null;
			}
			else
			{
				gameObject = (GameObject)(object)(((object)array.GetType() != typeof(GameObject)) ? null : array);
			}
			int layer = gameObject.layer;
			((UnityEngine.Object)this).m_CachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
			Vector3 localPosition = ((Transform)(object)this).localPosition;
			((WaitForSeconds)(object)gameObject)._002Ector(0.1f);
			return (List<EnvironmentKind>)gameObject.GetComponentInChildren<T>();
		}
	}

	public bool IsDone
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_forcedEnvironmentKinds != 0;
		}
	}

	public int ZMinimum => (_progressState == RouteBuildProgress.Done) ? 1 : 0;

	public int ZMaximum => _zMinimum;

	public bool ZMaximumActive => (byte)_zMaximum != 0;

	public int MinSpawnOrder => _zMaximumActive ? 1 : 0;

	public int LengthMin => _minSpawnOrder;

	public int LengthMax
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0010: Expected I4, but got Obj
			object obj = this - -64;
			return (int)obj;
		}
	}

	public ReadOnlyCollection<RouteChunk> PickedChunks
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (ReadOnlyCollection<RouteChunk>)_lengthMax;
		}
	}

	public List<RouteChunk> SpawnedChunks
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			if (_pickedChunksReadOnly == null)
			{
				object obj = this + 112;
				IEnumerator<_00210> enumerator = (IEnumerator<_00210>)((List<T>)(object)_pickedChunks).System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator();
				obj = enumerator;
			}
			return (List<RouteChunk>)(object)_pickedChunksReadOnly;
		}
	}

	public WeightRandomizedRouteChunkContainter StartChunks => (WeightRandomizedRouteChunkContainter)(object)_spawnedChunks;

	public WeightRandomizedRouteChunkContainter MidChunks => _startChunks;

	public WeightRandomizedRouteChunkContainter EndChunks => _midChunks;

	public int SpawnedChunkCount
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)_repeatConfiguration;
		}
	}

	public void Reset(RouteBuilder builder)
	{
		//IL_0039: Expected Obj, but got I
		//IL_001a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteSection)+7C]");
		if (((List<PickupSpawnPoint>)0).Contains((PickupSpawnPoint)(object)builder))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteSection)+7C]");
			bool flag = ((List<PickupSpawnPoint>)0).Remove((PickupSpawnPoint)(object)builder);
		}
	}

	public bool SupportsEnvironment(EnvironmentKind envKind)
	{
		//IL_0039: Expected Obj, but got I4
		//IL_0062: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_00a3: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		object obj = default;
		if (obj == null)
		{
			return true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		RouteType routeType = default;
		object obj2 = routeType + 16;
		object obj3 = default;
		obj2 = obj3;
		bool flag = ((RouteManager)this).CanCreateRoute(routeType);
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)((ComputeShader)flag).FindKernel(null) != 0;
	}

	public RepeatConfiguration GetRepeatConfiguration()
	{
		return (RepeatConfiguration)(object)_endChunks;
	}

	public RouteChunk GetRandomMidChunk(SyboRandom random)
	{
		//IL_002e: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		List<EnvironmentKind> limitedAllowedEnvironmentKinds = _limitedAllowedEnvironmentKinds;
		if (limitedAllowedEnvironmentKinds._size != 0)
		{
			bool flag = _limitedAllowedEnvironmentKinds.Contains((EnvironmentKind)(object)random);
			return (RouteChunk)flag;
		}
		return (RouteChunk)1;
	}

	public RouteChunk GetNextChunk(RouteBuilder builder, SyboRandom random)
	{
		//IL_0027: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		RouteBuilder routeBuilder = default;
		RouteChunk result;
		RouteBuilder routeBuilder2 = default;
		if (routeBuilder.IsDoneLayingSections)
		{
			result = (RouteChunk)1;
		}
		else if (routeBuilder2.IsDoneLayingSections)
		{
			result = (RouteChunk)(-1);
		}
		else
		{
			int spawnedLeadingEdgeWorldPositionZ = routeBuilder.SpawnedLeadingEdgeWorldPositionZ;
			int spawnedLeadingEdgeWorldPositionZ2 = routeBuilder2.SpawnedLeadingEdgeWorldPositionZ;
			object obj = spawnedLeadingEdgeWorldPositionZ - spawnedLeadingEdgeWorldPositionZ2;
			RouteChunk routeChunk = (RouteChunk)(obj * -1);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			IConstrainingRouteBuilder constrainingRouteBuilder = default;
			object obj2;
			if (constrainingRouteBuilder != null && routeBuilder2._constrainingBuilders.Contains(constrainingRouteBuilder))
			{
				result = (RouteChunk)1;
				obj2 = 1;
			}
			else
			{
				result = routeChunk;
				obj2 = 0;
			}
			IConstrainingRouteBuilder constrainingRouteBuilder2 = default;
			object obj3;
			if (constrainingRouteBuilder2 != null)
			{
				bool flag = routeBuilder._constrainingBuilders.Contains(constrainingRouteBuilder2);
				if (flag)
				{
					result = (RouteChunk)(-1);
				}
				obj3 = flag;
			}
			else
			{
				obj3 = 0;
			}
			object obj4 = obj3 & obj2;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
		}
		return result;
	}

	public void AddSpawnedChunk(RouteChunk chunk)
	{
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		object obj = this + 104;
		obj = chunk;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj3 = default;
		object obj2 = obj3 + 16;
		obj2 = this;
		object obj4 = _startChunks + 20;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = this;
		object obj7 = _midChunks + 20;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj9 = default;
		object obj8 = obj9 + 16;
		obj8 = this;
		object obj10 = _endChunks + 20;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		object obj12 = default;
		object obj11 = obj12 + 16;
		obj11 = this;
		object obj13 = _filteredChunks + 20;
		obj13 = obj12;
		((WeightRandomizedPrefabContainter<, >)(object)_filteredChunks).RemoveEmptyEntries();
		throw new IndexOutOfRangeException();
	}

	public void RemoveSpawnedChunk(RouteChunk chunk)
	{
		_spawnedChunks.Add(chunk);
	}

	public RouteChunk GetSpawnedChunk(int index)
	{
		//IL_0014: Expected Obj, but got I4
		RouteChunk routeChunk = _midChunks.PickSemiRandomlyOrderedPrefab((SyboRandom)index);
		_pickedChunks.Add(routeChunk);
		return routeChunk;
	}

	public bool HasChunk(RouteChunk chunk)
	{
		//IL_0014: Expected I4, but got Obj
		//IL_0020: Expected I4, but got Obj
		List<RouteChunk> spawnedChunks = _spawnedChunks;
		if (spawnedChunks._size > (nint)chunk)
		{
			RouteChunk routeChunk = _spawnedChunks.get_Item((int)chunk);
			return (byte)(int)routeChunk != 0;
		}
		return false;
	}

	public IRouteTransitionTrigger GetTransitionTrigger()
	{
		//IL_0019: Expected Obj, but got I4
		List<RouteChunk> spawnedChunks = _spawnedChunks;
		return (IRouteTransitionTrigger)spawnedChunks._size;
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_0315: Expected Obj, but got I4
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_03a8: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_00be: Expected I, but got Obj
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [457C0A]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		string text = null;
		object obj5 = default;
		object obj7 = default;
		object obj16 = default;
		while (true)
		{
			bool flag3 = text == null;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (flag3)
					{
						break;
					}
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v88 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v122 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj7 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					}
					continue;
				}
				object obj8 = obj4 + 4;
				object obj9 = obj8 + 1;
				obj8 = obj9;
				object obj10 = obj9 << 2;
				object obj11 = obj4 + obj10;
				obj11 = 101;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
					object obj12 = (nint)0 << 2;
					object obj13 = obj4 + obj12;
					if ((nint)obj13 == 101)
					{
						object obj14 = obj4 + 4;
						if ((nint)obj14 > -1)
						{
							object obj15 = obj14 + -1;
							obj14 = obj15;
						}
						goto IL_0409;
					}
				}
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_0409;
				IL_0409:
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					UnityEngine.Object obj17 = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
					throw new ArrayTypeMismatchException();
				}
				return text;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v83+44]");
			text = (string)0;
		}
	}

	private bool CanSpawnChunk(RouteChunk chunk)
	{
		if (_startChunks.Contains(chunk))
		{
			return true;
		}
		if (_midChunks.Contains(chunk))
		{
			return true;
		}
		return _endChunks.Contains(chunk);
	}

	private void IncrementProgressState()
	{
		CancelInvoke();
	}

	private WeightRandomizedRouteChunkContainter GetProgressStateChunks(RouteBuildProgress progressState)
	{
		//IL_0056: Expected Obj, but got I4
		//IL_0014: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [progressState @ L1 (SYBO.Subway.Routes.RouteBuildProgress)+1C]");
		if ((nint)0 == 0 && _pickedChunks.Contains((RouteChunk)progressState))
		{
			return null;
		}
		bool flag = _builder.IsStartPositionConstrained((int)progressState);
		return (WeightRandomizedRouteChunkContainter)flag;
	}

	public RouteSection()
	{
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_004b: Expected Obj, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		object obj6 = default;
		object obj13 = default;
		while (_progressState != RouteBuildProgress.Done)
		{
			bool flag = ((ConstrainingRouteBuilder)(object)this).IsConstrainingStartAt((int)_progressState);
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v7 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v8+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v9+8]");
			object obj3 = 0;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v60 @ S2_v7 (should have been resolved before IL gen)");
			bool flag2 = obj6 != null;
			bool flag3 = _progressState == RouteBuildProgress.Mid;
			object obj7 = flag2 & flag3;
			if (obj7 == null || (~(_middleChunkCountLimited ? 1u : 0u) == 0 && _midChunksCountUsed >= _midChunksCountTarget))
			{
				RouteBuildProgress progressState = _progressState + 1;
				_progressState = progressState;
				if (_progressState != RouteBuildProgress.Done)
				{
					bool flag4 = ((ConstrainingRouteBuilder)(object)this).IsConstrainingStartAt((int)_progressState);
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v23 (Il2CppMethodInfo)+C]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v24+60]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v25+8]");
					object obj10 = 0;
					object obj11 = obj10 & 0x3FFF;
					object obj12 = obj11 + 6161;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13 @ S2_v14 (should have been resolved before IL gen)");
					if (obj13 != null)
					{
						break;
					}
					continue;
				}
				break;
			}
			break;
		}
	}
}
