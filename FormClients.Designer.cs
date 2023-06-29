namespace Essai_Grand_Ordi_1
{
    partial class FormClients
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
            System.Windows.Forms.Label pHONE_NUMBERLabel;
            System.Windows.Forms.Label fIRST_NAMELabel;
            System.Windows.Forms.Label lAST_NAMELabel;
            System.Windows.Forms.Label sTREETLabel;
            System.Windows.Forms.Label aPARTMENT_NUMBERLabel;
            System.Windows.Forms.Label fLOORLabel;
            System.Windows.Forms.Label hOME_NUMBERLabel;
            System.Windows.Forms.Label cITYLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.bAKERYDataSet = new Essai_Grand_Ordi_1.BAKERYDataSet();
            this.cLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTSTableAdapter = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.CLIENTSTableAdapter();
            this.tableAdapterManager = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.TableAdapterManager();
            this.cLIENTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pHONE_NUMBERTextBox = new System.Windows.Forms.TextBox();
            this.fIRST_NAMETextBox = new System.Windows.Forms.TextBox();
            this.lAST_NAMETextBox = new System.Windows.Forms.TextBox();
            this.sTREETTextBox = new System.Windows.Forms.TextBox();
            this.aPARTMENT_NUMBERTextBox = new System.Windows.Forms.TextBox();
            this.fLOORTextBox = new System.Windows.Forms.TextBox();
            this.hOME_NUMBERTextBox = new System.Windows.Forms.TextBox();
            this.cITYTextBox = new System.Windows.Forms.TextBox();
            this.cLIENTSDataGridView = new System.Windows.Forms.DataGridView();
            this.cITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cITYTableAdapter = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.CITYTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            pHONE_NUMBERLabel = new System.Windows.Forms.Label();
            fIRST_NAMELabel = new System.Windows.Forms.Label();
            lAST_NAMELabel = new System.Windows.Forms.Label();
            sTREETLabel = new System.Windows.Forms.Label();
            aPARTMENT_NUMBERLabel = new System.Windows.Forms.Label();
            fLOORLabel = new System.Windows.Forms.Label();
            hOME_NUMBERLabel = new System.Windows.Forms.Label();
            cITYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pHONE_NUMBERLabel
            // 
            pHONE_NUMBERLabel.AutoSize = true;
            pHONE_NUMBERLabel.BackColor = System.Drawing.Color.Transparent;
            pHONE_NUMBERLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            pHONE_NUMBERLabel.Location = new System.Drawing.Point(27, 39);
            pHONE_NUMBERLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pHONE_NUMBERLabel.Name = "pHONE_NUMBERLabel";
            pHONE_NUMBERLabel.Size = new System.Drawing.Size(101, 15);
            pHONE_NUMBERLabel.TabIndex = 0;
            pHONE_NUMBERLabel.Text = "PHONE NUMBER:";
            // 
            // fIRST_NAMELabel
            // 
            fIRST_NAMELabel.AutoSize = true;
            fIRST_NAMELabel.BackColor = System.Drawing.Color.Transparent;
            fIRST_NAMELabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            fIRST_NAMELabel.Location = new System.Drawing.Point(27, 71);
            fIRST_NAMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fIRST_NAMELabel.Name = "fIRST_NAMELabel";
            fIRST_NAMELabel.Size = new System.Drawing.Size(78, 15);
            fIRST_NAMELabel.TabIndex = 2;
            fIRST_NAMELabel.Text = "FIRST NAME:";
            // 
            // lAST_NAMELabel
            // 
            lAST_NAMELabel.AutoSize = true;
            lAST_NAMELabel.BackColor = System.Drawing.Color.Transparent;
            lAST_NAMELabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            lAST_NAMELabel.Location = new System.Drawing.Point(27, 103);
            lAST_NAMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lAST_NAMELabel.Name = "lAST_NAMELabel";
            lAST_NAMELabel.Size = new System.Drawing.Size(75, 15);
            lAST_NAMELabel.TabIndex = 4;
            lAST_NAMELabel.Text = "LAST NAME:";
            // 
            // sTREETLabel
            // 
            sTREETLabel.AutoSize = true;
            sTREETLabel.BackColor = System.Drawing.Color.Transparent;
            sTREETLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            sTREETLabel.Location = new System.Drawing.Point(27, 135);
            sTREETLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sTREETLabel.Name = "sTREETLabel";
            sTREETLabel.Size = new System.Drawing.Size(50, 15);
            sTREETLabel.TabIndex = 6;
            sTREETLabel.Text = "STREET:";
            // 
            // aPARTMENT_NUMBERLabel
            // 
            aPARTMENT_NUMBERLabel.AutoSize = true;
            aPARTMENT_NUMBERLabel.BackColor = System.Drawing.Color.Transparent;
            aPARTMENT_NUMBERLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            aPARTMENT_NUMBERLabel.Location = new System.Drawing.Point(27, 167);
            aPARTMENT_NUMBERLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aPARTMENT_NUMBERLabel.Name = "aPARTMENT_NUMBERLabel";
            aPARTMENT_NUMBERLabel.Size = new System.Drawing.Size(130, 15);
            aPARTMENT_NUMBERLabel.TabIndex = 8;
            aPARTMENT_NUMBERLabel.Text = "APARTMENT NUMBER:";
            // 
            // fLOORLabel
            // 
            fLOORLabel.AutoSize = true;
            fLOORLabel.BackColor = System.Drawing.Color.Transparent;
            fLOORLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            fLOORLabel.Location = new System.Drawing.Point(27, 199);
            fLOORLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fLOORLabel.Name = "fLOORLabel";
            fLOORLabel.Size = new System.Drawing.Size(47, 15);
            fLOORLabel.TabIndex = 10;
            fLOORLabel.Text = "FLOOR:";
            // 
            // hOME_NUMBERLabel
            // 
            hOME_NUMBERLabel.AutoSize = true;
            hOME_NUMBERLabel.BackColor = System.Drawing.Color.Transparent;
            hOME_NUMBERLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            hOME_NUMBERLabel.Location = new System.Drawing.Point(27, 231);
            hOME_NUMBERLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOME_NUMBERLabel.Name = "hOME_NUMBERLabel";
            hOME_NUMBERLabel.Size = new System.Drawing.Size(96, 15);
            hOME_NUMBERLabel.TabIndex = 12;
            hOME_NUMBERLabel.Text = "HOME NUMBER:";
            // 
            // cITYLabel
            // 
            cITYLabel.AutoSize = true;
            cITYLabel.BackColor = System.Drawing.Color.Transparent;
            cITYLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            cITYLabel.Location = new System.Drawing.Point(27, 263);
            cITYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cITYLabel.Name = "cITYLabel";
            cITYLabel.Size = new System.Drawing.Size(35, 15);
            cITYLabel.TabIndex = 14;
            cITYLabel.Text = "CITY:";
            // 
            // bAKERYDataSet
            // 
            this.bAKERYDataSet.DataSetName = "BAKERYDataSet";
            this.bAKERYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTSBindingSource
            // 
            this.cLIENTSBindingSource.DataMember = "CLIENTS";
            this.cLIENTSBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // cLIENTSTableAdapter
            // 
            this.cLIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CITYTableAdapter = null;
            this.tableAdapterManager.CLIENTSTableAdapter = this.cLIENTSTableAdapter;
            this.tableAdapterManager.MENUTableAdapter = null;
            this.tableAdapterManager.ORDER_DETAILSTableAdapter = null;
            this.tableAdapterManager.ORDER_METHODSTableAdapter = null;
            this.tableAdapterManager.ORDERSTableAdapter = null;
            this.tableAdapterManager.PAYMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cLIENTSBindingSource1
            // 
            this.cLIENTSBindingSource1.DataMember = "CLIENTS";
            this.cLIENTSBindingSource1.DataSource = this.bAKERYDataSet;
            // 
            // pHONE_NUMBERTextBox
            // 
            this.pHONE_NUMBERTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pHONE_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "PHONE_NUMBER", true));
            this.pHONE_NUMBERTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pHONE_NUMBERTextBox.Location = new System.Drawing.Point(205, 35);
            this.pHONE_NUMBERTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pHONE_NUMBERTextBox.Name = "pHONE_NUMBERTextBox";
            this.pHONE_NUMBERTextBox.Size = new System.Drawing.Size(133, 16);
            this.pHONE_NUMBERTextBox.TabIndex = 1;
            // 
            // fIRST_NAMETextBox
            // 
            this.fIRST_NAMETextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fIRST_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "FIRST_NAME", true));
            this.fIRST_NAMETextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fIRST_NAMETextBox.Location = new System.Drawing.Point(205, 67);
            this.fIRST_NAMETextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fIRST_NAMETextBox.Name = "fIRST_NAMETextBox";
            this.fIRST_NAMETextBox.Size = new System.Drawing.Size(133, 16);
            this.fIRST_NAMETextBox.TabIndex = 3;
            // 
            // lAST_NAMETextBox
            // 
            this.lAST_NAMETextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lAST_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "LAST_NAME", true));
            this.lAST_NAMETextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lAST_NAMETextBox.Location = new System.Drawing.Point(205, 99);
            this.lAST_NAMETextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lAST_NAMETextBox.Name = "lAST_NAMETextBox";
            this.lAST_NAMETextBox.Size = new System.Drawing.Size(133, 16);
            this.lAST_NAMETextBox.TabIndex = 5;
            // 
            // sTREETTextBox
            // 
            this.sTREETTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sTREETTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "STREET", true));
            this.sTREETTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sTREETTextBox.Location = new System.Drawing.Point(205, 131);
            this.sTREETTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sTREETTextBox.Name = "sTREETTextBox";
            this.sTREETTextBox.Size = new System.Drawing.Size(133, 16);
            this.sTREETTextBox.TabIndex = 7;
            // 
            // aPARTMENT_NUMBERTextBox
            // 
            this.aPARTMENT_NUMBERTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aPARTMENT_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "APARTMENT_NUMBER", true));
            this.aPARTMENT_NUMBERTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.aPARTMENT_NUMBERTextBox.Location = new System.Drawing.Point(205, 163);
            this.aPARTMENT_NUMBERTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aPARTMENT_NUMBERTextBox.Name = "aPARTMENT_NUMBERTextBox";
            this.aPARTMENT_NUMBERTextBox.Size = new System.Drawing.Size(133, 16);
            this.aPARTMENT_NUMBERTextBox.TabIndex = 9;
            // 
            // fLOORTextBox
            // 
            this.fLOORTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fLOORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "FLOOR", true));
            this.fLOORTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fLOORTextBox.Location = new System.Drawing.Point(205, 195);
            this.fLOORTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fLOORTextBox.Name = "fLOORTextBox";
            this.fLOORTextBox.Size = new System.Drawing.Size(133, 16);
            this.fLOORTextBox.TabIndex = 11;
            // 
            // hOME_NUMBERTextBox
            // 
            this.hOME_NUMBERTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hOME_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "HOME_NUMBER", true));
            this.hOME_NUMBERTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hOME_NUMBERTextBox.Location = new System.Drawing.Point(205, 227);
            this.hOME_NUMBERTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hOME_NUMBERTextBox.Name = "hOME_NUMBERTextBox";
            this.hOME_NUMBERTextBox.Size = new System.Drawing.Size(133, 16);
            this.hOME_NUMBERTextBox.TabIndex = 13;
            // 
            // cITYTextBox
            // 
            this.cITYTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "CITY", true));
            this.cITYTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cITYTextBox.Location = new System.Drawing.Point(205, 259);
            this.cITYTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cITYTextBox.Name = "cITYTextBox";
            this.cITYTextBox.Size = new System.Drawing.Size(133, 16);
            this.cITYTextBox.TabIndex = 15;
            // 
            // cLIENTSDataGridView
            // 
            this.cLIENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cLIENTSDataGridView.Location = new System.Drawing.Point(372, 35);
            this.cLIENTSDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.cLIENTSDataGridView.Name = "cLIENTSDataGridView";
            this.cLIENTSDataGridView.Size = new System.Drawing.Size(1123, 286);
            this.cLIENTSDataGridView.TabIndex = 16;
            this.cLIENTSDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cLIENTSDataGridView_CellClick);
            // 
            // cITYBindingSource
            // 
            this.cITYBindingSource.DataMember = "CITY";
            this.cITYBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // cITYTableAdapter
            // 
            this.cITYTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1418, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Select";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 416);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cLIENTSDataGridView);
            this.Controls.Add(pHONE_NUMBERLabel);
            this.Controls.Add(this.pHONE_NUMBERTextBox);
            this.Controls.Add(fIRST_NAMELabel);
            this.Controls.Add(this.fIRST_NAMETextBox);
            this.Controls.Add(lAST_NAMELabel);
            this.Controls.Add(this.lAST_NAMETextBox);
            this.Controls.Add(sTREETLabel);
            this.Controls.Add(this.sTREETTextBox);
            this.Controls.Add(aPARTMENT_NUMBERLabel);
            this.Controls.Add(this.aPARTMENT_NUMBERTextBox);
            this.Controls.Add(fLOORLabel);
            this.Controls.Add(this.fLOORTextBox);
            this.Controls.Add(hOME_NUMBERLabel);
            this.Controls.Add(this.hOME_NUMBERTextBox);
            this.Controls.Add(cITYLabel);
            this.Controls.Add(this.cITYTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClients";
            this.Load += new System.EventHandler(this.FormClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BAKERYDataSet bAKERYDataSet;
        private System.Windows.Forms.BindingSource cLIENTSBindingSource;
        private BAKERYDataSetTableAdapters.CLIENTSTableAdapter cLIENTSTableAdapter;
        private BAKERYDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cLIENTSBindingSource1;
        private System.Windows.Forms.TextBox pHONE_NUMBERTextBox;
        private System.Windows.Forms.TextBox fIRST_NAMETextBox;
        private System.Windows.Forms.TextBox lAST_NAMETextBox;
        private System.Windows.Forms.TextBox sTREETTextBox;
        private System.Windows.Forms.TextBox aPARTMENT_NUMBERTextBox;
        private System.Windows.Forms.TextBox fLOORTextBox;
        private System.Windows.Forms.TextBox hOME_NUMBERTextBox;
        private System.Windows.Forms.TextBox cITYTextBox;
        private System.Windows.Forms.DataGridView cLIENTSDataGridView;
        private System.Windows.Forms.BindingSource cITYBindingSource;
        private BAKERYDataSetTableAdapters.CITYTableAdapter cITYTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}