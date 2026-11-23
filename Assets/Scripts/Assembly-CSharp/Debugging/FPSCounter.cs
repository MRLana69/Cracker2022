using System;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using UnityEngine;

namespace Debugging;

public class FPSCounter : MonoBehaviour
{
	public UILabel OptionalMinFPSLabel;

	public float UpdateInterval = 0.5f;

	private UILabel _label;

	private float accum;

	private int frames;

	private float timeleft;

	private float maxFrame;

	private bool _visible;

	private static FPSCounter _instance;

	private GameObject _prefabInstanceRoot;

	public bool Visible => _visible;

	public static FPSCounter Instance => _instance;

	private void Awake()
	{
		_instance = this;
		UILabel component = GetComponent<UILabel>();
		_label = component;
		timeleft = UpdateInterval;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0040: Expected VT, but got Obj
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_03f7: Expected Obj, but got F4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected VT, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		if (~(_visible ? 1u : 0u) != 0)
		{
			return;
		}
		float deltaTime = Time.deltaTime;
		float num = timeleft - deltaTime;
		timeleft = num;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		float timeScale = Time.timeScale;
		float deltaTime2 = Time.deltaTime;
		float num2 = timeScale / deltaTime2;
		float num3 = accum + num2;
		accum = num3;
		int num4 = frames + 1;
		frames = num4;
		float num5 = maxFrame;
		float deltaTime3 = Time.deltaTime;
		if (!(maxFrame > deltaTime3))
		{
			num5 = deltaTime3;
		}
		maxFrame = num5;
		if (timeleft > 0f)
		{
			return;
		}
		float num6 = accum / (float)frames;
		object obj3 = obj + 76;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string text = $"{arg:F1} FPS";
		_label.text = text;
		object obj4 = obj - -64;
		bool flag = num6 > 10f;
		float num7 = 0f;
		if (!flag)
		{
			num7 = 4f / 255f;
		}
		bool flag2 = !(num6 < 30f);
		float num8 = 0f;
		if (!flag2)
		{
			num8 = num7;
		}
		obj4 = num8;
		_ = 1065353216;
		float num9 = 0f;
		if (!flag)
		{
			num9 = 235f / 255f;
		}
		float num10 = 1f;
		if (!flag2)
		{
			num10 = num9;
		}
		float num11 = 0f;
		if (!flag2)
		{
			num11 = 1f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Color color = (Color)(obj + 24);
		_label.color = color;
		accum = 0f;
		timeleft = UpdateInterval;
		if (OptionalMinFPSLabel != null)
		{
			float num12 = 1f / maxFrame;
			object obj5 = obj + 76;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg2 = default;
			string text2 = $"{arg2:F1} MIN";
			OptionalMinFPSLabel.text = text2;
			bool flag3 = num12 > 10f;
			float num13 = 0f;
			if (!flag3)
			{
				num13 = 4f / 255f;
			}
			bool flag4 = !(num12 < 30f);
			float num14 = 0f;
			if (!flag4)
			{
				num14 = num13;
			}
			_ = 1065353216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			float num15 = 0f;
			if (!flag3)
			{
				num15 = 235f / 255f;
			}
			float num16 = 1f;
			if (!flag4)
			{
				num16 = num15;
			}
			float num17 = 0f;
			if (!flag4)
			{
				num17 = 1f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Color color2 = (Color)(obj + 8);
			OptionalMinFPSLabel.color = color2;
			maxFrame = 0f;
		}
	}

	public static FPSCounter Create(GameObject anchor)
	{
		//IL_006f: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(GameObject));
		UnityEngine.Object obj = Resources.Load("Prefabs/Special/FpsCounter", typeFromHandle);
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
		FPSCounter fPSCounter = default;
		fPSCounter._prefabInstanceRoot = prefabInstanceRoot;
		return fPSCounter;
	}

	public void ToggleVisible(bool visible)
	{
		_visible = visible;
		_prefabInstanceRoot.SetActive(visible);
	}
}
