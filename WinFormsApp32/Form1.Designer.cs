namespace WinFormsApp32
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
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            c1FlexGrid2 = new C1.Win.FlexGrid.C1FlexGrid();
            c1BarCode1 = new C1.Win.BarCode.C1BarCode();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid2).BeginInit();
            SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid1.Location = new Point(40, 42);
            c1FlexGrid1.Margin = new Padding(4, 5, 4, 5);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new Size(342, 249);
            c1FlexGrid1.TabIndex = 0;
            // 
            // c1FlexGrid2
            // 
            c1FlexGrid2.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid2.Location = new Point(612, 456);
            c1FlexGrid2.Name = "c1FlexGrid2";
            c1FlexGrid2.Size = new Size(360, 225);
            c1FlexGrid2.TabIndex = 1;
            // 
            // c1BarCode1
            // 
            c1BarCode1.AdditionalNumber = null;
            c1BarCode1.BackColor = Color.White;
            c1BarCode1.Font = new Font("Microsoft Sans Serif", 12F);
            c1BarCode1.ForeColor = Color.Black;
            c1BarCode1.Location = new Point(161, 549);
            c1BarCode1.MicroQRCodeOptions.EncodingCodePage = 65001;
            c1BarCode1.Name = "c1BarCode1";
            c1BarCode1.QuietZone.Bottom = 0D;
            c1BarCode1.QuietZone.Left = 0D;
            c1BarCode1.QuietZone.Right = 0D;
            c1BarCode1.QuietZone.Top = 0D;
            c1BarCode1.Size = new Size(247, 40);
            c1BarCode1.TabIndex = 2;
            c1BarCode1.Text = "c1BarCode1";
            c1BarCode1.TextFixedLength = 0;
            c1BarCode1.WideToNarrowRatio = 2F;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(c1BarCode1);
            Controls.Add(c1FlexGrid2);
            Controls.Add(c1FlexGrid1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid2;
        private C1.Win.BarCode.C1BarCode c1BarCode1;
    }
}
