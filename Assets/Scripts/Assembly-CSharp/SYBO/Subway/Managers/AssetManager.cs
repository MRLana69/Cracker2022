using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Managers;

public class AssetManager : SingletonMonobehavior<AssetManager>
{
	private Dictionary<EnvironmentBaseInfo, Transform> _combinedEnvBaseModels;

	protected override void Initialize()
	{
		Transform childTransform = transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.DynamicManagers);
		CombineGroundModels();
	}

	public unsafe Transform GetEnvironmentBaseModel(EnvironmentBaseInfo envBaseInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Ref, but got Unknown
		//IL_004b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = _combinedEnvBaseModels.TryGetValue(envBaseInfo, out *(Transform*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (Transform)0;
	}

	private unsafe void CreateModelInstances(out GroundAssetGroup instances)
	{
		//IL_0024: Expected Obj, but got VT
		//IL_0046: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		ThemeManager instance = ThemeManager.Instance;
		Theme theme = instance._theme;
		Transform transform = GameObjectUtil.InstantiateTransform((Transform)theme._groundAssets);
		ref GroundAssetGroup reference = ref *(GroundAssetGroup*)transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+80]");
		Transform transform2 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+84]");
		Transform transform3 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+88]");
		Transform transform4 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+8C]");
		Transform transform5 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+90]");
		Transform transform6 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+94]");
		Transform transform7 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+98]");
		Transform transform8 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+9C]");
		Transform transform9 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+A0]");
		Transform transform10 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+A4]");
		Transform transform11 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+A8]");
		Transform transform12 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+AC]");
		Transform transform13 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+B0]");
		Transform transform14 = GameObjectUtil.InstantiateTransform((Transform)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (SYBO.Subway.Themes.Theme)+B4]");
		Transform transform15 = GameObjectUtil.InstantiateTransform((Transform)0);
	}

	private void DestroyModelInstances(ref GroundAssetGroup ga)
	{
		//IL_01fe: Expected Obj, but got VT
		//IL_0016: Expected Obj, but got I
		//IL_0039: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_0197: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		GameObject obj = ((Component)ga).gameObject;
		UnityEngine.Object.Destroy(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+4]");
		GameObject obj2 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+8]");
		GameObject obj3 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+C]");
		GameObject obj4 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+10]");
		GameObject obj5 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+14]");
		GameObject obj6 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+18]");
		GameObject obj7 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+1C]");
		GameObject obj8 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+20]");
		GameObject obj9 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+24]");
		GameObject obj10 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+28]");
		GameObject obj11 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+2C]");
		GameObject obj12 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+30]");
		GameObject obj13 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+34]");
		GameObject obj14 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ga @ L1 (SYBO.Subway.Level.GroundAssetGroup&)+38]");
		GameObject obj15 = ((Component)0).gameObject;
		UnityEngine.Object.Destroy(obj15);
	}

	public unsafe void CombineGroundModels()
	{
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected Ref, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected Ref, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Ref, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_011c: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_017a: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01dd: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_023b: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_029e: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_02f4: Expected Obj, but got I
		//IL_02f4: Expected Obj, but got I
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_0357: Expected Obj, but got I
		//IL_0357: Expected Obj, but got I
		//IL_0357: Expected Obj, but got I
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected Obj, but got Unknown
		//IL_03b5: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got I
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_0418: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_0476: Expected Obj, but got I
		//IL_0476: Expected Obj, but got I
		//IL_0476: Expected Obj, but got I
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_04d9: Expected Obj, but got I
		//IL_04d9: Expected Obj, but got I
		//IL_04d9: Expected Obj, but got I
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected Obj, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_0537: Expected Obj, but got I
		//IL_0537: Expected Obj, but got I
		//IL_0537: Expected Obj, but got I
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_059a: Expected Obj, but got I
		//IL_059a: Expected Obj, but got I
		//IL_059a: Expected Obj, but got I
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected Obj, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected Obj, but got Unknown
		//IL_05f8: Expected Obj, but got I
		//IL_05f8: Expected Obj, but got I
		//IL_05f8: Expected Obj, but got I
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected Obj, but got Unknown
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected Obj, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		//IL_065b: Expected Obj, but got I
		//IL_065b: Expected Obj, but got I
		//IL_065b: Expected Obj, but got I
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected Obj, but got Unknown
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected Obj, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected Obj, but got Unknown
		//IL_06b9: Expected Obj, but got I
		//IL_06b9: Expected Obj, but got I
		//IL_06b9: Expected Obj, but got I
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected Obj, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected Obj, but got Unknown
		//IL_071c: Expected Obj, but got I
		//IL_071c: Expected Obj, but got I
		//IL_071c: Expected Obj, but got I
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected Obj, but got Unknown
		//IL_0748: Expected Obj, but got I
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_0779: Expected Obj, but got I
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected Obj, but got Unknown
		//IL_07a5: Expected Obj, but got I
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected Ref, but got Unknown
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Ref, but got Unknown
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected Ref, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		AssetManager assetManager = default;
		((AssetManager)null).CreateModelInstances(out *(GroundAssetGroup*)(assetManager + 16));
		assetManager.CreateModelInstances(out *(GroundAssetGroup*)(assetManager + 76));
		assetManager.CreateModelInstances(out *(GroundAssetGroup*)(assetManager + 136));
		object left = assetManager + 16;
		object mid = assetManager + 76;
		object right = assetManager + 136;
		CombineEnvironmentBaseModelsAndStore(EnvironmentBaseInfo.Tracks0, (Transform)left, (Transform)mid, (Transform)right);
		object left2 = assetManager + 16;
		object obj = assetManager + 76;
		object right2 = assetManager + 136;
		EnvironmentBaseInfo tracks = EnvironmentBaseInfo.Tracks1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S3_v7+18]");
		CombineEnvironmentBaseModelsAndStore(tracks, (Transform)left2, (Transform)0, (Transform)right2);
		object obj2 = assetManager + 16;
		object obj3 = assetManager + 76;
		object obj4 = assetManager + 136;
		EnvironmentBaseInfo tracks1ShadowStart = EnvironmentBaseInfo.Tracks1ShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S2_v15+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S3_v11+1C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S4_v11+4]");
		CombineEnvironmentBaseModelsAndStore(tracks1ShadowStart, (Transform)num, (Transform)num2, (Transform)0);
		object obj5 = assetManager + 16;
		object obj6 = assetManager + 76;
		object obj7 = assetManager + 136;
		EnvironmentBaseInfo tracks1ShadowMid = EnvironmentBaseInfo.Tracks1ShadowMid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S2_v18+8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S3_v15+20]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S4_v15+8]");
		CombineEnvironmentBaseModelsAndStore(tracks1ShadowMid, (Transform)num3, (Transform)num4, (Transform)0);
		object obj8 = assetManager + 16;
		object obj9 = assetManager + 76;
		object obj10 = assetManager + 136;
		EnvironmentBaseInfo tracks1ShadowEnd = EnvironmentBaseInfo.Tracks1ShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S2_v21+C]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S3_v19+24]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S4_v19+C]");
		CombineEnvironmentBaseModelsAndStore(tracks1ShadowEnd, (Transform)num5, (Transform)num6, (Transform)0);
		object obj11 = assetManager + 16;
		object obj12 = assetManager + 76;
		object obj13 = assetManager + 136;
		EnvironmentBaseInfo tracks1ShortShadowStart = EnvironmentBaseInfo.Tracks1ShortShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S2_v24+10]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S3_v23+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S4_v23+10]");
		CombineEnvironmentBaseModelsAndStore(tracks1ShortShadowStart, (Transform)num7, (Transform)num8, (Transform)0);
		object obj14 = assetManager + 16;
		object obj15 = assetManager + 76;
		object obj16 = assetManager + 136;
		EnvironmentBaseInfo tracks1ShortShadowEnd = EnvironmentBaseInfo.Tracks1ShortShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v27+14]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S3_v27+2C]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S4_v27+14]");
		CombineEnvironmentBaseModelsAndStore(tracks1ShortShadowEnd, (Transform)num9, (Transform)num10, (Transform)0);
		object obj17 = assetManager + 16;
		object mid2 = assetManager + 76;
		object obj18 = assetManager + 136;
		EnvironmentBaseInfo tracks2 = EnvironmentBaseInfo.Tracks2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S2_v30+18]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S4_v31+18]");
		CombineEnvironmentBaseModelsAndStore(tracks2, (Transform)num11, (Transform)mid2, (Transform)0, 4);
		object obj19 = assetManager + 16;
		object obj20 = assetManager + 76;
		object obj21 = assetManager + 136;
		EnvironmentBaseInfo tracks2ShadowStart = EnvironmentBaseInfo.Tracks2ShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S2_v33+1C]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S3_v35+4]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S4_v35+1C]");
		CombineEnvironmentBaseModelsAndStore(tracks2ShadowStart, (Transform)num12, (Transform)num13, (Transform)0);
		object obj22 = assetManager + 16;
		object obj23 = assetManager + 76;
		object obj24 = assetManager + 136;
		EnvironmentBaseInfo tracks2ShadowMid = EnvironmentBaseInfo.Tracks2ShadowMid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S2_v36+20]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S3_v39+8]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S4_v39+20]");
		CombineEnvironmentBaseModelsAndStore(tracks2ShadowMid, (Transform)num14, (Transform)num15, (Transform)0, 8);
		object obj25 = assetManager + 16;
		object obj26 = assetManager + 76;
		object obj27 = assetManager + 136;
		EnvironmentBaseInfo tracks2ShadowEnd = EnvironmentBaseInfo.Tracks2ShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S2_v39+24]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S3_v43+C]");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S4_v43+24]");
		CombineEnvironmentBaseModelsAndStore(tracks2ShadowEnd, (Transform)num16, (Transform)num17, (Transform)0);
		object obj28 = assetManager + 16;
		object obj29 = assetManager + 76;
		object obj30 = assetManager + 136;
		EnvironmentBaseInfo tracks2ShortShadowStart = EnvironmentBaseInfo.Tracks2ShortShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S2_v42+28]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S3_v47+10]");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S4_v47+28]");
		CombineEnvironmentBaseModelsAndStore(tracks2ShortShadowStart, (Transform)num18, (Transform)num19, (Transform)0, 4);
		object obj31 = assetManager + 16;
		object obj32 = assetManager + 76;
		object obj33 = assetManager + 136;
		EnvironmentBaseInfo tracks2ShortShadowEnd = EnvironmentBaseInfo.Tracks2ShortShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S2_v45+2C]");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S3_v51+14]");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S4_v51+2C]");
		CombineEnvironmentBaseModelsAndStore(tracks2ShortShadowEnd, (Transform)num20, (Transform)num21, (Transform)0, 4);
		object obj34 = assetManager + 16;
		object obj35 = assetManager + 76;
		object obj36 = assetManager + 136;
		EnvironmentBaseInfo tracks3 = EnvironmentBaseInfo.Tracks3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S2_v48+18]");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S3_v55+18]");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S4_v55+18]");
		CombineEnvironmentBaseModelsAndStore(tracks3, (Transform)num22, (Transform)num23, (Transform)0, 18);
		object obj37 = assetManager + 16;
		object obj38 = assetManager + 76;
		object obj39 = assetManager + 136;
		EnvironmentBaseInfo tracks3ShadowStart = EnvironmentBaseInfo.Tracks3ShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S2_v51+1C]");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S3_v59+1C]");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S4_v59+1C]");
		CombineEnvironmentBaseModelsAndStore(tracks3ShadowStart, (Transform)num24, (Transform)num25, (Transform)0, 4);
		object obj40 = assetManager + 16;
		object obj41 = assetManager + 76;
		object obj42 = assetManager + 136;
		EnvironmentBaseInfo tracks3ShadowMid = EnvironmentBaseInfo.Tracks3ShadowMid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S2_v54+20]");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S3_v63+20]");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S4_v63+20]");
		CombineEnvironmentBaseModelsAndStore(tracks3ShadowMid, (Transform)num26, (Transform)num27, (Transform)0, 15);
		object obj43 = assetManager + 16;
		object obj44 = assetManager + 76;
		object obj45 = assetManager + 136;
		EnvironmentBaseInfo tracks3ShadowEnd = EnvironmentBaseInfo.Tracks3ShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S2_v57+24]");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S3_v67+24]");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S4_v67+24]");
		CombineEnvironmentBaseModelsAndStore(tracks3ShadowEnd, (Transform)num28, (Transform)num29, (Transform)0);
		object obj46 = assetManager + 16;
		object obj47 = assetManager + 76;
		object obj48 = assetManager + 136;
		EnvironmentBaseInfo tracks3ShortShadowStart = EnvironmentBaseInfo.Tracks3ShortShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S2_v60+28]");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S3_v71+28]");
		nint num31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S4_v71+28]");
		CombineEnvironmentBaseModelsAndStore(tracks3ShortShadowStart, (Transform)num30, (Transform)num31, (Transform)0);
		object obj49 = assetManager + 16;
		object obj50 = assetManager + 76;
		object obj51 = assetManager + 136;
		EnvironmentBaseInfo tracks3ShortShadowEnd = EnvironmentBaseInfo.Tracks3ShortShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S2_v63+2C]");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S3_v75+2C]");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S4_v75+2C]");
		CombineEnvironmentBaseModelsAndStore(tracks3ShortShadowEnd, (Transform)num32, (Transform)num33, (Transform)0);
		object obj52 = assetManager + 16;
		EnvironmentBaseInfo tracks3Gates = EnvironmentBaseInfo.Tracks3Gates;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S3_v78+30]");
		CombineEnvironmentBaseModelsAndStore(tracks3Gates, null, (Transform)0, null);
		object obj53 = assetManager + 16;
		EnvironmentBaseInfo tracks3GatesShadow = EnvironmentBaseInfo.Tracks3GatesShadow;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S3_v81+34]");
		CombineEnvironmentBaseModelsAndStore(tracks3GatesShadow, null, (Transform)0, null);
		object obj54 = assetManager + 16;
		EnvironmentBaseInfo tracks3Special = EnvironmentBaseInfo.Tracks3Special;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S3_v84+38]");
		CombineEnvironmentBaseModelsAndStore(tracks3Special, null, (Transform)0, null);
		assetManager.DestroyModelInstances(ref *(GroundAssetGroup*)(assetManager + 16));
		assetManager.DestroyModelInstances(ref *(GroundAssetGroup*)(assetManager + 76));
		assetManager.DestroyModelInstances(ref *(GroundAssetGroup*)(assetManager + 136));
		PoolManager.TriggerPoolBalancing();
	}

	public unsafe void CombineEnvironmentBaseModelsAndStore(EnvironmentBaseInfo envBaseInfo, Transform left, Transform mid, Transform right, int preloadAmount = 2)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_03d9: Expected I, but got Obj
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected VT, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected VT, but got Unknown
		//IL_02c3: Expected Obj, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected VT, but got Unknown
		//IL_0452: Expected I, but got Obj
		//IL_04bd: Expected F4, but got I
		//IL_04b8: Expected native int or pointer, but got VT
		//IL_04dc: Expected F4, but got I
		//IL_04d7: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		object obj2 = envBaseInfo.EnvironmentBaseKind - 3;
		if ((nint)obj2 >= 2 && (left == null || right == null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		string text = EnvironmentBaseInfo.GetName(envBaseInfo);
		GameObject gameObject = default;
		gameObject._002Ector(text);
		Transform transform = gameObject.transform;
		if (left != null)
		{
			left.parent = transform;
			_ = 0;
			_ = 0;
			_ = 3248488448L;
			_ = 3248488448L;
			Vector3 localPosition = vector + 48;
			left.localPosition = localPosition;
		}
		mid.parent = transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v35 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v36 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Vector3 localPosition2 = vector + 32;
		mid.localPosition = localPosition2;
		if (right != null)
		{
			right.parent = transform;
			_ = 0;
			_ = 0;
			_ = 1101004800;
			_ = 1101004800;
			Vector3 localPosition3 = vector + 16;
			right.localPosition = localPosition3;
		}
		ModelInfo modelInfo = MeshUtil.CombineMeshes(gameObject, combineInactive: true);
		if (modelInfo != null)
		{
			MeshFilter meshFilter = GameObjectUtil.AddComponentIfMissing<MeshFilter>(gameObject);
			MeshRenderer meshRenderer = GameObjectUtil.AddComponentIfMissing<MeshRenderer>(gameObject);
			meshFilter.mesh = modelInfo.Mesh;
			Mesh sharedMesh = meshFilter.sharedMesh;
			sharedMesh.name = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
		}
		transform.DetachChildren();
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, UnityEngine.Transform>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v310 @ S5_v5+4] (should have been resolved before IL gen)");
		Transform parent = base.transform;
		transform.parent = parent;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v61 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		float num7 = (float)Vector3.downVector * 500f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v62 (Il2CppStaticFields<UnityEngine.Vector3>)+28]");
		float num8 = 0f * 500f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v62 (Il2CppStaticFields<UnityEngine.Vector3>)+2C]");
		float num9 = 0f * 500f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector)->x = 0f;
		transform.localPosition = vector;
		PrefabPool prefabPool = PoolManager.GetPrefabPool(transform);
		prefabPool.preloadAmount = preloadAmount;
	}

	public static Transform[] GetEnvironmentBasePrefabs(EnvironmentBaseInfo envBaseInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		object obj3 = obj + 4;
		ThemeManager instance = ThemeManager.Instance;
		object obj4 = instance._theme + 124;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		GroundAssetGroup ga = (GroundAssetGroup)(obj + 4);
		return GetPrefabsForBaseInfo(ga, envBaseInfo);
	}

	public static Transform[] GetPrefabsForBaseInfo(GroundAssetGroup ga, EnvironmentBaseInfo envBaseInfo)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		if (envBaseInfo == EnvironmentBaseInfo.Tracks0)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks1)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks1ShadowStart)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks1ShadowMid)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks1ShadowEnd)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks1ShortShadowStart)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks1ShortShadowEnd)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks2)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks2ShadowStart)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks2ShadowMid)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks2ShadowEnd)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks2ShortShadowStart)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks2ShortShadowEnd)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks3)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks3ShadowStart)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks3ShadowMid)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks3ShadowEnd)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks3ShortShadowStart)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks3ShortShadowEnd)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks3Gates)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks3GatesShadow)
		{
			throw new ArrayTypeMismatchException();
		}
		if (envBaseInfo == EnvironmentBaseInfo.Tracks3Special)
		{
			throw new ArrayTypeMismatchException();
		}
		Transform[] result = default;
		return result;
	}

	public AssetManager()
	{
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, UnityEngine.Transform>>>)+4] (should have been resolved before IL gen)");
		Dictionary<EnvironmentBaseInfo, Transform> combinedEnvBaseModels = default;
		_combinedEnvBaseModels = combinedEnvBaseModels;
		base._002Ector();
	}
}
