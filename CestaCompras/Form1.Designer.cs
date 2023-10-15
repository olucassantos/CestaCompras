namespace CestaCompras
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvListaItens = new System.Windows.Forms.ListView();
            this.rdoCestaUm = new System.Windows.Forms.RadioButton();
            this.rdoCestaDois = new System.Windows.Forms.RadioButton();
            this.rdoCestaTres = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.rdoMontarCesta = new System.Windows.Forms.RadioButton();
            this.grpAdicionarItem = new System.Windows.Forms.GroupBox();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.grpAdicionarItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvListaItens
            // 
            this.lvListaItens.HideSelection = false;
            this.lvListaItens.Location = new System.Drawing.Point(470, 77);
            this.lvListaItens.Name = "lvListaItens";
            this.lvListaItens.Size = new System.Drawing.Size(454, 408);
            this.lvListaItens.TabIndex = 0;
            this.lvListaItens.UseCompatibleStateImageBehavior = false;
            // 
            // rdoCestaUm
            // 
            this.rdoCestaUm.AutoSize = true;
            this.rdoCestaUm.Location = new System.Drawing.Point(12, 77);
            this.rdoCestaUm.Name = "rdoCestaUm";
            this.rdoCestaUm.Size = new System.Drawing.Size(87, 20);
            this.rdoCestaUm.TabIndex = 1;
            this.rdoCestaUm.TabStop = true;
            this.rdoCestaUm.Text = "Cesta Um";
            this.rdoCestaUm.UseVisualStyleBackColor = true;
            this.rdoCestaUm.CheckedChanged += new System.EventHandler(this.rdoCestaUm_CheckedChanged);
            // 
            // rdoCestaDois
            // 
            this.rdoCestaDois.AutoSize = true;
            this.rdoCestaDois.Location = new System.Drawing.Point(12, 103);
            this.rdoCestaDois.Name = "rdoCestaDois";
            this.rdoCestaDois.Size = new System.Drawing.Size(94, 20);
            this.rdoCestaDois.TabIndex = 2;
            this.rdoCestaDois.TabStop = true;
            this.rdoCestaDois.Text = "Cesta Dois";
            this.rdoCestaDois.UseVisualStyleBackColor = true;
            this.rdoCestaDois.CheckedChanged += new System.EventHandler(this.rdoCestaDois_CheckedChanged);
            // 
            // rdoCestaTres
            // 
            this.rdoCestaTres.AutoSize = true;
            this.rdoCestaTres.Location = new System.Drawing.Point(12, 129);
            this.rdoCestaTres.Name = "rdoCestaTres";
            this.rdoCestaTres.Size = new System.Drawing.Size(94, 20);
            this.rdoCestaTres.TabIndex = 3;
            this.rdoCestaTres.TabStop = true;
            this.rdoCestaTres.Text = "Cesta Tres";
            this.rdoCestaTres.UseVisualStyleBackColor = true;
            this.rdoCestaTres.CheckedChanged += new System.EventHandler(this.rdoCestaTres_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(866, 500);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0,00";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(386, 491);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // rdoMontarCesta
            // 
            this.rdoMontarCesta.AutoSize = true;
            this.rdoMontarCesta.Location = new System.Drawing.Point(13, 156);
            this.rdoMontarCesta.Name = "rdoMontarCesta";
            this.rdoMontarCesta.Size = new System.Drawing.Size(107, 20);
            this.rdoMontarCesta.TabIndex = 7;
            this.rdoMontarCesta.TabStop = true;
            this.rdoMontarCesta.Text = "Montar Cesta";
            this.rdoMontarCesta.UseVisualStyleBackColor = true;
            this.rdoMontarCesta.CheckedChanged += new System.EventHandler(this.rdoMontarCesta_CheckedChanged);
            // 
            // grpAdicionarItem
            // 
            this.grpAdicionarItem.Controls.Add(this.ckbChocolate);
            this.grpAdicionarItem.Location = new System.Drawing.Point(13, 192);
            this.grpAdicionarItem.Name = "grpAdicionarItem";
            this.grpAdicionarItem.Size = new System.Drawing.Size(451, 293);
            this.grpAdicionarItem.TabIndex = 8;
            this.grpAdicionarItem.TabStop = false;
            this.grpAdicionarItem.Text = "groupBox1";
            this.grpAdicionarItem.Visible = false;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(7, 22);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(90, 20);
            this.ckbChocolate.TabIndex = 0;
            this.ckbChocolate.Text = "Chocolate";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            this.ckbChocolate.CheckedChanged += new System.EventHandler(this.ckbChocolate_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 544);
            this.Controls.Add(this.grpAdicionarItem);
            this.Controls.Add(this.rdoMontarCesta);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoCestaTres);
            this.Controls.Add(this.rdoCestaDois);
            this.Controls.Add(this.rdoCestaUm);
            this.Controls.Add(this.lvListaItens);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAdicionarItem.ResumeLayout(false);
            this.grpAdicionarItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvListaItens;
        private System.Windows.Forms.RadioButton rdoCestaUm;
        private System.Windows.Forms.RadioButton rdoCestaDois;
        private System.Windows.Forms.RadioButton rdoCestaTres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.RadioButton rdoMontarCesta;
        private System.Windows.Forms.GroupBox grpAdicionarItem;
        private System.Windows.Forms.CheckBox ckbChocolate;
    }
}

