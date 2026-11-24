using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Kiloo.Common.Utility;

public class ActionQueue
{
	private readonly LinkedList<Action<Action>> actionQueue;

	private bool _running;

	public int Count
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0d3c: Expected Obj, but got I4
			//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d4a: Expected Obj, but got Unknown
			//IL_0757: Unknown result type (might be due to invalid IL or missing references)
			//IL_075c: Expected Obj, but got Unknown
			//IL_0765: Unknown result type (might be due to invalid IL or missing references)
			//IL_076a: Expected Obj, but got Unknown
			//IL_0796: Expected Obj, but got I4
			//IL_079f: Expected Obj, but got I4
			//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aaf: Expected Obj, but got Unknown
			//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0abd: Expected Obj, but got Unknown
			//IL_0ae9: Expected Obj, but got I4
			//IL_0af2: Expected Obj, but got I4
			//IL_0894: Expected Obj, but got I
			//IL_0be7: Expected Obj, but got I
			//IL_0928: Expected Obj, but got I
			//IL_0701: Unknown result type (might be due to invalid IL or missing references)
			//IL_0706: Expected Obj, but got Unknown
			//IL_070f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0714: Expected Obj, but got Unknown
			//IL_0740: Expected Obj, but got I4
			//IL_0749: Expected Obj, but got I4
			//IL_0c7b: Expected Obj, but got I
			//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_08cf: Expected Obj, but got Unknown
			//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c22: Expected Obj, but got Unknown
			//IL_095e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0963: Expected Obj, but got Unknown
			//IL_0cb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb6: Expected Obj, but got Unknown
			//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a59: Expected Obj, but got Unknown
			//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a67: Expected Obj, but got Unknown
			//IL_0a93: Expected Obj, but got I4
			//IL_0a9c: Expected Obj, but got I4
			//IL_0900: Unknown result type (might be due to invalid IL or missing references)
			//IL_0905: Expected Obj, but got Unknown
			//IL_0c53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c58: Expected Obj, but got Unknown
			//IL_0994: Unknown result type (might be due to invalid IL or missing references)
			//IL_0999: Expected Obj, but got Unknown
			//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cec: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = 0;
			object obj3 = obj2 + 8;
			obj3 = obj;
			_ = -1;
			if (this == null)
			{
				return 1;
			}
			ActionQueue actionQueue;
			if (this == null)
			{
				actionQueue = null;
			}
			else
			{
				actionQueue = (((object)GetType() != typeof(string)) ? null : this);
			}
			if (actionQueue != null)
			{
				return 1;
			}
			ActionQueue actionQueue2;
			if (this == null)
			{
				actionQueue2 = null;
			}
			else
			{
				actionQueue2 = (((object)GetType() != typeof(char)) ? null : this);
			}
			if (actionQueue2 != null)
			{
				return 1;
			}
			ActionQueue actionQueue3;
			if (this == null)
			{
				actionQueue3 = null;
			}
			else
			{
				actionQueue3 = (((object)GetType() != typeof(bool)) ? null : this);
			}
			if (actionQueue3 != null)
			{
				return 1;
			}
			ActionQueue actionQueue4;
			if (this == null)
			{
				actionQueue4 = null;
			}
			else
			{
				actionQueue4 = (((object)GetType() != typeof(float)) ? null : this);
			}
			if (actionQueue4 != null)
			{
				return 1;
			}
			ActionQueue actionQueue5;
			if (this == null)
			{
				actionQueue5 = null;
			}
			else
			{
				actionQueue5 = (((object)GetType() != typeof(int)) ? null : this);
			}
			if (actionQueue5 != null)
			{
				return 1;
			}
			ActionQueue actionQueue6;
			if (this == null)
			{
				actionQueue6 = null;
			}
			else
			{
				actionQueue6 = (((object)GetType() != typeof(uint)) ? null : this);
			}
			if (actionQueue6 != null)
			{
				return 1;
			}
			ActionQueue actionQueue7;
			if (this == null)
			{
				actionQueue7 = null;
			}
			else
			{
				actionQueue7 = (((object)GetType() != typeof(long)) ? null : this);
			}
			if (actionQueue7 != null)
			{
				return 1;
			}
			ActionQueue actionQueue8;
			if (this == null)
			{
				actionQueue8 = null;
			}
			else
			{
				actionQueue8 = (((object)GetType() != typeof(double)) ? null : this);
			}
			if (actionQueue8 != null)
			{
				return 1;
			}
			ActionQueue actionQueue9;
			if (this == null)
			{
				actionQueue9 = null;
			}
			else
			{
				actionQueue9 = (((object)GetType() != typeof(sbyte)) ? null : this);
			}
			if (actionQueue9 != null)
			{
				return 1;
			}
			ActionQueue actionQueue10;
			if (this == null)
			{
				actionQueue10 = null;
			}
			else
			{
				actionQueue10 = (((object)GetType() != typeof(byte)) ? null : this);
			}
			if (actionQueue10 != null)
			{
				return 1;
			}
			ActionQueue actionQueue11;
			if (this == null)
			{
				actionQueue11 = null;
			}
			else
			{
				actionQueue11 = (((object)GetType() != typeof(short)) ? null : this);
			}
			if (actionQueue11 != null)
			{
				return 1;
			}
			ActionQueue actionQueue12;
			if (this == null)
			{
				actionQueue12 = null;
			}
			else
			{
				actionQueue12 = (((object)GetType() != typeof(ushort)) ? null : this);
			}
			if (actionQueue12 != null)
			{
				return 1;
			}
			ActionQueue actionQueue13;
			if (this == null)
			{
				actionQueue13 = null;
			}
			else
			{
				actionQueue13 = (((object)GetType() != typeof(ulong)) ? null : this);
			}
			if (actionQueue13 != null)
			{
				return 1;
			}
			ActionQueue actionQueue14;
			if (this == null)
			{
				actionQueue14 = null;
			}
			else
			{
				actionQueue14 = (((object)GetType() != typeof(decimal)) ? null : this);
			}
			if (actionQueue14 != null)
			{
				return 1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj4 = default;
			object obj11;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj5 = default;
				object obj6 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj5 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj6 == null)
						{
							object obj7 = obj3 + 4;
							object obj8 = obj7 + 1;
							obj7 = obj8;
							object obj9 = obj8 << 2;
							object obj10 = obj3 + obj9;
							obj10 = 273;
							obj11 = 0;
							break;
						}
						continue;
					}
					object obj12 = obj3 + 4;
					object obj13 = obj12 + 1;
					obj12 = obj13;
					object obj14 = obj13 << 2;
					object obj15 = obj3 + obj14;
					obj15 = 183;
					obj11 = 0;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				object obj16 = default;
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
					object obj17 = (nint)0 << 2;
					object obj18 = obj3 + obj17;
					if ((nint)obj18 == 273)
					{
						object obj19 = obj3 + 4;
						if ((nint)obj19 > -1)
						{
							object obj20 = obj19 + -1;
							obj19 = obj20;
						}
						goto IL_0e17;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
					object obj21 = (nint)0 << 2;
					object obj22 = obj3 + obj21;
					if ((nint)obj22 == 183)
					{
						object obj23 = obj3 + 4;
						if ((nint)obj23 > -1)
						{
							object obj24 = obj23 + -1;
							obj23 = obj24;
						}
						return 1;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				object obj25 = default;
				if (obj25 == null)
				{
					goto IL_0e17;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj26 = default;
				object obj27 = default;
				object obj28 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj26 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						obj2 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj28 == null)
						{
							object obj29 = obj3 + 4;
							object obj30 = obj29 + 1;
							obj29 = obj30;
							object obj31 = obj30 << 2;
							object obj32 = obj3 + obj31;
							obj32 = 273;
							obj11 = 0;
							break;
						}
						continue;
					}
					object obj33 = obj3 + 4;
					object obj34 = obj33 + 1;
					obj33 = obj34;
					object obj35 = obj34 << 2;
					object obj36 = obj3 + obj35;
					obj36 = 269;
					obj11 = 0;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				object obj37 = default;
				if (obj37 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
					object obj38 = (nint)0 << 2;
					object obj39 = obj3 + obj38;
					if ((nint)obj39 == 273)
					{
						object obj40 = obj3 + 4;
						if ((nint)obj40 > -1)
						{
							object obj41 = obj40 + -1;
							obj40 = obj41;
						}
						goto IL_0e17;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
					object obj42 = (nint)0 << 2;
					object obj43 = obj3 + obj42;
					if ((nint)obj43 == 269)
					{
						object obj44 = obj3 + 4;
						if ((nint)obj44 > -1)
						{
							object obj45 = obj44 + -1;
							obj44 = obj45;
						}
						return 1;
					}
				}
			}
			if (obj11 == null)
			{
				return 1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			goto IL_0e17;
			IL_0e17:
			int result = default;
			return result;
		}
	}

	public void AddAction(Action<Action> action)
	{
		//IL_001a: Expected I4, but got Obj
		//IL_001a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.ActionQueue)+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.ActionQueue)+10]");
			((Action<bool>)0)((byte)(int)action != 0);
		}
	}

	public void AddAllActionsFromQueue(ActionQueue queue)
	{
		LinkedListNode<Action<Action>> linkedListNode = actionQueue.AddLast((Action<Action>)(object)queue);
	}

	public void Clear()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void AddAndRunSequentially(Action<Action> action)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 32;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @85EF");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 54)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				return;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void RunSequentially(Action callback = null)
	{
		AddAllActionsFromQueue((ActionQueue)(object)callback);
		RunParallel();
	}

	public void RunParallel(Action callback = null)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = callback;
		if (~(_running ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj5 = default;
			object obj4 = obj5 + 16;
			obj4 = obj2;
			_running = true;
			object obj6 = obj5 + 12;
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj8 = default;
			object obj7 = obj8 + 16;
			obj7 = obj5;
			object obj9 = obj5 + 12;
			obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public ActionQueue()
	{
		actionQueue.Clear();
		_running = false;
	}
}
