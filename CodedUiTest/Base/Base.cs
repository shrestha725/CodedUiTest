﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodedUiTest.AuditHistory;
using CodedUiTest.EmployeeList;
using CodedUiTest.Header;
using CodedUiTest.LeftMenu;
using CodedUiTest.Login;
using CodedUiTest.ToolBar;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
using MouseButtons = System.Windows.Forms.MouseButtons;
using CodedUiTest.EmployeeDeductions;

namespace CodedUiTest.Base
{
    public class TestBase
    {
        public LoginTestCases Login = new LoginTestCases();
        public LeftMenuTestCases LeftMenuTestCases = new LeftMenuTestCases();
        public ToolBarTestCases ToolBarTestCases = new ToolBarTestCases();
        public HeaderTestCases HeaderTestCases = new HeaderTestCases();
        public AuditHistoryTestCases AuditHistoryTestCases = new AuditHistoryTestCases();
        public EmployeeListTestCases EmployeeListTestCases = new EmployeeListTestCases();
        public EmployeeDeductionsTestCases EmployeeDeductionsTestCases = new EmployeeDeductionsTestCases();
        public static int tabOrder;
        //public Browser;

         //BrowserWindow Browser = BrowserWindow.Launch("https://empowerpayqa.empowerpay.com");
        
       



        public void LaunchInternetExplorerWithEmpowerPayQA()
        {
            //Playback.Initialize();
            // BrowserWindow browser = BrowserWindow.Launch(new System.Uri("https://empowerpayqa.empowerpay.com/Empower/"));
        }

        public static string GetTabValue()
        {
            switch (tabOrder)
            {
                case 1: return "19";
                case 2: return "24";
                case 3: return "29";
                case 4: return "34";
                case 5: return "39";
                case 6: return "44";
                case 7: return "49";
                default: return "";
            }
        }

       
        //private string fileName()
        //{

        //    const string a = "EMP_BenefitEnrollment_Dental.csv";
        //}




          public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
          public TestContext testContextInstance;

        ///--------------------------
          public string getText(HtmlEdit editControl)
          {
              string text = editControl.Text;
              //Debug.WriteLine(editControl.Id + ": " + text);
              return text;
          }
          public string getInnerText(HtmlEdit editControl)
          {
              string InnerText = editControl.InnerText;
              //Debug.WriteLine(editControl.Id + ": " + InnerText);
              return InnerText;
          }



          public static String GetTimeStamp(DateTime value)
          {
              return
                  value.ToString("MMddHHmmss");// 
              //*** Since there is a 10 digits restriction for the employee number year can not be included therefore there is chances that same employee number will be generated next year. 
              //value.ToString("yyyyMMddHHmmssffff");
              //value.ToString("yyyyMMddHHmmss");
              //value.ToString("yyMMddHHmmss");
              
          }


     


       



              

            










          /// <summary>
          /// Determines how empty lines are interpreted when reading CSV files.
          /// These values do not affect empty lines that occur within quoted fields
          /// or empty lines that appear at the end of the input file.
          /// </summary>
          public enum EmptyLineBehavior
          {
              /// <summary>
              /// Empty lines are interpreted as a line with zero columns.
              /// </summary>
              NoColumns,
              /// <summary>
              /// Empty lines are interpreted as a line with a single empty column.
              /// </summary>
              EmptyColumn,
              /// <summary>
              /// Empty lines are skipped over as though they did not exist.
              /// </summary>
              Ignore,
              /// <summary>
              /// An empty line is interpreted as the end of the input file.
              /// </summary>
              EndOfFile,
          }

          /// <summary>
          /// Common base class for CSV reader and writer classes.
          /// </summary>
          public abstract class CsvFileCommon
          {
              /// <summary>
              /// These are special characters in CSV files. If a column contains any
              /// of these characters, the entire column is wrapped in double quotes.
              /// </summary>
              protected char[] SpecialChars = new char[] { ',', '"', '\r', '\n' };

              // Indexes into SpecialChars for characters with specific meaning
              public const int DelimiterIndex = 0;
              public const int QuoteIndex = 1;

              /// <summary>
              /// Gets/sets the character used for column delimiters.
              /// </summary>
              public char Delimiter
              {
                  get { return SpecialChars[DelimiterIndex]; }
                  set { SpecialChars[DelimiterIndex] = value; }
              }

