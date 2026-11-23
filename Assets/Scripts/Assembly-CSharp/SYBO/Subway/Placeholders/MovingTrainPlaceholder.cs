using Cpp2ILInjected;
using SYBO.Subway.Level;
using SYBO.Subway.Placeholders.PrefabProviders;
using UnityEngine;

namespace SYBO.Subway.Placeholders;

public class MovingTrainPlaceholder : Placeholder
{
	private float _speed = 1f;

	public float Speed => _speed;

	protected override Transform InitializeSpawnedInstance(Transform objectTransform, string newName)
	{
		Transform result = base.InitializeSpawnedInstance(objectTransform, newName);
		MovingTrain[] componentsInChildren = _transform.GetComponentsInChildren<MovingTrain>(includeInactive: true);
		object obj;
		if (componentsInChildren.Length == 0)
		{
			obj = "Utils could not find moving train in children of ";
		}
		else
		{
			componentsInChildren[0].Speed = _speed;
			bool flag = componentsInChildren.Length < 2;
			obj = "Moving train placeholder loaded multiple MovingTrain chidren - ";
			if (flag)
			{
				goto IL_007e;
			}
		}
		string longName = Utils.GetLongName(_transform);
		string text = (string)obj + longName;
		goto IL_007e;
		IL_007e:
		return result;
	}

	public unsafe void OnDrawGizmos()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected VT, but got Unknown
		//IL_01bf: Expected F4, but got I
		//IL_01ba: Expected native int or pointer, but got VT
		//IL_01f8: Expected F4, but got I
		//IL_01f3: Expected native int or pointer, but got VT
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		PlaceholderPrefabProvider componentInChildren = GetComponentInChildren<PlaceholderPrefabProvider>();
		if (!(componentInChildren != null) || !(componentInChildren._prefab != null))
		{
			return;
		}
		BoxCollider[] componentsInChildren = componentInChildren._prefab.GetComponentsInChildren<BoxCollider>(includeInactive: true);
		if (componentsInChildren == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [C]");
			if ((nint)0 != 0)
			{
				return;
			}
		}
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 1065353216;
		_ = 1065353216;
		Color color = (Color)(vector + 32);
		Gizmos.color = color;
		Vector3 size = componentsInChildren[0].size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		float num = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		float num2 = 0f * 0.5f;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		float num3 = 0f + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		float num4 = 0f + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		float num5 = 0f + num2;
		Vector3 size2 = componentsInChildren[0].size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		((Vector3*)(nint)vector)->x = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 center = vector + 16;
		Gizmos.DrawWireCube(center, vector);
	}
}
