using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities.Data;
using UnityEngine;

namespace SYBO.Components.Utilities.Tickable;

[Serializable]
public class TickableScheduler : SingletonMonoBehaviour<TickableScheduler>
{
	public const float TargetEditTimeFPS = 60f;

	public TickableEvent OnRegisteredTickablesChanged;

	private List<ITickable> _registeredTickables;

	private bool _isApplicationPaused;

	private bool _isApplicationFocused;

	private DelayedTickTimer _editTimeDelayedTickTimer;

	public unsafe bool IsPaused
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected Obj, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected Obj, but got Unknown
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected Obj, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected Obj, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected Obj, but got Unknown
			//IL_006b: Expected I4, but got Obj
			object obj = this + 8;
			object obj2 = obj + 8;
			object obj3 = obj + 4;
			object obj4 = obj + 391;
			object obj5 = obj4 * 23;
			object obj6 = obj3 + obj5;
			object obj7 = obj6 * 23;
			return (byte)(int)(obj2 + obj7) != 0;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_001b: Expected Obj, but got I4
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected Obj, but got Unknown
			//IL_0043: Expected Obj, but got I4
			//IL_005d: Expected Obj, but got I4
			//IL_0073: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 24;
			obj = ((bool*)(value ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
			_ = 0;
			object obj3 = obj2 + 12;
			obj3 = ((bool*)(value ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
			_ = 0;
			obj2 = ((bool*)(value ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
			_ = 0;
			TickableScheduler tickableScheduler = (TickableScheduler)0;
			_ = 0;
			tickableScheduler = (TickableScheduler)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
	}

	public int RegisteredTickablesCount => _isApplicationPaused ? 1 : 0;

	protected void OnApplicationFocus(bool hasFocus)
	{
		_isApplicationPaused = hasFocus;
	}

	protected void OnApplicationPause(bool isPaused)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
		object obj = (isPaused ? 1 : 0) ^ 1;
		bool isApplicationFocused = (byte)(obj & 1) != 0;
		_isApplicationFocused = isApplicationFocused;
	}

	protected void OnEnable()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F5BB");
	}

	public void Initialize()
	{
		OnDisable();
	}

	private void OnDisable()
	{
		this._002Ector();
	}

	protected override void OnDestroy()
	{
	}

	protected void Update()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
		this._002Ector();
	}

	public void RegisterTickable(ITickable tickable)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool isApplicationPaused = (byte)(tickable & 1) != 0;
		_isApplicationPaused = isApplicationPaused;
	}

	public void Tick(float deltaTime)
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Math);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<System.Math>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<System.Math>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.Tickable.TickableScheduler)+30]");
		float value = 0f - deltaTime;
		float num3 = Math.Abs(value);
		if (num3 > 0.0001f)
		{
			_ = 1;
		}
	}

	public unsafe bool HasRegisteredTickable(ITickable tickable)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected VT, but got Unknown
		//IL_00a6: Expected I4, but got Obj
		//IL_00a1: Expected native int or pointer, but got VT
		//IL_00b6: Expected native int or pointer, but got VT
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected I4, but got Unknown
		//IL_00d6: Expected I4, but got Obj
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0124: Expected I4, but got Obj
		//IL_013f: Expected I, but got Obj
		//IL_0155: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I4
		//IL_0191: Expected I4, but got Obj
		//IL_018c: Expected native int or pointer, but got VT
		//IL_01a1: Expected native int or pointer, but got VT
		//IL_01b4: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I4, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		_ = 0;
		Vector3i vector3i = (Vector3i)(obj2 + 36);
		((Vector3i*)(nint)vector3i)->x = (int)this;
		Vector3i vector3i2 = vector3i;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.Tickable.TickableScheduler)+8]");
		((Vector3i*)(nint)vector3i2)->z = 0;
		int num = obj2 + 48;
		((int*)num)->m_value = (int)tickable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tickable @ L1 (SYBO.Components.Utilities.Tickable.ITickable)+8]");
		_ = 0;
		object obj3 = obj2 + 12;
		Vector3i vector3i3 = vector3i * num;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v18+8]");
		_ = 0;
		((int*)num)->m_value = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v18+8]");
		_ = 0;
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v27 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v45 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num4 = Mathf.Min((int[])((int*)num)->m_value);
		((Vector3i*)(nint)vector3i)->x = (int)obj;
		Vector3i vector3i4 = vector3i;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3i*)(nint)vector3i4)->z = 0;
		int num5 = Mathf.Min((int[])vector3i.y);
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		int num6 = Mathf.Min((int[])0);
		object obj5 = num5 + num4;
		return (byte)(num6 + obj5) != 0;
	}

	public void UnregisterTickable(ITickable tickable)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		throw new IndexOutOfRangeException();
	}

	private void UnregisterAllTickables()
	{
		float unscaledTime = Time.unscaledTime;
		((NumericFloatToggle)(object)this).Value = unscaledTime;
	}

	public TickableScheduler()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		if (_registeredTickables == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
			object obj = this + 20;
			object obj2 = default;
			obj = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
		throw new ArrayTypeMismatchException();
	}
}
