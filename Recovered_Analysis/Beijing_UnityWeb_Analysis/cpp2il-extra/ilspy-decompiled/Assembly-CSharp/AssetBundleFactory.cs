using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Components.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;

public class AssetBundleFactory<T> where T : UnityEngine.Object
{
	private sealed class _003CLoadAssetFromBundlesAsync_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetBundleFactory<T> _003C_003E4__this;

		public AssetBundle bundle;

		public string name;

		public Action<T> onSucces;

		private AssetBundleRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0007: Expected Obj, but got I4
				return _003C_003E1__state;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CLoadAssetFromBundlesAsync_003Ed__8(int _003C_003E1__state)
		{
			//IL_0188: Expected Obj, but got I4
			//IL_0196: Expected I, but got Obj
			//IL_01ac: Expected Obj, but got I
			//IL_01d4: Expected Obj, but got I4
			//IL_00d3: Expected Obj, but got I
			//IL_00e3: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0154: Expected Obj, but got I
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected Obj, but got Unknown
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Expected Obj, but got Unknown
			//IL_006c: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected Obj, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected Obj, but got Unknown
			//IL_010c: Expected Obj, but got I
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected Obj, but got Unknown
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected Obj, but got Unknown
			object obj = 0;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)_003C_003E1__state != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v7+60]");
				object obj4 = 0;
				object obj5 = obj4;
				object obj6 = obj5 & 0x3FFF;
				object obj7 = obj6 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v75 @ S3_v7 (should have been resolved before IL gen)");
				return;
			}
			bool flag = _003C_003E2__current != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v15+60]");
			object obj9 = 0;
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v16+4]");
				object obj10 = 0;
				object obj11 = obj10 & 0x7FF;
				object obj12 = obj11 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v89 @ S5_v9 (should have been resolved before IL gen)");
				YieldInstruction[] list = default;
				Coroutine coroutine = CoroutineUtil.WaitForAll(list);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v16+8]");
				object obj13 = 0;
				object obj14 = obj13 & 0x7FF;
				object obj15 = obj14 + 121922;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105 @ S5_v5 (should have been resolved before IL gen)");
			}
		}

		void IDisposable.Dispose()
		{
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

	private Dictionary<string, int> _requests;

	private Dictionary<string, List<Disposable<T>>> _disposableReferences;

	private bool _isComponent;

	private List<string> _toRemove;

	public AssetBundleFactory()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 8;
		object obj2 = default;
		obj = obj2;
	}

	public bool IsAssetBundleInUse(string assetBundleName)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj4 = default;
		if (obj4 != null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v9+60]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v10+4]");
			object obj7 = 0;
			object obj8 = obj7 & 0xFFF;
			object obj9 = obj8 + 1797;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25 @ S2_v6 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
			object obj10 = default;
			if (obj10 != null)
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v15+60]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v16+10]");
				object obj13 = 0;
				object obj14 = obj13 & 0xFFF;
				object obj15 = obj14 + 1797;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v60 @ S2_v13 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
				bool result = default;
				return result;
			}
			return false;
		}
		return false;
	}

	public void RequestItemInstance(string name, Action<T> onSuccess, bool asynchronous = false)
	{
		//IL_0547: Expected I, but got Obj
		//IL_055d: Expected Obj, but got I
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected Obj, but got Unknown
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01d1: Expected I, but got Obj
		//IL_021e: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0378: Expected Obj, but got I4
		//IL_0385: Expected Obj, but got VT
		//IL_025f: Expected I, but got Obj
		//IL_03ab: Expected VT, but got I4
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		//IL_02ac: Expected I, but got Obj
		//IL_02c2: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_03d5: Expected VT, but got Obj
		//IL_02ed: Expected I, but got Obj
		//IL_0417: Expected I, but got Obj
		//IL_042d: Expected Obj, but got I
		//IL_0458: Expected I, but got Obj
		//IL_04ee: Expected Obj, but got I
		//IL_04fe: Expected Obj, but got I
		//IL_050e: Expected Obj, but got I
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v111 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 4;
		if ((UnityEngine.Object)(object)_disposableReferences != null)
		{
			nint num3 = (nint)typeof(LogFilter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v89 (Il2CppClass<UnityEngine.Networking.LogFilter>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(LogFilter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v107 (Il2CppClass<UnityEngine.Networking.LogFilter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!LogFilter.logFatal)
			{
				return;
			}
			nint num5 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v97 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v103 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogException((Exception)(object)"SyncList not initialized");
			return;
		}
		NetworkIdentity component = ((Component)(object)_disposableReferences).GetComponent<NetworkIdentity>();
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v84 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (component != null)
		{
			nint num9 = (nint)typeof(LogFilter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v62 (Il2CppClass<UnityEngine.Networking.LogFilter>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(LogFilter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v80 (Il2CppClass<UnityEngine.Networking.LogFilter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!LogFilter.logFatal)
			{
				return;
			}
			nint num11 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v70 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num12 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v76 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogException((Exception)(object)"SyncList no NetworkIdentity");
		}
		else
		{
			if (!component.hasAuthority)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NetworkWriter networkWriter = default;
			networkWriter.SeekZero();
			SyncListString.ReadReference((NetworkReader)(object)networkWriter, (SyncListString)9);
			obj3 = component.m_NetId;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DDD9");
			networkWriter.Write((NetworkInstanceId)_isComponent);
			object obj9 = name & 0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DDDD");
			networkWriter.Write((NetworkInstanceId)onSuccess);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
			((PlayerController)(object)networkWriter)._002Ector();
			string tag = component.tag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num13 = (nint)typeof(NetworkServer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S1_v30 (Il2CppClass<UnityEngine.Networking.NetworkServer>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num14 = (nint)typeof(NetworkServer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S1_v38 (Il2CppClass<UnityEngine.Networking.NetworkServer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int error = default;
			((NetworkServer)(object)tag).GenerateDataError((NetworkConnection)(object)networkWriter, error);
			if (((NetworkBehaviour)(object)_disposableReferences).isClient && ((NetworkBehaviour)(object)_disposableReferences).isLocalPlayer && _toRemove != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L4 (Il2CppMethodInfo)+C]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S3_v5+60]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S3_v6+8]");
				object obj13 = 0;
				object obj14 = obj13 & 0x1FFF;
				object obj15 = obj14 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v115 @ S4_v5 (should have been resolved before IL gen)");
			}
		}
	}

	private void LoadAssetFromBundles(AssetBundle bundle, string name, Action<T> onSucces)
	{
		//IL_0151: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I
		//IL_0023: Expected Obj, but got I
		//IL_0033: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_025c: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I
		//IL_0294: Expected Obj, but got I
		//IL_02a4: Expected Obj, but got I
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02d8: Expected I, but got Obj
		//IL_02ee: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_039d: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_0103: Expected I, but got Obj
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v4+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5+18]");
		object obj6 = 0;
		object obj7 = obj6 & 0x3FFF;
		object obj8 = obj7 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S2_v4 (should have been resolved before IL gen)");
		object obj10 = default;
		object obj9 = obj10 + 8;
		obj9 = name;
		object obj11 = onSucces & 1;
		object obj12 = obj10 + 16;
		obj12 = this;
		object obj13 = obj10 + 20;
		obj13 = bundle;
		object obj14 = obj10 + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11+14]");
		string text = ((string)0).ToLowerInvariant();
		obj14 = text;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v8 (Il2CppMethodInfo)+C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v9+60]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S2_v10+44]");
		object obj17 = 0;
		object obj18 = obj17 & 0x1FFF;
		object obj19 = obj18 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v76 @ S3_v6 (should have been resolved before IL gen)");
		object obj20 = default;
		if ((nint)obj20 <= -1)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S4_v12 (Il2CppMethodInfo)+C]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S4_v13+60]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S4_v14+48]");
			object obj23 = 0;
			object obj24 = obj23 & 0x7FF;
			object obj25 = obj24 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v98 @ S5_v9 (should have been resolved before IL gen)");
		}
		Dictionary<string, int> requests = _requests;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11+14]");
		int num4 = requests.get_Item((string)0);
		object obj26 = num4 + 1;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S4_v5 (Il2CppMethodInfo)+C]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S4_v6+60]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S4_v7+48]");
		object obj29 = 0;
		object obj30 = obj29 & 0x7FF;
		object obj31 = obj30 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v137 @ S5_v5 (should have been resolved before IL gen)");
		nint num6 = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v33 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		if (obj32 != null)
		{
			nint num7 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v39 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string assetBundlesCachePath = AssetBundleManager.GetAssetBundlesCachePath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S3_v10+60]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S3_v11+1C]");
		object obj35 = 0;
		Action<AssetBundle> action = default;
		object obj36 = action + 16;
		obj36 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11+C]");
		bool asynchronous = (nint)0 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11+14]");
		((AssetBundleManager)(object)assetBundlesCachePath).RequestAssetBundle((string)0, action, asynchronous);
	}

	private Disposable<T> CreateDisposableObject(string name, T obj)
	{
		//IL_0177: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_0296: Expected I4, but got Obj
		//IL_02a4: Expected Obj, but got I
		//IL_0253: Expected I, but got Obj
		//IL_0269: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_00f3: Expected I, but got Obj
		nint num = (nint)typeof(ExecuteEvents);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.EventSystems.ExecuteEvents>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(ExecuteEvents);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v53 (Il2CppClass<UnityEngine.EventSystems.ExecuteEvents>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((BaseInput)this).imeCompositionMode = (IMECompositionMode)ExecuteEvents.s_InternalTransformList;
		nint num3 = default;
		object obj3 = num3 + 24;
		int num6 = default;
		Transform transform;
		object obj10 = default;
		int num9 = default;
		while (true)
		{
			nint num4 = (nint)typeof(ExecuteEvents);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v15 (Il2CppClass<UnityEngine.EventSystems.ExecuteEvents>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(ExecuteEvents);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v47 (Il2CppClass<UnityEngine.EventSystems.ExecuteEvents>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<Transform> s_InternalTransformList = ExecuteEvents.s_InternalTransformList;
			if (num6 < s_InternalTransformList._size)
			{
				nint num7 = (nint)typeof(ExecuteEvents);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v26 (Il2CppClass<UnityEngine.EventSystems.ExecuteEvents>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num8 = (nint)typeof(ExecuteEvents);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v40 (Il2CppClass<UnityEngine.EventSystems.ExecuteEvents>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				transform = ExecuteEvents.s_InternalTransformList.get_Item(num6);
				string tag = transform.tag;
				object obj6 = obj3;
				object obj7 = obj6;
				object obj8 = obj7 & 0x1FFF;
				object obj9 = obj8 + 30963;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ S4_v6 (should have been resolved before IL gen)");
				if (obj10 != null)
				{
					break;
				}
				num6 = num9 + 1;
				continue;
			}
			return null;
		}
		return (Disposable<T>)(object)transform.tag;
	}

	private IEnumerator LoadAssetFromBundlesAsync(AssetBundle bundle, string name, Action<T> onSucces)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+4]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v19 @ S2_v4 (should have been resolved before IL gen)");
		IEnumerator enumerator = default;
		object obj7 = enumerator + 8;
		obj7 = bundle;
		object obj8 = enumerator + 16;
		obj8 = name;
		object obj9 = enumerator + 20;
		obj9 = onSucces;
		return enumerator;
	}

	private unsafe void HandleOnLateUpdate()
	{
		//IL_0208: Expected Obj, but got I
		//IL_0218: Expected Obj, but got I
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0267: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected I, but got Unknown
		//IL_02cf: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I
		//IL_0311: Expected I, but got Obj
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected I4, but got Unknown
		//IL_00e0: Expected I, but got Obj
		//IL_0167: Expected Obj, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01cc: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 8;
		object obj7 = default;
		obj6 = obj7;
		nint num2 = default;
		object obj8 = num2 + 12;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15+60]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v8+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v9+4]");
		object obj13 = 0;
		object obj14 = obj13 & 0x3FFF;
		object obj15 = obj14 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v62 @ S2_v5 (should have been resolved before IL gen)");
		object obj16 = this + 12;
		object obj17 = default;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj18 = this + 20;
		obj18 = list;
		nint num3 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v30 (Il2CppClass<System.Type>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v56 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj21 = default;
		object obj20 = obj21 + 4;
		obj20 = typeof(Component);
		nint num5 = (nint)(obj21 + 8);
		((IntPtr*)num5)->m_value = (void*)(nint)obj20;
		Type type = Type.internal_from_handle((IntPtr)num5);
		object obj22 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v25+60]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v26+8]");
		obj21 = 0;
		((IntPtr*)num5)->m_value = (void*)(nint)obj21;
		Type type2 = Type.internal_from_handle((IntPtr)num5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj24 = default;
		bool isComponent = (byte)(obj24 & 1) != 0;
		_isComponent = isComponent;
		T val = (T)(object)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj25 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v34+60]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v35+C]");
		nint num6 = 0;
		Delegate obj27 = default;
		obj27.method_ptr = (nint)((IntPtr*)num6)->m_value;
		obj27.method = num6;
		object obj28 = obj27 + 16;
		obj28 = this;
		object obj29 = val + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v45 (T)+28]");
		Delegate obj30 = ((Delegate)0).CombineImpl(obj27);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		object obj31 = default;
		obj29 = obj31;
	}
}
