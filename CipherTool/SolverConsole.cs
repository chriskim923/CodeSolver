using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SolverLibrary;

namespace CipherTool
{
    public partial class SolverConsole : Form
    {
        private List<string> inputCache = new List<string>();
        BindingSource inputBinding = new BindingSource();

        public SolverConsole()
        {
            InitializeComponent();

            //inputBinding.DataSource = inputCache;
            inputBinding.DataSource = inputCache;
            inputCacheComboBox.DataSource = inputBinding;

            this.originalDecodeResultsTable.View = View.Details;
            this.originalDecodeResultsTable.GridLines = true;
            this.originalDecodeResultsTable.Columns.Add("Coding Method", 250);
            this.originalDecodeResultsTable.Columns.Add("Decoded String", 200);
            this.originalDecodeResultsTable.Columns.Add("Parsed Code", 500);

            this.invertedDecodeResultsTable.View = View.Details;
            this.invertedDecodeResultsTable.GridLines = true;
            this.invertedDecodeResultsTable.Columns.Add("Coding Method", 250);
            this.invertedDecodeResultsTable.Columns.Add("Decoded String", 200);
            this.invertedDecodeResultsTable.Columns.Add("Parsed Code", 500);
        }

        private void codeTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decodeButtonClick(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void decodeButtonClick(object sender, EventArgs e)
        {
            var inputCode = this.codeTextbox.Text;

            inputCache.Insert(0, inputCode);
            inputBinding.ResetBindings(false);
            this.codeTextbox.Clear();

            var invertedBinary = CodeInverter.TryInvert(inputCode, 2);
            var invertedTernary = CodeInverter.TryInvert(inputCode, 3);

            this.originalCodeDisplayLabel.Text = inputCode;
            this.invertedBinaryCodeDisplayLabel.Text = invertedBinary;
            this.invertedTernaryCodeDisplayLabel.Text = invertedTernary;

            var decoder = new CodeDecoder();
            List<string[]> originalDecodeResults = decoder.Decodify(inputCode);
            List<string[]> invertedBinaryDecodeResults = decoder.Decodify(invertedBinary, CodeType.Binary);
            List<string[]> invertedTernaryDecodeResults = decoder.Decodify(invertedTernary, CodeType.Ternary);

            this.originalDecodeResultsTable.Items.Clear();
            this.invertedDecodeResultsTable.Items.Clear();

            this.PopulateListView(originalDecodeResults, this.originalDecodeResultsTable);
            this.PopulateListView(invertedBinaryDecodeResults, this.invertedDecodeResultsTable);
            this.PopulateListView(invertedTernaryDecodeResults, this.invertedDecodeResultsTable);
        }

        private void inputCacheComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedInput = inputCacheComboBox.SelectedItem.ToString();
            this.codeTextbox.Text = selectedInput;
            decodeButtonClick(sender, e);
        }

        private void PopulateListView(List<string[]> decodeResults, ListView listView)
        {
            foreach (var listItem in decodeResults)
            {
                ListViewItem item;
                item = new ListViewItem(listItem);
                listView.Items.Add(item);
            }
        }
    }
}
