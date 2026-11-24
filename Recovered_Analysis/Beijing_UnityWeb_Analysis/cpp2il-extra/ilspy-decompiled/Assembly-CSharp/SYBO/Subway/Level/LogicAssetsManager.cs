using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Subway.Level;

public class LogicAssetsManager : SingletonMonoBehaviour<LogicAssetsManager>
{
	[Serializable]
	public class BasicObstaclePrefab
	{
		public BasicObstacleType Type;

		public GameObject Prefab;

		internal BasicObstaclePrefab(BasicObstacleType type)
		{
			//IL_005c: Expected I, but got Obj
			//IL_0072: Expected Obj, but got I
			//IL_0122: Expected Obj, but got I
			//IL_0016: Expected Obj, but got I
			//IL_009d: Expected I, but got Obj
			//IL_00ed: Expected Obj, but got I
			//IL_0044: Expected Obj, but got I
			if (type != BasicObstacleType.LightSignal)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.LogicAssetsManager+BasicObstaclePrefab)+10]");
				if (((AudioSource)0).loop)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.LogicAssetsManager+BasicObstaclePrefab)+10]");
					((AudioSource)0).UnPause();
				}
				return;
			}
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.LogicAssetsManager+BasicObstaclePrefab)+14]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.LogicAssetsManager+BasicObstaclePrefab)+10]");
				((AudioSource)0).Stop();
			}
		}
	}

	[Serializable]
	public class BlockerObstaclePrefab
	{
		public BlockerObstacleType Type;

		public GameObject Prefab;

		internal BlockerObstaclePrefab(BlockerObstacleType type)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected Obj, but got Unknown
			//IL_001e: Expected Obj, but got I4
			Type = type;
			object obj = this + 12;
			obj = 0;
		}
	}

	[Serializable]
	public class EnvironmentObstaclePrefab
	{
		public EnvironmentObstacleType Type;

		public GameObject Prefab;

		internal EnvironmentObstaclePrefab(EnvironmentObstacleType type)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected Obj, but got Unknown
			//IL_001e: Expected Obj, but got I4
			Type = type;
			object obj = this + 12;
			obj = 0;
		}
	}

	[Serializable]
	public class ObstacleAssets
	{
		public List<BasicObstaclePrefab> basicObstacles;

		public List<BasicObstaclePrefab> basicObstaclesWithCoins;

		public List<BlockerObstaclePrefab> blockerObstacles;

		public List<BlockerObstaclePrefab> blockerObstaclesWithCoins;

		public List<EnvironmentObstaclePrefab> environmentObstacles;

		public List<EnvironmentObstaclePrefab> environmentObstaclesExtended;

		internal ObstacleAssets()
		{
		}
	}

	public ObstacleAssets obstacles;

	public EnvironmentAssets environment;

	protected override void SubclassInitialize()
	{
	}

	public bool HasEnvironmentSegmentLogic(EnvironmentType envType)
	{
		//IL_00a8: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L1 (SYBO.Subway.Level.EnvironmentType)+8]");
		if ((UnityEngine.Object)0 != null)
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.LogicAssetsManager)+1C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L1 (SYBO.Subway.Level.EnvironmentType)+8]");
		((SkinnedMeshRenderer)num3).sharedMesh = (Mesh)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
		return true;
	}

	public unsafe Transform SpawnEnvironmentSegmentLogic(EnvironmentType envType, EnvironmentSequence sequence)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_00da: Expected I, but got Obj
		//IL_00f0: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_023b: Expected Obj, but got I4
		//IL_024a: Expected Obj, but got F4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_0271: Expected Obj, but got I4
		//IL_0294: Expected I, but got Obj
		//IL_02aa: Expected Obj, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected VT, but got Unknown
		//IL_0128: Expected F4, but got Obj
		//IL_0123: Expected native int or pointer, but got VT
		//IL_013d: Expected F4, but got I
		//IL_0138: Expected native int or pointer, but got VT
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected VT, but got Unknown
		//IL_0158: Expected F4, but got Obj
		//IL_0153: Expected native int or pointer, but got VT
		//IL_016d: Expected F4, but got I
		//IL_0168: Expected native int or pointer, but got VT
		//IL_01a0: Expected F4, but got Obj
		//IL_019b: Expected native int or pointer, but got VT
		//IL_01b5: Expected F4, but got I
		//IL_01b0: Expected native int or pointer, but got VT
		//IL_01d2: Expected I4, but got VT
		//IL_01cd: Expected native int or pointer, but got Obj
		//IL_01e7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v58 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BackgroundObject backgroundObject = UnityEngine.Object.Instantiate((BackgroundObject)envType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L2 (SYBO.Subway.Level.EnvironmentSequence)+1C]");
		object obj4 = -0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.LogicAssetsManager)+2C]");
		object obj5 = obj4 * 0;
		object obj6 = obj2 + 24;
		obj6 = 0;
		_ = 0;
		obj6 = 0f;
		_ = 0f;
		object obj7 = obj2 + 12;
		object obj8 = sequence + 32;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v21+8]");
		_ = 0;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v31 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v54 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v22+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 60);
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v28+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = vector - vector2;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.LogicAssetsManager)+1C]");
		*(EnvironmentBaseKind*)(nint)backgroundObject = new EnvironmentBaseKind((EnvironmentBaseType)sequence, EnvironmentBaseShadowSequence.None, (int)vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L2 (SYBO.Subway.Level.EnvironmentSequence)+44]");
		((List<BackgroundObject>)0).Add(backgroundObject);
		((CheckpointTrigger)null).Handler_OnCharacterEnter((object)backgroundObject, (EventArgs)null);
		return (Transform)(object)backgroundObject;
	}

	public void DespawnEnvironmentSegmentLogic(Transform segmentTransform)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = segmentTransform + 24;
		LogicAssetsManager logicAssetsManager = (LogicAssetsManager)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
		_ = 0;
	}

	public LogicAssetsManager()
	{
		//IL_001d: Expected VT, but got I4
		GameObject childTransform = gameObject;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)childTransform, HierarchyPathType.DynamicManagers, (Vector3)0);
	}
}
