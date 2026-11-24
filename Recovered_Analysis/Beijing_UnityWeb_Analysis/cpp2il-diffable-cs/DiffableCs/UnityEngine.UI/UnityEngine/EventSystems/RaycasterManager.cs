namespace UnityEngine.EventSystems;

internal static class RaycasterManager
{
	private static readonly List<BaseRaycaster> s_Raycasters; //Field offset: 0x0

	private static RaycasterManager() { }

	public static void AddRaycaster(BaseRaycaster baseRaycaster) { }

	public static List<BaseRaycaster> GetRaycasters() { }

	public static void RemoveRaycasters(BaseRaycaster baseRaycaster) { }

}

