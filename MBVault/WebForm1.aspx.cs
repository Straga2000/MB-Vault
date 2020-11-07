using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Ajax.Utilities;
using System.Drawing;

namespace MBVault
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MBVault.mdf;Integrated Security=True");

        Dictionary<string, DataObject> dataObjects; // public Map<String, Dictionary> dic = new HashMap();

        Dictionary<string, Dictionary<int, Dictionary<string, DataObject>>> boolValues;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            sqlConnection.Open();

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            var id = id;
            dataObjects[id].IfNull(data =>
            {
                data.firstname = firstname.Text;
                data.lastname = lastname.Text;
                data.region = region.Text;
                data.email = email.Text;
                data.phone = phone.Text;
                data.address = address.Text;
                data.cnp = cnp.Text;
                data.postalcode = postalcode.Text;
                data.idcard_series = idcard_series.Text;
                data.idcard_number = idcard_number.Text;
                data.birthday_date = birthday_date.Text;
                data.sex = sex.Text;
                data.city = city.Text;
                data.county = county.Text;
                data.country = country.Text;
                data.password = password.Text;

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "insert into Table values ('" + firstname.Text +
                    "' , '" + lastname.Text +
                    "' , '" + email.Text +
                    "' , '" + phone.Text +
                    "' , '" + address.Text +
                    "' , '" + cnp.Text +
                    "' , '" + postalcode.Text +
                    "' , '" + idcard_series.Text +
                    "' , '" + idcard_number.Text +
                    "' , '" + birthday_date.Text +
                    "' , '" + sex.Text +
                    "' , '" + city.Text +
                    "' , '" + county.Text +
                    "' , '" + country.Text +
                    "' , '" + password.Text + "')";
                sqlCommand.ExecuteNonQuery();
            });

            dataObjects[id].firstname = firstname.Text;
            dataObjects[id].lastname = lastname.Text;
            dataObjects[id].region = region.Text;
            dataObjects[id].email = email.Text;
            dataObjects[id].phone = phone.Text;
            dataObjects[id].address = address.Text;
            dataObjects[id].cnp = cnp.Text;
            dataObjects[id].postalcode = postalcode.Text;
            dataObjects[id].idcard_series = idcard_series.Text;
            dataObjects[id].idcard_number = idcard_number.Text;
            dataObjects[id].birthday_date = birthday_date.Text;
            dataObjects[id].sex = sex.Text;
            dataObjects[id].city = city.Text;
            dataObjects[id].county = county.Text;
            dataObjects[id].country = country.Text;
            dataObjects[id].password = password.Text;

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "update Table values set ('lastname='" + lastname.Text +
                "' , 'email=" + email.Text +
                "' , 'phone=" + phone.Text +
                "' , 'address=" + address.Text +
                "' , 'cnp=" + cnp.Text +
                "' , 'postalcode" + postalcode.Text +
                "' , 'idcard_series" + idcard_series.Text +
                "' , 'idcard_number" + idcard_number.Text +
                "' , 'birthday_date" + birthday_date.Text +
                "' , 'sex=" + sex.Text +
                "' , 'city=" + city.Text +
                "' , 'county=" + county.Text +
                "' , 'country=" + country.Text +
                "' , 'password=" + password.Text + "') " +
                "WHERE id=" + id;
            sqlCommand.ExecuteNonQuery();

        }

        protected void UploadData()
        {

            var id= id;
            using (SqlConnection myConnection = sqlConnection)
            {
                string oString = "Select * from Table where id=@id";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Fname", id);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        dataObjects[id].firstName = oReader["firstname"].ToString();
                        dataObjects[id].lastName = oReader["lastname"].ToString();
                        dataObjects[id].region = oReader["region"].ToString();
                        dataObjects[id].email = oReader["email"].ToString();
                        dataObjects[id].phone = oReader["phone"];
                        dataObjects[id].address = oReader["address"].ToString();
                        dataObjects[id].cnp = oReader["cnp"];
                        dataObjects[id].postalcode = oReader["postalcode"].ToString();
                        dataObjects[id].idcard_series = oReader["idcard_series"].ToString();
                        dataObjects[id].idcard_number = oReader["idcard_number"].ToString();
                        dataObjects[id].birthday_date = oReader["birthday_date"].ToString();
                        dataObjects[id].sex = oReader["sex"].ToString();
                        dataObjects[id].city = oReader["sex"].ToString();
                        dataObjects[id].county = oReader["county"].ToString();
                        dataObjects[id].country = oReader["country"].ToString();
                        dataObjects[id].password = oReader["password"].ToString();
                    }

                    myConnection.Close();
                }
            }
        }
    }
}