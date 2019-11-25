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
    public partial class FrmHasil : Form
    {
        public FrmHasil()
        {
            InitializeComponent();
        }
        private void FrmHitung_Hitung(Operasi ops)
        {
            int Out;
            if (ops.pilih == "Penjumlahan")
            {
                Operasi.Penjumlahan(ops.a, ops.b);
                Out = Operasi.Penjumlahan(ops.a, ops.b);
                Hasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2}", ops.a, ops.b, Out));
            }
            else if (ops.pilih == "Pengurangan")
            {
                Operasi.Pengurangan(ops.a, ops.b);
                Out = Operasi.Pengurangan(ops.a, ops.b);
                Hasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", ops.a, ops.b, Out));
            }
            else if (ops.pilih == "Perkalian")
            {
                Operasi.Perkalian(ops.a, ops.b);
                Out = Operasi.Perkalian(ops.a, ops.b);
                Hasil.Items.Add(string.Format("Hasil Perkalian: {0} x {1} = {2}", ops.a, ops.b, Out));
            }
            else if (ops.pilih == "Pembagian")
            {
                Operasi.Pembagian(ops.a, ops.b);
                Out = Operasi.Pembagian(ops.a, ops.b);
                Hasil.Items.Add(string.Format("Hasil Pembagian: {0} : {1} = {2}", ops.a, ops.b, Out));
            }


        }

        private void btn_hitung_Click(object sender, EventArgs e)
        {
            FrmHitung frmEntry = new FrmHitung();
            frmEntry.Hitung += FrmHitung_Hitung;

            // tampilkan form entry mahasiswa
            frmEntry.ShowDialog();

        }
    }
}
