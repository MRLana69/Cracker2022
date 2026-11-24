using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Kiloo.Common.UI;

namespace Kiloo.Common.Ads;

public class PriorityList
{
	private int _numberOfFails;

	private int _numberOfImpressions;

	private int _currentPriority;

	private DateTime _timeOfProviderChange;

	private readonly List<string> _exhaustedProviders;

	private IList<AdProviderInfo> _priorityList;

	private IAdSettingsProvider _settings;

	private AdType _adType;

	private string _waterfallID;

	private string currentProvider__BackingField;

	private Action m_changedProvider;

	private Action m_resetToTop;

	public unsafe string currentProvider
	{
		get
		{
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected Obj, but got Unknown
			//IL_00fe: Expected Obj, but got I4
			//IL_010c: Expected I, but got Obj
			//IL_0122: Expected Obj, but got I
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Expected Obj, but got Unknown
			//IL_0163: Expected Obj, but got I8
			//IL_016c: Expected Obj, but got VT
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Expected VT, but got Unknown
			//IL_0187: Expected I8, but got Obj
			//IL_0182: Expected native int or pointer, but got VT
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Expected Obj, but got Unknown
			//IL_01aa: Expected Ref, but got VT
			//IL_01b6: Expected Obj, but got I8
			//IL_0013: Expected I, but got Obj
			//IL_005b: Expected Obj, but got I4
			//IL_00e2: Expected Obj, but got F8
			//IL_0098: Expected Obj, but got I4
			//IL_00d5: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 16;
			obj = 0;
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<System.DateTime>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v42 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
			object obj4 = obj2 + 8;
			obj4 = systemTimeAsFileTime;
			obj2 = DateTime.MinValue;
			DateTime dateTime = (DateTime)(obj2 + 24);
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
			IFormatProvider formatProvider = (IFormatProvider)(obj2 + 32);
			formatProvider = (IFormatProvider)obj2;
			long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
			obj = num3;
			double num4 = (double)obj * 1.1574074074074074E-12;
			if (num4 != num4)
			{
				return (string)int.MinValue;
			}
			if (!(num4 < 2147483648.0))
			{
				return (string)int.MinValue;
			}
			if (!(num4 > -2147483649.0))
			{
				return (string)int.MinValue;
			}
			return (string)num4;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			DateTime timeOfProviderChange = (DateTime)(value & 1);
			_timeOfProviderChange = timeOfProviderChange;
		}
	}

