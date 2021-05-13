
namespace Trolleybus_manager
{
    partial class ChangePath
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
            System.Windows.Forms.Label протяженностьLabel;
            System.Windows.Forms.Label времяLabel;
            System.Windows.Forms.Label началоДвиженияLabel;
            System.Windows.Forms.Label конецДвиженияLabel;
            System.Windows.Forms.Label числоМашинLabel;
            System.Windows.Forms.Label числоОстановокLabel;
            this.manageDataSet = new Trolleybus_manager.manageDataSet();
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутыTableAdapter = new Trolleybus_manager.manageDataSetTableAdapters.МаршрутыTableAdapter();
            this.tableAdapterManager = new Trolleybus_manager.manageDataSetTableAdapters.TableAdapterManager();
            this.справочникОстановокTableAdapter = new Trolleybus_manager.manageDataSetTableAdapters.СправочникОстановокTableAdapter();
            this.номерМаршрутаTextBox = new System.Windows.Forms.TextBox();
            this.протяженностьNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.времяDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.началоДвиженияComboBox = new System.Windows.Forms.ComboBox();
            this.справочникОстановокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.конецДвиженияComboBox = new System.Windows.Forms.ComboBox();
            this.числоМашинNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.числоОстановокNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Change = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            номерМаршрутаLabel = new System.Windows.Forms.Label();
            протяженностьLabel = new System.Windows.Forms.Label();
            времяLabel = new System.Windows.Forms.Label();
            началоДвиженияLabel = new System.Windows.Forms.Label();
            конецДвиженияLabel = new System.Windows.Forms.Label();
            числоМашинLabel = new System.Windows.Forms.Label();
            числоОстановокLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.протяженностьNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникОстановокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.числоМашинNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.числоОстановокNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // номерМаршрутаLabel
            // 
            номерМаршрутаLabel.AutoSize = true;
            номерМаршрутаLabel.Location = new System.Drawing.Point(30, 41);
            номерМаршрутаLabel.Name = "номерМаршрутаLabel";
            номерМаршрутаLabel.Size = new System.Drawing.Size(170, 24);
            номерМаршрутаLabel.TabIndex = 1;
            номерМаршрутаLabel.Text = "Номер Маршрута:";
            // 
            // протяженностьLabel
            // 
            протяженностьLabel.AutoSize = true;
            протяженностьLabel.Location = new System.Drawing.Point(41, 73);
            протяженностьLabel.Name = "протяженностьLabel";
            протяженностьLabel.Size = new System.Drawing.Size(159, 24);
            протяженностьLabel.TabIndex = 2;
            протяженностьLabel.Text = "Протяженность:";
            // 
            // времяLabel
            // 
            времяLabel.AutoSize = true;
            времяLabel.Location = new System.Drawing.Point(128, 112);
            времяLabel.Name = "времяLabel";
            времяLabel.Size = new System.Drawing.Size(72, 24);
            времяLabel.TabIndex = 4;
            времяLabel.Text = "Время:";
            // 
            // началоДвиженияLabel
            // 
            началоДвиженияLabel.AutoSize = true;
            началоДвиженияLabel.Location = new System.Drawing.Point(23, 181);
            началоДвиженияLabel.Name = "началоДвиженияLabel";
            началоДвиженияLabel.Size = new System.Drawing.Size(177, 24);
            началоДвиженияLabel.TabIndex = 8;
            началоДвиженияLabel.Text = "Начало Движения:";
            // 
            // конецДвиженияLabel
            // 
            конецДвиженияLabel.AutoSize = true;
            конецДвиженияLabel.Location = new System.Drawing.Point(31, 219);
            конецДвиженияLabel.Name = "конецДвиженияLabel";
            конецДвиженияLabel.Size = new System.Drawing.Size(169, 24);
            конецДвиженияLabel.TabIndex = 10;
            конецДвиженияLabel.Text = "Конец Движения:";
            // 
            // числоМашинLabel
            // 
            числоМашинLabel.AutoSize = true;
            числоМашинLabel.Location = new System.Drawing.Point(65, 254);
            числоМашинLabel.Name = "числоМашинLabel";
            числоМашинLabel.Size = new System.Drawing.Size(135, 24);
            числоМашинLabel.TabIndex = 12;
            числоМашинLabel.Text = "Число Машин:";
            // 
            // числоОстановокLabel
            // 
            числоОстановокLabel.AutoSize = true;
            числоОстановокLabel.Location = new System.Drawing.Point(29, 143);
            числоОстановокLabel.Name = "числоОстановокLabel";
            числоОстановокLabel.Size = new System.Drawing.Size(171, 24);
            числоОстановокLabel.TabIndex = 13;
            числоОстановокLabel.Text = "Число Остановок:";
            // 
            // manageDataSet
            // 
            this.manageDataSet.DataSetName = "manageDataSet";
            this.manageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Trolleybus_manager.manageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.МаршрутыTableAdapter = this.маршрутыTableAdapter;
            this.tableAdapterManager.СправочникОстановокTableAdapter = this.справочникОстановокTableAdapter;
            this.tableAdapterManager.ТроллейбусыTableAdapter = null;
            // 
            // справочникОстановокTableAdapter
            // 
            this.справочникОстановокTableAdapter.ClearBeforeFill = true;
            // 
            // номерМаршрутаTextBox
            // 
            this.номерМаршрутаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутыBindingSource, "НомерМаршрута", true));
            this.номерМаршрутаTextBox.Location = new System.Drawing.Point(206, 38);
            this.номерМаршрутаTextBox.Name = "номерМаршрутаTextBox";
            this.номерМаршрутаTextBox.Size = new System.Drawing.Size(278, 29);
            this.номерМаршрутаTextBox.TabIndex = 2;
            // 
            // протяженностьNumericUpDown
            // 
            this.протяженностьNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.маршрутыBindingSource, "Протяженность", true));
            this.протяженностьNumericUpDown.Location = new System.Drawing.Point(206, 73);
            this.протяженностьNumericUpDown.Name = "протяженностьNumericUpDown";
            this.протяженностьNumericUpDown.Size = new System.Drawing.Size(278, 29);
            this.протяженностьNumericUpDown.TabIndex = 3;
            // 
            // времяDateTimePicker
            // 
            this.времяDateTimePicker.CustomFormat = "00:00";
            this.времяDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.маршрутыBindingSource, "Время", true));
            this.времяDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.времяDateTimePicker.Location = new System.Drawing.Point(206, 108);
            this.времяDateTimePicker.Name = "времяDateTimePicker";
            this.времяDateTimePicker.ShowUpDown = true;
            this.времяDateTimePicker.Size = new System.Drawing.Size(278, 29);
            this.времяDateTimePicker.TabIndex = 5;
            // 
            // началоДвиженияComboBox
            // 
            this.началоДвиженияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутыBindingSource, "НачалоДвижения", true));
            this.началоДвиженияComboBox.DataSource = this.справочникОстановокBindingSource;
            this.началоДвиженияComboBox.DisplayMember = "НазваниеОстановки";
            this.началоДвиженияComboBox.FormattingEnabled = true;
            this.началоДвиженияComboBox.Location = new System.Drawing.Point(206, 178);
            this.началоДвиженияComboBox.Name = "началоДвиженияComboBox";
            this.началоДвиженияComboBox.Size = new System.Drawing.Size(278, 32);
            this.началоДвиженияComboBox.TabIndex = 9;
            // 
            // справочникОстановокBindingSource
            // 
            this.справочникОстановокBindingSource.DataMember = "СправочникОстановок";
            this.справочникОстановокBindingSource.DataSource = this.manageDataSet;
            // 
            // конецДвиженияComboBox
            // 
            this.конецДвиженияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутыBindingSource, "КонецДвижения", true));
            this.конецДвиженияComboBox.DataSource = this.справочникОстановокBindingSource;
            this.конецДвиженияComboBox.DisplayMember = "НазваниеОстановки";
            this.конецДвиженияComboBox.FormattingEnabled = true;
            this.конецДвиженияComboBox.Location = new System.Drawing.Point(206, 216);
            this.конецДвиженияComboBox.Name = "конецДвиженияComboBox";
            this.конецДвиженияComboBox.Size = new System.Drawing.Size(278, 32);
            this.конецДвиженияComboBox.TabIndex = 11;
            // 
            // числоМашинNumericUpDown
            // 
            this.числоМашинNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.маршрутыBindingSource, "ЧислоМашин", true));
            this.числоМашинNumericUpDown.Location = new System.Drawing.Point(206, 254);
            this.числоМашинNumericUpDown.Name = "числоМашинNumericUpDown";
            this.числоМашинNumericUpDown.Size = new System.Drawing.Size(278, 29);
            this.числоМашинNumericUpDown.TabIndex = 13;
            // 
            // числоОстановокNumericUpDown
            // 
            this.числоОстановокNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.маршрутыBindingSource, "ЧислоОстановок", true));
            this.числоОстановокNumericUpDown.Location = new System.Drawing.Point(206, 143);
            this.числоОстановокNumericUpDown.Name = "числоОстановокNumericUpDown";
            this.числоОстановокNumericUpDown.Size = new System.Drawing.Size(278, 29);
            this.числоОстановокNumericUpDown.TabIndex = 14;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(27, 310);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(173, 41);
            this.Change.TabIndex = 15;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(311, 310);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(173, 41);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // ChangePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 359);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Change);
            this.Controls.Add(числоОстановокLabel);
            this.Controls.Add(this.числоОстановокNumericUpDown);
            this.Controls.Add(числоМашинLabel);
            this.Controls.Add(this.числоМашинNumericUpDown);
            this.Controls.Add(конецДвиженияLabel);
            this.Controls.Add(this.конецДвиженияComboBox);
            this.Controls.Add(началоДвиженияLabel);
            this.Controls.Add(this.началоДвиженияComboBox);
            this.Controls.Add(времяLabel);
            this.Controls.Add(this.времяDateTimePicker);
            this.Controls.Add(протяженностьLabel);
            this.Controls.Add(this.протяженностьNumericUpDown);
            this.Controls.Add(номерМаршрутаLabel);
            this.Controls.Add(this.номерМаршрутаTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChangePath";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить маршрут";
            this.Load += new System.EventHandler(this.AddPath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.протяженностьNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникОстановокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.числоМашинNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.числоОстановокNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private manageDataSet manageDataSet;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        private manageDataSetTableAdapters.МаршрутыTableAdapter маршрутыTableAdapter;
        private manageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox номерМаршрутаTextBox;
        private System.Windows.Forms.NumericUpDown протяженностьNumericUpDown;
        private System.Windows.Forms.DateTimePicker времяDateTimePicker;
        private System.Windows.Forms.ComboBox началоДвиженияComboBox;
        private System.Windows.Forms.ComboBox конецДвиженияComboBox;
        private System.Windows.Forms.NumericUpDown числоМашинNumericUpDown;
        private System.Windows.Forms.NumericUpDown числоОстановокNumericUpDown;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Cancel;
        private manageDataSetTableAdapters.СправочникОстановокTableAdapter справочникОстановокTableAdapter;
        private System.Windows.Forms.BindingSource справочникОстановокBindingSource;
    }
}