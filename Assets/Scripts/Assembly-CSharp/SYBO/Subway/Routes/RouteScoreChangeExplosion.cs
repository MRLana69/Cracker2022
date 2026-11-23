using UnityEngine;

namespace SYBO.Subway.Routes;

public class RouteScoreChangeExplosion : MonoBehaviour
{
	public static string PREFAB_RESOURCE_PATH = "Prefabs/Routes/RouteScoreChangeExplosion";

	public unsafe static RouteScoreChangeExplosion CreateAtPosition(Vector3 positionVector3)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ba: Expected native int or pointer, but got VT
		//IL_00cc: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		Object original = Resources.Load(PREFAB_RESOURCE_PATH);
		Object obj2 = Object.Instantiate(original);
		bool flag = (object)obj2 == null;
		GameObject gameObject = null;
		if (!flag)
		{
			bool flag2 = (object)obj2.GetType() == typeof(GameObject);
			gameObject = (GameObject)obj2;
			if (!flag2)
			{
				gameObject = null;
			}
		}
		Transform transform = gameObject.transform;
		((Vector3*)(nint)vector)->z = positionVector3.z;
		((Vector3*)(nint)vector)->x = positionVector3.x;
		transform.position = vector;
		Object.Destroy(gameObject, 0.1f);
		return gameObject.GetComponent<RouteScoreChangeExplosion>();
	}
}
