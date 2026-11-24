using System;
using System.Text;
using Cpp2ILInjected;
using SYBO.Common.Utility;
using UnityEngine;

namespace SYBO.Common.Benchmarking.Utility;

public class FirstMonobehaviour : SubscribableMonobehaviour
{
	public Action OnOnGUI;

	public Action<bool> OnOnApplicationPause;

	private void Awake()
	{
	}

	private void OnGUI()
	{
		MonoBehaviour.CancelInvoke((MonoBehaviour)this, (string)null);
	}

	private void OnApplicationPause(bool pause)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		Action onUpdate = (Action)(OnUpdate + 1);
		OnUpdate = onUpdate;
		if (OnLateUpdate != null)
		{
			UnityEngine.Object value = UnityEngine.Object.Instantiate((UnityEngine.Object)pause);
			StringBuilder stringBuilder = ((StringBuilder)(object)OnFixedUpdate).AppendLine((string)(object)value);
			StringBuilder stringBuilder2 = ((StringBuilder)(object)OnFixedUpdate).Append(44);
		}
	}

	public FirstMonobehaviour()
	{
		if (OnOnGUI != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}
