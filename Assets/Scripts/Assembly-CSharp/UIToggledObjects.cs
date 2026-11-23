using System.Collections.Generic;
using UnityEngine;

public class UIToggledObjects : MonoBehaviour
{
	public List<GameObject> activate;

	public List<GameObject> deactivate;

	private GameObject target;

	private bool inverse;

	private unsafe void Awake()
	{
		if (target != null)
		{
			List<GameObject> list = activate;
			if (list._size == 0)
			{
				List<GameObject> list2 = deactivate;
				if (list2._size == 0)
				{
					if (~(inverse ? 1u : 0u) == 0)
					{
						deactivate.Add(target);
					}
					else
					{
						activate.Add(target);
					}
					goto IL_00d5;
				}
			}
			target = null;
		}
		goto IL_00d5;
		IL_00d5:
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.Callback callback = default;
		callback._002Ector(this, (nint)__ldftn(UIToggledObjects.Toggle));
		EventDelegate eventDelegate = EventDelegate.Add(component.onChange, callback);
	}

	public void Toggle()
	{
		//IL_00d1: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected I4, but got Unknown
		//IL_0042: Expected I4, but got Obj
		UIToggle current = UIToggle.current;
		object obj = 57;
		if (!current.mStarted)
		{
			obj = 28;
		}
		object obj2 = obj + (object)current;
		if (!enabled)
		{
			return;
		}
		int num = 0;
		while (true)
		{
			List<GameObject> list = activate;
			if (num >= list._size)
			{
				break;
			}
			GameObject go = activate.get_Item(num);
			Set(go, (byte)(int)obj2 != 0);
			int num2 = num + 1;
			num = num2;
		}
		bool state = (byte)(obj2 ^ 1) != 0;
		int num3 = 0;
		while (true)
		{
			List<GameObject> list2 = deactivate;
			if (num3 < list2._size)
			{
				GameObject go2 = deactivate.get_Item(num3);
				Set(go2, state);
				int num4 = num3 + 1;
				num3 = num4;
				continue;
			}
			break;
		}
	}

	private void Set(GameObject go, bool state)
	{
		if (go != null)
		{
			NGUITools.SetActive(go, state);
		}
	}
}
