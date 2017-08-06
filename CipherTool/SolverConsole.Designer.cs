namespace CipherTool
{
    partial class SolverConsole
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.codeTextboxLabel = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.codeTextbox = new System.Windows.Forms.TextBox();
            this.resultsDataView = new System.Windows.Forms.DataGridView();
            this.inputsListbox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.Controls.Add(this.codeTextboxLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.solveButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.codeTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultsDataView, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputsListbox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 532);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // codeTextboxLabel
            // 
            this.codeTextboxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextboxLabel.AutoSize = true;
            this.codeTextboxLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.codeTextboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextboxLabel.Location = new System.Drawing.Point(3, 3);
            this.codeTextboxLabel.Margin = new System.Windows.Forms.Padding(3);
            this.codeTextboxLabel.Name = "codeTextboxLabel";
            this.codeTextboxLabel.Size = new System.Drawing.Size(77, 28);
            this.codeTextboxLabel.TabIndex = 0;
            this.codeTextboxLabel.Text = "Code";
            this.codeTextboxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solveButton
            // 
            this.solveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.solveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.solveButton.Location = new System.Drawing.Point(811, 3);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(97, 28);
            this.solveButton.TabIndex = 1;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = false;
            this.solveButton.Click += new System.EventHandler(this.solveButtonClick);
            // 
            // codeTextbox
            // 
            this.codeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.codeTextbox.Location = new System.Drawing.Point(86, 3);
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Size = new System.Drawing.Size(719, 27);
            this.codeTextbox.TabIndex = 2;
            this.codeTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeTextbox_KeyDown);
            // 
            // resultsDataView
            // 
            this.resultsDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataView.Location = new System.Drawing.Point(86, 127);
            this.resultsDataView.Name = "resultsDataView";
            this.resultsDataView.Size = new System.Drawing.Size(719, 402);
            this.resultsDataView.TabIndex = 3;
            // 
            // inputsListbox
            // 
            this.inputsListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.inputsListbox.FormattingEnabled = true;
            this.inputsListbox.ItemHeight = 20;
            this.inputsListbox.Location = new System.Drawing.Point(86, 37);
            this.inputsListbox.Name = "inputsListbox";
            this.inputsListbox.Size = new System.Drawing.Size(719, 84);
            this.inputsListbox.TabIndex = 4;
            // 
            // SolverConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(935, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SolverConsole";
            this.Text = "Cipher Solver";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label codeTextboxLabel;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.TextBox codeTextbox;
        private System.Windows.Forms.DataGridView resultsDataView;
        private System.Windows.Forms.ListBox inputsListbox;
    }
}