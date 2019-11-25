using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelevCal
{
    public partial class FrmHitung : Form
    {
        
        public delegate void CreateUpdateEventHandler(Operasi ops);
        public event CreateUpdateEventHandler Hitung;
        private Operasi ops;

        public FrmHitung()
        {
            InitializeComponent();
        }
     
        private void Proses_Click(object sender, EventArgs e)
        {
            ops = new Operasi();
            ops.a = Convert.ToInt32(NilaiA.Text);
            ops.b = Convert.ToInt32(NilaiB.Text);
            ops.pilih = cmbOps.Text;

            Hitung(ops);
            NilaiA.Clear();
            NilaiB.Clear();
        }
    }
}
