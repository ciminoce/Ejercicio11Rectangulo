
namespace Ejercicio11Cuadrado.Windows
{
    partial class FrmRectangulosEdit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LadoMayorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LadoMenorTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado Mayor:";
            // 
            // LadoMayorTextBox
            // 
            this.LadoMayorTextBox.Location = new System.Drawing.Point(120, 64);
            this.LadoMayorTextBox.Name = "LadoMayorTextBox";
            this.LadoMayorTextBox.Size = new System.Drawing.Size(100, 20);
            this.LadoMayorTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lado Menor:";
            // 
            // LadoMenorTextBox
            // 
            this.LadoMenorTextBox.Location = new System.Drawing.Point(120, 90);
            this.LadoMenorTextBox.Name = "LadoMenorTextBox";
            this.LadoMenorTextBox.Size = new System.Drawing.Size(100, 20);
            this.LadoMenorTextBox.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(13, 146);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(188, 146);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 2;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmRectangulosEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 222);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.LadoMenorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LadoMayorTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmRectangulosEdit";
            this.Text = "FrmRectangulosEdit";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LadoMayorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LadoMenorTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}