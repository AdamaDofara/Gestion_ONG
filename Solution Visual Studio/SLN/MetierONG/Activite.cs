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
    public class Activite
    {
        string _acticode;
        string _agencode;
        DateTime _actidate;
        int _actirecette;
        int _actidepense;

        public string acticode
        {
            get { return _acticode; }
            set { _acticode = value; }
        }
        public string agencode
        {
            get { return _agencode; }
            set { _agencode = value; }
        }
        public DateTime actidate
        {
            get { return _actidate; }
            set { _actidate = value; }
        }
        public int actirecette
        {
            get { return _actirecette; }
            set { _actirecette = value; }
        }
        public int actidepense
        {
            get { return _actidepense; }
            set { _actidepense = value; }
        }

        public void MapFromDataReader(IDataReader dreader)
        {
            if (!(DBNull.Value.Equals(dreader["acticode"])))
            {
                _acticode = (string)dreader["acticode"];
            }
            if (!(DBNull.Value.Equals(dreader["agencode"])))
            {
                _agencode = (string)dreader["agencode"];
            }
            if (!(DBNull.Value.Equals(dreader["actidate"])))
            {
                _actidate = (DateTime)dreader["actidate"];
            }
            if (!(DBNull.Value.Equals(dreader["actirecette"])))
            {
                _actirecette = (int)dreader["actirecette"];
            }
            if (!(DBNull.Value.Equals(dreader["actidepense"])))
            {
                _actidepense = (int)dreader["actidepense"];
            }

        }

        strActivite MyStructure
        {
            get
            {
                strActivite st = new strActivite();
                st.ActiCode = this._acticode;
                st.AgenCode = this._agencode;
                st.ActiDate = this._actidate;
                st.ActiRecette = this._actirecette;
                st.ActiDepense = this._actidepense;
                return st;
            }
        }

        public void Insert()
        {
            dbActivite undbUser = new dbActivite();
            undbUser.Insert(this.MyStructure);
        }

        public void Update()
        {
            dbActivite undbUser = new dbActivite();
            undbUser.Update(this.MyStructure);
        }

        public static DataTable SelectAll(string pacticode)
        {
            dbActivite undbUser = new dbActivite();
            DataTable dt = undbUser.SelectAll_Critere(pacticode);
            return dt;
        }

        public Activite()
        {

        }

        public Activite(string pacticode)
        {
            IDataReader dreader;
            dbActivite dbUser = new dbActivite();

            dreader = dbUser.GetObject(pacticode);
            if (dreader.Read())
            {
                this.MapFromDataReader(dreader);
            }
            dreader.Close();
        }
    }
}
