using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using NPoco.Expressions;
//using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Countries
{


    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlCommandBuilder sqlBuilder1 = null;
        private SqlCommandBuilder sqlBuilder2 = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlDataAdapter sqlDataAdapter1 = null;
        private SqlDataAdapter sqlDataAdapter2 = null;
        private DataSet dataSet = null;
       // private DataSet dataSet2 = null;


        string nn;
        public async void button1_Click(object sender, EventArgs e)
        {
            nn = textBox1.Text;
            // textBox2.Text = nn;
            // string name = "France";
            string url = "https://restcountries.eu/rest/v2/name/" + nn + "?fullText=true";

            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/x-www-urlencoded";

            try
            {

                WebResponse response = await request.GetResponseAsync();






                string answer = string.Empty;

                using (Stream s = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        answer = await reader.ReadToEndAsync();
                    }
                }
                response.Close();


                string answerr = answer.Trim('[', ']');
                Open.Open o = JsonConvert.DeserializeObject<Open.Open>(answerr);
                label1.Text = o.name;
                label2.Text = o.alpha3Code;
                label3.Text = o.capital;
                label4.Text = o.area.ToString();
                label5.Text = o.population.ToString();
                label6.Text = o.region;

            





            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[Сountries]  ", sqlConnection);
            sqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM [dbo].[Cities] ", sqlConnection);
            sqlDataAdapter2 = new SqlDataAdapter("SELECT  * FROM [dbo].[Regions]", sqlConnection);

            sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlBuilder1 = new SqlCommandBuilder(sqlDataAdapter1);
            sqlBuilder2 = new SqlCommandBuilder(sqlDataAdapter2);

            sqlBuilder.GetInsertCommand();
            sqlBuilder.GetUpdateCommand();
            sqlBuilder1.GetInsertCommand();
            sqlBuilder1.GetUpdateCommand();
            sqlBuilder2.GetInsertCommand();
            sqlBuilder2.GetUpdateCommand();

            //Countries
            sqlDataAdapter.InsertCommand = new SqlCommand("Create", sqlConnection);
            sqlDataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Название", SqlDbType.NChar, 30, "Название"));
            sqlDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Код_страны", SqlDbType.NChar, 10, "Код_страны"));
            sqlDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Столица", SqlDbType.NChar, 30, "Столица"));
            sqlDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Площадь", SqlDbType.Float, 53, "Площадь"));
            sqlDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Население", SqlDbType.Int, 0, "Население"));
            sqlDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Регион", SqlDbType.NChar, 30, "Регион"));
            SqlParameter parameter = sqlDataAdapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            //Cities
            sqlDataAdapter1.InsertCommand = new SqlCommand("Create1", sqlConnection);
            sqlDataAdapter1.InsertCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter1.InsertCommand.Parameters.Add(new SqlParameter("@Название", SqlDbType.NChar, 30, "Название"));
            SqlParameter parameter1 = sqlDataAdapter1.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter1.Direction = ParameterDirection.Output;


            //Regions
            sqlDataAdapter2.InsertCommand = new SqlCommand("Create2", sqlConnection);
            sqlDataAdapter2.InsertCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter2.InsertCommand.Parameters.Add(new SqlParameter("@Название", SqlDbType.NChar, 30, "Название"));          
            SqlParameter parameter2 = sqlDataAdapter2.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter2.Direction = ParameterDirection.Output;



            dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet, "Countries");
            sqlDataAdapter1.Fill(dataSet, "Cities");
            sqlDataAdapter2.Fill(dataSet, "Regions");

            //Countries
            DataTable dt = dataSet.Tables["Countries"];
            DataRow newRow = dt.NewRow();
            newRow["Название"] = o.name;
            newRow["Код_страны"] = o.alpha3Code;
            newRow["Столица"] = o.capital;
            newRow["Площадь"] = o.area.ToString();
            newRow["Население"] = o.population.ToString();
            newRow["Регион"] = o.region;
            dt.Rows.Add(newRow);

            sqlDataAdapter.Update(dt);
            dt.AcceptChanges();

            //Cities
            DataTable dt1 = dataSet.Tables["Cities"];
            DataRow newRow1 = dt1.NewRow();
                    
                    newRow1["Название"] = o.capital;
                    dt1.Rows.Add(newRow1);
            
               

                sqlDataAdapter1.Update(dt1);
            dt1.AcceptChanges();


            //Regions
            DataTable dt2 = dataSet.Tables["Regions"];
            DataRow newRow2 = dt2.NewRow();
            newRow2["Название"] = o.region;
            dt2.Rows.Add(newRow2);

            sqlDataAdapter2.Update(dt2);
            dt2.AcceptChanges(); 
            
            
            }



             catch
            {
                MessageBox.Show("Страна не найдена! Введите корректное название.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nikita\source\repos\Countries\Countries\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();
            LoadData();

        }



        private void LoadData()
        {
           
        }





        public void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить в базу данных?", "Сохранение", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Form2 newForm = new Form2();
                newForm.dataGridView1.DataSource = dataSet.Tables["Countries"];
                newForm.dataGridView2.DataSource = dataSet.Tables["Cities"];
                newForm.dataGridView3.DataSource = dataSet.Tables["Regions"];
                newForm.Show();
            }
        }

        

        
    }
}
