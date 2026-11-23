using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class AwardCollectibleHelper : MonoBehaviour
{
	private Image _itemIconSprite;

	private GameObject _completeIcon;

	private GameObject _glitterOverlay;

	private Image _background;

	public unsafe void SetupAwardCollectible(string backgroundToUse, string itemIconName, bool useGlitter, bool isItemCollected = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00e8: Expected I, but got Obj
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected VT, but got Unknown
		//IL_019f: Expected F4, but got I
		//IL_019a: Expected native int or pointer, but got VT
		//IL_01c1: Expected F4, but got I
		//IL_01bc: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 80);
		Transform transform = _itemIconSprite.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float num3 = (float)Vector3.zeroVector * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
		float num4 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		float num5 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion + 16);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		transform.localRotation = quaternion;
		string path = "UI/" + itemIconName;
		Sprite sprite = Resources.Load<Sprite>(path);
		_itemIconSprite.sprite = sprite;
		Image itemIconSprite = _itemIconSprite;
		if (itemIconSprite.m_Sprite == null)
		{
			_completeIcon.SetActive(isItemCollected);
		}
		if (_glitterOverlay != null)
		{
			_glitterOverlay.SetActive(useGlitter);
		}
	}
}
