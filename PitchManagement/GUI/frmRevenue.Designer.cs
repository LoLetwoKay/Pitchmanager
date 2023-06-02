
namespace GUI
{
    partial class frmRevenue
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsRevenue = new GUI.dtsRevenue();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ORDERTableAdapter = new GUI.dtsRevenueTableAdapters.ORDERTableAdapter();
            this.lblRevenue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // ORDERBindingSource
            // 
            this.ORDERBindingSource.DataMember = "ORDER";
            this.ORDERBindingSource.DataSource = this.dtsRevenue;
            // 
            // dtsRevenue
            // 
            this.dtsRevenue.DataSetName = "dtsRevenue";
            this.dtsRevenue.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dtsRevenue";
            reportDataSource1.Value = this.ORDERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.rRevenue.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 124);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 314);
            this.reportViewer1.TabIndex = 0;
            // 
            // ORDERTableAdapter
            // 
            this.ORDERTableAdapter.ClearBeforeFill = true;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(184, 9);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(432, 91);
            this.lblRevenue.TabIndex = 1;
            this.lblRevenue.Text = "REVENUE";
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.frmRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ORDERBindingSource;
        private dtsRevenue dtsRevenue;
        private dtsRevenueTableAdapters.ORDERTableAdapter ORDERTableAdapter;
        private System.Windows.Forms.Label lblRevenue;
    }
}