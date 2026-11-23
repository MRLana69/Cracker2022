using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace SYBO.Components.Utilities;

public static class FileUtility
{
	private sealed class _003CGetFiles_003Ed__0 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string directoryPath;

		public string _003C_003E3__directoryPath;

		private string fileSearchPattern;

		public string _003C_003E3__fileSearchPattern;

		private Queue<string> _003Cqueue_003E5__2;

		private string[] _003Cfiles_003E5__3;

		private int _003Ci_003E5__4;

		string IEnumerator<string>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		public _003CGetFiles_003Ed__0(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			_003C_003El__initialThreadId = currentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0863: Unknown result type (might be due to invalid IL or missing references)
			//IL_0868: Expected Obj, but got Unknown
			//IL_00ec: Expected Obj, but got I4
			//IL_00dc: Expected Obj, but got I4
			//IL_017b: Expected Obj, but got I4
			//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0801: Expected Obj, but got Unknown
			//IL_0813: Expected Obj, but got I
			//IL_08af: Expected Obj, but got I4
			//IL_01c2: Expected Obj, but got I4
			//IL_08d1: Expected Obj, but got I4
			//IL_01ef: Expected Obj, but got I4
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected Obj, but got Unknown
			//IL_04e5: Expected Obj, but got I
			//IL_02f2: Expected Obj, but got I4
			//IL_07e1: Expected Obj, but got I4
			//IL_0457: Expected Obj, but got I4
			//IL_079e: Expected Obj, but got I
			//IL_05ab: Expected Obj, but got I4
			//IL_0350: Expected Obj, but got I
			//IL_037b: Expected Obj, but got I
			//IL_03a0: Expected Obj, but got I
			//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bb: Expected Obj, but got Unknown
			//IL_0713: Expected Obj, but got I4
			//IL_060a: Expected Obj, but got I
			//IL_0635: Expected Obj, but got I
			//IL_065a: Expected Obj, but got I
			//IL_0670: Unknown result type (might be due to invalid IL or missing references)
			//IL_0675: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			object obj3 = obj + 8;
			_ = 0;
			bool result;
			string[] array = default;
			int num2 = default;
			object obj4;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					result = false;
					goto IL_088d;
				}
				_003C_003E1__state = -1;
				int num = ++_003Ci_003E5__4;
				array = _003Cfiles_003E5__3;
				num2 = num;
				obj4 = 0;
			}
			else
			{
				_003C_003E1__state = -1;
				nint num3 = 0;
				nint num4 = 0;
				IntPtr intPtr = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S2_v37 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Queue`1<System.String>>>)+4] (should have been resolved before IL gen)");
				Queue<string> queue = default;
				string[] array2 = default;
				queue._array = array2;
				_003Cqueue_003E5__2 = queue;
				_003Cqueue_003E5__2.Enqueue(directoryPath);
				obj4 = 1;
			}
			object obj5 = obj4;
			object obj10 = default;
			object obj11 = default;
			string[] array3 = default;
			string item = default;
			object obj12 = default;
			object obj15 = default;
			bool flag3 = default;
			string[] array4 = default;
			string[] array5 = default;
			object obj21 = default;
			object obj22 = default;
			string[] array6 = default;
			string item3 = default;
			object obj23 = default;
			object obj26 = default;
			string[] array7 = default;
			while (true)
			{
				if (obj5 == null)
				{
					if (num2 < array.Length)
					{
						int num5 = num2 << 2;
						object obj6 = array + num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v119+10]");
						_003C_003E2__current = (string)0;
						_003C_003E1__state = 1;
						result = true;
						break;
					}
				}
				else
				{
					Queue<string> queue2 = _003Cqueue_003E5__2;
					bool flag = queue2._size <= 0;
					result = false;
					if (flag)
					{
						break;
					}
					string text = _003Cqueue_003E5__2.Dequeue();
					directoryPath = text;
					_ = 0;
					((Queue<string>)7321).Enqueue(directoryPath);
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_0253;
					}
					object obj7 = 0;
					while (true)
					{
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v31+C]");
						if ((nint)obj8 >= 0)
						{
							break;
						}
						_ = 0;
						((Queue<string>)7322).Enqueue((string)(object)_003Cqueue_003E5__2);
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj9 = obj7 + 1;
							obj7 = obj9;
							continue;
						}
						goto IL_0243;
					}
					_003Cfiles_003E5__3 = null;
					_ = 0;
					((Queue<string>)7323).Enqueue(directoryPath);
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
						bool flag2 = obj10 != obj11;
						array = array3;
						if (!flag2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								((Queue<string>)1137).Enqueue(item);
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj12 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
										object obj13 = (nint)0 << 2;
										object obj14 = obj3 + obj13;
										obj14 = obj15;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
										object obj16 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
										object obj17 = (nint)0 << 2;
										object obj18 = obj17 + obj3;
										object obj19 = obj18 - 4;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
										throw new ArrayTypeMismatchException();
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
									string item2 = (string)obj15;
									_ = 0;
									((Queue<string>)1138).Enqueue(item2);
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									flag3 = (nint)0 != 1;
									if (flag3)
									{
										goto IL_0854;
									}
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag4 = (nint)0 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							_003CGetFiles_003Ed__0 obj20 = (_003CGetFiles_003Ed__0)0;
							array = array4;
							if (flag4)
							{
								goto IL_082c;
							}
						}
						goto IL_07b4;
					}
					_003Cfiles_003E5__3 = array5;
					bool flag5 = _003Cfiles_003E5__3 == null;
					array = _003Cfiles_003E5__3;
					if (!flag5)
					{
						_003Ci_003E5__4 = 0;
						array = _003Cfiles_003E5__3;
						num2 = 0;
						obj5 = 0;
						continue;
					}
				}
				goto IL_089f;
				IL_0243:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_0253;
				IL_0854:
				return flag3;
				IL_082c:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				goto IL_0854;
				IL_0253:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag6 = obj21 != obj22;
				array = array6;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						((Queue<string>)1137).Enqueue(item3);
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj23 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
								object obj24 = (nint)0 << 2;
								object obj25 = obj3 + obj24;
								obj25 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
								object obj27 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
								object obj28 = (nint)0 << 2;
								object obj29 = obj28 + obj3;
								object obj30 = obj29 - 4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
								throw new ArrayTypeMismatchException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							string item4 = (string)obj26;
							_ = 0;
							((Queue<string>)1138).Enqueue(item4);
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							flag3 = (nint)0 != 1;
							if (flag3)
							{
								goto IL_0854;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag7 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					_003CGetFiles_003Ed__0 obj20 = (_003CGetFiles_003Ed__0)0;
					array = array7;
					if (!flag7)
					{
						goto IL_082c;
					}
				}
				goto IL_07b4;
				IL_07b4:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				goto IL_089f;
				IL_089f:
				_003Cfiles_003E5__3 = null;
				obj5 = 1;
			}
			goto IL_088d;
			IL_088d:
			return result;
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

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			_003CGetFiles_003Ed__0 obj;
			if (_003C_003E1__state == -2)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (_003C_003El__initialThreadId == currentManagedThreadId)
				{
					_003C_003E1__state = 0;
					obj = this;
					goto IL_005f;
				}
			}
			_003CGetFiles_003Ed__0 obj2 = default;
			obj2._002Ector(0);
			obj = obj2;
			goto IL_005f;
			IL_005f:
			obj.directoryPath = _003C_003E3__directoryPath;
			obj.fileSearchPattern = _003C_003E3__fileSearchPattern;
			return obj;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}
	}

	public static IEnumerable<string> GetFiles(string directoryPath, string fileSearchPattern)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40F");
		IEnumerable<string> result = default;
		return result;
	}
}
