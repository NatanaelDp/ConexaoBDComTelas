namespace ConexaoBDComTelas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cboxConcluido = new System.Windows.Forms.CheckBox();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listTarefas = new System.Windows.Forms.ListView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.cboxConcluido);
            this.groupBox1.Controls.Add(this.txtTarefa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(112, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 115);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cboxConcluido
            // 
            this.cboxConcluido.AutoSize = true;
            this.cboxConcluido.Location = new System.Drawing.Point(16, 81);
            this.cboxConcluido.Name = "cboxConcluido";
            this.cboxConcluido.Size = new System.Drawing.Size(81, 19);
            this.cboxConcluido.TabIndex = 2;
            this.cboxConcluido.Text = "Concluído";
            this.cboxConcluido.UseVisualStyleBackColor = true;
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(16, 52);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(138, 23);
            this.txtTarefa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição da tarefa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listTarefas
            // 
            this.listTarefas.Location = new System.Drawing.Point(443, 158);
            this.listTarefas.Name = "listTarefas";
            this.listTarefas.Size = new System.Drawing.Size(278, 150);
            this.listTarefas.TabIndex = 1;
            this.listTarefas.UseCompatibleStateImageBehavior = false;
            this.listTarefas.View = System.Windows.Forms.View.List;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(444, 133);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(160, 23);
            this.txtPesquisa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(624, 133);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pesquisar uma tarefa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.listTarefas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSalvar;
        private CheckBox cboxConcluido;
        private TextBox txtTarefa;
        private Label label1;
        private ListView listTarefas;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private Label label2;
    }
}