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
    public class dbResponsable
    {
        SqlConnection SqlconX;
        public void CloseConnection()
        {
            if ((SqlconX != null) && (SqlconX.State == ConnectionState.Open))
            {
                SqlconX.Close();
            }
        }
        public string Insert(strResponsable pRespo)
        {
            try
            {
                string constr = MesUtilitaires.GetConnectString();
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("SPX_Responsable_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter prm;
                prm = new SqlParameter("@respocode", SqlDbType.VarChar, 20);
                prm.Value = pRespo.RespoCode;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@responom", SqlDbType.VarChar, 50);
                prm.Value = pRespo.RespoNom;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@respoprenom", SqlDbType.VarChar, 50);
                prm.Value = pRespo.RespoPrenom;
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
        public string Update(strResponsable pUnRespo)
        {
            try
            {
                string constr = MesUtilitaires.GetConnectString();

                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("SPX_Responsable_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter prm;

                prm = new SqlParameter("@respocode", SqlDbType.VarChar, 10);
                prm.Value = pUnRespo.RespoCode;
                cmd.Parameters.Add(prm);

                prm = new SqlParameter("@responom", SqlDbType.VarChar, 50);
                prm.Value = pUnRespo.RespoNom;
                cmd.Parameters.Add(prm);

                prm = new SqlParameter("@respoprenom", SqlDbType.VarChar, 50);
                prm.Value = pUnRespo.RespoPrenom;
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

        public IDataReader GetObject(string prespoCode)
        {
            IDataReader dr = null;
            string constr = MesUtilitaires.GetConnectString();
            SqlconX = new SqlConnection(constr);
            SqlconX.Open();
            SqlCommand cmd = new SqlCommand("SPX_Responsable_GET", SqlconX);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prm;
            prm = new SqlParameter("@respocode", SqlDbType.VarChar, 20);
            prm.Value = prespoCode;
            cmd.Parameters.Add(prm);
            dr = cmd.ExecuteReader();
            return dr;
        }

        public DataTable SelectAll_Critere(string pResponsableNom)
        {
            string constr = MesUtilitaires.GetConnectString();
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SPX_Responsable_GET_NAME", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prm;
            prm = new SqlParameter("@responom", SqlDbType.VarChar, 50);
            prm.Value = pResponsableNom;
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


