namespace LabSoftware1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabImportacao = new TabPage();
            tabPage2 = new TabPage();
            label3 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            button3 = new Button();
            label2 = new Label();
            button1 = new Button();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabImportacao.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabImportacao);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(583, 264);
            tabControl1.TabIndex = 0;
            // 
            // tabImportacao
            // 
            tabImportacao.Controls.Add(button4);
            tabImportacao.Controls.Add(button1);
            tabImportacao.Controls.Add(textBox2);
            tabImportacao.Controls.Add(button3);
            tabImportacao.Controls.Add(label2);
            tabImportacao.Controls.Add(button2);
            tabImportacao.Controls.Add(textBox3);
            tabImportacao.Controls.Add(label3);
            tabImportacao.Location = new Point(4, 24);
            tabImportacao.Name = "tabImportacao";
            tabImportacao.Padding = new Padding(3);
            tabImportacao.Size = new Size(575, 236);
            tabImportacao.TabIndex = 0;
            tabImportacao.Text = "Importação";
            tabImportacao.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(575, 236);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Relatório";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 16);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 14;
            label3.Text = "Arquivo Clientes:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 23);
            textBox3.TabIndex = 15;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(420, 12);
            button2.Name = "button2";
            button2.Size = new Size(33, 23);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 23);
            textBox2.TabIndex = 18;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(420, 44);
            button3.Name = "button3";
            button3.Size = new Size(33, 23);
            button3.TabIndex = 19;
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 44);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 17;
            label2.Text = "Arquivo Pagamentos:";
            // 
            // button1
            // 
            button1.Location = new Point(469, 14);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Importar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(469, 44);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 21;
            button4.Text = "Importar";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Sistema de Pagamentos";
            tabControl1.ResumeLayout(false);
            tabImportacao.ResumeLayout(false);
            tabImportacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabImportacao;
        private TabPage tabPage2;
        private Button button4;
        private Button button1;
        private TextBox textBox2;
        private Button button3;
        private Label label2;
        private Button button2;
        private TextBox textBox3;
        private Label label3;
    }
}
