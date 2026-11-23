using UnityEngine;
using gmsoft;

public class TestAnalytics : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Analytics.LogEvent("press_space");
		}
		if (Input.GetKeyDown(KeyCode.Return))
		{
			Analytics.LogEvent("press_enter");
		}
	}
}
