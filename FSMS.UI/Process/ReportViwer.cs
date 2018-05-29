using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSMS.UI.Process
{
    public partial class ReportViwer : Form
    {
        string formHeadertext = "ReportViewr";

        public string FormHeadertext
        {
            get { return formHeadertext; }
            set { formHeadertext = value; }
        }

        public ReportViwer()
        {
            InitializeComponent();
        }

        private void ReportViwer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
