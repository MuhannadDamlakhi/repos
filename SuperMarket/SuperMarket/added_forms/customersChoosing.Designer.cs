namespace SuperMarket.added_forms
{
    partial class customersChoosing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customersChoosing));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSet11 = new SuperMarket.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcust_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcust_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcust_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcust_address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textaddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textphone = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.customersTableAdapter1 = new SuperMarket.DataSet1TableAdapters.customersTableAdapter();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textaddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textphone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 99);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1165, 840);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "groupControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "customers";
            this.gridControl1.DataSource = this.dataSet11;
            this.gridControl1.Location = new System.Drawing.Point(3, 66);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1159, 762);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcust_id,
            this.colcust_name,
            this.colcust_phone,
            this.colcust_address});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colcust_id
            // 
            this.colcust_id.Caption = "المعرف";
            this.colcust_id.FieldName = "cust_id";
            this.colcust_id.MinWidth = 28;
            this.colcust_id.Name = "colcust_id";
            this.colcust_id.Visible = true;
            this.colcust_id.VisibleIndex = 0;
            this.colcust_id.Width = 105;
            // 
            // colcust_name
            // 
            this.colcust_name.Caption = "الاسم";
            this.colcust_name.FieldName = "cust_name";
            this.colcust_name.MinWidth = 28;
            this.colcust_name.Name = "colcust_name";
            this.colcust_name.Visible = true;
            this.colcust_name.VisibleIndex = 1;
            this.colcust_name.Width = 105;
            // 
            // colcust_phone
            // 
            this.colcust_phone.Caption = "رقم الهاتف";
            this.colcust_phone.FieldName = "cust_phone";
            this.colcust_phone.MinWidth = 28;
            this.colcust_phone.Name = "colcust_phone";
            this.colcust_phone.Visible = true;
            this.colcust_phone.VisibleIndex = 2;
            this.colcust_phone.Width = 105;
            // 
            // colcust_address
            // 
            this.colcust_address.Caption = "العنوان";
            this.colcust_address.FieldName = "cust_address";
            this.colcust_address.MinWidth = 28;
            this.colcust_address.Name = "colcust_address";
            this.colcust_address.Visible = true;
            this.colcust_address.VisibleIndex = 3;
            this.colcust_address.Width = 105;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(220, 93);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 25);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = ": الاسم";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(7, 124);
            this.textName.Name = "textName";
            this.textName.Properties.AutoHeight = false;
            this.textName.Size = new System.Drawing.Size(265, 38);
            this.textName.TabIndex = 0;
            this.textName.EditValueChanged += new System.EventHandler(this.textName_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 22.02985F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(697, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 50);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "الزبائن";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(207, 285);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 25);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = ": العنوان";
            // 
            // textaddress
            // 
            this.textaddress.Location = new System.Drawing.Point(7, 316);
            this.textaddress.Name = "textaddress";
            this.textaddress.Properties.AutoHeight = false;
            this.textaddress.Size = new System.Drawing.Size(265, 38);
            this.textaddress.TabIndex = 10;
            this.textaddress.EditValueChanged += new System.EventHandler(this.textaddress_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(173, 188);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 25);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = ": رقم الهاتف ";
            // 
            // textphone
            // 
            this.textphone.Location = new System.Drawing.Point(7, 219);
            this.textphone.Name = "textphone";
            this.textphone.Properties.AutoHeight = false;
            this.textphone.Size = new System.Drawing.Size(265, 38);
            this.textphone.TabIndex = 12;
            this.textphone.EditValueChanged += new System.EventHandler(this.textphone_EditValueChanged);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Bold);
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.simpleButton6.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(7, 12);
            this.simpleButton6.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.simpleButton6.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(265, 46);
            this.simpleButton6.TabIndex = 24;
            this.simpleButton6.Text = "إدخال زبون جديد";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl3.Controls.Add(this.simpleButton6);
            this.groupControl3.Controls.Add(this.textaddress);
            this.groupControl3.Controls.Add(this.textphone);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.textName);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Location = new System.Drawing.Point(1183, 99);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(280, 883);
            this.groupControl3.TabIndex = 25;
            this.groupControl3.Text = "groupControl3";
            // 
            // customersChoosing
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1465, 948);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Name = "customersChoosing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customers";
            this.Load += new System.EventHandler(this.customersChoosing_Load);
            this.Shown += new System.EventHandler(this.customersChoosing_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textaddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textphone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        //private void gridView1_DoubleClick(object sender, System.EventArgs e)
        //{
        //    //throw new System.NotImplementedException();
        //}

        //private void customersChoosing_Load(object sender, System.EventArgs e)
        //{
        //    throw new System.NotImplementedException();
        //}

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textphone;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textaddress;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DataSet1 dataSet11;
        private DevExpress.XtraGrid.Columns.GridColumn colcust_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcust_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcust_phone;
        private DevExpress.XtraGrid.Columns.GridColumn colcust_address;
        private DataSet1TableAdapters.customersTableAdapter customersTableAdapter1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}