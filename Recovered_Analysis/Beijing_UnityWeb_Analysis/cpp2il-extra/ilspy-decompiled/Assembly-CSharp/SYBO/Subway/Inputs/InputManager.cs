using System;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Components.Utilities.Validators;
using SYBO.Subway.Coins;
using SYBO.Subway.Managers;
using UnityEngine;

namespace SYBO.Subway.Inputs;

public class InputManager : SingletonMonoBehaviour<InputManager>
{
	private EventHandler<InputEventArgs> m_OnInputEvent;

	private Game.SwipeInfo _swipeInfo;

	private bool _isEnabled;

	private InputEventArgs _previousInputEventArgs;

	private InputEventArgs _currentInputEventArgs;

	private Swipe _currentSwipe;

	private float _lastTapTime;

	private bool WasButtonClicked__BackingField;

	private Camera __gameCamera;

	private Camera __menuCamera;

	private int _lastInputFrame;

	public bool IsEnabled
	{
		get
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected Obj, but got Unknown
			//IL_0042: Expected Obj, but got I
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected Obj, but got Unknown
			//IL_006a: Expected Obj, but got I
			//IL_001f: Expected I4, but got Obj
			object obj2 = default;
			object obj = obj2 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Inputs.InputManager)+8]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object obj3 = obj2 + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Inputs.InputManager)+C]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = this.m_OnInputEvent;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			object arg = default;
			object arg2 = default;
			return (byte)(int)string.Format((IFormatProvider)(object)"[InputEventArgs: InputType={0}, TimeStamp={1}, KeyCode={2}]", format, arg, arg2) != 0;
		}
		set
		{
			//IL_0066: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnInputEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public InputEventArgs PreviousInputEventArgs
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool isEnabled = _isEnabled;
			return (InputEventArgs)isEnabled;
		}
	}

	public InputEventArgs CurrentInputEventArgs => _previousInputEventArgs;

	public bool WasButtonClicked
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_currentInputEventArgs != 0;
		}
		set
		{
			//IL_0021: Expected Obj, but got I4
			bool isEnabled = _isEnabled;
			object obj = isEnabled ^ value;
			if (obj != null)
			{
				_isEnabled = value;
			}
		}
	}

	private Camera _gameCamera
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = WasButtonClicked__BackingField;
			return (Camera)flag;
		}
	}

	private Camera _menuCamera
	{
		get
		{
			//IL_0098: Expected I, but got Obj
			//IL_00ae: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (__gameCamera != null)
			{
				object obj2 = this + 48;
				GameObject gameObject = ((GameObject)(object)"Main Camera").gameObject;
				Camera component = gameObject.GetComponent<Camera>();
				obj2 = component;
			}
			return __gameCamera;
		}
	}

	public event EventHandler<InputEventArgs> OnInputEvent
	{
		add
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			this.m_OnInputEvent = null;
			float deltaTime = Time.deltaTime;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnInputEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	protected void Start()
	{
		((Validator<>)(object)this)._002Ector();
	}

	private void FixedUpdate()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		InputManager inputManager = default;
		inputManager.ConvertSwipeToInputEventAndRaise(null, SwipeDir.Up);
		object obj = this + 32;
		obj = inputManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		InputManager inputManager2 = default;
		inputManager2.ConvertSwipeToInputEventAndRaise(null, SwipeDir.Up);
		object obj2 = this + 28;
		obj2 = inputManager2;
	}

	protected void Update()
	{
		SubclassInitialize();
	}

	private void ProcessKeyCode(KeyCode keyCode)
	{
		bool flag = (byte)(keyCode & (KeyCode)1) != 0;
		WasButtonClicked__BackingField = flag;
	}

	private void HandleControls()
	{
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected Obj, but got Unknown
		//IL_05d8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I4
		//IL_063d: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I4
		//IL_00e2: Expected I, but got Obj
		//IL_022f: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I4
		//IL_017a: Expected I4, but got Obj
		//IL_0282: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I4
		//IL_01cd: Expected I4, but got Obj
		//IL_02d6: Expected Obj, but got I4
		//IL_02e1: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I4
		//IL_0220: Expected I4, but got Obj
		//IL_02f1: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I4
		//IL_0273: Expected I4, but got Obj
		//IL_030c: Expected Obj, but got I4
		//IL_0317: Expected Obj, but got I4
		//IL_02c6: Expected I4, but got Obj
		//IL_0327: Expected Obj, but got I4
		//IL_0332: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got I4
		//IL_034d: Expected Obj, but got I4
		//IL_035d: Expected Obj, but got I4
		//IL_0368: Expected Obj, but got I4
		//IL_0378: Expected Obj, but got I4
		//IL_0383: Expected Obj, but got I4
		//IL_0393: Expected Obj, but got I4
		//IL_039e: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I4
		//IL_03b9: Expected Obj, but got I4
		//IL_03c9: Expected Obj, but got I4
		//IL_03d4: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I4
		//IL_041a: Expected Obj, but got I4
		//IL_0425: Expected Obj, but got I4
		//IL_0435: Expected Obj, but got I4
		//IL_0440: Expected Obj, but got I4
		//IL_0450: Expected Obj, but got I4
		//IL_045b: Expected Obj, but got I4
		//IL_046b: Expected Obj, but got I4
		//IL_0476: Expected Obj, but got I4
		//IL_0486: Expected Obj, but got I4
		//IL_0491: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I4
		//IL_04ac: Expected Obj, but got I4
		//IL_04bc: Expected Obj, but got I4
		//IL_04c7: Expected Obj, but got I4
		//IL_04d7: Expected Obj, but got I4
		//IL_04e2: Expected Obj, but got I4
		//IL_04f2: Expected Obj, but got I4
		//IL_04fd: Expected Obj, but got I4
		//IL_050d: Expected Obj, but got I4
		//IL_0518: Expected Obj, but got I4
		//IL_0528: Expected Obj, but got I4
		//IL_0533: Expected Obj, but got I4
		//IL_0543: Expected Obj, but got I4
		//IL_054e: Expected Obj, but got I4
		//IL_055e: Expected Obj, but got I4
		//IL_0569: Expected Obj, but got I4
		//IL_0579: Expected Obj, but got I4
		//IL_0584: Expected Obj, but got I4
		//IL_0594: Expected Obj, but got I4
		//IL_059f: Expected Obj, but got I4
		//IL_05af: Expected Obj, but got I4
		//IL_05ba: Expected Obj, but got I4
		if (~(_isEnabled ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v13 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v127 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (System.Boolean)+C4]");
			if ((nint)0 != 0)
			{
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v114 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v123 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated2 = Game.IsInstantiated;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v119 (System.Boolean)+60]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v120+8]");
				if ((nint)0 == 0)
				{
					goto IL_05c4;
				}
			}
			SubclassInitialize();
			if (Input.GetKeyDown((string)273))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InputManager inputManager = default;
				inputManager.OnInputEvent += (EventHandler<InputEventArgs>)1;
				((Coin)(object)this).ToggleRenderer((byte)(int)inputManager != 0);
			}
			if (Input.GetKeyDown((string)274))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InputManager inputManager2 = default;
				inputManager2.OnInputEvent += (EventHandler<InputEventArgs>)2;
				((Coin)(object)this).ToggleRenderer((byte)(int)inputManager2 != 0);
			}
			if (Input.GetKeyDown((string)276))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InputManager inputManager3 = default;
				inputManager3.OnInputEvent += (EventHandler<InputEventArgs>)3;
				((Coin)(object)this).ToggleRenderer((byte)(int)inputManager3 != 0);
			}
			if (Input.GetKeyDown((string)275))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InputManager inputManager4 = default;
				inputManager4.OnInputEvent += (EventHandler<InputEventArgs>)4;
				((Coin)(object)this).ToggleRenderer((byte)(int)inputManager4 != 0);
			}
			if (Input.GetKeyDown((string)32))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InputManager inputManager5 = default;
				inputManager5.OnInputEvent += (EventHandler<InputEventArgs>)6;
				((Coin)(object)this).ToggleRenderer((byte)(int)inputManager5 != 0);
			}
			SendInputEvent((InputEventArgs)48);
			SendInputEvent((InputEventArgs)49);
			SendInputEvent((InputEventArgs)50);
			SendInputEvent((InputEventArgs)51);
			SendInputEvent((InputEventArgs)52);
			SendInputEvent((InputEventArgs)53);
			SendInputEvent((InputEventArgs)54);
			SendInputEvent((InputEventArgs)55);
			SendInputEvent((InputEventArgs)56);
			SendInputEvent((InputEventArgs)57);
			SendInputEvent((InputEventArgs)256);
			SendInputEvent((InputEventArgs)257);
			SendInputEvent((InputEventArgs)258);
			SendInputEvent((InputEventArgs)259);
			SendInputEvent((InputEventArgs)260);
			SendInputEvent((InputEventArgs)261);
			SendInputEvent((InputEventArgs)262);
			SendInputEvent((InputEventArgs)263);
			SendInputEvent((InputEventArgs)264);
			SendInputEvent((InputEventArgs)265);
			SendInputEvent((InputEventArgs)43);
			SendInputEvent((InputEventArgs)270);
			SendInputEvent((InputEventArgs)45);
			SendInputEvent((InputEventArgs)269);
			SendInputEvent((InputEventArgs)61);
			SendInputEvent((InputEventArgs)272);
			SendInputEvent((InputEventArgs)44);
			SendInputEvent((InputEventArgs)46);
			SendInputEvent((InputEventArgs)62);
			SendInputEvent((InputEventArgs)60);
			SendInputEvent((InputEventArgs)97);
			SendInputEvent((InputEventArgs)98);
			SendInputEvent((InputEventArgs)99);
			SendInputEvent((InputEventArgs)100);
			SendInputEvent((InputEventArgs)101);
			SendInputEvent((InputEventArgs)102);
			SendInputEvent((InputEventArgs)103);
			SendInputEvent((InputEventArgs)104);
			SendInputEvent((InputEventArgs)105);
			SendInputEvent((InputEventArgs)106);
			SendInputEvent((InputEventArgs)107);
			SendInputEvent((InputEventArgs)108);
			SendInputEvent((InputEventArgs)109);
			SendInputEvent((InputEventArgs)110);
			SendInputEvent((InputEventArgs)111);
			SendInputEvent((InputEventArgs)112);
			SendInputEvent((InputEventArgs)113);
			SendInputEvent((InputEventArgs)114);
			SendInputEvent((InputEventArgs)115);
			SendInputEvent((InputEventArgs)116);
			SendInputEvent((InputEventArgs)117);
			SendInputEvent((InputEventArgs)118);
			SendInputEvent((InputEventArgs)119);
			SendInputEvent((InputEventArgs)120);
			SendInputEvent((InputEventArgs)121);
			SendInputEvent((InputEventArgs)122);
			return;
		}
		goto IL_05c4;
		IL_05c4:
		object obj4 = this + 36;
		obj4 = 0;
	}

	private SwipeDir AnalyzeSwipe(Swipe nextSwipe)
	{
		bool flag = ((QualitySettingsManager)null).HasQualityLevelIntFromName((string)(object)nextSwipe);
		return ((flag ? 1 : 0) != -1) ? SwipeDir.Down : SwipeDir.Up;
	}

	private bool HandleTap()
	{
		//IL_0098: Expected I, but got Obj
		//IL_00ae: Expected Obj, but got I
		//IL_00d2: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (__menuCamera != null)
		{
			object obj2 = this + 52;
			GameObject gameObject = ((GameObject)(object)"1normal 2D Camera").gameObject;
			Camera component = gameObject.GetComponent<Camera>();
			obj2 = component;
		}
		return (byte)(int)__menuCamera != 0;
	}

	private void ConvertSwipeToInputEventAndRaise(Swipe swipe, SwipeDir swipeDir)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventArgs);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<System.EventArgs>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		this.m_OnInputEvent = (EventHandler<InputEventArgs>)swipeDir;
		float deltaTime = Time.deltaTime;
	}

	protected unsafe override void SubclassInitialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected VT, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected Obj, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected Obj, but got Unknown
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected Obj, but got Unknown
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Expected Obj, but got Unknown
		//IL_072a: Expected Obj, but got I4
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected Obj, but got Unknown
		//IL_076b: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_008a: Expected F4, but got Obj
		//IL_0085: Expected native int or pointer, but got VT
		//IL_009f: Expected F4, but got I
		//IL_009a: Expected native int or pointer, but got VT
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00bc: Expected Obj, but got F4
		//IL_0141: Expected F4, but got Obj
		//IL_013c: Expected native int or pointer, but got VT
		//IL_0156: Expected F4, but got I
		//IL_0151: Expected native int or pointer, but got VT
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got F4
		//IL_01ae: Expected VT, but got Obj
		//IL_0307: Expected Obj, but got F4
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_0239: Expected F4, but got Obj
		//IL_0234: Expected native int or pointer, but got VT
		//IL_024e: Expected F4, but got I
		//IL_0249: Expected native int or pointer, but got VT
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_026b: Expected Obj, but got F4
		//IL_01e7: Expected I4, but got Obj
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I4
		//IL_02a6: Expected VT, but got Obj
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03e8: Expected Obj, but got I
		//IL_03fe: Expected I, but got Obj
		//IL_0414: Expected Obj, but got I
		//IL_084f: Expected F4, but got Obj
		//IL_084a: Expected native int or pointer, but got VT
		//IL_0869: Expected F4, but got Obj
		//IL_0864: Expected native int or pointer, but got VT
		//IL_087e: Expected F4, but got I
		//IL_0879: Expected native int or pointer, but got VT
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected Obj, but got Unknown
		//IL_089b: Expected Obj, but got F4
		//IL_051c: Expected Obj, but got I
		//IL_0532: Expected I, but got Obj
		//IL_0548: Expected Obj, but got I
		//IL_043f: Expected I, but got Obj
		//IL_0917: Expected F4, but got Obj
		//IL_0912: Expected native int or pointer, but got VT
		//IL_0931: Expected F4, but got Obj
		//IL_092c: Expected native int or pointer, but got VT
		//IL_0946: Expected F4, but got I
		//IL_0941: Expected native int or pointer, but got VT
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected Obj, but got Unknown
		//IL_0963: Expected Obj, but got F4
		//IL_0979: Expected VT, but got Obj
		//IL_0573: Expected I, but got Obj
		//IL_0628: Expected Obj, but got I
		//IL_063e: Expected I, but got Obj
		//IL_0654: Expected Obj, but got I
		//IL_05bc: Expected I4, but got Obj
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got Unknown
		//IL_05d4: Expected Obj, but got I4
		//IL_09bd: Expected F4, but got Obj
		//IL_09b8: Expected native int or pointer, but got VT
		//IL_09d7: Expected F4, but got Obj
		//IL_09d2: Expected native int or pointer, but got VT
		//IL_09ec: Expected F4, but got I
		//IL_09e7: Expected native int or pointer, but got VT
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Expected Obj, but got Unknown
		//IL_0a09: Expected Obj, but got F4
		//IL_0a1f: Expected VT, but got Obj
		//IL_067f: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 192;
		Vector4 vector = (Vector4)(obj2 + 120);
		object obj3 = obj2 + 40;
		object obj4 = obj2 + 32;
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 16;
		object obj7 = obj2 + 52;
		obj7 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj8 = obj7 - -64;
		obj8 = 0;
		int renderedFrameCount = Time.renderedFrameCount;
		if (renderedFrameCount == _lastInputFrame)
		{
			return;
		}
		int renderedFrameCount2 = Time.renderedFrameCount;
		_lastInputFrame = renderedFrameCount2;
		if (Input.GetKeyDown((string)323))
		{
			object obj9 = this + 36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj10 = default;
			obj9 = obj10;
			Vector2 mouseScrollDelta = Input.mouseScrollDelta;
			((Vector4*)(nint)vector)->x = (float)obj2;
			Vector4 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector4*)(nint)vector2)->z = 0f;
			object obj11 = _currentSwipe + 8;
			obj11 = vector.x;
			_ = vector.z;
			Swipe currentSwipe = _currentSwipe;
			float timeSinceLevelLoad = Time.timeSinceLevelLoad;
			currentSwipe.startTime = timeSinceLevelLoad;
		}
		if ((Input.GetKeyUp(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Mouse0)) && _currentSwipe != null)
		{
			Vector2 mouseScrollDelta2 = Input.mouseScrollDelta;
			((Vector4*)(nint)vector)->x = (float)obj2;
			Vector4 vector3 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector4*)(nint)vector3)->z = 0f;
			object obj12 = _currentSwipe + 20;
			obj12 = vector.x;
			_ = vector.z;
			Swipe currentSwipe2 = _currentSwipe;
			float timeSinceLevelLoad2 = Time.timeSinceLevelLoad;
			currentSwipe2.endTime = timeSinceLevelLoad2;
			Coin coin = ((CoinCurve)(object)this).SpawnCoin((Vector3)_currentSwipe);
			if ((nint)coin != 4)
			{
				Vector3 coinPosition = ((CoinCurve)null).GetCoinPosition((int)coin);
				object obj13 = this + 36;
				obj13 = 0;
			}
		}
		if (Input.GetKeyDown(KeyCode.Mouse0) && _currentSwipe != null)
		{
			Vector2 mouseScrollDelta3 = Input.mouseScrollDelta;
			((Vector4*)(nint)vector)->x = (float)obj2;
			Vector4 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector4*)(nint)vector4)->z = 0f;
			object obj14 = _currentSwipe + 20;
			obj14 = vector.x;
			_ = vector.z;
			Swipe currentSwipe3 = _currentSwipe;
			float timeSinceLevelLoad3 = Time.timeSinceLevelLoad;
			currentSwipe3.endTime = timeSinceLevelLoad3;
			Coin coin2 = ((CoinCurve)(object)this).SpawnCoin((Vector3)_currentSwipe);
			if ((nint)coin2 == 4)
			{
				string text = ((Swipe)(object)this).ToString();
			}
		}
		bool touchSupported = Input.touchSupported;
		if ((touchSupported ? 1 : 0) <= (false ? 1 : 0))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11712");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8187");
		obj7 = vector.x;
		_ = vector.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector4)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector4)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector4)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector4)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector4)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector4)+38]");
		_ = 0;
		object obj15 = obj7 - -64;
		object obj16 = vector - -64;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+24]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		object obj17 = obj;
		if (!flag2)
		{
			object obj18 = this + 36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj19 = default;
			obj18 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
			obj = 0;
			obj2 = obj;
			nint num = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S1_v135 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num2 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S1_v151 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = obj2;
			((Vector4*)(nint)vector)->x = (float)obj4;
			Vector3 vector5 = vector;
			((Vector4*)(nint)vector)->x = (float)obj3;
			Vector4 vector6 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((Vector4*)(nint)vector6)->z = 0f;
			object obj21 = _currentSwipe + 8;
			obj21 = vector.x;
			_ = vector.z;
			Swipe currentSwipe4 = _currentSwipe;
			float timeSinceLevelLoad4 = Time.timeSinceLevelLoad;
			currentSwipe4.startTime = timeSinceLevelLoad4;
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+24]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+24]");
			if ((nint)0 != 3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+24]");
				if ((nint)0 != 4)
				{
					goto IL_08d2;
				}
			}
		}
		if (_currentSwipe != null)
		{
			Swipe currentSwipe5 = _currentSwipe;
			float timeSinceLevelLoad5 = Time.timeSinceLevelLoad;
			currentSwipe5.endTime = timeSinceLevelLoad5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
			obj17 = 0;
			obj2 = obj17;
			nint num3 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S1_v98 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num4 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S1_v118 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = obj2;
			((Vector4*)(nint)vector)->x = (float)obj5;
			Vector3 vector7 = vector;
			((Vector4*)(nint)vector)->x = (float)obj3;
			Vector4 vector8 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((Vector4*)(nint)vector8)->z = 0f;
			object obj23 = _currentSwipe + 20;
			obj23 = vector.x;
			_ = vector.z;
			Coin coin3 = ((CoinCurve)(object)this).SpawnCoin((Vector3)_currentSwipe);
			if ((nint)coin3 != 4)
			{
				Vector3 coinPosition2 = ((CoinCurve)null).GetCoinPosition((int)coin3);
				object obj24 = this + 36;
				obj24 = 0;
			}
		}
		goto IL_08d2;
		IL_08d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+24]");
		if ((nint)0 != 3 || _currentSwipe == null)
		{
			return;
		}
		Swipe currentSwipe6 = _currentSwipe;
		float timeSinceLevelLoad6 = Time.timeSinceLevelLoad;
		currentSwipe6.endTime = timeSinceLevelLoad6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
		obj17 = 0;
		obj2 = obj17;
		nint num5 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S1_v66 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num6 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S1_v84 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj6 = obj2;
		((Vector4*)(nint)vector)->x = (float)obj6;
		Vector3 vector9 = vector;
		((Vector4*)(nint)vector)->x = (float)obj3;
		Vector4 vector10 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((Vector4*)(nint)vector10)->z = 0f;
		object obj26 = _currentSwipe + 20;
		obj26 = vector.x;
		_ = vector.z;
		Coin coin4 = ((CoinCurve)(object)this).SpawnCoin((Vector3)_currentSwipe);
		if ((nint)coin4 == 4)
		{
			string text2 = ((Swipe)(object)this).ToString();
		}
	}

	public void SendInputEvent(InputEventArgs inputEventArgs)
	{
		//IL_00fb: Expected I4, but got Obj
		//IL_0075: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected Obj, but got I4
		//IL_0134: Expected I4, but got Obj
		//IL_0134: Expected Obj, but got I4
		//IL_00ed: Expected I4, but got Obj
		//IL_00ae: Expected I4, but got Obj
		//IL_00ae: Expected Obj, but got I4
		//IL_0143: Expected I4, but got Obj
		//IL_00bd: Expected I4, but got Obj
		InputEventArgs previousInputEventArgs = _previousInputEventArgs;
		if (previousInputEventArgs._inputType != InputType.KeyDownEnter)
		{
			InputEventArgs previousInputEventArgs2 = _previousInputEventArgs;
			if (previousInputEventArgs2._inputType != InputType.KeyDownStay)
			{
				goto IL_0175;
			}
		}
		InputEventArgs previousInputEventArgs3 = _previousInputEventArgs;
		if ((nint)previousInputEventArgs3._keyCode == (nint)inputEventArgs && Input.GetKeyUp((KeyCode)inputEventArgs))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InputManager inputManager = default;
			inputManager.ConvertSwipeToInputEventAndRaise((Swipe)8, (SwipeDir)inputEventArgs);
			((Coin)(object)this).ToggleRenderer((byte)(int)inputManager != 0);
		}
		goto IL_0175;
		IL_0175:
		if (Input.GetKeyDown((string)(object)inputEventArgs))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InputManager inputManager2 = default;
			inputManager2.ConvertSwipeToInputEventAndRaise((Swipe)7, (SwipeDir)inputEventArgs);
			((Coin)(object)this).ToggleRenderer((byte)(int)inputManager2 != 0);
		}
		if (Input.GetKeyDown((KeyCode)inputEventArgs))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InputManager inputManager3 = default;
			inputManager3.ConvertSwipeToInputEventAndRaise((Swipe)9, (SwipeDir)inputEventArgs);
			((Coin)(object)this).ToggleRenderer((byte)(int)inputManager3 != 0);
		}
	}

	private void RaiseOnInputEvent(InputEventArgs inputEventArgs)
	{
		//IL_000a: Expected I4, but got Obj
		((Coin)(object)this).ToggleRenderer((byte)(int)inputEventArgs != 0);
	}

	public InputManager()
	{
		//IL_001d: Expected VT, but got I4
		GameObject childTransform = gameObject;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)childTransform, HierarchyPathType.DynamicManagers, (Vector3)0);
	}
}
