namespace Tao_OpenGL_Initialization_Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label labelAlfa;
            System.Windows.Forms.Label labelBeta;
            System.Windows.Forms.Label labelOmega;
            this.printAlfaLabel = new System.Windows.Forms.Label();
            this.printBetaLabel = new System.Windows.Forms.Label();
            this.printOmegaLabel = new System.Windows.Forms.Label();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            labelAlfa = new System.Windows.Forms.Label();
            labelBeta = new System.Windows.Forms.Label();
            labelOmega = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlfa
            // 
            labelAlfa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelAlfa.Location = new System.Drawing.Point(907, 48);
            labelAlfa.Name = "labelAlfa";
            labelAlfa.Size = new System.Drawing.Size(85, 46);
            labelAlfa.TabIndex = 2;
            labelAlfa.Text = "alpha = ";
            labelAlfa.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelBeta
            // 
            labelBeta.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelBeta.Location = new System.Drawing.Point(1023, 48);
            labelBeta.Name = "labelBeta";
            labelBeta.Size = new System.Drawing.Size(85, 46);
            labelBeta.TabIndex = 5;
            labelBeta.Text = "beta = ";
            labelBeta.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelOmega
            // 
            labelOmega.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelOmega.Location = new System.Drawing.Point(1114, 48);
            labelOmega.Name = "labelOmega";
            labelOmega.Size = new System.Drawing.Size(96, 46);
            labelOmega.TabIndex = 6;
            labelOmega.Text = "omega = ";
            labelOmega.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // printAlfaLabel
            // 
            this.printAlfaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printAlfaLabel.Location = new System.Drawing.Point(907, 94);
            this.printAlfaLabel.Name = "printAlfaLabel";
            this.printAlfaLabel.Size = new System.Drawing.Size(85, 46);
            this.printAlfaLabel.TabIndex = 10;
            this.printAlfaLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // printBetaLabel
            // 
            this.printBetaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printBetaLabel.Location = new System.Drawing.Point(1023, 94);
            this.printBetaLabel.Name = "printBetaLabel";
            this.printBetaLabel.Size = new System.Drawing.Size(85, 46);
            this.printBetaLabel.TabIndex = 11;
            this.printBetaLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // printOmegaLabel
            // 
            this.printOmegaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printOmegaLabel.Location = new System.Drawing.Point(1114, 94);
            this.printOmegaLabel.Name = "printOmegaLabel";
            this.printOmegaLabel.Size = new System.Drawing.Size(85, 46);
            this.printOmegaLabel.TabIndex = 12;
            this.printOmegaLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(12, 12);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(877, 816);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.simpleOpenGlControl1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(912, 135);
            this.trackBar1.Maximum = 5000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 545);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 250;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1028, 135);
            this.trackBar2.Maximum = 5000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(56, 545);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Value = 800;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(1119, 135);
            this.trackBar3.Maximum = 5000;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(56, 545);
            this.trackBar3.TabIndex = 9;
            this.trackBar3.Value = 500;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1246, 853);
            this.Controls.Add(this.printOmegaLabel);
            this.Controls.Add(this.printBetaLabel);
            this.Controls.Add(this.printAlfaLabel);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(labelOmega);
            this.Controls.Add(labelBeta);
            this.Controls.Add(labelAlfa);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    
        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label printAlfaLabel;
        private System.Windows.Forms.Label printBetaLabel;
        private System.Windows.Forms.Label printOmegaLabel;
    }
}

