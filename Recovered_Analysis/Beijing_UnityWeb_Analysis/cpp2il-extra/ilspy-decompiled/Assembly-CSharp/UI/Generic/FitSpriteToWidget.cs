using Cpp2ILInjected;
using UnityEngine;

namespace UI.Generic;

public class FitSpriteToWidget : MonoBehaviour
{
	public enum FittingMode
	{
		Constrain,
		Fill,
		FitWidth,
		FitHeight,
		Stretch,
		PixelPerfect,
		MaxSize
	}

	private enum Execute
	{
		Off,
		OnEnable,
		OnStart,
		OnUpdate,
		OnFixedUpdate,
		OnLateUpdate
	}

	private UISprite _spriteToFit;

	private UIWidget _widgetContainer;

	public FittingMode fittingMode;

	private Execute _execute;

	public unsafe UIWidget widgetContainer
	{
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			//IL_0017: Expected Obj, but got I4
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_0077: Expected I4, but got Obj
			//IL_009e: Expected Obj, but got I4
			//IL_00b8: Expected I4, but got Obj
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected Obj, but got Unknown
			//IL_0052: Expected I4, but got Obj
			object obj = default;
			UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 16);
			obj = 0;
			_ = 0;
			if ((object)value != null)
			{
				object obj2 = this + 32;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
				object obj3 = obj2;
			}
			else
			{
				object obj4 = this + 16;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
				object obj3 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ L0_v1+8]");
			_ = 0;
			obj = ((UIWidget.Pivot*)(int)pivot)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5 (UIWidget+Pivot)+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			_spriteToFit.rawPivot = pivot;
		}
	}

	private void OnEnable()
	{
		CancelInvoke();
	}

	private void Start()
	{
		if (_execute == Execute.OnEnable)
		{
			FitStretch();
		}
	}

	private void Update()
	{
		if (_execute == Execute.OnStart)
		{
			FitStretch();
		}
	}

	private void FixedUpdate()
	{
		if (_execute == Execute.OnUpdate)
		{
			FitStretch();
		}
	}

	private void LateUpdate()
	{
		if (_execute == Execute.OnFixedUpdate)
		{
			FitStretch();
		}
	}

	public void FitNow()
	{
		if (_execute == Execute.OnLateUpdate)
		{
			FitStretch();
		}
	}

	private unsafe void FitMaxSize(int spriteWidth, int spriteHeight)
	{
		((UILabel)(object)_spriteToFit).fontSize = spriteWidth;
		UIWidget.Pivot pivot = default;
		((UIWidget.Pivot*)(int)pivot)->value__ = ((int*)spriteHeight)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [spriteHeight @ L2 (System.Int32)+8]");
		_ = 0;
		_widgetContainer.rawPivot = pivot;
	}

	private void FitPixelPerfect(int spriteWidth, int spriteHeight)
	{
		UISprite spriteToFit = _spriteToFit;
		UIWidget uIWidget = _widgetContainer;
		if (((UIWidget)spriteToFit).mHeight <= uIWidget.mHeight)
		{
			UISprite spriteToFit2 = _spriteToFit;
			UIWidget uIWidget2 = _widgetContainer;
			if (((UIWidget)spriteToFit2).mWidth <= uIWidget2.mWidth)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D8E");
				return;
			}
		}
		this._002Ector();
	}

	private void FitStretch()
	{
		//IL_0490: Expected I, but got Obj
		//IL_04a6: Expected Obj, but got I
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_0209: Expected F4, but got I4
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_0242: Expected F4, but got I4
		//IL_027b: Expected F4, but got I4
		//IL_0289: Expected F4, but got I4
		//IL_0594: Expected VT, but got Obj
		//IL_02c2: Expected F4, but got I4
		//IL_033e: Expected I4, but got F4
		//IL_034b: Expected F4, but got I4
		//IL_02fb: Expected F4, but got I4
		//IL_047d: Expected I4, but got F4
		//IL_047d: Expected I4, but got F4
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v75 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 12);
		if (((ComputeShader)(object)_spriteToFit).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_widgetContainer).FindKernel((string)null) == 0)
		{
			return;
		}
		UISprite spriteToFit = _spriteToFit;
		spriteToFit.keepAspectRatio = UIWidget.AspectRatioSource.Free;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		int frames = ((UISpriteAnimation)(object)_spriteToFit).frames;
		int frames2 = ((UISpriteAnimation)(object)_spriteToFit).frames;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v33 (System.Int32)+30]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v29 (System.Int32)+2C]");
		object obj3 = num5 + 0;
		int frames3 = ((UISpriteAnimation)(object)_spriteToFit).frames;
		int frames4 = ((UISpriteAnimation)(object)_spriteToFit).frames;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v25 (System.Int32)+34]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v21 (System.Int32)+38]");
		object obj4 = num6 + 0;
		int frames5 = ((UISpriteAnimation)(object)_spriteToFit).frames;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v30 (System.Int32)+14]");
		object obj5 = obj3 + 0;
		UISprite spriteToFit2 = _spriteToFit;
		float floatSpacingX = ((UILabel)(object)spriteToFit2.mAtlas).floatSpacingX;
		float num7 = (float)obj5 * floatSpacingX;
		if (num7 != num7)
		{
			num7 = -2.1474836E+09f;
		}
		else if (!(num7 < 2.1474836E+09f))
		{
			num7 = -2.1474836E+09f;
		}
		else if (!(num7 > -2.1474836E+09f))
		{
			num7 = -2.1474836E+09f;
		}
		int frames6 = ((UISpriteAnimation)(object)_spriteToFit).frames;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v40 (System.Int32)+18]");
		object obj6 = obj4 + 0;
		UISprite spriteToFit3 = _spriteToFit;
		float floatSpacingX2 = ((UILabel)(object)spriteToFit3.mAtlas).floatSpacingX;
		float num8 = (float)obj6 * floatSpacingX2;
		if (num8 != num8)
		{
			num8 = -2.1474836E+09f;
		}
		else if (!(num8 < 2.1474836E+09f))
		{
			num8 = -2.1474836E+09f;
		}
		else if (!(num8 > -2.1474836E+09f))
		{
			num8 = -2.1474836E+09f;
		}
		GameObject gameObject = _spriteToFit.gameObject;
		GameObject gameObject2 = _widgetContainer.gameObject;
		transform2.position = (Vector3)gameObject2;
		transform = transform2;
		((Object)transform).m_CachedPtr = ((Object)transform2).m_CachedPtr;
		Vector3 localPosition = transform.localPosition;
		UISprite spriteToFit4 = _spriteToFit;
		int num9 = (int)(num7 / num8);
		spriteToFit4.aspectRatio = num9;
		if (fittingMode != FittingMode.Constrain)
		{
			if (fittingMode != FittingMode.Fill)
			{
				if (fittingMode != FittingMode.FitWidth)
				{
					if (fittingMode != FittingMode.FitHeight)
					{
						if (fittingMode != FittingMode.Stretch)
						{
							if (fittingMode != FittingMode.PixelPerfect)
							{
								if (fittingMode == FittingMode.MaxSize)
								{
									FitPixelPerfect((int)num7, (int)num8);
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D8E");
							}
						}
						else
						{
							FitHeight();
						}
					}
					else
					{
						FitWidth();
					}
				}
				else
				{
					FitFill();
				}
			}
			else
			{
				FitConstrain();
			}
		}
		else
		{
			this._002Ector();
		}
	}

	private void FitHeight()
	{
		//IL_004e: Expected Obj, but got I4
		UISprite spriteToFit = _spriteToFit;
		spriteToFit.keepAspectRatio = UIWidget.AspectRatioSource.Free;
		UIWidget uIWidget = _widgetContainer;
		_spriteToFit.height = uIWidget.mWidth;
		UIWidget uIWidget2 = _widgetContainer;
		Color color = ((UIWidget)uIWidget2.mHeight).color;
	}

	private void FitWidth()
	{
		//IL_0030: Expected Obj, but got I4
		UISprite spriteToFit = _spriteToFit;
		spriteToFit.keepAspectRatio = UIWidget.AspectRatioSource.BasedOnHeight;
		UIWidget uIWidget = _widgetContainer;
		Color color = ((UIWidget)uIWidget.mHeight).color;
	}

	private void FitFill()
	{
		UISprite spriteToFit = _spriteToFit;
		spriteToFit.keepAspectRatio = UIWidget.AspectRatioSource.BasedOnWidth;
		UIWidget uIWidget = _widgetContainer;
		_spriteToFit.height = uIWidget.mWidth;
	}

	private void FitConstrain()
	{
		//IL_00a6: Expected Obj, but got I4
		UISprite spriteToFit = _spriteToFit;
		UISprite spriteToFit2 = _spriteToFit;
		UIWidget uIWidget = _widgetContainer;
		if (spriteToFit2.aspectRatio < uIWidget.aspectRatio)
		{
			spriteToFit.keepAspectRatio = UIWidget.AspectRatioSource.BasedOnWidth;
			UIWidget uIWidget2 = _widgetContainer;
			_spriteToFit.height = uIWidget2.mWidth;
		}
		else
		{
			spriteToFit.keepAspectRatio = UIWidget.AspectRatioSource.BasedOnHeight;
			UIWidget uIWidget3 = _widgetContainer;
			Color color = ((UIWidget)uIWidget3.mHeight).color;
		}
	}

	public FitSpriteToWidget()
	{
		//IL_00a9: Expected Obj, but got I4
		UISprite spriteToFit = _spriteToFit;
		UISprite spriteToFit2 = _spriteToFit;
		UIWidget uIWidget = _widgetContainer;
		if (!(spriteToFit2.aspectRatio < uIWidget.aspectRatio))
		{
			spriteToFit.keepAspectRatio = UIWidget.AspectRatioSource.BasedOnWidth;
			UIWidget uIWidget2 = _widgetContainer;
			_spriteToFit.height = uIWidget2.mWidth;
		}
		else
		{
			spriteToFit.keepAspectRatio = UIWidget.AspectRatioSource.BasedOnHeight;
			UIWidget uIWidget3 = _widgetContainer;
			Color color = ((UIWidget)uIWidget3.mHeight).color;
		}
	}
}
