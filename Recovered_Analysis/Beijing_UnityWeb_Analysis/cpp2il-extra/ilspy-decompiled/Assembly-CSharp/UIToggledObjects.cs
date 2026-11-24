using System;
using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected;
using UnityEngine;

public class UIToggledObjects : MonoBehaviour
{
	public List<GameObject> activate;

	public List<GameObject> deactivate;

	private GameObject target;

	private bool inverse;

	private void Awake()
	{
		CancelInvoke();
	}

	public unsafe void Toggle()
	{
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_0208: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0118: Expected I, but got Obj
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			List<GameObject> list = activate;
			if (list._size == 0)
			{
				List<GameObject> list2 = deactivate;
				if (list2._size == 0)
				{
					if (~(inverse ? 1u : 0u) == 0)
					{
						deactivate.Add(target);
					}
					else
					{
						activate.Add(target);
					}
					goto IL_01b1;
				}
			}
			object obj2 = this + 20;
			obj2 = 0;
		}
		goto IL_01b1;
		IL_01b1:
		UIToggle component = GetComponent<UIToggle>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventDelegate.Callback callback = default;
		((Delegate)callback).method_ptr = method_ptr;
		((Delegate)callback).method = (nint)__ldftn(UIToggledObjects.Toggle);
		object obj3 = callback + 16;
		obj3 = this;
		nint num3 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v14 (Il2CppClass<EventDelegate>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v19 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = EventDelegate.Remove(component.onChange, callback);
	}