	public bool wrapped
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)currentProvider__BackingField != 0;
		}
		set
		{
			//IL_0066: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_resetToTop;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 60;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public bool hasProviders
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this - -64;
			return obj != null;
		}
	}

	private int maxPriorityInList
	{
		get
		{
			if (_priorityList != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj = default;
				return ((nint)obj > 0) ? 1 : 0;
			}
			return 0;
		}
	}

	public bool reachedLastProvider
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Expected Obj, but got Unknown
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Expected Obj, but got Unknown
			//IL_024a: Expected Obj, but got I4
			//IL_0132: Expected Obj, but got I
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected Obj, but got Unknown
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			bool flag = false;
			object obj3 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj3 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v68+C]");
				if ((nint)0 > (nint)(flag ? 1 : 0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v68+C]");
					flag = false;
				}
			}
			object obj4 = obj2 + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj2 + obj6;
			obj7 = 63;
			object obj8 = default;
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj9 = (nint)0 << 2;
				object obj10 = obj2 + obj9;
				if ((nint)obj10 == 63)
				{
					object obj11 = obj2 + 4;
					if ((nint)obj11 > -1)
					{
						object obj12 = obj11 + -1;
						obj11 = obj12;
					}
					goto IL_0280;
				}
			}
			object obj13 = default;
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0280;
			IL_0280:
			return flag;
		}
	}

	public event Action changedProvider
	{
		add
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 52;
			obj = value;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_changedProvider;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 56;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event Action resetToTop
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_changedProvider;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 56;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_resetToTop;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 60;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public PriorityList(string waterfallID, AdType adType, IAdSettingsProvider settings)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		object obj = this + 8;
		obj = waterfallID;
		_numberOfImpressions = (int)adType;
		int currentPriority = settings & 1;
		_currentPriority = currentPriority;
	}

	public bool IncrementNumberOfFails()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 12;
		obj = this;
		bool flag = reachedLastProvider;
		int currentPriority = _currentPriority;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		if ((nint)currentPriority < (nint)0)
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Func<AdProviderInfo, bool> func = default;
		object obj3 = func + 16;
		obj3 = obj2;
		int num2 = Enumerable.Count(_priorityList, func);
		return num2 == 0;
	}

	public void IncrementNumberOfImpressions()
	{
		//IL_003f: Invalid comparison between VT and I4
		//IL_0069: Expected VT, but got I4
		int numberOfFails = _numberOfFails + 1;
		_numberOfFails = numberOfFails;
		int currentPriority = _currentPriority + 1;
		_currentPriority = currentPriority;
		if (_timeOfProviderChange == (DateTime)(object)0)
		{
			_timeOfProviderChange = (DateTime)1;
		}
	}

	public void CheckIfProviderExpired()
	{
		int numberOfImpressions = _numberOfImpressions + 1;
		_numberOfImpressions = numberOfImpressions;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj = default;
		if (_numberOfImpressions >= (nint)obj)
		{
			ResetToTop();
		}
	}

	private unsafe void MarkCurrentProviderAsExhausted()
	{
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected VT, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected VT, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected VT, but got Unknown
		//IL_04ae: Expected VT, but got I4
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected Obj, but got Unknown
		//IL_04cb: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I8
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_0583: Expected VT, but got Obj
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_051c: Expected VT, but got I4
		//IL_052b: Expected Obj, but got VT
		//IL_0538: Expected I8, but got Obj
		//IL_0533: Expected native int or pointer, but got VT
		//IL_0540: Expected native int or pointer, but got VT
		//IL_054d: Expected Obj, but got VT
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_05c7: Expected Ref, but got VT
		//IL_05d3: Expected Obj, but got VT
		//IL_05e0: Expected I8, but got Obj
		//IL_05db: Expected native int or pointer, but got VT
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got I8
		//IL_0189: Expected VT, but got Obj
		//IL_0196: Expected I8, but got Obj
		//IL_0191: Expected native int or pointer, but got VT
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_0132: Expected I, but got Obj
		//IL_0256: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_02aa: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I
		//IL_02ca: Expected Obj, but got I
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_0306: Expected Obj, but got I
		//IL_0316: Expected Obj, but got I
		//IL_0326: Expected Obj, but got I
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		object obj = default;
		TimeSpan timeSpan = (TimeSpan)(obj + 80);
		TimeSpan? timeSpan2 = (TimeSpan?)(object)(obj - -64);
		object obj2 = obj + 40;
		TimeSpan? timeSpan3 = (TimeSpan?)(object)(obj + 48);
		timeSpan3 = (TimeSpan?)(object)0;
		_ = 0;
		object obj3 = obj + 16;
		obj3 = 0;
		_ = 0;
		string text = currentProvider__BackingField;
		if (currentProvider__BackingField == null || text.m_stringLength == 0)
		{
			nint num = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v94 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v110 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			timeSpan2 = (TimeSpan?)(object)0;
			_ = 0;
			obj2 = TimeSpan.Zero;
			((TimeSpan*)(nint)timeSpan)->_ticks = (long)obj2;
			*(TimeSpan?*)(nint)timeSpan2 = timeSpan;
			obj3 = timeSpan2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (System.Nullable`1<System.TimeSpan>)+8]");
			_ = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A82A");
			obj3 = timeSpan._ticks;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.TimeSpan)+8]");
			_ = 0;
		}
		object obj5 = obj + 32;
		object obj6 = obj + 8;
		timeSpan3 = (TimeSpan?)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (System.Nullable`1<System.TimeSpan>)+8]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v37 (Il2CppClass<System.DateTime>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v86 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		TimeSpan value = ((TimeSpan?*)timeSpan3)->Value;
		obj5 = value;
		((TimeSpan*)(nint)timeSpan)->_ticks = (long)obj5;
		object obj8 = this + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC94");
		obj6 = systemTimeAsFileTime;
		object obj9 = default;
		obj = obj9;
		timeSpan2 = (TimeSpan?)obj6;
		((TimeSpan*)(nint)timeSpan)->_ticks = (long)obj;
		object obj10 = (Nullable)timeSpan2 & 0x3FFFFFFFFFFFFFFFL;
		long num5 = timeSpan._ticks & 0x3FFFFFFFFFFFFFFFL;
		if ((long)obj10 > num5)
		{
			string text2 = currentProvider__BackingField;
			if (currentProvider__BackingField != null && text2.m_stringLength != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S3_v5 (Il2CppMethodInfo)+C]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S3_v6+60]");
				object obj12 = 0;
				object obj13 = obj12;
				object obj14 = obj13 & 0x1FFF;
				object obj15 = obj14 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v276 @ S4_v7 (should have been resolved before IL gen)");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S4_v9 (Il2CppMethodInfo)+C]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S4_v10+60]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S4_v11+48]");
				object obj18 = 0;
				object obj19 = obj18 & 0x7FF;
				object obj20 = obj19 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v294 @ S5_v9 (should have been resolved before IL gen)");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S4_v14 (Il2CppMethodInfo)+C]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S4_v15+60]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S4_v16+48]");
				object obj23 = 0;
				object obj24 = obj23 & 0x7FF;
				object obj25 = obj24 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v313 @ S5_v13 (should have been resolved before IL gen)");
				object obj26 = this + 44;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			((AbstractListAdapter)this)._002Ector();
		}
	}

	private void ClearExhaustedProviders()
	{
		_exhaustedProviders.Add(currentProvider__BackingField);
	}

	public void ChangeToNextProvider()
	{
		throw new IndexOutOfRangeException();
	}

	public void ResetToTop()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_036b: Expected I4, but got Obj
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_03b8: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		if (maxPriorityInList == 0)
		{
			return;
		}
		ClearExhaustedProviders();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Func<AdProviderInfo, bool> func = default;
		object obj3 = func + 16;
		obj3 = this;
		IEnumerable<AdProviderInfo> source = Enumerable.Where(_priorityList, func);
		AdProviderInfo[] array = Enumerable.ToArray(source);
		bool flag = array.Length == 0;
		bool flag2 = !flag;
		AdProviderInfo[] array2 = array;
		if (flag2)
		{
			goto IL_0361;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		int num2 = int.MaxValue;
		object obj4 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj4 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v88+C]");
			if ((nint)0 > (nint)_currentPriority)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v88+C]");
				if ((nint)0 < (nint)num2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v88+C]");
					num2 = 0;
				}
			}
		}
		object obj5 = obj2 + 4;
		object obj6 = obj5 + 1;
		obj5 = obj6;
		object obj7 = obj6 << 2;
		object obj8 = obj2 + obj7;
		obj8 = 128;
		object obj9 = default;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj2 + obj10;
			if ((nint)obj11 == 128)
			{
				object obj12 = obj2 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				goto IL_03ef;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03ef;
		IL_0361:
		((AbstractListAdapter)this).NotifyDataSetChanged((int)array2);
		return;
		IL_03ef:
		if (num2 == int.MaxValue)
		{
			((AbstractListAdapter)this)._002Ector();
			return;
		}
		_currentPriority = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Func<AdProviderInfo, bool> func2 = default;
		object obj15 = func2 + 16;
		obj15 = this;
		IEnumerable<AdProviderInfo> source2 = Enumerable.Where(_priorityList, func2);
		AdProviderInfo[] array3 = Enumerable.ToArray(source2);
		ChangeToNextProvider();
		array2 = array3;
		goto IL_0361;
	}

	private void ChooseProvider(IList<AdProviderInfo> possibleProviders)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		object obj = this - -64;
		object obj2 = possibleProviders & 1;
		obj = obj2;
	}

	private bool _003CChangeToNextProvider_003Eb__35_0(AdProviderInfo p)
	{
		((InterstitialStats)this).IncrementShowCount();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		return _currentPriority >= (nint)obj;
	}

	private bool _003CChangeToNextProvider_003Eb__35_1(AdProviderInfo p)
	{
		if (p.priority__BackingField == _currentPriority)
		{
			bool flag = _exhaustedProviders.Contains(p.providerID__BackingField);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		return false;
	}

	private bool _003CResetToTop_003Eb__36_0(AdProviderInfo p)
	{
		return p.priority__BackingField == _currentPriority;
	}
}
