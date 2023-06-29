namespace Essai_Grand_Ordi_1
{
    partial class FormContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContact));
            this.bAKERYDataSet = new Essai_Grand_Ordi_1.BAKERYDataSet();
            this.cLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTSTableAdapter = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.CLIENTSTableAdapter();
            this.tableAdapterManager = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.TableAdapterManager();
            this.cITYTableAdapter = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.CITYTableAdapter();
            this.cITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.btnHome1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableAdapterManager.CITYTableAdapter = this.cITYTableAdapter;
            this.tableAdapterManager.CLIENTSTableAdapter = this.cLIENTSTableAdapter;
            this.tableAdapterManager.MENUTableAdapter = null;
            this.tableAdapterManager.ORDER_DETAILSTableAdapter = null;
            this.tableAdapterManager.ORDER_METHODSTableAdapter = null;
            this.tableAdapterManager.ORDERSTableAdapter = null;
            this.tableAdapterManager.PAYMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cITYTableAdapter
            // 
            this.cITYTableAdapter.ClearBeforeFill = true;
            // 
            // cITYBindingSource
            // 
            this.cITYBindingSource.DataMember = "CITY";
            this.cITYBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Essai_Grand_Ordi_1.Properties.Resources.istockphoto_530583274_612x612;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblName2);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.lblName1);
            this.panel1.Controls.Add(this.lblTel);
            this.panel1.Controls.Add(this.lblAdress);
            this.panel1.Controls.Add(this.btnHome1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 665);
            this.panel1.TabIndex = 0;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.BackColor = System.Drawing.Color.Transparent;
            this.lblName2.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblName2.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblName2.Location = new System.Drawing.Point(181, 154);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(368, 128);
            this.lblName2.TabIndex = 5;
            this.lblName2.Text = "Bakery";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMail.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMail.Location = new System.Drawing.Point(25, 525);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(273, 21);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Mail : Contact@cohensbakery.com";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.BackColor = System.Drawing.Color.Transparent;
            this.lblName1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblName1.Location = new System.Drawing.Point(82, 68);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(269, 86);
            this.lblName1.TabIndex = 4;
            this.lblName1.Text = "Cohen\'s";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTel.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTel.Location = new System.Drawing.Point(25, 490);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(161, 21);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "Phone : 0549915456";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblAdress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAdress.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAdress.Location = new System.Drawing.Point(25, 457);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(224, 20);
            this.lblAdress.TabIndex = 8;
            this.lblAdress.Text = "Adress : IbnGvirol 125 Tel Aviv";
            // 
            // btnHome1
            // 
            this.btnHome1.BackColor = System.Drawing.Color.Transparent;
            this.btnHome1.BackgroundImage = global::Essai_Grand_Ordi_1.Properties.Resources.icons8_home_32;
            this.btnHome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome1.Location = new System.Drawing.Point(962, 38);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(44, 41);
            this.btnHome1.TabIndex = 5;
            this.btnHome1.UseVisualStyleBackColor = false;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1026, 665);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContact";
            this.Load += new System.EventHandler(this.FormContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome1;
        private BAKERYDataSet bAKERYDataSet;
        private System.Windows.Forms.BindingSource cLIENTSBindingSource;
        private BAKERYDataSetTableAdapters.CLIENTSTableAdapter cLIENTSTableAdapter;
        private BAKERYDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BAKERYDataSetTableAdapters.CITYTableAdapter cITYTableAdapter;
        private System.Windows.Forms.BindingSource cITYBindingSource;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblName1;
    }
}