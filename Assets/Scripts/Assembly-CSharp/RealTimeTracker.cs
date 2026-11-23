using System;
using SYBO.Common.Utilities;
using UnityEngine;

public class RealTimeTracker : MonoBehaviour
{
	private static RealTimeTracker mInst;

	private float mRealTime;

	private float mRealDelta;

	public static float time
	{
		get
		{
			if (mInst == null)
			{
				Spawn();
			}
			RealTimeTracker realTimeTracker = mInst;
			return realTimeTracker.mRealTime;
		}
	}

	public static float deltaTime
	{
		get
		{
			if (mInst == null)
			{
				Spawn();
			}
			RealTimeTracker realTimeTracker = mInst;
			return realTimeTracker.mRealDelta;
		}
	}

	private static void Spawn()
	{
		GameObject gameObject = default;
		gameObject._002Ector("_RealTimeTracker");
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		Transform childTransform = gameObject.transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.Dynamic);
		Transform asLastSibling = gameObject.transform;
		HierarchyUtility.SetAsLastSibling(asLastSibling);
		RealTimeTracker realTimeTracker = gameObject.AddComponent<RealTimeTracker>();
		mInst = realTimeTracker;
		RealTimeTracker realTimeTracker2 = mInst;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		realTimeTracker2.mRealTime = realtimeSinceStartup;
		Transform childTransform2 = gameObject.transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform2, HierarchyPathType.DynamicManagers);
	}

	private void Update()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float num = realtimeSinceStartup - mRealTime;
		mRealTime = realtimeSinceStartup;
		float num2 = Math.Min(num, 1f);
		bool flag = num < 0f;
		float num3 = 0f;
		if (!flag)
		{
			num3 = num2;
		}
		mRealDelta = num3;
	}
}
