using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class BetterList<T>
{
	public delegate int CompareFunc(T left, T right);

	private sealed class _003CGetEnumerator_003Ed__6(int _003C_003E1__state) : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private T _003C_003E2__current;

		public BetterList<T> _003C_003E4__this;

		private int _003Ci_003E5__2;

		T IEnumerator<T>.Current
		{
			get
			{
				//IL_0010: Expected Obj, but got I
				//IL_0024: Expected VT, but got Obj
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
				_003CGetEnumerator_003Ed__6 obj = (_003CGetEnumerator_003Ed__6)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+14]");
				_003C_003E1__state = 0;
				return (T)null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_001f: Expected Obj, but got VT
				object obj2 = default;
				object obj = obj2 - 16;
				_ = _003Ci_003E5__2;
				obj = _003C_003E2__current;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object result = default;
				return result;
			}
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_001e: Expected Obj, but got I
			//IL_009a: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got I
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected Obj, but got Unknown
			//IL_0105: Expected Obj, but got I
			//IL_0121: Expected VT, but got Obj
			object obj2 = default;
			object obj = obj2 - 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BetterList`1<T>+<GetEnumerator>d__6<T>)+1C]");
			object obj3 = 0;
			object obj4;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0131;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BetterList`1<T>+<GetEnumerator>d__6<T>)+20]");
				obj4 = (nint)0 + (nint)1;
			}
			else
			{
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+8]");
				if ((nint)0 == 0)
				{
					goto IL_0131;
				}
				obj4 = 0;
			}
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+C]");
			if ((nint)obj5 < 0)
			{
				object obj6 = obj4 << 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+8]");
				object obj7 = 0 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v9+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v9+10]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_003Ci_003E5__2 = 0;
				_003C_003E2__current = (T)obj;
				_003C_003E1__state = 1;
			}
			goto IL_0131;
			IL_0131:
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public T[] buffer;

	public int size;

	// C# has no syntax for parameterized property 'Item'.
	public T get_Item(int i)
	{
		//IL_000e: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0047: Expected VT, but got Obj
		nint num = default;
		object obj = num << 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [i @ L1 (System.Int32)+8]");
		object obj2 = 0 + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v3+18]");
		buffer = (T[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v3+10]");
		BetterList<T> betterList = (BetterList<T>)0;
		return (T)null;
	}

	public void set_Item(int i, T value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got VT
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L2 (T)+8]");
		_ = 0;
		obj = value;
		int num = i << 4;
		object obj3 = buffer + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
	}

	public IEnumerator<T> GetEnumerator()
	{
		//IL_002b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S3_v3 (Il2CppRgctx<BetterList`1>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S3_v4+4] (should have been resolved before IL gen)");
		IEnumerator<T> result = default;
		return result;
	}

	private void AllocateMore()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		object obj = this + 8;
		T[] array = buffer;
		if (buffer != null)
		{
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array2 = default;
		if (obj != null && size >= 1)
		{
			((Array)obj).CopyTo(array2, 0);
		}
		obj = array2;
	}

	private void Trim()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d5: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		if (size >= 1)
		{
			T[] array = buffer;
			if (size < array.Length)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				object obj3 = default;
				object obj5 = default;
				T[] array2 = default;
				while (size > (nint)obj3)
				{
					object obj4 = obj5 << 4;
					object obj6 = (object)buffer + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v16+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v16+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					obj = 0;
					object obj7 = obj5 << 4;
					object obj8 = (object)array2 + obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					obj3 = obj5 + 1;
				}
				buffer = array2;
			}
		}
		else
		{
			buffer = null;
		}
	}

	public void Clear()
	{
		size = 0;
	}

	public void Release()
	{
		buffer = null;
	}

	public void Add(T item)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I
		//IL_00da: Expected Obj, but got VT
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		T[] array = buffer;
		int num;
		T[] array2;
		if (buffer != null)
		{
			bool flag = size != array.Length;
			num = size;
			array2 = buffer;
			if (flag)
			{
				goto IL_00ad;
			}
		}
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S2_v6 (Il2CppRgctx<BetterList`1>)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S2_v7+4] (should have been resolved before IL gen)");
		num = size;
		array2 = buffer;
		goto IL_00ad;
		IL_00ad:
		int num4 = num + 1;
		size = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (T)+8]");
		_ = 0;
		obj = item;
		int num5 = num << 4;
		object obj4 = array2 + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
	}

	public void Insert(int index, T item)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		T[] array = buffer;
		if (buffer == null || size == array.Length)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v13 (Il2CppRgctx<BetterList`1>)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S2_v14+4] (should have been resolved before IL gen)");
		}
		if (index >= 0)
		{
			bool flag = size <= index;
			int num3 = size;
			if (!flag)
			{
				while (index < num3)
				{
					object obj4 = obj - -64;
					object obj5 = num3 - 1;
					object obj6 = obj5 << 4;
					object obj7 = (object)buffer + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v34+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v34+10]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
					_ = 0;
					int num4 = num3 << 4;
					object obj8 = buffer + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					_ = 0;
					int num5 = num3 - 1;
					num3 = num5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L2 (T)+8]");
				_ = 0;
				int num6 = index << 4;
				object obj9 = buffer + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				int num7 = size + 1;
				size = num7;
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L2 (T)+8]");
		_ = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v16 (Il2CppRgctx<BetterList`1>)+10]");
		object obj10 = 0;
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S0_v17+4] (should have been resolved before IL gen)");
	}

	public unsafe bool Contains(T item)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got VT
		//IL_0259: Expected Obj, but got I4
		//IL_01c8: Expected F4, but got I
		//IL_00e0: Expected I, but got Obj
		//IL_0128: Expected F4, but got Obj
		//IL_0128: Expected Ref, but got F4
		//IL_0104: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0237: Expected I, but got F4
		//IL_016f: Expected F4, but got I
		//IL_016f: Expected Ref, but got F4
		//IL_01ae: Expected F4, but got Obj
		//IL_01ae: Expected Ref, but got F4
		//IL_01f8: Expected F4, but got Obj
		//IL_01f8: Expected Ref, but got F4
		//IL_0205: Expected Obj, but got I4
		//IL_02a5: Expected F4, but got Obj
		//IL_021c: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		bool result = default;
		if (buffer != null)
		{
			object obj3 = default;
			object obj6 = default;
			nint num2 = default;
			object obj9 = default;
			while (true)
			{
				bool flag = (nint)obj3 < size;
				bool flag2 = !flag;
				result = flag;
				if (flag2)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (T)+8]");
				_ = 0;
				obj = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj4 = obj3 << 4;
				object obj5 = (object)buffer + obj4;
				float num = (float)obj5 + 16f;
				bool flag3 = obj6 == null;
				object obj7 = 0;
				if (!flag3)
				{
					bool flag4 = obj6 == typeof(Color);
					num2 = (nint)typeof(Color);
					obj7 = obj6;
					if (!flag4)
					{
						num2 = (nint)typeof(Color);
						obj7 = 0;
					}
				}
				bool flag6;
				float num6;
				if (obj7 != null)
				{
					NullReferenceException ex = new NullReferenceException();
					if (((float*)num)->Equals((float)ex))
					{
						float num3 = num + 4f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v46 (System.NullReferenceException)+4]");
						if (((float*)num3)->Equals(0f))
						{
							float num4 = num + 8f;
							if (((float*)num4)->Equals((float)((Exception)ex)._className))
							{
								float num5 = num + 12f;
								bool flag5 = ((float*)num5)->Equals((float)((Exception)ex)._message);
								object obj8 = 0;
								if (!flag5)
								{
									obj8 = 5;
								}
								flag6 = (nint)obj8 == 5;
								num6 = (float)((Exception)ex)._message;
								goto IL_0267;
							}
						}
					}
				}
				num6 = num2;
				flag6 = true;
				goto IL_0267;
				IL_0267:
				bool flag7 = !flag6;
				result = flag;
				if (flag7)
				{
					break;
				}
				obj3 = obj9 + 1;
				num2 = (nint)num6;
			}
		}
		return result;
	}

	public unsafe int IndexOf(T item)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got VT
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_0268: Expected Obj, but got I4
		//IL_01ca: Expected F4, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_012a: Expected F4, but got Obj
		//IL_012a: Expected Ref, but got F4
		//IL_0106: Expected I, but got Obj
		//IL_010f: Expected Obj, but got I4
		//IL_0239: Expected I, but got F4
		//IL_0171: Expected F4, but got I
		//IL_0171: Expected Ref, but got F4
		//IL_01b0: Expected F4, but got Obj
		//IL_01b0: Expected Ref, but got F4
		//IL_01fa: Expected F4, but got Obj
		//IL_01fa: Expected Ref, but got F4
		//IL_0207: Expected Obj, but got I4
		//IL_02ac: Expected F4, but got Obj
		//IL_021e: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		bool flag = buffer == null;
		int result = -1;
		if (!flag)
		{
			int num = default;
			object obj4 = default;
			nint num4 = default;
			int num9 = default;
			while (true)
			{
				bool flag2 = num >= size;
				result = -1;
				if (flag2)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (T)+8]");
				_ = 0;
				obj = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				int num2 = num << 4;
				object obj3 = buffer + num2;
				float num3 = (float)obj3 + 16f;
				bool flag3 = obj4 == null;
				object obj5 = 0;
				if (!flag3)
				{
					bool flag4 = obj4 == typeof(Color);
					num4 = (nint)typeof(Color);
					obj5 = obj4;
					if (!flag4)
					{
						num4 = (nint)typeof(Color);
						obj5 = 0;
					}
				}
				bool flag6;
				float num8;
				if (obj5 != null)
				{
					NullReferenceException ex = new NullReferenceException();
					if (((float*)num3)->Equals((float)ex))
					{
						float num5 = num3 + 4f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v46 (System.NullReferenceException)+4]");
						if (((float*)num5)->Equals(0f))
						{
							float num6 = num3 + 8f;
							if (((float*)num6)->Equals((float)((Exception)ex)._className))
							{
								float num7 = num3 + 12f;
								bool flag5 = ((float*)num7)->Equals((float)((Exception)ex)._message);
								object obj6 = 0;
								if (!flag5)
								{
									obj6 = 5;
								}
								flag6 = (nint)obj6 == 5;
								num8 = (float)((Exception)ex)._message;
								goto IL_0276;
							}
						}
					}
				}
				num8 = num4;
				flag6 = true;
				goto IL_0276;
				IL_0276:
				if (flag6)
				{
					num = num9 + 1;
					num4 = (nint)num8;
					continue;
				}
				result = num;
				break;
			}
		}
		return result;
	}

	public bool Remove(T item)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01fd: Expected Obj, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 112;
		_ = 0;
		_ = 0;
		if (buffer != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppRgctx<BetterList`1>)+1C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v9+4] (should have been resolved before IL gen)");
			object obj4 = 0;
			object obj9 = default;
			while ((nint)obj4 < size)
			{
				object obj5 = obj4 << 4;
				object obj6 = (object)buffer + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v16+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v16+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (T)+8]");
				_ = 0;
				object obj7 = obj - -64;
				object obj8 = obj + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E98");
				if (obj9 != null)
				{
					int num3 = size - 1;
					size = num3;
					object obj10 = obj + 96;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					_ = 0;
					object obj11 = obj4 << 4;
					object obj12 = (object)buffer + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
					_ = 0;
					while (size > (nint)obj4)
					{
						object obj13 = obj4 + 1;
						object obj14 = obj13 << 4;
						object obj15 = (object)buffer + obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v60+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v60+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
						obj = 0;
						object obj16 = obj4 << 4;
						object obj17 = (object)buffer + obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						object obj18 = obj4 + 1;
						obj4 = obj18;
					}
					object obj19 = obj + 96;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					_ = 0;
					int num4 = size << 4;
					object obj20 = buffer + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					_ = 0;
					break;
				}
				object obj21 = obj4 + 1;
				obj4 = obj21;
			}
		}
		return true;
	}

	public void RemoveAt(int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		_ = 0;
		int num = default;
		if (buffer != null && num >= 0 && size > num)
		{
			int num2 = size - 1;
			size = num2;
			object obj3 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			_ = 0;
			int num3 = num << 4;
			object obj4 = buffer + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			int num4 = default;
			while (size > num4)
			{
				object obj5 = num + 1;
				object obj6 = obj5 << 4;
				object obj7 = (object)buffer + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v37+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v37+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				obj = 0;
				int num5 = num << 4;
				object obj8 = buffer + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				num4 = num + 1;
			}
			object obj9 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			_ = 0;
			int num6 = size << 4;
			object obj10 = buffer + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
		}
	}

	public T Pop()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0165: Expected Obj, but got I
		//IL_0175: Expected Obj, but got I
		//IL_017c: Expected VT, but got Obj
		//IL_007a: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00f9: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+8]");
		BetterList<T> betterList;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
				object obj3 = -1;
				object obj4 = obj3 << 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+8]");
				object obj5 = 0 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v15+18]");
				buffer = (T[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v15+10]");
				betterList = (BetterList<T>)0;
				object obj6 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
				object obj7 = (nint)0 << 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+8]");
				object obj8 = 0 + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				goto IL_017a;
			}
		}
		object obj9 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		buffer = (T[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		betterList = (BetterList<T>)0;
		goto IL_017a;
		IL_017a:
		return (T)null;
	}

	public T[] ToArray()
	{
		//IL_001c: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S2_v3 (Il2CppRgctx<BetterList`1>)+2C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S2_v4+4] (should have been resolved before IL gen)");
		return buffer;
	}

	public void Sort(CompareFunc comparer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00f1: Expected Obj, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_02b4: Expected Obj, but got I
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02fa: Expected Obj, but got I4
		//IL_0304: Expected Obj, but got I4
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_0348: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 144;
		_ = 0;
		_ = 0;
		object obj3 = size - 1;
		object obj4 = 1;
		object obj6 = default;
		object obj15 = default;
		object obj26 = default;
		while (true)
		{
			bool flag = obj4 == null;
			object obj5 = 0;
			if (flag)
			{
				break;
			}
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj7 = obj6 << 4;
				object obj8 = (object)buffer + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v11+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v11+10]");
				_ = 0;
				object obj9 = obj6 + 1;
				object obj10 = obj9 << 4;
				object obj11 = (object)buffer + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v17+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v17+10]");
				_ = 0;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v25 (Il2CppRgctx<BetterList`1>)+34]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
				_ = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
				_ = 0;
				object obj13 = obj + 48;
				object obj14 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ S0_v26+4] (should have been resolved before IL gen)");
				if ((nint)obj15 >= 1)
				{
					object obj16 = obj6 << 4;
					object obj17 = (object)buffer + obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v45+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v45+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
					_ = 0;
					object obj18 = obj6 + 1;
					object obj19 = obj18 << 4;
					object obj20 = (object)buffer + obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v55+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v55+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					_ = 0;
					object obj21 = obj6 << 4;
					object obj22 = (object)buffer + obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					obj = 0;
					object obj23 = obj6 + 1;
					object obj24 = obj23 << 4;
					object obj25 = (object)buffer + obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					obj5 = 1;
					obj14 = 4;
				}
				else if (obj5 == null)
				{
					if (obj6 == null)
					{
						obj26 = 0;
					}
					else
					{
						object obj27 = obj6 - 1;
						obj26 = obj27;
					}
				}
				object obj28 = obj6 + 1;
				obj6 = obj28;
			}
			obj6 = obj26;
			obj4 = obj5;
		}
	}
}
