//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\Spreadsheet.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SpreadsheetParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface ISpreadsheetListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>numericAtomExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericAtomExp([NotNull] SpreadsheetParser.NumericAtomExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numericAtomExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericAtomExp([NotNull] SpreadsheetParser.NumericAtomExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>powerExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPowerExp([NotNull] SpreadsheetParser.PowerExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>powerExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPowerExp([NotNull] SpreadsheetParser.PowerExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>mulDivExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulDivExp([NotNull] SpreadsheetParser.MulDivExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>mulDivExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulDivExp([NotNull] SpreadsheetParser.MulDivExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesisExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesisExp([NotNull] SpreadsheetParser.ParenthesisExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesisExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesisExp([NotNull] SpreadsheetParser.ParenthesisExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>idAtomExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdAtomExp([NotNull] SpreadsheetParser.IdAtomExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>idAtomExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdAtomExp([NotNull] SpreadsheetParser.IdAtomExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>addSubExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddSubExp([NotNull] SpreadsheetParser.AddSubExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addSubExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddSubExp([NotNull] SpreadsheetParser.AddSubExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>functionExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionExp([NotNull] SpreadsheetParser.FunctionExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionExp([NotNull] SpreadsheetParser.FunctionExpContext context);
}
