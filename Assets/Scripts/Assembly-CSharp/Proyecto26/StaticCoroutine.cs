using System.Collections;
using UnityEngine;

namespace Proyecto26;

public static class StaticCoroutine
{
	private class CoroutineHolder : MonoBehaviour
	{
	}

	private static CoroutineHolder _runner;

	private static CoroutineHolder Runner
	{
		get
		{
			if (_runner == null)
			{
				GameObject gameObject = default;
				gameObject._002Ector("Static Coroutine RestClient");
				CoroutineHolder runner = gameObject.AddComponent<CoroutineHolder>();
				_runner = runner;
				Object.DontDestroyOnLoad(_runner);
			}
			return _runner;
		}
	}

	public static Coroutine StartCoroutine(IEnumerator coroutine)
	{
		CoroutineHolder runner = Runner;
		return runner.StartCoroutine(coroutine);
	}
}
