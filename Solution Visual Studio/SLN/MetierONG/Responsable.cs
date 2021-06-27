using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonONG;
using AccessONG;
using System.Data;

namespace MetierONG
{
    public class Responsable
    {
        string _respocode;
        string _responom;
        string _respoprenom;

        public string respocode
        {
            get { return _respocode; }
            set { _respocode = value; }
        }
        public string responom
        {
            get { return _responom; }
            set { _responom = value; }
        }
        public string respoprenom
        {
            get { return _respoprenom; }
            set { _respoprenom = value; }
        }

        public void MapFromDataReader(IDataReader dreader)
        {
            if (!(DBNull.Value.Equals(dreader["respocode"])))
            {
                _respocode = (string)dreader["respocode"];
            }
            if (!(DBNull.Value.Equals(dreader["responom"])))
            {
                _responom = (string)dreader["responom"];
            }
            if (!(DBNull.Value.Equals(dreader["respoprenom"])))
            {
                _respoprenom = (string)dreader["respoprenom"];
            }

        }

        strResponsable MyStructure
        {
            get
            {
                strResponsable st = new strResponsable();
                st.RespoCode = this._respocode;
                st.RespoNom = this._responom;
                st.RespoPrenom = this._respoprenom;
                return st;
            }
        }

        public void Insert()
        {
            dbResponsable undbUser = new dbResponsable();
            undbUser.Insert(this.MyStructure);
        }

        public void Update()
        {
            dbResponsable undbUser = new dbResponsable();
            undbUser.Update(this.MyStructure);
        }

        public static DataTable SelectAll(string pRespoNom)
        {
            dbResponsable undbUser = new dbResponsable();
            DataTable dt = undbUser.SelectAll_Critere(pRespoNom);
            return dt;
        }

        public Responsable()
        {

        }

        public Responsable(string pRespoCode)
        {
            IDataReader dreader;
            dbResponsable dbUser = new dbResponsable();

            dreader = dbUser.GetObject(pRespoCode);
            if (dreader.Read())
            {
                this.MapFromDataReader(dreader);
            }
            dreader.Close();
        }
    }
}
