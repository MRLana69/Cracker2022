using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;

namespace SYBO.Common.Components.Renderers;

public class CurveParentRenderer : MonoBehaviour
{
	private CurveParent _curveParent;

	private GameObject _curveNode;

	protected unsafe void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0139: Expected F4, but got I
		//IL_0134: Expected native int or pointer, but got VT
		//IL_015b: Expected F4, but got I
		//IL_0156: Expected native int or pointer, but got VT
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 80);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (_curveNode != null)
		{
			float maxTime = _curveParent.MaxTime;
			float minTime = _curveParent.MinTime;
			GameObject gameObject = default;
			gameObject._002Ector("CurveNodes");
			Transform childTransform = gameObject.transform;
			Transform parentTransform = transform;
			HierarchyUtility.Reparent(childTransform, parentTransform);
			float num = minTime;
			while (!(num > maxTime))
			{
				Vector3 worldPositionForTime = _curveParent.GetWorldPositionForTime(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+20]");
				_ = 0;
				Quaternion rotationForTime = _curveParent.GetRotationForTime(num, 0.0125f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
				((Quaternion*)(nint)quaternion)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
				((Quaternion*)(nint)quaternion)->x = 0f;
				Vector3 position = (Vector3)(quaternion + 16);
				GameObject gameObject2 = Object.Instantiate(_curveNode, position, quaternion);
				Transform childTransform2 = gameObject2.transform;
				Transform parentTransform2 = gameObject.transform;
				HierarchyUtility.Reparent(childTransform2, parentTransform2);
				float num2 = num + 0.0125f;
				num = num2;
			}
		}
	}
}
