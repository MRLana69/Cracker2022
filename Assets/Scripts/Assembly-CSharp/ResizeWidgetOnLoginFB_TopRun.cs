using UnityEngine;

public class ResizeWidgetOnLoginFB_TopRun : MonoBehaviour
{
	public UIWidget emptyWidget;

	public void SetEmptyWidgetSize(int width, int height)
	{
		emptyWidget.width = width;
		emptyWidget.height = height;
	}
}
