using System;
using System.Data;
using System.Windows.Forms;
using FreeAccessLibrary.Data;

namespace FreeAccessLibrary_TestWFA
{
    public partial class FrmMainList : Form
    {
        private DataManager dtMan;

        public FrmMainList()
        {
            InitializeComponent();
            dtMan = new DataManager(Configuration.ConnectionString);
            RefreshLst();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            FrmPerson frm_p = new FrmPerson();
            frm_p.FormClosed += frm_p_FormClosed;
            frm_p.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            try
            {
                if (grdPersons.SelectedRows.Count < 1)
                {
                    return;
                }

                object obj_pid = grdPersons.SelectedRows[0].Cells[0].Value;
                int p_id = -1;

                // Geçersiz Person Id gönderilme ihtimaline karşı önlem
                if (!int.TryParse(string.Format("{0}", obj_pid), out p_id))
                {
                    return;
                }

                FrmPerson frm_p = new FrmPerson(p_id);
                frm_p.FormClosed += frm_p_FormClosed;
                frm_p.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                RefreshLst();
            }
        }

        private void frm_p_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshLst();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            try
            {
                if (grdPersons.SelectedRows.Count < 1)
                {
                    return;
                }

                object obj_pid = grdPersons.SelectedRows[0].Cells["Id"].Value;
                int p_id = -1;
                // Geçersiz Person Id gönderilme ihtimaline karşı önlem
                if (!int.TryParse(string.Format("{0}", obj_pid), out p_id))
                {
                    return;
                }

                DialogResult dr = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Doğrulama", MessageBoxButtons.YesNoCancel);

                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    dtMan.Delete("Person", p_id);
                    RefreshLst();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshLst();
        }

        private void RefreshLst()
        {
            DataTable dt = null;
            try
            {
                dt = dtMan.GetResultSetOfQuery("Select * From Person").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                grdPersons.DataSource = dt;
                grdPersons.Refresh();
            }
        }
    }
}