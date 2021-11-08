
namespace P2Circunferencia.Windows
{
    partial class FrmListaCircunferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaCircunferencias));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.colorDeRellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorRellenoToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.colorDeBordeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.porRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AscendenteRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DescendenteRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colRadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColorRelleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColorBorde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDeRegistrosLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorBordeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.EditarToolStripButton,
            this.toolStripSeparator1,
            this.FiltrarToolStripButton,
            this.OrdenarToolStripButton,
            this.ActualizarToolStripButton,
            this.toolStripSeparator2,
            this.SalirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 58);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = global::P2Circunferencia.Windows.Properties.Resources.add_database_36px;
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 55);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = global::P2Circunferencia.Windows.Properties.Resources.delete_database_36px;
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 55);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = global::P2Circunferencia.Windows.Properties.Resources.database_administrator_36px;
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 55);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorDeRellenoToolStripMenuItem,
            this.colorDeBordeToolStripMenuItem});
            this.FiltrarToolStripButton.Image = global::P2Circunferencia.Windows.Properties.Resources.filter_36px;
            this.FiltrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(50, 55);
            this.FiltrarToolStripButton.Text = "Filtrar";
            this.FiltrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // colorDeRellenoToolStripMenuItem
            // 
            this.colorDeRellenoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorRellenoToolStripComboBox});
            this.colorDeRellenoToolStripMenuItem.Name = "colorDeRellenoToolStripMenuItem";
            this.colorDeRellenoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorDeRellenoToolStripMenuItem.Text = "Color de Relleno";
            // 
            // ColorRellenoToolStripComboBox
            // 
            this.ColorRellenoToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorRellenoToolStripComboBox.Name = "ColorRellenoToolStripComboBox";
            this.ColorRellenoToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.ColorRellenoToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorRellenoToolStripComboBox_SelectedIndexChanged);
            // 
            // colorDeBordeToolStripMenuItem
            // 
            this.colorDeBordeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorBordeToolStripComboBox});
            this.colorDeBordeToolStripMenuItem.Name = "colorDeBordeToolStripMenuItem";
            this.colorDeBordeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorDeBordeToolStripMenuItem.Text = "Color de Borde";
            // 
            // OrdenarToolStripButton
            // 
            this.OrdenarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porRadioToolStripMenuItem});
            this.OrdenarToolStripButton.Image = global::P2Circunferencia.Windows.Properties.Resources.sort_36px;
            this.OrdenarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripButton.Name = "OrdenarToolStripButton";
            this.OrdenarToolStripButton.Size = new System.Drawing.Size(63, 55);
            this.OrdenarToolStripButton.Text = "Ordenar";
            this.OrdenarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // porRadioToolStripMenuItem
            // 
            this.porRadioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AscendenteRadioToolStripMenuItem,
            this.DescendenteRadioToolStripMenuItem});
            this.porRadioToolStripMenuItem.Name = "porRadioToolStripMenuItem";
            this.porRadioToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.porRadioToolStripMenuItem.Text = "por Radio";
            // 
            // AscendenteRadioToolStripMenuItem
            // 
            this.AscendenteRadioToolStripMenuItem.Name = "AscendenteRadioToolStripMenuItem";
            this.AscendenteRadioToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.AscendenteRadioToolStripMenuItem.Text = "Ascendente";
            this.AscendenteRadioToolStripMenuItem.Click += new System.EventHandler(this.AscendenteRadioToolStripMenuItem_Click);
            // 
            // DescendenteRadioToolStripMenuItem
            // 
            this.DescendenteRadioToolStripMenuItem.Name = "DescendenteRadioToolStripMenuItem";
            this.DescendenteRadioToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.DescendenteRadioToolStripMenuItem.Text = "Descendente";
            this.DescendenteRadioToolStripMenuItem.Click += new System.EventHandler(this.DescendenteRadioToolStripMenuItem_Click);
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.Image = global::P2Circunferencia.Windows.Properties.Resources.available_updates_36px;
            this.ActualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton.Name = "ActualizarToolStripButton";
            this.ActualizarToolStripButton.Size = new System.Drawing.Size(63, 55);
            this.ActualizarToolStripButton.Text = "Actualizar";
            this.ActualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ActualizarToolStripButton.Click += new System.EventHandler(this.ActualizarToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = global::P2Circunferencia.Windows.Properties.Resources.close_pane_36px;
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(40, 55);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatosDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CantidadDeRegistrosLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(657, 332);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 1;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRadio,
            this.colArea,
            this.colPerimetro,
            this.colColorRelleno,
            this.colColorBorde});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(657, 268);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colRadio
            // 
            this.colRadio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRadio.HeaderText = "Radio";
            this.colRadio.Name = "colRadio";
            this.colRadio.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArea.HeaderText = "Área";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // colPerimetro
            // 
            this.colPerimetro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPerimetro.HeaderText = "Perímetro";
            this.colPerimetro.Name = "colPerimetro";
            this.colPerimetro.ReadOnly = true;
            // 
            // colColorRelleno
            // 
            this.colColorRelleno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colColorRelleno.HeaderText = "Color de Relleno";
            this.colColorRelleno.Name = "colColorRelleno";
            this.colColorRelleno.ReadOnly = true;
            // 
            // colColorBorde
            // 
            this.colColorBorde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colColorBorde.HeaderText = "Color de Borde";
            this.colColorBorde.Name = "colColorBorde";
            this.colColorBorde.ReadOnly = true;
            // 
            // CantidadDeRegistrosLabel
            // 
            this.CantidadDeRegistrosLabel.AutoSize = true;
            this.CantidadDeRegistrosLabel.Location = new System.Drawing.Point(146, 21);
            this.CantidadDeRegistrosLabel.Name = "CantidadDeRegistrosLabel";
            this.CantidadDeRegistrosLabel.Size = new System.Drawing.Size(13, 13);
            this.CantidadDeRegistrosLabel.TabIndex = 1;
            this.CantidadDeRegistrosLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Registros:";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // ColorBordeToolStripComboBox
            // 
            this.ColorBordeToolStripComboBox.Name = "ColorBordeToolStripComboBox";
            this.ColorBordeToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.ColorBordeToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorBordeToolStripComboBox_SelectedIndexChanged);
            // 
            // FrmListaCircunferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 390);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(673, 429);
            this.MinimumSize = new System.Drawing.Size(673, 429);
            this.Name = "FrmListaCircunferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circunferencias";
            this.Load += new System.EventHandler(this.FrmListaCircunferencias_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColorRelleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColorBorde;
        private System.Windows.Forms.Label CantidadDeRegistrosLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton FiltrarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem colorDeRellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDeBordeToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem porRadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AscendenteRadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DescendenteRadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ColorRellenoToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox ColorBordeToolStripComboBox;
    }
}