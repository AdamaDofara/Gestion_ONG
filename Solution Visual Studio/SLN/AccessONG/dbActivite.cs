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
    public class dbActivite
    {
        SqlConnection SqlconX;
        public void CloseConnection()
        {
            if ((SqlconX != null) && (SqlconX.State == ConnectionState.Open))
            {
                SqlconX.Close();
            }
        }
        public string Insert(strActivite pActi)
        {
            try
            {
                string constr = MesUtilitaires.GetConnectString();
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("SPX_Activite_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter prm;
                prm = new SqlParameter("@acticode", SqlDbType.VarChar, 20);
                prm.Value = pActi.ActiCode;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@agencode", SqlDbType.VarChar, 50);
                prm.Value = pActi.AgenCode;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@actidate", SqlDbType.DateTime);
                prm.Value = pActi.ActiDate;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@actirecette", SqlDbType.Int);
                prm.Value = pActi.ActiRecette;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@actidepense", SqlDbType.Int);
                prm.Value = pActi.ActiRecette;
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
        public string Update(strActivite pActi)
        {
            try
            {
                string constr = MesUtilitaires.GetConnectString();
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("SPX_Activite_UPDATE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter prm;
                prm = new SqlParameter("@acticode", SqlDbType.VarChar, 20);
                prm.Value = pActi.ActiCode;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@agencode", SqlDbType.VarChar, 20);
                prm.Value = pActi.AgenCode;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@actidate", SqlDbType.DateTime);
                prm.Value = pActi.ActiDate;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@actirecette", SqlDbType.Int);
                prm.Value = pActi.ActiRecette;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@actidepense", SqlDbType.Int);
                prm.Value = pActi.ActiDepense;
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
        public IDataReader GetObject(string pacticode)
        {
            IDataReader dr = null;
            string constr = MesUtilitaires.GetConnectString();
            SqlconX = new SqlConnection(constr);
            SqlconX.Open();
            SqlCommand cmd = new SqlCommand("SPX_Activite_GET", SqlconX);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prm;
            prm = new SqlParameter("@acticode", SqlDbType.VarChar, 20);
            prm.Value = pacticode;
            cmd.Parameters.Add(prm);
            dr = cmd.ExecuteReader();
            return dr;
        }

        public DataTable SelectAll_Critere(string pActiCode)
        {
            string constr = MesUtilitaires.GetConnectString();
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SPX_Activite_GET", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prm;
            prm = new SqlParameter("@acticode", SqlDbType.VarChar, 20); ;
            prm.Value = pActiCode;
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
