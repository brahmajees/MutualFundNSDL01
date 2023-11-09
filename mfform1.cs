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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MutualFundNSDL01
{
    public partial class MFNsdlEntry : Form
    {
        public MFNsdlEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Focus();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Focus();    
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           Focus();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Focus();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5BasisCalcSD.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //

            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into MutualFundHD00" +
            "(Record_Id,Batch_No,Shr_ID,Tot_CA_Orders,Sender_Dt,Filler1,MasterUniqNo) " +
            "values(@Record_id,@Batch_No,@Shr_ID,@Tot_CA_Orders,@Sender_Dt,@Filler1,@MasterUniqNo)", con);
            
            cmd.Parameters.AddWithValue("@Record_id", lblRecord_id.Text);
            cmd.Parameters.AddWithValue("@Batch_No", txtBatch_no.Text);
            cmd.Parameters.AddWithValue("@Shr_ID", lblShr_ID.Text);
            cmd.Parameters.AddWithValue("@Tot_CA_Orders", txtTotalCAOrders.Text);
            cmd.Parameters.AddWithValue("@Sender_Dt", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Filler1", txtFiller1.Text);
            cmd.Parameters.AddWithValue("@MasterUniqNo", txtMastuniqNomf00.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has saved in MFHD00 database");
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            lblRecord_id.Text = null;
            txtBatch_no.Text = null;
            txtTotalCAOrders.Text = null;
            txtFiller1.Text = null;
            txtMastuniqNomf00.Text = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into MutualFunddt01 " +
            "(Record_Id,File_ident,RTA_Int_No,Drcr_ind,ISIN,CAType,Allot_dt,Allocation_Desc," +
            "Exec_Dt,TotAllQty_FL,TotAllQty_L,Tot_Ded_Rec,TotIssued_Amt,TotPaidup_Amt," +
            "StampDuty_Payable,Basis_Calc_SD,Filler2,MasterUniqNo) " +

            "values(@Record_Id1,@File_ident,@RTA_Int_No,@Drcr_ind,@ISIN,@CAType,@Allot_dt,@Allocation_Desc," +
            "@Exec_Dt,@TotAllQty_FL,@TotAllQty_L,@Tot_Ded_Rec,@TotIssued_Amt,@TotPaidup_Amt,@StampDuty_Payable," +
            "@Basis_Calc_SD,@Filler2,@MasterUniqNo)", con);

            cmd.Parameters.AddWithValue("@Record_id1",          lblRecordID1.Text);
            cmd.Parameters.AddWithValue("@file_ident",          lblFileIdent.Text);
            cmd.Parameters.AddWithValue("@RTA_Int_No",          txtFileIntRefNo.Text);
            var drcr = comboBox1Drcr_ind.Text.Substring(0, 1);
            cmd.Parameters.AddWithValue("@Drcr_ind",            drcr);
            cmd.Parameters.AddWithValue("@ISIN",                txtISIN2.Text);
            var ccatype = comboBox2CAType.Text.Substring(0, 4);
            cmd.Parameters.AddWithValue("@CAType",              ccatype);
            cmd.Parameters.AddWithValue("@Allot_dt",            dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            var aad = comboBoxAllDesc.Text.Substring(0, 4);
            cmd.Parameters.AddWithValue("@Allocation_Desc",     aad);
            cmd.Parameters.AddWithValue("@Exec_Dt",             dateTimePicker3.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TotAllQty_FL",        txtTotAllQtyFL2.Text);
            cmd.Parameters.AddWithValue("@TotAllQty_L",         txtAllQtyL2.Text);
            cmd.Parameters.AddWithValue("@Tot_Ded_Rec",         txtTotDedRec2.Text);
            cmd.Parameters.AddWithValue("@TotIssued_Amt",       txtTotIssAmt2.Text);
            cmd.Parameters.AddWithValue("@TotPaidup_Amt",       txtPaidupAmt2.Text);
            var stmp = comboBox4StampDP.Text.Substring(0, 1);
            cmd.Parameters.AddWithValue("@StampDuty_Payable",   stmp);
            var bcstamp = comboBox5BasisCalcSD.Text.Substring(0, 2);
            cmd.Parameters.AddWithValue("@Basis_Calc_SD",       bcstamp);
            cmd.Parameters.AddWithValue("@Filler2",             txtFiller2.Text);
            cmd.Parameters.AddWithValue("@MasterUniqNo",        txtBoxMastUniq01.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has saved in MFDT01 database");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtFileIntRefNo.Text = null;
            lblFileIdent.Text = null;
            txtISIN2.Text = null;
            txtTotAllQtyFL2.Text = null;
            txtAllQtyL2.Text = null;
            txtTotDedRec2.Text = null;
            txtTotIssAmt2.Text = null;
            txtPaidupAmt2.Text = null;
            txtFiller2.Text = null;
            txtBoxMastUniq01.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into MutualFunddt02 " +
                "(Record_Id,Dt_Line_No,DPID,CLID,CL_Acc_Cat,AllQty,Lockin_Reason_Code,Lockin_Release_Dt," +
                "Iss_Price,Iss_Amt,Paidup_Price,Paidup_Amt,Filler3,MasterUniqNo) " +

                "values(@Record_Id,@Dt_Line_No,@DPID,@CLID,@CL_Acc_Cat,@AllQty,@Lockin_Reason_Code," +
                "@Lockin_Release_Dt,@Iss_Price,@Iss_Amt,@Paidup_Price,@Paidup_Amt,@Filler3,@MasterUniqNo)", con);

            cmd.Parameters.AddWithValue("@Record_Id", lblRecordidenhd02.Text);
            cmd.Parameters.AddWithValue("@Dt_Line_No", txtDetRecLineNo.Text);
            cmd.Parameters.AddWithValue("@DPID", txtDpid3.Text);
            cmd.Parameters.AddWithValue("@CLID", txtClid3.Text);
            var claccat = comboBox3Cacategory.Text.Substring(0, 2);
            cmd.Parameters.AddWithValue("@CL_Acc_Cat", claccat);

            cmd.Parameters.AddWithValue("@AllQty", txtAllQty3.Text);
            var linrc = comboboxLockinreasoncode.Text.Substring(0, 2);
            cmd.Parameters.AddWithValue("@Lockin_Reason_Code", linrc);
            cmd.Parameters.AddWithValue("@Lockin_Release_Dt", dateTimePicker4.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Iss_Price", txtIssuePrice3.Text);
            cmd.Parameters.AddWithValue("@Iss_Amt", txtIssueAmt3.Text);
            cmd.Parameters.AddWithValue("@Paidup_Price", txtPaidupprice3.Text);
            cmd.Parameters.AddWithValue("@Paidup_Amt", txtPaidupAmt3.Text);
            cmd.Parameters.AddWithValue("@Filler3", txtFiller3.Text);
            cmd.Parameters.AddWithValue("@MasterUniqNo", txtMastUniqueNoHD02.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has saved in MFDT02 database");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblRecordidenhd02.Text = null;
            txtDetRecLineNo.Text = null;
            txtDpid3.Text = null;
            txtClid3.Text = null;
            txtAllQty3.Text = null;
            txtIssuePrice3.Text = null;
            txtIssueAmt3.Text = null;
            txtPaidupprice3.Text = null;
            txtPaidupAmt3.Text = null;
            txtFiller3.Text = null;
            txtMastUniqueNoHD02.Text = null;

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=VCCIPL-TECH\VENTURESQLEXP; Initial Catalog=VCCIPL ; Integrated Security=True;";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from MutualFundHD00 ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }

            //private void reconinfo_Load(object sender, EventArgs e)
            //{
            //    // TODO: This line of code loads data into the 'vCCIPLDataSet1.temp_recon' table. You can move, or remove it, as needed.
            //    this.temp_reconTableAdapter.Fill(this.vCCIPLDataSet1.temp_recon);

            //}
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=VCCIPL-TECH\VENTURESQLEXP; Initial Catalog=VCCIPL ; Integrated Security=True;";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from MutualFunddt01 ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView2.DataSource = dtbl;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=VCCIPL-TECH\VENTURESQLEXP; Initial Catalog=VCCIPL ; Integrated Security=True;";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from MutualFunddt02 ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView3.DataSource = dtbl;
            }
        }

        private void txtMastuniqNomf00_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtTotAllQtyFL2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtAllQtyL2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtTotDedRec2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtTotIssAmt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtPaidupAmt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtBoxMastUniq01_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtMastUniqueNoHD02_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtAllQty3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtIssuePrice3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtIssueAmt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtPaidupprice3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtPaidupAmt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }
    }
}
