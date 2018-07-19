namespace ado_select
{
    partial class MyConn
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
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.oleDbConnection3 = new System.Data.OleDb.OleDbConnection();
            this.SuspendLayout();
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\\Jan2018\\vp\\db.accdb";
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\\Jan2018\\vp\\db.accdb";
            // 
            // oleDbConnection3
            // 
            this.oleDbConnection3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\\Jan2018\\vp\\db.accdb";
            // 
            // MyConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MyConn";
            this.Text = "MyConn";
            this.Load += new System.EventHandler(this.MyConn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Data.OleDb.OleDbConnection oleDbConnection1;
        public System.Data.OleDb.OleDbConnection oleDbConnection2;
        private System.Data.OleDb.OleDbConnection oleDbConnection3;
    }
}