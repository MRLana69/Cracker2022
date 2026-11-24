using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

public class CharacterModelPreview : MonoBehaviour
{
	private GameObject _rigPrefab;

	private SkinnedMeshRenderer[] _renderes;

	public SkinnedMeshRenderer[] Renderes
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			//IL_001c: Expected Obj, but got VT
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			IEnumerator enumerator = ((AvatarAnimations)val).Play();
			((CharacterModel)this).AddCustomHoverboardVanityMenuFX((GameObject)(object)enumerator, (Transform)null);
			return (SkinnedMeshRenderer[])(object)enumerator;
		}
	}

	private void Awake()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Renderer> list = default;
		list._002Ector();
		object obj = this + 72;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<GameObject> list2 = default;
		list2._002Ector();
		object obj2 = this + 212;
		obj2 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Renderer> list3 = default;
		list3._002Ector();
		object obj3 = this + 216;
		obj3 = list3;
		CancelInvoke();
	}

	private void BuildRig()
	{
		this._002Ector();
	}

	public CharacterModelPreview()
	{
		//IL_0271: Expected I, but got Obj
		//IL_0287: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_00c0: Expected I, but got Obj
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_01c0: Expected Obj, but got I4
		//IL_014e: Expected I, but got Obj
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate(_rigPrefab);
		int layer = gameObject.layer;
		GameObject parentInternal = base.gameObject;
		((Transform)layer).parentInternal = (Transform)(object)parentInternal;
		int layer2 = gameObject.layer;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v15 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v63 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 32;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj4 + 48);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v20+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		int layer3 = gameObject.layer;
		nint num5 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v27 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v59 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj4 + 16;
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj6;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v32+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		int layer4 = gameObject.layer;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj4;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)layer4).parent = transform;
		CharacterRig component = gameObject.GetComponent<CharacterRig>();
		object obj7 = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj8 = default;
		obj7 = obj8;
		throw new ArrayTypeMismatchException();
	}
}
