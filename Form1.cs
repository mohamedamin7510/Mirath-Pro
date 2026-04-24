using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace OOP_Project_Concept2
{
    public partial class Form1 : Form
    {
        private Panel resultPanel = null!;
        private Label resultTitleLabel = null!;
        private DataGridView resultGrid = null!;
        private Button newCaseButton = null!;

        public Form1()
        {
            InitializeComponent();
            ConfigureMainInputLayout();
            InitializeMainLayoutRuntimeAlignment();
            InitializeResultPanel();
        }

        private void ConfigureMainInputLayout()
        {
            if (num_FullBrothers.Parent != panel1) panel1.Controls.Add(num_FullBrothers);
            if (num_FullSisters.Parent != panel1) panel1.Controls.Add(num_FullSisters);
            if (label7.Parent != panel1) panel1.Controls.Add(label7);
            if (label8.Parent != panel1) panel1.Controls.Add(label8);

            panel1.Size = new Size(760, 560);

            // prevent stretch/misalignment
            label4.Anchor = AnchorStyles.Top;
            label5.Anchor = AnchorStyles.Top;
            label7.Anchor = AnchorStyles.Top;
            label8.Anchor = AnchorStyles.Top;

            // labels text consistency
            label5.Text = "عدد الابناء الذكور";
            label4.Text = "عدد الابناء الاناث";
            label8.Text = "عدد الأخوة الذكور";
            label7.Text = "عدد الأخوة الاناث";

            // common layout constants
            const int leftColX = 180;
            const int rightColX = 530;
            const int inputW = 170;

            // amount
            label3.Location = new Point(286, 18);
            textBox_Total.Location = new Point(235, 62);
            textBox_Total.Size = new Size(290, 31);

            // row 1: sons / daughters
            label5.Location = new Point(500, 118);
            num_Sons.Location = new Point(rightColX, 160);
            num_Sons.Size = new Size(inputW, 27);

            label4.Location = new Point(150, 118);
            num_Daughters.Location = new Point(leftColX, 160);
            num_Daughters.Size = new Size(inputW, 27);

            // row 2: brothers / sisters (same pattern)
            label8.Location = new Point(500, 225);
            num_FullBrothers.Location = new Point(rightColX, 267);
            num_FullBrothers.Size = new Size(inputW, 27);

            label7.Location = new Point(150, 225);
            num_FullSisters.Location = new Point(leftColX, 267);
            num_FullSisters.Size = new Size(inputW, 27);

            // gender + partner status (centered between radios)
            rb_Male.Location = new Point(220, 362);
            rb_Female.Location = new Point(560, 362);

            // Center X between radio centers
            int radiosCenterX =
                (rb_Male.Left + (rb_Male.Width / 2) + rb_Female.Left + (rb_Female.Width / 2)) / 2;

            // Place "جنس المتوفي" centered
            label6.Location = new Point(radiosCenterX - (label6.Width / 2), 320);

            // Place partner checkbox centered under radios
            chk_PartnerAlive.Location = new Point(radiosCenterX - (chk_PartnerAlive.Width / 2), 405);

            // Parents row
            chk_Mother.Location = new Point(220, 448);
            chk_Father.Location = new Point(560, 448);

            button1.Location = new Point(265, 500);
            button1.Size = new Size(230, 52);
            button1.Text = "اضغط للحساب";

            num_Sons.Minimum = 0; num_Sons.Maximum = 50;
            num_Daughters.Minimum = 0; num_Daughters.Maximum = 50;
            num_FullBrothers.Minimum = 0; num_FullBrothers.Maximum = 50;
            num_FullSisters.Minimum = 0; num_FullSisters.Maximum = 50;
        }

        private void InitializeMainLayoutRuntimeAlignment()
        {
            panel1.Anchor = AnchorStyles.None;
            label2.Anchor = AnchorStyles.None;

            Load += (_, __) => AlignMainLayout();
            Resize += (_, __) => AlignMainLayout();
        }

        private void AlignMainLayout()
        {
            // Keep panel visible on all resolutions/DPI
            int x = (ClientSize.Width - panel1.Width) / 2;

            int centeredY = (ClientSize.Height - panel1.Height) / 2;
            int minY = 80;
            int maxY = Math.Max(minY, ClientSize.Height - panel1.Height - 20);
            int y = Math.Min(Math.Max(centeredY, minY), maxY);

            panel1.Location = new Point(x, y);

            // Title centered above panel
            label2.Location = new Point((ClientSize.Width - label2.Width) / 2, panel1.Top - 60);
        }

        private void InitializeResultPanel()
        {
            resultPanel = new Panel
            {
                Name = "resultPanel",
                Size = new Size(900, 560),
                BackColor = Color.FromArgb(8, 24, 47),
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false,
                Anchor = AnchorStyles.None,
                Location = new Point((ClientSize.Width - 900) / 2, (ClientSize.Height - 560) / 2)
            };

            resultTitleLabel = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 84,
                Text = "نتائج توزيع التركة",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold)
            };

            resultGrid = new DataGridView
            {
                Dock = DockStyle.Top,
                Height = 360,
                BackgroundColor = Color.FromArgb(8, 43, 83),
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                RightToLeft = RightToLeft.Yes,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                GridColor = Color.FromArgb(150, 170, 190),
                ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            };

            resultGrid.EnableHeadersVisualStyles = false;
            resultGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            resultGrid.ColumnHeadersHeight = 62;
            resultGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(16, 59, 109);
            resultGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            resultGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            resultGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            resultGrid.RowTemplate.Height = 48;
            resultGrid.DefaultCellStyle.BackColor = Color.FromArgb(10, 33, 62);
            resultGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(17, 46, 81);
            resultGrid.DefaultCellStyle.ForeColor = Color.White;
            resultGrid.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
            resultGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            resultGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(22, 72, 124);
            resultGrid.DefaultCellStyle.SelectionForeColor = Color.White;

            resultGrid.Columns.Clear();
            resultGrid.Columns.Add("colHeir", "اسم الوارث");
            resultGrid.Columns.Add("colFraction", "النصيب (كسر)");
            resultGrid.Columns.Add("colAmount", "المبلغ المستحق");
            resultGrid.Columns["colAmount"]!.DefaultCellStyle.ForeColor = Color.FromArgb(214, 177, 98);

            newCaseButton = new Button
            {
                Text = "حساب مسألة جديدة",
                Size = new Size(290, 80),
                BackColor = Color.FromArgb(12, 44, 82),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold)
            };
            newCaseButton.FlatAppearance.BorderColor = Color.FromArgb(160, 127, 52);
            newCaseButton.FlatAppearance.BorderSize = 2;
            newCaseButton.Location = new Point((resultPanel.Width - newCaseButton.Width) / 2, 452);
            newCaseButton.Click += NewCaseButton_Click;

            resultPanel.Controls.Add(newCaseButton);
            resultPanel.Controls.Add(resultGrid);
            resultPanel.Controls.Add(resultTitleLabel);
            Controls.Add(resultPanel);
            resultPanel.BringToFront();

            Resize += (_, __) =>
            {
                resultPanel.Location = new Point(
                    (ClientSize.Width - resultPanel.Width) / 2,
                    (ClientSize.Height - resultPanel.Height) / 2);
            };
        }

        private bool ValidateInputs(out double totalMoney)
        {
            totalMoney = 0;

            if (string.IsNullOrWhiteSpace(textBox_Total.Text))
            {
                MessageBox.Show("من فضلك أدخل مبلغ التركة.");
                textBox_Total.Focus();
                return false;
            }

            var ok = double.TryParse(
                textBox_Total.Text.Trim(),
                NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint,
                CultureInfo.CurrentCulture,
                out totalMoney);

            if (!ok || totalMoney <= 0)
            {
                MessageBox.Show("مبلغ التركة غير صحيح. أدخل رقمًا موجبًا.");
                textBox_Total.Focus();
                return false;
            }

            if (!rb_Male.Checked && !rb_Female.Checked)
            {
                MessageBox.Show("من فضلك اختر جنس المتوفى (ذكر / أنثى).");
                return false;
            }

            int heirsCount =
                (int)num_Sons.Value +
                (int)num_Daughters.Value +
                (int)num_FullBrothers.Value +
                (int)num_FullSisters.Value +
                (chk_Father.Checked ? 1 : 0) +
                (chk_Mother.Checked ? 1 : 0) +
                (chk_PartnerAlive.Checked ? 1 : 0);

            if (heirsCount == 0)
            {
                MessageBox.Show("لا يوجد أي وارث مُدخل. من فضلك أدخل بيانات الورثة.");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out double totalMoney)) return;

            try
            {
                resultGrid.Rows.Clear();

                int sonsCount = (int)num_Sons.Value;
                int daughtersCount = (int)num_Daughters.Value;
                int fullBrothersCount = (int)num_FullBrothers.Value;
                int fullSistersCount = (int)num_FullSisters.Value;

                bool isDeceasedMale = rb_Male.Checked;
                bool hasBranch = (sonsCount + daughtersCount > 0);
                bool hasMaleSon = sonsCount > 0;

                List<Heir> fixedHeirs = new();

                if (chk_PartnerAlive.Checked)
                    fixedHeirs.Add(isDeceasedMale ? new Wife("الزوجة") : new Husband("الزوج"));

                Father? myFather = null;
                if (chk_Father.Checked)
                {
                    myFather = new Father("الأب");
                    fixedHeirs.Add(myFather);
                }

                if (chk_Mother.Checked)
                    fixedHeirs.Add(new Mother("الأم"));

                double totalRatios = 0;
                foreach (var heir in fixedHeirs)
                {
                    double r = heir.GetShareRatio(hasBranch, isDeceasedMale);
                    if (r > 0) totalRatios += r;
                }

                double daughtersRatio = 0;
                Daughter myDaughters = new("البنات", daughtersCount, hasMaleSon);
                if (!hasMaleSon && daughtersCount > 0)
                {
                    daughtersRatio = myDaughters.GetShareRatio(hasBranch, isDeceasedMale);
                    totalRatios += daughtersRatio;
                }

                foreach (var heir in fixedHeirs)
                {
                    double ratio = heir.GetShareRatio(hasBranch, isDeceasedMale);
                    if (ratio > 0)
                    {
                        double currentRatio = totalRatios > 1.0 ? (ratio / totalRatios) : ratio;
                        heir.SetFinalAmount(totalMoney * currentRatio);
                    }
                }

                double daughtersFinalRatio = 0;
                if (!hasMaleSon && daughtersCount > 0)
                {
                    daughtersFinalRatio = totalRatios > 1.0 ? (daughtersRatio / totalRatios) : daughtersRatio;
                    myDaughters.SetFinalAmount(totalMoney * daughtersFinalRatio);
                }

                double allocatedMoney = fixedHeirs.Sum(h => h.FinalAmount);
                if (!hasMaleSon && daughtersCount > 0) allocatedMoney += myDaughters.FinalAmount;

                double residue = Math.Max(0, totalMoney - allocatedMoney);

                double totalSonsAmount = 0;
                double totalDaughtersAmount = 0;
                double totalBrothersAmount = 0;
                double totalSistersAmount = 0;

                if (hasMaleSon)
                {
                    double totalShares = (sonsCount * 2) + daughtersCount;
                    if (totalShares > 0)
                    {
                        double shareValue = residue / totalShares;
                        totalSonsAmount = (shareValue * 2) * sonsCount;
                        totalDaughtersAmount = shareValue * daughtersCount;
                        residue = 0;
                    }
                }
                else if (chk_Father.Checked && myFather != null)
                {
                    myFather.AddResidue(residue);
                    residue = 0;
                }
                else if (residue > 0 && (fullBrothersCount > 0 || fullSistersCount > 0))
                {
                    double siblingShares = (fullBrothersCount * 2) + fullSistersCount;
                    if (siblingShares > 0)
                    {
                        double siblingShareValue = residue / siblingShares;
                        totalBrothersAmount = (siblingShareValue * 2) * fullBrothersCount;
                        totalSistersAmount = siblingShareValue * fullSistersCount;
                        residue = 0;
                    }
                }

                foreach (var heir in fixedHeirs.Where(h => h.FinalAmount > 0))
                {
                    double ratio = heir.GetShareRatio(hasBranch, isDeceasedMale);
                    string fraction = ratio > 0
                        ? ToFractionText(totalRatios > 1.0 ? (ratio / totalRatios) : ratio)
                        : "تعصيب";

                    AddResultRow(heir.Relationship, fraction, heir.FinalAmount);
                }

                if (!hasMaleSon && daughtersCount > 0 && myDaughters.FinalAmount > 0)
                    AddResultRow($"البنات ({daughtersCount})", ToFractionText(daughtersFinalRatio), myDaughters.FinalAmount);

                if (hasMaleSon)
                {
                    if (sonsCount > 0) AddResultRow($"الأبناء ({sonsCount})", "تعصيب", totalSonsAmount);
                    if (daughtersCount > 0) AddResultRow($"البنات ({daughtersCount})", "تعصيب", totalDaughtersAmount);
                }

                if (totalBrothersAmount > 0 || totalSistersAmount > 0)
                {
                    if (fullBrothersCount > 0) AddResultRow($"الأخوة الأشقاء ({fullBrothersCount})", "تعصيب", totalBrothersAmount);
                    if (fullSistersCount > 0) AddResultRow($"الأخوات الشقيقات ({fullSistersCount})", "تعصيب", totalSistersAmount);
                }

                if (residue > 0.01) AddResultRow("باقي غير موزع", "-", residue);

                ShowResultPanel();
            }
            catch
            {
                MessageBox.Show("خطأ: تأكد من إدخال كافة البيانات بشكل صحيح.");
            }
        }

        private void AddResultRow(string heirName, string fraction, double amount)
        {
            resultGrid.Rows.Add(heirName, fraction, amount.ToString("N0"));
        }

        private static string ToFractionText(double ratio)
        {
            const double eps = 0.0001;
            if (Math.Abs(ratio - (1.0 / 2.0)) < eps) return "1/2";
            if (Math.Abs(ratio - (1.0 / 3.0)) < eps) return "1/3";
            if (Math.Abs(ratio - (1.0 / 4.0)) < eps) return "1/4";
            if (Math.Abs(ratio - (1.0 / 6.0)) < eps) return "1/6";
            if (Math.Abs(ratio - (1.0 / 8.0)) < eps) return "1/8";
            if (Math.Abs(ratio - (2.0 / 3.0)) < eps) return "2/3";
            return ratio.ToString("0.###");
        }

        private void ShowResultPanel()
        {
            panel1.Visible = false;
            label2.Visible = false;
            resultPanel.Visible = true;
            resultPanel.BringToFront();
        }

        private void NewCaseButton_Click(object? sender, EventArgs e)
        {
            resultPanel.Visible = false;
            panel1.Visible = true;
            label2.Visible = true;

            textBox_Total.Clear();
            num_Sons.Value = 0;
            num_Daughters.Value = 0;
            num_FullBrothers.Value = 0;
            num_FullSisters.Value = 0;
            chk_PartnerAlive.Checked = false;
            chk_Father.Checked = false;
            chk_Mother.Checked = false;
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            resultGrid.Rows.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color goldenColor = Color.FromArgb(160, 127, 52);
            int borderThickness = 3;

            using Pen borderPen = new(goldenColor, borderThickness);
            Rectangle rect = new(
                borderThickness / 2,
                borderThickness / 2,
                panel1.Width - borderThickness,
                panel1.Height - borderThickness);

            e.Graphics.DrawRectangle(borderPen, rect);
        }

        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Male.Checked)
                chk_PartnerAlive.Text = "الزوجة على قيد الحياة";
        }

        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Female.Checked)
                chk_PartnerAlive.Text = "الزوج على قيد الحياة";
        }
    }
}