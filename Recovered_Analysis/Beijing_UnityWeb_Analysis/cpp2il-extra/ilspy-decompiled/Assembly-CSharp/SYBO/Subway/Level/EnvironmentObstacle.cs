using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class EnvironmentObstacle : Obstacle
{
	private EnvironmentObstacleType _obstacleType;

	private TrackLane _blockedLanes;

	private EnvironmentSegmentLength _obstacleLength;

	private EnvironmentConstraint _environmentConstraint;

	public EnvironmentObstacleType ObstacleType => (EnvironmentObstacleType)_obstacleLength;

	public TrackLane BlockedLanes => (TrackLane)_obstacleType;

	public EnvironmentSegmentLength ObstacleLength => (EnvironmentSegmentLength)_blockedLanes;

	public EnvironmentConstraint EnvironmentConstraint
	{
		get
		{
			//IL_017b: Expected Obj, but got VT
			//IL_0190: Expected VT, but got I
			//IL_019e: Expected I, but got Obj
			//IL_01b4: Expected Obj, but got I
			//IL_010b: Expected Obj, but got VT
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected Obj, but got Unknown
			//IL_0234: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00f2: Expected Obj, but got I
			EnvironmentConstraint environmentConstraint = default;
			((Selector)environmentConstraint).OnDisable();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentConstraint)+10]");
			Transform transform = default;
			transform.position = (Vector3)0;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v7 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v35 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float f = (float)(nint)((Object)transform).m_CachedPtr / 2000f;
			int num3 = Mathf.RoundToInt(f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentConstraint)+20]");
			if ((nint)0 == num3)
			{
				nint num4 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentConstraint)+24]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentConstraint)+24]");
					((List<GameObject>)(object)this).Add((GameObject)0);
				}
			}
			else
			{
				((RandomizerTargetWeightedHold)environmentConstraint).PerformSelection((List<GameObject>)(object)this);
				if (_obstacleType != _obstacleType)
				{
					object obj3 = environmentConstraint + 36;
					int index = (int)(_obstacleType - 1);
					GameObject gameObject = ((List<GameObject>)(object)this).get_Item(index);
					obj3 = gameObject;
				}
			}
			return environmentConstraint;
		}
	}

	private void OnValidate()
	{
		CancelInvoke();
	}

	public EnvironmentObstacle()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0142: Expected Obj, but got I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		object obj = _obstacleType - 1;
		if (_obstacleType != EnvironmentObstacleType.Pillar)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2 && (nint)obj == 3)
				{
					_obstacleLength = EnvironmentSegmentLength.Extended;
					object obj2 = this + 24;
					obj2 = 8;
					object obj3 = this + 24;
					_ = 0;
					object obj4 = this + 24;
					_ = _obstacleLength;
				}
			}
			else
			{
				_blockedLanes = TrackLane.Sides;
				object obj5 = this + 24;
				obj5 = 16;
				object obj6 = this + 24;
				_ = 0;
				object obj7 = this + 24;
				_ = _obstacleLength;
			}
		}
		else
		{
			_blockedLanes = TrackLane.None;
			_obstacleLength = EnvironmentSegmentLength.Standard;
			object obj8 = this + 24;
			obj8 = 4;
			object obj9 = this + 24;
			_ = 0;
			object obj10 = this + 24;
			_ = 2;
		}
	}
}
