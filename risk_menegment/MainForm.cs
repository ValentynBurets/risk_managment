using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace risk_menegment
{
    public partial class MainForm : Form
    {

        RiskManager Manager = new RiskManager();

        public MainForm()
        {
            InitializeComponent();
        }

        void FillRiskSources()
        {
            dataGridRiskSources.Rows.Clear();
            dataGridRiskSources.Refresh();
            dataGridRiskSources.ColumnCount = 4;
            dataGridRiskSources.Columns[0].Width = 40;
            dataGridRiskSources.Columns[1].Width = dataGridRiskSources.Width - 125;
            dataGridRiskSources.Columns[2].Width = 40;
            dataGridRiskSources.Columns[3].Width = 40;
            List<string> row = new List<string> { "Тип", "Можливі ризики", "%", "Значення" };
            dataGridRiskSources.Rows.Add(row.ToArray());
            dataGridRiskSources.Rows[0].Cells[0].ReadOnly = true;
            dataGridRiskSources.Rows[0].Cells[1].ReadOnly = true;
            dataGridRiskSources.Rows[0].Cells[2].ReadOnly = true;
            for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            {
                for (int j = 0; j < RiskManager.RiskSources[i].Value.Count(); ++j)
                {
                    //var test = RiskManager.RiskSources[i].Value[j];
                    row = new List<string> { $"{RiskManager.RiskTypes[i]}{j + 1}", RiskManager.RiskSources[i].Value[j], $"{Manager.RiskSourcesValues[i][j].Value}", $"{Manager.RiskSourcesValues[i][j].Key}" };
                    int iRow = dataGridRiskSources.Rows.Add(row.ToArray());
                    dataGridRiskSources.Rows[iRow].Cells[0].ReadOnly = true;
                    dataGridRiskSources.Rows[iRow].Cells[1].ReadOnly = true;
                }
            }
        }

        void AltFillRiskSources()
        {
            altDataGridRiskSources.Rows.Clear();
            altDataGridRiskSources.Refresh();
            altDataGridRiskSources.ColumnCount = 3;
            altDataGridRiskSources.Columns[0].Width = 40;
            altDataGridRiskSources.Columns[1].Width = dataGridRiskSources.Width - 125;
            altDataGridRiskSources.Columns[2].Width = 80;
            
            List<string> row = new List<string> { "Тип", "Можливі ризики", "Значення" };
            altDataGridRiskSources.Rows.Add(row.ToArray());
            altDataGridRiskSources.Rows[0].Cells[0].ReadOnly = true;
            altDataGridRiskSources.Rows[0].Cells[1].ReadOnly = true;
            altDataGridRiskSources.Rows[0].Cells[2].ReadOnly = true;
            for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            {
                for (int j = 0; j < RiskManager.RiskSources[i].Value.Count(); ++j)
                {
                    //var test = RiskManager.RiskSources[i].Value[j];
                    row = new List<string> { $"{RiskManager.RiskTypes[i]}{j + 1}", RiskManager.RiskSources[i].Value[j], $"{Manager.altRiskSourcesValues[i][j]}" };
                    int iRow = altDataGridRiskSources.Rows.Add(row.ToArray());
                    altDataGridRiskSources.Rows[iRow].Cells[0].ReadOnly = true;
                    altDataGridRiskSources.Rows[iRow].Cells[1].ReadOnly = true;
                }
            }
        }
        void FillRiskEvents()
        {
            dataGridRiskEvents.Rows.Clear();
            dataGridRiskEvents.Refresh();
            dataGridRiskEvents.ColumnCount = 4;
            dataGridRiskEvents.Columns[0].Width = 40;
            dataGridRiskEvents.Columns[1].Width = dataGridRiskEvents.Width - 150;
            dataGridRiskEvents.Columns[2].Width = 40;
            dataGridRiskEvents.Columns[3].Width = 40;
            List<string> row = new List<string> { "Тип", "Ризикові події", "%", "Значення" };
            dataGridRiskEvents.Rows.Add(row.ToArray());
            dataGridRiskEvents.Rows[0].Cells[0].ReadOnly = true;
            dataGridRiskEvents.Rows[0].Cells[1].ReadOnly = true;
            dataGridRiskEvents.Rows[0].Cells[2].ReadOnly = true;
            for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            {
                for (int j = 0; j < RiskManager.RiskEvents[i].Value.Count(); ++j)
                {
                    row = new List<string> { $"{RiskManager.RiskTypes[i]}{j + 1}", RiskManager.RiskEvents[i].Value[j], $"{Manager.RiskEventsValues[i][j].Value}", $"{Manager.RiskEventsValues[i][j].Key}" };
                    int iRow = dataGridRiskEvents.Rows.Add(row.ToArray());
                    dataGridRiskEvents.Rows[iRow].Cells[0].ReadOnly = true;
                    dataGridRiskEvents.Rows[iRow].Cells[1].ReadOnly = true;
                }
            }
        }

        void AltFillRiskEvents()
        {
            altDataGridRiskEvents.Rows.Clear();
            altDataGridRiskEvents.Refresh();
            altDataGridRiskEvents.ColumnCount = 3;
            altDataGridRiskEvents.Columns[0].Width = 40;
            altDataGridRiskEvents.Columns[1].Width = altDataGridRiskEvents.Width - 150;
            altDataGridRiskEvents.Columns[2].Width = 80;
            List<string> row = new List<string> { "Тип", "Ризикові події", "Значення" };
            altDataGridRiskEvents.Rows.Add(row.ToArray());
            altDataGridRiskEvents.Rows[0].Cells[0].ReadOnly = true;
            altDataGridRiskEvents.Rows[0].Cells[1].ReadOnly = true;
            altDataGridRiskEvents.Rows[0].Cells[2].ReadOnly = true;
            for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            {
                for (int j = 0; j < RiskManager.RiskEvents[i].Value.Count(); ++j)
                {
                    row = new List<string> { $"{RiskManager.RiskTypes[i]}{j + 1}", RiskManager.RiskEvents[i].Value[j], $"{Manager.altRiskEventsValues[i][j]}" };
                    int iRow = altDataGridRiskEvents.Rows.Add(row.ToArray());
                    altDataGridRiskEvents.Rows[iRow].Cells[0].ReadOnly = true;
                    altDataGridRiskEvents.Rows[iRow].Cells[1].ReadOnly = true;
                }
            }
        }


        void FillExpertsGrades()
        {
            dataGridExpertsGrades.Rows.Clear();
            dataGridExpertsGrades.Refresh();
            dataGridExpertsGrades.ColumnCount = 13;
            dataGridExpertsGrades.Columns[0].Width = 40;
            dataGridExpertsGrades.Columns[1].Width = dataGridExpertsGrades.Width - 620;
            for (int i = 2; i < 13; ++i)
            {
                dataGridExpertsGrades.Columns[i].Width = 50;
            }

            List<string> row = new List<string> { "#", "Ризикові події" };
            row.AddRange(Enumerable.Range(1, 10).Select(num => "per" + num));
            row.Add("ER");
            dataGridExpertsGrades.Rows.Add(row.ToArray());
            dataGridExpertsGrades.Rows[0].ReadOnly = true;

            for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            {
                for (int j = 0; j < RiskManager.RiskEvents[i].Value.Count(); ++j)
                {
                    row = new List<string> { $"{RiskManager.RiskTypes[i]}{j + 1}", RiskManager.RiskEvents[i].Value[j] };
                    for (int k = 0; k < RiskManager.ExpertsCount; ++k)
                    {
                        row.Add(Manager.ExpertsGrades[i][j][k].ToString("n2"));
                    }
                    row.Add(Manager.ER[i][j].ToString("n2"));

                    int iRow = dataGridExpertsGrades.Rows.Add(row.ToArray());
                    dataGridExpertsGrades.Rows[iRow].Cells[0].ReadOnly = true;
                    dataGridExpertsGrades.Rows[iRow].Cells[1].ReadOnly = true;
                    dataGridExpertsGrades.Rows[iRow].Cells[12].ReadOnly = true;
                }
            }
        }
        void FillValuesGrid()
        {
            dataGridValues.Rows.Clear();
            dataGridValues.Refresh();
            dataGridValues.ColumnCount = 7;
            dataGridValues.Columns[0].Width = 40;
            dataGridValues.Columns[1].Width = dataGridValues.Width - 350;
            for (int i = 2; i < 5; ++i)
            {
                dataGridValues.Columns[i].Width = 40;
            }
            dataGridValues.Columns[5].Width = 80;
            dataGridValues.Columns[6].Width = 80;
            List<string> row = new List<string> { "#", "Ризикові події", "ER", "LRER", "VRER", "Пріоритет", "Імовірність настання" };
            dataGridValues.Rows.Add(row.ToArray());
            dataGridValues.Rows[0].ReadOnly = true;

            for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            {
                for (int j = 0; j < RiskManager.RiskEvents[i].Value.Count(); ++j)
                {
                    row = new List<string> { $"{RiskManager.RiskTypes[i]}{j + 1}", RiskManager.RiskEvents[i].Value[j] };
                    row.Add(Manager.ER[i][j].ToString("n2"));
                    row.Add(Manager.LRER[i][j].ToString("n2"));
                    row.Add(Manager.VRER[i][j].ToString("n2"));
                    row.Add("N/A");
                    int iRow = dataGridValues.Rows.Add(row.ToArray());
                    dataGridValues.Rows[iRow].Cells[0].ReadOnly = true;
                    dataGridValues.Rows[iRow].Cells[1].ReadOnly = true;
                    dataGridValues.Rows[iRow].Cells[2].ReadOnly = true;
                    dataGridValues.Rows[iRow].Cells[4].ReadOnly = true;
                    dataGridValues.Rows[iRow].Cells[5].ReadOnly = true;
                    dataGridValues.Rows[iRow].Cells[6].ReadOnly = true;
                }
            }
        }
        void FillRisksPrevention()
        {

            dataGridRisksPrevention.Rows.Clear();
            dataGridRisksPrevention.Refresh();
            dataGridRisksPrevention.ColumnCount = 3;
            dataGridRisksPrevention.Columns[0].Width = 40;
            dataGridRisksPrevention.Columns[1].Width = dataGridRisksPrevention.Width / 2 - 35;
            dataGridRisksPrevention.Columns[2].Width = dataGridRisksPrevention.Width / 2 - 35;

            List<string> row = new List<string> { "#", "Ризикові події", "Рішення" };
            dataGridRisksPrevention.Rows.Add(row.ToArray());
            dataGridRisksPrevention.Rows[0].ReadOnly = true;

            for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            {
                for (int j = 0; j < RiskManager.RiskEvents[i].Value.Count(); ++j)
                {
                    row = new List<string> { $"{RiskManager.RiskTypes[i]}{j + 1}", RiskManager.RiskEvents[i].Value[j] };
                    int iRow = dataGridRisksPrevention.Rows.Add(row.ToArray());

                    DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
                    comboBoxCell.DataSource = RiskManager.PreventionMethods.Select((str, index) => new { ID = index, Method = str }).ToList();
                    comboBoxCell.DisplayMember = "Method";
                    comboBoxCell.ValueMember = "ID";
                    comboBoxCell.Value = Manager.SelectedPreventions[i][j];

                    dataGridRisksPrevention.Rows[iRow].Cells[0].ReadOnly = true;
                    dataGridRisksPrevention.Rows[iRow].Cells[1].ReadOnly = true;
                    dataGridRisksPrevention.Rows[iRow].Cells[2] = comboBoxCell;
                }
            }
        }
        void FillExpertsGradesN()
        {
            dataGridExpertsGradesN.Rows.Clear();
            dataGridExpertsGradesN.Refresh();
            dataGridExpertsGradesN.ColumnCount = 13;
            dataGridExpertsGradesN.Columns[0].Width = 40;
            dataGridExpertsGradesN.Columns[1].Width = dataGridExpertsGradesN.Width - 630;
            for (int i = 2; i < 12; ++i)
            {
                dataGridExpertsGradesN.Columns[i].Width = 50;
            }
            dataGridExpertsGradesN.Columns[12].Width = 60;

            List<string> row = new List<string> { "#", "Ризикові події" };
            row.AddRange(Enumerable.Range(1, 10).Select(num => "per" + num));
            row.Add("ERPER");
            dataGridExpertsGradesN.Rows.Add(row.ToArray());
            dataGridExpertsGradesN.Rows[0].ReadOnly = true;

            for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            {
                for (int j = 0; j < RiskManager.RiskEvents[i].Value.Count(); ++j)
                {
                    row = new List<string> { $"{RiskManager.RiskTypes[i]}{j + 1}", RiskManager.RiskEvents[i].Value[j] };
                    for (int k = 0; k < RiskManager.ExpertsCount; ++k)
                    {
                        row.Add(Manager.EVER[i][j][k].ToString("n2"));
                    }
                    row.Add(Manager.ERPER[i][j].ToString("n2"));

                    int iRow = dataGridExpertsGradesN.Rows.Add(row.ToArray());
                    dataGridExpertsGradesN.Rows[iRow].Cells[0].ReadOnly = true;
                    dataGridExpertsGradesN.Rows[iRow].Cells[1].ReadOnly = true;
                    dataGridExpertsGradesN.Rows[iRow].Cells[12].ReadOnly = true;
                }
            }
        }
        void FillValuesGridN()
        {
            dataGridValuesN.Rows.Clear();
            dataGridValuesN.Refresh();
            dataGridValuesN.ColumnCount = 6;
            dataGridValuesN.Columns[0].Width = 40;
            dataGridValuesN.Columns[1].Width = dataGridValuesN.Width - 400;
            for (int i = 2; i < 6; ++i)
            {
                dataGridValuesN.Columns[i].Width = 80;
            }

            List<string> row = new List<string> { "#", "Ризикові події", "ERPER", "ELRER", "EVRER", "Пріоритет"};
            dataGridValuesN.Rows.Add(row.ToArray());
            dataGridValuesN.Rows[0].ReadOnly = true;

            double max = Manager.EVRER.Select(arr => arr.Max()).Max();
            double min = Manager.EVRER.Select(arr => arr.Min()).Min();
            double p1 = (max - min) / 3 + min;
            double p2 = (max - min) / 3 + p1;

            for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            {
                for (int j = 0; j < RiskManager.RiskEvents[i].Value.Count(); ++j)
                {
                    row = new List<string> { $"{RiskManager.RiskTypes[i]}{j + 1}", RiskManager.RiskEvents[i].Value[j] };
                    row.Add(Manager.ERPER[i][j].ToString("n2"));
                    row.Add(Manager.ELRER[i][j].ToString("n2"));
                    row.Add(Manager.EVRER[i][j].ToString("n2"));
                    Color color;
                    string level;
                    if (Manager.EVRER[i][j] < p1)
                    {
                        level = "Низький";
                        color = Color.FromArgb(0, 255, 0);
                    }
                    else if (Manager.EVRER[i][j] < p2)
                    {
                        level = "Середній";
                        color = Color.FromArgb(255, 255, 0);
                    }
                    else
                    {
                        level = "Високий";
                        color = Color.FromArgb(255, 0, 0);
                    }
                    row.Add(level);
                    
                    int iRow = dataGridValuesN.Rows.Add(row.ToArray());
                    dataGridValuesN.Rows[iRow].Cells[0].ReadOnly = true;
                    dataGridValuesN.Rows[iRow].Cells[1].ReadOnly = true;
                    dataGridValuesN.Rows[iRow].Cells[2].ReadOnly = true;
                    dataGridValuesN.Rows[iRow].Cells[4].ReadOnly = true;
                    dataGridValuesN.Rows[iRow].Cells[5].ReadOnly = true;
                    dataGridValuesN.Rows[iRow].DefaultCellStyle.BackColor = color;
                }
            }
        }
        void UpdateSourceRisks()
        {
            SourceT.Text = (Manager.RiskSourcesProbabilities[0].Value * 100).ToString("n2") + "%";
            SourceC.Text = (Manager.RiskSourcesProbabilities[1].Value * 100).ToString("n2") + "%";
            SourceP.Text = (Manager.RiskSourcesProbabilities[2].Value * 100).ToString("n2") + "%";
            SourceM.Text = (Manager.RiskSourcesProbabilities[3].Value * 100).ToString("n2") + "%";
            SourceAll.Text = (Manager.RiskSourcesProbabilities.Sum(pair => pair.Value) * 100).ToString("n2") + "%";
        }
        void AltUpdateSourceRisks()
        {
            AltSourceT.Text = (Manager.altRiskSourcesProbabilities[0].Value * 100).ToString("n2") + "%";
            AltSourceC.Text = (Manager.altRiskSourcesProbabilities[1].Value * 100).ToString("n2") + "%";
            AltSourceP.Text = (Manager.altRiskSourcesProbabilities[2].Value * 100).ToString("n2") + "%";
            AltSourceM.Text = (Manager.altRiskSourcesProbabilities[3].Value * 100).ToString("n2") + "%";
            AltSourceAll.Text = (Manager.altRiskSourcesProbabilities.Sum(pair => pair.Value) * 100).ToString("n2") + "%";
        }
        void UpdateEventsRisks()
        {
            EventsT.Text = (Manager.RiskEventsProbabilities[0].Value * 100).ToString("n2") + "%";
            EventsC.Text = (Manager.RiskEventsProbabilities[1].Value * 100).ToString("n2") + "%";
            EventsP.Text = (Manager.RiskEventsProbabilities[2].Value * 100).ToString("n2") + "%";
            EventsM.Text = (Manager.RiskEventsProbabilities[3].Value * 100).ToString("n2") + "%";
            EventsAll.Text = (Manager.RiskEventsProbabilities.Sum(pair => pair.Value) * 100).ToString("n2") + "%";
        }
        void AltUpdateEventsRisks()
        {
            AltEventsT.Text = (Manager.altRiskEventsProbabilities[0].Value * 100).ToString("n2") + "%";
            AltEventsC.Text = (Manager.altRiskEventsProbabilities[1].Value * 100).ToString("n2") + "%";
            AltEventsP.Text = (Manager.altRiskEventsProbabilities[2].Value * 100).ToString("n2") + "%";
            AltEventsM.Text = (Manager.altRiskEventsProbabilities[3].Value * 100).ToString("n2") + "%";
            AltEventsAll.Text = (Manager.altRiskEventsProbabilities.Sum(pair => pair.Value) * 100).ToString("n2") + "%";
        }
        void UpdateRiskValue()
        {
            double veryLowBorder = 0.1;
            double lowBorder = 0.25;
            double mediumBorder = 0.5;
            double hightBorder = 0.75;
            //double veryHightBorder = 1;

            double max = Manager.VRER.Select(arr => arr.Max()).Max();
            double min = Manager.VRER.Select(arr => arr.Min()).Min();
            double p1 = (max - min) / 3 + min;
            double p2 = (max - min) / 3 + p1;

            VeryLowRange.Text = $"[{min.ToString("n2")}; {veryLowBorder.ToString("n2")})";
            LowRange.Text = $"[{veryLowBorder.ToString("n2")}; {lowBorder.ToString("n2")})";
            MediumRange.Text = $"[{lowBorder.ToString("n2")}; {mediumBorder.ToString("n2")})";
            HighRange.Text = $"[{mediumBorder.ToString("n2")}; {hightBorder.ToString("n2")}]";
            VeryHighRange.Text = $"[{hightBorder.ToString("n2")}; {max.ToString("n2")}]";

            VeryLowRangeLabel.BackColor = Color.FromArgb(0, 255, 0);
            LowRangeLabel.BackColor = Color.FromArgb(200, 255, 0);
            MediumRangeLabel.BackColor = Color.FromArgb(255, 255, 0);
            HighRangeLabel.BackColor = Color.FromArgb(255, 200, 0);
            VeryHighRangeLabel.BackColor = Color.FromArgb(255, 0, 0);

            MinVRER.Text = min.ToString("n2");
            MaxVRER.Text = max.ToString("n2");

            //пріоритети
            //------------------------------------------------------
            LowRangePriority.Text = $"[{min.ToString("n2")}; {p1.ToString("n2")})";
            MediumRangePriority.Text = $"[{p1.ToString("n2")}; {p2.ToString("n2")})";
            HighRangePriority.Text = $"[{p2.ToString("n2")}; {max.ToString("n2")}]";


            LowRangePriorityLabel.BackColor = Color.FromArgb(0, 255, 0);
            MediumRangePriorityLabel.BackColor = Color.FromArgb(255, 255, 0);
            HighRangePriorityLabel.BackColor = Color.FromArgb(255, 0, 0);

            int tr = 1;
            for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            {
                for (int j = 0; j < RiskManager.RiskEvents[i].Value.Count(); ++j, ++tr)
                {
                    Color color;
                    string level;
                    if (Manager.VRER[i][j] < p1)
                    {
                        level = "Низький";
                        color = Color.FromArgb(0, 255, 0);
                    }
                    else if (Manager.VRER[i][j] < p2)
                    {
                        level = "Середній";
                        color = Color.FromArgb(255, 255, 0);
                    }
                    else
                    {
                        level = "Високий";
                        color = Color.FromArgb(255, 0, 0);
                    }

                    dataGridValues[5, tr].Value = level;
                    //dataGridValues.Rows[tr].DefaultCellStyle.BackColor = color;

                    //dataGridValues.Rows[tr].Cells[5].Value = level;
                    dataGridValues.Rows[tr].Cells[5].Style.BackColor = color;
                }
            }




            //імовірність виникнення
            //------------------------------------------------------------

            tr = 1;
            for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            {
                for (int j = 0; j < RiskManager.RiskEvents[i].Value.Count(); ++j, ++tr)
                {
                    Color color;
                    string level;

                    if (Manager.VRER[i][j] <= veryLowBorder)
                    {
                        level = "Дуже Низький";
                        color = Color.FromArgb(0, 255, 0);
                    }
                    else if (veryLowBorder < Manager.VRER[i][j] && Manager.VRER[i][j] <= lowBorder)
                    {
                        level = "Низький";
                        color = Color.FromArgb(200, 255, 0);
                    }
                    else if (lowBorder < Manager.VRER[i][j] && Manager.VRER[i][j] <= mediumBorder)
                    {
                        level = "Середній";
                        color = Color.FromArgb(255, 255, 0);
                    }
                    else if (mediumBorder < Manager.VRER[i][j] && Manager.VRER[i][j] <= hightBorder)
                    {
                        level = "Високий";
                        color = Color.FromArgb(255, 200, 0);
                    }
                    else if (hightBorder < Manager.VRER[i][j] && Manager.VRER[i][j] <= max)
                    {
                        level = "Дуже високий";
                        color = Color.FromArgb(255, 0, 0);
                    }
                    else
                    {
                        level = "Не визначено";
                        color = Color.FromArgb(0xdc, 0x76, 0x84);
                    }



                    //if (Manager.VRER[i][j] < p1)
                    //{
                    //    level = "Низький";
                    //    color = Color.FromArgb(0x9b, 0xd3, 0xcb);
                    //}
                    //else if (Manager.VRER[i][j] < p2)
                    //{
                    //    level = "Середній";
                    //    color = Color.FromArgb(0xf1, 0xd7, 0xbb);
                    //}
                    //else
                    //{
                    //    level = "Високий";
                    //    color = Color.FromArgb(0xdc, 0x76, 0x84);
                    //}

                    //dataGridValues[6, tr].Value = level;
                    //dataGridValues.Cell[tr][8].DefaultCellStyle.BackColor = color;
                    //dataGridValues[6, tr].Value = level;
                    dataGridValues.Rows[tr].Cells[6].Value = level;
                    dataGridValues.Rows[tr].Cells[6].Style.BackColor = color;
                }


            }
            
        }
        void UpdateRiskValueN()
        {
            //double veryLowBorder = 0.1;
            //double lowBorder = 0.25;
            //double mediumBorder = 0.5;
            //double hightBorder = 0.75;

            double max = Manager.EVRER.Select(arr => arr.Max()).Max();
            double min = Manager.EVRER.Select(arr => arr.Min()).Min();
            double p1 = (max - min) / 3 + min;
            double p2 = (max - min) / 3 + p1;
            LowRangeN.Text = $"[{min.ToString("n2")}; {p1.ToString("n2")})";
            MediumRangeN.Text = $"[{p1.ToString("n2")}; {p2.ToString("n2")})";
            HighRangeN.Text = $"[{p2.ToString("n2")}; {max.ToString("n2")}]";
            MinEVRER.Text = min.ToString("n2");
            MaxEVRER.Text = max.ToString("n2");

            int tr = 1;
            for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            {
                for (int j = 0; j < RiskManager.RiskEvents[i].Value.Count(); ++j, ++tr)
                {
                    Color color;
                    string level;
                    
                    if (Manager.EVRER[i][j] < p1)
                    {
                        level = "Низький";
                        color = Color.FromArgb(0, 255, 0);
                    }
                    else if (Manager.EVRER[i][j] < p2)
                    {
                        level = "Середній";
                        color = Color.FromArgb(255, 255, 0);
                    }
                    else
                    {
                        level = "Високий";
                        color = Color.FromArgb(255, 0, 0);
                    }

                    dataGridValuesN[5, tr].Value = level;
                    dataGridValuesN.Rows[tr].DefaultCellStyle.BackColor = color;
                }
            }

            //tr = 1;
            //for (int i = 0; i < RiskManager.RiskTypesCount; ++i)
            //{
            //    for (int j = 0; j < RiskManager.RiskEvents[i].Value.Count(); ++j, ++tr)
            //    {
            //        Color color;
            //        string level;

            //        if (Manager.EVRER[i][j] <= veryLowBorder)
            //        {
            //            level = "Дуже Низький";
            //            color = Color.FromArgb(0, 255, 0);
            //        }
            //        else if (veryLowBorder < Manager.EVRER[i][j] && Manager.EVRER[i][j] <= lowBorder)
            //        {
            //            level = "Низький";
            //            color = Color.FromArgb(200, 255, 0);
            //        }
            //        else if (lowBorder < Manager.EVRER[i][j] && Manager.EVRER[i][j] <= mediumBorder)
            //        {
            //            level = "Середній";
            //            color = Color.FromArgb(255, 255, 0);
            //        }
            //        else if (mediumBorder < Manager.EVRER[i][j] && Manager.EVRER[i][j] <= hightBorder)
            //        {
            //            level = "Високий";
            //            color = Color.FromArgb(255, 200, 0);
            //        }
            //        else if (hightBorder < Manager.EVRER[i][j] && Manager.EVRER[i][j] <= max)
            //        {
            //            level = "Дуже високий";
            //            color = Color.FromArgb(255, 0, 0);
            //        }
            //        else
            //        {
            //            level = "Не визначено";
            //            color = Color.FromArgb(0xdc, 0x76, 0x84);
            //        }

            //        dataGridValuesN.Rows[tr].Cells[6].Value = level;
            //        dataGridValuesN.Rows[tr].Cells[6].Style.BackColor = color;
            //    }


            //}
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            FillRiskSources();
            UpdateSourceRisks();
            FillRiskEvents();
            UpdateEventsRisks();

            AltFillRiskSources();
            AltUpdateSourceRisks();
            AltFillRiskEvents();
            AltUpdateEventsRisks();

            FillExpertsGrades();
            FillValuesGrid();
            UpdateRiskValue();
            FillRisksPrevention();
            FillExpertsGradesN();
            FillValuesGridN();
            UpdateRiskValueN();
        }

        private void dataGridRiskSources_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string num = (string)dataGridRiskSources.Rows[e.RowIndex].Cells[0].Value;
            int type = Array.IndexOf(RiskManager.RiskTypes, num[0].ToString());
            int risk = int.Parse(num.Substring(1)) - 1;
            Manager.ChangeRiskSourceValue(type, risk, int.Parse((string)dataGridRiskSources.Rows[e.RowIndex].Cells[3].Value));
            UpdateSourceRisks();
        }
        private void altdataGridRiskSources_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string num = (string)altDataGridRiskSources.Rows[e.RowIndex].Cells[0].Value;
            int type = Array.IndexOf(RiskManager.RiskTypes, num[0].ToString());
            int risk = int.Parse(num.Substring(1)) - 1;
            Manager.altChangeRiskSourceValue(type, risk, int.Parse((string)altDataGridRiskSources.Rows[e.RowIndex].Cells[2].Value));
            AltUpdateSourceRisks();
        }

        private void dataGridRiskEvents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string num = (string)dataGridRiskEvents.Rows[e.RowIndex].Cells[0].Value;
            int type = Array.IndexOf(RiskManager.RiskTypes, num[0].ToString());
            int risk = int.Parse(num.Substring(1)) - 1;
            Manager.ChangeRiskEventsValue(type, risk, int.Parse((string)dataGridRiskEvents.Rows[e.RowIndex].Cells[3].Value));
            UpdateEventsRisks();
        }

        private void altDataGridRiskEvents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string num = (string)altDataGridRiskEvents.Rows[e.RowIndex].Cells[0].Value;
            int type = Array.IndexOf(RiskManager.RiskTypes, num[0].ToString());
            int risk = int.Parse(num.Substring(1)) - 1;
            Manager.altChangeRiskEventsValue(type, risk, int.Parse((string)altDataGridRiskEvents.Rows[e.RowIndex].Cells[2].Value));
            AltUpdateEventsRisks();
        }

        private void dataGridExpertsGrades_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 2 || e.ColumnIndex > 11)
                return;

            string num = (string)dataGridExpertsGrades.Rows[e.RowIndex].Cells[0].Value;
            int type = Array.IndexOf(RiskManager.RiskTypes, num[0].ToString());
            int risk = int.Parse(num.Substring(1)) - 1;
            Manager.ChangeExpertGrade(type, risk, e.ColumnIndex - 2, double.Parse((string)dataGridExpertsGrades.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
            dataGridExpertsGrades[12, e.RowIndex].Value = Manager.ER[type][risk].ToString("n2");

            FillValuesGrid();
            UpdateRiskValue();
            FillExpertsGradesN();
            FillValuesGridN();
        }

        private void dataGridValues_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 3)
                return;
            string num = (string)dataGridValues.Rows[e.RowIndex].Cells[0].Value;
            int type = Array.IndexOf(RiskManager.RiskTypes, num[0].ToString());
            int risk = int.Parse(num.Substring(1)) - 1;
            Manager.ChangeLRER(type, risk, double.Parse((string)dataGridValues.Rows[e.RowIndex].Cells[3].Value));
            dataGridValues[4, e.RowIndex].Value = Manager.VRER[type][risk].ToString("n2");
            UpdateRiskValue();
        }

        private void dataGridRisksPrevention_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string num = (string)dataGridRisksPrevention.Rows[e.RowIndex].Cells[0].Value;
            int type = Array.IndexOf(RiskManager.RiskTypes, num[0].ToString());
            int risk = int.Parse(num.Substring(1)) - 1;
            Manager.ChangeSelectedPrevention(type, risk, (int)dataGridRisksPrevention[e.ColumnIndex, e.RowIndex].Value);

            FillExpertsGradesN();
            FillValuesGridN();
        }

        private void dataGridExpertsGradesN_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridValuesN_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 3)
                return;
            string num = (string)dataGridValuesN.Rows[e.RowIndex].Cells[0].Value;
            int type = Array.IndexOf(RiskManager.RiskTypes, num[0].ToString());
            int risk = int.Parse(num.Substring(1)) - 1;
            Manager.ChangeELRER(type, risk, double.Parse((string)dataGridValuesN.Rows[e.RowIndex].Cells[3].Value));
            dataGridValuesN[4, e.RowIndex].Value = Manager.EVRER[type][risk].ToString("n2");
            UpdateRiskValueN();
        }



        /*private void menuItem2_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "JSON file(*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog1.OpenFile()) != null)
                {
                    string content = JsonConvert.SerializeObject(Manager);
                    var writer = new StreamWriter(stream);
                    writer.Write(content);
                    writer.Flush();
                    stream.Close();
                }
            }
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "JSON file(*.json)|*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string content = File.ReadAllText(openFileDialog.FileName);
                    Manager = new JsonSerializer().Deserialize<RiskManager>(new JsonTextReader(new StringReader(content)));
                    //Manager = JsonConvert.DeserializeObject<RiskManager>(content);
                    
                    FillRiskSources();
                    UpdateSourceRisks();
                    FillRiskEvents();
                    UpdateEventsRisks();
                    FillExpertsGrades();
                    FillValuesGrid();
                    UpdateRiskValue();
                    FillRisksPrevention();
                    FillExpertsGradesN();
                    FillValuesGridN();
                    UpdateRiskValueN();
                }
            }
        }*/
    }
}
