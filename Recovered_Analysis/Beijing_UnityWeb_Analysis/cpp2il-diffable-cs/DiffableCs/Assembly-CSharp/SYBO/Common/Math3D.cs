namespace SYBO.Common;

public class Math3D
{
	private static Transform tempChild; //Field offset: 0x0
	private static Transform tempParent; //Field offset: 0x4
	private static Vector3[] positionRegister; //Field offset: 0x8
	private static float[] posTimeRegister; //Field offset: 0xC
	private static int positionSamplesTaken; //Field offset: 0x10
	private static Quaternion[] rotationRegister; //Field offset: 0x14
	private static float[] rotTimeRegister; //Field offset: 0x18

	private static Math3D() { }

	public Math3D() { }

	public static Vector3 AddVectorLength(Vector3 vector, float size) { }

	public static float AngleVectorPlane(Vector3 vector, Vector3 normal) { }

	public static bool AreLineSegmentsCrossing(Vector3 pointA1, Vector3 pointA2, Vector3 pointB1, Vector3 pointB2) { }

	public static bool ClosestPointsOnTwoLines(out Vector3 closestPointLine1, out Vector3 closestPointLine2, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2) { }

	public static float DotProductAngle(Vector3 vec1, Vector3 vec2) { }

	public static Vector3 GetForwardVector(Quaternion q) { }

	public static Vector3 GetRightVector(Quaternion q) { }

	public static Vector3 GetUpVector(Quaternion q) { }

	public static void Init() { }

	public static bool IsLineInRectangle(Vector3 linePoint1, Vector3 linePoint2, Vector3 rectA, Vector3 rectB, Vector3 rectC, Vector3 rectD) { }

	public static bool IsPointInRectangle(Vector3 point, Vector3 rectA, Vector3 rectC, Vector3 rectB, Vector3 rectD) { }

	public static bool LinearAcceleration(out Vector3 vector, Vector3 position, int samples) { }

	public static float LinearFunction2DBasic(float x, float Qx, float Qy) { }

	public static float LinearFunction2DFull(float x, float Px, float Py, float Qx, float Qy) { }

	public static bool LineLineIntersection(out Vector3 intersection, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2) { }

	public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planePoint, Vector3 planeNormal) { }

	public static void LookRotationExtended(ref GameObject gameObjectInOut, Vector3 alignWithVector, Vector3 alignWithNormal, Vector3 customForward, Vector3 customUp) { }

	public static float MouseDistanceToCircle(Vector3 point, float radius) { }

	public static float MouseDistanceToLine(Vector3 linePoint1, Vector3 linePoint2) { }

	public static void PlaneFrom3Points(out Vector3 planeNormal, out Vector3 planePoint, Vector3 pointA, Vector3 pointB, Vector3 pointC) { }

	public static bool PlanePlaneIntersection(out Vector3 linePoint, out Vector3 lineVec, Vector3 plane1Normal, Vector3 plane1Position, Vector3 plane2Normal, Vector3 plane2Position) { }

	public static int PointOnWhichSideOfLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point) { }

	public static Vector3 PositionFromMatrix(Matrix4x4 m) { }

	public static void PreciseAlign(ref GameObject gameObjectInOut, Vector3 alignWithVector, Vector3 alignWithNormal, Vector3 alignWithPosition, Vector3 triangleForward, Vector3 triangleNormal, Vector3 trianglePosition) { }

	public static Vector3 ProjectPointOnLine(Vector3 linePoint, Vector3 lineVec, Vector3 point) { }

	public static Vector3 ProjectPointOnLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point) { }

	public static Vector3 ProjectPointOnPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 point) { }

	public static Vector3 ProjectVectorOnPlane(Vector3 planeNormal, Vector3 vector) { }

	public static Quaternion QuaternionFromMatrix(Matrix4x4 m) { }

	public static Vector3 SetVectorLength(Vector3 vector, float size) { }

	public static float SignedDistancePlanePoint(Vector3 planeNormal, Vector3 planePoint, Vector3 point) { }

	public static float SignedDotProduct(Vector3 vectorA, Vector3 vectorB, Vector3 normal) { }

	public static float SignedVectorAngle(Vector3 referenceVector, Vector3 otherVector, Vector3 normal) { }

	public static Quaternion SubtractRotation(Quaternion B, Quaternion A) { }

	public static void TransformWithParent(out Quaternion childRotation, out Vector3 childPosition, Quaternion parentRotation, Vector3 parentPosition, Quaternion startParentRotation, Vector3 startParentPosition, Quaternion startChildRotation, Vector3 startChildPosition) { }

	public static void VectorsToTransform(ref GameObject gameObjectInOut, Vector3 positionVector, Vector3 directionVector, Vector3 normalVector) { }

}

