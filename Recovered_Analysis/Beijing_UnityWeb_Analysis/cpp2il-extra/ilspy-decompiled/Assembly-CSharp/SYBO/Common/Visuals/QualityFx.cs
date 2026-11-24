using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Visuals;

[Serializable]
public class QualityFx
{
	private QualityFeature _feature;

	private MonoBehaviour _unsupportedPrefab;

	private MonoBehaviour _supportedPrefab;

	public T InstantiateEffect<T>() where T : MonoBehaviour
	{
		return (T)_unsupportedPrefab;
	}

	public T InstantiateEffect<T>(Vector3 position, Quaternion rotation) where T : MonoBehaviour
	{
		//IL_000e: Expected Obj, but got I
		//IL_00b5: Expected VT, but got I4
		//IL_00b5: Expected VT, but got Obj
		//IL_00e2: Invalid comparison between Obj and VT
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		T result;
		if ((nint)obj3 == 1)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			T val = default;
			result = val;
		}
		else
		{
			Vector3 point = default;
			bool flag;
			T val2 = default;
			do
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				int num2 = Math3D.PointOnWhichSideOfLineSegment((Vector3)this, (Vector3)0, point);
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				flag = (object)val2 == (object)rotation;
				result = val2;
			}
			while (flag);
		}
		return result;
	}

	private T InstantiateInternal<T>(T prefab, Vector3 position, Quaternion rotation) where T : MonoBehaviour
	{
		//IL_0009: Expected Obj, but got I4
		object obj = 0;
		obj = prefab;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
		T result = default;
		return result;
	}

	public QualityFx()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
