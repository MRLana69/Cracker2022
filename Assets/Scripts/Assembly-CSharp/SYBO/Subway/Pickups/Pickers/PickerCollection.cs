using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace SYBO.Subway.Pickups.Pickers;

public class PickerCollection
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<IPicker> _003C_003E9__10_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal int _003CUpdatePickers_003Eb__10_0(IPicker a, IPicker b)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj3 = default;
			if ((nint)obj3 <= 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				return ((nint)obj3 < 0) ? 1 : 0;
			}
			return -1;
		}
	}

	private List<IPicker> _iPickerList;

	private PickupManager _pickupManager;

	private Action<PickerRemoveRequestEventArgs> m_OnPickerRemoveRequest;

	public event Action<PickerRemoveRequestEventArgs> OnPickerRemoveRequest
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_OnPickerRemoveRequest;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_OnPickerRemoveRequest;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public PickerCollection(PickupManager pickupManager)
	{
		_pickupManager = pickupManager;
		List<IPicker> list = default;
		list._002Ector();
		_iPickerList = list;
	}

	public void Add(IPicker iPicker)
	{
		if (!_iPickerList.Contains(iPicker))
		{
			_iPickerList.Add(iPicker);
			throw new ArgumentException();
		}
	}

	public bool HasPickerOfType<T>()
	{
		//IL_0036: Expected VT, but got I
		bool flag;
		int num = default;
		object obj = default;
		int num3 = default;
		while (true)
		{
			List<IPicker> iPickerList = _iPickerList;
			flag = num < iPickerList._size;
			if (!flag)
			{
				break;
			}
			IPicker picker = _iPickerList.get_Item(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			nint num2 = 0;
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num2);
			if (typeFromHandle == obj)
			{
				break;
			}
			num = num3 + 1;
		}
		return flag;
	}

	public IPicker GetItemAtIndex(int i)
	{
		return _iPickerList.get_Item(i);
	}

	public void Remove(IPicker iPicker)
	{
		if (_iPickerList.Remove(iPicker))
		{
			throw new ArgumentException();
		}
	}

	public void UpdatePickers()
	{
		bool flag = _003C_003Ec._003C_003E9__10_0 == null;
		bool flag2 = !flag;
		Comparison<IPicker> comparison = _003C_003Ec._003C_003E9__10_0;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		_iPickerList.Sort(comparison);
		List<IPicker> iPickerList = _iPickerList;
		int num = iPickerList._size;
		object obj = default;
		do
		{
			int num2 = num - 1;
			if (num2 >= 0)
			{
				IPicker picker = _iPickerList.get_Item(num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				num = num2;
				continue;
			}
			break;
		}
		while (obj != null);
	}

	private void IPicker_OnRemoveRequest(PickerRemoveRequestEventArgs pickerRemoveRequestEvent)
	{
		Action<PickerRemoveRequestEventArgs> onPickerRemoveRequest = this.m_OnPickerRemoveRequest;
		if (this.m_OnPickerRemoveRequest != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<SYBO.Subway.Pickups.Pickers.PickerRemoveRequestEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}
}
