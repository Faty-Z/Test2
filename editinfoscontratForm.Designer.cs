namespace Brouillon_Test
{
    partial class editinfoscontratForm
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
            this.LoadDoc = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.nom_projet = new System.Windows.Forms.TextBox();
            this.objectif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.partners = new System.Windows.Forms.ListBox();
            this.montant = new System.Windows.Forms.NumericUpDown();
            this.tfilename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.montant)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadDoc
            // 
            this.LoadDoc.Location = new System.Drawing.Point(92, 25);
            this.LoadDoc.Name = "LoadDoc";
            this.LoadDoc.Size = new System.Drawing.Size(303, 39);
            this.LoadDoc.TabIndex = 0;
            this.LoadDoc.Text = "LoadDoc";
            this.LoadDoc.UseVisualStyleBackColor = true;
            this.LoadDoc.Click += new System.EventHandler(this.LoadDoc_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(196, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 32);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // nom_projet
            // 
            this.nom_projet.Location = new System.Drawing.Point(69, 202);
            this.nom_projet.Name = "nom_projet";
            this.nom_projet.Size = new System.Drawing.Size(166, 20);
            this.nom_projet.TabIndex = 4;
            // 
            // objectif
            // 
            this.objectif.Location = new System.Drawing.Point(69, 285);
            this.objectif.Name = "objectif";
            this.objectif.Size = new System.Drawing.Size(166, 20);
            this.objectif.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "partners";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "nomProjet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "montant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "objectifs";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // partners
            // 
            this.partners.FormattingEnabled = true;
            this.partners.Location = new System.Drawing.Point(69, 126);
            this.partners.Name = "partners";
            this.partners.Size = new System.Drawing.Size(166, 56);
            this.partners.TabIndex = 10;
            // 
            // montant
            // 
            this.montant.Location = new System.Drawing.Point(69, 248);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(166, 20);
            this.montant.TabIndex = 11;
            // 
            // tfilename
            // 
            this.tfilename.Location = new System.Drawing.Point(92, 85);
            this.tfilename.Name = "tfilename";
            this.tfilename.Size = new System.Drawing.Size(303, 20);
            this.tfilename.TabIndex = 12;
            // 
            // editinfoscontratForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 390);
            this.Controls.Add(this.tfilename);
            this.Controls.Add(this.montant);
            this.Controls.Add(this.partners);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objectif);
            this.Controls.Add(this.nom_projet);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.LoadDoc);
            this.Name = "editinfoscontratForm";
            this.Text = "editinfoscontratForm";
            this.Load += new System.EventHandler(this.EditinfoscontratForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.montant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadDoc;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox nom_projet;
        private System.Windows.Forms.TextBox objectif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox partners;
        private System.Windows.Forms.NumericUpDown montant;
        private System.Windows.Forms.TextBox tfilename;
    }
}