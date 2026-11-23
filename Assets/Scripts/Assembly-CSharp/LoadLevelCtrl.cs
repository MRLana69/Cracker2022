using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevelCtrl : MonoBehaviour
{
	private sealed class _003CStart_003Ed__18(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadLevelCtrl _003C_003E4__this;

		private IEnumerator _003CcacheCoroutine_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected Obj, but got Unknown
			//IL_00c1: Expected I, but got Obj
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected Obj, but got Unknown
			LoadLevelCtrl loadLevelCtrl = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003CcacheCoroutine_003E5__2 = null;
						_003C_003E1__state = -1;
					}
					goto IL_0232;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				if (_003C_003E4__this.OnBlockDomains())
				{
					goto IL_0232;
				}
				TMP_Text tipContent = loadLevelCtrl.tipContent;
				string[] standardTipArray = loadLevelCtrl.standardTipArray;
				int num = UnityEngine.Random.Range(0, standardTipArray.Length);
				int num2 = num << 2;
				object obj = standardTipArray + num2;
				nint num3 = (nint)tipContent;
				object obj2 = tipContent + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ S2_v16 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				AssetBundleManager instance = AssetBundleManager.Instance;
				IEnumerator<float> enumerator = instance.CacheNeededAssetBundles();
				_003CcacheCoroutine_003E5__2 = enumerator;
				loadLevelCtrl.progress = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			if (obj3 == null)
			{
				loadLevelCtrl.progress = loadLevelCtrl.loadingBarBundlesPercentage;
				AsyncOperation asyncMerge = SceneManager.LoadSceneAsync(MergeLevelStartHelp.MERGE_SCENE_NAME_FOR_BUILDS, LoadSceneMode.Additive);
				loadLevelCtrl.asyncMerge = asyncMerge;
				IEnumerator routine = _003C_003E4__this.Progress();
				Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
				_003C_003E2__current = loadLevelCtrl.asyncMerge;
				_003C_003E1__state = 2;
				return true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			throw new NullReferenceException();
			IL_0232:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CProgress_003Ed__19(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadLevelCtrl _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00c1: Expected Obj, but got I
			//IL_023a: Expected Obj, but got I
			//IL_0224: Expected F4, but got I
			LoadLevelCtrl loadLevelCtrl = _003C_003E4__this;
			if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
			{
				if (_003C_003E1__state != 2)
				{
					if (_003C_003E1__state != 3)
					{
						if (_003C_003E1__state != 4)
						{
							if (_003C_003E1__state == 5)
							{
								_003C_003E1__state = -1;
								GC.Collect();
							}
							return false;
						}
						_003C_003E1__state = -1;
						GameObject gameObject = loadLevelCtrl.gameObject;
						UnityEngine.Object.Destroy(gameObject);
						_003C_003E2__current = null;
						_003C_003E1__state = 5;
						return true;
					}
					_003C_003E1__state = -1;
					if (!PoolManager._balancing)
					{
						PoolManager.BalancingBudgetMS = 5;
						continueTime = 0f;
						AsyncOperation asyncOperation = Resources.UnloadUnusedAssets();
						_003C_003E2__current = null;
						_003C_003E1__state = 4;
						return true;
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E1__state = -1;
				PoolManager.BalancingBudgetMS = 50;
				throw new ArgumentException();
			}
			_003C_003E1__state = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (LoadLevelCtrl)+20]");
			if (((AsyncOperation)0).isDone)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (LoadLevelCtrl)+20]");
			float num;
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (LoadLevelCtrl)+3C]");
				num = 0f;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (LoadLevelCtrl)+20]");
				float progress = ((AsyncOperation)0).progress;
				float num2 = progress * 1.11f;
				float num3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (LoadLevelCtrl)+34]");
				float num4 = num3 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (LoadLevelCtrl)+30]");
				float num5 = 0f + num4;
				num = num5;
			}
			if (num > 0.89f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (LoadLevelCtrl)+40]");
				if ((nint)0 == 0)
				{
					_ = 1;
				}
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private string[] ALLOW_DOMAINS;

	private string REDIRECT_URL;

	private Slider slider;

	private TMP_Text tipContent;

	private TMP_Text lable;

	private AsyncOperation asyncMerge;

	private float sliderSteps;

	private bool sliderStepsIsSet;

	private string[] standardTipArray;

	private float loadingBarBundlesPercentage;

	private float sceneLoadPercentage;

	private float prepoolingPercentage;

	private float progress;

	private bool sendDebug;

	public static float continueTime = 99999f;

	private bool OnBlockDomains()
	{
		string check_domains_str = string.Join("|", ALLOW_DOMAINS);
		return DomainLocker.RedirectDomain(check_domains_str, REDIRECT_URL);
	}

	private void Awake()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		if (!OnBlockDomains())
		{
			Transform transform = base.transform;
			GameObject target = transform.gameObject;
			UnityEngine.Object.DontDestroyOnLoad(target);
			PlayerInfo instance = PlayerInfo.Instance;
			instance.HUNT_DEFAULT();
			bool flag = Settings.SFX_DEFAULT();
			bool flag2 = Settings.MUSIC_DEFAULT();
		}
	}

	private void Update()
	{
		LoadBar();
	}

	private IEnumerator Start()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator Progress()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void PoolManager_onProgress(float balancingProgress)
	{
		float num = loadingBarBundlesPercentage + sceneLoadPercentage;
		float num2 = balancingProgress * prepoolingPercentage;
		float num3 = num + num2;
		progress = num3;
	}

	public void LoadBar()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a4: Expected I, but got Obj
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_0054: Expected F8, but got I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0146: Expected I, but got Obj
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		float num;
		if (~(sliderStepsIsSet ? 1u : 0u) == 0)
		{
			num = sliderSteps;
		}
		else
		{
			sliderStepsIsSet = true;
			sliderSteps = 1f;
			num = 1f;
		}
		Slider slider = this.slider;
		float num2 = progress * num;
		float num3 = num2 / num;
		nint num4 = (nint)slider;
		object obj3 = slider + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S2_v4 (Il2CppClass<UnityEngine.UI.Slider>)+234] (should have been resolved before IL gen)");
		TMP_Text tMP_Text = lable;
		double value = (double)num3 * 100.0;
		double num5 = Math.Abs(value);
		if (!(num5 < 2147483648.0))
		{
			value = -2147483648.0;
		}
		object obj4 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string text = $"{arg}%";
		nint num6 = (nint)tMP_Text;
		object obj5 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S2_v12 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public LoadLevelCtrl()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
