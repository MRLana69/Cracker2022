using Cpp2ILInjected;
using UnityEngine;

namespace WeeklyHunt;

public class WeeklyHuntColorImporterSettings : ScriptableObject
{
	public Texture2D salesTexture;

	public Texture2D huntTexture;

	public Vector2[] salesPixelSamplers;

	public Vector2[] huntPixelSamplers;

	public Color32[] miscColors;

	public Color32[] salesColors;

	public Color32[] huntColors;

	public WeeklyHuntColorImporterSettings()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
