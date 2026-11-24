namespace UnityEngine;

public class Object
{
	internal static int OffsetOfInstanceIDInCPlusPlusObject; //Field offset: 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null."; //Field offset: 0x0
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."; //Field offset: 0x0
	private nint m_CachedPtr; //Field offset: 0x8

	public HideFlags hideFlags
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public string name
	{
		 get { } //Length: 6
		 set { } //Length: 94
	}

	private static Object() { }

	public Object() { }

	private static void CheckNullArgument(object arg, string message) { }

	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	public static void Destroy(Object obj) { }

	public static void Destroy(Object obj, float t) { }

	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	public static void DestroyImmediate(Object obj) { }

	public static void DontDestroyOnLoad(Object target) { }

	public override bool Equals(object other) { }

	internal static Object FindObjectFromInstanceID(int instanceID) { }

	public static Object FindObjectOfType(Type type) { }

	public static T FindObjectOfType() { }

	public static T[] FindObjectsOfType() { }

	public static Object[] FindObjectsOfType(Type type) { }

	public HideFlags get_hideFlags() { }

	public string get_name() { }

	private nint GetCachedPtr() { }

	public override int GetHashCode() { }

	public int GetInstanceID() { }

	private static string GetName(Object obj) { }

	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation, Transform parent) { }

	public static T Instantiate(T original, Transform parent) { }

	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	public static T Instantiate(T original) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation) { }

	public static T Instantiate(T original, Transform parent, bool worldPositionStays) { }

	public static Object Instantiate(Object original) { }

	private static Object Internal_CloneSingle(Object data) { }

	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

	private static bool IsNativeObjectAlive(Object o) { }

	public static bool op_Equality(Object x, Object y) { }

	public static bool op_Implicit(Object exists) { }

	public static bool op_Inequality(Object x, Object y) { }

	public void set_hideFlags(HideFlags value) { }

	public void set_name(string value) { }

	private static void SetName(Object obj, string name) { }

	public override string ToString() { }

	private static string ToString(Object obj) { }

}

