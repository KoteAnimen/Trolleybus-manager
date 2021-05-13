
namespace Trolleybus_manager
{
    partial class AddState
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
            System.Windows.Forms.Label номерОстановкиLabel;
            System.Windows.Forms.Label названиеОстановкиLabel;
            this.manageDataSet = new Trolleybus_manager.manageDataSet();
            this.справочникОстановокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.справочникОстановокTableAdapter = new Trolleybus_manager.manageDataSetTableAdapters.СправочникОстановокTableAdapter();
            this.tableAdapterManager = new Trolleybus_manager.manageDataSetTableAdapters.TableAdapterManager();
            this.номерОстановкиTextBox = new System.Windows.Forms.TextBox();
            this.названиеОстановкиTextBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            номерОстановкиLabel = new System.Windows.Forms.Label();
            названиеОстановкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникОстановокBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // manageDataSet
            // 
            this.manageDataSet.DataSetName = "manageDataSet";
            this.manageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справочникОстановокBindingSource
            // 
            this.справочникОстановокBindingSource.DataMember = "СправочникОстановок";
            this.справочникОстановокBindingSource.DataSource = this.manageDataSet;
            // 
            // справочникОстановокTableAdapter
            // 
            this.справочникОстановокTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Trolleybus_manager.manageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.МаршрутыTableAdapter = null;
            this.tableAdapterManager.СправочникОстановокTableAdapter = this.справочникОстановокTableAdapter;
            this.tableAdapterManager.ТроллейбусыTableAdapter = null;
            // 
            // номерОстановкиLabel
            // 
            номерОстановкиLabel.AutoSize = true;
            номерОстановкиLabel.Location = new System.Drawing.Point(39, 30);
            номерОстановкиLabel.Name = "номерОстановкиLabel";
            номерОстановкиLabel.Size = new System.Drawing.Size(177, 24);
            номерОстановкиLabel.TabIndex = 1;
            номерОстановкиLabel.Text = "Номер Остановки:";
            // 
            // номерОстановкиTextBox
            // 
            this.номерОстановкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.справочникОстановокBindingSource, "НомерОстановки", true));
            this.номерОстановкиTextBox.Location = new System.Drawing.Point(222, 27);
            this.номерОстановкиTextBox.Name = "номерОстановкиTextBox";
            this.номерОстановкиTextBox.Size = new System.Drawing.Size(224, 29);
            this.номерОстановкиTextBox.TabIndex = 2;
            // 
            // названиеОстановкиLabel
            // 
            названиеОстановкиLabel.AutoSize = true;
            названиеОстановкиLabel.Location = new System.Drawing.Point(11, 65);
            названиеОстановкиLabel.Name = "названиеОстановкиLabel";
            названиеОстановкиLabel.Size = new System.Drawing.Size(205, 24);
            названиеОстановкиLabel.TabIndex = 2;
            названиеОстановкиLabel.Text = "Название Остановки:";
            // 
            // названиеОстановкиTextBox
            // 
            this.названиеОстановкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.справочникОстановокBindingSource, "НазваниеОстановки", true));
            this.названиеОстановкиTextBox.Location = new System.Drawing.Point(222, 62);
            this.названиеОстановкиTextBox.Name = "названиеОстановкиTextBox";
            this.названиеОстановкиTextBox.Size = new System.Drawing.Size(224, 29);
            this.названиеОстановкиTextBox.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(15, 119);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(171, 37);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(275, 119);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(171, 37);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // AddState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 175);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(названиеОстановкиLabel);
            this.Controls.Add(this.названиеОстановкиTextBox);
            this.Controls.Add(номерОстановкиLabel);
            this.Controls.Add(this.номерОстановкиTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddState";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить остановку";
            this.Load += new System.EventHandler(this.AddState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникОстановокBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private manageDataSet manageDataSet;
        private System.Windows.Forms.BindingSource справочникОстановокBindingSource;
        private manageDataSetTableAdapters.СправочникОстановокTableAdapter справочникОстановокTableAdapter;
        private manageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox номерОстановкиTextBox;
        private System.Windows.Forms.TextBox названиеОстановкиTextBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
    }
}