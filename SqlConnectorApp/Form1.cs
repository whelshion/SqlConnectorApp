using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class MainForm : Form
    {
        private static string connStr = ConfigurationManager.AppSettings["mssqlconnstring"];
        private static string queryStr = ConfigurationManager.AppSettings["querystring"];
        private static string lineDelimiter = ConfigurationManager.AppSettings["linedelimiter"];
        private string LineDelimiter
        {
            get
            {
                string tStr = string.IsNullOrWhiteSpace(lineDelimiter) ? "-" : lineDelimiter;
                StringBuilder sb = new StringBuilder();
                var pxWidth = this.msgBox.Width;
                var loopTimes = pxWidth / 7 / (lineDelimiter?.Length ?? 1);
                for (int i = 0; i < loopTimes; i++)
                {
                    sb.Append(lineDelimiter);
                }
                return sb.ToString();
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.msgBox.Text = string.Empty;
            AppendMessage(DateTime.Now.ToLocalTime().ToString());
            AppendMessage("  准备就绪...");
            AppendMessageLine();
        }

        private void mySqlBtn_Click(object sender, EventArgs e)
        {
            connStr = ConfigurationManager.AppSettings["mysqlconnstring"];

            AppendMessageLine(DateTime.Now.ToLocalTime().ToString());
            AppendMessageLine("执行MySQL语句：" + queryStr);
            AppendMessageLine(ExecuteMySqlQuery());
            AppendMessageLine();
            AppendMessageLine(LineDelimiter);
        }


        private void msSqlBtn_Click(object sender, EventArgs e)
        {
            connStr = ConfigurationManager.AppSettings["mssqlconnstring"];

            AppendMessageLine();
            AppendMessageLine(DateTime.Now.ToLocalTime().ToString());
            AppendMessageLine("执行MSSQL语句：" + queryStr);
            AppendMessageLine(ExecuteMsSqlQuery());
            AppendMessageLine();
            AppendMessageLine(LineDelimiter);

        }

        private void oracleBtn_Click(object sender, EventArgs e)
        {
            connStr = ConfigurationManager.AppSettings["orclconnstring"];

            AppendMessageLine();
            AppendMessageLine(DateTime.Now.ToLocalTime().ToString());
            AppendMessageLine("执行Oracle语句：" + queryStr);
            AppendMessageLine(ExecuteOracleQuery());
            AppendMessageLine();
            AppendMessageLine(LineDelimiter);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.msgBox.Text = string.Empty;
            AppendMessage(DateTime.Now.ToLocalTime().ToString());
            AppendMessage("  准备就绪...");
            AppendMessageLine();
        }

        private void AppendMessage(string message = "")
        {
            this.msgBox.AppendText(message);
            this.msgBox.ScrollToCaret();
        }
        private void AppendMessageLine(string message = "")
        {
            this.msgBox.AppendText(Environment.NewLine + message);
            this.msgBox.ScrollToCaret();
        }


        private string ExecuteMsSqlQuery()
        {
            string message = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(queryStr, conn))
                    {
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        if (ds.Tables.Count > 0)
                        {
                            message += DataTable2Sting(ds.Tables[0]);
                        }
                        else
                        {
                            message = "执行无结果";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message + Environment.NewLine + ex.StackTrace;
            }
            return message;
        }

        private string ExecuteMySqlQuery()
        {
            string message = string.Empty;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(queryStr, conn))
                    {
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        if (ds.Tables.Count > 0)
                        {
                            message += DataTable2Sting(ds.Tables[0]);
                        }
                        else
                        {
                            message = "执行无结果";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message + Environment.NewLine + ex.StackTrace;
            }
            return message;
        }

        private string ExecuteOracleQuery()
        {
            string message = string.Empty;
            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    using (OracleDataAdapter sda = new OracleDataAdapter(queryStr, conn))
                    {
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        if (ds.Tables.Count > 0)
                        {
                            message += DataTable2Sting(ds.Tables[0]);
                        }
                        else
                        {
                            message = "执行无结果";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message + Environment.NewLine + ex.StackTrace;
            }
            return message;
        }


        private string DataTable2Sting(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.Append("|");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    sb.Append(dt.Columns[j].ColumnName).Append(":").Append(dt.Rows[i][j].ToString()).Append("|");
                }
                if (i == dt.Rows.Count - 1)
                    continue;
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }





        /// <summary>         
        /// DataSetToList         
        /// </summary>          
        /// <typeparam name="T">转换类型</typeparam>         
        /// <param name="dataSet">数据源</param>         
        /// <param name="tableIndex">需要转换表的索引</param>        
        /// /// <returns>泛型集合</returns>
        public IList<T> DataSetToList<T>(DataSet dataset, int tableIndex = 0)
        {
            //确认参数有效
            if (dataset == null || dataset.Tables.Count <= 0 || tableIndex < 0)
            {
                return null;
            }
            DataTable dt = dataset.Tables[tableIndex];
            IList<T> list = new List<T>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (typeof(T) == typeof(int) || typeof(T) == typeof(string))
                {
                    list.Add((T)dt.Rows[0][0]);
                }
                else
                {
                    //创建泛型对象
                    T _t = Activator.CreateInstance<T>();
                    //获取对象所有属性
                    PropertyInfo[] propertyInfo = _t.GetType().GetProperties();
                    //属性和名称相同时则赋值
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        foreach (PropertyInfo info in propertyInfo)
                        {
                            if (dt.Columns[j].ColumnName.ToUpper().Equals(info.Name.ToUpper()))
                            {
                                if (dt.Rows[i][j] != DBNull.Value)
                                {
                                    info.SetValue(_t, dt.Rows[i][j], null);
                                }
                                else
                                {
                                    info.SetValue(_t, null, null);
                                }
                                break;
                            }
                        }
                    }
                    list.Add(_t);
                }
            }
            return list;
        }

    }
}
