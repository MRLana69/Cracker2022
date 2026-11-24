namespace UnityEngine;

public struct PhysicsScene : IEquatable<PhysicsScene>
{
	private int m_Handle; //Field offset: 0x0

	public override bool Equals(object other) { }

	public bool Equals(PhysicsScene other) { }

	public override int GetHashCode() { }

	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = Infinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = Infinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = Infinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	public override string ToString() { }

}

