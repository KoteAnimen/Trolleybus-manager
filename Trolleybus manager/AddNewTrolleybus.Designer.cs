
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
            System.Windows.Forms.Label номерМаршрутаLabel;
            System.Windows.Forms.Label крышаLabel;
            System.Windows.Forms.Label времяОтправленияLabel;
            System.Windows.Forms.Label состояниеLabel;
            this.manageDataSet = new Trolleybus_manager.manageDataSet();
            this.троллейбусыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.троллейбусыTableAdapter = new Trolleybus_manager.manageDataSetTableAdapters.ТроллейбусыTableAdapter();
            this.tableAdapterManager = new Trolleybus_manager.manageDataSetTableAdapters.TableAdapterManager();
            this.номерМаршрутаTextBox = new System.Windows.Forms.TextBox();
            this.крышаTextBox = new System.Windows.Forms.TextBox();
            this.времяОтправленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.состояниеComboBox = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            номерМаршрутаLabel = new System.Windows.Forms.Label();
            крышаLabel = new System.Windows.Forms.Label();
            времяОтправленияLabel = new System.Windows.Forms.Label();
            состояниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.троллейбусыBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // номерМаршрутаLabel
            // 
            номерМаршрутаLabel.AutoSize = true;
            номерМаршрутаLabel.Location = new System.Drawing.Point(40, 15);
            номерМаршрутаLabel.Name = "номерМаршрутаLabel";
            номерМаршрутаLabel.Size = new System.Drawing.Size(170, 24);
            номерМаршрутаLabel.TabIndex = 1;
            номерМаршрутаLabel.Text = "Номер Маршрута:";
            // 
            // номерМаршрутаTextBox
            // 
            this.номерМаршрутаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.троллейбусыBindingSource, "НомерМаршрута", true));
            this.номерМаршрутаTextBox.Location = new System.Drawing.Point(216, 12);
            this.номерМаршрутаTextBox.Name = "номерМаршрутаTextBox";
            this.номерМаршрутаTextBox.Size = new System.Drawing.Size(230, 29);
            this.номерМаршрутаTextBox.TabIndex = 2;
            // 
            // крышаLabel
            // 
            крышаLabel.AutoSize = true;
            крышаLabel.Location = new System.Drawing.Point(135, 88);
            крышаLabel.Name = "крышаLabel";
            крышаLabel.Size = new System.Drawing.Size(75, 24);
            крышаLabel.TabIndex = 4;
            крышаLabel.Text = "Крыша:";
            // 
            // крышаTextBox
            // 
            this.крышаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.троллейбусыBindingSource, "Крыша", true));
            this.крышаTextBox.Location = new System.Drawing.Point(216, 85);
            this.крышаTextBox.Name = "крышаTextBox";
            this.крышаTextBox.Size = new System.Drawing.Size(230, 29);
            this.крышаTextBox.TabIndex = 5;
            // 
            // времяОтправленияLabel
            // 
            времяОтправленияLabel.AutoSize = true;
            времяОтправленияLabel.Location = new System.Drawing.Point(12, 124);
            времяОтправленияLabel.Name = "времяОтправленияLabel";
            времяОтправленияLabel.Size = new System.Drawing.Size(198, 24);
            времяОтправленияLabel.TabIndex = 6;
            времяОтправленияLabel.Text = "Время Отправления:";
            // 
            // времяОтправленияDateTimePicker
            // 
            this.времяОтправленияDateTimePicker.CustomFormat = "00:00";
            this.времяОтправленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.троллейбусыBindingSource, "ВремяОтправления", true));
            this.времяОтправленияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.времяОтправленияDateTimePicker.Location = new System.Drawing.Point(216, 120);
            this.времяОтправленияDateTimePicker.Name = "времяОтправленияDateTimePicker";
            this.времяОтправленияDateTimePicker.ShowUpDown = true;
            this.времяОтправленияDateTimePicker.Size = new System.Drawing.Size(230, 29);
            this.времяОтправленияDateTimePicker.TabIndex = 7;
            // 
            // состояниеLabel
            // 
            состояниеLabel.AutoSize = true;
            состояниеLabel.Location = new System.Drawing.Point(97, 50);
            состояниеLabel.Name = "состояниеLabel";
            состояниеLabel.Size = new System.Drawing.Size(113, 24);
            состояниеLabel.TabIndex = 7;
            состояниеLabel.Text = "Состояние:";
            // 
            // состояниеComboBox
            // 
            this.состояниеComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.троллейбусыBindingSource, "Состояние", true));
            this.состояниеComboBox.FormattingEnabled = true;
            this.состояниеComboBox.Location = new System.Drawing.Point(216, 47);
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
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(280, 186);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(166, 35);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // AddNewTrolleybus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 231);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(состояниеLabel);
            this.Controls.Add(this.состояниеComboBox);
            this.Controls.Add(времяОтправленияLabel);
            this.Controls.Add(this.времяОтправленияDateTimePicker);
            this.Controls.Add(крышаLabel);
            this.Controls.Add(this.крышаTextBox);
            this.Controls.Add(номерМаршрутаLabel);
            this.Controls.Add(this.номерМаршрутаTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddNewTrolleybus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить машину";
            this.Load += new System.EventHandler(this.AddNewTrolleybus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.троллейбусыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private manageDataSet manageDataSet;
        private System.Windows.Forms.BindingSource троллейбусыBindingSource;
        private manageDataSetTableAdapters.ТроллейбусыTableAdapter троллейбусыTableAdapter;
        private manageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox номерМаршрутаTextBox;
        private System.Windows.Forms.TextBox крышаTextBox;
        private System.Windows.Forms.DateTimePicker времяОтправленияDateTimePicker;
        private System.Windows.Forms.ComboBox состояниеComboBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
    }
}