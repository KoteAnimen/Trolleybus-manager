
namespace Trolleybus_manager
{
    partial class AddNewTrolleybus
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
            System.Windows.Forms.Label времяОтправленияLabel;
            System.Windows.Forms.Label состояниеLabel;
            System.Windows.Forms.Label номерТроллейбусаLabel;
            System.Windows.Forms.Label номерМаршрутаLabel;
            this.manageDataSet = new Trolleybus_manager.manageDataSet();
            this.троллейбусыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.троллейбусыTableAdapter = new Trolleybus_manager.manageDataSetTableAdapters.ТроллейбусыTableAdapter();
            this.tableAdapterManager = new Trolleybus_manager.manageDataSetTableAdapters.TableAdapterManager();
            this.времяОтправленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.состояниеComboBox = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.номерТроллейбусаTextBox = new System.Windows.Forms.TextBox();
            this.номерМаршрутаComboBox = new System.Windows.Forms.ComboBox();
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутыTableAdapter = new Trolleybus_manager.manageDataSetTableAdapters.МаршрутыTableAdapter();
            времяОтправленияLabel = new System.Windows.Forms.Label();
            состояниеLabel = new System.Windows.Forms.Label();
            номерТроллейбусаLabel = new System.Windows.Forms.Label();
            номерМаршрутаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.троллейбусыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // времяОтправленияLabel
            // 
            времяОтправленияLabel.AutoSize = true;
            времяОтправленияLabel.Location = new System.Drawing.Point(12, 128);
            времяОтправленияLabel.Name = "времяОтправленияLabel";
            времяОтправленияLabel.Size = new System.Drawing.Size(198, 24);
            времяОтправленияLabel.TabIndex = 6;
            времяОтправленияLabel.Text = "Время Отправления:";
            // 
            // состояниеLabel
            // 
            состояниеLabel.AutoSize = true;
            состояниеLabel.Location = new System.Drawing.Point(97, 88);
            состояниеLabel.Name = "состояниеLabel";
            состояниеLabel.Size = new System.Drawing.Size(113, 24);
            состояниеLabel.TabIndex = 7;
            состояниеLabel.Text = "Состояние:";
            // 
            // номерТроллейбусаLabel
            // 
            номерТроллейбусаLabel.AutoSize = true;
            номерТроллейбусаLabel.Location = new System.Drawing.Point(15, 15);
            номерТроллейбусаLabel.Name = "номерТроллейбусаLabel";
            номерТроллейбусаLabel.Size = new System.Drawing.Size(195, 24);
            номерТроллейбусаLabel.TabIndex = 10;
            номерТроллейбусаLabel.Text = "Номер Троллейбуса:";
            // 
            // номерМаршрутаLabel
            // 
            номерМаршрутаLabel.AutoSize = true;
            номерМаршрутаLabel.Location = new System.Drawing.Point(40, 50);
            номерМаршрутаLabel.Name = "номерМаршрутаLabel";
            номерМаршрутаLabel.Size = new System.Drawing.Size(170, 24);
            номерМаршрутаLabel.TabIndex = 11;
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
            this.tableAdapterManager.МаршрутыTableAdapter = null;
            this.tableAdapterManager.СправочникОстановок1TableAdapter = null;
            this.tableAdapterManager.СправочникОстановок2TableAdapter = null;
            this.tableAdapterManager.СправочникОстановокTableAdapter = null;
            this.tableAdapterManager.ТроллейбусыTableAdapter = this.троллейбусыTableAdapter;
            // 
            // времяОтправленияDateTimePicker
            // 
            this.времяОтправленияDateTimePicker.CustomFormat = "HH:mm";
            this.времяОтправленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.троллейбусыBindingSource, "ВремяОтправления", true));
            this.времяОтправленияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.времяОтправленияDateTimePicker.Location = new System.Drawing.Point(216, 124);
            this.времяОтправленияDateTimePicker.Name = "времяОтправленияDateTimePicker";
            this.времяОтправленияDateTimePicker.ShowUpDown = true;
            this.времяОтправленияDateTimePicker.Size = new System.Drawing.Size(230, 29);
            this.времяОтправленияDateTimePicker.TabIndex = 7;
            // 
            // состояниеComboBox
            // 
            this.состояниеComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.троллейбусыBindingSource, "Состояние", true));
            this.состояниеComboBox.FormattingEnabled = true;
            this.состояниеComboBox.Items.AddRange(new object[] {
            "В пути",
            "Обслуживается",
            "В ремонте"});
            this.состояниеComboBox.Location = new System.Drawing.Point(216, 85);
            this.состояниеComboBox.Name = "состояниеComboBox";
            this.состояниеComboBox.Size = new System.Drawing.Size(230, 32);
            this.состояниеComboBox.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(16, 186);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(166, 35);
            this.Add.TabIndex = 9;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(280, 186);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(166, 35);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // номерТроллейбусаTextBox
            // 
            this.номерТроллейбусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.троллейбусыBindingSource, "НомерТроллейбуса", true));
            this.номерТроллейбусаTextBox.Location = new System.Drawing.Point(216, 12);
            this.номерТроллейбусаTextBox.Name = "номерТроллейбусаTextBox";
            this.номерТроллейбусаTextBox.Size = new System.Drawing.Size(230, 29);
            this.номерТроллейбусаTextBox.TabIndex = 11;
            // 
            // номерМаршрутаComboBox
            // 
            this.номерМаршрутаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.троллейбусыBindingSource, "НомерМаршрута", true));
            this.номерМаршрутаComboBox.DataSource = this.маршрутыBindingSource;
            this.номерМаршрутаComboBox.DisplayMember = "НомерМаршрута";
            this.номерМаршрутаComboBox.FormattingEnabled = true;
            this.номерМаршрутаComboBox.Location = new System.Drawing.Point(216, 47);
            this.номерМаршрутаComboBox.Name = "номерМаршрутаComboBox";
            this.номерМаршрутаComboBox.Size = new System.Drawing.Size(230, 32);
            this.номерМаршрутаComboBox.TabIndex = 12;
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataMember = "Маршруты";
            this.маршрутыBindingSource.DataSource = this.manageDataSet;
            // 
            // маршрутыTableAdapter
            // 
            this.маршрутыTableAdapter.ClearBeforeFill = true;
            // 
            // AddNewTrolleybus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 241);
            this.ControlBox = false;
            this.Controls.Add(номерМаршрутаLabel);
            this.Controls.Add(this.номерМаршрутаComboBox);
            this.Controls.Add(номерТроллейбусаLabel);
            this.Controls.Add(this.номерТроллейбусаTextBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(состояниеLabel);
            this.Controls.Add(this.состояниеComboBox);
            this.Controls.Add(времяОтправленияLabel);
            this.Controls.Add(this.времяОтправленияDateTimePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddNewTrolleybus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить машину";
            this.Load += new System.EventHandler(this.AddNewTrolleybus_Load);
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
        private System.Windows.Forms.DateTimePicker времяОтправленияDateTimePicker;
        private System.Windows.Forms.ComboBox состояниеComboBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox номерТроллейбусаTextBox;
        private System.Windows.Forms.ComboBox номерМаршрутаComboBox;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        private manageDataSetTableAdapters.МаршрутыTableAdapter маршрутыTableAdapter;
    }
}