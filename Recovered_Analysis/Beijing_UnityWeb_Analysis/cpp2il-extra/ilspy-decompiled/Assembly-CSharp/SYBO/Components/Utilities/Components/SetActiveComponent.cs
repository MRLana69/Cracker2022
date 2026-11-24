using UnityEngine;

namespace SYBO.Components.Utilities.Components;

public class SetActiveComponent : MonoBehaviour
{
	private bool _isActiveOnAwake;

	protected void Awake()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = "";
	}

	public SetActiveComponent()
	{
		//IL_002b: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		string text = tag;
		bool isActiveOnAwake = _isActiveOnAwake;
		((GameObject)(object)text).tag = (string)isActiveOnAwake;
		bool isActiveOnAwake2 = _isActiveOnAwake;
		tag = (string)isActiveOnAwake2;
	}
}
