using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using UnityEngine;

public class AssetBundleFactory<T> where T : UnityEngine.Object
{
	private Dictionary<string, int> _requests;

	private Dictionary<string, List<Disposable<T>>> _disposableReferences;

	private bool _isComponent;

	private List<string> _toRemove;

	public AssetBundleFactory()
	{
		//IL_0021: Expected Obj, but got I
		//IL_005c: Expected VT, but got Obj
		//IL_007c: Expected VT, but got I
		//IL_0088: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, int> requests = default;
		_requests = requests;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v4 (Il2CppRgctx<AssetBundleFactory`1>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S2_v5+4] (should have been resolved before IL gen)");
		Dictionary<string, List<Disposable<T>>> disposableReferences = default;
		_disposableReferences = disposableReferences;
		List<string> list = default;
		list._002Ector();
		_toRemove = list;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Component));
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v10 (Il2CppRgctx<AssetBundleFactory`1>)+8]");
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		nint num6 = (nint)typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S3_v8 (Il2CppClass<System.Type>)+16C] (should have been resolved before IL gen)");
		bool isComponent = default;
		_isComponent = isComponent;
		T instance = (T)(object)SingletonMonobehavior<>.Instance;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S2_v15 (Il2CppRgctx<AssetBundleFactory`1>)+C]");
		Action action = default;
		action._002Ector(this, (IntPtr)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v26 (T)+14]");
		Delegate obj2 = Delegate.Combine((Delegate)0, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void RequestItemInstance(string name, Action<T> onSuccess)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string text = name.ToLower();
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		if (obj6 == null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S5_v15 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S5_v16+4] (should have been resolved before IL gen)");
		}
		int num5 = _requests.get_Item(text);
		object obj8 = num5 + 1;
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ S5_v5+4] (should have been resolved before IL gen)");
		string text2 = "MyBundles/" + text;
		nint num8 = 0;
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S2_v13 (Il2CppRgctx<AssetBundleFactory`1>)+10]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ S2_v14+4] (should have been resolved before IL gen)");
		UnityEngine.Object obj11 = default;
		if (obj11 == null)
		{
			object obj12 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			nint num10 = 0;
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S3_v14 (Il2CppRgctx<AssetBundleFactory`1>)+1C]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ S3_v15+4] (should have been resolved before IL gen)");
		}
		else
		{
			nint num12 = 0;
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S5_v10 (Il2CppRgctx<AssetBundleFactory`1>)+20]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ S5_v11+4] (should have been resolved before IL gen)");
		}
	}

	public void LoadAssetFromBundles(AssetBundle bundle, string name, Action<T> onSucces)
	{
		//IL_0059: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I
		//IL_002e: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_025e: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		string path = "MyBundles/" + name;
		if (~(_isComponent ? 1u : 0u) == 0)
		{
			GameObject gameObject = Resources.Load<GameObject>(path);
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v50 (Il2CppRgctx<AssetBundleFactory`1>)+24]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S2_v51+4] (should have been resolved before IL gen)");
		}
		else
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v45 (Il2CppRgctx<AssetBundleFactory`1>)+10]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S2_v46+4] (should have been resolved before IL gen)");
		}
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v5 (Il2CppRgctx<AssetBundleFactory`1>)+28]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S2_v6+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S3_v3 (Il2CppRgctx<AssetBundleFactory`1>)+30]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S3_v4+4] (should have been resolved before IL gen)");
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S3_v8 (Il2CppRgctx<AssetBundleFactory`1>)+34]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ S3_v9+4] (should have been resolved before IL gen)");
		object obj6 = default;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			nint num11 = 0;
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S2_v39 (Il2CppRgctx<AssetBundleFactory`1>)+3C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v191 @ S2_v40+4] (should have been resolved before IL gen)");
			object obj8 = -(-64);
			object obj9 = -(-64);
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v203 @ S4_v14+4] (should have been resolved before IL gen)");
		}
		nint num13 = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S3_v14 (Il2CppRgctx<AssetBundleFactory`1>)+44]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v142 @ S3_v15+4] (should have been resolved before IL gen)");
		nint num15 = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S3_v19 (Il2CppRgctx<AssetBundleFactory`1>)+48]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ S3_v20+4] (should have been resolved before IL gen)");
		int num17 = _requests.get_Item(name);
		object obj13 = num17 - 1;
		nint num18 = 0;
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v178 @ S5_v5+4] (should have been resolved before IL gen)");
		if (onSucces != null)
		{
			nint num20 = 0;
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S3_v28 (Il2CppRgctx<AssetBundleFactory`1>)+4C]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v213 @ S3_v29+4] (should have been resolved before IL gen)");
			nint num22 = 0;
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S3_v33 (Il2CppRgctx<AssetBundleFactory`1>)+1C]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v223 @ S3_v34+4] (should have been resolved before IL gen)");
		}
	}

	private void HandleOnLateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_0280: Expected Obj, but got I
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0193: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		((List<T>)(object)_toRemove).Clear();
		object obj3 = obj + 8;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S3_v3 (Il2CppRgctx<AssetBundleFactory`1>)+50]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S3_v4+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj10 = default;
		UnityEngine.Object obj13 = default;
		object obj17 = default;
		while (true)
		{
			object obj5 = obj + 40;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95E");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			nint num4 = 0;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S3_v20 (Il2CppRgctx<AssetBundleFactory`1>)+44]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S3_v21+4] (should have been resolved before IL gen)");
			object obj8 = 0;
			while (true)
			{
				nint num6 = 0;
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S2_v21 (Il2CppRgctx<AssetBundleFactory`1>)+6C]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ S2_v22+4] (should have been resolved before IL gen)");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
				{
					break;
				}
				nint num8 = 0;
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S3_v24 (Il2CppRgctx<AssetBundleFactory`1>)+64]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v189 @ S3_v25+4] (should have been resolved before IL gen)");
				nint num10 = 0;
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S2_v37 (Il2CppRgctx<AssetBundleFactory`1>)+4C]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ S2_v38+4] (should have been resolved before IL gen)");
				if (obj13 == null)
				{
					nint num12 = 0;
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S3_v30 (Il2CppRgctx<AssetBundleFactory`1>)+68]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v252 @ S3_v31+4] (should have been resolved before IL gen)");
				}
				else
				{
					object obj15 = obj8 + 1;
					obj8 = obj15;
				}
			}
			nint num14 = 0;
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S2_v24 (Il2CppRgctx<AssetBundleFactory`1>)+6C]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v209 @ S2_v25+4] (should have been resolved before IL gen)");
			if (obj17 == null)
			{
				Dictionary<string, int> requests = _requests;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				if (requests.get_Item((string)0) == 0)
				{
					List<string> toRemove = _toRemove;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
					toRemove.Add((string)0);
				}
			}
		}
		int num16 = 0;
		while (true)
		{
			List<string> toRemove2 = _toRemove;
			if (num16 < toRemove2._size)
			{
				string text = _toRemove.get_Item(num16);
				nint num17 = 0;
				nint num18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S3_v12 (Il2CppRgctx<AssetBundleFactory`1>)+74]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ S3_v13+4] (should have been resolved before IL gen)");
				AssetBundleManager instance = AssetBundleManager.Instance;
				string bundleName = _toRemove.get_Item(num16);
				instance.UnloadAssetBundle(bundleName, unloadAllLoadedObjects: true);
				int num19 = num16 + 1;
				num16 = num19;
				continue;
			}
			break;
		}
	}
}