              /// <summary>
              /// Gets/sets the character used for column quotes.
              /// </summary>
              public char Quote
              {
                  get { return SpecialChars[QuoteIndex]; }
                  set { SpecialChars[QuoteIndex] = value; }
              }
          }

          /// <summary>
          /// Class for reading from comma-separated-value (CSV) files
          /// </summary>
          public class CsvFileReader : CsvFileCommon, IDisposable
          {
              // public members
              public StreamReader Reader;
              public string CurrLine;
              public int CurrPos;
              public EmptyLineBehavior EmptyLineBehavior;

              /// <summary>
              /// Initializes a new instance of the CsvFileReader class for the
              /// specified stream.
              /// </summary>
              /// <param name="stream">The stream to read from</param>
              /// <param name="emptyLineBehavior">Determines how empty lines are handled</param>
              public CsvFileReader(Stream stream,
                  EmptyLineBehavior emptyLineBehavior = EmptyLineBehavior.NoColumns)
              {
                  Reader = new StreamReader(stream);
                  EmptyLineBehavior = emptyLineBehavior;
              }

              /// <summary>
              /// Initializes a new instance of the CsvFileReader class for the
              /// specified file path.
              /// </summary>
              /// <param name="path">The name of the CSV file to read from</param>
              /// <param name="emptyLineBehavior">Determines how empty lines are handled</param>
              public CsvFileReader(string path,
                  EmptyLineBehavior emptyLineBehavior = EmptyLineBehavior.NoColumns)
              {
                  Reader = new StreamReader(path);
                  EmptyLineBehavior = emptyLineBehavior;
              }

              /// <summary>
              /// Reads a row of columns from the current CSV file. Returns false if no
              /// more data could be read because the end of the file was reached.
              /// </summary>
              /// <param name="columns">Collection to hold the columns read</param>
              public bool ReadRow(List<string> columns)
              {
                  // Verify required argument
                  if (columns == null)
                      throw new ArgumentNullException("columns");

              ReadNextLine:
                  // Read next line from the file
                  CurrLine = Reader.ReadLine();
                  CurrPos = 0;
                  // Test for end of file
                  if (CurrLine == null)
                      return false;
                  // Test for empty line
                  if (CurrLine.Length == 0)
                  {
                      switch (EmptyLineBehavior)
                      {
                          case EmptyLineBehavior.NoColumns:
                              columns.Clear();
                              return true;
                          case EmptyLineBehavior.Ignore:
                              goto ReadNextLine;
                          case EmptyLineBehavior.EndOfFile:
                              return false;
                      }
                  }

                  // Parse line
                  string column;
                  int numColumns = 0;
                  while (true)
                  {
                      // Read next column
                      if (CurrPos < CurrLine.Length && CurrLine[CurrPos] == Quote)
                          column = ReadQuotedColumn();
                      else
                          column = ReadUnquotedColumn();
                      // Add column to list
                      if (numColumns < columns.Count)
                          columns[numColumns] = column;
                      else
                          columns.Add(column);
                      numColumns++;
                      // Break if we reached the end of the line
                      if (CurrLine == null || CurrPos == CurrLine.Length)
                          break;
                      // Otherwise skip delimiter
                      //Debug.Assert(CurrLine[CurrPos] == Delimiter);
                      CurrPos++;
                  }
                  // Remove any unused columns from collection
                  if (numColumns < columns.Count)
                      columns.RemoveRange(numColumns, columns.Count - numColumns);
                  // Indicate success
                  return true;
              }

              /// <summary>
              /// Reads a quoted column by reading from the current line until a
              /// closing quote is found or the end of the file is reached. On return,
              /// the current position points to the delimiter or the end of the last
              /// line in the file. Note: CurrLine may be set to null on return.
              /// </summary>
              public string ReadQuotedColumn()
              {
                  // Skip opening quote character
                  //Debug.Assert(CurrPos < CurrLine.Length && CurrLine[CurrPos] == Quote);
                  CurrPos++;

                  // Parse column
                  StringBuilder builder = new StringBuilder();
                  while (true)
                  {
                      while (CurrPos == CurrLine.Length)
                      {
                          // End of line so attempt to read the next line
                          CurrLine = Reader.ReadLine();
                          CurrPos = 0;
                          // Done if we reached the end of the file
                          if (CurrLine == null)
                              return builder.ToString();
                          // Otherwise, treat as a multi-line field
                          builder.Append(Environment.NewLine);
                      }

                      // Test for quote character
                      if (CurrLine[CurrPos] == Quote)
                      {
                          // If two quotes, skip first and treat second as literal
                          int nextPos = (CurrPos + 1);
                          if (nextPos < CurrLine.Length && CurrLine[nextPos] == Quote)
                              CurrPos++;
                          else
                              break;  // Single quote ends quoted sequence
                      }
                      // Add current character to the column
                      builder.Append(CurrLine[CurrPos++]);
                  }

                  if (CurrPos < CurrLine.Length)
                  {
                      // Consume closing quote
                      //Debug.Assert(CurrLine[CurrPos] == Quote);
                      CurrPos++;
                      // Append any additional characters appearing before next delimiter
                      builder.Append(ReadUnquotedColumn());
                  }
                  // Return column value
                  return builder.ToString();
              }

