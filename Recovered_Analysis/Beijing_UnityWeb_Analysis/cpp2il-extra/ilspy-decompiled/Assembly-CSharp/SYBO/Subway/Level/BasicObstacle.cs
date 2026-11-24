using UnityEngine;

namespace SYBO.Subway.Level;

public class BasicObstacle : MonoBehaviour
{
	private BasicObstacleType _obstacleType;

	private bool _withCoins;

	private void OnValidate()
	{
		CancelInvoke();
	}

	public BasicObstacle()
	{
		if (_obstacleType == BasicObstacleType.LightSignal)
		{
			_withCoins = false;
		}
	}
}
