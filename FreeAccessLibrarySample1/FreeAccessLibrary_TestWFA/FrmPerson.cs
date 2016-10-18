using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using FreeAccessLibrary.Data;

namespace FreeAccessLibrary_TestWFA
{
    public partial class FrmPerson : Form
    {
        private int p_id = -1;
        private bool error_fired = false;
        private bool is_formload = false;
        private DataManager dtMan;
        private List<YasoParameter> changes;
        private byte[] im_bytes;

        public FrmPerson()
            : this(-1)
        {
        }

        public FrmPerson(int person_id)
        {
            InitializeComponent();
            p_id = person_id;
            changes = new List<YasoParameter>();
            dtMan = new DataManager(Configuration.ConnectionString);
        }

        private void FormLoad()
        {
            try
            {
                is_formload = false;

                if (p_id > 0)
                {
                    List<YasoParameter> h = new List<YasoParameter>();
                    h.Add(new YasoParameter { Name = "Id", Value = p_id });
                    DataTable dt = dtMan.GetResultSetOfQuery("Select * From Person Where Id=?", h).Tables[0];
                    AddChange("Id", p_id);
                    foreach (DataRow row in dt.Rows)
                    {
                        txtAd.Text = string.Format("{0}", row["Ad"]);
                        txtSoyad.Text = string.Format("{0}", row["Soyad"]);
                        if (row["Resim"] != null && row["Resim"] != DBNull.Value)
                        {
                            im_bytes = (byte[])row["Resim"];
                            if (im_bytes.Length > 0)
                            {
                                pcbxImage.Image = ImageByteConverter.byteArrayToImage(im_bytes);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error_fired = true;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                is_formload = true;
            }
        }

        private void FrmPerson_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                if (is_formload && !error_fired)
                {
                    if (txtAd.Text.Length == 0)
                    {
                        MessageBox.Show("Ad girin.");
                        return;
                    }

                    if (txtSoyad.Text.Length == 0)
                    {
                        MessageBox.Show("Soyad girin.");
                        return;
                    }

                    if (im_bytes == null || im_bytes.Length == 0)
                    {
                        MessageBox.Show("Resim seçin.");
                        return;
                    }

                    if (changes.IndexOf(new YasoParameter { Name = "Id" }) > -1 && p_id > 0)
                    {
                        // Update
                        if (changes.Count > 1)
                        {
                            dtMan.Update("person", changes);
                        }
                    }
                    else
                    {
                        // Insert
                        dtMan.Insert("person", changes);
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            this.Close();
        }

        private void AddChange(string column, object value)
        {
            if (!string.IsNullOrWhiteSpace(column))
            {
                YasoParameter prm = new YasoParameter { Name = column, Value = value };
                int indx = changes.IndexOf(prm);

                if (indx > -1)
                {
                    changes[indx] = prm;
                }
                else
                {
                    changes.Add(prm);
                }
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            if (is_formload)
            {
                AddChange("Ad", txtAd.Text);
            }
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            if (is_formload)
            {
                AddChange("Soyad", txtSoyad.Text);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    ofd.Filter = "Png Files|*.png|Jpeg Files|*.jpeg|Jpg Files|*.jpg";
                    ofd.Multiselect = false;
                    DialogResult dr = ofd.ShowDialog();

                    if (dr == System.Windows.Forms.DialogResult.OK)
                    {
                        im_bytes = File.ReadAllBytes(ofd.FileName);
                        pcbxImage.Image = ImageByteConverter.byteArrayToImage(im_bytes);
                        AddChange("Resim", im_bytes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
        }
    }
}