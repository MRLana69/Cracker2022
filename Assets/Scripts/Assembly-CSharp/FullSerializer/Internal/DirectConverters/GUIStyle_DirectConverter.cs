using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters;

public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle>
{
	protected unsafe override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea5: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected VT, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected VT, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected VT, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected VT, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected VT, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected VT, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected VT, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_023f: Expected Obj, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected VT, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected VT, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected VT, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected VT, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected VT, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected VT, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected VT, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected VT, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected VT, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected VT, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected Obj, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected VT, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected VT, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected VT, but got Unknown
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected VT, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected Obj, but got Unknown
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected VT, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected VT, but got Unknown
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected Obj, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected VT, but got Unknown
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected VT, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected Obj, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected VT, but got Unknown
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected VT, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected Obj, but got Unknown
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected VT, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected VT, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Expected Obj, but got Unknown
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected VT, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected VT, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected VT, but got Unknown
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected VT, but got Unknown
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Expected Obj, but got Unknown
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected VT, but got Unknown
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Expected VT, but got Unknown
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Expected Obj, but got Unknown
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a69: Expected VT, but got Unknown
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected VT, but got Unknown
		//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected Obj, but got Unknown
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected VT, but got Unknown
		//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Expected VT, but got Unknown
		//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b34: Expected Obj, but got Unknown
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected VT, but got Unknown
		//IL_0b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b94: Expected VT, but got Unknown
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc5: Expected Obj, but got Unknown
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c12: Expected VT, but got Unknown
		//IL_0c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c20: Expected VT, but got Unknown
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Expected Obj, but got Unknown
		//IL_0c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca3: Expected VT, but got Unknown
		//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb1: Expected VT, but got Unknown
		//IL_0cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected Obj, but got Unknown
		//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2f: Expected VT, but got Unknown
		//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3d: Expected VT, but got Unknown
		//IL_0d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6e: Expected Obj, but got Unknown
		//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc0: Expected VT, but got Unknown
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Expected VT, but got Unknown
		//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Expected Obj, but got Unknown
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4c: Expected VT, but got Unknown
		//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Expected VT, but got Unknown
		//IL_0e80: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 864;
		GUIStyleState active = model.active;
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(obj + 840);
		fsBaseConverter2.SerializeMember<GUIStyleState>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "active", active);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+348]");
		_ = 0;
		fsResult fsResult2 = (fsResult)(obj + 424);
		fsResult fsResult3 = (fsResult)(obj + 416);
		fsResult fsResult4 = fsResult2 + fsResult3;
		TextAnchor alignment = model.alignment;
		fsBaseConverter fsBaseConverter3 = (fsBaseConverter)(obj + 824);
		fsBaseConverter3.SerializeMember<TextAnchor>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "alignment", alignment);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+338]");
		_ = 0;
		fsResult fsResult5 = (fsResult)(obj + 408);
		fsResult fsResult6 = (fsResult)(obj + 400);
		fsResult fsResult7 = fsResult5 + fsResult6;
		RectOffset border = model.border;
		fsBaseConverter fsBaseConverter4 = (fsBaseConverter)(obj + 808);
		fsBaseConverter4.SerializeMember<RectOffset>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "border", border);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+328]");
		_ = 0;
		fsResult fsResult8 = (fsResult)(obj + 392);
		fsResult fsResult9 = (fsResult)(obj + 384);
		fsResult fsResult10 = fsResult8 + fsResult9;
		TextClipping clipping = model.clipping;
		fsBaseConverter fsBaseConverter5 = (fsBaseConverter)(obj + 792);
		fsBaseConverter5.SerializeMember<TextClipping>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "clipping", clipping);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+318]");
		_ = 0;
		fsResult fsResult11 = (fsResult)(obj + 376);
		fsResult fsResult12 = (fsResult)(obj + 368);
		fsResult fsResult13 = fsResult11 + fsResult12;
		Vector2 contentOffset = model.contentOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+310]");
		_ = 0;
		object obj3 = obj - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+168]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+168]");
		_ = 0;
		object obj4 = obj + 768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7350");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+300]");
		_ = 0;
		fsResult fsResult14 = (fsResult)(obj + 352);
		fsResult fsResult15 = (fsResult)(obj + 344);
		fsResult fsResult16 = fsResult14 + fsResult15;
		float fixedHeight = model.fixedHeight;
		fsBaseConverter fsBaseConverter6 = (fsBaseConverter)(obj + 752);
		fsBaseConverter6.SerializeMember<float>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "fixedHeight", fixedHeight);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2F0]");
		_ = 0;
		fsResult fsResult17 = (fsResult)(obj + 336);
		fsResult fsResult18 = (fsResult)(obj + 328);
		fsResult fsResult19 = fsResult17 + fsResult18;
		float fixedWidth = model.fixedWidth;
		fsBaseConverter fsBaseConverter7 = (fsBaseConverter)(obj + 736);
		fsBaseConverter7.SerializeMember<float>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "fixedWidth", fixedWidth);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2E0]");
		_ = 0;
		fsResult fsResult20 = (fsResult)(obj + 320);
		fsResult fsResult21 = (fsResult)(obj + 312);
		fsResult fsResult22 = fsResult20 + fsResult21;
		GUIStyleState focused = model.focused;
		fsBaseConverter fsBaseConverter8 = (fsBaseConverter)(obj + 720);
		fsBaseConverter8.SerializeMember<GUIStyleState>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "focused", focused);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2D0]");
		_ = 0;
		fsResult fsResult23 = (fsResult)(obj + 304);
		fsResult fsResult24 = (fsResult)(obj + 296);
		fsResult fsResult25 = fsResult23 + fsResult24;
		Font font = model.font;
		fsBaseConverter fsBaseConverter9 = (fsBaseConverter)(obj + 704);
		fsBaseConverter9.SerializeMember<Font>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "font", font);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C0]");
		_ = 0;
		fsResult fsResult26 = (fsResult)(obj + 288);
		fsResult fsResult27 = (fsResult)(obj + 280);
		fsResult fsResult28 = fsResult26 + fsResult27;
		int fontSize = model.fontSize;
		fsBaseConverter fsBaseConverter10 = (fsBaseConverter)(obj + 688);
		fsBaseConverter10.SerializeMember<int>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "fontSize", fontSize);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2B0]");
		_ = 0;
		fsResult fsResult29 = (fsResult)(obj + 272);
		fsResult fsResult30 = (fsResult)(obj + 264);
		fsResult fsResult31 = fsResult29 + fsResult30;
		FontStyle fontStyle = model.fontStyle;
		fsBaseConverter fsBaseConverter11 = (fsBaseConverter)(obj + 672);
		fsBaseConverter11.SerializeMember<FontStyle>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "fontStyle", fontStyle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A0]");
		_ = 0;
		fsResult fsResult32 = (fsResult)(obj + 256);
		fsResult fsResult33 = (fsResult)(obj + 248);
		fsResult fsResult34 = fsResult32 + fsResult33;
		GUIStyleState hover = model.hover;
		fsBaseConverter fsBaseConverter12 = (fsBaseConverter)(obj + 656);
		fsBaseConverter12.SerializeMember<GUIStyleState>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "hover", hover);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+290]");
		_ = 0;
		fsResult fsResult35 = (fsResult)(obj + 240);
		fsResult fsResult36 = (fsResult)(obj + 232);
		fsResult fsResult37 = fsResult35 + fsResult36;
		ImagePosition imagePosition = model.imagePosition;
		fsBaseConverter fsBaseConverter13 = (fsBaseConverter)(obj + 640);
		fsBaseConverter13.SerializeMember<ImagePosition>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "imagePosition", imagePosition);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
		_ = 0;
		fsResult fsResult38 = (fsResult)(obj + 224);
		fsResult fsResult39 = (fsResult)(obj + 216);
		fsResult fsResult40 = fsResult38 + fsResult39;
		RectOffset margin = model.margin;
		fsBaseConverter fsBaseConverter14 = (fsBaseConverter)(obj + 624);
		fsBaseConverter14.SerializeMember<RectOffset>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "margin", margin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
		_ = 0;
		fsResult fsResult41 = (fsResult)(obj + 208);
		fsResult fsResult42 = (fsResult)(obj + 200);
		fsResult fsResult43 = fsResult41 + fsResult42;
		string name = model.name;
		fsBaseConverter fsBaseConverter15 = (fsBaseConverter)(obj + 608);
		fsBaseConverter15.SerializeMember<string>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "name", name);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+260]");
		_ = 0;
		fsResult fsResult44 = (fsResult)(obj + 192);
		fsResult fsResult45 = (fsResult)(obj + 184);
		fsResult fsResult46 = fsResult44 + fsResult45;
		GUIStyleState normal = model.normal;
		fsBaseConverter fsBaseConverter16 = (fsBaseConverter)(obj + 592);
		fsBaseConverter16.SerializeMember<GUIStyleState>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "normal", normal);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+250]");
		_ = 0;
		fsResult fsResult47 = (fsResult)(obj + 176);
		fsResult fsResult48 = (fsResult)(obj + 168);
		fsResult fsResult49 = fsResult47 + fsResult48;
		GUIStyleState onActive = model.onActive;
		fsBaseConverter fsBaseConverter17 = (fsBaseConverter)(obj + 576);
		fsBaseConverter17.SerializeMember<GUIStyleState>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "onActive", onActive);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+240]");
		_ = 0;
		fsResult fsResult50 = (fsResult)(obj + 160);
		fsResult fsResult51 = (fsResult)(obj + 152);
		fsResult fsResult52 = fsResult50 + fsResult51;
		GUIStyleState onFocused = model.onFocused;
		fsBaseConverter fsBaseConverter18 = (fsBaseConverter)(obj + 560);
		fsBaseConverter18.SerializeMember<GUIStyleState>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "onFocused", onFocused);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
		_ = 0;
		fsResult fsResult53 = (fsResult)(obj + 144);
		fsResult fsResult54 = (fsResult)(obj + 136);
		fsResult fsResult55 = fsResult53 + fsResult54;
		GUIStyleState onHover = model.onHover;
		fsBaseConverter fsBaseConverter19 = (fsBaseConverter)(obj + 544);
		fsBaseConverter19.SerializeMember<GUIStyleState>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "onHover", onHover);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+220]");
		_ = 0;
		fsResult fsResult56 = (fsResult)(obj + 128);
		fsResult fsResult57 = (fsResult)(obj + 120);
		fsResult fsResult58 = fsResult56 + fsResult57;
		GUIStyleState onNormal = model.onNormal;
		fsBaseConverter fsBaseConverter20 = (fsBaseConverter)(obj + 528);
		fsBaseConverter20.SerializeMember<GUIStyleState>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "onNormal", onNormal);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+210]");
		_ = 0;
		fsResult fsResult59 = (fsResult)(obj + 112);
		fsResult fsResult60 = (fsResult)(obj + 104);
		fsResult fsResult61 = fsResult59 + fsResult60;
		RectOffset overflow = model.overflow;
		fsBaseConverter fsBaseConverter21 = (fsBaseConverter)(obj + 512);
		fsBaseConverter21.SerializeMember<RectOffset>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "overflow", overflow);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+200]");
		_ = 0;
		fsResult fsResult62 = (fsResult)(obj + 96);
		fsResult fsResult63 = (fsResult)(obj + 88);
		fsResult fsResult64 = fsResult62 + fsResult63;
		RectOffset padding = model.padding;
		fsBaseConverter fsBaseConverter22 = (fsBaseConverter)(obj + 496);
		fsBaseConverter22.SerializeMember<RectOffset>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "padding", padding);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F0]");
		_ = 0;
		fsResult fsResult65 = (fsResult)(obj + 80);
		fsResult fsResult66 = (fsResult)(obj + 72);
		fsResult fsResult67 = fsResult65 + fsResult66;
		bool richText = model.richText;
		fsBaseConverter fsBaseConverter23 = (fsBaseConverter)(obj + 480);
		fsBaseConverter23.SerializeMember<bool>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "richText", richText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E0]");
		_ = 0;
		fsResult fsResult68 = (fsResult)(obj - -64);
		fsResult fsResult69 = (fsResult)(obj + 56);
		fsResult fsResult70 = fsResult68 + fsResult69;
		bool stretchHeight = model.stretchHeight;
		fsBaseConverter fsBaseConverter24 = (fsBaseConverter)(obj + 464);
		fsBaseConverter24.SerializeMember<bool>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "stretchHeight", stretchHeight);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D0]");
		_ = 0;
		fsResult fsResult71 = (fsResult)(obj + 48);
		fsResult fsResult72 = (fsResult)(obj + 40);
		fsResult fsResult73 = fsResult71 + fsResult72;
		bool stretchWidth = model.stretchWidth;
		fsBaseConverter fsBaseConverter25 = (fsBaseConverter)(obj + 448);
		fsBaseConverter25.SerializeMember<bool>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "stretchWidth", stretchWidth);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C0]");
		_ = 0;
		fsResult fsResult74 = (fsResult)(obj + 32);
		fsResult fsResult75 = (fsResult)(obj + 24);
		fsResult fsResult76 = fsResult74 + fsResult75;
		bool wordWrap = model.wordWrap;
		fsBaseConverter fsBaseConverter26 = (fsBaseConverter)(obj + 432);
		fsBaseConverter26.SerializeMember<bool>((Dictionary<string, fsData>)(object)this, (Type)(object)serialized, "wordWrap", wordWrap);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B0]");
		_ = 0;
		fsResult fsResult77 = (fsResult)(obj + 16);
		fsResult fsResult78 = (fsResult)(obj + 8);
		fsResult fsResult79 = fsResult77 + fsResult78;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		fsResult fsResult80 = default;
		((fsResult*)(nint)fsResult80)->_success = false;
		return fsResult80;
	}

	protected unsafe override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1176: Unknown result type (might be due to invalid IL or missing references)
		//IL_117b: Expected Obj, but got Unknown
		//IL_1184: Unknown result type (might be due to invalid IL or missing references)
		//IL_1189: Expected Ref, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected VT, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Unknown
		//IL_006f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 960;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		GUIStyleState active = model.active;
		fsBaseConverter fsBaseConverter2 = (fsBaseConverter)(obj + 840);
		fsBaseConverter2.DeserializeMember<GUIStyleState>((Dictionary<string, fsData>)(object)this, (Type)(object)data, "active", out *(GUIStyleState*)(obj + 956));
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+348]");
		_ = 0;
		fsResult fsResult2 = (fsResult)(obj + 424);
		fsResult fsResult3 = (fsResult)(obj + 416);
		fsResult fsResult4 = fsResult2 + fsResult3;
		GUIStyle obj3 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3BC]");
		obj3.active = (GUIStyleState)0;
		TextAnchor alignment = model.alignment;
		throw new NullReferenceException();
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		GUIStyle gUIStyle = default;
		gUIStyle._002Ector();
		return gUIStyle;
	}
}
