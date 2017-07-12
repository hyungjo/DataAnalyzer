using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataAnalyzer.Tool
{
    public class ExcelToDataTableConverter
    {
        public static DataTable ImportDataTableFromExcel(string filePath)
        {
            try
            {
                DataTable dt = new DataTable();

                if (Path.GetExtension(filePath) == ".csv")
                {
                    string Fulltext;
                    
                        using (StreamReader sr = new StreamReader(filePath))
                        {
                            while (!sr.EndOfStream)
                            {
                                Fulltext = sr.ReadToEnd().ToString(); //read full file text  
                                string[] rows = Fulltext.Split('\n'); //split full file text into rows  
                                for (int i = 0; i < rows.Count() - 1; i++)
                                {
                                    string[] rowValues = rows[i].Split(','); //split each row with comma to get individual values  
                                    {
                                        if (i == 0)
                                        {
                                            for (int j = 0; j < rowValues.Count(); j++)
                                            {
                                                dt.Columns.Add(rowValues[j]); //add headers  
                                            }
                                        }
                                        else
                                        {
                                            DataRow dr = dt.NewRow();
                                            for (int k = 0; k < rowValues.Count(); k++)
                                            {
                                                dr[k] = rowValues[k].ToString();
                                            }
                                            dt.Rows.Add(dr); //add other rows  
                                        }
                                    }
                                }
                            }
                        }
                    return dt;
                }
                else
                {
                    string fullPath = Path.GetFullPath(filePath);
                    string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=NO;IMEX=1;TypeGuessRows=0;ImportMixedTypes=Text';";
                    string sql = @"SELECT * FROM [sheet1$]";

                    using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connString))
                    {
                        dataAdapter.Fill(dt);
                    }
                    dt = BuildHeadersFromFirstRowThenRemoveFirstRow(dt);

                    return dt;
                }
            }
            catch(InvalidOperationException ioe)
            {
                MessageBox.Show("Excel 파일을 불러올 수 없습니다.\n" + ioe.Message);
                return new DataTable();
            }
        }

        private static DataTable BuildHeadersFromFirstRowThenRemoveFirstRow(DataTable dt)
        {
            DataRow firstRow = dt.Rows[0];
            
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                Console.WriteLine(firstRow[i].ToString());
                if (!string.IsNullOrWhiteSpace(firstRow[i].ToString())) // handle empty cell
                    dt.Columns[i].ColumnName = firstRow[i].ToString().Trim();
            }

            dt.Rows.RemoveAt(0);

            return dt;
        }
        
        
    }
}
