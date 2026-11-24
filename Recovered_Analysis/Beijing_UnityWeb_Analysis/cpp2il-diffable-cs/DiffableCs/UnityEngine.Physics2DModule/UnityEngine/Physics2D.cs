namespace UnityEngine;

public class Physics2D
{
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; //Field offset: 0x0

	public static PhysicsScene2D defaultPhysicsScene
	{
		 get { } //Length: 7
	}

	public static bool queriesHitTriggers
	{
		 get { } //Length: 35
	}

	private static Physics2D() { }

	public static PhysicsScene2D get_defaultPhysicsScene() { }

	public static bool get_queriesHitTriggers() { }

	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }

	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	public static Collider2D[] OverlapCircleAll(Vector2 point, float radius) { }

	private static Collider2D[] OverlapCircleAll_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter) { }

	private static Collider2D[] OverlapCircleAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter) { }

	public static Collider2D OverlapPoint(Vector2 point, int layerMask) { }

	public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask) { }

	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = Infinity) { }

	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

}

