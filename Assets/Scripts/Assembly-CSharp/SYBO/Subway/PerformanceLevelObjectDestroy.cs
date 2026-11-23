using UnityEngine;

namespace SYBO.Subway;

public class PerformanceLevelObjectDestroy : MonoBehaviour
{
	private DeviceInfo.PerformanceLevel _minDevicePerformance;

	private void Awake()
	{
		DeviceInfo instance = DeviceInfo.Instance;
		if (_minDevicePerformance > instance.performanceLevel)
		{
			GameObject obj = gameObject;
			Object.Destroy(obj);
		}
	}
}
