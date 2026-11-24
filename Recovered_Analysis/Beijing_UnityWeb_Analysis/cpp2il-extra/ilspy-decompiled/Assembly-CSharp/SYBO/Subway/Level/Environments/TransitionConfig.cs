using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Components.Utilities.Validators;
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

		public float SpawnProbability;

		public WeightRandomizedTransitionPrefabContainer()
		{
			//IL_00fb: Expected Obj, but got I
			//IL_001a: Expected Obj, but got I
			//IL_002c: Expected I, but got Obj
			//IL_0042: Expected Obj, but got I
			//IL_006d: Expected I, but got Obj
			int num = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Environments.TransitionConfig+WeightRandomizedTransitionPrefabContainer)+8]");
				object obj = 0;
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v4+C]");
				if ((nint)num2 >= (nint)0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Environments.TransitionConfig+WeightRandomizedTransitionPrefabContainer)+8]");
				Transform prefabPool = ((List<Transform>)0).get_Item(num);
				nint num3 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v11 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v17 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				PoolManager.AddPool((PrefabPool)(object)prefabPool);
				int num5 = num + 1;
				num = num5;
			}
			throw new IndexOutOfRangeException();
		}
	}

	[Serializable]
	private class WeightedTransitionPrefab : WeightedPrefab<Transform>
	{
		public WeightedTransitionPrefab()
		{
			_ = 1f;
			((IDisposable)this).Dispose();
		}
	}

	private EnvironmentKind _environmentKind;

	private WeightRandomizedTransitionPrefabContainer _transitionStart;

	private WeightRandomizedTransitionPrefabContainer _transitionEnd;

	public EnvironmentKind EnvironmentKind => (EnvironmentKind)(object)_transitionEnd;

	public void Initialize()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 16;
		GamePositionRoot instance = GamePositionRoot.Instance;
		obj2 = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = default;
		object obj3 = obj4 + 8;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v8 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v9+60]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7 & 0xFFF;
		object obj9 = obj8 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ S2_v4 (should have been resolved before IL gen)");
		object obj10 = default;
		obj3 = obj10;
		object obj11 = this + 20;
		obj11 = obj4;
		((Validator<>)this)._002Ector();
	}

	public unsafe bool TryGetStartPrefab(EnvironmentKind fromEnvironment, SyboRandom random, out Transform prefab)
	{
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected Obj, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected VT, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected Obj, but got Unknown
		//IL_0051: Expected VT, but got Obj
		//IL_0061: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00dc: Expected I4, but got Obj
		//IL_00fb: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got F4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_018a: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I
		//IL_04f9: Expected F4, but got Obj
		//IL_04f4: Expected native int or pointer, but got VT
		//IL_050e: Expected F4, but got I
		//IL_0509: Expected native int or pointer, but got VT
		//IL_0538: Expected VT, but got Obj
		//IL_021d: Expected Obj, but got I4
		//IL_0225: Invalid comparison between Ref and Obj
		//IL_01cb: Expected I, but got Obj
		//IL_0596: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_02b7: Expected I4, but got Obj
		//IL_02d1: Expected Obj, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02ef: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got F4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_0360: Expected I, but got Obj
		//IL_0376: Expected Obj, but got I
		//IL_05b9: Expected F4, but got Obj
		//IL_05b4: Expected native int or pointer, but got VT
		//IL_05ce: Expected F4, but got I
		//IL_05c9: Expected native int or pointer, but got VT
		//IL_05f8: Expected VT, but got Obj
		//IL_03a1: Expected I, but got Obj
		//IL_040c: Expected VT, but got Obj
		//IL_040c: Expected Obj, but got VT
		//IL_0419: Expected Obj, but got F4
		//IL_042b: Expected I, but got F4
		object obj = default;
		Transform transform = (Transform)(obj + 48);
		Vector3 vector = (Vector3)(obj + 36);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		ref Transform reference = default;
		ref Transform reference2;
		if ((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) > unchecked((nint)null))
		{
			reference2 = ref reference;
		}
		else
		{
			reference = ref *(Transform*)null;
			reference2 = ref *(Transform*)null;
		}
		if ((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) < (nint)fromEnvironment._density)
		{
			BackgroundObject backgroundObject = ((List<BackgroundObject>)(object)fromEnvironment).get_Item((int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			GameObject gameObject = backgroundObject.gameObject;
			transform.localPosition = (Vector3)gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Environments.TransitionConfig)+24]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v16+C]");
			object obj5 = 0;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v17+C]");
			if ((nint)transform2 > 0)
			{
				GameObject gameObject2 = backgroundObject.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Environments.TransitionConfig)+24]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v22+C]");
				object obj7 = 0;
				float z = ((EnvironmentBackground)null).GetZ((int)backgroundObject._meshRenderers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [random @ L2 (SYBO.Common.Utilities.SyboRandom)+1C]");
				object obj8 = -0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Environments.TransitionConfig)+2C]");
				object obj9 = obj8 * 0;
				obj2 = 0;
				_ = 0;
				float num = z * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v23+8]");
				float num2 = 0f - num;
				obj2 = num2;
				_ = 0f;
				object obj10 = random + 32;
				obj3 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S2_v19+8]");
				_ = 0;
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v38 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num4 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v94 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector2 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Vector3*)(nint)vector2)->z = 0f;
				transform = (Transform)obj3;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				Vector3 vector3 = vector - (Vector3)transform;
				transform = (Transform)obj;
				Transform transform4 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles = transform.eulerAngles;
				((CheckpointTrigger)null).Handler_OnCharacterEnter((object)backgroundObject, (EventArgs)null);
				object obj12 = fromEnvironment._density - 1;
				int num5 = (int)((!System.Runtime.CompilerServices.Unsafe.AreSame(ref System.Runtime.CompilerServices.Unsafe.As<Transform, byte>(ref reference), ref *(byte*)obj12)) ? System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 1)) : null);
				BackgroundObject sender = ((List<BackgroundObject>)(object)fromEnvironment).get_Item(num5);
				((CheckpointTrigger)null).Handler_OnCharacterEnter((object)sender, (EventArgs)1);
				BackgroundObject backgroundObject2 = ((List<BackgroundObject>)(object)fromEnvironment).get_Item(num5);
				GameObject gameObject3 = backgroundObject2.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Environments.TransitionConfig)+24]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v56+C]");
				object obj14 = 0;
				BackgroundObject backgroundObject3 = ((List<BackgroundObject>)(object)fromEnvironment).get_Item(num5);
				float z2 = ((EnvironmentBackground)null).GetZ((int)backgroundObject3._meshRenderers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [random @ L2 (SYBO.Common.Utilities.SyboRandom)+1C]");
				object obj15 = -0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Environments.TransitionConfig)+2C]");
				object obj16 = obj15 * 0;
				obj2 = 0;
				_ = 0;
				float num6 = z2 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S1_v57+8]");
				float num7 = 0f - num6;
				obj2 = num7;
				_ = 0f;
				object obj17 = random + 32;
				obj3 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S2_v61+8]");
				_ = 0;
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S1_v72 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num9 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v90 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector4 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Vector3*)(nint)vector4)->z = 0f;
				transform = (Transform)obj3;
				Transform transform5 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				Vector3 vector5 = vector - (Vector3)transform;
				transform = (Transform)obj;
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles2 = transform.eulerAngles;
				bool flag = (byte)(~(backgroundObject._movable ? 1u : 0u)) != 0;
				reference = ref *(Transform*)num5;
				if (!flag)
				{
					MoveGameObject component = backgroundObject.GetComponent<MoveGameObject>();
					GameObject gameObject4 = backgroundObject.gameObject;
					((Transform)vector).localPosition = (Vector3)gameObject4;
					transform = (Transform)vector.x;
					((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
					((RandomizeOffset)(object)component).SetRandomOffsetsData((RandomizeOffset.RandomOffsetsData)(object)transform);
					reference = ref *(Transform*)num5;
				}
			}
			return (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != 0;
		}
		return false;
	}

	public unsafe bool TryGetEndPrefab(EnvironmentKind toEnvironment, SyboRandom random, out Transform prefab)
	{
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01ce: Expected Obj, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0049: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_008a: Expected I, but got Obj
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		ref Transform reference = ref *(Transform*)null;
		WeightRandomizedTransitionPrefabContainer transitionStart = _transitionStart;
		object obj = transitionStart.ExcludeEnvironments + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = transitionStart.ExcludeEnvironments + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			object obj6 = obj5;
			nint num = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v28 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v43 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v26+8]");
			bool flag;
			if ((nint)0 == (nint)toEnvironment._type)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v26+C]");
				flag = (nint)0 == (nint)toEnvironment._density;
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				object obj8 = obj2 + 1;
				obj2 = obj8;
				continue;
			}
			return false;
		}
		float num3 = ((UnityRandomGen)(object)random).NextFloat();
		WeightRandomizedTransitionPrefabContainer transitionStart2 = _transitionStart;
		bool result;
		if (num3 > transitionStart2.SpawnProbability)
		{
			result = false;
		}
		else
		{
			Transform transform = _transitionStart.PickSemiRandomlyOrderedPrefab(random);
			reference = ref *(Transform*)transform;
			result = true;
		}
		return result;
	}

	public TransitionConfig()
	{
		_transitionStart.RemoveEmptyEntries();
		_transitionEnd.RemoveEmptyEntries();
	}
}
