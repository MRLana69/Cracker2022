using System.Collections;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public abstract class HuntTokenCollectVFX : MonoBehaviour
{
	protected ParticleSystem _particleSystem;

	private void Awake()
	{
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	private void Update()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 12;
		ParticleSystem component = GetComponent<ParticleSystem>();
		obj = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public virtual void Setup()
	{
	}

	public abstract IEnumerator PlayEffect();
}
