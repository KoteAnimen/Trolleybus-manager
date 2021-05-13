
namespace Trolleybus_manager
{
    partial class Trolleybusses
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bussesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bussesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageDataSet = new Trolleybus_manager.manageDataSet();
            this.троллейбусыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.троллейбусыTableAdapter = new Trolleybus_manager.manageDataSetTableAdapters.ТроллейбусыTableAdapter();
            this.tableAdapterManager = new Trolleybus_manager.manageDataSetTableAdapters.TableAdapterManager();
            this.bussesTableAdapter = new Trolleybus_manager.manageDataSetTableAdapters.BussesTableAdapter();
            this.AddTrolleybus = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeTrolleybus = new System.Windows.Forms.ToolStripMenuItem();
            this.DeteleTrolleybus = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowBusByPath = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowBusByFix = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowBusByCare = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowBusByInPath = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bussesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bussesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.троллейбусыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTrolleybus,
            this.ChangeTrolleybus,
            this.DeteleTrolleybus,
            this.ShowBusByPath,
            this.ShowBusByFix,
            this.ShowBusByCare,
            this.ShowBusByInPath,
            this.ShowAll});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // bussesDataGridView
            // 
            this.bussesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bussesDataGridView.AutoGenerateColumns = false;
            this.bussesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bussesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bussesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.bussesDataGridView.DataSource = this.bussesBindingSource;
            this.bussesDataGridView.Location = new System.Drawing.Point(12, 27);
            this.bussesDataGridView.Name = "bussesDataGridView";
            this.bussesDataGridView.Size = new System.Drawing.Size(846, 355);
            this.bussesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "НомерМаршрута";
            this.dataGridViewTextBoxColumn1.HeaderText = "НомерМаршрута";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Состояние";
            this.dataGridViewTextBoxColumn2.HeaderText = "Состояние";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ВремяОтправления";
            this.dataGridViewTextBoxColumn3.HeaderText = "ВремяОтправления";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "НачалоДвижения";
            this.dataGridViewTextBoxColumn4.HeaderText = "НачалоДвижения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "КонецДвижения";
            this.dataGridViewTextBoxColumn5.HeaderText = "КонецДвижения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Протяженность";
            this.dataGridViewTextBoxColumn6.HeaderText = "Протяженность";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bussesBindingSource
            // 
            this.bussesBindingSource.DataMember = "Busses";
            this.bussesBindingSource.DataSource = this.manageDataSet;
            // 
            // manageDataSet
            // 
            this.manageDataSet.DataSetName = "manageDataSet";
            this.manageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // троллейбусыBindingSource
            // 
            this.троллейбусыBindingSource.DataMember = "Троллейбусы";
            this.троллейбусыBindingSource.DataSource = this.manageDataSet;
            // 
            // троллейбусыTableAdapter
            // 
            this.троллейбусыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Trolleybus_manager.manageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.МаршрутыTableAdapter = null;
            this.tableAdapterManager.СправочникОстановокTableAdapter = null;
            this.tableAdapterManager.ТроллейбусыTableAdapter = this.троллейбусыTableAdapter;
            // 
            // bussesTableAdapter
            // 
            this.bussesTableAdapter.ClearBeforeFill = true;
            // 
            // AddTrolleybus
            // 
            this.AddTrolleybus.Name = "AddTrolleybus";
            this.AddTrolleybus.Size = new System.Drawing.Size(332, 22);
            this.AddTrolleybus.Text = "Добавить машину";
            // 
            // ChangeTrolleybus
            // 
            this.ChangeTrolleybus.Name = "ChangeTrolleybus";
            this.ChangeTrolleybus.Size = new System.Drawing.Size(332, 22);
            this.ChangeTrolleybus.Text = "Изменить информацию о машине";
            // 
            // DeteleTrolleybus
            // 
            this.DeteleTrolleybus.Name = "DeteleTrolleybus";
            this.DeteleTrolleybus.Size = new System.Drawing.Size(332, 22);
            this.DeteleTrolleybus.Text = "Удалить машину";
            // 
            // ShowBusByPath
            // 
            this.ShowBusByPath.Name = "ShowBusByPath";
            this.ShowBusByPath.Size = new System.Drawing.Size(332, 22);
            this.ShowBusByPath.Text = "Просмотр всех машин выбранного маршрута";
            // 
            // ShowBusByFix
            // 
            this.ShowBusByFix.Name = "ShowBusByFix";
            this.ShowBusByFix.Size = new System.Drawing.Size(332, 22);
            this.ShowBusByFix.Text = "Показать машины в ремонте";
            // 
            // ShowBusByCare
            // 
            this.ShowBusByCare.Name = "ShowBusByCare";
            this.ShowBusByCare.Size = new System.Drawing.Size(332, 22);
            this.ShowBusByCare.Text = "Показать обслуживаемые машины";
            // 
            // ShowBusByInPath
            // 
            this.ShowBusByInPath.Name = "ShowBusByInPath";
            this.ShowBusByInPath.Size = new System.Drawing.Size(332, 22);
            this.ShowBusByInPath.Text = "Показать машины в пути";
            // 
            // ShowAll
            // 
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(332, 22);
            this.ShowAll.Text = "Показать все";
            // 
            // Trolleybusses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 394);
            this.Controls.Add(this.bussesDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Trolleybusses";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Троллейбусы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Trolleybusses_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bussesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bussesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.троллейбусыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private manageDataSet manageDataSet;
        private System.Windows.Forms.BindingSource троллейбусыBindingSource;
        private manageDataSetTableAdapters.ТроллейбусыTableAdapter троллейбусыTableAdapter;
        private manageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bussesBindingSource;
        private manageDataSetTableAdapters.BussesTableAdapter bussesTableAdapter;
        private System.Windows.Forms.DataGridView bussesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripMenuItem AddTrolleybus;
        private System.Windows.Forms.ToolStripMenuItem ChangeTrolleybus;
        private System.Windows.Forms.ToolStripMenuItem DeteleTrolleybus;
        private System.Windows.Forms.ToolStripMenuItem ShowBusByPath;
        private System.Windows.Forms.ToolStripMenuItem ShowBusByFix;
        private System.Windows.Forms.ToolStripMenuItem ShowBusByCare;
        private System.Windows.Forms.ToolStripMenuItem ShowBusByInPath;
        private System.Windows.Forms.ToolStripMenuItem ShowAll;
    }
}