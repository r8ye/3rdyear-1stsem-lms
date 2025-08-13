using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using lms_w_barcode.Forms;

namespace lms_w_barcode
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Form currentChildForm;
        public Form1()
        {
            InitializeComponent();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.CornflowerBlue;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Lavender;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.Silver;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.DarkGray;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formDashboard());

        }

        private void btnProcurements_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);           
        }

        /*

        private void Reset()
        {
            DisableButton();
        }
        */

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formAuthor());
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formGenre());
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formPublisher());
        }

        private void btnClassification_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formClassification());
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formBooks());
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formDepartment());
        }

        private void btnGradeLevel_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formGradeLevel());
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formSection());
        }

        bool catalogsExpand = false;
        private void timerCatalogs_Tick(object sender, EventArgs e)
        {
            if (catalogsExpand == false)
            {
                conCatalogs.Height += 10;

                if (conCatalogs.Height >= 294)
                {
                    timerCatalogs.Stop();
                    catalogsExpand = true;
                }
            }
            else
            {
                conCatalogs.Height -= 10;

                if (conCatalogs.Height <= 49)
                {
                    timerCatalogs.Stop();
                    catalogsExpand = false;
                }
            }
        }

        private void btnCatalogs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            timerCatalogs.Start();
        }

        bool borrowerExpand = false;
        private void timerBorrowers_Tick(object sender, EventArgs e)
        {
            if (borrowerExpand == false)
            {
                conBorrowers.Height += 10;

                if (conBorrowers.Height >= 196)
                {
                    timerBorrowers.Stop();
                    borrowerExpand = true;
                }
            }
            else
            {
                conBorrowers.Height -= 10;

                if (conBorrowers.Height <= 49)
                {
                    timerBorrowers.Stop();
                    borrowerExpand = false;
                }
            }
        }

        private void btnBorrower_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            timerBorrowers.Start();
        }

        bool recordExpand = false;
        private void timerRecords_Tick(object sender, EventArgs e)
        {
            if (recordExpand == false)
            {
                conRecords.Height += 10;

                if (conRecords.Height >= 196)
                {
                    timerRecords.Stop();
                    recordExpand = true;
                }
            }
            else
            {
                conRecords.Height -= 10;

                if (conRecords.Height <= 49)
                {
                    timerRecords.Stop();
                    recordExpand = false;
                }
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            timerRecords.Start();
        }

        private void btnBorrowers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formBorrower());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formInventory());
        }

        private void btnCirculation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formCirculation());
        }
    }
}
