namespace Tp4Sim
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Generar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.prec_uti_perdida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.precio_reemb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.precio_costo = new System.Windows.Forms.TextBox();
            this.cant_generar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cant_perd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cant_demand = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.resultado_ = new System.Windows.Forms.Label();
            this.politica_b = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.politica_A = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grilla_politica_a = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.grilla_politica_b = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDplb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantDemplb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantOrdplb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantVendplb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantPerplb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobraplb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COplb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reemplb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUPplb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costotalplb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CosAc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantDemandada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantOrdenada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantPerdida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CosUtPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_politica_a)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_politica_b)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Generar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cant_generar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 264);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros de Entrada";
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(105, 233);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(75, 23);
            this.Generar.TabIndex = 21;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prec_uti_perdida);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.precio_reemb);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.precio_costo);
            this.groupBox3.Location = new System.Drawing.Point(6, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 66);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos De Costo";
            // 
            // prec_uti_perdida
            // 
            this.prec_uti_perdida.Enabled = true;
            this.prec_uti_perdida.Location = new System.Drawing.Point(205, 32);
            this.prec_uti_perdida.MaxLength = 6;
            this.prec_uti_perdida.Name = "prec_uti_perdida";
            this.prec_uti_perdida.Size = new System.Drawing.Size(46, 20);
            this.prec_uti_perdida.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Utilidad Perdida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Reembolso";
            // 
            // precio_reemb
            // 
            this.precio_reemb.Enabled = true;
            this.precio_reemb.Location = new System.Drawing.Point(118, 32);
            this.precio_reemb.MaxLength = 6;
            this.precio_reemb.Name = "precio_reemb";
            this.precio_reemb.Size = new System.Drawing.Size(46, 20);
            this.precio_reemb.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Precio Costo";
            // 
            // precio_costo
            // 
            this.precio_costo.Enabled = true;
            this.precio_costo.Location = new System.Drawing.Point(22, 32);
            this.precio_costo.MaxLength = 4;
            this.precio_costo.Name = "precio_costo";
            this.precio_costo.Size = new System.Drawing.Size(46, 20);
            this.precio_costo.TabIndex = 8;
            // 
            // cant_generar
            // 
            this.cant_generar.Enabled = true;
            this.cant_generar.Location = new System.Drawing.Point(124, 126);
            this.cant_generar.MaxLength = 6;
            this.cant_generar.Name = "cant_generar";
            this.cant_generar.Size = new System.Drawing.Size(46, 20);
            this.cant_generar.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad a Generar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cant_perd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cant_demand);
            this.groupBox2.Location = new System.Drawing.Point(6, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 66);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Dia Anterior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cantidad Perdida";
            // 
            // cant_perd
            // 
            this.cant_perd.Enabled = true;
            this.cant_perd.Location = new System.Drawing.Point(184, 32);
            this.cant_perd.MaxLength = 6;
            this.cant_perd.Name = "cant_perd";
            this.cant_perd.Size = new System.Drawing.Size(46, 20);
            this.cant_perd.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cantidad demandada";
            // 
            // cant_demand
            // 
            this.cant_demand.Enabled = true;
            this.cant_demand.Location = new System.Drawing.Point(51, 32);
            this.cant_demand.MaxLength = 4;
            this.cant_demand.Name = "cant_demand";
            this.cant_demand.Size = new System.Drawing.Size(46, 20);
            this.cant_demand.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resultado_);
            this.groupBox4.Controls.Add(this.politica_b);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.politica_A);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(18, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 116);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultados";
            // 
            // resultado_
            // 
            this.resultado_.AutoSize = true;
            this.resultado_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado_.Location = new System.Drawing.Point(187, 59);
            this.resultado_.Name = "resultado_";
            this.resultado_.Size = new System.Drawing.Size(64, 13);
            this.resultado_.TabIndex = 25;
            this.resultado_.Text = "Resultado";
            // 
            // politica_b
            // 
            this.politica_b.Enabled = true;
            this.politica_b.Location = new System.Drawing.Point(73, 77);
            this.politica_b.MaxLength = 6;
            this.politica_b.Name = "politica_b";
            this.politica_b.Size = new System.Drawing.Size(46, 20);
            this.politica_b.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Politica B";
            // 
            // politica_A
            // 
            this.politica_A.Enabled = true;
            this.politica_A.Location = new System.Drawing.Point(73, 39);
            this.politica_A.MaxLength = 6;
            this.politica_A.Name = "politica_A";
            this.politica_A.Size = new System.Drawing.Size(46, 20);
            this.politica_A.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Politica A";
            // 
            // groupBox5
            // 
            this.groupBox5.AccessibleDescription = "c";
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.grilla_politica_a);
            this.groupBox5.Location = new System.Drawing.Point(318, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(660, 245);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Politica A";
            // 
            // grilla_politica_a
            // 
            this.grilla_politica_a.AllowUserToAddRows = false;
            this.grilla_politica_a.AllowUserToDeleteRows = false;
            this.grilla_politica_a.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_politica_a.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dias,
            this.RND,
            this.CantDemandada,
            this.CantOrdenada,
            this.CantVendida,
            this.CantPerdida,
            this.Sobra,
            this.CostCompra,
            this.Reembolso,
            this.CosUtPer,
            this.CostoTotal,
            this.CostoAcumulado});
            this.grilla_politica_a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grilla_politica_a.Location = new System.Drawing.Point(3, 16);
            this.grilla_politica_a.Name = "grilla_politica_a";
            this.grilla_politica_a.ReadOnly = true;
            this.grilla_politica_a.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_politica_a.Size = new System.Drawing.Size(654, 226);
            this.grilla_politica_a.TabIndex = 0;
            this.grilla_politica_a.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.AccessibleDescription = "c";
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.grilla_politica_b);
            this.groupBox6.Location = new System.Drawing.Point(321, 265);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(660, 250);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Politica B";
            // 
            // grilla_politica_b
            // 
            this.grilla_politica_b.AllowUserToAddRows = false;
            this.grilla_politica_b.AllowUserToDeleteRows = false;
            this.grilla_politica_b.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_politica_b.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.RNDplb,
            this.CantDemplb,
            this.CantOrdplb,
            this.CantVendplb,
            this.CantPerplb,
            this.Sobraplb,
            this.COplb,
            this.Reemplb,
            this.CUPplb,
            this.Costotalplb,
            this.CosAc});
            this.grilla_politica_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grilla_politica_b.Location = new System.Drawing.Point(3, 16);
            this.grilla_politica_b.Name = "grilla_politica_b";
            this.grilla_politica_b.ReadOnly = true;
            this.grilla_politica_b.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_politica_b.Size = new System.Drawing.Size(654, 231);
            this.grilla_politica_b.TabIndex = 0;
            this.grilla_politica_b.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Dias";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // RNDplb
            // 
            this.RNDplb.HeaderText = "RND";
            this.RNDplb.Name = "RNDplb";
            this.RNDplb.ReadOnly = true;
            // 
            // CantDemplb
            // 
            this.CantDemplb.HeaderText = "Cant. Demandada";
            this.CantDemplb.Name = "CantDemplb";
            this.CantDemplb.ReadOnly = true;
            // 
            // CantOrdplb
            // 
            this.CantOrdplb.HeaderText = "Cant. Ordenada";
            this.CantOrdplb.Name = "CantOrdplb";
            this.CantOrdplb.ReadOnly = true;
            // 
            // CantVendplb
            // 
            this.CantVendplb.HeaderText = "Cant. Vendida";
            this.CantVendplb.Name = "CantVendplb";
            this.CantVendplb.ReadOnly = true;
            // 
            // CantPerplb
            // 
            this.CantPerplb.HeaderText = "Cant Perdida";
            this.CantPerplb.Name = "CantPerplb";
            this.CantPerplb.ReadOnly = true;
            // 
            // Sobraplb
            // 
            this.Sobraplb.HeaderText = "Sobra";
            this.Sobraplb.Name = "Sobraplb";
            this.Sobraplb.ReadOnly = true;
            // 
            // COplb
            // 
            this.COplb.HeaderText = "Costo Compra";
            this.COplb.Name = "COplb";
            this.COplb.ReadOnly = true;
            // 
            // Reemplb
            // 
            this.Reemplb.HeaderText = "Reembolso";
            this.Reemplb.Name = "Reemplb";
            this.Reemplb.ReadOnly = true;
            // 
            // CUPplb
            // 
            this.CUPplb.HeaderText = "CUP";
            this.CUPplb.Name = "CUPplb";
            this.CUPplb.ReadOnly = true;
            // 
            // Costotalplb
            // 
            this.Costotalplb.HeaderText = "Costo total";
            this.Costotalplb.Name = "Costotalplb";
            this.Costotalplb.ReadOnly = true;
            // 
            // CosAc
            // 
            this.CosAc.HeaderText = "Costo Ac";
            this.CosAc.Name = "CosAc";
            this.CosAc.ReadOnly = true;
            // 
            // Dias
            // 
            this.Dias.HeaderText = "Dias";
            this.Dias.Name = "Dias";
            this.Dias.ReadOnly = true;
            // 
            // RND
            // 
            this.RND.HeaderText = "RND";
            this.RND.Name = "RND";
            this.RND.ReadOnly = true;
            // 
            // CantDemandada
            // 
            this.CantDemandada.HeaderText = "Cant. Demandada";
            this.CantDemandada.Name = "CantDemandada";
            this.CantDemandada.ReadOnly = true;
            // 
            // CantOrdenada
            // 
            this.CantOrdenada.HeaderText = "Cant. Ordenada";
            this.CantOrdenada.Name = "CantOrdenada";
            this.CantOrdenada.ReadOnly = true;
            // 
            // CantVendida
            // 
            this.CantVendida.HeaderText = "Cant. Vendida";
            this.CantVendida.Name = "CantVendida";
            this.CantVendida.ReadOnly = true;
            // 
            // CantPerdida
            // 
            this.CantPerdida.HeaderText = "Cant. Perdida";
            this.CantPerdida.Name = "CantPerdida";
            this.CantPerdida.ReadOnly = true;
            // 
            // Sobra
            // 
            this.Sobra.HeaderText = "Sobra";
            this.Sobra.Name = "Sobra";
            this.Sobra.ReadOnly = true;
            // 
            // CostCompra
            // 
            this.CostCompra.HeaderText = "Costo Compra";
            this.CostCompra.Name = "CostCompra";
            this.CostCompra.ReadOnly = true;
            // 
            // Reembolso
            // 
            this.Reembolso.HeaderText = "Reembolso";
            this.Reembolso.Name = "Reembolso";
            this.Reembolso.ReadOnly = true;
            // 
            // CosUtPer
            // 
            this.CosUtPer.HeaderText = "C.U.P";
            this.CosUtPer.Name = "CosUtPer";
            this.CosUtPer.ReadOnly = true;
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "Costo Total";
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.ReadOnly = true;
            // 
            // CostoAcumulado
            // 
            this.CostoAcumulado.HeaderText = "Costo Ac";
            this.CostoAcumulado.Name = "CostoAcumulado";
            this.CostoAcumulado.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 674);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_politica_a)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_politica_b)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox prec_uti_perdida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precio_reemb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox precio_costo;
        private System.Windows.Forms.TextBox cant_generar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cant_perd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cant_demand;
        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label resultado_;
        private System.Windows.Forms.TextBox politica_b;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox politica_A;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView grilla_politica_a;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView grilla_politica_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantDemandada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantOrdenada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantPerdida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CosUtPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDplb;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantDemplb;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantOrdplb;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantVendplb;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantPerplb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobraplb;
        private System.Windows.Forms.DataGridViewTextBoxColumn COplb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reemplb;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUPplb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costotalplb;
        private System.Windows.Forms.DataGridViewTextBoxColumn CosAc;
    }
}

