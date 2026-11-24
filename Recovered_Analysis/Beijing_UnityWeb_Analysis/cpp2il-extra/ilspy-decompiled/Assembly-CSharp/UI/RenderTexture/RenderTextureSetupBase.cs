using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.RenderTexture;

[Serializable]
public abstract class RenderTextureSetupBase
{
	private UITexture _texture;

	private Vector3 _position;

	private Vector3 _rotation;

	private float _scale;

	private GameObject _prefab;

	private AnimationClip _animationClip;

	protected GameObject _objectInstance;

	protected RenderTextureManager _renderTextureManager;

	public void Setup(CameraSettings overrideCameraSettings = null, bool copySettings = true)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ScrollListPopupCell scrollListPopupCell = default;
		scrollListPopupCell.cellType = ScrollListPopupCellType.Toggle;
		object obj = scrollListPopupCell + 12;
		obj = overrideCameraSettings;
		object obj2 = scrollListPopupCell + 16;
		obj2 = copySettings;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.RenderTexture.RenderTextureSetupBase)+38]");
		((List<ScrollListPopupCell>)0).Add(scrollListPopupCell);
	}

	protected virtual void OnSetup()
	{
	}

	public void ReleaseRenderTexture()
	{
	}

	protected virtual void OnReleaseRenderTexture()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		bool pause = default;
		((ResumeButtonHelper)(object)_renderTextureManager).OnApplicationPause(pause);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		_texture.tag = null;
	}
}
