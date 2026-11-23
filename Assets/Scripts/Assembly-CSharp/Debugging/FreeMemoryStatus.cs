using System;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

namespace Debugging;

public class FreeMemoryStatus : MonoBehaviour
{
	public float UpdateInterval = 0.5f;

	private UILabel _label;

	private float _timeleft;

	private static FreeMemoryStatus _instance;

	private GameObject _prefabInstanceRoot;

	public static FreeMemoryStatus Instance => _instance;

	private void Awake()
	{
		_instance = this;
		UILabel component = GetComponent<UILabel>();
		_label = component;
		_timeleft = UpdateInterval;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		float deltaTime = Time.deltaTime;
		if (!((_timeleft -= deltaTime) > 0f))
		{
			int deviceFreeMemory = DeviceUtility.GetDeviceFreeMemory();
			object obj3 = obj + 44;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			string text = $"{arg} MB Free";
			_label.text = text;
			bool flag = deviceFreeMemory < 51;
			float num = 4f / 255f;
			if (!flag)
			{
				num = 0f;
			}
			bool flag2 = deviceFreeMemory > 99;
			float num2 = 0f;
			if (!flag2)
			{
				num2 = num;
			}
			_ = 1065353216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			float num3 = 235f / 255f;
			if (!flag)
			{
				num3 = 0f;
			}
			float num4 = 1f;
			if (!flag2)
			{
				num4 = num3;
			}
			float num5 = 0f;
			if (!flag2)
			{
				num5 = 1f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Color color = (Color)(obj + 8);
			_label.color = color;
			_timeleft = UpdateInterval;
		}
	}

	public static FreeMemoryStatus Create(GameObject anchor)
	{
		//IL_006f: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(GameObject));
		UnityEngine.Object obj = Resources.Load("Prefabs/Special/FreeMemoryStatus", typeFromHandle);
		bool flag = (object)obj == null;
		UnityEngine.Object prefab = null;
		if (!flag)
		{
			bool flag2 = (object)obj.GetType() == typeof(GameObject);
			prefab = obj;
			if (!flag2)
			{
				prefab = null;
			}
		}
		GameObject prefabInstanceRoot = NGUITools.AddChild(anchor, (GameObject)prefab);
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S3_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		FreeMemoryStatus freeMemoryStatus = default;
		freeMemoryStatus._prefabInstanceRoot = prefabInstanceRoot;
		return freeMemoryStatus;
	}

	public void ToggleVisible(bool visible)
	{
		_prefabInstanceRoot.SetActive(visible);
	}
}
