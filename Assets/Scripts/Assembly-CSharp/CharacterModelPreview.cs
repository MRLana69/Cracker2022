using System;
using Cpp2ILInjected;
using UnityEngine;

public class CharacterModelPreview : MonoBehaviour
{
	private GameObject _rigPrefab;

	private SkinnedMeshRenderer[] _renderes;

	public SkinnedMeshRenderer[] Renderes => _renderes;

	private void Awake()
	{
		BuildRig();
	}

	private unsafe void BuildRig()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00f5: Expected I, but got Obj
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected VT, but got Unknown
		//IL_016d: Expected I, but got Obj
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected VT, but got Unknown
		//IL_01e5: Expected I, but got Obj
		//IL_020a: Expected F4, but got I
		//IL_0205: Expected native int or pointer, but got VT
		//IL_0218: Expected F4, but got VT
		//IL_0213: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		GameObject gameObject = UnityEngine.Object.Instantiate(_rigPrefab);
		Transform transform = gameObject.transform;
		Transform parent = base.transform;
		transform.parent = parent;
		Transform transform2 = gameObject.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 localPosition = vector + 32;
		transform2.localPosition = localPosition;
		Transform transform3 = gameObject.transform;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v36 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v37 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 16);
		transform3.localRotation = localRotation;
		Transform transform4 = gameObject.transform;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v33 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v34 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform4.localScale = vector;
		CharacterRig component = gameObject.GetComponent<CharacterRig>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		SkinnedMeshRenderer[] renderes = default;
		_renderes = renderes;
		SkinnedMeshRenderer[] renderes2 = _renderes;
		throw new ArrayTypeMismatchException();
	}
}
