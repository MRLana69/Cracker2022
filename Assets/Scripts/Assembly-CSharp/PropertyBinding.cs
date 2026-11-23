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

	public UpdateCondition update = UpdateCondition.OnUpdate;

	public bool editMode = true;

	private object mLastValue;

	private void Start()
	{
		UpdateTarget();
		if (update == UpdateCondition.OnStart)
		{
			enabled = false;
		}
	}

	private void Update()
	{
		if (update == UpdateCondition.OnUpdate)
		{
			UpdateTarget();
		}
	}

	private void LateUpdate()
	{
		if (update == UpdateCondition.OnLateUpdate)
		{
			UpdateTarget();
		}
	}

	private void FixedUpdate()
	{
		if (update == UpdateCondition.OnFixedUpdate)
		{
			UpdateTarget();
		}
	}

	private void OnValidate()
	{
		PropertyReference propertyReference = source;
		if (source != null)
		{
			propertyReference.mField = null;
			propertyReference.mProperty = null;
		}
		PropertyReference propertyReference2 = target;
		if (target != null)
		{
			propertyReference2.mField = null;
			propertyReference2.mProperty = null;
		}
	}

	public void UpdateTarget()
	{
		//IL_0189: Expected I, but got Obj
		//IL_01e0: Expected I, but got Obj
		if (source == null || target == null || !source.isValid || !target.isValid)
		{
			return;
		}
		if (direction != Direction.SourceUpdatesTarget)
		{
			if (direction == Direction.TargetUpdatesSource)
			{
				object value = target.Get();
				bool flag = source.Set(value);
				return;
			}
			Type propertyType = source.GetPropertyType();
			Type propertyType2 = target.GetPropertyType();
			if ((object)propertyType != propertyType2)
			{
				return;
			}
			object value2 = source.Get();
			object obj = mLastValue;
			if (mLastValue != null)
			{
				nint num = (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v105 @ S2_v9 (Il2CppClass<System.Object>)+BC] (should have been resolved before IL gen)");
				object obj2 = default;
				if (obj2 != null)
				{
					object value3 = target.Get();
					object obj3 = mLastValue;
					nint num2 = (nint)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S2_v12 (Il2CppClass<System.Object>)+BC] (should have been resolved before IL gen)");
					object obj4 = default;
					if (obj4 == null)
					{
						mLastValue = value3;
						bool flag2 = source.Set(value3);
					}
					return;
				}
			}
			mLastValue = value2;
			bool flag3 = target.Set(value2);
		}
		else
		{
			object value4 = source.Get();
			bool flag4 = target.Set(value4);
		}
	}
}
