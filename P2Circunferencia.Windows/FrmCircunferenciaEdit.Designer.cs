
namespace P2Circunferencia.Windows
{
    partial class FrmCircunferenciaEdit
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.RadioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorBordeComboBox = new System.Windows.Forms.ComboBox();
            this.ColorRellenoComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Image = global::P2Circunferencia.Windows.Properties.Resources.ok_36px;
            this.OKButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OKButton.Location = new System.Drawing.Point(40, 128);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(60, 60);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarButton.Image = global::P2Circunferencia.Windows.Properties.Resources.cancel_36px;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CancelarButton.Location = new System.Drawing.Point(151, 128);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(60, 60);
            this.CancelarButton.TabIndex = 0;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // RadioTextBox
            // 
            this.RadioTextBox.Location = new System.Drawing.Point(115, 21);
            this.RadioTextBox.Name = "RadioTextBox";
            this.RadioTextBox.Size = new System.Drawing.Size(121, 20);
            this.RadioTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radio:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color de Borde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color de Relleno:";
            // 
            // ColorBordeComboBox
            // 
            this.ColorBordeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorBordeComboBox.FormattingEnabled = true;
            this.ColorBordeComboBox.Location = new System.Drawing.Point(115, 82);
            this.ColorBordeComboBox.Name = "ColorBordeComboBox";
            this.ColorBordeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorBordeComboBox.TabIndex = 4;
            // 
            // ColorRellenoComboBox
            // 
            this.ColorRellenoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorRellenoComboBox.FormattingEnabled = true;
            this.ColorRellenoComboBox.Location = new System.Drawing.Point(115, 54);
            this.ColorRellenoComboBox.Name = "ColorRellenoComboBox";
            this.ColorRellenoComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorRellenoComboBox.TabIndex = 4;
            // 
            // FrmCircunferenciaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 213);
            this.ControlBox = false;
            this.Controls.Add(this.ColorRellenoComboBox);
            this.Controls.Add(this.ColorBordeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadioTextBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.OKButton);
            this.MaximumSize = new System.Drawing.Size(273, 252);
            this.MinimumSize = new System.Drawing.Size(273, 252);
            this.Name = "FrmCircunferenciaEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCircunferenciaEdit";
            this.Load += new System.EventHandler(this.FrmCircunferenciaEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.TextBox RadioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox ColorRellenoComboBox;
        private System.Windows.Forms.ComboBox ColorBordeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}