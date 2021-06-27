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
    public class dbAgence
    {
        SqlConnection SqlconX;
        public void CloseConnection()
        {
            if ((SqlconX != null) && (SqlconX.State == ConnectionState.Open))
            {
                SqlconX.Close();
            }
        }
        public string Insert(strAgence pRespo)
        {
            try
            {
                string constr = MesUtilitaires.GetConnectString();
                SqlConnection con = new SqlConnection(constr);
                con.Open();

                SqlCommand cmd = new SqlCommand("SPX_Agence_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter prm;

                prm = new SqlParameter("@agencode", SqlDbType.VarChar, 20);
                prm.Value = pRespo.AgenCode;
                cmd.Parameters.Add(prm);

                prm = new SqlParameter("@respocode", SqlDbType.VarChar, 20);
                prm.Value = pRespo.RespoCode;
                cmd.Parameters.Add(prm);

                prm = new SqlParameter("@agenville", SqlDbType.VarChar, 30);
                prm.Value = pRespo.AgenVille;
                cmd.Parameters.Add(prm);

                prm = new SqlParameter("@agenpays", SqlDbType.VarChar, 30);
                prm.Value = pRespo.AgenPays;
                cmd.Parameters.Add(prm);

                prm = new SqlParameter("@agencontinent", SqlDbType.VarChar, 30);
                prm.Value = pRespo.AgenContinent;
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
        public string Update(strAgence pRespo)
        {
            try
            {
                string constr = MesUtilitaires.GetConnectString();
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("SPX_Agence_UPDATE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter prm;
                prm = new SqlParameter("@agencode", SqlDbType.VarChar, 20);
                prm.Value = pRespo.AgenCode;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@respocode", SqlDbType.VarChar, 20);
                prm.Value = pRespo.RespoCode;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@agenville", SqlDbType.VarChar, 30);
                prm.Value = pRespo.AgenVille;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@agenpays", SqlDbType.VarChar, 30);
                prm.Value = pRespo.AgenPays;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@agencontinent", SqlDbType.VarChar, 30);
                prm.Value = pRespo.AgenContinent;
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
        public IDataReader GetObject(string pagenCode)
        {
            IDataReader dr = null;
            string constr = MesUtilitaires.GetConnectString();
            SqlconX = new SqlConnection(constr);
            SqlconX.Open();
            SqlCommand cmd = new SqlCommand("SPX_Agence_GET", SqlconX);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prm;
            prm = new SqlParameter("@agencode", SqlDbType.VarChar, 20);
            prm.Value = pagenCode;
            cmd.Parameters.Add(prm);
            dr = cmd.ExecuteReader();
            return dr;
        }

        public DataTable SelectAll_Critere(string pagenville)
        {
            string constr = MesUtilitaires.GetConnectString();
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SPX_Agence_GET_VILLE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prm;
            prm = new SqlParameter("@agenville", SqlDbType.VarChar, 20); ;
            prm.Value = pagenville;
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
  
