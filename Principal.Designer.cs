namespace Sistema
{
    partial class FormPrin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Tarefa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_Tarefas = new System.Windows.Forms.ListBox();
            this.btn_Conc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM-VINDO A SUA AGENDA!";
            // 
            // tb_Tarefa
            // 
            this.tb_Tarefa.Location = new System.Drawing.Point(532, 102);
            this.tb_Tarefa.Name = "tb_Tarefa";
            this.tb_Tarefa.Size = new System.Drawing.Size(222, 22);
            this.tb_Tarefa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(528, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "INSIRA AQUI A SUA TAREFA";
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Location = new System.Drawing.Point(532, 140);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(222, 32);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "ADICIONAR";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_Tarefas
            // 
            this.lb_Tarefas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Tarefas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Tarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tarefas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Tarefas.FormattingEnabled = true;
            this.lb_Tarefas.ItemHeight = 20;
            this.lb_Tarefas.Location = new System.Drawing.Point(287, 102);
            this.lb_Tarefas.Name = "lb_Tarefas";
            this.lb_Tarefas.Size = new System.Drawing.Size(212, 242);
            this.lb_Tarefas.TabIndex = 5;
            // 
            // btn_Conc
            // 
            this.btn_Conc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Conc.Location = new System.Drawing.Point(532, 178);
            this.btn_Conc.Name = "btn_Conc";
            this.btn_Conc.Size = new System.Drawing.Size(222, 32);
            this.btn_Conc.TabIndex = 6;
            this.btn_Conc.Text = "CONCLUIDO";
            this.btn_Conc.UseVisualStyleBackColor = true;
            this.btn_Conc.Click += new System.EventHandler(this.btn_Conc_Click);
            // 
            // FormPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.btn_Conc);
            this.Controls.Add(this.lb_Tarefas);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Tarefa);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormPrin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FormPrin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Tarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox lb_Tarefas;
        private System.Windows.Forms.Button btn_Conc;
    }
}