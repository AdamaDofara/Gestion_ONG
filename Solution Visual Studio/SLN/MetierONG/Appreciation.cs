using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using AccessONG;
using CommonONG;
namespace MetierONG
{
    public class Appreciation
    {
        string _respocode;
        string _acticode;
        string _appreciationactivite;
        string _justifrecette;
        string _justifdepense;

        public string respocode
        {
            get { return _respocode; }
            set { _respocode = value; }
        }
        public string acticode
        {
            get { return _acticode; }
            set { _acticode = value; }
        }
        public string appreciationactivite
        {
            get { return _appreciationactivite; }
            set { _appreciationactivite = value; }
        }
        public string justifrecette
        {
            get { return _justifrecette; }
            set { _justifrecette = value; }
        }
        public string justifdepense
        {
            get { return _justifdepense; }
            set { _justifdepense = value; }
        }

        public void MapFromDataReader(IDataReader dreader)
        {
            if (!(DBNull.Value.Equals(dreader["respocode"])))
            {
                _respocode = (string)dreader["respocode"];
            }
            if (!(DBNull.Value.Equals(dreader["acticode"])))
            {
                _acticode = (string)dreader["acticode"];
            }
            if (!(DBNull.Value.Equals(dreader["appreciationactivite"])))
            {
                _appreciationactivite = (string)dreader["appreciationactivite"];
            }
            if (!(DBNull.Value.Equals(dreader["justifrecette"])))
            {
                _justifrecette = (string)dreader["justifrecette"];
            }
            if (!(DBNull.Value.Equals(dreader["justifdepense"])))
            {
                _justifdepense = (string)dreader["justifdepense"];
            }

        }

        strAppreciation MyStructure
        {
            get
            {
                strAppreciation st = new strAppreciation();
                st.RespoCode = this._respocode;
                st.ActiCode = this._respocode;
                st.AppreciationActivite = this._appreciationactivite;
                st.JustifRecette = this._justifrecette;
                st.JustifDepense = this._justifdepense;
                return st;
            }
        }

        public void Insert()
        {
            dbAppreciation undbUser = new dbAppreciation();
            undbUser.Insert(this.MyStructure);
        }

        public void Update()
        {
            dbAppreciation undbUser = new dbAppreciation();
            undbUser.Update(this.MyStructure);
        }

        public static DataTable SelectAll(string pacticode)
        {
            dbAppreciation undbUser = new dbAppreciation();
            DataTable dt = undbUser.SelectAll_Critere(pacticode);
            return dt;
        }

        public Appreciation()
        {

        }

        public Appreciation(string pActiCode)
        {
            IDataReader dreader;
            dbAppreciation dbUser = new dbAppreciation();

            dreader = dbUser.GetObject(pActiCode);
            if (dreader.Read())
            {
                this.MapFromDataReader(dreader);
            }
            dreader.Close();
        }
    }
}
