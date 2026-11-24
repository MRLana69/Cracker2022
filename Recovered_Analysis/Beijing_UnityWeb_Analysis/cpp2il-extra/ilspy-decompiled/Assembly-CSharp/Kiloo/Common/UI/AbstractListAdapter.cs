using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Ads;
using Kiloo.Common.Extensions;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.UI;

public abstract class AbstractListAdapter
{
	public Action<int> onNotifyDataSetChanged;

	public abstract int GetCount();

	public unsafe virtual Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00e6: Expected Obj, but got I4
		//IL_0093: Expected I4, but got Obj
		//IL_0012: Expected Obj, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		object obj = dataIndex * container;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Color32[] array = default;
		object obj2 = array + 12;
		object obj3 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = ((bool*)(isMeasurePass ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isMeasurePass @ L3 (System.Boolean)+8]");
			_ = 0;
			object obj5 = array + 16;
			object obj6 = obj3 << 4;
			object obj7 = obj5 + obj6;
			obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj8 = obj3 + 1;
			obj3 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Texture2D texture2D = default;
		texture2D.ApplyImpl((byte)(int)container != 0, (byte)dataIndex != 0);
		texture2D.SetPixels32(array);
		((RenderTexture)(object)texture2D)._002Ector();
		return (Container)(object)texture2D;
	}

	public virtual int GetModelType(int index)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.UI.AbstractListAdapter)+10]");
		return (num == 0) ? 1 : 0;
	}

	public unsafe virtual long GetItemId(int position)
	{
		//IL_005c: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, (string)position);
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return ((bool*)text)->System_002EIConvertible_002EToInt64((IFormatProvider)null);
	}

	public virtual bool HasStableIds()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		Action<int> action = (Action<int>)(onNotifyDataSetChanged + 1);
		onNotifyDataSetChanged = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		Action<int> action2 = onNotifyDataSetChanged;
		object obj = default;
		if (System.Runtime.CompilerServices.Unsafe.As<Action<int>, UIntPtr>(ref action2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			return false;
		}
		((PriorityList)this).ResetToTop();
		return true;
	}

	public void NotifyDataSetChanged(int selection = 0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Obj, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I
		//IL_066a: Expected I, but got Obj
		//IL_0680: Expected Obj, but got I
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected Obj, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_05a5: Expected Obj, but got I4
		//IL_05ae: Expected Obj, but got I4
		//IL_0609: Expected Obj, but got I8
		//IL_0634: Expected Obj, but got I
		//IL_04c2: Expected I, but got Obj
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0325: Expected Obj, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_0410: Expected Obj, but got I
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02d8: Expected Obj, but got I4
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj5 = default;
		if ((nint)obj5 == 1)
		{
			object obj6 = this + 52;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v108+10]");
			obj6 = 0;
			goto IL_065c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v171+8]");
			obj8 = obj9 + 0;
		}
		object obj10 = obj4 + 4;
		object obj11 = obj10 + 1;
		obj10 = obj11;
		object obj12 = obj11 << 2;
		object obj13 = obj4 + obj12;
		obj13 = 92;
		object obj14 = 0;
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj4 + obj16;
			if ((nint)obj17 == 92)
			{
				object obj18 = obj4 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_0635;
			}
		}
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0635;
		IL_065c:
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v24 (Il2CppClass<System.DateTime>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v36 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		obj2 = systemTimeAsFileTime;
		obj3 = obj2;
		onNotifyDataSetChanged = null;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.UI.AbstractListAdapter)+38]");
		TransformExtensions.Reset((Transform)0);
		return;
		IL_0635:
		float time = Time.time;
		float num3 = time * (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj21 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj21 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				float num4 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v113+8]");
				float num5 = num4 + 0f;
				if (num3 < num5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					object obj22 = obj4 + 4;
					object obj23 = obj22 + 1;
					obj22 = obj23;
					object obj24 = obj23 << 2;
					object obj25 = obj4 + obj24;
					obj25 = 172;
					break;
				}
				continue;
			}
			object obj26 = obj4 + 4;
			object obj27 = obj26 + 1;
			obj26 = obj27;
			object obj28 = obj27 << 2;
			object obj29 = obj4 + obj28;
			obj29 = 172;
			break;
		}
		object obj30 = default;
		if (obj30 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
			object obj31 = (nint)0 << 2;
			object obj32 = obj4 + obj31;
			if ((nint)obj32 == 172)
			{
				object obj33 = obj4 + 4;
				if ((nint)obj33 > -1)
				{
					object obj34 = obj33 + -1;
					obj33 = obj34;
				}
				goto IL_065c;
			}
		}
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_065c;
	}

	protected AbstractListAdapter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_02ca: Expected Obj, but got I4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_0345: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		//IL_01f3: Expected I4, but got Obj
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_022b: Expected Obj, but got I4
		//IL_023c: Expected Obj, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.UI.AbstractListAdapter)+10]");
		bool flag = (nint)0 == -1;
		((PriorityList)this).ChangeToNextProvider();
		_ = int.MaxValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v77+C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.UI.AbstractListAdapter)+10]");
			if (num < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v77+C]");
				_ = 0;
			}
		}
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 94;
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
			if ((nint)obj10 == 94)
			{
				object obj11 = obj2 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				goto IL_0305;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0305;
		IL_0305:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Func<AdProviderInfo, bool> func = default;
		object obj14 = func + 16;
		obj14 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.UI.AbstractListAdapter)+24]");
		IEnumerable<AdProviderInfo> source = Enumerable.Where((IEnumerable<AdProviderInfo>)0, func);
		AdProviderInfo[] array = Enumerable.ToArray(source);
		NotifyDataSetChanged((int)array);
		if (!flag)
		{
			object obj15 = this - -64;
			obj15 = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.UI.AbstractListAdapter)+3C]");
			TransformExtensions.Reset((Transform)0);
		}
	}
}
