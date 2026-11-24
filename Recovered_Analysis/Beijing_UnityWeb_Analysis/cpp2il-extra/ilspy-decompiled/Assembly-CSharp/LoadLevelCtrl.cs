using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Ads;
using Onboarding;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class LoadLevelCtrl : MonoBehaviour
{
	private sealed class _003CStart_003Ed__26(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadLevelCtrl _003C_003E4__this;

		private IEnumerator _003CcacheCoroutine_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0088: Expected I, but got Obj
				//IL_009e: Expected Obj, but got I
				//IL_013f: Expected I, but got Obj
				//IL_0155: Expected Obj, but got I
				//IL_00c9: Expected I, but got Obj
				//IL_0469: Unknown result type (might be due to invalid IL or missing references)
				//IL_046e: Expected Obj, but got Unknown
				//IL_0180: Expected I, but got Obj
				//IL_02c5: Expected I, but got Obj
				//IL_02db: Expected Obj, but got I
				//IL_0380: Expected I, but got Obj
				//IL_0396: Expected Obj, but got I
				//IL_0306: Expected I, but got Obj
				//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ed: Expected Obj, but got Unknown
				//IL_04fc: Expected VT, but got I4
				//IL_0513: Expected I4, but got Obj
				//IL_0526: Expected Obj, but got I4
				//IL_034b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0350: Expected Obj, but got Unknown
				//IL_0359: Expected Obj, but got I4
				//IL_036d: Expected Obj, but got I4
				//IL_03c1: Expected I, but got Obj
				LoadLevelCtrl loadLevelCtrl = _003C_003E4__this;
				float num;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							goto IL_02b7;
						}
						return null;
					}
					_003C_003E1__state = -1;
					float maxDelay = NetworkServer.maxDelay;
					num = maxDelay;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9EAB");
					_003C_003E4__this.SetDefaultTip();
					UILabel tipLabel = loadLevelCtrl.tipLabel;
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num3 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)tipLabel.panel).FindKernel((string)null) != 0)
					{
						UILabel tipLabel2 = loadLevelCtrl.tipLabel;
						tipLabel2.panel._002Ector();
					}
					float maxDelay2 = NetworkServer.maxDelay;
					nint num4 = (nint)typeof(AssetBundleManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v75 (Il2CppClass<AssetBundleManager>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num5 = (nint)typeof(AssetBundleManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v81 (Il2CppClass<AssetBundleManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj3 = this + 20;
					string assetBundlesCachePath = AssetBundleManager.GetAssetBundlesCachePath();
					IEnumerator enumerator = ((AssetBundleManager)(object)assetBundlesCachePath).UnloadBundlesCoroutine();
					obj3 = enumerator;
					num = maxDelay2;
				}
				object obj4 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					if (obj4 == null)
					{
						break;
					}
					float maxDelay3 = NetworkServer.maxDelay;
					float num6 = maxDelay3 - num;
					if (!(num6 < 0.1f))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						throw new NullReferenceException();
					}
				}
				_003C_003E4__this.UnloadAssets();
				goto IL_02b7;
				IL_02b7:
				nint num7 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v31 (Il2CppClass<HouseKeeper>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num8 = (nint)typeof(HouseKeeper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v58 (Il2CppClass<HouseKeeper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(HouseKeeper.waitForCloudSave ? 1u : 0u) == 0)
				{
					object obj6 = this + 12;
					obj6 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				nint num9 = (nint)typeof(MergeLevelStartHelp);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v39 (Il2CppClass<SYBO.Subway.UI.MergeLevelStartHelp>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num10 = (nint)typeof(MergeLevelStartHelp);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v48 (Il2CppClass<SYBO.Subway.UI.MergeLevelStartHelp>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj8 = _003C_003E4__this + 12;
				AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(MergeLevelStartHelp.MERGE_SCENE_NAME_FOR_BUILDS, (LoadSceneParameters)1);
				obj8 = asyncOperation;
				int value = StatTools.GetValue((Stat)_003C_003E4__this);
				Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)value);
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CProgress_003Ed__27(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadLevelCtrl _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0241: Expected I, but got Obj
				//IL_0257: Expected Obj, but got I
				//IL_047c: Expected Obj, but got I
				//IL_0487: Expected Obj, but got I
				//IL_0490: Unknown result type (might be due to invalid IL or missing references)
				//IL_0495: Expected Obj, but got Unknown
				//IL_02cf: Expected I, but got Obj
				//IL_02e5: Expected Obj, but got I
				//IL_0282: Expected I, but got Obj
				//IL_0203: Unknown result type (might be due to invalid IL or missing references)
				//IL_0208: Expected Obj, but got Unknown
				//IL_0211: Expected Obj, but got I4
				//IL_0225: Expected Obj, but got I4
				//IL_038a: Expected I, but got Obj
				//IL_03a0: Expected Obj, but got I
				//IL_0310: Expected I, but got Obj
				//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_04f5: Expected Obj, but got Unknown
				//IL_04fe: Expected Obj, but got I4
				//IL_0512: Expected Obj, but got I4
				//IL_0355: Unknown result type (might be due to invalid IL or missing references)
				//IL_035a: Expected Obj, but got Unknown
				//IL_0363: Expected Obj, but got I4
				//IL_0377: Expected Obj, but got I4
				//IL_00b6: Expected I4, but got Obj
				//IL_03cb: Expected I, but got Obj
				//IL_00e3: Expected I, but got Obj
				//IL_00f9: Expected Obj, but got I
				//IL_0124: Expected I, but got Obj
				LoadLevelCtrl loadLevelCtrl = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state == 3)
						{
							_003C_003E1__state = -1;
							_0021_00210[] array = (_0021_00210[])(object)UnityEngine.Object.FindObjectsOfType<T>();
							bool isInitialized = AdSystemManager.isInitialized;
							TimeSpan? timeLimitForAdProvider = ((AdSettingsProvider)(object)"mainMenu").GetTimeLimitForAdProvider("interactive", (AdType)array);
							loadLevelCtrl._002Ector();
							string tag = loadLevelCtrl.tag;
							nint num = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj = (nint)0 & (nint)0x200;
							if (obj != null)
							{
								nint num2 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9EAB");
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					Type parentTypeDisallowingMultipleInclusion = UnityEngine.AttributeHelperEngine.GetParentTypeDisallowingMultipleInclusion((Type)(object)loadLevelCtrl.asyncMerge);
					if ((object)parentTypeDisallowingMultipleInclusion == null)
					{
						if (loadLevelCtrl.asyncMerge != null)
						{
							float waitTime = ((WaitForSecondsRealtime)(object)loadLevelCtrl.asyncMerge).waitTime;
							((Range)(object)loadLevelCtrl)._002Ector(waitTime, 1f);
						}
						object obj2 = this + 12;
						obj2 = 0;
						_003C_003E1__state = 1;
						return 1;
					}
					loadLevelCtrl.UnloadAssets();
					nint num3 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v51 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(PoolManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v67 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					PoolManager.BalancingBudgetMS = 50;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num5 = 0;
					PooledInstanceData pooledInstanceData = default;
					pooledInstanceData.node__BackingField = (LinkedListNode<PooledInstanceData>)num5;
					pooledInstanceData.transform__BackingField = (Transform)0;
					object obj4 = pooledInstanceData + 16;
					obj4 = loadLevelCtrl;
					PoolManager.RegisterInstance(pooledInstanceData);
				}
				nint num6 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v12 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num7 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v40 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9EAA");
				object obj6 = default;
				if (obj6 != null)
				{
					object obj7 = this + 12;
					obj7 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				nint num8 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v19 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num9 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v30 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				PoolManager.BalancingBudgetMS = 5;
				loadLevelCtrl._currentProgress = 1f;
				object obj9 = this + 12;
				obj9 = 0;
				_003C_003E1__state = 3;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private AsyncOperation asyncMerge;

	private UILabel titleTipLabel;

	private UILabel tipLabel;

	private UILabel userNameLabel;

	private UILabel _loadingLabel;

	private UISlider slider;

	private GameObject quad;

	private float sliderSteps;

	private bool sliderStepsIsSet;

	private const int DEFAULT_TITLE_POSTION_Y = 133;

	private const int PLAYERTIP_TITLE_POSTION_Y = 141;

	private const float CachingTimeBudget = 0.1f;

	private static bool StartupFinished__BackingField;

	private string[] standardTipArray;

	private float _markedProgress;

	private float _currentProgress;

	private float _loadSteps;

	public static bool StartupFinished
	{
		get
		{
			//IL_017c: Expected I, but got Obj
			//IL_0192: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01bf: Expected I4, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_012f: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Layers>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<Layers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (Layers._instance == null)
			{
				nint num3 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v30 (Il2CppClass<Layers>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Layers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v35 (Il2CppClass<Layers>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Layers._002Ecctor();
			}
			nint num5 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (Il2CppClass<Layers>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v23 (Il2CppClass<Layers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)Layers._instance != 0;
		}
		private set
		{
			_ = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
	}

	private void Awake()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected I4, but got Unknown
		bool flag = (byte)(this & 1) != 0;
		StartupFinished__BackingField = flag;
	}

	private void Update()
	{
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		GameObject gameObject = base.gameObject;
		string text = ((Component)(object)gameObject).tag;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)text).Exec();
	}

	private void SetLabels()
	{
		float progress = GetProgress();
	}

	private void SetUserTip(string loadScreenTitle, UserTip[] userTips)
	{
		//IL_01e8: Expected I, but got Obj
		//IL_01fe: Expected Obj, but got I
		//IL_024f: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I
		//IL_026f: Expected Obj, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0068: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_00a9: Expected I, but got Obj
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<GlobalColors>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v53 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 > -1)
		{
			nint num4 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v42 (Il2CppClass<GlobalColors>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v47 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @778F");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private void SetDefaultTip()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00b1: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("LOADING_PROGRESS_TEXT");
		_loadingLabel.fontSize = (int)text;
		MarkProgress();
	}

	private string GetRandomTipId()
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		object obj = tipLabel - 1;
		string key;
		if ((nint)tipLabel == 1)
		{
			key = "TUTORIAL_FRESH_MOVES";
		}
		else if ((nint)obj == 1)
		{
			key = "TUTORIAL_DOUBLE_TAP";
		}
		else
		{
			key = (((nint)obj == 2) ? "TUTORIAL_YOU_ROCK" : "");
		}
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v12 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return Strings.GetDefault(key);
	}

	private IEnumerator Start()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		object obj = standardTipArray + 16;
		string[] array = standardTipArray;
		int num = UnityEngine.Random.RandomRangeInt(0, array.Length);
		int num2 = num << 2;
		return (IEnumerator)(obj + num2);
	}

	private IEnumerator Progress()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private void PoolManager_onProgress(float balancingProgress)
	{
		sliderSteps = balancingProgress;
	}

	public float LoadBar()
	{
		return sliderSteps;
	}

	private float GetProgress()
	{
		//IL_004a: Expected F4, but got I4
		if (~(sliderStepsIsSet ? 1u : 0u) != 0)
		{
			UISlider uISlider = slider;
			UIWidget mBG = ((UIProgressBar)uISlider).mBG;
			sliderSteps = mBG.mWidth;
			sliderStepsIsSet = true;
		}
		float num = 1f - _markedProgress;
		float num2 = _currentProgress * num;
		float num3 = num2 / _loadSteps;
		float num4 = _markedProgress + num3;
		float num5 = num4 * sliderSteps;
		float alpha = num5 / sliderSteps;
		slider.alpha = alpha;
		return slider.alpha;
	}

	private void SetCurrentProgress(float progress, float maxDeltaProgress = 1f)
	{
		//IL_00e9: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got F4
		if (Layers.FindLayer((string)(object)this) != 0)
		{
			if (((TableElementAlwaysVisible)this).AreAllClosed())
			{
				float speedMultiplier = maxDeltaProgress - progress;
				((MoveGameObject)this).SpeedMultiplier = speedMultiplier;
			}
			return;
		}
		bool flag = ((TableElementAlwaysVisible)this).hasAnotherElementOpenOnBottom();
		bool flag2 = ((TableElementAlwaysVisible)this).AreAllClosed();
		if (flag)
		{
			if (flag2)
			{
				UILabel uILabel = titleTipLabel;
				UILabel uILabel2 = titleTipLabel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S2_v6 (UILabel)+5C]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S3_v3 (UILabel)+58]");
				object obj = num - 0;
				object obj2 = 0 - obj;
				float num2 = progress - maxDeltaProgress;
				object obj3 = 0f - num2;
				float speedMultiplier2 = (float)obj2 + (float)obj3;
				((MoveGameObject)this).SpeedMultiplier = speedMultiplier2;
			}
		}
		else if (flag2)
		{
			float num3 = progress - maxDeltaProgress;
			float speedMultiplier3 = 0f - num3;
			((MoveGameObject)this).SpeedMultiplier = speedMultiplier3;
		}
	}

	private void MarkProgress()
	{
		//IL_015a: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I
		//IL_01aa: Expected I4, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_007c: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00ab: Expected VT, but got Obj
		//IL_00b9: Expected Obj, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_013a: Expected I4, but got Obj
		userNameLabel.tag = null;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v33 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("LOAD_LEVEL_CTRL_TIP_MESSAGE");
		titleTipLabel.fontSize = (int)text;
		GameObject gameObject = titleTipLabel.gameObject;
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 24);
		GameObject gameObject2 = titleTipLabel.gameObject;
		transform.localPosition = (Vector3)gameObject2;
		Transform transform2 = (Transform)(obj2 + 12);
		GameObject gameObject3 = titleTipLabel.gameObject;
		transform2.localPosition = (Vector3)gameObject3;
		obj2 = 0;
		_ = 0;
		obj2 = transform;
		_ = 133f;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		Transform transform3 = (Transform)(obj2 + 36);
		transform3 = (Transform)obj2;
		Transform transform4 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform3.eulerAngles;
		IEnumerator key = Start();
		string text2 = Strings.GetDefault((string)(object)key);
		tipLabel.fontSize = (int)text2;
	}

	private void UnloadAssets()
	{
		float num = 1f - _markedProgress;
		float num2 = _currentProgress * num;
		float num3 = num2 / _loadSteps;
		float markedProgress = _markedProgress + num3;
		_markedProgress = markedProgress;
		_currentProgress = 0f;
		float loadSteps = _loadSteps - 1f;
		_loadSteps = loadSteps;
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_02c2: Expected Obj, but got I
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0315: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I
		//IL_00c3: Expected I, but got Obj
		//IL_0198: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_034d: Expected I, but got Obj
		//IL_0363: Expected Obj, but got I
		//IL_03bd: Expected I, but got Obj
		//IL_03d3: Expected Obj, but got I
		//IL_01d9: Expected I, but got Obj
		//IL_0390: Expected Obj, but got I4
		//IL_0226: Expected I, but got Obj
		//IL_0273: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+2C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+44]");
		if ((nint)0 != 0)
		{
			return;
		}
		string original = ((Component)context).tag;
		UnityEngine.Object a = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		if (!string.Equals((string)(object)a, "Character"))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+10]");
		if ((nint)0 != 0)
		{
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v62 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v68 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			string randomTipId = ((LoadLevelCtrl)(object)msg).GetRandomTipId();
			((UIScreenController)flag).GoToMainMenuFromGame((GameObject)(object)randomTipId);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+18]");
		if ((nint)0 != 0)
		{
			IEnumerator routine = ((TutorialEvent)(object)msg).FadeOutArrowsText();
			Coroutine coroutine = ((MonoBehaviour)(object)msg).StartCoroutine_Auto(routine);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+25]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+28]");
			object obj3 = 0;
			_ = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+24]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v26 (Il2CppClass<Flurry>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v53 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v31 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v49 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		_ = 0;
		OnboardingSave.numberOfRunsSinceLastGuideline = 1;
		nint num7 = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v39 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v45 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnboardingTracking.QueueOnboardingEvents((string)null);
		OnboardingTracking.QueueOnboardingEvents((string)1);
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public LoadLevelCtrl()
	{
		//IL_0184: Expected I, but got Obj
		//IL_019a: Expected Obj, but got I
		//IL_0111: Expected I, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I4
		//IL_00b6: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I4
		string dataPath = Application.dataPath;
		if (dataPath != null)
		{
			string dataPath2 = Application.dataPath;
			if ((nint)dataPath2 != 7)
			{
				Renderer component = quad.GetComponent<Renderer>();
				Material sharedMaterial = component.sharedMaterial;
				int renderQueue = sharedMaterial.renderQueue;
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)renderQueue).FindKernel(null) != 0)
				{
					SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)renderQueue;
				}
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(quad);
	}
}
