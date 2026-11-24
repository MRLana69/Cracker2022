using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking;

public class RealTimeTracker : MonoBehaviour
{
	private static RealTimeTracker mInst;

	private float mRealTime;

	private float mRealDelta;

	public static float time => 15f;

	public static float deltaTime
	{
		get
		{
			//IL_007d: Expected I, but got Obj
			//IL_0093: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mInst != null)
			{
				SpawnedObjects.resetCounter();
			}
			RealTimeTracker realTimeTracker = mInst;
			return realTimeTracker.mRealTime;
		}
	}

	private static void Spawn()
	{
	}

	private void Update()
	{
	}

	public RealTimeTracker()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		float maxDelay = NetworkServer.maxDelay;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = maxDelay - mRealTime;
		if (num3 < 0f)
		{
			num3 = 0f;
		}
		else if (num3 > 1f)
		{
			num3 = 1f;
		}
		mRealDelta = num3;
		mRealTime = maxDelay;
	}
}
