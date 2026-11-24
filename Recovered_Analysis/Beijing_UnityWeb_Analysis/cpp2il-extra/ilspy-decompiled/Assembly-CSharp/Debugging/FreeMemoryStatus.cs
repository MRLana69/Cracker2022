using System;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.DeviceUtility;
using UnityEngine;

namespace Debugging;

public class FreeMemoryStatus : MonoBehaviour
{
	public float UpdateInterval;

	private UILabel _label;

	private float _timeleft;

	private static FreeMemoryStatus _instance;

	private GameObject _prefabInstanceRoot;

	public static FreeMemoryStatus Instance => (FreeMemoryStatus)(object)FPSCounter._instance;

	private void Awake()
	{
		//IL_000b: Expected Obj, but got F4
		_label = (UILabel)0.5f;
		CancelInvoke();
	}

	private void Update()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		_instance = this;
		object obj = this + 16;
		UILabel component = GetComponent<UILabel>();
		obj = component;
		_timeleft = UpdateInterval;
	}

	public unsafe static FreeMemoryStatus Create(GameObject anchor)
	{
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected I, but got Unknown
		//IL_01c9: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0213: Expected I, but got Obj
		//IL_0229: Expected Obj, but got I
		//IL_013d: Expected I4, but got Obj
		//IL_0157: Expected Obj, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_019b: Expected Obj, but got I4
		//IL_00ab: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v49 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(GameObject);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type systemTypeInstance = Type.internal_from_handle((IntPtr)num3);
		UnityEngine.Object[] array = Resources.LoadAll("Prefabs/Special/FpsCounter", systemTypeInstance);
		if (array != null)
		{
			if ((object)array.GetType() != typeof(GameObject))
			{
				array = null;
			}
		}
		else
		{
			array = null;
		}
		nint num4 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v28 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v38 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num6 = NGUITools.CalculateNextDepth(anchor, (byte)(int)array != 0);
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S2_v4 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v101 @ S3_v4 (should have been resolved before IL gen)");
		FreeMemoryStatus freeMemoryStatus = default;
		object obj7 = freeMemoryStatus + 44;
		obj7 = num6;
		return freeMemoryStatus;
	}

	public void ToggleVisible(bool visible)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_001a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Debugging.FreeMemoryStatus)+2C]");
		((GameObject)0).tag = (string)visible;
	}

	public unsafe FreeMemoryStatus()
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected I4, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_01da: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I4
		//IL_021a: Expected I4, but got Obj
		//IL_00f2: Expected I4, but got Obj
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 24);
		object obj2 = obj + 8;
		obj2 = 0;
		_ = 0;
		float unscaledTime = Time.unscaledTime;
		float timeleft = _timeleft - unscaledTime;
		_timeleft = timeleft;
		if (_timeleft > 0f)
		{
			return;
		}
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v40 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int currentMemoryUsage = DeviceUtility.GetCurrentMemoryUsage();
		if (currentMemoryUsage > 99)
		{
			Color blue = Color.blue;
		}
		else if (currentMemoryUsage > 50)
		{
			Color green = Color.green;
		}
		else
		{
			Color magenta = Color.magenta;
		}
		obj2 = ((UIWidget.Pivot*)(int)pivot)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UIWidget+Pivot)+8]");
		_ = 0;
		obj = currentMemoryUsage;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = $"{args} MB Free";
		_label.fontSize = (int)text;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		_ = 0;
		_label.rawPivot = pivot;
		_timeleft = UpdateInterval;
	}
}
