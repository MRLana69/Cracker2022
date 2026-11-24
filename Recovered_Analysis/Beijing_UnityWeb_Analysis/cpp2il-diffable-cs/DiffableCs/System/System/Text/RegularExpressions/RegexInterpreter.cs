namespace System.Text.RegularExpressions;

internal sealed class RegexInterpreter : RegexRunner
{
	internal int runoperator; //Field offset: 0x50
	internal int[] runcodes; //Field offset: 0x54
	internal int runcodepos; //Field offset: 0x58
	internal string[] runstrings; //Field offset: 0x5C
	internal RegexCode runcode; //Field offset: 0x60
	internal RegexPrefix runfcPrefix; //Field offset: 0x64
	internal RegexBoyerMoore runbmPrefix; //Field offset: 0x68
	internal int runanchors; //Field offset: 0x6C
	internal bool runrtl; //Field offset: 0x70
	internal bool runci; //Field offset: 0x71
	internal CultureInfo runculture; //Field offset: 0x74

	internal RegexInterpreter(RegexCode code, CultureInfo culture) { }

	private void Advance() { }

	private void Advance(int i) { }

	private void Backtrack() { }

	private void Backwardnext() { }

	private int Bump() { }

	private char CharAt(int j) { }

	protected override bool FindFirstChar() { }

	private char Forwardcharnext() { }

	private int Forwardchars() { }

	protected override void Go() { }

	private void Goto(int newpos) { }

	protected override void InitTrackCount() { }

	private int Leftchars() { }

	private int Operand(int i) { }

	private int Operator() { }

	private bool Refmatch(int index, int len) { }

	private int Rightchars() { }

	private void SetOperator(int op) { }

	private int StackPeek(int i) { }

	private int StackPeek() { }

	private void StackPop() { }

	private void StackPop(int framesize) { }

	private void StackPush(int I1) { }

	private void StackPush(int I1, int I2) { }

	private bool Stringmatch(string str) { }

	private int Textpos() { }

	private int Textstart() { }

	private void Textto(int newpos) { }

	private int TrackPeek() { }

	private int TrackPeek(int i) { }

	private void TrackPop(int framesize) { }

	private void TrackPop() { }

	private int Trackpos() { }

	private void TrackPush(int I1, int I2, int I3) { }

	private void TrackPush(int I1, int I2) { }

	private void TrackPush() { }

	private void TrackPush(int I1) { }

	private void TrackPush2(int I1, int I2) { }

	private void TrackPush2(int I1) { }

	private void Trackto(int newpos) { }

}

