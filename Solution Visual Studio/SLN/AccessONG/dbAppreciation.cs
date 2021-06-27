using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using CommonONG;
namespace AccessONG
{
    public class dbAppreciation
    {
        SqlConnection SqlconX;
        public void CloseConnection()
        {
            if ((SqlconX != null) && (SqlconX.State == ConnectionState.Open))
            {
                SqlconX.Close();
            }
        }
        public string Insert(strAppreciation pAppreciation)
        {
            try
            {
                string constr = MesUtilitaires.GetConnectString();
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("SPX_Appreciation_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter prm;
                prm = new SqlParameter("@respocode", SqlDbType.VarChar, 20);
                prm.Value = pAppreciation.RespoCode;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@acticode", SqlDbType.VarChar, 20);
                prm.Value = pAppreciation.ActiCode;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@appreciationactivite", SqlDbType.Text);
                prm.Value = pAppreciation.AppreciationActivite;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@justifrecette", SqlDbType.Text);
                prm.Value = pAppreciation.JustifRecette;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@justifdepense", SqlDbType.Text);
                prm.Value = pAppreciation.JustifDepense;
                cmd.Parameters.Add(prm);
                string res = (string)cmd.ExecuteScalar();
                con.Close();
                return res;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                throw;
            }

        }
        public string Update(strAppreciation pAppreciation)
        {
            try
            {
                string constr = MesUtilitaires.GetConnectString();
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("SPX_Appreciation_UPDATE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter prm;
                prm = new SqlParameter("@respocode", SqlDbType.VarChar, 20);
                prm.Value = pAppreciation.RespoCode;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@acticode", SqlDbType.VarChar, 50);
                prm.Value = pAppreciation.ActiCode;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@appreciationactivite", SqlDbType.Text);
                prm.Value = pAppreciation.AppreciationActivite;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@justfirecette", SqlDbType.Text);
                prm.Value = pAppreciation.JustifRecette;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@justfidepense", SqlDbType.Text);
                prm.Value = pAppreciation.JustifDepense;
                cmd.Parameters.Add(prm);
                string res = (string)cmd.ExecuteScalar();
                con.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IDataReader GetObject(string pActicode)
        {
            IDataReader dr = null;
            string constr = MesUtilitaires.GetConnectString();
            SqlconX = new SqlConnection(constr);
            SqlconX.Open();
            SqlCommand cmd = new SqlCommand("SPX_Appreciation_GET", SqlconX);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prm;
            prm = new SqlParameter("@acticode", SqlDbType.VarChar, 20);
            prm.Value = pActicode;
            cmd.Parameters.Add(prm);
            dr = cmd.ExecuteReader();
            return dr;
        }

        public DataTable SelectAll_Critere(string pActicode)
        {
            string constr = MesUtilitaires.GetConnectString();
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SPX_Appreciation_GET", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prm;
            prm = new SqlParameter("@acticode", SqlDbType.VarChar, 20);
            prm.Value = pActicode;
            cmd.Parameters.Add(prm);
            DataTable dt;
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
