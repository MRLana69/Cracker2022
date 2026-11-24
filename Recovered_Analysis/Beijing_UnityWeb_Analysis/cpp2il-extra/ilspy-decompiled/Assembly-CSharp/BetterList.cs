using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class BetterList<T>
{
	public delegate int CompareFunc(T left, T right);

	private sealed class _003CGetEnumerator_003Ed__2 : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		public BetterList<T> _003C_003E4__this;

		private int _003Ci_003E5__2;

		T IEnumerator<T>.Current
		{
			get
			{
				//IL_0010: Expected Obj, but got I
				//IL_0020: Expected Obj, but got I
				//IL_0030: Expected Obj, but got I
				//IL_0039: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Expected Obj, but got Unknown
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected Obj, but got Unknown
				//IL_005d: Expected VT, but got I4
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2+60]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v3+24]");
				object obj3 = 0;
				object obj4 = obj3 & 0x3FFF;
				object obj5 = obj4 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13 @ S2_v4 (should have been resolved before IL gen)");
				return (T)_003C_003E1__state;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				//IL_0007: Expected Obj, but got VT
				return _003C_003E2__current;
			}
		}

		public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_001e: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I4
			//IL_0046: Expected Obj, but got I4
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Expected Obj, but got Unknown
			//IL_005b: Expected Obj, but got I4
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected Obj, but got Unknown
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected Obj, but got Unknown
			//IL_00b9: Expected Obj, but got I
			//IL_00c9: Expected Obj, but got I
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected Obj, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected Obj, but got Unknown
			//IL_019b: Expected Obj, but got I4
			//IL_01c6: Expected Obj, but got I4
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected Obj, but got Unknown
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected Obj, but got Unknown
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Expected Obj, but got Unknown
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Expected Obj, but got Unknown
			//IL_0252: Expected Obj, but got I4
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Expected Obj, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected Obj, but got Unknown
			//IL_0186: Expected Obj, but got I4
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected Obj, but got Unknown
			object obj = _003C_003E2__current - 1;
			nint num = default;
			object obj2 = num + 12;
			bool flag = true;
			object obj3 = 0;
			object obj17 = default;
			while (flag)
			{
				object obj4 = obj3;
				object obj5 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
				{
					object obj6 = this._003C_003E1__state + 16;
					object obj7 = obj4 << 2;
					object obj8 = obj6 + obj7;
					object obj9 = obj4 << 2;
					object obj10 = this._003C_003E1__state + obj9;
					object obj11 = obj10 + 20;
					object obj12 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S3_v8+60]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S3_v9+28]");
					object obj14 = 0;
					object obj15 = obj14 & 0x1FFF;
					object obj16 = obj15 + 30963;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S4_v2 (should have been resolved before IL gen)");
					if ((nint)obj17 < 1)
					{
						object obj18 = obj5 & 1;
						if (obj18 == null)
						{
							object obj19 = ((obj4 == null) ? ((object)0) : ((object)(obj4 - 1)));
							obj3 = obj19;
						}
					}
					else
					{
						object obj20 = this._003C_003E1__state + 16;
						object obj21 = obj4 << 2;
						object obj22 = obj20 + obj21;
						object obj23 = this._003C_003E1__state + 16;
						object obj24 = obj4 << 2;
						object obj25 = obj23 + obj24;
						object obj26 = obj4 << 2;
						object obj27 = this._003C_003E1__state + obj26;
						object obj28 = obj27 + 20;
						obj25 = obj28;
						object obj29 = obj4 << 2;
						object obj30 = this._003C_003E1__state + obj29;
						object obj31 = obj30 + 20;
						obj31 = obj22;
						obj5 = 1;
					}
					object obj32 = obj4 + 1;
					obj4 = obj32;
				}
				object obj33 = obj5 & 1;
				bool flag2 = obj33 != null;
				flag = flag2;
			}
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got VT
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

	public T[] buffer;

	public int size = 0;

	// C# has no syntax for parameterized property 'Item'.
	public T get_Item(int i)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0061: Expected VT, but got I4
		//IL_0064: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0xFFF;
		object obj5 = obj4 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v22 @ S1_v5 (should have been resolved before IL gen)");
		ReadOnlyDictionary<object, object> readOnlyDictionary = default;
		readOnlyDictionary.System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002ERemove((KeyValuePair<object, object>)0);
		return (T)null;
	}

	public void set_Item(int i, T value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
	}

	public IEnumerator<T> GetEnumerator()
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v3+18]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13 @ S2_v4 (should have been resolved before IL gen)");
		IEnumerator<T> result = default;
		return result;
	}

	private void AllocateMore()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}

	private void Trim()
	{
		//IL_00b9: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_005e: Expected I, but got Obj
		if (buffer != null)
		{
			T[] array = buffer;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = array.Length << 1;
			if ((nint)obj2 <= 32)
			{
				obj2 = 32;
			}
		}
		else
		{
			object obj2 = 32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v9+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num3 = default;
		if (buffer != null && size >= 1)
		{
			Array.Reverse((Array)buffer, num3, 0);
		}
		object obj5 = this + 8;
		obj5 = num3;
	}

	public void Clear()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		if (size < 1)
		{
			object obj = this + 8;
			obj = 0;
			return;
		}
		T[] array = buffer;
		if (size < array.Length)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v11+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj4 = 0;
			object obj6 = default;
			while ((nint)obj4 < size)
			{
				object obj5 = obj6 + 16;
				object obj7 = obj4 << 2;
				object obj8 = obj5 + obj7;
				object obj9 = buffer + 16;
				object obj10 = obj4 << 2;
				object obj11 = obj9 + obj10;
				obj8 = obj11;
				object obj12 = obj4 + 1;
				obj4 = obj12;
			}
			object obj13 = this + 8;
			obj13 = obj6;
		}
	}

	public void Release()
	{
		size = 0;
	}

	public void Add(T item)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0061: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0xFFF;
		object obj5 = obj4 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v22 @ S1_v5 (should have been resolved before IL gen)");
		ReadOnlyDictionary<object, object> readOnlyDictionary = default;
		readOnlyDictionary.System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EAdd((KeyValuePair<object, object>)0);
	}

	public void Insert(int index, T item)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got VT
		object obj = buffer + 16;
		int num = index << 2;
		object obj2 = obj + num;
		obj2 = item;
	}

	public bool Contains(T item)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001e: Expected Obj, but got VT
		//IL_0030: Expected I4, but got Obj
		object obj = buffer + 16;
		object obj2 = item << 2;
		object obj3 = obj + obj2;
		return (byte)(int)obj3 != 0;
	}

	public int IndexOf(T item)
	{
		//IL_0028: Expected Obj, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		if (buffer != null)
		{
			object obj = 0;
			object obj5 = default;
			while (true)
			{
				if ((nint)obj >= size)
				{
					return 0;
				}
				object obj2 = buffer + 16;
				object obj3 = obj << 2;
				object obj4 = obj2 + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				if (obj5 != null)
				{
					break;
				}
				object obj6 = obj + 1;
				obj = obj6;
			}
			return 1;
		}
		return 0;
	}

	public bool Remove(T item)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I4
		bool flag;
		if (buffer != null)
		{
			flag = false;
			object obj4 = default;
			while (true)
			{
				if ((flag ? 1 : 0) >= size)
				{
					flag = true;
					break;
				}
				object obj = buffer + 16;
				object obj2 = (flag ? 1u : 0u) << 2;
				object obj3 = obj + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				if (obj4 == null)
				{
					bool flag2 = (byte)((flag ? 1u : 0u) + 1u) != 0;
					flag = flag2;
					continue;
				}
				break;
			}
		}
		else
		{
			flag = true;
		}
		return flag;
	}

	public void RemoveAt(int index)
	{
		//IL_005e: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		if (buffer != null)
		{
			T[] array = buffer;
			if (size != array.Length)
			{
				goto IL_00a9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v9+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v10+C]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25 @ S2_v9 (should have been resolved before IL gen)");
		goto IL_00a9;
		IL_00a9:
		int num = size + 1;
		size = num;
		object obj6 = buffer + 16;
		int num2 = size << 2;
		object obj7 = obj6 + num2;
		obj7 = index;
	}

	public T Pop()
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S2_v3+4]");
		object obj6 = 0;
		object obj7 = obj6 & 0x3FFF;
		object obj8 = obj7 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v22 @ S3_v4 (should have been resolved before IL gen)");
		T val = default;
		object obj9 = val + 16;
		obj9 = this;
		return val;
	}

	public T[] ToArray()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		object obj = 0;
		T[] result;
		if (buffer != null && size != 0)
		{
			int num = --size;
			object obj2 = buffer + 16;
			int num2 = num << 2;
			object obj3 = obj2 + num2;
			result = (T[])obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			object obj4 = buffer + 16;
			int num3 = size << 2;
			object obj5 = obj4 + num3;
			obj5 = obj;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			result = (T[])obj;
		}
		return result;
	}

	public void Sort(CompareFunc comparer)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		object obj = 0;
		CompareFunc compareFunc = default;
		bool flag = (nint)compareFunc > -1;
		bool flag2 = buffer != null;
		object obj2 = flag & flag2;
		if (obj2 != null && size > (nint)compareFunc)
		{
			int num = size - 1;
			size = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			object obj3 = buffer + 16;
			object obj4 = (object)compareFunc << 2;
			object obj5 = obj3 + obj4;
			obj5 = obj;
			CompareFunc compareFunc2 = default;
			while ((nint)compareFunc2 < size)
			{
				object obj6 = buffer + 16;
				object obj7 = (object)compareFunc << 2;
				object obj8 = obj6 + obj7;
				object obj9 = (object)compareFunc << 2;
				object obj10 = (object)buffer + obj9;
				object obj11 = obj10 + 20;
				obj8 = obj11;
				compareFunc2 = (CompareFunc)(compareFunc + 1);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			object obj12 = buffer + 16;
			int num2 = size << 2;
			object obj13 = obj12 + num2;
			obj13 = obj;
		}
	}

	public BetterList()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		object obj = this + 8;
		obj = 0;
	}
}
