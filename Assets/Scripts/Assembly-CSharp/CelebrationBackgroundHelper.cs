using Cpp2ILInjected;
using UnityEngine;

public class CelebrationBackgroundHelper : MonoBehaviour
{
	public Transform backgroundRoot;

	public Transform celebrationCloner;

	private bool shouldRotate;

	private AnimationCurve _bragCelebrationAnimationCurve;

	public bool visible
	{
		get
		{
			GameObject gameObject = base.gameObject;
			return gameObject.activeSelf;
		}
		set
		{
			GameObject gameObject = base.gameObject;
			gameObject.SetActive(value);
		}
	}

	public void Hide()
	{
		visible = false;
	}

	public unsafe void Show(Quaternion rotation, bool shouldAnimateStripes, bool shouldRotateBackground)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00cf: Expected native int or pointer, but got VT
		//IL_00e1: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 16);
		if (!visible)
		{
			visible = true;
		}
		GameObject gameObject = celebrationCloner.gameObject;
		bool activeSelf = gameObject.activeSelf;
		if (activeSelf != shouldAnimateStripes)
		{
			GameObject gameObject2 = celebrationCloner.gameObject;
			gameObject2.SetActive(shouldAnimateStripes);
		}
		shouldRotate = shouldRotateBackground;
		((Quaternion*)(nint)quaternion)->z = rotation.z;
		((Quaternion*)(nint)quaternion)->x = rotation.x;
		backgroundRoot.rotation = quaternion;
		InvertParticlesDirection(invert: false);
	}

	public unsafe void SetParticleAnimationSpeed(float speed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00bf: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected VT, but got Unknown
		//IL_0078: Expected Ref, but got VT
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		GameObject gameObject = base.gameObject;
		ParticleSystem[] componentsInChildren = gameObject.GetComponentsInChildren<ParticleSystem>(includeInactive: false);
		object obj3 = 0;
		while (componentsInChildren.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)componentsInChildren + obj4;
			object obj6 = obj - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v19+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v22+8]");
			_ = 0;
			ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)(obj + 8);
			((ParticleSystem.MainModule*)mainModule)->simulationSpeed = speed;
			object obj7 = obj3 + 1;
			obj3 = obj7;
		}
	}

	public unsafe void InvertParticlesDirection(bool invert)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected VT, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected VT, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected VT, but got Unknown
		//IL_007f: Expected F4, but got I
		//IL_007a: Expected native int or pointer, but got VT
		//IL_008e: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 128);
		if (invert)
		{
			_ = 0;
			_ = 0;
			_ = 4812096201845374976L;
			_ = 4812096201845374976L;
			Vector3 localPosition = (Vector3)(quaternion + 16);
			celebrationCloner.localPosition = localPosition;
			_ = 1127481344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			_ = 0;
			((Quaternion*)(nint)quaternion)->x = 0f;
			celebrationCloner.localRotation = quaternion;
		}
		else
		{
			_ = 0;
			_ = 0;
			_ = -4494592428115755008L;
			_ = -4494592428115755008L;
			Vector3 localPosition2 = (Vector3)(quaternion + 48);
			celebrationCloner.localPosition = localPosition2;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(quaternion + 32);
			celebrationCloner.localRotation = localRotation;
		}
	}

	public float GetBragCelebrationAnimationCurveValue(float pos)
	{
		return _bragCelebrationAnimationCurve.Evaluate(pos);
	}

	private void Update()
	{
		if (~(shouldRotate ? 1u : 0u) == 0)
		{
			float deltaTime = Time.deltaTime;
			float zAngle = deltaTime * 45f;
			backgroundRoot.Rotate(0f, 0f, zAngle);
		}
	}
}
