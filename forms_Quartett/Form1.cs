﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ExcelDataReader;

namespace forms_Quartett
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] name = new string[32];

        int[] ps = new int[32];
        int[] kmh = new int[32];
        int[] speed = new int[32];
        int[] Value = new int[32];
        int[] weight = new int[32];
        int[] Baujahr = new int[32];

        private void setps()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void ExcelFileReader(string filePath)
        {
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader;

            //1. Reading Excel file
            if (Path.GetExtension(filePath).ToUpper() == ".XLS")
            {
                //1.1 Reading from a binary Excel file ('97-2003 format; *.xls)
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            else
            {
                //1.2 Reading from a OpenXml Excel file (2007 format; *.xlsx)
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }

            //2. DataSet - The result of each spreadsheet will be created in the result.Tables
            DataSet result;
            result = excelReader.AsDataSet();

            for (int i = 0; i < ps.Length; i++)
            {
                name[i] = Convert.ToString(result.Tables[0].Rows[i][0]);
                ps[i] = Convert.ToInt32(result.Tables[0].Rows[i][1]);
                kmh[i] = Convert.ToInt32(result.Tables[0].Rows[i][2]);
                speed[i] = Convert.ToInt32(result.Tables[0].Rows[i][3]);
                Value[i] = Convert.ToInt32(result.Tables[0].Rows[i][4]);
                weight[i] = Convert.ToInt32(result.Tables[0].Rows[i][5]);
                Baujahr[i] = Convert.ToInt32(result.Tables[0].Rows[i][6]);
            }


        }

    }
}

