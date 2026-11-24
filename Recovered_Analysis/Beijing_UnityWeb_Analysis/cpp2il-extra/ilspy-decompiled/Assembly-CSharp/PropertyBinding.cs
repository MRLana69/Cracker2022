using System;
using Cpp2ILInjected;
using UnityEngine;

public class PropertyBinding : MonoBehaviour
{
	public enum UpdateCondition
	{
		OnStart,
		OnUpdate,
		OnLateUpdate,
		OnFixedUpdate
	}

	public enum Direction
	{
		SourceUpdatesTarget,
		TargetUpdatesSource,
		BiDirectional
	}

	public PropertyReference source;

	public PropertyReference target;

	public Direction direction;

	public UpdateCondition update;

	public bool editMode;

	private object mLastValue;

	private void Start()
	{
		//IL_0020: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I4
		int height = Screen.height;
		int sleepTimeout = Screen.sleepTimeout;
		PropertyBinding propertyBinding = (PropertyBinding)0;
		propertyBinding = (PropertyBinding)height;
	}

	private void Update()
	{
		this._002Ector();
		if (update == UpdateCondition.OnStart)
		{
			tag = null;
		}
	}

	private void LateUpdate()
	{
		if (update == UpdateCondition.OnUpdate)
		{
			this._002Ector();
		}
	}

	private void FixedUpdate()
	{
		if (update == UpdateCondition.OnLateUpdate)
		{
			this._002Ector();
		}
	}

	private void OnValidate()
	{
		if (update == UpdateCondition.OnFixedUpdate)
		{
			this._002Ector();
		}
	}

	public void UpdateTarget()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got I4
		if (source != null)
		{
			object obj = source + 16;
			obj = 0;
			object obj2 = source + 20;
			obj2 = 0;
		}
		if (target != null)
		{
			object obj3 = target + 16;
			obj3 = 0;
			object obj4 = target + 20;
			obj4 = 0;
		}
	}

	public unsafe PropertyBinding()
	{
		//IL_0151: Expected I, but got Obj
		//IL_0167: Expected Obj, but got I
		//IL_0192: Expected I, but got Obj
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02d7: Expected Obj, but got I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0265: Expected Obj, but got I4
		if (source == null || target == null || !source.isEnabled || !target.isEnabled)
		{
			return;
		}
		if (direction == Direction.SourceUpdatesTarget)
		{
			bool flag = source.Cache();
			bool flag2 = target.Convert(ref *(flag ? ((object*)1) : ((object*)null)));
			return;
		}
		if (direction == Direction.TargetUpdatesSource)
		{
			bool flag3 = target.Cache();
			bool flag4 = source.Convert(ref *(flag3 ? ((object*)1) : ((object*)null)));
			return;
		}
		int hashCode = source.GetHashCode();
		int hashCode2 = target.GetHashCode();
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v4 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S2_v13 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (hashCode != hashCode2)
		{
			return;
		}
		bool flag5 = source.Cache();
		if (mLastValue != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			object obj2 = default;
			if (obj2 != null)
			{
				bool flag6 = target.Cache();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				object obj3 = default;
				if (obj3 == null)
				{
					object obj4 = this + 32;
					obj4 = flag6;
					bool flag7 = source.Convert(ref *(flag6 ? ((object*)1) : ((object*)null)));
				}
				return;
			}
		}
		object obj5 = this + 32;
		obj5 = flag5;
		bool flag8 = target.Convert(ref *(flag5 ? ((object*)1) : ((object*)null)));
	}
}
