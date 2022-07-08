namespace CalculoEscalaSiclica
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
            this.txtDataBase = new System.Windows.Forms.MaskedTextBox();
            this.txtDataAtual = new System.Windows.Forms.MaskedTextBox();
            this.txtTrabalha = new System.Windows.Forms.TextBox();
            this.txtFolga = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbnStatus = new System.Windows.Forms.Label();
            this.btnAddDia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDataBase
            // 
            this.txtDataBase.Location = new System.Drawing.Point(21, 78);
            this.txtDataBase.Mask = "00/00/0000";
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(72, 20);
            this.txtDataBase.TabIndex = 0;
            this.txtDataBase.ValidatingType = typeof(System.DateTime);
            this.txtDataBase.Leave += new System.EventHandler(this.txtDataBase_Leave);
            // 
            // txtDataAtual
            // 
            this.txtDataAtual.Location = new System.Drawing.Point(111, 78);
            this.txtDataAtual.Mask = "00/00/0000";
            this.txtDataAtual.Name = "txtDataAtual";
            this.txtDataAtual.Size = new System.Drawing.Size(72, 20);
            this.txtDataAtual.TabIndex = 1;
            this.txtDataAtual.ValidatingType = typeof(System.DateTime);
            this.txtDataAtual.Leave += new System.EventHandler(this.txtDataAtual_Leave);
            // 
            // txtTrabalha
            // 
            this.txtTrabalha.Location = new System.Drawing.Point(21, 30);
            this.txtTrabalha.Name = "txtTrabalha";
            this.txtTrabalha.Size = new System.Drawing.Size(46, 20);
            this.txtTrabalha.TabIndex = 2;
            this.txtTrabalha.Leave += new System.EventHandler(this.txtTrabalha_Leave);
            // 
            // txtFolga
            // 
            this.txtFolga.Location = new System.Drawing.Point(99, 30);
            this.txtFolga.Name = "txtFolga";
            this.txtFolga.Size = new System.Drawing.Size(42, 20);
            this.txtFolga.TabIndex = 3;
            this.txtFolga.Leave += new System.EventHandler(this.txtFolga_Leave);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(234, 76);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trabalha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Folga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Base";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Atual";
            // 
            // lbnStatus
            // 
            this.lbnStatus.AutoSize = true;
            this.lbnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnStatus.Location = new System.Drawing.Point(17, 111);
            this.lbnStatus.Name = "lbnStatus";
            this.lbnStatus.Size = new System.Drawing.Size(64, 20);
            this.lbnStatus.TabIndex = 10;
            this.lbnStatus.Text = "Status: ";
            // 
            // btnAddDia
            // 
            this.btnAddDia.Location = new System.Drawing.Point(189, 76);
            this.btnAddDia.Name = "btnAddDia";
            this.btnAddDia.Size = new System.Drawing.Size(31, 23);
            this.btnAddDia.TabIndex = 11;
            this.btnAddDia.Text = ">";
            this.btnAddDia.UseVisualStyleBackColor = true;
            this.btnAddDia.Click += new System.EventHandler(this.btnAddDia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 155);
            this.Controls.Add(this.btnAddDia);
            this.Controls.Add(this.lbnStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtFolga);
            this.Controls.Add(this.txtTrabalha);
            this.Controls.Add(this.txtDataAtual);
            this.Controls.Add(this.txtDataBase);
            this.Name = "Form1";
            this.Text = "Calculo de Escala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtDataBase;
        private System.Windows.Forms.MaskedTextBox txtDataAtual;
        private System.Windows.Forms.TextBox txtTrabalha;
        private System.Windows.Forms.TextBox txtFolga;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbnStatus;
        private System.Windows.Forms.Button btnAddDia;
    }
}

