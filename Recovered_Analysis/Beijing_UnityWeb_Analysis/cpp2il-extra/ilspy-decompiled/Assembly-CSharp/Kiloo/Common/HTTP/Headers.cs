using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.LocalizationManager;
using Kiloo.Common.Performance;
using UnityEngine;

namespace Kiloo.Common.HTTP;

public class Headers : IEnumerable<KeyValuePair<string, string>>, IEnumerable
{
	private sealed class _003CGetEnumerator_003Ed__26 : IEnumerator<KeyValuePair<string, string>>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private KeyValuePair<string, string> _003C_003E2__current;

		public Headers _003C_003E4__this;

		private Dictionary<string, List<string>>.Enumerator _003C_003E7__wrap1;

		unsafe KeyValuePair<string, string> IEnumerator<KeyValuePair<string, string>>.Current
		{
			get
			{
				//IL_0005: Expected native int or pointer, but got VT
				KeyValuePair<string, string> keyValuePair = default;
				System.Runtime.CompilerServices.Unsafe.Write(&((KeyValuePair<string, string>*)(nint)keyValuePair)->key, this);
				return keyValuePair;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0300: Expected Obj, but got Unknown
				//IL_0309: Unknown result type (might be due to invalid IL or missing references)
				//IL_030e: Expected Obj, but got Unknown
				//IL_0317: Unknown result type (might be due to invalid IL or missing references)
				//IL_031c: Expected Obj, but got Unknown
				//IL_0325: Unknown result type (might be due to invalid IL or missing references)
				//IL_032a: Expected Obj, but got Unknown
				//IL_0333: Expected Obj, but got I4
				//IL_033c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0341: Expected Obj, but got Unknown
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Expected Obj, but got Unknown
				//IL_00da: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Expected Obj, but got Unknown
				//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c2: Expected Obj, but got Unknown
				//IL_03b7: Expected Obj, but got I4
				//IL_0169: Unknown result type (might be due to invalid IL or missing references)
				//IL_016e: Expected Obj, but got Unknown
				//IL_0237: Expected Obj, but got I4
				//IL_027b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0280: Expected Obj, but got Unknown
				object obj2 = default;
				object obj = obj2 + 80;
				object obj3 = obj2 + 56;
				object obj4 = obj2 + 16;
				object obj5 = obj2 + 8;
				object obj6 = obj2 + 40;
				obj6 = 0;
				object obj7 = obj2 + 48;
				obj7 = obj;
				_ = -1;
				Headers headers = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						goto IL_03b1;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj3 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
					_ = 0;
					object obj8 = this + 24;
					obj8 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
					_ = 0;
				}
				_003C_003E1__state = -3;
				object obj9 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj10 = default;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					object obj11 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				}
				else
				{
					object obj12 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj6 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					obj5 = obj2;
					obj3 = obj5;
					object obj13 = this + 12;
					obj13 = obj3;
					_003C_003E1__state = 1;
				}
				goto IL_03b1;
				IL_03b1:
				return 1;
			}
		}

		public _003CGetEnumerator_003Ed__26(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
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

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Expected Obj, but got I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected Obj, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_010c: Expected Obj, but got I4
			//IL_015b: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			object obj3 = _003C_003E1__state - -3;
			if (_003C_003E1__state != -3 && ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 == 3 || (nint)obj3 != 4))
			{
				return;
			}
			object obj4 = obj + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj + obj6;
			obj7 = 26;
			((IEnumerator)this).Reset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 == -1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj + obj8;
			if ((nint)obj9 == 26)
			{
				object obj10 = obj + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
			}
		}

		void IEnumerator.Reset()
		{
			_003C_003E1__state = -1;
		}
	}

	private readonly Dictionary<string, List<string>> _headers;

	private string _contentType;

	private ContentType _parsedContentType;

	private static readonly string[] _niceNameExceptions;

	// C# has no syntax for parameterized property 'Item'.
	public string get_Item(string name)
	{
		//IL_0025: Expected Obj, but got I4
		object result = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj = default;
		if (obj != null)
		{
			return (string)result;
		}
		return null;
	}

	public void set_Item(string name, string value)
	{
		//IL_000d: Expected VT, but got Obj
		GUILayout.BeginArea((Rect)name, value);
	}

	public int Count
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)_parsedContentType;
		}
	}

	public unsafe ContentType contentType
	{
		get
		{
			//IL_03cb: Expected I, but got Obj
			//IL_03e1: Expected Obj, but got I
			//IL_0566: Expected I, but got Obj
			//IL_057c: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0155: Expected I, but got Obj
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Expected Obj, but got Unknown
			//IL_038a: Expected I, but got Obj
			//IL_03a0: Expected Obj, but got I
			//IL_0084: Expected I, but got Obj
			//IL_0512: Unknown result type (might be due to invalid IL or missing references)
			//IL_0517: Expected Obj, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected Obj, but got Unknown
			//IL_032c: Expected Obj, but got I4
			//IL_00e4: Expected I, but got Obj
			//IL_044c: Expected I, but got Obj
			//IL_0462: Expected Obj, but got I
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_047f: Expected Obj, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected Obj, but got Unknown
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Expected Obj, but got Unknown
			//IL_02fb: Expected Obj, but got I4
			//IL_0304: Unknown result type (might be due to invalid IL or missing references)
			//IL_0309: Expected Obj, but got Unknown
			//IL_02b4: Expected I, but got Obj
			//IL_04bc: Expected I4, but got Obj
			//IL_0243: Expected I, but got Obj
			object obj2 = default;
			object obj6 = default;
			object obj14 = default;
			while (true)
			{
				nint num = (nint)typeof(Headers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.Headers>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Headers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v88 (Il2CppClass<Kiloo.Common.HTTP.Headers>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string[] niceNameExceptions = _niceNameExceptions;
				bool flag = (nint)obj2 < niceNameExceptions.Length;
				nint num3 = (nint)typeof(Headers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v8 (Il2CppClass<Kiloo.Common.HTTP.Headers>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				bool flag2 = obj3 == null;
				Headers headers;
				if (flag)
				{
					if (!flag2)
					{
						nint num4 = (nint)typeof(Headers);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v82 (Il2CppClass<Kiloo.Common.HTTP.Headers>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj4 = _niceNameExceptions + 16;
					object obj5 = obj2 << 2;
					object a = obj4 + obj5;
					if (!string.Equals((string)a, (string)(object)this, StringComparison.InvariantCultureIgnoreCase))
					{
						obj2 = obj6 + 1;
						continue;
					}
					nint num5 = (nint)typeof(Headers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v64 (Il2CppClass<Kiloo.Common.HTTP.Headers>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num6 = (nint)typeof(Headers);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v74 (Il2CppClass<Kiloo.Common.HTTP.Headers>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj8 = _niceNameExceptions + 16;
					object obj9 = obj2 << 2;
					object obj10 = obj8 + obj9;
					headers = (Headers)obj10;
					break;
				}
				if (!flag2)
				{
					nint num7 = (nint)typeof(Headers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v49 (Il2CppClass<Kiloo.Common.HTTP.Headers>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = NicifyName((string)(object)this);
				if (text != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				char[] array = null;
				while (true)
				{
					char[] array2 = array;
					Dictionary<string, List<string>> headers2 = _headers;
					if (System.Runtime.CompilerServices.Unsafe.As<char[], UIntPtr>(ref array2) >= System.Runtime.CompilerServices.Unsafe.As<Dictionary<string, List<string>>, UIntPtr>(ref headers2))
					{
						break;
					}
					bool flag3;
					if (array != null)
					{
						char[] separator = (char[])(array - 1);
						string[] array3 = ((string)this).Split(separator);
						object obj11 = array3 & 0xFFFF;
						flag3 = (nint)obj11 == 45;
					}
					else
					{
						flag3 = true;
					}
					string[] array4 = ((string)this).Split(array);
					nint num8 = (nint)typeof(char);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v35 (Il2CppClass<System.Char>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					bool flag4 = obj12 == null;
					object obj13 = obj14 + 16;
					object obj15 = (object)array << 1;
					object obj16 = obj13 + obj15;
					TypeCode typeCode;
					if (flag3)
					{
						if (!flag4)
						{
							nint num9 = (nint)typeof(char);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v42 (Il2CppClass<System.Char>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						char c = char.ToLower((char)(int)array4);
						typeCode = (TypeCode)c;
					}
					else
					{
						if (!flag4)
						{
							nint num10 = (nint)typeof(char);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v33 (Il2CppClass<System.Char>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						typeCode = ((char*)array4)->GetTypeCode();
					}
					obj16 = typeCode;
					char[] array5 = (char[])(array + 1);
					array = array5;
				}
				int hashCode = ((StringComparer)null).GetHashCode(obj14);
				headers = (Headers)hashCode;
				break;
			}
			return (ContentType)(object)this;
		}
	}

	public bool Contains(string name)
	{
		//IL_0018: Expected I4, but got Obj
		return (byte)(int)Set(name, "") != 0;
	}

	public void Clear()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}

	public void Remove(string name)
	{
		((LegalTextData)this).SyncLanguageKeys();
	}

	public Headers Add(KeyValuePair<string, string> header)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		bool flag = (nint)obj6 > -1;
		return (Headers)flag;
	}

	public Headers Add(string name, object value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected Obj, but got Unknown
		//IL_08fb: Expected Obj, but got I4
		//IL_0910: Expected Obj, but got I4
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected Obj, but got Unknown
		//IL_093a: Expected I, but got Obj
		//IL_0950: Expected Obj, but got I
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9e: Expected Obj, but got Unknown
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_09eb: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_0106: Expected Obj, but got I4
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I4
		//IL_0737: Expected Obj, but got I
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected Obj, but got Unknown
		//IL_085a: Expected I, but got Obj
		//IL_0870: Expected Obj, but got I
		//IL_0216: Expected Obj, but got I4
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected Obj, but got Unknown
		//IL_0236: Expected Obj, but got I4
		//IL_089b: Expected I, but got Obj
		//IL_0249: Expected I, but got Obj
		//IL_025f: Expected Obj, but got I
		//IL_028a: Expected I, but got Obj
		//IL_02d5: Expected Obj, but got I4
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected Obj, but got Unknown
		//IL_06c0: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		_ = 0;
		obj2 = 0;
		object obj4 = obj2 + 40;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(AndroidGPUCategorizer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v210 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = (string)(obj2 + 8);
		object obj6 = obj2 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC87");
		object obj7 = default;
		string text2;
		object obj18;
		string text5 = default;
		if (obj7 != null)
		{
			nint num3 = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(AndroidGPUCategorizer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v206 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			LegalTextData instance = LegalTextData.instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = text;
			_ = text.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v25 (System.String)+10]");
			_ = 0;
			text2 = string.Empty;
			object obj10 = default;
			object obj11 = default;
			object obj12 = default;
			object obj13 = default;
			string text4 = default;
			object obj9;
			string text3 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj9 = 38;
				bool flag = obj10 == null;
				obj9 = 39;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj9 = 16;
				obj2 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj9 = 17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj11 == null)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj9 = 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				text3 = text4;
				obj9 = 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				text3 = text4;
				obj9 = 33;
				nint num5 = (nint)typeof(AndroidGPUCategorizer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S0_v185 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num6 = (nint)typeof(AndroidGPUCategorizer);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v195 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						text3 = text4;
						obj9 = 33;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				text3 = text4;
				text2 = text4;
			}
			object obj15 = obj9 - 16;
			object obj19 = default;
			if ((nint)obj9 != 16 && (nint)obj15 != 1 && (nint)obj15 != 2)
			{
				if ((nint)obj15 == 3 || (nint)obj15 == 4 || (nint)obj15 == 5 || (nint)obj15 == 6 || (nint)obj15 == 7)
				{
					goto IL_0ad3;
				}
				if ((nint)obj15 != 8)
				{
					if ((nint)obj15 != 9)
					{
						if ((nint)obj15 != 10)
						{
							if ((nint)obj15 == 11 || (nint)obj15 == 12 || (nint)obj15 == 13 || (nint)obj15 == 14 || (nint)obj15 == 15)
							{
								goto IL_0ad3;
							}
							if ((nint)obj15 != 16)
							{
								object obj16;
								if ((nint)obj15 != 17)
								{
									if ((nint)obj15 != 18 && (nint)obj15 != 19 && (nint)obj15 != 20 && (nint)obj15 != 21)
									{
										if ((nint)obj15 == 22)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj17 = default;
											obj16 = obj17;
											obj18 = obj19;
											goto IL_0a04;
										}
										if ((nint)obj15 == 23)
										{
											object obj20 = obj4 + 4;
											object obj21 = obj20 + 1;
											obj20 = obj21;
											object obj22 = obj21 << 2;
											object obj23 = obj4 + obj22;
											obj23 = 119;
											text5 = text2;
										}
									}
									goto IL_0ad3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								text2 = text3;
								object obj24 = default;
								obj16 = obj24;
								obj18 = obj19;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj25 = default;
								object obj16 = obj25;
								obj18 = obj19;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj26 = default;
							object obj16 = obj26;
							obj18 = obj19;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj27 = default;
						object obj16 = obj27;
						obj18 = obj19;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj28 = default;
					object obj16 = obj28;
					obj18 = obj19;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj29 = default;
				object obj16 = obj29;
				obj18 = obj19;
			}
			goto IL_0a04;
		}
		Headers result = null;
		goto IL_0a53;
		IL_0ad3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
			object obj30 = (nint)0 << 2;
			object obj31 = obj4 + obj30;
			if ((nint)obj31 == 119)
			{
				object obj32 = obj4 + 4;
				if ((nint)obj32 > -1)
				{
					object obj33 = obj32 + -1;
					obj32 = obj33;
				}
				goto IL_0af8;
			}
		}
		object obj34 = default;
		if (obj34 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0af8;
		IL_0af8:
		if (text5 == null || text5.m_stringLength == 0)
		{
			bool flag2 = value == null;
			result = null;
			if (!flag2)
			{
				string graphicsDeviceVersion = SystemInfo.GetGraphicsDeviceVersion();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
				result = null;
			}
		}
		else
		{
			nint num7 = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S0_v64 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num8 = (nint)typeof(AndroidGPUCategorizer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v71 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7F26");
			obj6 = name;
			text = (string)obj6;
			LegalLanguage legalLanguage = default;
			string text6 = legalLanguage.get_Item(text);
			result = (Headers)(object)text6;
		}
		goto IL_0a53;
		IL_0a04:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj36 = default;
		if (obj18 == obj36)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			text5 = text2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0ad3;
		IL_0a53:
		return result;
	}

	public Headers AddAll(IEnumerable<KeyValuePair<string, string>> headers)
	{
		//IL_001b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [headers @ L1 (System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String, System.String>>)+4]");
		return (Headers)(object)Get((string)(object)headers, (string)0);
	}

	public string Get(string name)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00e0: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 57;
		object obj10 = default;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v7+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 57)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_02c9;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_02c9;
		IL_02c9:
		return (string)(object)this;
	}

	public unsafe string Get(string name, string defaultValue)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I4
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		ref List<string> reference = ref *(List<string>*)null;
		if (!_headers.TryGetValue(name, out reference))
		{
			nint num = (nint)typeof(Headers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v47 (Il2CppClass<Kiloo.Common.HTTP.Headers>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Headers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v60 (Il2CppClass<Kiloo.Common.HTTP.Headers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ContentType contentType = ((Headers)(object)name).contentType;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list = default;
			list._002Ector();
			reference = ref *(List<string>*)list;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S4_v4+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S4_v5+48]");
			object obj4 = 0;
			object obj5 = obj4 & 0x7FF;
			object obj6 = obj5 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S5_v5 (should have been resolved before IL gen)");
		}
		string text;
		if (defaultValue == null)
		{
			text = null;
		}
		else
		{
			text = (((object)defaultValue.GetType() != typeof(string)) ? null : defaultValue);
		}
		bool flag = text == null;
		bool flag2 = !flag;
		IResponse response = (IResponse)(object)text;
		if (!flag2)
		{
			IResponse response2 = HTTPFactory.CreateResponse(null, (byte[])(object)defaultValue);
			response = response2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num4 = default;
		object obj7 = num4 + 16;
		obj7 = 44;
		string text2 = ((string)(object)response).Substring(num4);
		object obj8 = text2 + 12;
		object obj9 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
		{
			object obj10 = text2 + 16;
			object obj11 = obj9 << 2;
			object str = obj10 + obj11;
			string item = string.Copy((string)str);
			reference.Add(item);
			object obj12 = obj9 + 1;
			obj9 = obj12;
		}
		return (string)(object)this;
	}

	public DateTime Get(string name, DateTime defaultValue, bool allowDeltaTimeSeconds = false)
	{
		//IL_0010: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return (DateTime)0;
	}

	public unsafe DateTime? Get(string name, DateTime? defaultValue, bool allowDeltaTimeSeconds = false)
	{
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got VT
		//IL_00a7: Invalid comparison between VT and I4
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_0230: Expected Obj, but got VT
		//IL_011a: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00eb: Expected Obj, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		ref string reference = ref *(string*)null;
		DateTime? dateTime = default;
		object obj = (Nullable)dateTime + 28;
		obj = "Unknown";
		bool flag = name == null || name.m_stringLength == 0;
		object obj2 = (flag ? 1 : 0) ^ 1;
		object obj3 = obj2 & 1;
		object obj4 = (Nullable)dateTime + 12;
		string text = ((string)this).ToLowerInvariant();
		obj4 = text;
		object obj5 = (Nullable)dateTime + 16;
		bool flag2 = name == null || name.m_stringLength == 0;
		string text2 = ((!flag2) ? name.ToUpperInvariant() : string.Empty);
		obj5 = text2;
		object obj6 = (Nullable)dateTime + 24;
		Locale locale = Locale.Parse((string)dateTime);
		obj6 = locale;
		DateTime? dateTime2 = default;
		if ((DateTime)dateTime2 == (DateTime)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		}
		object obj7 = (Nullable)dateTime + 20;
		DateTime? dateTime3 = default;
		obj7 = dateTime3;
		if (allowDeltaTimeSeconds)
		{
			object obj8 = (Nullable)dateTime + 28;
			obj8 = allowDeltaTimeSeconds;
		}
		else
		{
			X509Certificate2Collection x509Certificate2Collection = TrustedRoots.LoadTrusted();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v27 (System.Security.Cryptography.X509Certificates.X509Certificate2Collection)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (System.Nullable`1<System.DateTime>)+18]");
			if (((Dictionary<string, string>)num).TryGetValue((string)0, out reference))
			{
				object obj9 = (Nullable)dateTime + 28;
				obj9 = reference;
			}
		}
		return dateTime;
	}

	public long Get(string name, long defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_022d: Expected I4, but got Obj
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_0131: Expected I8, but got Obj
		//IL_00c8: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		object obj3 = ((List<object>)this).get_Item((int)name);
		object obj4;
		if (obj3 == null)
		{
			obj4 = null;
		}
		else
		{
			obj4 = (((object)obj3.GetType() != typeof(long)) ? null : obj3);
		}
		if (obj4 != null)
		{
			throw new NullReferenceException();
		}
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v23 (Il2CppClass<System.Convert>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v74 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
		object obj7 = default;
		object obj6 = obj7 << 32;
		object obj8 = default;
		long num3 = obj8 | obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj10 = default;
		object obj9 = obj10;
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj12 = default;
		if (obj11 == obj12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj14 = default;
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj16 = default;
			object obj15 = obj16;
		}
		else
		{
			object obj15 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		long result = default;
		return result;
	}

	public IEnumerable<string> GetAll(string name)
	{
		return (IEnumerable<string>)Set(name, "");
	}

	public unsafe Headers Set(string name, object value)
	{
		//IL_0068: Expected Obj, but got I4
		ref List<string> reference = ref *(List<string>*)null;
		int num = default;
		if (_headers.TryGetValue(name, out reference))
		{
			string[] strB = reference.ToArray();
			num = string.CompareOrdinalIgnoreCaseHelper(", ", (string)(object)strB);
		}
		return (Headers)num;
	}

	public unsafe Headers SetAll(IEnumerable<KeyValuePair<string, string>> headers)
	{
		if (_headers.TryGetValue((string)(object)headers, out *(List<string>*)null))
		{
			return (Headers)(object)_headers.get_Item((string)(object)headers);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Headers result = default;
		return result;
	}

	public Headers SetAll(string name, IEnumerable<string> values)
	{
		IResponse innerException = HTTPFactory.CreateResponse(null, (byte[])(object)values);
		((HTTPBackOffException)this)._002Ector(name, (Exception)innerException);
		return this;
	}

	public Headers SetAll(Dictionary<string, List<string>> headers)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0333: Expected Obj, but got I4
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_034a: Expected Obj, but got I4
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_0386: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S3_v3+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v57 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj11 = default;
		object obj12 = default;
		object obj13 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj11 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				obj4 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj14 = obj5 + 4;
		object obj15 = obj14 + 1;
		obj14 = obj15;
		object obj16 = obj15 << 2;
		object obj17 = obj5 + obj16;
		obj17 = 92;
		object obj18 = default;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v9+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v9+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj5 + obj19;
			if ((nint)obj20 == 92)
			{
				object obj21 = obj5 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_0435;
			}
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0435;
		IL_0435:
		object value = default;
		string text = ConvertValue(value);
		return this;
	}

	public void ReadFrom(BinaryReader reader)
	{
		bool flag = _headers.Remove((string)(object)reader);
	}

	public void WriteTo(BinaryWriter writer)
	{
		throw new IndexOutOfRangeException();
	}

	public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_020a: Expected Obj, but got I4
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00bf: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj6 = default;
		IEnumerator<KeyValuePair<string, string>> result = default;
		object obj7 = default;
		IEnumerator<KeyValuePair<string, string>> enumerator = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			result = (IEnumerator<KeyValuePair<string, string>>)(object)(obj7 + (object)enumerator);
		}
		object obj8 = obj5 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj5 + obj10;
		obj11 = 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj5 + obj12;
			if ((nint)obj13 == 64)
			{
				object obj14 = obj5 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_02e0;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_02e0;
		IL_02e0:
		return result;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		return enumerator;
	}

	private static bool IsNameNice(string name)
	{
		//IL_000d: Expected I4, but got Obj
		return (byte)(int)((Headers)(object)name).System_002ECollections_002EIEnumerable_002EGetEnumerator() != 0;
	}

	private unsafe static string NicifyName(string name)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_01a8: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0280: Expected Obj, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0131: Expected I, but got Obj
		//IL_01ef: Expected I4, but got Obj
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_00b1: Expected I, but got Obj
		char[] array = null;
		while (true)
		{
			if ((nint)array >= name.m_stringLength)
			{
				return (string)1;
			}
			bool flag;
			if (array != null)
			{
				char[] separator = (char[])(array - 1);
				string[] array2 = name.Split(separator);
				object obj = array2 & 0xFFFF;
				flag = (nint)obj == 45;
			}
			else
			{
				flag = true;
			}
			string[] array3 = name.Split(array);
			nint num = (nint)typeof(char);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v9 (Il2CppClass<System.Char>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag2 = obj2 == null;
			if (flag)
			{
				if (!flag2)
				{
					nint num2 = (nint)typeof(char);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v38 (Il2CppClass<System.Char>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				char c = char.ToLower((char)(int)array3);
				int num3 = c & 0xFFFF;
				string[] array4 = name.Split(array);
				object obj3 = array4 & 0xFFFF;
				if (num3 != (nint)obj3)
				{
					return null;
				}
			}
			else
			{
				if (!flag2)
				{
					nint num4 = (nint)typeof(char);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v26 (Il2CppClass<System.Char>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				TypeCode typeCode = ((char*)array3)->GetTypeCode();
				object obj4 = typeCode & (TypeCode)0xFFFF;
				string[] array5 = name.Split(array);
				object obj5 = array5 & 0xFFFF;
				if (obj4 != obj5)
				{
					break;
				}
			}
			char[] array6 = (char[])(array + 1);
			array = array6;
		}
		return null;
	}

	private string ConvertValue(object value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0208: Expected Obj, but got I4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_022b: Expected Obj, but got I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00e0: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		}
		object obj7 = obj5 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj5 + obj9;
		obj10 = 63;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj5 + obj11;
			if ((nint)obj12 == 63)
			{
				object obj13 = obj5 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_02e2;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_02e2;
		IL_02e2:
		return (string)(object)this;
	}

	public override string ToString()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0151: Expected Obj, but got I4
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected Obj, but got Unknown
		//IL_0401: Expected Obj, but got I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got I4
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0191: Expected I, but got Obj
		//IL_01a7: Expected Obj, but got I
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_036a: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_02e0: Expected Obj, but got I
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_04a8: Expected I4, but got Obj
		//IL_03a3: Expected Obj, but got I
		//IL_03b3: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_01d2: Expected I, but got Obj
		bool flag = Contains("Content-Type");
		if (_contentType.get_Chars(flag ? 1 : 0) != '\0')
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num = default;
			object obj = num + 16;
			obj = 59;
			string text = ((string)flag).Substring(num);
			object obj2 = text + 16;
			string text2 = ((string)obj2).ToUpper();
			int num2 = text2.IndexOfAny((char[])47);
			string method;
			string uri;
			if (num2 < 1)
			{
				object str = text + 16;
				string text3 = string.Copy((string)str);
				string text4 = text3.ToLowerInvariant();
				method = text4;
				uri = "";
			}
			else
			{
				string str2 = text2.InternalSubString(0, num2);
				string text5 = string.Copy(str2);
				char[] trimChars = (char[])(num2 + 1);
				string str3 = text2.Trim(trimChars);
				uri = string.Copy(str3);
				method = text5;
			}
			object obj3 = text + 12;
			object obj4 = 1;
			byte[] array = null;
			Dictionary<string, string> dictionary = default;
			IEqualityComparer<string> comparer = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				if (array == null)
				{
					nint num3 = (nint)typeof(StringComparer);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v61 (Il2CppClass<System.StringComparer>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num4 = (nint)typeof(StringComparer);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v70 (Il2CppClass<System.StringComparer>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4FA");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					dictionary._002Ector((int)obj3, comparer);
					array = (byte[])(object)dictionary;
				}
				object obj6 = text + 16;
				object obj7 = obj4 << 2;
				object obj8 = obj6 + obj7;
				int num5 = ((string)obj8).IndexOfAny((char[])61);
				object obj9 = text + 16;
				object obj10 = obj4 << 2;
				object obj11 = obj9 + obj10;
				if (num5 < 0)
				{
					string text6 = string.Copy((string)obj11);
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S4_v15 (Il2CppMethodInfo)+C]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S4_v16+60]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S4_v17+48]");
					object obj14 = 0;
					object obj15 = obj14 & 0x7FF;
					object obj16 = obj15 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v248 @ S5_v11 (should have been resolved before IL gen)");
				}
				else
				{
					string str4 = ((string)obj11).InternalSubString(0, num5);
					string text7 = string.Copy(str4);
					object obj17 = text + 16;
					object obj18 = obj4 << 2;
					object obj19 = obj17 + obj18;
					char[] trimChars2 = (char[])(num5 + 1);
					string str5 = ((string)obj19).Trim(trimChars2);
					string text8 = string.Copy(str5);
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S4_v10 (Il2CppMethodInfo)+C]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S4_v11+60]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S4_v12+48]");
					object obj22 = 0;
					object obj23 = obj22 & 0x7FF;
					object obj24 = obj23 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v253 @ S5_v7 (should have been resolved before IL gen)");
				}
				object obj25 = obj4 + 1;
				obj4 = obj25;
			}
			object obj26 = this + 12;
			obj26 = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Request request = default;
			request._002Ector(method, (Uri)(object)uri, array);
			object obj27 = this + 16;
			obj27 = request;
		}
		return (string)(object)_parsedContentType;
	}

	public Dictionary<string, List<string>> GetInternalDictionary()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02e3: Expected Obj, but got I4
		//IL_019c: Expected Obj, but got I
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_00e0: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder sb = default;
		System.Text.StringBuilderCache.Release(sb);
		IEnumerator enumerator = System_002ECollections_002EIEnumerable_002EGetEnumerator();
		object obj5 = 1;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj3 = obj2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj5 = 0;
		}
		object obj7 = obj4 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj4 + obj9;
		obj10 = 96;
		if (enumerator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 96)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_0319;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0319;
		IL_0319:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Dictionary<string, List<string>> result = default;
		return result;
	}

	public Headers()
	{
		throw new IndexOutOfRangeException();
	}

	static Headers()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(AndroidGPUCategorizer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v9 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+5C]");
		object obj6 = (nint)0 + (nint)12;
		object obj7 = default;
		obj6 = obj7;
		AndroidGPUCategorizer._isInitialized = false;
	}
}
