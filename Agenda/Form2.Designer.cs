namespace Agenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbExibir = new System.Windows.Forms.ComboBox();
            this.lbView = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o nome da pessoa";
            // 
            // cbbExibir
            // 
            this.cbbExibir.FormattingEnabled = true;
            this.cbbExibir.Location = new System.Drawing.Point(86, 109);
            this.cbbExibir.Name = "cbbExibir";
            this.cbbExibir.Size = new System.Drawing.Size(121, 21);
            this.cbbExibir.TabIndex = 1;
            this.cbbExibir.Text = "Selecionar";
            this.cbbExibir.SelectedIndexChanged += new System.EventHandler(this.cbbExibir_SelectedIndexChanged);
            // 
            // lbView
            // 
            this.lbView.FormattingEnabled = true;
            this.lbView.Location = new System.Drawing.Point(12, 188);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(262, 95);
            this.lbView.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(108, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbView);
            this.Controls.Add(this.cbbExibir);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbExibir;
        private System.Windows.Forms.ListBox lbView;
        private System.Windows.Forms.Button btnDelete;
    }
}