using System;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Level.Environments;

[Serializable]
public class TransitionConfig
{
	[Serializable]
	private class WeightRandomizedTransitionPrefabContainer : WeightRandomizedPrefabContainter<WeightedTransitionPrefab, Transform>
	{
		public EnvironmentKind[] ExcludeEnvironments;

		public float SpawnProbability = 1f;
	}

	[Serializable]
	private class WeightedTransitionPrefab : WeightedPrefab<Transform>
	{
		public WeightedTransitionPrefab()
		{
			_ = 1;
			_ = 1;
		}
	}

	private EnvironmentKind _environmentKind;

	private WeightRandomizedTransitionPrefabContainer _transitionStart;

	private WeightRandomizedTransitionPrefabContainer _transitionEnd;

	public EnvironmentKind EnvironmentKind => _environmentKind;

	public void Initialize()
	{
		_transitionStart.RemoveEmptyEntries();
		_transitionEnd.RemoveEmptyEntries();
	}

	public unsafe bool TryGetStartPrefab(EnvironmentKind fromEnvironment, SyboRandom random, out Transform prefab)
	{
		//IL_013e: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		ref Transform reference = ref *(Transform*)null;
		WeightRandomizedTransitionPrefabContainer transitionStart = _transitionStart;
		EnvironmentKind[] excludeEnvironments = transitionStart.ExcludeEnvironments;
		object obj = 0;
		bool result;
		while (true)
		{
			if (excludeEnvironments.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)excludeEnvironments + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+10]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
				bool flag;
				if ((nint)0 == (nint)fromEnvironment._type)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+C]");
					flag = (nint)0 == (nint)fromEnvironment._density;
				}
				else
				{
					flag = false;
				}
				result = false;
				if (flag)
				{
					break;
				}
				object obj5 = obj + 1;
				obj = obj5;
				continue;
			}
			float num = random.Value();
			WeightRandomizedTransitionPrefabContainer transitionStart2 = _transitionStart;
			bool flag2 = num > transitionStart2.SpawnProbability;
			result = false;
			if (!flag2)
			{
				Transform transform = transitionStart2.PickSemiRandomlyOrderedPrefab(random);
				reference = ref *(Transform*)transform;
				result = true;
			}
			break;
		}
		return result;
	}

	public unsafe bool TryGetEndPrefab(EnvironmentKind toEnvironment, SyboRandom random, out Transform prefab)
	{
		//IL_013e: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		ref Transform reference = ref *(Transform*)null;
		WeightRandomizedTransitionPrefabContainer transitionEnd = _transitionEnd;
		EnvironmentKind[] excludeEnvironments = transitionEnd.ExcludeEnvironments;
		object obj = 0;
		bool result;
		while (true)
		{
			if (excludeEnvironments.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)excludeEnvironments + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+10]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
				bool flag;
				if ((nint)0 == (nint)toEnvironment._type)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+C]");
					flag = (nint)0 == (nint)toEnvironment._density;
				}
				else
				{
					flag = false;
				}
				result = false;
				if (flag)
				{
					break;
				}
				object obj5 = obj + 1;
				obj = obj5;
				continue;
			}
			float num = random.Value();
			WeightRandomizedTransitionPrefabContainer transitionEnd2 = _transitionEnd;
			bool flag2 = num > transitionEnd2.SpawnProbability;
			result = false;
			if (!flag2)
			{
				Transform transform = transitionEnd2.PickSemiRandomlyOrderedPrefab(random);
				reference = ref *(Transform*)transform;
				result = true;
			}
			break;
		}
		return result;
	}

	public TransitionConfig()
	{
		EnvironmentKind none = EnvironmentKind.None;
		_environmentKind = none;
		WeightRandomizedTransitionPrefabContainer weightRandomizedTransitionPrefabContainer = default;
		weightRandomizedTransitionPrefabContainer._002Ector();
		_transitionStart = weightRandomizedTransitionPrefabContainer;
		WeightRandomizedTransitionPrefabContainer weightRandomizedTransitionPrefabContainer2 = default;
		weightRandomizedTransitionPrefabContainer2._002Ector();
		_transitionEnd = weightRandomizedTransitionPrefabContainer2;
	}
}
