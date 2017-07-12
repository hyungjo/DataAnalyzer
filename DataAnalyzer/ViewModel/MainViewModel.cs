using DataAnalyzer.Model;
using DataAnalyzer.Tool;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DataAnalyzer.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    /// 

    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
       #region Constructor
        public MainViewModel()
        {
            //Related Data
            ExcelDataTable = new DataTable();

            //Related Chart
            SeriesCollection = new SeriesCollection();
            
            //Related Condition
            DateTimePicker = DateTime.Today.ToString();
            SelectedPointField = "L01_IF_T";
            Sampling = "100";
            Period = "1";
            StartDateTime = "시작 시간";
            StartVin = "시작 VIN";
            EndDateTime = "끝 시간";
            EndVin = "끝 VIN";
        }
        #endregion

        #region Property
        //Related Excel File
        private string excelFilePath;
        public string ExcelFilePath { get { return excelFilePath; } set { Set(ref excelFilePath, value); } }

        //Related Data
        private DataTable excelDataTable;
        public DataTable ExcelDataTable { get { return excelDataTable; } set { Set(ref excelDataTable, value); } }
        private int rowCount;
        public int RowCount { get { return rowCount; } set { Set(ref rowCount, value); } }

        //Related Condition
        private string dateTimePicker;
        public string DateTimePicker { get { return dateTimePicker; } set { Set(ref dateTimePicker, value); CalculateStartEndDateTimeVin(); } }
        private string sampling;
        public string Sampling { get { return sampling; } set { Set(ref sampling, value); CalculateStartEndDateTimeVin(); } }
        private List<string> pointFieldList;
        public List<string> PointFieldList { get { return pointFieldList; } set { Set(ref pointFieldList, value); } }
        private string selectedPointField;
        public string SelectedPointField { get { return selectedPointField; } set { Set(ref selectedPointField, value); } }
        private string defaultSelectedPointField;
        public string DefaultSelectedPointField { get { return defaultSelectedPointField; } set { Set(ref defaultSelectedPointField, value); } }
        private string selectedVin;
        public string SelectedVin { get { return selectedVin; } set { Set(ref selectedVin, value); } }
        private string period;
        public string Period { get { return period; } set { Set(ref period, value); } }
        private string startDateTime;
        public string StartDateTime { get { return startDateTime; } set { Set(ref startDateTime, value); } }
        private string startVin;
        public string StartVin { get { return startVin; } set { Set(ref startVin, value); } }
        private string endDateTime;
        public string EndDateTime { get { return endDateTime; } set { Set(ref endDateTime, value); } }
        private string endVin;
        public string EndVin { get { return endVin; } set { Set(ref endVin, value); } }

        //Related Chart
        private SeriesCollection seriesCollection;
        public SeriesCollection SeriesCollection { get { return seriesCollection; } set { Set(ref seriesCollection, value); } }
        private string[] labels;
        public string[] Labels { get { return labels; } set { Set(ref labels, value); } }
        private Func<double, string> yFormatter;
        public Func<double, string> YFormatter { get { return yFormatter; } set { Set(ref yFormatter, value); } }

        #endregion

        #region Command
        public ICommand LoadExcelFileCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    OpenFileDialog ofd = new OpenFileDialog()
                    {
                        Filter = "CSV Files (*.csv)|*.csv|Excel Files (*.xlsx)|*.xlsx"
                    };
                    Nullable<bool> result = ofd.ShowDialog();
                    if (result == true)
                    {
                        ExcelFilePath = ofd.FileName;
                        ExcelDataTable = ExcelToDataTableConverter.ImportDataTableFromExcel(ExcelFilePath);
                        
                        //DataSheetTab
                        RowCount = ExcelDataTable.Rows.Count;

                        //DataAnalysisTab
                        GeneratePointFieldList();
                    }
                });
            }
        }
        
        public ICommand GraphAddCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                         
                    if(Convert.ToInt32(Period) == 1)
                    {
                        //TEST
                        foreach (DataColumn dc in ExcelDataTable.Columns)
                        {
                            Console.WriteLine(dc.DataType);
                        }

                        var temp = (from row in ExcelDataTable.AsEnumerable()
                                    where DateTime.Compare(ParseDateTimeValue(row.Field<string>("DateTime")), ParseDateTimeValue(DateTimePicker)) <= 0
                                    select new
                                    {
                                        vin = row.Field<string>("Vin"),
                                        datetime = ParseDateTimeValue(row.Field<string>("DateTime")),
                                        point = ParsePointValue(row.Field<string>(SelectedPointField))
                                    }).Take(int.Parse(Sampling));

                        //TEST
                        foreach (var item in temp)
                        {
                            Console.WriteLine(item.vin + "  " + item.datetime + "  " + item.point);
                        }

                        Labels = temp.AsEnumerable().Select(x => x.vin).ToArray();
                        double[] pointValues = temp.AsEnumerable().Select(x => x.point).ToArray();
                        YFormatter = value => value.ToString("0.0");

                        //modifying the series collection will animate and update the chart

                        SeriesCollection.Add(new LineSeries
                        {
                            Title = SelectedVin + "(" + SelectedPointField + ")",
                            Values = new ChartValues<double>(pointValues),
                            LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                            Fill = Brushes.Transparent
                        });
                    }
                    else
                    {
                        var temp = (from row in ExcelDataTable.AsEnumerable()
                                    where DateTime.Compare(ParseDateTimeValue(row.Field<string>("DateTime")), ParseDateTimeValue(DateTimePicker)) <= 0
                                    select new
                                    {
                                        vin = row.Field<string>("Vin"),
                                        datetime = ParseDateTimeValue(row.Field<string>("DateTime")),
                                        point = ParsePointValue(row.Field<string>(SelectedPointField))
                                    }).Take(Convert.ToInt32(Sampling));


                        Labels = temp.AsEnumerable().Select(x => x.vin).ToArray();
                        double[] pointValues = temp.AsEnumerable().Select(x => x.point).ToArray();
                        YFormatter = value => value.ToString("0.0");

                        List<double> tempPointValue = new List<double>();
                        for(int i = 1; i <= temp.Count(); i++)
                        {
                            tempPointValue.Add(temp.ElementAt(i-1).point);
                            if (i % Convert.ToInt32(Period) == 0 || temp.Count() == i)
                            {
                                SeriesCollection.Add(new LineSeries
                                {
                                    Title = SelectedVin + " (" + (i - Convert.ToInt32(Period) + 1) + "~" + i + ")",
                                    Values = new ChartValues<double>(tempPointValue),
                                    LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                                    Fill = Brushes.Transparent
                                });
                                tempPointValue.Clear();
                            }
                        }                        
                    }
                });
            }
        }

        public ICommand GraphRemoveCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    SeriesCollection.Clear();
                });
            }
        }
        #endregion

        #region Member Method
        public void CalculateStartEndDateTimeVin()
        {
            if (ExcelDataTable.Rows.Count <= 0)
                return;
            var temp = (from row in ExcelDataTable.AsEnumerable()
                        where DateTime.Compare(ParseDateTimeValue(row.Field<string>("DateTime")), ParseDateTimeValue(DateTimePicker)) <= 0
                        select new
                        {
                            vin = row.Field<string>("Vin"),
                            datetime = ParseDateTimeValue(row.Field<string>("DateTime"))
                        }).Take(int.Parse(Sampling));

            //TEST
            foreach (var item in temp)
            {
                Console.WriteLine(item.vin + "  " + item.datetime);
            }

            var start = temp.OrderByDescending(x => x.datetime).Last();
            var end = temp.OrderByDescending(x => x.datetime).First();
            StartDateTime = start.datetime.ToString();
            StartVin = start.vin;
            EndDateTime = end.datetime.ToString();
            EndVin = end.vin;
        }

        public DateTime ParseDateTimeValue(string datetime)
        {
            DateTime result;

            if (DateTime.TryParse(datetime, out result) == true)
                return result;
            else
                return DateTime.Today.AddYears(1);
        }

        public double ParsePointValue(string point)
        {
            double result;

            if (double.TryParse(point, out result) == true)
                return result;
            else
                return 0;
        }

        public void GeneratePointFieldList()
        {
            List<string> temp = new List<string>();
            temp = ExcelDataTable.Columns.Cast<DataColumn>()
                                  .Select(row => row.ColumnName).ToList();
            temp.RemoveRange(0, 14);
            PointFieldList = temp;
        }

        
        #endregion
    }
}