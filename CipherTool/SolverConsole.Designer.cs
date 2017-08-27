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
            this.decodeButton = new System.Windows.Forms.Button();
            this.codeTextbox = new System.Windows.Forms.TextBox();
            this.originalDecodeResultsTable = new System.Windows.Forms.ListView();
            this.originalCodeDisplayLabel = new System.Windows.Forms.Label();
            this.invertedDecodeResultsTable = new System.Windows.Forms.ListView();
            this.originalLabel = new System.Windows.Forms.Label();
            this.invertedBinaryLabel = new System.Windows.Forms.Label();
            this.invertedBinaryCodeDisplayLabel = new System.Windows.Forms.Label();
            this.invertedTernaryLabel = new System.Windows.Forms.Label();
            this.invertedTernaryCodeDisplayLabel = new System.Windows.Forms.Label();
            this.inputCacheComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.Controls.Add(this.codeTextboxLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.decodeButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.codeTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.originalDecodeResultsTable, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.originalCodeDisplayLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.invertedDecodeResultsTable, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.originalLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.invertedBinaryLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.invertedBinaryCodeDisplayLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.invertedTernaryLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.invertedTernaryCodeDisplayLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.inputCacheComboBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 543);
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
            this.codeTextboxLabel.Size = new System.Drawing.Size(121, 28);
            this.codeTextboxLabel.TabIndex = 0;
            this.codeTextboxLabel.Text = "Code";
            this.codeTextboxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decodeButton
            // 
            this.decodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decodeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.decodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.decodeButton.Location = new System.Drawing.Point(969, 3);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(97, 28);
            this.decodeButton.TabIndex = 1;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = false;
            this.decodeButton.Click += new System.EventHandler(this.decodeButtonClick);
            // 
            // codeTextbox
            // 
            this.codeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.codeTextbox.Location = new System.Drawing.Point(130, 3);
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Size = new System.Drawing.Size(833, 27);
            this.codeTextbox.TabIndex = 2;
            this.codeTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeTextbox_KeyDown);
            // 
            // originalDecodeResultsTable
            // 
            this.originalDecodeResultsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originalDecodeResultsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.originalDecodeResultsTable.Location = new System.Drawing.Point(130, 94);
            this.originalDecodeResultsTable.Name = "originalDecodeResultsTable";
            this.originalDecodeResultsTable.Size = new System.Drawing.Size(833, 226);
            this.originalDecodeResultsTable.TabIndex = 5;
            this.originalDecodeResultsTable.UseCompatibleStateImageBehavior = false;
            // 
            // originalCodeDisplayLabel
            // 
            this.originalCodeDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.originalCodeDisplayLabel.AutoSize = true;
            this.originalCodeDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.originalCodeDisplayLabel.Location = new System.Drawing.Point(130, 67);
            this.originalCodeDisplayLabel.Name = "originalCodeDisplayLabel";
            this.originalCodeDisplayLabel.Size = new System.Drawing.Size(0, 24);
            this.originalCodeDisplayLabel.TabIndex = 6;
            // 
            // invertedDecodeResultsTable
            // 
            this.invertedDecodeResultsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invertedDecodeResultsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.invertedDecodeResultsTable.Location = new System.Drawing.Point(130, 373);
            this.invertedDecodeResultsTable.Name = "invertedDecodeResultsTable";
            this.invertedDecodeResultsTable.Size = new System.Drawing.Size(833, 167);
            this.invertedDecodeResultsTable.TabIndex = 7;
            this.invertedDecodeResultsTable.UseCompatibleStateImageBehavior = false;
            // 
            // originalLabel
            // 
            this.originalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originalLabel.AutoSize = true;
            this.originalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.originalLabel.Location = new System.Drawing.Point(3, 67);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(121, 24);
            this.originalLabel.TabIndex = 8;
            this.originalLabel.Text = "Original Code:";
            // 
            // invertedBinaryLabel
            // 
            this.invertedBinaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invertedBinaryLabel.AutoSize = true;
            this.invertedBinaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.invertedBinaryLabel.Location = new System.Drawing.Point(3, 323);
            this.invertedBinaryLabel.Name = "invertedBinaryLabel";
            this.invertedBinaryLabel.Size = new System.Drawing.Size(121, 23);
            this.invertedBinaryLabel.TabIndex = 9;
            this.invertedBinaryLabel.Text = "Inverted Binary:";
            // 
            // invertedBinaryCodeDisplayLabel
            // 
            this.invertedBinaryCodeDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invertedBinaryCodeDisplayLabel.AutoSize = true;
            this.invertedBinaryCodeDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.invertedBinaryCodeDisplayLabel.Location = new System.Drawing.Point(130, 323);
            this.invertedBinaryCodeDisplayLabel.Name = "invertedBinaryCodeDisplayLabel";
            this.invertedBinaryCodeDisplayLabel.Size = new System.Drawing.Size(833, 23);
            this.invertedBinaryCodeDisplayLabel.TabIndex = 10;
            this.invertedBinaryCodeDisplayLabel.Text = "       ";
            // 
            // invertedTernaryLabel
            // 
            this.invertedTernaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invertedTernaryLabel.AutoSize = true;
            this.invertedTernaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.invertedTernaryLabel.Location = new System.Drawing.Point(3, 346);
            this.invertedTernaryLabel.Name = "invertedTernaryLabel";
            this.invertedTernaryLabel.Size = new System.Drawing.Size(121, 24);
            this.invertedTernaryLabel.TabIndex = 11;
            this.invertedTernaryLabel.Text = "Inverted Ternary:";
            // 
            // invertedTernaryCodeDisplayLabel
            // 
            this.invertedTernaryCodeDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invertedTernaryCodeDisplayLabel.AutoSize = true;
            this.invertedTernaryCodeDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.invertedTernaryCodeDisplayLabel.Location = new System.Drawing.Point(130, 346);
            this.invertedTernaryCodeDisplayLabel.Name = "invertedTernaryCodeDisplayLabel";
            this.invertedTernaryCodeDisplayLabel.Size = new System.Drawing.Size(833, 24);
            this.invertedTernaryCodeDisplayLabel.TabIndex = 12;
            this.invertedTernaryCodeDisplayLabel.Text = "       ";
            // 
            // inputCacheComboBox
            // 
            this.inputCacheComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCacheComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.inputCacheComboBox.FormattingEnabled = true;
            this.inputCacheComboBox.IntegralHeight = false;
            this.inputCacheComboBox.Location = new System.Drawing.Point(130, 37);
            this.inputCacheComboBox.MaxDropDownItems = 6;
            this.inputCacheComboBox.Name = "inputCacheComboBox";
            this.inputCacheComboBox.Size = new System.Drawing.Size(833, 28);
            this.inputCacheComboBox.TabIndex = 13;
            this.inputCacheComboBox.SelectedIndexChanged += new System.EventHandler(this.inputCacheComboBoxSelectedIndexChanged);
            // 
            // SolverConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1093, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SolverConsole";
            this.Text = "Cipher Solver";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label codeTextboxLabel;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.TextBox codeTextbox;
        private System.Windows.Forms.ListView originalDecodeResultsTable;
        private System.Windows.Forms.Label originalCodeDisplayLabel;
        private System.Windows.Forms.ListView invertedDecodeResultsTable;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Label invertedBinaryLabel;
        private System.Windows.Forms.Label invertedBinaryCodeDisplayLabel;
        private System.Windows.Forms.Label invertedTernaryLabel;
        private System.Windows.Forms.Label invertedTernaryCodeDisplayLabel;
        private System.Windows.Forms.ComboBox inputCacheComboBox;
    }
}