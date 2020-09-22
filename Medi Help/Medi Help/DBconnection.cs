using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace Medi_Help
{
    class DBconnection
    {

        //public string conString = "Server=tcp:anushika.database.windows.net,1433;Initial Catalog=MediHelp;Persist Security Info=False;User ID=anushika;Password=im/2017/065;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //public string conString = "Data Source=ANUSHH-IKKE;Initial Catalog=MediHelp;Integrated Security=True";

        
        public string conString = "Server=tcp:mnksql.database.windows.net,1433;Initial Catalog=MediHelp;Persist Security Info=False;User ID=mnk;Password=MitMediHelp1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

 

        public SqlConnection getConnection()
        {

            SqlConnection con = new SqlConnection(conString);
            
            con.Open();
            return con;
            
        }
        

        //*************Employees Registration************//


        public void addEmployees(employee obj)
        {

            String sqlQuery = "INSERT INTO dbo.Employee(EmployeeNic,Name,Dob,Email,Phone,EmployeeType,UserName,Password,Photo) " +

            //"VALUES ('" + obj.ENic + "','" + obj.Name + "','" + obj.Dob + "','" + obj.Email + "','" + obj.Phone + "','" + obj.EmployeeType + "','" + obj.UserName + "','" + obj.Password + "',CONVERT(VARBINARY(25), '" + obj.Picture + "', 1))"; 

            "VALUES ('" + obj.ENic + "','" + obj.Name + "','" + obj.Dob + "','" + obj.Email + "','" + obj.Phone + "','" + obj.EmployeeType + "','" + obj.UserName + "','" + obj.Password + "','" + obj.Photo + "')";


            SqlCommand cmd1 = new SqlCommand(sqlQuery, getConnection());
            cmd1.ExecuteNonQuery();
            getConnection().Close();
        }

        public bool checkUserName(string userName)
        {
            string query1 = "IF OBJECT_ID('dbo.Employee', 'U') IS NOT NULL SELECT COUNT(*) FROM dbo.Employee WHERE username='" + userName + "' ";
            string query = "IF OBJECT_ID('dbo.Employee', 'U') IS NULL ";
            query += "BEGIN ";
            query += "CREATE TABLE [dbo].[Employee](";
            query += "[EmployeeNic] VARCHAR(25)  NOT NULL CONSTRAINT pkempId PRIMARY KEY,";
            query += "[Name] VARCHAR(100) NOT NULL,";
            query += "[Dob] VARCHAR(100) NOT NULL,";
            query += "[Email] VARCHAR(100) NOT NULL,";
            query += "[Phone] INT NOT NULL,";
            query += "[EmployeeType] VARCHAR(100) NOT NULL,";
            query += "[UserName] VARCHAR(100), "; 
            query += "[Password] VARCHAR(100), ";
            query += "[Photo] IMAGE ";
            query += ")";
            query += " END";
            getConnection();
            SqlCommand cmd = new SqlCommand(query, getConnection());
            cmd.ExecuteNonQuery();



            SqlDataAdapter sda = new SqlDataAdapter(query1, getConnection());

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void addChemicalsAndEquipments(chemicalsAndEquipments obj)
        {
            string query = "IF OBJECT_ID('dbo.ChemicalsAndEquipments', 'U') IS NULL ";
            query += "BEGIN ";
            query += "CREATE TABLE [dbo].[ChemicalsAndEquipments](";
            query += "[Name] VARCHAR(250)  NOT NULL CONSTRAINT pkId PRIMARY KEY,";
            query += "[Date] VARCHAR(25) NOT NULL,";
            query += "[Price] VARCHAR(100) NOT NULL,";
            query += "[Quantity] VARCHAR(20) NOT NULL,";
            query += "[EmployeeNic] VARCHAR(25)  NOT NULL CONSTRAINT fpkempId FOREIGN KEY (EmployeeNic) REFERENCES dbo.Employee(EmployeeNic),";
            query += "[Reference] VARCHAR(1000) ,";
            query += ")";
            query += " END";
            Console.WriteLine(obj.Name);
            String sqlQuery = "INSERT INTO dbo.ChemicalsAndEquipments(Name,Date,Price,Quantity,EmployeeNic,Reference) " +
            "VALUES ('" + obj.Name + "','" + obj.Date + "','" + obj.Price + "','" + obj.Quantity + "','" + obj.User + "','" + obj.Reference + "')";

            getConnection();
            SqlCommand cmd = new SqlCommand(query, getConnection());
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand(sqlQuery, getConnection());
            cmd1.ExecuteNonQuery();
            getConnection().Close();
        }

        public void updateChemicalAndEquipment(string cName, string quantity)
        {
            string upQuery = "UPDATE dbo.ChemicalsAndEquipments SET Quantity='" + quantity + "' WHERE Name='" + cName + "'";
            SqlCommand cmd1 = new SqlCommand(upQuery, getConnection());
            cmd1.ExecuteNonQuery();
            getConnection().Close();
        }

        public string getCurrentQuantity(string name)
        {
  
            string query= "SELECT Quantity FROM dbo.ChemicalsAndEquipments WHERE Name='" + name + "'";
            string quantity="";



            SqlDataAdapter sda = new SqlDataAdapter(query, getConnection());

            DataTable dt = new DataTable();
            sda.Fill(dt);
            
                quantity = dt.Rows[0][0].ToString(); //Use this requiredUserId in your next form!!
            

            return quantity;

        }

        public bool findChemicalEquipment(string cName)
        {
            string query = "IF OBJECT_ID('dbo.ChemicalsAndEquipments', 'U') IS NULL ";
            query += "BEGIN ";
            query += "CREATE TABLE [dbo].[ChemicalsAndEquipments](";
            query += "[Name] VARCHAR(250)  NOT NULL CONSTRAINT pkId PRIMARY KEY,";
            query += "[Date] VARCHAR(25) NOT NULL,";
            query += "[Price] VARCHAR(100) NOT NULL,";
            query += "[Quantity] VARCHAR(20) NOT NULL,";
            query += "[EmployeeNic] VARCHAR(25)  NOT NULL CONSTRAINT fpkempId FOREIGN KEY (EmployeeNic) REFERENCES dbo.Employee(EmployeeNic),";
            query += "[Reference] VARCHAR(1000) ,";
            query += ")";
            query += " END";
            string query1 = "IF OBJECT_ID('dbo.ChemicalsAndEquipments', 'U') IS NOT NULL SELECT COUNT(*) FROM dbo.ChemicalsAndEquipments WHERE Name='" + cName + "'";

            SqlCommand cmd = new SqlCommand(query, getConnection());
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(query1, getConnection());

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //*****user login****// 
        public bool adminLogin(login obj)
        {
            
            string query = "SELECT COUNT(*) FROM dbo.Employee WHERE username='" + obj.UserName + "' AND password='" + obj.Password + "'";

            string query1 = "SELECT EmployeeNic FROM dbo.Employee WHERE username='" + obj.UserName + "' AND password='" + obj.Password + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query,getConnection());

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlCommand command = new SqlCommand(query1, getConnection());
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine("qwerrr"+String.Format("{0}", reader["EmployeeNic"]));
                        string loggedInUser = String.Format("{0}", reader["EmployeeNic"]);
                        global.UserID = loggedInUser;

                    }
                }
                return true;
            }
            else
            {  
                return false;
            }

            

        }


        //*****add bills to the database****//
        public void addInvoice(bill obj)
        {
            string query = "IF OBJECT_ID('dbo.Invoice', 'U') IS NULL ";
            query += "BEGIN ";
            query += "CREATE TABLE [dbo].[Invoice](";
            query += "[BillNo] VARCHAR(25)  NOT NULL CONSTRAINT pkbillno PRIMARY KEY,";
            query += "[Date] VARCHAR(50) NOT NULL,";
            query += "[RequiredDate] VARCHAR(25) NOT NULL,";
            query += "[EmployeeNic] VARCHAR(25) NOT NULL CONSTRAINT pkemplId FOREIGN KEY (EmployeeNic) REFERENCES dbo.Employee(EmployeeNic),";
            query += "[PatientNic] VARCHAR(25) NOT NULL CONSTRAINT pkpatintnic FOREIGN KEY (PatientNic) REFERENCES dbo.Patient(PatientNic),";
            query += "[Total] float(53) NOT NULL,";
            query += "[Description] VARCHAR(250)  NOT NULL";
            query += ")";
            query += " END";

            String sqlQuery = "INSERT INTO dbo.Invoice(BillNo,Date,RequiredDate,EmployeeNic,PatientNic,Total,Description) " +
            "VALUES ('" + obj.BillNo + "','" + obj.TimeDate+ "','" + obj.RequiredDate + "','" + global.UserID + "','" + obj.Patientnic + "','" + obj.Total+ "','" + obj.Description + "')";

            getConnection();
            SqlCommand cmd = new SqlCommand(query, getConnection());
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand(sqlQuery, getConnection());
            cmd1.ExecuteNonQuery();
            getConnection().Close();
        }


        //**** add patient details to the database****//
        public void addPatient(bill obj)
        {
            

            String sqlQuery = "INSERT INTO dbo.Patient(PatientNic,Name,Dob,Gender,Address,Phone) " +
            "VALUES ('" + obj.Patientnic + "','" + obj.PatientName+ "','" + obj.PatientDob + "','" + obj.PatientGender + "','" + obj.PatientAddress + "','" + obj.PatientContact + "')";

            
            SqlCommand cmd1 = new SqlCommand(sqlQuery, getConnection());
            cmd1.ExecuteNonQuery();
            getConnection().Close();
        }


        //****add report details to the database****//
        public void Report(report obj)
        {
            string query = "IF OBJECT_ID('dbo.Report', 'U') IS NULL ";
            query += "BEGIN ";
            query += "CREATE TABLE [dbo].[Report](";
            query += "[ReportNumber] VARCHAR(1000)  NOT NULL ,";
            query += "[PatientNic] VARCHAR(25) NOT NULL,";
            query += "[ReportName] VARCHAR(100) NOT NULL,";
            query += "[RequiredDate] VARCHAR(100) ,";
            query += "[FinishedDate] VARCHAR(100) ,";
            query += "[ReportDocument] varbinary(MAX) ,";
            query += "CONSTRAINT pkreport PRIMARY KEY (ReportNumber,PatientNic)";
            query += ")";
            query += " END";

            String sqlQuery = "INSERT INTO dbo.Report(ReportNumber,PatientNic,ReportName,RequiredDate) " +
            "VALUES ('" + obj.ReportNumber + "','" + obj.PatientNic + "','" + obj.ReportName + "','" + obj.RequiredDate + "')";

            //Console.WriteLine("\nokay: " + obj.Reportnumber + "', '" + obj.PatientNic + "', '" + obj.Reportname + "', '" + obj.Requireddate);


            getConnection();
            SqlCommand cmd = new SqlCommand(query, getConnection());
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand(sqlQuery, getConnection());
            cmd1.ExecuteNonQuery();
            getConnection().Close();

        }

        //****cashier search patient****//
        public bool searchPatient(string search)
        {
            string query = "IF OBJECT_ID('dbo.Patient', 'U') IS NULL ";
            query += "BEGIN ";
            query += "CREATE TABLE [dbo].[Patient](";
            query += "[PatientNic] VARCHAR(25)  NOT NULL CONSTRAINT pkpatientnic PRIMARY KEY,";
            query += "[Name] VARCHAR(25) NOT NULL,";
            query += "[Dob] VARCHAR(25) NOT NULL,";
            query += "[Gender] VARCHAR(100) NOT NULL,";
            query += "[Address] VARCHAR(100) NOT NULL,";
            query += "[Phone] INT NOT NULL,";
            query += ")";
            query += " END";

            getConnection();
            SqlCommand cmd = new SqlCommand(query, getConnection());
            cmd.ExecuteNonQuery();


            string query1 = "SELECT COUNT(*) FROM dbo.Patient WHERE PatientNic='" + search +  "'";

            SqlDataAdapter sda = new SqlDataAdapter(query1, getConnection());

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        //****get patient details****//

        public ArrayList getPatientDetails(string patientNic)
        {
            ArrayList array = new ArrayList();

            string query1 = "SELECT Name FROM dbo.Patient WHERE PatientNic='" + patientNic + "'";
            SqlCommand command = new SqlCommand(query1, getConnection());
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine("name: \n" + String.Format("{0}", reader["Name"]));
                    array.Add ( String.Format("{0}", reader["Name"]));
                }
            }

            string query2 = "SELECT Dob FROM dbo.Patient WHERE PatientNic='" + patientNic + "'";
            SqlCommand command1 = new SqlCommand(query2, getConnection());
            using (SqlDataReader reader = command1.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine("dob: \n" + String.Format("{0}", reader["Dob"]));
                    array.Add(String.Format("{0}", reader["Dob"]));
                }
            }


            string query3 = "SELECT Gender FROM dbo.Patient WHERE PatientNic='" + patientNic + "'";
            SqlCommand command3 = new SqlCommand(query3, getConnection());
            using (SqlDataReader reader = command3.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine("gender: \n" + String.Format("{0}", reader["Gender"]));
                    array.Add(String.Format("{0}", reader["Gender"]));
                }
            }

            string query4 = "SELECT Address FROM dbo.Patient WHERE PatientNic='" + patientNic + "'";
            SqlCommand command4 = new SqlCommand(query4, getConnection());
            using (SqlDataReader reader = command4.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine("address: \n" + String.Format("{0}", reader["Address"]));
                    array.Add(String.Format("{0}", reader["Address"]));
                }
            }

            string query5 = "SELECT Phone FROM dbo.Patient WHERE PatientNic='" + patientNic + "'";
            SqlCommand command5 = new SqlCommand(query5, getConnection());
            using (SqlDataReader reader = command5.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine("Phone: \n" + String.Format("{0}", reader["Phone"]));
                    array.Add(String.Format("{0}", reader["Phone"]));
                }
            }

            return array;
        }


        //price list
        public void insertPricesFirstTime(string reportName, double price)
        {
            string query2 = "INSERT INTO dbo.PriceList(ReportName,Price) " +
            "VALUES ('" + reportName + "','" + price + "')";
            getConnection();
            SqlCommand cmd2 = new SqlCommand(query2, getConnection());
            cmd2.ExecuteNonQuery();
            getConnection().Close();
        }


        //get price to cashier
        public double getprice(string reportName)
        {
            double price = 0;
            string query1 = "SELECT Price FROM dbo.PriceList WHERE ReportName='" + reportName + "'";

            SqlCommand command = new SqlCommand(query1, getConnection());
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string price1 = String.Format("{0}", reader["Price"]);
                    price = Convert.ToDouble(price1);

                    return price;

                }
                else
                {
                    return price;
                }
            }


        }


        //update price list
        public void updatePriceList(string reportName,double price)
        {
            string query = "UPDATE dbo.PriceList SET Price='" + price + "' WHERE ReportName='" + reportName + "'";

            getConnection();
            SqlCommand cmd = new SqlCommand(query, getConnection());
            cmd.ExecuteNonQuery();


        }

        public void priceList()
        {
            string query = "IF OBJECT_ID('dbo.PriceList', 'U') IS NULL ";
            query += "BEGIN ";
            query += "CREATE TABLE [dbo].[PriceList](";
            query += "[ReportName] VARCHAR(100) NOT NULL CONSTRAINT pkreportname PRIMARY KEY,";
            query += "[Price] float(53) NOT NULL,";
            query += ")";
            query += " END";

            

            getConnection();
            SqlCommand cmd = new SqlCommand(query, getConnection());
            cmd.ExecuteNonQuery();
            


            string query3 = "SELECT COUNT(*) FROM [dbo].[PriceList] WITH (NOLOCK)";


            SqlDataAdapter sda = new SqlDataAdapter(query3, getConnection());

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "0")
            {
                //Console.WriteLine("lines: " + dt.Rows[0][0].ToString());
                insertPricesFirstTime("Lipid Profile",500.15);
                insertPricesFirstTime("Urine protein ratio",1000);
                insertPricesFirstTime("Vitamine B12-Serum",450.25);

                insertPricesFirstTime("Ionized Calcium",600);
                insertPricesFirstTime("Serum Ferritin",1000.78);
                insertPricesFirstTime("Thyroid Profile",1500);

            }
            else
            {
                return;
                //Console.WriteLine("lines: " + dt.Rows[0][0].ToString());
            }
            getConnection().Close();


        }

        //***display available reports to casheir***//

        public SqlCommand displayAvailableReports()
        {
            string qr = "IF OBJECT_ID('dbo.Report', 'U') IS NOT NULL select i.Date,r.ReportNumber,p.Name,p.PatientNic," +
                "r.ReportName,r.RequiredDate,r.FinishedDate from Patient p inner join " +
                " Report r on p.PatientNic = r.PatientNic inner join Invoice i on p.PatientNic = i.PatientNic WHERE r.FinishedDate IS NULL; ";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "IF OBJECT_ID('dbo.Report', 'U') IS NOT NULL select * from Report";
            cmd.CommandText = qr;
            cmd.ExecuteNonQuery();
            
            return cmd;
        }

        //display price list

        public SqlCommand diplayPriceList()
        {
            string qr = "IF OBJECT_ID('dbo.PriceList', 'U') IS NOT NULL select * from PriceList";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = qr;
            cmd.ExecuteNonQuery();

            return cmd;
        }

        //***display available reports to MLT***//
        public SqlCommand displayMLTAvailableReports()
        {
            string qr = "IF OBJECT_ID('dbo.Report', 'U') IS NOT NULL select i.Date,r.ReportNumber,p.Name,p.PatientNic,p.Dob," +
                "p.Gender,p.Phone, r.ReportName,r.RequiredDate,r.FinishedDate from Patient p inner join " +
                " Report r on p.PatientNic = r.PatientNic  inner join Invoice i on p.PatientNic = i.PatientNic WHERE r.FinishedDate IS NULL; ";


            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = qr;
            cmd.ExecuteNonQuery();

            return cmd;
        }

        //***display available Chemicals and equipments***//
        public SqlCommand displayAvailableChemicalsAndEquipments()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "IF OBJECT_ID('dbo.ChemicalsAndEquipments', 'U') IS NOT NULL select * from ChemicalsAndEquipments";
            cmd.ExecuteNonQuery();

            return cmd;
        }

        //****display registred Employees****//

        public SqlCommand displayRegistredEmployees()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select EmployeeNic,Name,Dob,Email,Phone,EmployeeType,UserName from Employee";
            cmd.ExecuteNonQuery();

            return cmd;
        }

        //display daily cash reports
        public SqlCommand displayTodayReport(string date)
        {
            string query = "IF OBJECT_ID('dbo.Invoice', 'U') IS NOT NULL SELECT * FROM [dbo].[Invoice] WHERE Date='" + date + "' ";

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            return cmd;
        }

        //display cash in hand
        public string displayCashInHand(string date)
        {
            string cashInHand = "";
            string query = "IF OBJECT_ID('dbo.Invoice', 'U') IS NOT NULL SELECT SUM(Total) FROM [dbo].[Invoice] WHERE Date='" + date + "' ";

            using (SqlCommand showresult = new SqlCommand(query, getConnection()))
            {
                    cashInHand = showresult.ExecuteScalar().ToString();
            }
            Console.WriteLine("\n cash:" + cashInHand);
            return cashInHand;
        }

        //****display patient reports***//
        public SqlCommand displayAllPatientsReports()
        {
            //,Report.ReportDocument
            string q = "SELECT Patient.PatientNic, Patient.Name,Patient.Dob,Patient.Gender,Patient.Address, Patient.Phone,Report.ReportNumber,Report.ReportName,Report.RequiredDate,Report.FinishedDate FROM Patient INNER JOIN Report ON Patient.PatientNic = Report.PatientNic; ";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();

            return cmd;
        }

        //****Upload report PDF to the database****//
        public void uploadReport(string file,string reportNumber,string patientNic,string finishedDate)
        {

            FileStream fsstream = File.OpenRead(file);
            byte[] contents = new byte[fsstream.Length];
            fsstream.Read(contents, 0, (int)fsstream.Length);
            fsstream.Close();
           
            string query= "UPDATE dbo.Report SET ReportDocument=(@f),FinishedDate=(@fd) WHERE ReportNumber='" + reportNumber + "' AND PatientNic='" + patientNic + "'";
 
            using (SqlCommand cmd = new SqlCommand(query, getConnection()))
            {
                cmd.Parameters.AddWithValue("@f", contents);
                cmd.Parameters.AddWithValue("@fd", finishedDate);
                cmd.ExecuteNonQuery();

            }
        }

        //**** Message Genarater  ****//

        //*** add message to database ***//
        public void messageDatebase(Message obj) 
        {
            string query = "IF OBJECT_ID('dbo.Message', 'U') IS NULL ";
            query += "BEGIN ";
            query += "CREATE TABLE [dbo].[Message](";
            query += "[MessageId] VARCHAR(100) NOT NULL CONSTRAINT pkmessageid PRIMARY KEY,";
            query += "[Message] VARCHAR(100) NOT NULL,";
            query += "[MessageType] VARCHAR(100) NOT NULL,";
            query += ")";
            query += " END";

            getConnection();
            SqlCommand cmd = new SqlCommand(query, getConnection());
            cmd.ExecuteNonQuery();

            String query1 = "INSERT INTO dbo.Message(MessageId,Message,MessageType) " +
            "VALUES ('" + obj.MessageId + "','" + obj.MessageText + "','" + obj.MessageType + "')";

            SqlCommand cmd1 = new SqlCommand(query1, getConnection());
            cmd1.ExecuteNonQuery();
            getConnection().Close();
        }

        //*** get message count  ***//
        public int getMessageCount()
        {
            int count = 0;
            string query = "SELECT COUNT(*) FROM dbo.Message";
            SqlCommand cmd = new SqlCommand(query, getConnection());

            cmd.CommandText = query;
            count = (Int32)cmd.ExecuteScalar();

            return count;
        }

        public void showNotificationTimeToTime()
        {


            Notification notification = new Notification();
            string message, messageType;
            string oString = "IF OBJECT_ID('dbo.Message', 'U') IS NOT NULL SELECT * FROM [dbo].[Message]";
            SqlCommand oCmd = new SqlCommand(oString, getConnection());
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    //DateTime start = DateTime.Now;
                    //DateTime finish = start.AddSeconds(5); // or whatever the delay is to be
                    //do { } while (DateTime.Now < finish);
                    message = oReader["Message"].ToString();
                    messageType = oReader["MessageType"].ToString();
                    notification.showNotification(message, messageType);
                    //notification.showNotification(message, messageType);

                }

                getConnection().Close();
            }
            
        }

        //display cash in hand
        public string displayReportBetweentwoDates(string date1, string date2)
        {
            string cashInHand = "";
            string query = "IF OBJECT_ID('dbo.Invoice', 'U') IS NOT NULL SELECT SUM(Total) FROM [dbo].[Invoice] WHERE Date BETWEEN '" + date1 + "' AND '" + date2 + "' ";

            using (SqlCommand showresult = new SqlCommand(query, getConnection()))
            {
                cashInHand = showresult.ExecuteScalar().ToString();
            }
            Console.WriteLine("\n cash:" + cashInHand);
            return cashInHand;
        }


        public SqlCommand displayReportBetweentwodays(string date1, string date2)
        {
            string query = "IF OBJECT_ID('dbo.Invoice', 'U') IS NOT NULL SELECT * FROM [dbo].[Invoice] WHERE Date BETWEEN '" + date1 + "' AND '" + date2 + "' ";

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            return cmd;
        }

        //display notification
        public SqlCommand displayNotifi()
        {
            string query = "IF OBJECT_ID('dbo.Invoice', 'U') IS NOT NULL SELECT * FROM [dbo].[Message] ";

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            return cmd;
        }

        public void deleteNotify(string mId)
        {
            string query = "IF OBJECT_ID('dbo.Message', 'U') IS NOT NULL Delete FROM [dbo].[Message] where MessageId='" + mId + "'";

            SqlCommand cmd1 = new SqlCommand(query, getConnection());
            cmd1.ExecuteNonQuery();
            getConnection().Close();
        }


        public bool adminLogin(string id)
        {
            string query = "SELECT EmployeeType FROM [dbo].[Employee] WHERE EmployeeNic='" + id+ "'";

            //string query = "SELECT EmployeeType FROM dbo.Employee WHERE EmployeeId='" + id + "' ";
            string type = "";



            SqlDataAdapter sda = new SqlDataAdapter(query, getConnection());

            DataTable dt = new DataTable();
            sda.Fill(dt);

            type = dt.Rows[0][0].ToString();

            if (type == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
