using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Performance;

public static class AndroidGPUCategorizer
{
	public delegate void UknownGPUHandler(string gpuName);

	private const string GPU_SCORES_PATH = "Kiloo/Performance/AndroidGPUScores";

	private static Dictionary<string, int> _gpuScores;

	private static bool _isInitialized;

	private static int gpuScore__BackingField;

	private static GPUCategory gpuCategory__BackingField;

	private static UknownGPUHandler m__unknownGPUHandler;

	public static int gpuScore
	{
		get
		{
			return gpuScore__BackingField;
		}
		private set
		{
			gpuScore__BackingField = value;
		}
	}

	public static GPUCategory gpuCategory
	{
		get
		{
			return gpuCategory__BackingField;
		}
		private set
		{
			gpuCategory__BackingField = value;
		}
	}

	public static string gpuInfo
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			string graphicsDeviceName = SystemInfo.GetGraphicsDeviceName();
			throw new ArrayTypeMismatchException();
		}
	}

	private static event UknownGPUHandler _unknownGPUHandler
	{
		add
		{
			Delegate obj = AndroidGPUCategorizer.m__unknownGPUHandler;
			UknownGPUHandler uknownGPUHandler = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AndroidGPUCategorizer.m__unknownGPUHandler;
				UknownGPUHandler unknownGPUHandler = uknownGPUHandler;
				if (!flag)
				{
					unknownGPUHandler = AndroidGPUCategorizer.m__unknownGPUHandler;
				}
				AndroidGPUCategorizer.m__unknownGPUHandler = unknownGPUHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AndroidGPUCategorizer.m__unknownGPUHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = AndroidGPUCategorizer.m__unknownGPUHandler;
			UknownGPUHandler uknownGPUHandler = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AndroidGPUCategorizer.m__unknownGPUHandler;
				UknownGPUHandler unknownGPUHandler = uknownGPUHandler;
				if (!flag)
				{
					unknownGPUHandler = AndroidGPUCategorizer.m__unknownGPUHandler;
				}
				AndroidGPUCategorizer.m__unknownGPUHandler = unknownGPUHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AndroidGPUCategorizer.m__unknownGPUHandler;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static bool IsSupportedOnPlatform()
	{
		RuntimePlatform platform = Application.platform;
		bool flag = platform == RuntimePlatform.Android;
		bool result = true;
		if (!flag)
		{
			RuntimePlatform platform2 = Application.platform;
			bool flag2 = platform2 == RuntimePlatform.MetroPlayerARM;
			result = true;
			if (!flag2)
			{
				RuntimePlatform platform3 = Application.platform;
				bool flag3 = platform3 == RuntimePlatform.WindowsPlayer;
				result = flag3;
			}
		}
		return result;
	}

	public static void Initialize(CategoryThresholds thresholds, UknownGPUHandler unknownGPUHandler = null)
	{
		Dictionary<string, int> gpuScores = LoadGPUScores();
		_gpuScores = gpuScores;
		AndroidGPUCategorizer.m__unknownGPUHandler = unknownGPUHandler;
		_isInitialized = true;
		CalculateGpuCaterogy(thresholds);
	}

	public static void CalculateGpuCaterogy(CategoryThresholds thresholds)
	{
		if (~(_isInitialized ? 1u : 0u) == 0)
		{
			GPUCategory category = GetCategory(_gpuScores, thresholds, AndroidGPUCategorizer.m__unknownGPUHandler);
			gpuCategory__BackingField = category;
		}
	}

	private static Dictionary<string, int> LoadGPUScores()
	{
		//IL_0054: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, int> gpuScores = default;
		_gpuScores = gpuScores;
		TextAsset textAsset = Resources.Load<TextAsset>("Kiloo/Performance/AndroidGPUScores");
		string text = textAsset.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		char[] array = default;
		array[0] = '\n';
		string[] array2 = text.Split(array, StringSplitOptions.RemoveEmptyEntries);
		object obj = 0;
		Array array3 = default;
		while (array2.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array2 + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			RuntimeHelpers.InitializeArray(array3, __ldtoken(_003CPrivateImplementationDetails_003E._3666EA94685132CCFEE315C03056C8D1FE580C09D2170A600B81910AB12B76F5));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v37+10]");
			string text2 = ((string)0).Trim((char[])array3);
			if (text2._stringLength != 0)
			{
				char c = text2.get_Chars(0);
				if (c != '#')
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v37+10]");
					string[] array4 = ((string)0).Split(' ');
					int num3 = int.Parse(array4[1]);
					nint num4 = 0;
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ S5_v6+4] (should have been resolved before IL gen)");
				}
			}
			object obj5 = obj + 1;
			obj = obj5;
		}
		return _gpuScores;
	}

	private static GPUCategory GetCategory(Dictionary<string, int> gpuToScore, CategoryThresholds thresholds, UknownGPUHandler unknownGPUHandler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I4
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_067e: Invalid comparison between I4 and VT
		//IL_01ae: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		GPUCategory result = default;
		if (IsSupportedOnPlatform())
		{
			string trimmedGPUName = GetTrimmedGPUName();
			object obj3 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj4 = obj + 40;
			obj = obj4;
			_ = 0;
			string text = string.Empty;
			object obj6 = default;
			object obj7 = default;
			GPUCategory gPUCategory = default;
			GPUCategory gPUCategory2 = default;
			object obj9 = default;
			object obj10 = default;
			GPUCategory gPUCategory3 = default;
			GPUCategory result2 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				string text2;
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj6 == null)
					{
						text2 = text;
						goto IL_0463;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
					obj = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj7 == null)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
								object obj8 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S0_v148+8]");
									if ((nint)0 <= (nint)text._stringLength)
									{
										continue;
									}
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [52FB60]");
												if ((nint)0 == 0)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														goto IL_037a;
													}
													_ = 1;
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
													gpuScore__BackingField = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
													text = (string)0;
													continue;
												}
											}
										}
										goto IL_037a;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				text2 = text;
				result = gPUCategory;
				goto IL_03eb;
				IL_037a:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				text2 = (string)0;
				result = gPUCategory2;
				goto IL_03eb;
				IL_03eb:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				if (obj9 == obj10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_0463;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result = gPUCategory3;
				}
				_ = 0;
				object obj11 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					goto IL_06a8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return result2;
				IL_06a8:
				if (unknownGPUHandler != null)
				{
					string graphicsDeviceName = SystemInfo.GetGraphicsDeviceName();
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: unknownGPUHandler.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				break;
				IL_065e:
				result = GPUCategory.Unknown;
				object obj12;
				if (obj12 == null)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)gpuScore__BackingField) < System.Runtime.CompilerServices.Unsafe.As<CategoryThresholds, UIntPtr>(ref thresholds);
					GPUCategory gPUCategory4 = GPUCategory.Low;
					if (!flag)
					{
						gPUCategory4 = GPUCategory.High;
					}
					result = gPUCategory4;
					break;
				}
				goto IL_06a8;
				IL_0463:
				object obj13 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @126E");
				if (text2 != null)
				{
					obj12 = 0;
					if (text2._stringLength != 0)
					{
						goto IL_065e;
					}
				}
				obj12 = 1;
				goto IL_065e;
			}
		}
		return result;
	}

	private static string GetTrimmedGPUName()
	{
		string graphicsDeviceName = SystemInfo.GetGraphicsDeviceName();
		string text = graphicsDeviceName.ToLower();
		string input = text.Replace("(tm)", string.Empty);
		Regex regex = default;
		regex._002Ector("[^a-z0-9]");
		return regex.Replace(input, string.Empty);
	}

	private static GPUCategory GetCategoryFromScore(int score, CategoryThresholds thresholds)
	{
		//IL_0008: Invalid comparison between I4 and VT
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)score) < System.Runtime.CompilerServices.Unsafe.As<CategoryThresholds, UIntPtr>(ref thresholds);
		GPUCategory result = GPUCategory.Low;
		if (!flag)
		{
			result = GPUCategory.High;
		}
		return result;
	}

	static AndroidGPUCategorizer()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, int> gpuScores = default;
		_gpuScores = gpuScores;
		_isInitialized = false;
	}
}
