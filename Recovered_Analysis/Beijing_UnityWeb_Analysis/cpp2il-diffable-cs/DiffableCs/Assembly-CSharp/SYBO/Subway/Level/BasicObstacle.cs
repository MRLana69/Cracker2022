namespace SYBO.Subway.Level;

public class BasicObstacle : MonoBehaviour
{
	private BasicObstacleType _obstacleType; //Field offset: 0xC
	private bool _withCoins; //Field offset: 0x10

	public BasicObstacle() { }

	private void OnValidate() { }

}

