using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolverLibrary;

namespace CipherTool
{
    public partial class SolverConsole : Form
    {
        private InputCache cache = new InputCache();
        BindingSource inputsBinding = new BindingSource();

        public SolverConsole()
        {
            InitializeComponent();

            inputsBinding.DataSource = cache.Inputs;
            inputsListbox.DataSource = inputsBinding;

            inputsListbox.DisplayMember = "Display";
            inputsListbox.ValueMember = "Display";
        }

        private void solveButtonClick(object sender, EventArgs e)
        {
            cache.Inputs.Add(new UserInput { Code = this.codeTextbox.Text });
            inputsBinding.ResetBindings(false);
            this.codeTextbox.Clear();
        }

        private void codeTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                solveButtonClick(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
