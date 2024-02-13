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
            c1CheckBox1 = new C1.Win.Input.C1CheckBox();
            c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1CheckBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Ribbon1).BeginInit();
            SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid1.Location = new Point(25, 244);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new Size(240, 150);
            c1FlexGrid1.TabIndex = 0;
            // 
            // c1FlexGrid2
            // 
            c1FlexGrid2.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid2.Location = new Point(428, 274);
            c1FlexGrid2.Margin = new Padding(2);
            c1FlexGrid2.Name = "c1FlexGrid2";
            c1FlexGrid2.Size = new Size(253, 136);
            c1FlexGrid2.TabIndex = 1;
            // 
            // c1BarCode1
            // 
            c1BarCode1.AdditionalNumber = null;
            c1BarCode1.BackColor = Color.White;
            c1BarCode1.Font = new Font("Microsoft Sans Serif", 12F);
            c1BarCode1.ForeColor = Color.Black;
            c1BarCode1.Location = new Point(509, 183);
            c1BarCode1.Margin = new Padding(2);
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
            // c1CheckBox1
            // 
            c1CheckBox1.AutoSize = true;
            c1CheckBox1.Location = new Point(341, 232);
            c1CheckBox1.Name = "c1CheckBox1";
            c1CheckBox1.Size = new Size(99, 19);
            c1CheckBox1.TabIndex = 3;
            c1CheckBox1.Text = "c1CheckBox1";
            // 
            // c1Ribbon1
            // 
            c1Ribbon1.ApplicationMenuHolder = ribbonApplicationMenu1;
            c1Ribbon1.BottomToolBarHolder = ribbonBottomToolBar1;
            c1Ribbon1.ConfigToolBarHolder = ribbonConfigToolBar1;
            c1Ribbon1.Location = new Point(0, 0);
            c1Ribbon1.Name = "c1Ribbon1";
            c1Ribbon1.QatHolder = ribbonQat1;
            c1Ribbon1.Size = new Size(800, 161);
            c1Ribbon1.Tabs.Add(ribbonTab1);
            c1Ribbon1.TopToolBarHolder = ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonQat1
            // 
            ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonConfigToolBar1
            // 
            ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonTopToolBar1
            // 
            ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // ribbonBottomToolBar1
            // 
            ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonTab1
            // 
            ribbonTab1.Groups.Add(ribbonGroup1);
            ribbonTab1.Name = "ribbonTab1";
            ribbonTab1.Text = "Tab";
            // 
            // ribbonGroup1
            // 
            ribbonGroup1.Name = "ribbonGroup1";
            ribbonGroup1.Text = "Group";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(c1Ribbon1);
            Controls.Add(c1CheckBox1);
            Controls.Add(c1BarCode1);
            Controls.Add(c1FlexGrid2);
            Controls.Add(c1FlexGrid1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid2).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1CheckBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Ribbon1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid2;
        private C1.Win.BarCode.C1BarCode c1BarCode1;
        private C1.Win.Input.C1CheckBox c1CheckBox1;
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
    }
}
