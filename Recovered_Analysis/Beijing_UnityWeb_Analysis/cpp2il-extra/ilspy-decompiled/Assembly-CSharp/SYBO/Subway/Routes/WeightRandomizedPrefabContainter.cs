using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;

namespace SYBO.Subway.Routes;

[Serializable]
public class WeightRandomizedPrefabContainter<TWeighted, T> : IEnumerable<TWeighted>, IEnumerable where TWeighted : WeightedPrefab<T> where T : Component
{
	private sealed class _003CPrefabIterator_003Ed__15 : IEnumerator<TWeighted>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private TWeighted _003C_003E2__current;

		public WeightRandomizedPrefabContainter<TWeighted, T> _003C_003E4__this;

		private int _003Ci_003E5__2;

		TWeighted IEnumerator<TWeighted>.Current
		{
			get
			{
				//IL_0013: Expected Obj, but got I
				//IL_002b: Expected Obj, but got I
				//IL_003b: Expected Obj, but got I
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Expected Obj, but got Unknown
				//IL_0052: Unknown result type (might be due to invalid IL or missing references)
				//IL_0057: Expected Obj, but got Unknown
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Expected Obj, but got Unknown
				//IL_0099: Expected Obj, but got I
				//IL_00a9: Expected Obj, but got I
				//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Expected Obj, but got Unknown
				//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c5: Expected Obj, but got Unknown
				nint num = default;
				object obj = num + 12;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v3+60]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v4+64]");
				object obj4 = 0;
				object obj5 = obj4 & 0x3FFF;
				object obj6 = obj5 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S3_v5 (should have been resolved before IL gen)");
				object obj8 = default;
				object obj7 = obj8 & 1;
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v8+60]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v9+8C]");
				object obj12 = 0;
				object obj13 = obj12 & 0x3FFF;
				object obj14 = obj13 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54 @ S2_v10 (should have been resolved before IL gen)");
				string format = default;
				object arg = default;
				return (TWeighted)(object)string.Format((IFormatProvider)(object)"[WeightRandomizedPrefabs: Name={1}, Empty={0}]", format, arg);
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CPrefabIterator_003Ed__15(int _003C_003E1__state)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0316: Expected Obj, but got I
			//IL_032e: Expected Obj, but got I
			//IL_033e: Expected Obj, but got I
			//IL_0347: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Expected Obj, but got Unknown
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Expected Obj, but got Unknown
			//IL_0372: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Expected Obj, but got Unknown
			//IL_0380: Unknown result type (might be due to invalid IL or missing references)
			//IL_0385: Expected Obj, but got Unknown
			//IL_03b1: Expected Obj, but got I4
			//IL_006a: Expected Obj, but got I
			//IL_0091: Expected Obj, but got I4
			//IL_0435: Expected Obj, but got I
			//IL_0445: Expected Obj, but got I
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Expected Obj, but got Unknown
			//IL_045c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0461: Expected Obj, but got Unknown
			//IL_0250: Expected Obj, but got I
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Expected Obj, but got Unknown
			//IL_00a4: Expected I, but got Obj
			//IL_00ba: Expected Obj, but got I
			//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c1: Expected Obj, but got Unknown
			//IL_00e5: Expected I, but got Obj
			//IL_015a: Expected Obj, but got I
			//IL_016a: Expected Obj, but got I
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [45B055]");
			bool flag = (nint)0 == 0;
			bool flag2 = !flag;
			obj2 = obj;
			_ = -1;
			nint num = default;
			object obj3 = num + 12;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v8+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v9+50]");
			object obj6 = 0;
			object obj7 = obj6 & 0x3FFF;
			object obj8 = obj7 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S2_v5 (should have been resolved before IL gen)");
			object obj9 = default;
			object obj15 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj9 == null)
				{
					break;
				}
				object obj10 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v65+60]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj12 = 0;
				while (true)
				{
					object obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v75+C]");
					if ((nint)obj13 >= 0)
					{
						break;
					}
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v86 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num3 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v107 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj15 != null)
					{
						object obj16 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v99+60]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v100+58]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						object obj19 = obj12 + 1;
						obj12 = obj19;
						continue;
					}
					break;
				}
			}
			object obj20 = obj2 + 4;
			object obj21 = obj20 + 1;
			obj20 = obj21;
			object obj22 = obj21 << 2;
			object obj23 = obj2 + obj22;
			obj23 = 104;
			object obj24 = default;
			if (obj24 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj25 = (nint)0 << 2;
				object obj26 = obj2 + obj25;
				if ((nint)obj26 == 104)
				{
					object obj27 = obj2 + 4;
					if ((nint)obj27 > -1)
					{
						object obj28 = obj27 + -1;
						obj27 = obj28;
					}
					goto IL_041d;
				}
			}
			object obj29 = default;
			if (obj29 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_041d;
			IL_041d:
			object obj30 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S2_v14+60]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S2_v15+5C]");
			object obj32 = 0;
			object obj33 = obj32 & 0x3FFF;
			object obj34 = obj33 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v258 @ S3_v9 (should have been resolved before IL gen)");
		}

		void IDisposable.Dispose()
		{
			//IL_000e: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			//IL_0057: Expected Obj, but got I
			//IL_0067: Expected Obj, but got I
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected Obj, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected Obj, but got Unknown
			//IL_00b8: Expected Obj, but got I
			//IL_00e9: Expected Obj, but got I
			//IL_00f9: Expected Obj, but got I
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected Obj, but got Unknown
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected Obj, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected Obj, but got Unknown
			//IL_014a: Expected Obj, but got I
			//IL_017b: Expected Obj, but got I
			//IL_018b: Expected Obj, but got I
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected Obj, but got Unknown
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected Obj, but got Unknown
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Expected Obj, but got Unknown
			//IL_01dc: Expected Obj, but got I
			//IL_01fc: Expected Obj, but got I
			//IL_0427: Expected Obj, but got I
			//IL_0441: Expected Obj, but got I
			//IL_0473: Expected Obj, but got I
			//IL_0487: Unknown result type (might be due to invalid IL or missing references)
			//IL_048c: Expected Obj, but got Unknown
			//IL_0231: Expected Obj, but got I
			//IL_02b4: Expected Obj, but got I
			//IL_02d4: Expected Obj, but got I
			//IL_04ad: Expected Obj, but got I
			//IL_04c7: Expected Obj, but got I
			//IL_04df: Expected Obj, but got I
			//IL_0283: Expected Obj, but got I
			//IL_038c: Expected Obj, but got I
			//IL_039c: Expected Obj, but got I
			//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03aa: Expected Obj, but got Unknown
			//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b8: Expected Obj, but got Unknown
			//IL_03da: Expected Obj, but got I
			//IL_03fa: Expected Obj, but got I
			//IL_0309: Expected Obj, but got I
			//IL_035b: Expected Obj, but got I
			nint num = default;
			object obj = num + 12;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S1_v3+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v4+94]");
			object obj6 = 0;
			object obj7 = obj6 & 0x3FFF;
			object obj8 = obj7 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v21 @ S2_v4 (should have been resolved before IL gen)");
			object obj9 = this + 8;
			object obj10 = default;
			obj9 = obj10;
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v11+60]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9+60]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v10+9C]");
			object obj15 = 0;
			object obj16 = obj15 & 0x3FFF;
			object obj17 = obj16 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S2_v8 (should have been resolved before IL gen)");
			object obj18 = this + 12;
			object obj19 = default;
			obj18 = obj19;
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v19+60]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v15+60]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v16+A4]");
			object obj24 = 0;
			object obj25 = obj24 & 0x3FFF;
			object obj26 = obj25 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v68 @ S2_v12 (should have been resolved before IL gen)");
			object obj27 = this + 16;
			object obj28 = default;
			obj27 = obj28;
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v27+60]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v30+BA]");
			object obj31 = (nint)0 & (nint)0x200;
			if (obj31 != null)
			{
				object obj32 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v91+60]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v94+74]");
				if ((nint)0 == 0)
				{
					object obj34 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v98+60]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj36 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v35+60]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v38+5C]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v39+4]");
			bool flag = (nint)0 == 0;
			bool flag2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v39+4]");
			object obj39 = 0;
			if (!flag2)
			{
				object obj40 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v46+60]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v49+BA]");
				object obj42 = (nint)0 & (nint)0x200;
				if (obj42 != null)
				{
					object obj43 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v79+60]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v82+74]");
					if ((nint)0 == 0)
					{
						object obj45 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v86+60]");
						object obj46 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj47 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v54+60]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v57+5C]");
				object obj49 = 0;
				object obj50 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v61+60]");
				object obj51 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj52 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v67+60]");
				object obj53 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v68+B4]");
				object obj54 = 0;
				object obj55 = obj54 & 0x1FFF;
				object obj56 = obj55 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v117 @ S4_v5 (should have been resolved before IL gen)");
				object obj57 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v72+60]");
				object obj58 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v75+5C]");
				object obj59 = (nint)0 + (nint)4;
				object obj60 = default;
				obj59 = obj60;
				obj39 = obj60;
			}
			object obj61 = this + 20;
			obj61 = obj39;
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private List<TWeighted> _weightedPrefabs;

	private WeightRandomizedContainer<T> _weightedRandomizedPrefabs;

	private SemiRandomlyOrderedList<T> _randomlyOrderedPrefabs;

	private Func<T, bool> _pickEvaluator;

	private string Name__BackingField;

	public unsafe bool IsEmpty
	{
		get
		{
			//IL_0245: Expected Obj, but got I
			//IL_025b: Expected I, but got Obj
			//IL_0271: Expected Obj, but got I
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected I, but got Unknown
			//IL_02b1: Expected I, but got Obj
			//IL_0088: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0307: Expected Obj, but got I
			//IL_0363: Expected I, but got Obj
			//IL_0379: Expected Obj, but got I
			//IL_041b: Expected Obj, but got I4
			//IL_0130: Expected Obj, but got I
			//IL_01e9: Expected I, but got Obj
			//IL_03b8: Expected Obj, but got I
			//IL_03da: Expected Obj, but got I
			//IL_03f2: Expected Obj, but got I4
			//IL_01c6: Expected Obj, but got I
			//IL_01ce: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			nint num = default;
			object obj = num + 24;
			object obj2 = obj;
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v8 (Il2CppClass<System.Type>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v42 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = obj2;
			nint num4 = (nint)(obj4 + 4);
			((IntPtr*)num4)->m_value = (void*)(nint)obj4;
			Type type = Type.internal_from_handle((IntPtr)num4);
			object obj5 = default;
			if (obj5 == type)
			{
				return true;
			}
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v16+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v72+74]");
				if ((nint)0 == 0)
				{
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v23+5C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v24+4]");
			bool flag = (nint)0 == 0;
			bool flag2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v24+4]");
			RouteType routeType = RouteType.None;
			if (!flag2)
			{
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v34+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					object obj14 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v62+74]");
					if ((nint)0 == 0)
					{
						object obj15 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v41+5C]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v34+8]");
				object obj19 = 0;
				RouteType routeType2 = default;
				object obj20 = routeType2 + 16;
				obj20 = obj17;
				object obj21 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v56+5C]");
				object obj22 = (nint)0 + (nint)4;
				obj22 = routeType2;
				routeType = routeType2;
			}
			bool flag3 = ((RouteManager)this).CanCreateRoute(routeType);
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)((ComputeShader)flag3).FindKernel(null) != 0;
		}
	}

	public string Name
	{
		get
		{
			//IL_000e: Expected Obj, but got I
			//IL_0017: Expected Obj, but got I4
			//IL_00c1: Expected Obj, but got I
			//IL_00d1: Expected Obj, but got I
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected Obj, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected Obj, but got Unknown
			//IL_0111: Expected Obj, but got I4
			//IL_0034: Expected Obj, but got I
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected Obj, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected Obj, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected Obj, but got Unknown
			nint num = default;
			object obj = num + 12;
			object obj2 = 0;
			object obj8 = default;
			string result;
			object obj14 = default;
			while (true)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S3_v3+60]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S3_v4+8]");
				object obj5 = 0;
				object obj6 = obj5 & 0x3FFF;
				object obj7 = obj6 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S4_v5 (should have been resolved before IL gen)");
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
				result = (string)1;
				if (flag)
				{
					break;
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S2_v7+60]");
				object obj10 = 0;
				object obj11 = obj10;
				object obj12 = obj11 & 0x1FFF;
				object obj13 = obj12 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v18 @ S3_v10 (should have been resolved before IL gen)");
				if (obj14 != null)
				{
					result = null;
					break;
				}
				object obj15 = obj2 + 1;
				obj2 = obj15;
			}
			return result;
		}
		set
		{
			//IL_000e: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			//IL_0057: Expected Obj, but got I
			//IL_0067: Expected Obj, but got I
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected Obj, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected Obj, but got Unknown
			nint num = default;
			object obj = num + 12;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S2_v2+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S2_v3+4]");
			object obj6 = 0;
			object obj7 = obj6 & 0x3FFF;
			object obj8 = obj7 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v23 @ S3_v4 (should have been resolved before IL gen)");
			object obj9 = this + 8;
			object obj10 = default;
			obj9 = obj10;
		}
	}

	public int Count
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)Name__BackingField;
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public unsafe TWeighted get_Item(int index)
	{
		//IL_006c: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected I, but got Unknown
		//IL_00e8: Expected I, but got Obj
		//IL_0108: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4+60]");
		object obj2 = 0;
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v8 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v18 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5+C]");
		object obj4 = 0;
		nint num3 = (nint)(obj4 + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)obj4;
		Type type = Type.internal_from_handle((IntPtr)num3);
		object obj5 = default;
		bool flag = obj5 == type;
		return (TWeighted)flag;
	}

	public void set_Item(int index, TWeighted value)
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		_weightedRandomizedPrefabs = (WeightRandomizedContainer<T>)1;
		object obj = this + 8;
		UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)index);
		obj = obj2;
		object obj3 = this + 16;
		obj3 = index;
		_weightedRandomizedPrefabs = (WeightRandomizedContainer<T>)(object)value;
	}

	public int GetTotalWeight()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S1_v3+8]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v14 @ S2_v4 (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public IEnumerator<TWeighted> GetEnumerator()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0017: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = 0;
		object obj8 = default;
		IEnumerator<TWeighted> result = default;
		IEnumerator<TWeighted> enumerator = default;
		while (true)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v3+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v4+8]");
			object obj5 = 0;
			object obj6 = obj5 & 0x3FFF;
			object obj7 = obj6 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S3_v5 (should have been resolved before IL gen)");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
			{
				break;
			}
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S2_v7+60]");
			object obj10 = 0;
			object obj11 = obj10;
			object obj12 = obj11 & 0x1FFF;
			object obj13 = obj12 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v15 @ S3_v9 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v11+C]");
			result = (IEnumerator<TWeighted>)(0 + enumerator);
			object obj14 = obj2 + 1;
			obj2 = obj14;
		}
		return result;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v3+C]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13 @ S2_v4 (should have been resolved before IL gen)");
		IEnumerator result = default;
		return result;
	}

	private IEnumerator<TWeighted> PrefabIterator()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v3+C]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13 @ S2_v4 (should have been resolved before IL gen)");
		IEnumerator<TWeighted> result = default;
		return result;
	}

	public void Add(TWeighted item)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = item;
	}

	public bool Contains(TWeighted item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S2_v2+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S3_v4 (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public bool Contains(T item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S2_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S2_v3+1C]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S3_v4 (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public void Clear()
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		_weightedRandomizedPrefabs = (WeightRandomizedContainer<T>)1;
		_weightedRandomizedPrefabs = (WeightRandomizedContainer<T>)1;
	}

	public void RemoveEmptyEntries()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S1_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v4+38]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17 @ S2_v5 (should have been resolved before IL gen)");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v8+3C]");
		object obj9 = 0;
		object obj10 = obj9 & 0x3FFF;
		object obj11 = obj10 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S2_v9 (should have been resolved before IL gen)");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v11+60]");
		object obj13 = -(-64);
		object obj14 = obj13;
		object obj15 = obj14 & 0x3FFF;
		object obj16 = obj15 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S2_v14 (should have been resolved before IL gen)");
	}

	public void SetPickEvaluator(Func<T, bool> evaluator)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S2_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S2_v3+18]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S3_v4 (should have been resolved before IL gen)");
	}

	private void BuildRandomlyOrderedPrefabList(SyboRandom random)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = random;
	}

	public T PickSemiRandomlyOrderedPrefab(SyboRandom random)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got I4
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S1_v3+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v4+24]");
		object obj6 = 0;
		object obj7 = obj6 & 0x3FFF;
		object obj8 = obj7 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v21 @ S2_v4 (should have been resolved before IL gen)");
		object obj10 = default;
		object obj9 = obj10 + 8;
		obj9 = random;
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v9+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v15+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v16+30]");
		object obj15 = 0;
		object obj16 = obj15 & 0x1FFF;
		object obj17 = obj16 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54 @ S5_v4 (should have been resolved before IL gen)");
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S2_v7+60]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S2_v8+34]");
		object obj20 = 0;
		object obj21 = obj20 & 0x1FFF;
		object obj22 = obj21 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v67 @ S3_v8 (should have been resolved before IL gen)");
		object obj23 = default;
		bool flag = obj23 != null;
		return (T)flag;
	}

	public T PickRandomPrefab(SyboRandom random)
	{
		//IL_02b7: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I
		//IL_02dd: Expected Obj, but got I
		//IL_02ed: Expected Obj, but got I
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_03c2: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_0406: Expected I, but got Obj
		//IL_041c: Expected Obj, but got I
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_018e: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I4
		//IL_00dc: Expected I, but got Obj
		//IL_034d: Expected Obj, but got I
		//IL_035d: Expected Obj, but got I
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_0093: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_01ea: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_0238: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		object result = 0;
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v6+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7+60]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36 @ S2_v5 (should have been resolved before IL gen)");
		object obj7 = default;
		if (obj7 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v28+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v29+64]");
			object obj10 = 0;
			object obj11 = obj10 & 0x3FFF;
			object obj12 = obj11 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50 @ S2_v32 (should have been resolved before IL gen)");
			object obj13 = default;
			if (obj13 == null)
			{
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S2_v34+60]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S2_v35+68]");
				object obj16 = 0;
				object obj17 = obj16 & 0x3FFF;
				object obj18 = obj17 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v61 @ S3_v35 (should have been resolved before IL gen)");
			}
		}
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S3_v5+60]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S3_v6+6C]");
		object obj21 = 0;
		object obj22 = obj21 & 0x1FFF;
		object obj23 = obj22 + 30963;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v87 @ S4_v5 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			return (T)(object)computeShader;
		}
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S2_v12+60]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S2_v13+70]");
		object obj27 = 0;
		object obj28 = obj27 & 0x3FFF;
		object obj29 = obj28 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v130 @ S3_v12 (should have been resolved before IL gen)");
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S2_v16+60]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S2_v17+74]");
		object obj32 = 0;
		object obj33 = obj32 & 0x3FFF;
		object obj34 = obj33 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v143 @ S3_v16 (should have been resolved before IL gen)");
		object obj35 = 0;
		object obj41 = default;
		object obj52 = default;
		while (true)
		{
			object obj36 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S2_v21+60]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S2_v22+80]");
			object obj38 = 0;
			object obj39 = obj38 & 0x3FFF;
			object obj40 = obj39 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v160 @ S3_v21 (should have been resolved before IL gen)");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj41))
			{
				object obj42 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S2_v25+60]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S2_v26+78]");
				object obj44 = 0;
				object obj45 = obj44 & 0x1FFF;
				object obj46 = obj45 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v209 @ S3_v25 (should have been resolved before IL gen)");
				object obj47 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S3_v27+60]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S3_v28+7C]");
				object obj49 = 0;
				object obj50 = obj49 & 0x1FFF;
				object obj51 = obj50 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v156 @ S4_v19 (should have been resolved before IL gen)");
				if (obj52 != null)
				{
					break;
				}
				object obj53 = obj35 + 1;
				obj35 = obj53;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			return (T)result;
		}
		T result2 = default;
		return result2;
	}

	public override string ToString()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S2_v2+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S2_v3+14]");
		object obj6 = 0;
		object obj7 = obj6 & 0x3FFF;
		object obj8 = obj7 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v22 @ S3_v4 (should have been resolved before IL gen)");
		string text = default;
		object obj9 = text + 16;
		obj9 = this;
		return text;
	}

	public WeightRandomizedPrefabContainter()
	{
		//IL_013b: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_001d: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0059: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I
		//IL_009a: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5+8]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S2_v5 (should have been resolved before IL gen)");
		object obj8 = default;
		object obj7 = obj8;
		while (true)
		{
			object obj9 = obj7 - 1;
			if ((nint)obj9 < 0)
			{
				break;
			}
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S2_v8+60]");
			object obj11 = 0;
			object obj12 = obj11;
			object obj13 = obj12 & 0x1FFF;
			object obj14 = obj13 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v71 @ S3_v7 (should have been resolved before IL gen)");
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v14+10]");
			if ((UnityEngine.Object)0 != null)
			{
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v15+60]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S2_v16+48]");
				object obj18 = 0;
				object obj19 = obj18 & 0x3FFF;
				object obj20 = obj19 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S3_v12 (should have been resolved before IL gen)");
			}
			obj7 = obj9;
		}
	}
}
