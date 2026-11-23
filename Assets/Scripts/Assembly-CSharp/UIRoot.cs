using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UIRoot : MonoBehaviour
{
	public enum Scaling
	{
		Flexible,
		Constrained,
		ConstrainedOnMobiles
	}

	public enum Constraint
	{
		Fit,
		Fill,
		FitWidth,
		FitHeight
	}

	public static List<UIRoot> list;

	public Scaling scalingStyle;

	public int manualWidth = 1280;

	public int manualHeight;

	public int minimumHeight = 320;

	public int maximumHeight;

	public bool fitWidth;

	public bool fitHeight = true;

	public bool adjustByDPI;

	public bool shrinkPortraitUI;

	private Transform mTrans;

	public Constraint constraint
	{
		get
		{
			if (~(fitWidth ? 1u : 0u) == 0)
			{
				bool flag = (byte)(~(fitHeight ? 1u : 0u)) != 0;
				return (Constraint)((flag ? 1u : 0u) << 1);
			}
			Constraint result = Constraint.FitHeight;
			if (!fitHeight)
			{
				result = Constraint.Fill;
			}
			return result;
		}
	}

	public Scaling activeScaling
	{
		get
		{
			bool flag = scalingStyle == Scaling.ConstrainedOnMobiles;
			Scaling result = Scaling.Constrained;
			if (!flag)
			{
				result = scalingStyle;
			}
			return result;
		}
	}

	public int activeHeight
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_019c: Expected Obj, but got I4
			//IL_01a5: Expected Obj, but got I4
			//IL_01be: Expected Obj, but got I4
			//IL_00fb: Expected Obj, but got I4
			//IL_020a: Expected Obj, but got I
			//IL_00e0: Expected Obj, but got I
			//IL_0471: Unknown result type (might be due to invalid IL or missing references)
			//IL_0476: Expected I4, but got Unknown
			//IL_0164: Expected F8, but got I4
			//IL_0335: Expected F8, but got I4
			//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ae: Expected I4, but got Unknown
			//IL_0439: Unknown result type (might be due to invalid IL or missing references)
			//IL_043e: Expected I4, but got Unknown
			//IL_040c: Expected I4, but got F8
			//IL_049a: Expected I4, but got F8
			//IL_03aa: Expected F8, but got I4
			//IL_02c0: Expected F8, but got I4
			//IL_04d2: Expected I4, but got F8
			//IL_0462: Expected I4, but got F8
			object obj2 = default;
			object obj = obj2 - 16;
			bool flag = scalingStyle == Scaling.ConstrainedOnMobiles;
			Scaling scaling = Scaling.Constrained;
			if (!flag)
			{
				scaling = scalingStyle;
			}
			int num2;
			int num4;
			object obj3;
			if (scaling == Scaling.Flexible)
			{
				Vector2 screenSize = NGUITools.screenSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				num2 = (int)(num / 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				bool flag2 = (nint)0 < (nint)minimumHeight;
				bool flag3 = !flag2;
				bool flag4 = !flag3;
				int num3 = minimumHeight;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					bool flag5 = (nint)0 > (nint)maximumHeight;
					bool flag6 = !flag5;
					num3 = maximumHeight;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					obj3 = 0;
					if (flag6)
					{
						goto IL_03d7;
					}
				}
				object obj4 = num3 * num2;
				num4 = num3;
				obj3 = obj4;
				goto IL_03d7;
			}
			bool flag7 = (byte)(~(fitHeight ? 1u : 0u)) != 0;
			object obj5 = (flag7 ? 1u : 0u) << 1;
			object obj6 = 3;
			if (!fitHeight)
			{
				obj6 = 1;
			}
			if (!fitWidth)
			{
				obj5 = obj6;
			}
			int result;
			if ((nint)obj5 == 3)
			{
				result = manualHeight;
			}
			else
			{
				Vector2 screenSize2 = NGUITools.screenSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj7 = num5 / 0;
				int num6 = manualWidth / manualHeight;
				if (obj5 != null)
				{
					if ((nint)obj5 != 1)
					{
						if ((nint)obj5 != 2)
						{
							result = manualHeight;
						}
						else
						{
							int num7 = manualWidth / obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num9 = default;
							double num8 = Math.Abs(num9);
							if (!(num8 < 2147483648.0))
							{
								num9 = -2147483648.0;
							}
							result = (int)num9;
						}
					}
					else
					{
						bool flag8 = (nint)obj7 > num6;
						bool flag9 = !flag8;
						result = manualHeight;
						if (!flag9)
						{
							int num10 = manualWidth / obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num12 = default;
							double num11 = Math.Abs(num12);
							if (!(num11 < 2147483648.0))
							{
								num12 = -2147483648.0;
							}
							result = (int)num12;
						}
					}
				}
				else
				{
					bool flag10 = (nint)obj7 < num6;
					bool flag11 = !flag10;
					result = manualHeight;
					if (!flag11)
					{
						int num13 = manualWidth / obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
						double num15 = default;
						double num14 = Math.Abs(num15);
						if (!(num14 < 2147483648.0))
						{
							num15 = -2147483648.0;
						}
						result = (int)num15;
					}
				}
			}
			goto IL_041a;
			IL_041a:
			return result;
			IL_03d7:
			int num16 = num4 / num2;
			if (!shrinkPortraitUI)
			{
				num16 = num4;
			}
			if (num4 <= (nint)obj3)
			{
				num16 = num4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num18 = default;
			double num17 = Math.Abs(num18);
			if (!(num17 < 2147483648.0))
			{
				num18 = -2147483648.0;
			}
			bool flag12 = (byte)(~(adjustByDPI ? 1u : 0u)) != 0;
			result = (int)num18;
			if (!flag12)
			{
				int num19 = NGUIMath.AdjustByDPI((float)num18);
				result = num19;
			}
			goto IL_041a;
		}
	}

	public float pixelSizeAdjustment
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_004d: Expected F8, but got I4
			//IL_00ab: Invalid comparison between F8 and I4
			//IL_006a: Expected I4, but got F8
			object obj2 = default;
			object obj = obj2 - 16;
			Vector2 screenSize = NGUITools.screenSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num2 = default;
			double num = Math.Abs(num2);
			if (!(num < 2147483648.0))
			{
				num2 = -2147483648.0;
			}
			if (num2 == -1.0)
			{
				return 1f;
			}
			return GetPixelSizeAdjustment((int)num2);
		}
	}

	public static float GetPixelSizeAdjustment(GameObject go)
	{
		UIRoot uIRoot = NGUITools.FindInParents<UIRoot>(go);
		if (uIRoot != null)
		{
			return uIRoot.pixelSizeAdjustment;
		}
		return 1f;
	}

	public float GetPixelSizeAdjustment(int height)
	{
		//IL_00df: Expected F4, but got I4
		bool flag = height > 2;
		int num = height;
		if (!flag)
		{
			num = 2;
		}
		bool flag2 = scalingStyle == Scaling.ConstrainedOnMobiles;
		Scaling scaling = Scaling.Constrained;
		if (!flag2)
		{
			scaling = scalingStyle;
		}
		if (scaling == Scaling.Constrained)
		{
			int num2 = activeHeight;
			return (float)num2 / (float)num;
		}
		if (minimumHeight > num)
		{
			return (float)minimumHeight / (float)num;
		}
		if (maximumHeight < num)
		{
			int num3 = maximumHeight / num;
			return num3;
		}
		return 1f;
	}

	protected virtual void Awake()
	{
		Transform transform = base.transform;
		mTrans = transform;
	}

	protected virtual void OnEnable()
	{
		list.Add(this);
	}

	protected virtual void OnDisable()
	{
		bool flag = list.Remove(this);
	}

	protected virtual void Start()
	{
		UIOrthoCamera componentInChildren = GetComponentInChildren<UIOrthoCamera>();
		if (componentInChildren != null)
		{
			GameObject gameObject = componentInChildren.gameObject;
			Camera component = gameObject.GetComponent<Camera>();
			componentInChildren.enabled = false;
			if (component != null)
			{
				component.orthographicSize = 1f;
			}
		}
	}

	private void Update()
	{
	}

	public void UpdateScale(bool updateAnchors = true)
	{
	}

	public static void Broadcast(string funcName)
	{
		List<UIRoot> list = UIRoot.list;
		int num = 0;
		while (num < list._size)
		{
			UIRoot uIRoot = UIRoot.list.get_Item(num);
			if (uIRoot != null)
			{
				uIRoot.BroadcastMessage(funcName, SendMessageOptions.DontRequireReceiver);
			}
			int num2 = num + 1;
			num = num2;
		}
	}

	public static void Broadcast(string funcName, object param)
	{
		if (param == null)
		{
			return;
		}
		List<UIRoot> list = UIRoot.list;
		int num = 0;
		while (num < list._size)
		{
			UIRoot uIRoot = UIRoot.list.get_Item(num);
			if (uIRoot != null)
			{
				uIRoot.BroadcastMessage(funcName, param, SendMessageOptions.DontRequireReceiver);
			}
			int num2 = num + 1;
			num = num2;
		}
	}

	public UIRoot()
	{
		//IL_001a: Expected I4, but got I8
		//IL_0029: Expected I4, but got I8
	}

	static UIRoot()
	{
		List<UIRoot> list = default;
		list._002Ector();
		UIRoot.list = list;
	}
}
