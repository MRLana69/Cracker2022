using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

public class UIGrid : UIWidgetContainer
{
	public delegate void OnReposition();

	public enum Arrangement
	{
		Horizontal,
		Vertical,
		CellSnap
	}

	public enum Sorting
	{
		None,
		Alphabetic,
		Horizontal,
		Vertical,
		Custom
	}

	public Arrangement arrangement;

	public Sorting sorting;

	public UIWidget.Pivot pivot;

	public int maxPerLine;

	public float cellWidth;

	public float cellHeight;

	public bool animateSmoothly;

	public bool hideInactive;

	public bool keepWithinPanel;

	public OnReposition onReposition;

	public Comparison<Transform> onCustomSort;

	private bool sorted;

	protected bool mReposition;

	protected UIPanel mPanel;

	protected bool mInitDone;

	public bool repositionNow
	{
		set
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_00e2: Expected Obj, but got I4
			//IL_0054: Expected I, but got Obj
			//IL_00ac: Expected Obj, but got I4
			//IL_00ac: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIGrid)+16]");
			if ((nint)0 == 0)
			{
				return;
			}
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)arrangement).FindKernel(null) != 0)
			{
				((GameObject)arrangement).BroadcastMessage("OnDrop", value, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	public List<Transform> GetChildList()
	{
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I4
		//IL_00c5: Expected I, but got Obj
		//IL_0119: Expected Obj, but got I4
		Collider component = GetComponent<Collider>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			bool isTrigger = component.isTrigger;
			return (List<Transform>)isTrigger;
		}
		Collider2D component2 = GetComponent<Collider2D>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
		{
			bool flag = component2.isActiveAndEnabled;
			return (List<Transform>)flag;
		}
		return null;
	}

	public unsafe Transform GetChild(int index)
	{
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_034a: Expected Obj, but got I4
		//IL_035e: Expected I, but got Obj
		//IL_0374: Expected Obj, but got I
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected VT, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_039d: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00ea: Expected I4, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I
		//IL_0166: Invalid comparison between Obj and F4
		//IL_026d: Expected VT, but got Obj
		//IL_0295: Expected I, but got Obj
		//IL_02ab: Expected Obj, but got I
		//IL_01b1: Expected VT, but got Obj
		//IL_01d4: Expected I, but got Obj
		//IL_01ea: Expected Obj, but got I
		//IL_0455: Expected F4, but got Obj
		//IL_0450: Expected native int or pointer, but got VT
		//IL_0467: Expected F4, but got I
		//IL_0462: Expected native int or pointer, but got VT
		//IL_0491: Expected VT, but got Obj
		//IL_04dd: Expected Obj, but got I4
		//IL_03cb: Expected F4, but got Obj
		//IL_03c6: Expected native int or pointer, but got VT
		//IL_03dd: Expected F4, but got I
		//IL_03d8: Expected native int or pointer, but got VT
		//IL_0407: Expected VT, but got Obj
		//IL_043e: Expected Obj, but got I4
		//IL_02d6: Expected I, but got Obj
		//IL_0215: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v93 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIDraggableCamera uIDraggableCamera = (UIDraggableCamera)(obj2 + 60);
		Vector3 vector = (Vector3)(obj2 + 48);
		Transform transform = (Transform)(obj2 + 24);
		object obj4 = obj2 + 12;
		if (((ComputeShader)(object)onCustomSort).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v89 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)arrangement).FindKernel(null) != 0)
			{
				uIDraggableCamera.Press((byte)(int)this != 0);
				obj = uIDraggableCamera;
				_ = ((UnityEngine.Object)uIDraggableCamera).m_CachedPtr;
				object obj6 = obj * obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
				object obj7 = num5 * 0;
				object obj8 = obj6 + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				object obj9 = num6 * 0;
				object obj10 = obj8 + obj9;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
				{
					if (index != 0)
					{
						transform.position = (Vector3)onCustomSort;
						obj4 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						_ = 0;
						nint num7 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v43 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num8 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v56 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector)->x = (float)transform;
						((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
						uIDraggableCamera = (UIDraggableCamera)obj4;
						UIDraggableCamera uIDraggableCamera2 = uIDraggableCamera;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+8]");
						((UnityEngine.Object)uIDraggableCamera2).m_CachedPtr = (IntPtr)0;
						Quaternion quaternion = Quaternion.FromToRotation(vector, (Vector3)uIDraggableCamera);
						uIDraggableCamera = (UIDraggableCamera)obj2;
						UIDraggableCamera uIDraggableCamera3 = uIDraggableCamera;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((UnityEngine.Object)uIDraggableCamera3).m_CachedPtr = (IntPtr)0;
						Vector3 localPosition = ((Transform)(object)uIDraggableCamera).localPosition;
						return (Transform)1;
					}
					string text = tag;
					transform.position = (Vector3)onCustomSort;
					obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					nint num9 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v50 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num10 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v64 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = (float)transform;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
					uIDraggableCamera = (UIDraggableCamera)obj4;
					UIDraggableCamera uIDraggableCamera4 = uIDraggableCamera;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+8]");
					((UnityEngine.Object)uIDraggableCamera4).m_CachedPtr = (IntPtr)0;
					Quaternion quaternion2 = Quaternion.FromToRotation(vector, (Vector3)uIDraggableCamera);
					uIDraggableCamera = (UIDraggableCamera)obj2;
					UIDraggableCamera uIDraggableCamera5 = uIDraggableCamera;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)uIDraggableCamera5).m_CachedPtr = (IntPtr)0;
					IEnumerator enumerator = ((SpawnPool)(object)text).DoDespawnAfterSeconds((Transform)(object)uIDraggableCamera, 13f);
					_ = 1;
					_ = 1;
					return (Transform)1;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public int GetIndex(Transform trans)
	{
		//IL_0012: Expected I4, but got Obj
		//IL_0012: Expected Obj, but got I4
		//IL_001e: Expected I4, but got Obj
		bool isEnabled = ((UIImageButton)(object)this).isEnabled;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6 (System.Boolean)+C]");
		if (0 > (nint)trans)
		{
			Transform transform = ((List<Transform>)isEnabled).get_Item((int)trans);
			return (int)transform;
		}
		return 0;
	}

	public void AddChild(Transform trans)
	{
		//IL_0033: Expected Obj, but got I4
		if ((object)trans != null)
		{
			mReposition = true;
			tag = (string)1;
		}
	}

	public unsafe void AddChild(Transform trans, bool sort)
	{
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_0362: Expected Obj, but got I4
		//IL_0376: Expected I, but got Obj
		//IL_038c: Expected Obj, but got I
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Ref, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected VT, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0336: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got F4
		//IL_00a1: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I
		//IL_0139: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01c9: Expected VT, but got Obj
		//IL_023c: Expected I, but got Obj
		//IL_0252: Expected Obj, but got I
		//IL_0416: Expected F4, but got Obj
		//IL_0411: Expected native int or pointer, but got VT
		//IL_0428: Expected F4, but got I
		//IL_0423: Expected native int or pointer, but got VT
		//IL_044a: Expected VT, but got Ref
		//IL_046e: Expected Obj, but got F4
		//IL_04a1: Expected Obj, but got F4
		//IL_027d: Expected I, but got Obj
		//IL_04ea: Expected Obj, but got I
		//IL_04fb: Expected VT, but got Obj
		//IL_0526: Expected I, but got Obj
		//IL_053c: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got F4
		//IL_0566: Expected F4, but got Obj
		//IL_0561: Expected native int or pointer, but got VT
		//IL_0578: Expected F4, but got I
		//IL_0573: Expected native int or pointer, but got VT
		//IL_0597: Expected VT, but got Ref
		//IL_05c0: Expected F4, but got I4
		//IL_05c0: Expected VT, but got Ref
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected Obj, but got Unknown
		//IL_05dc: Expected Obj, but got I4
		//IL_02e3: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 60;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v100 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Vector3 reference = ref *(Vector3*)(obj2 + 84);
		Vector3 vector = (Vector3)(obj2 + 72);
		Transform transform = (Transform)(obj2 + 48);
		Transform transform2 = (Transform)(obj2 + 36);
		Transform transform3 = (Transform)(obj2 + 24);
		object obj4 = obj2 + 12;
		if (((ComputeShader)(object)trans).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v103 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)cellWidth).FindKernel(null) != 0)
			{
				float num5 = cellWidth;
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v99 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v46 (System.Single)+68]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					float num8 = cellWidth;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v51 (System.Single)+68]");
					Camera anchorCamera = ((UIRect)0).anchorCamera;
					object obj7 = this + 32;
					string text = trans.tag;
					obj7 = text;
					transform.position = (Vector3)trans;
					reference = ref *(Vector3*)transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					transform2.Internal_LookAt_Injected(ref *(Vector3*)anchorCamera, ref reference);
					reference = ref *(((bool*)(sort ? 1 : 0))->m_value ? ((Vector3*)1) : ((Vector3*)null));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sort @ L2 (System.Boolean)+8]");
					_ = 0;
					transform3.Internal_LookAt_Injected(ref *(Vector3*)anchorCamera, ref reference);
					obj4 = transform3;
					_ = ((UnityEngine.Object)transform3).m_CachedPtr;
					nint num9 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v66 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num10 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v96 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = (float)transform2;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
					reference = ref *(Vector3*)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27+8]");
					_ = 0;
					Quaternion quaternion = Quaternion.FromToRotation(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
					obj = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					if (!((UIScrollView)cellWidth).canMoveVertically)
					{
						obj = 0f;
					}
					if (!((UIScrollView)cellWidth).shouldMoveHorizontally)
					{
						_ = 0f;
					}
					_ = 0f;
					float num11 = cellWidth;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v89 (System.Single)+68]");
					Transform cachedTransform = ((UIRect)0).cachedTransform;
					transform.localPosition = (Vector3)anchorCamera;
					transform2 = (Transform)obj;
					Transform transform4 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
					nint num12 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S1_v76 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num13 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S1_v93 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = (float)transform;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
					reference = ref *(Vector3*)transform2;
					_ = ((UnityEngine.Object)transform2).m_CachedPtr;
					Quaternion quaternion2 = Quaternion.FromToRotation(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
					reference = ref *(Vector3*)transform3;
					_ = ((UnityEngine.Object)transform3).m_CachedPtr;
					SpringPosition springPosition = SpringPosition.Begin((GameObject)(object)cachedTransform, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), (float)arrangement);
					object obj10 = springPosition + 28;
					obj10 = pivot;
					goto IL_05e1;
				}
			}
		}
		object obj11 = this + 32;
		obj11 = 0;
		goto IL_05e1;
		IL_05e1:
		if (maxPerLine != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
	}

	public bool RemoveChild(Transform t)
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		bool isEnabled = ((UIImageButton)(object)this).isEnabled;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S4_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S4_v4+8C]");
		object obj3 = 0;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S5_v4 (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	protected virtual void Init()
	{
		CancelInvoke();
	}

	protected virtual void Start()
	{
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		mInitDone = true;
		string go = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v15 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 52;
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>((GameObject)(object)go);
		obj2 = uIPanel;
	}

	protected virtual void Update()
	{
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		bool flag = animateSmoothly;
		animateSmoothly = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		animateSmoothly = flag;
		tag = null;
	}

	private void OnValidate()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		tag = null;
	}

	public static int SortByName(Transform a, Transform b)
	{
		//IL_0045: Expected Obj, but got I4
		bool isEnabled = ((UIImageButton)(object)a).isEnabled;
		if (((List<Transform>)isEnabled).Remove(b))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			return 1;
		}
		return 0;
	}

	public static int SortHorizontal(Transform a, Transform b)
	{
		UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)a);
		UnityEngine.Object value = UnityEngine.Object.Instantiate((UnityEngine.Object)b);
		return ((string)(object)obj).CompareTo((object)value);
	}

	public static int SortVertical(Transform a, Transform b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0038: Expected VT, but got Obj
		//IL_0057: Expected VT, but got Obj
		Transform transform = default;
		object obj = transform + 24;
		obj = 0;
		_ = 0;
		Transform transform2 = (Transform)(transform + 12);
		transform2.localPosition = (Vector3)a;
		obj = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		transform.localPosition = (Vector3)b;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D9CC");
		int result = default;
		return result;
	}

	protected virtual void Sort(List<Transform> list)
	{
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)list).FindKernel((string)null) != 0)
		{
			GameObject parentInternal = gameObject;
			((Transform)(object)list).parentInternal = (Transform)(object)parentInternal;
			bool isEnabled = ((UIImageButton)(object)this).isEnabled;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	public virtual void Reposition()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			return;
		}
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v10 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v17 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (NGUITools.GetActive((GameObject)(object)this))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public void ConstrainWithinPanel()
	{
		//IL_0213: Expected I, but got Obj
		//IL_0229: Expected Obj, but got I
		//IL_0041: Expected I, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_0123: Expected I, but got Obj
		//IL_0082: Expected I, but got Obj
		if (Application.platform != RuntimePlatform.OSXEditor && ~(mInitDone ? 1u : 0u) != 0)
		{
			string fileName = tag;
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v15 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v21 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			byte[] array = NGUITools.Load(fileName);
			if (array != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
		if (~(sorted ? 1u : 0u) == 0)
		{
			sorted = false;
			if (sorting == Sorting.None)
			{
				sorting = Sorting.Alphabetic;
			}
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v27 (Il2CppClass<NGUITools>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v30 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		bool isEnabled = ((UIImageButton)(object)this).isEnabled;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		if (~(keepWithinPanel ? 1u : 0u) == 0)
		{
			this._002Ector();
		}
		if (onReposition != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	protected virtual void ResetPosition(List<Transform> list)
	{
	}

	public UIGrid()
	{
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0070: Expected I4, but got Obj
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_00d7: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mPanel).FindKernel((string)null) == 0)
		{
			return;
		}
		GameObject gameObject = base.gameObject;
		UIPanel uIPanel = UIPanel.Find((Transform)(object)mPanel, (byte)(int)gameObject != 0, 1);
		UIScrollView component = mPanel.GetComponent<UIScrollView>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}
}
