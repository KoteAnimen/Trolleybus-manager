
namespace Trolleybus_manager
{
    partial class ChoiceBus
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
            System.Windows.Forms.Label номерМаршрутаLabel;
            this.manageDataSet = new Trolleybus_manager.manageDataSet();
            this.троллейбусыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.троллейбусыTableAdapter = new Trolleybus_manager.manageDataSetTableAdapters.ТроллейбусыTableAdapter();
            this.tableAdapterManager = new Trolleybus_manager.manageDataSetTableAdapters.TableAdapterManager();
            this.маршрутыTableAdapter = new Trolleybus_manager.manageDataSetTableAdapters.МаршрутыTableAdapter();
            this.номерМаршрутаComboBox = new System.Windows.Forms.ComboBox();
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Choice = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            номерМаршрутаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.троллейбусыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номерМаршрутаLabel
            // 
            номерМаршрутаLabel.AutoSize = true;
            номерМаршрутаLabel.Location = new System.Drawing.Point(12, 9);
            номерМаршрутаLabel.Name = "номерМаршрутаLabel";
            номерМаршрутаLabel.Size = new System.Drawing.Size(170, 24);
            номерМаршрутаLabel.TabIndex = 1;
            номерМаршрутаLabel.Text = "Номер Маршрута:";
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
            this.tableAdapterManager.МаршрутыTableAdapter = this.маршрутыTableAdapter;
            this.tableAdapterManager.СправочникОстановок1TableAdapter = null;
            this.tableAdapterManager.СправочникОстановок2TableAdapter = null;
            this.tableAdapterManager.СправочникОстановокTableAdapter = null;
            this.tableAdapterManager.ТроллейбусыTableAdapter = this.троллейбусыTableAdapter;
            // 
            // маршрутыTableAdapter
            // 
            this.маршрутыTableAdapter.ClearBeforeFill = true;
            // 
            // номерМаршрутаComboBox
            // 
            this.номерМаршрутаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.троллейбусыBindingSource, "НомерМаршрута", true));
            this.номерМаршрутаComboBox.DataSource = this.маршрутыBindingSource;
            this.номерМаршрутаComboBox.DisplayMember = "НомерМаршрута";
            this.номерМаршрутаComboBox.FormattingEnabled = true;
            this.номерМаршрутаComboBox.Location = new System.Drawing.Point(16, 36);
            this.номерМаршрутаComboBox.Name = "номерМаршрутаComboBox";
            this.номерМаршрутаComboBox.Size = new System.Drawing.Size(340, 32);
            this.номерМаршрутаComboBox.TabIndex = 2;
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataMember = "Маршруты";
            this.маршрутыBindingSource.DataSource = this.manageDataSet;
            // 
            // Choice
            // 
            this.Choice.Location = new System.Drawing.Point(16, 98);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(150, 35);
            this.Choice.TabIndex = 3;
            this.Choice.Text = "Выбор";
            this.Choice.UseVisualStyleBackColor = true;
            this.Choice.Click += new System.EventHandler(this.Choice_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(206, 98);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(150, 35);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ChoiceBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 143);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Choice);
            this.Controls.Add(номерМаршрутаLabel);
            this.Controls.Add(this.номерМаршрутаComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChoiceBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор троллейбуса";
            this.Load += new System.EventHandler(this.ChoiceBus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.троллейбусыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private manageDataSet manageDataSet;
        private System.Windows.Forms.BindingSource троллейбусыBindingSource;
        private manageDataSetTableAdapters.ТроллейбусыTableAdapter троллейбусыTableAdapter;
        private manageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox номерМаршрутаComboBox;
        private System.Windows.Forms.Button Choice;
        private System.Windows.Forms.Button Cancel;
        private manageDataSetTableAdapters.МаршрутыTableAdapter маршрутыTableAdapter;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
    }
}