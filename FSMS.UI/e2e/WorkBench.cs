using FSMS.Domain;
using FSMS.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FSMS.UI
{
    public partial class WorkBench : Form
    {

        RepositoryBase<SalesType> repo;
        string connstr;
        public WorkBench()
        {
            InitializeComponent();
            connstr = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
            repo = new RepositoryBase<SalesType>("SalesTypes");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            repo.Save(new SalesType() { Id = 1, Code = "CR", Name = "Card Sale" });
        }
    }
}
