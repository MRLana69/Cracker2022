using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Common.Utilities;

[Serializable]
public class WeightRandomizedOrderedContainter<TWeighted, T> : IEnumerable<TWeighted>, IEnumerable where TWeighted : WeightedObject<T> where T : class
{
	private sealed class _003CEnumerator_003Ed__14 : IEnumerator<TWeighted>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private TWeighted _003C_003E2__current;

		public WeightRandomizedOrderedContainter<TWeighted, T> _003C_003E4__this;

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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v4+50]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v9+78]");
				object obj12 = 0;
				object obj13 = obj12 & 0x3FFF;
				object obj14 = obj13 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54 @ S2_v10 (should have been resolved before IL gen)");
				string format = default;
				object arg = default;
				return (TWeighted)(object)string.Format((IFormatProvider)(object)"[WeightRandomizedContainter: Name={1}, Empty={0}]", format, arg);
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CEnumerator_003Ed__14(int _003C_003E1__state)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_02f2: Expected Obj, but got I
			//IL_030a: Expected Obj, but got I
			//IL_031a: Expected Obj, but got I
			//IL_0323: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Expected Obj, but got Unknown
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0336: Expected Obj, but got Unknown
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Expected Obj, but got Unknown
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Expected Obj, but got Unknown
			//IL_038d: Expected Obj, but got I4
			//IL_0048: Expected Obj, but got I
			//IL_006f: Expected Obj, but got I4
			//IL_0410: Expected Obj, but got I
			//IL_0420: Expected Obj, but got I
			//IL_0429: Unknown result type (might be due to invalid IL or missing references)
			//IL_042e: Expected Obj, but got Unknown
			//IL_0437: Unknown result type (might be due to invalid IL or missing references)
			//IL_043c: Expected Obj, but got Unknown
			//IL_022c: Expected Obj, but got I
			//IL_03b0: Expected Obj, but got I
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Expected Obj, but got Unknown
			//IL_00ab: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected Obj, but got Unknown
			//IL_00ff: Expected Obj, but got I
			//IL_010f: Expected Obj, but got I
			//IL_0136: Expected Obj, but got I
			//IL_0146: Expected Obj, but got I
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			nint num = default;
			object obj3 = num + 12;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v8+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v9+30]");
			object obj6 = 0;
			object obj7 = obj6 & 0x3FFF;
			object obj8 = obj7 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S2_v5 (should have been resolved before IL gen)");
			object obj9 = default;
			object obj16 = default;
			object obj20 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj9 == null)
				{
					break;
				}
				object obj10 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v65+60]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj12 = 0;
				while (true)
				{
					object obj13 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v81+60]");
					object obj14 = -(-64);
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16))
					{
						object obj17 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v93+60]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v94+38]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj20 != null)
						{
							object obj21 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v102+60]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v103+38]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							object obj24 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v110+60]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v111+3C]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							object obj27 = obj12 + 1;
							obj12 = obj27;
							continue;
						}
						break;
					}
					break;
				}
			}
			object obj28 = obj2 + 4;
			object obj29 = obj28 + 1;
			obj28 = obj29;
			object obj30 = obj29 << 2;
			object obj31 = obj2 + obj30;
			obj31 = 98;
			object obj32 = default;
			if (obj32 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj33 = (nint)0 << 2;
				object obj34 = obj2 + obj33;
				if ((nint)obj34 == 98)
				{
					object obj35 = obj2 + 4;
					if ((nint)obj35 > -1)
					{
						object obj36 = obj35 + -1;
						obj35 = obj36;
					}
					goto IL_03f8;
				}
			}
			object obj37 = default;
			if (obj37 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_03f8;
			IL_03f8:
			object obj38 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S2_v14+60]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S2_v15+48]");
			object obj40 = 0;
			object obj41 = obj40 & 0x3FFF;
			object obj42 = obj41 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v256 @ S3_v9 (should have been resolved before IL gen)");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v4+80]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v10+88]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v16+90]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v68+A0]");
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

	private List<TWeighted> _weightedObjects;

	private WeightRandomizedContainer<T> _weightedRandomizedObjects;

	private SemiRandomlyOrderedList<T> _randomlyOrderedObjects;

	private Func<T, bool> _pickEvaluator;

	private string Name__BackingField;

	public bool IsEmpty
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_weightedRandomizedObjects != 0;
		}
	}

	public unsafe string Name
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
			//IL_0091: Expected Obj, but got Ref
			//IL_00e1: Expected Obj, but got Ref
			nint num = default;
			object obj = num + 24;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			ref Material reference2 = default;
			ref Material reference = ref reference2;
			while ((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) >= (nint)2)
			{
				bool flag = ((Theme)this).TryGetDevicePerformanceRelativeMaterial((Material)null, out reference);
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref reference, 1));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref reference, 1));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
				reference = ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref reference, 1);
			}
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
		//IL_0009: Expected Obj, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Ref, but got Unknown
		//IL_0027: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		object result = 0;
		bool flag = ((Theme)index).TryGetDevicePerformanceRelativeMaterial(null, out *(Material*)(_weightedRandomizedObjects + 1));
		nint num = default;
		object obj = num + 12;
		object obj2 = 0;
		object obj8 = default;
		while (true)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v6+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S2_v7+14]");
			object obj5 = 0;
			object obj6 = obj5 & 0x3FFF;
			object obj7 = obj6 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S3_v7 (should have been resolved before IL gen)");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
			{
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S3_v10+60]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S3_v11+10]");
				object obj11 = 0;
				object obj12 = obj11 & 0x1FFF;
				object obj13 = obj12 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S4_v8 (should have been resolved before IL gen)");
				bool flag2 = flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v14+8]");
				if ((nint)(flag2 ? 1 : 0) <= (nint)0)
				{
					break;
				}
				object obj14 = obj2 + 1;
				obj2 = obj14;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			return (TWeighted)result;
		}
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v12+60]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v13+10]");
		object obj17 = 0;
		object obj18 = obj17 & 0x1FFF;
		object obj19 = obj18 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v91 @ S3_v16 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v21+C]");
		return (TWeighted)0;
	}

	public void set_Item(int index, TWeighted value)
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001e: Expected Obj, but got I4
		_weightedObjects = (List<TWeighted>)1;
		object obj = this + 12;
		obj = index;
		_weightedObjects = (List<TWeighted>)(object)value;
	}

	public IEnumerator<TWeighted> GetEnumerator()
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
		IEnumerator<TWeighted> result = default;
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

	private IEnumerator<TWeighted> Enumerator()
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

	public void Clear()
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		_weightedObjects = (List<TWeighted>)1;
		_weightedObjects = (List<TWeighted>)1;
	}

	public TWeighted Find(Predicate<TWeighted> predicate)
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
		TWeighted result = default;
		return result;
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

	private void BuildRandomlyOrderedList(SyboRandom random)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = random;
	}

	public T PickSemiRandomlyOrdered(SyboRandom random)
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S2_v3+2C]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S3_v4 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public T PickRandomPrefab(SyboRandom random)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_01b6: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I
		//IL_036e: Expected Obj, but got I
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_0110: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0212: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0260: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		object result = 0;
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v6+4C]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S2_v5 (should have been resolved before IL gen)");
		object obj7 = default;
		if (obj7 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v25+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v26+50]");
			object obj10 = 0;
			object obj11 = obj10 & 0x3FFF;
			object obj12 = obj11 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S2_v31 (should have been resolved before IL gen)");
			object obj13 = default;
			if (obj13 == null)
			{
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v33+60]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v34+54]");
				object obj16 = 0;
				object obj17 = obj16 & 0x3FFF;
				object obj18 = obj17 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S3_v35 (should have been resolved before IL gen)");
			}
		}
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S3_v5+60]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S3_v6+58]");
		object obj21 = 0;
		object obj22 = obj21 & 0x1FFF;
		object obj23 = obj22 + 30963;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v77 @ S4_v5 (should have been resolved before IL gen)");
		T val = default;
		if (val == null)
		{
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v11+60]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S2_v12+5C]");
			object obj26 = 0;
			object obj27 = obj26 & 0x3FFF;
			object obj28 = obj27 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v102 @ S3_v12 (should have been resolved before IL gen)");
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S2_v15+60]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S2_v16+60]");
			object obj31 = 0;
			object obj32 = obj31 & 0x3FFF;
			object obj33 = obj32 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v115 @ S3_v16 (should have been resolved before IL gen)");
			object obj34 = 0;
			object obj40 = default;
			object obj51 = default;
			while (true)
			{
				object obj35 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S2_v20+60]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S2_v21+6C]");
				object obj37 = 0;
				object obj38 = obj37 & 0x3FFF;
				object obj39 = obj38 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v135 @ S3_v21 (should have been resolved before IL gen)");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40))
				{
					object obj41 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S2_v24+60]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S2_v25+64]");
					object obj43 = 0;
					object obj44 = obj43 & 0x1FFF;
					object obj45 = obj44 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v182 @ S3_v25 (should have been resolved before IL gen)");
					object obj46 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S3_v27+60]");
					object obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S3_v28+68]");
					object obj48 = 0;
					object obj49 = obj48 & 0x1FFF;
					object obj50 = obj49 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S4_v19 (should have been resolved before IL gen)");
					if (obj51 != null)
					{
						break;
					}
					object obj52 = obj34 + 1;
					obj34 = obj52;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				return (T)result;
			}
		}
		return val;
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

	public WeightRandomizedOrderedContainter()
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
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S1_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v4+1C]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17 @ S2_v5 (should have been resolved before IL gen)");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v8+20]");
		object obj9 = 0;
		object obj10 = obj9 & 0x3FFF;
		object obj11 = obj10 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S2_v9 (should have been resolved before IL gen)");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v11+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v12+24]");
		object obj14 = 0;
		object obj15 = obj14 & 0x3FFF;
		object obj16 = obj15 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S2_v13 (should have been resolved before IL gen)");
	}
}
