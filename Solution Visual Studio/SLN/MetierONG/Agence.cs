using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessONG;
using System.Data;

using CommonONG;
namespace MetierONG
{
    public class Agence
    {
        string _agencode;
        string _respocode;
        string _agenville;
        string _agenpays;
        string _agencontinent;

        public string agencode
        {
            get { return _agencode; }
            set { _agencode = value; }
        }
        public string respocode
        {
            get { return _respocode; }
            set { _respocode = value; }
        }
        public string agenville
        {
            get { return _agenville; }
            set { _agenville = value; }
        }
        public string agenpays
        {
            get { return _agenpays; }
            set { _agenpays = value; }
        }
        public string agencontinent
        {
            get { return _agencontinent; }
            set { _agencontinent = value; }
        }

        public void MapFromDataReader(IDataReader dreader)
        {
            if (!(DBNull.Value.Equals(dreader["agencode"])))
            {
                _agencode = (string)dreader["agencode"];
            }
            if (!(DBNull.Value.Equals(dreader["respocode"])))
            {
                _respocode = (string)dreader["respocode"];
            }
            if (!(DBNull.Value.Equals(dreader["agenville"])))
            {
                _agenville = (string)dreader["agenville"];
            }
            if (!(DBNull.Value.Equals(dreader["agenpays"])))
            {
                _agenpays = (string)dreader["agenpays"];
            }
            if (!(DBNull.Value.Equals(dreader["agencontinent"])))
            {
                _agencontinent = (string)dreader["agencontinent"];
            }

        }

        strAgence MyStructure
        {
            get
            {
                strAgence st = new strAgence();
                st.AgenCode = this._agencode;
                st.RespoCode = this._respocode;
                st.AgenVille = this._agenville;
                st.AgenPays = this._agenpays;
                st.AgenContinent = this._agencontinent;
                return st;
            }
        }

        public void Insert()
        {
            dbAgence undbUser = new dbAgence();
            undbUser.Insert(this.MyStructure);
        }

        public void Update()
        {
            dbAgence undbUser = new dbAgence();
            undbUser.Update(this.MyStructure);
        }

        public static DataTable SelectAll(string pAgenCode)
        {
            dbAgence undbUser = new dbAgence();
            DataTable dt = undbUser.SelectAll_Critere(pAgenCode);
            return dt;
        }

        public Agence()
        {

        }

        public Agence(string pRespoCode)
        {
            IDataReader dreader;
            dbAgence dbUser = new dbAgence();

            dreader = dbUser.GetObject(pRespoCode);
            if (dreader.Read())
            {
                this.MapFromDataReader(dreader);
            }
            dreader.Close();
        }
    }
}
