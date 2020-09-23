using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CWav
{
    public class clsXls
    {
        public static byte[] ReadXls(string sPathFileName)
        {
            if (sPathFileName != "")
            {
                try
                {
                    DataSet ds = new DataSet();
                    OleDbConnection conexao = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + sPathFileName + ";" + "Extended Properties=Excel 8.0;");
                    OleDbDataAdapter da = new OleDbDataAdapter("Select * From [Plan1$]", conexao);
                    da.Fill(ds);

                    int iPos = 0;
                    byte[] bColumm = new byte[ds.Tables[0].Rows.Count * 2];
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        byte[] bByte = clsWav.PackageInt(Convert.ToInt32(row["F1"]));
                        //Array.Reverse(bByte);
                        Array.Copy(bByte, 0, bColumm, iPos, bByte.Length);
                        iPos += bByte.Length;
                    }
                    conexao.Close();
                    return bColumm;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro(ReadXls): " + ex.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }
    }
}
