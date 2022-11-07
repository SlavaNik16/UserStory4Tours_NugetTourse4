using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UserStory4Tours.models;

namespace UserStory4Tours
{
    public partial class Form1 : Form
    {
        private NugetTourse4.TourseWinForm<Tours> cal;
        private readonly BindingSource BinSource;
        private decimal sum = 0;
        public Form1()
        {
            InitializeComponent();
         
            ToursGridViev.AutoGenerateColumns = false;
            cal = new NugetTourse4.TourseWinForm<Tours>();
            BinSource = new BindingSource();
            BinSource.DataSource = cal.GetList();
            ToursGridViev.DataSource = BinSource;
        }
        

       

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Николаев В.А ИП-20-3", "Горящие туры 4 вариант",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddTool_Click(object sender, EventArgs e)
        {
            var infoForm = new ToursInfoForm();
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                cal.Add(infoForm.Tours);
                BinSource.ResetBindings(false);
                CalculatScroll();

            }
            
           
        }

        private void DeliteTool_Click(object sender, EventArgs e)
        {
            var id = (Tours)ToursGridViev.Rows[ToursGridViev.SelectedRows[0].Index].DataBoundItem;
            var text = cal.Perevod(id.direction, Direction.Turkey, "Турция", "Израиль", "Абхазия", "Кипр", "Шушары", "Таиланд");
            if (MessageBox.Show($"Вы действительно хотите удалить {text} в {id.DateDeparture:D}","Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cal.Remove(id);
                BinSource.ResetBindings(false);
                CalculatScroll();
            }
        }

       
        private void ChangeTool_Click(object sender, EventArgs e)
        {
            var id = (Tours)ToursGridViev.Rows[ToursGridViev.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new ToursInfoForm(id);
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                cal.Change(id, infoForm.Tours);
                BinSource.ResetBindings(false);
                CalculatScroll();
                
                
            }
        }

        private void AddMenu_Click(object sender, EventArgs e)
        {
            AddTool_Click(sender, e);
        }

        private void DeliteMenu_Click(object sender, EventArgs e)
        {
            DeliteTool_Click(sender, e);
        }

        private void ChangeMenu_Click(object sender, EventArgs e)
        {
            ChangeTool_Click(sender, e);
        }

        private void ToursGridViev_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ToursGridViev.Columns[e.ColumnIndex].Name == "AmountAllColumn")
            {
                var data = (Tours)ToursGridViev.Rows[e.RowIndex].DataBoundItem;
                sum += (data.NumberNight * data.NumberVac * data.CostVac) + data.Surcharges;
                e.Value = sum;
                sum = 0;
            }

            if (ToursGridViev.Columns[e.ColumnIndex].Name == "DirectColumn")
            {
                var val = (Direction)e.Value;
                e.Value = cal.Perevod(val, Direction.Turkey,"Турция", "Израиль", "Абхазия", "Кипр", "Шушары", "Таиланд");

            }
            if (ToursGridViev.Columns[e.ColumnIndex].Name == "Wi_FiColumn")
            {
                var val = (bool)e.Value;
                switch (val)
                {
                    case true:
                        e.Value = "Есть";
                        break;
                    case false:
                        e.Value = "Нет";
                        break;
                   
                }
            }


        }

        private void ToursGridViev_SelectionChanged(object sender, EventArgs e)
        {
            DeliteMenu.Enabled =
            ChangeMenu.Enabled =
            DeliteTool.Enabled = 
            ChangeTool.Enabled = 
            ToursGridViev.SelectedRows.Count > 0;
        }
        private void CalculatScroll()
        {
            NumberToursStatus.Text = $"Всего туров {cal.GetList().Count.ToString()}";

            decimal sumAll = cal.GetList().Sum(x=>(x.NumberNight * x.NumberVac * x.CostVac) + x.Surcharges);
            decimal sumAllSur = cal.GetList().Sum(x => x.Surcharges);

            TotalAmount.Text = $"Общая сумма {sumAll}";
            int SurCount = cal.GetList().Where(x => x.Surcharges != 0).Count();
            NumerToursSurcharges.Text = $"Кол-во туров с доплатами {SurCount}";
            TotalAmountSurcharges.Text = $"Общая сумма доплат {sumAllSur}";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