	private unsafe void Set(GameObject go, bool state)
	{
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_17c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ce: Expected Obj, but got Unknown
		//IL_17e1: Expected I, but got Obj
		//IL_17f7: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		//IL_0219: Expected I, but got Obj
		//IL_022f: Expected Obj, but got I
		//IL_04be: Expected I, but got Obj
		//IL_1830: Expected I, but got Obj
		//IL_1846: Expected Obj, but got I
		//IL_181d: Expected Obj, but got I4
		//IL_025a: Expected I, but got Obj
		//IL_1916: Expected Obj, but got I
		//IL_06c3: Expected I, but got Obj
		//IL_06d9: Expected Obj, but got I
		//IL_0c53: Expected I, but got Obj
		//IL_0c69: Expected Obj, but got I
		//IL_0ab4: Expected I, but got Obj
		//IL_13a3: Expected I, but got Obj
		//IL_13b9: Expected Obj, but got I
		//IL_053b: Expected I, but got Obj
		//IL_0551: Expected Obj, but got I
		//IL_15b0: Expected Obj, but got I4
		//IL_0704: Expected I, but got Obj
		//IL_02a7: Expected I, but got Obj
		//IL_02bd: Expected Obj, but got I
		//IL_0e19: Expected I, but got Obj
		//IL_0e2f: Expected Obj, but got I
		//IL_0c94: Expected I, but got Obj
		//IL_0751: Expected I, but got Obj
		//IL_057c: Expected I, but got Obj
		//IL_11ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b1: Expected Obj, but got Unknown
		//IL_11e2: Expected I, but got Obj
		//IL_11f8: Expected Obj, but got I
		//IL_1685: Expected Obj, but got I
		//IL_151c: Expected Obj, but got I
		//IL_152e: Expected I, but got Obj
		//IL_1544: Expected Obj, but got I
		//IL_079e: Expected I, but got Obj
		//IL_07b4: Expected Obj, but got I
		//IL_02e8: Expected I, but got Obj
		//IL_0e5a: Expected I, but got Obj
		//IL_156b: Expected Obj, but got I4
		//IL_13e4: Expected I, but got Obj
		//IL_13fa: Expected Obj, but got I
		//IL_140d: Expected I, but got Obj
		//IL_1423: Expected Obj, but got I
		//IL_1223: Expected I, but got Obj
		//IL_1239: Expected Obj, but got I
		//IL_0335: Expected I, but got Obj
		//IL_0ea7: Expected I, but got Obj
		//IL_0ebd: Expected Obj, but got I
		//IL_15eb: Expected Obj, but got I4
		//IL_15fd: Expected I, but got Obj
		//IL_1613: Expected Obj, but got I
		//IL_0b3a: Expected I, but got Obj
		//IL_189c: Expected Obj, but got I
		//IL_07df: Expected I, but got Obj
		//IL_16c0: Expected Obj, but got I
		//IL_0907: Expected I, but got Obj
		//IL_091d: Expected Obj, but got I
		//IL_082c: Expected I, but got Obj
		//IL_0430: Expected I, but got Obj
		//IL_0446: Expected Obj, but got I
		//IL_03c8: Expected I, but got Obj
		//IL_0fd4: Expected Obj, but got I4
		//IL_0ee8: Expected I, but got Obj
		//IL_0d1a: Expected I, but got Obj
		//IL_0c40: Expected Obj, but got I4
		//IL_14b7: Expected Obj, but got I
		//IL_0879: Expected I, but got Obj
		//IL_088f: Expected Obj, but got I
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_0f59: Expected Obj, but got I4
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected Obj, but got Unknown
		//IL_0bb7: Expected I, but got Obj
		//IL_0bcd: Expected Obj, but got I
		//IL_1464: Expected I, but got Obj
		//IL_147a: Expected Obj, but got I
		//IL_1497: Expected I, but got Obj
		//IL_0948: Expected I, but got Obj
		//IL_1451: Expected Obj, but got I
		//IL_0471: Expected I, but got Obj
		//IL_1713: Expected Obj, but got I4
		//IL_18cf: Expected Obj, but got I
		//IL_0997: Expected Obj, but got I
		//IL_08ba: Expected I, but got Obj
		//IL_0d97: Expected I, but got Obj
		//IL_0dad: Expected Obj, but got I
		//IL_0bf8: Expected I, but got Obj
		//IL_0a4b: Expected I, but got Obj
		//IL_0a7b: Expected I, but got Obj
		//IL_1016: Unknown result type (might be due to invalid IL or missing references)
		//IL_101b: Expected Obj, but got Unknown
		//IL_104e: Expected Obj, but got I
		//IL_1705: Expected Obj, but got I
		//IL_0dd8: Expected I, but got Obj
		//IL_0aa1: Expected I, but got Obj
		//IL_1721: Unknown result type (might be due to invalid IL or missing references)
		//IL_1726: Expected Obj, but got Unknown
		//IL_0a08: Expected Obj, but got I4
		//IL_0a38: Expected Obj, but got I
		//IL_0a38: Expected Obj, but got I
		//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b3: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+2C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A076");
			object obj = default;
			if (obj == null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+42]");
		if ((nint)0 == 0)
		{
			object obj2 = go & 1;
			object obj3 = go & 1;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v180 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v187 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)deactivate).FindKernel((string)null) != 0)
			{
				bool flag = (object)target != null;
				float num3 = (((object)go == null) ? 0f : 1f);
				float num4 = (((object)go == null) ? 1f : 0f);
				if (flag)
				{
					float num5 = num4;
				}
				else
				{
					float num5 = num3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+41]");
		bool flag2 = (nint)0 != 0;
		object obj5 = flag2 ^ go;
		if (obj5 == null)
		{
			return;
		}
		bool flag3 = activate != null;
		object obj6 = flag3 & go;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v269 (Il2CppClass<UIToggle>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num7 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v351 (Il2CppClass<UIToggle>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UIToggle> list = UIToggle.list;
			int size = list.size;
			while (true)
			{
				object obj8 = 0;
				while ((nint)obj8 < size)
				{
					nint num8 = (nint)typeof(UIToggle);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S0_v283 (Il2CppClass<UIToggle>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num9 = (nint)typeof(UIToggle);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S0_v345 (Il2CppClass<UIToggle>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					BetterList<UIToggle> list2 = UIToggle.list;
					object obj10 = list2.buffer + 16;
					object obj11 = obj8 << 2;
					object obj12 = obj10 + obj11;
					ComputeShader computeShader = (ComputeShader)obj12;
					nint num10 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v297 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num11 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S0_v341 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)obj12).FindKernel((string)(object)this) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S0_v295 (UnityEngine.ComputeShader)+C]");
						if (0 == (nint)activate)
						{
							((UIToggledObjects)obj12).Set((GameObject)null, true);
						}
					}
					nint num12 = (nint)typeof(UIToggle);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S0_v305 (Il2CppClass<UIToggle>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num13 = (nint)typeof(UIToggle);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S0_v331 (Il2CppClass<UIToggle>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					BetterList<UIToggle> list3 = UIToggle.list;
					if (list3.size == size)
					{
						object obj15 = obj8 + 1;
						obj8 = obj15;
						continue;
					}
					goto IL_0422;
				}
				break;
				IL_0422:
				nint num14 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ S0_v315 (Il2CppClass<UIToggle>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num15 = (nint)typeof(UIToggle);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ S0_v323 (Il2CppClass<UIToggle>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BetterList<UIToggle> list4 = UIToggle.list;
				size = list4.size;
			}
		}
		object obj17 = go & 1;
		nint num16 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v264 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)deactivate).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+25]");
			if ((nint)0 == 0)
			{
				nint num18 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v250 (Il2CppClass<NGUITools>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num19 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S0_v260 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (NGUITools.GetActive((GameObject)(object)this))
				{
					string text = ((Component)(object)deactivate).tag;
					bool flag4 = (object)target != null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+41]");
					bool flag5 = (nint)0 != 0;
					float num20 = ((!flag5) ? 0f : 1f);
					float num21 = ((!flag5) ? 1f : 0f);
					if (flag4)
					{
						float num22 = num21;
					}
					else
					{
						float num22 = num20;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @883B");
					goto IL_133b;
				}
			}
			bool flag6 = (object)target != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+41]");
			bool flag7 = (nint)0 != 0;
			float num23 = ((!flag7) ? 0f : 1f);
			float num24 = ((!flag7) ? 1f : 0f);
			if (flag6)
			{
				float num25 = num24;
			}
			else
			{
				float num25 = num23;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		}
		goto IL_133b;
		IL_133b:
		if (state)
		{
			nint num26 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S0_v164 (Il2CppClass<UIToggle>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num27 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v223 (Il2CppClass<UIToggle>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num28 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S1_v88 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num29 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S1_v132 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UIToggle.current != null)
			{
				nint num30 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ S0_v173 (Il2CppClass<UIToggle>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num31 = (nint)typeof(UIToggle);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S0_v217 (Il2CppClass<UIToggle>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num32 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ S0_v181 (Il2CppClass<UIToggle>)+5C]");
				object obj23 = (nint)0 + (nint)4;
				obj23 = this;
				nint num33 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ S1_v97 (Il2CppClass<EventDelegate>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num34 = (nint)typeof(EventDelegate);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ S1_v128 (Il2CppClass<EventDelegate>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+28]");
				if (Localization.LoadAndSelect((string)0))
				{
					nint num35 = (nint)typeof(EventDelegate);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ S1_v119 (Il2CppClass<EventDelegate>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num36 = (nint)typeof(EventDelegate);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ S1_v124 (Il2CppClass<EventDelegate>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+28]");
					Localization.dictionary = (Dictionary<string, string[]>)0;
				}
				else
				{
					nint num37 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S1_v107 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj26 = (nint)0 & (nint)0x200;
					if (obj26 != null)
					{
						nint num38 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ S1_v114 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+38]");
					if (((ComputeShader)0).FindKernel(null) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+3C]");
						object obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+3C]");
						bool flag8;
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ S0_v206+8]");
							flag8 = (nint)0 == 0;
						}
						else
						{
							flag8 = true;
						}
						if (!flag8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+41]");
							bool flag9 = (nint)0 != 0;
							object obj28 = flag9;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+38]");
							nint num39 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+3C]");
							object parameter = default;
							((GameObject)num39).BroadcastMessage((string)0, parameter, SendMessageOptions.DontRequireReceiver);
						}
					}
				}
				nint num40 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ S0_v189 (Il2CppClass<UIToggle>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				bool flag10 = obj29 == null;
				nint num41 = (nint)typeof(UIToggle);
				if (!flag10)
				{
					nint num42 = (nint)typeof(UIToggle);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ S0_v196 (Il2CppClass<UIToggle>)+74]");
					bool flag11 = (nint)0 == 0;
					bool flag12 = !flag11;
					num41 = (nint)typeof(UIToggle);
					if (!flag12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num41 = (nint)typeof(UIToggle);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ L2_v13 (Il2CppClass<UIToggle>)+5C]");
				object obj30 = (nint)0 + (nint)4;
				obj30 = UIToggle.current;
			}
		}
		nint num43 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num44 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S1_v82 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+1C]");
		if (((ComputeShader)0).FindKernel(null) == 0)
		{
			nint num45 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num46 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ S1_v71 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)inverse).FindKernel(null) == 0)
			{
				nint num47 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num48 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ S1_v60 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+20]");
				if (((ComputeShader)0).FindKernel(null) == 0)
				{
					return;
				}
				nint num49 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ S0_v49 (Il2CppClass<NGUITools>)+BA]");
				object obj34 = (nint)0 & (nint)0x200;
				if (obj34 != null)
				{
					nint num50 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S0_v98 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool active = NGUITools.GetActive((GameObject)(object)this);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+20]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ S0_v58+28]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+25]");
					bool flag13 = (nint)0 != 0;
					object obj36 = (active ? 1 : 0) ^ 1;
					object obj37 = flag13 | obj36;
					if (obj37 != null)
					{
						float pixelSize = (((object)go == null) ? 0f : 1f);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+20]");
						((UIAtlas)0).pixelSize = pixelSize;
					}
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BDA4");
				object obj38 = (active ? 1 : 0) ^ 1;
				float pixelSize2 = (((object)go == null) ? 0f : 1f);
				object obj39 = 0;
				object obj42 = default;
				while (true)
				{
					object obj40 = obj39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ S0_v62+C]");
					if ((nint)obj40 >= 0)
					{
						break;
					}
					object obj41 = obj42 + 16;
					object obj43 = obj39 << 2;
					object obj44 = obj41 + obj43;
					UIAtlas uIAtlas = (UIAtlas)obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+20]");
					object obj45 = 0;
					Dictionary<string, int> mSpriteIndices = uIAtlas.mSpriteIndices;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ S1_v44+28]");
					if (mSpriteIndices == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+25]");
						bool flag14 = (nint)0 != 0;
						object obj46 = flag14 | obj38;
						if (obj46 != null)
						{
							uIAtlas.pixelSize = pixelSize2;
						}
					}
					object obj47 = obj39 + 1;
					obj39 = obj47;
				}
				return;
			}
			Direction playDirection = (((object)go != null) ? Direction.Forward : Direction.Reverse);
			ActiveAnimation activeAnimation = ActiveAnimation.Play((Animator)inverse, null, playDirection, EnableCondition.IgnoreDisabledState, DisableCondition.DoNotDisable);
			nint num51 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ S0_v106 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj48 = (nint)0 & (nint)0x200;
			if (obj48 != null)
			{
				nint num52 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ S0_v128 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)activeAnimation).FindKernel((string)null) == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+25]");
			if ((nint)0 == 0)
			{
				nint num53 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ S0_v119 (Il2CppClass<NGUITools>)+BA]");
				object obj49 = (nint)0 & (nint)0x200;
				if (obj49 != null)
				{
					nint num54 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ S0_v125 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (NGUITools.GetActive((GameObject)(object)this))
				{
					return;
				}
			}
			activeAnimation.Reset();
			return;
		}
		bool keepCharCount = (((object)go != null) ? true : true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+1C]");
		bool flag15 = NGUIText.WrapText((string)0, out *(string*)null, keepCharCount, wrapLineColors: true);
		nint num55 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ S0_v136 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj50 = (nint)0 & (nint)0x200;
		if (obj50 != null)
		{
			nint num56 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ S0_v159 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)flag15).FindKernel(null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIToggledObjects)+25]");
		if ((nint)0 == 0)
		{
			nint num57 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S0_v149 (Il2CppClass<NGUITools>)+BA]");
			object obj51 = (nint)0 & (nint)0x200;
			if (obj51 != null)
			{
				nint num58 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ S0_v155 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUITools.GetActive((GameObject)(object)this))
			{
				return;
			}
		}
		((ActiveAnimation)flag15).Reset();
	}

	public UIToggledObjects()
	{
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIToggle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIToggle>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v44 (Il2CppClass<UIToggle>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIToggle current = UIToggle.current;
		bool flag = ((~(current.mStarted ? 1u : 0u) != 0) ? current.startsActive : current.mIsActive);
		if (!isActiveAndEnabled)
		{
			return;
		}
		int num3 = 0;
		while (true)
		{
			List<GameObject> list = activate;
			if (num3 >= list._size)
			{
				break;
			}
			GameObject item = activate.get_Item(num3);
			((UIWrapContent)null).UpdateItem((Transform)(object)item, flag ? 1 : 0);
			int num4 = num3 + 1;
			num3 = num4;
		}
		int index = (flag ? 1 : 0) ^ 1;
		int num5 = 0;
		while (true)
		{
			List<GameObject> list2 = deactivate;
			if (num5 < list2._size)
			{
				GameObject item2 = deactivate.get_Item(num5);
				((UIWrapContent)null).UpdateItem((Transform)(object)item2, index);
				int num6 = num5 + 1;
				num5 = num6;
				continue;
			}
			break;
		}
	}
}
