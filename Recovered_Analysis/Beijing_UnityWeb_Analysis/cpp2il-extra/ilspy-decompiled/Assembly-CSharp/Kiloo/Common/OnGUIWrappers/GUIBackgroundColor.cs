using UnityEngine;

namespace Kiloo.Common.OnGUIWrappers;

public class GUIBackgroundColor : InternalColor
{
	public unsafe GUIBackgroundColor(Color newColor)
	{
		//IL_0012: Expected I4, but got F4
		bool flag = default;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)newColor.r != 0;
		_ = newColor.b;
		GUILayout.EndScrollView(flag);
	}

	public override void Dispose()
	{
		GUILayout.EndScrollView();
	}
}
