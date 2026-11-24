using Cpp2ILInjected;
using UnityEngine;

public class FriendProgressHelper : MonoBehaviour
{
	public UILabel label;

	public UISlider slider;

	public UISprite coinPouch;

	public Vector3 GetCoinPouchGlobalPosition()
	{
		//IL_001d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got VT
		//IL_00f3: Expected Obj, but got I
		//IL_0040: Expected Obj, but got VT
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got VT
		//IL_0099: Expected I4, but got Obj
		//IL_00a5: Expected Obj, but got I4
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+14]");
		((FriendGhostHelper)0)._002Ector();
		Vector3 vector = default;
		if ((object)this != null)
		{
			Challenger[] friends = ((FriendGhostHandler)vector).GetFriends();
			if (friends != null)
			{
				object obj = vector + 28;
				Challenger[] topRunPlayers = ((FriendGhostHandler)null).GetTopRunPlayers();
				Challenger[] sortedFriends = ((FriendGhostHandler)vector).GetSortedFriends();
				int nextChallengerWithHigherScoreIndex = ((FriendGhostHandler)null).getNextChallengerWithHigherScoreIndex(topRunPlayers, (int)sortedFriends);
				obj = nextChallengerWithHigherScoreIndex;
				goto IL_00da;
			}
		}
		object obj2 = vector + 28;
		bool flag = ((FriendGhostHandler)null).InsertLocalUserHighScore();
		obj2 = flag;
		goto IL_00da;
		IL_00da:
		((FriendGhostHandler)vector).ScaleHelperBackground();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+14]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v10+66]");
		if ((nint)0 == 0)
		{
			_ = 3;
		}
		return vector;
	}

	public FriendProgressHelper()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0083: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got F4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 20;
		obj = 0;
		obj = 0;
		obj = -72;
		_ = -41;
		_ = -19;
		_ = 127;
		object obj3 = obj2 + 24;
		obj3 = obj;
		object obj4 = obj2 + 28;
		obj4 = obj3;
		object obj5 = obj2 + 16;
		obj5 = 0;
		obj5 = 0;
		obj5 = 120;
		_ = -86;
		_ = -50;
		_ = 127;
		object obj6 = obj2 + 12;
		obj6 = obj5;
		obj4 = obj6;
		object obj7 = this - -64;
		obj7 = obj4;
		obj2 = 0;
		_ = 0;
		obj2 = 75f;
		_ = -22f;
		_ = 0f;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj8 = this + 68;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
		_ = 0;
		CancelInvoke();
	}
}
