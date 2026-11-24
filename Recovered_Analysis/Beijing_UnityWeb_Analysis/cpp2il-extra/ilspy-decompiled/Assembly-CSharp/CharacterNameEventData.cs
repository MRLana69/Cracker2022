using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using SYBO.Subway.Info;

public class CharacterNameEventData
{
	public Characters.CharacterId currentCharacter;

	public int collectedLetterIndex;

	public int skippedCharacters;

	public bool wasLastCharacterCompleted;

	public int completedCharacters;

	public List<Characters.CharacterId> charactersList;

	public List<string> categoryWordsList;

	public long eventID;

	public SSEventCategory eventCategory;

	public CharacterNameEventData(List<Characters.CharacterId> charactersList, List<string> categoryWordsList, SSEventCategory eventCategory, Characters.CharacterId currentCharacter, int collectedLetterIndex, int completedCharacters, int skippedCharacters, bool wasLastCharacterCompleted, long eventID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public unsafe CharacterNameEventData()
	{
		//IL_584d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5852: Expected Obj, but got Unknown
		//IL_585b: Expected Obj, but got I4
		//IL_586a: Expected Obj, but got I4
		//IL_5873: Unknown result type (might be due to invalid IL or missing references)
		//IL_5878: Expected Obj, but got Unknown
		//IL_5889: Unknown result type (might be due to invalid IL or missing references)
		//IL_588e: Expected I4, but got Unknown
		//IL_589b: Expected I4, but got Obj
		//IL_58a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_58a9: Expected Obj, but got Unknown
		//IL_58b6: Expected Obj, but got I4
		//IL_58bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_58c4: Expected Obj, but got Unknown
		//IL_58cd: Expected Obj, but got I4
		//IL_58dc: Expected Obj, but got I4
		//IL_58e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_58ea: Expected Obj, but got Unknown
		//IL_58ff: Expected I4, but got Obj
		//IL_5908: Unknown result type (might be due to invalid IL or missing references)
		//IL_590d: Expected Obj, but got Unknown
		//IL_591a: Expected Obj, but got I4
		//IL_5923: Unknown result type (might be due to invalid IL or missing references)
		//IL_5928: Expected Obj, but got Unknown
		//IL_5931: Expected Obj, but got I4
		//IL_5940: Expected Obj, but got I4
		//IL_5949: Unknown result type (might be due to invalid IL or missing references)
		//IL_594e: Expected Obj, but got Unknown
		//IL_5963: Expected I4, but got Obj
		//IL_596c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5971: Expected Obj, but got Unknown
		//IL_597e: Expected Obj, but got I4
		//IL_5987: Unknown result type (might be due to invalid IL or missing references)
		//IL_598c: Expected Obj, but got Unknown
		//IL_5995: Expected Obj, but got I4
		//IL_59a4: Expected Obj, but got I4
		//IL_59ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_59b2: Expected Obj, but got Unknown
		//IL_59c7: Expected I4, but got Obj
		//IL_59d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_59d5: Expected Obj, but got Unknown
		//IL_59e2: Expected Obj, but got I4
		//IL_59eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_59f0: Expected Obj, but got Unknown
		//IL_59f9: Expected Obj, but got I4
		//IL_5a08: Expected Obj, but got I4
		//IL_5a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a16: Expected Obj, but got Unknown
		//IL_5a2b: Expected I4, but got Obj
		//IL_5a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a39: Expected Obj, but got Unknown
		//IL_5a46: Expected Obj, but got I4
		//IL_5a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a54: Expected Obj, but got Unknown
		//IL_5a5d: Expected Obj, but got I4
		//IL_5a6c: Expected Obj, but got I4
		//IL_5a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a7a: Expected Obj, but got Unknown
		//IL_5a8f: Expected I4, but got Obj
		//IL_5a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a9d: Expected Obj, but got Unknown
		//IL_5aaa: Expected Obj, but got I4
		//IL_5ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ab8: Expected Obj, but got Unknown
		//IL_5ac1: Expected Obj, but got I4
		//IL_5ad0: Expected Obj, but got I4
		//IL_5ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ade: Expected Obj, but got Unknown
		//IL_5af3: Expected I4, but got Obj
		//IL_5afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b01: Expected Obj, but got Unknown
		//IL_5b0e: Expected Obj, but got I4
		//IL_5b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b1c: Expected Obj, but got Unknown
		//IL_5b25: Expected Obj, but got I4
		//IL_5b34: Expected Obj, but got I4
		//IL_5b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b42: Expected Obj, but got Unknown
		//IL_5b57: Expected I4, but got Obj
		//IL_5b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b65: Expected Obj, but got Unknown
		//IL_5b72: Expected Obj, but got I4
		//IL_5b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b80: Expected Obj, but got Unknown
		//IL_5b89: Expected Obj, but got I4
		//IL_5b98: Expected Obj, but got I4
		//IL_5ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ba6: Expected Obj, but got Unknown
		//IL_5bbb: Expected I4, but got Obj
		//IL_5bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5bc9: Expected Obj, but got Unknown
		//IL_5bd6: Expected Obj, but got I4
		//IL_5bdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_5be4: Expected Obj, but got Unknown
		//IL_5bed: Expected Obj, but got I4
		//IL_5bfc: Expected Obj, but got I4
		//IL_5c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c0a: Expected Obj, but got Unknown
		//IL_5c1f: Expected I4, but got Obj
		//IL_5c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c2d: Expected Obj, but got Unknown
		//IL_5c3a: Expected Obj, but got I4
		//IL_5c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c48: Expected Obj, but got Unknown
		//IL_5c51: Expected Obj, but got I4
		//IL_5c60: Expected Obj, but got I4
		//IL_5c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c6e: Expected Obj, but got Unknown
		//IL_5c83: Expected I4, but got Obj
		//IL_5c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c91: Expected Obj, but got Unknown
		//IL_5c9e: Expected Obj, but got I4
		//IL_5ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_5cac: Expected Obj, but got Unknown
		//IL_5cb5: Expected Obj, but got I4
		//IL_5cc4: Expected Obj, but got I4
		//IL_5ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_5cd2: Expected Obj, but got Unknown
		//IL_5ce7: Expected I4, but got Obj
		//IL_5cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_5cf5: Expected Obj, but got Unknown
		//IL_5d02: Expected Obj, but got I4
		//IL_5d0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d10: Expected Obj, but got Unknown
		//IL_5d19: Expected Obj, but got I4
		//IL_5d28: Expected Obj, but got I4
		//IL_5d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d36: Expected Obj, but got Unknown
		//IL_5d4b: Expected I4, but got Obj
		//IL_5d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d59: Expected Obj, but got Unknown
		//IL_5d66: Expected Obj, but got I4
		//IL_5d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d74: Expected Obj, but got Unknown
		//IL_5d7d: Expected Obj, but got I4
		//IL_5d8c: Expected Obj, but got I4
		//IL_5d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d9a: Expected Obj, but got Unknown
		//IL_5daf: Expected I4, but got Obj
		//IL_5db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dbd: Expected Obj, but got Unknown
		//IL_5dca: Expected Obj, but got I4
		//IL_5dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dd8: Expected Obj, but got Unknown
		//IL_5de1: Expected Obj, but got I4
		//IL_5df0: Expected Obj, but got I4
		//IL_5df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dfe: Expected Obj, but got Unknown
		//IL_5e13: Expected I4, but got Obj
		//IL_5e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e21: Expected Obj, but got Unknown
		//IL_5e2e: Expected Obj, but got I4
		currentCharacter = Characters.CharacterId.lucy;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 2448;
		obj = 0;
		_ = 1;
		obj = 0;
		object obj3 = obj2 + 3272;
		obj3 = obj;
		CallingConvention callingConvention = (CallingConvention)(obj2 + 3288);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj3;
		object obj5 = default;
		object obj4 = obj5 + 16;
		obj4 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj6 = obj2 + 2440;
		obj6 = 0;
		_ = 1;
		obj6 = 11;
		object obj7 = obj2 + 3264;
		obj7 = obj6;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj7;
		object obj8 = obj5 + 32;
		obj8 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj9 = obj2 + 2432;
		obj9 = 0;
		_ = 1;
		obj9 = 2;
		object obj10 = obj2 + 3256;
		obj10 = obj9;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj10;
		object obj11 = obj5 + 56;
		obj11 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj12 = obj2 + 2416;
		obj12 = 0;
		_ = 1;
		obj12 = 6;
		object obj13 = obj2 + 3248;
		obj13 = obj12;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj13;
		object obj14 = obj5 - -64;
		obj14 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj15 = obj2 + 2408;
		obj15 = 0;
		_ = 1;
		obj15 = 3;
		object obj16 = obj2 + 3240;
		obj16 = obj15;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj16;
		object obj17 = obj5 + 88;
		obj17 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj18 = obj2 + 2392;
		obj18 = 0;
		_ = 1;
		obj18 = 8;
		object obj19 = obj2 + 3232;
		obj19 = obj18;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj19;
		object obj20 = obj5 + 96;
		obj20 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj21 = obj2 + 2384;
		obj21 = 0;
		_ = 1;
		obj21 = 13;
		object obj22 = obj2 + 3224;
		obj22 = obj21;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj22;
		object obj23 = obj5 + 104;
		obj23 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj24 = obj2 + 2368;
		obj24 = 0;
		_ = 1;
		obj24 = 1;
		object obj25 = obj2 + 3216;
		obj25 = obj24;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj25;
		object obj26 = obj5 + 112;
		obj26 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj27 = obj2 + 2360;
		obj27 = 0;
		_ = 1;
		obj27 = 7;
		object obj28 = obj2 + 3208;
		obj28 = obj27;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj28;
		object obj29 = obj5 + 136;
		obj29 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj30 = obj2 + 2344;
		obj30 = 0;
		_ = 1;
		obj30 = 12;
		object obj31 = obj2 + 3200;
		obj31 = obj30;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj31;
		object obj32 = obj5 + 144;
		obj32 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj33 = obj2 + 2336;
		obj33 = 0;
		_ = 1;
		obj33 = 5;
		object obj34 = obj2 + 3192;
		obj34 = obj33;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj34;
		object obj35 = obj5 + 168;
		obj35 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj36 = obj2 + 2320;
		obj36 = 0;
		_ = 1;
		obj36 = 4;
		object obj37 = obj2 + 3184;
		obj37 = obj36;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj37;
		object obj38 = obj5 + 176;
		obj38 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj39 = obj2 + 2312;
		obj39 = 0;
		_ = 1;
		obj39 = 14;
		object obj40 = obj2 + 3176;
		obj40 = obj39;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj40;
		object obj41 = obj5 + 200;
		obj41 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj42 = obj2 + 2296;
		obj42 = 0;
		_ = 1;
		obj42 = 9;
		object obj43 = obj2 + 3168;
		obj43 = obj42;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj43;
		object obj44 = obj5 + 208;
		obj44 = ((CallingConvention*)(int)callingConvention)->value__;
		object obj45 = obj2 + 2288;
		obj45 = 0;
		_ = 1;
		obj45 = 10;
		object obj46 = obj2 + 3160;
		obj46 = obj45;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj46;
		object obj47 = obj5 + 232;
		obj47 = ((CallingConvention*)(int)callingConvention)->value__;
		throw new ArrayTypeMismatchException();
	}
}
