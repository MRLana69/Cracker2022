using System.Collections.Generic;
using UnityEngine;

public class UIToggledComponents : MonoBehaviour
{
	public List<MonoBehaviour> activate;

	public List<MonoBehaviour> deactivate;

	private MonoBehaviour target;

	private bool inverse;

	private unsafe void Awake()
	{
		if (target != null)
		{
			List<MonoBehaviour> list = activate;
			if (list._size == 0)
			{
				List<MonoBehaviour> list2 = deactivate;
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
		callback._002Ector(this, (nint)__ldftn(UIToggledComponents.Toggle));
		EventDelegate eventDelegate = EventDelegate.Add(component.onChange, callback);
	}

	public void Toggle()
	{
		//IL_003d: Expected Obj, but got I4
		//IL_00f5: Expected I4, but got Obj
		//IL_0096: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected I4, but got Unknown
		//IL_00b2: Expected Obj, but got I4
		if (!enabled)
		{
			return;
		}
		int num = 0;
		while (true)
		{
			List<MonoBehaviour> list = activate;
			if (num >= list._size)
			{
				break;
			}
			MonoBehaviour monoBehaviour = activate.get_Item(num);
			UIToggle current = UIToggle.current;
			object obj = 57;
			if (!current.mStarted)
			{
				obj = 28;
			}
			object obj2 = obj + (object)current;
			monoBehaviour.enabled = (byte)(int)obj2 != 0;
			int num2 = num + 1;
			num = num2;
		}
		int num3 = 0;
		while (true)
		{
			List<MonoBehaviour> list2 = deactivate;
			if (num3 < list2._size)
			{
				MonoBehaviour monoBehaviour2 = deactivate.get_Item(num3);
				UIToggle current2 = UIToggle.current;
				object obj3 = 57;
				if (!current2.mStarted)
				{
					obj3 = 28;
				}
				object obj4 = obj3 + (object)current2;
				bool flag = (byte)(obj4 ^ 1) != 0;
				monoBehaviour2.enabled = flag;
				int num4 = num3 + 1;
				num3 = num4;
				continue;
			}
			break;
		}
	}
}
