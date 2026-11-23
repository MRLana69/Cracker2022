using System;
using SYBO.Common.Benchmarking;

namespace SYBO.Subway.Automation.Samplers;

public class ScreenOpenedSampler : IMetricSampler
{
	private bool _shouldSample;

	public void Initialize()
	{
		throw new ArgumentException();
	}

	public void Cleanup()
	{
		throw new ArgumentException();
	}

	public bool Update(float unscaledDeltaTime)
	{
		if (~(_shouldSample ? 1u : 0u) == 0)
		{
			_shouldSample = false;
		}
		return _shouldSample;
	}

	private void UIScreenController_OnNavigateToScreen(string screenId)
	{
		if (!screenId.Equals("IngameUI"))
		{
			_shouldSample = true;
		}
	}

	private void UIScreenController_OnPopupShown(string popupId)
	{
		//IL_0042: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		object obj;
		if (popupId != null)
		{
			obj = 0;
			if (popupId._stringLength != 0)
			{
				goto IL_0057;
			}
		}
		obj = 1;
		goto IL_0057;
		IL_0057:
		if (obj == null)
		{
			_shouldSample = true;
		}
	}
}
