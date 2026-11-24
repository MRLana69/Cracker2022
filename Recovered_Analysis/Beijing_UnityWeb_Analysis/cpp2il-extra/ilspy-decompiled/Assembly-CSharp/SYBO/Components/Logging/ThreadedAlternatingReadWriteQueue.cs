using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using SYBO.Components.Json;
using SYBO.Components.Json.Internal;

namespace SYBO.Components.Logging;

public class ThreadedAlternatingReadWriteQueue<T>
{
	public class ThreadedAlternateReadWriteQueueException : Exception
	{
		public ThreadedAlternateReadWriteQueueException(string message)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			//IL_0033: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I
			//IL_0071: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected Obj, but got Unknown
			//IL_00d8: Expected Obj, but got I4
			//IL_0190: Expected Obj, but got I
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Expected Obj, but got Unknown
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			object obj3 = obj2 + 16;
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v57+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v58+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			object obj7 = obj + 4;
			object obj8 = obj7 + 1;
			obj7 = obj8;
			object obj9 = obj8 << 2;
			object obj10 = obj + obj9;
			obj10 = 43;
			if (obj3 != null)
			{
				throw new ArgumentNullException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj + obj11;
				if ((nint)obj12 == 43)
				{
					object obj13 = obj + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					return;
				}
			}
			object obj15 = default;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
	}

	private object _lockObject;

	private Queue<T> _readQueue;

	private Queue<T> _writeQueue;

	private Thread _readThread;

	public int ReadQueueCount
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0264: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Expected Obj, but got Unknown
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Expected Obj, but got Unknown
			//IL_0280: Expected Obj, but got I4
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Expected Obj, but got Unknown
			//IL_02aa: Expected Obj, but got I
			//IL_0033: Expected I, but got Obj
			//IL_0049: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got I
			//IL_0074: Expected I, but got Obj
			//IL_0347: Expected I4, but got Obj
			object obj2 = default;
			object obj = obj2 + 32;
			object obj3 = obj2 + 20;
			object obj4 = obj2 + 16;
			obj4 = 0;
			object obj5 = obj2 + 8;
			obj5 = obj;
			_ = -1;
			nint num = default;
			object obj6 = num + 24;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj8 = default;
			ThreadedAlternatingReadWriteQueue<T> threadedAlternatingReadWriteQueue = default;
			if (obj8 != null)
			{
				threadedAlternatingReadWriteQueue = this;
			}
			else
			{
				object obj9 = obj6;
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v27 (Il2CppClass<System.Type>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num3 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v105 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+4]");
				obj2 = 0;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj12 = default;
				object obj11 = obj12;
				object obj14 = default;
				object obj13 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj15 = default;
				if (obj13 == obj15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj17 = default;
					object obj16 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj19 = default;
					object obj18 = obj19;
				}
				else
				{
					object obj18 = obj11;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			return (int)threadedAlternatingReadWriteQueue;
		}
	}

	public ThreadedAlternatingReadWriteQueue()
	{
		((FileStream)(object)_readQueue).ExposeHandle();
	}

	public void SetReadThread(Thread thread)
	{
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		string text = default;
		if (text != null && text.m_stringLength != 0)
		{
			JsonList jsonList = JsonList.ParseString(text);
			Dictionary<Type, HashSet<string>> dictionary = ((JsonContext)_lockObject).CollectUnknownReferences();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S3_v4+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S3_v5+8]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S4_v5 (should have been resolved before IL gen)");
		}
	}

	public void SwapQueues()
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		object obj = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		obj = obj2;
		nint num = default;
		object obj3 = num + 12;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v9+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v8+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v9+4]");
		object obj8 = 0;
		object obj9 = obj8 & 0x3FFF;
		object obj10 = obj9 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v39 @ S2_v4 (should have been resolved before IL gen)");
		object obj11 = this + 12;
		object obj12 = default;
		obj11 = obj12;
		object obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v17+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v14+60]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v15+4]");
		object obj17 = 0;
		object obj18 = obj17 & 0x3FFF;
		object obj19 = obj18 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v62 @ S2_v8 (should have been resolved before IL gen)");
		object obj20 = this + 16;
		object obj21 = default;
		obj20 = obj21;
	}

	public void Enqueue(T item)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got VT
		object obj = this + 20;
		obj = item;
	}

	public T Dequeue()
	{
		//IL_006e: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00f9: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		int domainID = Thread.GetDomainID();
		if ((nint)_readThread == domainID)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v9+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v10+14]");
			object obj3 = 0;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S2_v10 (should have been resolved before IL gen)");
			T result = default;
			return result;
		}
		nint num = default;
		object obj6 = num + 12;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v10+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v2+60]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v3+10]");
		object obj11 = 0;
		object obj12 = obj11 & 0x3FFF;
		object obj13 = obj12 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50 @ S3_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return (T)null;
	}

	public unsafe bool TryDequeue(out T item)
	{
		//IL_0062: Expected Obj, but got I
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected I, but got Unknown
		//IL_00c6: Expected I, but got Obj
		//IL_00e1: Expected Obj, but got Ref
		//IL_00e5: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v22 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = obj;
		nint num3 = (nint)(obj3 + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Type type = Type.internal_from_handle((IntPtr)num3);
		return (byte)(int)JsonReflectionParser.ReadReference(type, this, (JsonContext)System.Runtime.CompilerServices.Unsafe.AsPointer(ref item)) != 0;
	}
}
