using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIWrapContent : MonoBehaviour
{
	public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);

	public int itemSize;

	public bool cullContent;

	public int minIndex;

	public int maxIndex;

	public bool hideInactive;

	public OnInitializeItem onInitializeItem;

	protected Transform mTrans;

	protected UIPanel mPanel;

	protected UIScrollView mScroll;

	protected bool mHorizontal;

	protected bool mFirstTime;

	protected List<Transform> mChildren;

	protected virtual void Start()
	{
		CancelInvoke();
	}

	protected virtual void OnMove(UIPanel panel)
	{
		//IL_000a: Expected I4, but got Obj
		((UIToggle)this).isChecked = (byte)(int)panel != 0;
	}

	public virtual void SortBasedOnScrollMovement()
	{
		//IL_00d3: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mScroll).FindKernel((string)null) != 0)
		{
			UIPanel component = mScroll.GetComponent<UIPanel>();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = new NullReferenceException();
			object obj3 = default;
			object obj2 = obj3 + 16;
			obj2 = this;
			object obj4 = component + 196;
			obj4 = obj3;
		}
		mFirstTime = false;
	}

	public virtual void SortAlphabetically()
	{
		if (((ActiveAnimation)this).isPlaying)
		{
			throw new IndexOutOfRangeException();
		}
	}

	protected bool CacheScrollView()
	{
		//IL_028e: Expected I, but got Obj
		//IL_02a4: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01d7: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_00fc: Expected I, but got Obj
		//IL_016f: Expected I4, but got Obj
		object obj2 = default;
		bool result;
		object obj8 = default;
		while (true)
		{
			nint num = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v6 (Il2CppClass<UIToggle>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v54 (Il2CppClass<UIToggle>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UIToggle> list = UIToggle.list;
			if ((nint)obj2 >= list.size)
			{
				result = false;
				break;
			}
			nint num3 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v15 (Il2CppClass<UIToggle>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v47 (Il2CppClass<UIToggle>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UIToggle> list2 = UIToggle.list;
			object obj4 = list2.buffer + 16;
			object obj5 = obj2 << 2;
			object obj6 = obj4 + obj5;
			ComputeShader computeShader = (ComputeShader)obj6;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj6).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v27 (UnityEngine.ComputeShader)+C]");
				if (0 == (nint)this)
				{
					result = (byte)(int)obj6 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v27 (UnityEngine.ComputeShader)+41]");
					if ((nint)0 != 0)
					{
						break;
					}
				}
			}
			obj2 = obj8 + 1;
		}
		return result;
	}

	protected virtual void ResetChildPositions()
	{
		if (((ActiveAnimation)this).isPlaying)
		{
			throw new IndexOutOfRangeException();
		}
	}

	public virtual void WrapContent()
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got F4
		//IL_0098: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00ec: Expected I, but got F4
		//IL_003a: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		obj = 0;
		_ = 0;
		List<Transform> list = mChildren;
		int num = default;
		int num2 = default;
		while (num < list._size)
		{
			Transform transform2 = mChildren.get_Item(num);
			if (~(mHorizontal ? 1u : 0u) == 0)
			{
				transform = (Transform)0;
				((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
				object obj2 = itemSize * num;
				transform = (Transform)obj2;
				_ = 0f;
			}
			else
			{
				transform = (Transform)0;
				((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
				transform = (Transform)0f;
				object obj3 = -num;
				object obj4 = itemSize * obj3;
			}
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0f;
			obj = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			transform = (Transform)obj;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
			num = num2 + 1;
		}
	}

	private unsafe void OnValidate()
	{
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected Ref, but got Unknown
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f02: Expected VT, but got Unknown
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f10: Expected Obj, but got Unknown
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1e: Expected Obj, but got Unknown
		//IL_0f27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2c: Expected Obj, but got Unknown
		//IL_0f35: Expected Obj, but got I4
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Expected Obj, but got Unknown
		//IL_0f52: Expected Obj, but got I4
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected Obj, but got Unknown
		//IL_0f6f: Expected Obj, but got I4
		//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f83: Expected Obj, but got Unknown
		//IL_0f8c: Expected Obj, but got I4
		//IL_0f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa0: Expected Obj, but got Unknown
		//IL_0fa9: Expected Obj, but got I4
		//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbd: Expected Obj, but got Unknown
		//IL_0fc6: Expected Obj, but got I4
		//IL_0fea: Expected Obj, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_1041: Expected F4, but got Obj
		//IL_103c: Expected native int or pointer, but got VT
		//IL_1053: Expected F4, but got I
		//IL_104e: Expected native int or pointer, but got VT
		//IL_107a: Expected VT, but got Ref
		//IL_10ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b1: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_003b: Expected F4, but got Obj
		//IL_0036: Expected native int or pointer, but got VT
		//IL_0050: Expected F4, but got I
		//IL_004b: Expected native int or pointer, but got VT
		//IL_005d: Expected Obj, but got F4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got VT
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_086e: Expected Obj, but got I
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected Obj, but got Unknown
		//IL_0893: Expected Obj, but got I
		//IL_08a6: Expected Obj, but got F4
		//IL_01a6: Expected I, but got Obj
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_0224: Expected Obj, but got F4
		//IL_0236: Expected Obj, but got I4
		//IL_125d: Expected Obj, but got I4
		//IL_1266: Unknown result type (might be due to invalid IL or missing references)
		//IL_126b: Expected I4, but got Unknown
		//IL_08dd: Expected VT, but got Obj
		//IL_08dd: Expected Obj, but got Ref
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected Obj, but got Unknown
		//IL_08ef: Expected F4, but got Obj
		//IL_08ea: Expected native int or pointer, but got VT
		//IL_0904: Expected F4, but got I
		//IL_08ff: Expected native int or pointer, but got VT
		//IL_0928: Invalid comparison between F4 and Obj
		//IL_025b: Expected VT, but got Obj
		//IL_025b: Expected Obj, but got Ref
		//IL_026d: Expected F4, but got Obj
		//IL_0268: Expected native int or pointer, but got VT
		//IL_0282: Expected F4, but got I
		//IL_027d: Expected native int or pointer, but got VT
		//IL_02a3: Invalid comparison between F4 and Obj
		//IL_0b86: Expected VT, but got Obj
		//IL_0b86: Expected Obj, but got Ref
		//IL_0b93: Expected Obj, but got VT
		//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bae: Expected Obj, but got Unknown
		//IL_0bc5: Expected Obj, but got F4
		//IL_0bd2: Expected F4, but got Obj
		//IL_0bcd: Expected native int or pointer, but got VT
		//IL_0be7: Expected F4, but got I
		//IL_0be2: Expected native int or pointer, but got VT
		//IL_0c43: Expected I, but got Obj
		//IL_0c59: Expected Obj, but got I
		//IL_0954: Expected VT, but got Obj
		//IL_0954: Expected Obj, but got Ref
		//IL_0961: Expected Obj, but got VT
		//IL_0977: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected Obj, but got Unknown
		//IL_0993: Expected Obj, but got F4
		//IL_09a0: Expected F4, but got Obj
		//IL_099b: Expected native int or pointer, but got VT
		//IL_09b5: Expected F4, but got I
		//IL_09b0: Expected native int or pointer, but got VT
		//IL_0a11: Expected I, but got Obj
		//IL_0a27: Expected Obj, but got I
		//IL_04eb: Expected VT, but got Obj
		//IL_04eb: Expected Obj, but got Ref
		//IL_04f8: Expected Obj, but got VT
		//IL_051c: Expected Obj, but got F4
		//IL_0529: Expected F4, but got Obj
		//IL_0524: Expected native int or pointer, but got VT
		//IL_053e: Expected F4, but got I
		//IL_0539: Expected native int or pointer, but got VT
		//IL_0592: Expected I, but got Obj
		//IL_05a8: Expected Obj, but got I
		//IL_02cf: Expected VT, but got Obj
		//IL_02cf: Expected Obj, but got Ref
		//IL_02dc: Expected Obj, but got VT
		//IL_0300: Expected Obj, but got F4
		//IL_030d: Expected F4, but got Obj
		//IL_0308: Expected native int or pointer, but got VT
		//IL_0322: Expected F4, but got I
		//IL_031d: Expected native int or pointer, but got VT
		//IL_0376: Expected I, but got Obj
		//IL_038c: Expected Obj, but got I
		//IL_0c84: Expected I, but got Obj
		//IL_0a52: Expected I, but got Obj
		//IL_1460: Expected Obj, but got Ref
		//IL_05d3: Expected I, but got Obj
		//IL_03b7: Expected I, but got Obj
		//IL_0d71: Expected Ref, but got VT
		//IL_0d80: Expected VT, but got Obj
		//IL_0d80: Expected Obj, but got VT
		//IL_1418: Expected Obj, but got Ref
		//IL_0dcb: Expected I, but got Obj
		//IL_0de1: Expected Obj, but got I
		//IL_06c0: Expected Ref, but got VT
		//IL_06cf: Expected VT, but got Obj
		//IL_06cf: Expected Obj, but got VT
		//IL_064c: Expected Obj, but got I4
		//IL_0717: Expected I, but got Obj
		//IL_072d: Expected Obj, but got I
		//IL_0430: Expected Obj, but got I4
		//IL_068b: Expected Obj, but got I4
		//IL_046f: Expected Obj, but got I4
		//IL_0e66: Expected I, but got Obj
		//IL_0e7c: Expected Obj, but got I
		//IL_13d6: Invalid comparison between F4 and Obj
		//IL_13e4: Invalid comparison between F4 and Obj
		//IL_13f7: Expected Obj, but got I4
		//IL_1409: Expected VT, but got I4
		//IL_07b2: Expected I, but got Obj
		//IL_07c8: Expected Obj, but got I
		//IL_0ea7: Expected I, but got Obj
		//IL_11ff: Invalid comparison between F4 and Obj
		//IL_120d: Invalid comparison between F4 and Obj
		//IL_1220: Expected Obj, but got I4
		//IL_1232: Expected VT, but got I4
		//IL_07f3: Expected I, but got Obj
		object obj = default;
		ref Vector3 reference = ref *(Vector3*)(obj + 120);
		Vector3 vector = (Vector3)(obj + 108);
		Transform transform = (Transform)(obj + 24);
		object obj2 = obj + 12;
		object obj3 = obj + 96;
		obj3 = 0;
		_ = 0;
		object obj4 = obj + 84;
		obj4 = 0;
		_ = 0;
		object obj5 = obj + 72;
		obj5 = 0;
		_ = 0;
		object obj6 = obj + 60;
		obj6 = 0;
		_ = 0;
		object obj7 = obj + 48;
		obj7 = 0;
		_ = 0;
		object obj8 = obj + 36;
		obj8 = 0;
		_ = 0;
		List<Transform> list = mChildren;
		object obj9 = list._size * itemSize;
		float num = (float)obj9 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj10 = default;
		GUILayoutOption gUILayoutOption = default;
		object obj13 = default;
		while ((nint)obj10 <= 3)
		{
			object obj11 = gUILayoutOption + 16;
			object obj12 = obj13 * 12;
			object obj14 = obj11 + obj12;
			((Vector3*)(nint)vector)->x = (float)obj14;
			Vector3 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v313+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			obj4 = vector.x;
			_ = vector.z;
			reference = ref *(Vector3*)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+8]");
			_ = 0;
			transform.Internal_LookAt_Injected(ref *(Vector3*)mTrans, ref reference);
			obj4 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			reference = ref *(Vector3*)transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj15 = gUILayoutOption + 16;
			object obj16 = obj13 * 12;
			object obj17 = obj15 + obj16;
			obj17 = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
			_ = 0;
			obj10 = obj13 + 1;
		}
		object obj18 = gUILayoutOption + 16;
		transform = (Transform)obj18;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v33+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		object obj19 = gUILayoutOption + 40;
		obj2 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v38+8]");
		_ = 0;
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v51 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v301 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		reference = ref *(Vector3*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		Vector3 vector3 = Vector3.LerpUnclamped(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), 0.5f);
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		float num4 = num * 2f;
		object obj21 = gUILayoutOption + 16;
		bool flag5;
		if (~(mHorizontal ? 1u : 0u) == 0)
		{
			object obj22 = obj21 - itemSize;
			object obj23 = gUILayoutOption + 40;
			object obj24 = obj23 + itemSize;
			List<Transform> list2 = mChildren;
			object obj25 = 0f - num;
			int num5 = 0;
			object obj26 = 1;
			while (num5 < list2._size)
			{
				Transform transform3 = mChildren.get_Item(num5);
				((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localPosition = (Vector3)transform3;
				((Vector3*)(nint)vector)->x = (float)obj3;
				Vector3 vector4 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((Vector3*)(nint)vector4)->z = 0f;
				float num6 = (float)reference - vector.x;
				float num8;
				float num11;
				float num13;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25))
				{
					((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localPosition = (Vector3)transform3;
					obj5 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					float num7 = (float)obj5 + num4;
					obj5 = num7;
					((Vector3*)(nint)vector)->x = (float)obj5;
					Vector3 vector5 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23+8]");
					((Vector3*)(nint)vector5)->z = 0f;
					transform = (Transform)obj3;
					Transform transform4 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
					num8 = vector.x - (float)transform;
					obj2 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23+8]");
					_ = 0;
					nint num9 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S2_v96 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj27 = (nint)0 & (nint)0x200;
					if (obj27 != null)
					{
						nint num10 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S2_v100 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float width = (float)obj2 / (float)itemSize;
					GUILayoutOption gUILayoutOption2 = GUILayout.Width(width);
					if (minIndex == maxIndex)
					{
						goto IL_1116;
					}
					if (minIndex > (nint)gUILayoutOption2)
					{
						num11 = num8;
						obj26 = 0;
					}
					else
					{
						if ((nint)gUILayoutOption2 <= maxIndex)
						{
							goto IL_1116;
						}
						num11 = num8;
						obj26 = 0;
					}
				}
				else if (!(num6 > num))
				{
					bool flag = (byte)(~(mFirstTime ? 1u : 0u)) != 0;
					num11 = num6;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
						num11 = num6;
					}
				}
				else
				{
					((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localPosition = (Vector3)transform3;
					obj6 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					float num12 = (float)obj6 - num4;
					obj6 = num12;
					((Vector3*)(nint)vector)->x = (float)obj6;
					Vector3 vector6 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26+8]");
					((Vector3*)(nint)vector6)->z = 0f;
					transform = (Transform)obj3;
					Transform transform5 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
					num13 = vector.x - (float)transform;
					obj2 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26+8]");
					_ = 0;
					nint num14 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ S2_v80 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj28 = (nint)0 & (nint)0x200;
					if (obj28 != null)
					{
						nint num15 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ S2_v84 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float width2 = (float)obj2 / (float)itemSize;
					GUILayoutOption gUILayoutOption3 = GUILayout.Width(width2);
					if (minIndex == maxIndex)
					{
						goto IL_1184;
					}
					if (minIndex > (nint)gUILayoutOption3)
					{
						num11 = num13;
						obj26 = 0;
					}
					else
					{
						if ((nint)gUILayoutOption3 <= maxIndex)
						{
							goto IL_1184;
						}
						num11 = num13;
						obj26 = 0;
					}
				}
				goto IL_0690;
				IL_0690:
				if (~(cullContent ? 1u : 0u) == 0)
				{
					UIPanel uIPanel = mPanel;
					reference = ref *(Vector3*)uIPanel.mClipOffset;
					((Transform)vector).localPosition = (Vector3)mTrans;
					float num16 = (float)reference - vector.x;
					float num17 = num11 + num16;
					string trans = transform3.tag;
					nint num18 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ S1_v221 (Il2CppClass<UICamera>)+BA]");
					object obj29 = (nint)0 & (nint)0x200;
					if (obj29 != null)
					{
						GUILayoutOption typeFromHandle = (GUILayoutOption)(object)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ S1_v239 (UnityEngine.GUILayoutOption)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Rigidbody rigidbody = UICamera.FindRootRigidbody((Transform)(object)trans);
					if ((object)rigidbody == null)
					{
						string cam = transform3.tag;
						nint num19 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ S1_v228 (Il2CppClass<NGUITools>)+BA]");
						object obj30 = (nint)0 & (nint)0x200;
						if (obj30 != null)
						{
							nint num20 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ S1_v235 (Il2CppClass<NGUITools>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num17) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22);
						bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num17) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
						Transform transform6 = (Transform)(flag2 & flag3);
						NGUITools.FitOnScreen((Camera)(object)cam, transform6, (Vector3)0);
					}
				}
				int num21 = num5 + 1;
				num5 = num21;
				continue;
				IL_1184:
				reference = ref *(Vector3*)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26+8]");
				_ = 0;
				num11 = num13;
				goto IL_140f;
				IL_140f:
				vector3 = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).eulerAngles;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
				goto IL_0690;
				IL_1116:
				reference = ref *(Vector3*)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23+8]");
				_ = 0;
				num11 = num8;
				goto IL_140f;
			}
			object obj31 = obj26 & 1;
			bool flag4 = obj31 != null;
			flag5 = flag4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v65+4]");
			object obj32 = -itemSize;
			object obj33 = gUILayoutOption + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v78+4]");
			object obj34 = (nint)0 + (nint)itemSize;
			List<Transform> list3 = mChildren;
			object obj35 = 0f - num;
			int num22 = 0;
			flag5 = true;
			while (num22 < list3._size)
			{
				Transform transform7 = mChildren.get_Item(num22);
				((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localPosition = (Vector3)transform7;
				((Vector3*)(nint)vector)->x = (float)obj3;
				Vector3 vector7 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((Vector3*)(nint)vector7)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+4]");
				float num23 = 0f - vector.y;
				float num26;
				float num29;
				float num32;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35))
				{
					((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localPosition = (Vector3)transform7;
					obj7 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					object obj36 = obj7 + 4;
					float num24 = (float)obj36 + num4;
					obj36 = num24;
					((Vector3*)(nint)vector)->x = (float)obj7;
					Vector3 vector8 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29+8]");
					((Vector3*)(nint)vector8)->z = 0f;
					transform = (Transform)obj3;
					Transform transform8 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
					float num25 = vector.y;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Transform)+4]");
					num26 = num25 - 0f;
					obj2 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29+8]");
					_ = 0;
					nint num27 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S2_v48 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj37 = (nint)0 & (nint)0x200;
					if (obj37 != null)
					{
						nint num28 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S2_v52 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
					float width3 = 0f / (float)itemSize;
					GUILayoutOption gUILayoutOption4 = GUILayout.Width(width3);
					if (minIndex == maxIndex)
					{
						goto IL_12e5;
					}
					if (minIndex > (nint)gUILayoutOption4)
					{
						num29 = num26;
						flag5 = false;
					}
					else
					{
						if ((nint)gUILayoutOption4 <= maxIndex)
						{
							goto IL_12e5;
						}
						num29 = num26;
						flag5 = false;
					}
				}
				else if (!(num23 > num))
				{
					bool flag6 = (byte)(~(mFirstTime ? 1u : 0u)) != 0;
					num29 = num23;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
						num29 = num23;
					}
				}
				else
				{
					((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localPosition = (Vector3)transform7;
					obj8 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					object obj38 = obj8 + 4;
					float num30 = (float)obj38 - num4;
					obj38 = num30;
					((Vector3*)(nint)vector)->x = (float)obj8;
					Vector3 vector9 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v32+8]");
					((Vector3*)(nint)vector9)->z = 0f;
					transform = (Transform)obj3;
					Transform transform9 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
					float num31 = vector.y;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Transform)+4]");
					num32 = num31 - 0f;
					obj2 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v32+8]");
					_ = 0;
					nint num33 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ S2_v32 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj39 = (nint)0 & (nint)0x200;
					if (obj39 != null)
					{
						nint num34 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ S2_v36 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
					float width4 = 0f / (float)itemSize;
					GUILayoutOption gUILayoutOption5 = GUILayout.Width(width4);
					if (minIndex == maxIndex)
					{
						goto IL_135b;
					}
					if (minIndex > (nint)gUILayoutOption5)
					{
						num29 = num32;
						flag5 = false;
					}
					else
					{
						if ((nint)gUILayoutOption5 <= maxIndex)
						{
							goto IL_135b;
						}
						num29 = num32;
						flag5 = false;
					}
				}
				goto IL_0d41;
				IL_0d41:
				if (~(cullContent ? 1u : 0u) == 0)
				{
					UIPanel uIPanel2 = mPanel;
					reference = ref *(Vector3*)uIPanel2.mClipOffset;
					((Transform)vector).localPosition = (Vector3)mTrans;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+4]");
					float num35 = 0f - vector.y;
					float num36 = num29 + num35;
					string trans2 = transform7.tag;
					nint num37 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ S1_v95 (Il2CppClass<UICamera>)+BA]");
					object obj40 = (nint)0 & (nint)0x200;
					if (obj40 != null)
					{
						GUILayoutOption typeFromHandle2 = (GUILayoutOption)(object)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ S1_v113 (UnityEngine.GUILayoutOption)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Rigidbody rigidbody2 = UICamera.FindRootRigidbody((Transform)(object)trans2);
					if ((object)rigidbody2 == null)
					{
						string cam2 = transform7.tag;
						nint num38 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ S1_v102 (Il2CppClass<NGUITools>)+BA]");
						object obj41 = (nint)0 & (nint)0x200;
						if (obj41 != null)
						{
							nint num39 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ S1_v109 (Il2CppClass<NGUITools>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num36) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32);
						bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num36) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34);
						Transform transform10 = (Transform)(flag7 & flag8);
						NGUITools.FitOnScreen((Camera)(object)cam2, transform10, (Vector3)0);
					}
				}
				int num40 = num22 + 1;
				num22 = num40;
				continue;
				IL_135b:
				reference = ref *(Vector3*)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v32+8]");
				_ = 0;
				num29 = num32;
				goto IL_1457;
				IL_1457:
				vector3 = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).eulerAngles;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
				goto IL_0d41;
				IL_12e5:
				reference = ref *(Vector3*)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29+8]");
				_ = 0;
				num29 = num26;
				goto IL_1457;
			}
		}
		UIScrollView uIScrollView = mScroll;
		object obj42 = (flag5 ? 1 : 0) ^ 1;
		bool restrictWithinPanel = (byte)(obj42 & 1) != 0;
		uIScrollView.restrictWithinPanel = restrictWithinPanel;
		UIScrollView uIScrollView2 = mScroll;
		uIScrollView2.mCalculatedBounds = false;
	}

	protected virtual void UpdateItem(Transform item, int index)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)item).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v19 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.SetActiveChildren((GameObject)(object)item, (byte)index != 0);
	}

	public UIWrapContent()
	{
		if (maxIndex < minIndex)
		{
			maxIndex = minIndex;
		}
		if (minIndex > maxIndex)
		{
			maxIndex = minIndex;
		}
	}
}
