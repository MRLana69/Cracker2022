using Cpp2ILInjected;
using UnityEngine;

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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Vector2[] array = default;
		salesPixelSamplers = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Vector2[] array2 = default;
		huntPixelSamplers = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Color32[] array3 = default;
		miscColors = array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Color32[] array4 = default;
		salesColors = array4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Color32[] array5 = default;
		huntColors = array5;
		base._002Ector();
	}
}
