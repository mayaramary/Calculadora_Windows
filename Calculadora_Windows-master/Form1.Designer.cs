namespace Calculadora_Windows
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
            this.display = new System.Windows.Forms.TextBox();
            this.bsete = new System.Windows.Forms.Button();
            this.boito = new System.Windows.Forms.Button();
            this.bnove = new System.Windows.Forms.Button();
            this.bquatro = new System.Windows.Forms.Button();
            this.bcinco = new System.Windows.Forms.Button();
            this.bseis = new System.Windows.Forms.Button();
            this.bum = new System.Windows.Forms.Button();
            this.bdois = new System.Windows.Forms.Button();
            this.btres = new System.Windows.Forms.Button();
            this.bdivisao = new System.Windows.Forms.Button();
            this.bmultiplicacao = new System.Windows.Forms.Button();
            this.bsubtracao = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.bzero = new System.Windows.Forms.Button();
            this.bvirgula = new System.Windows.Forms.Button();
            this.bsoma = new System.Windows.Forms.Button();
            this.bigual = new System.Windows.Forms.Button();
            this.blimpa = new System.Windows.Forms.Button();
            this.braiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.Color.Black;
            this.display.Location = new System.Drawing.Point(75, 84);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(423, 52);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bsete
            // 
            this.bsete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsete.ForeColor = System.Drawing.Color.LightCoral;
            this.bsete.Location = new System.Drawing.Point(86, 189);
            this.bsete.Name = "bsete";
            this.bsete.Size = new System.Drawing.Size(53, 33);
            this.bsete.TabIndex = 6;
            this.bsete.Text = "7";
            this.bsete.UseVisualStyleBackColor = true;
            this.bsete.Click += new System.EventHandler(this.bsete_Click);
            // 
            // boito
            // 
            this.boito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boito.ForeColor = System.Drawing.Color.LightCoral;
            this.boito.Location = new System.Drawing.Point(170, 190);
            this.boito.Name = "boito";
            this.boito.Size = new System.Drawing.Size(55, 33);
            this.boito.TabIndex = 7;
            this.boito.Text = "8";
            this.boito.UseVisualStyleBackColor = true;
            this.boito.Click += new System.EventHandler(this.boito_Click);
            // 
            // bnove
            // 
            this.bnove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnove.ForeColor = System.Drawing.Color.LightCoral;
            this.bnove.Location = new System.Drawing.Point(257, 190);
            this.bnove.Name = "bnove";
            this.bnove.Size = new System.Drawing.Size(52, 33);
            this.bnove.TabIndex = 8;
            this.bnove.Text = "9";
            this.bnove.UseVisualStyleBackColor = true;
            this.bnove.Click += new System.EventHandler(this.bnove_Click);
            // 
            // bquatro
            // 
            this.bquatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bquatro.ForeColor = System.Drawing.Color.LightCoral;
            this.bquatro.Location = new System.Drawing.Point(85, 244);
            this.bquatro.Name = "bquatro";
            this.bquatro.Size = new System.Drawing.Size(53, 33);
            this.bquatro.TabIndex = 9;
            this.bquatro.Text = "4";
            this.bquatro.UseVisualStyleBackColor = true;
            this.bquatro.Click += new System.EventHandler(this.bquatro_Click);
            // 
            // bcinco
            // 
            this.bcinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcinco.ForeColor = System.Drawing.Color.LightCoral;
            this.bcinco.Location = new System.Drawing.Point(170, 245);
            this.bcinco.Name = "bcinco";
            this.bcinco.Size = new System.Drawing.Size(55, 33);
            this.bcinco.TabIndex = 10;
            this.bcinco.Text = "5";
            this.bcinco.UseVisualStyleBackColor = true;
            this.bcinco.Click += new System.EventHandler(this.bcinco_Click);
            // 
            // bseis
            // 
            this.bseis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bseis.ForeColor = System.Drawing.Color.LightCoral;
            this.bseis.Location = new System.Drawing.Point(256, 245);
            this.bseis.Name = "bseis";
            this.bseis.Size = new System.Drawing.Size(53, 33);
            this.bseis.TabIndex = 11;
            this.bseis.Text = "6";
            this.bseis.UseVisualStyleBackColor = true;
            this.bseis.Click += new System.EventHandler(this.bseis_Click);
            // 
            // bum
            // 
            this.bum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bum.ForeColor = System.Drawing.Color.LightCoral;
            this.bum.Location = new System.Drawing.Point(85, 298);
            this.bum.Name = "bum";
            this.bum.Size = new System.Drawing.Size(53, 33);
            this.bum.TabIndex = 12;
            this.bum.Text = "1";
            this.bum.UseVisualStyleBackColor = true;
            this.bum.Click += new System.EventHandler(this.bum_Click);
            // 
            // bdois
            // 
            this.bdois.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdois.ForeColor = System.Drawing.Color.LightCoral;
            this.bdois.Location = new System.Drawing.Point(170, 298);
            this.bdois.Name = "bdois";
            this.bdois.Size = new System.Drawing.Size(55, 33);
            this.bdois.TabIndex = 13;
            this.bdois.Text = "2";
            this.bdois.UseVisualStyleBackColor = true;
            this.bdois.Click += new System.EventHandler(this.bdois_Click);
            // 
            // btres
            // 
            this.btres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btres.ForeColor = System.Drawing.Color.LightCoral;
            this.btres.Location = new System.Drawing.Point(256, 299);
            this.btres.Name = "btres";
            this.btres.Size = new System.Drawing.Size(53, 33);
            this.btres.TabIndex = 14;
            this.btres.Text = "3";
            this.btres.UseVisualStyleBackColor = true;
            this.btres.Click += new System.EventHandler(this.btres_Click);
            // 
            // bdivisao
            // 
            this.bdivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdivisao.ForeColor = System.Drawing.Color.SteelBlue;
            this.bdivisao.Location = new System.Drawing.Point(347, 189);
            this.bdivisao.Name = "bdivisao";
            this.bdivisao.Size = new System.Drawing.Size(61, 33);
            this.bdivisao.TabIndex = 15;
            this.bdivisao.Text = "/";
            this.bdivisao.UseVisualStyleBackColor = true;
            this.bdivisao.Click += new System.EventHandler(this.bdivisao_Click);
            // 
            // bmultiplicacao
            // 
            this.bmultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmultiplicacao.ForeColor = System.Drawing.Color.SteelBlue;
            this.bmultiplicacao.Location = new System.Drawing.Point(347, 244);
            this.bmultiplicacao.Name = "bmultiplicacao";
            this.bmultiplicacao.Size = new System.Drawing.Size(61, 33);
            this.bmultiplicacao.TabIndex = 16;
            this.bmultiplicacao.Text = "*";
            this.bmultiplicacao.UseVisualStyleBackColor = true;
            this.bmultiplicacao.Click += new System.EventHandler(this.bmultiplicacao_Click);
            // 
            // bsubtracao
            // 
            this.bsubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsubtracao.ForeColor = System.Drawing.Color.SteelBlue;
            this.bsubtracao.Location = new System.Drawing.Point(347, 298);
            this.bsubtracao.Name = "bsubtracao";
            this.bsubtracao.Size = new System.Drawing.Size(61, 34);
            this.bsubtracao.TabIndex = 17;
            this.bsubtracao.Text = "-";
            this.bsubtracao.UseVisualStyleBackColor = true;
            this.bsubtracao.Click += new System.EventHandler(this.bsubtracao_Click);
            // 
            // b
            // 
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(85, 357);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(52, 30);
            this.b.TabIndex = 18;
            this.b.UseVisualStyleBackColor = true;
            // 
            // bzero
            // 
            this.bzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bzero.ForeColor = System.Drawing.Color.LightCoral;
            this.bzero.Location = new System.Drawing.Point(170, 357);
            this.bzero.Name = "bzero";
            this.bzero.Size = new System.Drawing.Size(54, 30);
            this.bzero.TabIndex = 19;
            this.bzero.Text = "0";
            this.bzero.UseVisualStyleBackColor = true;
            this.bzero.Click += new System.EventHandler(this.bzero_Click);
            // 
            // bvirgula
            // 
            this.bvirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvirgula.ForeColor = System.Drawing.Color.SteelBlue;
            this.bvirgula.Location = new System.Drawing.Point(257, 357);
            this.bvirgula.Name = "bvirgula";
            this.bvirgula.Size = new System.Drawing.Size(52, 30);
            this.bvirgula.TabIndex = 20;
            this.bvirgula.Text = ",";
            this.bvirgula.UseVisualStyleBackColor = true;
            this.bvirgula.Click += new System.EventHandler(this.bvirgula_Click);
            // 
            // bsoma
            // 
            this.bsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsoma.ForeColor = System.Drawing.Color.SteelBlue;
            this.bsoma.Location = new System.Drawing.Point(347, 357);
            this.bsoma.Name = "bsoma";
            this.bsoma.Size = new System.Drawing.Size(61, 30);
            this.bsoma.TabIndex = 21;
            this.bsoma.Text = "+";
            this.bsoma.UseVisualStyleBackColor = true;
            this.bsoma.Click += new System.EventHandler(this.bsoma_Click);
            // 
            // bigual
            // 
            this.bigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigual.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.bigual.Location = new System.Drawing.Point(440, 304);
            this.bigual.Name = "bigual";
            this.bigual.Size = new System.Drawing.Size(57, 84);
            this.bigual.TabIndex = 22;
            this.bigual.Text = "=";
            this.bigual.UseVisualStyleBackColor = true;
            this.bigual.Click += new System.EventHandler(this.bigual_Click);
            // 
            // blimpa
            // 
            this.blimpa.BackColor = System.Drawing.Color.Transparent;
            this.blimpa.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blimpa.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.blimpa.Location = new System.Drawing.Point(441, 189);
            this.blimpa.Name = "blimpa";
            this.blimpa.Size = new System.Drawing.Size(54, 46);
            this.blimpa.TabIndex = 23;
            this.blimpa.Text = "C";
            this.blimpa.UseVisualStyleBackColor = false;
            this.blimpa.Click += new System.EventHandler(this.blimpa_Click);
            // 
            // braiz
            // 
            this.braiz.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braiz.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.braiz.Location = new System.Drawing.Point(441, 249);
            this.braiz.Name = "braiz";
            this.braiz.Size = new System.Drawing.Size(54, 43);
            this.braiz.TabIndex = 24;
            this.braiz.Text = "Sqrt";
            this.braiz.UseVisualStyleBackColor = true;
            this.braiz.Click += new System.EventHandler(this.braiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(555, 449);
            this.Controls.Add(this.braiz);
            this.Controls.Add(this.blimpa);
            this.Controls.Add(this.bigual);
            this.Controls.Add(this.bsoma);
            this.Controls.Add(this.bvirgula);
            this.Controls.Add(this.bzero);
            this.Controls.Add(this.b);
            this.Controls.Add(this.bsubtracao);
            this.Controls.Add(this.bmultiplicacao);
            this.Controls.Add(this.bdivisao);
            this.Controls.Add(this.btres);
            this.Controls.Add(this.bdois);
            this.Controls.Add(this.bum);
            this.Controls.Add(this.bseis);
            this.Controls.Add(this.bcinco);
            this.Controls.Add(this.bquatro);
            this.Controls.Add(this.bnove);
            this.Controls.Add(this.boito);
            this.Controls.Add(this.bsete);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button bsete;
        private System.Windows.Forms.Button boito;
        private System.Windows.Forms.Button bnove;
        private System.Windows.Forms.Button bquatro;
        private System.Windows.Forms.Button bcinco;
        private System.Windows.Forms.Button bseis;
        private System.Windows.Forms.Button bum;
        private System.Windows.Forms.Button bdois;
        private System.Windows.Forms.Button btres;
        private System.Windows.Forms.Button bdivisao;
        private System.Windows.Forms.Button bmultiplicacao;
        private System.Windows.Forms.Button bsubtracao;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button bzero;
        private System.Windows.Forms.Button bvirgula;
        private System.Windows.Forms.Button bsoma;
        private System.Windows.Forms.Button bigual;
        private System.Windows.Forms.Button blimpa;
        private System.Windows.Forms.Button braiz;
    }
}

