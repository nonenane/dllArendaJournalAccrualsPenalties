using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dllArendaJournalAccrualsPenalties
{
    public partial class frmMain : Form
    {
        private DataTable dtData;
        private bool isChangeValue = false;

        public frmMain()
        {
            InitializeComponent();
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btExit,"Выход");
            tp.SetToolTip(btPrint, "Печать");
            tp.SetToolTip(btUpdate, "Обновить");
            //tp.SetToolTip(btExit, "Выход");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Task<DataTable> task = Config.hCntMain.getObjectLease(true);
            task.Wait();
            DataTable dtObjectLease = task.Result;

            cmbObject.DisplayMember = "cName";
            cmbObject.ValueMember = "id";
            cmbObject.DataSource = dtObjectLease;

            task = Config.hCntMain.getTypeContract(true);
            task.Wait();
            DataTable dtTypeContract = task.Result;

            cmbTypeContract.DisplayMember = "cName";
            cmbTypeContract.ValueMember = "id";
            cmbTypeContract.DataSource = dtTypeContract;

            task = Config.hCntMain.getListPeriodCredit(false);
            task.Wait();
            DataTable dtPeriodCredit = task.Result;

            cmbPeriodCredit.DisplayMember = "PeriodCredit";
            cmbPeriodCredit.ValueMember = "PeriodCredit";
            cmbPeriodCredit.DataSource = dtPeriodCredit;
        }

        private void dgvData_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {          
            int width = 0;
            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                if (!col.Visible) continue;
                if (col.Index == nameTenant.Index)
                {
                    tbTenant.Location = new Point(dgvData.Location.X + width + 1, tbTenant.Location.Y);
                    tbTenant.Size = new Size(nameTenant.Width, tbTenant.Height);
                }

                if (col.Index == cAgreements.Index)
                {
                    tbAgreement.Location = new Point(dgvData.Location.X + width + 1, tbTenant.Location.Y);
                    tbAgreement.Size = new Size(cAgreements.Width, tbTenant.Height);
                }

                if (col.Index == cItogPenalty.Index)
                {
                    tbItogPenalty.Location = new Point(dgvData.Location.X + width + 1, tbItogPenalty.Location.Y);
                    tbItogPenalty.Size = new Size(cItogPenalty.Width, tbItogPenalty.Height);
                    lItogoPenalty.Location = new Point(dgvData.Location.X + width - 45, lItogoPenalty.Location.Y);
                }
                width += col.Width;
            }
        }

        private void getData()
        {
            //Task<DataTable> task = Config.hCntMain.getJournalCongress(dtpStart.Value.Date, dtpEnd.Value.Date);
            //task.Wait();
            //dtData = task.Result.Copy();
            //task = null;
            dtData = new DataTable();

            setFilter();
            dgvData.DataSource = dtData;
            isChangeValue = false;
        }

        private void setFilter()
        {
            if (dtData == null || dtData.Rows.Count == 0)
            {
                //btEdit.Enabled = btDelete.Enabled = false;                
                return;
            }

            try
            {
                string filter = "";


                if (tbTenant.Text.Trim().Length != 0)
                    filter += (filter.Length == 0 ? "" : " and ") + $"nameTenant like '%{tbTenant.Text.Trim()}%'";

                if (tbAgreement.Text.Trim().Length != 0)
                    filter += (filter.Length == 0 ? "" : " and ") + $"Agreement like '%{tbAgreement.Text.Trim()}%'";

                if ((int)cmbObject.SelectedValue != 0)
                    filter += (filter.Length == 0 ? "" : " and ") + $"id_ObjectLease  = {cmbObject.SelectedValue}";
              

                dtData.DefaultView.RowFilter = filter;
                dtData.DefaultView.Sort = "nameLandLord asc, nameTenant asc, nameObject asc";
            }
            catch
            {
                dtData.DefaultView.RowFilter = "id = -1";
            }
            finally
            {
                //btEdit.Enabled = btDelete.Enabled =
                //dtData.DefaultView.Count != 0;
                dgvData_SelectionChanged(null, null);
            }
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvData.CurrentRow == null || dgvData.CurrentRow.Index == -1 || dtData == null || dtData.DefaultView.Count == 0 || dgvData.CurrentRow.Index >= dtData.DefaultView.Count)
            //{
            //    btPrint.Enabled = false;
            //    btAcceptD.Enabled = false;
            //    return;
            //}

            //btPrint.Enabled = true;

            //btAcceptD.Enabled = !(bool)dtData.DefaultView[dgvData.CurrentRow.Index]["isConfirmed"]
            //    || (!(bool)dtData.DefaultView[dgvData.CurrentRow.Index]["isConfirmed_LinkPetitionLeave"] && (bool)dtData.DefaultView[dgvData.CurrentRow.Index]["isLinkPetitionLeave"]);

            //new ToolTip().SetToolTip(btAcceptD, "Подтвердить съезд");
            //if ((!(bool)dtData.DefaultView[dgvData.CurrentRow.Index]["isConfirmed_LinkPetitionLeave"] && (bool)dtData.DefaultView[dgvData.CurrentRow.Index]["isLinkPetitionLeave"]))
            //    new ToolTip().SetToolTip(btAcceptD, "Подтвердить аннуляцию съезда");

        }

        private void dgvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            //Рисуем рамку для выделеной строки
            if (dgv.Rows[e.RowIndex].Selected)
            {
                int width = dgv.Width;
                Rectangle r = dgv.GetRowDisplayRectangle(e.RowIndex, false);
                Rectangle rect = new Rectangle(r.X, r.Y, width - 1, r.Height - 1);

                ControlPaint.DrawBorder(e.Graphics, rect,
                    SystemColors.Highlight, 2, ButtonBorderStyle.Solid,
                    SystemColors.Highlight, 2, ButtonBorderStyle.Solid,
                    SystemColors.Highlight, 2, ButtonBorderStyle.Solid,
                    SystemColors.Highlight, 2, ButtonBorderStyle.Solid);
            }
        }

        private void dgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1 && dtData != null && dtData.DefaultView.Count != 0)
            {

                Color rColor = Color.White;
                //if ((!(bool)dtData.DefaultView[e.RowIndex]["isLinkPetitionLeave"] || !(bool)dtData.DefaultView[e.RowIndex]["isConfirmed_LinkPetitionLeave"]) && (bool)dtData.DefaultView[e.RowIndex]["isConfirmed"])
                    //rColor = panel2.BackColor;

                dgvData.Rows[e.RowIndex].DefaultCellStyle.BackColor = rColor;
                dgvData.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = rColor;
                dgvData.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }

    }
}
