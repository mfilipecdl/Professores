namespace Professores
{
    partial class Form1
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
            this.LblProfessores = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.LblIDProfessor = new System.Windows.Forms.Label();
            this.TxtIDProfessor = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.GBoxMorada = new System.Windows.Forms.GroupBox();
            this.TxtRua = new System.Windows.Forms.TextBox();
            this.LblDataNasc = new System.Windows.Forms.Label();
            this.LblNIF = new System.Windows.Forms.Label();
            this.TxtNIF = new System.Windows.Forms.TextBox();
            this.LblSS = new System.Windows.Forms.Label();
            this.TxtSS = new System.Windows.Forms.TextBox();
            this.LblEscalao = new System.Windows.Forms.Label();
            this.CmbEscalao = new System.Windows.Forms.ComboBox();
            this.LblTempoServico = new System.Windows.Forms.Label();
            this.TxtTempoServico = new System.Windows.Forms.TextBox();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.DTPDataNasc = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadNãoProfissinalizado = new System.Windows.Forms.RadioButton();
            this.RadProfissionalizado = new System.Windows.Forms.RadioButton();
            this.ChkContratado = new System.Windows.Forms.CheckBox();
            this.GBoxMorada.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblProfessores
            // 
            this.LblProfessores.AutoSize = true;
            this.LblProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfessores.Location = new System.Drawing.Point(2, 0);
            this.LblProfessores.Name = "LblProfessores";
            this.LblProfessores.Size = new System.Drawing.Size(120, 24);
            this.LblProfessores.TabIndex = 0;
            this.LblProfessores.Text = "Professores";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 419);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 4;
            this.lineShape1.X2 = 786;
            this.lineShape1.Y1 = 24;
            this.lineShape1.Y2 = 24;
            // 
            // LblIDProfessor
            // 
            this.LblIDProfessor.AutoSize = true;
            this.LblIDProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDProfessor.Location = new System.Drawing.Point(12, 31);
            this.LblIDProfessor.Name = "LblIDProfessor";
            this.LblIDProfessor.Size = new System.Drawing.Size(21, 15);
            this.LblIDProfessor.TabIndex = 2;
            this.LblIDProfessor.Text = "ID";
            // 
            // TxtIDProfessor
            // 
            this.TxtIDProfessor.Location = new System.Drawing.Point(60, 31);
            this.TxtIDProfessor.Name = "TxtIDProfessor";
            this.TxtIDProfessor.Size = new System.Drawing.Size(158, 20);
            this.TxtIDProfessor.TabIndex = 3;
            this.TxtIDProfessor.TextChanged += new System.EventHandler(this.TxtIDProfessor_TextChanged);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(9, 57);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(45, 15);
            this.LblNome.TabIndex = 4;
            this.LblNome.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(60, 57);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(727, 20);
            this.TxtNome.TabIndex = 5;
            // 
            // GBoxMorada
            // 
            this.GBoxMorada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GBoxMorada.Controls.Add(this.TxtRua);
            this.GBoxMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxMorada.Location = new System.Drawing.Point(12, 95);
            this.GBoxMorada.Name = "GBoxMorada";
            this.GBoxMorada.Size = new System.Drawing.Size(775, 108);
            this.GBoxMorada.TabIndex = 6;
            this.GBoxMorada.TabStop = false;
            this.GBoxMorada.Text = "Morada";
            // 
            // TxtRua
            // 
            this.TxtRua.Location = new System.Drawing.Point(48, 20);
            this.TxtRua.Multiline = true;
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(703, 82);
            this.TxtRua.TabIndex = 1;
            // 
            // LblDataNasc
            // 
            this.LblDataNasc.AutoSize = true;
            this.LblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataNasc.Location = new System.Drawing.Point(10, 215);
            this.LblDataNasc.Name = "LblDataNasc";
            this.LblDataNasc.Size = new System.Drawing.Size(137, 15);
            this.LblDataNasc.TabIndex = 7;
            this.LblDataNasc.Text = "Data de Nascimento";
            // 
            // LblNIF
            // 
            this.LblNIF.AutoSize = true;
            this.LblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNIF.Location = new System.Drawing.Point(95, 262);
            this.LblNIF.Name = "LblNIF";
            this.LblNIF.Size = new System.Drawing.Size(29, 15);
            this.LblNIF.TabIndex = 11;
            this.LblNIF.Text = "NIF";
            // 
            // TxtNIF
            // 
            this.TxtNIF.Location = new System.Drawing.Point(130, 262);
            this.TxtNIF.Name = "TxtNIF";
            this.TxtNIF.Size = new System.Drawing.Size(100, 20);
            this.TxtNIF.TabIndex = 12;
            // 
            // LblSS
            // 
            this.LblSS.AutoSize = true;
            this.LblSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSS.Location = new System.Drawing.Point(99, 289);
            this.LblSS.Name = "LblSS";
            this.LblSS.Size = new System.Drawing.Size(25, 15);
            this.LblSS.TabIndex = 13;
            this.LblSS.Text = "SS";
            // 
            // TxtSS
            // 
            this.TxtSS.Location = new System.Drawing.Point(130, 288);
            this.TxtSS.Name = "TxtSS";
            this.TxtSS.Size = new System.Drawing.Size(129, 20);
            this.TxtSS.TabIndex = 14;
            // 
            // LblEscalao
            // 
            this.LblEscalao.AutoSize = true;
            this.LblEscalao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscalao.Location = new System.Drawing.Point(68, 317);
            this.LblEscalao.Name = "LblEscalao";
            this.LblEscalao.Size = new System.Drawing.Size(58, 15);
            this.LblEscalao.TabIndex = 15;
            this.LblEscalao.Text = "Escalão";
            // 
            // CmbEscalao
            // 
            this.CmbEscalao.FormattingEnabled = true;
            this.CmbEscalao.Location = new System.Drawing.Point(132, 314);
            this.CmbEscalao.Name = "CmbEscalao";
            this.CmbEscalao.Size = new System.Drawing.Size(49, 21);
            this.CmbEscalao.TabIndex = 16;
            // 
            // LblTempoServico
            // 
            this.LblTempoServico.AutoSize = true;
            this.LblTempoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempoServico.Location = new System.Drawing.Point(4, 341);
            this.LblTempoServico.Name = "LblTempoServico";
            this.LblTempoServico.Size = new System.Drawing.Size(122, 15);
            this.LblTempoServico.TabIndex = 17;
            this.LblTempoServico.Text = "Tempo de Serviço";
            // 
            // TxtTempoServico
            // 
            this.TxtTempoServico.Location = new System.Drawing.Point(132, 341);
            this.TxtTempoServico.Name = "TxtTempoServico";
            this.TxtTempoServico.Size = new System.Drawing.Size(49, 20);
            this.TxtTempoServico.TabIndex = 18;
            // 
            // BtnInserir
            // 
            this.BtnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInserir.Location = new System.Drawing.Point(573, 384);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 23);
            this.BtnInserir.TabIndex = 20;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(677, 384);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 21;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // DTPDataNasc
            // 
            this.DTPDataNasc.Location = new System.Drawing.Point(153, 215);
            this.DTPDataNasc.Name = "DTPDataNasc";
            this.DTPDataNasc.Size = new System.Drawing.Size(200, 20);
            this.DTPDataNasc.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.RadNãoProfissinalizado);
            this.groupBox1.Controls.Add(this.RadProfissionalizado);
            this.groupBox1.Controls.Add(this.ChkContratado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(480, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 102);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contratado";
            // 
            // RadNãoProfissinalizado
            // 
            this.RadNãoProfissinalizado.AutoSize = true;
            this.RadNãoProfissinalizado.Enabled = false;
            this.RadNãoProfissinalizado.Location = new System.Drawing.Point(67, 67);
            this.RadNãoProfissinalizado.Name = "RadNãoProfissinalizado";
            this.RadNãoProfissinalizado.Size = new System.Drawing.Size(166, 19);
            this.RadNãoProfissinalizado.TabIndex = 2;
            this.RadNãoProfissinalizado.TabStop = true;
            this.RadNãoProfissinalizado.Text = "Não Profissionalizado";
            this.RadNãoProfissinalizado.UseVisualStyleBackColor = true;
            // 
            // RadProfissionalizado
            // 
            this.RadProfissionalizado.AutoSize = true;
            this.RadProfissionalizado.Enabled = false;
            this.RadProfissionalizado.Location = new System.Drawing.Point(67, 42);
            this.RadProfissionalizado.Name = "RadProfissionalizado";
            this.RadProfissionalizado.Size = new System.Drawing.Size(136, 19);
            this.RadProfissionalizado.TabIndex = 1;
            this.RadProfissionalizado.TabStop = true;
            this.RadProfissionalizado.Text = "Profissionalizado";
            this.RadProfissionalizado.UseVisualStyleBackColor = true;
            this.RadProfissionalizado.CheckedChanged += new System.EventHandler(this.RadProfissionalizado_CheckedChanged);
            // 
            // ChkContratado
            // 
            this.ChkContratado.AutoSize = true;
            this.ChkContratado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkContratado.Location = new System.Drawing.Point(29, 19);
            this.ChkContratado.Name = "ChkContratado";
            this.ChkContratado.Size = new System.Drawing.Size(145, 17);
            this.ChkContratado.TabIndex = 0;
            this.ChkContratado.Text = "Professor Contratado";
            this.ChkContratado.UseVisualStyleBackColor = true;
            this.ChkContratado.CheckedChanged += new System.EventHandler(this.ChkContratado_CheckedChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DTPDataNasc);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.TxtTempoServico);
            this.Controls.Add(this.LblTempoServico);
            this.Controls.Add(this.CmbEscalao);
            this.Controls.Add(this.LblEscalao);
            this.Controls.Add(this.TxtSS);
            this.Controls.Add(this.LblSS);
            this.Controls.Add(this.TxtNIF);
            this.Controls.Add(this.LblNIF);
            this.Controls.Add(this.LblDataNasc);
            this.Controls.Add(this.GBoxMorada);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtIDProfessor);
            this.Controls.Add(this.LblIDProfessor);
            this.Controls.Add(this.LblProfessores);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Professores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBoxMorada.ResumeLayout(false);
            this.GBoxMorada.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProfessores;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label LblIDProfessor;
        private System.Windows.Forms.TextBox TxtIDProfessor;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.GroupBox GBoxMorada;
        private System.Windows.Forms.TextBox TxtRua;
        private System.Windows.Forms.Label LblDataNasc;
        private System.Windows.Forms.Label LblNIF;
        private System.Windows.Forms.TextBox TxtNIF;
        private System.Windows.Forms.Label LblSS;
        private System.Windows.Forms.TextBox TxtSS;
        private System.Windows.Forms.Label LblEscalao;
        private System.Windows.Forms.ComboBox CmbEscalao;
        private System.Windows.Forms.Label LblTempoServico;
        private System.Windows.Forms.TextBox TxtTempoServico;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DateTimePicker DTPDataNasc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadNãoProfissinalizado;
        private System.Windows.Forms.RadioButton RadProfissionalizado;
        private System.Windows.Forms.CheckBox ChkContratado;
    }
}

