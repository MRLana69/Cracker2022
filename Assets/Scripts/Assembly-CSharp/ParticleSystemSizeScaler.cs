using Cpp2ILInjected;
using UnityEngine;

public class ParticleSystemSizeScaler : MonoBehaviour
{
	private unsafe void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected VT, but got Unknown
		//IL_0036: Expected F4, but got I
		//IL_0036: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		ParticleSystem component = GetComponent<ParticleSystem>();
		object obj3 = obj - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v10+8]");
		_ = 0;
		Transform transform = base.transform;
		Vector3 lossyScale = transform.lossyScale;
		ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)(obj + 24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		((ParticleSystem.MainModule*)mainModule)->startSizeMultiplier = 0f;
		component.Stop();
		component.Play(withChildren: true);
	}
}
