
namespace Ejercicio11Cuadrado.Windows
{
    partial class FrmListaRectangulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colLadoMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadoMenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuperficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRegistrosLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraHerramientasToolStrip = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ladoMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MayorIgualLadoMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenorIgualLadoMayorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.IgualLadoMayorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.queToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ascendentePorLadoMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendentePorLadoMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendentePorSuperficieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.BarraHerramientasToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.CantidadRegistrosLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1086, 617);
            this.splitContainer1.SplitterDistance = 486;
            this.splitContainer1.TabIndex = 5;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.AllowUserToResizeColumns = false;
            this.DatosDataGridView.AllowUserToResizeRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLadoMayor,
            this.colLadoMenor,
            this.colSuperficie,
            this.colPerimetro});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(1086, 486);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colLadoMayor
            // 
            this.colLadoMayor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLadoMayor.HeaderText = "Lado Mayor";
            this.colLadoMayor.Name = "colLadoMayor";
            this.colLadoMayor.ReadOnly = true;
            // 
            // colLadoMenor
            // 
            this.colLadoMenor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLadoMenor.HeaderText = "Lado Menor";
            this.colLadoMenor.Name = "colLadoMenor";
            this.colLadoMenor.ReadOnly = true;
            // 
            // colSuperficie
            // 
            this.colSuperficie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSuperficie.HeaderText = "Superficie";
            this.colSuperficie.Name = "colSuperficie";
            this.colSuperficie.ReadOnly = true;
            // 
            // colPerimetro
            // 
            this.colPerimetro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPerimetro.HeaderText = "Perímetro";
            this.colPerimetro.Name = "colPerimetro";
            this.colPerimetro.ReadOnly = true;
            // 
            // CantidadRegistrosLabel
            // 
            this.CantidadRegistrosLabel.AutoSize = true;
            this.CantidadRegistrosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadRegistrosLabel.Location = new System.Drawing.Point(142, 25);
            this.CantidadRegistrosLabel.Name = "CantidadRegistrosLabel";
            this.CantidadRegistrosLabel.Size = new System.Drawing.Size(14, 13);
            this.CantidadRegistrosLabel.TabIndex = 0;
            this.CantidadRegistrosLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Registros:";
            // 
            // BarraHerramientasToolStrip
            // 
            this.BarraHerramientasToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.EditarToolStripButton,
            this.toolStripSeparator1,
            this.FiltrarToolStripButton,
            this.OrdenarToolStripButton,
            this.ActualizarToolStripButton,
            this.toolStripSeparator2,
            this.SalirToolStripButton});
            this.BarraHerramientasToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientasToolStrip.Name = "BarraHerramientasToolStrip";
            this.BarraHerramientasToolStrip.Size = new System.Drawing.Size(1086, 58);
            this.BarraHerramientasToolStrip.TabIndex = 4;
            this.BarraHerramientasToolStrip.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = global::Ejercicio11Cuadrado.Windows.Properties.Resources.add_file_36px;
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
            this.BorrarToolStripButton.Image = global::Ejercicio11Cuadrado.Windows.Properties.Resources.delete_file_36px;
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 55);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = global::Ejercicio11Cuadrado.Windows.Properties.Resources.create_36px;
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
            this.ladoMayorToolStripMenuItem});
            this.FiltrarToolStripButton.Image = global::Ejercicio11Cuadrado.Windows.Properties.Resources.conversion_36px;
            this.FiltrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(50, 55);
            this.FiltrarToolStripButton.Text = "Filtrar";
            this.FiltrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ladoMayorToolStripMenuItem
            // 
            this.ladoMayorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MayorIgualLadoMayorToolStripMenuItem,
            this.MenorIgualLadoMayorToolStripMenuItem1,
            this.IgualLadoMayorToolStripMenuItem2,
            this.queToolStripMenuItem3});
            this.ladoMayorToolStripMenuItem.Name = "ladoMayorToolStripMenuItem";
            this.ladoMayorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ladoMayorToolStripMenuItem.Text = "Lado Mayor";
            // 
            // MayorIgualLadoMayorToolStripMenuItem
            // 
            this.MayorIgualLadoMayorToolStripMenuItem.Name = "MayorIgualLadoMayorToolStripMenuItem";
            this.MayorIgualLadoMayorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MayorIgualLadoMayorToolStripMenuItem.Text = ">= Que";
            this.MayorIgualLadoMayorToolStripMenuItem.Click += new System.EventHandler(this.MayorIgualLadoMayorToolStripMenuItem_Click);
            // 
            // MenorIgualLadoMayorToolStripMenuItem1
            // 
            this.MenorIgualLadoMayorToolStripMenuItem1.Name = "MenorIgualLadoMayorToolStripMenuItem1";
            this.MenorIgualLadoMayorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.MenorIgualLadoMayorToolStripMenuItem1.Text = "<= Que";
            this.MenorIgualLadoMayorToolStripMenuItem1.Click += new System.EventHandler(this.MenorIgualLadoMayorToolStripMenuItem1_Click);
            // 
            // IgualLadoMayorToolStripMenuItem2
            // 
            this.IgualLadoMayorToolStripMenuItem2.Name = "IgualLadoMayorToolStripMenuItem2";
            this.IgualLadoMayorToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.IgualLadoMayorToolStripMenuItem2.Text = "= Que";
            this.IgualLadoMayorToolStripMenuItem2.Click += new System.EventHandler(this.IgualLadoMayorToolStripMenuItem2_Click);
            // 
            // queToolStripMenuItem3
            // 
            this.queToolStripMenuItem3.Name = "queToolStripMenuItem3";
            this.queToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.queToolStripMenuItem3.Text = "<> Que";
            // 
            // OrdenarToolStripButton
            // 
            this.OrdenarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendentePorLadoMayorToolStripMenuItem,
            this.descendentePorLadoMayorToolStripMenuItem,
            this.descendentePorSuperficieToolStripMenuItem});
            this.OrdenarToolStripButton.Image = global::Ejercicio11Cuadrado.Windows.Properties.Resources.up_down_arrow_36px;
            this.OrdenarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripButton.Name = "OrdenarToolStripButton";
            this.OrdenarToolStripButton.Size = new System.Drawing.Size(63, 55);
            this.OrdenarToolStripButton.Text = "Ordenar";
            this.OrdenarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ascendentePorLadoMayorToolStripMenuItem
            // 
            this.ascendentePorLadoMayorToolStripMenuItem.Image = global::Ejercicio11Cuadrado.Windows.Properties.Resources.numeric_24px;
            this.ascendentePorLadoMayorToolStripMenuItem.Name = "ascendentePorLadoMayorToolStripMenuItem";
            this.ascendentePorLadoMayorToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.ascendentePorLadoMayorToolStripMenuItem.Text = "Ascendente por Lado Mayor";
            this.ascendentePorLadoMayorToolStripMenuItem.Click += new System.EventHandler(this.ascendentePorLadoMayorToolStripMenuItem_Click);
            // 
            // descendentePorLadoMayorToolStripMenuItem
            // 
            this.descendentePorLadoMayorToolStripMenuItem.Image = global::Ejercicio11Cuadrado.Windows.Properties.Resources.reversed_numerical_sorting_24px;
            this.descendentePorLadoMayorToolStripMenuItem.Name = "descendentePorLadoMayorToolStripMenuItem";
            this.descendentePorLadoMayorToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.descendentePorLadoMayorToolStripMenuItem.Text = "Descendente por Lado Mayor";
            this.descendentePorLadoMayorToolStripMenuItem.Click += new System.EventHandler(this.descendentePorLadoMayorToolStripMenuItem_Click);
            // 
            // descendentePorSuperficieToolStripMenuItem
            // 
            this.descendentePorSuperficieToolStripMenuItem.Name = "descendentePorSuperficieToolStripMenuItem";
            this.descendentePorSuperficieToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.descendentePorSuperficieToolStripMenuItem.Text = "Descendente por Superficie";
            this.descendentePorSuperficieToolStripMenuItem.Click += new System.EventHandler(this.descendentePorSuperficieToolStripMenuItem_Click);
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.Image = global::Ejercicio11Cuadrado.Windows.Properties.Resources.restart_36px;
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
            this.SalirToolStripButton.Image = global::Ejercicio11Cuadrado.Windows.Properties.Resources.close_pane_36px;
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(40, 55);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // FrmListaRectangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 675);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.BarraHerramientasToolStrip);
            this.Name = "FrmListaRectangulos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmListaRectangulos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.BarraHerramientasToolStrip.ResumeLayout(false);
            this.BarraHerramientasToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Label CantidadRegistrosLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip BarraHerramientasToolStrip;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadoMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadoMenor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuperficie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerimetro;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem ascendentePorLadoMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendentePorLadoMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendentePorSuperficieToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton FiltrarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem ladoMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MayorIgualLadoMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenorIgualLadoMayorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem IgualLadoMayorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem queToolStripMenuItem3;
    }
}