              /// <summary>
              /// Reads an unquoted column by reading from the current line until a
              /// delimiter is found or the end of the line is reached. On return, the
              /// current position points to the delimiter or the end of the current
              /// line.
              /// </summary>
              public string ReadUnquotedColumn()
              {
                  int startPos = CurrPos;
                  CurrPos = CurrLine.IndexOf(Delimiter, CurrPos);
                  if (CurrPos == -1)
                      CurrPos = CurrLine.Length;
                  if (CurrPos > startPos)
                      return CurrLine.Substring(startPos, CurrPos - startPos);
                  return String.Empty;
              }

              // Propagate Dispose to StreamReader
              public void Dispose()
              {
                  Reader.Dispose();
              }
          }

          /// <summary>
          /// Class for writing to comma-separated-value (CSV) files.
          /// </summary>
          public class CsvFileWriter : CsvFileCommon, IDisposable
          {
              // public members
              public StreamWriter Writer;
              public string OneQuote = null;   
              public string TwoQuotes = null;
              public string QuotedFormat = null;

              /// <summary>
              /// Initializes a new instance of the CsvFileWriter class for the
              /// specified stream.
              /// </summary>
              /// <param name="stream">The stream to write to</param>
              public CsvFileWriter(Stream stream)
              {
                  Writer = new StreamWriter(stream);
              }

              /// <summary>
              /// Initializes a new instance of the CsvFileWriter class for the
              /// specified file path.
              /// </summary>
              /// <param name="path">The name of the CSV file to write to</param>
              public CsvFileWriter(string path)
              {
                  Writer = new StreamWriter(path);
              }

              /// <summary>
              /// Writes a row of columns to the current CSV file.
              /// </summary>
              /// <param name="columns">The list of columns to write</param>
              public void WriteRow(List<string> columns)
              {
                  // Verify required argument
                  if (columns == null)
                      throw new ArgumentNullException("columns");

                  // Ensure we're using current quote character
                  if (OneQuote == null || OneQuote[0] != Quote)
                  {
                      OneQuote = String.Format("{0}", Quote);
                      TwoQuotes = String.Format("{0}{0}", Quote);
                      QuotedFormat = String.Format("{0}{{0}}{0}", Quote);
                  }

                  // Write each column
                  for (int i = 0; i < columns.Count; i++)
                  {
                      // Add delimiter if this isn't the first column
                      if (i > 0)
                          Writer.Write(Delimiter);
                      // Write this column
                      if (columns[i].IndexOfAny(SpecialChars) == -1)
                          Writer.Write(columns[i]);
                      else
                          Writer.Write(QuotedFormat, columns[i].Replace(OneQuote, TwoQuotes));
                  }
                  Writer.WriteLine();
              }

              // Propagate Dispose to StreamWriter
              public void Dispose()
              {
                  Writer.Dispose();
              }
          }


          public void WriteValues()
          {
              using (var writer = new CsvFileWriter("WriteTest.csv"))
              {
                  // Write each row of data
                  for (int row = 0; row < 100; row++)
                  {
                      // TODO: Populate column values for this row
                      List<string> columns = new List<string>();
                      writer.WriteRow(columns);
                  }
              }
          }

          public void ReadValues()
          {
              List<string> columns = new List<string>();
              using (var reader = new CsvFileReader("ReadTest.csv"))
              {
                  while (reader.ReadRow(columns))
                  {
                      // TODO: Do something with columns' values
                  }
              }
          }
    


        }
    }







    


