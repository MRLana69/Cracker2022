using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.U2D;

public class Mirror : MonoBehaviour
{
	private Transform[] children;

	private TrackObject trackObject;

	private void Awake()
	{
		CancelInvoke();
	}

	public unsafe void OnActivate()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		TrackObject component = GetComponent<TrackObject>();
		bool flag = (object)component == null;
		bool flag2 = !flag;
		TrackObject trackObject = component;
		if (!flag2)
		{
			string text = tag;
			TrackObject trackObject2 = ((GameObject)(object)text).AddComponent<TrackObject>();
			trackObject = trackObject2;
		}
		object obj = this + 16;
		obj = trackObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(Mirror.OnActivate);
		object obj2 = action + 16;
		obj2 = this;
		this.trackObject.OnActivate -= action;
		GameObject gameObject = base.gameObject;
		int siblingIndex = ((Transform)(object)gameObject).GetSiblingIndex();
		object obj3 = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		Sprite sprite = null;
		GameObject gameObject2 = base.gameObject;
		int siblingIndex2 = ((Transform)(object)gameObject2).GetSiblingIndex();
		if ((nint)sprite < siblingIndex2)
		{
			GameObject gameObject3 = base.gameObject;
			bool flag3 = ((SpriteAtlas)(object)gameObject3).CanBindTo(sprite);
			throw new ArrayTypeMismatchException();
		}
	}

	public Mirror()
	{
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00f6: Expected VT, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 36);
		Transform transform2 = (Transform)(obj + 12);
		object obj2 = obj + 24;
		obj2 = 0;
		_ = 0;
		int num = UnityEngine.Random.RandomRangeInt(0, 2);
		int num2 = num << 1;
		object obj3 = num2 - 1;
		object obj4 = default;
		object obj13 = default;
		while (true)
		{
			Transform[] array = children;
			if ((nint)obj4 >= array.Length)
			{
				break;
			}
			object obj5 = children + 16;
			object obj6 = obj4 << 2;
			object obj7 = obj5 + obj6;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj7).FindKernel((string)null) != 0)
			{
				object obj9 = children + 16;
				object obj10 = obj4 << 2;
				object obj11 = obj9 + obj10;
				transform2.localPosition = (Vector3)obj11;
				obj2 = transform2;
				_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				obj = transform2;
				_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				object obj12 = obj * obj3;
				obj2 = obj12;
				transform = (Transform)obj2;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles = transform.eulerAngles;
			}
			obj4 = obj13 + 1;
		}
	}
}
