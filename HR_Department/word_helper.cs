using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using Word = Microsoft.Office.Interop.Word;

namespace HR_Department
{
    class word_helper
    {
        private FileInfo _file_info;

        public word_helper(string file_name)
        {
            if (File.Exists(file_name))
            {
                _file_info = new FileInfo(file_name);
            }
            else
            {
                throw new ArgumentException("File not found");
            }
        }

        internal bool Process(Dictionary<string, string> items)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _file_info.FullName;
                Object missing = Type.Missing;

                app.Documents.Open(file);
                foreach(var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;
                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: true,
                        ReplaceWith: missing, Replace: replace);
                }

                Object new_file_name = Path.Combine(AddEmployeeClass.path_project, AddEmployeeClass.employee.Фамилия + AddEmployeeClass.employee.Имя + AddEmployeeClass.employee.Отчество + _file_info.Name);
                app.ActiveDocument.SaveAs2(new_file_name);
                app.ActiveDocument.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (app != null)
                {
                    app.Quit();
                }
            }
            return false;
        }
    }
}
