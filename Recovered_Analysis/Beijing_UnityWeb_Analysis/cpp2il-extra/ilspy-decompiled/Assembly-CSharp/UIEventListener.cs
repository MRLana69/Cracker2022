using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class UIEventListener : MonoBehaviour
{
	public delegate void VoidDelegate(GameObject go);

	public delegate void BoolDelegate(GameObject go, bool state);

	public delegate void FloatDelegate(GameObject go, float delta);

	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	public delegate void ObjectDelegate(GameObject go, GameObject obj);

	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	public object parameter;

	public VoidDelegate onSubmit;

	public VoidDelegate onClick;

	public VoidDelegate onDoubleClick;

	public BoolDelegate onHover;

	public BoolDelegate onPress;

	public BoolDelegate onSelect;

	public FloatDelegate onScroll;

	public VoidDelegate onDragStart;

	public VectorDelegate onDrag;

	public VoidDelegate onDragOver;

	public VoidDelegate onDragOut;

	public VoidDelegate onDragEnd;

	public ObjectDelegate onDrop;

	public KeyCodeDelegate onKey;

	public BoolDelegate onTooltip;

	public bool needsActiveCollider;

	private bool isColliderEnabled
	{
		get
		{
			//IL_0258: Expected I, but got Obj
			//IL_026e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Expected Obj, but got Unknown
			//IL_01a8: Expected I, but got Obj
			//IL_01be: Expected Obj, but got I
			//IL_022d: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected Obj, but got Unknown
			//IL_00ee: Expected I, but got Obj
			bool flag = false;
			object obj2 = default;
			object obj9 = default;
			while (true)
			{
				nint num = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8 (Il2CppClass<UIDrawCall>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UIDrawCall);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v42 (Il2CppClass<UIDrawCall>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BetterList<UIDrawCall> mActiveList = UIDrawCall.mActiveList;
				if ((nint)obj2 >= mActiveList.size)
				{
					break;
				}
				nint num3 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v16 (Il2CppClass<UIDrawCall>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(UIDrawCall);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v36 (Il2CppClass<UIDrawCall>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BetterList<UIDrawCall> mActiveList2 = UIDrawCall.mActiveList;
				object obj4 = mActiveList2.buffer + 16;
				object obj5 = obj2 << 2;
				object obj6 = obj4 + obj5;
				object obj7 = obj6;
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v28+18]");
				if ((UnityEngine.Object)0 != this)
				{
					bool flag2 = (byte)((flag ? 1u : 0u) + 1u) != 0;
					flag = flag2;
				}
				obj2 = obj9 + 1;
			}
			return flag;
		}
	}

	private void OnSubmit()
	{
		//IL_00f6: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		onSubmit = (VoidDelegate)int.MaxValue;
		onClick = (VoidDelegate)int.MinValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Vector3> list = default;
		list._002Ector();
		object obj = this + 40;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Vector3> list2 = default;
		list2._002Ector();
		object obj2 = this + 44;
		obj2 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Vector4> list3 = default;
		list3._002Ector();
		object obj3 = this + 48;
		obj3 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Vector2> list4 = default;
		list4._002Ector();
		object obj4 = this + 52;
		obj4 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Vector4> list5 = default;
		list5._002Ector();
		object obj5 = this + 56;
		obj5 = list5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Color> list6 = default;
		list6._002Ector();
		object obj6 = this + 60;
		obj6 = list6;
		_ = 1;
		_ = 3000;
		_ = 1;
		CancelInvoke();
	}

	private void OnClick()
	{
		UIEventListener uIEventListener = Get((GameObject)(object)this);
		if ((object)uIEventListener != null && onSubmit != null)
		{
			string result = tag;
			onSubmit.EndInvoke((IAsyncResult)(object)result);
		}
	}

	private void OnDoubleClick()
	{
		UIEventListener uIEventListener = Get((GameObject)(object)this);
		if ((object)uIEventListener != null && onClick != null)
		{
			string result = tag;
			onClick.EndInvoke((IAsyncResult)(object)result);
		}
	}

	private unsafe void OnHover(bool isOver)
	{
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffb: Expected VT, but got Unknown
		//IL_1004: Unknown result type (might be due to invalid IL or missing references)
		//IL_1009: Expected Obj, but got Unknown
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_1017: Expected Obj, but got Unknown
		//IL_1020: Unknown result type (might be due to invalid IL or missing references)
		//IL_1025: Expected Obj, but got Unknown
		//IL_102e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1033: Expected Obj, but got Unknown
		//IL_103c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1041: Expected Obj, but got Unknown
		//IL_104a: Expected Obj, but got I4
		//IL_105a: Expected Obj, but got I4
		//IL_0e55: Expected I, but got Obj
		//IL_0e6b: Expected Obj, but got I
		//IL_1603: Expected Obj, but got I4
		//IL_0f0a: Expected F4, but got I
		//IL_0f05: Expected native int or pointer, but got VT
		//IL_0e96: Expected I, but got Obj
		//IL_0f39: Expected I, but got Obj
		//IL_0f4f: Expected Obj, but got I
		//IL_0ef3: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_0f7a: Expected I, but got Obj
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_1640: Expected I, but got Obj
		//IL_1656: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_014b: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I
		//IL_10cb: Expected I, but got Obj
		//IL_10e1: Expected Obj, but got I
		//IL_01d9: Expected I, but got Obj
		//IL_1685: Expected Obj, but got I
		//IL_018c: Expected I, but got Obj
		//IL_11a3: Expected I, but got Obj
		//IL_11b9: Expected Obj, but got I
		//IL_037f: Expected I, but got Obj
		//IL_16b4: Expected Obj, but got I
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_0400: Expected I, but got Obj
		//IL_03ed: Expected Obj, but got VT
		//IL_0268: Expected I, but got Obj
		//IL_027e: Expected Obj, but got I
		//IL_05f1: Expected Obj, but got I
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected I4, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_1107: Expected F4, but got Obj
		//IL_1113: Expected Obj, but got F4
		//IL_1139: Expected F4, but got I
		//IL_1168: Expected F4, but got I
		//IL_0487: Expected I, but got Obj
		//IL_049d: Expected Obj, but got I
		//IL_0313: Expected F4, but got I
		//IL_0329: Expected F4, but got Obj
		//IL_0324: Expected native int or pointer, but got VT
		//IL_033e: Expected F4, but got I
		//IL_0339: Expected native int or pointer, but got VT
		//IL_02a9: Expected I, but got Obj
		//IL_1252: Expected I, but got Obj
		//IL_1268: Expected Obj, but got I
		//IL_0634: Expected Obj, but got I
		//IL_1215: Expected Obj, but got I
		//IL_16e3: Expected Obj, but got I
		//IL_052f: Expected F4, but got I
		//IL_052a: Expected native int or pointer, but got VT
		//IL_04c8: Expected I, but got Obj
		//IL_066e: Expected I, but got Obj
		//IL_055e: Expected I, but got Obj
		//IL_0574: Expected Obj, but got I
		//IL_0518: Expected Obj, but got I
		//IL_1375: Expected Obj, but got I
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected Obj, but got Unknown
		//IL_06ee: Expected Obj, but got I4
		//IL_06ee: Expected Obj, but got I
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got Unknown
		//IL_0707: Expected I, but got Obj
		//IL_071d: Expected Obj, but got I
		//IL_0be5: Expected I, but got Obj
		//IL_0bfb: Expected Obj, but got I
		//IL_059f: Expected I, but got Obj
		//IL_144e: Expected Obj, but got I
		//IL_146a: Expected Obj, but got I
		//IL_1481: Expected Obj, but got I
		//IL_156b: Expected Obj, but got I
		//IL_0a89: Expected Obj, but got I
		//IL_07b2: Expected I4, but got Obj
		//IL_0748: Expected I, but got Obj
		//IL_1596: Expected I, but got Obj
		//IL_15ac: Expected Obj, but got I
		//IL_0c26: Expected I, but got Obj
		//IL_12c5: Expected Obj, but got I
		//IL_12d3: Expected I, but got Obj
		//IL_12e9: Expected Obj, but got I
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected Obj, but got Unknown
		//IL_0793: Expected I4, but got Obj
		//IL_171a: Expected Obj, but got I
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Expected Obj, but got Unknown
		//IL_14a0: Expected Obj, but got I4
		//IL_14a0: Expected Obj, but got I
		//IL_0adc: Expected I4, but got Obj
		//IL_07a4: Expected I4, but got Obj
		//IL_0ca7: Expected I, but got Obj
		//IL_0809: Expected Obj, but got I
		//IL_07c5: Expected I, but got Obj
		//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf1: Expected Obj, but got Unknown
		//IL_14f0: Expected Obj, but got I
		//IL_1540: Expected Obj, but got I
		//IL_0915: Expected I, but got Obj
		//IL_092b: Expected Obj, but got I
		//IL_0dd8: Expected Obj, but got I
		//IL_0d5b: Expected Obj, but got I
		//IL_0d6d: Expected Obj, but got I
		//IL_0df3: Expected Obj, but got I4
		//IL_0df3: Expected Obj, but got I
		//IL_0dbd: Expected Obj, but got I
		//IL_0bb0: Expected Obj, but got I
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected Obj, but got Unknown
		//IL_0b4b: Expected Obj, but got I4
		//IL_0b68: Expected Obj, but got I
		//IL_13e8: Expected Obj, but got I
		//IL_0956: Expected I, but got Obj
		//IL_0bd2: Expected Obj, but got I
		//IL_0bd2: Expected Obj, but got I
		//IL_09b8: Expected I, but got Obj
		//IL_09ce: Expected Obj, but got I
		//IL_141c: Expected Obj, but got I
		//IL_0a2f: Expected Obj, but got I
		//IL_09f9: Expected I, but got Obj
		object obj = default;
		Color color = (Color)(obj + 96);
		object obj2 = obj - -64;
		object obj3 = obj + 48;
		object obj4 = obj + 32;
		object obj5 = obj + 16;
		object obj6 = obj + 80;
		obj6 = 0;
		_ = 0;
		parameter = isOver;
		FloatDelegate floatDelegate = onScroll;
		bool flag3;
		bool flag7;
		bool flag9;
		if ((nint)((Delegate)floatDelegate).invoke_impl >= 1)
		{
			VoidDelegate voidDelegate = onDragOver;
			if (((Delegate)floatDelegate).invoke_impl == ((Delegate)voidDelegate).invoke_impl)
			{
				object obj7 = (nint)((Delegate)floatDelegate).invoke_impl & 3;
				bool flag = obj7 == null;
				VoidDelegate voidDelegate2 = onDragEnd;
				bool flag2 = ((Delegate)floatDelegate).invoke_impl == ((Delegate)voidDelegate2).invoke_impl;
				object obj8 = flag & flag2;
				if (obj8 != null)
				{
					nint num = (nint)typeof(UIDrawCall);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v70 (Il2CppClass<UIDrawCall>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num2 = (nint)typeof(UIDrawCall);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v364 (Il2CppClass<UIDrawCall>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (UIDrawCall.mColorSpace == ColorSpace.Uninitialized)
					{
						IntPtr intPtr = MaterialPropertyBlock.CreateImpl();
						nint num3 = (nint)typeof(UIDrawCall);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v352 (Il2CppClass<UIDrawCall>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num4 = (nint)typeof(UIDrawCall);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v358 (Il2CppClass<UIDrawCall>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UIDrawCall.mColorSpace = (ColorSpace)(nint)intPtr;
					}
					nint num5 = (nint)typeof(UIDrawCall);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v80 (Il2CppClass<UIDrawCall>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num6 = (nint)typeof(UIDrawCall);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v343 (Il2CppClass<UIDrawCall>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (UIDrawCall.mColorSpace == ColorSpace.Linear)
					{
						int num7 = 0;
						while (num7 < (nint)((Delegate)floatDelegate).invoke_impl)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8875");
							obj6 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
							_ = 0;
							obj3 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
							_ = 0;
							nint num8 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S0_v321 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj12 = (nint)0 & (nint)0x200;
							if (obj12 != null)
							{
								nint num9 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v339 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float num10 = Mathf.Sign((float)obj3);
							obj6 = num10;
							obj4 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
							float num11 = Mathf.Sign(0f);
							obj5 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
							float num12 = Mathf.Sign(0f);
							obj = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
							float num13 = Mathf.Sign(0f);
							((Color*)(nint)color)->r = (float)obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
							((Color*)(nint)color)->b = 0f;
							((List<Color>)(object)onDragEnd).set_Item(num7, color);
							int num14 = num7 + 1;
							num7 = num14;
						}
					}
					nint num15 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num16 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S1_v253 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+58]");
					if ((UnityEngine.Object)0 != null)
					{
						object obj14 = this + 88;
						string text = tag;
						_0021_00210 componentInChildren = (_0021_00210)((GameObject)(object)text).GetComponentInChildren<T>();
						obj14 = componentInChildren;
					}
					nint num17 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num18 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S1_v245 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+58]");
					if ((UnityEngine.Object)0 != null)
					{
						object obj16 = this + 88;
						string text2 = tag;
						MeshFilter meshFilter = ((GameObject)(object)text2).AddComponent<MeshFilter>();
						obj16 = meshFilter;
					}
					if ((nint)((Delegate)floatDelegate).invoke_impl > 64999)
					{
						_ = 0;
						nint num19 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S1_v217 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj17 = (nint)0 & (nint)0x200;
						if (obj17 != null)
						{
							nint num20 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ S1_v237 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
						if (((ComputeShader)0).FindKernel(null) != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
							((Mesh)0).RecalculateBounds();
						}
						((Color*)(nint)color)->r = (nint)((Delegate)floatDelegate).invoke_impl;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						string text3 = default;
						string exception = "Too many vertices on one panel: " + text3;
						nint num21 = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ S1_v227 (Il2CppClass<UnityEngine.Debug>)+BA]");
						object obj18 = (nint)0 & (nint)0x200;
						if (obj18 != null)
						{
							nint num22 = (nint)typeof(Debug);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S1_v232 (Il2CppClass<UnityEngine.Debug>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Debug.LogException((Exception)(object)exception);
						goto IL_0bd7;
					}
					object obj19 = (nint)((Delegate)floatDelegate).invoke_impl >> 1;
					flag3 = (byte)(obj19 * 3) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+64]");
					bool flag4;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+64]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v288+C]");
						flag4 = (nint)0 != (flag3 ? 1 : 0);
					}
					else
					{
						flag4 = true;
					}
					nint num23 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ S0_v158 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num24 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ S0_v282 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
					bool flag5 = (UnityEngine.Object)0 != null;
					bool flag6 = !flag5;
					flag7 = flag4;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Mesh mesh = default;
						Mesh.Internal_Create(mesh);
						object obj22 = this + 84;
						obj22 = mesh;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
						UnityEngine.Object.CheckNullArgument((object)0, (string)52);
						object obj23 = this - -64;
						nint num25 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ S2_v79 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj24 = (nint)0 & (nint)0x200;
						if (obj24 != null)
						{
							nint num26 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S2_v89 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool allowDestroyingAssets;
						if (((ComputeShader)obj23).FindKernel((string)null) != 0)
						{
							object original = this - -64;
							UnityEngine.Object obj25 = UnityEngine.Object.Instantiate((UnityEngine.Object)original);
							string text4 = string.ConcatArray((string[])(object)"[NGUI] ", (int)obj25);
							allowDestroyingAssets = (byte)(int)text4 != 0;
						}
						else
						{
							allowDestroyingAssets = (byte)(int)"[NGUI] Mesh" != 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
						UnityEngine.Object.DestroyImmediate((UnityEngine.Object)0, allowDestroyingAssets);
						nint num27 = (nint)typeof(UIDrawCall);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ S0_v266 (Il2CppClass<UIDrawCall>)+BA]");
						object obj26 = (nint)0 & (nint)0x200;
						if (obj26 != null)
						{
							nint num28 = (nint)typeof(UIDrawCall);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ S0_v277 (Il2CppClass<UIDrawCall>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (UIDrawCall.dx9BugWorkaround != 0)
						{
							flag7 = true;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
							((Texture)0)._002Ector();
							flag7 = true;
						}
					}
					VoidDelegate voidDelegate3 = onDragOver;
					if (((Delegate)voidDelegate3).invoke_impl == ((Delegate)floatDelegate).invoke_impl)
					{
						VoidDelegate voidDelegate4 = onDragEnd;
						bool flag8 = ((Delegate)voidDelegate4).invoke_impl != ((Delegate)floatDelegate).invoke_impl;
						flag9 = true;
						if (!flag8)
						{
							VoidDelegate voidDelegate5 = onDragOut;
							bool flag10 = ((Delegate)voidDelegate5).invoke_impl != ((Delegate)floatDelegate).invoke_impl;
							flag9 = true;
							if (!flag10)
							{
								VoidDelegate voidDelegate6 = onDragStart;
								bool flag11 = ((Delegate)voidDelegate6).invoke_impl != ((Delegate)floatDelegate).invoke_impl;
								flag9 = true;
								if (!flag11)
								{
									VectorDelegate vectorDelegate = onDrag;
									bool flag12 = ((Delegate)vectorDelegate).invoke_impl != ((Delegate)floatDelegate).invoke_impl;
									flag9 = true;
									if (!flag12)
									{
										nint num29 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ S0_v225 (Il2CppClass<UnityEngine.Object>)+BA]");
										object obj27 = (nint)0 & (nint)0x200;
										if (obj27 != null)
										{
											nint num30 = (nint)typeof(UnityEngine.Object);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ S0_v253 (Il2CppClass<UnityEngine.Object>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										if (((ComputeShader)(object)onHover).FindKernel((string)null) != 0)
										{
											BoolDelegate boolDelegate = onHover;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ S0_v238 (UIEventListener+BoolDelegate)+64]");
											if ((nint)0 != 0)
											{
												nint num31 = (nint)typeof(UnityEngine.Object);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ S0_v244 (Il2CppClass<UnityEngine.Object>)+BA]");
												object obj28 = (nint)0 & (nint)0x200;
												if (obj28 != null)
												{
													nint num32 = (nint)typeof(UnityEngine.Object);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S0_v250 (Il2CppClass<UnityEngine.Object>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
												bool flag13 = (UnityEngine.Object)0 == null;
												flag9 = true;
												if (flag13)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
													int subMeshCount = ((Mesh)0).subMeshCount;
													FloatDelegate floatDelegate2 = onScroll;
													bool flag14 = (IntPtr)subMeshCount != ((Delegate)floatDelegate2).invoke_impl;
													flag9 = true;
													if (!flag14)
													{
														goto IL_13d5;
													}
												}
												goto IL_135f;
											}
										}
										goto IL_13d5;
									}
								}
							}
						}
					}
					else
					{
						flag9 = true;
					}
					goto IL_135f;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+58]");
		bool flag15 = GraphicsFormatUtility.IsSRGBFormat(GraphicsFormat.None);
		nint num33 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num34 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v50 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)flag15).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+58]");
			bool flag16 = GraphicsFormatUtility.IsSRGBFormat(GraphicsFormat.None);
			((Mesh)flag16).RecalculateBounds();
		}
		((Color*)(nint)color)->r = (nint)((Delegate)floatDelegate).invoke_impl;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text5 = default;
		string exception2 = "UIWidgets must fill the buffer with 4 vertices per quad. Found " + text5;
		nint num35 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S1_v39 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num36 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v44 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception2);
		goto IL_0fb9;
		IL_135f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
		int subMeshCount2 = ((Mesh)0).subMeshCount;
		if ((IntPtr)subMeshCount2 != ((Delegate)floatDelegate).invoke_impl)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
			((Mesh)0).RecalculateBounds();
			flag7 = true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
		((Mesh)0).SetNormals((List<Vector3>)(object)onScroll);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
		((Mesh)0).SetUVs(0, (List<Vector4>)(object)onDragOver);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
		((Mesh)0).SetColors((List<Color32>)(object)onDragEnd);
		VoidDelegate voidDelegate7 = onDragOut;
		int submesh = ((((Delegate)voidDelegate7).invoke_impl == ((Delegate)floatDelegate).invoke_impl) ? ((int)onDragOut) : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
		((Mesh)0).SetTriangles((int[])1, submesh);
		VoidDelegate voidDelegate8 = onDragStart;
		List<Vector4> tangents = (List<Vector4>)(object)((((Delegate)voidDelegate8).invoke_impl != ((Delegate)floatDelegate).invoke_impl) ? null : onDragStart);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
		((Mesh)0).SetTangents(tangents);
		VectorDelegate vectorDelegate2 = onDrag;
		List<Color> colors = (List<Color>)(object)((((Delegate)vectorDelegate2).invoke_impl != ((Delegate)floatDelegate).invoke_impl) ? null : onDrag);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
		((Mesh)0).SetColors(colors);
		if (flag7)
		{
			object obj31 = this + 100;
			bool flag17 = ((UIWidget)null).UpdateVisibility((byte)(nint)((Delegate)floatDelegate).invoke_impl != 0, flag3);
			obj31 = flag17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
			nint num37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+64]");
			((Texture)num37).width = 0;
		}
		if (flag9 || onSelect == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
			((Mesh)0).MarkDynamic();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+58]");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+54]");
		((SkinnedMeshRenderer)num38).sharedMesh = (Mesh)0;
		goto IL_0bd7;
		IL_13d5:
		object obj32 = (nint)((Delegate)floatDelegate).invoke_impl << 1;
		FloatDelegate floatDelegate3 = onScroll;
		flag9 = (nint)obj32 < (nint)((Delegate)floatDelegate3).invoke_impl;
		goto IL_135f;
		IL_0fb9:
		throw new IndexOutOfRangeException();
		IL_0bd7:
		nint num39 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S1_v83 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num40 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ S1_v111 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+5C]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj34 = this + 92;
			string text6 = tag;
			MeshRenderer component = ((GameObject)(object)text6).GetComponent<MeshRenderer>();
			obj34 = component;
		}
		nint num41 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ S0_v107 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num42 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ S0_v143 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+5C]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj36 = this + 92;
			string text7 = tag;
			MeshRenderer meshRenderer = ((GameObject)(object)text7).AddComponent<MeshRenderer>();
			obj36 = meshRenderer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+68]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+5C]");
				((Renderer)0).receiveShadows = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+5C]");
				((Renderer)0).sortingLayerName = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+68]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+5C]");
					((Renderer)0).receiveShadows = false;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+5C]");
					((Renderer)0).receiveShadows = true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+5C]");
				((Renderer)0).sortingLayerName = (string)1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+7A]");
		if ((nint)0 != 0)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+80]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
			}
		}
		((UIDrawCall)this).OnWillRenderObject();
		goto IL_0fb9;
	}

	private void OnPress(bool isPressed)
	{
		UIEventListener uIEventListener = Get((GameObject)(object)this);
		if ((object)uIEventListener != null && onHover != null)
		{
			string text = tag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	private void OnSelect(bool selected)
	{
		UIEventListener uIEventListener = Get((GameObject)(object)this);
		if ((object)uIEventListener != null && onPress != null)
		{
			string text = tag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	private void OnScroll(float delta)
	{
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0109: Invalid comparison between I and F4
		//IL_00b3: Expected Obj, but got I4
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3;
		if (delta < 0f)
		{
			num3 = 0f;
		}
		else
		{
			num3 = ((!(delta > 1f)) ? delta : 1f);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIEventListener)+128]");
		if (0f != num3)
		{
			onDragStart = (VoidDelegate)1;
		}
	}

	private void OnDragStart()
	{
		UIEventListener uIEventListener = Get((GameObject)(object)this);
		if ((object)uIEventListener != null && onDoubleClick != null)
		{
			string result = tag;
			onDoubleClick.EndInvoke((IAsyncResult)(object)result);
		}
	}

	private void OnDrag(Vector2 delta)
	{
		UIEventListener uIEventListener = Get((GameObject)(object)this);
		if ((object)uIEventListener != null && onSelect != null)
		{
			string text = tag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	private void OnDragOver()
	{
		if (onDragStart != null)
		{
			string result = tag;
			onDragStart.EndInvoke((IAsyncResult)(object)result);
		}
	}

	private void OnDragOut()
	{
		UIEventListener uIEventListener = Get((GameObject)(object)this);
		if ((object)uIEventListener != null && onDragOver != null)
		{
			string result = tag;
			onDragOver.EndInvoke((IAsyncResult)(object)result);
		}
	}

	private void OnDragEnd()
	{
		UIEventListener uIEventListener = Get((GameObject)(object)this);
		if ((object)uIEventListener != null && onDragOut != null)
		{
			string result = tag;
			onDragOut.EndInvoke((IAsyncResult)(object)result);
		}
	}

	private void OnDrop(GameObject go)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		if (onDrag != null)
		{
			string text = tag;
			obj2 = go;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A09E");
		}
	}

	private void OnKey(KeyCode key)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		UIEventListener uIEventListener = Get((GameObject)(object)this);
		if ((object)uIEventListener != null)
		{
			object obj = this - -64;
			if (obj != null)
			{
				object obj2 = this - -64;
				string text = tag;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
		}
	}

	private void OnTooltip(bool show)
	{
		UIEventListener uIEventListener = Get((GameObject)(object)this);
		if ((object)uIEventListener != null && onKey != null)
		{
			string text = tag;
			onKey._002Ector(text, (IntPtr)(show ? 1 : 0));
		}
	}

	public void Clear()
	{
		if (onDragEnd != null)
		{
			string result = tag;
			onDragEnd.EndInvoke((IAsyncResult)(object)result);
		}
	}

	public static UIEventListener Get(GameObject go)
	{
		//IL_0182: Expected Obj, but got I4
		//IL_0020: Expected I, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_00d5: Expected I, but got Obj
		//IL_00eb: Expected Obj, but got I
		//IL_0061: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I4
		//IL_0116: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+4C]");
		if ((nint)0 != 0)
		{
			Collider component = ((Component)(object)go).GetComponent<Collider>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				bool isTrigger = component.isTrigger;
				return (UIEventListener)isTrigger;
			}
			Collider2D component2 = ((Component)(object)go).GetComponent<Collider2D>();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
			{
				bool flag = component2.isActiveAndEnabled;
				return (UIEventListener)flag;
			}
			return null;
		}
		return (UIEventListener)1;
	}

	public UIEventListener()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0118: Expected Obj, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_012c: Expected Obj, but got I4
		object obj = this + 16;
		obj = 0;
		object obj2 = this + 20;
		obj2 = 0;
		object obj3 = this + 24;
		obj3 = 0;
		object obj4 = this + 28;
		obj4 = 0;
		object obj5 = this + 32;
		obj5 = 0;
		object obj6 = this + 36;
		obj6 = 0;
		object obj7 = this + 40;
		obj7 = 0;
		object obj8 = this + 44;
		obj8 = 0;
		object obj9 = this + 48;
		obj9 = 0;
		object obj10 = this + 52;
		obj10 = 0;
		object obj11 = this + 56;
		obj11 = 0;
		object obj12 = this + 60;
		obj12 = 0;
		object obj13 = this - -64;
		obj13 = 0;
		object obj14 = this + 68;
		obj14 = 0;
		object obj15 = this + 72;
		obj15 = 0;
	}
}
