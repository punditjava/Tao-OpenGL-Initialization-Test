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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.printAlfaLabel = new System.Windows.Forms.Label();
            this.printBetaLabel = new System.Windows.Forms.Label();
            this.printOmegaLabel = new System.Windows.Forms.Label();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.calcuteMethodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.methodRungeKuttaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calcuteMethodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.methodEuleraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.methodRungeKuttaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            labelAlfa = new System.Windows.Forms.Label();
            labelBeta = new System.Windows.Forms.Label();
            labelOmega = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcuteMethodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodRungeKuttaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcuteMethodsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodEuleraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodRungeKuttaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlfa
            // 
            labelAlfa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelAlfa.Location = new System.Drawing.Point(907, 77);
            labelAlfa.Name = "labelAlfa";
            labelAlfa.Size = new System.Drawing.Size(71, 29);
            labelAlfa.TabIndex = 2;
            labelAlfa.Text = "alpha";
            labelAlfa.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelBeta
            // 
            labelBeta.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelBeta.Location = new System.Drawing.Point(1023, 77);
            labelBeta.Name = "labelBeta";
            labelBeta.Size = new System.Drawing.Size(67, 29);
            labelBeta.TabIndex = 5;
            labelBeta.Text = "beta";
            labelBeta.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelOmega
            // 
            labelOmega.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelOmega.Location = new System.Drawing.Point(1114, 77);
            labelOmega.Name = "labelOmega";
            labelOmega.Size = new System.Drawing.Size(80, 29);
            labelOmega.TabIndex = 6;
            labelOmega.Text = "omega";
            labelOmega.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(907, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 29);
            label1.TabIndex = 15;
            label1.Text = "x_0 = ";
            label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(1064, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 33);
            label2.TabIndex = 16;
            label2.Text = "y_0 = ";
            label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // printAlfaLabel
            // 
            this.printAlfaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printAlfaLabel.Location = new System.Drawing.Point(907, 106);
            this.printAlfaLabel.Name = "printAlfaLabel";
            this.printAlfaLabel.Size = new System.Drawing.Size(50, 34);
            this.printAlfaLabel.TabIndex = 10;
            this.printAlfaLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // printBetaLabel
            // 
            this.printBetaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printBetaLabel.Location = new System.Drawing.Point(1023, 106);
            this.printBetaLabel.Name = "printBetaLabel";
            this.printBetaLabel.Size = new System.Drawing.Size(50, 34);
            this.printBetaLabel.TabIndex = 11;
            this.printBetaLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // printOmegaLabel
            // 
            this.printOmegaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printOmegaLabel.Location = new System.Drawing.Point(1124, 106);
            this.printOmegaLabel.Name = "printOmegaLabel";
            this.printOmegaLabel.Size = new System.Drawing.Size(50, 34);
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
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.simpleOpenGlControl1MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(912, 135);
            this.trackBar1.Maximum = 5000;
            this.trackBar1.Minimum = -5000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 545);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 250;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1028, 135);
            this.trackBar2.Maximum = 5000;
            this.trackBar2.Minimum = -5000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(56, 545);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.Value = 2100;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(1119, 135);
            this.trackBar3.Maximum = 5000;
            this.trackBar3.Minimum = -5000;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(56, 545);
            this.trackBar3.TabIndex = 1;
            this.trackBar3.Value = 500;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3Scroll);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Items.AddRange(new object[] {
            "Метод Эйлера",
            "Метод Рунге-Кутта"});
            this.listBox1.Location = new System.Drawing.Point(912, 699);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 66);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1SelectedIndexChanged);
            // 
            // textBoxX0
            // 
            this.textBoxX0.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxX0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX0.Location = new System.Drawing.Point(971, 24);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(51, 35);
            this.textBoxX0.TabIndex = 19;
            this.textBoxX0.TextChanged += new System.EventHandler(this.textBoxX0TextChanged);
            // 
            // textBoxY0
            // 
            this.textBoxY0.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxY0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY0.Location = new System.Drawing.Point(1129, 24);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(53, 35);
            this.textBoxY0.TabIndex = 20;
            this.textBoxY0.TextChanged += new System.EventHandler(this.textBoxY0TextChanged);
            // 
            // methodRungeKuttaBindingSource1
            // 
            this.methodRungeKuttaBindingSource1.DataSource = typeof(Tao_OpenGL_Initialization_Test.MethodRungeKutta);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1390, 845);
            this.Controls.Add(this.textBoxY0);
            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.listBox1);
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
            this.Load += new System.EventHandler(this.form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcuteMethodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodRungeKuttaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcuteMethodsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodEuleraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodRungeKuttaBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource calcuteMethodsBindingSource;
        private System.Windows.Forms.BindingSource methodRungeKuttaBindingSource;
        private System.Windows.Forms.BindingSource calcuteMethodsBindingSource1;
        private System.Windows.Forms.BindingSource methodEuleraBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource methodRungeKuttaBindingSource1;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.TextBox textBoxY0;
    }
}

