using Cpp2ILInjected;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo;

public abstract class BaseTransformValueResetter : IValueResetter<Transform>
{
	protected SpaceType _spaceType;

	protected BaseTransformValueResetter(SpaceType spaceType)
	{
		//IL_000a: Expected Obj, but got I4
		byte[] list = CompressionExtensions.Compress((byte[])(object)this, (string)spaceType);
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public void Init(Transform transform)
	{
		//IL_000a: Expected I4, but got Obj
		_spaceType = (SpaceType)transform;
	}

	protected abstract void OnInitWorldSpace(Transform transform);

	protected abstract void OnInitLocalSpace(Transform transform);

	public void ResetValues(Transform transform)
	{
		if (_spaceType != SpaceType.World)
		{
			if (_spaceType == SpaceType.Local)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	protected abstract void OnResetWorldSpace(Transform transform);

	protected abstract void OnResetLocalSpace(Transform transform);
}
