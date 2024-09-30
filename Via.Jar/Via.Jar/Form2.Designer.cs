namespace Via.Jar
{
    partial class Form2
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
            this.viaJarLogo = new System.Windows.Forms.PictureBox();
            this.listActions = new System.Windows.Forms.ListBox();
            this.nomePassageiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.destino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viajar = new System.Windows.Forms.Button();
            this.localizacao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.embarcar = new System.Windows.Forms.Button();
            this.desembarque = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viaJarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // viaJarLogo
            // 
            this.viaJarLogo.Image = global::Via.Jar.Properties.Resources.via_jar1;
            this.viaJarLogo.Location = new System.Drawing.Point(52, 34);
            this.viaJarLogo.Name = "viaJarLogo";
            this.viaJarLogo.Size = new System.Drawing.Size(233, 194);
            this.viaJarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viaJarLogo.TabIndex = 0;
            this.viaJarLogo.TabStop = false;
            // 
            // listActions
            // 
            this.listActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listActions.FormattingEnabled = true;
            this.listActions.ItemHeight = 24;
            this.listActions.Location = new System.Drawing.Point(52, 363);
            this.listActions.Name = "listActions";
            this.listActions.Size = new System.Drawing.Size(630, 196);
            this.listActions.TabIndex = 1;
            // 
            // nomePassageiro
            // 
            this.nomePassageiro.Location = new System.Drawing.Point(305, 176);
            this.nomePassageiro.Multiline = true;
            this.nomePassageiro.Name = "nomePassageiro";
            this.nomePassageiro.Size = new System.Drawing.Size(180, 52);
            this.nomePassageiro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 3;
            // 
            // destino
            // 
            this.destino.Location = new System.Drawing.Point(305, 60);
            this.destino.Multiline = true;
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(180, 52);
            this.destino.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destino:";
            // 
            // viajar
            // 
            this.viajar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viajar.Location = new System.Drawing.Point(514, 234);
            this.viajar.Name = "viajar";
            this.viajar.Size = new System.Drawing.Size(168, 52);
            this.viajar.TabIndex = 6;
            this.viajar.Text = "Viajar";
            this.viajar.UseVisualStyleBackColor = true;
            this.viajar.Click += new System.EventHandler(this.viajar_Click);
            // 
            // localizacao
            // 
            this.localizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localizacao.Location = new System.Drawing.Point(514, 60);
            this.localizacao.Name = "localizacao";
            this.localizacao.Size = new System.Drawing.Size(168, 52);
            this.localizacao.TabIndex = 7;
            this.localizacao.Text = "Localização";
            this.localizacao.UseVisualStyleBackColor = true;
            this.localizacao.Click += new System.EventHandler(this.localizacao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome do Passageiro:";
            // 
            // embarcar
            // 
            this.embarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.embarcar.Location = new System.Drawing.Point(514, 176);
            this.embarcar.Name = "embarcar";
            this.embarcar.Size = new System.Drawing.Size(168, 52);
            this.embarcar.TabIndex = 9;
            this.embarcar.Text = "Embarcar";
            this.embarcar.UseVisualStyleBackColor = true;
            this.embarcar.Click += new System.EventHandler(this.embarcar_Click);
            // 
            // desembarque
            // 
            this.desembarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desembarque.Location = new System.Drawing.Point(514, 292);
            this.desembarque.Name = "desembarque";
            this.desembarque.Size = new System.Drawing.Size(168, 52);
            this.desembarque.TabIndex = 10;
            this.desembarque.Text = "Desembarque";
            this.desembarque.UseVisualStyleBackColor = true;
            this.desembarque.Click += new System.EventHandler(this.desembarque_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 600);
            this.Controls.Add(this.desembarque);
            this.Controls.Add(this.embarcar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.localizacao);
            this.Controls.Add(this.viajar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomePassageiro);
            this.Controls.Add(this.listActions);
            this.Controls.Add(this.viaJarLogo);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viaJarLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox viaJarLogo;
        private System.Windows.Forms.ListBox listActions;
        private System.Windows.Forms.TextBox nomePassageiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox destino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viajar;
        private System.Windows.Forms.Button localizacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button embarcar;
        private System.Windows.Forms.Button desembarque;
    }
}