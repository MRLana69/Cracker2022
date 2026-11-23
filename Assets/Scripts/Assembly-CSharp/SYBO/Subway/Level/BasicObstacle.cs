using UnityEngine;

namespace SYBO.Subway.Level;

public class BasicObstacle : MonoBehaviour
{
	private BasicObstacleType _obstacleType;

	private bool _withCoins;

	private void OnValidate()
	{
		if (_obstacleType == BasicObstacleType.LightSignal)
		{
			_withCoins = false;
		}
	}
}
