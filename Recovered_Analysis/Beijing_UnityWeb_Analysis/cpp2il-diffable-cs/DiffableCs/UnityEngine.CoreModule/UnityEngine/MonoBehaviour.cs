namespace UnityEngine;

public class MonoBehaviour : Behaviour
{

	public bool useGUILayout
	{
		 get { } //Length: 9
		 set { } //Length: 53
	}

	public MonoBehaviour() { }

	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	public void CancelInvoke() { }

	public void CancelInvoke(string methodName) { }

	public bool get_useGUILayout() { }

	internal string GetScriptClassName() { }

	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	public void Invoke(string methodName, float time) { }

	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	public bool IsInvoking(string methodName) { }

	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	public bool IsInvoking() { }

	private static bool IsObjectMonoBehaviour(Object obj) { }

	public static void print(object message) { }

	public void set_useGUILayout(bool value) { }

	public Coroutine StartCoroutine(IEnumerator routine) { }

	public Coroutine StartCoroutine(string methodName, object value) { }

	public Coroutine StartCoroutine(string methodName) { }

	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	public void StopAllCoroutines() { }

	public void StopCoroutine(string methodName) { }

	public void StopCoroutine(Coroutine routine) { }

	public void StopCoroutine(IEnumerator routine) { }

	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	private void StopCoroutineManaged(Coroutine routine) { }

}

