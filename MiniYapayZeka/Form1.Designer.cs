namespace MiniYapayZeka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Ekran = new Label();
            sorulanlar = new ListBox();
            btn_enter = new Button();
            ric_gelensoru = new RichTextBox();
            SuspendLayout();
            // 
            // lbl_Ekran
            // 
            lbl_Ekran.BackColor = Color.Black;
            lbl_Ekran.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Ekran.ForeColor = Color.Cornsilk;
            lbl_Ekran.Location = new Point(185, 37);
            lbl_Ekran.Name = "lbl_Ekran";
            lbl_Ekran.Size = new Size(591, 257);
            lbl_Ekran.TabIndex = 3;
            // 
            // sorulanlar
            // 
            sorulanlar.BackColor = Color.YellowGreen;
            sorulanlar.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sorulanlar.ForeColor = SystemColors.ActiveCaptionText;
            sorulanlar.FormattingEnabled = true;
            sorulanlar.ItemHeight = 29;
            sorulanlar.Location = new Point(12, 36);
            sorulanlar.Name = "sorulanlar";
            sorulanlar.Size = new Size(160, 381);
            sorulanlar.TabIndex = 4;
            // 
            // btn_enter
            // 
            btn_enter.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_enter.ForeColor = Color.Chocolate;
            btn_enter.Location = new Point(740, 333);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(36, 83);
            btn_enter.TabIndex = 6;
            btn_enter.Text = "E";
            btn_enter.UseVisualStyleBackColor = true;
            btn_enter.Click += btn_enter_Click;
            // 
            // ric_gelensoru
            // 
            ric_gelensoru.Location = new Point(185, 333);
            ric_gelensoru.Name = "ric_gelensoru";
            ric_gelensoru.Size = new Size(549, 83);
            ric_gelensoru.TabIndex = 7;
            ric_gelensoru.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(781, 442);
            Controls.Add(ric_gelensoru);
            Controls.Add(btn_enter);
            Controls.Add(sorulanlar);
            Controls.Add(lbl_Ekran);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_Ekran;
        private ListBox sorulanlar;
        private Button btn_enter;
        private RichTextBox ric_gelensoru;
    }
}